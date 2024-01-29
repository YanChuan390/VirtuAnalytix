using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using VEAGames.LAM.Constants;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class PatchCulling : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer[] DetailPatches;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x866FEC", Offset = "0x866FEC", VA = "0x866FEC")]
	public void DestroyPatch()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x867058", Offset = "0x867058", VA = "0x867058")]
	public void RendererEnabled(bool enabled = true)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x86714C", Offset = "0x86714C", VA = "0x86714C")]
	public void ShadowCastingMode(ShadowCastingMode mode)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x86723C", Offset = "0x86723C", VA = "0x86723C")]
	public PatchCulling()
	{
	}
}
[Token(Token = "0x2000003")]
public class FlyController : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MouseLook MouseLook;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x867244", Offset = "0x867244", VA = "0x867244")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x8672A0", Offset = "0x8672A0", VA = "0x8672A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x8674A4", Offset = "0x8674A4", VA = "0x8674A4")]
	public FlyController()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000004")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000005")]
		public enum Mode
		{
			[Token(Token = "0x4000013")]
			AnimationClips,
			[Token(Token = "0x4000014")]
			AnimationStates,
			[Token(Token = "0x4000015")]
			PlayableDirector,
			[Token(Token = "0x4000016")]
			Realtime
		}

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 0.1f)]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		public float keyReductionError;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		public Animator animator;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		public PlayableDirector director;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x867630", Offset = "0x867630", VA = "0x867630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x867638", Offset = "0x867638", VA = "0x867638")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x867644", Offset = "0x867644", VA = "0x867644")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x86764C", Offset = "0x86764C", VA = "0x86764C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x867654", Offset = "0x867654", VA = "0x867654")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x86765C", Offset = "0x86765C", VA = "0x86765C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x867520", Offset = "0x867520", VA = "0x867520")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x867564", Offset = "0x867564", VA = "0x867564")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x8675A8", Offset = "0x8675A8", VA = "0x8675A8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x8675EC", Offset = "0x8675EC", VA = "0x8675EC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000010")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000011")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000012")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000013")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000014")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x867664", Offset = "0x867664", VA = "0x867664")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x867668", Offset = "0x867668", VA = "0x867668")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x86766C", Offset = "0x86766C", VA = "0x86766C")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x867670", Offset = "0x867670", VA = "0x867670")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x867798", Offset = "0x867798", VA = "0x867798")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x867BDC", Offset = "0x867BDC", VA = "0x867BDC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x867BE4", Offset = "0x867BE4", VA = "0x867BE4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x867E20", Offset = "0x867E20", VA = "0x867E20", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x868084", Offset = "0x868084", VA = "0x868084", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x86839C", Offset = "0x86839C", VA = "0x86839C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x8679C4", Offset = "0x8679C4", VA = "0x8679C4")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x867A7C", Offset = "0x867A7C", VA = "0x867A7C")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x8685FC", Offset = "0x8685FC", VA = "0x8685FC")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class TQ
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x868664", Offset = "0x868664", VA = "0x868664")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x8686C8", Offset = "0x8686C8", VA = "0x8686C8")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x868924", Offset = "0x868924", VA = "0x868924")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x868904", Offset = "0x868904", VA = "0x868904")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x868F94", Offset = "0x868F94", VA = "0x868F94")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x868F9C", Offset = "0x868F9C", VA = "0x868F9C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x868FD4", Offset = "0x868FD4", VA = "0x868FD4")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x869398", Offset = "0x869398", VA = "0x869398")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x869578", Offset = "0x869578", VA = "0x869578")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x86957C", Offset = "0x86957C", VA = "0x86957C")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x869710", Offset = "0x869710", VA = "0x869710")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x869A74", Offset = "0x869A74", VA = "0x869A74")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x8698DC", Offset = "0x8698DC", VA = "0x8698DC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x869C5C", Offset = "0x869C5C", VA = "0x869C5C")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x869E90", Offset = "0x869E90", VA = "0x869E90")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x869F80", Offset = "0x869F80", VA = "0x869F80")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x86A064", Offset = "0x86A064", VA = "0x86A064")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x869FE8", Offset = "0x869FE8", VA = "0x869FE8")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x86A0CC", Offset = "0x86A0CC", VA = "0x86A0CC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x86A174", Offset = "0x86A174", VA = "0x86A174")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x86A460", Offset = "0x86A460", VA = "0x86A460")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x86A4D0", Offset = "0x86A4D0", VA = "0x86A4D0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x86AF6C", Offset = "0x86AF6C", VA = "0x86AF6C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x86B014", Offset = "0x86B014", VA = "0x86B014")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x86AF04", Offset = "0x86AF04", VA = "0x86AF04")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x86B108", Offset = "0x86B108", VA = "0x86B108")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x86B144", Offset = "0x86B144", VA = "0x86B144")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BakerTransform
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x867B34", Offset = "0x867B34", VA = "0x867B34")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x867E0C", Offset = "0x867E0C", VA = "0x867E0C")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x8680E8", Offset = "0x8680E8", VA = "0x8680E8")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x86B14C", Offset = "0x86B14C", VA = "0x86B14C")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x867CB4", Offset = "0x867CB4", VA = "0x867CB4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x86B3D4", Offset = "0x86B3D4", VA = "0x86B3D4")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x868408", Offset = "0x868408", VA = "0x868408")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x867E8C", Offset = "0x867E8C", VA = "0x867E8C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(1f, 9f)]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x86B43C", Offset = "0x86B43C", VA = "0x86B43C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x86B99C", Offset = "0x86B99C", VA = "0x86B99C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x86B9B8", Offset = "0x86B9B8", VA = "0x86B9B8", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x86BA94", Offset = "0x86BA94", VA = "0x86BA94", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x86BB50", Offset = "0x86BB50", VA = "0x86BB50", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x86BCF0", Offset = "0x86BCF0", VA = "0x86BCF0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x86BF94", Offset = "0x86BF94", VA = "0x86BF94")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x86C06C", Offset = "0x86C06C", VA = "0x86C06C")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000F")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000079")]
			Update,
			[Token(Token = "0x400007A")]
			FixedUpdate,
			[Token(Token = "0x400007B")]
			LateUpdate,
			[Token(Token = "0x400007C")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x86C11C", Offset = "0x86C11C", VA = "0x86C11C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x86C124", Offset = "0x86C124", VA = "0x86C124")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x86C12C", Offset = "0x86C12C", VA = "0x86C12C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x86C134", Offset = "0x86C134", VA = "0x86C134")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x86C13C", Offset = "0x86C13C", VA = "0x86C13C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x86C144", Offset = "0x86C144", VA = "0x86C144")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x86CB64", Offset = "0x86CB64", VA = "0x86CB64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x86C14C", Offset = "0x86C14C", VA = "0x86C14C")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x86C184", Offset = "0x86C184", VA = "0x86C184")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x86C18C", Offset = "0x86C18C", VA = "0x86C18C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x86C2C4", Offset = "0x86C2C4", VA = "0x86C2C4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x86C30C", Offset = "0x86C30C", VA = "0x86C30C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x86C364", Offset = "0x86C364", VA = "0x86C364", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x86C3BC", Offset = "0x86C3BC", VA = "0x86C3BC")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x86C2F0", Offset = "0x86C2F0", VA = "0x86C2F0")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x86C548", Offset = "0x86C548", VA = "0x86C548")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x86CB28", Offset = "0x86CB28", VA = "0x86CB28")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x86CBD0", Offset = "0x86CBD0", VA = "0x86CBD0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x86CC90", Offset = "0x86CC90", VA = "0x86CC90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x86CCBC", Offset = "0x86CCBC", VA = "0x86CCBC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x86CEE0", Offset = "0x86CEE0", VA = "0x86CEE0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x86CF1C", Offset = "0x86CF1C", VA = "0x86CF1C")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public enum Axis
	{
		[Token(Token = "0x4000083")]
		X,
		[Token(Token = "0x4000084")]
		Y,
		[Token(Token = "0x4000085")]
		Z
	}
	[Token(Token = "0x2000012")]
	public class AxisTools
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x86CF38", Offset = "0x86CF38", VA = "0x86CF38")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x86D018", Offset = "0x86D018", VA = "0x86D018")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x86D050", Offset = "0x86D050", VA = "0x86D050")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x86D198", Offset = "0x86D198", VA = "0x86D198")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x86D14C", Offset = "0x86D14C", VA = "0x86D14C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x86D294", Offset = "0x86D294", VA = "0x86D294")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x86D2D8", Offset = "0x86D2D8", VA = "0x86D2D8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x86D764", Offset = "0x86D764", VA = "0x86D764")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000014")]
		public class LimbOrientation
		{
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x86DA98", Offset = "0x86DA98", VA = "0x86DA98")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x86D7E0", Offset = "0x86D7E0", VA = "0x86D7E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x86DB0C", Offset = "0x86DB0C", VA = "0x86DB0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x86D76C", Offset = "0x86D76C", VA = "0x86D76C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000016")]
		public enum BoneType
		{
			[Token(Token = "0x40000A0")]
			Unassigned,
			[Token(Token = "0x40000A1")]
			Spine,
			[Token(Token = "0x40000A2")]
			Head,
			[Token(Token = "0x40000A3")]
			Arm,
			[Token(Token = "0x40000A4")]
			Leg,
			[Token(Token = "0x40000A5")]
			Tail,
			[Token(Token = "0x40000A6")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000017")]
		public enum BoneSide
		{
			[Token(Token = "0x40000A8")]
			Center,
			[Token(Token = "0x40000A9")]
			Left,
			[Token(Token = "0x40000AA")]
			Right
		}

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x86DDC4", Offset = "0x86DDC4", VA = "0x86DDC4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x86E090", Offset = "0x86E090", VA = "0x86E090")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x86E2CC", Offset = "0x86E2CC", VA = "0x86E2CC")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x86E340", Offset = "0x86E340", VA = "0x86E340")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x86E3D4", Offset = "0x86E3D4", VA = "0x86E3D4")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x86DF78", Offset = "0x86DF78", VA = "0x86DF78")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x86E244", Offset = "0x86E244", VA = "0x86E244")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x86EB0C", Offset = "0x86EB0C", VA = "0x86EB0C")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x86E964", Offset = "0x86E964", VA = "0x86E964")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x86EA38", Offset = "0x86EA38", VA = "0x86EA38")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x86E5BC", Offset = "0x86E5BC", VA = "0x86E5BC")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x86E658", Offset = "0x86E658", VA = "0x86E658")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x86E6F4", Offset = "0x86E6F4", VA = "0x86E6F4")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x86E790", Offset = "0x86E790", VA = "0x86E790")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x86E82C", Offset = "0x86E82C", VA = "0x86E82C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x86E8C8", Offset = "0x86E8C8", VA = "0x86E8C8")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x86ECF4", Offset = "0x86ECF4", VA = "0x86ECF4")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x86E4E8", Offset = "0x86E4E8", VA = "0x86E4E8")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x86EC70", Offset = "0x86EC70", VA = "0x86EC70")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x86ED54", Offset = "0x86ED54", VA = "0x86ED54")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x86EE14", Offset = "0x86EE14", VA = "0x86EE14")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x86EBFC", Offset = "0x86EBFC", VA = "0x86EBFC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x86EB8C", Offset = "0x86EB8C", VA = "0x86EB8C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class BipedReferences
	{
		[Token(Token = "0x2000019")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000A2")]
				[Address(RVA = "0x8758CC", Offset = "0x8758CC", VA = "0x8758CC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x8758B8", Offset = "0x8758B8", VA = "0x8758B8")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x871C04", Offset = "0x871C04", VA = "0x871C04", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x871F60", Offset = "0x871F60", VA = "0x871F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x871F70", Offset = "0x871F70", VA = "0x871F70", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x8722FC", Offset = "0x8722FC", VA = "0x8722FC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x87268C", Offset = "0x87268C", VA = "0x87268C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x872DB0", Offset = "0x872DB0", VA = "0x872DB0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x872920", Offset = "0x872920", VA = "0x872920")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x873630", Offset = "0x873630", VA = "0x873630")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x87371C", Offset = "0x87371C", VA = "0x87371C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x874238", Offset = "0x874238", VA = "0x874238")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x874044", Offset = "0x874044", VA = "0x874044")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x873DE4", Offset = "0x873DE4", VA = "0x873DE4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x8737B8", Offset = "0x8737B8", VA = "0x8737B8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x874138", Offset = "0x874138", VA = "0x874138")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x874318", Offset = "0x874318", VA = "0x874318")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x874EC0", Offset = "0x874EC0", VA = "0x874EC0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x874968", Offset = "0x874968", VA = "0x874968")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x87520C", Offset = "0x87520C", VA = "0x87520C")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x874CC8", Offset = "0x874CC8", VA = "0x874CC8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x875214", Offset = "0x875214", VA = "0x875214")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x87521C", Offset = "0x87521C", VA = "0x87521C")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x8753DC", Offset = "0x8753DC", VA = "0x8753DC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x875850", Offset = "0x875850", VA = "0x875850")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x8728A0", Offset = "0x8728A0", VA = "0x8728A0")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x8758D4", Offset = "0x8758D4", VA = "0x8758D4")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x8758DC", Offset = "0x8758DC", VA = "0x8758DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x8759D4", Offset = "0x8759D4", VA = "0x8759D4")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Hierarchy
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x8757CC", Offset = "0x8757CC", VA = "0x8757CC")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x8756C0", Offset = "0x8756C0", VA = "0x8756C0")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x87391C", Offset = "0x87391C", VA = "0x87391C")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x873F34", Offset = "0x873F34", VA = "0x873F34")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x873B9C", Offset = "0x873B9C", VA = "0x873B9C")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x8759E4", Offset = "0x8759E4", VA = "0x8759E4")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x873A4C", Offset = "0x873A4C", VA = "0x873A4C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x875AD8", Offset = "0x875AD8", VA = "0x875AD8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x875E44", Offset = "0x875E44", VA = "0x875E44")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x875C3C", Offset = "0x875C3C", VA = "0x875C3C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x875FCC", Offset = "0x875FCC", VA = "0x875FCC")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x875FD4", Offset = "0x875FD4", VA = "0x875FD4")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x87605C", Offset = "0x87605C", VA = "0x87605C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000C4")]
		None,
		[Token(Token = "0x40000C5")]
		InOutCubic,
		[Token(Token = "0x40000C6")]
		InOutQuintic,
		[Token(Token = "0x40000C7")]
		InOutSine,
		[Token(Token = "0x40000C8")]
		InQuintic,
		[Token(Token = "0x40000C9")]
		InQuartic,
		[Token(Token = "0x40000CA")]
		InCubic,
		[Token(Token = "0x40000CB")]
		InQuadratic,
		[Token(Token = "0x40000CC")]
		InElastic,
		[Token(Token = "0x40000CD")]
		InElasticSmall,
		[Token(Token = "0x40000CE")]
		InElasticBig,
		[Token(Token = "0x40000CF")]
		InSine,
		[Token(Token = "0x40000D0")]
		InBack,
		[Token(Token = "0x40000D1")]
		OutQuintic,
		[Token(Token = "0x40000D2")]
		OutQuartic,
		[Token(Token = "0x40000D3")]
		OutCubic,
		[Token(Token = "0x40000D4")]
		OutInCubic,
		[Token(Token = "0x40000D5")]
		OutInQuartic,
		[Token(Token = "0x40000D6")]
		OutElastic,
		[Token(Token = "0x40000D7")]
		OutElasticSmall,
		[Token(Token = "0x40000D8")]
		OutElasticBig,
		[Token(Token = "0x40000D9")]
		OutSine,
		[Token(Token = "0x40000DA")]
		OutBack,
		[Token(Token = "0x40000DB")]
		OutBackCubic,
		[Token(Token = "0x40000DC")]
		OutBackQuartic,
		[Token(Token = "0x40000DD")]
		BackInCubic,
		[Token(Token = "0x40000DE")]
		BackInQuartic
	}
	[Token(Token = "0x200001F")]
	public class Interp
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x8760E8", Offset = "0x8760E8", VA = "0x8760E8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x876A70", Offset = "0x876A70", VA = "0x876A70")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x876AE0", Offset = "0x876AE0", VA = "0x876AE0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x8764E8", Offset = "0x8764E8", VA = "0x8764E8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x8764F4", Offset = "0x8764F4", VA = "0x8764F4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x876518", Offset = "0x876518", VA = "0x876518")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x876554", Offset = "0x876554", VA = "0x876554")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x87656C", Offset = "0x87656C", VA = "0x87656C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x876580", Offset = "0x876580", VA = "0x876580")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x876594", Offset = "0x876594", VA = "0x876594")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x8765A4", Offset = "0x8765A4", VA = "0x8765A4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x8765EC", Offset = "0x8765EC", VA = "0x8765EC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x876624", Offset = "0x876624", VA = "0x876624")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x87664C", Offset = "0x87664C", VA = "0x87664C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x876B50", Offset = "0x876B50", VA = "0x876B50")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x876680", Offset = "0x876680", VA = "0x876680")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x8766A8", Offset = "0x8766A8", VA = "0x8766A8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x8766D8", Offset = "0x8766D8", VA = "0x8766D8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x87670C", Offset = "0x87670C", VA = "0x87670C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x876750", Offset = "0x876750", VA = "0x876750")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x8767B4", Offset = "0x8767B4", VA = "0x8767B4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x876818", Offset = "0x876818", VA = "0x876818")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x87686C", Offset = "0x87686C", VA = "0x87686C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x8768C0", Offset = "0x8768C0", VA = "0x8768C0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x8768F8", Offset = "0x8768F8", VA = "0x8768F8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x87692C", Offset = "0x87692C", VA = "0x87692C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x876B84", Offset = "0x876B84", VA = "0x876B84")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x876970", Offset = "0x876970", VA = "0x876970")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x876A00", Offset = "0x876A00", VA = "0x876A00")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x876A30", Offset = "0x876A30", VA = "0x876A30")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x876C14", Offset = "0x876C14", VA = "0x876C14")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x876C1C", Offset = "0x876C1C", VA = "0x876C1C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x876CA4", Offset = "0x876CA4", VA = "0x876CA4")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x876D30", Offset = "0x876D30", VA = "0x876D30")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x876D7C", Offset = "0x876D7C", VA = "0x876D7C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x876E38", Offset = "0x876E38", VA = "0x876E38")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x876D90", Offset = "0x876D90", VA = "0x876D90")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x876E4C", Offset = "0x876E4C", VA = "0x876E4C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x876EDC", Offset = "0x876EDC", VA = "0x876EDC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x876F04", Offset = "0x876F04", VA = "0x876F04")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x876F50", Offset = "0x876F50", VA = "0x876F50")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x876FB8", Offset = "0x876FB8", VA = "0x876FB8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x877114", Offset = "0x877114", VA = "0x877114")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x87724C", Offset = "0x87724C", VA = "0x87724C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x8772A4", Offset = "0x8772A4", VA = "0x8772A4")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000022")]
	public static class QuaTools
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x8772C8", Offset = "0x8772C8", VA = "0x8772C8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x877314", Offset = "0x877314", VA = "0x877314")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x877360", Offset = "0x877360", VA = "0x877360")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x877464", Offset = "0x877464", VA = "0x877464")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x877568", Offset = "0x877568", VA = "0x877568")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x87767C", Offset = "0x87767C", VA = "0x87767C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x877724", Offset = "0x877724", VA = "0x877724")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x877830", Offset = "0x877830", VA = "0x877830")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x877998", Offset = "0x877998", VA = "0x877998")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x877B7C", Offset = "0x877B7C", VA = "0x877B7C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x877C4C", Offset = "0x877C4C", VA = "0x877C4C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x877DD0", Offset = "0x877DD0", VA = "0x877DD0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x877EDC", Offset = "0x877EDC", VA = "0x877EDC")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000023")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x60000ED")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EE")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000EF")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x878050", Offset = "0x878050", VA = "0x878050")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x87834C", Offset = "0x87834C", VA = "0x87834C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x877F34", Offset = "0x877F34", VA = "0x877F34")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x877FC8", Offset = "0x877FC8", VA = "0x877FC8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x877FCC", Offset = "0x877FCC", VA = "0x877FCC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x877FD0", Offset = "0x877FD0", VA = "0x877FD0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x877FD4", Offset = "0x877FD4", VA = "0x877FD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x87804C", Offset = "0x87804C", VA = "0x87804C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x877FFC", Offset = "0x877FFC", VA = "0x877FFC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x878310", Offset = "0x878310", VA = "0x878310")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x87811C", Offset = "0x87811C", VA = "0x87811C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x8783E4", Offset = "0x8783E4", VA = "0x8783E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x878430", Offset = "0x878430", VA = "0x878430")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x87847C", Offset = "0x87847C", VA = "0x87847C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x8784B4", Offset = "0x8784B4", VA = "0x8784B4")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x8784C4", Offset = "0x8784C4", VA = "0x8784C4")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x878578", Offset = "0x878578", VA = "0x878578")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x87862C", Offset = "0x87862C", VA = "0x87862C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x8786E0", Offset = "0x8786E0", VA = "0x8786E0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class V3Tools
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x8786E8", Offset = "0x8786E8", VA = "0x8786E8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x878744", Offset = "0x878744", VA = "0x878744")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x87877C", Offset = "0x87877C", VA = "0x87877C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x8788CC", Offset = "0x8788CC", VA = "0x8788CC")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x878A48", Offset = "0x878A48", VA = "0x878A48")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x878C78", Offset = "0x878C78", VA = "0x878C78")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x878EC8", Offset = "0x878EC8", VA = "0x878EC8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x879120", Offset = "0x879120", VA = "0x879120")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x8792CC", Offset = "0x8792CC", VA = "0x8792CC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x8794C4", Offset = "0x8794C4", VA = "0x8794C4")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x879540", Offset = "0x879540", VA = "0x879540")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000027")]
	public static class Warning
	{
		[Token(Token = "0x2000028")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x8795D0", Offset = "0x8795D0", VA = "0x8795D0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x87357C", Offset = "0x87357C", VA = "0x87357C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000029")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x87978C", Offset = "0x87978C", VA = "0x87978C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x8797D0", Offset = "0x8797D0", VA = "0x8797D0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x879814", Offset = "0x879814", VA = "0x879814")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x879858", Offset = "0x879858", VA = "0x879858")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x87989C", Offset = "0x87989C", VA = "0x87989C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x879934", Offset = "0x879934", VA = "0x879934")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x879950", Offset = "0x879950", VA = "0x879950")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x87997C", Offset = "0x87997C", VA = "0x87997C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x8799A8", Offset = "0x8799A8", VA = "0x8799A8")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x8799E4", Offset = "0x8799E4", VA = "0x8799E4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x879A24", Offset = "0x879A24", VA = "0x879A24")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x879A44", Offset = "0x879A44", VA = "0x879A44")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x879A64", Offset = "0x879A64", VA = "0x879A64")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x879A88", Offset = "0x879A88", VA = "0x879A88")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x879AB0", Offset = "0x879AB0", VA = "0x879AB0")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x879AD8", Offset = "0x879AD8", VA = "0x879AD8")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x8798B8", Offset = "0x8798B8", VA = "0x8798B8")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x879AFC", Offset = "0x879AFC", VA = "0x879AFC")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x879B08", Offset = "0x879B08", VA = "0x879B08")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x879B14", Offset = "0x879B14", VA = "0x879B14")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x879DC8", Offset = "0x879DC8", VA = "0x879DC8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x879E64", Offset = "0x879E64", VA = "0x879E64", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x87A188", Offset = "0x87A188", VA = "0x87A188", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x87A5F4", Offset = "0x87A5F4", VA = "0x87A5F4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x87A618", Offset = "0x87A618", VA = "0x87A618")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000010")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x879C50", Offset = "0x879C50", VA = "0x879C50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x87A8B4", Offset = "0x87A8B4", VA = "0x87A8B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x87A014", Offset = "0x87A014", VA = "0x87A014")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x87A6C8", Offset = "0x87A6C8", VA = "0x87A6C8")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000012")]
		public bool isValid
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x87AADC", Offset = "0x87AADC", VA = "0x87AADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000132")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x87AB3C", Offset = "0x87AB3C", VA = "0x87AB3C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x87AB44", Offset = "0x87AB44", VA = "0x87AB44", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x87ABDC", Offset = "0x87ABDC", VA = "0x87ABDC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x87ABE4", Offset = "0x87ABE4", VA = "0x87ABE4")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool positionChanged
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x87AD18", Offset = "0x87AD18", VA = "0x87AD18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x87AC14", Offset = "0x87AC14", VA = "0x87AC14", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x87AD74", Offset = "0x87AD74", VA = "0x87AD74")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x87AD7C", Offset = "0x87AD7C", VA = "0x87AD7C")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x87ADAC", Offset = "0x87ADAC", VA = "0x87ADAC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x87AE28", Offset = "0x87AE28", VA = "0x87AE28")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x87AE30", Offset = "0x87AE30", VA = "0x87AE30")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x87AF64", Offset = "0x87AF64", VA = "0x87AF64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x87AE60", Offset = "0x87AE60", VA = "0x87AE60", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x87AFBC", Offset = "0x87AFBC", VA = "0x87AFBC")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x87AFC4", Offset = "0x87AFC4", VA = "0x87AFC4")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class Constraints
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x87AFF4", Offset = "0x87AFF4", VA = "0x87AFF4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x87A134", Offset = "0x87A134", VA = "0x87A134")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x87A2FC", Offset = "0x87A2FC", VA = "0x87A2FC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x87AAD4", Offset = "0x87AAD4", VA = "0x87AAD4")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000032")]
		public enum DOF
		{
			[Token(Token = "0x400011E")]
			One,
			[Token(Token = "0x400011F")]
			Three
		}

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x87B054", Offset = "0x87B054", VA = "0x87B054")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x87B05C", Offset = "0x87B05C", VA = "0x87B05C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x87B068", Offset = "0x87B068", VA = "0x87B068")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x87B088", Offset = "0x87B088", VA = "0x87B088")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x87B0A8", Offset = "0x87B0A8", VA = "0x87B0A8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x87B0C8", Offset = "0x87B0C8", VA = "0x87B0C8")]
			set
			{
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x87B0E8", Offset = "0x87B0E8", VA = "0x87B0E8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x87B1E0", Offset = "0x87B1E0", VA = "0x87B1E0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x87B6DC", Offset = "0x87B6DC", VA = "0x87B6DC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x87B7A8", Offset = "0x87B7A8", VA = "0x87B7A8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x87B860", Offset = "0x87B860", VA = "0x87B860")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x87BEC8", Offset = "0x87BEC8", VA = "0x87BEC8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x87BED8", Offset = "0x87BED8", VA = "0x87BED8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x87BEE0", Offset = "0x87BEE0", VA = "0x87BEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x87BEEC", Offset = "0x87BEEC", VA = "0x87BEEC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x87BF60", Offset = "0x87BF60", VA = "0x87BF60")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x87C2D8", Offset = "0x87C2D8", VA = "0x87C2D8")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x87C490", Offset = "0x87C490", VA = "0x87C490")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x87C1E8", Offset = "0x87C1E8", VA = "0x87C1E8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x87C60C", Offset = "0x87C60C", VA = "0x87C60C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x87C6B4", Offset = "0x87C6B4", VA = "0x87C6B4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x87C718", Offset = "0x87C718", VA = "0x87C718")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x87C780", Offset = "0x87C780", VA = "0x87C780")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x87C7DC", Offset = "0x87C7DC", VA = "0x87C7DC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x87C7E0", Offset = "0x87C7E0", VA = "0x87C7E0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x87C7F4", Offset = "0x87C7F4", VA = "0x87C7F4")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000035")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x87C868", Offset = "0x87C868", VA = "0x87C868")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x87C870", Offset = "0x87C870", VA = "0x87C870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000160")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x87C87C", Offset = "0x87C87C", VA = "0x87C87C")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x87CB2C", Offset = "0x87CB2C", VA = "0x87CB2C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x87C940", Offset = "0x87C940", VA = "0x87C940")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x87CB50", Offset = "0x87CB50", VA = "0x87CB50")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000167")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000168")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x87CCC4", Offset = "0x87CCC4", VA = "0x87CCC4")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x87DE4C", Offset = "0x87DE4C", VA = "0x87DE4C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x87DE90", Offset = "0x87DE90", VA = "0x87DE90", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x87DED4", Offset = "0x87DED4", VA = "0x87DED4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x87DFB4", Offset = "0x87DFB4", VA = "0x87DFB4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x87E054", Offset = "0x87E054", VA = "0x87E054")]
		private void Update()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x87E0A8", Offset = "0x87E0A8", VA = "0x87E0A8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x87E6C8", Offset = "0x87E6C8", VA = "0x87E6C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x87E708", Offset = "0x87E708", VA = "0x87E708")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x87ED58", Offset = "0x87ED58", VA = "0x87ED58")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x87EE80", Offset = "0x87EE80", VA = "0x87EE80")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x87F050", Offset = "0x87F050", VA = "0x87F050")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x87F228", Offset = "0x87F228", VA = "0x87F228")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000038")]
		public class SpineEffector
		{
			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x87FF84", Offset = "0x87FF84", VA = "0x87FF84")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000189")]
			[Address(RVA = "0x87FF94", Offset = "0x87FF94", VA = "0x87FF94")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x87F2D0", Offset = "0x87F2D0", VA = "0x87F2D0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x87F314", Offset = "0x87F314", VA = "0x87F314", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x87F358", Offset = "0x87F358", VA = "0x87F358", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x87F39C", Offset = "0x87F39C", VA = "0x87F39C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x87F404", Offset = "0x87F404", VA = "0x87F404")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x87F48C", Offset = "0x87F48C", VA = "0x87F48C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x87F738", Offset = "0x87F738", VA = "0x87F738")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x87F744", Offset = "0x87F744", VA = "0x87F744")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x87F4E8", Offset = "0x87F4E8", VA = "0x87F4E8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x87F750", Offset = "0x87F750", VA = "0x87F750")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x87FAC4", Offset = "0x87FAC4", VA = "0x87FAC4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x87FC48", Offset = "0x87FC48", VA = "0x87FC48")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x87FDA8", Offset = "0x87FDA8", VA = "0x87FDA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x87FEDC", Offset = "0x87FEDC", VA = "0x87FEDC")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x87FFD8", Offset = "0x87FFD8", VA = "0x87FFD8", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x88001C", Offset = "0x88001C", VA = "0x88001C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x880060", Offset = "0x880060", VA = "0x880060", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x880078", Offset = "0x880078", VA = "0x880078")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x880284", Offset = "0x880284", VA = "0x880284")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x880364", Offset = "0x880364", VA = "0x880364")]
		private void Update()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x880A48", Offset = "0x880A48", VA = "0x880A48")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x880F00", Offset = "0x880F00", VA = "0x880F00")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x8810AC", Offset = "0x8810AC", VA = "0x8810AC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x881434", Offset = "0x881434", VA = "0x881434")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x88160C", Offset = "0x88160C", VA = "0x88160C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x881834", Offset = "0x881834", VA = "0x881834")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200003B")]
		public struct Foot
		{
			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x882418", Offset = "0x882418", VA = "0x882418")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x8818DC", Offset = "0x8818DC", VA = "0x8818DC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x881920", Offset = "0x881920", VA = "0x881920", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x881964", Offset = "0x881964", VA = "0x881964", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x88198C", Offset = "0x88198C", VA = "0x88198C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x881A90", Offset = "0x881A90", VA = "0x881A90")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x881C74", Offset = "0x881C74", VA = "0x881C74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x881CD8", Offset = "0x881CD8", VA = "0x881CD8")]
		private void Update()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x881D30", Offset = "0x881D30", VA = "0x881D30")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x88207C", Offset = "0x88207C", VA = "0x88207C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x882478", Offset = "0x882478", VA = "0x882478")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x882508", Offset = "0x882508", VA = "0x882508")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x882958", Offset = "0x882958", VA = "0x882958")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x883018", Offset = "0x883018", VA = "0x883018")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x8832D0", Offset = "0x8832D0", VA = "0x8832D0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x883404", Offset = "0x883404", VA = "0x883404")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x8836CC", Offset = "0x8836CC", VA = "0x8836CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x8836FC", Offset = "0x8836FC", VA = "0x8836FC")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x88391C", Offset = "0x88391C", VA = "0x88391C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x883AC8", Offset = "0x883AC8", VA = "0x883AC8")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x883B0C", Offset = "0x883B0C", VA = "0x883B0C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x883B50", Offset = "0x883B50", VA = "0x883B50", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x883B94", Offset = "0x883B94", VA = "0x883B94", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x883BAC", Offset = "0x883BAC", VA = "0x883BAC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x883C34", Offset = "0x883C34", VA = "0x883C34")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x883C88", Offset = "0x883C88", VA = "0x883C88")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x883F0C", Offset = "0x883F0C", VA = "0x883F0C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x884100", Offset = "0x884100", VA = "0x884100")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x884184", Offset = "0x884184", VA = "0x884184")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x884420", Offset = "0x884420", VA = "0x884420")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x884580", Offset = "0x884580", VA = "0x884580")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x884748", Offset = "0x884748", VA = "0x884748")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200003E")]
		public enum Quality
		{
			[Token(Token = "0x4000185")]
			Fastest,
			[Token(Token = "0x4000186")]
			Simple,
			[Token(Token = "0x4000187")]
			Best
		}

		[Token(Token = "0x200003F")]
		public class Leg
		{
			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000022")]
			public bool isGrounded
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x885B34", Offset = "0x885B34", VA = "0x885B34")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x885B3C", Offset = "0x885B3C", VA = "0x885B3C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x885B48", Offset = "0x885B48", VA = "0x885B48")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x885B54", Offset = "0x885B54", VA = "0x885B54")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x885B60", Offset = "0x885B60", VA = "0x885B60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x885B68", Offset = "0x885B68", VA = "0x885B68")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x885B74", Offset = "0x885B74", VA = "0x885B74")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x885B7C", Offset = "0x885B7C", VA = "0x885B7C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x885B84", Offset = "0x885B84", VA = "0x885B84")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x885B90", Offset = "0x885B90", VA = "0x885B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x885B9C", Offset = "0x885B9C", VA = "0x885B9C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x885BA4", Offset = "0x885BA4", VA = "0x885BA4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x885BAC", Offset = "0x885BAC", VA = "0x885BAC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x885BB4", Offset = "0x885BB4", VA = "0x885BB4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x885BBC", Offset = "0x885BBC", VA = "0x885BBC")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x885BD4", Offset = "0x885BD4", VA = "0x885BD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x885BF4", Offset = "0x885BF4", VA = "0x885BF4")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x885C0C", Offset = "0x885C0C", VA = "0x885C0C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x885C2C", Offset = "0x885C2C", VA = "0x885C2C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x886514", Offset = "0x886514", VA = "0x886514")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001EF")]
				[Address(RVA = "0x886664", Offset = "0x886664", VA = "0x886664")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x885C74", Offset = "0x885C74", VA = "0x885C74")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x884C78", Offset = "0x884C78", VA = "0x884C78")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x885C88", Offset = "0x885C88", VA = "0x885C88")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x8857A4", Offset = "0x8857A4", VA = "0x8857A4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x884D8C", Offset = "0x884D8C", VA = "0x884D8C")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x886128", Offset = "0x886128", VA = "0x886128")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x885CC8", Offset = "0x885CC8", VA = "0x885CC8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x8865A8", Offset = "0x8865A8", VA = "0x8865A8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x885F90", Offset = "0x885F90", VA = "0x885F90")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x886010", Offset = "0x886010", VA = "0x886010")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x886614", Offset = "0x886614", VA = "0x886614")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x886548", Offset = "0x886548", VA = "0x886548")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x8866F0", Offset = "0x8866F0", VA = "0x8866F0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x884BD8", Offset = "0x884BD8", VA = "0x884BD8")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000040")]
		public class Pelvis
		{
			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700002E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001F1")]
				[Address(RVA = "0x8868A0", Offset = "0x8868A0", VA = "0x8868A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001F2")]
				[Address(RVA = "0x8868AC", Offset = "0x8868AC", VA = "0x8868AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0x8868B8", Offset = "0x8868B8", VA = "0x8868B8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x8868C0", Offset = "0x8868C0", VA = "0x8868C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x884D50", Offset = "0x884D50", VA = "0x884D50")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x885710", Offset = "0x885710", VA = "0x885710")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x8868C8", Offset = "0x8868C8", VA = "0x8868C8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x885524", Offset = "0x885524", VA = "0x885524")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x884C70", Offset = "0x884C70", VA = "0x884C70")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x8847AC", Offset = "0x8847AC", VA = "0x8847AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x8847B4", Offset = "0x8847B4", VA = "0x8847B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x8847BC", Offset = "0x8847BC", VA = "0x8847BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x8847C4", Offset = "0x8847C4", VA = "0x8847C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x8847CC", Offset = "0x8847CC", VA = "0x8847CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x8847D4", Offset = "0x8847D4", VA = "0x8847D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x8847E0", Offset = "0x8847E0", VA = "0x8847E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x8847E8", Offset = "0x8847E8", VA = "0x8847E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x8847F0", Offset = "0x8847F0", VA = "0x8847F0")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x884808", Offset = "0x884808", VA = "0x884808")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x884828", Offset = "0x884828", VA = "0x884828")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x87EE18", Offset = "0x87EE18", VA = "0x87EE18")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x885838", Offset = "0x885838", VA = "0x885838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x884870", Offset = "0x884870", VA = "0x884870")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x884AD0", Offset = "0x884AD0", VA = "0x884AD0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x87E404", Offset = "0x87E404", VA = "0x87E404")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x87EB64", Offset = "0x87EB64", VA = "0x87EB64")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x8808D0", Offset = "0x8808D0", VA = "0x8808D0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x87DF3C", Offset = "0x87DF3C", VA = "0x87DF3C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x884D74", Offset = "0x884D74", VA = "0x884D74")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x8858EC", Offset = "0x8858EC", VA = "0x8858EC")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x885970", Offset = "0x885970", VA = "0x885970")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x885AC4", Offset = "0x885AC4", VA = "0x885AC4")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x883A74", Offset = "0x883A74", VA = "0x883A74")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x88691C", Offset = "0x88691C", VA = "0x88691C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x886960", Offset = "0x886960", VA = "0x886960", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x8869A4", Offset = "0x8869A4", VA = "0x8869A4")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x8869E8", Offset = "0x8869E8", VA = "0x8869E8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x886A2C", Offset = "0x886A2C", VA = "0x886A2C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x886A70", Offset = "0x886A70", VA = "0x886A70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x886A78", Offset = "0x886A78", VA = "0x886A78")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x886AF4", Offset = "0x886AF4", VA = "0x886AF4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x886B38", Offset = "0x886B38", VA = "0x886B38", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x886B7C", Offset = "0x886B7C", VA = "0x886B7C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x886BC0", Offset = "0x886BC0", VA = "0x886BC0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x886C04", Offset = "0x886C04", VA = "0x886C04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x886C0C", Offset = "0x886C0C", VA = "0x886C0C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x886C80", Offset = "0x886C80", VA = "0x886C80", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x886CC4", Offset = "0x886CC4", VA = "0x886CC4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x886D08", Offset = "0x886D08", VA = "0x886D08")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x886D4C", Offset = "0x886D4C", VA = "0x886D4C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x886D90", Offset = "0x886D90", VA = "0x886D90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x886D98", Offset = "0x886D98", VA = "0x886D98")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x886E0C", Offset = "0x886E0C", VA = "0x886E0C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x886E50", Offset = "0x886E50", VA = "0x886E50", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x886E94", Offset = "0x886E94", VA = "0x886E94")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x886ED8", Offset = "0x886ED8", VA = "0x886ED8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x886F1C", Offset = "0x886F1C", VA = "0x886F1C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x886F24", Offset = "0x886F24", VA = "0x886F24")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x886F98", Offset = "0x886F98", VA = "0x886F98", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x886FDC", Offset = "0x886FDC", VA = "0x886FDC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x887020", Offset = "0x887020", VA = "0x887020")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x887064", Offset = "0x887064", VA = "0x887064")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x8870A8", Offset = "0x8870A8", VA = "0x8870A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x8870B0", Offset = "0x8870B0", VA = "0x8870B0")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x887124", Offset = "0x887124", VA = "0x887124", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x887168", Offset = "0x887168", VA = "0x887168", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x8871AC", Offset = "0x8871AC", VA = "0x8871AC")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x8871F0", Offset = "0x8871F0", VA = "0x8871F0")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x887234", Offset = "0x887234", VA = "0x887234")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x887278", Offset = "0x887278", VA = "0x887278")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x8872BC", Offset = "0x8872BC", VA = "0x8872BC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x8872FC", Offset = "0x8872FC", VA = "0x8872FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x887304", Offset = "0x887304", VA = "0x887304")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x8874D4", Offset = "0x8874D4", VA = "0x8874D4")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x887990", Offset = "0x887990", VA = "0x887990")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x8879B0", Offset = "0x8879B0", VA = "0x8879B0")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x887AA0", Offset = "0x887AA0", VA = "0x887AA0")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000226")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x887B50", Offset = "0x887B50", VA = "0x887B50", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x887BC8", Offset = "0x887BC8", VA = "0x887BC8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x887C38", Offset = "0x887C38", VA = "0x887C38", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600022A")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600022B")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x886AEC", Offset = "0x886AEC", VA = "0x886AEC")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x887C88", Offset = "0x887C88", VA = "0x887C88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x887D14", Offset = "0x887D14", VA = "0x887D14")]
		private void Start()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x887D78", Offset = "0x887D78", VA = "0x887D78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x887E18", Offset = "0x887E18", VA = "0x887E18")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x887E44", Offset = "0x887E44", VA = "0x887E44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x887D9C", Offset = "0x887D9C", VA = "0x887D9C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x887EC8", Offset = "0x887EC8", VA = "0x887EC8")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x887ED0", Offset = "0x887ED0", VA = "0x887ED0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x887F14", Offset = "0x887F14", VA = "0x887F14", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x887F58", Offset = "0x887F58", VA = "0x887F58")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x887F9C", Offset = "0x887F9C", VA = "0x887F9C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x887FE0", Offset = "0x887FE0", VA = "0x887FE0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x887FE8", Offset = "0x887FE8", VA = "0x887FE8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x88805C", Offset = "0x88805C", VA = "0x88805C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x8880A0", Offset = "0x8880A0", VA = "0x8880A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x8880E4", Offset = "0x8880E4", VA = "0x8880E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x888128", Offset = "0x888128", VA = "0x888128")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x88816C", Offset = "0x88816C", VA = "0x88816C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x888174", Offset = "0x888174", VA = "0x888174")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x8881E8", Offset = "0x8881E8", VA = "0x8881E8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x88822C", Offset = "0x88822C", VA = "0x88822C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x888270", Offset = "0x888270", VA = "0x888270")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x8882B4", Offset = "0x8882B4", VA = "0x8882B4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8882F8", Offset = "0x8882F8", VA = "0x8882F8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x888300", Offset = "0x888300", VA = "0x888300")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x888374", Offset = "0x888374", VA = "0x888374", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x8883B8", Offset = "0x8883B8", VA = "0x8883B8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x8883FC", Offset = "0x8883FC", VA = "0x8883FC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x888440", Offset = "0x888440", VA = "0x888440")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x888484", Offset = "0x888484", VA = "0x888484", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x88848C", Offset = "0x88848C", VA = "0x88848C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200004E")]
		public class References
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000256")]
				[Address(RVA = "0x888EDC", Offset = "0x888EDC", VA = "0x888EDC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000257")]
				[Address(RVA = "0x888B20", Offset = "0x888B20", VA = "0x888B20")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x8894E0", Offset = "0x8894E0", VA = "0x8894E0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x8885E8", Offset = "0x8885E8", VA = "0x8885E8")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x8894D8", Offset = "0x8894D8", VA = "0x8894D8")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x888500", Offset = "0x888500", VA = "0x888500", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x888544", Offset = "0x888544", VA = "0x888544", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x888588", Offset = "0x888588", VA = "0x888588")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8885CC", Offset = "0x8885CC", VA = "0x8885CC")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x888A84", Offset = "0x888A84", VA = "0x888A84")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x888AAC", Offset = "0x888AAC", VA = "0x888AAC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x888AB4", Offset = "0x888AB4", VA = "0x888AB4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x889298", Offset = "0x889298", VA = "0x889298", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x889428", Offset = "0x889428", VA = "0x889428")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x889A24", Offset = "0x889A24", VA = "0x889A24")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x889AF4", Offset = "0x889AF4", VA = "0x889AF4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x889B14", Offset = "0x889B14", VA = "0x889B14")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x889D68", Offset = "0x889D68", VA = "0x889D68")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x889BD4", Offset = "0x889BD4", VA = "0x889BD4")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x889E4C", Offset = "0x889E4C", VA = "0x889E4C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x889EB8", Offset = "0x889EB8", VA = "0x889EB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x88A368", Offset = "0x88A368", VA = "0x88A368")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x88A4FC", Offset = "0x88A4FC", VA = "0x88A4FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x88A628", Offset = "0x88A628", VA = "0x88A628")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000052")]
		public class BendBone
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x88D88C", Offset = "0x88D88C", VA = "0x88D88C")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x88D8EC", Offset = "0x88D8EC", VA = "0x88D8EC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x88AF20", Offset = "0x88AF20", VA = "0x88AF20")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x88B2F0", Offset = "0x88B2F0", VA = "0x88B2F0")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		[LargeHeader("Position")]
		public float positionWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		public float rotationWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[LargeHeader("Stretching")]
		public float postStretchWeight;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x88A630", Offset = "0x88A630", VA = "0x88A630")]
		private void Start()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x88AA70", Offset = "0x88AA70", VA = "0x88AA70")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x88AF4C", Offset = "0x88AF4C", VA = "0x88AF4C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x88B318", Offset = "0x88B318", VA = "0x88B318")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x88BC14", Offset = "0x88BC14", VA = "0x88BC14")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x88C00C", Offset = "0x88C00C", VA = "0x88C00C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x88C41C", Offset = "0x88C41C", VA = "0x88C41C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x88CD9C", Offset = "0x88CD9C", VA = "0x88CD9C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x88B958", Offset = "0x88B958", VA = "0x88B958")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x88CFD8", Offset = "0x88CFD8", VA = "0x88CFD8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x88CCB4", Offset = "0x88CCB4", VA = "0x88CCB4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x88CBB4", Offset = "0x88CBB4", VA = "0x88CBB4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x88D2DC", Offset = "0x88D2DC", VA = "0x88D2DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x88D678", Offset = "0x88D678", VA = "0x88D678")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000054")]
		public class ChildConstraint
		{
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000033")]
			public float nominalDistance
			{
				[Token(Token = "0x600028A")]
				[Address(RVA = "0x88FC58", Offset = "0x88FC58", VA = "0x88FC58")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600028B")]
				[Address(RVA = "0x88FC60", Offset = "0x88FC60", VA = "0x88FC60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x600028C")]
				[Address(RVA = "0x88FC68", Offset = "0x88FC68", VA = "0x88FC68")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600028D")]
				[Address(RVA = "0x88FC70", Offset = "0x88FC70", VA = "0x88FC70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x88FC7C", Offset = "0x88FC7C", VA = "0x88FC7C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x88FCD8", Offset = "0x88FCD8", VA = "0x88FCD8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x88FE38", Offset = "0x88FE38", VA = "0x88FE38")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x89001C", Offset = "0x89001C", VA = "0x89001C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000055")]
		public enum Smoothing
		{
			[Token(Token = "0x4000229")]
			None,
			[Token(Token = "0x400022A")]
			Exponential,
			[Token(Token = "0x400022B")]
			Cubic
		}

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400021D")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x88D974", Offset = "0x88D974", VA = "0x88D974")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x88DAA4", Offset = "0x88DAA4", VA = "0x88DAA4")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x88DC18", Offset = "0x88DC18", VA = "0x88DC18")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x88DD48", Offset = "0x88DD48", VA = "0x88DD48")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x88DE04", Offset = "0x88DE04", VA = "0x88DE04")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x88DF20", Offset = "0x88DF20", VA = "0x88DF20")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x88E670", Offset = "0x88E670", VA = "0x88E670")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x88E0A8", Offset = "0x88E0A8", VA = "0x88E0A8")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x88EA58", Offset = "0x88EA58", VA = "0x88EA58")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x88ECEC", Offset = "0x88ECEC", VA = "0x88ECEC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x88EFBC", Offset = "0x88EFBC", VA = "0x88EFBC")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x88F358", Offset = "0x88F358", VA = "0x88F358")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x88F854", Offset = "0x88F854", VA = "0x88F854")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x88FA54", Offset = "0x88FA54", VA = "0x88FA54")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x88F740", Offset = "0x88F740", VA = "0x88F740")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x88F1F8", Offset = "0x88F1F8", VA = "0x88F1F8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x88F6D8", Offset = "0x88F6D8", VA = "0x88F6D8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x88FB30", Offset = "0x88FB30", VA = "0x88FB30")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x88F604", Offset = "0x88F604", VA = "0x88F604")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x88F958", Offset = "0x88F958", VA = "0x88F958")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x890430", Offset = "0x890430", VA = "0x890430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x890438", Offset = "0x890438", VA = "0x890438")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x890258", Offset = "0x890258", VA = "0x890258")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x890444", Offset = "0x890444", VA = "0x890444")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x8904B0", Offset = "0x8904B0", VA = "0x8904B0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x890544", Offset = "0x890544", VA = "0x890544")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x890588", Offset = "0x890588", VA = "0x890588")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x890990", Offset = "0x890990", VA = "0x890990")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x890CE4", Offset = "0x890CE4", VA = "0x890CE4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x8910AC", Offset = "0x8910AC", VA = "0x8910AC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x890858", Offset = "0x890858", VA = "0x890858")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x8908F4", Offset = "0x8908F4", VA = "0x8908F4")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKEffector
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000036")]
		public bool isEndEffector
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x891770", Offset = "0x891770", VA = "0x891770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x891778", Offset = "0x891778", VA = "0x891778")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x891714", Offset = "0x891714", VA = "0x891714")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x891784", Offset = "0x891784", VA = "0x891784")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x891808", Offset = "0x891808", VA = "0x891808")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8919D8", Offset = "0x8919D8", VA = "0x8919D8")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x891BE4", Offset = "0x891BE4", VA = "0x891BE4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x891EEC", Offset = "0x891EEC", VA = "0x891EEC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x8921B0", Offset = "0x8921B0", VA = "0x8921B0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x8922C8", Offset = "0x8922C8", VA = "0x8922C8")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x892364", Offset = "0x892364", VA = "0x892364")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x892A04", Offset = "0x892A04", VA = "0x892A04")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x892A5C", Offset = "0x892A5C", VA = "0x892A5C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x892C24", Offset = "0x892C24", VA = "0x892C24")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x892E6C", Offset = "0x892E6C", VA = "0x892E6C")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000059")]
		public class BoneMap
		{
			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000037")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002B3")]
				[Address(RVA = "0x8933CC", Offset = "0x8933CC", VA = "0x8933CC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002B6")]
				[Address(RVA = "0x893484", Offset = "0x893484", VA = "0x893484")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002CA")]
				[Address(RVA = "0x893864", Offset = "0x893864", VA = "0x893864")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x89338C", Offset = "0x89338C", VA = "0x89338C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x8933FC", Offset = "0x8933FC", VA = "0x8933FC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x893440", Offset = "0x893440", VA = "0x893440")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x893494", Offset = "0x893494", VA = "0x893494")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x893568", Offset = "0x893568", VA = "0x893568")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x893570", Offset = "0x893570", VA = "0x893570")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x89363C", Offset = "0x89363C", VA = "0x89363C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x8936A8", Offset = "0x8936A8", VA = "0x8936A8")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x893754", Offset = "0x893754", VA = "0x893754")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x8939CC", Offset = "0x8939CC", VA = "0x8939CC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x8939F8", Offset = "0x8939F8", VA = "0x8939F8")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x893A24", Offset = "0x893A24", VA = "0x893A24")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x893A4C", Offset = "0x893A4C", VA = "0x893A4C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x893B0C", Offset = "0x893B0C", VA = "0x893B0C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x893C90", Offset = "0x893C90", VA = "0x893C90")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x893CB4", Offset = "0x893CB4", VA = "0x893CB4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x893DD4", Offset = "0x893DD4", VA = "0x893DD4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x893E38", Offset = "0x893E38", VA = "0x893E38")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x893FB8", Offset = "0x893FB8", VA = "0x893FB8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x894138", Offset = "0x894138", VA = "0x894138")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x8941B4", Offset = "0x8941B4", VA = "0x8941B4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x893B80", Offset = "0x893B80", VA = "0x893B80")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x8942D0", Offset = "0x8942D0", VA = "0x8942D0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x89311C", Offset = "0x89311C", VA = "0x89311C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x893124", Offset = "0x893124", VA = "0x893124", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x893128", Offset = "0x893128", VA = "0x893128")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x893270", Offset = "0x893270", VA = "0x893270")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x893384", Offset = "0x893384", VA = "0x893384")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x8942EC", Offset = "0x8942EC", VA = "0x8942EC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x894394", Offset = "0x894394", VA = "0x894394")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x894424", Offset = "0x894424", VA = "0x894424")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x8944D0", Offset = "0x8944D0", VA = "0x8944D0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x8944E8", Offset = "0x8944E8", VA = "0x8944E8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x894504", Offset = "0x894504", VA = "0x894504", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8945AC", Offset = "0x8945AC", VA = "0x8945AC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8945C4", Offset = "0x8945C4", VA = "0x8945C4")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200005C")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000283")]
			Parent,
			[Token(Token = "0x4000284")]
			Bone1,
			[Token(Token = "0x4000285")]
			Bone2,
			[Token(Token = "0x4000286")]
			Bone3
		}

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x8945E8", Offset = "0x8945E8", VA = "0x8945E8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x89465C", Offset = "0x89465C", VA = "0x89465C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x894724", Offset = "0x894724", VA = "0x894724")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x8949DC", Offset = "0x8949DC", VA = "0x8949DC")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x894B28", Offset = "0x894B28", VA = "0x894B28")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x894CAC", Offset = "0x894CAC", VA = "0x894CAC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x894D0C", Offset = "0x894D0C", VA = "0x894D0C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x894DA4", Offset = "0x894DA4", VA = "0x894DA4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x894E4C", Offset = "0x894E4C", VA = "0x894E4C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x895100", Offset = "0x895100", VA = "0x895100")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x895160", Offset = "0x895160", VA = "0x895160")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x8952A4", Offset = "0x8952A4", VA = "0x8952A4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x8955D0", Offset = "0x8955D0", VA = "0x8955D0")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x895748", Offset = "0x895748", VA = "0x895748")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x895900", Offset = "0x895900", VA = "0x895900")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x895974", Offset = "0x895974", VA = "0x895974")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x8959D0", Offset = "0x8959D0", VA = "0x8959D0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x895A48", Offset = "0x895A48", VA = "0x895A48", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x8960C0", Offset = "0x8960C0", VA = "0x8960C0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x8960F8", Offset = "0x8960F8", VA = "0x8960F8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x89635C", Offset = "0x89635C", VA = "0x89635C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x89667C", Offset = "0x89667C", VA = "0x89667C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x89675C", Offset = "0x89675C", VA = "0x89675C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x896810", Offset = "0x896810", VA = "0x896810")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200005F")]
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

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x8970E4", Offset = "0x8970E4", VA = "0x8970E4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x897128", Offset = "0x897128", VA = "0x897128")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x897208", Offset = "0x897208", VA = "0x897208")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x897234", Offset = "0x897234", VA = "0x897234")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x897260", Offset = "0x897260", VA = "0x897260")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x8972A4", Offset = "0x8972A4", VA = "0x8972A4")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x8972E8", Offset = "0x8972E8", VA = "0x8972E8")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000060")]
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
				[Token(Token = "0x6000309")]
				[Address(RVA = "0x897348", Offset = "0x897348", VA = "0x897348")]
				get
				{
					return null;
				}
				[Token(Token = "0x600030A")]
				[Address(RVA = "0x897438", Offset = "0x897438", VA = "0x897438")]
				set
				{
				}
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x8974BC", Offset = "0x8974BC", VA = "0x8974BC")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x897728", Offset = "0x897728", VA = "0x897728")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x8979E4", Offset = "0x8979E4", VA = "0x8979E4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x897BD8", Offset = "0x897BD8", VA = "0x897BD8")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x897C00", Offset = "0x897C00", VA = "0x897C00")]
			public Bone()
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x897C6C", Offset = "0x897C6C", VA = "0x897C6C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x897CEC", Offset = "0x897CEC", VA = "0x897CEC")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000061")]
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

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x897D80", Offset = "0x897D80", VA = "0x897D80")]
			public Node()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x897D84", Offset = "0x897D84", VA = "0x897D84")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x897DB0", Offset = "0x897DB0", VA = "0x897DB0")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000062")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000063")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
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
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x896CF0", Offset = "0x896CF0", VA = "0x896CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x896CF8", Offset = "0x896CF8", VA = "0x896CF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x896A4C", Offset = "0x896A4C", VA = "0x896A4C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x896AC0", Offset = "0x896AC0", VA = "0x896AC0")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x896C3C", Offset = "0x896C3C", VA = "0x896C3C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x896CAC", Offset = "0x896CAC", VA = "0x896CAC", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x896CB8", Offset = "0x896CB8", VA = "0x896CB8")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x896CC4", Offset = "0x896CC4", VA = "0x896CC4")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x896CCC", Offset = "0x896CCC", VA = "0x896CCC")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x896CE8", Offset = "0x896CE8", VA = "0x896CE8")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002F8")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002F9")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002FA")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002FB")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002FC")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x896D04", Offset = "0x896D04", VA = "0x896D04")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x896D1C", Offset = "0x896D1C", VA = "0x896D1C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x896E40", Offset = "0x896E40", VA = "0x896E40")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x896ED8", Offset = "0x896ED8", VA = "0x896ED8")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x8970CC", Offset = "0x8970CC", VA = "0x8970CC")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
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
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x8981AC", Offset = "0x8981AC", VA = "0x8981AC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x8981DC", Offset = "0x8981DC", VA = "0x8981DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x898E2C", Offset = "0x898E2C", VA = "0x898E2C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x89936C", Offset = "0x89936C", VA = "0x89936C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x898074", Offset = "0x898074", VA = "0x898074")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x89820C", Offset = "0x89820C", VA = "0x89820C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x898498", Offset = "0x898498", VA = "0x898498", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x898D84", Offset = "0x898D84", VA = "0x898D84")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x898A20", Offset = "0x898A20", VA = "0x898A20")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x898E34", Offset = "0x898E34", VA = "0x898E34")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x8993CC", Offset = "0x8993CC", VA = "0x8993CC")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
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

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x899470", Offset = "0x899470", VA = "0x899470", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x899814", Offset = "0x899814", VA = "0x899814")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x8998C4", Offset = "0x8998C4", VA = "0x8998C4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x899A44", Offset = "0x899A44", VA = "0x899A44", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x899BA4", Offset = "0x899BA4", VA = "0x899BA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x899BE4", Offset = "0x899BE4", VA = "0x899BE4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x899C34", Offset = "0x899C34", VA = "0x899C34", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x899F94", Offset = "0x899F94", VA = "0x899F94", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x899FB4", Offset = "0x899FB4", VA = "0x899FB4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x899C8C", Offset = "0x899C8C", VA = "0x899C8C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x89A014", Offset = "0x89A014", VA = "0x89A014")]
		private void Write()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x89A18C", Offset = "0x89A18C", VA = "0x89A18C")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x89A380", Offset = "0x89A380", VA = "0x89A380")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x89A3F0", Offset = "0x89A3F0", VA = "0x89A3F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x89A460", Offset = "0x89A460", VA = "0x89A460", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x89A714", Offset = "0x89A714", VA = "0x89A714")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x89ADA4", Offset = "0x89ADA4", VA = "0x89ADA4")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
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
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x89BD68", Offset = "0x89BD68", VA = "0x89BD68", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x89ADAC", Offset = "0x89ADAC", VA = "0x89ADAC")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x89B38C", Offset = "0x89B38C", VA = "0x89B38C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x89B4BC", Offset = "0x89B4BC", VA = "0x89B4BC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x89B544", Offset = "0x89B544", VA = "0x89B544", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x89BA5C", Offset = "0x89BA5C", VA = "0x89BA5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x89BD70", Offset = "0x89BD70", VA = "0x89BD70")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x89AE84", Offset = "0x89AE84", VA = "0x89AE84")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x89B474", Offset = "0x89B474", VA = "0x89B474")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x89BD20", Offset = "0x89BD20", VA = "0x89BD20")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x89B220", Offset = "0x89B220", VA = "0x89B220")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x89C41C", Offset = "0x89C41C", VA = "0x89C41C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x89C484", Offset = "0x89C484", VA = "0x89C484")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x89C554", Offset = "0x89C554", VA = "0x89C554")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x89C61C", Offset = "0x89C61C", VA = "0x89C61C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x89B7D4", Offset = "0x89B7D4", VA = "0x89B7D4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x89B918", Offset = "0x89B918", VA = "0x89B918")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x89C70C", Offset = "0x89C70C", VA = "0x89C70C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x89C00C", Offset = "0x89C00C", VA = "0x89C00C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x89B464", Offset = "0x89B464", VA = "0x89B464")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x89CD7C", Offset = "0x89CD7C", VA = "0x89CD7C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x89C8CC", Offset = "0x89C8CC", VA = "0x89C8CC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x89BE8C", Offset = "0x89BE8C", VA = "0x89BE8C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x89BF5C", Offset = "0x89BF5C", VA = "0x89BF5C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x89CE34", Offset = "0x89CE34", VA = "0x89CE34")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
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

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x89CED0", Offset = "0x89CED0", VA = "0x89CED0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x89D594", Offset = "0x89D594", VA = "0x89D594", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x89D620", Offset = "0x89D620", VA = "0x89D620", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x89D6B4", Offset = "0x89D6B4", VA = "0x89D6B4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x89D7AC", Offset = "0x89D7AC", VA = "0x89D7AC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x89D83C", Offset = "0x89D83C", VA = "0x89D83C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x89DC3C", Offset = "0x89DC3C", VA = "0x89DC3C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x89DE34", Offset = "0x89DE34", VA = "0x89DE34", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x89DCDC", Offset = "0x89DCDC", VA = "0x89DCDC")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x89DA14", Offset = "0x89DA14", VA = "0x89DA14")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x89DEB8", Offset = "0x89DEB8", VA = "0x89DEB8")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
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

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x89DF34", Offset = "0x89DF34", VA = "0x89DF34")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x89E010", Offset = "0x89E010", VA = "0x89E010")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x88FD24", Offset = "0x88FD24", VA = "0x88FD24")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x8916C4", Offset = "0x8916C4", VA = "0x8916C4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x8907E4", Offset = "0x8907E4", VA = "0x8907E4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x89E058", Offset = "0x89E058", VA = "0x89E058", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x89E1F8", Offset = "0x89E1F8", VA = "0x89E1F8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x89E354", Offset = "0x89E354", VA = "0x89E354", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x89E554", Offset = "0x89E554", VA = "0x89E554", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x89E624", Offset = "0x89E624", VA = "0x89E624", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x89E700", Offset = "0x89E700", VA = "0x89E700", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x89E85C", Offset = "0x89E85C", VA = "0x89E85C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x89E9F4", Offset = "0x89E9F4", VA = "0x89E9F4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x89EC1C", Offset = "0x89EC1C", VA = "0x89EC1C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x89EEEC", Offset = "0x89EEEC", VA = "0x89EEEC", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x89EF24", Offset = "0x89EF24", VA = "0x89EF24", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x89EFFC", Offset = "0x89EFFC", VA = "0x89EFFC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
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
	[Token(Token = "0x200006B")]
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
	[Token(Token = "0x200006C")]
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
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x89F150", Offset = "0x89F150", VA = "0x89F150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x89F290", Offset = "0x89F290", VA = "0x89F290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x89F298", Offset = "0x89F298", VA = "0x89F298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x89F2A0", Offset = "0x89F2A0", VA = "0x89F2A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x89F2A8", Offset = "0x89F2A8", VA = "0x89F2A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x89F2B0", Offset = "0x89F2B0", VA = "0x89F2B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x89F2B8", Offset = "0x89F2B8", VA = "0x89F2B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x89F2C0", Offset = "0x89F2C0", VA = "0x89F2C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x89F2C8", Offset = "0x89F2C8", VA = "0x89F2C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x89F2D0", Offset = "0x89F2D0", VA = "0x89F2D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x89F2FC", Offset = "0x89F2FC", VA = "0x89F2FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x89F328", Offset = "0x89F328", VA = "0x89F328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x89F354", Offset = "0x89F354", VA = "0x89F354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x89F380", Offset = "0x89F380", VA = "0x89F380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x89F3A8", Offset = "0x89F3A8", VA = "0x89F3A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x89F3D4", Offset = "0x89F3D4", VA = "0x89F3D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x89F400", Offset = "0x89F400", VA = "0x89F400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x89F42C", Offset = "0x89F42C", VA = "0x89F42C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x8A15F8", Offset = "0x8A15F8", VA = "0x8A15F8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x8A1604", Offset = "0x8A1604", VA = "0x8A1604")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x89F454", Offset = "0x89F454", VA = "0x89F454")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x89F554", Offset = "0x89F554", VA = "0x89F554")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x89F4A4", Offset = "0x89F4A4", VA = "0x89F4A4")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x89F5CC", Offset = "0x89F5CC", VA = "0x89F5CC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x89F158", Offset = "0x89F158", VA = "0x89F158")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x89F694", Offset = "0x89F694", VA = "0x89F694")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x89F744", Offset = "0x89F744", VA = "0x89F744")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x89F7F0", Offset = "0x89F7F0", VA = "0x89F7F0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x89F89C", Offset = "0x89F89C", VA = "0x89F89C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x89F8A4", Offset = "0x89F8A4", VA = "0x89F8A4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x89F8CC", Offset = "0x89F8CC", VA = "0x89F8CC")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x89F98C", Offset = "0x89F98C", VA = "0x89F98C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x89FB20", Offset = "0x89FB20", VA = "0x89FB20")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x8A0EFC", Offset = "0x8A0EFC", VA = "0x8A0EFC")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x8A14AC", Offset = "0x8A14AC", VA = "0x8A14AC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x8A1508", Offset = "0x8A1508", VA = "0x8A1508")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x8A134C", Offset = "0x8A134C", VA = "0x8A134C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x8A13FC", Offset = "0x8A13FC", VA = "0x8A13FC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x8A1610", Offset = "0x8A1610", VA = "0x8A1610")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x8A16D4", Offset = "0x8A16D4", VA = "0x8A16D4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x8A17A0", Offset = "0x8A17A0", VA = "0x8A17A0")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x8A18BC", Offset = "0x8A18BC", VA = "0x8A18BC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x8A1A4C", Offset = "0x8A1A4C", VA = "0x8A1A4C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x8A1BC4", Offset = "0x8A1BC4", VA = "0x8A1BC4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x8A1E20", Offset = "0x8A1E20", VA = "0x8A1E20", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x8A1E98", Offset = "0x8A1E98", VA = "0x8A1E98")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
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
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x8A3738", Offset = "0x8A3738", VA = "0x8A3738", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x8A3740", Offset = "0x8A3740", VA = "0x8A3740", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x8A3748", Offset = "0x8A3748", VA = "0x8A3748", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x8A3BEC", Offset = "0x8A3BEC", VA = "0x8A3BEC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x8A3CA8", Offset = "0x8A3CA8", VA = "0x8A3CA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x8A2EA4", Offset = "0x8A2EA4", VA = "0x8A2EA4")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x8A3054", Offset = "0x8A3054", VA = "0x8A3054")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x8A31A0", Offset = "0x8A31A0", VA = "0x8A31A0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x8A3200", Offset = "0x8A3200", VA = "0x8A3200", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x8A3274", Offset = "0x8A3274", VA = "0x8A3274", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x8A3654", Offset = "0x8A3654", VA = "0x8A3654", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x8A365C", Offset = "0x8A365C", VA = "0x8A365C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x8A3750", Offset = "0x8A3750", VA = "0x8A3750", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x8A3754", Offset = "0x8A3754", VA = "0x8A3754", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x8A3758", Offset = "0x8A3758", VA = "0x8A3758")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x8A3CF0", Offset = "0x8A3CF0", VA = "0x8A3CF0")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x8A40A8", Offset = "0x8A40A8", VA = "0x8A40A8")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x8A433C", Offset = "0x8A433C", VA = "0x8A433C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
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

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x8A43B0", Offset = "0x8A43B0", VA = "0x8A43B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x8A4754", Offset = "0x8A4754", VA = "0x8A4754")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x8A4808", Offset = "0x8A4808", VA = "0x8A4808", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x8A4988", Offset = "0x8A4988", VA = "0x8A4988", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x8A4AE8", Offset = "0x8A4AE8", VA = "0x8A4AE8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x8A4B38", Offset = "0x8A4B38", VA = "0x8A4B38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x8A4B98", Offset = "0x8A4B98", VA = "0x8A4B98", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x8A4EF4", Offset = "0x8A4EF4", VA = "0x8A4EF4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x8A4F14", Offset = "0x8A4F14", VA = "0x8A4F14")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x8A4BF0", Offset = "0x8A4BF0", VA = "0x8A4BF0")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x8A4F98", Offset = "0x8A4F98", VA = "0x8A4F98")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x8A5378", Offset = "0x8A5378", VA = "0x8A5378")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000070")]
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
		[Token(Token = "0x2000071")]
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

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x8A6A94", Offset = "0x8A6A94", VA = "0x8A6A94")]
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
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x8A6A78", Offset = "0x8A6A78", VA = "0x8A6A78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x8A5654", Offset = "0x8A5654", VA = "0x8A5654")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x8A5698", Offset = "0x8A5698", VA = "0x8A5698")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x8A5704", Offset = "0x8A5704", VA = "0x8A5704", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x8A5C4C", Offset = "0x8A5C4C", VA = "0x8A5C4C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x8A6768", Offset = "0x8A6768", VA = "0x8A6768", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x8A6810", Offset = "0x8A6810", VA = "0x8A6810")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x8A69E0", Offset = "0x8A69E0", VA = "0x8A69E0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x8A5A60", Offset = "0x8A5A60", VA = "0x8A5A60")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x8A5D08", Offset = "0x8A5D08", VA = "0x8A5D08")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000073")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000060")]
			public Vector3 forward
			{
				[Token(Token = "0x60003E3")]
				[Address(RVA = "0x8A8928", Offset = "0x8A8928", VA = "0x8A8928")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x8A8FD8", Offset = "0x8A8FD8", VA = "0x8A8FD8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x8A7A44", Offset = "0x8A7A44", VA = "0x8A7A44")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x8A7D38", Offset = "0x8A7D38", VA = "0x8A7D38")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x8A8C70", Offset = "0x8A8C70", VA = "0x8A8C70")]
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

		[Token(Token = "0x1700005A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x8A71C8", Offset = "0x8A71C8", VA = "0x8A71C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x8A7370", Offset = "0x8A7370", VA = "0x8A7370")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x8A7294", Offset = "0x8A7294", VA = "0x8A7294")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x8A7394", Offset = "0x8A7394", VA = "0x8A7394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x8A72A4", Offset = "0x8A72A4", VA = "0x8A72A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x8A7400", Offset = "0x8A7400", VA = "0x8A7400")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x8A6C30", Offset = "0x8A6C30", VA = "0x8A6C30")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x8A6C4C", Offset = "0x8A6C4C", VA = "0x8A6C4C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x8A6C78", Offset = "0x8A6C78", VA = "0x8A6C78")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x8A6CB0", Offset = "0x8A6CB0", VA = "0x8A6CB0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x8A6CF8", Offset = "0x8A6CF8", VA = "0x8A6CF8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x8A6D50", Offset = "0x8A6D50", VA = "0x8A6D50")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x8A6DC0", Offset = "0x8A6DC0", VA = "0x8A6DC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x8A6ED8", Offset = "0x8A6ED8", VA = "0x8A6ED8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x8A7004", Offset = "0x8A7004", VA = "0x8A7004", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x8A7424", Offset = "0x8A7424", VA = "0x8A7424", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x8A7678", Offset = "0x8A7678", VA = "0x8A7678", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x8A77D8", Offset = "0x8A77D8", VA = "0x8A77D8")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x8A7A74", Offset = "0x8A7A74", VA = "0x8A7A74", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x8A7E24", Offset = "0x8A7E24", VA = "0x8A7E24", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x8A7EE8", Offset = "0x8A7EE8", VA = "0x8A7EE8")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x8A8104", Offset = "0x8A8104", VA = "0x8A8104")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x8A844C", Offset = "0x8A844C", VA = "0x8A844C")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x8A8958", Offset = "0x8A8958", VA = "0x8A8958")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x8A78A0", Offset = "0x8A78A0", VA = "0x8A78A0")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x8A8D78", Offset = "0x8A8D78", VA = "0x8A8D78")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000075")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x8AA300", Offset = "0x8AA300", VA = "0x8AA300")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x8AABA8", Offset = "0x8AABA8", VA = "0x8AABA8")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x8A56D4", Offset = "0x8A56D4", VA = "0x8A56D4")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x8AAC44", Offset = "0x8AAC44", VA = "0x8AAC44")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x8A8FE0", Offset = "0x8A8FE0", VA = "0x8A8FE0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x8A9174", Offset = "0x8A9174", VA = "0x8A9174")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x8A92F4", Offset = "0x8A92F4", VA = "0x8A92F4")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x8A9300", Offset = "0x8A9300", VA = "0x8A9300")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x8A931C", Offset = "0x8A931C", VA = "0x8A931C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x8A9328", Offset = "0x8A9328", VA = "0x8A9328")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x8A9330", Offset = "0x8A9330", VA = "0x8A9330", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x8A9440", Offset = "0x8A9440", VA = "0x8A9440", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x8A9538", Offset = "0x8A9538", VA = "0x8A9538", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x8A9578", Offset = "0x8A9578", VA = "0x8A9578", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x8A95C8", Offset = "0x8A95C8", VA = "0x8A95C8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x8A999C", Offset = "0x8A999C", VA = "0x8A999C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x8A9A18", Offset = "0x8A9A18", VA = "0x8A9A18")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x8A9F0C", Offset = "0x8A9F0C", VA = "0x8A9F0C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x8AA064", Offset = "0x8AA064", VA = "0x8AA064", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x8AA210", Offset = "0x8AA210", VA = "0x8AA210")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x8AA190", Offset = "0x8AA190", VA = "0x8AA190")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x8AA3F0", Offset = "0x8AA3F0", VA = "0x8AA3F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x8AAC38", Offset = "0x8AAC38", VA = "0x8AAC38", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x8AAC3C", Offset = "0x8AAC3C", VA = "0x8AAC3C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x8AAC40", Offset = "0x8AAC40", VA = "0x8AAC40", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x8AA9E8", Offset = "0x8AA9E8", VA = "0x8AA9E8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x8A6894", Offset = "0x8A6894", VA = "0x8A6894")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000077")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000078")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400037D")]
				YawPitch,
				[Token(Token = "0x400037E")]
				FromTo
			}

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400037A")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400037B")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000063")]
			public Vector3 position
			{
				[Token(Token = "0x600041F")]
				[Address(RVA = "0x8B0A44", Offset = "0x8B0A44", VA = "0x8B0A44")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000420")]
				[Address(RVA = "0x8B0A50", Offset = "0x8B0A50", VA = "0x8B0A50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x8B0A5C", Offset = "0x8B0A5C", VA = "0x8B0A5C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000422")]
				[Address(RVA = "0x8B0A68", Offset = "0x8B0A68", VA = "0x8B0A68")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x8B0A74", Offset = "0x8B0A74", VA = "0x8B0A74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000424")]
				[Address(RVA = "0x8B0A9C", Offset = "0x8B0A9C", VA = "0x8B0A9C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0x8B0AD0", Offset = "0x8B0AD0", VA = "0x8B0AD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000426")]
				[Address(RVA = "0x8B0B10", Offset = "0x8B0B10", VA = "0x8B0B10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x8B0B50", Offset = "0x8B0B50", VA = "0x8B0B50", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x8B13F0", Offset = "0x8B13F0", VA = "0x8B13F0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x8B169C", Offset = "0x8B169C", VA = "0x8B169C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x8B16C0", Offset = "0x8B16C0", VA = "0x8B16C0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x8AE8CC", Offset = "0x8AE8CC", VA = "0x8AE8CC")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x8B20F4", Offset = "0x8B20F4", VA = "0x8B20F4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x8B214C", Offset = "0x8B214C", VA = "0x8B214C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x8B1A10", Offset = "0x8B1A10", VA = "0x8B1A10")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0x8B1A90", Offset = "0x8B1A90", VA = "0x8B1A90")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000430")]
			[Address(RVA = "0x8B2358", Offset = "0x8B2358", VA = "0x8B2358")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x8B08AC", Offset = "0x8B08AC", VA = "0x8B08AC")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000069")]
			public float sqrMag
			{
				[Token(Token = "0x6000437")]
				[Address(RVA = "0x8B2514", Offset = "0x8B2514", VA = "0x8B2514")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000438")]
				[Address(RVA = "0x8B251C", Offset = "0x8B251C", VA = "0x8B251C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public float mag
			{
				[Token(Token = "0x6000439")]
				[Address(RVA = "0x8B2524", Offset = "0x8B2524", VA = "0x8B2524")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043A")]
				[Address(RVA = "0x8B252C", Offset = "0x8B252C", VA = "0x8B252C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000432")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000433")]
			public abstract void PreSolve();

			[Token(Token = "0x6000434")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000435")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000436")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x8B2534", Offset = "0x8B2534", VA = "0x8B2534")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x8A52B8", Offset = "0x8A52B8", VA = "0x8A52B8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x8B253C", Offset = "0x8B253C", VA = "0x8B253C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x8B25C4", Offset = "0x8B25C4", VA = "0x8B25C4")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x8B265C", Offset = "0x8B265C", VA = "0x8B265C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x8AE7A4", Offset = "0x8AE7A4", VA = "0x8AE7A4")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x8B1F8C", Offset = "0x8B1F8C", VA = "0x8B1F8C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x8B26A4", Offset = "0x8B26A4", VA = "0x8B26A4")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x8B27C8", Offset = "0x8B27C8", VA = "0x8B27C8")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x8B2470", Offset = "0x8B2470", VA = "0x8B2470")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Footstep
		{
			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700006B")]
			public bool isStepping
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x8B27DC", Offset = "0x8B27DC", VA = "0x8B27DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006C")]
			public float stepProgress
			{
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x8B27F0", Offset = "0x8B27F0", VA = "0x8B27F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x8B27F8", Offset = "0x8B27F8", VA = "0x8B27F8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x8B2800", Offset = "0x8B2800", VA = "0x8B2800")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x8B29C4", Offset = "0x8B29C4", VA = "0x8B29C4")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x8B2A0C", Offset = "0x8B2A0C", VA = "0x8B2A0C")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x8B2C30", Offset = "0x8B2C30", VA = "0x8B2C30")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x8B2E38", Offset = "0x8B2E38", VA = "0x8B2E38")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x8B301C", Offset = "0x8B301C", VA = "0x8B301C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			[Range(0.01f, 2f)]
			public float legLengthMlp;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006D")]
			public Vector3 position
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x8B3190", Offset = "0x8B3190", VA = "0x8B3190")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x8B319C", Offset = "0x8B319C", VA = "0x8B319C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x8B31A8", Offset = "0x8B31A8", VA = "0x8B31A8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x8B31B4", Offset = "0x8B31B4", VA = "0x8B31B4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public bool hasToes
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x8B31C0", Offset = "0x8B31C0", VA = "0x8B31C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x8B31C8", Offset = "0x8B31C8", VA = "0x8B31C8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000070")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x8B31D4", Offset = "0x8B31D4", VA = "0x8B31D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x8B31FC", Offset = "0x8B31FC", VA = "0x8B31FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x8B3228", Offset = "0x8B3228", VA = "0x8B3228")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x8B3254", Offset = "0x8B3254", VA = "0x8B3254")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x8AE770", Offset = "0x8AE770", VA = "0x8AE770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x8B3280", Offset = "0x8B3280", VA = "0x8B3280")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x8B328C", Offset = "0x8B328C", VA = "0x8B328C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x8B3298", Offset = "0x8B3298", VA = "0x8B3298", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x8B3848", Offset = "0x8B3848", VA = "0x8B3848", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x8B3FB8", Offset = "0x8B3FB8", VA = "0x8B3FB8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x8B3F68", Offset = "0x8B3F68", VA = "0x8B3F68")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x8B3D1C", Offset = "0x8B3D1C", VA = "0x8B3D1C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x8A5110", Offset = "0x8A5110", VA = "0x8A5110")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x8B4870", Offset = "0x8B4870", VA = "0x8B4870")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x8B4494", Offset = "0x8B4494", VA = "0x8B4494")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x8B4CC8", Offset = "0x8B4CC8", VA = "0x8B4CC8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x8B4ED0", Offset = "0x8B4ED0", VA = "0x8B4ED0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x8A556C", Offset = "0x8A556C", VA = "0x8A556C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public class Locomotion
		{
			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x17000076")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x8B4FB0", Offset = "0x8B4FB0", VA = "0x8B4FB0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x8B4FBC", Offset = "0x8B4FBC", VA = "0x8B4FBC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x8B71E8", Offset = "0x8B71E8", VA = "0x8B71E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x8B721C", Offset = "0x8B721C", VA = "0x8B721C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x8B7254", Offset = "0x8B7254", VA = "0x8B7254")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700007A")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x8B7288", Offset = "0x8B7288", VA = "0x8B7288")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x8B4FC8", Offset = "0x8B4FC8", VA = "0x8B4FC8")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x8B52E4", Offset = "0x8B52E4", VA = "0x8B52E4")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x8B54D0", Offset = "0x8B54D0", VA = "0x8B54D0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x8B5898", Offset = "0x8B5898", VA = "0x8B5898")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x8B5950", Offset = "0x8B5950", VA = "0x8B5950")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x8B6DF4", Offset = "0x8B6DF4", VA = "0x8B6DF4")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x8B6FA8", Offset = "0x8B6FA8", VA = "0x8B6FA8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x8B7038", Offset = "0x8B7038", VA = "0x8B7038")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x8B72C0", Offset = "0x8B72C0", VA = "0x8B72C0")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			public float headClampWeight;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			[Range(-180f, 180f)]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700007B")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x8B6D8C", Offset = "0x8B6D8C", VA = "0x8B6D8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0x8B73D0", Offset = "0x8B73D0", VA = "0x8B73D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x8B7404", Offset = "0x8B7404", VA = "0x8B7404")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x8B744C", Offset = "0x8B744C", VA = "0x8B744C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public VirtualBone head
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x8B6DC0", Offset = "0x8B6DC0", VA = "0x8B6DC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x8B7480", Offset = "0x8B7480", VA = "0x8B7480")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x8B7494", Offset = "0x8B7494", VA = "0x8B7494")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x8B74A8", Offset = "0x8B74A8", VA = "0x8B74A8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047D")]
				[Address(RVA = "0x8B74BC", Offset = "0x8B74BC", VA = "0x8B74BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x8B74D0", Offset = "0x8B74D0", VA = "0x8B74D0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x8B8200", Offset = "0x8B8200", VA = "0x8B8200", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x8B83E8", Offset = "0x8B83E8", VA = "0x8B83E8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x8B8B7C", Offset = "0x8B8B7C", VA = "0x8B8B7C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x8B91B8", Offset = "0x8B91B8", VA = "0x8B91B8")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x8B9B04", Offset = "0x8B9B04", VA = "0x8B9B04")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x8BA2AC", Offset = "0x8BA2AC", VA = "0x8BA2AC")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x8BACEC", Offset = "0x8BACEC", VA = "0x8BACEC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x8BAEBC", Offset = "0x8BAEBC", VA = "0x8BAEBC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x8B8DC0", Offset = "0x8B8DC0", VA = "0x8B8DC0")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x8B9FD4", Offset = "0x8B9FD4", VA = "0x8B9FD4")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x8B96F4", Offset = "0x8B96F4", VA = "0x8B96F4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x8BAF90", Offset = "0x8BAF90", VA = "0x8BAF90")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x8BA0B0", Offset = "0x8BA0B0", VA = "0x8BA0B0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x8B9D64", Offset = "0x8B9D64", VA = "0x8B9D64")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x8BB3A8", Offset = "0x8BB3A8", VA = "0x8BB3A8")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000404")]
			Pelvis,
			[Token(Token = "0x4000405")]
			Chest,
			[Token(Token = "0x4000406")]
			Head,
			[Token(Token = "0x4000407")]
			LeftHand,
			[Token(Token = "0x4000408")]
			RightHand,
			[Token(Token = "0x4000409")]
			LeftFoot,
			[Token(Token = "0x400040A")]
			RightFoot,
			[Token(Token = "0x400040B")]
			LeftHeel,
			[Token(Token = "0x400040C")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public enum RotationOffset
		{
			[Token(Token = "0x400040E")]
			Pelvis,
			[Token(Token = "0x400040F")]
			Chest,
			[Token(Token = "0x4000410")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public class VirtualBone
		{
			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x8B8170", Offset = "0x8B8170", VA = "0x8B8170")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x8B81E0", Offset = "0x8B81E0", VA = "0x8B81E0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x8BB4C4", Offset = "0x8BB4C4", VA = "0x8BB4C4")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x8BB6C4", Offset = "0x8BB6C4", VA = "0x8BB6C4")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x8BB238", Offset = "0x8BB238", VA = "0x8BB238")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x8BB824", Offset = "0x8BB824", VA = "0x8BB824")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x8BB9CC", Offset = "0x8BB9CC", VA = "0x8BB9CC")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x8BBB54", Offset = "0x8BBB54", VA = "0x8BBB54")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x8BA908", Offset = "0x8BA908", VA = "0x8BA908")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x8BBBF8", Offset = "0x8BBBF8", VA = "0x8BBBF8")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x8BA53C", Offset = "0x8BA53C", VA = "0x8BA53C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x8BBD50", Offset = "0x8BBD50", VA = "0x8BBD50")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x8BBE64", Offset = "0x8BBE64", VA = "0x8BBE64")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		private int lod;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000061")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x8B059C", Offset = "0x8B059C", VA = "0x8B059C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x8B05A4", Offset = "0x8B05A4", VA = "0x8B05A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public int LOD
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x8B05AC", Offset = "0x8B05AC", VA = "0x8B05AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x8B05B4", Offset = "0x8B05B4", VA = "0x8B05B4")]
			set
			{
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x8AAC4C", Offset = "0x8AAC4C", VA = "0x8AAC4C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x8AB0B8", Offset = "0x8AB0B8", VA = "0x8AB0B8")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x8AAF4C", Offset = "0x8AAF4C", VA = "0x8AAF4C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x8AB8E8", Offset = "0x8AB8E8", VA = "0x8AB8E8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x8ABA2C", Offset = "0x8ABA2C", VA = "0x8ABA2C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x8ABA6C", Offset = "0x8ABA6C", VA = "0x8ABA6C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x8ABB90", Offset = "0x8ABB90", VA = "0x8ABB90")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x8ABC6C", Offset = "0x8ABC6C", VA = "0x8ABC6C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x8AC438", Offset = "0x8AC438", VA = "0x8AC438", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x8AC58C", Offset = "0x8AC58C", VA = "0x8AC58C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x8AC778", Offset = "0x8AC778", VA = "0x8AC778", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x8AC7E8", Offset = "0x8AC7E8", VA = "0x8AC7E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x8AC858", Offset = "0x8AC858", VA = "0x8AC858", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x8ACA60", Offset = "0x8ACA60", VA = "0x8ACA60")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x8AB3A8", Offset = "0x8AB3A8", VA = "0x8AB3A8")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x8AB48C", Offset = "0x8AB48C", VA = "0x8AB48C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x8AB7D4", Offset = "0x8AB7D4", VA = "0x8AB7D4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x8ABD80", Offset = "0x8ABD80", VA = "0x8ABD80")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x8ACCD0", Offset = "0x8ACCD0", VA = "0x8ACCD0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x8ACD0C", Offset = "0x8ACD0C", VA = "0x8ACD0C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x8AE2A8", Offset = "0x8AE2A8", VA = "0x8AE2A8")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x8ABED0", Offset = "0x8ABED0", VA = "0x8ABED0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x8AD118", Offset = "0x8AD118", VA = "0x8AD118")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x8AE6FC", Offset = "0x8AE6FC", VA = "0x8AE6FC")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x8AE738", Offset = "0x8AE738", VA = "0x8AE738")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x8AE16C", Offset = "0x8AE16C", VA = "0x8AE16C")]
		private void Write()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x8AFEB0", Offset = "0x8AFEB0", VA = "0x8AFEB0")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x8B05C8", Offset = "0x8B05C8", VA = "0x8B05C8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform child;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x8BC018", Offset = "0x8BC018", VA = "0x8BC018")]
		public void Relax()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x8BC45C", Offset = "0x8BC45C", VA = "0x8BC45C")]
		private void Start()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x8BC84C", Offset = "0x8BC84C", VA = "0x8BC84C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x8BC8C4", Offset = "0x8BC8C4", VA = "0x8BC8C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x8BC93C", Offset = "0x8BC93C", VA = "0x8BC93C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x8BCA74", Offset = "0x8BCA74", VA = "0x8BCA74")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000082")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x8BCB14", Offset = "0x8BCB14", VA = "0x8BCB14")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x8BCB1C", Offset = "0x8BCB1C", VA = "0x8BCB1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool isPaused
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x8BCB24", Offset = "0x8BCB24", VA = "0x8BCB24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x8BCB2C", Offset = "0x8BCB2C", VA = "0x8BCB2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x8BCB38", Offset = "0x8BCB38", VA = "0x8BCB38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x8BCB40", Offset = "0x8BCB40", VA = "0x8BCB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool inInteraction
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x8BCB48", Offset = "0x8BCB48", VA = "0x8BCB48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public float progress
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x8BF17C", Offset = "0x8BF17C", VA = "0x8BF17C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x8BCBA8", Offset = "0x8BCBA8", VA = "0x8BCBA8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x8BCC44", Offset = "0x8BCC44", VA = "0x8BCC44")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x8BCD04", Offset = "0x8BCD04", VA = "0x8BCD04")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x8BCE70", Offset = "0x8BCE70", VA = "0x8BCE70")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x8BD24C", Offset = "0x8BD24C", VA = "0x8BD24C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x8BD36C", Offset = "0x8BD36C", VA = "0x8BD36C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x8BD3C0", Offset = "0x8BD3C0", VA = "0x8BD3C0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x8BDF20", Offset = "0x8BDF20", VA = "0x8BDF20")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x8BE9D4", Offset = "0x8BE9D4", VA = "0x8BE9D4")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x8BEBF4", Offset = "0x8BEBF4", VA = "0x8BEBF4")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x8BF018", Offset = "0x8BF018", VA = "0x8BF018")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x8BF37C", Offset = "0x8BF37C", VA = "0x8BF37C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x8BF5B8", Offset = "0x8BF5B8", VA = "0x8BF5B8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x8BF6D4", Offset = "0x8BF6D4", VA = "0x8BF6D4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x8BF76C", Offset = "0x8BF76C", VA = "0x8BF76C")]
		public void Update()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x8BF974", Offset = "0x8BF974", VA = "0x8BF974")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x8BFA1C", Offset = "0x8BFA1C", VA = "0x8BFA1C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x8BFAC8", Offset = "0x8BFAC8", VA = "0x8BFAC8")]
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
			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x8BF1AC", Offset = "0x8BF1AC", VA = "0x8BF1AC")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x8C0A6C", Offset = "0x8C0A6C", VA = "0x8C0A6C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class Message
		{
			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x400045F")]
			private const string empty = "";

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x8C0974", Offset = "0x8C0974", VA = "0x8C0974")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x8C0A74", Offset = "0x8C0A74", VA = "0x8C0A74")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000466")]
			private const string empty = "";

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x8C0898", Offset = "0x8C0898", VA = "0x8C0898")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x8C0A7C", Offset = "0x8C0A7C", VA = "0x8C0A7C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x8C0B2C", Offset = "0x8C0B2C", VA = "0x8C0B2C")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x8C0C04", Offset = "0x8C0C04", VA = "0x8C0C04")]
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
				[Token(Token = "0x400046A")]
				PositionWeight,
				[Token(Token = "0x400046B")]
				RotationWeight,
				[Token(Token = "0x400046C")]
				PositionOffsetX,
				[Token(Token = "0x400046D")]
				PositionOffsetY,
				[Token(Token = "0x400046E")]
				PositionOffsetZ,
				[Token(Token = "0x400046F")]
				Pull,
				[Token(Token = "0x4000470")]
				Reach,
				[Token(Token = "0x4000471")]
				RotateBoneWeight,
				[Token(Token = "0x4000472")]
				Push,
				[Token(Token = "0x4000473")]
				PushParent,
				[Token(Token = "0x4000474")]
				PoserWeight,
				[Token(Token = "0x4000475")]
				BendGoalWeight
			}

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x8C019C", Offset = "0x8C019C", VA = "0x8C019C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x8C0C18", Offset = "0x8C0C18", VA = "0x8C0C18")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class Multiplier
		{
			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x8C07A4", Offset = "0x8C07A4", VA = "0x8C07A4")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x8C0C20", Offset = "0x8C0C20", VA = "0x8C0C20")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000087")]
		public float length
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x8BFCFC", Offset = "0x8BFCFC", VA = "0x8BFCFC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x8BFD04", Offset = "0x8BFD04", VA = "0x8BFD04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x8BFD0C", Offset = "0x8BFD0C", VA = "0x8BFD0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x8BFD14", Offset = "0x8BFD14", VA = "0x8BFD14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x8BFED4", Offset = "0x8BFED4", VA = "0x8BFED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x8BF270", Offset = "0x8BF270", VA = "0x8BF270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x8BFADC", Offset = "0x8BFADC", VA = "0x8BFADC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x8BFB20", Offset = "0x8BFB20", VA = "0x8BFB20")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x8BFB64", Offset = "0x8BFB64", VA = "0x8BFB64")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x8BFBA8", Offset = "0x8BFBA8", VA = "0x8BFBA8")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x8BFBEC", Offset = "0x8BFBEC", VA = "0x8BFBEC")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x8BFC30", Offset = "0x8BFC30", VA = "0x8BFC30")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x8BFC74", Offset = "0x8BFC74", VA = "0x8BFC74")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x8BFCB8", Offset = "0x8BFCB8", VA = "0x8BFCB8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x8BFD1C", Offset = "0x8BFD1C", VA = "0x8BFD1C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x8BFF54", Offset = "0x8BFF54", VA = "0x8BFF54")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x8BD9E0", Offset = "0x8BD9E0", VA = "0x8BD9E0")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x8C00CC", Offset = "0x8C00CC", VA = "0x8C00CC")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x8BD89C", Offset = "0x8BD89C", VA = "0x8BD89C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x8BD9D8", Offset = "0x8BD9D8", VA = "0x8BD9D8")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x8BE5CC", Offset = "0x8BE5CC", VA = "0x8BE5CC")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x8BEE0C", Offset = "0x8BEE0C", VA = "0x8BEE0C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x8C07D4", Offset = "0x8C07D4", VA = "0x8C07D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x8C01B8", Offset = "0x8C01B8", VA = "0x8C01B8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x8C00D4", Offset = "0x8C00D4", VA = "0x8C00D4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x8C0748", Offset = "0x8C0748", VA = "0x8C0748")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x8C07D8", Offset = "0x8C07D8", VA = "0x8C07D8")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x8C0834", Offset = "0x8C0834", VA = "0x8C0834")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008B")]
		public bool inInteraction
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x8C0E50", Offset = "0x8C0E50", VA = "0x8C0E50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x8C28F8", Offset = "0x8C28F8", VA = "0x8C28F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x8C2900", Offset = "0x8C2900", VA = "0x8C2900")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x8C2908", Offset = "0x8C2908", VA = "0x8C2908")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x8C2910", Offset = "0x8C2910", VA = "0x8C2910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x8C0C30", Offset = "0x8C0C30", VA = "0x8C0C30")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x8C0C74", Offset = "0x8C0C74", VA = "0x8C0C74")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x8C0CB8", Offset = "0x8C0CB8", VA = "0x8C0CB8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x8C0CFC", Offset = "0x8C0CFC", VA = "0x8C0CFC")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x8C0D40", Offset = "0x8C0D40", VA = "0x8C0D40")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x8C0D84", Offset = "0x8C0D84", VA = "0x8C0D84")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x8C0DC8", Offset = "0x8C0DC8", VA = "0x8C0DC8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x8C0E0C", Offset = "0x8C0E0C", VA = "0x8C0E0C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x8C0FC8", Offset = "0x8C0FC8", VA = "0x8C0FC8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x8C1080", Offset = "0x8C1080", VA = "0x8C1080")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x8C1138", Offset = "0x8C1138", VA = "0x8C1138")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x8C11D0", Offset = "0x8C11D0", VA = "0x8C11D0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x8C12B4", Offset = "0x8C12B4", VA = "0x8C12B4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x8C13AC", Offset = "0x8C13AC", VA = "0x8C13AC")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x8C1430", Offset = "0x8C1430", VA = "0x8C1430")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x8C14B4", Offset = "0x8C14B4", VA = "0x8C14B4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x8C1538", Offset = "0x8C1538", VA = "0x8C1538")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x8C15A0", Offset = "0x8C15A0", VA = "0x8C15A0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x8C1608", Offset = "0x8C1608", VA = "0x8C1608")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x8C1664", Offset = "0x8C1664", VA = "0x8C1664")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x8C16E4", Offset = "0x8C16E4", VA = "0x8C16E4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x8C178C", Offset = "0x8C178C", VA = "0x8C178C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x8C185C", Offset = "0x8C185C", VA = "0x8C185C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x8C1AEC", Offset = "0x8C1AEC", VA = "0x8C1AEC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x8C1CC0", Offset = "0x8C1CC0", VA = "0x8C1CC0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x8C1F30", Offset = "0x8C1F30", VA = "0x8C1F30")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x8C21BC", Offset = "0x8C21BC", VA = "0x8C21BC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x8C21F4", Offset = "0x8C21F4", VA = "0x8C21F4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x8C2254", Offset = "0x8C2254", VA = "0x8C2254")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x8C2380", Offset = "0x8C2380", VA = "0x8C2380")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x8C2564", Offset = "0x8C2564", VA = "0x8C2564")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x8C27D8", Offset = "0x8C27D8", VA = "0x8C27D8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x8C2018", Offset = "0x8C2018", VA = "0x8C2018")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x8C2918", Offset = "0x8C2918", VA = "0x8C2918")]
		public void Start()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x8C323C", Offset = "0x8C323C", VA = "0x8C323C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x8C325C", Offset = "0x8C325C", VA = "0x8C325C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x8C3278", Offset = "0x8C3278", VA = "0x8C3278")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x8C3294", Offset = "0x8C3294", VA = "0x8C3294")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x8C32E8", Offset = "0x8C32E8", VA = "0x8C32E8")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x8C346C", Offset = "0x8C346C", VA = "0x8C346C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x8C3568", Offset = "0x8C3568", VA = "0x8C3568")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x8C38C4", Offset = "0x8C38C4", VA = "0x8C38C4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x8C39DC", Offset = "0x8C39DC", VA = "0x8C39DC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x8C3CC4", Offset = "0x8C3CC4", VA = "0x8C3CC4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x8C2FDC", Offset = "0x8C2FDC", VA = "0x8C2FDC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x8C3DF4", Offset = "0x8C3DF4", VA = "0x8C3DF4")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x8C3F00", Offset = "0x8C3F00", VA = "0x8C3F00")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x8C3F88", Offset = "0x8C3F88", VA = "0x8C3F88")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x8C4048", Offset = "0x8C4048", VA = "0x8C4048")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x8C4060", Offset = "0x8C4060", VA = "0x8C4060")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x8C0EE8", Offset = "0x8C0EE8", VA = "0x8C0EE8")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x8C19D8", Offset = "0x8C19D8", VA = "0x8C19D8")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x8C44D8", Offset = "0x8C44D8", VA = "0x8C44D8")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public class Multiplier
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x8C4DF0", Offset = "0x8C4DF0", VA = "0x8C4DF0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x8C4B60", Offset = "0x8C4B60", VA = "0x8C4B60")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x8C4BA4", Offset = "0x8C4BA4", VA = "0x8C4BA4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x8C4BE8", Offset = "0x8C4BE8", VA = "0x8C4BE8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x8C4C2C", Offset = "0x8C4C2C", VA = "0x8C4C2C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x8C4C70", Offset = "0x8C4C70", VA = "0x8C4C70")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x8C4CB4", Offset = "0x8C4CB4", VA = "0x8C4CB4")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x8C4CF8", Offset = "0x8C4CF8", VA = "0x8C4CF8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x8C4D3C", Offset = "0x8C4D3C", VA = "0x8C4D3C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x8C0138", Offset = "0x8C0138", VA = "0x8C0138")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x8BF2F0", Offset = "0x8BF2F0", VA = "0x8BF2F0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x8BDA74", Offset = "0x8BDA74", VA = "0x8BDA74")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x8C4D80", Offset = "0x8C4D80", VA = "0x8C4D80")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		public class CharacterPosition
		{
			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0x8C5064", Offset = "0x8C5064", VA = "0x8C5064")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600053B")]
				[Address(RVA = "0x8C5070", Offset = "0x8C5070", VA = "0x8C5070")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0x8C5130", Offset = "0x8C5130", VA = "0x8C5130")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0x8C5894", Offset = "0x8C5894", VA = "0x8C5894")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class CameraPosition
		{
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600053E")]
			[Address(RVA = "0x8C58A8", Offset = "0x8C58A8", VA = "0x8C58A8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0x8C5A20", Offset = "0x8C5A20", VA = "0x8C5A20")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000540")]
			[Address(RVA = "0x8C5D28", Offset = "0x8C5D28", VA = "0x8C5D28")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000094")]
			public class Interaction
			{
				[Token(Token = "0x40004AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000543")]
				[Address(RVA = "0x8C5DAC", Offset = "0x8C5DAC", VA = "0x8C5DAC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x8C4F50", Offset = "0x8C4F50", VA = "0x8C4F50")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0x8C5D9C", Offset = "0x8C5D9C", VA = "0x8C5D9C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x8C4DF8", Offset = "0x8C4DF8", VA = "0x8C4DF8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x8C4E3C", Offset = "0x8C4E3C", VA = "0x8C4E3C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x8C4E80", Offset = "0x8C4E80", VA = "0x8C4E80")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x8C4EC4", Offset = "0x8C4EC4", VA = "0x8C4EC4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x8C4F08", Offset = "0x8C4F08", VA = "0x8C4F08")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x8C4F4C", Offset = "0x8C4F4C", VA = "0x8C4F4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x8C3710", Offset = "0x8C3710", VA = "0x8C3710")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x8C5000", Offset = "0x8C5000", VA = "0x8C5000")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public class Map
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x8C60AC", Offset = "0x8C60AC", VA = "0x8C60AC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x8C6404", Offset = "0x8C6404", VA = "0x8C6404")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x8C63C4", Offset = "0x8C63C4", VA = "0x8C63C4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x8C6248", Offset = "0x8C6248", VA = "0x8C6248")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x8C5DB4", Offset = "0x8C5DB4", VA = "0x8C5DB4", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x8C6154", Offset = "0x8C6154", VA = "0x8C6154", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x8C6158", Offset = "0x8C6158", VA = "0x8C6158", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x8C6368", Offset = "0x8C6368", VA = "0x8C6368", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x8C60F8", Offset = "0x8C60F8", VA = "0x8C60F8")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x8C6018", Offset = "0x8C6018", VA = "0x8C6018")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x8C6448", Offset = "0x8C6448", VA = "0x8C6448")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x8C6468", Offset = "0x8C6468", VA = "0x8C6468", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x8C6538", Offset = "0x8C6538", VA = "0x8C6538", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x8C6710", Offset = "0x8C6710", VA = "0x8C6710", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x8C67F8", Offset = "0x8C67F8", VA = "0x8C67F8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x8C6598", Offset = "0x8C6598", VA = "0x8C6598")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x8C6B28", Offset = "0x8C6B28", VA = "0x8C6B28")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000555")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x8C6B38", Offset = "0x8C6B38", VA = "0x8C6B38")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000557")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000558")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000559")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x8C6B44", Offset = "0x8C6B44", VA = "0x8C6B44", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x8C6B88", Offset = "0x8C6B88", VA = "0x8C6B88", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x8C6BB4", Offset = "0x8C6BB4", VA = "0x8C6BB4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x8C6458", Offset = "0x8C6458", VA = "0x8C6458")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200009A")]
		public class Rigidbone
		{
			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x8C7BD8", Offset = "0x8C7BD8", VA = "0x8C7BD8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x8C7D80", Offset = "0x8C7D80", VA = "0x8C7D80")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x8C7E54", Offset = "0x8C7E54", VA = "0x8C7E54")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009B")]
		public class Child
		{
			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x8C8094", Offset = "0x8C8094", VA = "0x8C8094")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x8C8100", Offset = "0x8C8100", VA = "0x8C8100")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x8C8210", Offset = "0x8C8210", VA = "0x8C8210")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0x8C846C", Offset = "0x8C846C", VA = "0x8C846C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600057B")]
				[Address(RVA = "0x8C84B4", Offset = "0x8C84B4", VA = "0x8C84B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x8C8254", Offset = "0x8C8254", VA = "0x8C8254")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x8C827C", Offset = "0x8C827C", VA = "0x8C827C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x8C8280", Offset = "0x8C8280", VA = "0x8C8280", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x8C8474", Offset = "0x8C8474", VA = "0x8C8474", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000090")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x8C6BF8", Offset = "0x8C6BF8", VA = "0x8C6BF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ikUsed
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x8C7598", Offset = "0x8C7598", VA = "0x8C7598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x8C6BCC", Offset = "0x8C6BCC", VA = "0x8C6BCC")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x8C6C5C", Offset = "0x8C6C5C", VA = "0x8C6C5C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x8C6D78", Offset = "0x8C6D78", VA = "0x8C6D78")]
		public void Start()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x8C6D04", Offset = "0x8C6D04", VA = "0x8C6D04")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x8C7230", Offset = "0x8C7230", VA = "0x8C7230")]
		private void Update()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x8C7458", Offset = "0x8C7458", VA = "0x8C7458")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x8C74FC", Offset = "0x8C74FC", VA = "0x8C74FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x8C76EC", Offset = "0x8C76EC", VA = "0x8C76EC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x8C756C", Offset = "0x8C756C", VA = "0x8C756C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x8C76B8", Offset = "0x8C76B8", VA = "0x8C76B8")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x8C7770", Offset = "0x8C7770", VA = "0x8C7770")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8C7710", Offset = "0x8C7710", VA = "0x8C7710")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x8C6CA4", Offset = "0x8C6CA4", VA = "0x8C6CA4")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x8C748C", Offset = "0x8C748C", VA = "0x8C748C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x8C796C", Offset = "0x8C796C", VA = "0x8C796C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x8C7AA4", Offset = "0x8C7AA4", VA = "0x8C7AA4")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000094")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x8C8920", Offset = "0x8C8920", VA = "0x8C8920")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x8C892C", Offset = "0x8C892C", VA = "0x8C892C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x8C895C", Offset = "0x8C895C", VA = "0x8C895C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x8C8964", Offset = "0x8C8964", VA = "0x8C8964")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x8C84BC", Offset = "0x8C84BC", VA = "0x8C84BC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x8C84F8", Offset = "0x8C84F8", VA = "0x8C84F8")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x8C8510", Offset = "0x8C8510", VA = "0x8C8510")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x8C8890", Offset = "0x8C8890", VA = "0x8C8890")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x8C88F4", Offset = "0x8C88F4", VA = "0x8C88F4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000585")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x8C8794", Offset = "0x8C8794", VA = "0x8C8794")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x8C8970", Offset = "0x8C8970", VA = "0x8C8970")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x8C8974", Offset = "0x8C8974", VA = "0x8C8974")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x8C899C", Offset = "0x8C899C", VA = "0x8C899C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x8C8A70", Offset = "0x8C8A70", VA = "0x8C8A70")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x8C8CC8", Offset = "0x8C8CC8", VA = "0x8C8CC8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x8C8E1C", Offset = "0x8C8E1C", VA = "0x8C8E1C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x8C8E7C", Offset = "0x8C8E7C", VA = "0x8C8E7C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x8C8EC0", Offset = "0x8C8EC0", VA = "0x8C8EC0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x8C8F04", Offset = "0x8C8F04", VA = "0x8C8F04")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x8C8F48", Offset = "0x8C8F48", VA = "0x8C8F48")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x8C8F8C", Offset = "0x8C8F8C", VA = "0x8C8F8C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x8C8FC4", Offset = "0x8C8FC4", VA = "0x8C8FC4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x8C92E8", Offset = "0x8C92E8", VA = "0x8C92E8")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x8C92F8", Offset = "0x8C92F8", VA = "0x8C92F8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x8C933C", Offset = "0x8C933C", VA = "0x8C933C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x8C9380", Offset = "0x8C9380", VA = "0x8C9380")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x8C93C4", Offset = "0x8C93C4", VA = "0x8C93C4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x8C9408", Offset = "0x8C9408", VA = "0x8C9408", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x8C9424", Offset = "0x8C9424", VA = "0x8C9424")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x8C966C", Offset = "0x8C966C", VA = "0x8C966C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class ReachCone
		{
			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000097")]
			public Vector3 o
			{
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0x8CB564", Offset = "0x8CB564", VA = "0x8CB564")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 a
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0x8CB590", Offset = "0x8CB590", VA = "0x8CB590")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 b
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x8CB5C0", Offset = "0x8CB5C0", VA = "0x8CB5C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 c
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0x8CB5F0", Offset = "0x8CB5F0", VA = "0x8CB5F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isValid
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x8CAA8C", Offset = "0x8CAA8C", VA = "0x8CAA8C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x8CAF30", Offset = "0x8CAF30", VA = "0x8CAF30")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x8CB0A8", Offset = "0x8CB0A8", VA = "0x8CB0A8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class LimitPoint
		{
			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x8CAA9C", Offset = "0x8CAA9C", VA = "0x8CAA9C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public LimitPoint[] points;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x8C96D0", Offset = "0x8C96D0", VA = "0x8C96D0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x8C9714", Offset = "0x8C9714", VA = "0x8C9714")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x8C9758", Offset = "0x8C9758", VA = "0x8C9758")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x8C979C", Offset = "0x8C979C", VA = "0x8C979C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x8C97E0", Offset = "0x8C97E0", VA = "0x8C97E0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x8C9EC4", Offset = "0x8C9EC4", VA = "0x8C9EC4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x8C9F4C", Offset = "0x8C9F4C", VA = "0x8C9F4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x8CA598", Offset = "0x8CA598", VA = "0x8CA598")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x8C9878", Offset = "0x8C9878", VA = "0x8C9878")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x8CAB00", Offset = "0x8CAB00", VA = "0x8CAB00")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x8CB31C", Offset = "0x8CB31C", VA = "0x8CB31C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x8CB364", Offset = "0x8CB364", VA = "0x8CB364")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x8CB3C4", Offset = "0x8CB3C4", VA = "0x8CB3C4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x8CA2F4", Offset = "0x8CA2F4", VA = "0x8CA2F4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x8CB430", Offset = "0x8CB430", VA = "0x8CB430")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x8CB4FC", Offset = "0x8CB4FC", VA = "0x8CB4FC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x8CB620", Offset = "0x8CB620", VA = "0x8CB620")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x8CB664", Offset = "0x8CB664", VA = "0x8CB664")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x8CB6A8", Offset = "0x8CB6A8", VA = "0x8CB6A8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x8CB6EC", Offset = "0x8CB6EC", VA = "0x8CB6EC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x8CB730", Offset = "0x8CB730", VA = "0x8CB730")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x8CB74C", Offset = "0x8CB74C", VA = "0x8CB74C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x8CB784", Offset = "0x8CB784", VA = "0x8CB784")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x8CBB30", Offset = "0x8CBB30", VA = "0x8CBB30")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x8CC814", Offset = "0x8CC814", VA = "0x8CC814", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0x8CC85C", Offset = "0x8CC85C", VA = "0x8CC85C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x8CC614", Offset = "0x8CC614", VA = "0x8CC614")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x8CC720", Offset = "0x8CC720", VA = "0x8CC720", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x8CC724", Offset = "0x8CC724", VA = "0x8CC724", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x8CC81C", Offset = "0x8CC81C", VA = "0x8CC81C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700009C")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x8CBBBC", Offset = "0x8CBBBC", VA = "0x8CBBBC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x8CBB3C", Offset = "0x8CBB3C", VA = "0x8CBB3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x8CBC40", Offset = "0x8CBC40", VA = "0x8CBC40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x8CC178", Offset = "0x8CC178", VA = "0x8CC178")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x8CC2FC", Offset = "0x8CC2FC", VA = "0x8CC2FC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x8CC5A0", Offset = "0x8CC5A0", VA = "0x8CC5A0")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__33))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x8CC63C", Offset = "0x8CC63C", VA = "0x8CC63C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Pose
		{
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x8CC934", Offset = "0x8CC934", VA = "0x8CC934")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x8CCEB0", Offset = "0x8CCEB0", VA = "0x8CCEB0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x8CCEB8", Offset = "0x8CCEB8", VA = "0x8CCEB8")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x8CC864", Offset = "0x8CC864", VA = "0x8CC864")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x8CCDE4", Offset = "0x8CCDE4", VA = "0x8CCDE4")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x8CCE44", Offset = "0x8CCE44", VA = "0x8CCE44")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000AA")]
			public class EffectorLink
			{
				[Token(Token = "0x400052C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400052D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x8CD37C", Offset = "0x8CD37C", VA = "0x8CD37C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x8CD024", Offset = "0x8CD024", VA = "0x8CD024")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x8CD354", Offset = "0x8CD354", VA = "0x8CD354")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x8CD364", Offset = "0x8CD364", VA = "0x8CD364")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x8CCED4", Offset = "0x8CCED4", VA = "0x8CCED4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x8CD334", Offset = "0x8CD334", VA = "0x8CD334")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x8CD384", Offset = "0x8CD384", VA = "0x8CD384", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x8CD3EC", Offset = "0x8CD3EC", VA = "0x8CD3EC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x8CD68C", Offset = "0x8CD68C", VA = "0x8CD68C")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x8CD6A8", Offset = "0x8CD6A8", VA = "0x8CD6A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x8CD744", Offset = "0x8CD744", VA = "0x8CD744")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x8CD804", Offset = "0x8CD804", VA = "0x8CD804")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A0")]
			public bool inProgress
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x8CD8A8", Offset = "0x8CD8A8", VA = "0x8CD8A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A1")]
			protected float crossFader
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x8CDDA8", Offset = "0x8CDDA8", VA = "0x8CDDA8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x8CDDB0", Offset = "0x8CDDB0", VA = "0x8CDDB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected float timer
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x8CDDB8", Offset = "0x8CDDB8", VA = "0x8CDDB8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x8CDDC0", Offset = "0x8CDDC0", VA = "0x8CDDC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 force
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x8CDDC8", Offset = "0x8CDDC8", VA = "0x8CDDC8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0x8CDDD4", Offset = "0x8CDDD4", VA = "0x8CDDD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected Vector3 point
			{
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0x8CDDE0", Offset = "0x8CDDE0", VA = "0x8CDDE0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0x8CDDEC", Offset = "0x8CDDEC", VA = "0x8CDDEC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x8CDC70", Offset = "0x8CDC70", VA = "0x8CDC70")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x8CD97C", Offset = "0x8CD97C", VA = "0x8CD97C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E9")]
			protected abstract float GetLength();

			[Token(Token = "0x60005EA")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005EB")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x8CDDF8", Offset = "0x8CDDF8", VA = "0x8CDDF8")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B0")]
			public class EffectorLink
			{
				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000545")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000546")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000547")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x8CE12C", Offset = "0x8CE12C", VA = "0x8CE12C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x8CDF88", Offset = "0x8CDF88", VA = "0x8CDF88")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F3")]
				[Address(RVA = "0x8CE1DC", Offset = "0x8CE1DC", VA = "0x8CE1DC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x8CDE0C", Offset = "0x8CDE0C", VA = "0x8CDE0C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x8CDF28", Offset = "0x8CDF28", VA = "0x8CDF28", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x8CDF9C", Offset = "0x8CDF9C", VA = "0x8CDF9C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x8CE1C8", Offset = "0x8CE1C8", VA = "0x8CE1C8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B2")]
			public class BoneLink
			{
				[Token(Token = "0x400054B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x400054C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x400054D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400054E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x8CE4AC", Offset = "0x8CE4AC", VA = "0x8CE4AC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x8CE2C8", Offset = "0x8CE2C8", VA = "0x8CE2C8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x8CE64C", Offset = "0x8CE64C", VA = "0x8CE64C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x8CE1E4", Offset = "0x8CE1E4", VA = "0x8CE1E4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x8CE270", Offset = "0x8CE270", VA = "0x8CE270", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x8CE2D4", Offset = "0x8CE2D4", VA = "0x8CE2D4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x8CE638", Offset = "0x8CE638", VA = "0x8CE638")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009F")]
		public bool inProgress
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x8CD80C", Offset = "0x8CD80C", VA = "0x8CD80C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x8CD8BC", Offset = "0x8CD8BC", VA = "0x8CD8BC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x8CDA54", Offset = "0x8CDA54", VA = "0x8CDA54")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x8CDD98", Offset = "0x8CDD98", VA = "0x8CDD98")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public abstract class Offset
		{
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A5")]
			protected float crossFader
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x8CEBBC", Offset = "0x8CEBBC", VA = "0x8CEBBC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x8CEBC4", Offset = "0x8CEBC4", VA = "0x8CEBC4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected float timer
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x8CEBCC", Offset = "0x8CEBCC", VA = "0x8CEBCC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x8CEBD4", Offset = "0x8CEBD4", VA = "0x8CEBD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x8CEBDC", Offset = "0x8CEBDC", VA = "0x8CEBDC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x8CEBE8", Offset = "0x8CEBE8", VA = "0x8CEBE8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x8CEBF4", Offset = "0x8CEBF4", VA = "0x8CEBF4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000605")]
				[Address(RVA = "0x8CEC00", Offset = "0x8CEC00", VA = "0x8CEC00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x8CEA6C", Offset = "0x8CEA6C", VA = "0x8CEA6C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x8CE768", Offset = "0x8CE768", VA = "0x8CE768")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000608")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000609")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600060A")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x8CEC0C", Offset = "0x8CEC0C", VA = "0x8CEC0C")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B6")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000560")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000561")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000562")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x8CEFF0", Offset = "0x8CEFF0", VA = "0x8CEFF0")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x8CEE14", Offset = "0x8CEE14", VA = "0x8CEE14")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000612")]
				[Address(RVA = "0x8CF084", Offset = "0x8CF084", VA = "0x8CF084")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x8CEC20", Offset = "0x8CEC20", VA = "0x8CEC20", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x8CEDB4", Offset = "0x8CEDB4", VA = "0x8CEDB4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x8CEE28", Offset = "0x8CEE28", VA = "0x8CEE28", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x8CF068", Offset = "0x8CF068", VA = "0x8CF068")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B8")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000567")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000568")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000569")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000617")]
				[Address(RVA = "0x8CF458", Offset = "0x8CF458", VA = "0x8CF458")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000618")]
				[Address(RVA = "0x8CF1BC", Offset = "0x8CF1BC", VA = "0x8CF1BC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000619")]
				[Address(RVA = "0x8CF574", Offset = "0x8CF574", VA = "0x8CF574")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x8CF08C", Offset = "0x8CF08C", VA = "0x8CF08C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x8CF164", Offset = "0x8CF164", VA = "0x8CF164", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x8CF1C8", Offset = "0x8CF1C8", VA = "0x8CF1C8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x8CF560", Offset = "0x8CF560", VA = "0x8CF560")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x8CE6B0", Offset = "0x8CE6B0", VA = "0x8CE6B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x8CE848", Offset = "0x8CE848", VA = "0x8CE848")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x8CEB9C", Offset = "0x8CEB9C", VA = "0x8CEB9C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000BB")]
			public class EffectorLink
			{
				[Token(Token = "0x4000577")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000578")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000620")]
				[Address(RVA = "0x8CFB3C", Offset = "0x8CFB3C", VA = "0x8CFB3C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x8CF644", Offset = "0x8CF644", VA = "0x8CF644")]
			public void Reset()
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x8CF7C4", Offset = "0x8CF7C4", VA = "0x8CF7C4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x8CFB20", Offset = "0x8CFB20", VA = "0x8CFB20")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x8CF5D8", Offset = "0x8CF5D8", VA = "0x8CF5D8")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x8CF720", Offset = "0x8CF720", VA = "0x8CF720", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x8CFB10", Offset = "0x8CFB10", VA = "0x8CFB10")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000A9")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x8CFBAC", Offset = "0x8CFBAC", VA = "0x8CFBAC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x8CFB44", Offset = "0x8CFB44", VA = "0x8CFB44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x8CFC30", Offset = "0x8CFC30", VA = "0x8CFC30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x8D0124", Offset = "0x8D0124", VA = "0x8D0124")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x8D02A8", Offset = "0x8D02A8", VA = "0x8D02A8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x8D04F4", Offset = "0x8D04F4", VA = "0x8D04F4")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BE")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x8D06FC", Offset = "0x8D06FC", VA = "0x8D06FC")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x8D098C", Offset = "0x8D098C", VA = "0x8D098C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x8D09FC", Offset = "0x8D09FC", VA = "0x8D09FC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x8D0A44", Offset = "0x8D0A44", VA = "0x8D0A44")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x8D0BC0", Offset = "0x8D0BC0", VA = "0x8D0BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x8D0C08", Offset = "0x8D0C08", VA = "0x8D0C08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x8D0600", Offset = "0x8D0600", VA = "0x8D0600")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x8D0A4C", Offset = "0x8D0A4C", VA = "0x8D0A4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x8D0A50", Offset = "0x8D0A50", VA = "0x8D0A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x8D0BC8", Offset = "0x8D0BC8", VA = "0x8D0BC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AA")]
		protected float deltaTime
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x8CD004", Offset = "0x8CD004", VA = "0x8CD004")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000628")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x8CD3CC", Offset = "0x8CD3CC", VA = "0x8CD3CC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x8D058C", Offset = "0x8D058C", VA = "0x8D058C")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x8D0628", Offset = "0x8D0628", VA = "0x8D0628")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x8CFA68", Offset = "0x8CFA68", VA = "0x8CFA68")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x8D0860", Offset = "0x8D0860", VA = "0x8D0860", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x8CD344", Offset = "0x8CD344", VA = "0x8CD344")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0x8D1060", Offset = "0x8D1060", VA = "0x8D1060", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x8D10A8", Offset = "0x8D10A8", VA = "0x8D10A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x8D0CC4", Offset = "0x8D0CC4", VA = "0x8D0CC4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x8D0EEC", Offset = "0x8D0EEC", VA = "0x8D0EEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x8D0EF0", Offset = "0x8D0EF0", VA = "0x8D0EF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x8D1068", Offset = "0x8D1068", VA = "0x8D1068", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AD")]
		protected float deltaTime
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x8D0C10", Offset = "0x8D0C10", VA = "0x8D0C10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600063A")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x8D0C30", Offset = "0x8D0C30", VA = "0x8D0C30", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x8D0C50", Offset = "0x8D0C50", VA = "0x8D0C50")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x8D0CEC", Offset = "0x8D0CEC", VA = "0x8D0CEC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x8D0DC0", Offset = "0x8D0DC0", VA = "0x8D0DC0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x8CEBAC", Offset = "0x8CEBAC", VA = "0x8CEBAC")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class EffectorLink
		{
			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x8D10B0", Offset = "0x8D10B0", VA = "0x8D10B0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x8D1408", Offset = "0x8D1408", VA = "0x8D1408")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x8CD5D8", Offset = "0x8CD5D8", VA = "0x8CD5D8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x8D1300", Offset = "0x8D1300", VA = "0x8D1300")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x8D13A4", Offset = "0x8D13A4", VA = "0x8D13A4")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000C6")]
			public class EffectorLink
			{
				[Token(Token = "0x40005B4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x6000651")]
				[Address(RVA = "0x8D1A5C", Offset = "0x8D1A5C", VA = "0x8D1A5C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x8D1480", Offset = "0x8D1480", VA = "0x8D1480")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x8D1620", Offset = "0x8D1620", VA = "0x8D1620")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x8D1728", Offset = "0x8D1728", VA = "0x8D1728")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x8D1A48", Offset = "0x8D1A48", VA = "0x8D1A48")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x8D1410", Offset = "0x8D1410", VA = "0x8D1410", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x8D1610", Offset = "0x8D1610", VA = "0x8D1610")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000C9")]
			public class EffectorLink
			{
				[Token(Token = "0x40005D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000661")]
				[Address(RVA = "0x8D2E08", Offset = "0x8D2E08", VA = "0x8D2E08")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x8D1C00", Offset = "0x8D1C00", VA = "0x8D1C00")]
			public void Start()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x8D2780", Offset = "0x8D2780", VA = "0x8D2780")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x8D2DF4", Offset = "0x8D2DF4", VA = "0x8D2DF4")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public enum Handedness
		{
			[Token(Token = "0x40005D6")]
			Right,
			[Token(Token = "0x40005D7")]
			Left
		}

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B0")]
		public bool isFinished
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x8D1A64", Offset = "0x8D1A64", VA = "0x8D1A64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x8D2984", Offset = "0x8D2984", VA = "0x8D2984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x8D29C0", Offset = "0x8D29C0", VA = "0x8D29C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform primaryHand
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x8D294C", Offset = "0x8D294C", VA = "0x8D294C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x8D2968", Offset = "0x8D2968", VA = "0x8D2968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x8D1A88", Offset = "0x8D1A88", VA = "0x8D1A88")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x8D1AB4", Offset = "0x8D1AB4", VA = "0x8D1AB4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x8D1CD4", Offset = "0x8D1CD4", VA = "0x8D1CD4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x8D29FC", Offset = "0x8D29FC", VA = "0x8D29FC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x8D2B14", Offset = "0x8D2B14", VA = "0x8D2B14")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x8D2B64", Offset = "0x8D2B64", VA = "0x8D2B64", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x8D2D68", Offset = "0x8D2D68", VA = "0x8D2D68")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x8D2E10", Offset = "0x8D2E10", VA = "0x8D2E10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x8D2F24", Offset = "0x8D2F24", VA = "0x8D2F24")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x8D3000", Offset = "0x8D3000", VA = "0x8D3000")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x8D3404", Offset = "0x8D3404", VA = "0x8D3404")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x8D3438", Offset = "0x8D3438", VA = "0x8D3438")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x8D3564", Offset = "0x8D3564", VA = "0x8D3564")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public class Settings
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x8D611C", Offset = "0x8D611C", VA = "0x8D611C")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000CF")]
			public class Target
			{
				[Token(Token = "0x40005F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40005F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40005FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x600066F")]
				[Address(RVA = "0x8D5254", Offset = "0x8D5254", VA = "0x8D5254")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000670")]
				[Address(RVA = "0x8D5CAC", Offset = "0x8D5CAC", VA = "0x8D5CAC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x8D4958", Offset = "0x8D4958", VA = "0x8D4958")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x8D3578", Offset = "0x8D3578", VA = "0x8D3578")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x8D366C", Offset = "0x8D366C", VA = "0x8D366C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x8D4960", Offset = "0x8D4960", VA = "0x8D4960")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x8D5308", Offset = "0x8D5308", VA = "0x8D5308")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x8D5D08", Offset = "0x8D5D08", VA = "0x8D5D08")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float LODDistance;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float squaredDistance;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VRIK ik;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float sqrMag;

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x8D6320", Offset = "0x8D6320", VA = "0x8D6320")]
		private void Start()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x8D6384", Offset = "0x8D6384", VA = "0x8D6384")]
		private void Update()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x8D6428", Offset = "0x8D6428", VA = "0x8D6428")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x8D64C4", Offset = "0x8D64C4", VA = "0x8D64C4")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B5")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x8D64D4", Offset = "0x8D64D4", VA = "0x8D64D4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x8D64E0", Offset = "0x8D64E0", VA = "0x8D64E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x8D64EC", Offset = "0x8D64EC", VA = "0x8D64EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x8D5040", Offset = "0x8D5040", VA = "0x8D5040")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x8D5F7C", Offset = "0x8D5F7C", VA = "0x8D5F7C")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x8D6608", Offset = "0x8D6608", VA = "0x8D6608")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x8D69D0", Offset = "0x8D69D0", VA = "0x8D69D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x8D6AFC", Offset = "0x8D6AFC", VA = "0x8D6AFC")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000D2")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class Offset
		{
			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x8D6BC0", Offset = "0x8D6BC0", VA = "0x8D6BC0")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x8D6E3C", Offset = "0x8D6E3C", VA = "0x8D6E3C")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x8D6B04", Offset = "0x8D6B04", VA = "0x8D6B04")]
		private void Start()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x8D6B5C", Offset = "0x8D6B5C", VA = "0x8D6B5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x8D6D70", Offset = "0x8D6D70", VA = "0x8D6D70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x8D6E34", Offset = "0x8D6E34", VA = "0x8D6E34")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x8D6E44", Offset = "0x8D6E44", VA = "0x8D6E44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x8D6EC4", Offset = "0x8D6EC4", VA = "0x8D6EC4")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x8D6ECC", Offset = "0x8D6ECC", VA = "0x8D6ECC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x8D6F38", Offset = "0x8D6F38", VA = "0x8D6F38")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x8D6F98", Offset = "0x8D6F98", VA = "0x8D6F98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x8D6FD0", Offset = "0x8D6FD0", VA = "0x8D6FD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x8D728C", Offset = "0x8D728C", VA = "0x8D728C")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x8D7294", Offset = "0x8D7294", VA = "0x8D7294")]
		private void Start()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x8D72CC", Offset = "0x8D72CC", VA = "0x8D72CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x8D7418", Offset = "0x8D7418", VA = "0x8D7418")]
		private void Pose()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x8D759C", Offset = "0x8D759C", VA = "0x8D759C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x8D7780", Offset = "0x8D7780", VA = "0x8D7780")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x8D7810", Offset = "0x8D7810", VA = "0x8D7810")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x8D7824", Offset = "0x8D7824", VA = "0x8D7824")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x8D7990", Offset = "0x8D7990", VA = "0x8D7990")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x8D7B8C", Offset = "0x8D7B8C", VA = "0x8D7B8C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x8D7BBC", Offset = "0x8D7BBC", VA = "0x8D7BBC")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x8D7FE8", Offset = "0x8D7FE8", VA = "0x8D7FE8")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x8D8008", Offset = "0x8D8008", VA = "0x8D8008")]
		private void Update()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x8D8924", Offset = "0x8D8924", VA = "0x8D8924")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x8D86A0", Offset = "0x8D86A0", VA = "0x8D86A0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x8D8A34", Offset = "0x8D8A34", VA = "0x8D8A34")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000B6")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x8D8A60", Offset = "0x8D8A60", VA = "0x8D8A60")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x8D8AE0", Offset = "0x8D8AE0", VA = "0x8D8AE0")]
		private void Update()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x8D8E24", Offset = "0x8D8E24", VA = "0x8D8E24")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000DD")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x8DAEC8", Offset = "0x8DAEC8", VA = "0x8DAEC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x8DAF10", Offset = "0x8DAF10", VA = "0x8DAF10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x8DABD4", Offset = "0x8DABD4", VA = "0x8DABD4")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x8DABFC", Offset = "0x8DABFC", VA = "0x8DABFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x8DAC00", Offset = "0x8DAC00", VA = "0x8DAC00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x8DAED0", Offset = "0x8DAED0", VA = "0x8DAED0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000B7")]
		public bool isStepping
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x8D8E38", Offset = "0x8D8E38", VA = "0x8D8E38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		public Vector3 position
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x8D8A04", Offset = "0x8D8A04", VA = "0x8D8A04")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x8D8E4C", Offset = "0x8D8E4C", VA = "0x8D8E4C")]
			set
			{
			}
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x8D8E98", Offset = "0x8D8E98", VA = "0x8D8E98")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x8D9118", Offset = "0x8D9118", VA = "0x8D9118")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x8D92F0", Offset = "0x8D92F0", VA = "0x8D92F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x8D9514", Offset = "0x8D9514", VA = "0x8D9514")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x8D97A4", Offset = "0x8D97A4", VA = "0x8D97A4")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x8D990C", Offset = "0x8D990C", VA = "0x8D990C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x8D9464", Offset = "0x8D9464", VA = "0x8D9464")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x8D9B44", Offset = "0x8D9B44", VA = "0x8D9B44")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x8DAF18", Offset = "0x8DAF18", VA = "0x8DAF18")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x8DAFF4", Offset = "0x8DAFF4", VA = "0x8DAFF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x8DB26C", Offset = "0x8DB26C", VA = "0x8DB26C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public struct Warp
		{
			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000676")]
			PositionOffset,
			[Token(Token = "0x4000677")]
			Position
		}

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x8DB274", Offset = "0x8DB274", VA = "0x8DB274", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x8DB294", Offset = "0x8DB294", VA = "0x8DB294")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x8DB4AC", Offset = "0x8DB4AC", VA = "0x8DB4AC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x8DB764", Offset = "0x8DB764", VA = "0x8DB764")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x8DB7F8", Offset = "0x8DB7F8", VA = "0x8DB7F8")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x8DB800", Offset = "0x8DB800", VA = "0x8DB800", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x8DB858", Offset = "0x8DB858", VA = "0x8DB858")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x8DBA60", Offset = "0x8DBA60", VA = "0x8DBA60", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x8DBC88", Offset = "0x8DBC88", VA = "0x8DBC88")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	[RequireComponent(typeof(AimIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x8DBC9C", Offset = "0x8DBC9C", VA = "0x8DBC9C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x8DBE70", Offset = "0x8DBE70", VA = "0x8DBE70", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x8DBEE0", Offset = "0x8DBEE0", VA = "0x8DBEE0")]
		private void Read()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x8DC018", Offset = "0x8DC018", VA = "0x8DC018")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x8DC074", Offset = "0x8DC074", VA = "0x8DC074")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x8DC6BC", Offset = "0x8DC6BC", VA = "0x8DC6BC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x8DC4D0", Offset = "0x8DC4D0", VA = "0x8DC4D0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x8DC960", Offset = "0x8DC960", VA = "0x8DC960")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x8DCA8C", Offset = "0x8DCA8C", VA = "0x8DCA8C")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x8DCAA8", Offset = "0x8DCAA8", VA = "0x8DCAA8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x8DCB90", Offset = "0x8DCB90", VA = "0x8DCB90", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x8DCEE4", Offset = "0x8DCEE4", VA = "0x8DCEE4")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x8DCFD4", Offset = "0x8DCFD4", VA = "0x8DCFD4")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BB")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x8DD27C", Offset = "0x8DD27C", VA = "0x8DD27C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BC")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x8DD2FC", Offset = "0x8DD2FC", VA = "0x8DD2FC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x8DD01C", Offset = "0x8DD01C", VA = "0x8DD01C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x8DD08C", Offset = "0x8DD08C", VA = "0x8DD08C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x8DD37C", Offset = "0x8DD37C", VA = "0x8DD37C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x8DD384", Offset = "0x8DD384", VA = "0x8DD384", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x8DD7E0", Offset = "0x8DD7E0", VA = "0x8DD7E0")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x8DD7E8", Offset = "0x8DD7E8", VA = "0x8DD7E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x8DD8A0", Offset = "0x8DD8A0", VA = "0x8DD8A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x8DDCFC", Offset = "0x8DDCFC", VA = "0x8DDCFC")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x8DDD9C", Offset = "0x8DDD9C", VA = "0x8DDD9C")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public class Limb
		{
			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x8DDF30", Offset = "0x8DDF30", VA = "0x8DDF30")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x8DE054", Offset = "0x8DE054", VA = "0x8DE054")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x8DDE0C", Offset = "0x8DDE0C", VA = "0x8DDE0C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x8DDFA8", Offset = "0x8DDFA8", VA = "0x8DDFA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x8DE040", Offset = "0x8DE040", VA = "0x8DE040")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x8DE044", Offset = "0x8DE044", VA = "0x8DE044")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x8DE064", Offset = "0x8DE064", VA = "0x8DE064")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x8DE0CC", Offset = "0x8DE0CC", VA = "0x8DE0CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x8DE1A0", Offset = "0x8DE1A0", VA = "0x8DE1A0")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x8DE1A8", Offset = "0x8DE1A8", VA = "0x8DE1A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x8DE200", Offset = "0x8DE200", VA = "0x8DE200")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x8DE398", Offset = "0x8DE398", VA = "0x8DE398")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x8DE3A0", Offset = "0x8DE3A0", VA = "0x8DE3A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x8DE480", Offset = "0x8DE480", VA = "0x8DE480")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x8DE50C", Offset = "0x8DE50C", VA = "0x8DE50C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x8DE9E0", Offset = "0x8DE9E0", VA = "0x8DE9E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x8DEB0C", Offset = "0x8DEB0C", VA = "0x8DEB0C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x8DEB14", Offset = "0x8DEB14", VA = "0x8DEB14")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x8DEC74", Offset = "0x8DEC74", VA = "0x8DEC74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x8DEC80", Offset = "0x8DEC80", VA = "0x8DEC80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x8DEF40", Offset = "0x8DEF40", VA = "0x8DEF40")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x8DF0CC", Offset = "0x8DF0CC", VA = "0x8DF0CC")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x8DED44", Offset = "0x8DED44", VA = "0x8DED44")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x8DFD84", Offset = "0x8DFD84", VA = "0x8DFD84")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[RequireComponent(typeof(FPSAiming))]
	[RequireComponent(typeof(Animator))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x8DFDA4", Offset = "0x8DFDA4", VA = "0x8DFDA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x8DFE34", Offset = "0x8DFE34", VA = "0x8DFE34")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x8DFF30", Offset = "0x8DFF30", VA = "0x8DFF30")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x8DFFDC", Offset = "0x8DFFDC", VA = "0x8DFFDC")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x8DFFEC", Offset = "0x8DFFEC", VA = "0x8DFFEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x8E013C", Offset = "0x8E013C", VA = "0x8E013C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x8E02A0", Offset = "0x8E02A0", VA = "0x8E02A0")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x8E02B0", Offset = "0x8E02B0", VA = "0x8E02B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x8E047C", Offset = "0x8E047C", VA = "0x8E047C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x8E088C", Offset = "0x8E088C", VA = "0x8E088C")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x8E089C", Offset = "0x8E089C", VA = "0x8E089C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x8E0984", Offset = "0x8E0984", VA = "0x8E0984")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x8E0A70", Offset = "0x8E0A70", VA = "0x8E0A70")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x8E0A78", Offset = "0x8E0A78", VA = "0x8E0A78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x8E0F78", Offset = "0x8E0F78", VA = "0x8E0F78")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x8E0F80", Offset = "0x8E0F80", VA = "0x8E0F80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x8E0FD8", Offset = "0x8E0FD8", VA = "0x8E0FD8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x8E1284", Offset = "0x8E1284", VA = "0x8E1284")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F5")]
		public class Partner
		{
			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000BD")]
			private Transform neck
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x8E1A90", Offset = "0x8E1A90", VA = "0x8E1A90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x8E12B4", Offset = "0x8E12B4", VA = "0x8E12B4")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x8E1330", Offset = "0x8E1330", VA = "0x8E1330")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x8E1928", Offset = "0x8E1928", VA = "0x8E1928")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x8E1ADC", Offset = "0x8E1ADC", VA = "0x8E1ADC")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x8E128C", Offset = "0x8E128C", VA = "0x8E128C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x8E12D4", Offset = "0x8E12D4", VA = "0x8E12D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x8E1918", Offset = "0x8E1918", VA = "0x8E1918")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public enum Mode
		{
			[Token(Token = "0x4000702")]
			Position,
			[Token(Token = "0x4000703")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000F8")]
		public class Absorber
		{
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x8E1C68", Offset = "0x8E1C68", VA = "0x8E1C68")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x8E1E50", Offset = "0x8E1E50", VA = "0x8E1E50")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x8E1E74", Offset = "0x8E1E74", VA = "0x8E1E74")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x8E1F84", Offset = "0x8E1F84", VA = "0x8E1F84")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x8E213C", Offset = "0x8E213C", VA = "0x8E213C")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x8E1AF0", Offset = "0x8E1AF0", VA = "0x8E1AF0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x8E1BE8", Offset = "0x8E1BE8", VA = "0x8E1BE8")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x8E1D44", Offset = "0x8E1D44", VA = "0x8E1D44", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x8E1F08", Offset = "0x8E1F08", VA = "0x8E1F08")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x8E1FF4", Offset = "0x8E1FF4", VA = "0x8E1FF4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x8E212C", Offset = "0x8E212C", VA = "0x8E212C")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x8E219C", Offset = "0x8E219C", VA = "0x8E219C")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x8E2214", Offset = "0x8E2214", VA = "0x8E2214")]
		private void Update()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x8E22E4", Offset = "0x8E22E4", VA = "0x8E22E4")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x8E242C", Offset = "0x8E242C", VA = "0x8E242C")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public class EffectorLink
		{
			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x8E26AC", Offset = "0x8E26AC", VA = "0x8E26AC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x8E2440", Offset = "0x8E2440", VA = "0x8E2440", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x8E252C", Offset = "0x8E252C", VA = "0x8E252C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x8E26A4", Offset = "0x8E26A4", VA = "0x8E26A4")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x8E26BC", Offset = "0x8E26BC", VA = "0x8E26BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x8E29D0", Offset = "0x8E29D0", VA = "0x8E29D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x8E31CC", Offset = "0x8E31CC", VA = "0x8E31CC")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000BE")]
		private bool holding
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x8E344C", Offset = "0x8E344C", VA = "0x8E344C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x8E3238", Offset = "0x8E3238", VA = "0x8E3238")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071A")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x8E346C", Offset = "0x8E346C", VA = "0x8E346C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x8E365C", Offset = "0x8E365C", VA = "0x8E365C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x8E37CC", Offset = "0x8E37CC", VA = "0x8E37CC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x8E389C", Offset = "0x8E389C", VA = "0x8E389C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x8E39BC", Offset = "0x8E39BC", VA = "0x8E39BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x8E3B30", Offset = "0x8E3B30", VA = "0x8E3B30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x8E3D6C", Offset = "0x8E3D6C", VA = "0x8E3D6C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x8E3D80", Offset = "0x8E3D80", VA = "0x8E3D80", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x8E3F60", Offset = "0x8E3F60", VA = "0x8E3F60")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x8E3F74", Offset = "0x8E3F74", VA = "0x8E3F74", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x8E4088", Offset = "0x8E4088", VA = "0x8E4088")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x8E409C", Offset = "0x8E409C", VA = "0x8E409C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x8E4134", Offset = "0x8E4134", VA = "0x8E4134")]
		private void Update()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x8E424C", Offset = "0x8E424C", VA = "0x8E424C")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x8E4254", Offset = "0x8E4254", VA = "0x8E4254")]
		private void Start()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x8E42AC", Offset = "0x8E42AC", VA = "0x8E42AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x8E42F8", Offset = "0x8E42F8", VA = "0x8E42F8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x8E4390", Offset = "0x8E4390", VA = "0x8E4390")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x8E4708", Offset = "0x8E4708", VA = "0x8E4708", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000737")]
				[Address(RVA = "0x8E4750", Offset = "0x8E4750", VA = "0x8E4750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x8E4524", Offset = "0x8E4524", VA = "0x8E4524")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x8E455C", Offset = "0x8E455C", VA = "0x8E455C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x8E4560", Offset = "0x8E4560", VA = "0x8E4560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x8E4710", Offset = "0x8E4710", VA = "0x8E4710", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x8E43A0", Offset = "0x8E43A0", VA = "0x8E43A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x8E4464", Offset = "0x8E4464", VA = "0x8E4464")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x8E44A0", Offset = "0x8E44A0", VA = "0x8E44A0")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x8E454C", Offset = "0x8E454C", VA = "0x8E454C")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600073E")]
				[Address(RVA = "0x8E49F4", Offset = "0x8E49F4", VA = "0x8E49F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000740")]
				[Address(RVA = "0x8E4A3C", Offset = "0x8E4A3C", VA = "0x8E4A3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x8E4880", Offset = "0x8E4880", VA = "0x8E4880")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x8E48B0", Offset = "0x8E48B0", VA = "0x8E48B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x8E48B4", Offset = "0x8E48B4", VA = "0x8E48B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x8E49FC", Offset = "0x8E49FC", VA = "0x8E49FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x8E4758", Offset = "0x8E4758", VA = "0x8E4758")]
		private void Start()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x8E480C", Offset = "0x8E480C", VA = "0x8E480C")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x8E48A8", Offset = "0x8E48A8", VA = "0x8E48A8")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class EffectorLink
		{
			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x8E4AA8", Offset = "0x8E4AA8", VA = "0x8E4AA8")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x8E567C", Offset = "0x8E567C", VA = "0x8E567C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x8E4EB0", Offset = "0x8E4EB0", VA = "0x8E4EB0")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x8E5758", Offset = "0x8E5758", VA = "0x8E5758")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x8E583C", Offset = "0x8E583C", VA = "0x8E583C")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x8E58C8", Offset = "0x8E58C8", VA = "0x8E58C8")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x8E5950", Offset = "0x8E5950", VA = "0x8E5950")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x8E5468", Offset = "0x8E5468", VA = "0x8E5468")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x8E59D8", Offset = "0x8E59D8", VA = "0x8E59D8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x8E4A44", Offset = "0x8E4A44", VA = "0x8E4A44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x8E4E50", Offset = "0x8E4E50", VA = "0x8E4E50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x8E53B8", Offset = "0x8E53B8", VA = "0x8E53B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x8E5674", Offset = "0x8E5674", VA = "0x8E5674")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x8E5A0C", Offset = "0x8E5A0C", VA = "0x8E5A0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x8E5A3C", Offset = "0x8E5A3C", VA = "0x8E5A3C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x8E5AEC", Offset = "0x8E5AEC", VA = "0x8E5AEC")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x8E5B00", Offset = "0x8E5B00", VA = "0x8E5B00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x8E5D18", Offset = "0x8E5D18", VA = "0x8E5D18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x8E5FB4", Offset = "0x8E5FB4", VA = "0x8E5FB4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x8E607C", Offset = "0x8E607C", VA = "0x8E607C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x8E61A8", Offset = "0x8E61A8", VA = "0x8E61A8")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x8E61B0", Offset = "0x8E61B0", VA = "0x8E61B0", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x8E62C8", Offset = "0x8E62C8", VA = "0x8E62C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x8E6490", Offset = "0x8E6490", VA = "0x8E6490")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x8E64AC", Offset = "0x8E64AC", VA = "0x8E64AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x8E66B4", Offset = "0x8E66B4", VA = "0x8E66B4")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x8E6720", Offset = "0x8E6720", VA = "0x8E6720")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200010D")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0x8E6E90", Offset = "0x8E6E90", VA = "0x8E6E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000767")]
				[Address(RVA = "0x8E6ED8", Offset = "0x8E6ED8", VA = "0x8E6ED8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x8E6B18", Offset = "0x8E6B18", VA = "0x8E6B18")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x8E6D08", Offset = "0x8E6D08", VA = "0x8E6D08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x8E6D0C", Offset = "0x8E6D0C", VA = "0x8E6D0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x8E6E98", Offset = "0x8E6E98", VA = "0x8E6E98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x8E6728", Offset = "0x8E6728", VA = "0x8E6728")]
		private void Start()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x8E6864", Offset = "0x8E6864", VA = "0x8E6864")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x8E67F0", Offset = "0x8E67F0", VA = "0x8E67F0")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x8E6B40", Offset = "0x8E6B40", VA = "0x8E6B40")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x8E6C18", Offset = "0x8E6C18", VA = "0x8E6C18")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x8E6CEC", Offset = "0x8E6CEC", VA = "0x8E6CEC")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x8E6EE0", Offset = "0x8E6EE0", VA = "0x8E6EE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x8E6F48", Offset = "0x8E6F48", VA = "0x8E6F48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x8E6FF4", Offset = "0x8E6FF4", VA = "0x8E6FF4")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Part
		{
			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x8E7068", Offset = "0x8E7068", VA = "0x8E7068")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x8E71A4", Offset = "0x8E71A4", VA = "0x8E71A4")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x8E7004", Offset = "0x8E7004", VA = "0x8E7004")]
		private void Update()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x8E719C", Offset = "0x8E719C", VA = "0x8E719C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000111")]
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

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x8E71AC", Offset = "0x8E71AC", VA = "0x8E71AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x8E72FC", Offset = "0x8E72FC", VA = "0x8E72FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x8E7460", Offset = "0x8E7460", VA = "0x8E7460")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000112")]
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

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x8E7470", Offset = "0x8E7470", VA = "0x8E7470")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x8E75D0", Offset = "0x8E75D0", VA = "0x8E75D0")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000113")]
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

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x8E7644", Offset = "0x8E7644", VA = "0x8E7644")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x8E7694", Offset = "0x8E7694", VA = "0x8E7694")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x8E786C", Offset = "0x8E786C", VA = "0x8E786C")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000114")]
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

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x8E78C4", Offset = "0x8E78C4", VA = "0x8E78C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x8E7DF4", Offset = "0x8E7DF4", VA = "0x8E7DF4")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000115")]
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

		[Token(Token = "0x170000C5")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x8E7E70", Offset = "0x8E7E70", VA = "0x8E7E70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x8E7E50", Offset = "0x8E7E50", VA = "0x8E7E50", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x8E7E78", Offset = "0x8E7E78", VA = "0x8E7E78")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x8E7ED8", Offset = "0x8E7ED8", VA = "0x8E7ED8", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x8DCED4", Offset = "0x8DCED4", VA = "0x8DCED4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x8E82C8", Offset = "0x8E82C8", VA = "0x8E82C8", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x8E805C", Offset = "0x8E805C", VA = "0x8E805C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x8E82D8", Offset = "0x8E82D8", VA = "0x8E82D8")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000116")]
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

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x8E82F0", Offset = "0x8E82F0", VA = "0x8E82F0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x8E8350", Offset = "0x8E8350", VA = "0x8E8350", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x8E83E0", Offset = "0x8E83E0", VA = "0x8E83E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x8E8504", Offset = "0x8E8504", VA = "0x8E8504")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000117")]
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
		[Range(0.1f, 3f)]
		[SerializeField]
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

		[Token(Token = "0x170000C6")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x8E8538", Offset = "0x8E8538", VA = "0x8E8538", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x8DCB08", Offset = "0x8DCB08", VA = "0x8DCB08", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x8E851C", Offset = "0x8E851C", VA = "0x8E851C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x8E862C", Offset = "0x8E862C", VA = "0x8E862C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x8E8A00", Offset = "0x8E8A00", VA = "0x8E8A00")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x8DCFF8", Offset = "0x8DCFF8", VA = "0x8DCFF8")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
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

		[Token(Token = "0x600078B")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x8E8B28", Offset = "0x8E8B28", VA = "0x8E8B28")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x8E8D14", Offset = "0x8E8D14", VA = "0x8E8D14", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x8E8F40", Offset = "0x8E8F40", VA = "0x8E8F40", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x8E90E0", Offset = "0x8E90E0", VA = "0x8E90E0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x8E9140", Offset = "0x8E9140", VA = "0x8E9140")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x8E92A4", Offset = "0x8E92A4", VA = "0x8E92A4")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x8E94A8", Offset = "0x8E94A8", VA = "0x8E94A8")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x8E94CC", Offset = "0x8E94CC", VA = "0x8E94CC")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x8E94F0", Offset = "0x8E94F0", VA = "0x8E94F0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x8E963C", Offset = "0x8E963C", VA = "0x8E963C")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public enum MoveMode
		{
			[Token(Token = "0x40007ED")]
			Directional,
			[Token(Token = "0x40007EE")]
			Strafe
		}

		[Token(Token = "0x200011B")]
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

		[Token(Token = "0x200011C")]
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

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007AB")]
				[Address(RVA = "0x8EC03C", Offset = "0x8EC03C", VA = "0x8EC03C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AD")]
				[Address(RVA = "0x8EC084", Offset = "0x8EC084", VA = "0x8EC084", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x8EBDF8", Offset = "0x8EBDF8", VA = "0x8EBDF8")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x8EBF38", Offset = "0x8EBF38", VA = "0x8EBF38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x8EBF3C", Offset = "0x8EBF3C", VA = "0x8EBF3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x8EC044", Offset = "0x8EC044", VA = "0x8EC044", Slot = "8")]
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

		[Token(Token = "0x170000C7")]
		public bool onGround
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x8E965C", Offset = "0x8E965C", VA = "0x8E965C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x8E9664", Offset = "0x8E9664", VA = "0x8E9664")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x8E9670", Offset = "0x8E9670", VA = "0x8E9670", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x8E9860", Offset = "0x8E9860", VA = "0x8E9860")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x8E98E4", Offset = "0x8E98E4", VA = "0x8E98E4", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x8E9994", Offset = "0x8E9994", VA = "0x8E9994")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x8EA980", Offset = "0x8EA980", VA = "0x8EA980", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x8EAE10", Offset = "0x8EAE10", VA = "0x8EAE10", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x8EA044", Offset = "0x8EA044", VA = "0x8EA044")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x8EAEE8", Offset = "0x8EAEE8", VA = "0x8EAEE8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x8EB574", Offset = "0x8EB574", VA = "0x8EB574")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x8EAA0C", Offset = "0x8EAA0C", VA = "0x8EAA0C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x8EB664", Offset = "0x8EB664", VA = "0x8EB664", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x8EBAE4", Offset = "0x8EBAE4", VA = "0x8EBAE4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x8EBC0C", Offset = "0x8EBC0C", VA = "0x8EBC0C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x8EBD60", Offset = "0x8EBD60", VA = "0x8EBD60")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__74))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x8EA420", Offset = "0x8EA420", VA = "0x8EA420")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x8EBE20", Offset = "0x8EBE20", VA = "0x8EBE20")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011E")]
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

		[Token(Token = "0x170000CA")]
		public bool isGrounded
		{
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x8EC08C", Offset = "0x8EC08C", VA = "0x8EC08C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x8EC094", Offset = "0x8EC094", VA = "0x8EC094")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x8EC0A0", Offset = "0x8EC0A0", VA = "0x8EC0A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x8EC148", Offset = "0x8EC148", VA = "0x8EC148")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x8EC760", Offset = "0x8EC760", VA = "0x8EC760")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x8EC190", Offset = "0x8EC190", VA = "0x8EC190")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x8EC4F8", Offset = "0x8EC4F8", VA = "0x8EC4F8")]
		private void Move()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x8EC790", Offset = "0x8EC790", VA = "0x8EC790")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x8EC828", Offset = "0x8EC828", VA = "0x8EC828")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x8EC8A8", Offset = "0x8EC8A8", VA = "0x8EC8A8")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200011F")]
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

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x8EC8D0", Offset = "0x8EC8D0", VA = "0x8EC8D0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x8ECA18", Offset = "0x8ECA18", VA = "0x8ECA18", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x8ED090", Offset = "0x8ED090", VA = "0x8ED090")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x8ED27C", Offset = "0x8ED27C", VA = "0x8ED27C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000121")]
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

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x8EC90C", Offset = "0x8EC90C", VA = "0x8EC90C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x8ED2A8", Offset = "0x8ED2A8", VA = "0x8ED2A8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x8ED298", Offset = "0x8ED298", VA = "0x8ED298")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x8ED5EC", Offset = "0x8ED5EC", VA = "0x8ED5EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x8ED624", Offset = "0x8ED624", VA = "0x8ED624")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000123")]
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

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x8ED62C", Offset = "0x8ED62C", VA = "0x8ED62C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x8ED654", Offset = "0x8ED654", VA = "0x8ED654")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x8ED6F8", Offset = "0x8ED6F8", VA = "0x8ED6F8")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000124")]
	public class Navigator
	{
		[Token(Token = "0x2000125")]
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

		[Token(Token = "0x170000CB")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x8ED70C", Offset = "0x8ED70C", VA = "0x8ED70C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x8ED718", Offset = "0x8ED718", VA = "0x8ED718")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public State state
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x8ED724", Offset = "0x8ED724", VA = "0x8ED724")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x8ED72C", Offset = "0x8ED72C", VA = "0x8ED72C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x8EC940", Offset = "0x8EC940", VA = "0x8EC940")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x8ECC38", Offset = "0x8ECC38", VA = "0x8ECC38")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x8ED80C", Offset = "0x8ED80C", VA = "0x8ED80C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x8ED870", Offset = "0x8ED870", VA = "0x8ED870")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x8ED734", Offset = "0x8ED734", VA = "0x8ED734")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x8ED790", Offset = "0x8ED790", VA = "0x8ED790")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x8ED0B8", Offset = "0x8ED0B8", VA = "0x8ED0B8")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x8ED9A4", Offset = "0x8ED9A4", VA = "0x8ED9A4")]
		public Navigator()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000126")]
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x8EDA14", Offset = "0x8EDA14", VA = "0x8EDA14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x8EDAEC", Offset = "0x8EDAEC", VA = "0x8EDAEC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x8EE058", Offset = "0x8EE058", VA = "0x8EE058")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x8EE5A8", Offset = "0x8EE5A8", VA = "0x8EE5A8")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000128")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0x8EECDC", Offset = "0x8EECDC", VA = "0x8EECDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DC")]
				[Address(RVA = "0x8EED24", Offset = "0x8EED24", VA = "0x8EED24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x8EE630", Offset = "0x8EE630", VA = "0x8EE630")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x8EE7AC", Offset = "0x8EE7AC", VA = "0x8EE7AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x8EE7B0", Offset = "0x8EE7B0", VA = "0x8EE7B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x8EECE4", Offset = "0x8EECE4", VA = "0x8EECE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x8EE5BC", Offset = "0x8EE5BC", VA = "0x8EE5BC")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x8EE658", Offset = "0x8EE658", VA = "0x8EE658")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x8EE7A4", Offset = "0x8EE7A4", VA = "0x8EE7A4")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x170000CF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x8EF1C0", Offset = "0x8EF1C0", VA = "0x8EF1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x8EF208", Offset = "0x8EF208", VA = "0x8EF208", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x8EEDA0", Offset = "0x8EEDA0", VA = "0x8EEDA0")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x8EEDD8", Offset = "0x8EEDD8", VA = "0x8EEDD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x8EEDDC", Offset = "0x8EEDDC", VA = "0x8EEDDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x8EF1C8", Offset = "0x8EF1C8", VA = "0x8EF1C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x8EED2C", Offset = "0x8EED2C", VA = "0x8EED2C")]
		[IteratorStateMachine(typeof(<Start>d__1))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x8EEDC8", Offset = "0x8EEDC8", VA = "0x8EEDC8")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x8EF210", Offset = "0x8EF210", VA = "0x8EF210")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x8EF268", Offset = "0x8EF268", VA = "0x8EF268")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x8EF2E0", Offset = "0x8EF2E0", VA = "0x8EF2E0")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x8EF2F0", Offset = "0x8EF2F0", VA = "0x8EF2F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x8EF360", Offset = "0x8EF360", VA = "0x8EF360")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x8EF548", Offset = "0x8EF548", VA = "0x8EF548")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x8EF570", Offset = "0x8EF570", VA = "0x8EF570")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x8EF580", Offset = "0x8EF580", VA = "0x8EF580")]
		private void Update()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x8EF6C8", Offset = "0x8EF6C8", VA = "0x8EF6C8")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x8EF6E4", Offset = "0x8EF6E4", VA = "0x8EF6E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x8EF810", Offset = "0x8EF810", VA = "0x8EF810")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x8EF820", Offset = "0x8EF820", VA = "0x8EF820")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x8EF8D0", Offset = "0x8EF8D0", VA = "0x8EF8D0")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x8EF8D8", Offset = "0x8EF8D8", VA = "0x8EF8D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x8EF930", Offset = "0x8EF930", VA = "0x8EF930")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x8EFC10", Offset = "0x8EFC10", VA = "0x8EFC10")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000131")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x8EFCA4", Offset = "0x8EFCA4", VA = "0x8EFCA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x8EFEA0", Offset = "0x8EFEA0", VA = "0x8EFEA0")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x8EFEA8", Offset = "0x8EFEA8", VA = "0x8EFEA8")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x8EFEC8", Offset = "0x8EFEC8", VA = "0x8EFEC8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x8EFF2C", Offset = "0x8EFF2C", VA = "0x8EFF2C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x8EFF90", Offset = "0x8EFF90", VA = "0x8EFF90")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x8EFF98", Offset = "0x8EFF98", VA = "0x8EFF98")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class MeshContainer
	{
		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x8EFFA0", Offset = "0x8EFFA0", VA = "0x8EFFA0")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x8F0010", Offset = "0x8F0010", VA = "0x8F0010")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x8F0048", Offset = "0x8F0048", VA = "0x8F0048")]
		public void Start()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x8F0144", Offset = "0x8F0144", VA = "0x8F0144")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x8F0454", Offset = "0x8F0454", VA = "0x8F0454")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x8F0508", Offset = "0x8F0508", VA = "0x8F0508")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x8F0660", Offset = "0x8F0660", VA = "0x8F0660")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x8F0ED4", Offset = "0x8F0ED4", VA = "0x8F0ED4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x8F0F2C", Offset = "0x8F0F2C", VA = "0x8F0F2C")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x8F100C", Offset = "0x8F100C", VA = "0x8F100C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x8F1070", Offset = "0x8F1070", VA = "0x8F1070")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x8F081C", Offset = "0x8F081C", VA = "0x8F081C")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x8F10D4", Offset = "0x8F10D4", VA = "0x8F10D4")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x8F1388", Offset = "0x8F1388", VA = "0x8F1388")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x8F1134", Offset = "0x8F1134", VA = "0x8F1134")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x8F14F4", Offset = "0x8F14F4", VA = "0x8F14F4")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x8F11D8", Offset = "0x8F11D8", VA = "0x8F11D8")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x8F1514", Offset = "0x8F1514", VA = "0x8F1514")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x8F1584", Offset = "0x8F1584", VA = "0x8F1584")]
		public void Start()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x8F16AC", Offset = "0x8F16AC", VA = "0x8F16AC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x8F18C4", Offset = "0x8F18C4", VA = "0x8F18C4")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000138")]
		public enum WaterMode
		{
			[Token(Token = "0x4000870")]
			Simple,
			[Token(Token = "0x4000871")]
			Reflective,
			[Token(Token = "0x4000872")]
			Refractive
		}

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x8F18CC", Offset = "0x8F18CC", VA = "0x8F18CC")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x8F320C", Offset = "0x8F320C", VA = "0x8F320C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x8F3574", Offset = "0x8F3574", VA = "0x8F3574")]
		private void Update()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x8F2D8C", Offset = "0x8F2D8C", VA = "0x8F2D8C")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x8F2420", Offset = "0x8F2420", VA = "0x8F2420")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x8F240C", Offset = "0x8F240C", VA = "0x8F240C")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x8F22A0", Offset = "0x8F22A0", VA = "0x8F22A0")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x8F305C", Offset = "0x8F305C", VA = "0x8F305C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x8F2FC8", Offset = "0x8F2FC8", VA = "0x8F2FC8")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x8F3820", Offset = "0x8F3820", VA = "0x8F3820")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000874")]
		High = 2,
		[Token(Token = "0x4000875")]
		Medium = 1,
		[Token(Token = "0x4000876")]
		Low = 0
	}
	[Token(Token = "0x200013A")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x8F3920", Offset = "0x8F3920", VA = "0x8F3920")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x8F3A98", Offset = "0x8F3A98", VA = "0x8F3A98")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x8F3B3C", Offset = "0x8F3B3C", VA = "0x8F3B3C")]
		public void Update()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x8F3BB0", Offset = "0x8F3BB0", VA = "0x8F3BB0")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x8F3BC8", Offset = "0x8F3BC8", VA = "0x8F3BC8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x8F3BCC", Offset = "0x8F3BCC", VA = "0x8F3BCC")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x8F3D8C", Offset = "0x8F3D8C", VA = "0x8F3D8C")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x8F3E70", Offset = "0x8F3E70", VA = "0x8F3E70")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200013C")]
	public enum AAMode
	{
		[Token(Token = "0x400087D")]
		FXAA2,
		[Token(Token = "0x400087E")]
		FXAA3Console,
		[Token(Token = "0x400087F")]
		FXAA1PresetA,
		[Token(Token = "0x4000880")]
		FXAA1PresetB,
		[Token(Token = "0x4000881")]
		NFAA,
		[Token(Token = "0x4000882")]
		SSAA,
		[Token(Token = "0x4000883")]
		DLAA
	}
	[Token(Token = "0x200013D")]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x8F3E78", Offset = "0x8F3E78", VA = "0x8F3E78")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x8F3EE0", Offset = "0x8F3EE0", VA = "0x8F3EE0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x8F4050", Offset = "0x8F4050", VA = "0x8F4050")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x8F4514", Offset = "0x8F4514", VA = "0x8F4514")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	[RequireComponent(typeof(Camera))]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200013F")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40008B9")]
			Ghosting,
			[Token(Token = "0x40008BA")]
			Anamorphic,
			[Token(Token = "0x40008BB")]
			Combined
		}

		[Token(Token = "0x2000140")]
		public enum TweakMode
		{
			[Token(Token = "0x40008BD")]
			Basic,
			[Token(Token = "0x40008BE")]
			Complex
		}

		[Token(Token = "0x2000141")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40008C0")]
			Auto,
			[Token(Token = "0x40008C1")]
			On,
			[Token(Token = "0x40008C2")]
			Off
		}

		[Token(Token = "0x2000142")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40008C4")]
			Screen,
			[Token(Token = "0x40008C5")]
			Add
		}

		[Token(Token = "0x2000143")]
		public enum BloomQuality
		{
			[Token(Token = "0x40008C7")]
			Cheap,
			[Token(Token = "0x40008C8")]
			High
		}

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x8F4538", Offset = "0x8F4538", VA = "0x8F4538", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x8F4624", Offset = "0x8F4624", VA = "0x8F4624")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x8F5794", Offset = "0x8F5794", VA = "0x8F5794")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x8F55FC", Offset = "0x8F55FC", VA = "0x8F55FC")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x8F5350", Offset = "0x8F5350", VA = "0x8F5350")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x8F527C", Offset = "0x8F527C", VA = "0x8F527C")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x8F5410", Offset = "0x8F5410", VA = "0x8F5410")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x8F5858", Offset = "0x8F5858", VA = "0x8F5858")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x40008CA")]
		Ghosting,
		[Token(Token = "0x40008CB")]
		Anamorphic,
		[Token(Token = "0x40008CC")]
		Combined
	}
	[Token(Token = "0x2000145")]
	public enum TweakMode34
	{
		[Token(Token = "0x40008CE")]
		Basic,
		[Token(Token = "0x40008CF")]
		Complex
	}
	[Token(Token = "0x2000146")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40008D1")]
		Auto,
		[Token(Token = "0x40008D2")]
		On,
		[Token(Token = "0x40008D3")]
		Off
	}
	[Token(Token = "0x2000147")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40008D5")]
		Screen,
		[Token(Token = "0x40008D6")]
		Add
	}
	[Token(Token = "0x2000148")]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x8F58E4", Offset = "0x8F58E4", VA = "0x8F58E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x8F5A40", Offset = "0x8F5A40", VA = "0x8F5A40")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x8F6800", Offset = "0x8F6800", VA = "0x8F6800")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x8F6678", Offset = "0x8F6678", VA = "0x8F6678")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x8F6420", Offset = "0x8F6420", VA = "0x8F6420")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x8F6528", Offset = "0x8F6528", VA = "0x8F6528")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x8F68B0", Offset = "0x8F68B0", VA = "0x8F68B0")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x200014A")]
		public enum Resolution
		{
			[Token(Token = "0x4000902")]
			Low,
			[Token(Token = "0x4000903")]
			High
		}

		[Token(Token = "0x200014B")]
		public enum BlurType
		{
			[Token(Token = "0x4000905")]
			Standard,
			[Token(Token = "0x4000906")]
			Sgx
		}

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float threshold;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 2.5f)]
		public float intensity;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0.25f, 5.5f)]
		public float blurSize;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x8F6924", Offset = "0x8F6924", VA = "0x8F6924", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x8F6998", Offset = "0x8F6998", VA = "0x8F6998")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x8F6A24", Offset = "0x8F6A24", VA = "0x8F6A24")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x8F6D94", Offset = "0x8F6D94", VA = "0x8F6D94")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x170000D1")]
		protected Material material
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x8F6DB8", Offset = "0x8F6DB8", VA = "0x8F6DB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x8F6EC0", Offset = "0x8F6EC0", VA = "0x8F6EC0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x8F6F6C", Offset = "0x8F6F6C", VA = "0x8F6F6C")]
		protected void Start()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x8F701C", Offset = "0x8F701C", VA = "0x8F701C")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x8F712C", Offset = "0x8F712C", VA = "0x8F712C")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x8F7228", Offset = "0x8F7228", VA = "0x8F7228")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x8F7384", Offset = "0x8F7384", VA = "0x8F7384")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200014E")]
		public enum BlurType
		{
			[Token(Token = "0x4000912")]
			StandardGauss,
			[Token(Token = "0x4000913")]
			SgxGauss
		}

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 2f)]
		public int downsample;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		public float blurSize;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x8F739C", Offset = "0x8F739C", VA = "0x8F739C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x8F7410", Offset = "0x8F7410", VA = "0x8F7410")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x8F749C", Offset = "0x8F749C", VA = "0x8F749C")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x8F77C4", Offset = "0x8F77C4", VA = "0x8F77C4")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[RequireComponent(typeof(Camera))]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000150")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x4000935")]
			CameraMotion,
			[Token(Token = "0x4000936")]
			LocalBlur,
			[Token(Token = "0x4000937")]
			Reconstruction,
			[Token(Token = "0x4000938")]
			ReconstructionDX11,
			[Token(Token = "0x4000939")]
			ReconstructionDisc
		}

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x8F77E0", Offset = "0x8F77E0", VA = "0x8F77E0")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x8F7A40", Offset = "0x8F7A40", VA = "0x8F7A40")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x8F7CD0", Offset = "0x8F7CD0", VA = "0x8F7CD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x8F7D90", Offset = "0x8F7D90", VA = "0x8F7D90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x8F7EF4", Offset = "0x8F7EF4", VA = "0x8F7EF4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x8F7FA8", Offset = "0x8F7FA8", VA = "0x8F7FA8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x8F7B70", Offset = "0x8F7B70", VA = "0x8F7B70")]
		private void Remember()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x8F9AFC", Offset = "0x8F9AFC", VA = "0x8F9AFC")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x8F9A78", Offset = "0x8F9A78", VA = "0x8F9A78")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x8F9AEC", Offset = "0x8F9AEC", VA = "0x8F9AEC")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x8F9E90", Offset = "0x8F9E90", VA = "0x8F9E90")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	[ExecuteInEditMode]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000152")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000953")]
			Simple,
			[Token(Token = "0x4000954")]
			Advanced
		}

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x8FA028", Offset = "0x8FA028", VA = "0x8FA028")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x8FA048", Offset = "0x8FA048", VA = "0x8FA048")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x8FA04C", Offset = "0x8FA04C", VA = "0x8FA04C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x8FA310", Offset = "0x8FA310", VA = "0x8FA310")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x8FA604", Offset = "0x8FA604", VA = "0x8FA604")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x8FA608", Offset = "0x8FA608", VA = "0x8FA608")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x8FA914", Offset = "0x8FA914", VA = "0x8FA914")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000153")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x8FAFA0", Offset = "0x8FAFA0", VA = "0x8FAFA0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x8FB010", Offset = "0x8FB010", VA = "0x8FB010")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x8FB0AC", Offset = "0x8FB0AC", VA = "0x8FB0AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x8FB13C", Offset = "0x8FB13C", VA = "0x8FB13C")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x8FB338", Offset = "0x8FB338", VA = "0x8FB338")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x8FB438", Offset = "0x8FB438", VA = "0x8FB438")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x8FB780", Offset = "0x8FB780", VA = "0x8FB780")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x8FB974", Offset = "0x8FB974", VA = "0x8FB974")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x8FB9CC", Offset = "0x8FB9CC", VA = "0x8FB9CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x8FBA88", Offset = "0x8FBA88", VA = "0x8FBA88")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[RequireComponent(typeof(Camera))]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float intensity;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.999f)]
		public float threshold;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x8FBA90", Offset = "0x8FBA90", VA = "0x8FBA90", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x8FBB2C", Offset = "0x8FBB2C", VA = "0x8FBB2C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x8FBE58", Offset = "0x8FBE58", VA = "0x8FBE58")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000156")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0.0001f, 1f)]
		public float adaptationSpeed;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float limitMinimum;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float limitMaximum;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x170000D2")]
		protected Material materialLum
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x8FBE70", Offset = "0x8FBE70", VA = "0x8FBE70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x8FBF44", Offset = "0x8FBF44", VA = "0x8FBF44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x8FC018", Offset = "0x8FC018", VA = "0x8FC018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		protected Material materialApply
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x8FC0EC", Offset = "0x8FC0EC", VA = "0x8FC0EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x8FC1C0", Offset = "0x8FC1C0", VA = "0x8FC1C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x8FC244", Offset = "0x8FC244", VA = "0x8FC244")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x8FC390", Offset = "0x8FC390", VA = "0x8FC390")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x8FC56C", Offset = "0x8FC56C", VA = "0x8FC56C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x8FC7AC", Offset = "0x8FC7AC", VA = "0x8FC7AC")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x8FC964", Offset = "0x8FC964", VA = "0x8FC964")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x8FC9E0", Offset = "0x8FC9E0", VA = "0x8FC9E0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x8FCAA4", Offset = "0x8FCAA4", VA = "0x8FCAA4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x8FCE1C", Offset = "0x8FCE1C", VA = "0x8FCE1C")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000158")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000159")]
		public enum BlurType
		{
			[Token(Token = "0x4000991")]
			DiscBlur,
			[Token(Token = "0x4000992")]
			DX11
		}

		[Token(Token = "0x200015A")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000994")]
			Low,
			[Token(Token = "0x4000995")]
			Medium,
			[Token(Token = "0x4000996")]
			High
		}

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x8FCE38", Offset = "0x8FCE38", VA = "0x8FCE38", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x8FD038", Offset = "0x8FD038", VA = "0x8FD038")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x8FD0B8", Offset = "0x8FD0B8", VA = "0x8FD0B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x8FD1B0", Offset = "0x8FD1B0", VA = "0x8FD1B0")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x8FCEF0", Offset = "0x8FCEF0", VA = "0x8FCEF0")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x8FD208", Offset = "0x8FD208", VA = "0x8FD208")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x8FD2F4", Offset = "0x8FD2F4", VA = "0x8FD2F4")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x8FD5C4", Offset = "0x8FD5C4", VA = "0x8FD5C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x8FE8C4", Offset = "0x8FE8C4", VA = "0x8FE8C4")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200015B")]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x200015C")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40009C3")]
			OnlyBackground = 1,
			[Token(Token = "0x40009C4")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200015D")]
		public enum DofResolution
		{
			[Token(Token = "0x40009C6")]
			High = 2,
			[Token(Token = "0x40009C7")]
			Medium,
			[Token(Token = "0x40009C8")]
			Low
		}

		[Token(Token = "0x200015E")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40009CA")]
			Low = 1,
			[Token(Token = "0x40009CB")]
			High = 2,
			[Token(Token = "0x40009CC")]
			VeryHigh = 4
		}

		[Token(Token = "0x200015F")]
		public enum BokehDestination
		{
			[Token(Token = "0x40009CE")]
			Background = 1,
			[Token(Token = "0x40009CF")]
			Foreground,
			[Token(Token = "0x40009D0")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x8FE91C", Offset = "0x8FE91C", VA = "0x8FE91C")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x8FEE78", Offset = "0x8FEE78", VA = "0x8FEE78", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x8FF150", Offset = "0x8FF150", VA = "0x8FF150")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x8FF2B8", Offset = "0x8FF2B8", VA = "0x8FF2B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x8FF338", Offset = "0x8FF338", VA = "0x8FF338")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x8FF424", Offset = "0x8FF424", VA = "0x8FF424")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x8FF448", Offset = "0x8FF448", VA = "0x8FF448")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x8FF46C", Offset = "0x8FF46C", VA = "0x8FF46C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x9001D8", Offset = "0x9001D8", VA = "0x9001D8")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x900788", Offset = "0x900788", VA = "0x900788")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x900AFC", Offset = "0x900AFC", VA = "0x900AFC")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x9000B0", Offset = "0x9000B0", VA = "0x9000B0")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x9003B8", Offset = "0x9003B8", VA = "0x9003B8")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x900994", Offset = "0x900994", VA = "0x900994")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x8FFD00", Offset = "0x8FFD00", VA = "0x8FFD00")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x900ED4", Offset = "0x900ED4", VA = "0x900ED4")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000161")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40009DD")]
			TriangleDepthNormals,
			[Token(Token = "0x40009DE")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40009DF")]
			SobelDepth,
			[Token(Token = "0x40009E0")]
			SobelDepthThin,
			[Token(Token = "0x40009E1")]
			TriangleLuminance
		}

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x90102C", Offset = "0x90102C", VA = "0x90102C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x901164", Offset = "0x901164", VA = "0x901164")]
		private new void Start()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x9010B4", Offset = "0x9010B4", VA = "0x9010B4")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x901170", Offset = "0x901170", VA = "0x901170")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x901174", Offset = "0x901174", VA = "0x901174")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x901348", Offset = "0x901348", VA = "0x901348")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000162")]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float strengthX;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1.5f)]
		public float strengthY;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x901374", Offset = "0x901374", VA = "0x901374", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x9013DC", Offset = "0x9013DC", VA = "0x9013DC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x901510", Offset = "0x901510", VA = "0x901510")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000163")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x901524", Offset = "0x901524", VA = "0x901524", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x90158C", Offset = "0x90158C", VA = "0x90158C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x901B1C", Offset = "0x901B1C", VA = "0x901B1C")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-1f, 1f)]
		public float rampOffset;

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x901B3C", Offset = "0x901B3C", VA = "0x901B3C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x901CF4", Offset = "0x901CF4", VA = "0x901CF4")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000165")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x170000D6")]
		protected Material material
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x901C20", Offset = "0x901C20", VA = "0x901C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x901D04", Offset = "0x901D04", VA = "0x901D04", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x901DA4", Offset = "0x901DA4", VA = "0x901DA4", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x901CFC", Offset = "0x901CFC", VA = "0x901CFC")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[AddComponentMenu("")]
	public class ImageEffects
	{
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x901E30", Offset = "0x901E30", VA = "0x901E30")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x9020A0", Offset = "0x9020A0", VA = "0x9020A0")]
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x902108", Offset = "0x902108", VA = "0x902108")]
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x902178", Offset = "0x902178", VA = "0x902178")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000167")]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 0.92f)]
		public float blurAmount;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x902180", Offset = "0x902180", VA = "0x902180", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x902184", Offset = "0x902184", VA = "0x902184", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x9021E8", Offset = "0x9021E8", VA = "0x9021E8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x902550", Offset = "0x902550", VA = "0x902550")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000168")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	[RequireComponent(typeof(Camera))]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x902564", Offset = "0x902564", VA = "0x902564", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x902600", Offset = "0x902600", VA = "0x902600")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x902E00", Offset = "0x902E00", VA = "0x902E00")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x903140", Offset = "0x903140", VA = "0x903140")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000169")]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float grainIntensityMin;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float grainIntensityMax;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0.1f, 50f)]
		public float grainSize;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float scratchIntensityMin;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		public float scratchIntensityMax;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1f, 30f)]
		public float scratchFPS;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float scratchJitter;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x170000D7")]
		protected Material material
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x9032F4", Offset = "0x9032F4", VA = "0x9032F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x9031C8", Offset = "0x9031C8", VA = "0x9031C8")]
		protected void Start()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x90345C", Offset = "0x90345C", VA = "0x90345C")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x90352C", Offset = "0x90352C", VA = "0x90352C")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x9035D0", Offset = "0x9035D0", VA = "0x9035D0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x9038F8", Offset = "0x9038F8", VA = "0x9038F8")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x8FEA1C", Offset = "0x8FEA1C", VA = "0x8FEA1C")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x90394C", Offset = "0x90394C", VA = "0x90394C")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x903B84", Offset = "0x903B84", VA = "0x903B84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x903B90", Offset = "0x903B90", VA = "0x903B90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x903B94", Offset = "0x903B94", VA = "0x903B94")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x903C74", Offset = "0x903C74", VA = "0x903C74")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x903C7C", Offset = "0x903C7C", VA = "0x903C7C", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x903D3C", Offset = "0x903D3C", VA = "0x903D3C")]
		protected void Start()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x8FEFA0", Offset = "0x8FEFA0", VA = "0x8FEFA0")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x903D48", Offset = "0x903D48", VA = "0x903D48")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x903DA0", Offset = "0x903DA0", VA = "0x903DA0")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x8FF098", Offset = "0x8FF098", VA = "0x8FF098")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x903DA8", Offset = "0x903DA8", VA = "0x903DA8")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x90392C", Offset = "0x90392C", VA = "0x90392C")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x90402C", Offset = "0x90402C", VA = "0x90402C")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x900F48", Offset = "0x900F48", VA = "0x900F48")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x200016B")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x9043A4", Offset = "0x9043A4", VA = "0x9043A4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x90440C", Offset = "0x90440C", VA = "0x90440C")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x904658", Offset = "0x904658", VA = "0x904658")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x9049CC", Offset = "0x9049CC", VA = "0x9049CC")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x904B70", Offset = "0x904B70", VA = "0x904B70")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200016C")]
	internal class Quads
	{
		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x904B78", Offset = "0x904B78", VA = "0x904B78")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x8FF154", Offset = "0x8FF154", VA = "0x8FF154")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x900C9C", Offset = "0x900C9C", VA = "0x900C9C")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x904C48", Offset = "0x904C48", VA = "0x904C48")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x904FCC", Offset = "0x904FCC", VA = "0x904FCC")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200016D")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200016E")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000A26")]
			Additive,
			[Token(Token = "0x4000A27")]
			ScreenBlend,
			[Token(Token = "0x4000A28")]
			Multiply,
			[Token(Token = "0x4000A29")]
			Overlay,
			[Token(Token = "0x4000A2A")]
			AlphaBlend
		}

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x904FD4", Offset = "0x904FD4", VA = "0x904FD4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x90503C", Offset = "0x90503C", VA = "0x90503C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x90518C", Offset = "0x90518C", VA = "0x90518C")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200016F")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 3f)]
		public float intensity;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.1f, 3f)]
		public float radius;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 3f)]
		public int blurIterations;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 5f)]
		public float blurFilterDistance;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x90519C", Offset = "0x90519C", VA = "0x90519C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x905204", Offset = "0x905204", VA = "0x905204")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x905294", Offset = "0x905294", VA = "0x905294")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x905A48", Offset = "0x905A48", VA = "0x905A48")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000170")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000171")]
		public enum SSAOSamples
		{
			[Token(Token = "0x4000A3F")]
			Low,
			[Token(Token = "0x4000A40")]
			Medium,
			[Token(Token = "0x4000A41")]
			High
		}

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0.05f, 1f)]
		public float m_Radius;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 4f)]
		public int m_Blur;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 6f)]
		public int m_Downsampling;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1E-05f, 0.5f)]
		public float m_MinZ;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x905A64", Offset = "0x905A64", VA = "0x905A64")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x905B10", Offset = "0x905B10", VA = "0x905B10")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x905B94", Offset = "0x905B94", VA = "0x905B94")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x905B9C", Offset = "0x905B9C", VA = "0x905B9C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x905D3C", Offset = "0x905D3C", VA = "0x905D3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x905C64", Offset = "0x905C64", VA = "0x905C64")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x905DA8", Offset = "0x905DA8", VA = "0x905DA8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x90637C", Offset = "0x90637C", VA = "0x90637C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000172")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Reflection")]
	public class ScreenSpaceReflection : PostEffectsBase
	{
		[Token(Token = "0x2000173")]
		public enum SSRDebugMode
		{
			[Token(Token = "0x4000A51")]
			None,
			[Token(Token = "0x4000A52")]
			IncomingRadiance,
			[Token(Token = "0x4000A53")]
			SSRResult,
			[Token(Token = "0x4000A54")]
			FinalGlossyTerm,
			[Token(Token = "0x4000A55")]
			SSRMask,
			[Token(Token = "0x4000A56")]
			Roughness,
			[Token(Token = "0x4000A57")]
			BaseColor,
			[Token(Token = "0x4000A58")]
			SpecColor,
			[Token(Token = "0x4000A59")]
			Reflectivity,
			[Token(Token = "0x4000A5A")]
			ReflectionProbeOnly,
			[Token(Token = "0x4000A5B")]
			ReflectionProbeMinusSSR,
			[Token(Token = "0x4000A5C")]
			SSRMinusReflectionProbe,
			[Token(Token = "0x4000A5D")]
			NoGlossy,
			[Token(Token = "0x4000A5E")]
			NegativeNoGlossy,
			[Token(Token = "0x4000A5F")]
			MipLevel
		}

		[Token(Token = "0x2000174")]
		public enum SSRResolution
		{
			[Token(Token = "0x4000A61")]
			FullResolution,
			[Token(Token = "0x4000A62")]
			HalfTraceFullResolve,
			[Token(Token = "0x4000A63")]
			HalfResolution
		}

		[Serializable]
		[Token(Token = "0x2000175")]
		public struct SSRSettings
		{
			[Token(Token = "0x2000176")]
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : Attribute
			{
				[Token(Token = "0x2000177")]
				public enum Category
				{
					[Token(Token = "0x4000A84")]
					Basic,
					[Token(Token = "0x4000A85")]
					Reflections,
					[Token(Token = "0x4000A86")]
					Advanced,
					[Token(Token = "0x4000A87")]
					Debug,
					[Token(Token = "0x4000A88")]
					Undefined
				}

				[Token(Token = "0x4000A81")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public readonly Category category;

				[Token(Token = "0x4000A82")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public readonly int priority;

				[Token(Token = "0x60008E3")]
				[Address(RVA = "0x9083B8", Offset = "0x9083B8", VA = "0x9083B8")]
				public LayoutAttribute(Category category, int priority)
				{
				}
			}

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			[Layout(LayoutAttribute.Category.Basic, 1)]
			public float reflectionMultiplier;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0.5f, 1000f)]
			[Tooltip("Maximum reflection distance in world units.")]
			[Layout(LayoutAttribute.Category.Basic, 2)]
			public float maxDistance;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Layout(LayoutAttribute.Category.Basic, 3)]
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[Range(0f, 1000f)]
			public float fadeDistance;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			[Layout(LayoutAttribute.Category.Basic, 4)]
			public float screenEdgeFading;

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Enable for better reflections of very bright objects at a performance cost")]
			[Layout(LayoutAttribute.Category.Basic, 5)]
			public bool enableHDR;

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[Layout(LayoutAttribute.Category.Basic, 6)]
			[Tooltip("Add reflections on top of existing ones. Not physically correct.")]
			public bool additiveReflection;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Max raytracing length.")]
			[Range(16f, 2048f)]
			[Layout(LayoutAttribute.Category.Reflections, 1)]
			public int maxSteps;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			[Range(0f, 4f)]
			[Layout(LayoutAttribute.Category.Reflections, 2)]
			public int rayStepSize;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			[Layout(LayoutAttribute.Category.Reflections, 3)]
			[Range(0.01f, 10f)]
			public float widthModifier;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Layout(LayoutAttribute.Category.Reflections, 4)]
			[Range(0f, 1f)]
			[Tooltip("Increase if reflections flicker on very rough surfaces.")]
			public float smoothFallbackThreshold;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Start falling back to non-SSR value solution at smoothFallbackThreshold - smoothFallbackDistance, with full fallback occuring at smoothFallbackThreshold.")]
			[Layout(LayoutAttribute.Category.Reflections, 5)]
			[Range(0f, 0.2f)]
			public float smoothFallbackDistance;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Layout(LayoutAttribute.Category.Reflections, 6)]
			[Range(0f, 1f)]
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			public float fresnelFade;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[Range(0.1f, 10f)]
			[Layout(LayoutAttribute.Category.Reflections, 7)]
			public float fresnelFadePower;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Controls how blurry reflections get as objects are further from the camera. 0 is constant blur no matter trace distance or distance from camera. 1 fully takes into account both factors.")]
			[Layout(LayoutAttribute.Category.Reflections, 8)]
			[Range(0f, 1f)]
			public float distanceBlur;

			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Range(0f, 0.99f)]
			[Tooltip("Increase to decrease flicker in scenes; decrease to prevent ghosting (especially in dynamic scenes). 0 gives maximum performance.")]
			[Layout(LayoutAttribute.Category.Advanced, 1)]
			public float temporalFilterStrength;

			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Layout(LayoutAttribute.Category.Advanced, 2)]
			[Tooltip("Enable to limit ghosting from applying the temporal filter.")]
			public bool useTemporalConfidence;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			[Tooltip("Improves quality in scenes with varying smoothness, at a potential performance cost.")]
			[Layout(LayoutAttribute.Category.Advanced, 3)]
			public bool traceEverywhere;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
			[Tooltip("Enable to force more surfaces to use reflection probes if you see streaks on the sides of objects or bad reflections of their backs.")]
			[Layout(LayoutAttribute.Category.Advanced, 4)]
			public bool treatBackfaceHitAsMiss;

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
			[Tooltip("Enable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave off for scenes with glossy vertical objects.")]
			[Layout(LayoutAttribute.Category.Advanced, 5)]
			public bool suppressBackwardsRays;

			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[Tooltip("Improve visual fidelity of reflections on rough surfaces near corners in the scene, at the cost of a small amount of performance.")]
			[Layout(LayoutAttribute.Category.Advanced, 6)]
			public bool improveCorners;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Layout(LayoutAttribute.Category.Advanced, 7)]
			[Tooltip("Half resolution SSRR is much faster, but less accurate. Quality can be reclaimed for some performance by doing the resolve at full resolution.")]
			public SSRResolution resolution;

			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Layout(LayoutAttribute.Category.Advanced, 8)]
			[Tooltip("Drastically improves reflection reconstruction quality at the expense of some performance.")]
			public bool bilateralUpsample;

			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			[Layout(LayoutAttribute.Category.Advanced, 9)]
			[Tooltip("Improve visual fidelity of mirror reflections at the cost of a small amount of performance.")]
			public bool reduceBanding;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
			[Layout(LayoutAttribute.Category.Advanced, 10)]
			[Tooltip("Enable to limit the effect a few bright pixels can have on rougher surfaces")]
			public bool highlightSuppression;

			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Layout(LayoutAttribute.Category.Debug, 1)]
			[Tooltip("Various Debug Visualizations")]
			public SSRDebugMode debugMode;

			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("Uncheck to disable SSR without disabling the entire component")]
			[Layout(LayoutAttribute.Category.Debug, 2)]
			public bool enable;

			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly SSRSettings s_Performance;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static readonly SSRSettings s_Default;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static readonly SSRSettings s_HighQuality;

			[Token(Token = "0x170000D8")]
			public static SSRSettings performanceSettings
			{
				[Token(Token = "0x60008DF")]
				[Address(RVA = "0x908134", Offset = "0x908134", VA = "0x908134")]
				get
				{
					return default(SSRSettings);
				}
			}

			[Token(Token = "0x170000D9")]
			public static SSRSettings defaultSettings
			{
				[Token(Token = "0x60008E0")]
				[Address(RVA = "0x908194", Offset = "0x908194", VA = "0x908194")]
				get
				{
					return default(SSRSettings);
				}
			}

			[Token(Token = "0x170000DA")]
			public static SSRSettings highQualitySettings
			{
				[Token(Token = "0x60008E1")]
				[Address(RVA = "0x9081F8", Offset = "0x9081F8", VA = "0x9081F8")]
				get
				{
					return default(SSRSettings);
				}
			}
		}

		[Token(Token = "0x2000178")]
		private enum PassIndex
		{
			[Token(Token = "0x4000A8A")]
			RayTraceStep1,
			[Token(Token = "0x4000A8B")]
			RayTraceStep2,
			[Token(Token = "0x4000A8C")]
			RayTraceStep4,
			[Token(Token = "0x4000A8D")]
			RayTraceStep8,
			[Token(Token = "0x4000A8E")]
			RayTraceStep16,
			[Token(Token = "0x4000A8F")]
			CompositeFinal,
			[Token(Token = "0x4000A90")]
			Blur,
			[Token(Token = "0x4000A91")]
			CompositeSSR,
			[Token(Token = "0x4000A92")]
			Blit,
			[Token(Token = "0x4000A93")]
			EdgeGeneration,
			[Token(Token = "0x4000A94")]
			MinMipGeneration,
			[Token(Token = "0x4000A95")]
			HitPointToReflections,
			[Token(Token = "0x4000A96")]
			BilateralKeyPack,
			[Token(Token = "0x4000A97")]
			BlitDepthAsCSZ,
			[Token(Token = "0x4000A98")]
			TemporalFilter,
			[Token(Token = "0x4000A99")]
			AverageRayDistanceGeneration
		}

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public SSRSettings settings;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Enable to try and bypass expensive bilateral upsampling away from edges. There is a slight performance hit for generating the edge buffers, but a potentially high performance savings from bypassing bilateral upsampling where it is unneeded. Test on your target platforms to see if performance improves.")]
		private bool useEdgeDetector;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(-4f, 4f)]
		private float mipBias;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool useOcclusion;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool fullResolutionFiltering;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		private bool fallbackToSky;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		private bool computeAverageRayDistance;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool m_HasInformationFromPreviousFrame;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Matrix4x4 m_PreviousWorldToCameraMatrix;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RenderTexture m_PreviousDepthBuffer;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RenderTexture m_PreviousHitBuffer;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture m_PreviousReflectionBuffer;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader ssrShader;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material ssrMaterial;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x9063B0", Offset = "0x9063B0", VA = "0x9063B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x906418", Offset = "0x906418", VA = "0x906418")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x9065C0", Offset = "0x9065C0", VA = "0x9065C0")]
		private void PreparePreviousBuffers(int w, int h)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x9067E4", Offset = "0x9067E4", VA = "0x9067E4")]
		[ImageEffectOpaque]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x908090", Offset = "0x908090", VA = "0x908090")]
		public ScreenSpaceReflection()
		{
		}
	}
	[Token(Token = "0x2000179")]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	[ExecuteInEditMode]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x9083E4", Offset = "0x9083E4", VA = "0x9083E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x908464", Offset = "0x908464", VA = "0x908464")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200017A")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x200017B")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000AA9")]
			Low,
			[Token(Token = "0x4000AAA")]
			Normal,
			[Token(Token = "0x4000AAB")]
			High
		}

		[Token(Token = "0x200017C")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000AAD")]
			Screen,
			[Token(Token = "0x4000AAE")]
			Add
		}

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x90846C", Offset = "0x90846C", VA = "0x90846C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x9084F8", Offset = "0x9084F8", VA = "0x9084F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x908BB4", Offset = "0x908BB4", VA = "0x908BB4")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x200017E")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000AB7")]
			TiltShiftMode,
			[Token(Token = "0x4000AB8")]
			IrisMode
		}

		[Token(Token = "0x200017F")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000ABA")]
			Preview,
			[Token(Token = "0x4000ABB")]
			Low,
			[Token(Token = "0x4000ABC")]
			Normal,
			[Token(Token = "0x4000ABD")]
			High
		}

		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 15f)]
		public float blurArea;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 25f)]
		public float maxBlurSize;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x908BF8", Offset = "0x908BF8", VA = "0x908BF8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x908C60", Offset = "0x908C60", VA = "0x908C60")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x908EF0", Offset = "0x908EF0", VA = "0x908EF0")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	[RequireComponent(typeof(Camera))]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000181")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000ACC")]
			SimpleReinhard,
			[Token(Token = "0x4000ACD")]
			UserCurve,
			[Token(Token = "0x4000ACE")]
			Hable,
			[Token(Token = "0x4000ACF")]
			Photographic,
			[Token(Token = "0x4000AD0")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000AD1")]
			AdaptiveReinhard,
			[Token(Token = "0x4000AD2")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000182")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000AD4")]
			Square16 = 0x10,
			[Token(Token = "0x4000AD5")]
			Square32 = 0x20,
			[Token(Token = "0x4000AD6")]
			Square64 = 0x40,
			[Token(Token = "0x4000AD7")]
			Square128 = 0x80,
			[Token(Token = "0x4000AD8")]
			Square256 = 0x100,
			[Token(Token = "0x4000AD9")]
			Square512 = 0x200,
			[Token(Token = "0x4000ADA")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x908F08", Offset = "0x908F08", VA = "0x908F08", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x90906C", Offset = "0x90906C", VA = "0x90906C")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x9092EC", Offset = "0x9092EC", VA = "0x9092EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x909444", Offset = "0x909444", VA = "0x909444")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x909544", Offset = "0x909544", VA = "0x909544")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x909CE4", Offset = "0x909CE4", VA = "0x909CE4")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000183")]
	internal class Triangles
	{
		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x909D10", Offset = "0x909D10", VA = "0x909D10")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x909DE4", Offset = "0x909DE4", VA = "0x909DE4")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x909F48", Offset = "0x909F48", VA = "0x909F48")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x90A180", Offset = "0x90A180", VA = "0x90A180")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x90A474", Offset = "0x90A474", VA = "0x90A474")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000184")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 360f)]
		public float angle;

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x90A47C", Offset = "0x90A47C", VA = "0x90A47C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x90A4B4", Offset = "0x90A4B4", VA = "0x90A4B4")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000185")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	[ExecuteInEditMode]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000186")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000AEF")]
			Simple,
			[Token(Token = "0x4000AF0")]
			Advanced
		}

		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x4000AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x90A4DC", Offset = "0x90A4DC", VA = "0x90A4DC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x90A58C", Offset = "0x90A58C", VA = "0x90A58C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x90AAE0", Offset = "0x90AAE0", VA = "0x90AAE0")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000187")]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	[ExecuteInEditMode]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x90AB0C", Offset = "0x90AB0C", VA = "0x90AB0C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x90AB44", Offset = "0x90AB44", VA = "0x90AB44")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x2000188")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x2000189")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x90B2D0", Offset = "0x90B2D0", VA = "0x90B2D0", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x90ACD0", Offset = "0x90ACD0", VA = "0x90ACD0")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x4000B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x170000DB")]
		public bool protecting
		{
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x90AB6C", Offset = "0x90AB6C", VA = "0x90AB6C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x90AB74", Offset = "0x90AB74", VA = "0x90AB74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x90AB80", Offset = "0x90AB80", VA = "0x90AB80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x90ACD8", Offset = "0x90ACD8", VA = "0x90ACD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x90B258", Offset = "0x90B258", VA = "0x90B258")]
		public ProtectCameraFromWallClip()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200018A")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x90B3C4", Offset = "0x90B3C4", VA = "0x90B3C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x90B658", Offset = "0x90B658", VA = "0x90B658")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x90B7DC", Offset = "0x90B7DC", VA = "0x90B7DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x90B84C", Offset = "0x90B84C", VA = "0x90B84C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x90B918", Offset = "0x90B918", VA = "0x90B918", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x90B97C", Offset = "0x90B97C", VA = "0x90B97C")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x90B9E8", Offset = "0x90B9E8", VA = "0x90B9E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x90B9EC", Offset = "0x90B9EC", VA = "0x90B9EC")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x90BAB4", Offset = "0x90BAB4", VA = "0x90BAB4")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x90BB7C", Offset = "0x90BB7C", VA = "0x90BB7C")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x90BC44", Offset = "0x90BC44", VA = "0x90BC44")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x90BD0C", Offset = "0x90BD0C", VA = "0x90BD0C")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x90BDD4", Offset = "0x90BDD4", VA = "0x90BDD4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x90BDD8", Offset = "0x90BDD8", VA = "0x90BDD8")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200018D")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000B0E")]
			Hardware,
			[Token(Token = "0x4000B0F")]
			Touch
		}

		[Token(Token = "0x200018E")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x170000DD")]
			public string name
			{
				[Token(Token = "0x600092C")]
				[Address(RVA = "0x90C628", Offset = "0x90C628", VA = "0x90C628")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x90C630", Offset = "0x90C630", VA = "0x90C630")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000DE")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600092E")]
				[Address(RVA = "0x90C638", Offset = "0x90C638", VA = "0x90C638")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600092F")]
				[Address(RVA = "0x90C640", Offset = "0x90C640", VA = "0x90C640")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000DF")]
			public float GetValue
			{
				[Token(Token = "0x6000934")]
				[Address(RVA = "0x90C694", Offset = "0x90C694", VA = "0x90C694")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000E0")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000935")]
				[Address(RVA = "0x90C69C", Offset = "0x90C69C", VA = "0x90C69C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x90B544", Offset = "0x90B544", VA = "0x90B544")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x90C64C", Offset = "0x90C64C", VA = "0x90C64C")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x90B7F4", Offset = "0x90B7F4", VA = "0x90B7F4")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x90C68C", Offset = "0x90C68C", VA = "0x90C68C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200018F")]
		public class VirtualButton
		{
			[Token(Token = "0x4000B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x170000E1")]
			public string name
			{
				[Token(Token = "0x6000936")]
				[Address(RVA = "0x90C6A4", Offset = "0x90C6A4", VA = "0x90C6A4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000937")]
				[Address(RVA = "0x90C6AC", Offset = "0x90C6AC", VA = "0x90C6AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x90C6B4", Offset = "0x90C6B4", VA = "0x90C6B4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000939")]
				[Address(RVA = "0x90C6BC", Offset = "0x90C6BC", VA = "0x90C6BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E3")]
			public bool GetButton
			{
				[Token(Token = "0x600093F")]
				[Address(RVA = "0x90C7F8", Offset = "0x90C7F8", VA = "0x90C7F8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E4")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000940")]
				[Address(RVA = "0x90C800", Offset = "0x90C800", VA = "0x90C800")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E5")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0x90C824", Offset = "0x90C824", VA = "0x90C824")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x90C6C8", Offset = "0x90C6C8", VA = "0x90C6C8")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x90C70C", Offset = "0x90C70C", VA = "0x90C70C")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x90C754", Offset = "0x90C754", VA = "0x90C754")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x90C780", Offset = "0x90C780", VA = "0x90C780")]
			public void Released()
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x90C7A0", Offset = "0x90C7A0", VA = "0x90C7A0")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x170000DC")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x90C460", Offset = "0x90C460", VA = "0x90C460")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x90BDE0", Offset = "0x90BDE0", VA = "0x90BDE0")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x90BEB8", Offset = "0x90BEB8", VA = "0x90BEB8")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x90B4D8", Offset = "0x90B4D8", VA = "0x90B4D8")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x90BF5C", Offset = "0x90BF5C", VA = "0x90BF5C")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x90B580", Offset = "0x90B580", VA = "0x90B580")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x90BFC8", Offset = "0x90BFC8", VA = "0x90BFC8")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x90C034", Offset = "0x90C034", VA = "0x90C034")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x90C0F0", Offset = "0x90C0F0", VA = "0x90C0F0")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x90B5EC", Offset = "0x90B5EC", VA = "0x90B5EC")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x90C15C", Offset = "0x90C15C", VA = "0x90C15C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x90C234", Offset = "0x90C234", VA = "0x90C234")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x90C1B4", Offset = "0x90C1B4", VA = "0x90C1B4")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x90C28C", Offset = "0x90C28C", VA = "0x90C28C")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x90C2FC", Offset = "0x90C2FC", VA = "0x90C2FC")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x90C36C", Offset = "0x90C36C", VA = "0x90C36C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x90BA44", Offset = "0x90BA44", VA = "0x90BA44")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x90BB0C", Offset = "0x90BB0C", VA = "0x90BB0C")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x90BBD4", Offset = "0x90BBD4", VA = "0x90BBD4")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x90BD64", Offset = "0x90BD64", VA = "0x90BD64")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x90BC9C", Offset = "0x90BC9C", VA = "0x90BC9C")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x90C3DC", Offset = "0x90C3DC", VA = "0x90C3DC")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x90C4CC", Offset = "0x90C4CC", VA = "0x90C4CC")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x90C540", Offset = "0x90C540", VA = "0x90C540")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x90C5B4", Offset = "0x90C5B4", VA = "0x90C5B4")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x90C848", Offset = "0x90C848", VA = "0x90C848")]
		private void Update()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x90C84C", Offset = "0x90C84C", VA = "0x90C84C")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x90C8BC", Offset = "0x90C8BC", VA = "0x90C8BC")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000192")]
		public enum AxisOption
		{
			[Token(Token = "0x4000B23")]
			Both,
			[Token(Token = "0x4000B24")]
			OnlyHorizontal,
			[Token(Token = "0x4000B25")]
			OnlyVertical
		}

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x90C8C4", Offset = "0x90C8C4", VA = "0x90C8C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x90CA28", Offset = "0x90CA28", VA = "0x90CA28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x90CA58", Offset = "0x90CA58", VA = "0x90CA58")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x90C8C8", Offset = "0x90C8C8", VA = "0x90C8C8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x90CAB8", Offset = "0x90CAB8", VA = "0x90CAB8", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x90CC04", Offset = "0x90CC04", VA = "0x90CC04", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x90CC40", Offset = "0x90CC40", VA = "0x90CC40", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x90CC44", Offset = "0x90CC44", VA = "0x90CC44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x90CC84", Offset = "0x90CC84", VA = "0x90CC84")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000193")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x90CD10", Offset = "0x90CD10", VA = "0x90CD10")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x90CD20", Offset = "0x90CD20", VA = "0x90CD20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x90CD18", Offset = "0x90CD18", VA = "0x90CD18")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x90CE28", Offset = "0x90CE28", VA = "0x90CE28")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x90D120", Offset = "0x90D120", VA = "0x90D120")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000195")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000B2C")]
			ForwardAxis,
			[Token(Token = "0x4000B2D")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000196")]
		public class AxisMapping
		{
			[Token(Token = "0x2000197")]
			public enum MappingType
			{
				[Token(Token = "0x4000B31")]
				NamedAxis,
				[Token(Token = "0x4000B32")]
				MousePositionX,
				[Token(Token = "0x4000B33")]
				MousePositionY,
				[Token(Token = "0x4000B34")]
				MousePositionZ
			}

			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x90D47C", Offset = "0x90D47C", VA = "0x90D47C")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x90D128", Offset = "0x90D128", VA = "0x90D128")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x90D204", Offset = "0x90D204", VA = "0x90D204")]
		private void Update()
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x90D454", Offset = "0x90D454", VA = "0x90D454")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x90D46C", Offset = "0x90D46C", VA = "0x90D46C")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000198")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000199")]
		public enum AxisOption
		{
			[Token(Token = "0x4000B48")]
			Both,
			[Token(Token = "0x4000B49")]
			OnlyHorizontal,
			[Token(Token = "0x4000B4A")]
			OnlyVertical
		}

		[Token(Token = "0x200019A")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000B4C")]
			Absolute,
			[Token(Token = "0x4000B4D")]
			Relative,
			[Token(Token = "0x4000B4E")]
			Swipe
		}

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x90D484", Offset = "0x90D484", VA = "0x90D484")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x90D5C8", Offset = "0x90D5C8", VA = "0x90D5C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x90D488", Offset = "0x90D488", VA = "0x90D488")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x90D650", Offset = "0x90D650", VA = "0x90D650")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x90D750", Offset = "0x90D750", VA = "0x90D750", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x90D788", Offset = "0x90D788", VA = "0x90D788")]
		private void Update()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x90D960", Offset = "0x90D960", VA = "0x90D960", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x90D9C0", Offset = "0x90D9C0", VA = "0x90D9C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x90DA90", Offset = "0x90DA90", VA = "0x90DA90")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x170000E6")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x90DB24", Offset = "0x90DB24", VA = "0x90DB24")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x90DB30", Offset = "0x90DB30", VA = "0x90DB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x90DB3C", Offset = "0x90DB3C", VA = "0x90DB3C")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x90DB94", Offset = "0x90DB94", VA = "0x90DB94")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x90DBEC", Offset = "0x90DBEC", VA = "0x90DBEC")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x90DD84", Offset = "0x90DD84", VA = "0x90DD84")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x90DF1C", Offset = "0x90DF1C", VA = "0x90DF1C")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x90DFAC", Offset = "0x90DFAC", VA = "0x90DFAC")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x90E03C", Offset = "0x90E03C", VA = "0x90E03C")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x90E0D0", Offset = "0x90E0D0", VA = "0x90E0D0")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x90E0D8", Offset = "0x90E0D8", VA = "0x90E0D8")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x90E0E0", Offset = "0x90E0E0", VA = "0x90E0E0")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600096D")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600096E")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600096F")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000970")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000971")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000972")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000973")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000974")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000975")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000976")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000977")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x90E0E8", Offset = "0x90E0E8", VA = "0x90E0E8")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200019C")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x90E210", Offset = "0x90E210", VA = "0x90E210")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x90E29C", Offset = "0x90E29C", VA = "0x90E29C")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x90E328", Offset = "0x90E328", VA = "0x90E328", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x90E3C0", Offset = "0x90E3C0", VA = "0x90E3C0", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x90E458", Offset = "0x90E458", VA = "0x90E458", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x90E4F0", Offset = "0x90E4F0", VA = "0x90E4F0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x90E58C", Offset = "0x90E58C", VA = "0x90E58C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x90E628", Offset = "0x90E628", VA = "0x90E628", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x90E6C0", Offset = "0x90E6C0", VA = "0x90E6C0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x90E764", Offset = "0x90E764", VA = "0x90E764", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x90E7FC", Offset = "0x90E7FC", VA = "0x90E7FC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x90E894", Offset = "0x90E894", VA = "0x90E894", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x90E92C", Offset = "0x90E92C", VA = "0x90E92C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x90E938", Offset = "0x90E938", VA = "0x90E938")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x90E93C", Offset = "0x90E93C", VA = "0x90E93C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x90E950", Offset = "0x90E950", VA = "0x90E950", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x90E95C", Offset = "0x90E95C", VA = "0x90E95C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x90E968", Offset = "0x90E968", VA = "0x90E968", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x90E974", Offset = "0x90E974", VA = "0x90E974", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x90E9C4", Offset = "0x90E9C4", VA = "0x90E9C4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x90EA14", Offset = "0x90EA14", VA = "0x90EA14", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x90EA64", Offset = "0x90EA64", VA = "0x90EA64", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x90EAB4", Offset = "0x90EAB4", VA = "0x90EAB4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x90EB04", Offset = "0x90EB04", VA = "0x90EB04", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x90EB54", Offset = "0x90EB54", VA = "0x90EB54", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x90EB5C", Offset = "0x90EB5C", VA = "0x90EB5C")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Serializable]
	[Token(Token = "0x200019E")]
	public class MouseLook
	{
		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x90EB60", Offset = "0x90EB60", VA = "0x90EB60")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x90EBB0", Offset = "0x90EBB0", VA = "0x90EBB0")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x90EF54", Offset = "0x90EF54", VA = "0x90EF54")]
		public Quaternion LookRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x90EEF0", Offset = "0x90EEF0", VA = "0x90EEF0")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x90F1E0", Offset = "0x90F1E0", VA = "0x90F1E0")]
		public MouseLook()
		{
		}
	}
}
namespace VEAGames.LAM
{
	[Token(Token = "0x200019F")]
	public class BatchUpdateJob
	{
		[Token(Token = "0x4000B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly LAMBatchedFoliage m_Foliage;

		[Token(Token = "0x4000B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TerrainData m_TerrainData;

		[Token(Token = "0x4000B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stopwatch m_Stopwatch;

		[Token(Token = "0x4000B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_PatchIndex;

		[Token(Token = "0x4000B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long m_Mask;

		[Token(Token = "0x4000B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_TypeIndex;

		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_TypeInProgress;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_Complete;

		[Token(Token = "0x4000B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_PlacesLeft;

		[Token(Token = "0x4000B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_XStart;

		[Token(Token = "0x4000B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_XEnd;

		[Token(Token = "0x4000B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_YStart;

		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_YEnd;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_Stepx;

		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_Stepy;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_XCell;

		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_YCell;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_PlacesToFill;

		[Token(Token = "0x4000B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rect m_PatchRect;

		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Matrix4x4 m_RotOffset;

		[Token(Token = "0x4000B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject m_PatchRootObject;

		[Token(Token = "0x4000B71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private PatchType patchType;

		[Token(Token = "0x4000B72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly MeshBuilder m_MeshBuilder;

		[Token(Token = "0x4000B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly PatchBuilder m_PatchBuilder;

		[Token(Token = "0x170000E7")]
		public bool JobComplete
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x90F654", Offset = "0x90F654", VA = "0x90F654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x90F20C", Offset = "0x90F20C", VA = "0x90F20C")]
		public BatchUpdateJob(LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x90F65C", Offset = "0x90F65C", VA = "0x90F65C")]
		public void Start(int patchIndex, long mask, PatchType type = PatchType.DynamicPatch)
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x90F674", Offset = "0x90F674", VA = "0x90F674")]
		public float Update(float maxMs)
		{
			return default(float);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x90F6D8", Offset = "0x90F6D8", VA = "0x90F6D8")]
		private bool DoUpdate(float maxMs)
		{
			return default(bool);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x90F8A0", Offset = "0x90F8A0", VA = "0x90F8A0")]
		private void PrepareType(int typeIndex)
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x9107A0", Offset = "0x9107A0", VA = "0x9107A0")]
		private void BuildSomeMeshes(float maxMs)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x912F00", Offset = "0x912F00", VA = "0x912F00")]
		private GameObject InstantiatePrefab(Vector3 pos, Quaternion rotation, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x9134D4", Offset = "0x9134D4", VA = "0x9134D4")]
		public void CancelJob()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	[ExecuteInEditMode]
	public class LAMBatchedFoliage : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A1")]
		public class FoliageType
		{
			[Token(Token = "0x4000B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LAMFoliageDefinition Definition;

			[Token(Token = "0x4000B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool? _IsDefinitionCache;

			[Token(Token = "0x4000B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LAMBatchedFoliage_PatchesHolder PatchesHolder;

			[NonSerialized]
			[Token(Token = "0x4000B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool ForceDisableShadows;

			[NonSerialized]
			[Token(Token = "0x4000B91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float DensityAdjustment;

			[NonSerialized]
			[Token(Token = "0x4000B92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float OverrideCullDistance;

			[Token(Token = "0x170000E8")]
			private bool IsDefinition
			{
				[Token(Token = "0x60009BE")]
				[Address(RVA = "0x916048", Offset = "0x916048", VA = "0x916048")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E9")]
			public string Name
			{
				[Token(Token = "0x60009BF")]
				[Address(RVA = "0x915BCC", Offset = "0x915BCC", VA = "0x915BCC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			public MeshFilter PatchPrefab
			{
				[Token(Token = "0x60009C0")]
				[Address(RVA = "0x912258", Offset = "0x912258", VA = "0x912258")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			public GameObject InstancePrefab
			{
				[Token(Token = "0x60009C1")]
				[Address(RVA = "0x912ED0", Offset = "0x912ED0", VA = "0x912ED0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			public float MinDistance
			{
				[Token(Token = "0x60009C2")]
				[Address(RVA = "0x911778", Offset = "0x911778", VA = "0x911778")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000ED")]
			public float RotateToNormal
			{
				[Token(Token = "0x60009C3")]
				[Address(RVA = "0x9123B8", Offset = "0x9123B8", VA = "0x9123B8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000EE")]
			public bool RandomRotation
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0x9123E4", Offset = "0x9123E4", VA = "0x9123E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EF")]
			public MinMax ScaleVariation
			{
				[Token(Token = "0x60009C5")]
				[Address(RVA = "0x91241C", Offset = "0x91241C", VA = "0x91241C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			public Vector3 AdditionalRotation
			{
				[Token(Token = "0x60009C6")]
				[Address(RVA = "0x912034", Offset = "0x912034", VA = "0x912034")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F1")]
			public Vector3 AdditionalOffset
			{
				[Token(Token = "0x60009C7")]
				[Address(RVA = "0x911FBC", Offset = "0x911FBC", VA = "0x911FBC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F2")]
			public int MaxPerPatch
			{
				[Token(Token = "0x60009C8")]
				[Address(RVA = "0x9114EC", Offset = "0x9114EC", VA = "0x9114EC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000F3")]
			public bool MergeGeometry
			{
				[Token(Token = "0x60009C9")]
				[Address(RVA = "0x914864", Offset = "0x914864", VA = "0x914864")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F4")]
			public PatchType PatchType
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0x90F870", Offset = "0x90F870", VA = "0x90F870")]
				get
				{
					return default(PatchType);
				}
			}

			[Token(Token = "0x170000F5")]
			public bool UpdateAtRuntime
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0x91613C", Offset = "0x91613C", VA = "0x91613C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F6")]
			public bool RuntimeCulling
			{
				[Token(Token = "0x60009CC")]
				[Address(RVA = "0x916174", Offset = "0x916174", VA = "0x916174")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F7")]
			public float ShadowCullDistance
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0x9161AC", Offset = "0x9161AC", VA = "0x9161AC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000F8")]
			public float CullDistance
			{
				[Token(Token = "0x60009CE")]
				[Address(RVA = "0x9161D8", Offset = "0x9161D8", VA = "0x9161D8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000F9")]
			public Mesh Mesh
			{
				[Token(Token = "0x60009CF")]
				[Address(RVA = "0x91151C", Offset = "0x91151C", VA = "0x91151C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x916288", Offset = "0x916288", VA = "0x916288")]
			public FoliageType()
			{
			}
		}

		[Token(Token = "0x20001A2")]
		[CompilerGenerated]
		private sealed class <UpdateTypesRoutine>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LAMBatchedFoliage <>4__this;

			[Token(Token = "0x4000B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rect uvRect;

			[Token(Token = "0x4000B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public long typeMask;

			[Token(Token = "0x4000B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PatchType patchType;

			[Token(Token = "0x4000B99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int <myVersion>5__2;

			[Token(Token = "0x4000B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <xs>5__3;

			[Token(Token = "0x4000B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <ys>5__4;

			[Token(Token = "0x4000B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <xe>5__5;

			[Token(Token = "0x4000B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private int <ye>5__6;

			[Token(Token = "0x4000B9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <n>5__7;

			[Token(Token = "0x4000B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private int <ii>5__8;

			[Token(Token = "0x4000BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int <jj>5__9;

			[Token(Token = "0x170000FA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D4")]
				[Address(RVA = "0x916680", Offset = "0x916680", VA = "0x916680", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D6")]
				[Address(RVA = "0x9166C8", Offset = "0x9166C8", VA = "0x9166C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x91483C", Offset = "0x91483C", VA = "0x91483C")]
			[DebuggerHidden]
			public <UpdateTypesRoutine>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x916298", Offset = "0x916298", VA = "0x916298", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x91629C", Offset = "0x91629C", VA = "0x91629C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x916688", Offset = "0x916688", VA = "0x916688", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public int PatchesResolution;

		[Token(Token = "0x4000B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RandomSeed;

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(5f, 25f)]
		public float RuntimeFrameBudget;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public float GrassRebuildDistance;

		[Token(Token = "0x4000B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float RuntimeRebuildDistance;

		[Token(Token = "0x4000B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float MeshScaleMultiplier;

		[Token(Token = "0x4000B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float RuntimeDensityMultiplier;

		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[FormerlySerializedAs("Layers")]
		public FoliageType[] Types;

		[Token(Token = "0x4000B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LAMBatchedFoliage_TypeDataHolder DataHolder;

		[Token(Token = "0x4000B7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public int MaxDetailResolution;

		[Token(Token = "0x4000B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		public float TerrainHeigth;

		[Token(Token = "0x4000B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float TerrainPatchesRatio;

		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public float PatchesMultiplier;

		[Token(Token = "0x4000B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public float DefaultDetailResolution;

		[Token(Token = "0x4000B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public float DefaultPatchesResolution;

		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LAMDetailsAutoPainter dap;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Terrain m_Terrain;

		[Token(Token = "0x4000B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Camera m_Spectator;

		[Token(Token = "0x4000B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private long[,] m_PatchesValidity;

		[Token(Token = "0x4000B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BatchUpdateJob m_Updater;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject m_GrassPatcher;

		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_CurrentUpdateRoutineVersion;

		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<int> m_GrassListPatch;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<int> m_DynamicListPatch;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool isRebuild;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x9135D4", Offset = "0x9135D4", VA = "0x9135D4")]
		private GameObject GetPatchObject(int patchIndex, FoliageType type)
		{
			return null;
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x910448", Offset = "0x910448", VA = "0x910448")]
		public bool ClearPatch(int patchIndex, FoliageType type, bool alsoDestroyPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x9136DC", Offset = "0x9136DC", VA = "0x9136DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x913F10", Offset = "0x913F10", VA = "0x913F10")]
		private void Start()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x9142B4", Offset = "0x9142B4", VA = "0x9142B4")]
		public void CopyData(LAMBatchedFoliage_TypeDataHolder otherData)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x9139BC", Offset = "0x9139BC", VA = "0x9139BC")]
		private void RecreateDataArrays(bool fromValidate = false)
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x913DD8", Offset = "0x913DD8", VA = "0x913DD8")]
		private void RecreatePatchesValidity(bool newResolution = false)
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x9143BC", Offset = "0x9143BC", VA = "0x9143BC")]
		private void CheckUpdatesOverlap()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x914480", Offset = "0x914480", VA = "0x914480")]
		public void UpdateTypesSync(long typeMask, Rect uvRect, PatchType type = PatchType.DynamicPatch)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x914788", Offset = "0x914788", VA = "0x914788")]
		[IteratorStateMachine(typeof(<UpdateTypesRoutine>d__35))]
		public IEnumerator UpdateTypesRoutine(long typeMask, Rect uvRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x911728", Offset = "0x911728", VA = "0x911728")]
		public Rect GetPatchRect(int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x9117A8", Offset = "0x9117A8", VA = "0x9117A8")]
		public GameObject ResetPatchObject(int patchIndex, int typeIndex)
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x914904", Offset = "0x914904", VA = "0x914904")]
		private void Update()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x91492C", Offset = "0x91492C", VA = "0x91492C")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x915374", Offset = "0x915374", VA = "0x915374")]
		private bool TryBuildPatchCycle(int cx, int cy, ref float budget, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x9151AC", Offset = "0x9151AC", VA = "0x9151AC")]
		private bool TryBuildPatchRuntime(int x, int y, ref float msLeft, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x914F74", Offset = "0x914F74", VA = "0x914F74")]
		private bool TryDestroyPatchCycle(int cx, int cy, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x915644", Offset = "0x915644", VA = "0x915644")]
		private bool TryDestroyListPatch(Rect buildRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x915804", Offset = "0x915804", VA = "0x915804")]
		private bool TryDestroyPatchRuntime(int patchIndex, Rect buildRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x911F34", Offset = "0x911F34", VA = "0x911F34")]
		public Vector3 UvToTerrain(Vector2 relativePos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x9159E0", Offset = "0x9159E0", VA = "0x9159E0")]
		public void SetTypeData(int x, int y, int typeIndex, bool value)
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x915AC0", Offset = "0x915AC0", VA = "0x915AC0")]
		public void SetTypeDataRect(int xStart, int yStart, int detailIndex, int[,] data)
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x91154C", Offset = "0x91154C", VA = "0x91154C")]
		public string GetTypeName(int index)
		{
			return null;
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x915C38", Offset = "0x915C38", VA = "0x915C38")]
		public void Remove(int index)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x910730", Offset = "0x910730", VA = "0x910730")]
		public void MarkValidity(int patchIndex, int typeIndex, bool valid)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x915E74", Offset = "0x915E74", VA = "0x915E74")]
		public void ClearType(int typeIndex)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x914470", Offset = "0x914470", VA = "0x914470")]
		public void CancelPendingRebuild()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x913F1C", Offset = "0x913F1C", VA = "0x913F1C")]
		public void RunDestroy(bool newResolution = false, bool destroyAll = false)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x915F28", Offset = "0x915F28", VA = "0x915F28")]
		public LAMBatchedFoliage()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	internal class Timer : IDisposable
	{
		[Token(Token = "0x4000BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string m_Text;

		[Token(Token = "0x4000BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stopwatch m_Stopwatch;

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x916714", Offset = "0x916714", VA = "0x916714")]
		public Timer(string text)
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x9167A0", Offset = "0x9167A0", VA = "0x9167A0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class LAMBatchedFoliage_FoliageHolder : MonoBehaviour
	{
		[Token(Token = "0x4000BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public LAMBatchedFoliage_PatchesHolder PatchesHolder;

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x916888", Offset = "0x916888", VA = "0x916888")]
		public LAMBatchedFoliage_FoliageHolder()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public class LAMBatchedFoliage_PatchesHolder : MonoBehaviour
	{
		[Token(Token = "0x20001A7")]
		private struct PatchCullData
		{
			[Token(Token = "0x4000BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MeshRenderer Renderer;
		}

		[Token(Token = "0x4000BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] PatchObjects;

		[Token(Token = "0x4000BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool MergeGeometry;

		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public GameObject FoliageHolder;

		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<PatchCulling> LAMPatches;

		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PatchCullData[] m_PatchCull;

		[Token(Token = "0x4000BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CullingGroup m_Culling;

		[Token(Token = "0x4000BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LAMBatchedFoliage m_BatchedFoliage;

		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_LayerIndex;

		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_SpheresCount;

		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Initialized;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private ShadowCastingMode m_DefaultShadowMode;

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x916890", Offset = "0x916890", VA = "0x916890")]
		private void Initialize(LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x916B84", Offset = "0x916B84", VA = "0x916B84")]
		private void SetupCullingGroup(float halfDistance, float maxDistance)
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x916F30", Offset = "0x916F30", VA = "0x916F30")]
		private void OnPatchCullingStateChanged(CullingGroupEvent evt)
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x916F78", Offset = "0x916F78", VA = "0x916F78")]
		private void Cull(int objIndex, int distance)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x917168", Offset = "0x917168", VA = "0x917168")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x91489C", Offset = "0x91489C", VA = "0x91489C")]
		public void AddObject(int patchIndex, GameObject go)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x913314", Offset = "0x913314", VA = "0x913314")]
		public void AddLAMPatch(PatchCulling pc)
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x913684", Offset = "0x913684", VA = "0x913684")]
		public void RemoveLAMPatch(PatchCulling pc)
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x9133C4", Offset = "0x9133C4", VA = "0x9133C4")]
		public void PrepareCull(int patchIndex, LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x91719C", Offset = "0x91719C", VA = "0x91719C")]
		public void UpdateCullDistances(float halfDistance, float maxDistance)
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x917248", Offset = "0x917248", VA = "0x917248")]
		public void DestroyPatches()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x91736C", Offset = "0x91736C", VA = "0x91736C")]
		public LAMBatchedFoliage_PatchesHolder()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public class LAMBatchedFoliage_TypeDataHolder : ScriptableObject
	{
		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public long[] Data;

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x917460", Offset = "0x917460", VA = "0x917460")]
		public LAMBatchedFoliage_TypeDataHolder()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public class LAMCopyTerrainMaterialProps : MonoBehaviour
	{
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x917468", Offset = "0x917468", VA = "0x917468")]
		private void Start()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x917848", Offset = "0x917848", VA = "0x917848")]
		public LAMCopyTerrainMaterialProps()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	[ExecuteInEditMode]
	public class LAMDetailsAutoPainter : MonoBehaviour
	{
		[Token(Token = "0x20001AB")]
		public enum TextureChannelType
		{
			[Token(Token = "0x4000BBF")]
			Red,
			[Token(Token = "0x4000BC0")]
			Green,
			[Token(Token = "0x4000BC1")]
			Blue,
			[Token(Token = "0x4000BC2")]
			Alpha,
			[Token(Token = "0x4000BC3")]
			Black
		}

		[Serializable]
		[Token(Token = "0x20001AC")]
		public class LayerDefinition
		{
			[Token(Token = "0x4000BC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4000BC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LAMMultiPaintLayer PaintLayer;

			[Token(Token = "0x4000BC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float[] TextureLayerWeights;

			[Token(Token = "0x4000BC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[CurveGraph(Start = 0f, End = 90f)]
			public TrapezoidCurve SlopeCutoff;

			[Token(Token = "0x4000BC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float Density;

			[Token(Token = "0x4000BC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Range(0f, 1f)]
			public float RandomVariation;

			[Token(Token = "0x4000BCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float MinWeight;

			[Token(Token = "0x4000BCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Texture2D MaskTexture;

			[Token(Token = "0x4000BCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float MaskTextureScale;

			[Token(Token = "0x4000BCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public TextureChannelType MaskChannel;

			[Token(Token = "0x4000BCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool DodgeUpperLayers;

			[Token(Token = "0x4000BCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
			public bool SkipRepaint;

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x918D5C", Offset = "0x918D5C", VA = "0x918D5C")]
			public LayerDefinition()
			{
			}
		}

		[Token(Token = "0x20001AD")]
		private class TerrainSample
		{
			[Token(Token = "0x4000BD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 UV;

			[Token(Token = "0x4000BD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float[] LayerWeights;

			[Token(Token = "0x4000BD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 Normal;

			[Token(Token = "0x4000BD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float Height;

			[Token(Token = "0x4000BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float SlopeAngle;

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x918DF4", Offset = "0x918DF4", VA = "0x918DF4")]
			public TerrainSample()
			{
			}
		}

		[Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class <Paint>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LAMDetailsAutoPainter <>4__this;

			[Token(Token = "0x4000BDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rect rect;

			[Token(Token = "0x4000BDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TerrainData <td>5__2;

			[Token(Token = "0x4000BDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <xStart>5__3;

			[Token(Token = "0x4000BDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int <yStart>5__4;

			[Token(Token = "0x4000BDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <w>5__5;

			[Token(Token = "0x4000BE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <h>5__6;

			[Token(Token = "0x4000BE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TerrainSample <sample>5__7;

			[Token(Token = "0x4000BE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <ii>5__8;

			[Token(Token = "0x4000BE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private int <jj>5__9;

			[Token(Token = "0x170000FC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A02")]
				[Address(RVA = "0x919C60", Offset = "0x919C60", VA = "0x919C60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A04")]
				[Address(RVA = "0x919CA8", Offset = "0x919CA8", VA = "0x919CA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x917DE0", Offset = "0x917DE0", VA = "0x917DE0")]
			[DebuggerHidden]
			public <Paint>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x918EAC", Offset = "0x918EAC", VA = "0x918EAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x918EB0", Offset = "0x918EB0", VA = "0x918EB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x919C68", Offset = "0x919C68", VA = "0x919C68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int RandomSeed;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SplatMaskScaleMultiplier;

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public LayerDefinition[] Layers;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LAMMultiPaintLayer[] m_PaintLayers;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LAMDetailsAutoPainter_LayerDataHolder DataHolder;

		[Token(Token = "0x4000BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float GlobalDensityAdjust;

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Terrain m_Terrain;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LAMTerrainTool m_TerrainTool;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[,,] m_AlphaMaps;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public LAMBatchedFoliage Batched;

		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LatticeNoise m_Noise;

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x917850", Offset = "0x917850", VA = "0x917850")]
		private void Start()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x917934", Offset = "0x917934", VA = "0x917934")]
		public void UpdateMaps()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x9179E0", Offset = "0x9179E0", VA = "0x9179E0")]
		private void RecreateDataHolder()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x917C40", Offset = "0x917C40", VA = "0x917C40")]
		public void CopyData(LAMDetailsAutoPainter_LayerDataHolder otherData)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x917D44", Offset = "0x917D44", VA = "0x917D44")]
		[IteratorStateMachine(typeof(<Paint>d__18))]
		public IEnumerator Paint(Rect rect)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x917E08", Offset = "0x917E08", VA = "0x917E08")]
		private bool LayerIsValid(LayerDefinition layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x917EBC", Offset = "0x917EBC", VA = "0x917EBC")]
		private int PaintSample(int layerIndex, int ii, int jj, TerrainSample sample, ref float sum)
		{
			return default(int);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x918250", Offset = "0x918250", VA = "0x918250")]
		private float GetChannel(Color color, TextureChannelType maskChannel)
		{
			return default(float);
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x918378", Offset = "0x918378", VA = "0x918378")]
		private void SampleTerrainData(float x, float y, TerrainSample result)
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x918794", Offset = "0x918794", VA = "0x918794")]
		private float SampleBilinear(int alphaIndex, Vector2 pos)
		{
			return default(float);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x9182F4", Offset = "0x9182F4", VA = "0x9182F4")]
		private int ProbRound(float v, float rnd)
		{
			return default(int);
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x9189E0", Offset = "0x9189E0", VA = "0x9189E0")]
		public void ClearLayer(int index)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x918D48", Offset = "0x918D48", VA = "0x918D48")]
		public LAMDetailsAutoPainter()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class LAMDetailsAutoPainter_LayerDataHolder : ScriptableObject
	{
		[Token(Token = "0x4000BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public byte[] Data;

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x919CE0", Offset = "0x919CE0", VA = "0x919CE0")]
		public LAMDetailsAutoPainter_LayerDataHolder()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public sealed class LAMEditorSettings : ScriptableObject
	{
		[Token(Token = "0x4000BE6")]
		private const string GUID = "36ce4cc03e7f99943b402502e4164709";

		[Token(Token = "0x4000BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LAMEditorSettings _Instance;

		[Token(Token = "0x4000BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _IsLoaded;

		[Token(Token = "0x4000BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D _AutoLayerIcon;

		[Token(Token = "0x4000BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D _MultiBrushIcon;

		[Token(Token = "0x170000FE")]
		public static LAMEditorSettings Instance
		{
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x919CFC", Offset = "0x919CFC", VA = "0x919CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FF")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x919D84", Offset = "0x919D84", VA = "0x919D84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000100")]
		public Texture2D AutoLayerIcon
		{
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x919E2C", Offset = "0x919E2C", VA = "0x919E2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x919E34", Offset = "0x919E34", VA = "0x919E34")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public Texture2D MultiBrushIcon
		{
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x919E3C", Offset = "0x919E3C", VA = "0x919E3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x919E44", Offset = "0x919E44", VA = "0x919E44")]
			set
			{
			}
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x919CE8", Offset = "0x919CE8", VA = "0x919CE8")]
		private LAMEditorSettings()
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x919CF0", Offset = "0x919CF0", VA = "0x919CF0")]
		private void Awake()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	[CreateAssetMenu(fileName = "new foliage", menuName = "LAM Foliage Type")]
	public class LAMFoliageDefinition : ScriptableObject
	{
		[Token(Token = "0x4000BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshFilter PatchPrefab;

		[Token(Token = "0x4000BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject InstancePrefab;

		[Token(Token = "0x4000BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float MinDistance;

		[Token(Token = "0x4000BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float RotateToNormal;

		[Token(Token = "0x4000BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RandomRotation;

		[Token(Token = "0x4000BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[MinMax(MinLimit = 0.5f, MaxLimit = 2.5f)]
		public MinMax ScaleVariation;

		[Token(Token = "0x4000BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 AdditionalRotation;

		[Token(Token = "0x4000BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 AdditionalOffset;

		[Token(Token = "0x4000BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int MaxPerPatch;

		[Token(Token = "0x4000BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public bool MergeGeometry;

		[Token(Token = "0x4000BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public PatchType PatchType;

		[Token(Token = "0x4000BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		public bool UpdateAtRuntime;

		[Token(Token = "0x4000BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		[HideInInspector]
		public bool RuntimeCulling;

		[Token(Token = "0x4000BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[FormerlySerializedAs("HalfCullDistance")]
		public float ShadowCullDistance;

		[Token(Token = "0x4000BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		public float CullDistance;

		[Token(Token = "0x17000102")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x916204", Offset = "0x916204", VA = "0x916204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x919E4C", Offset = "0x919E4C", VA = "0x919E4C")]
		public LAMFoliageDefinition()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B4")]
	public class LAMMultiPaintLayer
	{
		[Token(Token = "0x20001B5")]
		public enum LayerType
		{
			[Token(Token = "0x4000C01")]
			BuiltInDetail,
			[Token(Token = "0x4000C02")]
			BuiltInTree,
			[Token(Token = "0x4000C03")]
			BatchedFoliage
		}

		[Token(Token = "0x4000BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayerType Type;

		[Token(Token = "0x4000BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int DetailIndex;

		[Token(Token = "0x4000BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Gradient TreeColorVariation;

		[Token(Token = "0x4000BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MinMax(MinLimit = 0.5f, MaxLimit = 2.5f)]
		public MinMax TreeScaleVariation;

		[Token(Token = "0x4000BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[MinMax(MinLimit = 0.5f, MaxLimit = 2.5f)]
		public MinMax TreeHeightVariation;

		[NonSerialized]
		[Token(Token = "0x4000BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[XmlIgnore]
		public int[,] Data;

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x9199D8", Offset = "0x9199D8", VA = "0x9199D8")]
		public static void ApplyLayers(LAMMultiPaintLayer[] layers, int xStart, int yStart, Terrain terrain, int treesSeed, out long batchedMask)
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x919F90", Offset = "0x919F90", VA = "0x919F90")]
		private static void SetDetailLayer(int xStart, int yStart, TerrainData td, LAMMultiPaintLayer layer)
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x91987C", Offset = "0x91987C", VA = "0x91987C")]
		public void InitData(int x, int y)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x91A7C0", Offset = "0x91A7C0", VA = "0x91A7C0")]
		public static string[] GetLayerNames(LayerType type, Component ownerComponent)
		{
			return null;
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x91A8B4", Offset = "0x91A8B4", VA = "0x91A8B4")]
		public static string[] GetDetailLayerNames(Terrain terrain)
		{
			return null;
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x91A9F8", Offset = "0x91A9F8", VA = "0x91A9F8")]
		public static string[] GetTreeLayerNames(Terrain terrain)
		{
			return null;
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x91AB3C", Offset = "0x91AB3C", VA = "0x91AB3C")]
		public static string[] GetFoliageLayerNames(LAMBatchedFoliage bf)
		{
			return null;
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x91ACB0", Offset = "0x91ACB0", VA = "0x91ACB0")]
		public string GetLayerName(Component ownerComponent)
		{
			return null;
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x91999C", Offset = "0x91999C", VA = "0x91999C")]
		public bool IsSameAs(LAMMultiPaintLayer other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x91B060", Offset = "0x91B060", VA = "0x91B060")]
		public LAMMultiPaintLayer()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class LAMQualitySettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B9")]
		public class QualityLevelData
		{
			[Token(Token = "0x4000C0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[QualityLevel]
			public int QualityLevel;

			[Token(Token = "0x4000C10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool DisableGrassShadows;

			[Token(Token = "0x4000C11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float GrassDrawDistance;

			[Token(Token = "0x4000C12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			public float GrassDensityMultiplier;

			[Token(Token = "0x4000C13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool DisableTerrainTesselation;

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x91C710", Offset = "0x91C710", VA = "0x91C710")]
			public QualityLevelData()
			{
			}
		}

		[Token(Token = "0x4000C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public QualityLevelData[] Levels;

		[Token(Token = "0x4000C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public LayerMask GrassLayers;

		[Token(Token = "0x4000C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Material> m_GrassFadingMaterials;

		[Token(Token = "0x4000C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ShowGui;

		[Token(Token = "0x4000C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool m_GuiVisible;

		[Token(Token = "0x4000C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] m_Times;

		[Token(Token = "0x17000103")]
		public int CurrentLevel
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x91B39C", Offset = "0x91B39C", VA = "0x91B39C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x91B3A4", Offset = "0x91B3A4", VA = "0x91B3A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x91B3AC", Offset = "0x91B3AC", VA = "0x91B3AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x91B400", Offset = "0x91B400", VA = "0x91B400")]
		public int GetMatchingLevel(int unityQualityLevel)
		{
			return default(int);
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x91BA3C", Offset = "0x91BA3C", VA = "0x91BA3C")]
		public void SetLevel(int index)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x91B4F4", Offset = "0x91B4F4", VA = "0x91B4F4")]
		private void SetLevel(QualityLevelData levelData, bool force = false)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x91BA94", Offset = "0x91BA94", VA = "0x91BA94")]
		private void ApplyGrassSettings(LAMBatchedFoliage foliage, QualityLevelData levelData, bool force)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x91C058", Offset = "0x91C058", VA = "0x91C058")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x91C0BC", Offset = "0x91C0BC", VA = "0x91C0BC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x914D4C", Offset = "0x914D4C", VA = "0x914D4C")]
		public static void RefreshGrassSettings(float GrassDrawDistance)
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x91C60C", Offset = "0x91C60C", VA = "0x91C60C")]
		public LAMQualitySettings()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public class QualityLevelAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x91C718", Offset = "0x91C718", VA = "0x91C718")]
		public QualityLevelAttribute()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	[ExecuteInEditMode]
	public class LAMTerrainTool : MonoBehaviour
	{
		[Token(Token = "0x20001BC")]
		public enum ShaderType
		{
			[Token(Token = "0x4000C23")]
			AdditiveWith3AutoLayers,
			[Token(Token = "0x4000C24")]
			DisplacementWith3Layers,
			[Token(Token = "0x4000C25")]
			DisplacementWith6Layers
		}

		[Token(Token = "0x20001BD")]
		public class ShaderTypeMetaData
		{
			[Token(Token = "0x4000C26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string ShaderName;

			[Token(Token = "0x4000C27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Description;

			[Token(Token = "0x4000C28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int MaxLayers;

			[Token(Token = "0x4000C29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool HasAdditiveLayers;

			[Token(Token = "0x4000C2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool HasTesselation;

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x91E7E8", Offset = "0x91E7E8", VA = "0x91E7E8")]
			public ShaderTypeMetaData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BE")]
		public class LayerDefinition
		{
			[Token(Token = "0x4000C2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4000C2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D ColorTexture;

			[Token(Token = "0x4000C2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Texture2D NormalsTexture;

			[Token(Token = "0x4000C2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D SMOTexture;

			[Token(Token = "0x4000C2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float Scale;

			[Token(Token = "0x4000C30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float ScaleFar;

			[Token(Token = "0x4000C31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float ScaleMixStart;

			[Token(Token = "0x4000C32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float ScaleMixEnd;

			[Token(Token = "0x4000C33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool UseAuto;

			[Token(Token = "0x4000C34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public TrapezoidCurve Angle;

			[Token(Token = "0x4000C35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public TrapezoidCurve Height;

			[Token(Token = "0x4000C36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0.001f, 1f)]
			public float TextureBleed;

			[Token(Token = "0x4000C37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			public float DisplacementScale;

			[Token(Token = "0x4000C38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			public float Roughness;

			[Token(Token = "0x4000C39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Color Specular;

			[Token(Token = "0x4000C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public bool UseTriplanarProjection;

			[Token(Token = "0x4000C3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[FormerlySerializedAs("NoiseAmount")]
			public float OverlayStrength;

			[Token(Token = "0x4000C3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[FormerlySerializedAs("NoiseScale")]
			public float OverlayScale;

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x91E7F0", Offset = "0x91E7F0", VA = "0x91E7F0")]
			public LayerDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BF")]
		public class TessData
		{
			[Token(Token = "0x4000C3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float RangeMin;

			[Token(Token = "0x4000C3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float RangeMax;

			[Token(Token = "0x4000C3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Tesselation;

			[Token(Token = "0x4000C40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0.1f, 8f)]
			public float FalloffPower;

			[Token(Token = "0x4000C41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float GlobalScale;

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x91E53C", Offset = "0x91E53C", VA = "0x91E53C")]
			public TessData()
			{
			}
		}

		[Token(Token = "0x4000C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D IconAuto;

		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShaderType Shader;

		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerDefinition[] Layers;

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("Noise")]
		public Texture2D ColorOverlay;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("NoiseScaleMultiplier")]
		public float OverlayScaleMultiplier;

		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TessData Displacement;

		[Token(Token = "0x4000C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D ColorPaintTexture;

		[Token(Token = "0x4000C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool AutoDebugMode;

		[Token(Token = "0x4000C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GlobalScale;

		[Token(Token = "0x4000C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialInstance;

		[Token(Token = "0x4000C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Terrain m_Terrain;

		[Token(Token = "0x4000C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D s_GrayTexture;

		[Token(Token = "0x4000C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public SplatPrototype[] oldsp;

		[Token(Token = "0x4000C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly ShaderTypeMetaData[] MetaData;

		[Token(Token = "0x17000104")]
		private string CurrentShader
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x91C720", Offset = "0x91C720", VA = "0x91C720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x91C7A8", Offset = "0x91C7A8", VA = "0x91C7A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x91CE34", Offset = "0x91CE34", VA = "0x91CE34")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x91C828", Offset = "0x91C828", VA = "0x91C828")]
		private void EnsureInstance()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x91CF94", Offset = "0x91CF94", VA = "0x91CF94")]
		public void EnsureLayerCount()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x91D49C", Offset = "0x91D49C", VA = "0x91D49C")]
		public bool SplatPrototypesEquals(SplatPrototype[] arrOne, SplatPrototype[] arrTwo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x91CA54", Offset = "0x91CA54", VA = "0x91CA54")]
		public void ApplyMaterialProperties()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x91D7F0", Offset = "0x91D7F0", VA = "0x91D7F0")]
		private void ApplyLayerDefinition(LayerDefinition layer, int index)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x91DFCC", Offset = "0x91DFCC", VA = "0x91DFCC")]
		private void ClearLayerDefinition(int index, bool alsoTextures = true)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x9189A4", Offset = "0x9189A4", VA = "0x9189A4")]
		public LayerDefinition GetLayer(int index)
		{
			return null;
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x9176EC", Offset = "0x9176EC", VA = "0x9176EC")]
		public static Texture2D GetGrayTexture()
		{
			return null;
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x91E308", Offset = "0x91E308", VA = "0x91E308")]
		public void SetGrassShaderPropertiesGlobal()
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x91E440", Offset = "0x91E440", VA = "0x91E440")]
		public LAMTerrainTool()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	[ExecuteInEditMode]
	public class LAMWind : MonoBehaviour
	{
		[Token(Token = "0x4000C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float WindStrength;

		[Token(Token = "0x4000C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float WaveStrength;

		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float WaveFrequency;

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x91E8D4", Offset = "0x91E8D4", VA = "0x91E8D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x91E99C", Offset = "0x91E99C", VA = "0x91E99C")]
		public LAMWind()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public struct LatticeNoise
	{
		[Token(Token = "0x4000C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_Seed;

		[Token(Token = "0x17000105")]
		public int Seed
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x91E9BC", Offset = "0x91E9BC", VA = "0x91E9BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x91E9B4", Offset = "0x91E9B4", VA = "0x91E9B4")]
		public LatticeNoise(int seed)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x9122E4", Offset = "0x9122E4", VA = "0x9122E4")]
		public float GetValue01(int x, int y)
		{
			return default(float);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x912354", Offset = "0x912354", VA = "0x912354")]
		public float GetValue(int x, int y)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20001C2")]
	public class MeshBuilder
	{
		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<Vector3> m_Vertices;

		[Token(Token = "0x4000C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<Vector3> m_Normals;

		[Token(Token = "0x4000C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<Vector4> m_Tangents;

		[Token(Token = "0x4000C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<int> m_Indices;

		[Token(Token = "0x4000C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<Vector2> m_UVs;

		[Token(Token = "0x4000C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<Vector2> m_UV2s;

		[Token(Token = "0x4000C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<Vector2> m_UV3s;

		[Token(Token = "0x4000C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<Vector2> m_UV4s;

		[Token(Token = "0x4000C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<Color> m_Colors;

		[Token(Token = "0x4000C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshTopology m_Topology;

		[Token(Token = "0x4000C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Mesh m_LastMesh;

		[Token(Token = "0x4000C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_InstanceIndex;

		[Token(Token = "0x4000C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] m_LastVertices;

		[Token(Token = "0x4000C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] m_LastNormals;

		[Token(Token = "0x4000C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector4[] m_LastTangents;

		[Token(Token = "0x4000C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int[] m_LastIndices;

		[Token(Token = "0x4000C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2[] m_LastUVs;

		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2[] m_LastUV2s;

		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2[] m_LastUV3s;

		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector2[] m_LastUV4s;

		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Color[] m_LastColors;

		[Token(Token = "0x17000106")]
		public int[] Indices
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x91E9C4", Offset = "0x91E9C4", VA = "0x91E9C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		public int InstanceCount
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x91EA14", Offset = "0x91EA14", VA = "0x91EA14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x91EA1C", Offset = "0x91EA1C", VA = "0x91EA1C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x9124AC", Offset = "0x9124AC", VA = "0x9124AC")]
		public void AddMeshInstance(Matrix4x4 transform, Color colorModifier)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x91EB40", Offset = "0x91EB40", VA = "0x91EB40")]
		private static bool HasData(Array array)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x913030", Offset = "0x913030", VA = "0x913030")]
		public Mesh CreateMesh()
		{
			return null;
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x9120AC", Offset = "0x9120AC", VA = "0x9120AC")]
		public void Reset(Mesh mesh)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x90F35C", Offset = "0x90F35C", VA = "0x90F35C")]
		public MeshBuilder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001C3")]
	public class MinMax
	{
		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Min;

		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Max;

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x912498", Offset = "0x912498", VA = "0x912498")]
		public float Get(float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x91EB60", Offset = "0x91EB60", VA = "0x91EB60")]
		public float Get()
		{
			return default(float);
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x916134", Offset = "0x916134", VA = "0x916134")]
		public MinMax()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	public class MinMaxAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float MinLimit;

		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxLimit;

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x91EB8C", Offset = "0x91EB8C", VA = "0x91EB8C")]
		public MinMaxAttribute()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class PatchBuilder
	{
		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<MeshRenderer> m_Objects;

		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Mesh m_LastMesh;

		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] m_LastMaterials;

		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_LastRoot;

		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_InstanceIndex;

		[Token(Token = "0x17000108")]
		public int InstanceCount
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x91EB9C", Offset = "0x91EB9C", VA = "0x91EB9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x91EBA4", Offset = "0x91EBA4", VA = "0x91EBA4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x912C88", Offset = "0x912C88", VA = "0x912C88")]
		public void AddPatchInstance(Vector3 patchPos, Quaternion patchRot, Vector3 patchScale)
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x91EC18", Offset = "0x91EC18", VA = "0x91EC18")]
		private static bool HasData(Array array)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x9132C4", Offset = "0x9132C4", VA = "0x9132C4")]
		public MeshRenderer[] CreatePatch()
		{
			return null;
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x912288", Offset = "0x912288", VA = "0x912288")]
		public void Reset(Mesh mesh, Material[] mat, GameObject root)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x90F5CC", Offset = "0x90F5CC", VA = "0x90F5CC")]
		public PatchBuilder()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	[ExecuteInEditMode]
	public class SetLayerCullDistances : MonoBehaviour
	{
		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ApplyToEditorCamera;

		[Token(Token = "0x4000C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public float[] LayerDistances;

		[Token(Token = "0x4000C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera camera;

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x91EC38", Offset = "0x91EC38", VA = "0x91EC38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x91ED18", Offset = "0x91ED18", VA = "0x91ED18")]
		public SetLayerCullDistances()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001C7")]
	public class TrapezoidCurve
	{
		[Token(Token = "0x4000C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float From;

		[Token(Token = "0x4000C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float To;

		[Token(Token = "0x4000C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Smoothing;

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x918210", Offset = "0x918210", VA = "0x918210")]
		public float GetValue(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x918DEC", Offset = "0x918DEC", VA = "0x918DEC")]
		public TrapezoidCurve()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public class CurveGraphAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Start;

		[Token(Token = "0x4000C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float End;

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x91ED7C", Offset = "0x91ED7C", VA = "0x91ED7C")]
		public CurveGraphAttribute()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public class TreePainter
	{
		[Token(Token = "0x4000C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Terrain m_Terrain;

		[Token(Token = "0x4000C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<TreeInstance> m_Trees;

		[Token(Token = "0x17000109")]
		public MinMax ScaleVariation
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x91ED8C", Offset = "0x91ED8C", VA = "0x91ED8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x91ED94", Offset = "0x91ED94", VA = "0x91ED94")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public MinMax HeightVariation
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x91ED9C", Offset = "0x91ED9C", VA = "0x91ED9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x91EDA4", Offset = "0x91EDA4", VA = "0x91EDA4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public Gradient ColorVariation
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x91EDAC", Offset = "0x91EDAC", VA = "0x91EDAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x91EDB4", Offset = "0x91EDB4", VA = "0x91EDB4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x919EEC", Offset = "0x919EEC", VA = "0x919EEC")]
		public TreePainter(Terrain terrain)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x91A10C", Offset = "0x91A10C", VA = "0x91A10C")]
		public void SpawnTrees(int xStart, int yStart, int detailIndex, int[,] data, int seed)
		{
		}
	}
}
namespace VEAGames.LAM.Constants
{
	[Token(Token = "0x20001CB")]
	public enum PatchType
	{
		[Token(Token = "0x4000C75")]
		DynamicPatch,
		[Token(Token = "0x4000C76")]
		GrassPatch,
		[Token(Token = "0x4000C77")]
		StaticPatch,
		[Token(Token = "0x4000C78")]
		All
	}
}
