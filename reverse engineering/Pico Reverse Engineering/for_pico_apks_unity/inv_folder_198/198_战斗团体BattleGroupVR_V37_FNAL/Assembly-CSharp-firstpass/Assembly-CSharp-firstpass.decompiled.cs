using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Crosstales.Common.Model.Enum;
using Crosstales.Common.Util;
using Crosstales.RTVoice.Model;
using Crosstales.RTVoice.Model.Enum;
using Crosstales.RTVoice.Provider;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AddComponentMenu("")]
public class ImageEffects
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xB5310C", Offset = "0xB5310C", VA = "0xB5310C")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB5337C", Offset = "0xB5337C", VA = "0xB5337C")]
	[Obsolete("Use Graphics.Blit(source,dest) instead")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB533E4", Offset = "0xB533E4", VA = "0xB533E4")]
	[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB53454", Offset = "0xB53454", VA = "0xB53454")]
	public ImageEffects()
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000003")]
	[AddComponentMenu("")]
	[RequireComponent(typeof(Camera))]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000001")]
		protected Material material
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xB534FC", Offset = "0xB534FC", VA = "0xB534FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xB5345C", Offset = "0xB5345C", VA = "0xB5345C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xB535B4", Offset = "0xB535B4", VA = "0xB535B4", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xB53640", Offset = "0xB53640", VA = "0xB53640")]
		public ImageEffectBase()
		{
		}
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
			[Token(Token = "0x4000012")]
			AnimationClips,
			[Token(Token = "0x4000013")]
			AnimationStates,
			[Token(Token = "0x4000014")]
			PlayableDirector,
			[Token(Token = "0x4000015")]
			Realtime
		}

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		public Animator animator;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		public PlayableDirector director;

		[Token(Token = "0x17000002")]
		public bool isBaking
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0xB53758", Offset = "0xB53758", VA = "0xB53758")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xB53760", Offset = "0xB53760", VA = "0xB53760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float bakingProgress
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xB5376C", Offset = "0xB5376C", VA = "0xB5376C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0xB53774", Offset = "0xB53774", VA = "0xB53774")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		protected float clipLength
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xB5377C", Offset = "0xB5377C", VA = "0xB5377C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xB53784", Offset = "0xB53784", VA = "0xB53784")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xB53648", Offset = "0xB53648", VA = "0xB53648")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xB5368C", Offset = "0xB5368C", VA = "0xB5368C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xB536D0", Offset = "0xB536D0", VA = "0xB536D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xB53714", Offset = "0xB53714", VA = "0xB53714")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000011")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000012")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000013")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000014")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000015")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xB5378C", Offset = "0xB5378C", VA = "0xB5378C")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xB53790", Offset = "0xB53790", VA = "0xB53790")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xB53794", Offset = "0xB53794", VA = "0xB53794")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xB53798", Offset = "0xB53798", VA = "0xB53798")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xB53890", Offset = "0xB53890", VA = "0xB53890")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xB53CAC", Offset = "0xB53CAC", VA = "0xB53CAC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xB53CB4", Offset = "0xB53CB4", VA = "0xB53CB4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB53EA0", Offset = "0xB53EA0", VA = "0xB53EA0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB54104", Offset = "0xB54104", VA = "0xB54104", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xB5441C", Offset = "0xB5441C", VA = "0xB5441C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xB53AA8", Offset = "0xB53AA8", VA = "0xB53AA8")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xB53B60", Offset = "0xB53B60", VA = "0xB53B60")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xB5467C", Offset = "0xB5467C", VA = "0xB5467C")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class TQ
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xB546D8", Offset = "0xB546D8", VA = "0xB546D8")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xB5473C", Offset = "0xB5473C", VA = "0xB5473C")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xB5498C", Offset = "0xB5498C", VA = "0xB5498C")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xB5496C", Offset = "0xB5496C", VA = "0xB5496C")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xB54FE4", Offset = "0xB54FE4", VA = "0xB54FE4")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0xB54FEC", Offset = "0xB54FEC", VA = "0xB54FEC")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xB55024", Offset = "0xB55024", VA = "0xB55024")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xB553E8", Offset = "0xB553E8", VA = "0xB553E8")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xB555C8", Offset = "0xB555C8", VA = "0xB555C8")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xB555CC", Offset = "0xB555CC", VA = "0xB555CC")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB55760", Offset = "0xB55760", VA = "0xB55760")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xB55A1C", Offset = "0xB55A1C", VA = "0xB55A1C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xB558D8", Offset = "0xB558D8", VA = "0xB558D8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xB55BA4", Offset = "0xB55BA4", VA = "0xB55BA4")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xB55DD8", Offset = "0xB55DD8", VA = "0xB55DD8")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xB55EC8", Offset = "0xB55EC8", VA = "0xB55EC8")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xB55FAC", Offset = "0xB55FAC", VA = "0xB55FAC")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xB55F30", Offset = "0xB55F30", VA = "0xB55F30")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xB56014", Offset = "0xB56014", VA = "0xB56014")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xB560BC", Offset = "0xB560BC", VA = "0xB560BC")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xB563A8", Offset = "0xB563A8", VA = "0xB563A8")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xB5640C", Offset = "0xB5640C", VA = "0xB5640C")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xB56EA0", Offset = "0xB56EA0", VA = "0xB56EA0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xB56F48", Offset = "0xB56F48", VA = "0xB56F48")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xB56E40", Offset = "0xB56E40", VA = "0xB56E40")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xB5703C", Offset = "0xB5703C", VA = "0xB5703C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB57078", Offset = "0xB57078", VA = "0xB57078")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BakerTransform
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xB53C18", Offset = "0xB53C18", VA = "0xB53C18")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB53E8C", Offset = "0xB53E8C", VA = "0xB53E8C")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB54168", Offset = "0xB54168", VA = "0xB54168")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB57080", Offset = "0xB57080", VA = "0xB57080")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB53D84", Offset = "0xB53D84", VA = "0xB53D84")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB57308", Offset = "0xB57308", VA = "0xB57308")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB54488", Offset = "0xB54488", VA = "0xB54488")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB53F0C", Offset = "0xB53F0C", VA = "0xB53F0C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xB57370", Offset = "0xB57370", VA = "0xB57370")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xB57828", Offset = "0xB57828", VA = "0xB57828", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xB57844", Offset = "0xB57844", VA = "0xB57844", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xB57920", Offset = "0xB57920", VA = "0xB57920", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xB579DC", Offset = "0xB579DC", VA = "0xB579DC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xB57B7C", Offset = "0xB57B7C", VA = "0xB57B7C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xB57E20", Offset = "0xB57E20", VA = "0xB57E20")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xB57EF8", Offset = "0xB57EF8", VA = "0xB57EF8")]
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
			[Token(Token = "0x4000078")]
			Update,
			[Token(Token = "0x4000079")]
			FixedUpdate,
			[Token(Token = "0x400007A")]
			LateUpdate,
			[Token(Token = "0x400007B")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000005")]
		public float x
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xB57F9C", Offset = "0xB57F9C", VA = "0xB57F9C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xB57FA4", Offset = "0xB57FA4", VA = "0xB57FA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float y
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0xB57FAC", Offset = "0xB57FAC", VA = "0xB57FAC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0xB57FB4", Offset = "0xB57FB4", VA = "0xB57FB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float distanceTarget
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0xB57FBC", Offset = "0xB57FBC", VA = "0xB57FBC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xB57FC4", Offset = "0xB57FC4", VA = "0xB57FC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		private float zoomAdd
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xB589D4", Offset = "0xB589D4", VA = "0xB589D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xB57FCC", Offset = "0xB57FCC", VA = "0xB57FCC")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xB58004", Offset = "0xB58004", VA = "0xB58004")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xB5800C", Offset = "0xB5800C", VA = "0xB5800C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xB58134", Offset = "0xB58134", VA = "0xB58134", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xB5817C", Offset = "0xB5817C", VA = "0xB5817C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xB581D4", Offset = "0xB581D4", VA = "0xB581D4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xB5822C", Offset = "0xB5822C", VA = "0xB5822C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xB58160", Offset = "0xB58160", VA = "0xB58160")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xB583B8", Offset = "0xB583B8", VA = "0xB583B8")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xB58998", Offset = "0xB58998", VA = "0xB58998")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xB58A40", Offset = "0xB58A40", VA = "0xB58A40")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xB58B00", Offset = "0xB58B00", VA = "0xB58B00")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xB58B2C", Offset = "0xB58B2C", VA = "0xB58B2C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xB58D50", Offset = "0xB58D50", VA = "0xB58D50")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB58D8C", Offset = "0xB58D8C", VA = "0xB58D8C")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public enum Axis
	{
		[Token(Token = "0x4000082")]
		X,
		[Token(Token = "0x4000083")]
		Y,
		[Token(Token = "0x4000084")]
		Z
	}
	[Token(Token = "0x2000012")]
	public class AxisTools
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0xB58DA8", Offset = "0xB58DA8", VA = "0xB58DA8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB58E88", Offset = "0xB58E88", VA = "0xB58E88")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xB58EC0", Offset = "0xB58EC0", VA = "0xB58EC0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xB59008", Offset = "0xB59008", VA = "0xB59008")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xB58FBC", Offset = "0xB58FBC", VA = "0xB58FBC")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xB59104", Offset = "0xB59104", VA = "0xB59104")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xB59148", Offset = "0xB59148", VA = "0xB59148")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xB595D4", Offset = "0xB595D4", VA = "0xB595D4")]
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
			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000071")]
			[Address(RVA = "0xB598D0", Offset = "0xB598D0", VA = "0xB598D0")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xB5961C", Offset = "0xB5961C", VA = "0xB5961C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xB59944", Offset = "0xB59944", VA = "0xB59944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xB595DC", Offset = "0xB595DC", VA = "0xB595DC")]
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
			[Token(Token = "0x400009F")]
			Unassigned,
			[Token(Token = "0x40000A0")]
			Spine,
			[Token(Token = "0x40000A1")]
			Head,
			[Token(Token = "0x40000A2")]
			Arm,
			[Token(Token = "0x40000A3")]
			Leg,
			[Token(Token = "0x40000A4")]
			Tail,
			[Token(Token = "0x40000A5")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000017")]
		public enum BoneSide
		{
			[Token(Token = "0x40000A7")]
			Center,
			[Token(Token = "0x40000A8")]
			Left,
			[Token(Token = "0x40000A9")]
			Right
		}

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xB59BF8", Offset = "0xB59BF8", VA = "0xB59BF8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xB59EBC", Offset = "0xB59EBC", VA = "0xB59EBC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xB5A0F0", Offset = "0xB5A0F0", VA = "0xB5A0F0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xB5A164", Offset = "0xB5A164", VA = "0xB5A164")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xB5A1F8", Offset = "0xB5A1F8", VA = "0xB5A1F8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xB59DA4", Offset = "0xB59DA4", VA = "0xB59DA4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xB5A068", Offset = "0xB5A068", VA = "0xB5A068")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xB5A930", Offset = "0xB5A930", VA = "0xB5A930")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xB5A788", Offset = "0xB5A788", VA = "0xB5A788")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB5A85C", Offset = "0xB5A85C", VA = "0xB5A85C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xB5A3E0", Offset = "0xB5A3E0", VA = "0xB5A3E0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB5A47C", Offset = "0xB5A47C", VA = "0xB5A47C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB5A518", Offset = "0xB5A518", VA = "0xB5A518")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB5A5B4", Offset = "0xB5A5B4", VA = "0xB5A5B4")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB5A650", Offset = "0xB5A650", VA = "0xB5A650")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB5A6EC", Offset = "0xB5A6EC", VA = "0xB5A6EC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB5AB18", Offset = "0xB5AB18", VA = "0xB5AB18")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB5A30C", Offset = "0xB5A30C", VA = "0xB5A30C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB5AA94", Offset = "0xB5AA94", VA = "0xB5AA94")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB5AB78", Offset = "0xB5AB78", VA = "0xB5AB78")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB5AC38", Offset = "0xB5AC38", VA = "0xB5AC38")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB5AA20", Offset = "0xB5AA20", VA = "0xB5AA20")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB5A9B0", Offset = "0xB5A9B0", VA = "0xB5A9B0")]
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
			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000D")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0xB6054C", Offset = "0xB6054C", VA = "0xB6054C")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xB60538", Offset = "0xB60538", VA = "0xB60538")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000B")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xB5CC30", Offset = "0xB5CC30", VA = "0xB5CC30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public bool isEmpty
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xB5CF8C", Offset = "0xB5CF8C", VA = "0xB5CF8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB5CF9C", Offset = "0xB5CF9C", VA = "0xB5CF9C", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB5D328", Offset = "0xB5D328", VA = "0xB5D328", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB5D6B8", Offset = "0xB5D6B8", VA = "0xB5D6B8")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB5DCDC", Offset = "0xB5DCDC", VA = "0xB5DCDC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB5D918", Offset = "0xB5D918", VA = "0xB5D918")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xB5E4D8", Offset = "0xB5E4D8", VA = "0xB5E4D8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xB5E5B8", Offset = "0xB5E5B8", VA = "0xB5E5B8")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB5F030", Offset = "0xB5F030", VA = "0xB5F030")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB5EE50", Offset = "0xB5EE50", VA = "0xB5EE50")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB5EBF0", Offset = "0xB5EBF0", VA = "0xB5EBF0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xB5E654", Offset = "0xB5E654", VA = "0xB5E654")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB5EF44", Offset = "0xB5EF44", VA = "0xB5EF44")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB5F110", Offset = "0xB5F110", VA = "0xB5F110")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xB5FBD0", Offset = "0xB5FBD0", VA = "0xB5FBD0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xB5F690", Offset = "0xB5F690", VA = "0xB5F690")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xB5FEA4", Offset = "0xB5FEA4", VA = "0xB5FEA4")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xB5F9E4", Offset = "0xB5F9E4", VA = "0xB5F9E4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xB5FEAC", Offset = "0xB5FEAC", VA = "0xB5FEAC")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xB5FEB4", Offset = "0xB5FEB4", VA = "0xB5FEB4")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xB60068", Offset = "0xB60068", VA = "0xB60068")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xB604D0", Offset = "0xB604D0", VA = "0xB604D0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xB5D8B0", Offset = "0xB5D8B0", VA = "0xB5D8B0")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xB60554", Offset = "0xB60554", VA = "0xB60554")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xB6055C", Offset = "0xB6055C", VA = "0xB6055C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xB60654", Offset = "0xB60654", VA = "0xB60654")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Hierarchy
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xB6044C", Offset = "0xB6044C", VA = "0xB6044C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xB60340", Offset = "0xB60340", VA = "0xB60340")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xB5E730", Offset = "0xB5E730", VA = "0xB5E730")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xB5ED40", Offset = "0xB5ED40", VA = "0xB5ED40")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xB5E9B0", Offset = "0xB5E9B0", VA = "0xB5E9B0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xB60664", Offset = "0xB60664", VA = "0xB60664")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xB5E860", Offset = "0xB5E860", VA = "0xB5E860")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xB60758", Offset = "0xB60758", VA = "0xB60758")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xB60AC4", Offset = "0xB60AC4", VA = "0xB60AC4")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xB608BC", Offset = "0xB608BC", VA = "0xB608BC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xB60C4C", Offset = "0xB60C4C", VA = "0xB60C4C")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xB60C54", Offset = "0xB60C54", VA = "0xB60C54")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB60CBC", Offset = "0xB60CBC", VA = "0xB60CBC")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000C3")]
		None,
		[Token(Token = "0x40000C4")]
		InOutCubic,
		[Token(Token = "0x40000C5")]
		InOutQuintic,
		[Token(Token = "0x40000C6")]
		InOutSine,
		[Token(Token = "0x40000C7")]
		InQuintic,
		[Token(Token = "0x40000C8")]
		InQuartic,
		[Token(Token = "0x40000C9")]
		InCubic,
		[Token(Token = "0x40000CA")]
		InQuadratic,
		[Token(Token = "0x40000CB")]
		InElastic,
		[Token(Token = "0x40000CC")]
		InElasticSmall,
		[Token(Token = "0x40000CD")]
		InElasticBig,
		[Token(Token = "0x40000CE")]
		InSine,
		[Token(Token = "0x40000CF")]
		InBack,
		[Token(Token = "0x40000D0")]
		OutQuintic,
		[Token(Token = "0x40000D1")]
		OutQuartic,
		[Token(Token = "0x40000D2")]
		OutCubic,
		[Token(Token = "0x40000D3")]
		OutInCubic,
		[Token(Token = "0x40000D4")]
		OutInQuartic,
		[Token(Token = "0x40000D5")]
		OutElastic,
		[Token(Token = "0x40000D6")]
		OutElasticSmall,
		[Token(Token = "0x40000D7")]
		OutElasticBig,
		[Token(Token = "0x40000D8")]
		OutSine,
		[Token(Token = "0x40000D9")]
		OutBack,
		[Token(Token = "0x40000DA")]
		OutBackCubic,
		[Token(Token = "0x40000DB")]
		OutBackQuartic,
		[Token(Token = "0x40000DC")]
		BackInCubic,
		[Token(Token = "0x40000DD")]
		BackInQuartic
	}
	[Token(Token = "0x200001F")]
	public class Interp
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xB60D24", Offset = "0xB60D24", VA = "0xB60D24")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xB616AC", Offset = "0xB616AC", VA = "0xB616AC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xB6171C", Offset = "0xB6171C", VA = "0xB6171C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xB61124", Offset = "0xB61124", VA = "0xB61124")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xB61130", Offset = "0xB61130", VA = "0xB61130")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xB61154", Offset = "0xB61154", VA = "0xB61154")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB61190", Offset = "0xB61190", VA = "0xB61190")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xB611A8", Offset = "0xB611A8", VA = "0xB611A8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xB611BC", Offset = "0xB611BC", VA = "0xB611BC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xB611D0", Offset = "0xB611D0", VA = "0xB611D0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xB611E0", Offset = "0xB611E0", VA = "0xB611E0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xB61228", Offset = "0xB61228", VA = "0xB61228")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xB61260", Offset = "0xB61260", VA = "0xB61260")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xB61288", Offset = "0xB61288", VA = "0xB61288")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xB6178C", Offset = "0xB6178C", VA = "0xB6178C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xB612BC", Offset = "0xB612BC", VA = "0xB612BC")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xB612E4", Offset = "0xB612E4", VA = "0xB612E4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xB61314", Offset = "0xB61314", VA = "0xB61314")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xB61348", Offset = "0xB61348", VA = "0xB61348")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xB6138C", Offset = "0xB6138C", VA = "0xB6138C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xB613F0", Offset = "0xB613F0", VA = "0xB613F0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xB61454", Offset = "0xB61454", VA = "0xB61454")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB614A8", Offset = "0xB614A8", VA = "0xB614A8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xB614FC", Offset = "0xB614FC", VA = "0xB614FC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xB61534", Offset = "0xB61534", VA = "0xB61534")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xB61568", Offset = "0xB61568", VA = "0xB61568")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xB617C0", Offset = "0xB617C0", VA = "0xB617C0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xB615AC", Offset = "0xB615AC", VA = "0xB615AC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xB6163C", Offset = "0xB6163C", VA = "0xB6163C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xB6166C", Offset = "0xB6166C", VA = "0xB6166C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xB61850", Offset = "0xB61850", VA = "0xB61850")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xB61858", Offset = "0xB61858", VA = "0xB61858")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xB618C0", Offset = "0xB618C0", VA = "0xB618C0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xB61928", Offset = "0xB61928", VA = "0xB61928")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xB61974", Offset = "0xB61974", VA = "0xB61974")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xB61A30", Offset = "0xB61A30", VA = "0xB61A30")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xB61988", Offset = "0xB61988", VA = "0xB61988")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xB61A44", Offset = "0xB61A44", VA = "0xB61A44")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xB61AD4", Offset = "0xB61AD4", VA = "0xB61AD4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xB61AFC", Offset = "0xB61AFC", VA = "0xB61AFC")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xB61B48", Offset = "0xB61B48", VA = "0xB61B48")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xB61BB0", Offset = "0xB61BB0", VA = "0xB61BB0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xB61D04", Offset = "0xB61D04", VA = "0xB61D04")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xB61E3C", Offset = "0xB61E3C", VA = "0xB61E3C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xB61E94", Offset = "0xB61E94", VA = "0xB61E94")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000022")]
	public static class QuaTools
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xB61EB8", Offset = "0xB61EB8", VA = "0xB61EB8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xB61F04", Offset = "0xB61F04", VA = "0xB61F04")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xB61F50", Offset = "0xB61F50", VA = "0xB61F50")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xB62054", Offset = "0xB62054", VA = "0xB62054")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xB62158", Offset = "0xB62158", VA = "0xB62158")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xB6226C", Offset = "0xB6226C", VA = "0xB6226C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xB62314", Offset = "0xB62314", VA = "0xB62314")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xB62420", Offset = "0xB62420", VA = "0xB62420")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xB62588", Offset = "0xB62588", VA = "0xB62588")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xB6276C", Offset = "0xB6276C", VA = "0xB6276C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xB6283C", Offset = "0xB6283C", VA = "0xB6283C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xB629C0", Offset = "0xB629C0", VA = "0xB629C0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xB62ACC", Offset = "0xB62ACC", VA = "0xB62ACC")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000023")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

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
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000F")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0xB62C40", Offset = "0xB62C40", VA = "0xB62C40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xB62F00", Offset = "0xB62F00", VA = "0xB62F00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xB62B24", Offset = "0xB62B24", VA = "0xB62B24")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xB62BB8", Offset = "0xB62BB8", VA = "0xB62BB8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xB62BBC", Offset = "0xB62BBC", VA = "0xB62BBC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xB62BC0", Offset = "0xB62BC0", VA = "0xB62BC0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xB62BC4", Offset = "0xB62BC4", VA = "0xB62BC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xB62C3C", Offset = "0xB62C3C", VA = "0xB62C3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xB62BEC", Offset = "0xB62BEC", VA = "0xB62BEC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xB62EC4", Offset = "0xB62EC4", VA = "0xB62EC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xB62D0C", Offset = "0xB62D0C", VA = "0xB62D0C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xB62F98", Offset = "0xB62F98", VA = "0xB62F98")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xB62FE4", Offset = "0xB62FE4", VA = "0xB62FE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xB63030", Offset = "0xB63030", VA = "0xB63030")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xB63068", Offset = "0xB63068", VA = "0xB63068")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xB63078", Offset = "0xB63078", VA = "0xB63078")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xB6312C", Offset = "0xB6312C", VA = "0xB6312C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xB631E0", Offset = "0xB631E0", VA = "0xB631E0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xB63294", Offset = "0xB63294", VA = "0xB63294")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class V3Tools
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xB6329C", Offset = "0xB6329C", VA = "0xB6329C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xB632F8", Offset = "0xB632F8", VA = "0xB632F8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xB63330", Offset = "0xB63330", VA = "0xB63330")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xB63480", Offset = "0xB63480", VA = "0xB63480")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xB635FC", Offset = "0xB635FC", VA = "0xB635FC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xB6382C", Offset = "0xB6382C", VA = "0xB6382C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xB63A7C", Offset = "0xB63A7C", VA = "0xB63A7C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xB63CD4", Offset = "0xB63CD4", VA = "0xB63CD4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xB63E80", Offset = "0xB63E80", VA = "0xB63E80")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xB64078", Offset = "0xB64078", VA = "0xB64078")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xB640F4", Offset = "0xB640F4", VA = "0xB640F4")]
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

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xB64184", Offset = "0xB64184", VA = "0xB64184")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xB5E424", Offset = "0xB5E424", VA = "0xB5E424")]
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
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xB64330", Offset = "0xB64330", VA = "0xB64330")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xB64374", Offset = "0xB64374", VA = "0xB64374")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xB643B8", Offset = "0xB643B8", VA = "0xB643B8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xB643FC", Offset = "0xB643FC", VA = "0xB643FC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xB64440", Offset = "0xB64440", VA = "0xB64440")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xB644D8", Offset = "0xB644D8", VA = "0xB644D8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xB644F4", Offset = "0xB644F4", VA = "0xB644F4")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xB64520", Offset = "0xB64520", VA = "0xB64520")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xB6454C", Offset = "0xB6454C", VA = "0xB6454C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xB64588", Offset = "0xB64588", VA = "0xB64588")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xB645C8", Offset = "0xB645C8", VA = "0xB645C8")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xB645E8", Offset = "0xB645E8", VA = "0xB645E8")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xB64608", Offset = "0xB64608", VA = "0xB64608")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xB6462C", Offset = "0xB6462C", VA = "0xB6462C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xB64654", Offset = "0xB64654", VA = "0xB64654")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xB6467C", Offset = "0xB6467C", VA = "0xB6467C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xB6445C", Offset = "0xB6445C", VA = "0xB6445C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xB646A0", Offset = "0xB646A0", VA = "0xB646A0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xB646AC", Offset = "0xB646AC", VA = "0xB646AC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xB646B8", Offset = "0xB646B8", VA = "0xB646B8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xB64924", Offset = "0xB64924", VA = "0xB64924", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xB649C0", Offset = "0xB649C0", VA = "0xB649C0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xB64CE0", Offset = "0xB64CE0", VA = "0xB64CE0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xB6514C", Offset = "0xB6514C", VA = "0xB6514C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xB65170", Offset = "0xB65170", VA = "0xB65170")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000011")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xB647F4", Offset = "0xB647F4", VA = "0xB647F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xB65394", Offset = "0xB65394", VA = "0xB65394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xB64B70", Offset = "0xB64B70", VA = "0xB64B70")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xB65208", Offset = "0xB65208", VA = "0xB65208")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000013")]
		public bool isValid
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0xB65550", Offset = "0xB65550", VA = "0xB65550")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000133")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xB655B0", Offset = "0xB655B0", VA = "0xB655B0")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xB655B8", Offset = "0xB655B8", VA = "0xB655B8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xB65650", Offset = "0xB65650", VA = "0xB65650")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xB65658", Offset = "0xB65658", VA = "0xB65658")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		private bool positionChanged
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xB65784", Offset = "0xB65784", VA = "0xB65784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xB65680", Offset = "0xB65680", VA = "0xB65680", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xB657E0", Offset = "0xB657E0", VA = "0xB657E0")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xB657E8", Offset = "0xB657E8", VA = "0xB657E8")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xB65810", Offset = "0xB65810", VA = "0xB65810", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xB6588C", Offset = "0xB6588C", VA = "0xB6588C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xB65894", Offset = "0xB65894", VA = "0xB65894")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000015")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xB659C0", Offset = "0xB659C0", VA = "0xB659C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xB658BC", Offset = "0xB658BC", VA = "0xB658BC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xB65A18", Offset = "0xB65A18", VA = "0xB65A18")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xB65A20", Offset = "0xB65A20", VA = "0xB65A20")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class Constraints
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xB65A48", Offset = "0xB65A48", VA = "0xB65A48")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xB64C90", Offset = "0xB64C90", VA = "0xB64C90")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xB64E54", Offset = "0xB64E54", VA = "0xB64E54")]
		public void Update()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xB65548", Offset = "0xB65548", VA = "0xB65548")]
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
			[Token(Token = "0x400011D")]
			One,
			[Token(Token = "0x400011E")]
			Three
		}

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x17000016")]
		public bool initiated
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xB65AA8", Offset = "0xB65AA8", VA = "0xB65AA8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xB65AB0", Offset = "0xB65AB0", VA = "0xB65AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xB65ABC", Offset = "0xB65ABC", VA = "0xB65ABC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xB65ADC", Offset = "0xB65ADC", VA = "0xB65ADC")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xB65AFC", Offset = "0xB65AFC", VA = "0xB65AFC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xB65B1C", Offset = "0xB65B1C", VA = "0xB65B1C")]
			set
			{
			}
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xB65B3C", Offset = "0xB65B3C", VA = "0xB65B3C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xB65C28", Offset = "0xB65C28", VA = "0xB65C28")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xB66108", Offset = "0xB66108", VA = "0xB66108")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xB661D4", Offset = "0xB661D4", VA = "0xB661D4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xB6628C", Offset = "0xB6628C", VA = "0xB6628C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xB668EC", Offset = "0xB668EC", VA = "0xB668EC")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000033")]
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

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xB668FC", Offset = "0xB668FC", VA = "0xB668FC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xB66904", Offset = "0xB66904", VA = "0xB66904")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xB66910", Offset = "0xB66910", VA = "0xB66910")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xB66984", Offset = "0xB66984", VA = "0xB66984")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xB66C90", Offset = "0xB66C90", VA = "0xB66C90")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xB66DFC", Offset = "0xB66DFC", VA = "0xB66DFC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xB66BA8", Offset = "0xB66BA8", VA = "0xB66BA8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xB66F5C", Offset = "0xB66F5C", VA = "0xB66F5C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xB67004", Offset = "0xB67004", VA = "0xB67004")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xB67068", Offset = "0xB67068", VA = "0xB67068")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xB670D0", Offset = "0xB670D0", VA = "0xB670D0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xB6712C", Offset = "0xB6712C", VA = "0xB6712C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xB67130", Offset = "0xB67130", VA = "0xB67130", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xB67144", Offset = "0xB67144", VA = "0xB67144")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000035")]
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

		[Token(Token = "0x1700001A")]
		public bool initiated
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xB671AC", Offset = "0xB671AC", VA = "0xB671AC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xB671B4", Offset = "0xB671B4", VA = "0xB671B4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000161")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xB671C0", Offset = "0xB671C0", VA = "0xB671C0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xB67470", Offset = "0xB67470", VA = "0xB67470")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xB67284", Offset = "0xB67284", VA = "0xB67284")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xB67494", Offset = "0xB67494", VA = "0xB67494")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000168")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000169")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xB67608", Offset = "0xB67608", VA = "0xB67608")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
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

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xB67774", Offset = "0xB67774", VA = "0xB67774", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xB677B8", Offset = "0xB677B8", VA = "0xB677B8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xB677FC", Offset = "0xB677FC", VA = "0xB677FC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xB678DC", Offset = "0xB678DC", VA = "0xB678DC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xB6797C", Offset = "0xB6797C", VA = "0xB6797C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xB679D0", Offset = "0xB679D0", VA = "0xB679D0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xB67F44", Offset = "0xB67F44", VA = "0xB67F44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xB67F84", Offset = "0xB67F84", VA = "0xB67F84")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xB685D4", Offset = "0xB685D4", VA = "0xB685D4")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xB686FC", Offset = "0xB686FC", VA = "0xB686FC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xB688CC", Offset = "0xB688CC", VA = "0xB688CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xB68A74", Offset = "0xB68A74", VA = "0xB68A74")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000038")]
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

			[Token(Token = "0x6000189")]
			[Address(RVA = "0xB69718", Offset = "0xB69718", VA = "0xB69718")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0xB69728", Offset = "0xB69728", VA = "0xB69728")]
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

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xB68B04", Offset = "0xB68B04", VA = "0xB68B04")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xB68B48", Offset = "0xB68B48", VA = "0xB68B48", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xB68B8C", Offset = "0xB68B8C", VA = "0xB68B8C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xB68BD0", Offset = "0xB68BD0", VA = "0xB68BD0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xB68C38", Offset = "0xB68C38", VA = "0xB68C38")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xB68CC0", Offset = "0xB68CC0", VA = "0xB68CC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xB68F30", Offset = "0xB68F30", VA = "0xB68F30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xB68F3C", Offset = "0xB68F3C", VA = "0xB68F3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xB68D1C", Offset = "0xB68D1C", VA = "0xB68D1C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xB68F48", Offset = "0xB68F48", VA = "0xB68F48")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xB692BC", Offset = "0xB692BC", VA = "0xB692BC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xB69440", Offset = "0xB69440", VA = "0xB69440")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xB69574", Offset = "0xB69574", VA = "0xB69574")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xB69688", Offset = "0xB69688", VA = "0xB69688")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
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
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
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

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xB6976C", Offset = "0xB6976C", VA = "0xB6976C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xB697B0", Offset = "0xB697B0", VA = "0xB697B0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xB697F4", Offset = "0xB697F4", VA = "0xB697F4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xB6980C", Offset = "0xB6980C", VA = "0xB6980C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xB69A18", Offset = "0xB69A18", VA = "0xB69A18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xB69AF8", Offset = "0xB69AF8", VA = "0xB69AF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xB6A1DC", Offset = "0xB6A1DC", VA = "0xB6A1DC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xB6A63C", Offset = "0xB6A63C", VA = "0xB6A63C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xB6A7E8", Offset = "0xB6A7E8", VA = "0xB6A7E8")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xB6AB70", Offset = "0xB6AB70", VA = "0xB6AB70")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xB6AD48", Offset = "0xB6AD48", VA = "0xB6AD48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xB6AF4C", Offset = "0xB6AF4C", VA = "0xB6AF4C")]
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

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xB6BA98", Offset = "0xB6BA98", VA = "0xB6BA98")]
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
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
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

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xB6AFDC", Offset = "0xB6AFDC", VA = "0xB6AFDC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xB6B020", Offset = "0xB6B020", VA = "0xB6B020", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xB6B064", Offset = "0xB6B064", VA = "0xB6B064", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xB6B08C", Offset = "0xB6B08C", VA = "0xB6B08C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xB6B190", Offset = "0xB6B190", VA = "0xB6B190")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xB6B374", Offset = "0xB6B374", VA = "0xB6B374")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xB6B3D8", Offset = "0xB6B3D8", VA = "0xB6B3D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xB6B430", Offset = "0xB6B430", VA = "0xB6B430")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xB6B744", Offset = "0xB6B744", VA = "0xB6B744")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xB6BACC", Offset = "0xB6BACC", VA = "0xB6BACC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB6BB5C", Offset = "0xB6BB5C", VA = "0xB6BB5C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xB6BFAC", Offset = "0xB6BFAC", VA = "0xB6BFAC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xB6C66C", Offset = "0xB6C66C", VA = "0xB6C66C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xB6C924", Offset = "0xB6C924", VA = "0xB6C924")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xB6CA58", Offset = "0xB6CA58", VA = "0xB6CA58")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xB6CD20", Offset = "0xB6CD20", VA = "0xB6CD20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xB6CD50", Offset = "0xB6CD50", VA = "0xB6CD50")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xB6CF4C", Offset = "0xB6CF4C", VA = "0xB6CF4C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003C")]
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

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xB6D0D4", Offset = "0xB6D0D4", VA = "0xB6D0D4")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xB6D118", Offset = "0xB6D118", VA = "0xB6D118", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xB6D15C", Offset = "0xB6D15C", VA = "0xB6D15C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xB6D1A0", Offset = "0xB6D1A0", VA = "0xB6D1A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xB6D1B8", Offset = "0xB6D1B8", VA = "0xB6D1B8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xB6D240", Offset = "0xB6D240", VA = "0xB6D240")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xB6D294", Offset = "0xB6D294", VA = "0xB6D294")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xB6D4CC", Offset = "0xB6D4CC", VA = "0xB6D4CC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xB6D6C0", Offset = "0xB6D6C0", VA = "0xB6D6C0")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xB6D744", Offset = "0xB6D744", VA = "0xB6D744")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xB6D9E0", Offset = "0xB6D9E0", VA = "0xB6D9E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xB6DB14", Offset = "0xB6DB14", VA = "0xB6DB14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xB6DCAC", Offset = "0xB6DCAC", VA = "0xB6DCAC")]
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
			[Token(Token = "0x4000184")]
			Fastest,
			[Token(Token = "0x4000185")]
			Simple,
			[Token(Token = "0x4000186")]
			Best
		}

		[Token(Token = "0x200003F")]
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

			[Token(Token = "0x17000023")]
			public bool isGrounded
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0xB6F05C", Offset = "0xB6F05C", VA = "0xB6F05C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0xB6F064", Offset = "0xB6F064", VA = "0xB6F064")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0xB6F070", Offset = "0xB6F070", VA = "0xB6F070")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0xB6F07C", Offset = "0xB6F07C", VA = "0xB6F07C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public bool initiated
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0xB6F088", Offset = "0xB6F088", VA = "0xB6F088")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0xB6F090", Offset = "0xB6F090", VA = "0xB6F090")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public float heightFromGround
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0xB6F09C", Offset = "0xB6F09C", VA = "0xB6F09C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0xB6F0A4", Offset = "0xB6F0A4", VA = "0xB6F0A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0xB6F0AC", Offset = "0xB6F0AC", VA = "0xB6F0AC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0xB6F0B8", Offset = "0xB6F0B8", VA = "0xB6F0B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public Transform transform
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0xB6F0C4", Offset = "0xB6F0C4", VA = "0xB6F0C4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0xB6F0CC", Offset = "0xB6F0CC", VA = "0xB6F0CC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public float IKOffset
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0xB6F0D4", Offset = "0xB6F0D4", VA = "0xB6F0D4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0xB6F0DC", Offset = "0xB6F0DC", VA = "0xB6F0DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0xB6F0E4", Offset = "0xB6F0E4", VA = "0xB6F0E4")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0xB6F0FC", Offset = "0xB6F0FC", VA = "0xB6F0FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0xB6F11C", Offset = "0xB6F11C", VA = "0xB6F11C")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0xB6F134", Offset = "0xB6F134", VA = "0xB6F134")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0xB6F154", Offset = "0xB6F154", VA = "0xB6F154")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002D")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0xB6FA3C", Offset = "0xB6FA3C", VA = "0xB6FA3C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002E")]
			private float rootYOffset
			{
				[Token(Token = "0x60001F0")]
				[Address(RVA = "0xB6FB8C", Offset = "0xB6FB8C", VA = "0xB6FB8C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xB6F19C", Offset = "0xB6F19C", VA = "0xB6F19C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xB6E1C4", Offset = "0xB6E1C4", VA = "0xB6E1C4")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xB6F1B0", Offset = "0xB6F1B0", VA = "0xB6F1B0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xB6ECCC", Offset = "0xB6ECCC", VA = "0xB6ECCC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xB6E2B4", Offset = "0xB6E2B4", VA = "0xB6E2B4")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xB6F650", Offset = "0xB6F650", VA = "0xB6F650")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xB6F1F0", Offset = "0xB6F1F0", VA = "0xB6F1F0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xB6FAD0", Offset = "0xB6FAD0", VA = "0xB6FAD0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xB6F4B8", Offset = "0xB6F4B8", VA = "0xB6F4B8")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xB6F538", Offset = "0xB6F538", VA = "0xB6F538")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xB6FB3C", Offset = "0xB6FB3C", VA = "0xB6FB3C")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xB6FA70", Offset = "0xB6FA70", VA = "0xB6FA70")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xB6FC18", Offset = "0xB6FC18", VA = "0xB6FC18")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xB6E124", Offset = "0xB6E124", VA = "0xB6E124")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000040")]
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

			[Token(Token = "0x1700002F")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001F2")]
				[Address(RVA = "0xB6FDC8", Offset = "0xB6FDC8", VA = "0xB6FDC8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0xB6FDD4", Offset = "0xB6FDD4", VA = "0xB6FDD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public float heightOffset
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0xB6FDE0", Offset = "0xB6FDE0", VA = "0xB6FDE0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001F5")]
				[Address(RVA = "0xB6FDE8", Offset = "0xB6FDE8", VA = "0xB6FDE8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xB6E28C", Offset = "0xB6E28C", VA = "0xB6E28C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xB6EC38", Offset = "0xB6EC38", VA = "0xB6EC38")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xB6FDF0", Offset = "0xB6FDF0", VA = "0xB6FDF0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xB6EA4C", Offset = "0xB6EA4C", VA = "0xB6EA4C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xB6E1BC", Offset = "0xB6E1BC", VA = "0xB6E1BC")]
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

		[Token(Token = "0x1700001B")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xB6DD04", Offset = "0xB6DD04", VA = "0xB6DD04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xB6DD0C", Offset = "0xB6DD0C", VA = "0xB6DD0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xB6DD14", Offset = "0xB6DD14", VA = "0xB6DD14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xB6DD1C", Offset = "0xB6DD1C", VA = "0xB6DD1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool isGrounded
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xB6DD24", Offset = "0xB6DD24", VA = "0xB6DD24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xB6DD2C", Offset = "0xB6DD2C", VA = "0xB6DD2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Transform root
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xB6DD38", Offset = "0xB6DD38", VA = "0xB6DD38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xB6DD40", Offset = "0xB6DD40", VA = "0xB6DD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xB6DD48", Offset = "0xB6DD48", VA = "0xB6DD48")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xB6DD60", Offset = "0xB6DD60", VA = "0xB6DD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xB6DD80", Offset = "0xB6DD80", VA = "0xB6DD80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public Vector3 up
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xB68694", Offset = "0xB68694", VA = "0xB68694")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000022")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xB6ED60", Offset = "0xB6ED60", VA = "0xB6ED60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xB6DDC8", Offset = "0xB6DDC8", VA = "0xB6DDC8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xB6E028", Offset = "0xB6E028", VA = "0xB6E028")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xB67CD0", Offset = "0xB67CD0", VA = "0xB67CD0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xB683E0", Offset = "0xB683E0", VA = "0xB683E0")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xB6A064", Offset = "0xB6A064", VA = "0xB6A064")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xB67864", Offset = "0xB67864", VA = "0xB67864")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xB6E29C", Offset = "0xB6E29C", VA = "0xB6E29C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xB6EE14", Offset = "0xB6EE14", VA = "0xB6EE14")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xB6EE98", Offset = "0xB6EE98", VA = "0xB6EE98")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xB6EFEC", Offset = "0xB6EFEC", VA = "0xB6EFEC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xB6D080", Offset = "0xB6D080", VA = "0xB6D080")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xB6FE44", Offset = "0xB6FE44", VA = "0xB6FE44", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xB6FE88", Offset = "0xB6FE88", VA = "0xB6FE88", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xB6FECC", Offset = "0xB6FECC", VA = "0xB6FECC")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xB6FF10", Offset = "0xB6FF10", VA = "0xB6FF10")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xB6FF54", Offset = "0xB6FF54", VA = "0xB6FF54")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xB6FF98", Offset = "0xB6FF98", VA = "0xB6FF98", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xB6FFA0", Offset = "0xB6FFA0", VA = "0xB6FFA0")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xB70010", Offset = "0xB70010", VA = "0xB70010", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xB70054", Offset = "0xB70054", VA = "0xB70054", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xB70098", Offset = "0xB70098", VA = "0xB70098")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xB700DC", Offset = "0xB700DC", VA = "0xB700DC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xB70120", Offset = "0xB70120", VA = "0xB70120", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xB70128", Offset = "0xB70128", VA = "0xB70128")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xB70190", Offset = "0xB70190", VA = "0xB70190", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xB701D4", Offset = "0xB701D4", VA = "0xB701D4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xB70218", Offset = "0xB70218", VA = "0xB70218")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xB7025C", Offset = "0xB7025C", VA = "0xB7025C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xB702A0", Offset = "0xB702A0", VA = "0xB702A0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xB702A8", Offset = "0xB702A8", VA = "0xB702A8")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xB70310", Offset = "0xB70310", VA = "0xB70310", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xB70354", Offset = "0xB70354", VA = "0xB70354", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xB70398", Offset = "0xB70398", VA = "0xB70398")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xB703DC", Offset = "0xB703DC", VA = "0xB703DC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xB70420", Offset = "0xB70420", VA = "0xB70420", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xB70428", Offset = "0xB70428", VA = "0xB70428")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xB70490", Offset = "0xB70490", VA = "0xB70490", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xB704D4", Offset = "0xB704D4", VA = "0xB704D4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xB70518", Offset = "0xB70518", VA = "0xB70518")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xB7055C", Offset = "0xB7055C", VA = "0xB7055C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xB705A0", Offset = "0xB705A0", VA = "0xB705A0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xB705A8", Offset = "0xB705A8", VA = "0xB705A8")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xB70610", Offset = "0xB70610", VA = "0xB70610", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xB70654", Offset = "0xB70654", VA = "0xB70654", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xB70698", Offset = "0xB70698", VA = "0xB70698")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xB706DC", Offset = "0xB706DC", VA = "0xB706DC")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xB70720", Offset = "0xB70720", VA = "0xB70720")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xB70764", Offset = "0xB70764", VA = "0xB70764")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xB707A8", Offset = "0xB707A8", VA = "0xB707A8")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xB707CC", Offset = "0xB707CC", VA = "0xB707CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xB707D4", Offset = "0xB707D4", VA = "0xB707D4")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xB70990", Offset = "0xB70990", VA = "0xB70990")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xB70E40", Offset = "0xB70E40", VA = "0xB70E40")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xB70E60", Offset = "0xB70E60", VA = "0xB70E60")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xB70F38", Offset = "0xB70F38", VA = "0xB70F38")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000227")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xB70FD0", Offset = "0xB70FD0", VA = "0xB70FD0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xB71048", Offset = "0xB71048", VA = "0xB71048", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xB710B8", Offset = "0xB710B8", VA = "0xB710B8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600022B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600022C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xB70008", Offset = "0xB70008", VA = "0xB70008")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000048")]
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

		[Token(Token = "0x17000031")]
		private bool animatePhysics
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xB71108", Offset = "0xB71108", VA = "0xB71108")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xB71194", Offset = "0xB71194", VA = "0xB71194")]
		private void Start()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xB711F8", Offset = "0xB711F8", VA = "0xB711F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xB71298", Offset = "0xB71298", VA = "0xB71298")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xB712C4", Offset = "0xB712C4", VA = "0xB712C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xB7121C", Offset = "0xB7121C", VA = "0xB7121C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xB71348", Offset = "0xB71348", VA = "0xB71348")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xB71350", Offset = "0xB71350", VA = "0xB71350", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xB71394", Offset = "0xB71394", VA = "0xB71394", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xB713D8", Offset = "0xB713D8", VA = "0xB713D8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xB7141C", Offset = "0xB7141C", VA = "0xB7141C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xB71460", Offset = "0xB71460", VA = "0xB71460", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xB71468", Offset = "0xB71468", VA = "0xB71468")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xB714D0", Offset = "0xB714D0", VA = "0xB714D0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xB71514", Offset = "0xB71514", VA = "0xB71514", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xB71558", Offset = "0xB71558", VA = "0xB71558")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xB7159C", Offset = "0xB7159C", VA = "0xB7159C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xB715E0", Offset = "0xB715E0", VA = "0xB715E0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xB715E8", Offset = "0xB715E8", VA = "0xB715E8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xB71650", Offset = "0xB71650", VA = "0xB71650", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xB71694", Offset = "0xB71694", VA = "0xB71694", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xB716D8", Offset = "0xB716D8", VA = "0xB716D8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xB7171C", Offset = "0xB7171C", VA = "0xB7171C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xB71760", Offset = "0xB71760", VA = "0xB71760", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xB71768", Offset = "0xB71768", VA = "0xB71768")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xB717D0", Offset = "0xB717D0", VA = "0xB717D0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xB71814", Offset = "0xB71814", VA = "0xB71814", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xB71858", Offset = "0xB71858", VA = "0xB71858")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xB7189C", Offset = "0xB7189C", VA = "0xB7189C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xB718E0", Offset = "0xB718E0", VA = "0xB718E0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xB718E8", Offset = "0xB718E8", VA = "0xB718E8")]
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

			[Token(Token = "0x17000032")]
			public bool isFilled
			{
				[Token(Token = "0x6000257")]
				[Address(RVA = "0xB7221C", Offset = "0xB7221C", VA = "0xB7221C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000033")]
			public bool isEmpty
			{
				[Token(Token = "0x6000258")]
				[Address(RVA = "0xB71E60", Offset = "0xB71E60", VA = "0xB71E60")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0xB72808", Offset = "0xB72808", VA = "0xB72808")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0xB71A38", Offset = "0xB71A38", VA = "0xB71A38")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0xB72800", Offset = "0xB72800", VA = "0xB72800")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xB71950", Offset = "0xB71950", VA = "0xB71950", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xB71994", Offset = "0xB71994", VA = "0xB71994", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xB719D8", Offset = "0xB719D8", VA = "0xB719D8")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xB71A1C", Offset = "0xB71A1C", VA = "0xB71A1C")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xB71DC4", Offset = "0xB71DC4", VA = "0xB71DC4")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xB71DEC", Offset = "0xB71DEC", VA = "0xB71DEC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xB71DF4", Offset = "0xB71DF4", VA = "0xB71DF4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xB725D8", Offset = "0xB725D8", VA = "0xB725D8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xB72768", Offset = "0xB72768", VA = "0xB72768")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
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

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xB72C44", Offset = "0xB72C44", VA = "0xB72C44")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xB72D08", Offset = "0xB72D08", VA = "0xB72D08")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xB72D28", Offset = "0xB72D28", VA = "0xB72D28")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xB72F7C", Offset = "0xB72F7C", VA = "0xB72F7C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xB72DE8", Offset = "0xB72DE8", VA = "0xB72DE8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xB73060", Offset = "0xB73060", VA = "0xB73060")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000050")]
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

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xB730C0", Offset = "0xB730C0", VA = "0xB730C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xB7355C", Offset = "0xB7355C", VA = "0xB7355C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xB736F0", Offset = "0xB736F0", VA = "0xB736F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xB737FC", Offset = "0xB737FC", VA = "0xB737FC")]
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

			[Token(Token = "0x6000273")]
			[Address(RVA = "0xB76900", Offset = "0xB76900", VA = "0xB76900")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0xB76960", Offset = "0xB76960", VA = "0xB76960")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0xB74064", Offset = "0xB74064", VA = "0xB74064")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0xB74434", Offset = "0xB74434", VA = "0xB74434")]
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
		[Tooltip("Master weight for positioning the head.")]
		[LargeHeader("Position")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
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
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
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

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xB73804", Offset = "0xB73804", VA = "0xB73804")]
		private void Start()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xB73BF0", Offset = "0xB73BF0", VA = "0xB73BF0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xB74090", Offset = "0xB74090", VA = "0xB74090")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xB7445C", Offset = "0xB7445C", VA = "0xB7445C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xB74D58", Offset = "0xB74D58", VA = "0xB74D58")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xB75150", Offset = "0xB75150", VA = "0xB75150")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xB75560", Offset = "0xB75560", VA = "0xB75560")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xB75EE0", Offset = "0xB75EE0", VA = "0xB75EE0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xB74A9C", Offset = "0xB74A9C", VA = "0xB74A9C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xB7611C", Offset = "0xB7611C", VA = "0xB7611C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xB75DF8", Offset = "0xB75DF8", VA = "0xB75DF8")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xB75CF8", Offset = "0xB75CF8", VA = "0xB75CF8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xB76420", Offset = "0xB76420", VA = "0xB76420")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xB76758", Offset = "0xB76758", VA = "0xB76758")]
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

			[Token(Token = "0x17000034")]
			public float nominalDistance
			{
				[Token(Token = "0x600028B")]
				[Address(RVA = "0xB78BB4", Offset = "0xB78BB4", VA = "0xB78BB4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600028C")]
				[Address(RVA = "0xB78BBC", Offset = "0xB78BBC", VA = "0xB78BBC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000035")]
			public bool isRigid
			{
				[Token(Token = "0x600028D")]
				[Address(RVA = "0xB78BC4", Offset = "0xB78BC4", VA = "0xB78BC4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600028E")]
				[Address(RVA = "0xB78BCC", Offset = "0xB78BCC", VA = "0xB78BCC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0xB78BD8", Offset = "0xB78BD8", VA = "0xB78BD8")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0xB78C18", Offset = "0xB78C18", VA = "0xB78C18")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0xB78D78", Offset = "0xB78D78", VA = "0xB78D78")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0xB78F5C", Offset = "0xB78F5C", VA = "0xB78F5C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000055")]
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

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xB769DC", Offset = "0xB769DC", VA = "0xB769DC")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xB76ADC", Offset = "0xB76ADC", VA = "0xB76ADC")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xB76C14", Offset = "0xB76C14", VA = "0xB76C14")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xB76D2C", Offset = "0xB76D2C", VA = "0xB76D2C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xB76DE8", Offset = "0xB76DE8", VA = "0xB76DE8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xB76EF4", Offset = "0xB76EF4", VA = "0xB76EF4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xB775CC", Offset = "0xB775CC", VA = "0xB775CC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xB77070", Offset = "0xB77070", VA = "0xB77070")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xB779B4", Offset = "0xB779B4", VA = "0xB779B4")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xB77C48", Offset = "0xB77C48", VA = "0xB77C48")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xB77F18", Offset = "0xB77F18", VA = "0xB77F18")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xB782B4", Offset = "0xB782B4", VA = "0xB782B4")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xB787B0", Offset = "0xB787B0", VA = "0xB787B0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xB789B0", Offset = "0xB789B0", VA = "0xB789B0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xB7869C", Offset = "0xB7869C", VA = "0xB7869C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xB78154", Offset = "0xB78154", VA = "0xB78154")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xB78634", Offset = "0xB78634", VA = "0xB78634")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xB78A8C", Offset = "0xB78A8C", VA = "0xB78A8C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xB78560", Offset = "0xB78560", VA = "0xB78560")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xB788B4", Offset = "0xB788B4", VA = "0xB788B4")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
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

		[Token(Token = "0x17000036")]
		public bool initiated
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xB79370", Offset = "0xB79370", VA = "0xB79370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xB79378", Offset = "0xB79378", VA = "0xB79378")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xB79198", Offset = "0xB79198", VA = "0xB79198")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xB79384", Offset = "0xB79384", VA = "0xB79384")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xB793F0", Offset = "0xB793F0", VA = "0xB793F0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xB7947C", Offset = "0xB7947C", VA = "0xB7947C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xB79488", Offset = "0xB79488", VA = "0xB79488")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xB79890", Offset = "0xB79890", VA = "0xB79890")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xB79BE4", Offset = "0xB79BE4", VA = "0xB79BE4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xB79FAC", Offset = "0xB79FAC", VA = "0xB79FAC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xB79758", Offset = "0xB79758", VA = "0xB79758")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xB797F4", Offset = "0xB797F4", VA = "0xB797F4")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
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

		[Token(Token = "0x17000037")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xB7A670", Offset = "0xB7A670", VA = "0xB7A670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xB7A678", Offset = "0xB7A678", VA = "0xB7A678")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xB7A614", Offset = "0xB7A614", VA = "0xB7A614")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xB7A684", Offset = "0xB7A684", VA = "0xB7A684")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xB7A708", Offset = "0xB7A708", VA = "0xB7A708")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xB7A8A8", Offset = "0xB7A8A8", VA = "0xB7A8A8")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xB7AA64", Offset = "0xB7AA64", VA = "0xB7AA64")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xB7AD58", Offset = "0xB7AD58", VA = "0xB7AD58")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xB7AFE4", Offset = "0xB7AFE4", VA = "0xB7AFE4")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xB7B0FC", Offset = "0xB7B0FC", VA = "0xB7B0FC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xB7B198", Offset = "0xB7B198", VA = "0xB7B198")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xB7B838", Offset = "0xB7B838", VA = "0xB7B838")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xB7B890", Offset = "0xB7B890", VA = "0xB7B890")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xB7BA58", Offset = "0xB7BA58", VA = "0xB7BA58")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xB7BCA0", Offset = "0xB7BCA0", VA = "0xB7BCA0")]
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

			[Token(Token = "0x17000038")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002B4")]
				[Address(RVA = "0xB7C1DC", Offset = "0xB7C1DC", VA = "0xB7C1DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000039")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002B7")]
				[Address(RVA = "0xB7C294", Offset = "0xB7C294", VA = "0xB7C294")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700003A")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002CB")]
				[Address(RVA = "0xB7C650", Offset = "0xB7C650", VA = "0xB7C650")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xB7C1B4", Offset = "0xB7C1B4", VA = "0xB7C1B4")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xB7C20C", Offset = "0xB7C20C", VA = "0xB7C20C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xB7C250", Offset = "0xB7C250", VA = "0xB7C250")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xB7C2A4", Offset = "0xB7C2A4", VA = "0xB7C2A4")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xB7C378", Offset = "0xB7C378", VA = "0xB7C378")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xB7C380", Offset = "0xB7C380", VA = "0xB7C380")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xB7C44C", Offset = "0xB7C44C", VA = "0xB7C44C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xB7C4B8", Offset = "0xB7C4B8", VA = "0xB7C4B8")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xB7C540", Offset = "0xB7C540", VA = "0xB7C540")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xB7C7B8", Offset = "0xB7C7B8", VA = "0xB7C7B8")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xB7C7E4", Offset = "0xB7C7E4", VA = "0xB7C7E4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xB7C810", Offset = "0xB7C810", VA = "0xB7C810")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xB7C838", Offset = "0xB7C838", VA = "0xB7C838")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xB7C8F8", Offset = "0xB7C8F8", VA = "0xB7C8F8")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xB7CA7C", Offset = "0xB7CA7C", VA = "0xB7CA7C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xB7CAA0", Offset = "0xB7CAA0", VA = "0xB7CAA0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xB7CBC0", Offset = "0xB7CBC0", VA = "0xB7CBC0")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xB7CC24", Offset = "0xB7CC24", VA = "0xB7CC24")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xB7CDA4", Offset = "0xB7CDA4", VA = "0xB7CDA4")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xB7CF24", Offset = "0xB7CF24", VA = "0xB7CF24")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xB7CFA0", Offset = "0xB7CFA0", VA = "0xB7CFA0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xB7C96C", Offset = "0xB7C96C", VA = "0xB7C96C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xB7D0BC", Offset = "0xB7D0BC", VA = "0xB7D0BC")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xB7BF50", Offset = "0xB7BF50", VA = "0xB7BF50", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xB7BF58", Offset = "0xB7BF58", VA = "0xB7BF58", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xB7BF5C", Offset = "0xB7BF5C", VA = "0xB7BF5C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xB7C098", Offset = "0xB7C098", VA = "0xB7C098")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xB7C1AC", Offset = "0xB7C1AC", VA = "0xB7C1AC")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
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

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xB7D0D8", Offset = "0xB7D0D8", VA = "0xB7D0D8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xB7D174", Offset = "0xB7D174", VA = "0xB7D174")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xB7D1F8", Offset = "0xB7D1F8", VA = "0xB7D1F8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xB7D290", Offset = "0xB7D290", VA = "0xB7D290")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xB7D2A8", Offset = "0xB7D2A8", VA = "0xB7D2A8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xB7D2C4", Offset = "0xB7D2C4", VA = "0xB7D2C4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xB7D350", Offset = "0xB7D350", VA = "0xB7D350")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xB7D368", Offset = "0xB7D368", VA = "0xB7D368")]
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

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xB7D38C", Offset = "0xB7D38C", VA = "0xB7D38C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xB7D400", Offset = "0xB7D400", VA = "0xB7D400")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xB7D4C8", Offset = "0xB7D4C8", VA = "0xB7D4C8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xB7D780", Offset = "0xB7D780", VA = "0xB7D780")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xB7D89C", Offset = "0xB7D89C", VA = "0xB7D89C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xB7D9E4", Offset = "0xB7D9E4", VA = "0xB7D9E4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xB7D9F0", Offset = "0xB7D9F0", VA = "0xB7D9F0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xB7DA88", Offset = "0xB7DA88", VA = "0xB7DA88")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xB7DB30", Offset = "0xB7DB30", VA = "0xB7DB30", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xB7DD8C", Offset = "0xB7DD8C", VA = "0xB7DD8C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xB7DDEC", Offset = "0xB7DDEC", VA = "0xB7DDEC")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
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

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xB7DF30", Offset = "0xB7DF30", VA = "0xB7DF30", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xB7E250", Offset = "0xB7E250", VA = "0xB7E250")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xB7E38C", Offset = "0xB7E38C", VA = "0xB7E38C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xB7E4FC", Offset = "0xB7E4FC", VA = "0xB7E4FC")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xB7E50C", Offset = "0xB7E50C", VA = "0xB7E50C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xB7E568", Offset = "0xB7E568", VA = "0xB7E568")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xB7E5E0", Offset = "0xB7E5E0", VA = "0xB7E5E0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xB7EBF4", Offset = "0xB7EBF4", VA = "0xB7EBF4")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xB7EC2C", Offset = "0xB7EC2C", VA = "0xB7EC2C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xB7EE90", Offset = "0xB7EE90", VA = "0xB7EE90")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xB7F1B0", Offset = "0xB7F1B0", VA = "0xB7F1B0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xB7F290", Offset = "0xB7F290", VA = "0xB7F290")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xB7F344", Offset = "0xB7F344", VA = "0xB7F344")]
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
			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000303")]
			[Address(RVA = "0xB7FC0C", Offset = "0xB7FC0C", VA = "0xB7FC0C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0xB7FC50", Offset = "0xB7FC50", VA = "0xB7FC50")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0xB7FD30", Offset = "0xB7FD30", VA = "0xB7FD30")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0xB7FD5C", Offset = "0xB7FD5C", VA = "0xB7FD5C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0xB7FD88", Offset = "0xB7FD88", VA = "0xB7FD88")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0xB7FDCC", Offset = "0xB7FDCC", VA = "0xB7FDCC")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0xB7FE10", Offset = "0xB7FE10", VA = "0xB7FE10")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000060")]
		public class Bone : Point
		{
			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700003C")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600030A")]
				[Address(RVA = "0xB7FE70", Offset = "0xB7FE70", VA = "0xB7FE70")]
				get
				{
					return null;
				}
				[Token(Token = "0x600030B")]
				[Address(RVA = "0xB7FF50", Offset = "0xB7FF50", VA = "0xB7FF50")]
				set
				{
				}
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0xB7FFC8", Offset = "0xB7FFC8", VA = "0xB7FFC8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0xB80234", Offset = "0xB80234", VA = "0xB80234")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0xB804F0", Offset = "0xB804F0", VA = "0xB804F0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0xB806E4", Offset = "0xB806E4", VA = "0xB806E4")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0xB8070C", Offset = "0xB8070C", VA = "0xB8070C")]
			public Bone()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0xB80778", Offset = "0xB80778", VA = "0xB80778")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0xB807F0", Offset = "0xB807F0", VA = "0xB807F0")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000061")]
		public class Node : Point
		{
			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000313")]
			[Address(RVA = "0xB80878", Offset = "0xB80878", VA = "0xB80878")]
			public Node()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0xB8087C", Offset = "0xB8087C", VA = "0xB8087C")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0xB808A0", Offset = "0xB808A0", VA = "0xB808A0")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000062")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000063")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700003B")]
		public bool initiated
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xB7F818", Offset = "0xB7F818", VA = "0xB7F818")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xB7F820", Offset = "0xB7F820", VA = "0xB7F820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xB7F580", Offset = "0xB7F580", VA = "0xB7F580")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xB7F5F4", Offset = "0xB7F5F4", VA = "0xB7F5F4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xB7F764", Offset = "0xB7F764", VA = "0xB7F764")]
		public void Update()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xB7F7D4", Offset = "0xB7F7D4", VA = "0xB7F7D4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xB7F7E0", Offset = "0xB7F7E0", VA = "0xB7F7E0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xB7F7EC", Offset = "0xB7F7EC", VA = "0xB7F7EC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xB7F7F4", Offset = "0xB7F7F4", VA = "0xB7F7F4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xB7F810", Offset = "0xB7F810", VA = "0xB7F810")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002F9")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002FA")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002FB")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002FC")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002FD")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xB7F82C", Offset = "0xB7F82C", VA = "0xB7F82C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xB7F844", Offset = "0xB7F844", VA = "0xB7F844")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xB7F968", Offset = "0xB7F968", VA = "0xB7F968")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xB7FA00", Offset = "0xB7FA00", VA = "0xB7FA00")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xB7FBF4", Offset = "0xB7FBF4", VA = "0xB7FBF4")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700003D")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xB80C70", Offset = "0xB80C70", VA = "0xB80C70")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0xB80CA0", Offset = "0xB80CA0", VA = "0xB80CA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override int minBones
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0xB818D4", Offset = "0xB818D4", VA = "0xB818D4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000040")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xB81E14", Offset = "0xB81E14", VA = "0xB81E14", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xB80B38", Offset = "0xB80B38", VA = "0xB80B38")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xB80CD0", Offset = "0xB80CD0", VA = "0xB80CD0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xB80F5C", Offset = "0xB80F5C", VA = "0xB80F5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xB8182C", Offset = "0xB8182C", VA = "0xB8182C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xB814C8", Offset = "0xB814C8", VA = "0xB814C8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xB818DC", Offset = "0xB818DC", VA = "0xB818DC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xB81E74", Offset = "0xB81E74", VA = "0xB81E74")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xB81F18", Offset = "0xB81F18", VA = "0xB81F18", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xB82274", Offset = "0xB82274", VA = "0xB82274")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xB822D4", Offset = "0xB822D4", VA = "0xB822D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xB82418", Offset = "0xB82418", VA = "0xB82418", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xB82578", Offset = "0xB82578", VA = "0xB82578", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xB825B8", Offset = "0xB825B8", VA = "0xB825B8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xB82608", Offset = "0xB82608", VA = "0xB82608", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xB82968", Offset = "0xB82968", VA = "0xB82968", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xB82988", Offset = "0xB82988", VA = "0xB82988")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xB82660", Offset = "0xB82660", VA = "0xB82660")]
		private void Read()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xB829E8", Offset = "0xB829E8", VA = "0xB829E8")]
		private void Write()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xB82B60", Offset = "0xB82B60", VA = "0xB82B60")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xB82CF4", Offset = "0xB82CF4", VA = "0xB82CF4")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xB82D64", Offset = "0xB82D64", VA = "0xB82D64", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xB82DD4", Offset = "0xB82DD4", VA = "0xB82DD4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xB83088", Offset = "0xB83088", VA = "0xB83088")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xB83718", Offset = "0xB83718", VA = "0xB83718")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000041")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0xB846C0", Offset = "0xB846C0", VA = "0xB846C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xB83720", Offset = "0xB83720", VA = "0xB83720")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xB83D00", Offset = "0xB83D00", VA = "0xB83D00")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xB83E30", Offset = "0xB83E30", VA = "0xB83E30", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xB83EB8", Offset = "0xB83EB8", VA = "0xB83EB8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xB843B4", Offset = "0xB843B4", VA = "0xB843B4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xB846C8", Offset = "0xB846C8", VA = "0xB846C8")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xB837F8", Offset = "0xB837F8", VA = "0xB837F8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xB83DE8", Offset = "0xB83DE8", VA = "0xB83DE8")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xB84678", Offset = "0xB84678", VA = "0xB84678")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xB83B94", Offset = "0xB83B94", VA = "0xB83B94")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xB84D74", Offset = "0xB84D74", VA = "0xB84D74")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xB84DDC", Offset = "0xB84DDC", VA = "0xB84DDC")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xB84EAC", Offset = "0xB84EAC", VA = "0xB84EAC")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xB84F74", Offset = "0xB84F74", VA = "0xB84F74")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xB8412C", Offset = "0xB8412C", VA = "0xB8412C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xB84270", Offset = "0xB84270", VA = "0xB84270")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xB85064", Offset = "0xB85064", VA = "0xB85064")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xB84964", Offset = "0xB84964", VA = "0xB84964")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xB83DD8", Offset = "0xB83DD8", VA = "0xB83DD8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xB856D4", Offset = "0xB856D4", VA = "0xB856D4")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xB85224", Offset = "0xB85224", VA = "0xB85224")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xB847E4", Offset = "0xB847E4", VA = "0xB847E4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xB848B4", Offset = "0xB848B4", VA = "0xB848B4")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xB8578C", Offset = "0xB8578C", VA = "0xB8578C")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xB85810", Offset = "0xB85810", VA = "0xB85810", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xB85E64", Offset = "0xB85E64", VA = "0xB85E64", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xB85EF0", Offset = "0xB85EF0", VA = "0xB85EF0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xB85F84", Offset = "0xB85F84", VA = "0xB85F84", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xB8606C", Offset = "0xB8606C", VA = "0xB8606C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xB860FC", Offset = "0xB860FC", VA = "0xB860FC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xB864FC", Offset = "0xB864FC", VA = "0xB864FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xB866D4", Offset = "0xB866D4", VA = "0xB866D4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xB8659C", Offset = "0xB8659C", VA = "0xB8659C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xB862D4", Offset = "0xB862D4", VA = "0xB862D4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xB86758", Offset = "0xB86758", VA = "0xB86758")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xB867C8", Offset = "0xB867C8", VA = "0xB867C8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xB868A4", Offset = "0xB868A4", VA = "0xB868A4")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xB78C64", Offset = "0xB78C64", VA = "0xB78C64")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xB7A5C4", Offset = "0xB7A5C4", VA = "0xB7A5C4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xB796E4", Offset = "0xB796E4", VA = "0xB796E4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xB868EC", Offset = "0xB868EC", VA = "0xB868EC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xB86A84", Offset = "0xB86A84", VA = "0xB86A84", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xB86BE0", Offset = "0xB86BE0", VA = "0xB86BE0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xB86DDC", Offset = "0xB86DDC", VA = "0xB86DDC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xB86EAC", Offset = "0xB86EAC", VA = "0xB86EAC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xB86F88", Offset = "0xB86F88", VA = "0xB86F88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xB870E4", Offset = "0xB870E4", VA = "0xB870E4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xB8727C", Offset = "0xB8727C", VA = "0xB8727C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xB874A4", Offset = "0xB874A4", VA = "0xB874A4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xB87774", Offset = "0xB87774", VA = "0xB87774", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xB877AC", Offset = "0xB877AC", VA = "0xB877AC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xB87884", Offset = "0xB87884", VA = "0xB87884")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002DE")]
		Body,
		[Token(Token = "0x40002DF")]
		LeftShoulder,
		[Token(Token = "0x40002E0")]
		RightShoulder,
		[Token(Token = "0x40002E1")]
		LeftThigh,
		[Token(Token = "0x40002E2")]
		RightThigh,
		[Token(Token = "0x40002E3")]
		LeftHand,
		[Token(Token = "0x40002E4")]
		RightHand,
		[Token(Token = "0x40002E5")]
		LeftFoot,
		[Token(Token = "0x40002E6")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002E8")]
		LeftArm,
		[Token(Token = "0x40002E9")]
		RightArm,
		[Token(Token = "0x40002EA")]
		LeftLeg,
		[Token(Token = "0x40002EB")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000042")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0xB8799C", Offset = "0xB8799C", VA = "0xB8799C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0xB87ADC", Offset = "0xB87ADC", VA = "0xB87ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xB87AE4", Offset = "0xB87AE4", VA = "0xB87AE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xB87AEC", Offset = "0xB87AEC", VA = "0xB87AEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xB87AF4", Offset = "0xB87AF4", VA = "0xB87AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xB87AFC", Offset = "0xB87AFC", VA = "0xB87AFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xB87B04", Offset = "0xB87B04", VA = "0xB87B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xB87B0C", Offset = "0xB87B0C", VA = "0xB87B0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0xB87B14", Offset = "0xB87B14", VA = "0xB87B14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xB87B1C", Offset = "0xB87B1C", VA = "0xB87B1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xB87B48", Offset = "0xB87B48", VA = "0xB87B48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xB87B74", Offset = "0xB87B74", VA = "0xB87B74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xB87BA0", Offset = "0xB87BA0", VA = "0xB87BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0xB87BCC", Offset = "0xB87BCC", VA = "0xB87BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0xB87BF4", Offset = "0xB87BF4", VA = "0xB87BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0xB87C20", Offset = "0xB87C20", VA = "0xB87C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0xB87C4C", Offset = "0xB87C4C", VA = "0xB87C4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0xB87C78", Offset = "0xB87C78", VA = "0xB87C78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xB899D8", Offset = "0xB899D8", VA = "0xB899D8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xB899E4", Offset = "0xB899E4", VA = "0xB899E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xB87CA0", Offset = "0xB87CA0", VA = "0xB87CA0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xB87DA0", Offset = "0xB87DA0", VA = "0xB87DA0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xB87CF0", Offset = "0xB87CF0", VA = "0xB87CF0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xB87E18", Offset = "0xB87E18", VA = "0xB87E18")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xB879A4", Offset = "0xB879A4", VA = "0xB879A4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xB87EE0", Offset = "0xB87EE0", VA = "0xB87EE0")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xB87F90", Offset = "0xB87F90", VA = "0xB87F90")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xB8803C", Offset = "0xB8803C", VA = "0xB8803C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xB880E8", Offset = "0xB880E8", VA = "0xB880E8")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xB880F0", Offset = "0xB880F0", VA = "0xB880F0")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xB88118", Offset = "0xB88118", VA = "0xB88118")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xB881D8", Offset = "0xB881D8", VA = "0xB881D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xB88368", Offset = "0xB88368", VA = "0xB88368")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xB892DC", Offset = "0xB892DC", VA = "0xB892DC")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xB8988C", Offset = "0xB8988C", VA = "0xB8988C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xB898E8", Offset = "0xB898E8", VA = "0xB898E8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xB8972C", Offset = "0xB8972C", VA = "0xB8972C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xB897DC", Offset = "0xB897DC", VA = "0xB897DC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xB899F0", Offset = "0xB899F0", VA = "0xB899F0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xB89AB4", Offset = "0xB89AB4", VA = "0xB89AB4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xB89B80", Offset = "0xB89B80", VA = "0xB89B80")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xB89C9C", Offset = "0xB89C9C", VA = "0xB89C9C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xB89E2C", Offset = "0xB89E2C", VA = "0xB89E2C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xB89FA4", Offset = "0xB89FA4", VA = "0xB89FA4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xB8A200", Offset = "0xB8A200", VA = "0xB8A200", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xB8A278", Offset = "0xB8A278", VA = "0xB8A278")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000055")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xB8AAB8", Offset = "0xB8AAB8", VA = "0xB8AAB8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xB8AAC0", Offset = "0xB8AAC0", VA = "0xB8AAC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xB8AAC8", Offset = "0xB8AAC8", VA = "0xB8AAC8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xB8AF6C", Offset = "0xB8AF6C", VA = "0xB8AF6C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000059")]
		protected float positionOffset
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xB8B028", Offset = "0xB8B028", VA = "0xB8B028")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xB8A284", Offset = "0xB8A284", VA = "0xB8A284")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xB8A408", Offset = "0xB8A408", VA = "0xB8A408")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xB8A534", Offset = "0xB8A534", VA = "0xB8A534", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xB8A594", Offset = "0xB8A594", VA = "0xB8A594", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xB8A608", Offset = "0xB8A608", VA = "0xB8A608", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xB8A9D4", Offset = "0xB8A9D4", VA = "0xB8A9D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xB8A9DC", Offset = "0xB8A9DC", VA = "0xB8A9DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xB8AAD0", Offset = "0xB8AAD0", VA = "0xB8AAD0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xB8AAD4", Offset = "0xB8AAD4", VA = "0xB8AAD4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xB8AAD8", Offset = "0xB8AAD8", VA = "0xB8AAD8")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xB8B070", Offset = "0xB8B070", VA = "0xB8B070")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xB8B428", Offset = "0xB8B428", VA = "0xB8B428")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xB8B6BC", Offset = "0xB8B6BC", VA = "0xB8B6BC")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xB8B724", Offset = "0xB8B724", VA = "0xB8B724", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xB8BA80", Offset = "0xB8BA80", VA = "0xB8BA80")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xB8BAE4", Offset = "0xB8BAE4", VA = "0xB8BAE4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xB8BC28", Offset = "0xB8BC28", VA = "0xB8BC28", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xB8BD88", Offset = "0xB8BD88", VA = "0xB8BD88", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xB8BDD8", Offset = "0xB8BDD8", VA = "0xB8BDD8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xB8BE38", Offset = "0xB8BE38", VA = "0xB8BE38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xB8C194", Offset = "0xB8C194", VA = "0xB8C194", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xB8C1B4", Offset = "0xB8C1B4", VA = "0xB8C1B4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xB8BE90", Offset = "0xB8BE90", VA = "0xB8BE90")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xB8C238", Offset = "0xB8C238", VA = "0xB8C238")]
		private void Write()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xB8C618", Offset = "0xB8C618", VA = "0xB8C618")]
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
			[Token(Token = "0x4000316")]
			Animation,
			[Token(Token = "0x4000317")]
			Target,
			[Token(Token = "0x4000318")]
			Parent,
			[Token(Token = "0x4000319")]
			Arm,
			[Token(Token = "0x400031A")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000071")]
		public struct AxisDirection
		{
			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xB8DC74", Offset = "0xB8DC74", VA = "0xB8DC74")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700005A")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xB8DC58", Offset = "0xB8DC58", VA = "0xB8DC58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xB8C888", Offset = "0xB8C888", VA = "0xB8C888")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xB8C8CC", Offset = "0xB8C8CC", VA = "0xB8C8CC")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xB8C938", Offset = "0xB8C938", VA = "0xB8C938", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xB8CE80", Offset = "0xB8CE80", VA = "0xB8CE80", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xB8D99C", Offset = "0xB8D99C", VA = "0xB8D99C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xB8DA44", Offset = "0xB8DA44", VA = "0xB8DA44")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xB8DBD8", Offset = "0xB8DBD8", VA = "0xB8DBD8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xB8CC94", Offset = "0xB8CC94", VA = "0xB8CC94")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xB8CF3C", Offset = "0xB8CF3C", VA = "0xB8CF3C")]
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
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000061")]
			public Vector3 forward
			{
				[Token(Token = "0x60003E4")]
				[Address(RVA = "0xB8FA30", Offset = "0xB8FA30", VA = "0xB8FA30")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xB90088", Offset = "0xB90088", VA = "0xB90088")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xB8EB90", Offset = "0xB8EB90", VA = "0xB8EB90")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xB8EE40", Offset = "0xB8EE40", VA = "0xB8EE40")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xB8FD78", Offset = "0xB8FD78", VA = "0xB8FD78")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x1700005B")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xB8E394", Offset = "0xB8E394", VA = "0xB8E394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xB8E53C", Offset = "0xB8E53C", VA = "0xB8E53C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0xB8E460", Offset = "0xB8E460", VA = "0xB8E460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xB8E560", Offset = "0xB8E560", VA = "0xB8E560")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xB8E470", Offset = "0xB8E470", VA = "0xB8E470")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xB8E5CC", Offset = "0xB8E5CC", VA = "0xB8E5CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xB8DE10", Offset = "0xB8DE10", VA = "0xB8DE10")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xB8DE2C", Offset = "0xB8DE2C", VA = "0xB8DE2C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xB8DE58", Offset = "0xB8DE58", VA = "0xB8DE58")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xB8DE90", Offset = "0xB8DE90", VA = "0xB8DE90")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xB8DED8", Offset = "0xB8DED8", VA = "0xB8DED8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xB8DF30", Offset = "0xB8DF30", VA = "0xB8DF30")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xB8DFA0", Offset = "0xB8DFA0", VA = "0xB8DFA0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xB8E0B8", Offset = "0xB8E0B8", VA = "0xB8E0B8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xB8E1E4", Offset = "0xB8E1E4", VA = "0xB8E1E4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xB8E5F0", Offset = "0xB8E5F0", VA = "0xB8E5F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xB8E814", Offset = "0xB8E814", VA = "0xB8E814", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xB8E974", Offset = "0xB8E974", VA = "0xB8E974")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xB8EBB8", Offset = "0xB8EBB8", VA = "0xB8EBB8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xB8EF2C", Offset = "0xB8EF2C", VA = "0xB8EF2C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xB8EFF0", Offset = "0xB8EFF0", VA = "0xB8EFF0")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xB8F20C", Offset = "0xB8F20C", VA = "0xB8F20C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xB8F554", Offset = "0xB8F554", VA = "0xB8F554")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xB8FA60", Offset = "0xB8FA60", VA = "0xB8FA60")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xB8EA24", Offset = "0xB8EA24", VA = "0xB8EA24")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xB8FE80", Offset = "0xB8FE80", VA = "0xB8FE80")]
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
			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xB9132C", Offset = "0xB9132C", VA = "0xB9132C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xB91BD4", Offset = "0xB91BD4", VA = "0xB91BD4")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xB8C908", Offset = "0xB8C908", VA = "0xB8C908")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xB91C70", Offset = "0xB91C70", VA = "0xB91C70")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xB90090", Offset = "0xB90090", VA = "0xB90090")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xB90224", Offset = "0xB90224", VA = "0xB90224")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xB903A4", Offset = "0xB903A4", VA = "0xB903A4")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xB903B0", Offset = "0xB903B0", VA = "0xB903B0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xB903CC", Offset = "0xB903CC", VA = "0xB903CC")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xB903D8", Offset = "0xB903D8", VA = "0xB903D8")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xB903E0", Offset = "0xB903E0", VA = "0xB903E0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xB904CC", Offset = "0xB904CC", VA = "0xB904CC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xB905C4", Offset = "0xB905C4", VA = "0xB905C4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xB90604", Offset = "0xB90604", VA = "0xB90604", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xB90654", Offset = "0xB90654", VA = "0xB90654", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xB909F8", Offset = "0xB909F8", VA = "0xB909F8")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xB90A44", Offset = "0xB90A44", VA = "0xB90A44")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xB90F38", Offset = "0xB90F38", VA = "0xB90F38")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xB91090", Offset = "0xB91090", VA = "0xB91090", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xB9123C", Offset = "0xB9123C", VA = "0xB9123C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xB911BC", Offset = "0xB911BC", VA = "0xB911BC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xB9141C", Offset = "0xB9141C", VA = "0xB9141C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xB91C64", Offset = "0xB91C64", VA = "0xB91C64", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xB91C68", Offset = "0xB91C68", VA = "0xB91C68", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xB91C6C", Offset = "0xB91C6C", VA = "0xB91C6C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xB91A14", Offset = "0xB91A14", VA = "0xB91A14")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xB8DAB0", Offset = "0xB8DAB0", VA = "0xB8DAB0")]
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
				[Token(Token = "0x400037C")]
				YawPitch,
				[Token(Token = "0x400037D")]
				FromTo
			}

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000379")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400037A")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000063")]
			public Vector3 position
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0xB978E0", Offset = "0xB978E0", VA = "0xB978E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600041F")]
				[Address(RVA = "0xB978EC", Offset = "0xB978EC", VA = "0xB978EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000420")]
				[Address(RVA = "0xB978F8", Offset = "0xB978F8", VA = "0xB978F8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000421")]
				[Address(RVA = "0xB97904", Offset = "0xB97904", VA = "0xB97904")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000422")]
				[Address(RVA = "0xB97910", Offset = "0xB97910", VA = "0xB97910")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000423")]
				[Address(RVA = "0xB97938", Offset = "0xB97938", VA = "0xB97938")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000424")]
				[Address(RVA = "0xB9796C", Offset = "0xB9796C", VA = "0xB9796C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0xB979AC", Offset = "0xB979AC", VA = "0xB979AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0xB979EC", Offset = "0xB979EC", VA = "0xB979EC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0xB98230", Offset = "0xB98230", VA = "0xB98230", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0xB984DC", Offset = "0xB984DC", VA = "0xB984DC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0xB98500", Offset = "0xB98500", VA = "0xB98500")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0xB95848", Offset = "0xB95848", VA = "0xB95848")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0xB98F34", Offset = "0xB98F34", VA = "0xB98F34", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0xB98F8C", Offset = "0xB98F8C", VA = "0xB98F8C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0xB98850", Offset = "0xB98850", VA = "0xB98850")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0xB988D0", Offset = "0xB988D0", VA = "0xB988D0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0xB99198", Offset = "0xB99198", VA = "0xB99198")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000430")]
			[Address(RVA = "0xB97754", Offset = "0xB97754", VA = "0xB97754")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000069")]
			public float sqrMag
			{
				[Token(Token = "0x6000436")]
				[Address(RVA = "0xB99348", Offset = "0xB99348", VA = "0xB99348")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000437")]
				[Address(RVA = "0xB99350", Offset = "0xB99350", VA = "0xB99350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public float mag
			{
				[Token(Token = "0x6000438")]
				[Address(RVA = "0xB99358", Offset = "0xB99358", VA = "0xB99358")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000439")]
				[Address(RVA = "0xB99360", Offset = "0xB99360", VA = "0xB99360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000431")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000432")]
			public abstract void PreSolve();

			[Token(Token = "0x6000433")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000434")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000435")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xB99368", Offset = "0xB99368", VA = "0xB99368")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xB8C558", Offset = "0xB8C558", VA = "0xB8C558")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xB99370", Offset = "0xB99370", VA = "0xB99370")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0xB993F8", Offset = "0xB993F8", VA = "0xB993F8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xB99490", Offset = "0xB99490", VA = "0xB99490")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0xB95720", Offset = "0xB95720", VA = "0xB95720")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xB98DCC", Offset = "0xB98DCC", VA = "0xB98DCC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0xB994D8", Offset = "0xB994D8", VA = "0xB994D8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0xB995FC", Offset = "0xB995FC", VA = "0xB995FC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0xB992B0", Offset = "0xB992B0", VA = "0xB992B0")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Footstep
		{
			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700006B")]
			public bool isStepping
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0xB99610", Offset = "0xB99610", VA = "0xB99610")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006C")]
			public float stepProgress
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0xB99624", Offset = "0xB99624", VA = "0xB99624")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000446")]
				[Address(RVA = "0xB9962C", Offset = "0xB9962C", VA = "0xB9962C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0xB99634", Offset = "0xB99634", VA = "0xB99634")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0xB997F8", Offset = "0xB997F8", VA = "0xB997F8")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0xB99840", Offset = "0xB99840", VA = "0xB99840")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0xB99A64", Offset = "0xB99A64", VA = "0xB99A64")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0xB99C6C", Offset = "0xB99C6C", VA = "0xB99C6C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0xB99E50", Offset = "0xB99E50", VA = "0xB99E50")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006D")]
			public Vector3 position
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0xB99FC4", Offset = "0xB99FC4", VA = "0xB99FC4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600044E")]
				[Address(RVA = "0xB99FD0", Offset = "0xB99FD0", VA = "0xB99FD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public Quaternion rotation
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0xB99FDC", Offset = "0xB99FDC", VA = "0xB99FDC")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000450")]
				[Address(RVA = "0xB99FE8", Offset = "0xB99FE8", VA = "0xB99FE8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public bool hasToes
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0xB99FF4", Offset = "0xB99FF4", VA = "0xB99FF4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0xB99FFC", Offset = "0xB99FFC", VA = "0xB99FFC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000070")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0xB9A008", Offset = "0xB9A008", VA = "0xB9A008")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0xB9A030", Offset = "0xB9A030", VA = "0xB9A030")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0xB9A05C", Offset = "0xB9A05C", VA = "0xB9A05C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0xB9A088", Offset = "0xB9A088", VA = "0xB9A088")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0xB956EC", Offset = "0xB956EC", VA = "0xB956EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0xB9A0B4", Offset = "0xB9A0B4", VA = "0xB9A0B4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000459")]
				[Address(RVA = "0xB9A0C0", Offset = "0xB9A0C0", VA = "0xB9A0C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0xB9A0CC", Offset = "0xB9A0CC", VA = "0xB9A0CC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0xB9A634", Offset = "0xB9A634", VA = "0xB9A634", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0xB9ADA4", Offset = "0xB9ADA4", VA = "0xB9ADA4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0xB9AD54", Offset = "0xB9AD54", VA = "0xB9AD54")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xB9AB08", Offset = "0xB9AB08", VA = "0xB9AB08")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xB8C3B0", Offset = "0xB8C3B0", VA = "0xB8C3B0")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xB9B65C", Offset = "0xB9B65C", VA = "0xB9B65C")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xB9B280", Offset = "0xB9B280", VA = "0xB9B280")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xB9BAB4", Offset = "0xB9BAB4", VA = "0xB9BAB4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xB9BCBC", Offset = "0xB9BCBC", VA = "0xB9BCBC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xB8C7AC", Offset = "0xB8C7AC", VA = "0xB8C7AC")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public class Locomotion
		{
			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x17000076")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0xB9BD9C", Offset = "0xB9BD9C", VA = "0xB9BD9C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000466")]
				[Address(RVA = "0xB9BDA8", Offset = "0xB9BDA8", VA = "0xB9BDA8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0xB9DFB4", Offset = "0xB9DFB4", VA = "0xB9DFB4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0xB9DFE8", Offset = "0xB9DFE8", VA = "0xB9DFE8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0xB9E020", Offset = "0xB9E020", VA = "0xB9E020")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700007A")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0xB9E054", Offset = "0xB9E054", VA = "0xB9E054")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0xB9BDB4", Offset = "0xB9BDB4", VA = "0xB9BDB4")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xB9C0B0", Offset = "0xB9C0B0", VA = "0xB9C0B0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0xB9C29C", Offset = "0xB9C29C", VA = "0xB9C29C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xB9C664", Offset = "0xB9C664", VA = "0xB9C664")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0xB9C71C", Offset = "0xB9C71C", VA = "0xB9C71C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xB9DBC0", Offset = "0xB9DBC0", VA = "0xB9DBC0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0xB9DD74", Offset = "0xB9DD74", VA = "0xB9DD74")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xB9DE04", Offset = "0xB9DE04", VA = "0xB9DE04")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0xB9E08C", Offset = "0xB9E08C", VA = "0xB9E08C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			public float chestClampWeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700007B")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0xB9DB58", Offset = "0xB9DB58", VA = "0xB9DB58")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0xB9E178", Offset = "0xB9E178", VA = "0xB9E178")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0xB9E1AC", Offset = "0xB9E1AC", VA = "0xB9E1AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0xB9E1F4", Offset = "0xB9E1F4", VA = "0xB9E1F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public VirtualBone head
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0xB9DB8C", Offset = "0xB9DB8C", VA = "0xB9DB8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0xB9E228", Offset = "0xB9E228", VA = "0xB9E228")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047A")]
				[Address(RVA = "0xB9E23C", Offset = "0xB9E23C", VA = "0xB9E23C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0xB9E250", Offset = "0xB9E250", VA = "0xB9E250")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047C")]
				[Address(RVA = "0xB9E264", Offset = "0xB9E264", VA = "0xB9E264")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0xB9E278", Offset = "0xB9E278", VA = "0xB9E278", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0xB9EF68", Offset = "0xB9EF68", VA = "0xB9EF68", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0xB9F150", Offset = "0xB9F150", VA = "0xB9F150", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0xB9F8E4", Offset = "0xB9F8E4", VA = "0xB9F8E4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0xB9FF20", Offset = "0xB9FF20", VA = "0xB9FF20")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0xBA086C", Offset = "0xBA086C", VA = "0xBA086C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0xBA1014", Offset = "0xBA1014", VA = "0xBA1014")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0xBA1A54", Offset = "0xBA1A54", VA = "0xBA1A54", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0xBA1C24", Offset = "0xBA1C24", VA = "0xBA1C24", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0xB9FB28", Offset = "0xB9FB28", VA = "0xB9FB28")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0xBA0D3C", Offset = "0xBA0D3C", VA = "0xBA0D3C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0xBA045C", Offset = "0xBA045C", VA = "0xBA045C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0xBA1CF8", Offset = "0xBA1CF8", VA = "0xBA1CF8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0xBA0E18", Offset = "0xBA0E18", VA = "0xBA0E18")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0xBA0ACC", Offset = "0xBA0ACC", VA = "0xBA0ACC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0xBA2110", Offset = "0xBA2110", VA = "0xBA2110")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000403")]
			Pelvis,
			[Token(Token = "0x4000404")]
			Chest,
			[Token(Token = "0x4000405")]
			Head,
			[Token(Token = "0x4000406")]
			LeftHand,
			[Token(Token = "0x4000407")]
			RightHand,
			[Token(Token = "0x4000408")]
			LeftFoot,
			[Token(Token = "0x4000409")]
			RightFoot,
			[Token(Token = "0x400040A")]
			LeftHeel,
			[Token(Token = "0x400040B")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public enum RotationOffset
		{
			[Token(Token = "0x400040D")]
			Pelvis,
			[Token(Token = "0x400040E")]
			Chest,
			[Token(Token = "0x400040F")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public class VirtualBone
		{
			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600048D")]
			[Address(RVA = "0xB9EED8", Offset = "0xB9EED8", VA = "0xB9EED8")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0xB9EF48", Offset = "0xB9EF48", VA = "0xB9EF48")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0xBA222C", Offset = "0xBA222C", VA = "0xBA222C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0xBA242C", Offset = "0xBA242C", VA = "0xBA242C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0xBA1FA0", Offset = "0xBA1FA0", VA = "0xBA1FA0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0xBA258C", Offset = "0xBA258C", VA = "0xBA258C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0xBA2734", Offset = "0xBA2734", VA = "0xBA2734")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0xBA28BC", Offset = "0xBA28BC", VA = "0xBA28BC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0xBA1670", Offset = "0xBA1670", VA = "0xBA1670")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0xBA2960", Offset = "0xBA2960", VA = "0xBA2960")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0xBA12A4", Offset = "0xBA12A4", VA = "0xBA12A4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0xBA2AB8", Offset = "0xBA2AB8", VA = "0xBA2AB8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0xBA2BCC", Offset = "0xBA2BCC", VA = "0xBA2BCC")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		public int LOD;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000062")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xB97518", Offset = "0xB97518", VA = "0xB97518")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0xB97520", Offset = "0xB97520", VA = "0xB97520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xB91C78", Offset = "0xB91C78", VA = "0xB91C78")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xB92098", Offset = "0xB92098", VA = "0xB92098")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xB91F4C", Offset = "0xB91F4C", VA = "0xB91F4C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xB928C8", Offset = "0xB928C8", VA = "0xB928C8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xB92A0C", Offset = "0xB92A0C", VA = "0xB92A0C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xB92A4C", Offset = "0xB92A4C", VA = "0xB92A4C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xB92B70", Offset = "0xB92B70", VA = "0xB92B70")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xB92C4C", Offset = "0xB92C4C", VA = "0xB92C4C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xB933C0", Offset = "0xB933C0", VA = "0xB933C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xB93514", Offset = "0xB93514", VA = "0xB93514", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xB93700", Offset = "0xB93700", VA = "0xB93700", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xB93770", Offset = "0xB93770", VA = "0xB93770", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xB937E0", Offset = "0xB937E0", VA = "0xB937E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xB939DC", Offset = "0xB939DC", VA = "0xB939DC")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xB92388", Offset = "0xB92388", VA = "0xB92388")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xB9246C", Offset = "0xB9246C", VA = "0xB9246C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xB927B4", Offset = "0xB927B4", VA = "0xB927B4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xB92D60", Offset = "0xB92D60", VA = "0xB92D60")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xB93C4C", Offset = "0xB93C4C", VA = "0xB93C4C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xB93C88", Offset = "0xB93C88", VA = "0xB93C88", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xB95224", Offset = "0xB95224", VA = "0xB95224")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xB92EB0", Offset = "0xB92EB0", VA = "0xB92EB0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xB94094", Offset = "0xB94094", VA = "0xB94094")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xB95678", Offset = "0xB95678", VA = "0xB95678")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xB956B4", Offset = "0xB956B4", VA = "0xB956B4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xB950E8", Offset = "0xB950E8", VA = "0xB950E8")]
		private void Write()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xB96E2C", Offset = "0xB96E2C", VA = "0xB96E2C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xB97528", Offset = "0xB97528", VA = "0xB97528")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform child;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xBA2D80", Offset = "0xBA2D80", VA = "0xBA2D80")]
		public void Relax()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xBA31C4", Offset = "0xBA31C4", VA = "0xBA31C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xBA3564", Offset = "0xBA3564", VA = "0xBA3564")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xBA35DC", Offset = "0xBA35DC", VA = "0xBA35DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xBA3654", Offset = "0xBA3654", VA = "0xBA3654")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xBA376C", Offset = "0xBA376C", VA = "0xBA376C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000082")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xBA380C", Offset = "0xBA380C", VA = "0xBA380C")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xBA3814", Offset = "0xBA3814", VA = "0xBA3814")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool isPaused
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xBA381C", Offset = "0xBA381C", VA = "0xBA381C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xBA3824", Offset = "0xBA3824", VA = "0xBA3824")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xBA3830", Offset = "0xBA3830", VA = "0xBA3830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xBA3838", Offset = "0xBA3838", VA = "0xBA3838")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool inInteraction
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xBA3840", Offset = "0xBA3840", VA = "0xBA3840")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public float progress
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xBA5D5C", Offset = "0xBA5D5C", VA = "0xBA5D5C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xBA38A0", Offset = "0xBA38A0", VA = "0xBA38A0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xBA3930", Offset = "0xBA3930", VA = "0xBA3930")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xBA39C4", Offset = "0xBA39C4", VA = "0xBA39C4")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xBA3B30", Offset = "0xBA3B30", VA = "0xBA3B30")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xBA3F0C", Offset = "0xBA3F0C", VA = "0xBA3F0C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xBA402C", Offset = "0xBA402C", VA = "0xBA402C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xBA4080", Offset = "0xBA4080", VA = "0xBA4080")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xBA4B88", Offset = "0xBA4B88", VA = "0xBA4B88")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xBA55D0", Offset = "0xBA55D0", VA = "0xBA55D0")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xBA57F0", Offset = "0xBA57F0", VA = "0xBA57F0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xBA5C14", Offset = "0xBA5C14", VA = "0xBA5C14")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xBA5F5C", Offset = "0xBA5F5C", VA = "0xBA5F5C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xBA6198", Offset = "0xBA6198", VA = "0xBA6198")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xBA62A8", Offset = "0xBA62A8", VA = "0xBA62A8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xBA6340", Offset = "0xBA6340", VA = "0xBA6340")]
		public void Update()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xBA6530", Offset = "0xBA6530", VA = "0xBA6530")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xBA65D8", Offset = "0xBA65D8", VA = "0xBA65D8")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xBA6684", Offset = "0xBA6684", VA = "0xBA6684")]
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
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xBA5D8C", Offset = "0xBA5D8C", VA = "0xBA5D8C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xBA7614", Offset = "0xBA7614", VA = "0xBA7614")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class Message
		{
			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x400045E")]
			private const string empty = "";

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xBA751C", Offset = "0xBA751C", VA = "0xBA751C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xBA761C", Offset = "0xBA761C", VA = "0xBA761C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000465")]
			private const string empty = "";

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xBA7440", Offset = "0xBA7440", VA = "0xBA7440")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xBA7624", Offset = "0xBA7624", VA = "0xBA7624")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xBA76D4", Offset = "0xBA76D4", VA = "0xBA76D4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xBA77AC", Offset = "0xBA77AC", VA = "0xBA77AC")]
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
				[Token(Token = "0x4000469")]
				PositionWeight,
				[Token(Token = "0x400046A")]
				RotationWeight,
				[Token(Token = "0x400046B")]
				PositionOffsetX,
				[Token(Token = "0x400046C")]
				PositionOffsetY,
				[Token(Token = "0x400046D")]
				PositionOffsetZ,
				[Token(Token = "0x400046E")]
				Pull,
				[Token(Token = "0x400046F")]
				Reach,
				[Token(Token = "0x4000470")]
				RotateBoneWeight,
				[Token(Token = "0x4000471")]
				Push,
				[Token(Token = "0x4000472")]
				PushParent,
				[Token(Token = "0x4000473")]
				PoserWeight,
				[Token(Token = "0x4000474")]
				BendGoalWeight
			}

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xBA6D50", Offset = "0xBA6D50", VA = "0xBA6D50")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xBA77C0", Offset = "0xBA77C0", VA = "0xBA77C0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class Multiplier
		{
			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xBA7358", Offset = "0xBA7358", VA = "0xBA7358")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xBA77C8", Offset = "0xBA77C8", VA = "0xBA77C8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000087")]
		public float length
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xBA68B8", Offset = "0xBA68B8", VA = "0xBA68B8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xBA68C0", Offset = "0xBA68C0", VA = "0xBA68C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xBA68C8", Offset = "0xBA68C8", VA = "0xBA68C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xBA68D0", Offset = "0xBA68D0", VA = "0xBA68D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xBA6A88", Offset = "0xBA6A88", VA = "0xBA6A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xBA5E50", Offset = "0xBA5E50", VA = "0xBA5E50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xBA6698", Offset = "0xBA6698", VA = "0xBA6698")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xBA66DC", Offset = "0xBA66DC", VA = "0xBA66DC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xBA6720", Offset = "0xBA6720", VA = "0xBA6720")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xBA6764", Offset = "0xBA6764", VA = "0xBA6764")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xBA67A8", Offset = "0xBA67A8", VA = "0xBA67A8")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xBA67EC", Offset = "0xBA67EC", VA = "0xBA67EC")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xBA6830", Offset = "0xBA6830", VA = "0xBA6830")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xBA6874", Offset = "0xBA6874", VA = "0xBA6874")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xBA68D8", Offset = "0xBA68D8", VA = "0xBA68D8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xBA6B08", Offset = "0xBA6B08", VA = "0xBA6B08")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xBA4650", Offset = "0xBA4650", VA = "0xBA4650")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xBA6C80", Offset = "0xBA6C80", VA = "0xBA6C80")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xBA450C", Offset = "0xBA450C", VA = "0xBA450C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xBA4648", Offset = "0xBA4648", VA = "0xBA4648")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xBA51C8", Offset = "0xBA51C8", VA = "0xBA51C8")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xBA5A08", Offset = "0xBA5A08", VA = "0xBA5A08")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xBA7388", Offset = "0xBA7388", VA = "0xBA7388")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xBA6D6C", Offset = "0xBA6D6C", VA = "0xBA6D6C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xBA6C88", Offset = "0xBA6C88", VA = "0xBA6C88")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xBA72FC", Offset = "0xBA72FC", VA = "0xBA72FC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xBA738C", Offset = "0xBA738C", VA = "0xBA738C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xBA73E8", Offset = "0xBA73E8", VA = "0xBA73E8")]
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

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008B")]
		public bool inInteraction
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xBA79F8", Offset = "0xBA79F8", VA = "0xBA79F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xBA9458", Offset = "0xBA9458", VA = "0xBA9458")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0xBA9460", Offset = "0xBA9460", VA = "0xBA9460")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0xBA9468", Offset = "0xBA9468", VA = "0xBA9468")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xBA9470", Offset = "0xBA9470", VA = "0xBA9470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xBA77D8", Offset = "0xBA77D8", VA = "0xBA77D8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xBA781C", Offset = "0xBA781C", VA = "0xBA781C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xBA7860", Offset = "0xBA7860", VA = "0xBA7860")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xBA78A4", Offset = "0xBA78A4", VA = "0xBA78A4")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xBA78E8", Offset = "0xBA78E8", VA = "0xBA78E8")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xBA792C", Offset = "0xBA792C", VA = "0xBA792C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xBA7970", Offset = "0xBA7970", VA = "0xBA7970")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xBA79B4", Offset = "0xBA79B4", VA = "0xBA79B4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xBA7B70", Offset = "0xBA7B70", VA = "0xBA7B70")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xBA7C28", Offset = "0xBA7C28", VA = "0xBA7C28")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xBA7CE0", Offset = "0xBA7CE0", VA = "0xBA7CE0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xBA7D78", Offset = "0xBA7D78", VA = "0xBA7D78")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xBA7E5C", Offset = "0xBA7E5C", VA = "0xBA7E5C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xBA7F54", Offset = "0xBA7F54", VA = "0xBA7F54")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xBA7FD8", Offset = "0xBA7FD8", VA = "0xBA7FD8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xBA805C", Offset = "0xBA805C", VA = "0xBA805C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xBA80E0", Offset = "0xBA80E0", VA = "0xBA80E0")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xBA8148", Offset = "0xBA8148", VA = "0xBA8148")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xBA81B0", Offset = "0xBA81B0", VA = "0xBA81B0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xBA820C", Offset = "0xBA820C", VA = "0xBA820C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xBA828C", Offset = "0xBA828C", VA = "0xBA828C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xBA8334", Offset = "0xBA8334", VA = "0xBA8334")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xBA8404", Offset = "0xBA8404", VA = "0xBA8404")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xBA8694", Offset = "0xBA8694", VA = "0xBA8694")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xBA8850", Offset = "0xBA8850", VA = "0xBA8850")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xBA8AB8", Offset = "0xBA8AB8", VA = "0xBA8AB8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xBA8D44", Offset = "0xBA8D44", VA = "0xBA8D44")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xBA8D7C", Offset = "0xBA8D7C", VA = "0xBA8D7C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xBA8DDC", Offset = "0xBA8DDC", VA = "0xBA8DDC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xBA8EE4", Offset = "0xBA8EE4", VA = "0xBA8EE4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xBA90C4", Offset = "0xBA90C4", VA = "0xBA90C4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xBA9338", Offset = "0xBA9338", VA = "0xBA9338")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xBA8BA0", Offset = "0xBA8BA0", VA = "0xBA8BA0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xBA9478", Offset = "0xBA9478", VA = "0xBA9478")]
		public void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xBA9CC4", Offset = "0xBA9CC4", VA = "0xBA9CC4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xBA9CE4", Offset = "0xBA9CE4", VA = "0xBA9CE4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xBA9D00", Offset = "0xBA9D00", VA = "0xBA9D00")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xBA9D1C", Offset = "0xBA9D1C", VA = "0xBA9D1C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xBA9D70", Offset = "0xBA9D70", VA = "0xBA9D70")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xBA9EDC", Offset = "0xBA9EDC", VA = "0xBA9EDC")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xBA9FD8", Offset = "0xBA9FD8", VA = "0xBA9FD8")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xBAA334", Offset = "0xBAA334", VA = "0xBAA334")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xBAA418", Offset = "0xBAA418", VA = "0xBAA418")]
		public void Update()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xBAA6FC", Offset = "0xBAA6FC", VA = "0xBAA6FC")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xBA9A7C", Offset = "0xBA9A7C", VA = "0xBA9A7C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xBAA82C", Offset = "0xBAA82C", VA = "0xBAA82C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xBAA938", Offset = "0xBAA938", VA = "0xBAA938")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xBAA9C0", Offset = "0xBAA9C0", VA = "0xBAA9C0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xBAAA80", Offset = "0xBAAA80", VA = "0xBAAA80")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xBAAA98", Offset = "0xBAAA98", VA = "0xBAAA98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xBA7A90", Offset = "0xBA7A90", VA = "0xBA7A90")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xBA8580", Offset = "0xBA8580", VA = "0xBA8580")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xBAAE80", Offset = "0xBAAE80", VA = "0xBAAE80")]
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
			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xBAB6E0", Offset = "0xBAB6E0", VA = "0xBAB6E0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xBAB450", Offset = "0xBAB450", VA = "0xBAB450")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xBAB494", Offset = "0xBAB494", VA = "0xBAB494")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xBAB4D8", Offset = "0xBAB4D8", VA = "0xBAB4D8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xBAB51C", Offset = "0xBAB51C", VA = "0xBAB51C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xBAB560", Offset = "0xBAB560", VA = "0xBAB560")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xBAB5A4", Offset = "0xBAB5A4", VA = "0xBAB5A4")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xBAB5E8", Offset = "0xBAB5E8", VA = "0xBAB5E8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xBAB62C", Offset = "0xBAB62C", VA = "0xBAB62C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xBA6CEC", Offset = "0xBA6CEC", VA = "0xBA6CEC")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xBA5ED0", Offset = "0xBA5ED0", VA = "0xBA5ED0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xBA46E4", Offset = "0xBA46E4", VA = "0xBA46E4")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xBAB670", Offset = "0xBAB670", VA = "0xBAB670")]
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
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000539")]
				[Address(RVA = "0xBAB948", Offset = "0xBAB948", VA = "0xBAB948")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0xBAB954", Offset = "0xBAB954", VA = "0xBAB954")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0xBABA14", Offset = "0xBABA14", VA = "0xBABA14")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0xBAC178", Offset = "0xBAC178", VA = "0xBAC178")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class CameraPosition
		{
			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600053D")]
			[Address(RVA = "0xBAC18C", Offset = "0xBAC18C", VA = "0xBAC18C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0xBAC304", Offset = "0xBAC304", VA = "0xBAC304")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0xBAC60C", Offset = "0xBAC60C", VA = "0xBAC60C")]
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
				[Token(Token = "0x40004AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000542")]
				[Address(RVA = "0xBAC690", Offset = "0xBAC690", VA = "0xBAC690")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x6000540")]
			[Address(RVA = "0xBAB840", Offset = "0xBAB840", VA = "0xBAB840")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0xBAC680", Offset = "0xBAC680", VA = "0xBAC680")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xBAB6E8", Offset = "0xBAB6E8", VA = "0xBAB6E8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xBAB72C", Offset = "0xBAB72C", VA = "0xBAB72C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xBAB770", Offset = "0xBAB770", VA = "0xBAB770")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xBAB7B4", Offset = "0xBAB7B4", VA = "0xBAB7B4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xBAB7F8", Offset = "0xBAB7F8", VA = "0xBAB7F8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xBAB83C", Offset = "0xBAB83C", VA = "0xBAB83C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xBAA180", Offset = "0xBAA180", VA = "0xBAA180")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xBAB8F0", Offset = "0xBAB8F0", VA = "0xBAB8F0")]
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
			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600054A")]
			[Address(RVA = "0xBAC984", Offset = "0xBAC984", VA = "0xBAC984")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xBACCC0", Offset = "0xBACCC0", VA = "0xBACCC0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0xBACC80", Offset = "0xBACC80", VA = "0xBACC80")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0xBACB04", Offset = "0xBACB04", VA = "0xBACB04")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xBAC698", Offset = "0xBAC698", VA = "0xBAC698", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xBACA10", Offset = "0xBACA10", VA = "0xBACA10", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xBACA14", Offset = "0xBACA14", VA = "0xBACA14", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xBACC24", Offset = "0xBACC24", VA = "0xBACC24", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xBAC9B4", Offset = "0xBAC9B4", VA = "0xBAC9B4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xBAC8F0", Offset = "0xBAC8F0", VA = "0xBAC8F0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xBACD04", Offset = "0xBACD04", VA = "0xBACD04")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xBACD24", Offset = "0xBACD24", VA = "0xBACD24", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xBACDE0", Offset = "0xBACDE0", VA = "0xBACDE0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xBACF84", Offset = "0xBACF84", VA = "0xBACF84", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xBAD06C", Offset = "0xBAD06C", VA = "0xBAD06C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xBACE34", Offset = "0xBACE34", VA = "0xBACE34")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xBAD39C", Offset = "0xBAD39C", VA = "0xBAD39C")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000554")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xBAD3AC", Offset = "0xBAD3AC", VA = "0xBAD3AC")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000556")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000557")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000558")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xBAD3B8", Offset = "0xBAD3B8", VA = "0xBAD3B8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xBAD3FC", Offset = "0xBAD3FC", VA = "0xBAD3FC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xBAD428", Offset = "0xBAD428", VA = "0xBAD428", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xBACD14", Offset = "0xBACD14", VA = "0xBACD14")]
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
			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xBAE340", Offset = "0xBAE340", VA = "0xBAE340")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0xBAE494", Offset = "0xBAE494", VA = "0xBAE494")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xBAE568", Offset = "0xBAE568", VA = "0xBAE568")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009B")]
		public class Child
		{
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000572")]
			[Address(RVA = "0xBAE7A8", Offset = "0xBAE7A8", VA = "0xBAE7A8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0xBAE804", Offset = "0xBAE804", VA = "0xBAE804")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0xBAE914", Offset = "0xBAE914", VA = "0xBAE914")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0xBAEB64", Offset = "0xBAEB64", VA = "0xBAEB64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0xBAEBAC", Offset = "0xBAEBAC", VA = "0xBAEBAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0xBAE958", Offset = "0xBAE958", VA = "0xBAE958")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0xBAE980", Offset = "0xBAE980", VA = "0xBAE980", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0xBAE984", Offset = "0xBAE984", VA = "0xBAE984", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0xBAEB6C", Offset = "0xBAEB6C", VA = "0xBAEB6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000090")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xBAD46C", Offset = "0xBAD46C", VA = "0xBAD46C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ikUsed
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xBADD5C", Offset = "0xBADD5C", VA = "0xBADD5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xBAD440", Offset = "0xBAD440", VA = "0xBAD440")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xBAD4D0", Offset = "0xBAD4D0", VA = "0xBAD4D0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xBAD5E0", Offset = "0xBAD5E0", VA = "0xBAD5E0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xBAD578", Offset = "0xBAD578", VA = "0xBAD578")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xBAD9F4", Offset = "0xBAD9F4", VA = "0xBAD9F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xBADC1C", Offset = "0xBADC1C", VA = "0xBADC1C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xBADCC0", Offset = "0xBADCC0", VA = "0xBADCC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xBADEB0", Offset = "0xBADEB0", VA = "0xBADEB0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xBADD30", Offset = "0xBADD30", VA = "0xBADD30")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xBADE7C", Offset = "0xBADE7C", VA = "0xBADE7C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xBADF34", Offset = "0xBADF34", VA = "0xBADF34")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xBADED4", Offset = "0xBADED4", VA = "0xBADED4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xBAD518", Offset = "0xBAD518", VA = "0xBAD518")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xBADC50", Offset = "0xBADC50", VA = "0xBADC50")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xBAE130", Offset = "0xBAE130", VA = "0xBAE130")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xBAE248", Offset = "0xBAE248", VA = "0xBAE248")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000094")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xBAF018", Offset = "0xBAF018", VA = "0xBAF018")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xBAF024", Offset = "0xBAF024", VA = "0xBAF024")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xBAF054", Offset = "0xBAF054", VA = "0xBAF054")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xBAF05C", Offset = "0xBAF05C", VA = "0xBAF05C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xBAEBB4", Offset = "0xBAEBB4", VA = "0xBAEBB4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xBAEBF0", Offset = "0xBAEBF0", VA = "0xBAEBF0")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xBAEC08", Offset = "0xBAEC08", VA = "0xBAEC08")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xBAEF88", Offset = "0xBAEF88", VA = "0xBAEF88")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xBAEFEC", Offset = "0xBAEFEC", VA = "0xBAEFEC")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000584")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xBAEE8C", Offset = "0xBAEE8C", VA = "0xBAEE8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xBAF068", Offset = "0xBAF068", VA = "0xBAF068")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xBAF06C", Offset = "0xBAF06C", VA = "0xBAF06C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xBAF094", Offset = "0xBAF094", VA = "0xBAF094")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xBAF168", Offset = "0xBAF168", VA = "0xBAF168")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xBAF3C0", Offset = "0xBAF3C0", VA = "0xBAF3C0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xBAF514", Offset = "0xBAF514", VA = "0xBAF514")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xBAF574", Offset = "0xBAF574", VA = "0xBAF574")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xBAF5B8", Offset = "0xBAF5B8", VA = "0xBAF5B8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xBAF5FC", Offset = "0xBAF5FC", VA = "0xBAF5FC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xBAF640", Offset = "0xBAF640", VA = "0xBAF640")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xBAF684", Offset = "0xBAF684", VA = "0xBAF684", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xBAF6BC", Offset = "0xBAF6BC", VA = "0xBAF6BC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xBAF9E0", Offset = "0xBAF9E0", VA = "0xBAF9E0")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xBAF9F0", Offset = "0xBAF9F0", VA = "0xBAF9F0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xBAFA34", Offset = "0xBAFA34", VA = "0xBAFA34")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xBAFA78", Offset = "0xBAFA78", VA = "0xBAFA78")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xBAFABC", Offset = "0xBAFABC", VA = "0xBAFABC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xBAFB00", Offset = "0xBAFB00", VA = "0xBAFB00", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xBAFB1C", Offset = "0xBAFB1C", VA = "0xBAFB1C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xBAFD64", Offset = "0xBAFD64", VA = "0xBAFD64")]
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
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000097")]
			public Vector3 o
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0xBB1AF8", Offset = "0xBB1AF8", VA = "0xBB1AF8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 a
			{
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0xBB1B24", Offset = "0xBB1B24", VA = "0xBB1B24")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 b
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0xBB1B54", Offset = "0xBB1B54", VA = "0xBB1B54")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 c
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0xBB1B84", Offset = "0xBB1B84", VA = "0xBB1B84")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isValid
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0xBB1040", Offset = "0xBB1040", VA = "0xBB1040")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xBB14E4", Offset = "0xBB14E4", VA = "0xBB14E4")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xBB1648", Offset = "0xBB1648", VA = "0xBB1648")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class LimitPoint
		{
			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xBB1050", Offset = "0xBB1050", VA = "0xBB1050")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xBAFDC8", Offset = "0xBAFDC8", VA = "0xBAFDC8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xBAFE0C", Offset = "0xBAFE0C", VA = "0xBAFE0C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xBAFE50", Offset = "0xBAFE50", VA = "0xBAFE50")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xBAFE94", Offset = "0xBAFE94", VA = "0xBAFE94")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xBAFED8", Offset = "0xBAFED8", VA = "0xBAFED8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xBB0510", Offset = "0xBB0510", VA = "0xBB0510", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xBB0598", Offset = "0xBB0598", VA = "0xBB0598")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xBB0B78", Offset = "0xBB0B78", VA = "0xBB0B78")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xBAFF64", Offset = "0xBAFF64", VA = "0xBAFF64")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xBB10B4", Offset = "0xBB10B4", VA = "0xBB10B4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xBB18BC", Offset = "0xBB18BC", VA = "0xBB18BC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xBB1904", Offset = "0xBB1904", VA = "0xBB1904")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xBB1964", Offset = "0xBB1964", VA = "0xBB1964")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xBB08D4", Offset = "0xBB08D4", VA = "0xBB08D4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xBB19D0", Offset = "0xBB19D0", VA = "0xBB19D0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xBB1A9C", Offset = "0xBB1A9C", VA = "0xBB1A9C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xBB1BB4", Offset = "0xBB1BB4", VA = "0xBB1BB4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xBB1BF8", Offset = "0xBB1BF8", VA = "0xBB1BF8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xBB1C3C", Offset = "0xBB1C3C", VA = "0xBB1C3C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xBB1C80", Offset = "0xBB1C80", VA = "0xBB1C80")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xBB1CC4", Offset = "0xBB1CC4", VA = "0xBB1CC4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xBB1CE0", Offset = "0xBB1CE0", VA = "0xBB1CE0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xBB1D18", Offset = "0xBB1D18", VA = "0xBB1D18")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xBB20C4", Offset = "0xBB20C4", VA = "0xBB20C4")]
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
			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0xBB2D80", Offset = "0xBB2D80", VA = "0xBB2D80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0xBB2DC8", Offset = "0xBB2DC8", VA = "0xBB2DC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xBB2B8C", Offset = "0xBB2B8C", VA = "0xBB2B8C")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xBB2C98", Offset = "0xBB2C98", VA = "0xBB2C98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xBB2C9C", Offset = "0xBB2C9C", VA = "0xBB2C9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xBB2D88", Offset = "0xBB2D88", VA = "0xBB2D88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700009C")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xBB214C", Offset = "0xBB214C", VA = "0xBB214C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xBB20D0", Offset = "0xBB20D0", VA = "0xBB20D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xBB21D0", Offset = "0xBB21D0", VA = "0xBB21D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xBB26FC", Offset = "0xBB26FC", VA = "0xBB26FC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xBB2880", Offset = "0xBB2880", VA = "0xBB2880")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xBB2B24", Offset = "0xBB2B24", VA = "0xBB2B24")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__33))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xBB2BB4", Offset = "0xBB2BB4", VA = "0xBB2BB4")]
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
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xBB2EA0", Offset = "0xBB2EA0", VA = "0xBB2EA0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xBB3410", Offset = "0xBB3410", VA = "0xBB3410")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xBB3418", Offset = "0xBB3418", VA = "0xBB3418")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xBB2DD0", Offset = "0xBB2DD0", VA = "0xBB2DD0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xBB3350", Offset = "0xBB3350", VA = "0xBB3350")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xBB33B0", Offset = "0xBB33B0", VA = "0xBB33B0")]
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
				[Token(Token = "0x400052B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400052C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60005D2")]
				[Address(RVA = "0xBB38DC", Offset = "0xBB38DC", VA = "0xBB38DC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xBB3584", Offset = "0xBB3584", VA = "0xBB3584")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xBB38B4", Offset = "0xBB38B4", VA = "0xBB38B4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xBB38C4", Offset = "0xBB38C4", VA = "0xBB38C4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xBB3434", Offset = "0xBB3434", VA = "0xBB3434", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xBB3894", Offset = "0xBB3894", VA = "0xBB3894")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xBB38E4", Offset = "0xBB38E4", VA = "0xBB38E4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xBB394C", Offset = "0xBB394C", VA = "0xBB394C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xBB3BEC", Offset = "0xBB3BEC", VA = "0xBB3BEC")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xBB3C08", Offset = "0xBB3C08", VA = "0xBB3C08")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xBB3C94", Offset = "0xBB3C94", VA = "0xBB3C94")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xBB3D54", Offset = "0xBB3D54", VA = "0xBB3D54")]
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
			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A0")]
			public bool inProgress
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0xBB3DF8", Offset = "0xBB3DF8", VA = "0xBB3DF8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A1")]
			protected float crossFader
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0xBB42F8", Offset = "0xBB42F8", VA = "0xBB42F8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0xBB4300", Offset = "0xBB4300", VA = "0xBB4300")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected float timer
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0xBB4308", Offset = "0xBB4308", VA = "0xBB4308")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0xBB4310", Offset = "0xBB4310", VA = "0xBB4310")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 force
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0xBB4318", Offset = "0xBB4318", VA = "0xBB4318")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0xBB4324", Offset = "0xBB4324", VA = "0xBB4324")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected Vector3 point
			{
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0xBB4330", Offset = "0xBB4330", VA = "0xBB4330")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0xBB433C", Offset = "0xBB433C", VA = "0xBB433C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xBB41C0", Offset = "0xBB41C0", VA = "0xBB41C0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xBB3ECC", Offset = "0xBB3ECC", VA = "0xBB3ECC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E8")]
			protected abstract float GetLength();

			[Token(Token = "0x60005E9")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005EA")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xBB4348", Offset = "0xBB4348", VA = "0xBB4348")]
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
				[Token(Token = "0x4000543")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000545")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000546")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005F0")]
				[Address(RVA = "0xBB467C", Offset = "0xBB467C", VA = "0xBB467C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F1")]
				[Address(RVA = "0xBB44D8", Offset = "0xBB44D8", VA = "0xBB44D8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F2")]
				[Address(RVA = "0xBB472C", Offset = "0xBB472C", VA = "0xBB472C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xBB435C", Offset = "0xBB435C", VA = "0xBB435C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xBB4478", Offset = "0xBB4478", VA = "0xBB4478", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xBB44EC", Offset = "0xBB44EC", VA = "0xBB44EC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xBB4718", Offset = "0xBB4718", VA = "0xBB4718")]
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
				[Token(Token = "0x400054A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x400054B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x400054C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400054D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005F7")]
				[Address(RVA = "0xBB49EC", Offset = "0xBB49EC", VA = "0xBB49EC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F8")]
				[Address(RVA = "0xBB4818", Offset = "0xBB4818", VA = "0xBB4818")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F9")]
				[Address(RVA = "0xBB4B8C", Offset = "0xBB4B8C", VA = "0xBB4B8C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xBB4734", Offset = "0xBB4734", VA = "0xBB4734", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xBB47C0", Offset = "0xBB47C0", VA = "0xBB47C0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xBB4824", Offset = "0xBB4824", VA = "0xBB4824", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xBB4B78", Offset = "0xBB4B78", VA = "0xBB4B78")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009F")]
		public bool inProgress
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xBB3D5C", Offset = "0xBB3D5C", VA = "0xBB3D5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xBB3E0C", Offset = "0xBB3E0C", VA = "0xBB3E0C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xBB3FA4", Offset = "0xBB3FA4", VA = "0xBB3FA4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xBB42E8", Offset = "0xBB42E8", VA = "0xBB42E8")]
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
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A5")]
			protected float crossFader
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0xBB50FC", Offset = "0xBB50FC", VA = "0xBB50FC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0xBB5104", Offset = "0xBB5104", VA = "0xBB5104")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected float timer
			{
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0xBB510C", Offset = "0xBB510C", VA = "0xBB510C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000600")]
				[Address(RVA = "0xBB5114", Offset = "0xBB5114", VA = "0xBB5114")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000601")]
				[Address(RVA = "0xBB511C", Offset = "0xBB511C", VA = "0xBB511C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000602")]
				[Address(RVA = "0xBB5128", Offset = "0xBB5128", VA = "0xBB5128")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000603")]
				[Address(RVA = "0xBB5134", Offset = "0xBB5134", VA = "0xBB5134")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000604")]
				[Address(RVA = "0xBB5140", Offset = "0xBB5140", VA = "0xBB5140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xBB4FAC", Offset = "0xBB4FAC", VA = "0xBB4FAC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xBB4CA8", Offset = "0xBB4CA8", VA = "0xBB4CA8")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000607")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000608")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000609")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600060A")]
			[Address(RVA = "0xBB514C", Offset = "0xBB514C", VA = "0xBB514C")]
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
				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000560")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000561")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600060F")]
				[Address(RVA = "0xBB5530", Offset = "0xBB5530", VA = "0xBB5530")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0xBB5354", Offset = "0xBB5354", VA = "0xBB5354")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000611")]
				[Address(RVA = "0xBB55C4", Offset = "0xBB55C4", VA = "0xBB55C4")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600060B")]
			[Address(RVA = "0xBB5160", Offset = "0xBB5160", VA = "0xBB5160", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0xBB52F4", Offset = "0xBB52F4", VA = "0xBB52F4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0xBB5368", Offset = "0xBB5368", VA = "0xBB5368", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xBB55A8", Offset = "0xBB55A8", VA = "0xBB55A8")]
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
				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000567")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000568")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000616")]
				[Address(RVA = "0xBB5984", Offset = "0xBB5984", VA = "0xBB5984")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000617")]
				[Address(RVA = "0xBB56FC", Offset = "0xBB56FC", VA = "0xBB56FC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000618")]
				[Address(RVA = "0xBB5AA0", Offset = "0xBB5AA0", VA = "0xBB5AA0")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000612")]
			[Address(RVA = "0xBB55CC", Offset = "0xBB55CC", VA = "0xBB55CC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0xBB56A4", Offset = "0xBB56A4", VA = "0xBB56A4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0xBB5708", Offset = "0xBB5708", VA = "0xBB5708", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0xBB5A8C", Offset = "0xBB5A8C", VA = "0xBB5A8C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xBB4BF0", Offset = "0xBB4BF0", VA = "0xBB4BF0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xBB4D88", Offset = "0xBB4D88", VA = "0xBB4D88")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xBB50DC", Offset = "0xBB50DC", VA = "0xBB50DC")]
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
				[Token(Token = "0x4000576")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000577")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x600061F")]
				[Address(RVA = "0xBB6068", Offset = "0xBB6068", VA = "0xBB6068")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600061C")]
			[Address(RVA = "0xBB5B70", Offset = "0xBB5B70", VA = "0xBB5B70")]
			public void Reset()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0xBB5CF0", Offset = "0xBB5CF0", VA = "0xBB5CF0")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0xBB604C", Offset = "0xBB604C", VA = "0xBB604C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xBB5B04", Offset = "0xBB5B04", VA = "0xBB5B04")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xBB5C4C", Offset = "0xBB5C4C", VA = "0xBB5C4C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xBB603C", Offset = "0xBB603C", VA = "0xBB603C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000A9")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xBB60D8", Offset = "0xBB60D8", VA = "0xBB60D8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xBB6070", Offset = "0xBB6070", VA = "0xBB6070")]
		private void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xBB615C", Offset = "0xBB615C", VA = "0xBB615C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xBB6644", Offset = "0xBB6644", VA = "0xBB6644")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xBB67C8", Offset = "0xBB67C8", VA = "0xBB67C8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xBB6A14", Offset = "0xBB6A14", VA = "0xBB6A14")]
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
			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x600062E")]
			[Address(RVA = "0xBB6C10", Offset = "0xBB6C10", VA = "0xBB6C10")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0xBB6E80", Offset = "0xBB6E80", VA = "0xBB6E80")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0xBB6EF0", Offset = "0xBB6EF0", VA = "0xBB6EF0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0xBB6F38", Offset = "0xBB6F38", VA = "0xBB6F38")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0xBB7094", Offset = "0xBB7094", VA = "0xBB7094", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0xBB70DC", Offset = "0xBB70DC", VA = "0xBB70DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0xBB6B14", Offset = "0xBB6B14", VA = "0xBB6B14")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0xBB6F40", Offset = "0xBB6F40", VA = "0xBB6F40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0xBB6F44", Offset = "0xBB6F44", VA = "0xBB6F44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0xBB709C", Offset = "0xBB709C", VA = "0xBB709C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AA")]
		protected float deltaTime
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0xBB3564", Offset = "0xBB3564", VA = "0xBB3564")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000627")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xBB392C", Offset = "0xBB392C", VA = "0xBB392C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xBB6AAC", Offset = "0xBB6AAC", VA = "0xBB6AAC")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xBB6B3C", Offset = "0xBB6B3C", VA = "0xBB6B3C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xBB5F94", Offset = "0xBB5F94", VA = "0xBB5F94")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xBB6D74", Offset = "0xBB6D74", VA = "0xBB6D74", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xBB38A4", Offset = "0xBB38A4", VA = "0xBB38A4")]
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
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000642")]
				[Address(RVA = "0xBB74E8", Offset = "0xBB74E8", VA = "0xBB74E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000644")]
				[Address(RVA = "0xBB7530", Offset = "0xBB7530", VA = "0xBB7530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xBB718C", Offset = "0xBB718C", VA = "0xBB718C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xBB7394", Offset = "0xBB7394", VA = "0xBB7394", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0xBB7398", Offset = "0xBB7398", VA = "0xBB7398", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0xBB74F0", Offset = "0xBB74F0", VA = "0xBB74F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AD")]
		protected float deltaTime
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0xBB70E4", Offset = "0xBB70E4", VA = "0xBB70E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000639")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xBB7104", Offset = "0xBB7104", VA = "0xBB7104", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xBB7124", Offset = "0xBB7124", VA = "0xBB7124")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xBB71B4", Offset = "0xBB71B4", VA = "0xBB71B4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xBB7288", Offset = "0xBB7288", VA = "0xBB7288", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xBB50EC", Offset = "0xBB50EC", VA = "0xBB50EC")]
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
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xBB7538", Offset = "0xBB7538", VA = "0xBB7538")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0xBB7884", Offset = "0xBB7884", VA = "0xBB7884")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xBB3B38", Offset = "0xBB3B38", VA = "0xBB3B38")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xBB7788", Offset = "0xBB7788", VA = "0xBB7788")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xBB782C", Offset = "0xBB782C", VA = "0xBB782C")]
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
				[Token(Token = "0x40005B3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x6000650")]
				[Address(RVA = "0xBB7ED8", Offset = "0xBB7ED8", VA = "0xBB7ED8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600064C")]
			[Address(RVA = "0xBB78FC", Offset = "0xBB78FC", VA = "0xBB78FC")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xBB7A9C", Offset = "0xBB7A9C", VA = "0xBB7A9C")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xBB7BA4", Offset = "0xBB7BA4", VA = "0xBB7BA4")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xBB7EC4", Offset = "0xBB7EC4", VA = "0xBB7EC4")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xBB788C", Offset = "0xBB788C", VA = "0xBB788C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xBB7A8C", Offset = "0xBB7A8C", VA = "0xBB7A8C")]
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
				[Token(Token = "0x40005D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000660")]
				[Address(RVA = "0xBB922C", Offset = "0xBB922C", VA = "0xBB922C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xBB807C", Offset = "0xBB807C", VA = "0xBB807C")]
			public void Start()
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xBB8BD8", Offset = "0xBB8BD8", VA = "0xBB8BD8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0xBB9218", Offset = "0xBB9218", VA = "0xBB9218")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public enum Handedness
		{
			[Token(Token = "0x40005D5")]
			Right,
			[Token(Token = "0x40005D6")]
			Left
		}

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B0")]
		public bool isFinished
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xBB7EE0", Offset = "0xBB7EE0", VA = "0xBB7EE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0xBB8DDC", Offset = "0xBB8DDC", VA = "0xBB8DDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xBB8E18", Offset = "0xBB8E18", VA = "0xBB8E18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xBB8DA4", Offset = "0xBB8DA4", VA = "0xBB8DA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xBB8DC0", Offset = "0xBB8DC0", VA = "0xBB8DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xBB7F04", Offset = "0xBB7F04", VA = "0xBB7F04")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xBB7F30", Offset = "0xBB7F30", VA = "0xBB7F30")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xBB8150", Offset = "0xBB8150", VA = "0xBB8150", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xBB8E54", Offset = "0xBB8E54", VA = "0xBB8E54")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xBB8F6C", Offset = "0xBB8F6C", VA = "0xBB8F6C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xBB8FBC", Offset = "0xBB8FBC", VA = "0xBB8FBC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xBB918C", Offset = "0xBB918C", VA = "0xBB918C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xBB9234", Offset = "0xBB9234", VA = "0xBB9234")]
		private void Start()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xBB9324", Offset = "0xBB9324", VA = "0xBB9324")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xBB9400", Offset = "0xBB9400", VA = "0xBB9400")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xBB9804", Offset = "0xBB9804", VA = "0xBB9804")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xBB9838", Offset = "0xBB9838", VA = "0xBB9838")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xBB9944", Offset = "0xBB9944", VA = "0xBB9944")]
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
			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x600066C")]
			[Address(RVA = "0xBBC2B0", Offset = "0xBBC2B0", VA = "0xBBC2B0")]
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
				[Token(Token = "0x40005F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40005F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40005F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x600066E")]
				[Address(RVA = "0xBBB508", Offset = "0xBBB508", VA = "0xBBB508")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600066F")]
				[Address(RVA = "0xBBBEB0", Offset = "0xBBBEB0", VA = "0xBBBEB0")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600066D")]
			[Address(RVA = "0xBBAC88", Offset = "0xBBAC88", VA = "0xBBAC88")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xBB9958", Offset = "0xBB9958", VA = "0xBB9958")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xBB9A4C", Offset = "0xBB9A4C", VA = "0xBB9A4C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xBBAC90", Offset = "0xBBAC90", VA = "0xBBAC90")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xBBB5BC", Offset = "0xBBB5BC", VA = "0xBBB5BC")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xBBBF0C", Offset = "0xBBBF0C", VA = "0xBBBF0C")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xBBC4B4", Offset = "0xBBC4B4", VA = "0xBBC4B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xBBC504", Offset = "0xBBC504", VA = "0xBBC504")]
		private void Update()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xBBC52C", Offset = "0xBBC52C", VA = "0xBBC52C")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xBBC64C", Offset = "0xBBC64C", VA = "0xBBC64C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B5")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0xBBC664", Offset = "0xBBC664", VA = "0xBBC664")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0xBBC670", Offset = "0xBBC670", VA = "0xBBC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xBBC67C", Offset = "0xBBC67C", VA = "0xBBC67C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xBBB348", Offset = "0xBBB348", VA = "0xBBB348")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xBBC158", Offset = "0xBBC158", VA = "0xBBC158")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xBBC770", Offset = "0xBBC770", VA = "0xBBC770")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xBBCB38", Offset = "0xBBCB38", VA = "0xBBCB38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xBBCC44", Offset = "0xBBCC44", VA = "0xBBCC44")]
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
			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000680")]
			[Address(RVA = "0xBBCD00", Offset = "0xBBCD00", VA = "0xBBCD00")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0xBBCF68", Offset = "0xBBCF68", VA = "0xBBCF68")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xBBCC4C", Offset = "0xBBCC4C", VA = "0xBBCC4C")]
		private void Start()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xBBCC9C", Offset = "0xBBCC9C", VA = "0xBBCC9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xBBCEA8", Offset = "0xBBCEA8", VA = "0xBBCEA8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xBBCF60", Offset = "0xBBCF60", VA = "0xBBCF60")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xBBCF70", Offset = "0xBBCF70", VA = "0xBBCF70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xBBCFF0", Offset = "0xBBCFF0", VA = "0xBBCFF0")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xBBCFF8", Offset = "0xBBCFF8", VA = "0xBBCFF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xBBD064", Offset = "0xBBD064", VA = "0xBBD064")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xBBD0C4", Offset = "0xBBD0C4", VA = "0xBBD0C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xBBD0FC", Offset = "0xBBD0FC", VA = "0xBBD0FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xBBD3B8", Offset = "0xBBD3B8", VA = "0xBBD3B8")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xBBD3C0", Offset = "0xBBD3C0", VA = "0xBBD3C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xBBD3F8", Offset = "0xBBD3F8", VA = "0xBBD3F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xBBD544", Offset = "0xBBD544", VA = "0xBBD544")]
		private void Pose()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xBBD6AC", Offset = "0xBBD6AC", VA = "0xBBD6AC")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xBBD890", Offset = "0xBBD890", VA = "0xBBD890")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xBBD920", Offset = "0xBBD920", VA = "0xBBD920")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xBBD934", Offset = "0xBBD934", VA = "0xBBD934")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xBBDAA0", Offset = "0xBBDAA0", VA = "0xBBDAA0")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xBBDC9C", Offset = "0xBBDC9C", VA = "0xBBDC9C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xBBDCCC", Offset = "0xBBDCCC", VA = "0xBBDCCC")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xBBE0F8", Offset = "0xBBE0F8", VA = "0xBBE0F8")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xBBE118", Offset = "0xBBE118", VA = "0xBBE118")]
		private void Update()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xBBEA34", Offset = "0xBBEA34", VA = "0xBBEA34")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xBBE7B0", Offset = "0xBBE7B0", VA = "0xBBE7B0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xBBEB44", Offset = "0xBBEB44", VA = "0xBBEB44")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000B6")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xBBEB70", Offset = "0xBBEB70", VA = "0xBBEB70")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xBBEBF0", Offset = "0xBBEBF0", VA = "0xBBEBF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xBBEF34", Offset = "0xBBEF34", VA = "0xBBEF34")]
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
			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0xBBFF88", Offset = "0xBBFF88", VA = "0xBBFF88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0xBBFFD0", Offset = "0xBBFFD0", VA = "0xBBFFD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xBBFCA0", Offset = "0xBBFCA0", VA = "0xBBFCA0")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xBBFCC8", Offset = "0xBBFCC8", VA = "0xBBFCC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xBBFCCC", Offset = "0xBBFCCC", VA = "0xBBFCCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xBBFF90", Offset = "0xBBFF90", VA = "0xBBFF90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000B7")]
		public bool isStepping
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xBBEF48", Offset = "0xBBEF48", VA = "0xBBEF48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		public Vector3 position
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0xBBEB14", Offset = "0xBBEB14", VA = "0xBBEB14")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0xBBEF5C", Offset = "0xBBEF5C", VA = "0xBBEF5C")]
			set
			{
			}
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xBBEFA8", Offset = "0xBBEFA8", VA = "0xBBEFA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xBBF1F0", Offset = "0xBBF1F0", VA = "0xBBF1F0")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xBBF3C8", Offset = "0xBBF3C8", VA = "0xBBF3C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xBBF5E0", Offset = "0xBBF5E0", VA = "0xBBF5E0")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xBBF870", Offset = "0xBBF870", VA = "0xBBF870")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xBBF9D8", Offset = "0xBBF9D8", VA = "0xBBF9D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xBBF53C", Offset = "0xBBF53C", VA = "0xBBF53C")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xBBFC10", Offset = "0xBBFC10", VA = "0xBBFC10")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xBBFFD8", Offset = "0xBBFFD8", VA = "0xBBFFD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xBC00A4", Offset = "0xBC00A4", VA = "0xBC00A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xBC031C", Offset = "0xBC031C", VA = "0xBC031C")]
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
			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000675")]
			PositionOffset,
			[Token(Token = "0x4000676")]
			Position
		}

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		[Space(10f)]
		public Warp[] warps;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xBC0324", Offset = "0xBC0324", VA = "0xBC0324", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xBC0344", Offset = "0xBC0344", VA = "0xBC0344")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xBC055C", Offset = "0xBC055C", VA = "0xBC055C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xBC0814", Offset = "0xBC0814", VA = "0xBC0814")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xBC08A8", Offset = "0xBC08A8", VA = "0xBC08A8")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xBC08B0", Offset = "0xBC08B0", VA = "0xBC08B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xBC0900", Offset = "0xBC0900", VA = "0xBC0900")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xBC0B08", Offset = "0xBC0B08", VA = "0xBC0B08", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xBC0D30", Offset = "0xBC0D30", VA = "0xBC0D30")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[RequireComponent(typeof(AimIK))]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xBC0D44", Offset = "0xBC0D44", VA = "0xBC0D44", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xBC0ED8", Offset = "0xBC0ED8", VA = "0xBC0ED8", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xBC0F48", Offset = "0xBC0F48", VA = "0xBC0F48")]
		private void Read()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xBC1080", Offset = "0xBC1080", VA = "0xBC1080")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xBC10DC", Offset = "0xBC10DC", VA = "0xBC10DC")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xBC1724", Offset = "0xBC1724", VA = "0xBC1724")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xBC1538", Offset = "0xBC1538", VA = "0xBC1538")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xBC19C8", Offset = "0xBC19C8", VA = "0xBC19C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xBC1AD4", Offset = "0xBC1AD4", VA = "0xBC1AD4")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xBC1AF0", Offset = "0xBC1AF0", VA = "0xBC1AF0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xBC1BC4", Offset = "0xBC1BC4", VA = "0xBC1BC4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xBC1F18", Offset = "0xBC1F18", VA = "0xBC1F18")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xBC2008", Offset = "0xBC2008", VA = "0xBC2008")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BB")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xBC22A8", Offset = "0xBC22A8", VA = "0xBC22A8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BC")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xBC2328", Offset = "0xBC2328", VA = "0xBC2328")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xBC2050", Offset = "0xBC2050", VA = "0xBC2050")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xBC20B8", Offset = "0xBC20B8", VA = "0xBC20B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xBC23A8", Offset = "0xBC23A8", VA = "0xBC23A8")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xBC23B0", Offset = "0xBC23B0", VA = "0xBC23B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xBC280C", Offset = "0xBC280C", VA = "0xBC280C")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xBC2814", Offset = "0xBC2814", VA = "0xBC2814")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xBC28B8", Offset = "0xBC28B8", VA = "0xBC28B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xBC2D14", Offset = "0xBC2D14", VA = "0xBC2D14")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xBC2DB4", Offset = "0xBC2DB4", VA = "0xBC2DB4")]
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
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0xBC2F48", Offset = "0xBC2F48", VA = "0xBC2F48")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xBC306C", Offset = "0xBC306C", VA = "0xBC306C")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xBC2E24", Offset = "0xBC2E24", VA = "0xBC2E24")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xBC2FC0", Offset = "0xBC2FC0", VA = "0xBC2FC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xBC3058", Offset = "0xBC3058", VA = "0xBC3058")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xBC305C", Offset = "0xBC305C", VA = "0xBC305C")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xBC307C", Offset = "0xBC307C", VA = "0xBC307C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xBC30E4", Offset = "0xBC30E4", VA = "0xBC30E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xBC31AC", Offset = "0xBC31AC", VA = "0xBC31AC")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xBC31B4", Offset = "0xBC31B4", VA = "0xBC31B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xBC3204", Offset = "0xBC3204", VA = "0xBC3204")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xBC339C", Offset = "0xBC339C", VA = "0xBC339C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xBC33A4", Offset = "0xBC33A4", VA = "0xBC33A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xBC3474", Offset = "0xBC3474", VA = "0xBC3474")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xBC3500", Offset = "0xBC3500", VA = "0xBC3500")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xBC39D4", Offset = "0xBC39D4", VA = "0xBC39D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xBC3AE0", Offset = "0xBC3AE0", VA = "0xBC3AE0")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xBC3AE8", Offset = "0xBC3AE8", VA = "0xBC3AE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xBC3C48", Offset = "0xBC3C48", VA = "0xBC3C48")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xBC3C54", Offset = "0xBC3C54", VA = "0xBC3C54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xBC3F14", Offset = "0xBC3F14", VA = "0xBC3F14")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xBC40A0", Offset = "0xBC40A0", VA = "0xBC40A0")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xBC3D18", Offset = "0xBC3D18", VA = "0xBC3D18")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xBC4D58", Offset = "0xBC4D58", VA = "0xBC4D58")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(FPSAiming))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xBC4D78", Offset = "0xBC4D78", VA = "0xBC4D78")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xBC4DF4", Offset = "0xBC4DF4", VA = "0xBC4DF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xBC4EF0", Offset = "0xBC4EF0", VA = "0xBC4EF0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xBC4F9C", Offset = "0xBC4F9C", VA = "0xBC4F9C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xBC4FAC", Offset = "0xBC4FAC", VA = "0xBC4FAC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xBC50F0", Offset = "0xBC50F0", VA = "0xBC50F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xBC5254", Offset = "0xBC5254", VA = "0xBC5254")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xBC5264", Offset = "0xBC5264", VA = "0xBC5264")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xBC5430", Offset = "0xBC5430", VA = "0xBC5430")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xBC5840", Offset = "0xBC5840", VA = "0xBC5840")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xBC5850", Offset = "0xBC5850", VA = "0xBC5850")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xBC5938", Offset = "0xBC5938", VA = "0xBC5938")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xBC5A24", Offset = "0xBC5A24", VA = "0xBC5A24")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xBC5A2C", Offset = "0xBC5A2C", VA = "0xBC5A2C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xBC5F2C", Offset = "0xBC5F2C", VA = "0xBC5F2C")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xBC5F34", Offset = "0xBC5F34", VA = "0xBC5F34")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xBC5F84", Offset = "0xBC5F84", VA = "0xBC5F84")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xBC6230", Offset = "0xBC6230", VA = "0xBC6230")]
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
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000BD")]
			private Transform neck
			{
				[Token(Token = "0x60006FF")]
				[Address(RVA = "0xBC6A3C", Offset = "0xBC6A3C", VA = "0xBC6A3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xBC6260", Offset = "0xBC6260", VA = "0xBC6260")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xBC62DC", Offset = "0xBC62DC", VA = "0xBC62DC")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0xBC68D4", Offset = "0xBC68D4", VA = "0xBC68D4")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0xBC6A88", Offset = "0xBC6A88", VA = "0xBC6A88")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xBC6238", Offset = "0xBC6238", VA = "0xBC6238")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xBC6280", Offset = "0xBC6280", VA = "0xBC6280")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xBC68C4", Offset = "0xBC68C4", VA = "0xBC68C4")]
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
			[Token(Token = "0x4000701")]
			Position,
			[Token(Token = "0x4000702")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000F8")]
		public class Absorber
		{
			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000708")]
			[Address(RVA = "0xBC6C00", Offset = "0xBC6C00", VA = "0xBC6C00")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0xBC6DD4", Offset = "0xBC6DD4", VA = "0xBC6DD4")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0xBC6DF8", Offset = "0xBC6DF8", VA = "0xBC6DF8")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0xBC6F08", Offset = "0xBC6F08", VA = "0xBC6F08")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xBC70A0", Offset = "0xBC70A0", VA = "0xBC70A0")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xBC6A9C", Offset = "0xBC6A9C", VA = "0xBC6A9C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xBC6B80", Offset = "0xBC6B80", VA = "0xBC6B80")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xBC6CC8", Offset = "0xBC6CC8", VA = "0xBC6CC8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xBC6E8C", Offset = "0xBC6E8C", VA = "0xBC6E8C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xBC6F78", Offset = "0xBC6F78", VA = "0xBC6F78", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xBC7090", Offset = "0xBC7090", VA = "0xBC7090")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xBC7100", Offset = "0xBC7100", VA = "0xBC7100")]
		private void Start()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xBC7170", Offset = "0xBC7170", VA = "0xBC7170")]
		private void Update()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xBC7240", Offset = "0xBC7240", VA = "0xBC7240")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xBC7388", Offset = "0xBC7388", VA = "0xBC7388")]
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
			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000714")]
			[Address(RVA = "0xBC7608", Offset = "0xBC7608", VA = "0xBC7608")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xBC739C", Offset = "0xBC739C", VA = "0xBC739C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xBC7488", Offset = "0xBC7488", VA = "0xBC7488", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xBC7600", Offset = "0xBC7600", VA = "0xBC7600")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xBC7618", Offset = "0xBC7618", VA = "0xBC7618")]
		private void Start()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xBC7918", Offset = "0xBC7918", VA = "0xBC7918")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xBC8114", Offset = "0xBC8114", VA = "0xBC8114")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000BE")]
		private bool holding
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0xBC8394", Offset = "0xBC8394", VA = "0xBC8394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xBC8180", Offset = "0xBC8180", VA = "0xBC8180")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000719")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xBC83B4", Offset = "0xBC83B4", VA = "0xBC83B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xBC8574", Offset = "0xBC8574", VA = "0xBC8574")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xBC86E4", Offset = "0xBC86E4", VA = "0xBC86E4")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xBC87B4", Offset = "0xBC87B4", VA = "0xBC87B4")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xBC88D4", Offset = "0xBC88D4", VA = "0xBC88D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xBC8A48", Offset = "0xBC8A48", VA = "0xBC8A48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xBC8C44", Offset = "0xBC8C44", VA = "0xBC8C44")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000722")]
		[Address(RVA = "0xBC8C58", Offset = "0xBC8C58", VA = "0xBC8C58", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xBC8E38", Offset = "0xBC8E38", VA = "0xBC8E38")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000724")]
		[Address(RVA = "0xBC8E4C", Offset = "0xBC8E4C", VA = "0xBC8E4C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xBC8F60", Offset = "0xBC8F60", VA = "0xBC8F60")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xBC8F74", Offset = "0xBC8F74", VA = "0xBC8F74")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xBC900C", Offset = "0xBC900C", VA = "0xBC900C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xBC9124", Offset = "0xBC9124", VA = "0xBC9124")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xBC912C", Offset = "0xBC912C", VA = "0xBC912C")]
		private void Start()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xBC917C", Offset = "0xBC917C", VA = "0xBC917C")]
		private void Update()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xBC91C8", Offset = "0xBC91C8", VA = "0xBC91C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xBC9260", Offset = "0xBC9260", VA = "0xBC9260")]
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
			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0xBC95A0", Offset = "0xBC95A0", VA = "0xBC95A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0xBC95E8", Offset = "0xBC95E8", VA = "0xBC95E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0xBC93D4", Offset = "0xBC93D4", VA = "0xBC93D4")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0xBC940C", Offset = "0xBC940C", VA = "0xBC940C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0xBC9410", Offset = "0xBC9410", VA = "0xBC9410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0xBC95A8", Offset = "0xBC95A8", VA = "0xBC95A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xBC9270", Offset = "0xBC9270", VA = "0xBC9270")]
		private void Start()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xBC9320", Offset = "0xBC9320", VA = "0xBC9320")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xBC935C", Offset = "0xBC935C", VA = "0xBC935C")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xBC93FC", Offset = "0xBC93FC", VA = "0xBC93FC")]
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
			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600073D")]
				[Address(RVA = "0xBC985C", Offset = "0xBC985C", VA = "0xBC985C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0xBC98A4", Offset = "0xBC98A4", VA = "0xBC98A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0xBC9700", Offset = "0xBC9700", VA = "0xBC9700")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0xBC9730", Offset = "0xBC9730", VA = "0xBC9730", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0xBC9734", Offset = "0xBC9734", VA = "0xBC9734", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0xBC9864", Offset = "0xBC9864", VA = "0xBC9864", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xBC95F0", Offset = "0xBC95F0", VA = "0xBC95F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xBC9698", Offset = "0xBC9698", VA = "0xBC9698")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xBC9728", Offset = "0xBC9728", VA = "0xBC9728")]
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
			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xBC9910", Offset = "0xBC9910", VA = "0xBC9910")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0xBCA44C", Offset = "0xBCA44C", VA = "0xBCA44C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xBC9CD4", Offset = "0xBC9CD4", VA = "0xBC9CD4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0xBCA528", Offset = "0xBCA528", VA = "0xBCA528")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0xBCA60C", Offset = "0xBCA60C", VA = "0xBCA60C")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xBCA698", Offset = "0xBCA698", VA = "0xBCA698")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0xBCA720", Offset = "0xBCA720", VA = "0xBCA720")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0xBCA28C", Offset = "0xBCA28C", VA = "0xBCA28C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0xBCA7A8", Offset = "0xBCA7A8", VA = "0xBCA7A8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xBC98AC", Offset = "0xBC98AC", VA = "0xBC98AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xBC9C74", Offset = "0xBC9C74", VA = "0xBC9C74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xBCA1DC", Offset = "0xBCA1DC", VA = "0xBCA1DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xBCA444", Offset = "0xBCA444", VA = "0xBCA444")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xBCA7DC", Offset = "0xBCA7DC", VA = "0xBCA7DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xBCA80C", Offset = "0xBCA80C", VA = "0xBCA80C")]
		private void Update()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xBCA8BC", Offset = "0xBCA8BC", VA = "0xBCA8BC")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xBCA8D0", Offset = "0xBCA8D0", VA = "0xBCA8D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xBCAAB4", Offset = "0xBCAAB4", VA = "0xBCAAB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xBCAD50", Offset = "0xBCAD50", VA = "0xBCAD50")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xBCAE18", Offset = "0xBCAE18", VA = "0xBCAE18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xBCAF24", Offset = "0xBCAF24", VA = "0xBCAF24")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xBCAF2C", Offset = "0xBCAF2C", VA = "0xBCAF2C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xBCB044", Offset = "0xBCB044", VA = "0xBCB044")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xBCB20C", Offset = "0xBCB20C", VA = "0xBCB20C")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xBCB228", Offset = "0xBCB228", VA = "0xBCB228")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xBCB430", Offset = "0xBCB430", VA = "0xBCB430")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xBCB49C", Offset = "0xBCB49C", VA = "0xBCB49C")]
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
			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000764")]
				[Address(RVA = "0xBCBBE8", Offset = "0xBCBBE8", VA = "0xBCBBE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000766")]
				[Address(RVA = "0xBCBC30", Offset = "0xBCBC30", VA = "0xBCBC30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0xBCB87C", Offset = "0xBCB87C", VA = "0xBCB87C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xBCBA6C", Offset = "0xBCBA6C", VA = "0xBCBA6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xBCBA70", Offset = "0xBCBA70", VA = "0xBCBA70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xBCBBF0", Offset = "0xBCBBF0", VA = "0xBCBBF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xBCB4A4", Offset = "0xBCB4A4", VA = "0xBCB4A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xBCB5C8", Offset = "0xBCB5C8", VA = "0xBCB5C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xBCB560", Offset = "0xBCB560", VA = "0xBCB560")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xBCB8A4", Offset = "0xBCB8A4", VA = "0xBCB8A4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xBCB97C", Offset = "0xBCB97C", VA = "0xBCB97C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xBCBA50", Offset = "0xBCBA50", VA = "0xBCBA50")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xBCBC38", Offset = "0xBCBC38", VA = "0xBCBC38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xBCBCA0", Offset = "0xBCBCA0", VA = "0xBCBCA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xBCBD4C", Offset = "0xBCBD4C", VA = "0xBCBD4C")]
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
			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xBCBDC0", Offset = "0xBCBDC0", VA = "0xBCBDC0")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0xBCBEE0", Offset = "0xBCBEE0", VA = "0xBCBEE0")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xBCBD5C", Offset = "0xBCBD5C", VA = "0xBCBD5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xBCBED8", Offset = "0xBCBED8", VA = "0xBCBED8")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xBCBEE8", Offset = "0xBCBEE8", VA = "0xBCBEE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xBCC02C", Offset = "0xBCC02C", VA = "0xBCC02C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xBCC190", Offset = "0xBCC190", VA = "0xBCC190")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xBCC1A0", Offset = "0xBCC1A0", VA = "0xBCC1A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xBCC2F4", Offset = "0xBCC2F4", VA = "0xBCC2F4")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xBCC35C", Offset = "0xBCC35C", VA = "0xBCC35C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xBCC3AC", Offset = "0xBCC3AC", VA = "0xBCC3AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xBCC584", Offset = "0xBCC584", VA = "0xBCC584")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xBCC5DC", Offset = "0xBCC5DC", VA = "0xBCC5DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xBCCAFC", Offset = "0xBCCAFC", VA = "0xBCCAFC")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000C5")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000779")]
			[Address(RVA = "0xBCCB78", Offset = "0xBCCB78", VA = "0xBCCB78", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xBCCB58", Offset = "0xBCCB58", VA = "0xBCCB58", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xBCCB80", Offset = "0xBCCB80", VA = "0xBCCB80")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xBCCBE0", Offset = "0xBCCBE0", VA = "0xBCCBE0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xBC1F08", Offset = "0xBC1F08", VA = "0xBC1F08", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xBCCFD0", Offset = "0xBCCFD0", VA = "0xBCCFD0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xBCCD64", Offset = "0xBCCD64", VA = "0xBCCD64")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xBCCFE0", Offset = "0xBCCFE0", VA = "0xBCCFE0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xBCCFF8", Offset = "0xBCCFF8", VA = "0xBCCFF8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xBCD050", Offset = "0xBCD050", VA = "0xBCD050", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xBCD0E0", Offset = "0xBCD0E0", VA = "0xBCD0E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xBCD204", Offset = "0xBCD204", VA = "0xBCD204")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007A2")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007A3")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x170000C6")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0xBCD238", Offset = "0xBCD238", VA = "0xBCD238", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xBC1B48", Offset = "0xBC1B48", VA = "0xBC1B48", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xBCD21C", Offset = "0xBCD21C", VA = "0xBCD21C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xBCD32C", Offset = "0xBCD32C", VA = "0xBCD32C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xBCD700", Offset = "0xBCD700", VA = "0xBCD700")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xBC202C", Offset = "0xBC202C", VA = "0xBC202C")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007AF")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x600078A")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xBCD828", Offset = "0xBCD828", VA = "0xBCD828")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xBCDA14", Offset = "0xBCDA14", VA = "0xBCDA14", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xBCDBC4", Offset = "0xBCDBC4", VA = "0xBCDBC4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xBCDD64", Offset = "0xBCDD64", VA = "0xBCDD64")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xBCDDC4", Offset = "0xBCDDC4", VA = "0xBCDDC4")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xBCDF28", Offset = "0xBCDF28", VA = "0xBCDF28")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xBCE12C", Offset = "0xBCE12C", VA = "0xBCE12C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xBCE150", Offset = "0xBCE150", VA = "0xBCE150")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xBCE174", Offset = "0xBCE174", VA = "0xBCE174")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xBCE2C0", Offset = "0xBCE2C0", VA = "0xBCE2C0")]
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
			[Token(Token = "0x40007EC")]
			Directional,
			[Token(Token = "0x40007ED")]
			Strafe
		}

		[Token(Token = "0x200011B")]
		public struct AnimState
		{
			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200011C")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007AA")]
				[Address(RVA = "0xBD0C8C", Offset = "0xBD0C8C", VA = "0xBD0C8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AC")]
				[Address(RVA = "0xBD0CD4", Offset = "0xBD0CD4", VA = "0xBD0CD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xBD0A54", Offset = "0xBD0A54", VA = "0xBD0A54")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xBD0B94", Offset = "0xBD0B94", VA = "0xBD0B94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xBD0B98", Offset = "0xBD0B98", VA = "0xBD0B98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xBD0C94", Offset = "0xBD0C94", VA = "0xBD0C94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x170000C7")]
		public bool onGround
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0xBCE2E0", Offset = "0xBCE2E0", VA = "0xBCE2E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0xBCE2E8", Offset = "0xBCE2E8", VA = "0xBCE2E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xBCE2F4", Offset = "0xBCE2F4", VA = "0xBCE2F4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xBCE4C8", Offset = "0xBCE4C8", VA = "0xBCE4C8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xBCE54C", Offset = "0xBCE54C", VA = "0xBCE54C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xBCE5FC", Offset = "0xBCE5FC", VA = "0xBCE5FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xBCF5E8", Offset = "0xBCF5E8", VA = "0xBCF5E8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xBCFA78", Offset = "0xBCFA78", VA = "0xBCFA78", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xBCECAC", Offset = "0xBCECAC", VA = "0xBCECAC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xBCFB50", Offset = "0xBCFB50", VA = "0xBCFB50")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xBD01DC", Offset = "0xBD01DC", VA = "0xBD01DC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xBCF674", Offset = "0xBCF674", VA = "0xBCF674")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xBD02CC", Offset = "0xBD02CC", VA = "0xBD02CC", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xBD074C", Offset = "0xBD074C", VA = "0xBD074C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xBD0874", Offset = "0xBD0874", VA = "0xBD0874", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xBD09C8", Offset = "0xBD09C8", VA = "0xBD09C8")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__74))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xBCF088", Offset = "0xBCF088", VA = "0xBCF088")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xBD0A7C", Offset = "0xBD0A7C", VA = "0xBD0A7C")]
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
			[Token(Token = "0x4000809")]
			Smooth,
			[Token(Token = "0x400080A")]
			Linear
		}

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000CA")]
		public bool isGrounded
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xBD0CDC", Offset = "0xBD0CDC", VA = "0xBD0CDC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xBD0CE4", Offset = "0xBD0CE4", VA = "0xBD0CE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xBD0CF0", Offset = "0xBD0CF0", VA = "0xBD0CF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xBD0D84", Offset = "0xBD0D84", VA = "0xBD0D84")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xBD139C", Offset = "0xBD139C", VA = "0xBD139C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xBD0DCC", Offset = "0xBD0DCC", VA = "0xBD0DCC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xBD1134", Offset = "0xBD1134", VA = "0xBD1134")]
		private void Move()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xBD13CC", Offset = "0xBD13CC", VA = "0xBD13CC")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xBD1464", Offset = "0xBD1464", VA = "0xBD1464")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xBD14E4", Offset = "0xBD14E4", VA = "0xBD14E4")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xBD250C", Offset = "0xBD250C", VA = "0xBD250C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xBD2628", Offset = "0xBD2628", VA = "0xBD2628", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xBD2C8C", Offset = "0xBD2C8C", VA = "0xBD2C8C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xBD2E78", Offset = "0xBD2E78", VA = "0xBD2E78")]
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
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xBD2548", Offset = "0xBD2548", VA = "0xBD2548", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xBD2EA4", Offset = "0xBD2EA4", VA = "0xBD2EA4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xBD2E94", Offset = "0xBD2E94", VA = "0xBD2E94")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xBD31E8", Offset = "0xBD31E8", VA = "0xBD31E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xBD3220", Offset = "0xBD3220", VA = "0xBD3220")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xBD3228", Offset = "0xBD3228", VA = "0xBD3228")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xBD3250", Offset = "0xBD3250", VA = "0xBD3250")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xBD32F4", Offset = "0xBD32F4", VA = "0xBD32F4")]
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
			[Token(Token = "0x400082C")]
			Idle,
			[Token(Token = "0x400082D")]
			Seeking,
			[Token(Token = "0x400082E")]
			OnPath
		}

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000CB")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xBD3308", Offset = "0xBD3308", VA = "0xBD3308")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xBD3314", Offset = "0xBD3314", VA = "0xBD3314")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public State state
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xBD3320", Offset = "0xBD3320", VA = "0xBD3320")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xBD3328", Offset = "0xBD3328", VA = "0xBD3328")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xBD2574", Offset = "0xBD2574", VA = "0xBD2574")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xBD2848", Offset = "0xBD2848", VA = "0xBD2848")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xBD3408", Offset = "0xBD3408", VA = "0xBD3408")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xBD346C", Offset = "0xBD346C", VA = "0xBD346C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xBD3330", Offset = "0xBD3330", VA = "0xBD3330")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xBD338C", Offset = "0xBD338C", VA = "0xBD338C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xBD2CB4", Offset = "0xBD2CB4", VA = "0xBD2CB4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xBD35A0", Offset = "0xBD35A0", VA = "0xBD35A0")]
		public Navigator()
		{
		}
	}
}
namespace Crosstales
{
	[Token(Token = "0x2000126")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xBD3604", Offset = "0xBD3604", VA = "0xBD3604")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xBD3694", Offset = "0xBD3694", VA = "0xBD3694")]
		public static string CTReverse(this string str)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xBD3700", Offset = "0xBD3700", VA = "0xBD3700")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xBD3780", Offset = "0xBD3780", VA = "0xBD3780")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xBD37DC", Offset = "0xBD37DC", VA = "0xBD37DC")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xBD3848", Offset = "0xBD3848", VA = "0xBD3848")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xBD39F0", Offset = "0xBD39F0", VA = "0xBD39F0")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60007D6")]
		public static void CTShuffle<T>(this T[] array, int seed = 0)
		{
		}

		[Token(Token = "0x60007D7")]
		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xBD3B98", Offset = "0xBD3B98", VA = "0xBD3B98")]
		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xBD3D58", Offset = "0xBD3D58", VA = "0xBD3D58")]
		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xBD3ECC", Offset = "0xBD3ECC", VA = "0xBD3ECC")]
		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xBD406C", Offset = "0xBD406C", VA = "0xBD406C")]
		public static string CTDump(this Vector4[] array)
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x60007DE")]
		public static string CTDump<T>(this IList<T> list, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xBD422C", Offset = "0xBD422C", VA = "0xBD422C")]
		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xBD4670", Offset = "0xBD4670", VA = "0xBD4670")]
		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xBD4A50", Offset = "0xBD4A50", VA = "0xBD4A50")]
		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xBD4E64", Offset = "0xBD4E64", VA = "0xBD4E64")]
		public static string CTDump(this IList<Vector4> list)
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		public static List<string> CTToString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		public static void CTAddRange<K, V>(this IDictionary<K, V> source, IDictionary<K, V> collection)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xBD52A8", Offset = "0xBD52A8", VA = "0xBD52A8")]
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}
	}
}
namespace Crosstales.RTVoice
{
	[Token(Token = "0x200012A")]
	public delegate void VoicesReady();
	[Token(Token = "0x200012B")]
	public delegate void SpeakStart(Wrapper wrapper);
	[Token(Token = "0x200012C")]
	public delegate void SpeakComplete(Wrapper wrapper);
	[Token(Token = "0x200012D")]
	public delegate void SpeakCurrentWord(Wrapper wrapper, string[] speechTextArray, int wordIndex);
	[Token(Token = "0x200012E")]
	public delegate void SpeakCurrentPhoneme(Wrapper wrapper, string phoneme);
	[Token(Token = "0x200012F")]
	public delegate void SpeakCurrentViseme(Wrapper wrapper, string viseme);
	[Token(Token = "0x2000130")]
	public delegate void SpeakAudioGenerationStart(Wrapper wrapper);
	[Token(Token = "0x2000131")]
	public delegate void SpeakAudioGenerationComplete(Wrapper wrapper);
	[Token(Token = "0x2000132")]
	public delegate void ErrorInfo(Wrapper wrapper, string info);
	[Token(Token = "0x2000133")]
	public delegate void ProviderChange(string provider);
	[Token(Token = "0x2000134")]
	public delegate void AudioFileGeneratorStart();
	[Token(Token = "0x2000135")]
	public delegate void AudioFileGeneratorComplete();
	[Token(Token = "0x2000136")]
	public delegate void ParalanguageStart();
	[Token(Token = "0x2000137")]
	public delegate void ParalanguageComplete();
	[Token(Token = "0x2000138")]
	public delegate void SpeechTextStart();
	[Token(Token = "0x2000139")]
	public delegate void SpeechTextComplete();
	[Token(Token = "0x200013A")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_live_speaker.html")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LiveSpeaker : MonoBehaviour
	{
		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] splitChar;

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xBD6724", Offset = "0xBD6724", VA = "0xBD6724")]
		public void SpeakNative(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xBD6804", Offset = "0xBD6804", VA = "0xBD6804")]
		public void SpeakNative(string args)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xBD68D8", Offset = "0xBD68D8", VA = "0xBD68D8")]
		public void SpeakNative(string[] args)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xBD7250", Offset = "0xBD7250", VA = "0xBD7250")]
		public void Speak(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xBD7330", Offset = "0xBD7330", VA = "0xBD7330")]
		public void Speak(string args)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xBD7404", Offset = "0xBD7404", VA = "0xBD7404")]
		public void Speak(string[] args)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xBD77AC", Offset = "0xBD77AC", VA = "0xBD77AC")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xBD823C", Offset = "0xBD823C", VA = "0xBD823C")]
		public LiveSpeaker()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_speaker.html")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class Speaker : MonoBehaviour
	{
		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Custom provider for RT-Voice.")]
		[Header("Custom Provider")]
		public BaseCustomVoiceProvider CustomProvider;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Enable or disable the custom provider (default: false).")]
		public bool CustomMode;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Header("MaryTTS")]
		[Tooltip("Enable or disable MaryTTS (default: false).")]
		public bool MaryTTSMode;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Server URL for MaryTTS.")]
		public string MaryTTSUrl;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 65535f)]
		[Tooltip("Server port for MaryTTS (default: 59125).")]
		public int MaryTTSPort;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("User name for MaryTTS (default: empty).")]
		public string MaryTTSUser;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("User password for MaryTTS (default: empty).")]
		public string MaryTTSPassword;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Input type for MaryTTS (default: MaryTTSType.RAWMARYXML).")]
		public MaryTTSType MaryTTSType;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Enable or disable eSpeak for standalone platforms (default: false).")]
		[Header("eSpeak Settings")]
		public bool ESpeakMode;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Active modifier for all eSpeak voices (default: none, m1-m6 = male, f1-f4 = female).")]
		public ESpeakModifiers ESpeakModifier;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Header("Advanced Settings")]
		[Tooltip("Automatically clear tags from speeches depending on the capabilities of the current TTS-system (default: false).")]
		public bool AutoClearTags;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[Tooltip("Enable or disable native speak under WSA. If enabled, the build type must be 'XAML'! (default: false)")]
		public bool WSANative;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		[Header("Behaviour Settings")]
		[Tooltip("Silence any speeches if this component gets disabled (default: false).")]
		public bool SilenceOnDisable;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		[Tooltip("Silence any speeches if the application loses the focus. Otherwise the speeches are paused and unpaused (default: false).")]
		[FormerlySerializedAs("SilenceOnFocustLost")]
		public bool SilenceOnFocusLost;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Don't destroy gameobject during scene switches (default: true).")]
		public bool DontDestroy;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly Dictionary<string, AudioSource> removeSources;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float cleanUpTimer;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IVoiceProvider voiceProvider;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Speaker instance;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static GameObject go;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<string, AudioSource> genericSources;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<string, AudioSource> providedSources;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool loggedVPIsNull;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static int speechCount;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static int busyCount;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static bool deleted;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly char[] splitCharWords;

		[Token(Token = "0x4000850")]
		private const float cleanUpTime = 5f;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Thread deleteWorker;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static VoicesReady _onVoicesReady;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static SpeakStart _onSpeakStart;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static SpeakComplete _onSpeakComplete;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static SpeakCurrentWord _onSpeakCurrentWord;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static SpeakCurrentPhoneme _onSpeakCurrentPhoneme;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static SpeakCurrentViseme _onSpeakCurrentViseme;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static SpeakAudioGenerationStart _onSpeakAudioGenerationStart;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static SpeakAudioGenerationComplete _onSpeakAudioGenerationComplete;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static ProviderChange _onProviderChange;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static ErrorInfo _onErrorInfo;

		[Token(Token = "0x170000CD")]
		public static int SpeechCount
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0xBD9128", Offset = "0xBD9128", VA = "0xBD9128")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600084C")]
			[Address(RVA = "0xBD9180", Offset = "0xBD9180", VA = "0xBD9180")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public static int BusyCount
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0xBD91E0", Offset = "0xBD91E0", VA = "0xBD91E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600084E")]
			[Address(RVA = "0xBD9238", Offset = "0xBD9238", VA = "0xBD9238")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public static bool areVoicesReady
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0xBD9298", Offset = "0xBD9298", VA = "0xBD9298")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xBD92F0", Offset = "0xBD92F0", VA = "0xBD92F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public static BaseCustomVoiceProvider CustomVoiceProvider
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xBD934C", Offset = "0xBD934C", VA = "0xBD934C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xBD9410", Offset = "0xBD9410", VA = "0xBD9410")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public static bool isCustomMode
		{
			[Token(Token = "0x6000853")]
			[Address(RVA = "0xBD9580", Offset = "0xBD9580", VA = "0xBD9580")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000854")]
			[Address(RVA = "0xBD964C", Offset = "0xBD964C", VA = "0xBD964C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public static bool isMaryMode
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0xBD9748", Offset = "0xBD9748", VA = "0xBD9748")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000856")]
			[Address(RVA = "0xBD9814", Offset = "0xBD9814", VA = "0xBD9814")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public static string MaryUrl
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0xBD9910", Offset = "0xBD9910", VA = "0xBD9910")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xBD99E8", Offset = "0xBD99E8", VA = "0xBD99E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public static int MaryPort
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xBD9AB4", Offset = "0xBD9AB4", VA = "0xBD9AB4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xBD9B78", Offset = "0xBD9B78", VA = "0xBD9B78")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public static string MaryUser
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xBD9C44", Offset = "0xBD9C44", VA = "0xBD9C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xBD9D24", Offset = "0xBD9D24", VA = "0xBD9D24")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public static string MaryPassword
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xBD9DF0", Offset = "0xBD9DF0", VA = "0xBD9DF0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0xBD9ED0", Offset = "0xBD9ED0", VA = "0xBD9ED0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public static MaryTTSType MaryType
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0xBD9F9C", Offset = "0xBD9F9C", VA = "0xBD9F9C")]
			get
			{
				return default(MaryTTSType);
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0xBDA060", Offset = "0xBDA060", VA = "0xBDA060")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public static bool isESpeakMode
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0xBDA120", Offset = "0xBDA120", VA = "0xBDA120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0xBDA1EC", Offset = "0xBDA1EC", VA = "0xBDA1EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public static ESpeakModifiers ESpeakMod
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xBDA2E8", Offset = "0xBDA2E8", VA = "0xBDA2E8")]
			get
			{
				return default(ESpeakModifiers);
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xBDA3AC", Offset = "0xBDA3AC", VA = "0xBDA3AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public static bool isWSANative
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xBDA46C", Offset = "0xBDA46C", VA = "0xBDA46C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0xBDA538", Offset = "0xBDA538", VA = "0xBDA538")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public static bool isAutoClearTags
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xBDA5FC", Offset = "0xBDA5FC", VA = "0xBDA5FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xBDA6C8", Offset = "0xBDA6C8", VA = "0xBDA6C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public static bool isSilenceOnDisable
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xBDA78C", Offset = "0xBDA78C", VA = "0xBDA78C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xBDA858", Offset = "0xBDA858", VA = "0xBDA858")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public static bool isSilenceOnFocusLost
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xBDA91C", Offset = "0xBDA91C", VA = "0xBDA91C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xBDA9E8", Offset = "0xBDA9E8", VA = "0xBDA9E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public static bool isTTSAvailable
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0xBDAAAC", Offset = "0xBDAAAC", VA = "0xBDAAAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public static bool isSpeaking
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0xBDAD14", Offset = "0xBDAD14", VA = "0xBDAD14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E0")]
		public static bool isBusy
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xBDADA4", Offset = "0xBDADA4", VA = "0xBDADA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E1")]
		public static bool enforcedStandaloneTTS
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0xBDAE34", Offset = "0xBDAE34", VA = "0xBDAE34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000871")]
			[Address(RVA = "0xBDAE8C", Offset = "0xBDAE8C", VA = "0xBDAE8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public static string AudioFileExtension
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0xBDAEE8", Offset = "0xBDAEE8", VA = "0xBDAEE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		public static string DefaultVoiceName
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0xBDB008", Offset = "0xBDB008", VA = "0xBDB008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public static List<Voice> Voices
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xBDB134", Offset = "0xBDB134", VA = "0xBDB134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public static bool isWorkingInEditor
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0xBDB284", Offset = "0xBDB284", VA = "0xBDB284")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		public static bool isWorkingInPlaymode
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0xBDB394", Offset = "0xBDB394", VA = "0xBDB394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E7")]
		public static int MaxTextLength
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0xBDB4A4", Offset = "0xBDB4A4", VA = "0xBDB4A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E8")]
		public static bool isSpeakNativeSupported
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xBDB5B4", Offset = "0xBDB5B4", VA = "0xBDB5B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public static bool isSpeakSupported
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0xBDB6C4", Offset = "0xBDB6C4", VA = "0xBDB6C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		public static bool isPlatformSupported
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0xBDB7D4", Offset = "0xBDB7D4", VA = "0xBDB7D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		public static bool isSSMLSupported
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0xBDB8CC", Offset = "0xBDB8CC", VA = "0xBDB8CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EC")]
		public static bool isOnlineService
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0xBDB9DC", Offset = "0xBDB9DC", VA = "0xBDB9DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000ED")]
		public static bool hasCoRoutines
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xBDBAEC", Offset = "0xBDBAEC", VA = "0xBDBAEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		public static bool isIL2CPPSupported
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xBDBBFC", Offset = "0xBDBBFC", VA = "0xBDBBFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EF")]
		public static bool hasVoicesInEditor
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xBDBD0C", Offset = "0xBDBD0C", VA = "0xBDBD0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F0")]
		public static List<string> Cultures
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xBDBE1C", Offset = "0xBDBE1C", VA = "0xBDBE1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public static event VoicesReady OnVoicesReady
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0xBD82C8", Offset = "0xBD82C8", VA = "0xBD82C8")]
			add
			{
			}
			[Token(Token = "0x6000838")]
			[Address(RVA = "0xBD8380", Offset = "0xBD8380", VA = "0xBD8380")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event SpeakStart OnSpeakStart
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0xBD8438", Offset = "0xBD8438", VA = "0xBD8438")]
			add
			{
			}
			[Token(Token = "0x600083A")]
			[Address(RVA = "0xBD84F0", Offset = "0xBD84F0", VA = "0xBD84F0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event SpeakComplete OnSpeakComplete
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0xBD85A8", Offset = "0xBD85A8", VA = "0xBD85A8")]
			add
			{
			}
			[Token(Token = "0x600083C")]
			[Address(RVA = "0xBD8660", Offset = "0xBD8660", VA = "0xBD8660")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event SpeakCurrentWord OnSpeakCurrentWord
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0xBD8718", Offset = "0xBD8718", VA = "0xBD8718")]
			add
			{
			}
			[Token(Token = "0x600083E")]
			[Address(RVA = "0xBD87D0", Offset = "0xBD87D0", VA = "0xBD87D0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event SpeakCurrentPhoneme OnSpeakCurrentPhoneme
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0xBD8888", Offset = "0xBD8888", VA = "0xBD8888")]
			add
			{
			}
			[Token(Token = "0x6000840")]
			[Address(RVA = "0xBD8940", Offset = "0xBD8940", VA = "0xBD8940")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event SpeakCurrentViseme OnSpeakCurrentViseme
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0xBD89F8", Offset = "0xBD89F8", VA = "0xBD89F8")]
			add
			{
			}
			[Token(Token = "0x6000842")]
			[Address(RVA = "0xBD8AB0", Offset = "0xBD8AB0", VA = "0xBD8AB0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public static event SpeakAudioGenerationStart OnSpeakAudioGenerationStart
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0xBD8B68", Offset = "0xBD8B68", VA = "0xBD8B68")]
			add
			{
			}
			[Token(Token = "0x6000844")]
			[Address(RVA = "0xBD8C20", Offset = "0xBD8C20", VA = "0xBD8C20")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public static event SpeakAudioGenerationComplete OnSpeakAudioGenerationComplete
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0xBD8CD8", Offset = "0xBD8CD8", VA = "0xBD8CD8")]
			add
			{
			}
			[Token(Token = "0x6000846")]
			[Address(RVA = "0xBD8D90", Offset = "0xBD8D90", VA = "0xBD8D90")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public static event ProviderChange OnProviderChange
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0xBD8E48", Offset = "0xBD8E48", VA = "0xBD8E48")]
			add
			{
			}
			[Token(Token = "0x6000848")]
			[Address(RVA = "0xBD8F00", Offset = "0xBD8F00", VA = "0xBD8F00")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public static event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0xBD8FB8", Offset = "0xBD8FB8", VA = "0xBD8FB8")]
			add
			{
			}
			[Token(Token = "0x600084A")]
			[Address(RVA = "0xBD9070", Offset = "0xBD9070", VA = "0xBD9070")]
			remove
			{
			}
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xBDBF6C", Offset = "0xBDBF6C", VA = "0xBDBF6C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xBDCFCC", Offset = "0xBDCFCC", VA = "0xBDCFCC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xBDDBE4", Offset = "0xBDDBE4", VA = "0xBDDBE4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xBDE3F4", Offset = "0xBDE3F4", VA = "0xBDE3F4")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xBDE5E0", Offset = "0xBDE5E0", VA = "0xBDE5E0")]
		public void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xBDEFA0", Offset = "0xBDEFA0", VA = "0xBDEFA0")]
		public static float ApproximateSpeechLength(string text, float rate = 1f, float wordsPerMinute = 175f, float timeFactor = 0.9f)
		{
			return default(float);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xBDF570", Offset = "0xBDF570", VA = "0xBDF570")]
		public static bool isVoiceForGenderAvailable(Gender gender, string culture = "")
		{
			return default(bool);
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xBDF5FC", Offset = "0xBDF5FC", VA = "0xBDF5FC")]
		public static List<Voice> VoicesForGender(Gender gender, string culture = "", bool isFuzzy = true)
		{
			return null;
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xBDFB94", Offset = "0xBDFB94", VA = "0xBDFB94")]
		public static Voice VoiceForGender(Gender gender, string culture = "", int index = 0, string fallbackCulture = "", bool isFuzzy = true)
		{
			return null;
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xBE0214", Offset = "0xBE0214", VA = "0xBE0214")]
		public static bool isVoiceForCultureAvailable(string culture)
		{
			return default(bool);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xBDF818", Offset = "0xBDF818", VA = "0xBDF818")]
		public static List<Voice> VoicesForCulture(string culture, bool isFuzzy = true)
		{
			return null;
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xBD6E00", Offset = "0xBD6E00", VA = "0xBD6E00")]
		public static Voice VoiceForCulture(string culture, int index = 0, string fallbackCulture = "", bool isFuzzy = true)
		{
			return null;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xBE0298", Offset = "0xBE0298", VA = "0xBE0298")]
		public static bool isVoiceForNameAvailable(string name, bool isExact = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xBD6C74", Offset = "0xBD6C74", VA = "0xBD6C74")]
		public static Voice VoiceForName(string name, bool isExact = false)
		{
			return null;
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xBE0310", Offset = "0xBE0310", VA = "0xBE0310")]
		public static string SpeakNative(string text, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f, bool forceSSML = true)
		{
			return null;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xBE03E0", Offset = "0xBE03E0", VA = "0xBE03E0")]
		public static void SpeakNativeWithUID(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xBD6778", Offset = "0xBD6778", VA = "0xBD6778")]
		public static string SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xBE092C", Offset = "0xBE092C", VA = "0xBE092C")]
		public static string Speak(string text, [Optional] AudioSource source, [Optional] Voice voice, bool speakImmediately = true, float rate = 1f, float pitch = 1f, float volume = 1f, string outputFile = "", bool forceSSML = true)
		{
			return null;
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xBE0A24", Offset = "0xBE0A24", VA = "0xBE0A24")]
		public static void SpeakWithUID(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xBD72A4", Offset = "0xBD72A4", VA = "0xBD72A4")]
		public static string Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xBE0EF0", Offset = "0xBE0EF0", VA = "0xBE0EF0")]
		public static void SpeakMarkedWordsWithUID(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xBE1230", Offset = "0xBE1230", VA = "0xBE1230")]
		public static void SpeakMarkedWordsWithUID(string uid, string text, AudioSource source, [Optional] Voice voice, float rate = 1f, float pitch = 1f, bool forceSSML = true)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xBE1328", Offset = "0xBE1328", VA = "0xBE1328")]
		public static string Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xBE1550", Offset = "0xBE1550", VA = "0xBE1550")]
		public static string Generate(string text, string outputFile, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f, bool forceSSML = true)
		{
			return null;
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xBD77F8", Offset = "0xBD77F8", VA = "0xBD77F8")]
		public static void Silence()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xBE1630", Offset = "0xBE1630", VA = "0xBE1630")]
		public static void Silence(string uid)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xBDEB14", Offset = "0xBDEB14", VA = "0xBDEB14")]
		public static void Pause([Optional] string uid)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xBDE688", Offset = "0xBDE688", VA = "0xBDE688")]
		public static void UnPause([Optional] string uid)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xBD9530", Offset = "0xBD9530", VA = "0xBD9530")]
		public static void ReloadProvider()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xBDC708", Offset = "0xBDC708", VA = "0xBDC708")]
		public static void DeleteAudioFiles()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xBE195C", Offset = "0xBE195C", VA = "0xBE195C")]
		private static void deleteAudioFiles(string persistentDataPath)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xBDCABC", Offset = "0xBDCABC", VA = "0xBDCABC")]
		private static void initProvider()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xBE22A4", Offset = "0xBE22A4", VA = "0xBE22A4")]
		private static void initOSProvider()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xBE0894", Offset = "0xBE0894", VA = "0xBE0894")]
		private static void logWrapperIsNull()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xBDABD4", Offset = "0xBDABD4", VA = "0xBDABD4")]
		private static void logVPIsNull()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xBE1E64", Offset = "0xBE1E64", VA = "0xBE1E64")]
		private static void subscribeCustomEvents()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xBDDFB8", Offset = "0xBDDFB8", VA = "0xBDDFB8")]
		private static void unsubscribeCustomEvents()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xBE2704", Offset = "0xBE2704", VA = "0xBE2704")]
		private static void onVoicesReady()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xBE27D0", Offset = "0xBE27D0", VA = "0xBE27D0")]
		private static void onSpeakStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xBE28B4", Offset = "0xBE28B4", VA = "0xBE28B4")]
		private static void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xBE29DC", Offset = "0xBE29DC", VA = "0xBE29DC")]
		private static void onSpeakCurrentWord(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xBE2A94", Offset = "0xBE2A94", VA = "0xBE2A94")]
		private static void onSpeakCurrentPhoneme(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xBE2B44", Offset = "0xBE2B44", VA = "0xBE2B44")]
		private static void onSpeakCurrentViseme(Wrapper wrapper, string viseme)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xBE2BF4", Offset = "0xBE2BF4", VA = "0xBE2BF4")]
		private static void onSpeakAudioGenerationStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xBE2C90", Offset = "0xBE2C90", VA = "0xBE2C90")]
		private static void onSpeakAudioGenerationComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xBE2654", Offset = "0xBE2654", VA = "0xBE2654")]
		private static void onErrorInfo(Wrapper wrapper, string errorInfo)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xBE2D2C", Offset = "0xBE2D2C", VA = "0xBE2D2C")]
		public Speaker()
		{
		}
	}
	[Token(Token = "0x2000141")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_voice_provider_example.html")]
	public class VoiceProviderExample : BaseCustomVoiceProvider
	{
		[Token(Token = "0x2000142")]
		[CompilerGenerated]
		private sealed class <Generate>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceProviderExample <>4__this;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <>7__wrap1;

			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <>7__wrap2;

			[Token(Token = "0x170000FF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D8")]
				[Address(RVA = "0xBE3B7C", Offset = "0xBE3B7C", VA = "0xBE3B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000100")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008DA")]
				[Address(RVA = "0xBE3BC4", Offset = "0xBE3BC4", VA = "0xBE3BC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xBE3774", Offset = "0xBE3774", VA = "0xBE3774")]
			[DebuggerHidden]
			public <Generate>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xBE392C", Offset = "0xBE392C", VA = "0xBE392C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xBE3930", Offset = "0xBE3930", VA = "0xBE3930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xBE3B84", Offset = "0xBE3B84", VA = "0xBE3B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000143")]
		[CompilerGenerated]
		private sealed class <Speak>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceProviderExample <>4__this;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <>7__wrap1;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <>7__wrap2;

			[Token(Token = "0x17000101")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008DE")]
				[Address(RVA = "0xBE3E48", Offset = "0xBE3E48", VA = "0xBE3E48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000102")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E0")]
				[Address(RVA = "0xBE3E90", Offset = "0xBE3E90", VA = "0xBE3E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0xBE3810", Offset = "0xBE3810", VA = "0xBE3810")]
			[DebuggerHidden]
			public <Speak>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0xBE3BCC", Offset = "0xBE3BCC", VA = "0xBE3BCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0xBE3BD0", Offset = "0xBE3BD0", VA = "0xBE3BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0xBE3E50", Offset = "0xBE3E50", VA = "0xBE3E50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class <SpeakNative>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceProviderExample <>4__this;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <>7__wrap1;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <>7__wrap2;

			[Token(Token = "0x17000103")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008E4")]
				[Address(RVA = "0xBE4148", Offset = "0xBE4148", VA = "0xBE4148", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000104")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E6")]
				[Address(RVA = "0xBE4190", Offset = "0xBE4190", VA = "0xBE4190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xBE38AC", Offset = "0xBE38AC", VA = "0xBE38AC")]
			[DebuggerHidden]
			public <SpeakNative>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0xBE3E98", Offset = "0xBE3E98", VA = "0xBE3E98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0xBE3E9C", Offset = "0xBE3E9C", VA = "0xBE3E9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0xBE4150", Offset = "0xBE4150", VA = "0xBE4150", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xBE3350", Offset = "0xBE3350", VA = "0xBE3350", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		public override AudioType AudioFileType
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xBE3390", Offset = "0xBE3390", VA = "0xBE3390", Slot = "26")]
			get
			{
				return default(AudioType);
			}
		}

		[Token(Token = "0x170000F3")]
		public override string DefaultVoiceName
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xBE3398", Offset = "0xBE3398", VA = "0xBE3398", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F4")]
		public override bool isWorkingInEditor
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xBE33D8", Offset = "0xBE33D8", VA = "0xBE33D8", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F5")]
		public override bool isWorkingInPlaymode
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xBE33E0", Offset = "0xBE33E0", VA = "0xBE33E0", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F6")]
		public override bool isPlatformSupported
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xBE33E8", Offset = "0xBE33E8", VA = "0xBE33E8", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F7")]
		public override int MaxTextLength
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xBE33F0", Offset = "0xBE33F0", VA = "0xBE33F0", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F8")]
		public override bool isSpeakNativeSupported
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xBE33F8", Offset = "0xBE33F8", VA = "0xBE33F8", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F9")]
		public override bool isSpeakSupported
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xBE3400", Offset = "0xBE3400", VA = "0xBE3400", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FA")]
		public override bool isSSMLSupported
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xBE3408", Offset = "0xBE3408", VA = "0xBE3408", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FB")]
		public override bool isOnlineService
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xBE3410", Offset = "0xBE3410", VA = "0xBE3410", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FC")]
		public override bool hasCoRoutines
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xBE3418", Offset = "0xBE3418", VA = "0xBE3418", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FD")]
		public override bool isIL2CPPSupported
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xBE3420", Offset = "0xBE3420", VA = "0xBE3420", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FE")]
		public override bool hasVoicesInEditor
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xBE3428", Offset = "0xBE3428", VA = "0xBE3428", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xBE3430", Offset = "0xBE3430", VA = "0xBE3430", Slot = "45")]
		public override void Load()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xBE3700", Offset = "0xBE3700", VA = "0xBE3700", Slot = "44")]
		[IteratorStateMachine(typeof(<Generate>d__29))]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xBE379C", Offset = "0xBE379C", VA = "0xBE379C", Slot = "43")]
		[IteratorStateMachine(typeof(<Speak>d__30))]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xBE3838", Offset = "0xBE3838", VA = "0xBE3838", Slot = "42")]
		[IteratorStateMachine(typeof(<SpeakNative>d__31))]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xBE38D4", Offset = "0xBE38D4", VA = "0xBE38D4")]
		public VoiceProviderExample()
		{
		}
	}
}
namespace Crosstales.RTVoice.Util
{
	[Token(Token = "0x2000145")]
	public static class Config
	{
		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string ASSET_PATH;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool DEBUG;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public static bool AUDIOFILE_AUTOMATIC_DELETE;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public static bool ENFORCE_32BIT_WINDOWS;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public static bool ENFORCE_STANDALONE_TTS;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string TTS_WINDOWS_BUILD;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string TTS_MACOS;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string TTS_LINUX;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string TTS_LINUX_DATA;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static bool ENSURE_NAME;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public static bool isLoaded;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string audiofilePath;

		[Token(Token = "0x17000105")]
		public static string AUDIOFILE_PATH
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0xBE4198", Offset = "0xBE4198", VA = "0xBE4198")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0xBE41F0", Offset = "0xBE41F0", VA = "0xBE41F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public static string TTS_WINDOWS_EDITOR
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0xBE4288", Offset = "0xBE4288", VA = "0xBE4288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		public static string TTS_WINDOWS_EDITOR_x86
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xBE431C", Offset = "0xBE431C", VA = "0xBE431C")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000146")]
	public abstract class Constants : BaseConstants
	{
		[Token(Token = "0x4000886")]
		public const string ASSET_NAME = "RT-Voice PRO";

		[Token(Token = "0x4000887")]
		public const string ASSET_VERSION = "2019.6.1";

		[Token(Token = "0x4000888")]
		public const int ASSET_BUILD = 20191010;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x400088B")]
		public const string ASSET_PRO_URL = "https://assetstore.unity.com/packages/slug/41068?aid=1011lNGT";

		[Token(Token = "0x400088C")]
		public const string ASSET_2019_URL = "https://www.assetstore.unity3d.com/#!/content/41068?aid=1011lNGT";

		[Token(Token = "0x400088D")]
		public const string ASSET_3P_URL = "https://assetstore.unity.com/lists/rt-voice-friends-42209?aid=1011lNGT";

		[Token(Token = "0x400088E")]
		public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/rtvoice_versions.txt";

		[Token(Token = "0x400088F")]
		public const string ASSET_CONTACT = "rtvoice@crosstales.com";

		[Token(Token = "0x4000890")]
		public const string ASSET_MANUAL_URL = "https://www.crosstales.com/media/data/assets/rtvoice/RTVoice-doc.pdf";

		[Token(Token = "0x4000891")]
		public const string ASSET_API_URL = "http://www.crosstales.com/en/assets/rtvoice/api/";

		[Token(Token = "0x4000892")]
		public const string ASSET_FORUM_URL = "http://forum.unity3d.com/threads/rt-voice-run-time-text-to-speech-solution.340046/";

		[Token(Token = "0x4000893")]
		public const string ASSET_WEB_URL = "https://www.crosstales.com/en/portfolio/rtvoice/";

		[Token(Token = "0x4000894")]
		public const string ASSET_VIDEO_PROMO = "https://youtu.be/iVhTWDLY7g8?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x4000895")]
		public const string ASSET_VIDEO_TUTORIAL = "https://youtu.be/OJyVgCmX3wU?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x4000896")]
		public const string ASSET_3P_ADVENTURE_CREATOR = "https://assetstore.unity.com/packages/slug/11896?aid=1011lNGT";

		[Token(Token = "0x4000897")]
		public const string ASSET_3P_CINEMA_DIRECTOR = "https://assetstore.unity.com/packages/slug/19779?aid=1011lNGT";

		[Token(Token = "0x4000898")]
		public const string ASSET_3P_DIALOGUE_SYSTEM = "https://assetstore.unity.com/packages/slug/11672?aid=1011lNGT";

		[Token(Token = "0x4000899")]
		public const string ASSET_3P_LOCALIZED_DIALOGS = "https://assetstore.unity.com/packages/slug/5020?aid=1011lNGT";

		[Token(Token = "0x400089A")]
		public const string ASSET_3P_LIPSYNC = "https://assetstore.unity.com/packages/slug/32117?aid=1011lNGT";

		[Token(Token = "0x400089B")]
		public const string ASSET_3P_NPC_CHAT = "https://assetstore.unity.com/packages/slug/9723?aid=1011lNGT";

		[Token(Token = "0x400089C")]
		public const string ASSET_3P_QUEST_SYSTEM = "https://assetstore.unity.com/packages/slug/63460?aid=1011lNGT";

		[Token(Token = "0x400089D")]
		public const string ASSET_3P_SALSA = "https://assetstore.unity.com/packages/slug/148442?aid=1011lNGT";

		[Token(Token = "0x400089E")]
		public const string ASSET_3P_SLATE = "https://assetstore.unity.com/packages/slug/56558?aid=1011lNGT";

		[Token(Token = "0x400089F")]
		public const string ASSET_3P_AMPLITUDE = "https://assetstore.unity.com/packages/slug/111277?aid=1011lNGT";

		[Token(Token = "0x40008A0")]
		public const string ASSET_3P_KLATTERSYNTH = "https://assetstore.unity.com/packages/slug/95453?aid=1011lNGT";

		[Token(Token = "0x40008A1")]
		public const string ASSET_3P_WEBGL = "https://assetstore.unity.com/packages/slug/81861?aid=1011lNGT";

		[Token(Token = "0x40008A2")]
		public const string ASSET_3P_GOOGLE = "https://assetstore.unity.com/packages/slug/115170?aid=1011lNGT";

		[Token(Token = "0x40008A3")]
		public const string KEY_PREFIX = "RTVOICE_CFG_";

		[Token(Token = "0x40008A4")]
		public const string KEY_ASSET_PATH = "RTVOICE_CFG_ASSET_PATH";

		[Token(Token = "0x40008A5")]
		public const string KEY_DEBUG = "RTVOICE_CFG_DEBUG";

		[Token(Token = "0x40008A6")]
		public const string KEY_AUDIOFILE_PATH = "RTVOICE_CFG_AUDIOFILE_PATH";

		[Token(Token = "0x40008A7")]
		public const string KEY_AUDIOFILE_AUTOMATIC_DELETE = "RTVOICE_CFG_AUDIOFILE_AUTOMATIC_DELETE";

		[Token(Token = "0x40008A8")]
		public const string KEY_ENFORCE_32BIT_WINDOWS = "RTVOICE_CFG_ENFORCE_32BIT_WINDOWS";

		[Token(Token = "0x40008A9")]
		public const string KEY_ENFORCE_STANDALONE_TTS = "RTVOICE_CFG_ENFORCE_STANDALONE_TTS";

		[Token(Token = "0x40008AA")]
		public const string KEY_ENSURE_NAME = "RTVOICE_CFG_ENSURE_NAME";

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly string DEFAULT_AUDIOFILE_PATH;

		[Token(Token = "0x40008AC")]
		public const bool DEFAULT_AUDIOFILE_AUTOMATIC_DELETE = true;

		[Token(Token = "0x40008AD")]
		public const bool DEFAULT_ENFORCE_32BIT_WINDOWS = false;

		[Token(Token = "0x40008AE")]
		public const bool DEFAULT_ENFORCE_STANDALONE_TTS = true;

		[Token(Token = "0x40008AF")]
		public const string DEFAULT_TTS_WINDOWS_BUILD = "/RTVoiceTTSWrapper.exe";

		[Token(Token = "0x40008B0")]
		public const string DEFAULT_TTS_MACOS = "say";

		[Token(Token = "0x40008B1")]
		public const string DEFAULT_TTS_LINUX = "espeak";

		[Token(Token = "0x40008B2")]
		public const string DEFAULT_TTS_LINUX_DATA = "";

		[Token(Token = "0x40008B3")]
		public const int DEFAULT_TTS_KILL_TIME = 7000;

		[Token(Token = "0x40008B4")]
		public const bool DEFAULT_ENSURE_NAME = true;

		[Token(Token = "0x40008B5")]
		public const string RTVOICE_SCENE_OBJECT_NAME = "RTVoice";

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string TTS_WINDOWS_SUBPATH;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string TTS_WINDOWS_x86_SUBPATH;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string ESPEAK_FEMALE_MODIFIER;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string AUDIOFILE_PREFIX;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float SPEAK_CALL_SPEED;

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xBE44EC", Offset = "0xBE44EC", VA = "0xBE44EC")]
		protected Constants()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public abstract class Helper : BaseHelper
	{
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] appleFemales;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string[] appleMales;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string[] wsaFemales;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string[] wsaMales;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Dictionary<int, string> LocaleCodes;

		[Token(Token = "0x17000108")]
		public static bool hasBuiltInTTS
		{
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0xBDC950", Offset = "0xBDC950", VA = "0xBDC950")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		public static ProviderType CurrentProviderType
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xBE8980", Offset = "0xBE8980", VA = "0xBE8980")]
			get
			{
				return default(ProviderType);
			}
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xBE46B4", Offset = "0xBE46B4", VA = "0xBE46B4")]
		static Helper()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xBE8AD8", Offset = "0xBE8AD8", VA = "0xBE8AD8")]
		public static Gender StringToGender(string gender)
		{
			return default(Gender);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xBE8BB8", Offset = "0xBE8BB8", VA = "0xBE8BB8")]
		public static Gender AppleVoiceNameToGender(string voiceName)
		{
			return default(Gender);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xBE8D58", Offset = "0xBE8D58", VA = "0xBE8D58")]
		public static Gender WSAVoiceNameToGender(string voiceName)
		{
			return default(Gender);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xBE8EF8", Offset = "0xBE8EF8", VA = "0xBE8EF8")]
		public static string CleanText(string text, bool removeTags = true, bool clearSpaces = true, bool clearLineEndings = true)
		{
			return null;
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xBE8FCC", Offset = "0xBE8FCC", VA = "0xBE8FCC")]
		public static string MarkSpokenText(string[] speechTextArray, int wordIndex, bool markAllSpokenWords = false, string markPrefix = "<color=green><b>", string markPostfix = "</b></color>")
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xBE925C", Offset = "0xBE925C", VA = "0xBE925C")]
		protected Helper()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class WavMaster
	{
		[Token(Token = "0x40008C2")]
		private const int blockSize_16Bit = 2;

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xBE92E4", Offset = "0xBE92E4", VA = "0xBE92E4")]
		public static AudioClip ToAudioClip(string filePath, string name = "wav")
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xBE93B8", Offset = "0xBE93B8", VA = "0xBE93B8")]
		public static AudioClip ToAudioClip(byte[] fileBytes, int offsetSamples = 0, string name = "wav")
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xBE9BA4", Offset = "0xBE9BA4", VA = "0xBE9BA4")]
		public static byte[] FromAudioClip(AudioClip audioClip)
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xBE9C04", Offset = "0xBE9C04", VA = "0xBE9C04")]
		public static byte[] FromAudioClip(AudioClip audioClip, out string filepath, bool saveAsFile = true, string dirname = "rtv_audio")
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xBEA35C", Offset = "0xBEA35C", VA = "0xBEA35C")]
		public static ushort BitDepth(AudioClip audioClip)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xBE96E4", Offset = "0xBE96E4", VA = "0xBE96E4")]
		private static float[] convert8BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xBE97DC", Offset = "0xBE97DC", VA = "0xBE97DC")]
		private static float[] convert16BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xBE9904", Offset = "0xBE9904", VA = "0xBE9904")]
		private static float[] convert24BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xBE9A7C", Offset = "0xBE9A7C", VA = "0xBE9A7C")]
		private static float[] convert32BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xBE9EE4", Offset = "0xBE9EE4", VA = "0xBE9EE4")]
		private static int writeFileHeader(ref MemoryStream stream, int fileSize)
		{
			return default(int);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xBE9FF0", Offset = "0xBE9FF0", VA = "0xBE9FF0")]
		private static int writeFileFormat(ref MemoryStream stream, int channels, int sampleRate, ushort bitDepth)
		{
			return default(int);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xBEA1CC", Offset = "0xBEA1CC", VA = "0xBEA1CC")]
		private static int writeFileData(ref MemoryStream stream, AudioClip audioClip, ushort bitDepth)
		{
			return default(int);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xBEA464", Offset = "0xBEA464", VA = "0xBEA464")]
		private static byte[] convertAudioClipDataToInt16ByteArray(float[] data)
		{
			return null;
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xBEA420", Offset = "0xBEA420", VA = "0xBEA420")]
		private static int writeBytesToMemoryStream(ref MemoryStream stream, byte[] bytes)
		{
			return default(int);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xBEA45C", Offset = "0xBEA45C", VA = "0xBEA45C")]
		private static int bytesPerSample(ushort bitDepth)
		{
			return default(int);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xBEA5CC", Offset = "0xBEA5CC", VA = "0xBEA5CC")]
		private static int BlockSize(ushort bitDepth)
		{
			return default(int);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xBE95B4", Offset = "0xBE95B4", VA = "0xBE95B4")]
		private static string formatCode(ushort code)
		{
			return null;
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xBEA684", Offset = "0xBEA684", VA = "0xBEA684")]
		public WavMaster()
		{
		}
	}
}
namespace Crosstales.RTVoice.Tool
{
	[Token(Token = "0x200014B")]
	[ExecuteInEditMode]
	[HelpURL("https://crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_audio_file_generator.html")]
	public class AudioFileGenerator : MonoBehaviour
	{
		[Token(Token = "0x200014C")]
		[CompilerGenerated]
		private sealed class <generate>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioFileGenerator <>4__this;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TextAsset[] <>7__wrap1;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<string>.Enumerator <>7__wrap3;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Wrapper <wrapper>5__5;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private string <uid>5__6;

			[Token(Token = "0x1700010A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000926")]
				[Address(RVA = "0xBEB8C0", Offset = "0xBEB8C0", VA = "0xBEB8C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000928")]
				[Address(RVA = "0xBEB908", Offset = "0xBEB908", VA = "0xBEB908", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0xBEAB64", Offset = "0xBEAB64", VA = "0xBEAB64")]
			[DebuggerHidden]
			public <generate>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0xBEB2F4", Offset = "0xBEB2F4", VA = "0xBEB2F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xBEB320", Offset = "0xBEB320", VA = "0xBEB320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0xBEB870", Offset = "0xBEB870", VA = "0xBEB870")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0xBEB8C8", Offset = "0xBEB8C8", VA = "0xBEB8C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Text files to generate.")]
		public TextAsset[] TextFiles;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Are the specified file paths inside the Assets-folder (current project)? If this option is enabled, it prefixes the path with 'Application.dataPath' (default: true).")]
		public bool FileInsideAssets;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Tooltip("Normalize the volume of the WAV files (default: false). Note: this works only under Windows standalone.")]
		public bool isNormalize;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[Tooltip("Enable generating of the texts on start (default: false).")]
		public bool GenerateOnStart;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] splitChar;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string lastUid;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isGenerate;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioFileGeneratorStart _onStart;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioFileGeneratorComplete _onComplete;

		[Token(Token = "0x1400000B")]
		public event AudioFileGeneratorStart OnAudioFileGeneratorStart
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0xBEA68C", Offset = "0xBEA68C", VA = "0xBEA68C")]
			add
			{
			}
			[Token(Token = "0x6000910")]
			[Address(RVA = "0xBEA70C", Offset = "0xBEA70C", VA = "0xBEA70C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event AudioFileGeneratorComplete OnAudioFileGeneratorComplete
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0xBEA78C", Offset = "0xBEA78C", VA = "0xBEA78C")]
			add
			{
			}
			[Token(Token = "0x6000912")]
			[Address(RVA = "0xBEA80C", Offset = "0xBEA80C", VA = "0xBEA80C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xBEA88C", Offset = "0xBEA88C", VA = "0xBEA88C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xBEA97C", Offset = "0xBEA97C", VA = "0xBEA97C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xBEAA6C", Offset = "0xBEAA6C", VA = "0xBEAA6C")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xBEAA70", Offset = "0xBEAA70", VA = "0xBEAA70")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xBEAAFC", Offset = "0xBEAAFC", VA = "0xBEAAFC")]
		[IteratorStateMachine(typeof(<generate>d__19))]
		public IEnumerator generate()
		{
			return null;
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xBEAB8C", Offset = "0xBEAB8C", VA = "0xBEAB8C")]
		private void convert(string outputFile)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xBEABF4", Offset = "0xBEABF4", VA = "0xBEABF4")]
		public void Normalize(string inputFile)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xBEAC5C", Offset = "0xBEAC5C", VA = "0xBEAC5C")]
		public static float GetMaxPeak(string inputFile)
		{
			return default(float);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xBEACCC", Offset = "0xBEACCC", VA = "0xBEACCC")]
		private Wrapper prepare(string[] args, string speech)
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xBEAF94", Offset = "0xBEAF94", VA = "0xBEAF94")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xBEAFA4", Offset = "0xBEAFA4", VA = "0xBEAFA4")]
		private void onSpeakAudioGenerationComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xBEB090", Offset = "0xBEB090", VA = "0xBEB090")]
		private void onStart()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xBEB154", Offset = "0xBEB154", VA = "0xBEB154")]
		private void onComplete()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xBEB218", Offset = "0xBEB218", VA = "0xBEB218")]
		public AudioFileGenerator()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[ExecuteInEditMode]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_change_gender.html")]
	public class ChangeGender : MonoBehaviour
	{
		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The new gender for all voices.")]
		public Gender NewGender;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Change voices only when eSpeak is used (default: true).")]
		public bool ESpeakOnly;

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xBEB910", Offset = "0xBEB910", VA = "0xBEB910")]
		public void Start()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xBEB9AC", Offset = "0xBEB9AC", VA = "0xBEB9AC")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xBEBA48", Offset = "0xBEBA48", VA = "0xBEBA48")]
		public void GenderChanged(int index)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xBEBA50", Offset = "0xBEBA50", VA = "0xBEBA50")]
		public void Change()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xBEBBE4", Offset = "0xBEBBE4", VA = "0xBEBBE4")]
		public ChangeGender()
		{
		}
	}
	[Token(Token = "0x200014E")]
	[RequireComponent(typeof(AudioSource))]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_loudspeaker.html")]
	public class Loudspeaker : MonoBehaviour
	{
		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Origin AudioSource.")]
		public AudioSource Source;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Synchronize with the origin (default: false).")]
		public bool Synchronized;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Tooltip("Silence the origin (default: true).")]
		public bool SilenceSource;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource audioSource;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool stopped;

		[Token(Token = "0x1700010C")]
		public bool isSynchronized
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xBEBBF4", Offset = "0xBEBBF4", VA = "0xBEBBF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0xBEBBFC", Offset = "0xBEBBFC", VA = "0xBEBBFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public bool isSilenceSource
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0xBEBC08", Offset = "0xBEBC08", VA = "0xBEBC08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000931")]
			[Address(RVA = "0xBEBC10", Offset = "0xBEBC10", VA = "0xBEBC10")]
			set
			{
			}
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xBEBC1C", Offset = "0xBEBC1C", VA = "0xBEBC1C")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xBEBCA0", Offset = "0xBEBCA0", VA = "0xBEBCA0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xBEBD54", Offset = "0xBEBD54", VA = "0xBEBD54")]
		public void Update()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xBEBE7C", Offset = "0xBEBE7C", VA = "0xBEBE7C")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xBEBF1C", Offset = "0xBEBF1C", VA = "0xBEBF1C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xBEBF5C", Offset = "0xBEBF5C", VA = "0xBEBF5C")]
		public Loudspeaker()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_paralanguage.html")]
	[RequireComponent(typeof(AudioSource))]
	public class Paralanguage : MonoBehaviour
	{
		[Token(Token = "0x2000151")]
		[CompilerGenerated]
		private sealed class <processStack>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Paralanguage <>4__this;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private IEnumerator<KeyValuePair<int, string>> <>7__wrap1;

			[Token(Token = "0x17000112")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0xBED9D8", Offset = "0xBED9D8", VA = "0xBED9D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000113")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600095B")]
				[Address(RVA = "0xBEDA20", Offset = "0xBEDA20", VA = "0xBEDA20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0xBECE60", Offset = "0xBECE60", VA = "0xBECE60")]
			[DebuggerHidden]
			public <processStack>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0xBED298", Offset = "0xBED298", VA = "0xBED298", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0xBED2C4", Offset = "0xBED2C4", VA = "0xBED2C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0xBED928", Offset = "0xBED928", VA = "0xBED928")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0xBED9E0", Offset = "0xBED9E0", VA = "0xBED9E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		[Tooltip("Text to speak.")]
		public string Text;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Voices for the speech.")]
		public VoiceAlias Voices;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Speak mode (default: 'Speak').")]
		public SpeakMode Mode;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Audio clips to play.")]
		public AudioClip[] Clips;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Optional Settings")]
		[Tooltip("Speech rate of the speaker in percent (1 = 100%, default: 1, optional).")]
		[Range(0f, 3f)]
		public float Rate;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speech pitch of the speaker in percent (1 = 100%, default: 1, optional, mobile only).")]
		[Range(0f, 2f)]
		public float Pitch;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Volume of the speaker in percent (1 = 100%, default: 1, optional, Windows only).")]
		public float Volume;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("Behaviour Settings")]
		[Tooltip("Enable speaking of the text on start (default: false).")]
		public bool PlayOnStart;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Delay until the speech for this text starts (default: 0).")]
		public float Delay;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex splitRegex;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string uid;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool played;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly IDictionary<int, string> stack;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly IDictionary<string, AudioClip> clipDict;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource audioSource;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool next;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ParalanguageStart _onStart;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ParalanguageComplete _onComplete;

		[Token(Token = "0x1700010E")]
		public string CurrentText
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0xBEC170", Offset = "0xBEC170", VA = "0xBEC170")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093D")]
			[Address(RVA = "0xBEC178", Offset = "0xBEC178", VA = "0xBEC178")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public float CurrentRate
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0xBEC180", Offset = "0xBEC180", VA = "0xBEC180")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600093F")]
			[Address(RVA = "0xBEC188", Offset = "0xBEC188", VA = "0xBEC188")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public float CurrentPitch
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0xBEC190", Offset = "0xBEC190", VA = "0xBEC190")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000941")]
			[Address(RVA = "0xBEC198", Offset = "0xBEC198", VA = "0xBEC198")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public float CurrentVolume
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0xBEC1A0", Offset = "0xBEC1A0", VA = "0xBEC1A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0xBEC1A8", Offset = "0xBEC1A8", VA = "0xBEC1A8")]
			set
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event ParalanguageStart OnParalanguageStart
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0xBEBF70", Offset = "0xBEBF70", VA = "0xBEBF70")]
			add
			{
			}
			[Token(Token = "0x6000939")]
			[Address(RVA = "0xBEBFF0", Offset = "0xBEBFF0", VA = "0xBEBFF0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event ParalanguageComplete OnParalanguageComplete
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0xBEC070", Offset = "0xBEC070", VA = "0xBEC070")]
			add
			{
			}
			[Token(Token = "0x600093B")]
			[Address(RVA = "0xBEC0F0", Offset = "0xBEC0F0", VA = "0xBEC0F0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xBEC1B0", Offset = "0xBEC1B0", VA = "0xBEC1B0")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xBEC234", Offset = "0xBEC234", VA = "0xBEC234")]
		public void Start()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xBEC3E8", Offset = "0xBEC3E8", VA = "0xBEC3E8")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xBEC4D8", Offset = "0xBEC4D8", VA = "0xBEC4D8")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xBEC530", Offset = "0xBEC530", VA = "0xBEC530")]
		public void Speak()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xBECD48", Offset = "0xBECD48", VA = "0xBECD48")]
		public void Silence()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xBECDF8", Offset = "0xBECDF8", VA = "0xBECDF8")]
		[IteratorStateMachine(typeof(<processStack>d__42))]
		private IEnumerator processStack()
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xBEC32C", Offset = "0xBEC32C", VA = "0xBEC32C")]
		private void play()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xBECE88", Offset = "0xBECE88", VA = "0xBECE88")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xBECE8C", Offset = "0xBECE8C", VA = "0xBECE8C")]
		private void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xBECEC4", Offset = "0xBECEC4", VA = "0xBECEC4")]
		private void onStart()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xBECF88", Offset = "0xBECF88", VA = "0xBECF88")]
		private void onComplete()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xBED04C", Offset = "0xBED04C", VA = "0xBED04C")]
		public Paralanguage()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_sequencer.html")]
	public class Sequencer : MonoBehaviour
	{
		[Token(Token = "0x2000154")]
		[CompilerGenerated]
		private sealed class <playMe>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Sequencer <>4__this;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence seq;

			[Token(Token = "0x17000115")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600096F")]
				[Address(RVA = "0xBEF6C8", Offset = "0xBEF6C8", VA = "0xBEF6C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000971")]
				[Address(RVA = "0xBEF710", Offset = "0xBEF710", VA = "0xBEF710", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0xBEF388", Offset = "0xBEF388", VA = "0xBEF388")]
			[DebuggerHidden]
			public <playMe>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0xBEF444", Offset = "0xBEF444", VA = "0xBEF444", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0xBEF448", Offset = "0xBEF448", VA = "0xBEF448", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0xBEF6D0", Offset = "0xBEF6D0", VA = "0xBEF6D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("All available sequences.")]
		public Sequence[] Sequences;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Delay in seconds before the Sequencer starts processing (default: 0).")]
		public float Delay;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Enable the Sequencer on start (default: false).")]
		[Header("Behaviour Settings")]
		public bool PlayOnStart;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int currentIndex;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string uidCurrentSpeaker;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool playAllSequences;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool played;

		[Token(Token = "0x17000114")]
		public Sequence CurrentSequence
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0xBEEA28", Offset = "0xBEEA28", VA = "0xBEEA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xBEEA5C", Offset = "0xBEEA5C", VA = "0xBEEA5C")]
		public void Start()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xBEEC14", Offset = "0xBEEC14", VA = "0xBEEC14")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xBEED14", Offset = "0xBEED14", VA = "0xBEED14")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xBEF0E4", Offset = "0xBEF0E4", VA = "0xBEF0E4")]
		public void PlaySequence(int index = 0)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xBEF288", Offset = "0xBEF288", VA = "0xBEF288")]
		public void PlayNextSequence()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xBEF290", Offset = "0xBEF290", VA = "0xBEF290")]
		public void PlayAllSequences()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xBEF2B4", Offset = "0xBEF2B4", VA = "0xBEF2B4")]
		public void StopAllSequences()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xBEF31C", Offset = "0xBEF31C", VA = "0xBEF31C")]
		private void speakCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xBEF384", Offset = "0xBEF384", VA = "0xBEF384")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xBEEB64", Offset = "0xBEEB64", VA = "0xBEEB64")]
		private void play()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xBEF214", Offset = "0xBEF214", VA = "0xBEF214")]
		[IteratorStateMachine(typeof(<playMe>d__19))]
		private IEnumerator playMe(Sequence seq)
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xBEF3B0", Offset = "0xBEF3B0", VA = "0xBEF3B0")]
		public Sequencer()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_speech_text.html")]
	public class SpeechText : MonoBehaviour
	{
		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Text to speak.")]
		[Multiline]
		public string Text;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Voices for the speech.")]
		public VoiceAlias Voices;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Speak mode (default: 'Speak').")]
		public SpeakMode Mode;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Optional Settings")]
		[Tooltip("AudioSource for the output (optional).")]
		public AudioSource Source;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Speech rate of the speaker in percent (1 = 100%, default: 1, optional).")]
		[Range(0f, 3f)]
		public float Rate;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 2f)]
		[Tooltip("Speech pitch of the speaker in percent (1 = 100%, default: 1, optional, mobile only).")]
		public float Pitch;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Volume of the speaker in percent (1 = 100%, default: 1, optional, Windows only).")]
		[Range(0f, 1f)]
		public float Volume;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("Behaviour Settings")]
		[Tooltip("Enable speaking of the text on start (default: false).")]
		public bool PlayOnStart;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Delay in seconds until the speech for this text starts (default: 0).")]
		public float Delay;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Header("Output File Settings")]
		[Tooltip("Generate audio file on/off (default: false).")]
		public bool GenerateAudioFile;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("File name (incl. path) for the generated audio.")]
		public string FileName;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Is the generated file path inside the Assets-folder (current project)? If this option is enabled, it prefixes the path with 'Application.dataPath'.")]
		public bool FileInsideAssets;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string uid;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool played;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastSpeaktime;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SpeechTextStart _onStart;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SpeechTextComplete _onComplete;

		[Token(Token = "0x17000117")]
		public string CurrentText
		{
			[Token(Token = "0x6000976")]
			[Address(RVA = "0xBEF918", Offset = "0xBEF918", VA = "0xBEF918")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000977")]
			[Address(RVA = "0xBEF920", Offset = "0xBEF920", VA = "0xBEF920")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public float CurrentRate
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0xBEF928", Offset = "0xBEF928", VA = "0xBEF928")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000979")]
			[Address(RVA = "0xBEF930", Offset = "0xBEF930", VA = "0xBEF930")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public float CurrentPitch
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0xBEF938", Offset = "0xBEF938", VA = "0xBEF938")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600097B")]
			[Address(RVA = "0xBEF940", Offset = "0xBEF940", VA = "0xBEF940")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public float CurrentVolume
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0xBEF948", Offset = "0xBEF948", VA = "0xBEF948")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600097D")]
			[Address(RVA = "0xBEF950", Offset = "0xBEF950", VA = "0xBEF950")]
			set
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event SpeechTextStart OnSpeechTextStart
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0xBEF718", Offset = "0xBEF718", VA = "0xBEF718")]
			add
			{
			}
			[Token(Token = "0x6000973")]
			[Address(RVA = "0xBEF798", Offset = "0xBEF798", VA = "0xBEF798")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event SpeechTextComplete OnSpeechTextComplete
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0xBEF818", Offset = "0xBEF818", VA = "0xBEF818")]
			add
			{
			}
			[Token(Token = "0x6000975")]
			[Address(RVA = "0xBEF898", Offset = "0xBEF898", VA = "0xBEF898")]
			remove
			{
			}
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xBEF958", Offset = "0xBEF958", VA = "0xBEF958")]
		public void Start()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0xBEFB74", Offset = "0xBEFB74", VA = "0xBEFB74")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xBEFCC8", Offset = "0xBEFCC8", VA = "0xBEFCC8")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xBEFD90", Offset = "0xBEFD90", VA = "0xBEFD90")]
		public void Speak()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xBF0048", Offset = "0xBF0048", VA = "0xBF0048")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xBEFAB4", Offset = "0xBEFAB4", VA = "0xBEFAB4")]
		private void play()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xBF00F4", Offset = "0xBF00F4", VA = "0xBF00F4")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xBF00F8", Offset = "0xBF00F8", VA = "0xBF00F8")]
		private void onSpeakStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xBF01C0", Offset = "0xBF01C0", VA = "0xBF01C0")]
		private void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xBF00FC", Offset = "0xBF00FC", VA = "0xBF00FC")]
		private void onStart()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xBF01C4", Offset = "0xBF01C4", VA = "0xBF01C4")]
		private void onComplete()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xBF0288", Offset = "0xBF0288", VA = "0xBF0288")]
		public SpeechText()
		{
		}
	}
	[Token(Token = "0x2000156")]
	[ExecuteInEditMode]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_text_file_speaker.html")]
	public class TextFileSpeaker : MonoBehaviour
	{
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Text files to speak.")]
		public TextAsset[] TextFiles;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Voices for the speech.")]
		public VoiceAlias Voices;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Speak mode (default: 'Speak').")]
		public SpeakMode Mode;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Header("Behaviour Settings")]
		[Tooltip("Enable speaking of a random text file on start (default: false).")]
		public bool PlayOnStart;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Tooltip("Enable speaking of a random text file on start (default: false).")]
		public bool PlayAllOnStart;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		[Tooltip("Speaks the text files in random order (default: false).")]
		public bool SpeakRandom;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Delay until the speech for this text starts (default: 0).")]
		public float Delay;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Optional Settings")]
		[Tooltip("AudioSource for the output (optional).")]
		public AudioSource Source;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 3f)]
		[Tooltip("Speech rate of the speaker in percent (1 = 100%, default: 1, optional).")]
		public float Rate;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 2f)]
		[Tooltip("Speech pitch of the speaker in percent (1 = 100%, default: 1, optional, mobile only).")]
		public float Pitch;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Volume of the speaker in percent (1 = 100%, default: 1, optional, Windows only).")]
		[Range(0f, 1f)]
		public float Volume;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string[] texts;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string[] randomTexts;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int textIndex;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int randomTextIndex;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random rnd;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string uid;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool played;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool playAll;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float lastSpeaktime;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int lastNumberOfTextfiles;

		[Token(Token = "0x1700011B")]
		public float CurrentRate
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0xBF0324", Offset = "0xBF0324", VA = "0xBF0324")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600098B")]
			[Address(RVA = "0xBF032C", Offset = "0xBF032C", VA = "0xBF032C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public float CurrentPitch
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0xBF0334", Offset = "0xBF0334", VA = "0xBF0334")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600098D")]
			[Address(RVA = "0xBF033C", Offset = "0xBF033C", VA = "0xBF033C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public float CurrentVolume
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0xBF0344", Offset = "0xBF0344", VA = "0xBF0344")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600098F")]
			[Address(RVA = "0xBF034C", Offset = "0xBF034C", VA = "0xBF034C")]
			set
			{
			}
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xBF0354", Offset = "0xBF0354", VA = "0xBF0354")]
		public void Start()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xBF0774", Offset = "0xBF0774", VA = "0xBF0774")]
		public void Update()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xBF07A4", Offset = "0xBF07A4", VA = "0xBF07A4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xBF08A4", Offset = "0xBF08A4", VA = "0xBF08A4")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xBF08FC", Offset = "0xBF08FC", VA = "0xBF08FC")]
		public void SpeakAll()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xBF0914", Offset = "0xBF0914", VA = "0xBF0914")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xBF090C", Offset = "0xBF090C", VA = "0xBF090C")]
		public void Next()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xBF09C8", Offset = "0xBF09C8", VA = "0xBF09C8")]
		public void Next(bool random)
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xBF0E00", Offset = "0xBF0E00", VA = "0xBF0E00")]
		public void Previous()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xBF0E08", Offset = "0xBF0E08", VA = "0xBF0E08")]
		public void Previous(bool random)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xBF0E90", Offset = "0xBF0E90", VA = "0xBF0E90")]
		public void Speak()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xBF0A40", Offset = "0xBF0A40", VA = "0xBF0A40")]
		public string SpeakText(int index = -1, bool random = false)
		{
			return null;
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xBF091C", Offset = "0xBF091C", VA = "0xBF091C")]
		public void Silence()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xBF0464", Offset = "0xBF0464", VA = "0xBF0464")]
		public void Reload()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xBF0664", Offset = "0xBF0664", VA = "0xBF0664")]
		private void play()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xBF0E98", Offset = "0xBF0E98", VA = "0xBF0E98")]
		private string speak(string text)
		{
			return null;
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xBF0FCC", Offset = "0xBF0FCC", VA = "0xBF0FCC")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xBF0FD0", Offset = "0xBF0FD0", VA = "0xBF0FD0")]
		private void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xBF1058", Offset = "0xBF1058", VA = "0xBF1058")]
		public TextFileSpeaker()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[HelpURL("https://crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_voice_initalizer.html")]
	public class VoiceInitalizer : MonoBehaviour
	{
		[Token(Token = "0x2000158")]
		[CompilerGenerated]
		private sealed class <initalizeVoices>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceInitalizer <>4__this;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<Voice>.Enumerator <>7__wrap1;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string[] <>7__wrap2;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <>7__wrap3;

			[Token(Token = "0x1700011E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009AF")]
				[Address(RVA = "0xBF1A6C", Offset = "0xBF1A6C", VA = "0xBF1A6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B1")]
				[Address(RVA = "0xBF1AB4", Offset = "0xBF1AB4", VA = "0xBF1AB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xBF1474", Offset = "0xBF1474", VA = "0xBF1474")]
			[DebuggerHidden]
			public <initalizeVoices>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xBF1604", Offset = "0xBF1604", VA = "0xBF1604", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xBF1620", Offset = "0xBF1620", VA = "0xBF1620", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0xBF1A1C", Offset = "0xBF1A1C", VA = "0xBF1A1C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0xBF1A74", Offset = "0xBF1A74", VA = "0xBF1A74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Selected provider to initalize the voices (default: Android).")]
		public ProviderType Provider;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Initialize voices by name.")]
		public string[] VoiceNames;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Initialize all voices (default: false).")]
		public bool AllVoices;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Header("Behaviour Settings")]
		[Tooltip("Destroy the gameobject after initialize (default: true).")]
		public bool DestroyWhenFinished;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string activeUid;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string completedUid;

		[Token(Token = "0x400092C")]
		private const string text = "crosstales";

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xBF1148", Offset = "0xBF1148", VA = "0xBF1148")]
		public void Start()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xBF120C", Offset = "0xBF120C", VA = "0xBF120C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xBF130C", Offset = "0xBF130C", VA = "0xBF130C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xBF140C", Offset = "0xBF140C", VA = "0xBF140C")]
		[IteratorStateMachine(typeof(<initalizeVoices>d__10))]
		private IEnumerator initalizeVoices()
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xBF149C", Offset = "0xBF149C", VA = "0xBF149C")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xBF1580", Offset = "0xBF1580", VA = "0xBF1580")]
		private void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xBF159C", Offset = "0xBF159C", VA = "0xBF159C")]
		public VoiceInitalizer()
		{
		}
	}
	[Token(Token = "0x2000159")]
	[HelpURL("https://crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_voice_initalizer.html")]
	public class VoiceInitializer : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		[CompilerGenerated]
		private sealed class <initalizeVoices>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceInitializer <>4__this;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<Voice>.Enumerator <>7__wrap1;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator<Voice> <>7__wrap2;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C3")]
				[Address(RVA = "0xBF294C", Offset = "0xBF294C", VA = "0xBF294C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C5")]
				[Address(RVA = "0xBF2994", Offset = "0xBF2994", VA = "0xBF2994", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0xBF1DE8", Offset = "0xBF1DE8", VA = "0xBF1DE8")]
			[DebuggerHidden]
			public <initalizeVoices>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0xBF20BC", Offset = "0xBF20BC", VA = "0xBF20BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0xBF20F0", Offset = "0xBF20F0", VA = "0xBF20F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xBF284C", Offset = "0xBF284C", VA = "0xBF284C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0xBF289C", Offset = "0xBF289C", VA = "0xBF289C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0xBF2954", Offset = "0xBF2954", VA = "0xBF2954", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Selected provider to initialize the voices (default: Android).")]
		public ProviderType Provider;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Initialize voices by name.")]
		public string[] VoiceNames;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Initialize all voices (default: false).")]
		public bool AllVoices;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Destroy the gameobject after initialize (default: true).")]
		[Header("Behaviour Settings")]
		public bool DestroyWhenFinished;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string activeUid;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string completedUid;

		[Token(Token = "0x4000939")]
		private const string text = "crosstales";

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xBF1ABC", Offset = "0xBF1ABC", VA = "0xBF1ABC")]
		public void Start()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xBF1B80", Offset = "0xBF1B80", VA = "0xBF1B80")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xBF1C80", Offset = "0xBF1C80", VA = "0xBF1C80")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xBF1D80", Offset = "0xBF1D80", VA = "0xBF1D80")]
		[IteratorStateMachine(typeof(<initalizeVoices>d__10))]
		private IEnumerator initalizeVoices()
		{
			return null;
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xBF1E10", Offset = "0xBF1E10", VA = "0xBF1E10")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xBF1EF4", Offset = "0xBF1EF4", VA = "0xBF1EF4")]
		private void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xBF1F10", Offset = "0xBF1F10", VA = "0xBF1F10")]
		public VoiceInitializer()
		{
		}
	}
}
namespace Crosstales.RTVoice.Provider
{
	[Token(Token = "0x200015C")]
	public abstract class BaseCustomVoiceProvider : MonoBehaviour, IVoiceProvider
	{
		[Token(Token = "0x200015E")]
		[CompilerGenerated]
		private sealed class <playAudioFile>d__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isLocalFile;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string outputFile;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string url;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public AudioType type;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Dictionary<string, string> headers;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public BaseCustomVoiceProvider <>4__this;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool isNative;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private AudioClip <ac>5__3;

			[Token(Token = "0x17000133")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A09")]
				[Address(RVA = "0xBF5D5C", Offset = "0xBF5D5C", VA = "0xBF5D5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000134")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0xBF5DA4", Offset = "0xBF5DA4", VA = "0xBF5DA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0xBF3B14", Offset = "0xBF3B14", VA = "0xBF3B14")]
			[DebuggerHidden]
			public <playAudioFile>d__83(int <>1__state)
			{
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xBF5098", Offset = "0xBF5098", VA = "0xBF5098", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xBF50C4", Offset = "0xBF50C4", VA = "0xBF50C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xBF5CAC", Offset = "0xBF5CAC", VA = "0xBF5CAC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0xBF5D64", Offset = "0xBF5D64", VA = "0xBF5D64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<Voice> cachedVoices;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<string> cachedCultures;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected bool silence;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static char[] splitCharWords;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VoicesReady _onVoicesReady;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SpeakStart _onSpeakStart;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpeakComplete _onSpeakComplete;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpeakCurrentWord _onSpeakCurrentWord;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SpeakCurrentPhoneme _onSpeakCurrentPhoneme;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SpeakCurrentViseme _onSpeakCurrentViseme;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SpeakAudioGenerationStart _onSpeakAudioGenerationStart;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SpeakAudioGenerationComplete _onSpeakAudioGenerationComplete;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ErrorInfo _onErrorInfo;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool isActive1;

		[Token(Token = "0x17000122")]
		public bool isActive
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xBF329C", Offset = "0xBF329C", VA = "0xBF329C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xBF32A4", Offset = "0xBF32A4", VA = "0xBF32A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public abstract string AudioFileExtension
		{
			[Token(Token = "0x60009DA")]
			get;
		}

		[Token(Token = "0x17000124")]
		public abstract AudioType AudioFileType
		{
			[Token(Token = "0x60009DB")]
			get;
		}

		[Token(Token = "0x17000125")]
		public abstract string DefaultVoiceName
		{
			[Token(Token = "0x60009DC")]
			get;
		}

		[Token(Token = "0x17000126")]
		public virtual List<Voice> Voices
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xBF32B0", Offset = "0xBF32B0", VA = "0xBF32B0", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		public abstract bool isWorkingInEditor
		{
			[Token(Token = "0x60009DE")]
			get;
		}

		[Token(Token = "0x17000128")]
		public abstract bool isWorkingInPlaymode
		{
			[Token(Token = "0x60009DF")]
			get;
		}

		[Token(Token = "0x17000129")]
		public abstract int MaxTextLength
		{
			[Token(Token = "0x60009E0")]
			get;
		}

		[Token(Token = "0x1700012A")]
		public abstract bool isSpeakNativeSupported
		{
			[Token(Token = "0x60009E1")]
			get;
		}

		[Token(Token = "0x1700012B")]
		public abstract bool isSpeakSupported
		{
			[Token(Token = "0x60009E2")]
			get;
		}

		[Token(Token = "0x1700012C")]
		public abstract bool isPlatformSupported
		{
			[Token(Token = "0x60009E3")]
			get;
		}

		[Token(Token = "0x1700012D")]
		public abstract bool isSSMLSupported
		{
			[Token(Token = "0x60009E4")]
			get;
		}

		[Token(Token = "0x1700012E")]
		public abstract bool isOnlineService
		{
			[Token(Token = "0x60009E5")]
			get;
		}

		[Token(Token = "0x1700012F")]
		public abstract bool hasCoRoutines
		{
			[Token(Token = "0x60009E6")]
			get;
		}

		[Token(Token = "0x17000130")]
		public abstract bool isIL2CPPSupported
		{
			[Token(Token = "0x60009E7")]
			get;
		}

		[Token(Token = "0x17000131")]
		public abstract bool hasVoicesInEditor
		{
			[Token(Token = "0x60009E8")]
			get;
		}

		[Token(Token = "0x17000132")]
		public List<string> Cultures
		{
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0xBF32B8", Offset = "0xBF32B8", VA = "0xBF32B8", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000011")]
		public event VoicesReady OnVoicesReady
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xBF299C", Offset = "0xBF299C", VA = "0xBF299C")]
			add
			{
			}
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xBF2A1C", Offset = "0xBF2A1C", VA = "0xBF2A1C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event SpeakStart OnSpeakStart
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xBF2A9C", Offset = "0xBF2A9C", VA = "0xBF2A9C")]
			add
			{
			}
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xBF2B1C", Offset = "0xBF2B1C", VA = "0xBF2B1C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event SpeakComplete OnSpeakComplete
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xBF2B9C", Offset = "0xBF2B9C", VA = "0xBF2B9C")]
			add
			{
			}
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xBF2C1C", Offset = "0xBF2C1C", VA = "0xBF2C1C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event SpeakCurrentWord OnSpeakCurrentWord
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xBF2C9C", Offset = "0xBF2C9C", VA = "0xBF2C9C")]
			add
			{
			}
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xBF2D1C", Offset = "0xBF2D1C", VA = "0xBF2D1C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event SpeakCurrentPhoneme OnSpeakCurrentPhoneme
		{
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xBF2D9C", Offset = "0xBF2D9C", VA = "0xBF2D9C")]
			add
			{
			}
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xBF2E1C", Offset = "0xBF2E1C", VA = "0xBF2E1C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event SpeakCurrentViseme OnSpeakCurrentViseme
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xBF2E9C", Offset = "0xBF2E9C", VA = "0xBF2E9C")]
			add
			{
			}
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xBF2F1C", Offset = "0xBF2F1C", VA = "0xBF2F1C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event SpeakAudioGenerationStart OnSpeakAudioGenerationStart
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xBF2F9C", Offset = "0xBF2F9C", VA = "0xBF2F9C")]
			add
			{
			}
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0xBF301C", Offset = "0xBF301C", VA = "0xBF301C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event SpeakAudioGenerationComplete OnSpeakAudioGenerationComplete
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0xBF309C", Offset = "0xBF309C", VA = "0xBF309C")]
			add
			{
			}
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0xBF311C", Offset = "0xBF311C", VA = "0xBF311C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xBF319C", Offset = "0xBF319C", VA = "0xBF319C")]
			add
			{
			}
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0xBF321C", Offset = "0xBF321C", VA = "0xBF321C")]
			remove
			{
			}
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xBF38F8", Offset = "0xBF38F8", VA = "0xBF38F8", Slot = "40")]
		public virtual void Silence()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xBF3904", Offset = "0xBF3904", VA = "0xBF3904", Slot = "41")]
		public virtual void Silence(string uid)
		{
		}

		[Token(Token = "0x60009EC")]
		public abstract IEnumerator SpeakNative(Wrapper wrapper);

		[Token(Token = "0x60009ED")]
		public abstract IEnumerator Speak(Wrapper wrapper);

		[Token(Token = "0x60009EE")]
		public abstract IEnumerator Generate(Wrapper wrapper);

		[Token(Token = "0x60009EF")]
		public abstract void Load();

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xBF3908", Offset = "0xBF3908", VA = "0xBF3908")]
		protected string getOutputFile(string uid, bool isPersistentData = false)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xBF3A54", Offset = "0xBF3A54", VA = "0xBF3A54", Slot = "46")]
		[IteratorStateMachine(typeof(<playAudioFile>d__83))]
		protected virtual IEnumerator playAudioFile(Wrapper wrapper, string url, string outputFile, AudioType type = AudioType.WAV, bool isNative = false, bool isLocalFile = true, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xBF3B3C", Offset = "0xBF3B3C", VA = "0xBF3B3C", Slot = "47")]
		protected virtual void copyAudioFile(Wrapper wrapper, string outputFile, bool isLocalFile = true, [Optional] byte[] data)
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xBF3FFC", Offset = "0xBF3FFC", VA = "0xBF3FFC", Slot = "48")]
		protected virtual void processAudioFile(Wrapper wrapper, string outputFile, bool isLocalFile = true, [Optional] byte[] data)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xBF4564", Offset = "0xBF4564", VA = "0xBF4564", Slot = "49")]
		protected virtual string getVoiceName(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xBF4654", Offset = "0xBF4654", VA = "0xBF4654")]
		protected void onVoicesReady()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xBF4718", Offset = "0xBF4718", VA = "0xBF4718")]
		protected void onSpeakStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xBF4828", Offset = "0xBF4828", VA = "0xBF4828")]
		protected void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xBF4938", Offset = "0xBF4938", VA = "0xBF4938")]
		protected void onSpeakCurrentWord(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xBF4B34", Offset = "0xBF4B34", VA = "0xBF4B34")]
		protected void onSpeakCurrentPhoneme(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xBF4C6C", Offset = "0xBF4C6C", VA = "0xBF4C6C")]
		protected void onSpeakCurrentViseme(Wrapper wrapper, string viseme)
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xBF4DA4", Offset = "0xBF4DA4", VA = "0xBF4DA4")]
		protected void onSpeakAudioGenerationStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xBF4454", Offset = "0xBF4454", VA = "0xBF4454")]
		protected void onSpeakAudioGenerationComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xBF3F04", Offset = "0xBF3F04", VA = "0xBF3F04")]
		protected void onErrorInfo(Wrapper wrapper, string info)
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xBF4EB4", Offset = "0xBF4EB4", VA = "0xBF4EB4")]
		protected BaseCustomVoiceProvider()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public abstract class BaseVoiceProvider : IVoiceProvider
	{
		[Token(Token = "0x2000161")]
		[CompilerGenerated]
		private sealed class <playAudioFile>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isLocalFile;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string outputFile;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string url;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public AudioType type;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Dictionary<string, string> headers;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public BaseVoiceProvider <>4__this;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool isNative;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private AudioClip <ac>5__3;

			[Token(Token = "0x17000145")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0xBF96B0", Offset = "0xBF96B0", VA = "0xBF96B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000146")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A4E")]
				[Address(RVA = "0xBF96F8", Offset = "0xBF96F8", VA = "0xBF96F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0xBF73D4", Offset = "0xBF73D4", VA = "0xBF73D4")]
			[DebuggerHidden]
			public <playAudioFile>d__81(int <>1__state)
			{
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0xBF8990", Offset = "0xBF8990", VA = "0xBF8990", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0xBF89BC", Offset = "0xBF89BC", VA = "0xBF89BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0xBF9600", Offset = "0xBF9600", VA = "0xBF9600")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0xBF96B8", Offset = "0xBF96B8", VA = "0xBF96B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<Voice> cachedVoices;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<string> cachedCultures;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly Dictionary<string, Process> processes;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected bool silence;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly char[] splitCharWords;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly MonoBehaviour speakerObj;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VoicesReady _onVoicesReady;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static SpeakStart _onSpeakStart;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static SpeakComplete _onSpeakComplete;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static SpeakCurrentWord _onSpeakCurrentWord;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static SpeakCurrentPhoneme _onSpeakCurrentPhoneme;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static SpeakCurrentViseme _onSpeakCurrentViseme;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static SpeakAudioGenerationStart _onSpeakAudioGenerationStart;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static SpeakAudioGenerationComplete _onSpeakAudioGenerationComplete;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static ErrorInfo _onErrorInfo;

		[Token(Token = "0x17000135")]
		public abstract string AudioFileExtension
		{
			[Token(Token = "0x6000A1F")]
			get;
		}

		[Token(Token = "0x17000136")]
		public abstract AudioType AudioFileType
		{
			[Token(Token = "0x6000A20")]
			get;
		}

		[Token(Token = "0x17000137")]
		public abstract string DefaultVoiceName
		{
			[Token(Token = "0x6000A21")]
			get;
		}

		[Token(Token = "0x17000138")]
		public virtual List<Voice> Voices
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0xBF6B70", Offset = "0xBF6B70", VA = "0xBF6B70", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		public abstract bool isWorkingInEditor
		{
			[Token(Token = "0x6000A23")]
			get;
		}

		[Token(Token = "0x1700013A")]
		public abstract bool isWorkingInPlaymode
		{
			[Token(Token = "0x6000A24")]
			get;
		}

		[Token(Token = "0x1700013B")]
		public abstract int MaxTextLength
		{
			[Token(Token = "0x6000A25")]
			get;
		}

		[Token(Token = "0x1700013C")]
		public abstract bool isSpeakNativeSupported
		{
			[Token(Token = "0x6000A26")]
			get;
		}

		[Token(Token = "0x1700013D")]
		public abstract bool isSpeakSupported
		{
			[Token(Token = "0x6000A27")]
			get;
		}

		[Token(Token = "0x1700013E")]
		public abstract bool isPlatformSupported
		{
			[Token(Token = "0x6000A28")]
			get;
		}

		[Token(Token = "0x1700013F")]
		public abstract bool isSSMLSupported
		{
			[Token(Token = "0x6000A29")]
			get;
		}

		[Token(Token = "0x17000140")]
		public abstract bool isOnlineService
		{
			[Token(Token = "0x6000A2A")]
			get;
		}

		[Token(Token = "0x17000141")]
		public abstract bool hasCoRoutines
		{
			[Token(Token = "0x6000A2B")]
			get;
		}

		[Token(Token = "0x17000142")]
		public abstract bool isIL2CPPSupported
		{
			[Token(Token = "0x6000A2C")]
			get;
		}

		[Token(Token = "0x17000143")]
		public abstract bool hasVoicesInEditor
		{
			[Token(Token = "0x6000A2D")]
			get;
		}

		[Token(Token = "0x17000144")]
		public List<string> Cultures
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0xBF6B78", Offset = "0xBF6B78", VA = "0xBF6B78", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400001A")]
		public static event VoicesReady OnVoicesReady
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0xBF5E80", Offset = "0xBF5E80", VA = "0xBF5E80")]
			add
			{
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0xBF5F38", Offset = "0xBF5F38", VA = "0xBF5F38")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public static event SpeakStart OnSpeakStart
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xBF5FF0", Offset = "0xBF5FF0", VA = "0xBF5FF0")]
			add
			{
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xBF60A8", Offset = "0xBF60A8", VA = "0xBF60A8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public static event SpeakComplete OnSpeakComplete
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xBF6160", Offset = "0xBF6160", VA = "0xBF6160")]
			add
			{
			}
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xBF6218", Offset = "0xBF6218", VA = "0xBF6218")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public static event SpeakCurrentWord OnSpeakCurrentWord
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0xBF62D0", Offset = "0xBF62D0", VA = "0xBF62D0")]
			add
			{
			}
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0xBF6388", Offset = "0xBF6388", VA = "0xBF6388")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public static event SpeakCurrentPhoneme OnSpeakCurrentPhoneme
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xBF6440", Offset = "0xBF6440", VA = "0xBF6440")]
			add
			{
			}
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0xBF64F8", Offset = "0xBF64F8", VA = "0xBF64F8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public static event SpeakCurrentViseme OnSpeakCurrentViseme
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0xBF65B0", Offset = "0xBF65B0", VA = "0xBF65B0")]
			add
			{
			}
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0xBF6668", Offset = "0xBF6668", VA = "0xBF6668")]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public static event SpeakAudioGenerationStart OnSpeakAudioGenerationStart
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0xBF6720", Offset = "0xBF6720", VA = "0xBF6720")]
			add
			{
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0xBF67D8", Offset = "0xBF67D8", VA = "0xBF67D8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000021")]
		public static event SpeakAudioGenerationComplete OnSpeakAudioGenerationComplete
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xBF6890", Offset = "0xBF6890", VA = "0xBF6890")]
			add
			{
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xBF6948", Offset = "0xBF6948", VA = "0xBF6948")]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public static event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xBF6A00", Offset = "0xBF6A00", VA = "0xBF6A00")]
			add
			{
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xBF6AB8", Offset = "0xBF6AB8", VA = "0xBF6AB8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xBF5DAC", Offset = "0xBF5DAC", VA = "0xBF5DAC")]
		protected BaseVoiceProvider(MonoBehaviour obj)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xBF71B8", Offset = "0xBF71B8", VA = "0xBF71B8", Slot = "40")]
		public virtual void Silence()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xBF71C4", Offset = "0xBF71C4", VA = "0xBF71C4", Slot = "41")]
		public virtual void Silence(string uid)
		{
		}

		[Token(Token = "0x6000A31")]
		public abstract IEnumerator SpeakNative(Wrapper wrapper);

		[Token(Token = "0x6000A32")]
		public abstract IEnumerator Speak(Wrapper wrapper);

		[Token(Token = "0x6000A33")]
		public abstract IEnumerator Generate(Wrapper wrapper);

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xBF71C8", Offset = "0xBF71C8", VA = "0xBF71C8")]
		protected string getOutputFile(string uid, bool isPersistentData = false)
		{
			return null;
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xBF7314", Offset = "0xBF7314", VA = "0xBF7314", Slot = "45")]
		[IteratorStateMachine(typeof(<playAudioFile>d__81))]
		protected virtual IEnumerator playAudioFile(Wrapper wrapper, string url, string outputFile, AudioType type = AudioType.WAV, bool isNative = false, bool isLocalFile = true, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xBF73FC", Offset = "0xBF73FC", VA = "0xBF73FC")]
		private void copyAudioFile(Wrapper wrapper, string outputFile, bool isLocalFile = true, [Optional] byte[] data)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xBF7960", Offset = "0xBF7960", VA = "0xBF7960", Slot = "46")]
		protected virtual void processAudioFile(Wrapper wrapper, string outputFile, bool isLocalFile = true, [Optional] byte[] data)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xBF7CE4", Offset = "0xBF7CE4", VA = "0xBF7CE4", Slot = "47")]
		protected virtual string getVoiceName(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xBF7DD4", Offset = "0xBF7DD4", VA = "0xBF7DD4")]
		protected static void onVoicesReady()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xBF7EE0", Offset = "0xBF7EE0", VA = "0xBF7EE0")]
		protected static void onSpeakStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xBF8038", Offset = "0xBF8038", VA = "0xBF8038")]
		protected static void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xBF8190", Offset = "0xBF8190", VA = "0xBF8190")]
		protected static void onSpeakCurrentWord(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xBF83D0", Offset = "0xBF83D0", VA = "0xBF83D0")]
		protected static void onSpeakCurrentPhoneme(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xBF8550", Offset = "0xBF8550", VA = "0xBF8550")]
		protected static void onSpeakCurrentViseme(Wrapper wrapper, string viseme)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xBF86D0", Offset = "0xBF86D0", VA = "0xBF86D0")]
		protected static void onSpeakAudioGenerationStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xBF7B8C", Offset = "0xBF7B8C", VA = "0xBF7B8C")]
		protected static void onSpeakAudioGenerationComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xBF7820", Offset = "0xBF7820", VA = "0xBF7820")]
		protected static void onErrorInfo(Wrapper wrapper, string info)
		{
		}
	}
	[Token(Token = "0x2000162")]
	public interface IVoiceProvider
	{
		[Token(Token = "0x17000147")]
		string AudioFileExtension
		{
			[Token(Token = "0x6000A4F")]
			get;
		}

		[Token(Token = "0x17000148")]
		AudioType AudioFileType
		{
			[Token(Token = "0x6000A50")]
			get;
		}

		[Token(Token = "0x17000149")]
		string DefaultVoiceName
		{
			[Token(Token = "0x6000A51")]
			get;
		}

		[Token(Token = "0x1700014A")]
		List<Voice> Voices
		{
			[Token(Token = "0x6000A52")]
			get;
		}

		[Token(Token = "0x1700014B")]
		int MaxTextLength
		{
			[Token(Token = "0x6000A53")]
			get;
		}

		[Token(Token = "0x1700014C")]
		bool isWorkingInEditor
		{
			[Token(Token = "0x6000A54")]
			get;
		}

		[Token(Token = "0x1700014D")]
		bool isWorkingInPlaymode
		{
			[Token(Token = "0x6000A55")]
			get;
		}

		[Token(Token = "0x1700014E")]
		bool isSpeakNativeSupported
		{
			[Token(Token = "0x6000A56")]
			get;
		}

		[Token(Token = "0x1700014F")]
		bool isSpeakSupported
		{
			[Token(Token = "0x6000A57")]
			get;
		}

		[Token(Token = "0x17000150")]
		bool isPlatformSupported
		{
			[Token(Token = "0x6000A58")]
			get;
		}

		[Token(Token = "0x17000151")]
		bool isSSMLSupported
		{
			[Token(Token = "0x6000A59")]
			get;
		}

		[Token(Token = "0x17000152")]
		bool isOnlineService
		{
			[Token(Token = "0x6000A5A")]
			get;
		}

		[Token(Token = "0x17000153")]
		bool hasCoRoutines
		{
			[Token(Token = "0x6000A5B")]
			get;
		}

		[Token(Token = "0x17000154")]
		bool isIL2CPPSupported
		{
			[Token(Token = "0x6000A5C")]
			get;
		}

		[Token(Token = "0x17000155")]
		bool hasVoicesInEditor
		{
			[Token(Token = "0x6000A5D")]
			get;
		}

		[Token(Token = "0x17000156")]
		List<string> Cultures
		{
			[Token(Token = "0x6000A5E")]
			get;
		}

		[Token(Token = "0x6000A5F")]
		void Silence();

		[Token(Token = "0x6000A60")]
		void Silence(string uid);

		[Token(Token = "0x6000A61")]
		IEnumerator SpeakNative(Wrapper wrapper);

		[Token(Token = "0x6000A62")]
		IEnumerator Speak(Wrapper wrapper);

		[Token(Token = "0x6000A63")]
		IEnumerator Generate(Wrapper wrapper);
	}
	[Token(Token = "0x2000163")]
	public class VoiceProviderAndroid : BaseVoiceProvider
	{
		[Token(Token = "0x2000164")]
		[CompilerGenerated]
		private sealed class <SpeakNative>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceProviderAndroid <>4__this;

			[Token(Token = "0x17000165")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A7D")]
				[Address(RVA = "0xBFA400", Offset = "0xBFA400", VA = "0xBFA400", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000166")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A7F")]
				[Address(RVA = "0xBFA448", Offset = "0xBFA448", VA = "0xBFA448", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0xBF9B68", Offset = "0xBF9B68", VA = "0xBF9B68")]
			[DebuggerHidden]
			public <SpeakNative>d__32(int <>1__state)
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0xBF9E90", Offset = "0xBF9E90", VA = "0xBF9E90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0xBF9E94", Offset = "0xBF9E94", VA = "0xBF9E94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0xBFA408", Offset = "0xBFA408", VA = "0xBFA408", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000165")]
		[CompilerGenerated]
		private sealed class <Speak>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceProviderAndroid <>4__this;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <outputFile>5__2;

			[Token(Token = "0x17000167")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A83")]
				[Address(RVA = "0xBFAA6C", Offset = "0xBFAA6C", VA = "0xBFAA6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000168")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A85")]
				[Address(RVA = "0xBFAAB4", Offset = "0xBFAAB4", VA = "0xBFAAB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0xBF9C04", Offset = "0xBF9C04", VA = "0xBF9C04")]
			[DebuggerHidden]
			public <Speak>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0xBFA450", Offset = "0xBFA450", VA = "0xBFA450", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0xBFA454", Offset = "0xBFA454", VA = "0xBFA454", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0xBFAA74", Offset = "0xBFAA74", VA = "0xBFAA74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000166")]
		[CompilerGenerated]
		private sealed class <Generate>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceProviderAndroid <>4__this;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <outputFile>5__2;

			[Token(Token = "0x17000169")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A89")]
				[Address(RVA = "0xBFAFF8", Offset = "0xBFAFF8", VA = "0xBFAFF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A8B")]
				[Address(RVA = "0xBFB040", Offset = "0xBFB040", VA = "0xBFB040", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0xBF9CA0", Offset = "0xBF9CA0", VA = "0xBF9CA0")]
			[DebuggerHidden]
			public <Generate>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0xBFAABC", Offset = "0xBFAABC", VA = "0xBFAABC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0xBFAAC0", Offset = "0xBFAAC0", VA = "0xBFAAC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0xBFB000", Offset = "0xBFB000", VA = "0xBFB000", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000168")]
		[CompilerGenerated]
		private sealed class <getVoices>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceProviderAndroid <>4__this;

			[Token(Token = "0x1700016B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A92")]
				[Address(RVA = "0xBFB988", Offset = "0xBFB988", VA = "0xBFB988", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A94")]
				[Address(RVA = "0xBFB9D0", Offset = "0xBFB9D0", VA = "0xBFB9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0xBF9E68", Offset = "0xBF9E68", VA = "0xBF9E68")]
			[DebuggerHidden]
			public <getVoices>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0xBFB0CC", Offset = "0xBFB0CC", VA = "0xBFB0CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0xBFB0D0", Offset = "0xBFB0D0", VA = "0xBFB0D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0xBFB990", Offset = "0xBFB990", VA = "0xBFB990", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool isInitialized;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaObject TtsHandler;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly WaitForSeconds wfs;

		[Token(Token = "0x17000157")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0xBF99CC", Offset = "0xBF99CC", VA = "0xBF99CC", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		public override AudioType AudioFileType
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0xBF9A0C", Offset = "0xBF9A0C", VA = "0xBF9A0C", Slot = "26")]
			get
			{
				return default(AudioType);
			}
		}

		[Token(Token = "0x17000159")]
		public override string DefaultVoiceName
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0xBF9A14", Offset = "0xBF9A14", VA = "0xBF9A14", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		public override bool isWorkingInEditor
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0xBF9A54", Offset = "0xBF9A54", VA = "0xBF9A54", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015B")]
		public override bool isWorkingInPlaymode
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0xBF9A5C", Offset = "0xBF9A5C", VA = "0xBF9A5C", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015C")]
		public override int MaxTextLength
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0xBF9A64", Offset = "0xBF9A64", VA = "0xBF9A64", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015D")]
		public override bool isSpeakNativeSupported
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0xBF9A6C", Offset = "0xBF9A6C", VA = "0xBF9A6C", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015E")]
		public override bool isSpeakSupported
		{
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0xBF9A74", Offset = "0xBF9A74", VA = "0xBF9A74", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015F")]
		public override bool isPlatformSupported
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0xBF9A7C", Offset = "0xBF9A7C", VA = "0xBF9A7C", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000160")]
		public override bool isSSMLSupported
		{
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0xBF9ACC", Offset = "0xBF9ACC", VA = "0xBF9ACC", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000161")]
		public override bool isOnlineService
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0xBF9AD4", Offset = "0xBF9AD4", VA = "0xBF9AD4", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000162")]
		public override bool hasCoRoutines
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0xBF9ADC", Offset = "0xBF9ADC", VA = "0xBF9ADC", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000163")]
		public override bool isIL2CPPSupported
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0xBF9AE4", Offset = "0xBF9AE4", VA = "0xBF9AE4", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000164")]
		public override bool hasVoicesInEditor
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0xBF9AEC", Offset = "0xBF9AEC", VA = "0xBF9AEC", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xBF9700", Offset = "0xBF9700", VA = "0xBF9700")]
		public VoiceProviderAndroid(MonoBehaviour obj)
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xBF9AF4", Offset = "0xBF9AF4", VA = "0xBF9AF4", Slot = "42")]
		[IteratorStateMachine(typeof(<SpeakNative>d__32))]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xBF9B90", Offset = "0xBF9B90", VA = "0xBF9B90", Slot = "43")]
		[IteratorStateMachine(typeof(<Speak>d__33))]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xBF9C2C", Offset = "0xBF9C2C", VA = "0xBF9C2C", Slot = "44")]
		[IteratorStateMachine(typeof(<Generate>d__34))]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xBF9CC8", Offset = "0xBF9CC8", VA = "0xBF9CC8", Slot = "40")]
		public override void Silence()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xBF9DA4", Offset = "0xBF9DA4", VA = "0xBF9DA4")]
		public static void ShutdownTTS()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xBF9964", Offset = "0xBF9964", VA = "0xBF9964")]
		[IteratorStateMachine(typeof(<getVoices>d__37))]
		private IEnumerator getVoices()
		{
			return null;
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xBF97E8", Offset = "0xBF97E8", VA = "0xBF97E8")]
		private void initializeTTS()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class VoiceProviderMary : BaseVoiceProvider
	{
		[Token(Token = "0x200016A")]
		[CompilerGenerated]
		private sealed class <SpeakNative>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceProviderMary <>4__this;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Wrapper wrapper;

			[Token(Token = "0x1700017B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AAE")]
				[Address(RVA = "0xBFC48C", Offset = "0xBFC48C", VA = "0xBFC48C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB0")]
				[Address(RVA = "0xBFC4D4", Offset = "0xBFC4D4", VA = "0xBFC4D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0xBFBE1C", Offset = "0xBFBE1C", VA = "0xBFBE1C")]
			[DebuggerHidden]
			public <SpeakNative>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0xBFC424", Offset = "0xBFC424", VA = "0xBFC424", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0xBFC428", Offset = "0xBFC428", VA = "0xBFC428", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xBFC494", Offset = "0xBFC494", VA = "0xBFC494", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016B")]
		[CompilerGenerated]
		private sealed class <Speak>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceProviderMary <>4__this;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Wrapper wrapper;

			[Token(Token = "0x1700017D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB4")]
				[Address(RVA = "0xBFC53C", Offset = "0xBFC53C", VA = "0xBFC53C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB6")]
				[Address(RVA = "0xBFC584", Offset = "0xBFC584", VA = "0xBFC584", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0xBFBEB8", Offset = "0xBFBEB8", VA = "0xBFBEB8")]
			[DebuggerHidden]
			public <Speak>d__32(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xBFC4DC", Offset = "0xBFC4DC", VA = "0xBFC4DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xBFC4E0", Offset = "0xBFC4E0", VA = "0xBFC4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xBFC544", Offset = "0xBFC544", VA = "0xBFC544", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016C")]
		[CompilerGenerated]
		private sealed class <Generate>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceProviderMary <>4__this;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700017F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ABB")]
				[Address(RVA = "0xBFDB94", Offset = "0xBFDB94", VA = "0xBFDB94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000180")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ABD")]
				[Address(RVA = "0xBFDBDC", Offset = "0xBFDBDC", VA = "0xBFDBDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0xBFBF54", Offset = "0xBFBF54", VA = "0xBFBF54")]
			[DebuggerHidden]
			public <Generate>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xBFC58C", Offset = "0xBFC58C", VA = "0xBFC58C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0xBFC5A8", Offset = "0xBFC5A8", VA = "0xBFC5A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xBFDAE4", Offset = "0xBFDAE4", VA = "0xBFDAE4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0xBFDB9C", Offset = "0xBFDB9C", VA = "0xBFDB9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016D")]
		[CompilerGenerated]
		private sealed class <speak>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wrapper wrapper;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceProviderMary <>4__this;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isNative;

			[Token(Token = "0x17000181")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AC1")]
				[Address(RVA = "0xBFE760", Offset = "0xBFE760", VA = "0xBFE760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000182")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AC3")]
				[Address(RVA = "0xBFE7A8", Offset = "0xBFE7A8", VA = "0xBFE7A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xBFBFFC", Offset = "0xBFBFFC", VA = "0xBFBFFC")]
			[DebuggerHidden]
			public <speak>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0xBFDBE4", Offset = "0xBFDBE4", VA = "0xBFDBE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xBFDBE8", Offset = "0xBFDBE8", VA = "0xBFDBE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xBFE768", Offset = "0xBFE768", VA = "0xBFE768", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016F")]
		[CompilerGenerated]
		private sealed class <getVoices>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceProviderMary <>4__this;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<string[]> <serverVoicesResponse>5__2;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x17000183")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ACC")]
				[Address(RVA = "0xBFF68C", Offset = "0xBFF68C", VA = "0xBFF68C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000184")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ACE")]
				[Address(RVA = "0xBFF6D4", Offset = "0xBFF6D4", VA = "0xBFF6D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0xBFC024", Offset = "0xBFC024", VA = "0xBFC024")]
			[DebuggerHidden]
			public <getVoices>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0xBFE97C", Offset = "0xBFE97C", VA = "0xBFE97C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0xBFE998", Offset = "0xBFE998", VA = "0xBFE998", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xBFF5DC", Offset = "0xBFF5DC", VA = "0xBFF5DC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xBFF694", Offset = "0xBFF694", VA = "0xBFF694", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string uri;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<string, string> headers;

		[Token(Token = "0x1700016D")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0xBFBCC4", Offset = "0xBFBCC4", VA = "0xBFBCC4", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		public override AudioType AudioFileType
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0xBFBD04", Offset = "0xBFBD04", VA = "0xBFBD04", Slot = "26")]
			get
			{
				return default(AudioType);
			}
		}

		[Token(Token = "0x1700016F")]
		public override string DefaultVoiceName
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0xBFBD0C", Offset = "0xBFBD0C", VA = "0xBFBD0C", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000170")]
		public override bool isWorkingInEditor
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0xBFBD4C", Offset = "0xBFBD4C", VA = "0xBFBD4C", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000171")]
		public override bool isWorkingInPlaymode
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0xBFBD54", Offset = "0xBFBD54", VA = "0xBFBD54", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000172")]
		public override int MaxTextLength
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xBFBD5C", Offset = "0xBFBD5C", VA = "0xBFBD5C", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000173")]
		public override bool isSpeakNativeSupported
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xBFBD68", Offset = "0xBFBD68", VA = "0xBFBD68", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000174")]
		public override bool isSpeakSupported
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xBFBD70", Offset = "0xBFBD70", VA = "0xBFBD70", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000175")]
		public override bool isPlatformSupported
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xBFBD78", Offset = "0xBFBD78", VA = "0xBFBD78", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000176")]
		public override bool isSSMLSupported
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xBFBD80", Offset = "0xBFBD80", VA = "0xBFBD80", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000177")]
		public override bool isOnlineService
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0xBFBD88", Offset = "0xBFBD88", VA = "0xBFBD88", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000178")]
		public override bool hasCoRoutines
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0xBFBD90", Offset = "0xBFBD90", VA = "0xBFBD90", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000179")]
		public override bool isIL2CPPSupported
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xBFBD98", Offset = "0xBFBD98", VA = "0xBFBD98", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017A")]
		public override bool hasVoicesInEditor
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0xBFBDA0", Offset = "0xBFBDA0", VA = "0xBFBDA0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xBFB9D8", Offset = "0xBFB9D8", VA = "0xBFB9D8")]
		public VoiceProviderMary(MonoBehaviour obj, string url, int port = 59125, string user = "", string password = "")
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0xBFBDA8", Offset = "0xBFBDA8", VA = "0xBFBDA8", Slot = "42")]
		[IteratorStateMachine(typeof(<SpeakNative>d__31))]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xBFBE44", Offset = "0xBFBE44", VA = "0xBFBE44", Slot = "43")]
		[IteratorStateMachine(typeof(<Speak>d__32))]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xBFBEE0", Offset = "0xBFBEE0", VA = "0xBFBEE0", Slot = "44")]
		[IteratorStateMachine(typeof(<Generate>d__33))]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xBFBF7C", Offset = "0xBFBF7C", VA = "0xBFBF7C")]
		[IteratorStateMachine(typeof(<speak>d__34))]
		private IEnumerator speak(Wrapper wrapper, bool isNative)
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xBFBC5C", Offset = "0xBFBC5C", VA = "0xBFBC5C")]
		[IteratorStateMachine(typeof(<getVoices>d__35))]
		private IEnumerator getVoices()
		{
			return null;
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xBFC04C", Offset = "0xBFC04C", VA = "0xBFC04C")]
		private static string prepareProsody(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xBFC338", Offset = "0xBFC338", VA = "0xBFC338")]
		private static string getVoiceCulture(Wrapper wrapper)
		{
			return null;
		}
	}
}
namespace Crosstales.RTVoice.Model
{
	[Serializable]
	[Token(Token = "0x2000170")]
	public class Sequence
	{
		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Text to speak.")]
		[Multiline]
		public string Text;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Voices for the speech.")]
		public VoiceAlias Voices;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Speak mode (default: 'Speak').")]
		public SpeakMode Mode;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AudioSource for the output (optional).")]
		[Header("Optional Settings")]
		public AudioSource Source;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speech rate of the speaker in percent (1 = 100%, default: 1, optional).")]
		[Range(0f, 3f)]
		public float Rate;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Speech pitch of the speaker in percent (1 = 100%, default: 1, optional, mobile only).")]
		[Range(0f, 2f)]
		public float Pitch;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Volume of the speaker in percent (1 = 100%, default: 1, optional, Windows only).")]
		public float Volume;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		public bool initalized;

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0xBFF6DC", Offset = "0xBFF6DC", VA = "0xBFF6DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xBFF9E0", Offset = "0xBFF9E0", VA = "0xBFF9E0")]
		public Sequence()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000171")]
	public class Voice
	{
		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Name of the voice.")]
		public string Name;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Description of the voice.")]
		public string Description;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Gender of the voice.")]
		public Gender Gender;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Age of the voice.")]
		public string Age;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Identifier of the voice.")]
		public string Identifier;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Vendor of the voice.")]
		public string Vendor;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Version of the voice.")]
		public string Version;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Sample rate in Hz of the voice.")]
		public int SampleRate;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string culture;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string simplifiedCulture;

		[Token(Token = "0x17000185")]
		public string Culture
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0xBFFA48", Offset = "0xBFFA48", VA = "0xBFFA48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0xBFFA50", Offset = "0xBFFA50", VA = "0xBFFA50")]
			set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public string SimplifiedCulture
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0xBFFB18", Offset = "0xBFFB18", VA = "0xBFFB18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xBFFA9C", Offset = "0xBFFA9C", VA = "0xBFFA9C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0xBFB8B8", Offset = "0xBFB8B8", VA = "0xBFB8B8")]
		public Voice(string name, string description, Gender gender, string age, string culture, string id = "", string vendor = "unknown", string version = "unknown", int sampleRate = 0)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0xBFFB20", Offset = "0xBFFB20", VA = "0xBFFB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000172")]
	public class VoiceAlias
	{
		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Name of the voice under Windows.")]
		public string VoiceNameWindows;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Name of the voice under macOS.")]
		public string VoiceNameMac;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Name of the voice under Linux and for eSpeak.")]
		public string VoiceNameLinux;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Name of the voice under Android.")]
		public string VoiceNameAndroid;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Name of the voice under iOS.")]
		public string VoiceNameIOS;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Name of the voice under WSA.")]
		public string VoiceNameWSA;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Name of the voice under MaryTTS.")]
		public string VoiceNameMaryTTS;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Name of the voice for custom TTS-systems.")]
		public string VoiceNameCustom;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Fallback culture for the text (e.g. 'en', optional).")]
		public string Culture;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Fallback gender for the text.")]
		public Gender Gender;

		[Token(Token = "0x17000187")]
		public string VoiceName
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xBFFD18", Offset = "0xBFFD18", VA = "0xBFFD18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000188")]
		public Voice Voice
		{
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0xBEF604", Offset = "0xBEF604", VA = "0xBEF604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0xBFFEE4", Offset = "0xBFFEE4", VA = "0xBFFEE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xC00318", Offset = "0xC00318", VA = "0xC00318")]
		public VoiceAlias()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class Wrapper
	{
		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Uid;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource Source;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Voice Voice;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool SpeakImmediately;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string OutputFile;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ForceSSML;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string text;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float rate;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float pitch;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float volume;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string cachedString;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly DateTime created;

		[Token(Token = "0x17000189")]
		public string Text
		{
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0xBF41F0", Offset = "0xBF41F0", VA = "0xBF41F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0xC00418", Offset = "0xC00418", VA = "0xC00418")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public float Rate
		{
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0xC00424", Offset = "0xC00424", VA = "0xC00424")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0xC0042C", Offset = "0xC0042C", VA = "0xC0042C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public float Pitch
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0xC00448", Offset = "0xC00448", VA = "0xC00448")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0xC00450", Offset = "0xC00450", VA = "0xC00450")]
			set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public float Volume
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0xC0046C", Offset = "0xC0046C", VA = "0xC0046C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0xC00474", Offset = "0xC00474", VA = "0xC00474")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public DateTime Created
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0xC00490", Offset = "0xC00490", VA = "0xC00490")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x1700018E")]
		public float SpeechTime
		{
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0xC00498", Offset = "0xC00498", VA = "0xC00498")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0xC00568", Offset = "0xC00568", VA = "0xC00568")]
		public Wrapper()
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0xC00640", Offset = "0xC00640", VA = "0xC00640")]
		public Wrapper(string text, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f, bool forceSSML = true)
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0xC00794", Offset = "0xC00794", VA = "0xC00794")]
		public Wrapper(string text, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f, [Optional] AudioSource source, bool speakImmediately = true, string outputFile = "", bool forceSSML = true)
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0xC0090C", Offset = "0xC0090C", VA = "0xC0090C")]
		public Wrapper(string uid, string text, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f, [Optional] AudioSource source, bool speakImmediately = true, string outputFile = "", bool forceSSML = true)
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0xC00950", Offset = "0xC00950", VA = "0xC00950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Crosstales.RTVoice.Model.Enum
{
	[Token(Token = "0x2000174")]
	public enum ESpeakModifiers
	{
		[Token(Token = "0x40009DB")]
		none,
		[Token(Token = "0x40009DC")]
		m1,
		[Token(Token = "0x40009DD")]
		m2,
		[Token(Token = "0x40009DE")]
		m3,
		[Token(Token = "0x40009DF")]
		m4,
		[Token(Token = "0x40009E0")]
		m5,
		[Token(Token = "0x40009E1")]
		m6,
		[Token(Token = "0x40009E2")]
		f1,
		[Token(Token = "0x40009E3")]
		f2,
		[Token(Token = "0x40009E4")]
		f3,
		[Token(Token = "0x40009E5")]
		f4,
		[Token(Token = "0x40009E6")]
		croak,
		[Token(Token = "0x40009E7")]
		whisper
	}
	[Token(Token = "0x2000175")]
	public enum Gender
	{
		[Token(Token = "0x40009E9")]
		MALE,
		[Token(Token = "0x40009EA")]
		FEMALE,
		[Token(Token = "0x40009EB")]
		UNKNOWN
	}
	[Token(Token = "0x2000176")]
	public enum MaryTTSType
	{
		[Token(Token = "0x40009ED")]
		RAWMARYXML,
		[Token(Token = "0x40009EE")]
		EMOTIONML,
		[Token(Token = "0x40009EF")]
		SSML,
		[Token(Token = "0x40009F0")]
		TEXT
	}
	[Token(Token = "0x2000177")]
	public enum ProviderType
	{
		[Token(Token = "0x40009F2")]
		Windows,
		[Token(Token = "0x40009F3")]
		macOS,
		[Token(Token = "0x40009F4")]
		Android,
		[Token(Token = "0x40009F5")]
		iOS,
		[Token(Token = "0x40009F6")]
		WSA,
		[Token(Token = "0x40009F7")]
		MaryTTS,
		[Token(Token = "0x40009F8")]
		Linux
	}
	[Token(Token = "0x2000178")]
	public enum SpeakMode
	{
		[Token(Token = "0x40009FA")]
		Speak,
		[Token(Token = "0x40009FB")]
		SpeakNative
	}
}
namespace Crosstales.RTVoice.Demo
{
	[Token(Token = "0x2000179")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_dialog.html")]
	public class Dialog : MonoBehaviour
	{
		[Token(Token = "0x200017A")]
		[CompilerGenerated]
		private sealed class <DialogSequence>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dialog <>4__this;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <index>5__2;

			[Token(Token = "0x1700018F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AF3")]
				[Address(RVA = "0xC0186C", Offset = "0xC0186C", VA = "0xC0186C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000190")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AF5")]
				[Address(RVA = "0xC018B4", Offset = "0xC018B4", VA = "0xC018B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xC0106C", Offset = "0xC0106C", VA = "0xC0106C")]
			[DebuggerHidden]
			public <DialogSequence>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xC01488", Offset = "0xC01488", VA = "0xC01488", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xC0148C", Offset = "0xC0148C", VA = "0xC0148C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xC01874", Offset = "0xC01874", VA = "0xC01874", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Configuration")]
		public string CultureA;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string CultureB;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 3f)]
		public float RateA;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 3f)]
		public float RateB;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 2f)]
		public float PitchA;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 2f)]
		public float PitchB;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float VolumeA;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float VolumeB;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Gender GenderA;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Gender GenderB;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioSource AudioPersonA;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioSource AudioPersonB;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SpeakMode ModeA;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public SpeakMode ModeB;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Dialogues")]
		public string[] DialogPersonA;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string[] DialogPersonB;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string CurrentDialogA;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string CurrentDialogB;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool Running;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string uidSpeakerA;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string uidSpeakerB;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool playingA;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool playingB;

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0xC00E04", Offset = "0xC00E04", VA = "0xC00E04")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0xC00F04", Offset = "0xC00F04", VA = "0xC00F04")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0xC01004", Offset = "0xC01004", VA = "0xC01004")]
		[IteratorStateMachine(typeof(<DialogSequence>d__25))]
		public IEnumerator DialogSequence()
		{
			return null;
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0xC01094", Offset = "0xC01094", VA = "0xC01094")]
		private void speakStartMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0xC01248", Offset = "0xC01248", VA = "0xC01248")]
		private void speakCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0xC013F4", Offset = "0xC013F4", VA = "0xC013F4")]
		public Dialog()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_g_u_i_audio_filter.html")]
	public class GUIAudioFilter : MonoBehaviour
	{
		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Audio Source")]
		public AudioSource Source;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Filters")]
		public AudioReverbFilter ReverbFilter;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioChorusFilter ChorusFilter;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEchoFilter EchoFilter;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioDistortionFilter DistortionFilter;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioLowPassFilter LowPassFilter;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioHighPassFilter HighPassFilter;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("UI Objects")]
		public Text Distortion;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Text Lowpass;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text Highpass;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text Volume;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Text Pitch;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dropdown ReverbFilterDropdown;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly List<AudioReverbPreset> reverbPresets;

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0xC018BC", Offset = "0xC018BC", VA = "0xC018BC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0xC01E18", Offset = "0xC01E18", VA = "0xC01E18")]
		public void ResetFilters()
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0xC01F5C", Offset = "0xC01F5C", VA = "0xC01F5C")]
		public void ReverbFilterDropdownChanged(int index)
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0xC01FCC", Offset = "0xC01FCC", VA = "0xC01FCC")]
		public void ChorusFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0xC01FEC", Offset = "0xC01FEC", VA = "0xC01FEC")]
		public void EchoFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0xC0200C", Offset = "0xC0200C", VA = "0xC0200C")]
		public void DistortionFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0xC0202C", Offset = "0xC0202C", VA = "0xC0202C")]
		public void DistortionFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0xC020CC", Offset = "0xC020CC", VA = "0xC020CC")]
		public void LowPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0xC020EC", Offset = "0xC020EC", VA = "0xC020EC")]
		public void LowPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xC02148", Offset = "0xC02148", VA = "0xC02148")]
		public void HighPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0xC02168", Offset = "0xC02168", VA = "0xC02168")]
		public void HighPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0xC021C4", Offset = "0xC021C4", VA = "0xC021C4")]
		public void VolumeChanged(float value)
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0xC02264", Offset = "0xC02264", VA = "0xC02264")]
		public void PitchChanged(float value)
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0xC02304", Offset = "0xC02304", VA = "0xC02304")]
		public GUIAudioFilter()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_g_u_i_dialog.html")]
	public class GUIDialog : MonoBehaviour
	{
		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Dialog Script")]
		public Dialog DialogScript;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("UI Objects")]
		public Color32 SpeakerColor;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image PanelPersonA;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image PanelPersonB;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text PersonA;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text PersonB;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color32 baseColorA;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Color32 baseColorB;

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0xC02380", Offset = "0xC02380", VA = "0xC02380")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0xC02984", Offset = "0xC02984", VA = "0xC02984")]
		public void Update()
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xC02DA4", Offset = "0xC02DA4", VA = "0xC02DA4")]
		public void StartDialog()
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0xC02E7C", Offset = "0xC02E7C", VA = "0xC02E7C")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0xC03174", Offset = "0xC03174", VA = "0xC03174")]
		public void ChangeRateA(float value)
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0xC03190", Offset = "0xC03190", VA = "0xC03190")]
		public void ChangeRateB(float value)
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0xC031AC", Offset = "0xC031AC", VA = "0xC031AC")]
		public void ChangePitchA(float value)
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0xC031C8", Offset = "0xC031C8", VA = "0xC031C8")]
		public void ChangePitchB(float value)
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0xC031E4", Offset = "0xC031E4", VA = "0xC031E4")]
		public void ChangeVolumeA(float value)
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0xC03200", Offset = "0xC03200", VA = "0xC03200")]
		public void ChangeVolumeB(float value)
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0xC0321C", Offset = "0xC0321C", VA = "0xC0321C")]
		public void GenderAChanged(int index)
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0xC03238", Offset = "0xC03238", VA = "0xC03238")]
		public void GenderBChanged(int index)
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0xC03254", Offset = "0xC03254", VA = "0xC03254")]
		public GUIDialog()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_g_u_i_main.html")]
	public class GUIMain : MonoBehaviour
	{
		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("UI Objects")]
		public Text Name;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text Version;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text Scene;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject NoVoices;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text Errors;

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0xC03268", Offset = "0xC03268", VA = "0xC03268")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0xC034D0", Offset = "0xC034D0", VA = "0xC034D0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0xC034DC", Offset = "0xC034DC", VA = "0xC034DC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0xC03630", Offset = "0xC03630", VA = "0xC03630")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0xC03784", Offset = "0xC03784", VA = "0xC03784")]
		public void OpenAssetURL()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0xC037C8", Offset = "0xC037C8", VA = "0xC037C8")]
		public void OpenCTURL()
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0xC0380C", Offset = "0xC0380C", VA = "0xC0380C")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0xC0385C", Offset = "0xC0385C", VA = "0xC0385C")]
		public void Quit()
		{
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xC03880", Offset = "0xC03880", VA = "0xC03880")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xC039B0", Offset = "0xC039B0", VA = "0xC039B0")]
		private void onErrorInfo(Wrapper wrapper, string errorInfo)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0xC03A50", Offset = "0xC03A50", VA = "0xC03A50")]
		private void onSpeakStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0xC03AFC", Offset = "0xC03AFC", VA = "0xC03AFC")]
		public GUIMain()
		{
		}
	}
	[Token(Token = "0x200017E")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_g_u_i_multi_audio_filter.html")]
	public class GUIMultiAudioFilter : MonoBehaviour
	{
		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Audio Sources")]
		public List<AudioSource> Sources;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Filters")]
		public List<AudioReverbFilter> ReverbFilters;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<AudioChorusFilter> ChorusFilters;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<AudioEchoFilter> EchoFilters;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<AudioDistortionFilter> DistortionFilters;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<AudioLowPassFilter> LowPassFilters;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<AudioHighPassFilter> HighPassFilters;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("UI Objects")]
		public Text Distortion;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Text Lowpass;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text Highpass;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text Volume;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Text Pitch;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dropdown ReverbFilterDropdown;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly List<AudioReverbPreset> reverbPresets;

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0xC03B04", Offset = "0xC03B04", VA = "0xC03B04")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0xC04050", Offset = "0xC04050", VA = "0xC04050")]
		public void ResetFilters()
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xC048DC", Offset = "0xC048DC", VA = "0xC048DC")]
		public void ClearFilters()
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xC04A9C", Offset = "0xC04A9C", VA = "0xC04A9C")]
		public void ReverbFilterDropdownChanged(int index)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xC04C24", Offset = "0xC04C24", VA = "0xC04C24")]
		public void ChorusFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xC04D7C", Offset = "0xC04D7C", VA = "0xC04D7C")]
		public void EchoFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xC04ED4", Offset = "0xC04ED4", VA = "0xC04ED4")]
		public void DistortionFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xC0502C", Offset = "0xC0502C", VA = "0xC0502C")]
		public void DistortionFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xC051CC", Offset = "0xC051CC", VA = "0xC051CC")]
		public void LowPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xC05324", Offset = "0xC05324", VA = "0xC05324")]
		public void LowPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xC054A4", Offset = "0xC054A4", VA = "0xC054A4")]
		public void HighPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0xC055FC", Offset = "0xC055FC", VA = "0xC055FC")]
		public void HighPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xC0577C", Offset = "0xC0577C", VA = "0xC0577C")]
		public void VolumeChanged(float value)
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0xC0591C", Offset = "0xC0591C", VA = "0xC0591C")]
		public void PitchChanged(float value)
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0xC05ABC", Offset = "0xC05ABC", VA = "0xC05ABC")]
		public GUIMultiAudioFilter()
		{
		}
	}
	[Token(Token = "0x200017F")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_g_u_i_scenes.html")]
	public class GUIScenes : MonoBehaviour
	{
		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Name of the previous scene.")]
		public string PreviousScene;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Name of the previous scene (WebGL only).")]
		public string PreviousSceneWebGL;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Name of the next scene.")]
		public string NextScene;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Name of the next scene (WebGL only).")]
		public string NextSceneWebGL;

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0xC05D14", Offset = "0xC05D14", VA = "0xC05D14")]
		public void LoadPreviousScene()
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0xC05DD8", Offset = "0xC05DD8", VA = "0xC05DD8")]
		public void LoadNextScene()
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0xC05E9C", Offset = "0xC05E9C", VA = "0xC05E9C")]
		public GUIScenes()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_g_u_i_speech.html")]
	public class GUISpeech : MonoBehaviour
	{
		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Settings")]
		public bool StartAsNative;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GUIMultiAudioFilter AudioFilter;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Table")]
		public GameObject ItemPrefab;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject Target;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Scrollbar Scroll;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int ColumnCount;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector2 SpaceWidth;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector2 SpaceHeight;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("UI Objects")]
		public InputField Input;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InputField Culture;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text Cultures;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Toggle MaryToogle;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Text Voices;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float Rate;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float Pitch;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float Volume;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static bool isNative;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastCulture;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Voice> items;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Gender gender;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool isCustomProvider;

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0xC05EA4", Offset = "0xC05EA4", VA = "0xC05EA4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0xC0640C", Offset = "0xC0640C", VA = "0xC0640C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0xC07118", Offset = "0xC07118", VA = "0xC07118")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0xC071BC", Offset = "0xC071BC", VA = "0xC071BC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0xC07260", Offset = "0xC07260", VA = "0xC07260")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0xC0730C", Offset = "0xC0730C", VA = "0xC0730C")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0xC0735C", Offset = "0xC0735C", VA = "0xC0735C")]
		public void ChangeRate(float rate)
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0xC073C0", Offset = "0xC073C0", VA = "0xC073C0")]
		public void ChangeVolume(float volume)
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0xC07424", Offset = "0xC07424", VA = "0xC07424")]
		public void ChangePitch(float pitch)
		{
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0xC07488", Offset = "0xC07488", VA = "0xC07488")]
		public void ChangeNative(bool native)
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0xC074E4", Offset = "0xC074E4", VA = "0xC074E4")]
		public void ChangeMaryTTS(bool maryTTS)
		{
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0xC07580", Offset = "0xC07580", VA = "0xC07580")]
		public void GenderChanged(int index)
		{
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0xC075E4", Offset = "0xC075E4", VA = "0xC075E4")]
		private void onProviderChange(string provider)
		{
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0xC0762C", Offset = "0xC0762C", VA = "0xC0762C")]
		private void clearVoicesList()
		{
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0xC065D0", Offset = "0xC065D0", VA = "0xC065D0")]
		private void buildVoicesList()
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0xC07764", Offset = "0xC07764", VA = "0xC07764")]
		public GUISpeech()
		{
		}
	}
	[Token(Token = "0x2000181")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_native_audio.html")]
	public class NativeAudio : MonoBehaviour
	{
		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string SpeechText;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool PlayOnStart;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Delay;

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0xC08878", Offset = "0xC08878", VA = "0xC08878")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0xC088DC", Offset = "0xC088DC", VA = "0xC088DC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0xC089D0", Offset = "0xC089D0", VA = "0xC089D0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0xC08AC4", Offset = "0xC08AC4", VA = "0xC08AC4")]
		public void StartTTS()
		{
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0xC08B74", Offset = "0xC08B74", VA = "0xC08B74")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0xC08BC4", Offset = "0xC08BC4", VA = "0xC08BC4")]
		private static void play(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0xC08C68", Offset = "0xC08C68", VA = "0xC08C68")]
		private static void stop(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0xC08D0C", Offset = "0xC08D0C", VA = "0xC08D0C")]
		public NativeAudio()
		{
		}
	}
	[Token(Token = "0x2000182")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_pre_generated_audio.html")]
	public class PreGeneratedAudio : MonoBehaviour
	{
		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string SpeechText;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool PlayOnStart;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource audioSource;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isPlayed;

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0xC08D64", Offset = "0xC08D64", VA = "0xC08D64")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0xC08E60", Offset = "0xC08E60", VA = "0xC08E60")]
		public void Update()
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0xC0906C", Offset = "0xC0906C", VA = "0xC0906C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0xC09110", Offset = "0xC09110", VA = "0xC09110")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0xC091B4", Offset = "0xC091B4", VA = "0xC091B4")]
		public void Play()
		{
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0xC0923C", Offset = "0xC0923C", VA = "0xC0923C")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0xC08FF8", Offset = "0xC08FF8", VA = "0xC08FF8")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0xC09258", Offset = "0xC09258", VA = "0xC09258")]
		private void speakAudioGenerationCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0xC09268", Offset = "0xC09268", VA = "0xC09268")]
		public PreGeneratedAudio()
		{
		}
	}
	[Token(Token = "0x2000183")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_send_message.html")]
	public class SendMessage : MonoBehaviour
	{
		[Token(Token = "0x2000184")]
		[CompilerGenerated]
		private sealed class <SpeakerB>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SendMessage <>4__this;

			[Token(Token = "0x17000191")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B5A")]
				[Address(RVA = "0xC0983C", Offset = "0xC0983C", VA = "0xC0983C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000192")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B5C")]
				[Address(RVA = "0xC09884", Offset = "0xC09884", VA = "0xC09884", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0xC09538", Offset = "0xC09538", VA = "0xC09538")]
			[DebuggerHidden]
			public <SpeakerB>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0xC09640", Offset = "0xC09640", VA = "0xC09640", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B59")]
			[Address(RVA = "0xC09644", Offset = "0xC09644", VA = "0xC09644", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0xC09844", Offset = "0xC09844", VA = "0xC09844", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string TextA;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Multiline]
		public string TextB;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float DelayTextB;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool PlayOnStart;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject receiver;

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0xC092B8", Offset = "0xC092B8", VA = "0xC092B8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0xC09320", Offset = "0xC09320", VA = "0xC09320")]
		public void Play()
		{
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xC093F0", Offset = "0xC093F0", VA = "0xC093F0")]
		public void SpeakerA()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0xC094C8", Offset = "0xC094C8", VA = "0xC094C8")]
		[IteratorStateMachine(typeof(<SpeakerB>d__8))]
		public IEnumerator SpeakerB()
		{
			return null;
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0xC09560", Offset = "0xC09560", VA = "0xC09560")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xC095C0", Offset = "0xC095C0", VA = "0xC095C0")]
		public SendMessage()
		{
		}
	}
	[Token(Token = "0x2000185")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_sequence_caller.html")]
	public class SequenceCaller : MonoBehaviour
	{
		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject receiver;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int NumberOfSequences;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float SequenceDelay;

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xC0988C", Offset = "0xC0988C", VA = "0xC0988C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0xC09908", Offset = "0xC09908", VA = "0xC09908")]
		private void playNextSequence()
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0xC0995C", Offset = "0xC0995C", VA = "0xC0995C")]
		public SequenceCaller()
		{
		}
	}
	[Token(Token = "0x2000186")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_simple.html")]
	public class Simple : MonoBehaviour
	{
		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Configuration")]
		public AudioSource SourceA;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource SourceB;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 3f)]
		public float RateSpeakerA;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 3f)]
		public float RateSpeakerB;

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PlayOnStart;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("UI Objects")]
		public Text TextSpeakerA;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text TextSpeakerB;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Text PhonemeSpeakerA;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Text PhonemeSpeakerB;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Text VisemeSpeakerA;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text VisemeSpeakerB;

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string uidSpeakerA;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string uidSpeakerB;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string textA;

		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string textB;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Wrapper currentWrapper;

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0xC0996C", Offset = "0xC0996C", VA = "0xC0996C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0xC09B20", Offset = "0xC09B20", VA = "0xC09B20")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0xC09DC4", Offset = "0xC09DC4", VA = "0xC09DC4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0xC09A50", Offset = "0xC09A50", VA = "0xC09A50")]
		public void Play()
		{
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0xC0A068", Offset = "0xC0A068", VA = "0xC0A068")]
		public void SpeakerA()
		{
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0xC0A13C", Offset = "0xC0A13C", VA = "0xC0A13C")]
		public void SpeakerB()
		{
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0xC0A210", Offset = "0xC0A210", VA = "0xC0A210")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0xC0A40C", Offset = "0xC0A40C", VA = "0xC0A40C")]
		private void speakAudio()
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0xC0A468", Offset = "0xC0A468", VA = "0xC0A468")]
		private static void speakAudioGenerationStartMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0xC0A50C", Offset = "0xC0A50C", VA = "0xC0A50C")]
		private void speakAudioGenerationCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0xC0A5EC", Offset = "0xC0A5EC", VA = "0xC0A5EC")]
		private void speakStartMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0xC0A740", Offset = "0xC0A740", VA = "0xC0A740")]
		private void speakCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0xC0AAAC", Offset = "0xC0AAAC", VA = "0xC0AAAC")]
		private void speakCurrentWordMethod(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0xC0ACC4", Offset = "0xC0ACC4", VA = "0xC0ACC4")]
		private void speakCurrentPhonemeMethod(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0xC0AE4C", Offset = "0xC0AE4C", VA = "0xC0AE4C")]
		private void speakCurrentVisemeMethod(Wrapper wrapper, string viseme)
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0xC0AFD4", Offset = "0xC0AFD4", VA = "0xC0AFD4")]
		public Simple()
		{
		}
	}
	[Token(Token = "0x2000187")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_simple_native.html")]
	public class SimpleNative : MonoBehaviour
	{
		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 3f)]
		[Header("Configuration")]
		public float RateSpeakerA;

		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 3f)]
		public float RateSpeakerB;

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 3f)]
		public float RateSpeakerC;

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool PlayOnStart;

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("UI Objects")]
		public Text TextSpeakerA;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text TextSpeakerB;

		[Token(Token = "0x4000A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text TextSpeakerC;

		[Token(Token = "0x4000A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text PhonemeSpeakerA;

		[Token(Token = "0x4000A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Text PhonemeSpeakerB;

		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Text PhonemeSpeakerC;

		[Token(Token = "0x4000A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Text VisemeSpeakerA;

		[Token(Token = "0x4000A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text VisemeSpeakerB;

		[Token(Token = "0x4000A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text VisemeSpeakerC;

		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string uidSpeakerA;

		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string uidSpeakerB;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string uidSpeakerC;

		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string textA;

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string textB;

		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string textC;

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0xC0B054", Offset = "0xC0B054", VA = "0xC0B054")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0xC0B2F8", Offset = "0xC0B2F8", VA = "0xC0B2F8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0xC0B4F4", Offset = "0xC0B4F4", VA = "0xC0B4F4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0xC0B1E4", Offset = "0xC0B1E4", VA = "0xC0B1E4")]
		public void Play()
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0xC0B6F0", Offset = "0xC0B6F0", VA = "0xC0B6F0")]
		public void SpeakerA()
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0xC0B7B4", Offset = "0xC0B7B4", VA = "0xC0B7B4")]
		public void SpeakerB()
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0xC0B878", Offset = "0xC0B878", VA = "0xC0B878")]
		public void SpeakerC()
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0xC0B93C", Offset = "0xC0B93C", VA = "0xC0B93C")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0xC0BB50", Offset = "0xC0BB50", VA = "0xC0BB50")]
		private void speakStartMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0xC0BCD8", Offset = "0xC0BCD8", VA = "0xC0BCD8")]
		private void speakCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0xC0C18C", Offset = "0xC0C18C", VA = "0xC0C18C")]
		private void speakCurrentWordMethod(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0xC0C3F0", Offset = "0xC0C3F0", VA = "0xC0C3F0")]
		private void speakCurrentPhonemeMethod(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0xC0C5C4", Offset = "0xC0C5C4", VA = "0xC0C5C4")]
		private void speakCurrentVisemeMethod(Wrapper wrapper, string viseme)
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0xC0C798", Offset = "0xC0C798", VA = "0xC0C798")]
		public SimpleNative()
		{
		}
	}
	[Token(Token = "0x2000188")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_speak_wrapper.html")]
	[RequireComponent(typeof(AudioSource))]
	public class SpeakWrapper : MonoBehaviour
	{
		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Voice SpeakerVoice;

		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputField Input;

		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text Label;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioSource Audio;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string uid;

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0xC0C83C", Offset = "0xC0C83C", VA = "0xC0C83C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0xC0C88C", Offset = "0xC0C88C", VA = "0xC0C88C")]
		public void Speak()
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0xC0CA1C", Offset = "0xC0CA1C", VA = "0xC0CA1C")]
		public SpeakWrapper()
		{
		}
	}
}
namespace Crosstales.RTVoice.Demo.Util
{
	[Token(Token = "0x2000189")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_util_1_1i_o_s_controller.html")]
	public class iOSController : MonoBehaviour
	{
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0xC0CA74", Offset = "0xC0CA74", VA = "0xC0CA74")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0xC0CB8C", Offset = "0xC0CB8C", VA = "0xC0CB8C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0xC0CC1C", Offset = "0xC0CC1C", VA = "0xC0CC1C")]
		public iOSController()
		{
		}
	}
	[Token(Token = "0x200018A")]
	[RequireComponent(typeof(Renderer))]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_util_1_1_material_changer.html")]
	public class MaterialChanger : MonoBehaviour
	{
		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource Source;

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material ActiveMaterial;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material inactiveMaterial;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Renderer myRenderer;

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0xC0CC24", Offset = "0xC0CC24", VA = "0xC0CC24")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0xC0CC88", Offset = "0xC0CC88", VA = "0xC0CC88")]
		public void Update()
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0xC0CD0C", Offset = "0xC0CD0C", VA = "0xC0CD0C")]
		public MaterialChanger()
		{
		}
	}
	[Token(Token = "0x200018B")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_util_1_1_native_controller.html")]
	public class NativeController : MonoBehaviour
	{
		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Configuration")]
		[Tooltip("Enable or disable the 'Objects' for native mode (default: true).")]
		public bool Active;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Objects")]
		[Tooltip("Selected objects for the controller.")]
		public GameObject[] Objects;

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0xC0CD14", Offset = "0xC0CD14", VA = "0xC0CD14")]
		public void Update()
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0xC0D134", Offset = "0xC0D134", VA = "0xC0D134")]
		public NativeController()
		{
		}
	}
	[Token(Token = "0x200018D")]
	[HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_util_1_1_platform_controller.html")]
	public class PlatformController : Crosstales.Common.Util.PlatformController
	{
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0xC0D20C", Offset = "0xC0D20C", VA = "0xC0D20C", Slot = "4")]
		public override void Start()
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0xC0D318", Offset = "0xC0D318", VA = "0xC0D318")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0xC0D3BC", Offset = "0xC0D3BC", VA = "0xC0D3BC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0xC0D248", Offset = "0xC0D248", VA = "0xC0D248")]
		private void onProviderChange(string provider)
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0xC0D614", Offset = "0xC0D614", VA = "0xC0D614")]
		public PlatformController()
		{
		}
	}
}
namespace Crosstales.UI
{
	[Token(Token = "0x200018E")]
	public class Social : MonoBehaviour
	{
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0xC0D634", Offset = "0xC0D634", VA = "0xC0D634")]
		public void Facebook()
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0xC0D678", Offset = "0xC0D678", VA = "0xC0D678")]
		public void Twitter()
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0xC0D6BC", Offset = "0xC0D6BC", VA = "0xC0D6BC")]
		public void LinkedIn()
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0xC0D700", Offset = "0xC0D700", VA = "0xC0D700")]
		public void Youtube()
		{
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0xC0D744", Offset = "0xC0D744", VA = "0xC0D744")]
		public void Discord()
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0xC0D788", Offset = "0xC0D788", VA = "0xC0D788")]
		public Social()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class StaticManager : MonoBehaviour
	{
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0xC0D790", Offset = "0xC0D790", VA = "0xC0D790")]
		public void Quit()
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0xC0D798", Offset = "0xC0D798", VA = "0xC0D798")]
		public void OpenCrosstales()
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0xC0D7DC", Offset = "0xC0D7DC", VA = "0xC0D7DC")]
		public void OpenAssetstore()
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0xC0D820", Offset = "0xC0D820", VA = "0xC0D820")]
		public StaticManager()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class UIDrag : MonoBehaviour
	{
		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float offsetX;

		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float offsetY;

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tf;

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0xC0D828", Offset = "0xC0D828", VA = "0xC0D828")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0xC0D844", Offset = "0xC0D844", VA = "0xC0D844")]
		public void BeginDrag()
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0xC0D898", Offset = "0xC0D898", VA = "0xC0D898")]
		public void OnDrag()
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0xC0D8FC", Offset = "0xC0D8FC", VA = "0xC0D8FC")]
		public UIDrag()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class UIFocus : MonoBehaviour
	{
		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Name of the gameobject containing the UIWindowManager.")]
		public string ManagerName;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UIWindowManager manager;

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image image;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tf;

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0xC0D904", Offset = "0xC0D904", VA = "0xC0D904")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0xC0D9C8", Offset = "0xC0D9C8", VA = "0xC0D9C8")]
		public void OnPanelEnter()
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0xC0DC58", Offset = "0xC0DC58", VA = "0xC0DC58")]
		public UIFocus()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class UIHint : MonoBehaviour
	{
		[Token(Token = "0x2000193")]
		[CompilerGenerated]
		private sealed class <lerpAlphaDown>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Component gameObjectToFade;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIHint <>4__this;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float startAlphaValue;

			[Token(Token = "0x4000AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float endAlphaValue;

			[Token(Token = "0x4000AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float delay;

			[Token(Token = "0x4000AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float time;

			[Token(Token = "0x17000193")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BAB")]
				[Address(RVA = "0xC0E07C", Offset = "0xC0E07C", VA = "0xC0E07C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000194")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BAD")]
				[Address(RVA = "0xC0E0C4", Offset = "0xC0E0C4", VA = "0xC0E0C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0xC0DE50", Offset = "0xC0DE50", VA = "0xC0DE50")]
			[DebuggerHidden]
			public <lerpAlphaDown>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0xC0DEB8", Offset = "0xC0DEB8", VA = "0xC0DEB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0xC0DEBC", Offset = "0xC0DEBC", VA = "0xC0DEBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0xC0E084", Offset = "0xC0E084", VA = "0xC0E084", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000194")]
		[CompilerGenerated]
		private sealed class <lerpAlphaUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Component gameObjectToFade;

			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIHint <>4__this;

			[Token(Token = "0x4000AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float startAlphaValue;

			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float endAlphaValue;

			[Token(Token = "0x4000AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float delay;

			[Token(Token = "0x4000AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float time;

			[Token(Token = "0x17000195")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BB1")]
				[Address(RVA = "0xC0E288", Offset = "0xC0E288", VA = "0xC0E288", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000196")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BB3")]
				[Address(RVA = "0xC0E2D0", Offset = "0xC0E2D0", VA = "0xC0E2D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0xC0DE78", Offset = "0xC0DE78", VA = "0xC0DE78")]
			[DebuggerHidden]
			public <lerpAlphaUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0xC0E0CC", Offset = "0xC0E0CC", VA = "0xC0E0CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0xC0E0D0", Offset = "0xC0E0D0", VA = "0xC0E0D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0xC0E290", Offset = "0xC0E290", VA = "0xC0E290", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Group to fade.")]
		public CanvasGroup Group;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Delay in seconds before fading (default: 2).")]
		public float Delay;

		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Fade time in seconds (default: 2).")]
		public float FadeTime;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Disable UI element after the fade (default: true).")]
		public bool Disable;

		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Fade at Start (default: true).")]
		public bool FadeAtStart;

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0xC0DCA8", Offset = "0xC0DCA8", VA = "0xC0DCA8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0xC0DCE8", Offset = "0xC0DCE8", VA = "0xC0DCE8")]
		public void FadeUp()
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0xC0DCB8", Offset = "0xC0DCB8", VA = "0xC0DCB8")]
		public void FadeDown()
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0xC0DDB4", Offset = "0xC0DDB4", VA = "0xC0DDB4")]
		[IteratorStateMachine(typeof(<lerpAlphaDown>d__8))]
		private IEnumerator lerpAlphaDown(float startAlphaValue, float endAlphaValue, float time, float delay, Component gameObjectToFade)
		{
			return null;
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0xC0DD18", Offset = "0xC0DD18", VA = "0xC0DD18")]
		[IteratorStateMachine(typeof(<lerpAlphaUp>d__9))]
		private IEnumerator lerpAlphaUp(float startAlphaValue, float endAlphaValue, float time, float delay, Component gameObjectToFade)
		{
			return null;
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0xC0DEA0", Offset = "0xC0DEA0", VA = "0xC0DEA0")]
		public UIHint()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class UIResize : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
	{
		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Minimum size of the UI element.")]
		public Vector2 MinSize;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Maximum size of the UI element.")]
		public Vector2 MaxSize;

		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform panelRectTransform;

		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 originalLocalPointerPosition;

		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 originalSizeDelta;

		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 originalSize;

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0xC0E2D8", Offset = "0xC0E2D8", VA = "0xC0E2D8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0xC0E38C", Offset = "0xC0E38C", VA = "0xC0E38C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0xC0E444", Offset = "0xC0E444", VA = "0xC0E444", Slot = "5")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0xC0E5B8", Offset = "0xC0E5B8", VA = "0xC0E5B8")]
		public UIResize()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class UIWindowManager : MonoBehaviour
	{
		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("All Windows of the scene.")]
		public GameObject[] Windows;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image image;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject DontTouch;

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0xC0E5CC", Offset = "0xC0E5CC", VA = "0xC0E5CC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0xC0DA78", Offset = "0xC0DA78", VA = "0xC0DA78")]
		public void ChangeState(GameObject active)
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0xC0E6D4", Offset = "0xC0E6D4", VA = "0xC0E6D4")]
		public UIWindowManager()
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class WindowManager : MonoBehaviour
	{
		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Window movement speed (default: 3).")]
		public float Speed;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Dependent GameObjects (active == open).")]
		public GameObject[] Dependencies;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UIFocus focus;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool open;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool close;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 startPos;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 centerPos;

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lerpPos;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float openProgress;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float closeProgress;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject panel;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform tf;

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0xC0E6DC", Offset = "0xC0E6DC", VA = "0xC0E6DC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0xC0E80C", Offset = "0xC0E80C", VA = "0xC0E80C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0xC0E9AC", Offset = "0xC0E9AC", VA = "0xC0E9AC")]
		public void SwitchPanel()
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0xC0E9BC", Offset = "0xC0E9BC", VA = "0xC0E9BC")]
		public void OpenPanel()
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0xC0E7D4", Offset = "0xC0E7D4", VA = "0xC0E7D4")]
		public void ClosePanel()
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xC0EAB0", Offset = "0xC0EAB0", VA = "0xC0EAB0")]
		public WindowManager()
		{
		}
	}
}
namespace Crosstales.UI.Util
{
	[Token(Token = "0x2000198")]
	public class AudioFilterController : MonoBehaviour
	{
		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Searches for all audio filters in the whole scene (default: true).")]
		[Header("Audio Filters")]
		public bool FindAllAudioFiltersOnStart;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioReverbFilter[] ReverbFilters;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioChorusFilter[] ChorusFilters;

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEchoFilter[] EchoFilters;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioDistortionFilter[] DistortionFilters;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioLowPassFilter[] LowPassFilters;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioHighPassFilter[] HighPassFilters;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		[Tooltip("Resets all active audio filters (default: on).")]
		public bool ResetAudioFiltersOnStart;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool ChorusFilter;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool EchoFilter;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool DistortionFilter;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float DistortionFilterValue;

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool LowpassFilter;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float LowpassFilterValue;

		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool HighpassFilter;

		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float HighpassFilterValue;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("UI Objects")]
		public Dropdown ReverbFilterDropdown;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Text DistortionText;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Text LowpassText;

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Text HighpassText;

		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<AudioReverbPreset> reverbPresets;

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool initalized;

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0xC0EAC0", Offset = "0xC0EAC0", VA = "0xC0EAC0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0xC0F00C", Offset = "0xC0F00C", VA = "0xC0F00C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0xC0F080", Offset = "0xC0F080", VA = "0xC0F080")]
		public void FindAllAudioFilters()
		{
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0xC0F334", Offset = "0xC0F334", VA = "0xC0F334")]
		public void ResetAudioFilters()
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0xC0F3A8", Offset = "0xC0F3A8", VA = "0xC0F3A8")]
		public void ReverbFilterDropdownChanged(int index)
		{
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0xC0F464", Offset = "0xC0F464", VA = "0xC0F464")]
		public void ChorusFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0xC0F4CC", Offset = "0xC0F4CC", VA = "0xC0F4CC")]
		public void EchoFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0xC0F534", Offset = "0xC0F534", VA = "0xC0F534")]
		public void DistortionFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0xC0F59C", Offset = "0xC0F59C", VA = "0xC0F59C")]
		public void DistortionFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0xC0F6A8", Offset = "0xC0F6A8", VA = "0xC0F6A8")]
		public void LowPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0xC0F710", Offset = "0xC0F710", VA = "0xC0F710")]
		public void LowPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0xC0F81C", Offset = "0xC0F81C", VA = "0xC0F81C")]
		public void HighPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0xC0F884", Offset = "0xC0F884", VA = "0xC0F884")]
		public void HighPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0xC0F990", Offset = "0xC0F990", VA = "0xC0F990")]
		public AudioFilterController()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class AudioSourceController : MonoBehaviour
	{
		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Searches for all AudioSource in the whole scene (default: true).")]
		[Header("Audio Sources")]
		public bool FindAllAudioSourcesOnStart;

		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Active controlled AudioSources.")]
		public AudioSource[] AudioSources;

		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Resets all active AudioSources (default: true).")]
		[Header("Settings")]
		public bool ResetAudioSourcesOnStart;

		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Mute on/off (default: false).")]
		public bool Mute;

		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[Tooltip("Loop on/off (default: false).")]
		public bool Loop;

		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Volume of the audio (default: 1)")]
		public float Volume;

		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Pitch of the audio (default: 1).")]
		public float Pitch;

		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Stereo pan of the audio (default: 0).")]
		public float StereoPan;

		[Token(Token = "0x4000AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("UI Objects")]
		public Text VolumeText;

		[Token(Token = "0x4000AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text PitchText;

		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Text StereoPanText;

		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool initalized;

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0xC0FA30", Offset = "0xC0FA30", VA = "0xC0FA30")]
		public void Update()
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0xC0FAA4", Offset = "0xC0FAA4", VA = "0xC0FAA4")]
		public void FindAllAudioSources()
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0xC0FB84", Offset = "0xC0FB84", VA = "0xC0FB84")]
		public void ResetAllAudioSources()
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0xC0FBC8", Offset = "0xC0FBC8", VA = "0xC0FBC8")]
		public void MuteEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0xC0FC30", Offset = "0xC0FC30", VA = "0xC0FC30")]
		public void LoopEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0xC0FC98", Offset = "0xC0FC98", VA = "0xC0FC98")]
		public void VolumeChanged(float value)
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0xC0FDA4", Offset = "0xC0FDA4", VA = "0xC0FDA4")]
		public void PitchChanged(float value)
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0xC0FEB0", Offset = "0xC0FEB0", VA = "0xC0FEB0")]
		public void StereoPanChanged(float value)
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0xC0FFBC", Offset = "0xC0FFBC", VA = "0xC0FFBC")]
		public AudioSourceController()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public class FPSDisplay : MonoBehaviour
	{
		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Text component to display the FPS.")]
		public Text FPS;

		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float deltaTime;

		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float elapsedTime;

		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float msec;

		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float fps;

		[Token(Token = "0x4000AF3")]
		private const string wait = "<i>...calculating <b>FPS</b>...</i>";

		[Token(Token = "0x4000AF4")]
		private const string red = "<color=#E57373><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x4000AF5")]
		private const string orange = "<color=#FFB74D><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x4000AF6")]
		private const string green = "<color=#81C784><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0xC0FFD8", Offset = "0xC0FFD8", VA = "0xC0FFD8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0xC10204", Offset = "0xC10204", VA = "0xC10204")]
		public FPSDisplay()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class ScrollRectHandler : MonoBehaviour
	{
		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScrollRect Scroll;

		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float WindowsSensitivity;

		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MacSensitivity;

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0xC1020C", Offset = "0xC1020C", VA = "0xC1020C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0xC10278", Offset = "0xC10278", VA = "0xC10278")]
		public ScrollRectHandler()
		{
		}
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x200019C")]
	[DisallowMultipleComponent]
	public class SurviveSceneSwitch : MonoBehaviour
	{
		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Objects which have to survive a scene switch.")]
		public GameObject[] Survivors;

		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Don't destroy gameobject during scene switches (default: true).")]
		public bool DontDestroy;

		[Token(Token = "0x4000AFC")]
		private const float ensureParentTime = 1.5f;

		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float ensureParentTimer;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SurviveSceneSwitch instance;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Transform tf;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0xC1028C", Offset = "0xC1028C", VA = "0xC1028C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0xC108CC", Offset = "0xC108CC", VA = "0xC108CC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0xC108D8", Offset = "0xC108D8", VA = "0xC108D8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0xC10CE4", Offset = "0xC10CE4", VA = "0xC10CE4")]
		public SurviveSceneSwitch()
		{
		}
	}
	[Token(Token = "0x200019E")]
	[DisallowMultipleComponent]
	public class TakeScreenshot : MonoBehaviour
	{
		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Prefix for the generate file names.")]
		public string Prefix;

		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Factor by which to increase resolution (default: 1).")]
		public int Scale;

		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Key-press to capture the screen (default: F8).")]
		public KeyCode KeyCode;

		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Texture2D texture;

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0xC10E18", Offset = "0xC10E18", VA = "0xC10E18")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0xC10EA0", Offset = "0xC10EA0", VA = "0xC10EA0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0xC10ECC", Offset = "0xC10ECC", VA = "0xC10ECC")]
		public void Capture()
		{
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0xC10FF8", Offset = "0xC10FF8", VA = "0xC10FF8")]
		public TakeScreenshot()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class BackgroundController : MonoBehaviour
	{
		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Selected objects to disable in the background for the controller.")]
		public GameObject[] Objects;

		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isFocused;

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0xC11054", Offset = "0xC11054", VA = "0xC11054")]
		public void Start()
		{
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0xC11074", Offset = "0xC11074", VA = "0xC11074")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0xC1125C", Offset = "0xC1125C", VA = "0xC1125C")]
		public BackgroundController()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x4000B0A")]
		public const string ASSET_AUTHOR = "crosstales LLC";

		[Token(Token = "0x4000B0B")]
		public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

		[Token(Token = "0x4000B0C")]
		public const string ASSET_CT_URL = "https://assetstore.unity.com/lists/crosstales-42213?aid=1011lNGT";

		[Token(Token = "0x4000B0D")]
		public const string ASSET_SOCIAL_DISCORD = "https://discord.gg/ZbZ2sh4";

		[Token(Token = "0x4000B0E")]
		public const string ASSET_SOCIAL_FACEBOOK = "https://www.facebook.com/crosstales/";

		[Token(Token = "0x4000B0F")]
		public const string ASSET_SOCIAL_TWITTER = "https://twitter.com/crosstales";

		[Token(Token = "0x4000B10")]
		public const string ASSET_SOCIAL_YOUTUBE = "https://www.youtube.com/c/Crosstales";

		[Token(Token = "0x4000B11")]
		public const string ASSET_SOCIAL_LINKEDIN = "https://www.linkedin.com/company/crosstales";

		[Token(Token = "0x4000B12")]
		public const string ASSET_3P_PLAYMAKER = "https://assetstore.unity.com/packages/slug/368?aid=1011lNGT";

		[Token(Token = "0x4000B13")]
		public const string ASSET_BWF = "https://assetstore.unity.com/packages/slug/26255?aid=1011lNGT";

		[Token(Token = "0x4000B14")]
		public const string ASSET_DJ = "https://assetstore.unity.com/packages/slug/41993?aid=1011lNGT";

		[Token(Token = "0x4000B15")]
		public const string ASSET_FB = "https://assetstore.unity.com/packages/slug/98713?aid=1011lNGT";

		[Token(Token = "0x4000B16")]
		public const string ASSET_OC = "https://assetstore.unity.com/packages/slug/74688?aid=1011lNGT";

		[Token(Token = "0x4000B17")]
		public const string ASSET_RADIO = "https://assetstore.unity.com/packages/slug/32034?aid=1011lNGT";

		[Token(Token = "0x4000B18")]
		public const string ASSET_RTV = "https://assetstore.unity.com/packages/slug/41068?aid=1011lNGT";

		[Token(Token = "0x4000B19")]
		public const string ASSET_TB = "https://assetstore.unity.com/packages/slug/98711?aid=1011lNGT";

		[Token(Token = "0x4000B1A")]
		public const string ASSET_TPB = "https://assetstore.unity.com/packages/slug/98714?aid=1011lNGT";

		[Token(Token = "0x4000B1B")]
		public const string ASSET_TPS = "https://assetstore.unity.com/packages/slug/60040?aid=1011lNGT";

		[Token(Token = "0x4000B1C")]
		public const string ASSET_TR = "https://assetstore.unity.com/packages/slug/61617?aid=1011lNGT";

		[Token(Token = "0x4000B1D")]
		public const int FACTOR_KB = 1024;

		[Token(Token = "0x4000B1E")]
		public const int FACTOR_MB = 1048576;

		[Token(Token = "0x4000B1F")]
		public const int FACTOR_GB = 1073741824;

		[Token(Token = "0x4000B20")]
		public const float FLOAT_32768 = 32768f;

		[Token(Token = "0x4000B21")]
		public const float FLOAT_TOLERANCE = 0.0001f;

		[Token(Token = "0x4000B22")]
		public const string FORMAT_TWO_DECIMAL_PLACES = "0.00";

		[Token(Token = "0x4000B23")]
		public const string FORMAT_NO_DECIMAL_PLACES = "0";

		[Token(Token = "0x4000B24")]
		public const string FORMAT_PERCENT = "0%";

		[Token(Token = "0x4000B25")]
		public const bool DEFAULT_DEBUG = false;

		[Token(Token = "0x4000B26")]
		public const string PATH_DELIMITER_WINDOWS = "\\";

		[Token(Token = "0x4000B27")]
		public const string PATH_DELIMITER_UNIX = "/";

		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x4000B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x4000B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string PREFIX_HTTP;

		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string PREFIX_HTTPS;

		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x4000B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x4000B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x17000197")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0xC11264", Offset = "0xC11264", VA = "0xC11264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000198")]
		public static string APPLICATION_PATH
		{
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0xC11370", Offset = "0xC11370", VA = "0xC11370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0xC11588", Offset = "0xC11588", VA = "0xC11588")]
		protected BaseConstants()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public abstract class BaseHelper
	{
		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly Regex lineEndingsRegex;

		[Token(Token = "0x4000B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly Regex cleanSpacesRegex;

		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static readonly Regex cleanTagsRegex;

		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x4000B40")]
		protected const string file_prefix = "file://";

		[Token(Token = "0x17000199")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0xC116D8", Offset = "0xC116D8", VA = "0xC116D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019A")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0xC09530", Offset = "0xC09530", VA = "0xC09530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019B")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0xC10270", Offset = "0xC10270", VA = "0xC10270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019C")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0xC116F4", Offset = "0xC116F4", VA = "0xC116F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019D")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0xC116FC", Offset = "0xC116FC", VA = "0xC116FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019E")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0xC1124C", Offset = "0xC1124C", VA = "0xC1124C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019F")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0xC11254", Offset = "0xC11254", VA = "0xC11254")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A0")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0xC1176C", Offset = "0xC1176C", VA = "0xC1176C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A1")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0xC11774", Offset = "0xC11774", VA = "0xC11774")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A2")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0xC1177C", Offset = "0xC1177C", VA = "0xC1177C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A3")]
		public static bool isPS4Platform
		{
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0xC11784", Offset = "0xC11784", VA = "0xC11784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A4")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0xC1178C", Offset = "0xC1178C", VA = "0xC1178C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A5")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0xC0D460", Offset = "0xC0D460", VA = "0xC0D460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A6")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0xC112E8", Offset = "0xC112E8", VA = "0xC112E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A7")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0xC11794", Offset = "0xC11794", VA = "0xC11794")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A8")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0xC117F4", Offset = "0xC117F4", VA = "0xC117F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A9")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0xC0CB2C", Offset = "0xC0CB2C", VA = "0xC0CB2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AA")]
		public static bool isEditor
		{
			[Token(Token = "0x6000C00")]
			[Address(RVA = "0xC11864", Offset = "0xC11864", VA = "0xC11864")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AB")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x6000C01")]
			[Address(RVA = "0xC11358", Offset = "0xC11358", VA = "0xC11358")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AC")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0xC11360", Offset = "0xC11360", VA = "0xC11360")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AD")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x6000C03")]
			[Address(RVA = "0xC11368", Offset = "0xC11368", VA = "0xC11368")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AE")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0xC10878", Offset = "0xC10878", VA = "0xC10878")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AF")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0xC118D4", Offset = "0xC118D4", VA = "0xC118D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B0")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0xC118DC", Offset = "0xC118DC", VA = "0xC118DC")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x170001B1")]
		public static string StreamingAssetsPath
		{
			[Token(Token = "0x6000C07")]
			[Address(RVA = "0xC1195C", Offset = "0xC1195C", VA = "0xC1195C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0xC11A18", Offset = "0xC11A18", VA = "0xC11A18")]
		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0xC08ED8", Offset = "0xC08ED8", VA = "0xC08ED8")]
		public static bool hasActiveClip(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0xC11B9C", Offset = "0xC11B9C", VA = "0xC11B9C")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0xC1140C", Offset = "0xC1140C", VA = "0xC1140C")]
		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0xC11D50", Offset = "0xC11D50", VA = "0xC11D50")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0xC11F28", Offset = "0xC11F28", VA = "0xC11F28")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0xC1243C", Offset = "0xC1243C", VA = "0xC1243C")]
		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0xC12640", Offset = "0xC12640", VA = "0xC12640")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0xC128B0", Offset = "0xC128B0", VA = "0xC128B0")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0xC12A00", Offset = "0xC12A00", VA = "0xC12A00")]
		public static string ClearTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0xC12A98", Offset = "0xC12A98", VA = "0xC12A98")]
		public static string ClearSpaces(string text)
		{
			return null;
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0xC12B28", Offset = "0xC12B28", VA = "0xC12B28")]
		public static string ClearLineEndings(string text)
		{
			return null;
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0xC12BC0", Offset = "0xC12BC0", VA = "0xC12BC0")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0xC12EBC", Offset = "0xC12EBC", VA = "0xC12EBC")]
		public static string FormatBytesToHRF(long bytes)
		{
			return null;
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0xC13100", Offset = "0xC13100", VA = "0xC13100")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0xC13634", Offset = "0xC13634", VA = "0xC13634")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0xC127BC", Offset = "0xC127BC", VA = "0xC127BC")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0xC13788", Offset = "0xC13788", VA = "0xC13788")]
		public static void FileCopy(string inputFile, string outputFile, bool move = false)
		{
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0xC13AB4", Offset = "0xC13AB4", VA = "0xC13AB4")]
		public static void ShowFileLocation(string file)
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0xC13B5C", Offset = "0xC13B5C", VA = "0xC13B5C")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0xC13C40", Offset = "0xC13C40", VA = "0xC13C40")]
		protected BaseHelper()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public static class CTPlayerPrefs
	{
		[Token(Token = "0x4000B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly SerializableDictionary<string, string> content;

		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string fileName;

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0xC13ED8", Offset = "0xC13ED8", VA = "0xC13ED8")]
		static CTPlayerPrefs()
		{
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0xC14018", Offset = "0xC14018", VA = "0xC14018")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0xC14098", Offset = "0xC14098", VA = "0xC14098")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0xC14110", Offset = "0xC14110", VA = "0xC14110")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0xC14190", Offset = "0xC14190", VA = "0xC14190")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0xC14274", Offset = "0xC14274", VA = "0xC14274")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0xC142F4", Offset = "0xC142F4", VA = "0xC142F4")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0xC14368", Offset = "0xC14368", VA = "0xC14368")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0xC143DC", Offset = "0xC143DC", VA = "0xC143DC")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0xC144B8", Offset = "0xC144B8", VA = "0xC144B8")]
		public static DateTime GetDate(string key)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0xC145B4", Offset = "0xC145B4", VA = "0xC145B4")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0xC146C0", Offset = "0xC146C0", VA = "0xC146C0")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0xC1473C", Offset = "0xC1473C", VA = "0xC1473C")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0xC147B8", Offset = "0xC147B8", VA = "0xC147B8")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0xC148A4", Offset = "0xC148A4", VA = "0xC148A4")]
		public static void SetDate(string key, DateTime value)
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x170001B2")]
		public int Timeout
		{
			[Token(Token = "0x6000C31")]
			[Address(RVA = "0xC14974", Offset = "0xC14974", VA = "0xC14974")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C32")]
			[Address(RVA = "0xC1497C", Offset = "0xC1497C", VA = "0xC1497C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B3")]
		public int ConnectionLimit
		{
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0xC14984", Offset = "0xC14984", VA = "0xC14984")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0xC1498C", Offset = "0xC1498C", VA = "0xC1498C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0xC14994", Offset = "0xC14994", VA = "0xC14994")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0xC149A0", Offset = "0xC149A0", VA = "0xC149A0")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0xC14A14", Offset = "0xC14A14", VA = "0xC14A14")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0xC14A94", Offset = "0xC14A94", VA = "0xC14A94", Slot = "27")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A5")]
	public class FFTAnalyzer : MonoBehaviour
	{
		[Token(Token = "0x4000B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Array for the samples. More samples mean better accuracy but it also needs more performance (default: 256)")]
		public float[] Samples;

		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Analyzed channel (0 = right, 1 = left, default: 0).")]
		public int Channel;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("FFT-algorithm to analyze the audio (default: BlackmanHarris).")]
		public FFTWindow FFTMode;

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0xC14BF4", Offset = "0xC14BF4", VA = "0xC14BF4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0xC14C08", Offset = "0xC14C08", VA = "0xC14C08")]
		public FFTAnalyzer()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public class FreeCam : MonoBehaviour
	{
		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MovementSpeed;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FastMovementSpeed;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float FreeLookSensitivity;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ZoomSensitivity;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float FastZoomSensitivity;

		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tf;

		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool looking;

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0xC14C68", Offset = "0xC14C68", VA = "0xC14C68")]
		public void Start()
		{
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0xC14C84", Offset = "0xC14C84", VA = "0xC14C84")]
		public void Update()
		{
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0xC15338", Offset = "0xC15338", VA = "0xC15338")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0xC152EC", Offset = "0xC152EC", VA = "0xC152EC")]
		public void StartLooking()
		{
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0xC15314", Offset = "0xC15314", VA = "0xC15314")]
		public void StopLooking()
		{
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0xC1535C", Offset = "0xC1535C", VA = "0xC1535C")]
		public FreeCam()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class PlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Configuration")]
		[Tooltip("Selected platforms for the controller.")]
		public List<Platform> Platforms;

		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Enable or disable the 'Objects' for the selected 'Platforms' (default: true).")]
		public bool Active;

		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Selected objects for the controller.")]
		[Header("Objects")]
		public GameObject[] Objects;

		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Platform currentPlatform;

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0xC15378", Offset = "0xC15378", VA = "0xC15378", Slot = "4")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0xC0D5B4", Offset = "0xC0D5B4", VA = "0xC0D5B4")]
		protected void selectPlatform()
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0xC0D4B0", Offset = "0xC0D4B0", VA = "0xC0D4B0")]
		protected void activateGO()
		{
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0xC0D624", Offset = "0xC0D624", VA = "0xC0D624")]
		public PlatformController()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public class RandomColor : MonoBehaviour
	{
		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Use intervals to change the color (default: true).")]
		public bool UseInterval;

		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Random change interval between min (= x) and max (= y) in seconds (default: x = 5, y = 10).")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Random hue range between min (= x) and max (= y) (default: x = 0, y = 1).")]
		public Vector2 HueRange;

		[Token(Token = "0x4000B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Random saturation range between min (= x) and max (= y) (default: x = 1, y = 1).")]
		public Vector2 SaturationRange;

		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Random value range between min (= x) and max (= y) (default: x = 1, y = 1).")]
		public Vector2 ValueRange;

		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Random alpha range between min (= x) and max (= y) (default: x = 1, y = 1).")]
		public Vector2 AlphaRange;

		[Token(Token = "0x4000B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Use gray scale colors (default: false).")]
		public bool GrayScale;

		[Token(Token = "0x4000B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Modify the color of a material instead of the Renderer (default: not set, optional).")]
		public Material Material;

		[Token(Token = "0x4000B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Set the object to a random color at Start (default: false).")]
		public bool RandomColorAtStart;

		[Token(Token = "0x4000B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x4000B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x4000B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer currentRenderer;

		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Color32 startColor;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Color32 endColor;

		[Token(Token = "0x4000B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float lerpProgress;

		[Token(Token = "0x4000B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int colorID;

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0xC1537C", Offset = "0xC1537C", VA = "0xC1537C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0xC15C94", Offset = "0xC15C94", VA = "0xC15C94")]
		public void Update()
		{
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0xC1669C", Offset = "0xC1669C", VA = "0xC1669C")]
		public RandomColor()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public class RandomRotator : MonoBehaviour
	{
		[Token(Token = "0x4000B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Use intervals to change the rotation (default: true).")]
		public bool UseInterval;

		[Token(Token = "0x4000B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Random change interval between min (= x) and max (= y) in seconds (default: x = 10, y = 20).")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Minimum rotation speed per axis (default: 5 for all axis).")]
		public Vector3 SpeedMin;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Minimum rotation speed per axis (default: 15 for all axis).")]
		public Vector3 SpeedMax;

		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Set the object to a random rotation at Start (default: false).")]
		public bool RandomRotationAtStart;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 speed;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x4000B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0xC16730", Offset = "0xC16730", VA = "0xC16730")]
		public void Start()
		{
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0xC16788", Offset = "0xC16788", VA = "0xC16788")]
		public void Update()
		{
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0xC16918", Offset = "0xC16918", VA = "0xC16918")]
		public RandomRotator()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class RandomScaler : MonoBehaviour
	{
		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Use intervals to change the scale (default: true).")]
		public bool UseInterval;

		[Token(Token = "0x4000B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Random change interval between min (= x) and max (= y) in seconds (default: x = 10, y = 20).")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000B71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Minimum rotation speed per axis (default: 5 for all axis).")]
		public Vector3 ScaleMin;

		[Token(Token = "0x4000B72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Maximum scale per axis (default: 0.1 for all axis).")]
		public Vector3 ScaleMax;

		[Token(Token = "0x4000B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Uniform scaling for all axis (x-axis values will be used, default: true).")]
		public bool Uniform;

		[Token(Token = "0x4000B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[Tooltip("Set the object to a random scale at Start (default: false).")]
		public bool RandomScaleAtStart;

		[Token(Token = "0x4000B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 startScale;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 endScale;

		[Token(Token = "0x4000B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float elapsedTime;

		[Token(Token = "0x4000B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float changeTime;

		[Token(Token = "0x4000B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lerpTime;

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0xC1694C", Offset = "0xC1694C", VA = "0xC1694C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0xC16A24", Offset = "0xC16A24", VA = "0xC16A24")]
		public void Update()
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0xC16B8C", Offset = "0xC16B8C", VA = "0xC16B8C")]
		public RandomScaler()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AB")]
	public class SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, IXmlSerializable, ISerializable
	{
		[Token(Token = "0x4000B7B")]
		private const string ItemNodeName = "Item";

		[Token(Token = "0x4000B7C")]
		private const string KeyNodeName = "Key";

		[Token(Token = "0x4000B7D")]
		private const string ValueNodeName = "Value";

		[Token(Token = "0x4000B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XmlSerializer keySerializer;

		[Token(Token = "0x4000B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XmlSerializer valueSerializer;

		[Token(Token = "0x170001B4")]
		private XmlSerializer ValueSerializer
		{
			[Token(Token = "0x6000C5A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B5")]
		private XmlSerializer KeySerializer
		{
			[Token(Token = "0x6000C5B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C4F")]
		public SerializableDictionary()
		{
		}

		[Token(Token = "0x6000C50")]
		public SerializableDictionary(IDictionary<TKey, TVal> dictionary)
		{
		}

		[Token(Token = "0x6000C51")]
		public SerializableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000C52")]
		public SerializableDictionary(int capacity)
		{
		}

		[Token(Token = "0x6000C53")]
		public SerializableDictionary(IDictionary<TKey, TVal> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000C54")]
		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000C55")]
		protected SerializableDictionary(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000C56")]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000C57")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000C58")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000C59")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	public static class SerializeDeSerialize
	{
		[Token(Token = "0x170001B6")]
		private static BinaryFormatter binaryFormatter
		{
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0xC16BC4", Offset = "0xC16BC4", VA = "0xC16BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C5D")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x6000C5E")]
		public static byte[] SerializeToByteArray<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x6000C5F")]
		public static T DeserializeFromFile<T>(string filename)
		{
			return (T)null;
		}

		[Token(Token = "0x6000C60")]
		public static T DeserializeFromByteArray<T>(byte[] data)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20001AD")]
	public class SpectrumVisualizer : MonoBehaviour
	{
		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("FFT-analyzer with the spectrum data.")]
		public FFTAnalyzer Analyzer;

		[Token(Token = "0x4000B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Prefab for the frequency representation.")]
		public GameObject VisualPrefab;

		[Token(Token = "0x4000B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Width per prefab.")]
		public float Width;

		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Gain-power for the frequency.")]
		public float Gain;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Frequency band from left-to-right (default: true).")]
		public bool LeftToRight;

		[Token(Token = "0x4000B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Opacity of the material of the prefab (default: 1).")]
		public float Opacity;

		[Token(Token = "0x4000B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform tf;

		[Token(Token = "0x4000B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform[] visualTransforms;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 visualPos;

		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int samplesPerChannel;

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0xC16C24", Offset = "0xC16C24", VA = "0xC16C24")]
		public void Start()
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0xC16F3C", Offset = "0xC16F3C", VA = "0xC16F3C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0xC16FE0", Offset = "0xC16FE0", VA = "0xC16FE0")]
		public SpectrumVisualizer()
		{
		}
	}
	[Token(Token = "0x20001AE")]
	public static class XmlHelper
	{
		[Token(Token = "0x6000C64")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x6000C65")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x6000C66")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x6000C67")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x6000C68")]
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true)
		{
			return (T)null;
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x20001AF")]
	public enum Platform
	{
		[Token(Token = "0x4000B8B")]
		Windows,
		[Token(Token = "0x4000B8C")]
		OSX,
		[Token(Token = "0x4000B8D")]
		Linux,
		[Token(Token = "0x4000B8E")]
		IOS,
		[Token(Token = "0x4000B8F")]
		Android,
		[Token(Token = "0x4000B90")]
		WSA,
		[Token(Token = "0x4000B91")]
		Web,
		[Token(Token = "0x4000B92")]
		Unsupported,
		[Token(Token = "0x4000B93")]
		MaryTTS
	}
	[Token(Token = "0x20001B0")]
	public enum SampleRate
	{
		[Token(Token = "0x4000B95")]
		_8000Hz = 8000,
		[Token(Token = "0x4000B96")]
		_11025Hz = 11025,
		[Token(Token = "0x4000B97")]
		_22050Hz = 22050,
		[Token(Token = "0x4000B98")]
		_44100Hz = 44100,
		[Token(Token = "0x4000B99")]
		_48000Hz = 48000
	}
}
