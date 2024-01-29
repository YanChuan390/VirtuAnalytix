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
			[Address(RVA = "0xEA6610", Offset = "0xEA6610", VA = "0xEA6610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xEA6618", Offset = "0xEA6618", VA = "0xEA6618")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xEA6624", Offset = "0xEA6624", VA = "0xEA6624")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0xEA662C", Offset = "0xEA662C", VA = "0xEA662C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xEA6634", Offset = "0xEA6634", VA = "0xEA6634")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xEA663C", Offset = "0xEA663C", VA = "0xEA663C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xEA6500", Offset = "0xEA6500", VA = "0xEA6500")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xEA6544", Offset = "0xEA6544", VA = "0xEA6544")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xEA6588", Offset = "0xEA6588", VA = "0xEA6588")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xEA65CC", Offset = "0xEA65CC", VA = "0xEA65CC")]
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
		[Address(RVA = "0xEA6644", Offset = "0xEA6644", VA = "0xEA6644")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xEA6648", Offset = "0xEA6648", VA = "0xEA6648")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xEA664C", Offset = "0xEA664C", VA = "0xEA664C")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xEA6650", Offset = "0xEA6650", VA = "0xEA6650")]
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
		[Address(RVA = "0xEA6778", Offset = "0xEA6778", VA = "0xEA6778")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xEA6BBC", Offset = "0xEA6BBC", VA = "0xEA6BBC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xEA6BC4", Offset = "0xEA6BC4", VA = "0xEA6BC4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xEA6E00", Offset = "0xEA6E00", VA = "0xEA6E00", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xEA7064", Offset = "0xEA7064", VA = "0xEA7064", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xEA737C", Offset = "0xEA737C", VA = "0xEA737C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xEA69A4", Offset = "0xEA69A4", VA = "0xEA69A4")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xEA6A5C", Offset = "0xEA6A5C", VA = "0xEA6A5C")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xEA75DC", Offset = "0xEA75DC", VA = "0xEA75DC")]
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
		[Address(RVA = "0xEA7644", Offset = "0xEA7644", VA = "0xEA7644")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xEA76A8", Offset = "0xEA76A8", VA = "0xEA76A8")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xEA7904", Offset = "0xEA7904", VA = "0xEA7904")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xEA78E4", Offset = "0xEA78E4", VA = "0xEA78E4")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xEA7F74", Offset = "0xEA7F74", VA = "0xEA7F74")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xEA7F7C", Offset = "0xEA7F7C", VA = "0xEA7F7C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xEA7FB4", Offset = "0xEA7FB4", VA = "0xEA7FB4")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xEA8378", Offset = "0xEA8378", VA = "0xEA8378")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xEA8558", Offset = "0xEA8558", VA = "0xEA8558")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xEA855C", Offset = "0xEA855C", VA = "0xEA855C")]
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
		[Address(RVA = "0xEA86F0", Offset = "0xEA86F0", VA = "0xEA86F0")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xEA8A54", Offset = "0xEA8A54", VA = "0xEA8A54")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xEA88BC", Offset = "0xEA88BC", VA = "0xEA88BC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xEA8C3C", Offset = "0xEA8C3C", VA = "0xEA8C3C")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xEA8E70", Offset = "0xEA8E70", VA = "0xEA8E70")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xEA8F60", Offset = "0xEA8F60", VA = "0xEA8F60")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xEA9044", Offset = "0xEA9044", VA = "0xEA9044")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xEA8FC8", Offset = "0xEA8FC8", VA = "0xEA8FC8")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xEA90AC", Offset = "0xEA90AC", VA = "0xEA90AC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xEA9154", Offset = "0xEA9154", VA = "0xEA9154")]
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
		[Address(RVA = "0xEA9440", Offset = "0xEA9440", VA = "0xEA9440")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xEA94B0", Offset = "0xEA94B0", VA = "0xEA94B0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xEA9F4C", Offset = "0xEA9F4C", VA = "0xEA9F4C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xEA9FF4", Offset = "0xEA9FF4", VA = "0xEA9FF4")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xEA9EE4", Offset = "0xEA9EE4", VA = "0xEA9EE4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xEAA0E8", Offset = "0xEAA0E8", VA = "0xEAA0E8")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xEAA124", Offset = "0xEAA124", VA = "0xEAA124")]
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
		[Address(RVA = "0xEA6B14", Offset = "0xEA6B14", VA = "0xEA6B14")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xEA6DEC", Offset = "0xEA6DEC", VA = "0xEA6DEC")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xEA70C8", Offset = "0xEA70C8", VA = "0xEA70C8")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xEAA12C", Offset = "0xEAA12C", VA = "0xEAA12C")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xEA6C94", Offset = "0xEA6C94", VA = "0xEA6C94")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xEAA3B4", Offset = "0xEAA3B4", VA = "0xEAA3B4")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xEA73E8", Offset = "0xEA73E8", VA = "0xEA73E8")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xEA6E6C", Offset = "0xEA6E6C", VA = "0xEA6E6C")]
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
		[Address(RVA = "0xEAA41C", Offset = "0xEAA41C", VA = "0xEAA41C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xEAA97C", Offset = "0xEAA97C", VA = "0xEAA97C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xEAA998", Offset = "0xEAA998", VA = "0xEAA998", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xEAAA74", Offset = "0xEAAA74", VA = "0xEAAA74", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xEAAB30", Offset = "0xEAAB30", VA = "0xEAAB30", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xEAACD0", Offset = "0xEAACD0", VA = "0xEAACD0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xEAAF74", Offset = "0xEAAF74", VA = "0xEAAF74")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xEAB04C", Offset = "0xEAB04C", VA = "0xEAB04C")]
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
			[Address(RVA = "0xEAB0FC", Offset = "0xEAB0FC", VA = "0xEAB0FC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xEAB104", Offset = "0xEAB104", VA = "0xEAB104")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xEAB10C", Offset = "0xEAB10C", VA = "0xEAB10C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xEAB114", Offset = "0xEAB114", VA = "0xEAB114")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xEAB11C", Offset = "0xEAB11C", VA = "0xEAB11C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xEAB124", Offset = "0xEAB124", VA = "0xEAB124")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xEABB44", Offset = "0xEABB44", VA = "0xEABB44")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xEAB12C", Offset = "0xEAB12C", VA = "0xEAB12C")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xEAB164", Offset = "0xEAB164", VA = "0xEAB164")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xEAB16C", Offset = "0xEAB16C", VA = "0xEAB16C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xEAB2A4", Offset = "0xEAB2A4", VA = "0xEAB2A4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xEAB2EC", Offset = "0xEAB2EC", VA = "0xEAB2EC", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xEAB344", Offset = "0xEAB344", VA = "0xEAB344", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xEAB39C", Offset = "0xEAB39C", VA = "0xEAB39C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xEAB2D0", Offset = "0xEAB2D0", VA = "0xEAB2D0")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xEAB528", Offset = "0xEAB528", VA = "0xEAB528")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xEABB08", Offset = "0xEABB08", VA = "0xEABB08")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xEABBB0", Offset = "0xEABBB0", VA = "0xEABBB0")]
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
		[Address(RVA = "0xEABC70", Offset = "0xEABC70", VA = "0xEABC70")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xEABC9C", Offset = "0xEABC9C", VA = "0xEABC9C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xEABEC0", Offset = "0xEABEC0", VA = "0xEABEC0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xEABEFC", Offset = "0xEABEFC", VA = "0xEABEFC")]
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
		[Address(RVA = "0xEABF18", Offset = "0xEABF18", VA = "0xEABF18")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xEABFF8", Offset = "0xEABFF8", VA = "0xEABFF8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xEAC030", Offset = "0xEAC030", VA = "0xEAC030")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xEAC178", Offset = "0xEAC178", VA = "0xEAC178")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xEAC12C", Offset = "0xEAC12C", VA = "0xEAC12C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xEAC274", Offset = "0xEAC274", VA = "0xEAC274")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xEAC2B8", Offset = "0xEAC2B8", VA = "0xEAC2B8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xEAC744", Offset = "0xEAC744", VA = "0xEAC744")]
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
			[Address(RVA = "0xEACA78", Offset = "0xEACA78", VA = "0xEACA78")]
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
			[Address(RVA = "0xEAC7C0", Offset = "0xEAC7C0", VA = "0xEAC7C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xEACAEC", Offset = "0xEACAEC", VA = "0xEACAEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xEAC74C", Offset = "0xEAC74C", VA = "0xEAC74C")]
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
		[Address(RVA = "0xEACDA4", Offset = "0xEACDA4", VA = "0xEACDA4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xEAD070", Offset = "0xEAD070", VA = "0xEAD070")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xEAD2AC", Offset = "0xEAD2AC", VA = "0xEAD2AC")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xEAD320", Offset = "0xEAD320", VA = "0xEAD320")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xEAD3B4", Offset = "0xEAD3B4", VA = "0xEAD3B4")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xEACF58", Offset = "0xEACF58", VA = "0xEACF58")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xEAD224", Offset = "0xEAD224", VA = "0xEAD224")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xEADAEC", Offset = "0xEADAEC", VA = "0xEADAEC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xEAD944", Offset = "0xEAD944", VA = "0xEAD944")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xEADA18", Offset = "0xEADA18", VA = "0xEADA18")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xEAD59C", Offset = "0xEAD59C", VA = "0xEAD59C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xEAD638", Offset = "0xEAD638", VA = "0xEAD638")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xEAD6D4", Offset = "0xEAD6D4", VA = "0xEAD6D4")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xEAD770", Offset = "0xEAD770", VA = "0xEAD770")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xEAD80C", Offset = "0xEAD80C", VA = "0xEAD80C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xEAD8A8", Offset = "0xEAD8A8", VA = "0xEAD8A8")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xEADCD4", Offset = "0xEADCD4", VA = "0xEADCD4")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xEAD4C8", Offset = "0xEAD4C8", VA = "0xEAD4C8")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xEADC50", Offset = "0xEADC50", VA = "0xEADC50")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xEADD34", Offset = "0xEADD34", VA = "0xEADD34")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xEADDF4", Offset = "0xEADDF4", VA = "0xEADDF4")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xEADBDC", Offset = "0xEADBDC", VA = "0xEADBDC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xEADB6C", Offset = "0xEADB6C", VA = "0xEADB6C")]
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
				[Address(RVA = "0xEB48AC", Offset = "0xEB48AC", VA = "0xEB48AC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0xEB4898", Offset = "0xEB4898", VA = "0xEB4898")]
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
			[Address(RVA = "0xEB0BE4", Offset = "0xEB0BE4", VA = "0xEB0BE4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xEB0F40", Offset = "0xEB0F40", VA = "0xEB0F40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xEB0F50", Offset = "0xEB0F50", VA = "0xEB0F50", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xEB12DC", Offset = "0xEB12DC", VA = "0xEB12DC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xEB166C", Offset = "0xEB166C", VA = "0xEB166C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xEB1D90", Offset = "0xEB1D90", VA = "0xEB1D90")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xEB1900", Offset = "0xEB1900", VA = "0xEB1900")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xEB2610", Offset = "0xEB2610", VA = "0xEB2610")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xEB26FC", Offset = "0xEB26FC", VA = "0xEB26FC")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xEB3218", Offset = "0xEB3218", VA = "0xEB3218")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xEB3024", Offset = "0xEB3024", VA = "0xEB3024")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xEB2DC4", Offset = "0xEB2DC4", VA = "0xEB2DC4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xEB2798", Offset = "0xEB2798", VA = "0xEB2798")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xEB3118", Offset = "0xEB3118", VA = "0xEB3118")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xEB32F8", Offset = "0xEB32F8", VA = "0xEB32F8")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xEB3EA0", Offset = "0xEB3EA0", VA = "0xEB3EA0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xEB3948", Offset = "0xEB3948", VA = "0xEB3948")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xEB41EC", Offset = "0xEB41EC", VA = "0xEB41EC")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xEB3CA8", Offset = "0xEB3CA8", VA = "0xEB3CA8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xEB41F4", Offset = "0xEB41F4", VA = "0xEB41F4")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xEB41FC", Offset = "0xEB41FC", VA = "0xEB41FC")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xEB43BC", Offset = "0xEB43BC", VA = "0xEB43BC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xEB4830", Offset = "0xEB4830", VA = "0xEB4830")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xEB1880", Offset = "0xEB1880", VA = "0xEB1880")]
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
		[Address(RVA = "0xEB48B4", Offset = "0xEB48B4", VA = "0xEB48B4")]
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
		[Address(RVA = "0xEB48BC", Offset = "0xEB48BC", VA = "0xEB48BC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xEB49B4", Offset = "0xEB49B4", VA = "0xEB49B4")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0xEB47AC", Offset = "0xEB47AC", VA = "0xEB47AC")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xEB46A0", Offset = "0xEB46A0", VA = "0xEB46A0")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xEB28FC", Offset = "0xEB28FC", VA = "0xEB28FC")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xEB2F14", Offset = "0xEB2F14", VA = "0xEB2F14")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xEB2B7C", Offset = "0xEB2B7C", VA = "0xEB2B7C")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xEB49C4", Offset = "0xEB49C4", VA = "0xEB49C4")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xEB2A2C", Offset = "0xEB2A2C", VA = "0xEB2A2C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xEB4AB8", Offset = "0xEB4AB8", VA = "0xEB4AB8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xEB4E24", Offset = "0xEB4E24", VA = "0xEB4E24")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xEB4C1C", Offset = "0xEB4C1C", VA = "0xEB4C1C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xEB4FAC", Offset = "0xEB4FAC", VA = "0xEB4FAC")]
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
		[Address(RVA = "0xEB4FB4", Offset = "0xEB4FB4", VA = "0xEB4FB4")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xEB503C", Offset = "0xEB503C", VA = "0xEB503C")]
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
		[Address(RVA = "0xEB50C8", Offset = "0xEB50C8", VA = "0xEB50C8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xEB5A50", Offset = "0xEB5A50", VA = "0xEB5A50")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xEB5AC0", Offset = "0xEB5AC0", VA = "0xEB5AC0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xEB54C8", Offset = "0xEB54C8", VA = "0xEB54C8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xEB54D4", Offset = "0xEB54D4", VA = "0xEB54D4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xEB54F8", Offset = "0xEB54F8", VA = "0xEB54F8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xEB5534", Offset = "0xEB5534", VA = "0xEB5534")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xEB554C", Offset = "0xEB554C", VA = "0xEB554C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xEB5560", Offset = "0xEB5560", VA = "0xEB5560")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xEB5574", Offset = "0xEB5574", VA = "0xEB5574")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xEB5584", Offset = "0xEB5584", VA = "0xEB5584")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xEB55CC", Offset = "0xEB55CC", VA = "0xEB55CC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xEB5604", Offset = "0xEB5604", VA = "0xEB5604")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xEB562C", Offset = "0xEB562C", VA = "0xEB562C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xEB5B30", Offset = "0xEB5B30", VA = "0xEB5B30")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xEB5660", Offset = "0xEB5660", VA = "0xEB5660")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xEB5688", Offset = "0xEB5688", VA = "0xEB5688")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xEB56B8", Offset = "0xEB56B8", VA = "0xEB56B8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xEB56EC", Offset = "0xEB56EC", VA = "0xEB56EC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xEB5730", Offset = "0xEB5730", VA = "0xEB5730")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xEB5794", Offset = "0xEB5794", VA = "0xEB5794")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xEB57F8", Offset = "0xEB57F8", VA = "0xEB57F8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xEB584C", Offset = "0xEB584C", VA = "0xEB584C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xEB58A0", Offset = "0xEB58A0", VA = "0xEB58A0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xEB58D8", Offset = "0xEB58D8", VA = "0xEB58D8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xEB590C", Offset = "0xEB590C", VA = "0xEB590C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xEB5B64", Offset = "0xEB5B64", VA = "0xEB5B64")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xEB5950", Offset = "0xEB5950", VA = "0xEB5950")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xEB59E0", Offset = "0xEB59E0", VA = "0xEB59E0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xEB5A10", Offset = "0xEB5A10", VA = "0xEB5A10")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xEB5BF4", Offset = "0xEB5BF4", VA = "0xEB5BF4")]
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
		[Address(RVA = "0xEB5BFC", Offset = "0xEB5BFC", VA = "0xEB5BFC")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xEB5C84", Offset = "0xEB5C84", VA = "0xEB5C84")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xEB5D10", Offset = "0xEB5D10", VA = "0xEB5D10")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xEB5D5C", Offset = "0xEB5D5C", VA = "0xEB5D5C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xEB5E18", Offset = "0xEB5E18", VA = "0xEB5E18")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xEB5D70", Offset = "0xEB5D70", VA = "0xEB5D70")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xEB5E2C", Offset = "0xEB5E2C", VA = "0xEB5E2C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xEB5EBC", Offset = "0xEB5EBC", VA = "0xEB5EBC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xEB5EE4", Offset = "0xEB5EE4", VA = "0xEB5EE4")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xEB5F30", Offset = "0xEB5F30", VA = "0xEB5F30")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xEB5F98", Offset = "0xEB5F98", VA = "0xEB5F98")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xEB60F4", Offset = "0xEB60F4", VA = "0xEB60F4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xEB622C", Offset = "0xEB622C", VA = "0xEB622C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xEB6284", Offset = "0xEB6284", VA = "0xEB6284")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xEB62A8", Offset = "0xEB62A8", VA = "0xEB62A8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xEB62F4", Offset = "0xEB62F4", VA = "0xEB62F4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xEB6340", Offset = "0xEB6340", VA = "0xEB6340")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xEB6444", Offset = "0xEB6444", VA = "0xEB6444")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xEB6548", Offset = "0xEB6548", VA = "0xEB6548")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xEB665C", Offset = "0xEB665C", VA = "0xEB665C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xEB6704", Offset = "0xEB6704", VA = "0xEB6704")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xEB6810", Offset = "0xEB6810", VA = "0xEB6810")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xEB6978", Offset = "0xEB6978", VA = "0xEB6978")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xEB6B5C", Offset = "0xEB6B5C", VA = "0xEB6B5C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xEB6C2C", Offset = "0xEB6C2C", VA = "0xEB6C2C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xEB6DB0", Offset = "0xEB6DB0", VA = "0xEB6DB0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xEB6EBC", Offset = "0xEB6EBC", VA = "0xEB6EBC")]
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
			[Address(RVA = "0xEB7030", Offset = "0xEB7030", VA = "0xEB7030")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xEB72F4", Offset = "0xEB72F4", VA = "0xEB72F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xEB6F14", Offset = "0xEB6F14", VA = "0xEB6F14")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xEB6FA8", Offset = "0xEB6FA8", VA = "0xEB6FA8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xEB6FAC", Offset = "0xEB6FAC", VA = "0xEB6FAC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xEB6FB0", Offset = "0xEB6FB0", VA = "0xEB6FB0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xEB6FB4", Offset = "0xEB6FB4", VA = "0xEB6FB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xEB702C", Offset = "0xEB702C", VA = "0xEB702C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xEB6FDC", Offset = "0xEB6FDC", VA = "0xEB6FDC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xEB72F0", Offset = "0xEB72F0", VA = "0xEB72F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xEB70FC", Offset = "0xEB70FC", VA = "0xEB70FC")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xEB738C", Offset = "0xEB738C", VA = "0xEB738C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xEB7390", Offset = "0xEB7390", VA = "0xEB7390")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xEB7394", Offset = "0xEB7394", VA = "0xEB7394")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xEB73CC", Offset = "0xEB73CC", VA = "0xEB73CC")]
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
		[Address(RVA = "0xEB73DC", Offset = "0xEB73DC", VA = "0xEB73DC")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xEB7490", Offset = "0xEB7490", VA = "0xEB7490")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xEB7544", Offset = "0xEB7544", VA = "0xEB7544")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xEB75F8", Offset = "0xEB75F8", VA = "0xEB75F8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V3Tools
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xEB7600", Offset = "0xEB7600", VA = "0xEB7600")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xEB765C", Offset = "0xEB765C", VA = "0xEB765C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xEB7694", Offset = "0xEB7694", VA = "0xEB7694")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xEB77E4", Offset = "0xEB77E4", VA = "0xEB77E4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xEB7960", Offset = "0xEB7960", VA = "0xEB7960")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xEB7B90", Offset = "0xEB7B90", VA = "0xEB7B90")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xEB7DE0", Offset = "0xEB7DE0", VA = "0xEB7DE0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xEB8038", Offset = "0xEB8038", VA = "0xEB8038")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xEB81E4", Offset = "0xEB81E4", VA = "0xEB81E4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xEB83DC", Offset = "0xEB83DC", VA = "0xEB83DC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xEB8458", Offset = "0xEB8458", VA = "0xEB8458")]
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
		[Address(RVA = "0xEB84E8", Offset = "0xEB84E8", VA = "0xEB84E8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xEB255C", Offset = "0xEB255C", VA = "0xEB255C")]
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
		[Address(RVA = "0xEB86A4", Offset = "0xEB86A4", VA = "0xEB86A4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xEB86E8", Offset = "0xEB86E8", VA = "0xEB86E8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xEB872C", Offset = "0xEB872C", VA = "0xEB872C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xEB8770", Offset = "0xEB8770", VA = "0xEB8770")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xEB87B4", Offset = "0xEB87B4", VA = "0xEB87B4")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xEB884C", Offset = "0xEB884C", VA = "0xEB884C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xEB8868", Offset = "0xEB8868", VA = "0xEB8868")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xEB8894", Offset = "0xEB8894", VA = "0xEB8894")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xEB88C0", Offset = "0xEB88C0", VA = "0xEB88C0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xEB88FC", Offset = "0xEB88FC", VA = "0xEB88FC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xEB893C", Offset = "0xEB893C", VA = "0xEB893C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xEB895C", Offset = "0xEB895C", VA = "0xEB895C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xEB897C", Offset = "0xEB897C", VA = "0xEB897C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xEB89A0", Offset = "0xEB89A0", VA = "0xEB89A0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xEB89C8", Offset = "0xEB89C8", VA = "0xEB89C8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xEB89F0", Offset = "0xEB89F0", VA = "0xEB89F0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xEB87D0", Offset = "0xEB87D0", VA = "0xEB87D0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xEB8A14", Offset = "0xEB8A14", VA = "0xEB8A14")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xEB8A20", Offset = "0xEB8A20", VA = "0xEB8A20")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xEB8A2C", Offset = "0xEB8A2C", VA = "0xEB8A2C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xEB8CE0", Offset = "0xEB8CE0", VA = "0xEB8CE0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xEB8D7C", Offset = "0xEB8D7C", VA = "0xEB8D7C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xEB90A0", Offset = "0xEB90A0", VA = "0xEB90A0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xEB950C", Offset = "0xEB950C", VA = "0xEB950C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xEB9530", Offset = "0xEB9530", VA = "0xEB9530")]
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
			[Address(RVA = "0xEB8B68", Offset = "0xEB8B68", VA = "0xEB8B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xEB97CC", Offset = "0xEB97CC", VA = "0xEB97CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xEB8F2C", Offset = "0xEB8F2C", VA = "0xEB8F2C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xEB95E0", Offset = "0xEB95E0", VA = "0xEB95E0")]
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
			[Address(RVA = "0xEB99F4", Offset = "0xEB99F4", VA = "0xEB99F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012B")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xEB9A54", Offset = "0xEB9A54", VA = "0xEB9A54")]
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
		[Address(RVA = "0xEB9A5C", Offset = "0xEB9A5C", VA = "0xEB9A5C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xEB9AF4", Offset = "0xEB9AF4", VA = "0xEB9AF4")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xEB9AFC", Offset = "0xEB9AFC", VA = "0xEB9AFC")]
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
			[Address(RVA = "0xEB9C30", Offset = "0xEB9C30", VA = "0xEB9C30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xEB9B2C", Offset = "0xEB9B2C", VA = "0xEB9B2C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xEB9C8C", Offset = "0xEB9C8C", VA = "0xEB9C8C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xEB9C94", Offset = "0xEB9C94", VA = "0xEB9C94")]
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
		[Address(RVA = "0xEB9CC4", Offset = "0xEB9CC4", VA = "0xEB9CC4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xEB9D40", Offset = "0xEB9D40", VA = "0xEB9D40")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xEB9D48", Offset = "0xEB9D48", VA = "0xEB9D48")]
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
			[Address(RVA = "0xEB9E7C", Offset = "0xEB9E7C", VA = "0xEB9E7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xEB9D78", Offset = "0xEB9D78", VA = "0xEB9D78", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xEB9ED4", Offset = "0xEB9ED4", VA = "0xEB9ED4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xEB9EDC", Offset = "0xEB9EDC", VA = "0xEB9EDC")]
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
		[Address(RVA = "0xEB9F0C", Offset = "0xEB9F0C", VA = "0xEB9F0C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xEB904C", Offset = "0xEB904C", VA = "0xEB904C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xEB9214", Offset = "0xEB9214", VA = "0xEB9214")]
		public void Update()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xEB99EC", Offset = "0xEB99EC", VA = "0xEB99EC")]
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
			[Address(RVA = "0xEB9F6C", Offset = "0xEB9F6C", VA = "0xEB9F6C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xEB9F74", Offset = "0xEB9F74", VA = "0xEB9F74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xEB9F80", Offset = "0xEB9F80", VA = "0xEB9F80")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xEB9FA0", Offset = "0xEB9FA0", VA = "0xEB9FA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xEB9FC0", Offset = "0xEB9FC0", VA = "0xEB9FC0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xEB9FE0", Offset = "0xEB9FE0", VA = "0xEB9FE0")]
			set
			{
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xEBA000", Offset = "0xEBA000", VA = "0xEBA000")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xEBA0F8", Offset = "0xEBA0F8", VA = "0xEBA0F8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xEBA5F4", Offset = "0xEBA5F4", VA = "0xEBA5F4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xEBA6C0", Offset = "0xEBA6C0", VA = "0xEBA6C0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xEBA778", Offset = "0xEBA778", VA = "0xEBA778")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xEBADE0", Offset = "0xEBADE0", VA = "0xEBADE0")]
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
			[Address(RVA = "0xEBADF0", Offset = "0xEBADF0", VA = "0xEBADF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xEBADF8", Offset = "0xEBADF8", VA = "0xEBADF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xEBAE04", Offset = "0xEBAE04", VA = "0xEBAE04")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xEBAE78", Offset = "0xEBAE78", VA = "0xEBAE78")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xEBB1F0", Offset = "0xEBB1F0", VA = "0xEBB1F0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xEBB3A8", Offset = "0xEBB3A8", VA = "0xEBB3A8")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xEBB100", Offset = "0xEBB100", VA = "0xEBB100")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xEBB524", Offset = "0xEBB524", VA = "0xEBB524", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xEBB5CC", Offset = "0xEBB5CC", VA = "0xEBB5CC")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xEBB630", Offset = "0xEBB630", VA = "0xEBB630")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xEBB698", Offset = "0xEBB698", VA = "0xEBB698")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xEBB6F4", Offset = "0xEBB6F4", VA = "0xEBB6F4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xEBB6F8", Offset = "0xEBB6F8", VA = "0xEBB6F8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xEBB70C", Offset = "0xEBB70C", VA = "0xEBB70C")]
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
			[Address(RVA = "0xEBB780", Offset = "0xEBB780", VA = "0xEBB780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xEBB788", Offset = "0xEBB788", VA = "0xEBB788")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000159")]
		public abstract void ResetPosition();

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xEBB794", Offset = "0xEBB794", VA = "0xEBB794")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xEBBA44", Offset = "0xEBBA44", VA = "0xEBBA44")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xEBB858", Offset = "0xEBB858", VA = "0xEBB858")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xEBBA68", Offset = "0xEBBA68", VA = "0xEBBA68")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000160")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000161")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xEBBBDC", Offset = "0xEBBBDC", VA = "0xEBBBDC")]
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
		[Address(RVA = "0xEBBD64", Offset = "0xEBBD64", VA = "0xEBBD64", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xEBBDA8", Offset = "0xEBBDA8", VA = "0xEBBDA8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xEBBDEC", Offset = "0xEBBDEC", VA = "0xEBBDEC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xEBBE58", Offset = "0xEBBE58", VA = "0xEBBE58")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xEBBEF8", Offset = "0xEBBEF8", VA = "0xEBBEF8")]
		private void Update()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xEBBF4C", Offset = "0xEBBF4C", VA = "0xEBBF4C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xEBC2AC", Offset = "0xEBC2AC", VA = "0xEBC2AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xEBC2EC", Offset = "0xEBC2EC", VA = "0xEBC2EC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xEBC74C", Offset = "0xEBC74C", VA = "0xEBC74C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xEBC80C", Offset = "0xEBC80C", VA = "0xEBC80C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xEBC9DC", Offset = "0xEBC9DC", VA = "0xEBC9DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xEBCBB4", Offset = "0xEBCBB4", VA = "0xEBCBB4")]
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
			[Address(RVA = "0xEBDE3C", Offset = "0xEBDE3C", VA = "0xEBDE3C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0xEBDE4C", Offset = "0xEBDE4C", VA = "0xEBDE4C")]
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
		[Address(RVA = "0xEBCC58", Offset = "0xEBCC58", VA = "0xEBCC58")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xEBCC9C", Offset = "0xEBCC9C", VA = "0xEBCC9C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xEBCCE0", Offset = "0xEBCCE0", VA = "0xEBCCE0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xEBCD24", Offset = "0xEBCD24", VA = "0xEBCD24", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xEBCE04", Offset = "0xEBCE04", VA = "0xEBCE04")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xEBCE8C", Offset = "0xEBCE8C", VA = "0xEBCE8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xEBD138", Offset = "0xEBD138", VA = "0xEBD138")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xEBD144", Offset = "0xEBD144", VA = "0xEBD144")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xEBCEE8", Offset = "0xEBCEE8", VA = "0xEBCEE8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xEBD414", Offset = "0xEBD414", VA = "0xEBD414")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xEBD97C", Offset = "0xEBD97C", VA = "0xEBD97C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xEBDB00", Offset = "0xEBDB00", VA = "0xEBDB00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xEBDC60", Offset = "0xEBDC60", VA = "0xEBDC60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xEBDD94", Offset = "0xEBDD94", VA = "0xEBDD94")]
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
		[Address(RVA = "0xEBDE90", Offset = "0xEBDE90", VA = "0xEBDE90", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xEBDED4", Offset = "0xEBDED4", VA = "0xEBDED4", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xEBDF18", Offset = "0xEBDF18", VA = "0xEBDF18", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xEBDF30", Offset = "0xEBDF30", VA = "0xEBDF30")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xEBE13C", Offset = "0xEBE13C", VA = "0xEBE13C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xEBE21C", Offset = "0xEBE21C", VA = "0xEBE21C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xEBE900", Offset = "0xEBE900", VA = "0xEBE900")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xEBEDB8", Offset = "0xEBEDB8", VA = "0xEBEDB8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xEBEF64", Offset = "0xEBEF64", VA = "0xEBEF64")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xEBF2EC", Offset = "0xEBF2EC", VA = "0xEBF2EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xEBF4C4", Offset = "0xEBF4C4", VA = "0xEBF4C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xEBF6EC", Offset = "0xEBF6EC", VA = "0xEBF6EC")]
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
			[Address(RVA = "0xEC02D0", Offset = "0xEC02D0", VA = "0xEC02D0")]
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
		[Address(RVA = "0xEBF794", Offset = "0xEBF794", VA = "0xEBF794", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xEBF7D8", Offset = "0xEBF7D8", VA = "0xEBF7D8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xEBF81C", Offset = "0xEBF81C", VA = "0xEBF81C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xEBF844", Offset = "0xEBF844", VA = "0xEBF844")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xEBF948", Offset = "0xEBF948", VA = "0xEBF948")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xEBFB2C", Offset = "0xEBFB2C", VA = "0xEBFB2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xEBFB90", Offset = "0xEBFB90", VA = "0xEBFB90")]
		private void Update()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xEBFBE8", Offset = "0xEBFBE8", VA = "0xEBFBE8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xEBFF34", Offset = "0xEBFF34", VA = "0xEBFF34")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xEC0330", Offset = "0xEC0330", VA = "0xEC0330")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xEC03C0", Offset = "0xEC03C0", VA = "0xEC03C0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xEC0810", Offset = "0xEC0810", VA = "0xEC0810")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xEC0ED0", Offset = "0xEC0ED0", VA = "0xEC0ED0")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xEC1188", Offset = "0xEC1188", VA = "0xEC1188")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xEC12BC", Offset = "0xEC12BC", VA = "0xEC12BC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xEC1584", Offset = "0xEC1584", VA = "0xEC1584")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xEC15B4", Offset = "0xEC15B4", VA = "0xEC15B4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xEC17D4", Offset = "0xEC17D4", VA = "0xEC17D4")]
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
		[Address(RVA = "0xEC1980", Offset = "0xEC1980", VA = "0xEC1980")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xEC19C4", Offset = "0xEC19C4", VA = "0xEC19C4", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xEC1A08", Offset = "0xEC1A08", VA = "0xEC1A08", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xEC1A4C", Offset = "0xEC1A4C", VA = "0xEC1A4C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xEC1A64", Offset = "0xEC1A64", VA = "0xEC1A64")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xEC1AEC", Offset = "0xEC1AEC", VA = "0xEC1AEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xEC1B40", Offset = "0xEC1B40", VA = "0xEC1B40")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xEC1DC4", Offset = "0xEC1DC4", VA = "0xEC1DC4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xEC1FB8", Offset = "0xEC1FB8", VA = "0xEC1FB8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xEC203C", Offset = "0xEC203C", VA = "0xEC203C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xEC22D8", Offset = "0xEC22D8", VA = "0xEC22D8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xEC2438", Offset = "0xEC2438", VA = "0xEC2438")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xEC2600", Offset = "0xEC2600", VA = "0xEC2600")]
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
				[Address(RVA = "0xEC3A54", Offset = "0xEC3A54", VA = "0xEC3A54")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0xEC3A5C", Offset = "0xEC3A5C", VA = "0xEC3A5C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0xEC3A68", Offset = "0xEC3A68", VA = "0xEC3A68")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0xEC3A74", Offset = "0xEC3A74", VA = "0xEC3A74")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0xEC3A80", Offset = "0xEC3A80", VA = "0xEC3A80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0xEC3A88", Offset = "0xEC3A88", VA = "0xEC3A88")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xEC3A94", Offset = "0xEC3A94", VA = "0xEC3A94")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0xEC3A9C", Offset = "0xEC3A9C", VA = "0xEC3A9C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0xEC3AA4", Offset = "0xEC3AA4", VA = "0xEC3AA4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0xEC3AB0", Offset = "0xEC3AB0", VA = "0xEC3AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0xEC3ABC", Offset = "0xEC3ABC", VA = "0xEC3ABC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0xEC3AC4", Offset = "0xEC3AC4", VA = "0xEC3AC4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0xEC3ACC", Offset = "0xEC3ACC", VA = "0xEC3ACC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0xEC3AD4", Offset = "0xEC3AD4", VA = "0xEC3AD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0xEC3ADC", Offset = "0xEC3ADC", VA = "0xEC3ADC")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0xEC3AF4", Offset = "0xEC3AF4", VA = "0xEC3AF4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0xEC3B14", Offset = "0xEC3B14", VA = "0xEC3B14")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0xEC3B2C", Offset = "0xEC3B2C", VA = "0xEC3B2C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0xEC3B4C", Offset = "0xEC3B4C", VA = "0xEC3B4C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0xEC4434", Offset = "0xEC4434", VA = "0xEC4434")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0xEC4584", Offset = "0xEC4584", VA = "0xEC4584")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xEC3B94", Offset = "0xEC3B94", VA = "0xEC3B94")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xEC2B98", Offset = "0xEC2B98", VA = "0xEC2B98")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xEC3BA8", Offset = "0xEC3BA8", VA = "0xEC3BA8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xEC36C4", Offset = "0xEC36C4", VA = "0xEC36C4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xEC2CAC", Offset = "0xEC2CAC", VA = "0xEC2CAC")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xEC4048", Offset = "0xEC4048", VA = "0xEC4048")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xEC3BE8", Offset = "0xEC3BE8", VA = "0xEC3BE8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xEC44C8", Offset = "0xEC44C8", VA = "0xEC44C8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xEC3EB0", Offset = "0xEC3EB0", VA = "0xEC3EB0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xEC3F30", Offset = "0xEC3F30", VA = "0xEC3F30")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xEC4534", Offset = "0xEC4534", VA = "0xEC4534")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xEC4468", Offset = "0xEC4468", VA = "0xEC4468")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xEC4610", Offset = "0xEC4610", VA = "0xEC4610")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xEC2AF8", Offset = "0xEC2AF8", VA = "0xEC2AF8")]
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
				[Address(RVA = "0xEC47C0", Offset = "0xEC47C0", VA = "0xEC47C0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0xEC47CC", Offset = "0xEC47CC", VA = "0xEC47CC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0xEC47D8", Offset = "0xEC47D8", VA = "0xEC47D8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0xEC47E0", Offset = "0xEC47E0", VA = "0xEC47E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xEC2C70", Offset = "0xEC2C70", VA = "0xEC2C70")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xEC3630", Offset = "0xEC3630", VA = "0xEC3630")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xEC47E8", Offset = "0xEC47E8", VA = "0xEC47E8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xEC3444", Offset = "0xEC3444", VA = "0xEC3444")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xEC2B90", Offset = "0xEC2B90", VA = "0xEC2B90")]
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
			[Address(RVA = "0xEC2664", Offset = "0xEC2664", VA = "0xEC2664")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xEC266C", Offset = "0xEC266C", VA = "0xEC266C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xEC2674", Offset = "0xEC2674", VA = "0xEC2674")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xEC267C", Offset = "0xEC267C", VA = "0xEC267C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xEC2684", Offset = "0xEC2684", VA = "0xEC2684")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xEC268C", Offset = "0xEC268C", VA = "0xEC268C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xEC2698", Offset = "0xEC2698", VA = "0xEC2698")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xEC26A0", Offset = "0xEC26A0", VA = "0xEC26A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xEC26A8", Offset = "0xEC26A8", VA = "0xEC26A8")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xEC26C0", Offset = "0xEC26C0", VA = "0xEC26C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xEC26E0", Offset = "0xEC26E0", VA = "0xEC26E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xEC2988", Offset = "0xEC2988", VA = "0xEC2988")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0xEC3758", Offset = "0xEC3758", VA = "0xEC3758")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xEC2728", Offset = "0xEC2728", VA = "0xEC2728")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xEC29F0", Offset = "0xEC29F0", VA = "0xEC29F0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xEBD150", Offset = "0xEBD150", VA = "0xEBD150")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xEBD788", Offset = "0xEBD788", VA = "0xEBD788")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xEBE788", Offset = "0xEBE788", VA = "0xEBE788")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xEBCD8C", Offset = "0xEBCD8C", VA = "0xEBCD8C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xEC2C94", Offset = "0xEC2C94", VA = "0xEC2C94")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xEC380C", Offset = "0xEC380C", VA = "0xEC380C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xEC3890", Offset = "0xEC3890", VA = "0xEC3890")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xEC39E4", Offset = "0xEC39E4", VA = "0xEC39E4")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xEC192C", Offset = "0xEC192C", VA = "0xEC192C")]
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
		[Address(RVA = "0xEC483C", Offset = "0xEC483C", VA = "0xEC483C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xEC4880", Offset = "0xEC4880", VA = "0xEC4880", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xEC48C4", Offset = "0xEC48C4", VA = "0xEC48C4")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xEC4908", Offset = "0xEC4908", VA = "0xEC4908")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xEC494C", Offset = "0xEC494C", VA = "0xEC494C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xEC4990", Offset = "0xEC4990", VA = "0xEC4990", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xEC4998", Offset = "0xEC4998", VA = "0xEC4998")]
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
		[Address(RVA = "0xEC4A14", Offset = "0xEC4A14", VA = "0xEC4A14", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xEC4A58", Offset = "0xEC4A58", VA = "0xEC4A58", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xEC4A9C", Offset = "0xEC4A9C", VA = "0xEC4A9C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xEC4AE0", Offset = "0xEC4AE0", VA = "0xEC4AE0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xEC4B24", Offset = "0xEC4B24", VA = "0xEC4B24", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xEC4B2C", Offset = "0xEC4B2C", VA = "0xEC4B2C")]
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
		[Address(RVA = "0xEC4BA0", Offset = "0xEC4BA0", VA = "0xEC4BA0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xEC4BE4", Offset = "0xEC4BE4", VA = "0xEC4BE4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xEC4C28", Offset = "0xEC4C28", VA = "0xEC4C28")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xEC4C6C", Offset = "0xEC4C6C", VA = "0xEC4C6C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xEC4CB0", Offset = "0xEC4CB0", VA = "0xEC4CB0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xEC4CB8", Offset = "0xEC4CB8", VA = "0xEC4CB8")]
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
		[Address(RVA = "0xEC4D2C", Offset = "0xEC4D2C", VA = "0xEC4D2C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xEC4D70", Offset = "0xEC4D70", VA = "0xEC4D70", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xEC4DB4", Offset = "0xEC4DB4", VA = "0xEC4DB4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xEC4DF8", Offset = "0xEC4DF8", VA = "0xEC4DF8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xEC4E3C", Offset = "0xEC4E3C", VA = "0xEC4E3C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xEC4E44", Offset = "0xEC4E44", VA = "0xEC4E44")]
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
		[Address(RVA = "0xEC4EB8", Offset = "0xEC4EB8", VA = "0xEC4EB8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xEC4EFC", Offset = "0xEC4EFC", VA = "0xEC4EFC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xEC4F40", Offset = "0xEC4F40", VA = "0xEC4F40")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xEC4F84", Offset = "0xEC4F84", VA = "0xEC4F84")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xEC4FC8", Offset = "0xEC4FC8", VA = "0xEC4FC8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xEC4FD0", Offset = "0xEC4FD0", VA = "0xEC4FD0")]
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
		[Address(RVA = "0xEC5044", Offset = "0xEC5044", VA = "0xEC5044", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xEC5088", Offset = "0xEC5088", VA = "0xEC5088", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xEC50CC", Offset = "0xEC50CC", VA = "0xEC50CC")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xEC5110", Offset = "0xEC5110", VA = "0xEC5110")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xEC5154", Offset = "0xEC5154", VA = "0xEC5154")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xEC5198", Offset = "0xEC5198", VA = "0xEC5198")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xEC51DC", Offset = "0xEC51DC", VA = "0xEC51DC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xEC521C", Offset = "0xEC521C", VA = "0xEC521C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xEC5224", Offset = "0xEC5224", VA = "0xEC5224")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xEC53F4", Offset = "0xEC53F4", VA = "0xEC53F4")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xEC58B0", Offset = "0xEC58B0", VA = "0xEC58B0")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xEC58D0", Offset = "0xEC58D0", VA = "0xEC58D0")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xEC59C0", Offset = "0xEC59C0", VA = "0xEC59C0")]
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
		[Address(RVA = "0xEC5A70", Offset = "0xEC5A70", VA = "0xEC5A70", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xEC5AE8", Offset = "0xEC5AE8", VA = "0xEC5AE8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xEC5B58", Offset = "0xEC5B58", VA = "0xEC5B58", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000223")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000224")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xEC4A0C", Offset = "0xEC4A0C", VA = "0xEC4A0C")]
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
			[Address(RVA = "0xEC5BA8", Offset = "0xEC5BA8", VA = "0xEC5BA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xEC5C34", Offset = "0xEC5C34", VA = "0xEC5C34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xEC5C98", Offset = "0xEC5C98", VA = "0xEC5C98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xEC5D38", Offset = "0xEC5D38", VA = "0xEC5D38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xEC5D64", Offset = "0xEC5D64", VA = "0xEC5D64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xEC5CBC", Offset = "0xEC5CBC", VA = "0xEC5CBC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xEC5DE8", Offset = "0xEC5DE8", VA = "0xEC5DE8")]
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
		[Address(RVA = "0xEC5DF0", Offset = "0xEC5DF0", VA = "0xEC5DF0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xEC5E34", Offset = "0xEC5E34", VA = "0xEC5E34", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xEC5E78", Offset = "0xEC5E78", VA = "0xEC5E78")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xEC5EBC", Offset = "0xEC5EBC", VA = "0xEC5EBC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xEC5F00", Offset = "0xEC5F00", VA = "0xEC5F00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xEC5F08", Offset = "0xEC5F08", VA = "0xEC5F08")]
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
		[Address(RVA = "0xEC5F7C", Offset = "0xEC5F7C", VA = "0xEC5F7C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xEC5FC0", Offset = "0xEC5FC0", VA = "0xEC5FC0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xEC6004", Offset = "0xEC6004", VA = "0xEC6004")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xEC6048", Offset = "0xEC6048", VA = "0xEC6048")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xEC608C", Offset = "0xEC608C", VA = "0xEC608C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xEC6094", Offset = "0xEC6094", VA = "0xEC6094")]
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
		[Address(RVA = "0xEC6108", Offset = "0xEC6108", VA = "0xEC6108", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xEC614C", Offset = "0xEC614C", VA = "0xEC614C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xEC6190", Offset = "0xEC6190", VA = "0xEC6190")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xEC61D4", Offset = "0xEC61D4", VA = "0xEC61D4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xEC6218", Offset = "0xEC6218", VA = "0xEC6218", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xEC6220", Offset = "0xEC6220", VA = "0xEC6220")]
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
		[Address(RVA = "0xEC6294", Offset = "0xEC6294", VA = "0xEC6294", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xEC62D8", Offset = "0xEC62D8", VA = "0xEC62D8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xEC631C", Offset = "0xEC631C", VA = "0xEC631C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xEC6360", Offset = "0xEC6360", VA = "0xEC6360")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xEC63A4", Offset = "0xEC63A4", VA = "0xEC63A4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xEC63AC", Offset = "0xEC63AC", VA = "0xEC63AC")]
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
				[Address(RVA = "0xEC6DFC", Offset = "0xEC6DFC", VA = "0xEC6DFC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0xEC6A40", Offset = "0xEC6A40", VA = "0xEC6A40")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0xEC7400", Offset = "0xEC7400", VA = "0xEC7400")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0xEC6508", Offset = "0xEC6508", VA = "0xEC6508")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0xEC73F8", Offset = "0xEC73F8", VA = "0xEC73F8")]
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
		[Address(RVA = "0xEC6420", Offset = "0xEC6420", VA = "0xEC6420", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xEC6464", Offset = "0xEC6464", VA = "0xEC6464", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xEC64A8", Offset = "0xEC64A8", VA = "0xEC64A8")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xEC64EC", Offset = "0xEC64EC", VA = "0xEC64EC")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xEC69A4", Offset = "0xEC69A4", VA = "0xEC69A4")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xEC69CC", Offset = "0xEC69CC", VA = "0xEC69CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xEC69D4", Offset = "0xEC69D4", VA = "0xEC69D4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xEC71B8", Offset = "0xEC71B8", VA = "0xEC71B8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xEC7348", Offset = "0xEC7348", VA = "0xEC7348")]
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
		[Address(RVA = "0xEC7944", Offset = "0xEC7944", VA = "0xEC7944")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xEC7A14", Offset = "0xEC7A14", VA = "0xEC7A14")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xEC7A34", Offset = "0xEC7A34", VA = "0xEC7A34")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xEC7C88", Offset = "0xEC7C88", VA = "0xEC7C88")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xEC7AF4", Offset = "0xEC7AF4", VA = "0xEC7AF4")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xEC7D6C", Offset = "0xEC7D6C", VA = "0xEC7D6C")]
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
		[Address(RVA = "0xEC7DD8", Offset = "0xEC7DD8", VA = "0xEC7DD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xEC8288", Offset = "0xEC8288", VA = "0xEC8288")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xEC841C", Offset = "0xEC841C", VA = "0xEC841C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xEC8548", Offset = "0xEC8548", VA = "0xEC8548")]
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
			[Address(RVA = "0xECB7AC", Offset = "0xECB7AC", VA = "0xECB7AC")]
			public BendBone()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0xECB80C", Offset = "0xECB80C", VA = "0xECB80C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0xEC8E40", Offset = "0xEC8E40", VA = "0xEC8E40")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0xEC9210", Offset = "0xEC9210", VA = "0xEC9210")]
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
		[Address(RVA = "0xEC8550", Offset = "0xEC8550", VA = "0xEC8550")]
		private void Start()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xEC8990", Offset = "0xEC8990", VA = "0xEC8990")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xEC8E6C", Offset = "0xEC8E6C", VA = "0xEC8E6C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xEC9238", Offset = "0xEC9238", VA = "0xEC9238")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xEC9B34", Offset = "0xEC9B34", VA = "0xEC9B34")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xEC9F2C", Offset = "0xEC9F2C", VA = "0xEC9F2C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xECA33C", Offset = "0xECA33C", VA = "0xECA33C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xECACBC", Offset = "0xECACBC", VA = "0xECACBC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xEC9878", Offset = "0xEC9878", VA = "0xEC9878")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xECAEF8", Offset = "0xECAEF8", VA = "0xECAEF8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xECABD4", Offset = "0xECABD4", VA = "0xECABD4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xECAAD4", Offset = "0xECAAD4", VA = "0xECAAD4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xECB1FC", Offset = "0xECB1FC", VA = "0xECB1FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xECB598", Offset = "0xECB598", VA = "0xECB598")]
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
				[Address(RVA = "0xECE914", Offset = "0xECE914", VA = "0xECE914")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000284")]
				[Address(RVA = "0xECE91C", Offset = "0xECE91C", VA = "0xECE91C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x6000285")]
				[Address(RVA = "0xECE924", Offset = "0xECE924", VA = "0xECE924")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000286")]
				[Address(RVA = "0xECE92C", Offset = "0xECE92C", VA = "0xECE92C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0xECE938", Offset = "0xECE938", VA = "0xECE938")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0xECC5E8", Offset = "0xECC5E8", VA = "0xECC5E8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0xECCCCC", Offset = "0xECCCCC", VA = "0xECCCCC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0xECE6D8", Offset = "0xECE6D8", VA = "0xECE6D8")]
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
		[Address(RVA = "0xECB894", Offset = "0xECB894", VA = "0xECB894")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xECBA2C", Offset = "0xECBA2C", VA = "0xECBA2C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xECBB9C", Offset = "0xECBB9C", VA = "0xECBB9C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xECBCCC", Offset = "0xECBCCC", VA = "0xECBCCC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xECBD88", Offset = "0xECBD88", VA = "0xECBD88")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xECBEA4", Offset = "0xECBEA4", VA = "0xECBEA4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xECC8E8", Offset = "0xECC8E8", VA = "0xECC8E8")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xECC020", Offset = "0xECC020", VA = "0xECC020")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xECCEB0", Offset = "0xECCEB0", VA = "0xECCEB0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xECD144", Offset = "0xECD144", VA = "0xECD144")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xECD414", Offset = "0xECD414", VA = "0xECD414")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xECDDDC", Offset = "0xECDDDC", VA = "0xECDDDC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xECE2D4", Offset = "0xECE2D4", VA = "0xECE2D4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xECE4D4", Offset = "0xECE4D4", VA = "0xECE4D4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xECE1C0", Offset = "0xECE1C0", VA = "0xECE1C0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xECDC7C", Offset = "0xECDC7C", VA = "0xECDC7C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xECE15C", Offset = "0xECE15C", VA = "0xECE15C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xECE5B0", Offset = "0xECE5B0", VA = "0xECE5B0")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xECE088", Offset = "0xECE088", VA = "0xECE088")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xECE3D8", Offset = "0xECE3D8", VA = "0xECE3D8")]
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
			[Address(RVA = "0xECEB6C", Offset = "0xECEB6C", VA = "0xECEB6C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xECEB74", Offset = "0xECEB74", VA = "0xECEB74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xECE994", Offset = "0xECE994", VA = "0xECE994")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xECB9C0", Offset = "0xECB9C0", VA = "0xECB9C0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xECEB80", Offset = "0xECEB80", VA = "0xECEB80")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xECC63C", Offset = "0xECC63C", VA = "0xECC63C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xECC680", Offset = "0xECC680", VA = "0xECC680")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xECED5C", Offset = "0xECED5C", VA = "0xECED5C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xECF0B0", Offset = "0xECF0B0", VA = "0xECF0B0")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xECD64C", Offset = "0xECD64C", VA = "0xECD64C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xECEC14", Offset = "0xECEC14", VA = "0xECEC14")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xECECB8", Offset = "0xECECB8", VA = "0xECECB8")]
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
			[Address(RVA = "0xED04D4", Offset = "0xED04D4", VA = "0xED04D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0xED04DC", Offset = "0xED04DC", VA = "0xED04DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xED0478", Offset = "0xED0478", VA = "0xED0478")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xED04E8", Offset = "0xED04E8", VA = "0xED04E8")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xED056C", Offset = "0xED056C", VA = "0xED056C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xED073C", Offset = "0xED073C", VA = "0xED073C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xED0948", Offset = "0xED0948", VA = "0xED0948")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xED0C50", Offset = "0xED0C50", VA = "0xED0C50")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xED0F88", Offset = "0xED0F88", VA = "0xED0F88")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xED10F0", Offset = "0xED10F0", VA = "0xED10F0")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xED118C", Offset = "0xED118C", VA = "0xED118C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xED182C", Offset = "0xED182C", VA = "0xED182C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xED1884", Offset = "0xED1884", VA = "0xED1884")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xED1A4C", Offset = "0xED1A4C", VA = "0xED1A4C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xED1C94", Offset = "0xED1C94", VA = "0xED1C94")]
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
				[Address(RVA = "0xED21F4", Offset = "0xED21F4", VA = "0xED21F4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002AF")]
				[Address(RVA = "0xED22AC", Offset = "0xED22AC", VA = "0xED22AC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002C3")]
				[Address(RVA = "0xED268C", Offset = "0xED268C", VA = "0xED268C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xED21B4", Offset = "0xED21B4", VA = "0xED21B4")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xED2224", Offset = "0xED2224", VA = "0xED2224")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xED2268", Offset = "0xED2268", VA = "0xED2268")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xED22BC", Offset = "0xED22BC", VA = "0xED22BC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xED2390", Offset = "0xED2390", VA = "0xED2390")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xED2398", Offset = "0xED2398", VA = "0xED2398")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xED2464", Offset = "0xED2464", VA = "0xED2464")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xED24D0", Offset = "0xED24D0", VA = "0xED24D0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xED257C", Offset = "0xED257C", VA = "0xED257C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xED27F4", Offset = "0xED27F4", VA = "0xED27F4")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xED2820", Offset = "0xED2820", VA = "0xED2820")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xED284C", Offset = "0xED284C", VA = "0xED284C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xED2874", Offset = "0xED2874", VA = "0xED2874")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xED2934", Offset = "0xED2934", VA = "0xED2934")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xED2AB8", Offset = "0xED2AB8", VA = "0xED2AB8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xED2ADC", Offset = "0xED2ADC", VA = "0xED2ADC")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xED2BFC", Offset = "0xED2BFC", VA = "0xED2BFC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xED2C60", Offset = "0xED2C60", VA = "0xED2C60")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xED2DE0", Offset = "0xED2DE0", VA = "0xED2DE0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xED2F60", Offset = "0xED2F60", VA = "0xED2F60")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xED2FDC", Offset = "0xED2FDC", VA = "0xED2FDC")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xED29A8", Offset = "0xED29A8", VA = "0xED29A8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xED30F8", Offset = "0xED30F8", VA = "0xED30F8")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xED1F44", Offset = "0xED1F44", VA = "0xED1F44", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xED1F4C", Offset = "0xED1F4C", VA = "0xED1F4C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xED1F50", Offset = "0xED1F50", VA = "0xED1F50")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xED2098", Offset = "0xED2098", VA = "0xED2098")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xED21AC", Offset = "0xED21AC", VA = "0xED21AC")]
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
		[Address(RVA = "0xED3114", Offset = "0xED3114", VA = "0xED3114", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xED31BC", Offset = "0xED31BC", VA = "0xED31BC")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xED324C", Offset = "0xED324C", VA = "0xED324C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xED32F8", Offset = "0xED32F8", VA = "0xED32F8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xED3310", Offset = "0xED3310", VA = "0xED3310")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xED332C", Offset = "0xED332C", VA = "0xED332C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xED33D4", Offset = "0xED33D4", VA = "0xED33D4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xED33EC", Offset = "0xED33EC", VA = "0xED33EC")]
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
		[Address(RVA = "0xED3410", Offset = "0xED3410", VA = "0xED3410", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xED3484", Offset = "0xED3484", VA = "0xED3484")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xED354C", Offset = "0xED354C", VA = "0xED354C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xED3804", Offset = "0xED3804", VA = "0xED3804")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xED3950", Offset = "0xED3950", VA = "0xED3950")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xED3AD4", Offset = "0xED3AD4", VA = "0xED3AD4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xED3B34", Offset = "0xED3B34", VA = "0xED3B34")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xED3BCC", Offset = "0xED3BCC", VA = "0xED3BCC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xED3C74", Offset = "0xED3C74", VA = "0xED3C74", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xED3F28", Offset = "0xED3F28", VA = "0xED3F28")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xED3F88", Offset = "0xED3F88", VA = "0xED3F88")]
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
		[Address(RVA = "0xED40CC", Offset = "0xED40CC", VA = "0xED40CC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xED43F8", Offset = "0xED43F8", VA = "0xED43F8")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xED4570", Offset = "0xED4570", VA = "0xED4570")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xED4728", Offset = "0xED4728", VA = "0xED4728")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xED479C", Offset = "0xED479C", VA = "0xED479C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xED47F8", Offset = "0xED47F8", VA = "0xED47F8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xED4870", Offset = "0xED4870", VA = "0xED4870", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xED4EE8", Offset = "0xED4EE8", VA = "0xED4EE8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xED4F20", Offset = "0xED4F20", VA = "0xED4F20")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xED5184", Offset = "0xED5184", VA = "0xED5184")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xED54A4", Offset = "0xED54A4", VA = "0xED54A4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xED5584", Offset = "0xED5584", VA = "0xED5584")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xED5638", Offset = "0xED5638", VA = "0xED5638")]
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
			[Address(RVA = "0xED5F0C", Offset = "0xED5F0C", VA = "0xED5F0C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xED5F50", Offset = "0xED5F50", VA = "0xED5F50")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xED6030", Offset = "0xED6030", VA = "0xED6030")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xED605C", Offset = "0xED605C", VA = "0xED605C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xED6088", Offset = "0xED6088", VA = "0xED6088")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0xED60CC", Offset = "0xED60CC", VA = "0xED60CC")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0xED6110", Offset = "0xED6110", VA = "0xED6110")]
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
				[Address(RVA = "0xED6170", Offset = "0xED6170", VA = "0xED6170")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000303")]
				[Address(RVA = "0xED6260", Offset = "0xED6260", VA = "0xED6260")]
				set
				{
				}
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0xED62E4", Offset = "0xED62E4", VA = "0xED62E4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0xED6550", Offset = "0xED6550", VA = "0xED6550")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0xED680C", Offset = "0xED680C", VA = "0xED680C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0xED6A00", Offset = "0xED6A00", VA = "0xED6A00")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0xED6A28", Offset = "0xED6A28", VA = "0xED6A28")]
			public Bone()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0xED6A94", Offset = "0xED6A94", VA = "0xED6A94")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0xED6B14", Offset = "0xED6B14", VA = "0xED6B14")]
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
			[Address(RVA = "0xED6BA8", Offset = "0xED6BA8", VA = "0xED6BA8")]
			public Node()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0xED6BAC", Offset = "0xED6BAC", VA = "0xED6BAC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0xED6BD8", Offset = "0xED6BD8", VA = "0xED6BD8")]
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
			[Address(RVA = "0xED5B18", Offset = "0xED5B18", VA = "0xED5B18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xED5B20", Offset = "0xED5B20", VA = "0xED5B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xED5874", Offset = "0xED5874", VA = "0xED5874")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xED58E8", Offset = "0xED58E8", VA = "0xED58E8")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xED5A64", Offset = "0xED5A64", VA = "0xED5A64")]
		public void Update()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xED5AD4", Offset = "0xED5AD4", VA = "0xED5AD4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xED5AE0", Offset = "0xED5AE0", VA = "0xED5AE0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xED5AEC", Offset = "0xED5AEC", VA = "0xED5AEC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xED5AF4", Offset = "0xED5AF4", VA = "0xED5AF4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xED5B10", Offset = "0xED5B10", VA = "0xED5B10")]
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
		[Address(RVA = "0xED5B2C", Offset = "0xED5B2C", VA = "0xED5B2C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xED5B44", Offset = "0xED5B44", VA = "0xED5B44")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xED5C68", Offset = "0xED5C68", VA = "0xED5C68")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xED5D00", Offset = "0xED5D00", VA = "0xED5D00")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xED5EF4", Offset = "0xED5EF4", VA = "0xED5EF4")]
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
			[Address(RVA = "0xED6FD4", Offset = "0xED6FD4", VA = "0xED6FD4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xED7004", Offset = "0xED7004", VA = "0xED7004")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xED7C54", Offset = "0xED7C54", VA = "0xED7C54", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xED8194", Offset = "0xED8194", VA = "0xED8194", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xED6E9C", Offset = "0xED6E9C", VA = "0xED6E9C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xED7034", Offset = "0xED7034", VA = "0xED7034", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xED72C0", Offset = "0xED72C0", VA = "0xED72C0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xED7BAC", Offset = "0xED7BAC", VA = "0xED7BAC")]
		private void Solve()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xED7848", Offset = "0xED7848", VA = "0xED7848")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xED7C5C", Offset = "0xED7C5C", VA = "0xED7C5C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xED81F4", Offset = "0xED81F4", VA = "0xED81F4")]
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
		[Address(RVA = "0xED8314", Offset = "0xED8314", VA = "0xED8314", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xED86B8", Offset = "0xED86B8", VA = "0xED86B8")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xED8768", Offset = "0xED8768", VA = "0xED8768", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xED88E8", Offset = "0xED88E8", VA = "0xED88E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xED8A48", Offset = "0xED8A48", VA = "0xED8A48", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xED8A88", Offset = "0xED8A88", VA = "0xED8A88", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xED8AD8", Offset = "0xED8AD8", VA = "0xED8AD8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xED8E38", Offset = "0xED8E38", VA = "0xED8E38", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xED8E58", Offset = "0xED8E58", VA = "0xED8E58")]
		private void Solve()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xED8B30", Offset = "0xED8B30", VA = "0xED8B30")]
		private void Read()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xED8EB8", Offset = "0xED8EB8", VA = "0xED8EB8")]
		private void Write()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xED9030", Offset = "0xED9030", VA = "0xED9030")]
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
		[Address(RVA = "0xED9224", Offset = "0xED9224", VA = "0xED9224")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xED9294", Offset = "0xED9294", VA = "0xED9294", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xED9788", Offset = "0xED9788", VA = "0xED9788", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xED9E5C", Offset = "0xED9E5C", VA = "0xED9E5C")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xEDA4EC", Offset = "0xEDA4EC", VA = "0xEDA4EC")]
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
			[Address(RVA = "0xEDB4D4", Offset = "0xEDB4D4", VA = "0xEDB4D4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xEDA4F0", Offset = "0xEDA4F0", VA = "0xEDA4F0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xEDAAD0", Offset = "0xEDAAD0", VA = "0xEDAAD0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xEDAC00", Offset = "0xEDAC00", VA = "0xEDAC00", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xEDAC88", Offset = "0xEDAC88", VA = "0xEDAC88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xEDB19C", Offset = "0xEDB19C", VA = "0xEDB19C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xEDB4DC", Offset = "0xEDB4DC", VA = "0xEDB4DC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xEDA5C8", Offset = "0xEDA5C8", VA = "0xEDA5C8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xEDABB8", Offset = "0xEDABB8", VA = "0xEDABB8")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xEDB48C", Offset = "0xEDB48C", VA = "0xEDB48C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xEDA964", Offset = "0xEDA964", VA = "0xEDA964")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xEDBB88", Offset = "0xEDBB88", VA = "0xEDBB88")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xEDBBF0", Offset = "0xEDBBF0", VA = "0xEDBBF0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xEDBCC0", Offset = "0xEDBCC0", VA = "0xEDBCC0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xEDBD88", Offset = "0xEDBD88", VA = "0xEDBD88")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xEDAF14", Offset = "0xEDAF14", VA = "0xEDAF14")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xEDB058", Offset = "0xEDB058", VA = "0xEDB058")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xEDBE78", Offset = "0xEDBE78", VA = "0xEDBE78")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xEDB778", Offset = "0xEDB778", VA = "0xEDB778")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xEDABA8", Offset = "0xEDABA8", VA = "0xEDABA8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xEDC4E8", Offset = "0xEDC4E8", VA = "0xEDC4E8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xEDC038", Offset = "0xEDC038", VA = "0xEDC038")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xEDB5F8", Offset = "0xEDB5F8", VA = "0xEDB5F8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xEDB6C8", Offset = "0xEDB6C8", VA = "0xEDB6C8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xEDC5A0", Offset = "0xEDC5A0", VA = "0xEDC5A0")]
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
		[Address(RVA = "0xEDC638", Offset = "0xEDC638", VA = "0xEDC638", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xEDCCFC", Offset = "0xEDCCFC", VA = "0xEDCCFC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xEDCD88", Offset = "0xEDCD88", VA = "0xEDCD88", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xEDCE1C", Offset = "0xEDCE1C", VA = "0xEDCE1C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xEDCF14", Offset = "0xEDCF14", VA = "0xEDCF14")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xEDCFA4", Offset = "0xEDCFA4", VA = "0xEDCFA4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xEDD3A4", Offset = "0xEDD3A4", VA = "0xEDD3A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xEDD59C", Offset = "0xEDD59C", VA = "0xEDD59C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xEDD444", Offset = "0xEDD444", VA = "0xEDD444")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xEDD17C", Offset = "0xEDD17C", VA = "0xEDD17C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xEDD620", Offset = "0xEDD620", VA = "0xEDD620")]
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
		[Address(RVA = "0xEDD69C", Offset = "0xEDD69C", VA = "0xEDD69C")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xEDD778", Offset = "0xEDD778", VA = "0xEDD778")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xEDD7C0", Offset = "0xEDD7C0", VA = "0xEDD7C0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xED10A0", Offset = "0xED10A0", VA = "0xED10A0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xED0F14", Offset = "0xED0F14", VA = "0xED0F14")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xEDD8D4", Offset = "0xEDD8D4", VA = "0xEDD8D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xEDDA74", Offset = "0xEDDA74", VA = "0xEDDA74", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xEDDBD0", Offset = "0xEDDBD0", VA = "0xEDDBD0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xEDDDD0", Offset = "0xEDDDD0", VA = "0xEDDDD0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xEDDEA0", Offset = "0xEDDEA0", VA = "0xEDDEA0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xEDDF7C", Offset = "0xEDDF7C", VA = "0xEDDF7C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xEDE0D8", Offset = "0xEDE0D8", VA = "0xEDE0D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xEDE270", Offset = "0xEDE270", VA = "0xEDE270", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xEDE49C", Offset = "0xEDE49C", VA = "0xEDE49C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xEDE76C", Offset = "0xEDE76C", VA = "0xEDE76C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xEDE7A4", Offset = "0xEDE7A4", VA = "0xEDE7A4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xEDE87C", Offset = "0xEDE87C", VA = "0xEDE87C")]
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
			[Address(RVA = "0xEDE9D0", Offset = "0xEDE9D0", VA = "0xEDE9D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0xEDEB10", Offset = "0xEDEB10", VA = "0xEDEB10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xEDEB18", Offset = "0xEDEB18", VA = "0xEDEB18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0xEDEB20", Offset = "0xEDEB20", VA = "0xEDEB20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0xEDEB28", Offset = "0xEDEB28", VA = "0xEDEB28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0xEDEB30", Offset = "0xEDEB30", VA = "0xEDEB30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0xEDEB38", Offset = "0xEDEB38", VA = "0xEDEB38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0xEDEB40", Offset = "0xEDEB40", VA = "0xEDEB40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0xEDEB48", Offset = "0xEDEB48", VA = "0xEDEB48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0xEDEB50", Offset = "0xEDEB50", VA = "0xEDEB50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xEDEB7C", Offset = "0xEDEB7C", VA = "0xEDEB7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xEDEBA8", Offset = "0xEDEBA8", VA = "0xEDEBA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xEDEBD4", Offset = "0xEDEBD4", VA = "0xEDEBD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xEDEC00", Offset = "0xEDEC00", VA = "0xEDEC00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xEDEC28", Offset = "0xEDEC28", VA = "0xEDEC28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xEDEC54", Offset = "0xEDEC54", VA = "0xEDEC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0xEDEC80", Offset = "0xEDEC80", VA = "0xEDEC80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xEDECAC", Offset = "0xEDECAC", VA = "0xEDECAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xEE0E90", Offset = "0xEE0E90", VA = "0xEE0E90")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xEE0E9C", Offset = "0xEE0E9C", VA = "0xEE0E9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xEDECD4", Offset = "0xEDECD4", VA = "0xEDECD4")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xEDEDD4", Offset = "0xEDEDD4", VA = "0xEDEDD4")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xEDED24", Offset = "0xEDED24", VA = "0xEDED24")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xEDEE4C", Offset = "0xEDEE4C", VA = "0xEDEE4C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xEDE9D8", Offset = "0xEDE9D8", VA = "0xEDE9D8")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xEDEF14", Offset = "0xEDEF14", VA = "0xEDEF14")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xEDEFC4", Offset = "0xEDEFC4", VA = "0xEDEFC4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xEDF070", Offset = "0xEDF070", VA = "0xEDF070")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xEDF11C", Offset = "0xEDF11C", VA = "0xEDF11C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xEDF124", Offset = "0xEDF124", VA = "0xEDF124")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xEDF14C", Offset = "0xEDF14C", VA = "0xEDF14C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xEDF20C", Offset = "0xEDF20C", VA = "0xEDF20C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xEDF3A0", Offset = "0xEDF3A0", VA = "0xEDF3A0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xEE078C", Offset = "0xEE078C", VA = "0xEE078C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xEE0D3C", Offset = "0xEE0D3C", VA = "0xEE0D3C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xEE0D98", Offset = "0xEE0D98", VA = "0xEE0D98")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xEE0BDC", Offset = "0xEE0BDC", VA = "0xEE0BDC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xEE0C8C", Offset = "0xEE0C8C", VA = "0xEE0C8C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xEE0EA8", Offset = "0xEE0EA8", VA = "0xEE0EA8")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xEE0F6C", Offset = "0xEE0F6C", VA = "0xEE0F6C", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xEE1038", Offset = "0xEE1038", VA = "0xEE1038")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xEE1154", Offset = "0xEE1154", VA = "0xEE1154")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xEE12E4", Offset = "0xEE12E4", VA = "0xEE12E4")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xEE145C", Offset = "0xEE145C", VA = "0xEE145C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xEE16B8", Offset = "0xEE16B8", VA = "0xEE16B8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xEE1730", Offset = "0xEE1730", VA = "0xEE1730")]
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
			[Address(RVA = "0xEE1FB8", Offset = "0xEE1FB8", VA = "0xEE1FB8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xEE1FC0", Offset = "0xEE1FC0", VA = "0xEE1FC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0xEE1FC8", Offset = "0xEE1FC8", VA = "0xEE1FC8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xEE1FD8", Offset = "0xEE1FD8", VA = "0xEE1FD8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xED9E14", Offset = "0xED9E14", VA = "0xED9E14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xEE173C", Offset = "0xEE173C", VA = "0xEE173C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xEE18E4", Offset = "0xEE18E4", VA = "0xEE18E4")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xEE1A30", Offset = "0xEE1A30", VA = "0xEE1A30", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xEE1A8C", Offset = "0xEE1A8C", VA = "0xEE1A8C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xEE1AFC", Offset = "0xEE1AFC", VA = "0xEE1AFC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xEE1ED4", Offset = "0xEE1ED4", VA = "0xEE1ED4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xEE1EDC", Offset = "0xEE1EDC", VA = "0xEE1EDC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xEE1FD0", Offset = "0xEE1FD0", VA = "0xEE1FD0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xEE1FD4", Offset = "0xEE1FD4", VA = "0xEE1FD4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xED9300", Offset = "0xED9300", VA = "0xED9300")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xED9A68", Offset = "0xED9A68", VA = "0xED9A68")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xEE2094", Offset = "0xEE2094", VA = "0xEE2094")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xED8294", Offset = "0xED8294", VA = "0xED8294")]
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
		[Address(RVA = "0xEE2328", Offset = "0xEE2328", VA = "0xEE2328", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xEE26CC", Offset = "0xEE26CC", VA = "0xEE26CC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xEE2780", Offset = "0xEE2780", VA = "0xEE2780", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xEE2900", Offset = "0xEE2900", VA = "0xEE2900", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xEE2A60", Offset = "0xEE2A60", VA = "0xEE2A60", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xEE2AB0", Offset = "0xEE2AB0", VA = "0xEE2AB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xEE2B10", Offset = "0xEE2B10", VA = "0xEE2B10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xEE2E6C", Offset = "0xEE2E6C", VA = "0xEE2E6C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xEE2E8C", Offset = "0xEE2E8C", VA = "0xEE2E8C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xEE2B68", Offset = "0xEE2B68", VA = "0xEE2B68")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xEE2F10", Offset = "0xEE2F10", VA = "0xEE2F10")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xEE32F0", Offset = "0xEE32F0", VA = "0xEE32F0")]
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
			[Address(RVA = "0xEE4A0C", Offset = "0xEE4A0C", VA = "0xEE4A0C")]
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
			[Address(RVA = "0xEE49F0", Offset = "0xEE49F0", VA = "0xEE49F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xEE35CC", Offset = "0xEE35CC", VA = "0xEE35CC")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xEE3610", Offset = "0xEE3610", VA = "0xEE3610")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xEE367C", Offset = "0xEE367C", VA = "0xEE367C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xEE3BC4", Offset = "0xEE3BC4", VA = "0xEE3BC4", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xEE46E0", Offset = "0xEE46E0", VA = "0xEE46E0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xEE4788", Offset = "0xEE4788", VA = "0xEE4788")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xEE4958", Offset = "0xEE4958", VA = "0xEE4958")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xEE39D8", Offset = "0xEE39D8", VA = "0xEE39D8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xEE3C80", Offset = "0xEE3C80", VA = "0xEE3C80")]
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
				[Address(RVA = "0xEE68A0", Offset = "0xEE68A0", VA = "0xEE68A0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xEE6F50", Offset = "0xEE6F50", VA = "0xEE6F50")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xEE59BC", Offset = "0xEE59BC", VA = "0xEE59BC")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xEE5CB0", Offset = "0xEE5CB0", VA = "0xEE5CB0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xEE6BE8", Offset = "0xEE6BE8", VA = "0xEE6BE8")]
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
			[Address(RVA = "0xEE5140", Offset = "0xEE5140", VA = "0xEE5140")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xEE52E8", Offset = "0xEE52E8", VA = "0xEE52E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xEE520C", Offset = "0xEE520C", VA = "0xEE520C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xEE530C", Offset = "0xEE530C", VA = "0xEE530C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xEE521C", Offset = "0xEE521C", VA = "0xEE521C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xEE5378", Offset = "0xEE5378", VA = "0xEE5378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xEE4BA8", Offset = "0xEE4BA8", VA = "0xEE4BA8")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xEE4BC4", Offset = "0xEE4BC4", VA = "0xEE4BC4")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xEE4BF0", Offset = "0xEE4BF0", VA = "0xEE4BF0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xEE4C28", Offset = "0xEE4C28", VA = "0xEE4C28")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xEE4C70", Offset = "0xEE4C70", VA = "0xEE4C70")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xEE4CC8", Offset = "0xEE4CC8", VA = "0xEE4CC8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xEE4D38", Offset = "0xEE4D38", VA = "0xEE4D38", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xEE4E50", Offset = "0xEE4E50", VA = "0xEE4E50", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xEE4F7C", Offset = "0xEE4F7C", VA = "0xEE4F7C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xEE539C", Offset = "0xEE539C", VA = "0xEE539C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xEE55F0", Offset = "0xEE55F0", VA = "0xEE55F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xEE5750", Offset = "0xEE5750", VA = "0xEE5750")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xEE59EC", Offset = "0xEE59EC", VA = "0xEE59EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xEE5D9C", Offset = "0xEE5D9C", VA = "0xEE5D9C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xEE5E60", Offset = "0xEE5E60", VA = "0xEE5E60")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xEE607C", Offset = "0xEE607C", VA = "0xEE607C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xEE63C4", Offset = "0xEE63C4", VA = "0xEE63C4")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xEE68D0", Offset = "0xEE68D0", VA = "0xEE68D0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xEE5818", Offset = "0xEE5818", VA = "0xEE5818")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xEE6CF0", Offset = "0xEE6CF0", VA = "0xEE6CF0")]
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
			[Address(RVA = "0xEE8278", Offset = "0xEE8278", VA = "0xEE8278")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xEE8B20", Offset = "0xEE8B20", VA = "0xEE8B20")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xEE364C", Offset = "0xEE364C", VA = "0xEE364C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xEE8BBC", Offset = "0xEE8BBC", VA = "0xEE8BBC")]
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
		[Address(RVA = "0xEE6F58", Offset = "0xEE6F58", VA = "0xEE6F58")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xEE70EC", Offset = "0xEE70EC", VA = "0xEE70EC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xEE726C", Offset = "0xEE726C", VA = "0xEE726C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xEE7278", Offset = "0xEE7278", VA = "0xEE7278")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xEE7294", Offset = "0xEE7294", VA = "0xEE7294")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xEE72A0", Offset = "0xEE72A0", VA = "0xEE72A0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xEE72A8", Offset = "0xEE72A8", VA = "0xEE72A8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xEE73B8", Offset = "0xEE73B8", VA = "0xEE73B8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xEE74B0", Offset = "0xEE74B0", VA = "0xEE74B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xEE74F0", Offset = "0xEE74F0", VA = "0xEE74F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xEE7540", Offset = "0xEE7540", VA = "0xEE7540", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xEE7914", Offset = "0xEE7914", VA = "0xEE7914")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xEE7990", Offset = "0xEE7990", VA = "0xEE7990")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xEE7E84", Offset = "0xEE7E84", VA = "0xEE7E84")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xEE7FDC", Offset = "0xEE7FDC", VA = "0xEE7FDC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xEE8188", Offset = "0xEE8188", VA = "0xEE8188")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xEE8108", Offset = "0xEE8108", VA = "0xEE8108")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xEE8368", Offset = "0xEE8368", VA = "0xEE8368", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xEE8BB0", Offset = "0xEE8BB0", VA = "0xEE8BB0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xEE8BB4", Offset = "0xEE8BB4", VA = "0xEE8BB4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xEE8BB8", Offset = "0xEE8BB8", VA = "0xEE8BB8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xEE8960", Offset = "0xEE8960", VA = "0xEE8960")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xEE480C", Offset = "0xEE480C", VA = "0xEE480C")]
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
				[Address(RVA = "0xEF0134", Offset = "0xEF0134", VA = "0xEF0134")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000417")]
				[Address(RVA = "0xEF0140", Offset = "0xEF0140", VA = "0xEF0140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0xEF014C", Offset = "0xEF014C", VA = "0xEF014C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000419")]
				[Address(RVA = "0xEF0158", Offset = "0xEF0158", VA = "0xEF0158")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600041A")]
				[Address(RVA = "0xEF0164", Offset = "0xEF0164", VA = "0xEF0164")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0xEF018C", Offset = "0xEF018C", VA = "0xEF018C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0xEF01C0", Offset = "0xEF01C0", VA = "0xEF01C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0xEF0200", Offset = "0xEF0200", VA = "0xEF0200")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0xEF0240", Offset = "0xEF0240", VA = "0xEF0240", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0xEF0AE0", Offset = "0xEF0AE0", VA = "0xEF0AE0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0xEF0D8C", Offset = "0xEF0D8C", VA = "0xEF0D8C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0xEF0DB0", Offset = "0xEF0DB0", VA = "0xEF0DB0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0xEEE574", Offset = "0xEEE574", VA = "0xEEE574")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0xEF17E4", Offset = "0xEF17E4", VA = "0xEF17E4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0xEF183C", Offset = "0xEF183C", VA = "0xEF183C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0xEF1100", Offset = "0xEF1100", VA = "0xEF1100")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0xEF1180", Offset = "0xEF1180", VA = "0xEF1180")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0xEF1A48", Offset = "0xEF1A48", VA = "0xEF1A48")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0xEEFE8C", Offset = "0xEEFE8C", VA = "0xEEFE8C")]
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
				[Address(RVA = "0xEF1C04", Offset = "0xEF1C04", VA = "0xEF1C04")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600042F")]
				[Address(RVA = "0xEF1C0C", Offset = "0xEF1C0C", VA = "0xEF1C0C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0xEF1C14", Offset = "0xEF1C14", VA = "0xEF1C14")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000431")]
				[Address(RVA = "0xEF1C1C", Offset = "0xEF1C1C", VA = "0xEF1C1C")]
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
			[Address(RVA = "0xEF1C24", Offset = "0xEF1C24", VA = "0xEF1C24")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0xEE3230", Offset = "0xEE3230", VA = "0xEE3230")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xEF1C2C", Offset = "0xEF1C2C", VA = "0xEF1C2C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0xEF1CB4", Offset = "0xEF1CB4", VA = "0xEF1CB4")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0xEF1D4C", Offset = "0xEF1D4C", VA = "0xEF1D4C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0xEEE44C", Offset = "0xEEE44C", VA = "0xEEE44C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0xEF167C", Offset = "0xEF167C", VA = "0xEF167C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0xEF1D94", Offset = "0xEF1D94", VA = "0xEF1D94")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xEF1EB8", Offset = "0xEF1EB8", VA = "0xEF1EB8")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xEF1B60", Offset = "0xEF1B60", VA = "0xEF1B60")]
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
				[Address(RVA = "0xEF1ECC", Offset = "0xEF1ECC", VA = "0xEF1ECC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x600043D")]
				[Address(RVA = "0xEF1EE0", Offset = "0xEF1EE0", VA = "0xEF1EE0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043E")]
				[Address(RVA = "0xEF1EE8", Offset = "0xEF1EE8", VA = "0xEF1EE8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0xEF1EF0", Offset = "0xEF1EF0", VA = "0xEF1EF0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xEF20B4", Offset = "0xEF20B4", VA = "0xEF20B4")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0xEF20FC", Offset = "0xEF20FC", VA = "0xEF20FC")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0xEF2320", Offset = "0xEF2320", VA = "0xEF2320")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0xEF2528", Offset = "0xEF2528", VA = "0xEF2528")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0xEF270C", Offset = "0xEF270C", VA = "0xEF270C")]
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
				[Address(RVA = "0xEF2880", Offset = "0xEF2880", VA = "0xEF2880")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000446")]
				[Address(RVA = "0xEF288C", Offset = "0xEF288C", VA = "0xEF288C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0xEF2898", Offset = "0xEF2898", VA = "0xEF2898")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000448")]
				[Address(RVA = "0xEF28A4", Offset = "0xEF28A4", VA = "0xEF28A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0xEF28B0", Offset = "0xEF28B0", VA = "0xEF28B0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044A")]
				[Address(RVA = "0xEF28B8", Offset = "0xEF28B8", VA = "0xEF28B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0xEF28C4", Offset = "0xEF28C4", VA = "0xEF28C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0xEF28EC", Offset = "0xEF28EC", VA = "0xEF28EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0xEF2918", Offset = "0xEF2918", VA = "0xEF2918")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0xEF2944", Offset = "0xEF2944", VA = "0xEF2944")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0xEEE418", Offset = "0xEEE418", VA = "0xEEE418")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0xEF2970", Offset = "0xEF2970", VA = "0xEF2970")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000451")]
				[Address(RVA = "0xEF297C", Offset = "0xEF297C", VA = "0xEF297C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0xEF2988", Offset = "0xEF2988", VA = "0xEF2988", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0xEF2F38", Offset = "0xEF2F38", VA = "0xEF2F38", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0xEF36A8", Offset = "0xEF36A8", VA = "0xEF36A8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0xEF3658", Offset = "0xEF3658", VA = "0xEF3658")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0xEF340C", Offset = "0xEF340C", VA = "0xEF340C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0xEE3088", Offset = "0xEE3088", VA = "0xEE3088")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0xEF3F60", Offset = "0xEF3F60", VA = "0xEF3F60")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0xEF3B84", Offset = "0xEF3B84", VA = "0xEF3B84")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0xEF43B8", Offset = "0xEF43B8", VA = "0xEF43B8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0xEF45C0", Offset = "0xEF45C0", VA = "0xEF45C0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0xEE34E4", Offset = "0xEE34E4", VA = "0xEE34E4")]
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
				[Address(RVA = "0xEF46A0", Offset = "0xEF46A0", VA = "0xEF46A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045E")]
				[Address(RVA = "0xEF46AC", Offset = "0xEF46AC", VA = "0xEF46AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0xEF4A88", Offset = "0xEF4A88", VA = "0xEF4A88")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0xEF4ABC", Offset = "0xEF4ABC", VA = "0xEF4ABC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0xEF4AF4", Offset = "0xEF4AF4", VA = "0xEF4AF4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0xEF4B28", Offset = "0xEF4B28", VA = "0xEF4B28")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xEECD34", Offset = "0xEECD34", VA = "0xEECD34")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xEEA820", Offset = "0xEEA820", VA = "0xEEA820")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xEE9C94", Offset = "0xEE9C94", VA = "0xEE9C94")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xEE9BDC", Offset = "0xEE9BDC", VA = "0xEE9BDC")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xEED048", Offset = "0xEED048", VA = "0xEED048")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xEF46B8", Offset = "0xEF46B8", VA = "0xEF46B8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0xEF486C", Offset = "0xEF486C", VA = "0xEF486C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xEF48D8", Offset = "0xEF48D8", VA = "0xEF48D8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0xEF0024", Offset = "0xEF0024", VA = "0xEF0024")]
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
				[Address(RVA = "0xEF4B60", Offset = "0xEF4B60", VA = "0xEF4B60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0xEF4B94", Offset = "0xEF4B94", VA = "0xEF4B94")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0xEF4BC8", Offset = "0xEF4BC8", VA = "0xEF4BC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0xEF4C10", Offset = "0xEF4C10", VA = "0xEF4C10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0xEF4C44", Offset = "0xEF4C44", VA = "0xEF4C44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0xEF4C78", Offset = "0xEF4C78", VA = "0xEF4C78")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0xEF4C8C", Offset = "0xEF4C8C", VA = "0xEF4C8C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000473")]
				[Address(RVA = "0xEF4CA0", Offset = "0xEF4CA0", VA = "0xEF4CA0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000474")]
				[Address(RVA = "0xEF4CB4", Offset = "0xEF4CB4", VA = "0xEF4CB4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0xEF4CC8", Offset = "0xEF4CC8", VA = "0xEF4CC8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0xEF59F8", Offset = "0xEF59F8", VA = "0xEF59F8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0xEF5BE0", Offset = "0xEF5BE0", VA = "0xEF5BE0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0xEF6374", Offset = "0xEF6374", VA = "0xEF6374")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0xEF69B0", Offset = "0xEF69B0", VA = "0xEF69B0")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0xEF72FC", Offset = "0xEF72FC", VA = "0xEF72FC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0xEF7AA4", Offset = "0xEF7AA4", VA = "0xEF7AA4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0xEF84E4", Offset = "0xEF84E4", VA = "0xEF84E4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0xEF86B4", Offset = "0xEF86B4", VA = "0xEF86B4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0xEF65B8", Offset = "0xEF65B8", VA = "0xEF65B8")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0xEF77CC", Offset = "0xEF77CC", VA = "0xEF77CC")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0xEF6EEC", Offset = "0xEF6EEC", VA = "0xEF6EEC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0xEF8788", Offset = "0xEF8788", VA = "0xEF8788")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0xEF78A8", Offset = "0xEF78A8", VA = "0xEF78A8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0xEF755C", Offset = "0xEF755C", VA = "0xEF755C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0xEF8BA0", Offset = "0xEF8BA0", VA = "0xEF8BA0")]
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
			[Address(RVA = "0xEF5968", Offset = "0xEF5968", VA = "0xEF5968")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0xEF59D8", Offset = "0xEF59D8", VA = "0xEF59D8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0xEF8CBC", Offset = "0xEF8CBC", VA = "0xEF8CBC")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0xEF8EBC", Offset = "0xEF8EBC", VA = "0xEF8EBC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0xEF8A30", Offset = "0xEF8A30", VA = "0xEF8A30")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0xEF901C", Offset = "0xEF901C", VA = "0xEF901C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0xEF91C4", Offset = "0xEF91C4", VA = "0xEF91C4")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0xEF934C", Offset = "0xEF934C", VA = "0xEF934C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0xEF8100", Offset = "0xEF8100", VA = "0xEF8100")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0xEF93F0", Offset = "0xEF93F0", VA = "0xEF93F0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0xEF7D34", Offset = "0xEF7D34", VA = "0xEF7D34")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0xEF9548", Offset = "0xEF9548", VA = "0xEF9548")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0xEF965C", Offset = "0xEF965C", VA = "0xEF965C")]
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
			[Address(RVA = "0xEEFB9C", Offset = "0xEEFB9C", VA = "0xEEFB9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xEEFBA4", Offset = "0xEEFBA4", VA = "0xEEFBA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xEE8BC4", Offset = "0xEE8BC4", VA = "0xEE8BC4")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xEE9030", Offset = "0xEE9030", VA = "0xEE9030")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xEE8EC4", Offset = "0xEE8EC4", VA = "0xEE8EC4")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xEE9860", Offset = "0xEE9860", VA = "0xEE9860")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xEE99A4", Offset = "0xEE99A4", VA = "0xEE99A4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xEE99E4", Offset = "0xEE99E4", VA = "0xEE99E4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xEE9B08", Offset = "0xEE9B08", VA = "0xEE9B08")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xEEA05C", Offset = "0xEEA05C", VA = "0xEEA05C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEEAA04", Offset = "0xEEAA04", VA = "0xEEAA04", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xEEAB58", Offset = "0xEEAB58", VA = "0xEEAB58", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xEEAD44", Offset = "0xEEAD44", VA = "0xEEAD44", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xEEADB4", Offset = "0xEEADB4", VA = "0xEEADB4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xEEAE24", Offset = "0xEEAE24", VA = "0xEEAE24", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xEEB02C", Offset = "0xEEB02C", VA = "0xEEB02C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xEE9320", Offset = "0xEE9320", VA = "0xEE9320")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xEE9404", Offset = "0xEE9404", VA = "0xEE9404")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xEE974C", Offset = "0xEE974C", VA = "0xEE974C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xEEA16C", Offset = "0xEEA16C", VA = "0xEEA16C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xEEB29C", Offset = "0xEEB29C", VA = "0xEEB29C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xEEB2D8", Offset = "0xEEB2D8", VA = "0xEEB2D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xEEC86C", Offset = "0xEEC86C", VA = "0xEEC86C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xEEA2BC", Offset = "0xEEA2BC", VA = "0xEEA2BC")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xEEB6E0", Offset = "0xEEB6E0", VA = "0xEEB6E0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xEECCC0", Offset = "0xEECCC0", VA = "0xEECCC0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xEECCFC", Offset = "0xEECCFC", VA = "0xEECCFC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xEEC730", Offset = "0xEEC730", VA = "0xEEC730")]
		private void Write()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xEEFB58", Offset = "0xEEFB58", VA = "0xEEFB58")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xEEFBAC", Offset = "0xEEFBAC", VA = "0xEEFBAC")]
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
		[Address(RVA = "0xEF9810", Offset = "0xEF9810", VA = "0xEF9810")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xEF9C54", Offset = "0xEF9C54", VA = "0xEF9C54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xEFA044", Offset = "0xEFA044", VA = "0xEFA044")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xEFA0BC", Offset = "0xEFA0BC", VA = "0xEFA0BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xEFA134", Offset = "0xEFA134", VA = "0xEFA134")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xEFA26C", Offset = "0xEFA26C", VA = "0xEFA26C")]
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
			[Address(RVA = "0xEFA30C", Offset = "0xEFA30C", VA = "0xEFA30C")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xEFA314", Offset = "0xEFA314", VA = "0xEFA314")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xEFA31C", Offset = "0xEFA31C", VA = "0xEFA31C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xEFA324", Offset = "0xEFA324", VA = "0xEFA324")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0xEFA330", Offset = "0xEFA330", VA = "0xEFA330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xEFA338", Offset = "0xEFA338", VA = "0xEFA338")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0xEFA340", Offset = "0xEFA340", VA = "0xEFA340")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xEFC974", Offset = "0xEFC974", VA = "0xEFC974")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xEFA3A0", Offset = "0xEFA3A0", VA = "0xEFA3A0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xEFA43C", Offset = "0xEFA43C", VA = "0xEFA43C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xEFA4FC", Offset = "0xEFA4FC", VA = "0xEFA4FC")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xEFA668", Offset = "0xEFA668", VA = "0xEFA668")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xEFAA44", Offset = "0xEFAA44", VA = "0xEFAA44")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xEFAB64", Offset = "0xEFAB64", VA = "0xEFAB64")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xEFABB8", Offset = "0xEFABB8", VA = "0xEFABB8")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xEFB718", Offset = "0xEFB718", VA = "0xEFB718")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xEFC1CC", Offset = "0xEFC1CC", VA = "0xEFC1CC")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xEFC3EC", Offset = "0xEFC3EC", VA = "0xEFC3EC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xEFC810", Offset = "0xEFC810", VA = "0xEFC810")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xEFCB74", Offset = "0xEFCB74", VA = "0xEFCB74")]
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
		[Address(RVA = "0xEFCDB0", Offset = "0xEFCDB0", VA = "0xEFCDB0")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xEFCECC", Offset = "0xEFCECC", VA = "0xEFCECC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xEFCF64", Offset = "0xEFCF64", VA = "0xEFCF64")]
		public void Update()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xEFD16C", Offset = "0xEFD16C", VA = "0xEFD16C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xEFD214", Offset = "0xEFD214", VA = "0xEFD214")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xEFD2C0", Offset = "0xEFD2C0", VA = "0xEFD2C0")]
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
			[Address(RVA = "0xEFC9A4", Offset = "0xEFC9A4", VA = "0xEFC9A4")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xEFE264", Offset = "0xEFE264", VA = "0xEFE264")]
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
			[Address(RVA = "0xEFE16C", Offset = "0xEFE16C", VA = "0xEFE16C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xEFE26C", Offset = "0xEFE26C", VA = "0xEFE26C")]
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
			[Address(RVA = "0xEFE090", Offset = "0xEFE090", VA = "0xEFE090")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xEFE274", Offset = "0xEFE274", VA = "0xEFE274")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xEFE324", Offset = "0xEFE324", VA = "0xEFE324")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xEFE3FC", Offset = "0xEFE3FC", VA = "0xEFE3FC")]
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
			[Address(RVA = "0xEFD994", Offset = "0xEFD994", VA = "0xEFD994")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xEFE410", Offset = "0xEFE410", VA = "0xEFE410")]
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
			[Address(RVA = "0xEFDF9C", Offset = "0xEFDF9C", VA = "0xEFDF9C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xEFE418", Offset = "0xEFE418", VA = "0xEFE418")]
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
			[Address(RVA = "0xEFD4F4", Offset = "0xEFD4F4", VA = "0xEFD4F4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xEFD4FC", Offset = "0xEFD4FC", VA = "0xEFD4FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xEFD504", Offset = "0xEFD504", VA = "0xEFD504")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xEFD50C", Offset = "0xEFD50C", VA = "0xEFD50C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xEFD6CC", Offset = "0xEFD6CC", VA = "0xEFD6CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xEFCA68", Offset = "0xEFCA68", VA = "0xEFCA68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xEFD2D4", Offset = "0xEFD2D4", VA = "0xEFD2D4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xEFD318", Offset = "0xEFD318", VA = "0xEFD318")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xEFD35C", Offset = "0xEFD35C", VA = "0xEFD35C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xEFD3A0", Offset = "0xEFD3A0", VA = "0xEFD3A0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xEFD3E4", Offset = "0xEFD3E4", VA = "0xEFD3E4")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xEFD428", Offset = "0xEFD428", VA = "0xEFD428")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xEFD46C", Offset = "0xEFD46C", VA = "0xEFD46C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xEFD4B0", Offset = "0xEFD4B0", VA = "0xEFD4B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xEFD514", Offset = "0xEFD514", VA = "0xEFD514")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xEFD74C", Offset = "0xEFD74C", VA = "0xEFD74C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xEFB1D8", Offset = "0xEFB1D8", VA = "0xEFB1D8")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xEFD8C4", Offset = "0xEFD8C4", VA = "0xEFD8C4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xEFB094", Offset = "0xEFB094", VA = "0xEFB094")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xEFB1D0", Offset = "0xEFB1D0", VA = "0xEFB1D0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xEFBDC4", Offset = "0xEFBDC4", VA = "0xEFBDC4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xEFC604", Offset = "0xEFC604", VA = "0xEFC604")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xEFDFCC", Offset = "0xEFDFCC", VA = "0xEFDFCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xEFD9B0", Offset = "0xEFD9B0", VA = "0xEFD9B0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xEFD8CC", Offset = "0xEFD8CC", VA = "0xEFD8CC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xEFDF40", Offset = "0xEFDF40", VA = "0xEFDF40")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xEFDFD0", Offset = "0xEFDFD0", VA = "0xEFDFD0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xEFE02C", Offset = "0xEFE02C", VA = "0xEFE02C")]
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
			[Address(RVA = "0xEFE648", Offset = "0xEFE648", VA = "0xEFE648")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xF000F0", Offset = "0xF000F0", VA = "0xF000F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xF000F8", Offset = "0xF000F8", VA = "0xF000F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xF00100", Offset = "0xF00100", VA = "0xF00100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xF00108", Offset = "0xF00108", VA = "0xF00108")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xEFE428", Offset = "0xEFE428", VA = "0xEFE428")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xEFE46C", Offset = "0xEFE46C", VA = "0xEFE46C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xEFE4B0", Offset = "0xEFE4B0", VA = "0xEFE4B0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xEFE4F4", Offset = "0xEFE4F4", VA = "0xEFE4F4")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xEFE538", Offset = "0xEFE538", VA = "0xEFE538")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xEFE57C", Offset = "0xEFE57C", VA = "0xEFE57C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xEFE5C0", Offset = "0xEFE5C0", VA = "0xEFE5C0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xEFE604", Offset = "0xEFE604", VA = "0xEFE604")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xEFE7C0", Offset = "0xEFE7C0", VA = "0xEFE7C0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xEFE878", Offset = "0xEFE878", VA = "0xEFE878")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xEFE930", Offset = "0xEFE930", VA = "0xEFE930")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xEFE9C8", Offset = "0xEFE9C8", VA = "0xEFE9C8")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xEFEAAC", Offset = "0xEFEAAC", VA = "0xEFEAAC")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xEFEBA4", Offset = "0xEFEBA4", VA = "0xEFEBA4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xEFEC28", Offset = "0xEFEC28", VA = "0xEFEC28")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xEFECAC", Offset = "0xEFECAC", VA = "0xEFECAC")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xEFED30", Offset = "0xEFED30", VA = "0xEFED30")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xEFED98", Offset = "0xEFED98", VA = "0xEFED98")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xEFEE00", Offset = "0xEFEE00", VA = "0xEFEE00")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xEFEE5C", Offset = "0xEFEE5C", VA = "0xEFEE5C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xEFEEDC", Offset = "0xEFEEDC", VA = "0xEFEEDC")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xEFEF84", Offset = "0xEFEF84", VA = "0xEFEF84")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xEFF054", Offset = "0xEFF054", VA = "0xEFF054")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xEFF2E4", Offset = "0xEFF2E4", VA = "0xEFF2E4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xEFF4B8", Offset = "0xEFF4B8", VA = "0xEFF4B8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xEFF728", Offset = "0xEFF728", VA = "0xEFF728")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xEFF9B4", Offset = "0xEFF9B4", VA = "0xEFF9B4")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xEFF9EC", Offset = "0xEFF9EC", VA = "0xEFF9EC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xEFFA4C", Offset = "0xEFFA4C", VA = "0xEFFA4C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xEFFB78", Offset = "0xEFFB78", VA = "0xEFFB78")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xEFFD5C", Offset = "0xEFFD5C", VA = "0xEFFD5C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xEFFFD0", Offset = "0xEFFFD0", VA = "0xEFFFD0")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xEFF810", Offset = "0xEFF810", VA = "0xEFF810")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xF00110", Offset = "0xF00110", VA = "0xF00110")]
		public void Start()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xF00A34", Offset = "0xF00A34", VA = "0xF00A34")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xF00A54", Offset = "0xF00A54", VA = "0xF00A54")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xF00A70", Offset = "0xF00A70", VA = "0xF00A70")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xF00A8C", Offset = "0xF00A8C", VA = "0xF00A8C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xF00AE0", Offset = "0xF00AE0", VA = "0xF00AE0")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xF00C64", Offset = "0xF00C64", VA = "0xF00C64")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xF00D60", Offset = "0xF00D60", VA = "0xF00D60")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xF010BC", Offset = "0xF010BC", VA = "0xF010BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xF011D4", Offset = "0xF011D4", VA = "0xF011D4")]
		public void Update()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xF014BC", Offset = "0xF014BC", VA = "0xF014BC")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xF007D4", Offset = "0xF007D4", VA = "0xF007D4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xF015EC", Offset = "0xF015EC", VA = "0xF015EC")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xF016F8", Offset = "0xF016F8", VA = "0xF016F8")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xF01780", Offset = "0xF01780", VA = "0xF01780")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xF01840", Offset = "0xF01840", VA = "0xF01840")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xF01858", Offset = "0xF01858", VA = "0xF01858")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xEFE6E0", Offset = "0xEFE6E0", VA = "0xEFE6E0")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xEFF1D0", Offset = "0xEFF1D0", VA = "0xEFF1D0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xF01CD0", Offset = "0xF01CD0", VA = "0xF01CD0")]
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
			[Address(RVA = "0xF025E8", Offset = "0xF025E8", VA = "0xF025E8")]
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
		[Address(RVA = "0xF02358", Offset = "0xF02358", VA = "0xF02358")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xF0239C", Offset = "0xF0239C", VA = "0xF0239C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xF023E0", Offset = "0xF023E0", VA = "0xF023E0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xF02424", Offset = "0xF02424", VA = "0xF02424")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xF02468", Offset = "0xF02468", VA = "0xF02468")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xF024AC", Offset = "0xF024AC", VA = "0xF024AC")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xF024F0", Offset = "0xF024F0", VA = "0xF024F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xF02534", Offset = "0xF02534", VA = "0xF02534")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xEFD930", Offset = "0xEFD930", VA = "0xEFD930")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xEFCAE8", Offset = "0xEFCAE8", VA = "0xEFCAE8")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xEFB26C", Offset = "0xEFB26C", VA = "0xEFB26C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xF02578", Offset = "0xF02578", VA = "0xF02578")]
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
				[Address(RVA = "0xF0285C", Offset = "0xF0285C", VA = "0xF0285C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0xF02868", Offset = "0xF02868", VA = "0xF02868")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0xF02928", Offset = "0xF02928", VA = "0xF02928")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0xF0308C", Offset = "0xF0308C", VA = "0xF0308C")]
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
			[Address(RVA = "0xF030A0", Offset = "0xF030A0", VA = "0xF030A0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0xF03218", Offset = "0xF03218", VA = "0xF03218")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0xF03520", Offset = "0xF03520", VA = "0xF03520")]
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
				[Address(RVA = "0xF035A4", Offset = "0xF035A4", VA = "0xF035A4")]
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
			[Address(RVA = "0xF02748", Offset = "0xF02748", VA = "0xF02748")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF03594", Offset = "0xF03594", VA = "0xF03594")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xF025F0", Offset = "0xF025F0", VA = "0xF025F0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xF02634", Offset = "0xF02634", VA = "0xF02634")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xF02678", Offset = "0xF02678", VA = "0xF02678")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xF026BC", Offset = "0xF026BC", VA = "0xF026BC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xF02700", Offset = "0xF02700", VA = "0xF02700")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xF02744", Offset = "0xF02744", VA = "0xF02744")]
		private void Start()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xF00F08", Offset = "0xF00F08", VA = "0xF00F08")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xF027F8", Offset = "0xF027F8", VA = "0xF027F8")]
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
			[Address(RVA = "0xF038A4", Offset = "0xF038A4", VA = "0xF038A4")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xF03BFC", Offset = "0xF03BFC", VA = "0xF03BFC")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xF03BBC", Offset = "0xF03BBC", VA = "0xF03BBC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xF03A40", Offset = "0xF03A40", VA = "0xF03A40")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xF035AC", Offset = "0xF035AC", VA = "0xF035AC", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xF0394C", Offset = "0xF0394C", VA = "0xF0394C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF03950", Offset = "0xF03950", VA = "0xF03950", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF03B60", Offset = "0xF03B60", VA = "0xF03B60", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF038F0", Offset = "0xF038F0", VA = "0xF038F0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF03810", Offset = "0xF03810", VA = "0xF03810")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF03C40", Offset = "0xF03C40", VA = "0xF03C40")]
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
		[Address(RVA = "0xF03C60", Offset = "0xF03C60", VA = "0xF03C60", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xF03D30", Offset = "0xF03D30", VA = "0xF03D30", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xF03F08", Offset = "0xF03F08", VA = "0xF03F08", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xF03FF0", Offset = "0xF03FF0", VA = "0xF03FF0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF03D90", Offset = "0xF03D90", VA = "0xF03D90")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF04320", Offset = "0xF04320", VA = "0xF04320")]
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
		[Address(RVA = "0xF04330", Offset = "0xF04330", VA = "0xF04330")]
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
		[Address(RVA = "0xF0433C", Offset = "0xF0433C", VA = "0xF0433C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xF04380", Offset = "0xF04380", VA = "0xF04380", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xF043AC", Offset = "0xF043AC", VA = "0xF043AC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xF03C50", Offset = "0xF03C50", VA = "0xF03C50")]
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
			[Address(RVA = "0xF04A1C", Offset = "0xF04A1C", VA = "0xF04A1C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0xF055C8", Offset = "0xF055C8", VA = "0xF055C8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xF05388", Offset = "0xF05388", VA = "0xF05388")]
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
			[Address(RVA = "0xF04BC4", Offset = "0xF04BC4", VA = "0xF04BC4")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0xF056E0", Offset = "0xF056E0", VA = "0xF056E0")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xF0569C", Offset = "0xF0569C", VA = "0xF0569C")]
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
				[Address(RVA = "0xF05C4C", Offset = "0xF05C4C", VA = "0xF05C4C", Slot = "4")]
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
				[Address(RVA = "0xF05C94", Offset = "0xF05C94", VA = "0xF05C94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xF04C30", Offset = "0xF04C30", VA = "0xF04C30")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xF05A5C", Offset = "0xF05A5C", VA = "0xF05A5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xF05A60", Offset = "0xF05A60", VA = "0xF05A60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xF05C54", Offset = "0xF05C54", VA = "0xF05C54", Slot = "8")]
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
			[Address(RVA = "0xF043F0", Offset = "0xF043F0", VA = "0xF043F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool ikUsed
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xF04FBC", Offset = "0xF04FBC", VA = "0xF04FBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xF043C4", Offset = "0xF043C4", VA = "0xF043C4")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xF04454", Offset = "0xF04454", VA = "0xF04454")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xF0456C", Offset = "0xF0456C", VA = "0xF0456C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xF044F8", Offset = "0xF044F8", VA = "0xF044F8")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xF04C58", Offset = "0xF04C58", VA = "0xF04C58")]
		private void Update()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xF04E80", Offset = "0xF04E80", VA = "0xF04E80")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xF04F20", Offset = "0xF04F20", VA = "0xF04F20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xF05110", Offset = "0xF05110", VA = "0xF05110")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xF04F90", Offset = "0xF04F90", VA = "0xF04F90")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xF050DC", Offset = "0xF050DC", VA = "0xF050DC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xF05190", Offset = "0xF05190", VA = "0xF05190")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xF05134", Offset = "0xF05134", VA = "0xF05134")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xF0449C", Offset = "0xF0449C", VA = "0xF0449C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xF04EB4", Offset = "0xF04EB4", VA = "0xF04EB4")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xF057F0", Offset = "0xF057F0", VA = "0xF057F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xF05928", Offset = "0xF05928", VA = "0xF05928")]
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
			[Address(RVA = "0xF06100", Offset = "0xF06100", VA = "0xF06100")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xF0610C", Offset = "0xF0610C", VA = "0xF0610C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xF0613C", Offset = "0xF0613C", VA = "0xF0613C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xF06144", Offset = "0xF06144", VA = "0xF06144")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xF05C9C", Offset = "0xF05C9C", VA = "0xF05C9C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xF05CD8", Offset = "0xF05CD8", VA = "0xF05CD8")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xF05CF0", Offset = "0xF05CF0", VA = "0xF05CF0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xF06070", Offset = "0xF06070", VA = "0xF06070")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xF060D4", Offset = "0xF060D4", VA = "0xF060D4")]
		public void Disable()
		{
		}

		[Token(Token = "0x600057C")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xF05F74", Offset = "0xF05F74", VA = "0xF05F74")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xF06150", Offset = "0xF06150", VA = "0xF06150")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xF06154", Offset = "0xF06154", VA = "0xF06154")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xF0617C", Offset = "0xF0617C", VA = "0xF0617C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xF06250", Offset = "0xF06250", VA = "0xF06250")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xF064A8", Offset = "0xF064A8", VA = "0xF064A8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xF065FC", Offset = "0xF065FC", VA = "0xF065FC")]
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
		[Address(RVA = "0xF0665C", Offset = "0xF0665C", VA = "0xF0665C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xF066A0", Offset = "0xF066A0", VA = "0xF066A0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xF066E4", Offset = "0xF066E4", VA = "0xF066E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xF06728", Offset = "0xF06728", VA = "0xF06728")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xF0676C", Offset = "0xF0676C", VA = "0xF0676C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xF067A4", Offset = "0xF067A4", VA = "0xF067A4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xF06AC8", Offset = "0xF06AC8", VA = "0xF06AC8")]
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
		[Address(RVA = "0xF06AD8", Offset = "0xF06AD8", VA = "0xF06AD8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xF06B1C", Offset = "0xF06B1C", VA = "0xF06B1C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xF06B60", Offset = "0xF06B60", VA = "0xF06B60")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xF06BA4", Offset = "0xF06BA4", VA = "0xF06BA4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xF06BE8", Offset = "0xF06BE8", VA = "0xF06BE8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xF06C04", Offset = "0xF06C04", VA = "0xF06C04")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xF06E4C", Offset = "0xF06E4C", VA = "0xF06E4C")]
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
				[Address(RVA = "0xF08908", Offset = "0xF08908", VA = "0xF08908")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000097")]
			public Vector3 a
			{
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0xF08934", Offset = "0xF08934", VA = "0xF08934")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 b
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0xF08964", Offset = "0xF08964", VA = "0xF08964")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 c
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0xF08994", Offset = "0xF08994", VA = "0xF08994")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public bool isValid
			{
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0xF08B3C", Offset = "0xF08B3C", VA = "0xF08B3C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xF089C4", Offset = "0xF089C4", VA = "0xF089C4")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xF08B4C", Offset = "0xF08B4C", VA = "0xF08B4C")]
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
			[Address(RVA = "0xF08DC0", Offset = "0xF08DC0", VA = "0xF08DC0")]
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
		[Address(RVA = "0xF06EB0", Offset = "0xF06EB0", VA = "0xF06EB0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xF06EF4", Offset = "0xF06EF4", VA = "0xF06EF4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xF06F38", Offset = "0xF06F38", VA = "0xF06F38")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xF06F7C", Offset = "0xF06F7C", VA = "0xF06F7C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xF06FC0", Offset = "0xF06FC0", VA = "0xF06FC0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xF076B0", Offset = "0xF076B0", VA = "0xF076B0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xF07738", Offset = "0xF07738", VA = "0xF07738")]
		private void Start()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xF07D98", Offset = "0xF07D98", VA = "0xF07D98")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xF07058", Offset = "0xF07058", VA = "0xF07058")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xF08290", Offset = "0xF08290", VA = "0xF08290")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xF086C0", Offset = "0xF086C0", VA = "0xF086C0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xF08708", Offset = "0xF08708", VA = "0xF08708")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xF08768", Offset = "0xF08768", VA = "0xF08768")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xF07AF4", Offset = "0xF07AF4", VA = "0xF07AF4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xF087D4", Offset = "0xF087D4", VA = "0xF087D4")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xF088A0", Offset = "0xF088A0", VA = "0xF088A0")]
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
		[Address(RVA = "0xF08E24", Offset = "0xF08E24", VA = "0xF08E24")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xF08E68", Offset = "0xF08E68", VA = "0xF08E68")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xF08EAC", Offset = "0xF08EAC", VA = "0xF08EAC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xF08EF0", Offset = "0xF08EF0", VA = "0xF08EF0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xF08F34", Offset = "0xF08F34", VA = "0xF08F34")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xF08F50", Offset = "0xF08F50", VA = "0xF08F50", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xF08FE4", Offset = "0xF08FE4", VA = "0xF08FE4")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xF0939C", Offset = "0xF0939C", VA = "0xF0939C")]
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
				[Address(RVA = "0xF0A084", Offset = "0xF0A084", VA = "0xF0A084", Slot = "4")]
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
				[Address(RVA = "0xF0A0CC", Offset = "0xF0A0CC", VA = "0xF0A0CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xF09E84", Offset = "0xF09E84", VA = "0xF09E84")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xF09F90", Offset = "0xF09F90", VA = "0xF09F90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xF09F94", Offset = "0xF09F94", VA = "0xF09F94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xF0A08C", Offset = "0xF0A08C", VA = "0xF0A08C", Slot = "8")]
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
			[Address(RVA = "0xF0942C", Offset = "0xF0942C", VA = "0xF0942C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xF093AC", Offset = "0xF093AC", VA = "0xF093AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xF094B0", Offset = "0xF094B0", VA = "0xF094B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xF099E8", Offset = "0xF099E8", VA = "0xF099E8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xF09B6C", Offset = "0xF09B6C", VA = "0xF09B6C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xF09E10", Offset = "0xF09E10", VA = "0xF09E10")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__33))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xF09EAC", Offset = "0xF09EAC", VA = "0xF09EAC")]
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
			[Address(RVA = "0xF0A1A4", Offset = "0xF0A1A4", VA = "0xF0A1A4")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xF0A720", Offset = "0xF0A720", VA = "0xF0A720")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xF0A728", Offset = "0xF0A728", VA = "0xF0A728")]
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
		[Address(RVA = "0xF0A0D4", Offset = "0xF0A0D4", VA = "0xF0A0D4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xF0A654", Offset = "0xF0A654", VA = "0xF0A654")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xF0A6B4", Offset = "0xF0A6B4", VA = "0xF0A6B4")]
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
				[Address(RVA = "0xF0ABEC", Offset = "0xF0ABEC", VA = "0xF0ABEC")]
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
			[Address(RVA = "0xF0A894", Offset = "0xF0A894", VA = "0xF0A894")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xF0ABC4", Offset = "0xF0ABC4", VA = "0xF0ABC4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xF0ABD4", Offset = "0xF0ABD4", VA = "0xF0ABD4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xF0A744", Offset = "0xF0A744", VA = "0xF0A744", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xF0ABA4", Offset = "0xF0ABA4", VA = "0xF0ABA4")]
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
		[Address(RVA = "0xF0ABF4", Offset = "0xF0ABF4", VA = "0xF0ABF4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xF0AC5C", Offset = "0xF0AC5C", VA = "0xF0AC5C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xF0AEFC", Offset = "0xF0AEFC", VA = "0xF0AEFC")]
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
		[Address(RVA = "0xF0AF18", Offset = "0xF0AF18", VA = "0xF0AF18")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xF0AFB4", Offset = "0xF0AFB4", VA = "0xF0AFB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xF0B074", Offset = "0xF0B074", VA = "0xF0B074")]
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
				[Address(RVA = "0xF0B118", Offset = "0xF0B118", VA = "0xF0B118")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A0")]
			protected float crossFader
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0xF0B618", Offset = "0xF0B618", VA = "0xF0B618")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0xF0B620", Offset = "0xF0B620", VA = "0xF0B620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			protected float timer
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0xF0B628", Offset = "0xF0B628", VA = "0xF0B628")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0xF0B630", Offset = "0xF0B630", VA = "0xF0B630")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected Vector3 force
			{
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0xF0B638", Offset = "0xF0B638", VA = "0xF0B638")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0xF0B644", Offset = "0xF0B644", VA = "0xF0B644")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 point
			{
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0xF0B650", Offset = "0xF0B650", VA = "0xF0B650")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0xF0B65C", Offset = "0xF0B65C", VA = "0xF0B65C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xF0B4E0", Offset = "0xF0B4E0", VA = "0xF0B4E0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xF0B1EC", Offset = "0xF0B1EC", VA = "0xF0B1EC")]
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
			[Address(RVA = "0xF0B668", Offset = "0xF0B668", VA = "0xF0B668")]
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
				[Address(RVA = "0xF0B99C", Offset = "0xF0B99C", VA = "0xF0B99C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005E9")]
				[Address(RVA = "0xF0B7F8", Offset = "0xF0B7F8", VA = "0xF0B7F8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005EA")]
				[Address(RVA = "0xF0BA4C", Offset = "0xF0BA4C", VA = "0xF0BA4C")]
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
			[Address(RVA = "0xF0B67C", Offset = "0xF0B67C", VA = "0xF0B67C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xF0B798", Offset = "0xF0B798", VA = "0xF0B798", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xF0B80C", Offset = "0xF0B80C", VA = "0xF0B80C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xF0BA38", Offset = "0xF0BA38", VA = "0xF0BA38")]
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
				[Address(RVA = "0xF0BD1C", Offset = "0xF0BD1C", VA = "0xF0BD1C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F0")]
				[Address(RVA = "0xF0BB38", Offset = "0xF0BB38", VA = "0xF0BB38")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F1")]
				[Address(RVA = "0xF0BEBC", Offset = "0xF0BEBC", VA = "0xF0BEBC")]
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
			[Address(RVA = "0xF0BA54", Offset = "0xF0BA54", VA = "0xF0BA54", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xF0BAE0", Offset = "0xF0BAE0", VA = "0xF0BAE0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xF0BB44", Offset = "0xF0BB44", VA = "0xF0BB44", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xF0BEA8", Offset = "0xF0BEA8", VA = "0xF0BEA8")]
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
			[Address(RVA = "0xF0B07C", Offset = "0xF0B07C", VA = "0xF0B07C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xF0B12C", Offset = "0xF0B12C", VA = "0xF0B12C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xF0B2C4", Offset = "0xF0B2C4", VA = "0xF0B2C4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xF0B608", Offset = "0xF0B608", VA = "0xF0B608")]
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
				[Address(RVA = "0xF0C42C", Offset = "0xF0C42C", VA = "0xF0C42C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0xF0C434", Offset = "0xF0C434", VA = "0xF0C434")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected float timer
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0xF0C43C", Offset = "0xF0C43C", VA = "0xF0C43C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0xF0C444", Offset = "0xF0C444", VA = "0xF0C444")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 force
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0xF0C44C", Offset = "0xF0C44C", VA = "0xF0C44C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0xF0C458", Offset = "0xF0C458", VA = "0xF0C458")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 point
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0xF0C464", Offset = "0xF0C464", VA = "0xF0C464")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0xF0C470", Offset = "0xF0C470", VA = "0xF0C470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xF0C2DC", Offset = "0xF0C2DC", VA = "0xF0C2DC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xF0BFD8", Offset = "0xF0BFD8", VA = "0xF0BFD8")]
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
			[Address(RVA = "0xF0C47C", Offset = "0xF0C47C", VA = "0xF0C47C")]
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
				[Address(RVA = "0xF0C860", Offset = "0xF0C860", VA = "0xF0C860")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000608")]
				[Address(RVA = "0xF0C684", Offset = "0xF0C684", VA = "0xF0C684")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000609")]
				[Address(RVA = "0xF0C8F4", Offset = "0xF0C8F4", VA = "0xF0C8F4")]
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
			[Address(RVA = "0xF0C490", Offset = "0xF0C490", VA = "0xF0C490", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xF0C624", Offset = "0xF0C624", VA = "0xF0C624", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xF0C698", Offset = "0xF0C698", VA = "0xF0C698", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xF0C8D8", Offset = "0xF0C8D8", VA = "0xF0C8D8")]
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
				[Address(RVA = "0xF0CCC8", Offset = "0xF0CCC8", VA = "0xF0CCC8")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0xF0CA2C", Offset = "0xF0CA2C", VA = "0xF0CA2C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0xF0CDE4", Offset = "0xF0CDE4", VA = "0xF0CDE4")]
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
			[Address(RVA = "0xF0C8FC", Offset = "0xF0C8FC", VA = "0xF0C8FC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0xF0C9D4", Offset = "0xF0C9D4", VA = "0xF0C9D4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0xF0CA38", Offset = "0xF0CA38", VA = "0xF0CA38", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0xF0CDD0", Offset = "0xF0CDD0", VA = "0xF0CDD0")]
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
		[Address(RVA = "0xF0BF20", Offset = "0xF0BF20", VA = "0xF0BF20", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xF0C0B8", Offset = "0xF0C0B8", VA = "0xF0C0B8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xF0C40C", Offset = "0xF0C40C", VA = "0xF0C40C")]
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
				[Address(RVA = "0xF0D3AC", Offset = "0xF0D3AC", VA = "0xF0D3AC")]
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
			[Address(RVA = "0xF0CEB4", Offset = "0xF0CEB4", VA = "0xF0CEB4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0xF0D034", Offset = "0xF0D034", VA = "0xF0D034")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0xF0D390", Offset = "0xF0D390", VA = "0xF0D390")]
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
		[Address(RVA = "0xF0CE48", Offset = "0xF0CE48", VA = "0xF0CE48")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xF0CF90", Offset = "0xF0CF90", VA = "0xF0CF90", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xF0D380", Offset = "0xF0D380", VA = "0xF0D380")]
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
			[Address(RVA = "0xF0D41C", Offset = "0xF0D41C", VA = "0xF0D41C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xF0D3B4", Offset = "0xF0D3B4", VA = "0xF0D3B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xF0D4A0", Offset = "0xF0D4A0", VA = "0xF0D4A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xF0D994", Offset = "0xF0D994", VA = "0xF0D994")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xF0DB18", Offset = "0xF0DB18", VA = "0xF0DB18")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xF0DD64", Offset = "0xF0DD64", VA = "0xF0DD64")]
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
			[Address(RVA = "0xF0DF6C", Offset = "0xF0DF6C", VA = "0xF0DF6C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0xF0E1FC", Offset = "0xF0E1FC", VA = "0xF0E1FC")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0xF0E26C", Offset = "0xF0E26C", VA = "0xF0E26C")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0xF0E2B4", Offset = "0xF0E2B4", VA = "0xF0E2B4")]
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
				[Address(RVA = "0xF0E430", Offset = "0xF0E430", VA = "0xF0E430", Slot = "4")]
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
				[Address(RVA = "0xF0E478", Offset = "0xF0E478", VA = "0xF0E478", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0xF0DE70", Offset = "0xF0DE70", VA = "0xF0DE70")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0xF0E2BC", Offset = "0xF0E2BC", VA = "0xF0E2BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0xF0E2C0", Offset = "0xF0E2C0", VA = "0xF0E2C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0xF0E438", Offset = "0xF0E438", VA = "0xF0E438", Slot = "8")]
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
			[Address(RVA = "0xF0A874", Offset = "0xF0A874", VA = "0xF0A874")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600061F")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xF0AC3C", Offset = "0xF0AC3C", VA = "0xF0AC3C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xF0DDFC", Offset = "0xF0DDFC", VA = "0xF0DDFC")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xF0DE98", Offset = "0xF0DE98", VA = "0xF0DE98")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xF0D2D8", Offset = "0xF0D2D8", VA = "0xF0D2D8")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xF0E0D0", Offset = "0xF0E0D0", VA = "0xF0E0D0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xF0ABB4", Offset = "0xF0ABB4", VA = "0xF0ABB4")]
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
				[Address(RVA = "0xF0E8D0", Offset = "0xF0E8D0", VA = "0xF0E8D0", Slot = "4")]
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
				[Address(RVA = "0xF0E918", Offset = "0xF0E918", VA = "0xF0E918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0xF0E534", Offset = "0xF0E534", VA = "0xF0E534")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0xF0E75C", Offset = "0xF0E75C", VA = "0xF0E75C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0xF0E760", Offset = "0xF0E760", VA = "0xF0E760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0xF0E8D8", Offset = "0xF0E8D8", VA = "0xF0E8D8", Slot = "8")]
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
			[Address(RVA = "0xF0E480", Offset = "0xF0E480", VA = "0xF0E480")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000631")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xF0E4A0", Offset = "0xF0E4A0", VA = "0xF0E4A0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xF0E4C0", Offset = "0xF0E4C0", VA = "0xF0E4C0")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xF0E55C", Offset = "0xF0E55C", VA = "0xF0E55C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xF0E630", Offset = "0xF0E630", VA = "0xF0E630", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xF0C41C", Offset = "0xF0C41C", VA = "0xF0C41C")]
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
			[Address(RVA = "0xF0E920", Offset = "0xF0E920", VA = "0xF0E920")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0xF0EC78", Offset = "0xF0EC78", VA = "0xF0EC78")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xF0AE48", Offset = "0xF0AE48", VA = "0xF0AE48")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xF0EB70", Offset = "0xF0EB70", VA = "0xF0EB70")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xF0EC14", Offset = "0xF0EC14", VA = "0xF0EC14")]
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
				[Address(RVA = "0xF0F2CC", Offset = "0xF0F2CC", VA = "0xF0F2CC")]
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
			[Address(RVA = "0xF0ECF0", Offset = "0xF0ECF0", VA = "0xF0ECF0")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xF0EE90", Offset = "0xF0EE90", VA = "0xF0EE90")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xF0EF98", Offset = "0xF0EF98", VA = "0xF0EF98")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xF0F2B8", Offset = "0xF0F2B8", VA = "0xF0F2B8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xF0EC80", Offset = "0xF0EC80", VA = "0xF0EC80", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xF0EE80", Offset = "0xF0EE80", VA = "0xF0EE80")]
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
				[Address(RVA = "0xF10678", Offset = "0xF10678", VA = "0xF10678")]
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
			[Address(RVA = "0xF0F470", Offset = "0xF0F470", VA = "0xF0F470")]
			public void Start()
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0xF0FFF0", Offset = "0xF0FFF0", VA = "0xF0FFF0")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xF10664", Offset = "0xF10664", VA = "0xF10664")]
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
			[Address(RVA = "0xF0F2D4", Offset = "0xF0F2D4", VA = "0xF0F2D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xF101F4", Offset = "0xF101F4", VA = "0xF101F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0xF10230", Offset = "0xF10230", VA = "0xF10230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xF101BC", Offset = "0xF101BC", VA = "0xF101BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0xF101D8", Offset = "0xF101D8", VA = "0xF101D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xF0F2F8", Offset = "0xF0F2F8", VA = "0xF0F2F8")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xF0F324", Offset = "0xF0F324", VA = "0xF0F324")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xF0F544", Offset = "0xF0F544", VA = "0xF0F544", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xF1026C", Offset = "0xF1026C", VA = "0xF1026C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xF10384", Offset = "0xF10384", VA = "0xF10384")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xF103D4", Offset = "0xF103D4", VA = "0xF103D4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xF105D8", Offset = "0xF105D8", VA = "0xF105D8")]
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
		[Address(RVA = "0xF10680", Offset = "0xF10680", VA = "0xF10680")]
		private void Start()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xF10794", Offset = "0xF10794", VA = "0xF10794")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xF10870", Offset = "0xF10870", VA = "0xF10870")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xF10C74", Offset = "0xF10C74", VA = "0xF10C74")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xF10CA8", Offset = "0xF10CA8", VA = "0xF10CA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xF10DD4", Offset = "0xF10DD4", VA = "0xF10DD4")]
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
			[Address(RVA = "0xF1398C", Offset = "0xF1398C", VA = "0xF1398C")]
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
				[Address(RVA = "0xF12AC4", Offset = "0xF12AC4", VA = "0xF12AC4")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000667")]
				[Address(RVA = "0xF1351C", Offset = "0xF1351C", VA = "0xF1351C")]
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
			[Address(RVA = "0xF121C8", Offset = "0xF121C8", VA = "0xF121C8")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xF10DE8", Offset = "0xF10DE8", VA = "0xF10DE8")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xF10EDC", Offset = "0xF10EDC", VA = "0xF10EDC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xF121D0", Offset = "0xF121D0", VA = "0xF121D0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xF12B78", Offset = "0xF12B78", VA = "0xF12B78")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xF13578", Offset = "0xF13578", VA = "0xF13578")]
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
		[Address(RVA = "0xF13B90", Offset = "0xF13B90", VA = "0xF13B90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xF13BE8", Offset = "0xF13BE8", VA = "0xF13BE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xF13C10", Offset = "0xF13C10", VA = "0xF13C10")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xF13D30", Offset = "0xF13D30", VA = "0xF13D30")]
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
			[Address(RVA = "0xF13D48", Offset = "0xF13D48", VA = "0xF13D48")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0xF13D54", Offset = "0xF13D54", VA = "0xF13D54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xF13D60", Offset = "0xF13D60", VA = "0xF13D60")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xF128B0", Offset = "0xF128B0", VA = "0xF128B0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xF137EC", Offset = "0xF137EC", VA = "0xF137EC")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xF13E7C", Offset = "0xF13E7C", VA = "0xF13E7C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xF14244", Offset = "0xF14244", VA = "0xF14244")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xF14370", Offset = "0xF14370", VA = "0xF14370")]
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
			[Address(RVA = "0xF14434", Offset = "0xF14434", VA = "0xF14434")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0xF146B0", Offset = "0xF146B0", VA = "0xF146B0")]
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
		[Address(RVA = "0xF14378", Offset = "0xF14378", VA = "0xF14378")]
		private void Start()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xF143D0", Offset = "0xF143D0", VA = "0xF143D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xF145E4", Offset = "0xF145E4", VA = "0xF145E4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xF146A8", Offset = "0xF146A8", VA = "0xF146A8")]
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
		[Address(RVA = "0xF146B8", Offset = "0xF146B8", VA = "0xF146B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xF14738", Offset = "0xF14738", VA = "0xF14738")]
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
		[Address(RVA = "0xF14740", Offset = "0xF14740", VA = "0xF14740")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xF147AC", Offset = "0xF147AC", VA = "0xF147AC")]
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
		[Address(RVA = "0xF1480C", Offset = "0xF1480C", VA = "0xF1480C")]
		private void Start()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xF14844", Offset = "0xF14844", VA = "0xF14844")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xF14B00", Offset = "0xF14B00", VA = "0xF14B00")]
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
		[Address(RVA = "0xF14B08", Offset = "0xF14B08", VA = "0xF14B08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xF14B40", Offset = "0xF14B40", VA = "0xF14B40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xF14C8C", Offset = "0xF14C8C", VA = "0xF14C8C")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xF14E10", Offset = "0xF14E10", VA = "0xF14E10")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xF14FF4", Offset = "0xF14FF4", VA = "0xF14FF4")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xF15084", Offset = "0xF15084", VA = "0xF15084")]
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
		[Address(RVA = "0xF15098", Offset = "0xF15098", VA = "0xF15098")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xF15204", Offset = "0xF15204", VA = "0xF15204")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xF15400", Offset = "0xF15400", VA = "0xF15400")]
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
		[Address(RVA = "0xF15430", Offset = "0xF15430", VA = "0xF15430")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xF1585C", Offset = "0xF1585C", VA = "0xF1585C")]
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
		[Address(RVA = "0xF1587C", Offset = "0xF1587C", VA = "0xF1587C")]
		private void Update()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xF16198", Offset = "0xF16198", VA = "0xF16198")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xF15F14", Offset = "0xF15F14", VA = "0xF15F14")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xF162A8", Offset = "0xF162A8", VA = "0xF162A8")]
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
			[Address(RVA = "0xF162D4", Offset = "0xF162D4", VA = "0xF162D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xF16354", Offset = "0xF16354", VA = "0xF16354")]
		private void Update()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xF16698", Offset = "0xF16698", VA = "0xF16698")]
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
				[Address(RVA = "0xF17720", Offset = "0xF17720", VA = "0xF17720", Slot = "4")]
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
				[Address(RVA = "0xF17768", Offset = "0xF17768", VA = "0xF17768", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xF173B8", Offset = "0xF173B8", VA = "0xF173B8")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xF17470", Offset = "0xF17470", VA = "0xF17470", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xF17474", Offset = "0xF17474", VA = "0xF17474", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xF17728", Offset = "0xF17728", VA = "0xF17728", Slot = "8")]
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
			[Address(RVA = "0xF166AC", Offset = "0xF166AC", VA = "0xF166AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public Vector3 position
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xF16278", Offset = "0xF16278", VA = "0xF16278")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xF166C0", Offset = "0xF166C0", VA = "0xF166C0")]
			set
			{
			}
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xF1670C", Offset = "0xF1670C", VA = "0xF1670C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xF1698C", Offset = "0xF1698C", VA = "0xF1698C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xF16B64", Offset = "0xF16B64", VA = "0xF16B64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xF16D88", Offset = "0xF16D88", VA = "0xF16D88")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xF17018", Offset = "0xF17018", VA = "0xF17018")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xF17180", Offset = "0xF17180", VA = "0xF17180")]
		private void Update()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xF16CD8", Offset = "0xF16CD8", VA = "0xF16CD8")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xF173E0", Offset = "0xF173E0", VA = "0xF173E0")]
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
		[Address(RVA = "0xF17770", Offset = "0xF17770", VA = "0xF17770")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xF1784C", Offset = "0xF1784C", VA = "0xF1784C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xF17AC0", Offset = "0xF17AC0", VA = "0xF17AC0")]
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
		[Address(RVA = "0xF17AC8", Offset = "0xF17AC8", VA = "0xF17AC8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xF17AF4", Offset = "0xF17AF4", VA = "0xF17AF4")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xF17D0C", Offset = "0xF17D0C", VA = "0xF17D0C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xF17FC4", Offset = "0xF17FC4", VA = "0xF17FC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xF18058", Offset = "0xF18058", VA = "0xF18058")]
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
		[Address(RVA = "0xF18068", Offset = "0xF18068", VA = "0xF18068", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xF180C0", Offset = "0xF180C0", VA = "0xF180C0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xF182C8", Offset = "0xF182C8", VA = "0xF182C8", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xF184F0", Offset = "0xF184F0", VA = "0xF184F0")]
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
		[Address(RVA = "0xF18504", Offset = "0xF18504", VA = "0xF18504", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xF186D8", Offset = "0xF186D8", VA = "0xF186D8", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xF18748", Offset = "0xF18748", VA = "0xF18748")]
		private void Read()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xF18880", Offset = "0xF18880", VA = "0xF18880")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xF188DC", Offset = "0xF188DC", VA = "0xF188DC")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xF18F44", Offset = "0xF18F44", VA = "0xF18F44")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xF18D58", Offset = "0xF18D58", VA = "0xF18D58")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xF191E8", Offset = "0xF191E8", VA = "0xF191E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xF19314", Offset = "0xF19314", VA = "0xF19314")]
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
		[Address(RVA = "0xF19330", Offset = "0xF19330", VA = "0xF19330", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xF19394", Offset = "0xF19394", VA = "0xF19394", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xF196D0", Offset = "0xF196D0", VA = "0xF196D0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xF197C0", Offset = "0xF197C0", VA = "0xF197C0")]
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
			[Address(RVA = "0xF1AA28", Offset = "0xF1AA28", VA = "0xF1AA28")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BB")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xF1AAA8", Offset = "0xF1AAA8", VA = "0xF1AAA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xF1A7C8", Offset = "0xF1A7C8", VA = "0xF1A7C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xF1A838", Offset = "0xF1A838", VA = "0xF1A838")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xF1AB28", Offset = "0xF1AB28", VA = "0xF1AB28")]
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
		[Address(RVA = "0xF1AB30", Offset = "0xF1AB30", VA = "0xF1AB30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xF1AF8C", Offset = "0xF1AF8C", VA = "0xF1AF8C")]
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
		[Address(RVA = "0xF1AF94", Offset = "0xF1AF94", VA = "0xF1AF94")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xF1B04C", Offset = "0xF1B04C", VA = "0xF1B04C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xF1B4A8", Offset = "0xF1B4A8", VA = "0xF1B4A8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xF1B548", Offset = "0xF1B548", VA = "0xF1B548")]
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
			[Address(RVA = "0xF1B6DC", Offset = "0xF1B6DC", VA = "0xF1B6DC")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xF1B800", Offset = "0xF1B800", VA = "0xF1B800")]
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
		[Address(RVA = "0xF1B5B8", Offset = "0xF1B5B8", VA = "0xF1B5B8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xF1B754", Offset = "0xF1B754", VA = "0xF1B754")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xF1B7EC", Offset = "0xF1B7EC", VA = "0xF1B7EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xF1B7F0", Offset = "0xF1B7F0", VA = "0xF1B7F0")]
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
		[Address(RVA = "0xF1B810", Offset = "0xF1B810", VA = "0xF1B810")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xF1B878", Offset = "0xF1B878", VA = "0xF1B878")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xF1B94C", Offset = "0xF1B94C", VA = "0xF1B94C")]
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
		[Address(RVA = "0xF1B954", Offset = "0xF1B954", VA = "0xF1B954")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xF1B9AC", Offset = "0xF1B9AC", VA = "0xF1B9AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xF1BB44", Offset = "0xF1BB44", VA = "0xF1BB44")]
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
		[Address(RVA = "0xF1BB4C", Offset = "0xF1BB4C", VA = "0xF1BB4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xF1BC2C", Offset = "0xF1BC2C", VA = "0xF1BC2C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xF1BCB8", Offset = "0xF1BCB8", VA = "0xF1BCB8")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xF1C18C", Offset = "0xF1C18C", VA = "0xF1C18C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xF1C2B8", Offset = "0xF1C2B8", VA = "0xF1C2B8")]
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
		[Address(RVA = "0xF1C2C0", Offset = "0xF1C2C0", VA = "0xF1C2C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xF1C420", Offset = "0xF1C420", VA = "0xF1C420")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xF1C42C", Offset = "0xF1C42C", VA = "0xF1C42C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xF1C6EC", Offset = "0xF1C6EC", VA = "0xF1C6EC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xF1C878", Offset = "0xF1C878", VA = "0xF1C878")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xF1C4F0", Offset = "0xF1C4F0", VA = "0xF1C4F0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xF1D530", Offset = "0xF1D530", VA = "0xF1D530")]
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
		[Address(RVA = "0xF1D550", Offset = "0xF1D550", VA = "0xF1D550")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xF1D5E0", Offset = "0xF1D5E0", VA = "0xF1D5E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xF1D6DC", Offset = "0xF1D6DC", VA = "0xF1D6DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xF1D788", Offset = "0xF1D788", VA = "0xF1D788")]
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
		[Address(RVA = "0xF1D798", Offset = "0xF1D798", VA = "0xF1D798")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xF1D8E8", Offset = "0xF1D8E8", VA = "0xF1D8E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xF1DA4C", Offset = "0xF1DA4C", VA = "0xF1DA4C")]
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
		[Address(RVA = "0xF1DA5C", Offset = "0xF1DA5C", VA = "0xF1DA5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xF1DC28", Offset = "0xF1DC28", VA = "0xF1DC28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xF1E038", Offset = "0xF1E038", VA = "0xF1E038")]
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
		[Address(RVA = "0xF1E048", Offset = "0xF1E048", VA = "0xF1E048")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xF1E130", Offset = "0xF1E130", VA = "0xF1E130")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xF1E21C", Offset = "0xF1E21C", VA = "0xF1E21C")]
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
		[Address(RVA = "0xF1E224", Offset = "0xF1E224", VA = "0xF1E224")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xF1E724", Offset = "0xF1E724", VA = "0xF1E724")]
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
		[Address(RVA = "0xF1E72C", Offset = "0xF1E72C", VA = "0xF1E72C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xF1E784", Offset = "0xF1E784", VA = "0xF1E784")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xF1EA30", Offset = "0xF1EA30", VA = "0xF1EA30")]
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
				[Address(RVA = "0xF1F23C", Offset = "0xF1F23C", VA = "0xF1F23C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xF1EA60", Offset = "0xF1EA60", VA = "0xF1EA60")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xF1EADC", Offset = "0xF1EADC", VA = "0xF1EADC")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xF1F0D4", Offset = "0xF1F0D4", VA = "0xF1F0D4")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xF1F288", Offset = "0xF1F288", VA = "0xF1F288")]
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
		[Address(RVA = "0xF1EA38", Offset = "0xF1EA38", VA = "0xF1EA38")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xF1EA80", Offset = "0xF1EA80", VA = "0xF1EA80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xF1F0C4", Offset = "0xF1F0C4", VA = "0xF1F0C4")]
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
			[Address(RVA = "0xF1F414", Offset = "0xF1F414", VA = "0xF1F414")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0xF1F5FC", Offset = "0xF1F5FC", VA = "0xF1F5FC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0xF1F620", Offset = "0xF1F620", VA = "0xF1F620")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0xF1F730", Offset = "0xF1F730", VA = "0xF1F730")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0xF1F8E8", Offset = "0xF1F8E8", VA = "0xF1F8E8")]
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
		[Address(RVA = "0xF1F29C", Offset = "0xF1F29C", VA = "0xF1F29C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xF1F394", Offset = "0xF1F394", VA = "0xF1F394")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xF1F4F0", Offset = "0xF1F4F0", VA = "0xF1F4F0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xF1F6B4", Offset = "0xF1F6B4", VA = "0xF1F6B4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xF1F7A0", Offset = "0xF1F7A0", VA = "0xF1F7A0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xF1F8D8", Offset = "0xF1F8D8", VA = "0xF1F8D8")]
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
		[Address(RVA = "0xF1F948", Offset = "0xF1F948", VA = "0xF1F948")]
		private void Start()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xF1F9C0", Offset = "0xF1F9C0", VA = "0xF1F9C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xF1FA90", Offset = "0xF1FA90", VA = "0xF1FA90")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xF1FBD8", Offset = "0xF1FBD8", VA = "0xF1FBD8")]
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
			[Address(RVA = "0xF1FE58", Offset = "0xF1FE58", VA = "0xF1FE58")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xF1FBEC", Offset = "0xF1FBEC", VA = "0xF1FBEC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xF1FCD8", Offset = "0xF1FCD8", VA = "0xF1FCD8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xF1FE50", Offset = "0xF1FE50", VA = "0xF1FE50")]
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
		[Address(RVA = "0xF1FE68", Offset = "0xF1FE68", VA = "0xF1FE68")]
		private void Start()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xF2017C", Offset = "0xF2017C", VA = "0xF2017C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xF20978", Offset = "0xF20978", VA = "0xF20978")]
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
			[Address(RVA = "0xF20BF8", Offset = "0xF20BF8", VA = "0xF20BF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xF209E4", Offset = "0xF209E4", VA = "0xF209E4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000711")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xF20C18", Offset = "0xF20C18", VA = "0xF20C18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xF20E08", Offset = "0xF20E08", VA = "0xF20E08")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xF20F78", Offset = "0xF20F78", VA = "0xF20F78")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xF21048", Offset = "0xF21048", VA = "0xF21048")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xF21168", Offset = "0xF21168", VA = "0xF21168")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xF212DC", Offset = "0xF212DC", VA = "0xF212DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xF21518", Offset = "0xF21518", VA = "0xF21518")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600071A")]
		[Address(RVA = "0xF2152C", Offset = "0xF2152C", VA = "0xF2152C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xF2170C", Offset = "0xF2170C", VA = "0xF2170C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600071C")]
		[Address(RVA = "0xF21720", Offset = "0xF21720", VA = "0xF21720", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xF21834", Offset = "0xF21834", VA = "0xF21834")]
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
		[Address(RVA = "0xF21848", Offset = "0xF21848", VA = "0xF21848")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xF218E0", Offset = "0xF218E0", VA = "0xF218E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xF219F8", Offset = "0xF219F8", VA = "0xF219F8")]
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
		[Address(RVA = "0xF21A00", Offset = "0xF21A00", VA = "0xF21A00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xF21A58", Offset = "0xF21A58", VA = "0xF21A58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xF21AA4", Offset = "0xF21AA4", VA = "0xF21AA4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xF21B3C", Offset = "0xF21B3C", VA = "0xF21B3C")]
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
				[Address(RVA = "0xF21EB4", Offset = "0xF21EB4", VA = "0xF21EB4", Slot = "4")]
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
				[Address(RVA = "0xF21EFC", Offset = "0xF21EFC", VA = "0xF21EFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0xF21CD0", Offset = "0xF21CD0", VA = "0xF21CD0")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0xF21D08", Offset = "0xF21D08", VA = "0xF21D08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0xF21D0C", Offset = "0xF21D0C", VA = "0xF21D0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0xF21EBC", Offset = "0xF21EBC", VA = "0xF21EBC", Slot = "8")]
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
		[Address(RVA = "0xF21B4C", Offset = "0xF21B4C", VA = "0xF21B4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xF21C10", Offset = "0xF21C10", VA = "0xF21C10")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xF21C4C", Offset = "0xF21C4C", VA = "0xF21C4C")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xF21CF8", Offset = "0xF21CF8", VA = "0xF21CF8")]
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
				[Address(RVA = "0xF221A0", Offset = "0xF221A0", VA = "0xF221A0", Slot = "4")]
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
				[Address(RVA = "0xF221E8", Offset = "0xF221E8", VA = "0xF221E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0xF2202C", Offset = "0xF2202C", VA = "0xF2202C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0xF2205C", Offset = "0xF2205C", VA = "0xF2205C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0xF22060", Offset = "0xF22060", VA = "0xF22060", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0xF221A8", Offset = "0xF221A8", VA = "0xF221A8", Slot = "8")]
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
		[Address(RVA = "0xF21F04", Offset = "0xF21F04", VA = "0xF21F04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xF21FB8", Offset = "0xF21FB8", VA = "0xF21FB8")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xF22054", Offset = "0xF22054", VA = "0xF22054")]
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
			[Address(RVA = "0xF22254", Offset = "0xF22254", VA = "0xF22254")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0xF22E28", Offset = "0xF22E28", VA = "0xF22E28")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0xF2265C", Offset = "0xF2265C", VA = "0xF2265C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0xF22F04", Offset = "0xF22F04", VA = "0xF22F04")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0xF22FE8", Offset = "0xF22FE8", VA = "0xF22FE8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0xF23074", Offset = "0xF23074", VA = "0xF23074")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0xF230FC", Offset = "0xF230FC", VA = "0xF230FC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0xF22C14", Offset = "0xF22C14", VA = "0xF22C14")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xF23184", Offset = "0xF23184", VA = "0xF23184")]
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
		[Address(RVA = "0xF221F0", Offset = "0xF221F0", VA = "0xF221F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xF225FC", Offset = "0xF225FC", VA = "0xF225FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xF22B64", Offset = "0xF22B64", VA = "0xF22B64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xF22E20", Offset = "0xF22E20", VA = "0xF22E20")]
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
		[Address(RVA = "0xF231B8", Offset = "0xF231B8", VA = "0xF231B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xF231E8", Offset = "0xF231E8", VA = "0xF231E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xF23298", Offset = "0xF23298", VA = "0xF23298")]
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
		[Address(RVA = "0xF232AC", Offset = "0xF232AC", VA = "0xF232AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xF234C4", Offset = "0xF234C4", VA = "0xF234C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xF23760", Offset = "0xF23760", VA = "0xF23760")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xF23828", Offset = "0xF23828", VA = "0xF23828")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xF23954", Offset = "0xF23954", VA = "0xF23954")]
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
		[Address(RVA = "0xF2395C", Offset = "0xF2395C", VA = "0xF2395C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xF23DB4", Offset = "0xF23DB4", VA = "0xF23DB4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xF23F7C", Offset = "0xF23F7C", VA = "0xF23F7C")]
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
		[Address(RVA = "0xF23FB0", Offset = "0xF23FB0", VA = "0xF23FB0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xF241B8", Offset = "0xF241B8", VA = "0xF241B8")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xF24224", Offset = "0xF24224", VA = "0xF24224")]
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
				[Address(RVA = "0xF24994", Offset = "0xF24994", VA = "0xF24994", Slot = "4")]
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
				[Address(RVA = "0xF249DC", Offset = "0xF249DC", VA = "0xF249DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0xF2461C", Offset = "0xF2461C", VA = "0xF2461C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xF2480C", Offset = "0xF2480C", VA = "0xF2480C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xF24810", Offset = "0xF24810", VA = "0xF24810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xF2499C", Offset = "0xF2499C", VA = "0xF2499C", Slot = "8")]
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
		[Address(RVA = "0xF2422C", Offset = "0xF2422C", VA = "0xF2422C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xF24368", Offset = "0xF24368", VA = "0xF24368")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xF242F4", Offset = "0xF242F4", VA = "0xF242F4")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xF24644", Offset = "0xF24644", VA = "0xF24644")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xF2471C", Offset = "0xF2471C", VA = "0xF2471C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xF247F0", Offset = "0xF247F0", VA = "0xF247F0")]
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
		[Address(RVA = "0xF249E4", Offset = "0xF249E4", VA = "0xF249E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xF24A4C", Offset = "0xF24A4C", VA = "0xF24A4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xF24AF8", Offset = "0xF24AF8", VA = "0xF24AF8")]
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
			[Address(RVA = "0xF24B6C", Offset = "0xF24B6C", VA = "0xF24B6C")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xF24CA8", Offset = "0xF24CA8", VA = "0xF24CA8")]
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
		[Address(RVA = "0xF24B08", Offset = "0xF24B08", VA = "0xF24B08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xF24CA0", Offset = "0xF24CA0", VA = "0xF24CA0")]
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
		[Address(RVA = "0xF24CB0", Offset = "0xF24CB0", VA = "0xF24CB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xF24CB4", Offset = "0xF24CB4", VA = "0xF24CB4")]
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
		[Address(RVA = "0xF24CC4", Offset = "0xF24CC4", VA = "0xF24CC4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xF24E14", Offset = "0xF24E14", VA = "0xF24E14")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xF24F78", Offset = "0xF24F78", VA = "0xF24F78")]
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
		[Address(RVA = "0xF24F88", Offset = "0xF24F88", VA = "0xF24F88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xF250E8", Offset = "0xF250E8", VA = "0xF250E8")]
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
		[Address(RVA = "0xF2515C", Offset = "0xF2515C", VA = "0xF2515C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xF251AC", Offset = "0xF251AC", VA = "0xF251AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xF25384", Offset = "0xF25384", VA = "0xF25384")]
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
		[Address(RVA = "0xF253DC", Offset = "0xF253DC", VA = "0xF253DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xF2590C", Offset = "0xF2590C", VA = "0xF2590C")]
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
			[Address(RVA = "0xF25988", Offset = "0xF25988", VA = "0xF25988", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xF25968", Offset = "0xF25968", VA = "0xF25968", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xF25990", Offset = "0xF25990", VA = "0xF25990")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xF259F0", Offset = "0xF259F0", VA = "0xF259F0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xF25B74", Offset = "0xF25B74", VA = "0xF25B74", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xF25DF0", Offset = "0xF25DF0", VA = "0xF25DF0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xF25B84", Offset = "0xF25B84", VA = "0xF25B84")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xF25E00", Offset = "0xF25E00", VA = "0xF25E00")]
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
		[Address(RVA = "0xF25E18", Offset = "0xF25E18", VA = "0xF25E18", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xF25E78", Offset = "0xF25E78", VA = "0xF25E78", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xF25F08", Offset = "0xF25F08", VA = "0xF25F08")]
		private void Update()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xF2602C", Offset = "0xF2602C", VA = "0xF2602C")]
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
			[Address(RVA = "0xF260E8", Offset = "0xF260E8", VA = "0xF260E8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xF26044", Offset = "0xF26044", VA = "0xF26044", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xF260CC", Offset = "0xF260CC", VA = "0xF260CC", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xF261DC", Offset = "0xF261DC", VA = "0xF261DC", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xF265B0", Offset = "0xF265B0", VA = "0xF265B0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xF266D8", Offset = "0xF266D8", VA = "0xF266D8")]
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
		[Address(RVA = "0xF266FC", Offset = "0xF266FC", VA = "0xF266FC")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xF268E8", Offset = "0xF268E8", VA = "0xF268E8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xF26B14", Offset = "0xF26B14", VA = "0xF26B14", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xF26CB4", Offset = "0xF26CB4", VA = "0xF26CB4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xF26D14", Offset = "0xF26D14", VA = "0xF26D14")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xF26E78", Offset = "0xF26E78", VA = "0xF26E78")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xF2707C", Offset = "0xF2707C", VA = "0xF2707C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xF270A0", Offset = "0xF270A0", VA = "0xF270A0")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xF270C4", Offset = "0xF270C4", VA = "0xF270C4")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xF27210", Offset = "0xF27210", VA = "0xF27210")]
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
				[Address(RVA = "0xF29C10", Offset = "0xF29C10", VA = "0xF29C10", Slot = "4")]
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
				[Address(RVA = "0xF29C58", Offset = "0xF29C58", VA = "0xF29C58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xF299CC", Offset = "0xF299CC", VA = "0xF299CC")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xF29B0C", Offset = "0xF29B0C", VA = "0xF29B0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xF29B10", Offset = "0xF29B10", VA = "0xF29B10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xF29C18", Offset = "0xF29C18", VA = "0xF29C18", Slot = "8")]
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
			[Address(RVA = "0xF27230", Offset = "0xF27230", VA = "0xF27230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000790")]
			[Address(RVA = "0xF27238", Offset = "0xF27238", VA = "0xF27238")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xF27244", Offset = "0xF27244", VA = "0xF27244", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xF27434", Offset = "0xF27434", VA = "0xF27434")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xF274B8", Offset = "0xF274B8", VA = "0xF274B8", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xF27568", Offset = "0xF27568", VA = "0xF27568")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xF28554", Offset = "0xF28554", VA = "0xF28554", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xF289E4", Offset = "0xF289E4", VA = "0xF289E4", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xF27C18", Offset = "0xF27C18", VA = "0xF27C18")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xF28ABC", Offset = "0xF28ABC", VA = "0xF28ABC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xF29148", Offset = "0xF29148", VA = "0xF29148")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xF285E0", Offset = "0xF285E0", VA = "0xF285E0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xF29238", Offset = "0xF29238", VA = "0xF29238", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xF296B8", Offset = "0xF296B8", VA = "0xF296B8")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xF297E0", Offset = "0xF297E0", VA = "0xF297E0", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xF29934", Offset = "0xF29934", VA = "0xF29934")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__74))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xF27FF4", Offset = "0xF27FF4", VA = "0xF27FF4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xF299F4", Offset = "0xF299F4", VA = "0xF299F4")]
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
			[Address(RVA = "0xF29C60", Offset = "0xF29C60", VA = "0xF29C60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xF29C68", Offset = "0xF29C68", VA = "0xF29C68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xF29C74", Offset = "0xF29C74", VA = "0xF29C74")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xF29D1C", Offset = "0xF29D1C", VA = "0xF29D1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xF2A334", Offset = "0xF2A334", VA = "0xF2A334")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xF29D64", Offset = "0xF29D64", VA = "0xF29D64")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xF2A0CC", Offset = "0xF2A0CC", VA = "0xF2A0CC")]
		private void Move()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xF2A364", Offset = "0xF2A364", VA = "0xF2A364")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xF2A3FC", Offset = "0xF2A3FC", VA = "0xF2A3FC")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xF2A47C", Offset = "0xF2A47C", VA = "0xF2A47C")]
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
		[Address(RVA = "0xF2A4A4", Offset = "0xF2A4A4", VA = "0xF2A4A4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xF2A5EC", Offset = "0xF2A5EC", VA = "0xF2A5EC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xF2AC64", Offset = "0xF2AC64", VA = "0xF2AC64")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xF2AE50", Offset = "0xF2AE50", VA = "0xF2AE50")]
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
		[Address(RVA = "0xF2A4E0", Offset = "0xF2A4E0", VA = "0xF2A4E0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xF23A70", Offset = "0xF23A70", VA = "0xF23A70", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xF23FA0", Offset = "0xF23FA0", VA = "0xF23FA0")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xF2AE6C", Offset = "0xF2AE6C", VA = "0xF2AE6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xF2AEA4", Offset = "0xF2AEA4", VA = "0xF2AEA4")]
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
		[Address(RVA = "0xF2AEAC", Offset = "0xF2AEAC", VA = "0xF2AEAC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xF2AED4", Offset = "0xF2AED4", VA = "0xF2AED4")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xF2AF78", Offset = "0xF2AF78", VA = "0xF2AF78")]
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
			[Address(RVA = "0xF2AF8C", Offset = "0xF2AF8C", VA = "0xF2AF8C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xF2AF98", Offset = "0xF2AF98", VA = "0xF2AF98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public State state
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xF2AFA4", Offset = "0xF2AFA4", VA = "0xF2AFA4")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xF2AFAC", Offset = "0xF2AFAC", VA = "0xF2AFAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xF2A514", Offset = "0xF2A514", VA = "0xF2A514")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xF2A80C", Offset = "0xF2A80C", VA = "0xF2A80C")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xF2B08C", Offset = "0xF2B08C", VA = "0xF2B08C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xF2B0F0", Offset = "0xF2B0F0", VA = "0xF2B0F0")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xF2AFB4", Offset = "0xF2AFB4", VA = "0xF2AFB4")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xF2B010", Offset = "0xF2B010", VA = "0xF2B010")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xF2AC8C", Offset = "0xF2AC8C", VA = "0xF2AC8C")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xF2B224", Offset = "0xF2B224", VA = "0xF2B224")]
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
		[Address(RVA = "0xF2B294", Offset = "0xF2B294", VA = "0xF2B294")]
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
		[Address(RVA = "0xF2B29C", Offset = "0xF2B29C", VA = "0xF2B29C")]
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
		[Address(RVA = "0xF2B2A4", Offset = "0xF2B2A4", VA = "0xF2B2A4")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xF2B2AC", Offset = "0xF2B2AC", VA = "0xF2B2AC")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xF2B2DC", Offset = "0xF2B2DC", VA = "0xF2B2DC")]
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
		[Address(RVA = "0xF2B2E4", Offset = "0xF2B2E4", VA = "0xF2B2E4")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xF2B2EC", Offset = "0xF2B2EC", VA = "0xF2B2EC")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xF2B2F4", Offset = "0xF2B2F4", VA = "0xF2B2F4")]
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
		[Address(RVA = "0xF2B2FC", Offset = "0xF2B2FC", VA = "0xF2B2FC")]
		private SuppressLogAttribute()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xF2B304", Offset = "0xF2B304", VA = "0xF2B304")]
		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
