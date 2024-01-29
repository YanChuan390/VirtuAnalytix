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
		[SerializeField]
		public Animator animator;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		public PlayableDirector director;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x21711DC", Offset = "0x21711DC", VA = "0x21711DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x21711E4", Offset = "0x21711E4", VA = "0x21711E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x21711F0", Offset = "0x21711F0", VA = "0x21711F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x21711F8", Offset = "0x21711F8", VA = "0x21711F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2171200", Offset = "0x2171200", VA = "0x2171200")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2171208", Offset = "0x2171208", VA = "0x2171208")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x21710CC", Offset = "0x21710CC", VA = "0x21710CC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2171110", Offset = "0x2171110", VA = "0x2171110")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2171154", Offset = "0x2171154", VA = "0x2171154")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2171198", Offset = "0x2171198", VA = "0x2171198")]
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
		[Address(RVA = "0x2171210", Offset = "0x2171210", VA = "0x2171210")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2171214", Offset = "0x2171214", VA = "0x2171214")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2171218", Offset = "0x2171218", VA = "0x2171218")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x217121C", Offset = "0x217121C", VA = "0x217121C")]
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
		[Address(RVA = "0x2171314", Offset = "0x2171314", VA = "0x2171314")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2171730", Offset = "0x2171730", VA = "0x2171730", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2171738", Offset = "0x2171738", VA = "0x2171738", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2171924", Offset = "0x2171924", VA = "0x2171924", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2171B88", Offset = "0x2171B88", VA = "0x2171B88", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2171EA0", Offset = "0x2171EA0", VA = "0x2171EA0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x217152C", Offset = "0x217152C", VA = "0x217152C")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x21715E4", Offset = "0x21715E4", VA = "0x21715E4")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2172100", Offset = "0x2172100", VA = "0x2172100")]
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
		[Address(RVA = "0x217215C", Offset = "0x217215C", VA = "0x217215C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x21721C0", Offset = "0x21721C0", VA = "0x21721C0")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2172410", Offset = "0x2172410", VA = "0x2172410")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x21723F0", Offset = "0x21723F0", VA = "0x21723F0")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2172A68", Offset = "0x2172A68", VA = "0x2172A68")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2172A70", Offset = "0x2172A70", VA = "0x2172A70")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2172AA8", Offset = "0x2172AA8", VA = "0x2172AA8")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2172E6C", Offset = "0x2172E6C", VA = "0x2172E6C")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x217304C", Offset = "0x217304C", VA = "0x217304C")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2173050", Offset = "0x2173050", VA = "0x2173050")]
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
		[Address(RVA = "0x21731E4", Offset = "0x21731E4", VA = "0x21731E4")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x21734A0", Offset = "0x21734A0", VA = "0x21734A0")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x217335C", Offset = "0x217335C", VA = "0x217335C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2173628", Offset = "0x2173628", VA = "0x2173628")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x217385C", Offset = "0x217385C", VA = "0x217385C")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x217394C", Offset = "0x217394C", VA = "0x217394C")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2173A30", Offset = "0x2173A30", VA = "0x2173A30")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x21739B4", Offset = "0x21739B4", VA = "0x21739B4")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2173A98", Offset = "0x2173A98", VA = "0x2173A98")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2173B40", Offset = "0x2173B40", VA = "0x2173B40")]
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
		[Address(RVA = "0x2173E2C", Offset = "0x2173E2C", VA = "0x2173E2C")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2173E90", Offset = "0x2173E90", VA = "0x2173E90")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2174924", Offset = "0x2174924", VA = "0x2174924")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x21749CC", Offset = "0x21749CC", VA = "0x21749CC")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x21748C4", Offset = "0x21748C4", VA = "0x21748C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2174AC0", Offset = "0x2174AC0", VA = "0x2174AC0")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2174AFC", Offset = "0x2174AFC", VA = "0x2174AFC")]
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
		[Address(RVA = "0x217169C", Offset = "0x217169C", VA = "0x217169C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2171910", Offset = "0x2171910", VA = "0x2171910")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2171BEC", Offset = "0x2171BEC", VA = "0x2171BEC")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2174B04", Offset = "0x2174B04", VA = "0x2174B04")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2171808", Offset = "0x2171808", VA = "0x2171808")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2174D8C", Offset = "0x2174D8C", VA = "0x2174D8C")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2171F0C", Offset = "0x2171F0C", VA = "0x2171F0C")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2171990", Offset = "0x2171990", VA = "0x2171990")]
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
		[Address(RVA = "0x2174DF4", Offset = "0x2174DF4", VA = "0x2174DF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x21752AC", Offset = "0x21752AC", VA = "0x21752AC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x21752C8", Offset = "0x21752C8", VA = "0x21752C8", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x21753A4", Offset = "0x21753A4", VA = "0x21753A4", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2175460", Offset = "0x2175460", VA = "0x2175460", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2175600", Offset = "0x2175600", VA = "0x2175600", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x21758A4", Offset = "0x21758A4", VA = "0x21758A4")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x217597C", Offset = "0x217597C", VA = "0x217597C")]
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
		[Range(0f, 1f)]
		public float blockedOffset;

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
			[Address(RVA = "0x2175A20", Offset = "0x2175A20", VA = "0x2175A20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2175A28", Offset = "0x2175A28", VA = "0x2175A28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2175A30", Offset = "0x2175A30", VA = "0x2175A30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2175A38", Offset = "0x2175A38", VA = "0x2175A38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2175A40", Offset = "0x2175A40", VA = "0x2175A40")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2175A48", Offset = "0x2175A48", VA = "0x2175A48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2176458", Offset = "0x2176458", VA = "0x2176458")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2175A50", Offset = "0x2175A50", VA = "0x2175A50")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2175A88", Offset = "0x2175A88", VA = "0x2175A88")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2175A90", Offset = "0x2175A90", VA = "0x2175A90", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2175BB8", Offset = "0x2175BB8", VA = "0x2175BB8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2175C00", Offset = "0x2175C00", VA = "0x2175C00", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2175C58", Offset = "0x2175C58", VA = "0x2175C58", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2175CB0", Offset = "0x2175CB0", VA = "0x2175CB0")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2175BE4", Offset = "0x2175BE4", VA = "0x2175BE4")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2175E3C", Offset = "0x2175E3C", VA = "0x2175E3C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x217641C", Offset = "0x217641C", VA = "0x217641C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x21764C4", Offset = "0x21764C4", VA = "0x21764C4")]
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
		[Address(RVA = "0x2176584", Offset = "0x2176584", VA = "0x2176584")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x21765B0", Offset = "0x21765B0", VA = "0x21765B0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x21767D4", Offset = "0x21767D4", VA = "0x21767D4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2176810", Offset = "0x2176810", VA = "0x2176810")]
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
		[Address(RVA = "0x217682C", Offset = "0x217682C", VA = "0x217682C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x217690C", Offset = "0x217690C", VA = "0x217690C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2176944", Offset = "0x2176944", VA = "0x2176944")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2176A8C", Offset = "0x2176A8C", VA = "0x2176A8C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2176A40", Offset = "0x2176A40", VA = "0x2176A40")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2176B88", Offset = "0x2176B88", VA = "0x2176B88")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2176BCC", Offset = "0x2176BCC", VA = "0x2176BCC")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2177058", Offset = "0x2177058", VA = "0x2177058")]
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
			[Address(RVA = "0x2177354", Offset = "0x2177354", VA = "0x2177354")]
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
			[Address(RVA = "0x21770A0", Offset = "0x21770A0", VA = "0x21770A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x21773C8", Offset = "0x21773C8", VA = "0x21773C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2177060", Offset = "0x2177060", VA = "0x2177060")]
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
		[Address(RVA = "0x217767C", Offset = "0x217767C", VA = "0x217767C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2177940", Offset = "0x2177940", VA = "0x2177940")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2177B74", Offset = "0x2177B74", VA = "0x2177B74")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2177BE8", Offset = "0x2177BE8", VA = "0x2177BE8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2177C7C", Offset = "0x2177C7C", VA = "0x2177C7C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2177828", Offset = "0x2177828", VA = "0x2177828")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2177AEC", Offset = "0x2177AEC", VA = "0x2177AEC")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x21783B4", Offset = "0x21783B4", VA = "0x21783B4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x217820C", Offset = "0x217820C", VA = "0x217820C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x21782E0", Offset = "0x21782E0", VA = "0x21782E0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2177E64", Offset = "0x2177E64", VA = "0x2177E64")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2177F00", Offset = "0x2177F00", VA = "0x2177F00")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2177F9C", Offset = "0x2177F9C", VA = "0x2177F9C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2178038", Offset = "0x2178038", VA = "0x2178038")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x21780D4", Offset = "0x21780D4", VA = "0x21780D4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2178170", Offset = "0x2178170", VA = "0x2178170")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x217859C", Offset = "0x217859C", VA = "0x217859C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2177D90", Offset = "0x2177D90", VA = "0x2177D90")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2178518", Offset = "0x2178518", VA = "0x2178518")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x21785FC", Offset = "0x21785FC", VA = "0x21785FC")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x21786BC", Offset = "0x21786BC", VA = "0x21786BC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x21784A4", Offset = "0x21784A4", VA = "0x21784A4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2178434", Offset = "0x2178434", VA = "0x2178434")]
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
				[Address(RVA = "0x217DFD0", Offset = "0x217DFD0", VA = "0x217DFD0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x217DFBC", Offset = "0x217DFBC", VA = "0x217DFBC")]
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
			[Address(RVA = "0x217A6B4", Offset = "0x217A6B4", VA = "0x217A6B4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x217AA10", Offset = "0x217AA10", VA = "0x217AA10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x217AA20", Offset = "0x217AA20", VA = "0x217AA20", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x217ADAC", Offset = "0x217ADAC", VA = "0x217ADAC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x217B13C", Offset = "0x217B13C", VA = "0x217B13C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x217B760", Offset = "0x217B760", VA = "0x217B760")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x217B39C", Offset = "0x217B39C", VA = "0x217B39C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x217BF5C", Offset = "0x217BF5C", VA = "0x217BF5C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x217C03C", Offset = "0x217C03C", VA = "0x217C03C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x217CAB4", Offset = "0x217CAB4", VA = "0x217CAB4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x217C8D4", Offset = "0x217C8D4", VA = "0x217C8D4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x217C674", Offset = "0x217C674", VA = "0x217C674")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x217C0D8", Offset = "0x217C0D8", VA = "0x217C0D8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x217C9C8", Offset = "0x217C9C8", VA = "0x217C9C8")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x217CB94", Offset = "0x217CB94", VA = "0x217CB94")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x217D654", Offset = "0x217D654", VA = "0x217D654")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x217D114", Offset = "0x217D114", VA = "0x217D114")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x217D928", Offset = "0x217D928", VA = "0x217D928")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x217D468", Offset = "0x217D468", VA = "0x217D468")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x217D930", Offset = "0x217D930", VA = "0x217D930")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x217D938", Offset = "0x217D938", VA = "0x217D938")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x217DAEC", Offset = "0x217DAEC", VA = "0x217DAEC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x217DF54", Offset = "0x217DF54", VA = "0x217DF54")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x217B334", Offset = "0x217B334", VA = "0x217B334")]
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
		[Address(RVA = "0x217DFD8", Offset = "0x217DFD8", VA = "0x217DFD8")]
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
		[Address(RVA = "0x217DFE0", Offset = "0x217DFE0", VA = "0x217DFE0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x217E0D8", Offset = "0x217E0D8", VA = "0x217E0D8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x217DED0", Offset = "0x217DED0", VA = "0x217DED0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x217DDC4", Offset = "0x217DDC4", VA = "0x217DDC4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x217C1B4", Offset = "0x217C1B4", VA = "0x217C1B4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x217C7C4", Offset = "0x217C7C4", VA = "0x217C7C4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x217C434", Offset = "0x217C434", VA = "0x217C434")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x217E0E8", Offset = "0x217E0E8", VA = "0x217E0E8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x217C2E4", Offset = "0x217C2E4", VA = "0x217C2E4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x217E1DC", Offset = "0x217E1DC", VA = "0x217E1DC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x217E548", Offset = "0x217E548", VA = "0x217E548")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x217E340", Offset = "0x217E340", VA = "0x217E340")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x217E6D0", Offset = "0x217E6D0", VA = "0x217E6D0")]
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
		[Address(RVA = "0x217E6D8", Offset = "0x217E6D8", VA = "0x217E6D8")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x217E740", Offset = "0x217E740", VA = "0x217E740")]
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
		[Address(RVA = "0x217E7A8", Offset = "0x217E7A8", VA = "0x217E7A8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x217F130", Offset = "0x217F130", VA = "0x217F130")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x217F1A0", Offset = "0x217F1A0", VA = "0x217F1A0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x217EBA8", Offset = "0x217EBA8", VA = "0x217EBA8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x217EBB4", Offset = "0x217EBB4", VA = "0x217EBB4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x217EBD8", Offset = "0x217EBD8", VA = "0x217EBD8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x217EC14", Offset = "0x217EC14", VA = "0x217EC14")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x217EC2C", Offset = "0x217EC2C", VA = "0x217EC2C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x217EC40", Offset = "0x217EC40", VA = "0x217EC40")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x217EC54", Offset = "0x217EC54", VA = "0x217EC54")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x217EC64", Offset = "0x217EC64", VA = "0x217EC64")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x217ECAC", Offset = "0x217ECAC", VA = "0x217ECAC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x217ECE4", Offset = "0x217ECE4", VA = "0x217ECE4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x217ED0C", Offset = "0x217ED0C", VA = "0x217ED0C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x217F210", Offset = "0x217F210", VA = "0x217F210")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x217ED40", Offset = "0x217ED40", VA = "0x217ED40")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x217ED68", Offset = "0x217ED68", VA = "0x217ED68")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x217ED98", Offset = "0x217ED98", VA = "0x217ED98")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x217EDCC", Offset = "0x217EDCC", VA = "0x217EDCC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x217EE10", Offset = "0x217EE10", VA = "0x217EE10")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x217EE74", Offset = "0x217EE74", VA = "0x217EE74")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x217EED8", Offset = "0x217EED8", VA = "0x217EED8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x217EF2C", Offset = "0x217EF2C", VA = "0x217EF2C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x217EF80", Offset = "0x217EF80", VA = "0x217EF80")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x217EFB8", Offset = "0x217EFB8", VA = "0x217EFB8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x217EFEC", Offset = "0x217EFEC", VA = "0x217EFEC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x217F244", Offset = "0x217F244", VA = "0x217F244")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x217F030", Offset = "0x217F030", VA = "0x217F030")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x217F0C0", Offset = "0x217F0C0", VA = "0x217F0C0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x217F0F0", Offset = "0x217F0F0", VA = "0x217F0F0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x217F2D4", Offset = "0x217F2D4", VA = "0x217F2D4")]
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
		[Address(RVA = "0x217F2DC", Offset = "0x217F2DC", VA = "0x217F2DC")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x217F344", Offset = "0x217F344", VA = "0x217F344")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x217F3AC", Offset = "0x217F3AC", VA = "0x217F3AC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x217F3F8", Offset = "0x217F3F8", VA = "0x217F3F8")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x217F4B4", Offset = "0x217F4B4", VA = "0x217F4B4")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x217F40C", Offset = "0x217F40C", VA = "0x217F40C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x217F4C8", Offset = "0x217F4C8", VA = "0x217F4C8")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x217F558", Offset = "0x217F558", VA = "0x217F558")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x217F580", Offset = "0x217F580", VA = "0x217F580")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x217F5CC", Offset = "0x217F5CC", VA = "0x217F5CC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x217F634", Offset = "0x217F634", VA = "0x217F634")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x217F788", Offset = "0x217F788", VA = "0x217F788")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x217F8C0", Offset = "0x217F8C0", VA = "0x217F8C0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x217F918", Offset = "0x217F918", VA = "0x217F918")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x217F93C", Offset = "0x217F93C", VA = "0x217F93C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x217F988", Offset = "0x217F988", VA = "0x217F988")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x217F9D4", Offset = "0x217F9D4", VA = "0x217F9D4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x217FAD8", Offset = "0x217FAD8", VA = "0x217FAD8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x217FBDC", Offset = "0x217FBDC", VA = "0x217FBDC")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x217FCF0", Offset = "0x217FCF0", VA = "0x217FCF0")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x217FD98", Offset = "0x217FD98", VA = "0x217FD98")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x217FEA4", Offset = "0x217FEA4", VA = "0x217FEA4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x218000C", Offset = "0x218000C", VA = "0x218000C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x21801F0", Offset = "0x21801F0", VA = "0x21801F0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x21802C0", Offset = "0x21802C0", VA = "0x21802C0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2180444", Offset = "0x2180444", VA = "0x2180444")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2180550", Offset = "0x2180550", VA = "0x2180550")]
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
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
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
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x21806C4", Offset = "0x21806C4", VA = "0x21806C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x218094C", Offset = "0x218094C", VA = "0x218094C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x21805A8", Offset = "0x21805A8", VA = "0x21805A8")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x218063C", Offset = "0x218063C", VA = "0x218063C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2180640", Offset = "0x2180640", VA = "0x2180640", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2180644", Offset = "0x2180644", VA = "0x2180644", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2180648", Offset = "0x2180648", VA = "0x2180648")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x21806C0", Offset = "0x21806C0", VA = "0x21806C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2180670", Offset = "0x2180670", VA = "0x2180670")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2180948", Offset = "0x2180948", VA = "0x2180948")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2180790", Offset = "0x2180790", VA = "0x2180790")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x21809E4", Offset = "0x21809E4", VA = "0x21809E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x21809E8", Offset = "0x21809E8", VA = "0x21809E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x21809EC", Offset = "0x21809EC", VA = "0x21809EC")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2180A24", Offset = "0x2180A24", VA = "0x2180A24")]
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

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2180A34", Offset = "0x2180A34", VA = "0x2180A34")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2180AE8", Offset = "0x2180AE8", VA = "0x2180AE8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2180B9C", Offset = "0x2180B9C", VA = "0x2180B9C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2180C50", Offset = "0x2180C50", VA = "0x2180C50")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V3Tools
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2180C58", Offset = "0x2180C58", VA = "0x2180C58")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2180CB4", Offset = "0x2180CB4", VA = "0x2180CB4")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2180CEC", Offset = "0x2180CEC", VA = "0x2180CEC")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2180E3C", Offset = "0x2180E3C", VA = "0x2180E3C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2180FB8", Offset = "0x2180FB8", VA = "0x2180FB8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x21811E8", Offset = "0x21811E8", VA = "0x21811E8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2181438", Offset = "0x2181438", VA = "0x2181438")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2181690", Offset = "0x2181690", VA = "0x2181690")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x218183C", Offset = "0x218183C", VA = "0x218183C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2181A34", Offset = "0x2181A34", VA = "0x2181A34")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2181AB0", Offset = "0x2181AB0", VA = "0x2181AB0")]
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

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2181B40", Offset = "0x2181B40", VA = "0x2181B40")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x217BEA8", Offset = "0x217BEA8", VA = "0x217BEA8")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000027")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2181CEC", Offset = "0x2181CEC", VA = "0x2181CEC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2181D30", Offset = "0x2181D30", VA = "0x2181D30")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2181D74", Offset = "0x2181D74", VA = "0x2181D74")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2181DB8", Offset = "0x2181DB8", VA = "0x2181DB8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2181DFC", Offset = "0x2181DFC", VA = "0x2181DFC")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2181E94", Offset = "0x2181E94", VA = "0x2181E94")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2181EB0", Offset = "0x2181EB0", VA = "0x2181EB0")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2181EDC", Offset = "0x2181EDC", VA = "0x2181EDC")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2181F08", Offset = "0x2181F08", VA = "0x2181F08")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2181F44", Offset = "0x2181F44", VA = "0x2181F44")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2181F84", Offset = "0x2181F84", VA = "0x2181F84")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2181FA4", Offset = "0x2181FA4", VA = "0x2181FA4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2181FC4", Offset = "0x2181FC4", VA = "0x2181FC4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2181FE8", Offset = "0x2181FE8", VA = "0x2181FE8")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2182010", Offset = "0x2182010", VA = "0x2182010")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2182038", Offset = "0x2182038", VA = "0x2182038")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2181E18", Offset = "0x2181E18", VA = "0x2181E18")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x218205C", Offset = "0x218205C", VA = "0x218205C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2182068", Offset = "0x2182068", VA = "0x2182068")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2182074", Offset = "0x2182074", VA = "0x2182074")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x21822E0", Offset = "0x21822E0", VA = "0x21822E0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x218237C", Offset = "0x218237C", VA = "0x218237C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x218269C", Offset = "0x218269C", VA = "0x218269C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2182B08", Offset = "0x2182B08", VA = "0x2182B08")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2182B2C", Offset = "0x2182B2C", VA = "0x2182B2C")]
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
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x21821B0", Offset = "0x21821B0", VA = "0x21821B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2182D50", Offset = "0x2182D50", VA = "0x2182D50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x218252C", Offset = "0x218252C", VA = "0x218252C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2182BC4", Offset = "0x2182BC4", VA = "0x2182BC4")]
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
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2182F0C", Offset = "0x2182F0C", VA = "0x2182F0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012B")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2182F6C", Offset = "0x2182F6C", VA = "0x2182F6C")]
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

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2182F74", Offset = "0x2182F74", VA = "0x2182F74", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x218300C", Offset = "0x218300C", VA = "0x218300C")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2183014", Offset = "0x2183014", VA = "0x2183014")]
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
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2183140", Offset = "0x2183140", VA = "0x2183140")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x218303C", Offset = "0x218303C", VA = "0x218303C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x218319C", Offset = "0x218319C", VA = "0x218319C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x21831A4", Offset = "0x21831A4", VA = "0x21831A4")]
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

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x21831CC", Offset = "0x21831CC", VA = "0x21831CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2183248", Offset = "0x2183248", VA = "0x2183248")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2183250", Offset = "0x2183250", VA = "0x2183250")]
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
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x218337C", Offset = "0x218337C", VA = "0x218337C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2183278", Offset = "0x2183278", VA = "0x2183278", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x21833D4", Offset = "0x21833D4", VA = "0x21833D4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x21833DC", Offset = "0x21833DC", VA = "0x21833DC")]
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
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2183404", Offset = "0x2183404", VA = "0x2183404")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x218264C", Offset = "0x218264C", VA = "0x218264C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2182810", Offset = "0x2182810", VA = "0x2182810")]
		public void Update()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2182F04", Offset = "0x2182F04", VA = "0x2182F04")]
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
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

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
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x2183464", Offset = "0x2183464", VA = "0x2183464")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x218346C", Offset = "0x218346C", VA = "0x218346C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2183478", Offset = "0x2183478", VA = "0x2183478")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2183498", Offset = "0x2183498", VA = "0x2183498")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x21834B8", Offset = "0x21834B8", VA = "0x21834B8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x21834D8", Offset = "0x21834D8", VA = "0x21834D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x21834F8", Offset = "0x21834F8", VA = "0x21834F8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x21835E4", Offset = "0x21835E4", VA = "0x21835E4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2183AC4", Offset = "0x2183AC4", VA = "0x2183AC4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2183B90", Offset = "0x2183B90", VA = "0x2183B90")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2183C48", Offset = "0x2183C48", VA = "0x2183C48")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x21842A8", Offset = "0x21842A8", VA = "0x21842A8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x21842B8", Offset = "0x21842B8", VA = "0x21842B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x21842C0", Offset = "0x21842C0", VA = "0x21842C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x21842CC", Offset = "0x21842CC", VA = "0x21842CC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2184340", Offset = "0x2184340", VA = "0x2184340")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x218464C", Offset = "0x218464C", VA = "0x218464C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x21847B8", Offset = "0x21847B8", VA = "0x21847B8")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2184564", Offset = "0x2184564", VA = "0x2184564")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2184918", Offset = "0x2184918", VA = "0x2184918", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x21849C0", Offset = "0x21849C0", VA = "0x21849C0")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2184A24", Offset = "0x2184A24", VA = "0x2184A24")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2184A8C", Offset = "0x2184A8C", VA = "0x2184A8C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2184AE8", Offset = "0x2184AE8", VA = "0x2184AE8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2184AEC", Offset = "0x2184AEC", VA = "0x2184AEC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2184B00", Offset = "0x2184B00", VA = "0x2184B00")]
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
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2184B68", Offset = "0x2184B68", VA = "0x2184B68")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2184B70", Offset = "0x2184B70", VA = "0x2184B70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000159")]
		public abstract void ResetPosition();

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2184B7C", Offset = "0x2184B7C", VA = "0x2184B7C")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2184E2C", Offset = "0x2184E2C", VA = "0x2184E2C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2184C40", Offset = "0x2184C40", VA = "0x2184C40")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2184E50", Offset = "0x2184E50", VA = "0x2184E50")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000160")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000161")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2184FC4", Offset = "0x2184FC4", VA = "0x2184FC4")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
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

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2185130", Offset = "0x2185130", VA = "0x2185130", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2185174", Offset = "0x2185174", VA = "0x2185174", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x21851B8", Offset = "0x21851B8", VA = "0x21851B8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2185224", Offset = "0x2185224", VA = "0x2185224")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x21852C4", Offset = "0x21852C4", VA = "0x21852C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2185318", Offset = "0x2185318", VA = "0x2185318")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x218561C", Offset = "0x218561C", VA = "0x218561C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x218565C", Offset = "0x218565C", VA = "0x218565C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2185ABC", Offset = "0x2185ABC", VA = "0x2185ABC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2185B7C", Offset = "0x2185B7C", VA = "0x2185B7C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2185D4C", Offset = "0x2185D4C", VA = "0x2185D4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2185EF4", Offset = "0x2185EF4", VA = "0x2185EF4")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public class SpineEffector
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2749740", Offset = "0x2749740", VA = "0x2749740")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2749750", Offset = "0x2749750", VA = "0x2749750")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
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

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x274864C", Offset = "0x274864C", VA = "0x274864C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2748690", Offset = "0x2748690", VA = "0x2748690", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x27486D4", Offset = "0x27486D4", VA = "0x27486D4", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2748718", Offset = "0x2748718", VA = "0x2748718", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x27487F8", Offset = "0x27487F8", VA = "0x27487F8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2748880", Offset = "0x2748880", VA = "0x2748880")]
		private void Update()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2748AF0", Offset = "0x2748AF0", VA = "0x2748AF0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2748AFC", Offset = "0x2748AFC", VA = "0x2748AFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x27488DC", Offset = "0x27488DC", VA = "0x27488DC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2748D7C", Offset = "0x2748D7C", VA = "0x2748D7C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x27492E4", Offset = "0x27492E4", VA = "0x27492E4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2749468", Offset = "0x2749468", VA = "0x2749468")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x274959C", Offset = "0x274959C", VA = "0x274959C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x27496B0", Offset = "0x27496B0", VA = "0x27496B0")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
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

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2749794", Offset = "0x2749794", VA = "0x2749794", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x27497D8", Offset = "0x27497D8", VA = "0x27497D8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x274981C", Offset = "0x274981C", VA = "0x274981C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2749834", Offset = "0x2749834", VA = "0x2749834")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2749A40", Offset = "0x2749A40", VA = "0x2749A40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2749B20", Offset = "0x2749B20", VA = "0x2749B20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x274A204", Offset = "0x274A204", VA = "0x274A204")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x274A664", Offset = "0x274A664", VA = "0x274A664")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x274A810", Offset = "0x274A810", VA = "0x274A810")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x274AB98", Offset = "0x274AB98", VA = "0x274AB98")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x274AD70", Offset = "0x274AD70", VA = "0x274AD70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x274AF74", Offset = "0x274AF74", VA = "0x274AF74")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
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

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x274BAC0", Offset = "0x274BAC0", VA = "0x274BAC0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
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

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x274B004", Offset = "0x274B004", VA = "0x274B004", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x274B048", Offset = "0x274B048", VA = "0x274B048", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x274B08C", Offset = "0x274B08C", VA = "0x274B08C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x274B0B4", Offset = "0x274B0B4", VA = "0x274B0B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x274B1B8", Offset = "0x274B1B8", VA = "0x274B1B8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x274B39C", Offset = "0x274B39C", VA = "0x274B39C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x274B400", Offset = "0x274B400", VA = "0x274B400")]
		private void Update()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x274B458", Offset = "0x274B458", VA = "0x274B458")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x274B76C", Offset = "0x274B76C", VA = "0x274B76C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x274BAF4", Offset = "0x274BAF4", VA = "0x274BAF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x274BB84", Offset = "0x274BB84", VA = "0x274BB84")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x274BFD4", Offset = "0x274BFD4", VA = "0x274BFD4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x274C694", Offset = "0x274C694", VA = "0x274C694")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x274C94C", Offset = "0x274C94C", VA = "0x274C94C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x274CA80", Offset = "0x274CA80", VA = "0x274CA80")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x274CD48", Offset = "0x274CD48", VA = "0x274CD48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x274CD78", Offset = "0x274CD78", VA = "0x274CD78")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x274CF74", Offset = "0x274CF74", VA = "0x274CF74")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x274D0FC", Offset = "0x274D0FC", VA = "0x274D0FC")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x274D140", Offset = "0x274D140", VA = "0x274D140", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x274D184", Offset = "0x274D184", VA = "0x274D184", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x274D1C8", Offset = "0x274D1C8", VA = "0x274D1C8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x274D1E0", Offset = "0x274D1E0", VA = "0x274D1E0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x274D268", Offset = "0x274D268", VA = "0x274D268")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x274D2BC", Offset = "0x274D2BC", VA = "0x274D2BC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x274D4F4", Offset = "0x274D4F4", VA = "0x274D4F4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x274D6E8", Offset = "0x274D6E8", VA = "0x274D6E8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x274D76C", Offset = "0x274D76C", VA = "0x274D76C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x274DA08", Offset = "0x274DA08", VA = "0x274DA08")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x274DB3C", Offset = "0x274DB3C", VA = "0x274DB3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x274DCD4", Offset = "0x274DCD4", VA = "0x274DCD4")]
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
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

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
				[Token(Token = "0x60001C7")]
				[Address(RVA = "0x274F0EC", Offset = "0x274F0EC", VA = "0x274F0EC")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x274F0F4", Offset = "0x274F0F4", VA = "0x274F0F4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x274F100", Offset = "0x274F100", VA = "0x274F100")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x274F10C", Offset = "0x274F10C", VA = "0x274F10C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x274F118", Offset = "0x274F118", VA = "0x274F118")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x274F120", Offset = "0x274F120", VA = "0x274F120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x274F12C", Offset = "0x274F12C", VA = "0x274F12C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x274F134", Offset = "0x274F134", VA = "0x274F134")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x274F13C", Offset = "0x274F13C", VA = "0x274F13C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x274F148", Offset = "0x274F148", VA = "0x274F148")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x274F154", Offset = "0x274F154", VA = "0x274F154")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x274F15C", Offset = "0x274F15C", VA = "0x274F15C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x274F164", Offset = "0x274F164", VA = "0x274F164")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x274F16C", Offset = "0x274F16C", VA = "0x274F16C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x274F174", Offset = "0x274F174", VA = "0x274F174")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x274F18C", Offset = "0x274F18C", VA = "0x274F18C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x274F1AC", Offset = "0x274F1AC", VA = "0x274F1AC")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x274F1C4", Offset = "0x274F1C4", VA = "0x274F1C4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x274F1E4", Offset = "0x274F1E4", VA = "0x274F1E4")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x274FACC", Offset = "0x274FACC", VA = "0x274FACC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x274FC1C", Offset = "0x274FC1C", VA = "0x274FC1C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x274F22C", Offset = "0x274F22C", VA = "0x274F22C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x274E254", Offset = "0x274E254", VA = "0x274E254")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x274F240", Offset = "0x274F240", VA = "0x274F240")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x274ED5C", Offset = "0x274ED5C", VA = "0x274ED5C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x274E344", Offset = "0x274E344", VA = "0x274E344")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x274F6E0", Offset = "0x274F6E0", VA = "0x274F6E0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x274F280", Offset = "0x274F280", VA = "0x274F280")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x274FB60", Offset = "0x274FB60", VA = "0x274FB60")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x274F548", Offset = "0x274F548", VA = "0x274F548")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x274F5C8", Offset = "0x274F5C8", VA = "0x274F5C8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x274FBCC", Offset = "0x274FBCC", VA = "0x274FBCC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x274FB00", Offset = "0x274FB00", VA = "0x274FB00")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x274FCA8", Offset = "0x274FCA8", VA = "0x274FCA8")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x274E1B4", Offset = "0x274E1B4", VA = "0x274E1B4")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003E")]
		public class Pelvis
		{
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
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x274FE58", Offset = "0x274FE58", VA = "0x274FE58")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x274FE64", Offset = "0x274FE64", VA = "0x274FE64")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x274FE70", Offset = "0x274FE70", VA = "0x274FE70")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x274FE78", Offset = "0x274FE78", VA = "0x274FE78")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x274E31C", Offset = "0x274E31C", VA = "0x274E31C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x274ECC8", Offset = "0x274ECC8", VA = "0x274ECC8")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x274FE80", Offset = "0x274FE80", VA = "0x274FE80")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x274EADC", Offset = "0x274EADC", VA = "0x274EADC")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x274E24C", Offset = "0x274E24C", VA = "0x274E24C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x274DD2C", Offset = "0x274DD2C", VA = "0x274DD2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x274DD34", Offset = "0x274DD34", VA = "0x274DD34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x274DD3C", Offset = "0x274DD3C", VA = "0x274DD3C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x274DD44", Offset = "0x274DD44", VA = "0x274DD44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x274DD4C", Offset = "0x274DD4C", VA = "0x274DD4C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x274DD54", Offset = "0x274DD54", VA = "0x274DD54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x274DD60", Offset = "0x274DD60", VA = "0x274DD60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x274DD68", Offset = "0x274DD68", VA = "0x274DD68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x274DD70", Offset = "0x274DD70", VA = "0x274DD70")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x274DD88", Offset = "0x274DD88", VA = "0x274DD88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x274DDA8", Offset = "0x274DDA8", VA = "0x274DDA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x274E050", Offset = "0x274E050", VA = "0x274E050")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x274EDF0", Offset = "0x274EDF0", VA = "0x274EDF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x274DDF0", Offset = "0x274DDF0", VA = "0x274DDF0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x274E0B8", Offset = "0x274E0B8", VA = "0x274E0B8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2748B08", Offset = "0x2748B08", VA = "0x2748B08")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x27490F0", Offset = "0x27490F0", VA = "0x27490F0")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x274A08C", Offset = "0x274A08C", VA = "0x274A08C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2748780", Offset = "0x2748780", VA = "0x2748780")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x274E32C", Offset = "0x274E32C", VA = "0x274E32C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x274EEA4", Offset = "0x274EEA4", VA = "0x274EEA4")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x274EF28", Offset = "0x274EF28", VA = "0x274EF28")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x274F07C", Offset = "0x274F07C", VA = "0x274F07C")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x274D0A8", Offset = "0x274D0A8", VA = "0x274D0A8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x274FED4", Offset = "0x274FED4", VA = "0x274FED4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x274FF18", Offset = "0x274FF18", VA = "0x274FF18", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x274FF5C", Offset = "0x274FF5C", VA = "0x274FF5C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x274FFA0", Offset = "0x274FFA0", VA = "0x274FFA0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x274FFE4", Offset = "0x274FFE4", VA = "0x274FFE4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2750028", Offset = "0x2750028", VA = "0x2750028", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2750030", Offset = "0x2750030", VA = "0x2750030")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x27500A0", Offset = "0x27500A0", VA = "0x27500A0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x27500E4", Offset = "0x27500E4", VA = "0x27500E4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2750128", Offset = "0x2750128", VA = "0x2750128")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x275016C", Offset = "0x275016C", VA = "0x275016C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x27501B0", Offset = "0x27501B0", VA = "0x27501B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x27501B8", Offset = "0x27501B8", VA = "0x27501B8")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2750220", Offset = "0x2750220", VA = "0x2750220", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2750264", Offset = "0x2750264", VA = "0x2750264", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x27502A8", Offset = "0x27502A8", VA = "0x27502A8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x27502EC", Offset = "0x27502EC", VA = "0x27502EC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2750330", Offset = "0x2750330", VA = "0x2750330", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2750338", Offset = "0x2750338", VA = "0x2750338")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x27503A0", Offset = "0x27503A0", VA = "0x27503A0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x27503E4", Offset = "0x27503E4", VA = "0x27503E4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2750428", Offset = "0x2750428", VA = "0x2750428")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x275046C", Offset = "0x275046C", VA = "0x275046C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x27504B0", Offset = "0x27504B0", VA = "0x27504B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x27504B8", Offset = "0x27504B8", VA = "0x27504B8")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2750520", Offset = "0x2750520", VA = "0x2750520", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2750564", Offset = "0x2750564", VA = "0x2750564", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x27505A8", Offset = "0x27505A8", VA = "0x27505A8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x27505EC", Offset = "0x27505EC", VA = "0x27505EC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2750630", Offset = "0x2750630", VA = "0x2750630", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2750638", Offset = "0x2750638", VA = "0x2750638")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x27506A0", Offset = "0x27506A0", VA = "0x27506A0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x27506E4", Offset = "0x27506E4", VA = "0x27506E4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2750728", Offset = "0x2750728", VA = "0x2750728")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x275076C", Offset = "0x275076C", VA = "0x275076C")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x27507B0", Offset = "0x27507B0", VA = "0x27507B0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x27507F4", Offset = "0x27507F4", VA = "0x27507F4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2750838", Offset = "0x2750838", VA = "0x2750838")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x275085C", Offset = "0x275085C", VA = "0x275085C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2750864", Offset = "0x2750864", VA = "0x2750864")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2750A20", Offset = "0x2750A20", VA = "0x2750A20")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2750ED0", Offset = "0x2750ED0", VA = "0x2750ED0")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2750EF0", Offset = "0x2750EF0", VA = "0x2750EF0")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2750FC8", Offset = "0x2750FC8", VA = "0x2750FC8")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x600021F")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2751060", Offset = "0x2751060", VA = "0x2751060", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x27510D8", Offset = "0x27510D8", VA = "0x27510D8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2751148", Offset = "0x2751148", VA = "0x2751148", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000223")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000224")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2750098", Offset = "0x2750098", VA = "0x2750098")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2751198", Offset = "0x2751198", VA = "0x2751198")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2751224", Offset = "0x2751224", VA = "0x2751224")]
		private void Start()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2751288", Offset = "0x2751288", VA = "0x2751288")]
		private void Update()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2751328", Offset = "0x2751328", VA = "0x2751328")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2751354", Offset = "0x2751354", VA = "0x2751354")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x27512AC", Offset = "0x27512AC", VA = "0x27512AC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x27513D8", Offset = "0x27513D8", VA = "0x27513D8")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x27513E0", Offset = "0x27513E0", VA = "0x27513E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2751424", Offset = "0x2751424", VA = "0x2751424", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2751468", Offset = "0x2751468", VA = "0x2751468")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x27514AC", Offset = "0x27514AC", VA = "0x27514AC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x27514F0", Offset = "0x27514F0", VA = "0x27514F0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x27514F8", Offset = "0x27514F8", VA = "0x27514F8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2751560", Offset = "0x2751560", VA = "0x2751560", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x27515A4", Offset = "0x27515A4", VA = "0x27515A4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x27515E8", Offset = "0x27515E8", VA = "0x27515E8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x275162C", Offset = "0x275162C", VA = "0x275162C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2751670", Offset = "0x2751670", VA = "0x2751670", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2751678", Offset = "0x2751678", VA = "0x2751678")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x27516E0", Offset = "0x27516E0", VA = "0x27516E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2751724", Offset = "0x2751724", VA = "0x2751724", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2751768", Offset = "0x2751768", VA = "0x2751768")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x27517AC", Offset = "0x27517AC", VA = "0x27517AC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x27517F0", Offset = "0x27517F0", VA = "0x27517F0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x27517F8", Offset = "0x27517F8", VA = "0x27517F8")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2751860", Offset = "0x2751860", VA = "0x2751860", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x27518A4", Offset = "0x27518A4", VA = "0x27518A4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x27518E8", Offset = "0x27518E8", VA = "0x27518E8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x275192C", Offset = "0x275192C", VA = "0x275192C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2751970", Offset = "0x2751970", VA = "0x2751970", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2751978", Offset = "0x2751978", VA = "0x2751978")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
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
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
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
			[Tooltip("Optional")]
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
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x600024F")]
				[Address(RVA = "0x27522AC", Offset = "0x27522AC", VA = "0x27522AC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x2751EF0", Offset = "0x2751EF0", VA = "0x2751EF0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2752898", Offset = "0x2752898", VA = "0x2752898")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x2751AC8", Offset = "0x2751AC8", VA = "0x2751AC8")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2752890", Offset = "0x2752890", VA = "0x2752890")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x27519E0", Offset = "0x27519E0", VA = "0x27519E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2751A24", Offset = "0x2751A24", VA = "0x2751A24", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2751A68", Offset = "0x2751A68", VA = "0x2751A68")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2751AAC", Offset = "0x2751AAC", VA = "0x2751AAC")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2751E54", Offset = "0x2751E54", VA = "0x2751E54")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2751E7C", Offset = "0x2751E7C", VA = "0x2751E7C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2751E84", Offset = "0x2751E84", VA = "0x2751E84", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2752668", Offset = "0x2752668", VA = "0x2752668", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x27527F8", Offset = "0x27527F8", VA = "0x27527F8")]
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
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2752CD4", Offset = "0x2752CD4", VA = "0x2752CD4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2752D98", Offset = "0x2752D98", VA = "0x2752D98")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2752DB8", Offset = "0x2752DB8", VA = "0x2752DB8")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x275300C", Offset = "0x275300C", VA = "0x275300C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2752E78", Offset = "0x2752E78", VA = "0x2752E78")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x27530F0", Offset = "0x27530F0", VA = "0x27530F0")]
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

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2753150", Offset = "0x2753150", VA = "0x2753150")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x27535EC", Offset = "0x27535EC", VA = "0x27535EC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2753780", Offset = "0x2753780", VA = "0x2753780")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x275388C", Offset = "0x275388C", VA = "0x275388C")]
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
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2756990", Offset = "0x2756990", VA = "0x2756990")]
			public BendBone()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x27569F0", Offset = "0x27569F0", VA = "0x27569F0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x27540F4", Offset = "0x27540F4", VA = "0x27540F4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x27544C4", Offset = "0x27544C4", VA = "0x27544C4")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[LargeHeader("CCD")]
		public float CCDWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
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

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2753894", Offset = "0x2753894", VA = "0x2753894")]
		private void Start()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2753C80", Offset = "0x2753C80", VA = "0x2753C80")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2754120", Offset = "0x2754120", VA = "0x2754120")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x27544EC", Offset = "0x27544EC", VA = "0x27544EC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2754DE8", Offset = "0x2754DE8", VA = "0x2754DE8")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x27551E0", Offset = "0x27551E0", VA = "0x27551E0")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x27555F0", Offset = "0x27555F0", VA = "0x27555F0")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2755F70", Offset = "0x2755F70", VA = "0x2755F70")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2754B2C", Offset = "0x2754B2C", VA = "0x2754B2C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x27561AC", Offset = "0x27561AC", VA = "0x27561AC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2755E88", Offset = "0x2755E88", VA = "0x2755E88")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2755D88", Offset = "0x2755D88", VA = "0x2755D88")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x27564B0", Offset = "0x27564B0", VA = "0x27564B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x27567E8", Offset = "0x27567E8", VA = "0x27567E8")]
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
				[Token(Token = "0x6000283")]
				[Address(RVA = "0x27599A4", Offset = "0x27599A4", VA = "0x27599A4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000284")]
				[Address(RVA = "0x27599AC", Offset = "0x27599AC", VA = "0x27599AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x27599B4", Offset = "0x27599B4", VA = "0x27599B4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x27599BC", Offset = "0x27599BC", VA = "0x27599BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x27599C8", Offset = "0x27599C8", VA = "0x27599C8")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x27576B0", Offset = "0x27576B0", VA = "0x27576B0")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2757D5C", Offset = "0x2757D5C", VA = "0x2757D5C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2759768", Offset = "0x2759768", VA = "0x2759768")]
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
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
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

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2756A6C", Offset = "0x2756A6C", VA = "0x2756A6C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2756BD4", Offset = "0x2756BD4", VA = "0x2756BD4")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2756D08", Offset = "0x2756D08", VA = "0x2756D08")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2756E20", Offset = "0x2756E20", VA = "0x2756E20")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2756EDC", Offset = "0x2756EDC", VA = "0x2756EDC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2756FE8", Offset = "0x2756FE8", VA = "0x2756FE8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2757978", Offset = "0x2757978", VA = "0x2757978")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2757154", Offset = "0x2757154", VA = "0x2757154")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2757F40", Offset = "0x2757F40", VA = "0x2757F40")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x27581D4", Offset = "0x27581D4", VA = "0x27581D4")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x27584A4", Offset = "0x27584A4", VA = "0x27584A4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2758E6C", Offset = "0x2758E6C", VA = "0x2758E6C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2759364", Offset = "0x2759364", VA = "0x2759364")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2759564", Offset = "0x2759564", VA = "0x2759564")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2759250", Offset = "0x2759250", VA = "0x2759250")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2758D0C", Offset = "0x2758D0C", VA = "0x2758D0C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x27591EC", Offset = "0x27591EC", VA = "0x27591EC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2759640", Offset = "0x2759640", VA = "0x2759640")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2759118", Offset = "0x2759118", VA = "0x2759118")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2759468", Offset = "0x2759468", VA = "0x2759468")]
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
		[Range(0f, 1f)]
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

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x2759BE0", Offset = "0x2759BE0", VA = "0x2759BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x2759BE8", Offset = "0x2759BE8", VA = "0x2759BE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2759A08", Offset = "0x2759A08", VA = "0x2759A08")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2756B68", Offset = "0x2756B68", VA = "0x2756B68")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2759BF4", Offset = "0x2759BF4", VA = "0x2759BF4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2757704", Offset = "0x2757704", VA = "0x2757704")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2757710", Offset = "0x2757710", VA = "0x2757710")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2759DC8", Offset = "0x2759DC8", VA = "0x2759DC8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x275A11C", Offset = "0x275A11C", VA = "0x275A11C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x27586DC", Offset = "0x27586DC", VA = "0x27586DC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2759C80", Offset = "0x2759C80", VA = "0x2759C80")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2759D24", Offset = "0x2759D24", VA = "0x2759D24")]
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
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
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

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
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
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x2920638", Offset = "0x2920638", VA = "0x2920638")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x2920640", Offset = "0x2920640", VA = "0x2920640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x29205DC", Offset = "0x29205DC", VA = "0x29205DC")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x292064C", Offset = "0x292064C", VA = "0x292064C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x29206D0", Offset = "0x29206D0", VA = "0x29206D0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2920870", Offset = "0x2920870", VA = "0x2920870")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2920A2C", Offset = "0x2920A2C", VA = "0x2920A2C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2920D20", Offset = "0x2920D20", VA = "0x2920D20")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2921020", Offset = "0x2921020", VA = "0x2921020")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2921188", Offset = "0x2921188", VA = "0x2921188")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2921224", Offset = "0x2921224", VA = "0x2921224")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x29218C4", Offset = "0x29218C4", VA = "0x29218C4")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x292191C", Offset = "0x292191C", VA = "0x292191C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2921AE4", Offset = "0x2921AE4", VA = "0x2921AE4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2921D2C", Offset = "0x2921D2C", VA = "0x2921D2C")]
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
				[Token(Token = "0x60002AC")]
				[Address(RVA = "0x2922268", Offset = "0x2922268", VA = "0x2922268")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002AF")]
				[Address(RVA = "0x2922320", Offset = "0x2922320", VA = "0x2922320")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002C3")]
				[Address(RVA = "0x29226DC", Offset = "0x29226DC", VA = "0x29226DC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x2922240", Offset = "0x2922240", VA = "0x2922240")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x2922298", Offset = "0x2922298", VA = "0x2922298")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x29222DC", Offset = "0x29222DC", VA = "0x29222DC")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x2922330", Offset = "0x2922330", VA = "0x2922330")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2922404", Offset = "0x2922404", VA = "0x2922404")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x292240C", Offset = "0x292240C", VA = "0x292240C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x29224D8", Offset = "0x29224D8", VA = "0x29224D8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2922544", Offset = "0x2922544", VA = "0x2922544")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x29225CC", Offset = "0x29225CC", VA = "0x29225CC")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2922844", Offset = "0x2922844", VA = "0x2922844")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x2922870", Offset = "0x2922870", VA = "0x2922870")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x292289C", Offset = "0x292289C", VA = "0x292289C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x29228C4", Offset = "0x29228C4", VA = "0x29228C4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x2922984", Offset = "0x2922984", VA = "0x2922984")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x2922B08", Offset = "0x2922B08", VA = "0x2922B08")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x2922B2C", Offset = "0x2922B2C", VA = "0x2922B2C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x2922C4C", Offset = "0x2922C4C", VA = "0x2922C4C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x2922CB0", Offset = "0x2922CB0", VA = "0x2922CB0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x2922E30", Offset = "0x2922E30", VA = "0x2922E30")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x2922FB0", Offset = "0x2922FB0", VA = "0x2922FB0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x292302C", Offset = "0x292302C", VA = "0x292302C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x29229F8", Offset = "0x29229F8", VA = "0x29229F8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x2923148", Offset = "0x2923148", VA = "0x2923148")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2921FDC", Offset = "0x2921FDC", VA = "0x2921FDC", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2921FE4", Offset = "0x2921FE4", VA = "0x2921FE4", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2921FE8", Offset = "0x2921FE8", VA = "0x2921FE8")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2922124", Offset = "0x2922124", VA = "0x2922124")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2922238", Offset = "0x2922238", VA = "0x2922238")]
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
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2923164", Offset = "0x2923164", VA = "0x2923164", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2923200", Offset = "0x2923200", VA = "0x2923200")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2923284", Offset = "0x2923284", VA = "0x2923284")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x292331C", Offset = "0x292331C", VA = "0x292331C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2923334", Offset = "0x2923334", VA = "0x2923334")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2923350", Offset = "0x2923350", VA = "0x2923350", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x29233DC", Offset = "0x29233DC", VA = "0x29233DC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x29233F4", Offset = "0x29233F4", VA = "0x29233F4")]
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
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
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

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2923418", Offset = "0x2923418", VA = "0x2923418", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x292348C", Offset = "0x292348C", VA = "0x292348C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2923554", Offset = "0x2923554", VA = "0x2923554")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x292380C", Offset = "0x292380C", VA = "0x292380C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2923928", Offset = "0x2923928", VA = "0x2923928")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2923A70", Offset = "0x2923A70", VA = "0x2923A70")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2923A7C", Offset = "0x2923A7C", VA = "0x2923A7C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2923B14", Offset = "0x2923B14", VA = "0x2923B14")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2923BBC", Offset = "0x2923BBC", VA = "0x2923BBC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2923E18", Offset = "0x2923E18", VA = "0x2923E18")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2923E78", Offset = "0x2923E78", VA = "0x2923E78")]
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
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
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

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2923FBC", Offset = "0x2923FBC", VA = "0x2923FBC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x29242DC", Offset = "0x29242DC", VA = "0x29242DC")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2924418", Offset = "0x2924418", VA = "0x2924418")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2924588", Offset = "0x2924588", VA = "0x2924588")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2924598", Offset = "0x2924598", VA = "0x2924598")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x29245F4", Offset = "0x29245F4", VA = "0x29245F4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x292466C", Offset = "0x292466C", VA = "0x292466C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2924C80", Offset = "0x2924C80", VA = "0x2924C80")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2924CB8", Offset = "0x2924CB8", VA = "0x2924CB8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2924F1C", Offset = "0x2924F1C", VA = "0x2924F1C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x292523C", Offset = "0x292523C", VA = "0x292523C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x292531C", Offset = "0x292531C", VA = "0x292531C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x29253D0", Offset = "0x29253D0", VA = "0x29253D0")]
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
			[Range(0f, 1f)]
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

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x2925C98", Offset = "0x2925C98", VA = "0x2925C98")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x2925CDC", Offset = "0x2925CDC", VA = "0x2925CDC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x2925DBC", Offset = "0x2925DBC", VA = "0x2925DBC")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x2925DE8", Offset = "0x2925DE8", VA = "0x2925DE8")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x2925E14", Offset = "0x2925E14", VA = "0x2925E14")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x2925E58", Offset = "0x2925E58", VA = "0x2925E58")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x2925E9C", Offset = "0x2925E9C", VA = "0x2925E9C")]
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
				[Token(Token = "0x6000302")]
				[Address(RVA = "0x2925EFC", Offset = "0x2925EFC", VA = "0x2925EFC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x2925FDC", Offset = "0x2925FDC", VA = "0x2925FDC")]
				set
				{
				}
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x2926054", Offset = "0x2926054", VA = "0x2926054")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x29262C0", Offset = "0x29262C0", VA = "0x29262C0")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x292657C", Offset = "0x292657C", VA = "0x292657C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x2926770", Offset = "0x2926770", VA = "0x2926770")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2926798", Offset = "0x2926798", VA = "0x2926798")]
			public Bone()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2926804", Offset = "0x2926804", VA = "0x2926804")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x292687C", Offset = "0x292687C", VA = "0x292687C")]
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

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2926904", Offset = "0x2926904", VA = "0x2926904")]
			public Node()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2926908", Offset = "0x2926908", VA = "0x2926908")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x292692C", Offset = "0x292692C", VA = "0x292692C")]
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
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight;

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
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x29258A4", Offset = "0x29258A4", VA = "0x29258A4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x29258AC", Offset = "0x29258AC", VA = "0x29258AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x292560C", Offset = "0x292560C", VA = "0x292560C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2925680", Offset = "0x2925680", VA = "0x2925680")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x29257F0", Offset = "0x29257F0", VA = "0x29257F0")]
		public void Update()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2925860", Offset = "0x2925860", VA = "0x2925860", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x292586C", Offset = "0x292586C", VA = "0x292586C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2925878", Offset = "0x2925878", VA = "0x2925878")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2925880", Offset = "0x2925880", VA = "0x2925880")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x292589C", Offset = "0x292589C", VA = "0x292589C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002F1")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002F2")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002F3")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002F4")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002F5")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x29258B8", Offset = "0x29258B8", VA = "0x29258B8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x29258D0", Offset = "0x29258D0", VA = "0x29258D0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x29259F4", Offset = "0x29259F4", VA = "0x29259F4")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2925A8C", Offset = "0x2925A8C", VA = "0x2925A8C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2925C80", Offset = "0x2925C80", VA = "0x2925C80")]
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
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
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
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2926CFC", Offset = "0x2926CFC", VA = "0x2926CFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2926D2C", Offset = "0x2926D2C", VA = "0x2926D2C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x2927960", Offset = "0x2927960", VA = "0x2927960", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x2927EA0", Offset = "0x2927EA0", VA = "0x2927EA0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x2926BC4", Offset = "0x2926BC4", VA = "0x2926BC4")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2926D5C", Offset = "0x2926D5C", VA = "0x2926D5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2926FE8", Offset = "0x2926FE8", VA = "0x2926FE8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x29278B8", Offset = "0x29278B8", VA = "0x29278B8")]
		private void Solve()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2927554", Offset = "0x2927554", VA = "0x2927554")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2927968", Offset = "0x2927968", VA = "0x2927968")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2927F00", Offset = "0x2927F00", VA = "0x2927F00")]
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
		[Range(0f, 1f)]
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

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2928014", Offset = "0x2928014", VA = "0x2928014", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2928370", Offset = "0x2928370", VA = "0x2928370")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x29283D0", Offset = "0x29283D0", VA = "0x29283D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2928514", Offset = "0x2928514", VA = "0x2928514", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2928674", Offset = "0x2928674", VA = "0x2928674", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x29286B4", Offset = "0x29286B4", VA = "0x29286B4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2928704", Offset = "0x2928704", VA = "0x2928704", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2928A64", Offset = "0x2928A64", VA = "0x2928A64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2928A84", Offset = "0x2928A84", VA = "0x2928A84")]
		private void Solve()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x292875C", Offset = "0x292875C", VA = "0x292875C")]
		private void Read()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2928AE4", Offset = "0x2928AE4", VA = "0x2928AE4")]
		private void Write()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2928C5C", Offset = "0x2928C5C", VA = "0x2928C5C")]
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

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2928DF0", Offset = "0x2928DF0", VA = "0x2928DF0")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2928E60", Offset = "0x2928E60", VA = "0x2928E60", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2929354", Offset = "0x2929354", VA = "0x2929354", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2929A28", Offset = "0x2929A28", VA = "0x2929A28")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x292A0B8", Offset = "0x292A0B8", VA = "0x292A0B8")]
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
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x292B084", Offset = "0x292B084", VA = "0x292B084", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x292A0BC", Offset = "0x292A0BC", VA = "0x292A0BC")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x292A69C", Offset = "0x292A69C", VA = "0x292A69C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x292A7CC", Offset = "0x292A7CC", VA = "0x292A7CC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x292A854", Offset = "0x292A854", VA = "0x292A854", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x292AD4C", Offset = "0x292AD4C", VA = "0x292AD4C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x292B08C", Offset = "0x292B08C", VA = "0x292B08C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x292A194", Offset = "0x292A194", VA = "0x292A194")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x292A784", Offset = "0x292A784", VA = "0x292A784")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x292B03C", Offset = "0x292B03C", VA = "0x292B03C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x292A530", Offset = "0x292A530", VA = "0x292A530")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x292B738", Offset = "0x292B738", VA = "0x292B738")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x292B7A0", Offset = "0x292B7A0", VA = "0x292B7A0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x292B870", Offset = "0x292B870", VA = "0x292B870")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x292B938", Offset = "0x292B938", VA = "0x292B938")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x292AAC4", Offset = "0x292AAC4", VA = "0x292AAC4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x292AC08", Offset = "0x292AC08", VA = "0x292AC08")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x292BA28", Offset = "0x292BA28", VA = "0x292BA28")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x292B328", Offset = "0x292B328", VA = "0x292B328")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x292A774", Offset = "0x292A774", VA = "0x292A774")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x292C098", Offset = "0x292C098", VA = "0x292C098")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x292BBE8", Offset = "0x292BBE8", VA = "0x292BBE8")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x292B1A8", Offset = "0x292B1A8", VA = "0x292B1A8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x292B278", Offset = "0x292B278", VA = "0x292B278")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x292C150", Offset = "0x292C150", VA = "0x292C150")]
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
		[Range(0f, 1f)]
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

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x292C1D0", Offset = "0x292C1D0", VA = "0x292C1D0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x292C824", Offset = "0x292C824", VA = "0x292C824", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x292C8B0", Offset = "0x292C8B0", VA = "0x292C8B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x292C944", Offset = "0x292C944", VA = "0x292C944", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x292CA2C", Offset = "0x292CA2C", VA = "0x292CA2C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x292CABC", Offset = "0x292CABC", VA = "0x292CABC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x292CEBC", Offset = "0x292CEBC", VA = "0x292CEBC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x292D094", Offset = "0x292D094", VA = "0x292D094", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x292CF5C", Offset = "0x292CF5C", VA = "0x292CF5C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x292CC94", Offset = "0x292CC94", VA = "0x292CC94")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x292D118", Offset = "0x292D118", VA = "0x292D118")]
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
		[Range(0f, 10f)]
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

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x292D188", Offset = "0x292D188", VA = "0x292D188")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x292D264", Offset = "0x292D264", VA = "0x292D264")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x292D2AC", Offset = "0x292D2AC", VA = "0x292D2AC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2921138", Offset = "0x2921138", VA = "0x2921138")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2920FAC", Offset = "0x2920FAC", VA = "0x2920FAC")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x292D3C0", Offset = "0x292D3C0", VA = "0x292D3C0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x292D558", Offset = "0x292D558", VA = "0x292D558", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x292D6B4", Offset = "0x292D6B4", VA = "0x292D6B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x292D8B0", Offset = "0x292D8B0", VA = "0x292D8B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x292D980", Offset = "0x292D980", VA = "0x292D980", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x292DA5C", Offset = "0x292DA5C", VA = "0x292DA5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x292DBB8", Offset = "0x292DBB8", VA = "0x292DBB8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x292DD50", Offset = "0x292DD50", VA = "0x292DD50", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x292DF7C", Offset = "0x292DF7C", VA = "0x292DF7C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x292E24C", Offset = "0x292E24C", VA = "0x292E24C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x292E284", Offset = "0x292E284", VA = "0x292E284", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x292E35C", Offset = "0x292E35C", VA = "0x292E35C")]
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
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x292E474", Offset = "0x292E474", VA = "0x292E474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x292E5B4", Offset = "0x292E5B4", VA = "0x292E5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x292E5BC", Offset = "0x292E5BC", VA = "0x292E5BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x292E5C4", Offset = "0x292E5C4", VA = "0x292E5C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x292E5CC", Offset = "0x292E5CC", VA = "0x292E5CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x292E5D4", Offset = "0x292E5D4", VA = "0x292E5D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x292E5DC", Offset = "0x292E5DC", VA = "0x292E5DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x292E5E4", Offset = "0x292E5E4", VA = "0x292E5E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x292E5EC", Offset = "0x292E5EC", VA = "0x292E5EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x292E5F4", Offset = "0x292E5F4", VA = "0x292E5F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x292E620", Offset = "0x292E620", VA = "0x292E620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x292E64C", Offset = "0x292E64C", VA = "0x292E64C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x292E678", Offset = "0x292E678", VA = "0x292E678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x292E6A4", Offset = "0x292E6A4", VA = "0x292E6A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x292E6CC", Offset = "0x292E6CC", VA = "0x292E6CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x292E6F8", Offset = "0x292E6F8", VA = "0x292E6F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x292E724", Offset = "0x292E724", VA = "0x292E724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x292E750", Offset = "0x292E750", VA = "0x292E750")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x29304C4", Offset = "0x29304C4", VA = "0x29304C4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x29304D0", Offset = "0x29304D0", VA = "0x29304D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x292E778", Offset = "0x292E778", VA = "0x292E778")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x292E878", Offset = "0x292E878", VA = "0x292E878")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x292E7C8", Offset = "0x292E7C8", VA = "0x292E7C8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x292E8F0", Offset = "0x292E8F0", VA = "0x292E8F0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x292E47C", Offset = "0x292E47C", VA = "0x292E47C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x292E9B8", Offset = "0x292E9B8", VA = "0x292E9B8")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x292EA68", Offset = "0x292EA68", VA = "0x292EA68")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x292EB14", Offset = "0x292EB14", VA = "0x292EB14")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x292EBC0", Offset = "0x292EBC0", VA = "0x292EBC0")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x292EBC8", Offset = "0x292EBC8", VA = "0x292EBC8")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x292EBF0", Offset = "0x292EBF0", VA = "0x292EBF0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x292ECB0", Offset = "0x292ECB0", VA = "0x292ECB0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x292EE40", Offset = "0x292EE40", VA = "0x292EE40")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x292FDC0", Offset = "0x292FDC0", VA = "0x292FDC0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2930370", Offset = "0x2930370", VA = "0x2930370")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x29303CC", Offset = "0x29303CC", VA = "0x29303CC")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2930210", Offset = "0x2930210", VA = "0x2930210")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x29302C0", Offset = "0x29302C0", VA = "0x29302C0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x29304DC", Offset = "0x29304DC", VA = "0x29304DC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x29305A0", Offset = "0x29305A0", VA = "0x29305A0", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x293066C", Offset = "0x293066C", VA = "0x293066C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2930788", Offset = "0x2930788", VA = "0x2930788")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2930918", Offset = "0x2930918", VA = "0x2930918")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2930A90", Offset = "0x2930A90", VA = "0x2930A90", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2930CEC", Offset = "0x2930CEC", VA = "0x2930CEC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2930D64", Offset = "0x2930D64", VA = "0x2930D64")]
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
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x293158C", Offset = "0x293158C", VA = "0x293158C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2931594", Offset = "0x2931594", VA = "0x2931594", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x293159C", Offset = "0x293159C", VA = "0x293159C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x29315AC", Offset = "0x29315AC", VA = "0x29315AC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x29299E0", Offset = "0x29299E0", VA = "0x29299E0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2930D70", Offset = "0x2930D70", VA = "0x2930D70")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2930EEC", Offset = "0x2930EEC", VA = "0x2930EEC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x2931018", Offset = "0x2931018", VA = "0x2931018", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2931074", Offset = "0x2931074", VA = "0x2931074", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x29310E4", Offset = "0x29310E4", VA = "0x29310E4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x29314A8", Offset = "0x29314A8", VA = "0x29314A8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x29314B0", Offset = "0x29314B0", VA = "0x29314B0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x29315A4", Offset = "0x29315A4", VA = "0x29315A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x29315A8", Offset = "0x29315A8", VA = "0x29315A8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2928ECC", Offset = "0x2928ECC", VA = "0x2928ECC")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2929634", Offset = "0x2929634", VA = "0x2929634")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2931668", Offset = "0x2931668", VA = "0x2931668")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2927FA0", Offset = "0x2927FA0", VA = "0x2927FA0")]
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
		[Range(0f, 1f)]
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

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2A628A4", Offset = "0x2A628A4", VA = "0x2A628A4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2A62C00", Offset = "0x2A62C00", VA = "0x2A62C00")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2A62C64", Offset = "0x2A62C64", VA = "0x2A62C64", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2A62DA8", Offset = "0x2A62DA8", VA = "0x2A62DA8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2A62F08", Offset = "0x2A62F08", VA = "0x2A62F08", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2A62F58", Offset = "0x2A62F58", VA = "0x2A62F58", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2A62FB8", Offset = "0x2A62FB8", VA = "0x2A62FB8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2A63314", Offset = "0x2A63314", VA = "0x2A63314", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2A63334", Offset = "0x2A63334", VA = "0x2A63334")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2A63010", Offset = "0x2A63010", VA = "0x2A63010")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2A633B8", Offset = "0x2A633B8", VA = "0x2A633B8")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2A63798", Offset = "0x2A63798", VA = "0x2A63798")]
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

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x2A64DF4", Offset = "0x2A64DF4", VA = "0x2A64DF4")]
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
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
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
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x2A64DD8", Offset = "0x2A64DD8", VA = "0x2A64DD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x2A63A08", Offset = "0x2A63A08", VA = "0x2A63A08")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2A63A4C", Offset = "0x2A63A4C", VA = "0x2A63A4C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2A63AB8", Offset = "0x2A63AB8", VA = "0x2A63AB8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2A64000", Offset = "0x2A64000", VA = "0x2A64000", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2A64B1C", Offset = "0x2A64B1C", VA = "0x2A64B1C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2A64BC4", Offset = "0x2A64BC4", VA = "0x2A64BC4")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2A64D58", Offset = "0x2A64D58", VA = "0x2A64D58")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2A63E14", Offset = "0x2A63E14", VA = "0x2A63E14")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2A640BC", Offset = "0x2A640BC", VA = "0x2A640BC")]
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
				[Token(Token = "0x60003DC")]
				[Address(RVA = "0x2A66BB0", Offset = "0x2A66BB0", VA = "0x2A66BB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x2A67208", Offset = "0x2A67208", VA = "0x2A67208")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2A65D10", Offset = "0x2A65D10", VA = "0x2A65D10")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x2A65FC0", Offset = "0x2A65FC0", VA = "0x2A65FC0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2A66EF8", Offset = "0x2A66EF8", VA = "0x2A66EF8")]
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
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
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
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x2A65514", Offset = "0x2A65514", VA = "0x2A65514")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x2A656BC", Offset = "0x2A656BC", VA = "0x2A656BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x2A655E0", Offset = "0x2A655E0", VA = "0x2A655E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x2A656E0", Offset = "0x2A656E0", VA = "0x2A656E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x2A655F0", Offset = "0x2A655F0", VA = "0x2A655F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x2A6574C", Offset = "0x2A6574C", VA = "0x2A6574C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2A64F90", Offset = "0x2A64F90", VA = "0x2A64F90")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2A64FAC", Offset = "0x2A64FAC", VA = "0x2A64FAC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2A64FD8", Offset = "0x2A64FD8", VA = "0x2A64FD8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2A65010", Offset = "0x2A65010", VA = "0x2A65010")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2A65058", Offset = "0x2A65058", VA = "0x2A65058")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2A650B0", Offset = "0x2A650B0", VA = "0x2A650B0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2A65120", Offset = "0x2A65120", VA = "0x2A65120", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2A65238", Offset = "0x2A65238", VA = "0x2A65238", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2A65364", Offset = "0x2A65364", VA = "0x2A65364", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2A65770", Offset = "0x2A65770", VA = "0x2A65770", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2A65994", Offset = "0x2A65994", VA = "0x2A65994", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2A65AF4", Offset = "0x2A65AF4", VA = "0x2A65AF4")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2A65D38", Offset = "0x2A65D38", VA = "0x2A65D38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2A660AC", Offset = "0x2A660AC", VA = "0x2A660AC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2A66170", Offset = "0x2A66170", VA = "0x2A66170")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2A6638C", Offset = "0x2A6638C", VA = "0x2A6638C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2A666D4", Offset = "0x2A666D4", VA = "0x2A666D4")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2A66BE0", Offset = "0x2A66BE0", VA = "0x2A66BE0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2A65BA4", Offset = "0x2A65BA4", VA = "0x2A65BA4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2A67000", Offset = "0x2A67000", VA = "0x2A67000")]
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

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x2A684AC", Offset = "0x2A684AC", VA = "0x2A684AC")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x2A68D54", Offset = "0x2A68D54", VA = "0x2A68D54")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x2A63A88", Offset = "0x2A63A88", VA = "0x2A63A88")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x2A68DF0", Offset = "0x2A68DF0", VA = "0x2A68DF0")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
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

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2A67210", Offset = "0x2A67210", VA = "0x2A67210")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2A673A4", Offset = "0x2A673A4", VA = "0x2A673A4")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2A67524", Offset = "0x2A67524", VA = "0x2A67524")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2A67530", Offset = "0x2A67530", VA = "0x2A67530")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2A6754C", Offset = "0x2A6754C", VA = "0x2A6754C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2A67558", Offset = "0x2A67558", VA = "0x2A67558")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2A67560", Offset = "0x2A67560", VA = "0x2A67560", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2A6764C", Offset = "0x2A6764C", VA = "0x2A6764C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2A67744", Offset = "0x2A67744", VA = "0x2A67744", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2A67784", Offset = "0x2A67784", VA = "0x2A67784", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2A677D4", Offset = "0x2A677D4", VA = "0x2A677D4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2A67B78", Offset = "0x2A67B78", VA = "0x2A67B78")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2A67BC4", Offset = "0x2A67BC4", VA = "0x2A67BC4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2A680B8", Offset = "0x2A680B8", VA = "0x2A680B8")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2A68210", Offset = "0x2A68210", VA = "0x2A68210", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2A683BC", Offset = "0x2A683BC", VA = "0x2A683BC")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2A6833C", Offset = "0x2A6833C", VA = "0x2A6833C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2A6859C", Offset = "0x2A6859C", VA = "0x2A6859C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2A68DE4", Offset = "0x2A68DE4", VA = "0x2A68DE4", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2A68DE8", Offset = "0x2A68DE8", VA = "0x2A68DE8", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2A68DEC", Offset = "0x2A68DEC", VA = "0x2A68DEC", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2A68B94", Offset = "0x2A68B94", VA = "0x2A68B94")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2A64C30", Offset = "0x2A64C30", VA = "0x2A64C30")]
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
				[Token(Token = "0x400037B")]
				YawPitch,
				[Token(Token = "0x400037C")]
				FromTo
			}

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000378")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000379")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000062")]
			public Vector3 position
			{
				[Token(Token = "0x6000416")]
				[Address(RVA = "0x2A701B0", Offset = "0x2A701B0", VA = "0x2A701B0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000417")]
				[Address(RVA = "0x2A701BC", Offset = "0x2A701BC", VA = "0x2A701BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x2A701C8", Offset = "0x2A701C8", VA = "0x2A701C8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x2A701D4", Offset = "0x2A701D4", VA = "0x2A701D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x2A701E0", Offset = "0x2A701E0", VA = "0x2A701E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x2A70208", Offset = "0x2A70208", VA = "0x2A70208")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x2A7023C", Offset = "0x2A7023C", VA = "0x2A7023C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x2A7027C", Offset = "0x2A7027C", VA = "0x2A7027C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x2A702BC", Offset = "0x2A702BC", VA = "0x2A702BC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x2A70B00", Offset = "0x2A70B00", VA = "0x2A70B00", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x2A70DAC", Offset = "0x2A70DAC", VA = "0x2A70DAC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x2A70DD0", Offset = "0x2A70DD0", VA = "0x2A70DD0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x2A6E6D8", Offset = "0x2A6E6D8", VA = "0x2A6E6D8")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x2A71804", Offset = "0x2A71804", VA = "0x2A71804", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x2A7185C", Offset = "0x2A7185C", VA = "0x2A7185C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x2A71120", Offset = "0x2A71120", VA = "0x2A71120")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x2A711A0", Offset = "0x2A711A0", VA = "0x2A711A0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x2A71A68", Offset = "0x2A71A68", VA = "0x2A71A68")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x2A6FF38", Offset = "0x2A6FF38", VA = "0x2A6FF38")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000077")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000068")]
			public float sqrMag
			{
				[Token(Token = "0x600042E")]
				[Address(RVA = "0x2A71C18", Offset = "0x2A71C18", VA = "0x2A71C18")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x2A71C20", Offset = "0x2A71C20", VA = "0x2A71C20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x2A71C28", Offset = "0x2A71C28", VA = "0x2A71C28")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x2A71C30", Offset = "0x2A71C30", VA = "0x2A71C30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000429")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600042A")]
			public abstract void PreSolve();

			[Token(Token = "0x600042B")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600042C")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600042D")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x2A71C38", Offset = "0x2A71C38", VA = "0x2A71C38")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x2A636D8", Offset = "0x2A636D8", VA = "0x2A636D8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x2A71C40", Offset = "0x2A71C40", VA = "0x2A71C40")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x2A71CC8", Offset = "0x2A71CC8", VA = "0x2A71CC8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x2A71D60", Offset = "0x2A71D60", VA = "0x2A71D60")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x2A6E5B0", Offset = "0x2A6E5B0", VA = "0x2A6E5B0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2A7169C", Offset = "0x2A7169C", VA = "0x2A7169C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2A71DA8", Offset = "0x2A71DA8", VA = "0x2A71DA8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x2A71ECC", Offset = "0x2A71ECC", VA = "0x2A71ECC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x2A71B80", Offset = "0x2A71B80", VA = "0x2A71B80")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public class Footstep
		{
			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700006A")]
			public bool isStepping
			{
				[Token(Token = "0x600043C")]
				[Address(RVA = "0x2A71EE0", Offset = "0x2A71EE0", VA = "0x2A71EE0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x600043D")]
				[Address(RVA = "0x2A71EF4", Offset = "0x2A71EF4", VA = "0x2A71EF4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x2A71EFC", Offset = "0x2A71EFC", VA = "0x2A71EFC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x2A71F04", Offset = "0x2A71F04", VA = "0x2A71F04")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x2A720C8", Offset = "0x2A720C8", VA = "0x2A720C8")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x2A72110", Offset = "0x2A72110", VA = "0x2A72110")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2A72334", Offset = "0x2A72334", VA = "0x2A72334")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x2A7253C", Offset = "0x2A7253C", VA = "0x2A7253C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x2A72720", Offset = "0x2A72720", VA = "0x2A72720")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			[Range(0.01f, 2f)]
			public float legLengthMlp;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x2A72894", Offset = "0x2A72894", VA = "0x2A72894")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x2A728A0", Offset = "0x2A728A0", VA = "0x2A728A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x2A728AC", Offset = "0x2A728AC", VA = "0x2A728AC")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x2A728B8", Offset = "0x2A728B8", VA = "0x2A728B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x2A728C4", Offset = "0x2A728C4", VA = "0x2A728C4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x2A728CC", Offset = "0x2A728CC", VA = "0x2A728CC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x2A728D8", Offset = "0x2A728D8", VA = "0x2A728D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x2A72900", Offset = "0x2A72900", VA = "0x2A72900")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x2A7292C", Offset = "0x2A7292C", VA = "0x2A7292C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x2A72958", Offset = "0x2A72958", VA = "0x2A72958")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x2A6E57C", Offset = "0x2A6E57C", VA = "0x2A6E57C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x2A72984", Offset = "0x2A72984", VA = "0x2A72984")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x2A72990", Offset = "0x2A72990", VA = "0x2A72990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x2A7299C", Offset = "0x2A7299C", VA = "0x2A7299C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x2A72F04", Offset = "0x2A72F04", VA = "0x2A72F04", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x2A73674", Offset = "0x2A73674", VA = "0x2A73674", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x2A73624", Offset = "0x2A73624", VA = "0x2A73624")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x2A733D8", Offset = "0x2A733D8", VA = "0x2A733D8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x2A63530", Offset = "0x2A63530", VA = "0x2A63530")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x2A73F2C", Offset = "0x2A73F2C", VA = "0x2A73F2C")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x2A73B50", Offset = "0x2A73B50", VA = "0x2A73B50")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x2A74384", Offset = "0x2A74384", VA = "0x2A74384", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x2A7458C", Offset = "0x2A7458C", VA = "0x2A7458C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x2A6392C", Offset = "0x2A6392C", VA = "0x2A6392C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Locomotion
		{
			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Range(0f, 180f)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x17000075")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x2A7466C", Offset = "0x2A7466C", VA = "0x2A7466C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x2A74678", Offset = "0x2A74678", VA = "0x2A74678")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x2A74A54", Offset = "0x2A74A54", VA = "0x2A74A54")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x2A74A88", Offset = "0x2A74A88", VA = "0x2A74A88")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x2A74AC0", Offset = "0x2A74AC0", VA = "0x2A74AC0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x2A74AF4", Offset = "0x2A74AF4", VA = "0x2A74AF4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x2A6CEB8", Offset = "0x2A6CEB8", VA = "0x2A6CEB8")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x2A6A9B0", Offset = "0x2A6A9B0", VA = "0x2A6A9B0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x2A69E7C", Offset = "0x2A69E7C", VA = "0x2A69E7C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x2A69DC4", Offset = "0x2A69DC4", VA = "0x2A69DC4")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x2A6D1AC", Offset = "0x2A6D1AC", VA = "0x2A6D1AC")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x2A74684", Offset = "0x2A74684", VA = "0x2A74684")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2A74838", Offset = "0x2A74838", VA = "0x2A74838")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2A748A4", Offset = "0x2A748A4", VA = "0x2A748A4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x2A700C4", Offset = "0x2A700C4", VA = "0x2A700C4")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(0f, 1f)]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			public float rotateChestByHands;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			public float chestClampWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			public float headClampWeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700007A")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x2526ED0", Offset = "0x2526ED0", VA = "0x2526ED0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x2526F04", Offset = "0x2526F04", VA = "0x2526F04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x2526F38", Offset = "0x2526F38", VA = "0x2526F38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x2526F80", Offset = "0x2526F80", VA = "0x2526F80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x2526FB4", Offset = "0x2526FB4", VA = "0x2526FB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x2526FE8", Offset = "0x2526FE8", VA = "0x2526FE8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x2526FFC", Offset = "0x2526FFC", VA = "0x2526FFC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x2527010", Offset = "0x2527010", VA = "0x2527010")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x2527024", Offset = "0x2527024", VA = "0x2527024")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x2527038", Offset = "0x2527038", VA = "0x2527038", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x2527D28", Offset = "0x2527D28", VA = "0x2527D28", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x2527F10", Offset = "0x2527F10", VA = "0x2527F10", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x25286A4", Offset = "0x25286A4", VA = "0x25286A4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x2528CE0", Offset = "0x2528CE0", VA = "0x2528CE0")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x252962C", Offset = "0x252962C", VA = "0x252962C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x2529DD4", Offset = "0x2529DD4", VA = "0x2529DD4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x252A814", Offset = "0x252A814", VA = "0x252A814", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x252A9E4", Offset = "0x252A9E4", VA = "0x252A9E4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x25288E8", Offset = "0x25288E8", VA = "0x25288E8")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2529AFC", Offset = "0x2529AFC", VA = "0x2529AFC")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x252921C", Offset = "0x252921C", VA = "0x252921C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x252AAB8", Offset = "0x252AAB8", VA = "0x252AAB8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x2529BD8", Offset = "0x2529BD8", VA = "0x2529BD8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x252988C", Offset = "0x252988C", VA = "0x252988C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x252AED0", Offset = "0x252AED0", VA = "0x252AED0")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000402")]
			Pelvis,
			[Token(Token = "0x4000403")]
			Chest,
			[Token(Token = "0x4000404")]
			Head,
			[Token(Token = "0x4000405")]
			LeftHand,
			[Token(Token = "0x4000406")]
			RightHand,
			[Token(Token = "0x4000407")]
			LeftFoot,
			[Token(Token = "0x4000408")]
			RightFoot,
			[Token(Token = "0x4000409")]
			LeftHeel,
			[Token(Token = "0x400040A")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public enum RotationOffset
		{
			[Token(Token = "0x400040C")]
			Pelvis,
			[Token(Token = "0x400040D")]
			Chest,
			[Token(Token = "0x400040E")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public class VirtualBone
		{
			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x2527C98", Offset = "0x2527C98", VA = "0x2527C98")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x2527D08", Offset = "0x2527D08", VA = "0x2527D08")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x252AFEC", Offset = "0x252AFEC", VA = "0x252AFEC")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x252B1EC", Offset = "0x252B1EC", VA = "0x252B1EC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x252AD60", Offset = "0x252AD60", VA = "0x252AD60")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x252B34C", Offset = "0x252B34C", VA = "0x252B34C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x252B4F4", Offset = "0x252B4F4", VA = "0x252B4F4")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x252B67C", Offset = "0x252B67C", VA = "0x252B67C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x252A430", Offset = "0x252A430", VA = "0x252A430")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x252B720", Offset = "0x252B720", VA = "0x252B720")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x252A064", Offset = "0x252A064", VA = "0x252A064")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x252B878", Offset = "0x252B878", VA = "0x252B878")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x252B98C", Offset = "0x252B98C", VA = "0x252B98C")]
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
		public bool SetRootPositionManualy;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int lastLOD;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Range(0f, 2f)]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		public int LOD;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000061")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x2A6FD00", Offset = "0x2A6FD00", VA = "0x2A6FD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x2A6FD08", Offset = "0x2A6FD08", VA = "0x2A6FD08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2A68DF8", Offset = "0x2A68DF8", VA = "0x2A68DF8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2A69218", Offset = "0x2A69218", VA = "0x2A69218")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2A690CC", Offset = "0x2A690CC", VA = "0x2A690CC")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2A69A48", Offset = "0x2A69A48", VA = "0x2A69A48")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2A69B8C", Offset = "0x2A69B8C", VA = "0x2A69B8C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2A69BCC", Offset = "0x2A69BCC", VA = "0x2A69BCC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2A69CF0", Offset = "0x2A69CF0", VA = "0x2A69CF0")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2A6A244", Offset = "0x2A6A244", VA = "0x2A6A244")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2A6AB94", Offset = "0x2A6AB94", VA = "0x2A6AB94", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2A6ACE8", Offset = "0x2A6ACE8", VA = "0x2A6ACE8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2A6AED4", Offset = "0x2A6AED4", VA = "0x2A6AED4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2A6AF44", Offset = "0x2A6AF44", VA = "0x2A6AF44", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2A6AFB4", Offset = "0x2A6AFB4", VA = "0x2A6AFB4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2A6B1B0", Offset = "0x2A6B1B0", VA = "0x2A6B1B0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2A69508", Offset = "0x2A69508", VA = "0x2A69508")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2A695EC", Offset = "0x2A695EC", VA = "0x2A695EC")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2A69934", Offset = "0x2A69934", VA = "0x2A69934")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2A6A354", Offset = "0x2A6A354", VA = "0x2A6A354")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2A6B420", Offset = "0x2A6B420", VA = "0x2A6B420", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2A6B45C", Offset = "0x2A6B45C", VA = "0x2A6B45C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2A6C9F0", Offset = "0x2A6C9F0", VA = "0x2A6C9F0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2A6A4A4", Offset = "0x2A6A4A4", VA = "0x2A6A4A4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2A6B864", Offset = "0x2A6B864", VA = "0x2A6B864")]
		private void Solve()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2A6CE44", Offset = "0x2A6CE44", VA = "0x2A6CE44")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2A6CE80", Offset = "0x2A6CE80", VA = "0x2A6CE80")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2A6C8B4", Offset = "0x2A6C8B4", VA = "0x2A6C8B4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2A6FCBC", Offset = "0x2A6FCBC", VA = "0x2A6FCBC")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2A6FD10", Offset = "0x2A6FD10", VA = "0x2A6FD10")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform child;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x252BB40", Offset = "0x252BB40", VA = "0x252BB40")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x252BF84", Offset = "0x252BF84", VA = "0x252BF84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x252C324", Offset = "0x252C324", VA = "0x252C324")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x252C39C", Offset = "0x252C39C", VA = "0x252C39C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x252C414", Offset = "0x252C414", VA = "0x252C414")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x252C52C", Offset = "0x252C52C", VA = "0x252C52C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000081")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x252C5CC", Offset = "0x252C5CC", VA = "0x252C5CC")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x252C5D4", Offset = "0x252C5D4", VA = "0x252C5D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x252C5DC", Offset = "0x252C5DC", VA = "0x252C5DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x252C5E4", Offset = "0x252C5E4", VA = "0x252C5E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x252C5F0", Offset = "0x252C5F0", VA = "0x252C5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x252C5F8", Offset = "0x252C5F8", VA = "0x252C5F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x252C600", Offset = "0x252C600", VA = "0x252C600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x252EB1C", Offset = "0x252EB1C", VA = "0x252EB1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x252C660", Offset = "0x252C660", VA = "0x252C660")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x252C6F0", Offset = "0x252C6F0", VA = "0x252C6F0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x252C784", Offset = "0x252C784", VA = "0x252C784")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x252C8F0", Offset = "0x252C8F0", VA = "0x252C8F0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x252CCCC", Offset = "0x252CCCC", VA = "0x252CCCC")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x252CDEC", Offset = "0x252CDEC", VA = "0x252CDEC")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x252CE40", Offset = "0x252CE40", VA = "0x252CE40")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x252D948", Offset = "0x252D948", VA = "0x252D948")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x252E390", Offset = "0x252E390", VA = "0x252E390")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x252E5B0", Offset = "0x252E5B0", VA = "0x252E5B0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x252E9D4", Offset = "0x252E9D4", VA = "0x252E9D4")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x252ED1C", Offset = "0x252ED1C", VA = "0x252ED1C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x252EF58", Offset = "0x252EF58", VA = "0x252EF58")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x252F068", Offset = "0x252F068", VA = "0x252F068")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x252F100", Offset = "0x252F100", VA = "0x252F100")]
		public void Update()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x252F2F0", Offset = "0x252F2F0", VA = "0x252F2F0")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x252F398", Offset = "0x252F398", VA = "0x252F398")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x252F444", Offset = "0x252F444", VA = "0x252F444")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x252EB4C", Offset = "0x252EB4C", VA = "0x252EB4C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x25303D4", Offset = "0x25303D4", VA = "0x25303D4")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public class Message
		{
			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x400045D")]
			private const string empty = "";

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x25302DC", Offset = "0x25302DC", VA = "0x25302DC")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x25303DC", Offset = "0x25303DC", VA = "0x25303DC")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000464")]
			private const string empty = "";

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x2530200", Offset = "0x2530200", VA = "0x2530200")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x25303E4", Offset = "0x25303E4", VA = "0x25303E4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x2530494", Offset = "0x2530494", VA = "0x2530494")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x253056C", Offset = "0x253056C", VA = "0x253056C")]
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
				[Token(Token = "0x4000468")]
				PositionWeight,
				[Token(Token = "0x4000469")]
				RotationWeight,
				[Token(Token = "0x400046A")]
				PositionOffsetX,
				[Token(Token = "0x400046B")]
				PositionOffsetY,
				[Token(Token = "0x400046C")]
				PositionOffsetZ,
				[Token(Token = "0x400046D")]
				Pull,
				[Token(Token = "0x400046E")]
				Reach,
				[Token(Token = "0x400046F")]
				RotateBoneWeight,
				[Token(Token = "0x4000470")]
				Push,
				[Token(Token = "0x4000471")]
				PushParent,
				[Token(Token = "0x4000472")]
				PoserWeight,
				[Token(Token = "0x4000473")]
				BendGoalWeight
			}

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x252FB10", Offset = "0x252FB10", VA = "0x252FB10")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x2530580", Offset = "0x2530580", VA = "0x2530580")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public class Multiplier
		{
			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x2530118", Offset = "0x2530118", VA = "0x2530118")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x2530588", Offset = "0x2530588", VA = "0x2530588")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x252F678", Offset = "0x252F678", VA = "0x252F678")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x252F680", Offset = "0x252F680", VA = "0x252F680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x252F688", Offset = "0x252F688", VA = "0x252F688")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x252F690", Offset = "0x252F690", VA = "0x252F690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x252F848", Offset = "0x252F848", VA = "0x252F848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x252EC10", Offset = "0x252EC10", VA = "0x252EC10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x252F458", Offset = "0x252F458", VA = "0x252F458")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x252F49C", Offset = "0x252F49C", VA = "0x252F49C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x252F4E0", Offset = "0x252F4E0", VA = "0x252F4E0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x252F524", Offset = "0x252F524", VA = "0x252F524")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x252F568", Offset = "0x252F568", VA = "0x252F568")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x252F5AC", Offset = "0x252F5AC", VA = "0x252F5AC")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x252F5F0", Offset = "0x252F5F0", VA = "0x252F5F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x252F634", Offset = "0x252F634", VA = "0x252F634")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x252F698", Offset = "0x252F698", VA = "0x252F698")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x252F8C8", Offset = "0x252F8C8", VA = "0x252F8C8")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x252D410", Offset = "0x252D410", VA = "0x252D410")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x252FA40", Offset = "0x252FA40", VA = "0x252FA40")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x252D2CC", Offset = "0x252D2CC", VA = "0x252D2CC")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x252D408", Offset = "0x252D408", VA = "0x252D408")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x252DF88", Offset = "0x252DF88", VA = "0x252DF88")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x252E7C8", Offset = "0x252E7C8", VA = "0x252E7C8")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2530148", Offset = "0x2530148", VA = "0x2530148")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x252FB2C", Offset = "0x252FB2C", VA = "0x252FB2C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x252FA48", Offset = "0x252FA48", VA = "0x252FA48")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x25300BC", Offset = "0x25300BC", VA = "0x25300BC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x253014C", Offset = "0x253014C", VA = "0x253014C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x25301A8", Offset = "0x25301A8", VA = "0x25301A8")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008B")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008A")]
		public bool inInteraction
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x25307B8", Offset = "0x25307B8", VA = "0x25307B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x2532218", Offset = "0x2532218", VA = "0x2532218")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x2532220", Offset = "0x2532220", VA = "0x2532220")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x2532228", Offset = "0x2532228", VA = "0x2532228")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2532230", Offset = "0x2532230", VA = "0x2532230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2530598", Offset = "0x2530598", VA = "0x2530598")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x25305DC", Offset = "0x25305DC", VA = "0x25305DC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2530620", Offset = "0x2530620", VA = "0x2530620")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2530664", Offset = "0x2530664", VA = "0x2530664")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x25306A8", Offset = "0x25306A8", VA = "0x25306A8")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x25306EC", Offset = "0x25306EC", VA = "0x25306EC")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2530730", Offset = "0x2530730", VA = "0x2530730")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2530774", Offset = "0x2530774", VA = "0x2530774")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2530930", Offset = "0x2530930", VA = "0x2530930")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x25309E8", Offset = "0x25309E8", VA = "0x25309E8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2530AA0", Offset = "0x2530AA0", VA = "0x2530AA0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2530B38", Offset = "0x2530B38", VA = "0x2530B38")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2530C1C", Offset = "0x2530C1C", VA = "0x2530C1C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2530D14", Offset = "0x2530D14", VA = "0x2530D14")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2530D98", Offset = "0x2530D98", VA = "0x2530D98")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2530E1C", Offset = "0x2530E1C", VA = "0x2530E1C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2530EA0", Offset = "0x2530EA0", VA = "0x2530EA0")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2530F08", Offset = "0x2530F08", VA = "0x2530F08")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2530F70", Offset = "0x2530F70", VA = "0x2530F70")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2530FCC", Offset = "0x2530FCC", VA = "0x2530FCC")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x253104C", Offset = "0x253104C", VA = "0x253104C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x25310F4", Offset = "0x25310F4", VA = "0x25310F4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x25311C4", Offset = "0x25311C4", VA = "0x25311C4")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2531454", Offset = "0x2531454", VA = "0x2531454")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2531610", Offset = "0x2531610", VA = "0x2531610")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2531878", Offset = "0x2531878", VA = "0x2531878")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2531B04", Offset = "0x2531B04", VA = "0x2531B04")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2531B3C", Offset = "0x2531B3C", VA = "0x2531B3C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2531B9C", Offset = "0x2531B9C", VA = "0x2531B9C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2531CA4", Offset = "0x2531CA4", VA = "0x2531CA4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2531E84", Offset = "0x2531E84", VA = "0x2531E84")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x25320F8", Offset = "0x25320F8", VA = "0x25320F8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2531960", Offset = "0x2531960", VA = "0x2531960")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2532238", Offset = "0x2532238", VA = "0x2532238")]
		public void Start()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2532A84", Offset = "0x2532A84", VA = "0x2532A84")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2532AA4", Offset = "0x2532AA4", VA = "0x2532AA4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2532AC0", Offset = "0x2532AC0", VA = "0x2532AC0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2532ADC", Offset = "0x2532ADC", VA = "0x2532ADC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2532B30", Offset = "0x2532B30", VA = "0x2532B30")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2532C9C", Offset = "0x2532C9C", VA = "0x2532C9C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2532D98", Offset = "0x2532D98", VA = "0x2532D98")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x25330F4", Offset = "0x25330F4", VA = "0x25330F4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x25331D8", Offset = "0x25331D8", VA = "0x25331D8")]
		public void Update()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x25334BC", Offset = "0x25334BC", VA = "0x25334BC")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x253283C", Offset = "0x253283C", VA = "0x253283C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x25335EC", Offset = "0x25335EC", VA = "0x25335EC")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x25336F8", Offset = "0x25336F8", VA = "0x25336F8")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2533780", Offset = "0x2533780", VA = "0x2533780")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2533840", Offset = "0x2533840", VA = "0x2533840")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2533858", Offset = "0x2533858", VA = "0x2533858")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2530850", Offset = "0x2530850", VA = "0x2530850")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2531340", Offset = "0x2531340", VA = "0x2531340")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2533C40", Offset = "0x2533C40", VA = "0x2533C40")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public class Multiplier
		{
			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x25344A0", Offset = "0x25344A0", VA = "0x25344A0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2534210", Offset = "0x2534210", VA = "0x2534210")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2534254", Offset = "0x2534254", VA = "0x2534254")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2534298", Offset = "0x2534298", VA = "0x2534298")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x25342DC", Offset = "0x25342DC", VA = "0x25342DC")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2534320", Offset = "0x2534320", VA = "0x2534320")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2534364", Offset = "0x2534364", VA = "0x2534364")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x25343A8", Offset = "0x25343A8", VA = "0x25343A8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x25343EC", Offset = "0x25343EC", VA = "0x25343EC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x252FAAC", Offset = "0x252FAAC", VA = "0x252FAAC")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x252EC90", Offset = "0x252EC90", VA = "0x252EC90")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x252D4A4", Offset = "0x252D4A4", VA = "0x252D4A4")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2534430", Offset = "0x2534430", VA = "0x2534430")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public class CharacterPosition
		{
			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x1700008D")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000531")]
				[Address(RVA = "0x2534708", Offset = "0x2534708", VA = "0x2534708")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x2534714", Offset = "0x2534714", VA = "0x2534714")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x25347D4", Offset = "0x25347D4", VA = "0x25347D4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x2534F38", Offset = "0x2534F38", VA = "0x2534F38")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class CameraPosition
		{
			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x2534F4C", Offset = "0x2534F4C", VA = "0x2534F4C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x25350C4", Offset = "0x25350C4", VA = "0x25350C4")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x25353CC", Offset = "0x25353CC", VA = "0x25353CC")]
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
				[Token(Token = "0x40004AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600053A")]
				[Address(RVA = "0x2535450", Offset = "0x2535450", VA = "0x2535450")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x2534600", Offset = "0x2534600", VA = "0x2534600")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x2535440", Offset = "0x2535440", VA = "0x2535440")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x25344A8", Offset = "0x25344A8", VA = "0x25344A8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x25344EC", Offset = "0x25344EC", VA = "0x25344EC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2534530", Offset = "0x2534530", VA = "0x2534530")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2534574", Offset = "0x2534574", VA = "0x2534574")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x25345B8", Offset = "0x25345B8", VA = "0x25345B8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x25345FC", Offset = "0x25345FC", VA = "0x25345FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2532F40", Offset = "0x2532F40", VA = "0x2532F40")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x25346B0", Offset = "0x25346B0", VA = "0x25346B0")]
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
			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000542")]
			[Address(RVA = "0x2535744", Offset = "0x2535744", VA = "0x2535744")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x2535A80", Offset = "0x2535A80", VA = "0x2535A80")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x2535A40", Offset = "0x2535A40", VA = "0x2535A40")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x25358C4", Offset = "0x25358C4", VA = "0x25358C4")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2535458", Offset = "0x2535458", VA = "0x2535458", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x25357D0", Offset = "0x25357D0", VA = "0x25357D0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x25357D4", Offset = "0x25357D4", VA = "0x25357D4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x25359E4", Offset = "0x25359E4", VA = "0x25359E4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2535774", Offset = "0x2535774", VA = "0x2535774")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x25356B0", Offset = "0x25356B0", VA = "0x25356B0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2535AC4", Offset = "0x2535AC4", VA = "0x2535AC4")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x2535AE4", Offset = "0x2535AE4", VA = "0x2535AE4", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2535BA0", Offset = "0x2535BA0", VA = "0x2535BA0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2535D44", Offset = "0x2535D44", VA = "0x2535D44", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2535E2C", Offset = "0x2535E2C", VA = "0x2535E2C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2535BF4", Offset = "0x2535BF4", VA = "0x2535BF4")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x253615C", Offset = "0x253615C", VA = "0x253615C")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600054C")]
		public abstract void AutoMapping();

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x253616C", Offset = "0x253616C", VA = "0x253616C")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600054E")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x600054F")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000550")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2536178", Offset = "0x2536178", VA = "0x2536178", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x25361BC", Offset = "0x25361BC", VA = "0x25361BC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x25361E8", Offset = "0x25361E8", VA = "0x25361E8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x2535AD4", Offset = "0x2535AD4", VA = "0x2535AD4")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000098")]
		public class Rigidbone
		{
			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000567")]
			[Address(RVA = "0x25367A8", Offset = "0x25367A8", VA = "0x25367A8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x25372F0", Offset = "0x25372F0", VA = "0x25372F0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0x25370B0", Offset = "0x25370B0", VA = "0x25370B0")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000099")]
		public class Child
		{
			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x25368FC", Offset = "0x25368FC", VA = "0x25368FC")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0x2537408", Offset = "0x2537408", VA = "0x2537408")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x25373C4", Offset = "0x25373C4", VA = "0x25373C4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000570")]
				[Address(RVA = "0x253790C", Offset = "0x253790C", VA = "0x253790C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000572")]
				[Address(RVA = "0x2537954", Offset = "0x2537954", VA = "0x2537954", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x2536958", Offset = "0x2536958", VA = "0x2536958")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x2537728", Offset = "0x2537728", VA = "0x2537728", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x253772C", Offset = "0x253772C", VA = "0x253772C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x2537914", Offset = "0x2537914", VA = "0x2537914", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700008F")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x253622C", Offset = "0x253622C", VA = "0x253622C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool ikUsed
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x2536CE4", Offset = "0x2536CE4", VA = "0x2536CE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2536200", Offset = "0x2536200", VA = "0x2536200")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2536290", Offset = "0x2536290", VA = "0x2536290")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x253639C", Offset = "0x253639C", VA = "0x253639C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2536334", Offset = "0x2536334", VA = "0x2536334")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2536980", Offset = "0x2536980", VA = "0x2536980")]
		private void Update()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2536BA8", Offset = "0x2536BA8", VA = "0x2536BA8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2536C48", Offset = "0x2536C48", VA = "0x2536C48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2536E38", Offset = "0x2536E38", VA = "0x2536E38")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2536CB8", Offset = "0x2536CB8", VA = "0x2536CB8")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2536E04", Offset = "0x2536E04", VA = "0x2536E04")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2536EB8", Offset = "0x2536EB8", VA = "0x2536EB8")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2536E5C", Offset = "0x2536E5C", VA = "0x2536E5C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x25362D8", Offset = "0x25362D8", VA = "0x25362D8")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2536BDC", Offset = "0x2536BDC", VA = "0x2536BDC")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2537518", Offset = "0x2537518", VA = "0x2537518")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2537630", Offset = "0x2537630", VA = "0x2537630")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000093")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x2537DC0", Offset = "0x2537DC0", VA = "0x2537DC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x2537DCC", Offset = "0x2537DCC", VA = "0x2537DCC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x2537DFC", Offset = "0x2537DFC", VA = "0x2537DFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x2537E04", Offset = "0x2537E04", VA = "0x2537E04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x253795C", Offset = "0x253795C", VA = "0x253795C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2537998", Offset = "0x2537998", VA = "0x2537998")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x25379B0", Offset = "0x25379B0", VA = "0x25379B0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2537D30", Offset = "0x2537D30", VA = "0x2537D30")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2537D94", Offset = "0x2537D94", VA = "0x2537D94")]
		public void Disable()
		{
		}

		[Token(Token = "0x600057C")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x2537C34", Offset = "0x2537C34", VA = "0x2537C34")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2537E10", Offset = "0x2537E10", VA = "0x2537E10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2537E14", Offset = "0x2537E14", VA = "0x2537E14")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2537E3C", Offset = "0x2537E3C", VA = "0x2537E3C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2537F10", Offset = "0x2537F10", VA = "0x2537F10")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2538168", Offset = "0x2538168", VA = "0x2538168")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x25382BC", Offset = "0x25382BC", VA = "0x25382BC")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x253831C", Offset = "0x253831C", VA = "0x253831C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2538360", Offset = "0x2538360", VA = "0x2538360")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x25383A4", Offset = "0x25383A4", VA = "0x25383A4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x25383E8", Offset = "0x25383E8", VA = "0x25383E8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x253842C", Offset = "0x253842C", VA = "0x253842C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2538464", Offset = "0x2538464", VA = "0x2538464")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2538788", Offset = "0x2538788", VA = "0x2538788")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2538798", Offset = "0x2538798", VA = "0x2538798")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x25387DC", Offset = "0x25387DC", VA = "0x25387DC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2538820", Offset = "0x2538820", VA = "0x2538820")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2538864", Offset = "0x2538864", VA = "0x2538864")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x25388A8", Offset = "0x25388A8", VA = "0x25388A8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x25388C4", Offset = "0x25388C4", VA = "0x25388C4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2538B0C", Offset = "0x2538B0C", VA = "0x2538B0C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public class ReachCone
		{
			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000096")]
			public Vector3 o
			{
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0x265F04C", Offset = "0x265F04C", VA = "0x265F04C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000097")]
			public Vector3 a
			{
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0x265F078", Offset = "0x265F078", VA = "0x265F078")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 b
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x265F0A8", Offset = "0x265F0A8", VA = "0x265F0A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 c
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x265F0D8", Offset = "0x265F0D8", VA = "0x265F0D8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public bool isValid
			{
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0x265F26C", Offset = "0x265F26C", VA = "0x265F26C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x265F108", Offset = "0x265F108", VA = "0x265F108")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x265F27C", Offset = "0x265F27C", VA = "0x265F27C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class LimitPoint
		{
			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x265F4F0", Offset = "0x265F4F0", VA = "0x265F4F0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public LimitPoint[] points;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2538B70", Offset = "0x2538B70", VA = "0x2538B70")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2538BB4", Offset = "0x2538BB4", VA = "0x2538BB4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2538BF8", Offset = "0x2538BF8", VA = "0x2538BF8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2538C3C", Offset = "0x2538C3C", VA = "0x2538C3C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2538C80", Offset = "0x2538C80", VA = "0x2538C80")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x25392C4", Offset = "0x25392C4", VA = "0x25392C4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x253934C", Offset = "0x253934C", VA = "0x253934C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2539940", Offset = "0x2539940", VA = "0x2539940")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2538D0C", Offset = "0x2538D0C", VA = "0x2538D0C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2539E0C", Offset = "0x2539E0C", VA = "0x2539E0C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x253A23C", Offset = "0x253A23C", VA = "0x253A23C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x253A284", Offset = "0x253A284", VA = "0x253A284")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x253A2E4", Offset = "0x253A2E4", VA = "0x253A2E4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x253969C", Offset = "0x253969C", VA = "0x253969C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x253A350", Offset = "0x253A350", VA = "0x253A350")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x253A41C", Offset = "0x253A41C", VA = "0x253A41C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x265F554", Offset = "0x265F554", VA = "0x265F554")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x265F598", Offset = "0x265F598", VA = "0x265F598")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x265F5DC", Offset = "0x265F5DC", VA = "0x265F5DC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x265F620", Offset = "0x265F620", VA = "0x265F620")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x265F664", Offset = "0x265F664", VA = "0x265F664")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x265F680", Offset = "0x265F680", VA = "0x265F680", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x265F714", Offset = "0x265F714", VA = "0x265F714")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x265FACC", Offset = "0x265FACC", VA = "0x265FACC")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x266078C", Offset = "0x266078C", VA = "0x266078C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x26607D4", Offset = "0x26607D4", VA = "0x26607D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x2660598", Offset = "0x2660598", VA = "0x2660598")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x26606A4", Offset = "0x26606A4", VA = "0x26606A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x26606A8", Offset = "0x26606A8", VA = "0x26606A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x2660794", Offset = "0x2660794", VA = "0x2660794", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700009B")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x265FB58", Offset = "0x265FB58", VA = "0x265FB58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x265FADC", Offset = "0x265FADC", VA = "0x265FADC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x265FBDC", Offset = "0x265FBDC", VA = "0x265FBDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2660108", Offset = "0x2660108", VA = "0x2660108")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x266028C", Offset = "0x266028C", VA = "0x266028C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2660530", Offset = "0x2660530", VA = "0x2660530")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__33))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x26605C0", Offset = "0x26605C0", VA = "0x26605C0")]
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
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x26608AC", Offset = "0x26608AC", VA = "0x26608AC")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x2660E1C", Offset = "0x2660E1C", VA = "0x2660E1C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x2660E24", Offset = "0x2660E24", VA = "0x2660E24")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x26607DC", Offset = "0x26607DC", VA = "0x26607DC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2660D5C", Offset = "0x2660D5C", VA = "0x2660D5C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2660DBC", Offset = "0x2660DBC", VA = "0x2660DBC")]
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
				[Token(Token = "0x400052A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400052B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x26612E8", Offset = "0x26612E8", VA = "0x26612E8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x2660F90", Offset = "0x2660F90", VA = "0x2660F90")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x26612C0", Offset = "0x26612C0", VA = "0x26612C0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x26612D0", Offset = "0x26612D0", VA = "0x26612D0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2660E40", Offset = "0x2660E40", VA = "0x2660E40", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x26612A0", Offset = "0x26612A0", VA = "0x26612A0")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x26612F0", Offset = "0x26612F0", VA = "0x26612F0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2661358", Offset = "0x2661358", VA = "0x2661358", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x26615F8", Offset = "0x26615F8", VA = "0x26615F8")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2661614", Offset = "0x2661614", VA = "0x2661614")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x26616A0", Offset = "0x26616A0", VA = "0x26616A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2661760", Offset = "0x2661760", VA = "0x2661760")]
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
			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700009F")]
			public bool inProgress
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x2661804", Offset = "0x2661804", VA = "0x2661804")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A0")]
			protected float crossFader
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x2661D04", Offset = "0x2661D04", VA = "0x2661D04")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x2661D0C", Offset = "0x2661D0C", VA = "0x2661D0C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			protected float timer
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x2661D14", Offset = "0x2661D14", VA = "0x2661D14")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x2661D1C", Offset = "0x2661D1C", VA = "0x2661D1C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected Vector3 force
			{
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x2661D24", Offset = "0x2661D24", VA = "0x2661D24")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x2661D30", Offset = "0x2661D30", VA = "0x2661D30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 point
			{
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x2661D3C", Offset = "0x2661D3C", VA = "0x2661D3C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x2661D48", Offset = "0x2661D48", VA = "0x2661D48")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x2661BCC", Offset = "0x2661BCC", VA = "0x2661BCC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x26618D8", Offset = "0x26618D8", VA = "0x26618D8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E0")]
			protected abstract float GetLength();

			[Token(Token = "0x60005E1")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005E2")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x2661D54", Offset = "0x2661D54", VA = "0x2661D54")]
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
				[Token(Token = "0x4000542")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000543")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000545")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005E8")]
				[Address(RVA = "0x2662088", Offset = "0x2662088", VA = "0x2662088")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005E9")]
				[Address(RVA = "0x2661EE4", Offset = "0x2661EE4", VA = "0x2661EE4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x2662138", Offset = "0x2662138", VA = "0x2662138")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x2661D68", Offset = "0x2661D68", VA = "0x2661D68", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x2661E84", Offset = "0x2661E84", VA = "0x2661E84", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x2661EF8", Offset = "0x2661EF8", VA = "0x2661EF8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x2662124", Offset = "0x2662124", VA = "0x2662124")]
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
				[Token(Token = "0x4000549")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x400054A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x400054B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400054C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005EF")]
				[Address(RVA = "0x26623F8", Offset = "0x26623F8", VA = "0x26623F8")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x2662224", Offset = "0x2662224", VA = "0x2662224")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x2662598", Offset = "0x2662598", VA = "0x2662598")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x2662140", Offset = "0x2662140", VA = "0x2662140", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x26621CC", Offset = "0x26621CC", VA = "0x26621CC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x2662230", Offset = "0x2662230", VA = "0x2662230", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x2662584", Offset = "0x2662584", VA = "0x2662584")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009E")]
		public bool inProgress
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x2661768", Offset = "0x2661768", VA = "0x2661768")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2661818", Offset = "0x2661818", VA = "0x2661818", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x26619B0", Offset = "0x26619B0", VA = "0x26619B0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2661CF4", Offset = "0x2661CF4", VA = "0x2661CF4")]
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
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A4")]
			protected float crossFader
			{
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x2662B08", Offset = "0x2662B08", VA = "0x2662B08")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x2662B10", Offset = "0x2662B10", VA = "0x2662B10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected float timer
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x2662B18", Offset = "0x2662B18", VA = "0x2662B18")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x2662B20", Offset = "0x2662B20", VA = "0x2662B20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 force
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x2662B28", Offset = "0x2662B28", VA = "0x2662B28")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x2662B34", Offset = "0x2662B34", VA = "0x2662B34")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 point
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x2662B40", Offset = "0x2662B40", VA = "0x2662B40")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x2662B4C", Offset = "0x2662B4C", VA = "0x2662B4C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x26629B8", Offset = "0x26629B8", VA = "0x26629B8")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x26626B4", Offset = "0x26626B4", VA = "0x26626B4")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005FF")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000600")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000601")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x2662B58", Offset = "0x2662B58", VA = "0x2662B58")]
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
				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000560")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000607")]
				[Address(RVA = "0x2662F3C", Offset = "0x2662F3C", VA = "0x2662F3C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000608")]
				[Address(RVA = "0x2662D60", Offset = "0x2662D60", VA = "0x2662D60")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000609")]
				[Address(RVA = "0x2662FD0", Offset = "0x2662FD0", VA = "0x2662FD0")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x2662B6C", Offset = "0x2662B6C", VA = "0x2662B6C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x2662D00", Offset = "0x2662D00", VA = "0x2662D00", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x2662D74", Offset = "0x2662D74", VA = "0x2662D74", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x2662FB4", Offset = "0x2662FB4", VA = "0x2662FB4")]
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
				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000567")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600060E")]
				[Address(RVA = "0x2663390", Offset = "0x2663390", VA = "0x2663390")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x2663108", Offset = "0x2663108", VA = "0x2663108")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x26634AC", Offset = "0x26634AC", VA = "0x26634AC")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x2662FD8", Offset = "0x2662FD8", VA = "0x2662FD8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x26630B0", Offset = "0x26630B0", VA = "0x26630B0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x2663114", Offset = "0x2663114", VA = "0x2663114", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x2663498", Offset = "0x2663498", VA = "0x2663498")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x26625FC", Offset = "0x26625FC", VA = "0x26625FC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2662794", Offset = "0x2662794", VA = "0x2662794")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2662AE8", Offset = "0x2662AE8", VA = "0x2662AE8")]
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
				[Token(Token = "0x4000575")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000576")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000617")]
				[Address(RVA = "0x2663A74", Offset = "0x2663A74", VA = "0x2663A74")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x266357C", Offset = "0x266357C", VA = "0x266357C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x26636FC", Offset = "0x26636FC", VA = "0x26636FC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x2663A58", Offset = "0x2663A58", VA = "0x2663A58")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x2663510", Offset = "0x2663510", VA = "0x2663510")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x2663658", Offset = "0x2663658", VA = "0x2663658", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2663A48", Offset = "0x2663A48", VA = "0x2663A48")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000A8")]
		private Vector3 pivot
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x2663AE4", Offset = "0x2663AE4", VA = "0x2663AE4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2663A7C", Offset = "0x2663A7C", VA = "0x2663A7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2663B68", Offset = "0x2663B68", VA = "0x2663B68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2664050", Offset = "0x2664050", VA = "0x2664050")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x26641D4", Offset = "0x26641D4", VA = "0x26641D4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2664420", Offset = "0x2664420", VA = "0x2664420")]
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
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x266461C", Offset = "0x266461C", VA = "0x266461C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x266488C", Offset = "0x266488C", VA = "0x266488C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x26648FC", Offset = "0x26648FC", VA = "0x26648FC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x2664944", Offset = "0x2664944", VA = "0x2664944")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062D")]
				[Address(RVA = "0x2664AA0", Offset = "0x2664AA0", VA = "0x2664AA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x2664AE8", Offset = "0x2664AE8", VA = "0x2664AE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x2664520", Offset = "0x2664520", VA = "0x2664520")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x266494C", Offset = "0x266494C", VA = "0x266494C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x2664950", Offset = "0x2664950", VA = "0x2664950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x2664AA8", Offset = "0x2664AA8", VA = "0x2664AA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A9")]
		protected float deltaTime
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x2660F70", Offset = "0x2660F70", VA = "0x2660F70")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600061F")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x2661338", Offset = "0x2661338", VA = "0x2661338", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x26644B8", Offset = "0x26644B8", VA = "0x26644B8")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2664548", Offset = "0x2664548", VA = "0x2664548")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x26639A0", Offset = "0x26639A0", VA = "0x26639A0")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2664780", Offset = "0x2664780", VA = "0x2664780", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x26612B0", Offset = "0x26612B0", VA = "0x26612B0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x2664EF4", Offset = "0x2664EF4", VA = "0x2664EF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x2664F3C", Offset = "0x2664F3C", VA = "0x2664F3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x2664B98", Offset = "0x2664B98", VA = "0x2664B98")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2664DA0", Offset = "0x2664DA0", VA = "0x2664DA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x2664DA4", Offset = "0x2664DA4", VA = "0x2664DA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x2664EFC", Offset = "0x2664EFC", VA = "0x2664EFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x2664AF0", Offset = "0x2664AF0", VA = "0x2664AF0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000631")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2664B10", Offset = "0x2664B10", VA = "0x2664B10", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2664B30", Offset = "0x2664B30", VA = "0x2664B30")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2664BC0", Offset = "0x2664BC0", VA = "0x2664BC0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2664C94", Offset = "0x2664C94", VA = "0x2664C94", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x2662AF8", Offset = "0x2662AF8", VA = "0x2662AF8")]
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
			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x2664F44", Offset = "0x2664F44", VA = "0x2664F44")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x2665290", Offset = "0x2665290", VA = "0x2665290")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2661544", Offset = "0x2661544", VA = "0x2661544")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2665194", Offset = "0x2665194", VA = "0x2665194")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2665238", Offset = "0x2665238", VA = "0x2665238")]
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
				[Token(Token = "0x40005B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x6000648")]
				[Address(RVA = "0x26658E4", Offset = "0x26658E4", VA = "0x26658E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x2665308", Offset = "0x2665308", VA = "0x2665308")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x26654A8", Offset = "0x26654A8", VA = "0x26654A8")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x26655B0", Offset = "0x26655B0", VA = "0x26655B0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x26658D0", Offset = "0x26658D0", VA = "0x26658D0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2665298", Offset = "0x2665298", VA = "0x2665298", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2665498", Offset = "0x2665498", VA = "0x2665498")]
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
				[Token(Token = "0x40005D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000658")]
				[Address(RVA = "0x2666C38", Offset = "0x2666C38", VA = "0x2666C38")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x2665A88", Offset = "0x2665A88", VA = "0x2665A88")]
			public void Start()
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x26665E4", Offset = "0x26665E4", VA = "0x26665E4")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x2666C24", Offset = "0x2666C24", VA = "0x2666C24")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public enum Handedness
		{
			[Token(Token = "0x40005D4")]
			Right,
			[Token(Token = "0x40005D5")]
			Left
		}

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000AF")]
		public bool isFinished
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x26658EC", Offset = "0x26658EC", VA = "0x26658EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x26667E8", Offset = "0x26667E8", VA = "0x26667E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x2666824", Offset = "0x2666824", VA = "0x2666824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x26667B0", Offset = "0x26667B0", VA = "0x26667B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x26667CC", Offset = "0x26667CC", VA = "0x26667CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2665910", Offset = "0x2665910", VA = "0x2665910")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x266593C", Offset = "0x266593C", VA = "0x266593C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2665B5C", Offset = "0x2665B5C", VA = "0x2665B5C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2666860", Offset = "0x2666860", VA = "0x2666860")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2666978", Offset = "0x2666978", VA = "0x2666978")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x26669C8", Offset = "0x26669C8", VA = "0x26669C8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2666B98", Offset = "0x2666B98", VA = "0x2666B98")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2666C40", Offset = "0x2666C40", VA = "0x2666C40")]
		private void Start()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2666D30", Offset = "0x2666D30", VA = "0x2666D30")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2666E0C", Offset = "0x2666E0C", VA = "0x2666E0C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2667210", Offset = "0x2667210", VA = "0x2667210")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2667244", Offset = "0x2667244", VA = "0x2667244")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2667350", Offset = "0x2667350", VA = "0x2667350")]
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
			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x2669CBC", Offset = "0x2669CBC", VA = "0x2669CBC")]
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
				[Token(Token = "0x40005F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40005F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40005F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000666")]
				[Address(RVA = "0x2668F14", Offset = "0x2668F14", VA = "0x2668F14")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000667")]
				[Address(RVA = "0x26698BC", Offset = "0x26698BC", VA = "0x26698BC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x2668694", Offset = "0x2668694", VA = "0x2668694")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2667364", Offset = "0x2667364", VA = "0x2667364")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x2667458", Offset = "0x2667458", VA = "0x2667458")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x266869C", Offset = "0x266869C", VA = "0x266869C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x2668FC8", Offset = "0x2668FC8", VA = "0x2668FC8")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x2669918", Offset = "0x2669918", VA = "0x2669918")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x2669EC0", Offset = "0x2669EC0", VA = "0x2669EC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2669F10", Offset = "0x2669F10", VA = "0x2669F10")]
		private void Update()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2669F38", Offset = "0x2669F38", VA = "0x2669F38")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x266A058", Offset = "0x266A058", VA = "0x266A058")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B4")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x266A070", Offset = "0x266A070", VA = "0x266A070")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x266A07C", Offset = "0x266A07C", VA = "0x266A07C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x266A088", Offset = "0x266A088", VA = "0x266A088")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2668D54", Offset = "0x2668D54", VA = "0x2668D54")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2669B64", Offset = "0x2669B64", VA = "0x2669B64")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x266A17C", Offset = "0x266A17C", VA = "0x266A17C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x266A544", Offset = "0x266A544", VA = "0x266A544")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x266A650", Offset = "0x266A650", VA = "0x266A650")]
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
			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x266A70C", Offset = "0x266A70C", VA = "0x266A70C")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x266A974", Offset = "0x266A974", VA = "0x266A974")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x266A658", Offset = "0x266A658", VA = "0x266A658")]
		private void Start()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x266A6A8", Offset = "0x266A6A8", VA = "0x266A6A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x266A8B4", Offset = "0x266A8B4", VA = "0x266A8B4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x266A96C", Offset = "0x266A96C", VA = "0x266A96C")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x266A97C", Offset = "0x266A97C", VA = "0x266A97C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x266A9FC", Offset = "0x266A9FC", VA = "0x266A9FC")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x266AA04", Offset = "0x266AA04", VA = "0x266AA04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x266AA70", Offset = "0x266AA70", VA = "0x266AA70")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x266AAD0", Offset = "0x266AAD0", VA = "0x266AAD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x266AB08", Offset = "0x266AB08", VA = "0x266AB08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x266ADC4", Offset = "0x266ADC4", VA = "0x266ADC4")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x266ADCC", Offset = "0x266ADCC", VA = "0x266ADCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x266AE04", Offset = "0x266AE04", VA = "0x266AE04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x266AF50", Offset = "0x266AF50", VA = "0x266AF50")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x266B0B8", Offset = "0x266B0B8", VA = "0x266B0B8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x266B29C", Offset = "0x266B29C", VA = "0x266B29C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x266B32C", Offset = "0x266B32C", VA = "0x266B32C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x266B340", Offset = "0x266B340", VA = "0x266B340")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x266B4AC", Offset = "0x266B4AC", VA = "0x266B4AC")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x266B6A8", Offset = "0x266B6A8", VA = "0x266B6A8")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x266B6D8", Offset = "0x266B6D8", VA = "0x266B6D8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x266BB04", Offset = "0x266BB04", VA = "0x266BB04")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x266BB24", Offset = "0x266BB24", VA = "0x266BB24")]
		private void Update()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x266C440", Offset = "0x266C440", VA = "0x266C440")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x266C1BC", Offset = "0x266C1BC", VA = "0x266C1BC")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x266C550", Offset = "0x266C550", VA = "0x266C550")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000B5")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x266C57C", Offset = "0x266C57C", VA = "0x266C57C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x266C5FC", Offset = "0x266C5FC", VA = "0x266C5FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x266C940", Offset = "0x266C940", VA = "0x266C940")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A1")]
				[Address(RVA = "0x266D978", Offset = "0x266D978", VA = "0x266D978", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x266D9C0", Offset = "0x266D9C0", VA = "0x266D9C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x266D61C", Offset = "0x266D61C", VA = "0x266D61C")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x266D6D4", Offset = "0x266D6D4", VA = "0x266D6D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x266D6D8", Offset = "0x266D6D8", VA = "0x266D6D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x266D980", Offset = "0x266D980", VA = "0x266D980", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000B6")]
		public bool isStepping
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x266C954", Offset = "0x266C954", VA = "0x266C954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public Vector3 position
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x266C520", Offset = "0x266C520", VA = "0x266C520")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x266C968", Offset = "0x266C968", VA = "0x266C968")]
			set
			{
			}
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x266C9B4", Offset = "0x266C9B4", VA = "0x266C9B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x266CBFC", Offset = "0x266CBFC", VA = "0x266CBFC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x266CDD4", Offset = "0x266CDD4", VA = "0x266CDD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x266CFEC", Offset = "0x266CFEC", VA = "0x266CFEC")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x266D27C", Offset = "0x266D27C", VA = "0x266D27C")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x266D3E4", Offset = "0x266D3E4", VA = "0x266D3E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x266CF48", Offset = "0x266CF48", VA = "0x266CF48")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x266D644", Offset = "0x266D644", VA = "0x266D644")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x266D9C8", Offset = "0x266D9C8", VA = "0x266D9C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x266DA94", Offset = "0x266DA94", VA = "0x266DA94")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x266DD08", Offset = "0x266DD08", VA = "0x266DD08")]
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
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000674")]
			PositionOffset,
			[Token(Token = "0x4000675")]
			Position
		}

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		[Space(10f)]
		public Warp[] warps;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x266DD10", Offset = "0x266DD10", VA = "0x266DD10", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x266DD3C", Offset = "0x266DD3C", VA = "0x266DD3C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x266DF54", Offset = "0x266DF54", VA = "0x266DF54", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x266E20C", Offset = "0x266E20C", VA = "0x266E20C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x266E2A0", Offset = "0x266E2A0", VA = "0x266E2A0")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x266E2B0", Offset = "0x266E2B0", VA = "0x266E2B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x266E300", Offset = "0x266E300", VA = "0x266E300")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x266E508", Offset = "0x266E508", VA = "0x266E508", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x266E730", Offset = "0x266E730", VA = "0x266E730")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[RequireComponent(typeof(AimIK))]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x266E744", Offset = "0x266E744", VA = "0x266E744", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x266E8D8", Offset = "0x266E8D8", VA = "0x266E8D8", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x266E948", Offset = "0x266E948", VA = "0x266E948")]
		private void Read()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x266EA80", Offset = "0x266EA80", VA = "0x266EA80")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x266EADC", Offset = "0x266EADC", VA = "0x266EADC")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x266F144", Offset = "0x266F144", VA = "0x266F144")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x266EF58", Offset = "0x266EF58", VA = "0x266EF58")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x266F3E8", Offset = "0x266F3E8", VA = "0x266F3E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x266F4F4", Offset = "0x266F4F4", VA = "0x266F4F4")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x266F510", Offset = "0x266F510", VA = "0x266F510", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x266F56C", Offset = "0x266F56C", VA = "0x266F56C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x266F8A8", Offset = "0x266F8A8", VA = "0x266F8A8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x266F998", Offset = "0x266F998", VA = "0x266F998")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BA")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x248CDAC", Offset = "0x248CDAC", VA = "0x248CDAC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BB")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x248CE2C", Offset = "0x248CE2C", VA = "0x248CE2C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x248CB54", Offset = "0x248CB54", VA = "0x248CB54")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x248CBBC", Offset = "0x248CBBC", VA = "0x248CBBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x248CEAC", Offset = "0x248CEAC", VA = "0x248CEAC")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x248CEB4", Offset = "0x248CEB4", VA = "0x248CEB4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x248D310", Offset = "0x248D310", VA = "0x248D310")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x248D318", Offset = "0x248D318", VA = "0x248D318")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x248D3BC", Offset = "0x248D3BC", VA = "0x248D3BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x248D818", Offset = "0x248D818", VA = "0x248D818")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x248D8B8", Offset = "0x248D8B8", VA = "0x248D8B8")]
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
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x248DA4C", Offset = "0x248DA4C", VA = "0x248DA4C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x248DB70", Offset = "0x248DB70", VA = "0x248DB70")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x248D928", Offset = "0x248D928", VA = "0x248D928")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x248DAC4", Offset = "0x248DAC4", VA = "0x248DAC4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x248DB5C", Offset = "0x248DB5C", VA = "0x248DB5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x248DB60", Offset = "0x248DB60", VA = "0x248DB60")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x248DB80", Offset = "0x248DB80", VA = "0x248DB80")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x248DBE8", Offset = "0x248DBE8", VA = "0x248DBE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x248DCB0", Offset = "0x248DCB0", VA = "0x248DCB0")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x248DCB8", Offset = "0x248DCB8", VA = "0x248DCB8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x248DD08", Offset = "0x248DD08", VA = "0x248DD08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x248DEA0", Offset = "0x248DEA0", VA = "0x248DEA0")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x248DEA8", Offset = "0x248DEA8", VA = "0x248DEA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x248DF78", Offset = "0x248DF78", VA = "0x248DF78")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x248E004", Offset = "0x248E004", VA = "0x248E004")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x248E4D8", Offset = "0x248E4D8", VA = "0x248E4D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x248E5E4", Offset = "0x248E5E4", VA = "0x248E5E4")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x248E5EC", Offset = "0x248E5EC", VA = "0x248E5EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x248E74C", Offset = "0x248E74C", VA = "0x248E74C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x248E758", Offset = "0x248E758", VA = "0x248E758")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x248EA18", Offset = "0x248EA18", VA = "0x248EA18")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x248EBA4", Offset = "0x248EBA4", VA = "0x248EBA4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x248E81C", Offset = "0x248E81C", VA = "0x248E81C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x248F85C", Offset = "0x248F85C", VA = "0x248F85C")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[RequireComponent(typeof(FPSAiming))]
	[RequireComponent(typeof(Animator))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x248F87C", Offset = "0x248F87C", VA = "0x248F87C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x248F8F8", Offset = "0x248F8F8", VA = "0x248F8F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x248F9F4", Offset = "0x248F9F4", VA = "0x248F9F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x248FAA0", Offset = "0x248FAA0", VA = "0x248FAA0")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x248FAB0", Offset = "0x248FAB0", VA = "0x248FAB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x248FBF4", Offset = "0x248FBF4", VA = "0x248FBF4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x248FD58", Offset = "0x248FD58", VA = "0x248FD58")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x248FD68", Offset = "0x248FD68", VA = "0x248FD68")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x248FF34", Offset = "0x248FF34", VA = "0x248FF34")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2490344", Offset = "0x2490344", VA = "0x2490344")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2490354", Offset = "0x2490354", VA = "0x2490354")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x249043C", Offset = "0x249043C", VA = "0x249043C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2490528", Offset = "0x2490528", VA = "0x2490528")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2490530", Offset = "0x2490530", VA = "0x2490530")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2490A30", Offset = "0x2490A30", VA = "0x2490A30")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2490A38", Offset = "0x2490A38", VA = "0x2490A38")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2490A88", Offset = "0x2490A88", VA = "0x2490A88")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x2490D34", Offset = "0x2490D34", VA = "0x2490D34")]
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
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000BC")]
			private Transform neck
			{
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x2491540", Offset = "0x2491540", VA = "0x2491540")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x2490D64", Offset = "0x2490D64", VA = "0x2490D64")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x2490DE0", Offset = "0x2490DE0", VA = "0x2490DE0")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x24913D8", Offset = "0x24913D8", VA = "0x24913D8")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x249158C", Offset = "0x249158C", VA = "0x249158C")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2490D3C", Offset = "0x2490D3C", VA = "0x2490D3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2490D84", Offset = "0x2490D84", VA = "0x2490D84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x24913C8", Offset = "0x24913C8", VA = "0x24913C8")]
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
			[Token(Token = "0x4000700")]
			Position,
			[Token(Token = "0x4000701")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000F6")]
		public class Absorber
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x2491704", Offset = "0x2491704", VA = "0x2491704")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x24918D8", Offset = "0x24918D8", VA = "0x24918D8")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x24918FC", Offset = "0x24918FC", VA = "0x24918FC")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x2491A0C", Offset = "0x2491A0C", VA = "0x2491A0C")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x2491BA4", Offset = "0x2491BA4", VA = "0x2491BA4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x24915A0", Offset = "0x24915A0", VA = "0x24915A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2491684", Offset = "0x2491684", VA = "0x2491684")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x24917CC", Offset = "0x24917CC", VA = "0x24917CC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x2491990", Offset = "0x2491990", VA = "0x2491990")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x2491A7C", Offset = "0x2491A7C", VA = "0x2491A7C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2491B94", Offset = "0x2491B94", VA = "0x2491B94")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x2491C04", Offset = "0x2491C04", VA = "0x2491C04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x2491C74", Offset = "0x2491C74", VA = "0x2491C74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x2491D44", Offset = "0x2491D44", VA = "0x2491D44")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x2491E8C", Offset = "0x2491E8C", VA = "0x2491E8C")]
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
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x249210C", Offset = "0x249210C", VA = "0x249210C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x2491EA0", Offset = "0x2491EA0", VA = "0x2491EA0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x2491F8C", Offset = "0x2491F8C", VA = "0x2491F8C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x2492104", Offset = "0x2492104", VA = "0x2492104")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x249211C", Offset = "0x249211C", VA = "0x249211C")]
		private void Start()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x249241C", Offset = "0x249241C", VA = "0x249241C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2492C18", Offset = "0x2492C18", VA = "0x2492C18")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000BD")]
		private bool holding
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x2492E98", Offset = "0x2492E98", VA = "0x2492E98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2492C84", Offset = "0x2492C84", VA = "0x2492C84")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000711")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x2492EB8", Offset = "0x2492EB8", VA = "0x2492EB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2493078", Offset = "0x2493078", VA = "0x2493078")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x24931E8", Offset = "0x24931E8", VA = "0x24931E8")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x24932B8", Offset = "0x24932B8", VA = "0x24932B8")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x24933D8", Offset = "0x24933D8", VA = "0x24933D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x249354C", Offset = "0x249354C", VA = "0x249354C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2493748", Offset = "0x2493748", VA = "0x2493748")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x249375C", Offset = "0x249375C", VA = "0x249375C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x249393C", Offset = "0x249393C", VA = "0x249393C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2493950", Offset = "0x2493950", VA = "0x2493950", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2493A64", Offset = "0x2493A64", VA = "0x2493A64")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2493A78", Offset = "0x2493A78", VA = "0x2493A78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2493B10", Offset = "0x2493B10", VA = "0x2493B10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2493C28", Offset = "0x2493C28", VA = "0x2493C28")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2493C30", Offset = "0x2493C30", VA = "0x2493C30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2493C80", Offset = "0x2493C80", VA = "0x2493C80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2493CCC", Offset = "0x2493CCC", VA = "0x2493CCC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2493D64", Offset = "0x2493D64", VA = "0x2493D64")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000BE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0x24940A4", Offset = "0x24940A4", VA = "0x24940A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072E")]
				[Address(RVA = "0x24940EC", Offset = "0x24940EC", VA = "0x24940EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x2493ED8", Offset = "0x2493ED8", VA = "0x2493ED8")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x2493F10", Offset = "0x2493F10", VA = "0x2493F10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x2493F14", Offset = "0x2493F14", VA = "0x2493F14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x24940AC", Offset = "0x24940AC", VA = "0x24940AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2493D74", Offset = "0x2493D74", VA = "0x2493D74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2493E24", Offset = "0x2493E24", VA = "0x2493E24")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2493E60", Offset = "0x2493E60", VA = "0x2493E60")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2493F00", Offset = "0x2493F00", VA = "0x2493F00")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x2494360", Offset = "0x2494360", VA = "0x2494360", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000737")]
				[Address(RVA = "0x24943A8", Offset = "0x24943A8", VA = "0x24943A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x2494204", Offset = "0x2494204", VA = "0x2494204")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x2494234", Offset = "0x2494234", VA = "0x2494234", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x2494238", Offset = "0x2494238", VA = "0x2494238", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x2494368", Offset = "0x2494368", VA = "0x2494368", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x24940F4", Offset = "0x24940F4", VA = "0x24940F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x249419C", Offset = "0x249419C", VA = "0x249419C")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x249422C", Offset = "0x249422C", VA = "0x249422C")]
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
			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x2494414", Offset = "0x2494414", VA = "0x2494414")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x2494F50", Offset = "0x2494F50", VA = "0x2494F50")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x24947D8", Offset = "0x24947D8", VA = "0x24947D8")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x249502C", Offset = "0x249502C", VA = "0x249502C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x2495110", Offset = "0x2495110", VA = "0x2495110")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x249519C", Offset = "0x249519C", VA = "0x249519C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x2495224", Offset = "0x2495224", VA = "0x2495224")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x2494D90", Offset = "0x2494D90", VA = "0x2494D90")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x24952AC", Offset = "0x24952AC", VA = "0x24952AC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x24943B0", Offset = "0x24943B0", VA = "0x24943B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2494778", Offset = "0x2494778", VA = "0x2494778")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2494CE0", Offset = "0x2494CE0", VA = "0x2494CE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2494F48", Offset = "0x2494F48", VA = "0x2494F48")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The amount of motion to transfer.")]
		public float transferMotion;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x24952E0", Offset = "0x24952E0", VA = "0x24952E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2495310", Offset = "0x2495310", VA = "0x2495310")]
		private void Update()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x24953C0", Offset = "0x24953C0", VA = "0x24953C0")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x24953D4", Offset = "0x24953D4", VA = "0x24953D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x24955B8", Offset = "0x24955B8", VA = "0x24955B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2495854", Offset = "0x2495854", VA = "0x2495854")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x249591C", Offset = "0x249591C", VA = "0x249591C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2495A28", Offset = "0x2495A28", VA = "0x2495A28")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2495A30", Offset = "0x2495A30", VA = "0x2495A30", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2495E88", Offset = "0x2495E88", VA = "0x2495E88")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2496050", Offset = "0x2496050", VA = "0x2496050")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2496084", Offset = "0x2496084", VA = "0x2496084")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x249628C", Offset = "0x249628C", VA = "0x249628C")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x24962F8", Offset = "0x24962F8", VA = "0x24962F8")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075C")]
				[Address(RVA = "0x2496A44", Offset = "0x2496A44", VA = "0x2496A44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075E")]
				[Address(RVA = "0x2496A8C", Offset = "0x2496A8C", VA = "0x2496A8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x24966D8", Offset = "0x24966D8", VA = "0x24966D8")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x24968C8", Offset = "0x24968C8", VA = "0x24968C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x24968CC", Offset = "0x24968CC", VA = "0x24968CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x2496A4C", Offset = "0x2496A4C", VA = "0x2496A4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x2496300", Offset = "0x2496300", VA = "0x2496300")]
		private void Start()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2496424", Offset = "0x2496424", VA = "0x2496424")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x24963BC", Offset = "0x24963BC", VA = "0x24963BC")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x2496700", Offset = "0x2496700", VA = "0x2496700")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x24967D8", Offset = "0x24967D8", VA = "0x24967D8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x24968AC", Offset = "0x24968AC", VA = "0x24968AC")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x2496A94", Offset = "0x2496A94", VA = "0x2496A94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2496AFC", Offset = "0x2496AFC", VA = "0x2496AFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x2496BA8", Offset = "0x2496BA8", VA = "0x2496BA8")]
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
			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x2496C1C", Offset = "0x2496C1C", VA = "0x2496C1C")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x2496D3C", Offset = "0x2496D3C", VA = "0x2496D3C")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2496BB8", Offset = "0x2496BB8", VA = "0x2496BB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2496D34", Offset = "0x2496D34", VA = "0x2496D34")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class VRIKAvatarScaleCalibrationOculus : MonoBehaviour
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scaleMlp;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2496D44", Offset = "0x2496D44", VA = "0x2496D44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2496D48", Offset = "0x2496D48", VA = "0x2496D48")]
		public VRIKAvatarScaleCalibrationOculus()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2496D58", Offset = "0x2496D58", VA = "0x2496D58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2496E9C", Offset = "0x2496E9C", VA = "0x2496E9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2497000", Offset = "0x2497000", VA = "0x2497000")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2497010", Offset = "0x2497010", VA = "0x2497010")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2497164", Offset = "0x2497164", VA = "0x2497164")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x24971CC", Offset = "0x24971CC", VA = "0x24971CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x249721C", Offset = "0x249721C", VA = "0x249721C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x24973F4", Offset = "0x24973F4", VA = "0x24973F4")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x249744C", Offset = "0x249744C", VA = "0x249744C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x249796C", Offset = "0x249796C", VA = "0x249796C")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000C4")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x24979E8", Offset = "0x24979E8", VA = "0x24979E8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x24979C8", Offset = "0x24979C8", VA = "0x24979C8", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x24979F0", Offset = "0x24979F0", VA = "0x24979F0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2497A50", Offset = "0x2497A50", VA = "0x2497A50", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2497BD4", Offset = "0x2497BD4", VA = "0x2497BD4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2497E50", Offset = "0x2497E50", VA = "0x2497E50", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2497BE4", Offset = "0x2497BE4", VA = "0x2497BE4")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2497E60", Offset = "0x2497E60", VA = "0x2497E60")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2497E78", Offset = "0x2497E78", VA = "0x2497E78", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2497ED0", Offset = "0x2497ED0", VA = "0x2497ED0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2497F60", Offset = "0x2497F60", VA = "0x2497F60")]
		private void Update()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2498084", Offset = "0x2498084", VA = "0x2498084")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007A3")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007A4")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x170000C5")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x2498134", Offset = "0x2498134", VA = "0x2498134", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x249809C", Offset = "0x249809C", VA = "0x249809C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2498118", Offset = "0x2498118", VA = "0x2498118", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2498228", Offset = "0x2498228", VA = "0x2498228", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x24985FC", Offset = "0x24985FC", VA = "0x24985FC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2498724", Offset = "0x2498724", VA = "0x2498724")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007B0")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000784")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2498748", Offset = "0x2498748", VA = "0x2498748")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x2498934", Offset = "0x2498934", VA = "0x2498934", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x2498AE4", Offset = "0x2498AE4", VA = "0x2498AE4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x2498C84", Offset = "0x2498C84", VA = "0x2498C84")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x2498CE4", Offset = "0x2498CE4", VA = "0x2498CE4")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2498E48", Offset = "0x2498E48", VA = "0x2498E48")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x249904C", Offset = "0x249904C", VA = "0x249904C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2499070", Offset = "0x2499070", VA = "0x2499070")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2499094", Offset = "0x2499094", VA = "0x2499094")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x24991E0", Offset = "0x24991E0", VA = "0x24991E0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public enum MoveMode
		{
			[Token(Token = "0x40007ED")]
			Directional,
			[Token(Token = "0x40007EE")]
			Strafe
		}

		[Token(Token = "0x200011A")]
		public struct AnimState
		{
			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A4")]
				[Address(RVA = "0x249BBAC", Offset = "0x249BBAC", VA = "0x249BBAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x249BBF4", Offset = "0x249BBF4", VA = "0x249BBF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x249B974", Offset = "0x249B974", VA = "0x249B974")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x249BAB4", Offset = "0x249BAB4", VA = "0x249BAB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x249BAB8", Offset = "0x249BAB8", VA = "0x249BAB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x249BBB4", Offset = "0x249BBB4", VA = "0x249BBB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x170000C6")]
		public bool onGround
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x2499200", Offset = "0x2499200", VA = "0x2499200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x2499208", Offset = "0x2499208", VA = "0x2499208")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2499214", Offset = "0x2499214", VA = "0x2499214", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x24993E8", Offset = "0x24993E8", VA = "0x24993E8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x249946C", Offset = "0x249946C", VA = "0x249946C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x249951C", Offset = "0x249951C", VA = "0x249951C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x249A508", Offset = "0x249A508", VA = "0x249A508", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x249A998", Offset = "0x249A998", VA = "0x249A998", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x2499BCC", Offset = "0x2499BCC", VA = "0x2499BCC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x249AA70", Offset = "0x249AA70", VA = "0x249AA70")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x249B0FC", Offset = "0x249B0FC", VA = "0x249B0FC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x249A594", Offset = "0x249A594", VA = "0x249A594")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x249B1EC", Offset = "0x249B1EC", VA = "0x249B1EC", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x249B66C", Offset = "0x249B66C", VA = "0x249B66C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x249B794", Offset = "0x249B794", VA = "0x249B794", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x249B8E8", Offset = "0x249B8E8", VA = "0x249B8E8")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__74))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2499FA8", Offset = "0x2499FA8", VA = "0x2499FA8")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x249B99C", Offset = "0x249B99C", VA = "0x249B99C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011D")]
		public enum RotationMode
		{
			[Token(Token = "0x400080A")]
			Smooth,
			[Token(Token = "0x400080B")]
			Linear
		}

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000C9")]
		public bool isGrounded
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x249BBFC", Offset = "0x249BBFC", VA = "0x249BBFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x249BC04", Offset = "0x249BC04", VA = "0x249BC04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x249BC10", Offset = "0x249BC10", VA = "0x249BC10")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x249BCA4", Offset = "0x249BCA4", VA = "0x249BCA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x249C2BC", Offset = "0x249C2BC", VA = "0x249C2BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x249BCEC", Offset = "0x249BCEC", VA = "0x249BCEC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x249C054", Offset = "0x249C054", VA = "0x249C054")]
		private void Move()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x249C2EC", Offset = "0x249C2EC", VA = "0x249C2EC")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x249C384", Offset = "0x249C384", VA = "0x249C384")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x249C404", Offset = "0x249C404", VA = "0x249C404")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x249C42C", Offset = "0x249C42C", VA = "0x249C42C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x249C548", Offset = "0x249C548", VA = "0x249C548", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x249CBAC", Offset = "0x249CBAC", VA = "0x249CBAC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x249CD98", Offset = "0x249CD98", VA = "0x249CD98")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
		public struct State
		{
			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x249C468", Offset = "0x249C468", VA = "0x249C468", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2495B44", Offset = "0x2495B44", VA = "0x2495B44", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2496074", Offset = "0x2496074", VA = "0x2496074")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x249CDB4", Offset = "0x249CDB4", VA = "0x249CDB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x249CDEC", Offset = "0x249CDEC", VA = "0x249CDEC")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x249CDF4", Offset = "0x249CDF4", VA = "0x249CDF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x249CE1C", Offset = "0x249CE1C", VA = "0x249CE1C")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x249CEC0", Offset = "0x249CEC0", VA = "0x249CEC0")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000123")]
	public class Navigator
	{
		[Token(Token = "0x2000124")]
		public enum State
		{
			[Token(Token = "0x400082D")]
			Idle,
			[Token(Token = "0x400082E")]
			Seeking,
			[Token(Token = "0x400082F")]
			OnPath
		}

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000CA")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x249CED4", Offset = "0x249CED4", VA = "0x249CED4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x249CEE0", Offset = "0x249CEE0", VA = "0x249CEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public State state
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x249CEEC", Offset = "0x249CEEC", VA = "0x249CEEC")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x249CEF4", Offset = "0x249CEF4", VA = "0x249CEF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x249C494", Offset = "0x249C494", VA = "0x249C494")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x249C768", Offset = "0x249C768", VA = "0x249C768")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x249CFD4", Offset = "0x249CFD4", VA = "0x249CFD4")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x249D038", Offset = "0x249D038", VA = "0x249D038")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x249CEFC", Offset = "0x249CEFC", VA = "0x249CEFC")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x249CF58", Offset = "0x249CF58", VA = "0x249CF58")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x249CBD4", Offset = "0x249CBD4", VA = "0x249CBD4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x249D16C", Offset = "0x249D16C", VA = "0x249D16C")]
		public Navigator()
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000125")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x249D1D0", Offset = "0x249D1D0", VA = "0x249D1D0")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public enum MessageCode
	{
		[Token(Token = "0x4000831")]
		UnityReflectionMethodNotFound
	}
	[Token(Token = "0x2000127")]
	[AttributeUsage(AttributeTargets.Method)]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x249D1D8", Offset = "0x249D1D8", VA = "0x249D1D8")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class RenameAttribute : Attribute
	{
		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string target;

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x249D1E0", Offset = "0x249D1E0", VA = "0x249D1E0")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x249D1E8", Offset = "0x249D1E8", VA = "0x249D1E8")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x249D210", Offset = "0x249D210", VA = "0x249D210")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x249D218", Offset = "0x249D218", VA = "0x249D218")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x249D220", Offset = "0x249D220", VA = "0x249D220")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x249D228", Offset = "0x249D228", VA = "0x249D228")]
		public SkipRenameAttribute()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeUsage(AttributeTargets.Method)]
	public class SuppressLogAttribute : Attribute
	{
		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MessageCode _messageCode;

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x249D230", Offset = "0x249D230", VA = "0x249D230")]
		private SuppressLogAttribute()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x249D238", Offset = "0x249D238", VA = "0x249D238")]
		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
