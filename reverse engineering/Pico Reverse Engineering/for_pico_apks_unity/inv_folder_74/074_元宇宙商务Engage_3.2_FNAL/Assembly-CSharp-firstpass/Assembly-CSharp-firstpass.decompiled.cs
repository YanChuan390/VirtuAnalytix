using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using ImaginationOverflow.UniversalDeepLinking;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DeeplinkingExample : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Panel;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Reference;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject InstructionText;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x366A868", Offset = "0x366A868", VA = "0x366A868")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x366A960", Offset = "0x366A960", VA = "0x366A960")]
	private void SetupUi()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x366A9B4", Offset = "0x366A9B4", VA = "0x366A9B4")]
	private void Instance_LinkActivated(LinkActivation s)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x366AB70", Offset = "0x366AB70", VA = "0x366AB70")]
	private void UpdateContentSize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x366AC24", Offset = "0x366AC24", VA = "0x366AC24")]
	public DeeplinkingExample()
	{
	}
}
[Token(Token = "0x2000003")]
public class OpenLinkBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Url;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3670BF8", Offset = "0x3670BF8", VA = "0x3670BF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3670C9C", Offset = "0x3670C9C", VA = "0x3670C9C")]
	public void Open()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3670CA8", Offset = "0x3670CA8", VA = "0x3670CA8")]
	public OpenLinkBehaviour()
	{
	}
}
[Token(Token = "0x2000004")]
public static class Engage_PhotonHelper
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int playerID;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static double photonNetworkTime;
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000005")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000008")]
		High = 2,
		[Token(Token = "0x4000009")]
		Medium = 1,
		[Token(Token = "0x400000A")]
		Low = 0
	}
	[Token(Token = "0x2000006")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4BF55EC", Offset = "0x4BF55EC", VA = "0x4BF55EC")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4BF576C", Offset = "0x4BF576C", VA = "0x4BF576C")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4BF5820", Offset = "0x4BF5820", VA = "0x4BF5820")]
		public void Update()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4BF58A4", Offset = "0x4BF58A4", VA = "0x4BF58A4")]
		public WaterBase()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974124", Offset = "0x1974124")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974124", Offset = "0x1974124")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000099")]
		public enum Mode
		{
			[Token(Token = "0x40003FA")]
			AnimationClips,
			[Token(Token = "0x40003FB")]
			AnimationStates,
			[Token(Token = "0x40003FC")]
			PlayableDirector,
			[Token(Token = "0x40003FD")]
			Realtime
		}

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974C10", Offset = "0x1974C10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1974C10", Offset = "0x1974C10")]
		public int frameRate;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974C68", Offset = "0x1974C68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1974C68", Offset = "0x1974C68")]
		public float keyReductionError;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974CC0", Offset = "0x1974CC0")]
		public Mode mode;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974CF8", Offset = "0x1974CF8")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974D30", Offset = "0x1974D30")]
		public string[] animationStates;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974D68", Offset = "0x1974D68")]
		public bool loop;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974DA0", Offset = "0x1974DA0")]
		public string saveToFolder;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974DD8", Offset = "0x1974DD8")]
		public string appendName;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974E10", Offset = "0x1974E10")]
		public string saveName;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974E48", Offset = "0x1974E48")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974E58", Offset = "0x1974E58")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974E88", Offset = "0x1974E88")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x3671DE0", Offset = "0x3671DE0", VA = "0x3671DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DB4C", Offset = "0x197DB4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x3671DE8", Offset = "0x3671DE8", VA = "0x3671DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DB5C", Offset = "0x197DB5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x3671DF4", Offset = "0x3671DF4", VA = "0x3671DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DB6C", Offset = "0x197DB6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x3671DFC", Offset = "0x3671DFC", VA = "0x3671DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DB7C", Offset = "0x197DB7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x3671E04", Offset = "0x3671E04", VA = "0x3671E04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DB8C", Offset = "0x197DB8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x3671E0C", Offset = "0x3671E0C", VA = "0x3671E0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DB9C", Offset = "0x197DB9C")]
			private set
			{
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3671CB0", Offset = "0x3671CB0", VA = "0x3671CB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DA6C", Offset = "0x197DA6C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3671CFC", Offset = "0x3671CFC", VA = "0x3671CFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DAA4", Offset = "0x197DAA4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3671D48", Offset = "0x3671D48", VA = "0x3671D48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DADC", Offset = "0x197DADC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3671D94", Offset = "0x3671D94", VA = "0x3671D94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DB14", Offset = "0x197DB14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000015")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000016")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000017")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000018")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000019")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3671E14", Offset = "0x3671E14", VA = "0x3671E14")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3671E18", Offset = "0x3671E18", VA = "0x3671E18")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3671E1C", Offset = "0x3671E1C", VA = "0x3671E1C")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3671E20", Offset = "0x3671E20", VA = "0x3671E20")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974E98", Offset = "0x1974E98")]
		public bool markAsLegacy;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974ED0", Offset = "0x1974ED0")]
		public Transform root;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974F08", Offset = "0x1974F08")]
		public Transform rootNode;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974F40", Offset = "0x1974F40")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974F78", Offset = "0x1974F78")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4BED0E8", Offset = "0x4BED0E8", VA = "0x4BED0E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4BED4B4", Offset = "0x4BED4B4", VA = "0x4BED4B4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4BED4BC", Offset = "0x4BED4BC", VA = "0x4BED4BC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4BED5CC", Offset = "0x4BED5CC", VA = "0x4BED5CC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4BED648", Offset = "0x4BED648", VA = "0x4BED648", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4BED6C4", Offset = "0x4BED6C4", VA = "0x4BED6C4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4BED304", Offset = "0x4BED304", VA = "0x4BED304")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4BED3DC", Offset = "0x4BED3DC", VA = "0x4BED3DC")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4BED740", Offset = "0x4BED740", VA = "0x4BED740")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class TQ
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4BF2CE0", Offset = "0x4BF2CE0", VA = "0x4BF2CE0")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AvatarUtility
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3670CB0", Offset = "0x3670CB0", VA = "0x3670CB0")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3670EC4", Offset = "0x3670EC4", VA = "0x3670EC4")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3670EA4", Offset = "0x3670EA4", VA = "0x3670EA4")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3671544", Offset = "0x3671544", VA = "0x3671544")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3673094", Offset = "0x3673094", VA = "0x3673094")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3674568", Offset = "0x3674568", VA = "0x3674568")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x3672AA8", Offset = "0x3672AA8", VA = "0x3672AA8")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x36730DC", Offset = "0x36730DC", VA = "0x36730DC")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x36725E0", Offset = "0x36725E0", VA = "0x36725E0")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3671EE0", Offset = "0x3671EE0", VA = "0x3671EE0")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x367212C", Offset = "0x367212C", VA = "0x367212C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3672000", Offset = "0x3672000", VA = "0x3672000")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3672264", Offset = "0x3672264", VA = "0x3672264")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x367283C", Offset = "0x367283C", VA = "0x367283C")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3672938", Offset = "0x3672938", VA = "0x3672938")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3672A34", Offset = "0x3672A34", VA = "0x3672A34")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x36729AC", Offset = "0x36729AC", VA = "0x36729AC")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3672CF4", Offset = "0x3672CF4", VA = "0x3672CF4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3672DA8", Offset = "0x3672DA8", VA = "0x3672DA8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x36730E0", Offset = "0x36730E0", VA = "0x36730E0")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3673150", Offset = "0x3673150", VA = "0x3673150")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3673838", Offset = "0x3673838", VA = "0x3673838")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x36738EC", Offset = "0x36738EC", VA = "0x36738EC")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x36737D8", Offset = "0x36737D8", VA = "0x36737D8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x36739D0", Offset = "0x36739D0", VA = "0x36739D0")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3673A18", Offset = "0x3673A18", VA = "0x3673A18")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class BakerTransform
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3673A20", Offset = "0x3673A20", VA = "0x3673A20")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3673BB4", Offset = "0x3673BB4", VA = "0x3673BB4")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3673BC8", Offset = "0x3673BC8", VA = "0x3673BC8")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3673E58", Offset = "0x3673E58", VA = "0x3673E58")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3673ABC", Offset = "0x3673ABC", VA = "0x3673ABC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x36740A4", Offset = "0x36740A4", VA = "0x36740A4")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x3674118", Offset = "0x3674118", VA = "0x3674118")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x3674364", Offset = "0x3674364", VA = "0x3674364")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974FB0", Offset = "0x1974FB0")]
		public bool bakeHandIK;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1974FE8", Offset = "0x1974FE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1974FE8", Offset = "0x1974FE8")]
		public float IKKeyReductionError;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975040", Offset = "0x1975040")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975040", Offset = "0x1975040")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4BEE678", Offset = "0x4BEE678", VA = "0x4BEE678")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4BEEAA4", Offset = "0x4BEEAA4", VA = "0x4BEEAA4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4BEEAC0", Offset = "0x4BEEAC0", VA = "0x4BEEAC0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4BEEBE0", Offset = "0x4BEEBE0", VA = "0x4BEEBE0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4BEECBC", Offset = "0x4BEECBC", VA = "0x4BEECBC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4BEEE8C", Offset = "0x4BEEE8C", VA = "0x4BEEE8C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4BEF224", Offset = "0x4BEF224", VA = "0x4BEF224")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4BEF300", Offset = "0x4BEF300", VA = "0x4BEF300")]
		public HumanoidBaker()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public enum Axis
	{
		[Token(Token = "0x4000059")]
		X,
		[Token(Token = "0x400005A")]
		Y,
		[Token(Token = "0x400005B")]
		Z
	}
	[Token(Token = "0x2000011")]
	public class AxisTools
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x367154C", Offset = "0x367154C", VA = "0x367154C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x3671604", Offset = "0x3671604", VA = "0x3671604")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x36716B0", Offset = "0x36716B0", VA = "0x36716B0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x3671894", Offset = "0x3671894", VA = "0x3671894")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x36717CC", Offset = "0x36717CC", VA = "0x36717CC")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x36719B0", Offset = "0x36719B0", VA = "0x36719B0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x36719F8", Offset = "0x36719F8", VA = "0x36719F8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x3671CA8", Offset = "0x3671CA8", VA = "0x3671CA8")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200009A")]
		public class LimbOrientation
		{
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x3674C10", Offset = "0x3674C10", VA = "0x3674C10")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000004")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x367499C", Offset = "0x367499C", VA = "0x367499C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x3674C88", Offset = "0x3674C88", VA = "0x3674C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x3674950", Offset = "0x3674950", VA = "0x3674950")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		public enum BoneType
		{
			[Token(Token = "0x4000402")]
			Unassigned,
			[Token(Token = "0x4000403")]
			Spine,
			[Token(Token = "0x4000404")]
			Head,
			[Token(Token = "0x4000405")]
			Arm,
			[Token(Token = "0x4000406")]
			Leg,
			[Token(Token = "0x4000407")]
			Tail,
			[Token(Token = "0x4000408")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200009C")]
		public enum BoneSide
		{
			[Token(Token = "0x400040A")]
			Center,
			[Token(Token = "0x400040B")]
			Left,
			[Token(Token = "0x400040C")]
			Right
		}

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3674EFC", Offset = "0x3674EFC", VA = "0x3674EFC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x36751FC", Offset = "0x36751FC", VA = "0x36751FC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x367544C", Offset = "0x367544C", VA = "0x367544C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x36754D0", Offset = "0x36754D0", VA = "0x36754D0")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x367557C", Offset = "0x367557C", VA = "0x367557C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x36750AC", Offset = "0x36750AC", VA = "0x36750AC")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x36753AC", Offset = "0x36753AC", VA = "0x36753AC")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x3675DBC", Offset = "0x3675DBC", VA = "0x3675DBC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3675BD4", Offset = "0x3675BD4", VA = "0x3675BD4")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x3675CC8", Offset = "0x3675CC8", VA = "0x3675CC8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x367579C", Offset = "0x367579C", VA = "0x367579C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x3675850", Offset = "0x3675850", VA = "0x3675850")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x3675904", Offset = "0x3675904", VA = "0x3675904")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x36759B8", Offset = "0x36759B8", VA = "0x36759B8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x3675A6C", Offset = "0x3675A6C", VA = "0x3675A6C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3675B20", Offset = "0x3675B20", VA = "0x3675B20")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x3675FD0", Offset = "0x3675FD0", VA = "0x3675FD0")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x36756B0", Offset = "0x36756B0", VA = "0x36756B0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3675F40", Offset = "0x3675F40", VA = "0x3675F40")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3676040", Offset = "0x3676040", VA = "0x3676040")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x3676118", Offset = "0x3676118", VA = "0x3676118")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x3675EC4", Offset = "0x3675EC4", VA = "0x3675EC4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x3675E4C", Offset = "0x3675E4C", VA = "0x3675E4C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public class BipedReferences
	{
		[Token(Token = "0x200009D")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000081")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000590")]
				[Address(RVA = "0x367B0A8", Offset = "0x367B0A8", VA = "0x367B0A8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x367B094", Offset = "0x367B094", VA = "0x367B094")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000006")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x3677C8C", Offset = "0x3677C8C", VA = "0x3677C8C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public bool isEmpty
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x3678078", Offset = "0x3678078", VA = "0x3678078")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x3678088", Offset = "0x3678088", VA = "0x3678088", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x36784B4", Offset = "0x36784B4", VA = "0x36784B4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x36788EC", Offset = "0x36788EC", VA = "0x36788EC")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x3678EFC", Offset = "0x3678EFC", VA = "0x3678EFC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x3678B38", Offset = "0x3678B38", VA = "0x3678B38")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x36796AC", Offset = "0x36796AC", VA = "0x36796AC")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x36797A0", Offset = "0x36797A0", VA = "0x36797A0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x3679CF8", Offset = "0x3679CF8", VA = "0x3679CF8")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x3679AFC", Offset = "0x3679AFC", VA = "0x3679AFC")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x3679974", Offset = "0x3679974", VA = "0x3679974")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x3679840", Offset = "0x3679840", VA = "0x3679840")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x3679C00", Offset = "0x3679C00", VA = "0x3679C00")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x3679DF4", Offset = "0x3679DF4", VA = "0x3679DF4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x367A894", Offset = "0x367A894", VA = "0x367A894")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x367A378", Offset = "0x367A378", VA = "0x367A378")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x367AB88", Offset = "0x367AB88", VA = "0x367AB88")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x367A6B8", Offset = "0x367A6B8", VA = "0x367A6B8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x367AB90", Offset = "0x367AB90", VA = "0x367AB90")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x367AB98", Offset = "0x367AB98", VA = "0x367AB98")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x367AD58", Offset = "0x367AD58", VA = "0x367AD58")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x367AF70", Offset = "0x367AF70", VA = "0x367AF70")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x3678AC8", Offset = "0x3678AC8", VA = "0x3678AC8")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x367B0B0", Offset = "0x367B0B0", VA = "0x367B0B0")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x367B0B8", Offset = "0x367B0B8", VA = "0x367B0B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x367B1F8", Offset = "0x367B1F8", VA = "0x367B1F8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class Hierarchy
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x4BED7A8", Offset = "0x4BED7A8", VA = "0x4BED7A8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x4BED9A8", Offset = "0x4BED9A8", VA = "0x4BED9A8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x4BED840", Offset = "0x4BED840", VA = "0x4BED840")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4BEDACC", Offset = "0x4BEDACC", VA = "0x4BEDACC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4BEDBF0", Offset = "0x4BEDBF0", VA = "0x4BEDBF0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4BEDE98", Offset = "0x4BEDE98", VA = "0x4BEDE98")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4BEDFB4", Offset = "0x4BEDFB4", VA = "0x4BEDFB4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x4BEE13C", Offset = "0x4BEE13C", VA = "0x4BEE13C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x4BEE4D0", Offset = "0x4BEE4D0", VA = "0x4BEE4D0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x4BEE2BC", Offset = "0x4BEE2BC", VA = "0x4BEE2BC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4BEE670", Offset = "0x4BEE670", VA = "0x4BEE670")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x4BEF3B4", Offset = "0x4BEF3B4", VA = "0x4BEF3B4")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4BEF424", Offset = "0x4BEF424", VA = "0x4BEF424")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000089")]
		None,
		[Token(Token = "0x400008A")]
		InOutCubic,
		[Token(Token = "0x400008B")]
		InOutQuintic,
		[Token(Token = "0x400008C")]
		InOutSine,
		[Token(Token = "0x400008D")]
		InQuintic,
		[Token(Token = "0x400008E")]
		InQuartic,
		[Token(Token = "0x400008F")]
		InCubic,
		[Token(Token = "0x4000090")]
		InQuadratic,
		[Token(Token = "0x4000091")]
		InElastic,
		[Token(Token = "0x4000092")]
		InElasticSmall,
		[Token(Token = "0x4000093")]
		InElasticBig,
		[Token(Token = "0x4000094")]
		InSine,
		[Token(Token = "0x4000095")]
		InBack,
		[Token(Token = "0x4000096")]
		OutQuintic,
		[Token(Token = "0x4000097")]
		OutQuartic,
		[Token(Token = "0x4000098")]
		OutCubic,
		[Token(Token = "0x4000099")]
		OutInCubic,
		[Token(Token = "0x400009A")]
		OutInQuartic,
		[Token(Token = "0x400009B")]
		OutElastic,
		[Token(Token = "0x400009C")]
		OutElasticSmall,
		[Token(Token = "0x400009D")]
		OutElasticBig,
		[Token(Token = "0x400009E")]
		OutSine,
		[Token(Token = "0x400009F")]
		OutBack,
		[Token(Token = "0x40000A0")]
		OutBackCubic,
		[Token(Token = "0x40000A1")]
		OutBackQuartic,
		[Token(Token = "0x40000A2")]
		BackInCubic,
		[Token(Token = "0x40000A3")]
		BackInQuartic
	}
	[Token(Token = "0x200001A")]
	public class Interp
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4BEF494", Offset = "0x4BEF494", VA = "0x4BEF494")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4BEFEFC", Offset = "0x4BEFEFC", VA = "0x4BEFEFC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4BF0004", Offset = "0x4BF0004", VA = "0x4BF0004")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4BEF800", Offset = "0x4BEF800", VA = "0x4BEF800")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4BEF80C", Offset = "0x4BEF80C", VA = "0x4BEF80C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x4BEF830", Offset = "0x4BEF830", VA = "0x4BEF830")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x4BEF86C", Offset = "0x4BEF86C", VA = "0x4BEF86C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x4BEF884", Offset = "0x4BEF884", VA = "0x4BEF884")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x4BEF898", Offset = "0x4BEF898", VA = "0x4BEF898")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x4BEF8AC", Offset = "0x4BEF8AC", VA = "0x4BEF8AC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4BEF8BC", Offset = "0x4BEF8BC", VA = "0x4BEF8BC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x4BEF904", Offset = "0x4BEF904", VA = "0x4BEF904")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4BEF93C", Offset = "0x4BEF93C", VA = "0x4BEF93C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4BEF964", Offset = "0x4BEF964", VA = "0x4BEF964")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4BF0100", Offset = "0x4BF0100", VA = "0x4BF0100")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4BEF998", Offset = "0x4BEF998", VA = "0x4BEF998")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x4BEF9C0", Offset = "0x4BEF9C0", VA = "0x4BEF9C0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4BEF9F0", Offset = "0x4BEF9F0", VA = "0x4BEF9F0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4BEFA24", Offset = "0x4BEFA24", VA = "0x4BEFA24")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4BEFA68", Offset = "0x4BEFA68", VA = "0x4BEFA68")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4BEFACC", Offset = "0x4BEFACC", VA = "0x4BEFACC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4BEFB30", Offset = "0x4BEFB30", VA = "0x4BEFB30")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4BEFB84", Offset = "0x4BEFB84", VA = "0x4BEFB84")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4BEFBD8", Offset = "0x4BEFBD8", VA = "0x4BEFBD8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x4BEFC70", Offset = "0x4BEFC70", VA = "0x4BEFC70")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x4BEFD04", Offset = "0x4BEFD04", VA = "0x4BEFD04")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4BF0134", Offset = "0x4BF0134", VA = "0x4BF0134")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x4BEFDA8", Offset = "0x4BEFDA8", VA = "0x4BEFDA8")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4BEFE8C", Offset = "0x4BEFE8C", VA = "0x4BEFE8C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4BEFEBC", Offset = "0x4BEFEBC", VA = "0x4BEFEBC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4BF021C", Offset = "0x4BF021C", VA = "0x4BF021C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4BF0304", Offset = "0x4BF0304", VA = "0x4BF0304")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4BF035C", Offset = "0x4BF035C", VA = "0x4BF035C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4BF0428", Offset = "0x4BF0428", VA = "0x4BF0428")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4BF0374", Offset = "0x4BF0374", VA = "0x4BF0374")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4BF0440", Offset = "0x4BF0440", VA = "0x4BF0440")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4BF04E4", Offset = "0x4BF04E4", VA = "0x4BF04E4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4BF0510", Offset = "0x4BF0510", VA = "0x4BF0510")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4BF0560", Offset = "0x4BF0560", VA = "0x4BF0560")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4BF05CC", Offset = "0x4BF05CC", VA = "0x4BF05CC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4BF06C0", Offset = "0x4BF06C0", VA = "0x4BF06C0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4BF0798", Offset = "0x4BF0798", VA = "0x4BF0798")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4BF07F8", Offset = "0x4BF07F8", VA = "0x4BF07F8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001C")]
	public abstract class LazySingleton<T> : MonoBehaviour where T : LazySingleton<T>
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000008")]
		public static bool hasInstance
		{
			[Token(Token = "0x60000CA")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public static T instance
		{
			[Token(Token = "0x60000CB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CC")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000CD")]
		protected LazySingleton()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public enum ShowIfMode
	{
		[Token(Token = "0x40000A6")]
		Disabled,
		[Token(Token = "0x40000A7")]
		Hidden
	}
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1974194", Offset = "0x1974194")]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19750A4", Offset = "0x19750A4")]
		private string <propName>k__BackingField;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19750B4", Offset = "0x19750B4")]
		private object <propValue>k__BackingField;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19750C4", Offset = "0x19750C4")]
		private object <otherPropValue>k__BackingField;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19750D4", Offset = "0x19750D4")]
		private bool <indent>k__BackingField;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19750E4", Offset = "0x19750E4")]
		private ShowIfMode <mode>k__BackingField;

		[Token(Token = "0x1700000A")]
		public string propName
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x4BF2448", Offset = "0x4BF2448", VA = "0x4BF2448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC1C", Offset = "0x197DC1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x4BF2450", Offset = "0x4BF2450", VA = "0x4BF2450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC2C", Offset = "0x197DC2C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public object propValue
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x4BF2458", Offset = "0x4BF2458", VA = "0x4BF2458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC3C", Offset = "0x197DC3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x4BF2460", Offset = "0x4BF2460", VA = "0x4BF2460")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC4C", Offset = "0x197DC4C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public object otherPropValue
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x4BF2468", Offset = "0x4BF2468", VA = "0x4BF2468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC5C", Offset = "0x197DC5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x4BF2470", Offset = "0x4BF2470", VA = "0x4BF2470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC6C", Offset = "0x197DC6C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool indent
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x4BF2478", Offset = "0x4BF2478", VA = "0x4BF2478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC7C", Offset = "0x197DC7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4BF2480", Offset = "0x4BF2480", VA = "0x4BF2480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC8C", Offset = "0x197DC8C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x4BF248C", Offset = "0x4BF248C", VA = "0x4BF248C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DC9C", Offset = "0x197DC9C")]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x4BF2494", Offset = "0x4BF2494", VA = "0x4BF2494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DCAC", Offset = "0x197DCAC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4BF249C", Offset = "0x4BF249C", VA = "0x4BF249C")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x19741CC", Offset = "0x19741CC")]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19750F4", Offset = "0x19750F4")]
		private float <min>k__BackingField;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1975104", Offset = "0x1975104")]
		private float <max>k__BackingField;

		[Token(Token = "0x1700000F")]
		public float min
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x4BF2650", Offset = "0x4BF2650", VA = "0x4BF2650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DCBC", Offset = "0x197DCBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x4BF2658", Offset = "0x4BF2658", VA = "0x4BF2658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DCCC", Offset = "0x197DCCC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float max
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x4BF2660", Offset = "0x4BF2660", VA = "0x4BF2660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DCDC", Offset = "0x197DCDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x4BF2668", Offset = "0x4BF2668", VA = "0x4BF2668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DCEC", Offset = "0x197DCEC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4BF2670", Offset = "0x4BF2670", VA = "0x4BF2670")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string name;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string color;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x4BF24F8", Offset = "0x4BF24F8", VA = "0x4BF24F8")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x4BF25A0", Offset = "0x4BF25A0", VA = "0x4BF25A0")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x4BF0224", Offset = "0x4BF0224", VA = "0x4BF0224")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4BF0294", Offset = "0x4BF0294", VA = "0x4BF0294")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public static class QuaTools
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x4BF0828", Offset = "0x4BF0828", VA = "0x4BF0828")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4BF092C", Offset = "0x4BF092C", VA = "0x4BF092C")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4BF0A2C", Offset = "0x4BF0A2C", VA = "0x4BF0A2C")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x4BF0C28", Offset = "0x4BF0C28", VA = "0x4BF0C28")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x4BF0D9C", Offset = "0x4BF0D9C", VA = "0x4BF0D9C")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x4BF0F08", Offset = "0x4BF0F08", VA = "0x4BF0F08")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x4BF1164", Offset = "0x4BF1164", VA = "0x4BF1164")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x4BF12B0", Offset = "0x4BF12B0", VA = "0x4BF12B0")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x4BF13FC", Offset = "0x4BF13FC", VA = "0x4BF13FC")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x4BF1510", Offset = "0x4BF1510", VA = "0x4BF1510")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x4BF1624", Offset = "0x4BF1624", VA = "0x4BF1624")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x4BF17B0", Offset = "0x4BF17B0", VA = "0x4BF17B0")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x4BF1880", Offset = "0x4BF1880", VA = "0x4BF1880")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x4BF19D4", Offset = "0x4BF19D4", VA = "0x4BF19D4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x4BF1C58", Offset = "0x4BF1C58", VA = "0x4BF1C58")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x4BF1E6C", Offset = "0x4BF1E6C", VA = "0x4BF1E6C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x4BE9794", Offset = "0x4BE9794", VA = "0x4BE9794")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x4BF1FEC", Offset = "0x4BF1FEC", VA = "0x4BF1FEC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4BF20FC", Offset = "0x4BF20FC", VA = "0x4BF20FC")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x4BF2158", Offset = "0x4BF2158", VA = "0x4BF2158")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4BF230C", Offset = "0x4BF230C", VA = "0x4BF230C")]
		public static Quaternion MirrorYZ(Quaternion r)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000023")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000011")]
		public static T instance
		{
			[Token(Token = "0x60000F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F9")]
		public static void Clear()
		{
		}

		[Token(Token = "0x60000FA")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000FB")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975114", Offset = "0x1975114")]
		public bool fixTransforms;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000012")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x4BF2818", Offset = "0x4BF2818", VA = "0x4BF2818")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		private bool isAnimated
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x4BF2B14", Offset = "0x4BF2B14", VA = "0x4BF2B14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4BF26E0", Offset = "0x4BF26E0", VA = "0x4BF26E0")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4BF2778", Offset = "0x4BF2778", VA = "0x4BF2778", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4BF277C", Offset = "0x4BF277C", VA = "0x4BF277C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4BF2780", Offset = "0x4BF2780", VA = "0x4BF2780", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4BF2784", Offset = "0x4BF2784", VA = "0x4BF2784")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4BF2814", Offset = "0x4BF2814", VA = "0x4BF2814")]
		private void Start()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4BF27BC", Offset = "0x4BF27BC", VA = "0x4BF27BC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4BF2AC8", Offset = "0x4BF2AC8", VA = "0x4BF2AC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4BF2908", Offset = "0x4BF2908", VA = "0x4BF2908")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4BF2BD0", Offset = "0x4BF2BD0", VA = "0x4BF2BD0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4BF2C2C", Offset = "0x4BF2C2C", VA = "0x4BF2C2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4BF2C88", Offset = "0x4BF2C88", VA = "0x4BF2C88")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x4BF2CD0", Offset = "0x4BF2CD0", VA = "0x4BF2CD0")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x4BF2D50", Offset = "0x4BF2D50", VA = "0x4BF2D50")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4BF2E08", Offset = "0x4BF2E08", VA = "0x4BF2E08")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x4BF2EC0", Offset = "0x4BF2EC0", VA = "0x4BF2EC0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x4BF2F78", Offset = "0x4BF2F78", VA = "0x4BF2F78")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class V2Tools
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x4BF2F80", Offset = "0x4BF2F80", VA = "0x4BF2F80")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x4BF2FB0", Offset = "0x4BF2FB0", VA = "0x4BF2FB0")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4BF305C", Offset = "0x4BF305C", VA = "0x4BF305C")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x4BF3108", Offset = "0x4BF3108", VA = "0x4BF3108")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x4BF32D8", Offset = "0x4BF32D8", VA = "0x4BF32D8")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	public static class V3Tools
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4BF3440", Offset = "0x4BF3440", VA = "0x4BF3440")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4BF34C4", Offset = "0x4BF34C4", VA = "0x4BF34C4")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4BF3564", Offset = "0x4BF3564", VA = "0x4BF3564")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4BF36A8", Offset = "0x4BF36A8", VA = "0x4BF36A8")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4BF37C8", Offset = "0x4BF37C8", VA = "0x4BF37C8")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4BF38E0", Offset = "0x4BF38E0", VA = "0x4BF38E0")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4BF3AA4", Offset = "0x4BF3AA4", VA = "0x4BF3AA4")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4BF3B9C", Offset = "0x4BF3B9C", VA = "0x4BF3B9C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4BF3C94", Offset = "0x4BF3C94", VA = "0x4BF3C94")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4BF3E00", Offset = "0x4BF3E00", VA = "0x4BF3E00")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4BF3F9C", Offset = "0x4BF3F9C", VA = "0x4BF3F9C")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x4BF40E8", Offset = "0x4BF40E8", VA = "0x4BF40E8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x4BF430C", Offset = "0x4BF430C", VA = "0x4BF430C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4BF4548", Offset = "0x4BF4548", VA = "0x4BF4548")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4BF4798", Offset = "0x4BF4798", VA = "0x4BF4798")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x4BF4998", Offset = "0x4BF4998", VA = "0x4BF4998")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x4BF4B74", Offset = "0x4BF4B74", VA = "0x4BF4B74")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4BF4CA8", Offset = "0x4BF4CA8", VA = "0x4BF4CA8")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x4BF4E00", Offset = "0x4BF4E00", VA = "0x4BF4E00")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4BF4F8C", Offset = "0x4BF4F8C", VA = "0x4BF4F8C")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4BF4F4C", Offset = "0x4BF4F4C", VA = "0x4BF4F4C")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000028")]
	public static class Warning
	{
		[Token(Token = "0x200009E")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4BF50C8", Offset = "0x4BF50C8", VA = "0x4BF50C8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4BF54F4", Offset = "0x4BF54F4", VA = "0x4BF54F4")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x2000029")]
	public class Navigator
	{
		[Token(Token = "0x200009F")]
		public enum State
		{
			[Token(Token = "0x4000410")]
			Idle,
			[Token(Token = "0x4000411")]
			Seeking,
			[Token(Token = "0x4000412")]
			OnPath
		}

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197514C", Offset = "0x197514C")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975184", Offset = "0x1975184")]
		public float cornerRadius;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19751BC", Offset = "0x19751BC")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19751F4", Offset = "0x19751F4")]
		public float maxSampleDistance;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197522C", Offset = "0x197522C")]
		public float nextPathInterval;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1975264", Offset = "0x1975264")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1975274", Offset = "0x1975274")]
		private State <state>k__BackingField;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000014")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x367B22C", Offset = "0x367B22C", VA = "0x367B22C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DCFC", Offset = "0x197DCFC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x367B238", Offset = "0x367B238", VA = "0x367B238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DD0C", Offset = "0x197DD0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public State state
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x367B244", Offset = "0x367B244", VA = "0x367B244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DD1C", Offset = "0x197DD1C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x367B24C", Offset = "0x367B24C", VA = "0x367B24C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DD2C", Offset = "0x197DD2C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x367B254", Offset = "0x367B254", VA = "0x367B254")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x367B328", Offset = "0x367B328", VA = "0x367B328")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x367B86C", Offset = "0x367B86C", VA = "0x367B86C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x367B8DC", Offset = "0x367B8DC", VA = "0x367B8DC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x367B734", Offset = "0x367B734", VA = "0x367B734")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x367B7A8", Offset = "0x367B7A8", VA = "0x367B7A8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x367BA24", Offset = "0x367BA24", VA = "0x367BA24")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x367BBD4", Offset = "0x367BBD4", VA = "0x367BBD4")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974204", Offset = "0x1974204")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974204", Offset = "0x1974204")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x367DE14", Offset = "0x367DE14", VA = "0x367DE14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DD3C", Offset = "0x197DD3C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x367DE60", Offset = "0x367DE60", VA = "0x367DE60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DD74", Offset = "0x197DD74")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x367DEAC", Offset = "0x367DEAC", VA = "0x367DEAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DDAC", Offset = "0x197DDAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x367DEF8", Offset = "0x367DEF8", VA = "0x367DEF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DDE4", Offset = "0x197DDE4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x367DF44", Offset = "0x367DF44", VA = "0x367DF44")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x367DFE0", Offset = "0x367DFE0", VA = "0x367DFE0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x367E000", Offset = "0x367E000", VA = "0x367E000")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x367E030", Offset = "0x367E030", VA = "0x367E030")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x367E060", Offset = "0x367E060", VA = "0x367E060")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x367E0A0", Offset = "0x367E0A0", VA = "0x367E0A0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x367E0E4", Offset = "0x367E0E4", VA = "0x367E0E4")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x367E108", Offset = "0x367E108", VA = "0x367E108")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x367E12C", Offset = "0x367E12C", VA = "0x367E12C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x367E154", Offset = "0x367E154", VA = "0x367E154")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x367E180", Offset = "0x367E180", VA = "0x367E180")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x367E1AC", Offset = "0x367E1AC", VA = "0x367E1AC")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x367DF64", Offset = "0x367DF64", VA = "0x367DF64")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x367E1D4", Offset = "0x367E1D4", VA = "0x367E1D4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x367E1E0", Offset = "0x367E1E0", VA = "0x367E1E0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x367E1EC", Offset = "0x367E1EC", VA = "0x367E1EC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x367E4D4", Offset = "0x367E4D4", VA = "0x367E4D4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x367E57C", Offset = "0x367E57C", VA = "0x367E57C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x367E8C0", Offset = "0x367E8C0", VA = "0x367E8C0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x367EDA8", Offset = "0x367EDA8", VA = "0x367EDA8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x367EDDC", Offset = "0x367EDDC", VA = "0x367EDDC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000016")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x367E38C", Offset = "0x367E38C", VA = "0x367E38C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x367EFA4", Offset = "0x367EFA4", VA = "0x367EFA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x367E748", Offset = "0x367E748", VA = "0x367E748")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x367EE5C", Offset = "0x367EE5C", VA = "0x367EE5C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000018")]
		public bool isValid
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x367FA7C", Offset = "0x367FA7C", VA = "0x367FA7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000156")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x367FAEC", Offset = "0x367FAEC", VA = "0x367FAEC")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x367FAF4", Offset = "0x367FAF4", VA = "0x367FAF4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x367FC00", Offset = "0x367FC00", VA = "0x367FC00")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x367FC08", Offset = "0x367FC08", VA = "0x367FC08")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000019")]
		private bool positionChanged
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x367FDD0", Offset = "0x367FDD0", VA = "0x367FDD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x367FC34", Offset = "0x367FC34", VA = "0x367FC34", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x367FE8C", Offset = "0x367FE8C", VA = "0x367FE8C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x367FE94", Offset = "0x367FE94", VA = "0x367FE94")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x367FEC0", Offset = "0x367FEC0", VA = "0x367FEC0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x367FFE8", Offset = "0x367FFE8", VA = "0x367FFE8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x367FFF0", Offset = "0x367FFF0", VA = "0x367FFF0")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x36801BC", Offset = "0x36801BC", VA = "0x36801BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x368001C", Offset = "0x368001C", VA = "0x368001C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x368028C", Offset = "0x368028C", VA = "0x368028C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x3680294", Offset = "0x3680294", VA = "0x3680294")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class Constraints
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975284", Offset = "0x1975284")]
		public float positionWeight;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197529C", Offset = "0x197529C")]
		public float rotationWeight;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x36802C0", Offset = "0x36802C0", VA = "0x36802C0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x367E86C", Offset = "0x367E86C", VA = "0x367E86C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x367EA48", Offset = "0x367EA48", VA = "0x367EA48")]
		public void Update()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x367F170", Offset = "0x367F170", VA = "0x367F170")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000A0")]
		public enum DOF
		{
			[Token(Token = "0x4000414")]
			One,
			[Token(Token = "0x4000415")]
			Three
		}

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19752B4", Offset = "0x19752B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19752B4", Offset = "0x19752B4")]
		public float weight;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975308", Offset = "0x1975308")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975308", Offset = "0x1975308")]
		public float rotationWeight;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197535C", Offset = "0x197535C")]
		public DOF rotationDOF;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975394", Offset = "0x1975394")]
		public bool fixBone1Twist;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19753CC", Offset = "0x19753CC")]
		public Transform bone1;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975404", Offset = "0x1975404")]
		public Transform bone2;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197543C", Offset = "0x197543C")]
		public Transform bone3;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975474", Offset = "0x1975474")]
		public Transform tip;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19754AC", Offset = "0x19754AC")]
		public Transform target;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19754E4", Offset = "0x19754E4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x1700001B")]
		public bool initiated
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x3D75568", Offset = "0x3D75568", VA = "0x3D75568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DE1C", Offset = "0x197DE1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x3D75570", Offset = "0x3D75570", VA = "0x3D75570")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DE2C", Offset = "0x197DE2C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x3D7557C", Offset = "0x3D7557C", VA = "0x3D7557C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x3D7559C", Offset = "0x3D7559C", VA = "0x3D7559C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x3D755BC", Offset = "0x3D755BC", VA = "0x3D755BC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x3D755DC", Offset = "0x3D755DC", VA = "0x3D755DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x3D755FC", Offset = "0x3D755FC", VA = "0x3D755FC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x3D756FC", Offset = "0x3D756FC", VA = "0x3D756FC")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x3D75D90", Offset = "0x3D75D90", VA = "0x3D75D90")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x3D75E6C", Offset = "0x3D75E6C", VA = "0x3D75E6C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x3D75F34", Offset = "0x3D75F34", VA = "0x3D75F34")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x3D76550", Offset = "0x3D76550", VA = "0x3D76550")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19754F4", Offset = "0x19754F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19754F4", Offset = "0x19754F4")]
		public float weight;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1975548", Offset = "0x1975548")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001E")]
		public bool initiated
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x3D76560", Offset = "0x3D76560", VA = "0x3D76560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DE3C", Offset = "0x197DE3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x3D76568", Offset = "0x3D76568", VA = "0x3D76568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DE4C", Offset = "0x197DE4C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x3D76574", Offset = "0x3D76574", VA = "0x3D76574")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3D765FC", Offset = "0x3D765FC", VA = "0x3D765FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DE5C", Offset = "0x197DE5C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x3D76920", Offset = "0x3D76920", VA = "0x3D76920")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x3D76A90", Offset = "0x3D76A90", VA = "0x3D76A90")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x3D76818", Offset = "0x3D76818", VA = "0x3D76818")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x3D76BF8", Offset = "0x3D76BF8", VA = "0x3D76BF8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x3D76CB8", Offset = "0x3D76CB8", VA = "0x3D76CB8")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x3D76D30", Offset = "0x3D76D30", VA = "0x3D76D30")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x3D76DA4", Offset = "0x3D76DA4", VA = "0x3D76DA4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x3D76E0C", Offset = "0x3D76E0C", VA = "0x3D76E0C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x3D76E10", Offset = "0x3D76E10", VA = "0x3D76E10", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x3D76E24", Offset = "0x3D76E24", VA = "0x3D76E24")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000A1")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975558", Offset = "0x1975558")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975558", Offset = "0x1975558")]
		public float weight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19755AC", Offset = "0x19755AC")]
		public Grounding solver;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19755E4", Offset = "0x19755E4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001F")]
		public bool initiated
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x3D77E58", Offset = "0x3D77E58", VA = "0x3D77E58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DE94", Offset = "0x197DE94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x3D77E60", Offset = "0x3D77E60", VA = "0x3D77E60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197DEA4", Offset = "0x197DEA4")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000184")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x3D77E6C", Offset = "0x3D77E6C", VA = "0x3D77E6C")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x3D78140", Offset = "0x3D78140", VA = "0x3D78140")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x3D77FB0", Offset = "0x3D77FB0", VA = "0x3D77FB0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x3D78174", Offset = "0x3D78174", VA = "0x3D78174")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600018C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x3D7837C", Offset = "0x3D7837C", VA = "0x3D7837C")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974264", Offset = "0x1974264")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974264", Offset = "0x1974264")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19755F4", Offset = "0x19755F4")]
		public BipedIK ik;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197562C", Offset = "0x197562C")]
		public float spineBend;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975664", Offset = "0x1975664")]
		public float spineSpeed;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x3D786E4", Offset = "0x3D786E4", VA = "0x3D786E4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DEB4", Offset = "0x197DEB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x3D78730", Offset = "0x3D78730", VA = "0x3D78730", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DEEC", Offset = "0x197DEEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3D7877C", Offset = "0x3D7877C", VA = "0x3D7877C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x3D78880", Offset = "0x3D78880", VA = "0x3D78880")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x3D78930", Offset = "0x3D78930", VA = "0x3D78930")]
		private void Update()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x3D789E4", Offset = "0x3D789E4", VA = "0x3D789E4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x3D78EF8", Offset = "0x3D78EF8", VA = "0x3D78EF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x3D78F4C", Offset = "0x3D78F4C", VA = "0x3D78F4C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x3D79760", Offset = "0x3D79760", VA = "0x3D79760")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3D798C0", Offset = "0x3D798C0", VA = "0x3D798C0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x3D79A50", Offset = "0x3D79A50", VA = "0x3D79A50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x3D79BC0", Offset = "0x3D79BC0", VA = "0x3D79BC0")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19742C4", Offset = "0x19742C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19742C4", Offset = "0x19742C4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class SpineEffector
		{
			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978998", Offset = "0x1978998")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19789D0", Offset = "0x19789D0")]
			public float horizontalWeight;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978A08", Offset = "0x1978A08")]
			public float verticalWeight;

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x3D7AA28", Offset = "0x3D7AA28", VA = "0x3D7AA28")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x3D7AA38", Offset = "0x3D7AA38", VA = "0x3D7AA38")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197569C", Offset = "0x197569C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19756D4", Offset = "0x19756D4")]
		public float spineBend;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197570C", Offset = "0x197570C")]
		public float spineSpeed;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x3D79C40", Offset = "0x3D79C40", VA = "0x3D79C40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DF24", Offset = "0x197DF24")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x3D79C8C", Offset = "0x3D79C8C", VA = "0x3D79C8C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DF5C", Offset = "0x197DF5C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x3D79CD8", Offset = "0x3D79CD8", VA = "0x3D79CD8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DF94", Offset = "0x197DF94")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x3D79D24", Offset = "0x3D79D24", VA = "0x3D79D24", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x3D79DA4", Offset = "0x3D79DA4", VA = "0x3D79DA4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3D79E3C", Offset = "0x3D79E3C", VA = "0x3D79E3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x3D7A0F8", Offset = "0x3D7A0F8", VA = "0x3D7A0F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x3D7A104", Offset = "0x3D7A104", VA = "0x3D7A104")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x3D79EF8", Offset = "0x3D79EF8", VA = "0x3D79EF8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x3D7A110", Offset = "0x3D7A110", VA = "0x3D7A110")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x3D7A5B0", Offset = "0x3D7A5B0", VA = "0x3D7A5B0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x3D7A770", Offset = "0x3D7A770", VA = "0x3D7A770")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x3D7A8A8", Offset = "0x3D7A8A8", VA = "0x3D7A8A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3D7A9A8", Offset = "0x3D7A9A8", VA = "0x3D7A9A8")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974324", Offset = "0x1974324")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974324", Offset = "0x1974324")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975744", Offset = "0x1975744")]
		public Transform pelvis;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197577C", Offset = "0x197577C")]
		public Transform characterRoot;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19757B4", Offset = "0x19757B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19757B4", Offset = "0x19757B4")]
		public float rootRotationWeight;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975808", Offset = "0x1975808")]
		public float rootRotationSpeed;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975840", Offset = "0x1975840")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x3D7AA80", Offset = "0x3D7AA80", VA = "0x3D7AA80", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197DFCC", Offset = "0x197DFCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x3D7AACC", Offset = "0x3D7AACC", VA = "0x3D7AACC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E004", Offset = "0x197E004")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x3D7AB18", Offset = "0x3D7AB18", VA = "0x3D7AB18", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x3D7AB30", Offset = "0x3D7AB30", VA = "0x3D7AB30")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x3D7AD20", Offset = "0x3D7AD20", VA = "0x3D7AD20")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x3D7AE20", Offset = "0x3D7AE20", VA = "0x3D7AE20")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x3D7B568", Offset = "0x3D7B568", VA = "0x3D7B568")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x3D7B94C", Offset = "0x3D7B94C", VA = "0x3D7B94C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x3D7BBBC", Offset = "0x3D7BBBC", VA = "0x3D7BBBC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x3D7BEDC", Offset = "0x3D7BEDC", VA = "0x3D7BEDC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x3D7C078", Offset = "0x3D7C078", VA = "0x3D7C078")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x3D7C240", Offset = "0x3D7C240", VA = "0x3D7C240")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974384", Offset = "0x1974384")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974384", Offset = "0x1974384")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000A3")]
		public struct Foot
		{
			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x3D7CDBC", Offset = "0x3D7CDBC", VA = "0x3D7CDBC")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975878", Offset = "0x1975878")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19758B0", Offset = "0x19758B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19758B0", Offset = "0x19758B0")]
		public float rootRotationWeight;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975904", Offset = "0x1975904")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975904", Offset = "0x1975904")]
		public float minRootRotation;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197595C", Offset = "0x197595C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197595C", Offset = "0x197595C")]
		public float maxRootRotation;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19759B4", Offset = "0x19759B4")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19759EC", Offset = "0x19759EC")]
		public float maxLegOffset;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975A24", Offset = "0x1975A24")]
		public float maxForeLegOffset;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975A5C", Offset = "0x1975A5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975A5C", Offset = "0x1975A5C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975AB0", Offset = "0x1975AB0")]
		public Transform characterRoot;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975AE8", Offset = "0x1975AE8")]
		public Transform pelvis;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975B20", Offset = "0x1975B20")]
		public Transform lastSpineBone;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975B58", Offset = "0x1975B58")]
		public Transform head;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x3D7C2C0", Offset = "0x3D7C2C0", VA = "0x3D7C2C0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E03C", Offset = "0x197E03C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x3D7C30C", Offset = "0x3D7C30C", VA = "0x3D7C30C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E074", Offset = "0x197E074")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x3D7C358", Offset = "0x3D7C358", VA = "0x3D7C358", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x3D7C38C", Offset = "0x3D7C38C", VA = "0x3D7C38C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x3D7C4BC", Offset = "0x3D7C4BC", VA = "0x3D7C4BC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x3D7C67C", Offset = "0x3D7C67C", VA = "0x3D7C67C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x3D7C6E4", Offset = "0x3D7C6E4", VA = "0x3D7C6E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x3D7C79C", Offset = "0x3D7C79C", VA = "0x3D7C79C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x3D7CA9C", Offset = "0x3D7CA9C", VA = "0x3D7CA9C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x3D7CDFC", Offset = "0x3D7CDFC", VA = "0x3D7CDFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x3D7CF48", Offset = "0x3D7CF48", VA = "0x3D7CF48")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x3D7D3EC", Offset = "0x3D7D3EC", VA = "0x3D7D3EC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x3D7DBDC", Offset = "0x3D7DBDC", VA = "0x3D7DBDC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x3D7DE9C", Offset = "0x3D7DE9C", VA = "0x3D7DE9C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x3D7DFFC", Offset = "0x3D7DFFC", VA = "0x3D7DFFC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x3D7E2D8", Offset = "0x3D7E2D8", VA = "0x3D7E2D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x3D7E310", Offset = "0x3D7E310", VA = "0x3D7E310")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x3D7E4D0", Offset = "0x3D7E4D0", VA = "0x3D7E4D0")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19743E4", Offset = "0x19743E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19743E4", Offset = "0x19743E4")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975BA0", Offset = "0x1975BA0")]
		public VRIK ik;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x3D7E5E8", Offset = "0x3D7E5E8", VA = "0x3D7E5E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E0AC", Offset = "0x197E0AC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x3D7E634", Offset = "0x3D7E634", VA = "0x3D7E634", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E0E4", Offset = "0x197E0E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x3D7E680", Offset = "0x3D7E680", VA = "0x3D7E680", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E11C", Offset = "0x197E11C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x3D7E6CC", Offset = "0x3D7E6CC", VA = "0x3D7E6CC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x3D7E6E4", Offset = "0x3D7E6E4", VA = "0x3D7E6E4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x3D7E77C", Offset = "0x3D7E77C", VA = "0x3D7E77C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x3D7E830", Offset = "0x3D7E830", VA = "0x3D7E830")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x3D7EA30", Offset = "0x3D7EA30", VA = "0x3D7EA30")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x3D7ECC4", Offset = "0x3D7ECC4", VA = "0x3D7ECC4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x3D7EDCC", Offset = "0x3D7EDCC", VA = "0x3D7EDCC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x3D7EFCC", Offset = "0x3D7EFCC", VA = "0x3D7EFCC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x3D7F104", Offset = "0x3D7F104", VA = "0x3D7F104")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x3D7F264", Offset = "0x3D7F264", VA = "0x3D7F264")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public enum Quality
		{
			[Token(Token = "0x400041E")]
			Fastest,
			[Token(Token = "0x400041F")]
			Simple,
			[Token(Token = "0x4000420")]
			Best
		}

		[Token(Token = "0x20000A5")]
		public class Leg
		{
			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978A40", Offset = "0x1978A40")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978A50", Offset = "0x1978A50")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978A60", Offset = "0x1978A60")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978A70", Offset = "0x1978A70")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978A80", Offset = "0x1978A80")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978A90", Offset = "0x1978A90")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978AA0", Offset = "0x1978AA0")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978AB0", Offset = "0x1978AB0")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978AC0", Offset = "0x1978AC0")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000082")]
			public bool isGrounded
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0x3D80CBC", Offset = "0x3D80CBC", VA = "0x3D80CBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC28", Offset = "0x197FC28")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600059D")]
				[Address(RVA = "0x3D80CC4", Offset = "0x3D80CC4", VA = "0x3D80CC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC38", Offset = "0x197FC38")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600059E")]
				[Address(RVA = "0x3D80CD0", Offset = "0x3D80CD0", VA = "0x3D80CD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC48", Offset = "0x197FC48")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600059F")]
				[Address(RVA = "0x3D80CDC", Offset = "0x3D80CDC", VA = "0x3D80CDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC58", Offset = "0x197FC58")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public bool initiated
			{
				[Token(Token = "0x60005A0")]
				[Address(RVA = "0x3D80CE8", Offset = "0x3D80CE8", VA = "0x3D80CE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC68", Offset = "0x197FC68")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005A1")]
				[Address(RVA = "0x3D80CF0", Offset = "0x3D80CF0", VA = "0x3D80CF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC78", Offset = "0x197FC78")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public float heightFromGround
			{
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0x3D80CFC", Offset = "0x3D80CFC", VA = "0x3D80CFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC88", Offset = "0x197FC88")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0x3D80D04", Offset = "0x3D80D04", VA = "0x3D80D04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC98", Offset = "0x197FC98")]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x3D80D0C", Offset = "0x3D80D0C", VA = "0x3D80D0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FCA8", Offset = "0x197FCA8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x3D80D18", Offset = "0x3D80D18", VA = "0x3D80D18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FCB8", Offset = "0x197FCB8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000087")]
			public Transform transform
			{
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x3D80D24", Offset = "0x3D80D24", VA = "0x3D80D24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FCC8", Offset = "0x197FCC8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0x3D80D2C", Offset = "0x3D80D2C", VA = "0x3D80D2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FCD8", Offset = "0x197FCD8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public float IKOffset
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x3D80D34", Offset = "0x3D80D34", VA = "0x3D80D34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FCE8", Offset = "0x197FCE8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0x3D80D3C", Offset = "0x3D80D3C", VA = "0x3D80D3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FCF8", Offset = "0x197FCF8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x3D80D44", Offset = "0x3D80D44", VA = "0x3D80D44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD08", Offset = "0x197FD08")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0x3D80D5C", Offset = "0x3D80D5C", VA = "0x3D80D5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD18", Offset = "0x197FD18")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0x3D80D7C", Offset = "0x3D80D7C", VA = "0x3D80D7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD28", Offset = "0x197FD28")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x3D80D94", Offset = "0x3D80D94", VA = "0x3D80D94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD38", Offset = "0x197FD38")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0x3D80DB4", Offset = "0x3D80DB4", VA = "0x3D80DB4")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700008C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005B4")]
				[Address(RVA = "0x3D81B78", Offset = "0x3D81B78", VA = "0x3D81B78")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700008D")]
			private float rootYOffset
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x3D81E50", Offset = "0x3D81E50", VA = "0x3D81E50")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x3D80DFC", Offset = "0x3D80DFC", VA = "0x3D80DFC")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x3D7F8FC", Offset = "0x3D7F8FC", VA = "0x3D7F8FC")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x3D80E10", Offset = "0x3D80E10", VA = "0x3D80E10")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x3D807DC", Offset = "0x3D807DC", VA = "0x3D807DC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x3D7FA08", Offset = "0x3D7FA08", VA = "0x3D7FA08")]
			public void Process()
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x3D815EC", Offset = "0x3D815EC", VA = "0x3D815EC")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x3D80E5C", Offset = "0x3D80E5C", VA = "0x3D80E5C")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x3D81CF8", Offset = "0x3D81CF8", VA = "0x3D81CF8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x3D81298", Offset = "0x3D81298", VA = "0x3D81298")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x3D813A0", Offset = "0x3D813A0", VA = "0x3D813A0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x3D81DF4", Offset = "0x3D81DF4", VA = "0x3D81DF4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x3D81C04", Offset = "0x3D81C04", VA = "0x3D81C04")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x3D81F78", Offset = "0x3D81F78", VA = "0x3D81F78")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x3D7F84C", Offset = "0x3D7F84C", VA = "0x3D7F84C")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000A6")]
		public class Pelvis
		{
			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978AD0", Offset = "0x1978AD0")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978AE0", Offset = "0x1978AE0")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700008E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x3D82068", Offset = "0x3D82068", VA = "0x3D82068")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD48", Offset = "0x197FD48")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x3D82074", Offset = "0x3D82074", VA = "0x3D82074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD58", Offset = "0x197FD58")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			public float heightOffset
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x3D82080", Offset = "0x3D82080", VA = "0x3D82080")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD68", Offset = "0x197FD68")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x3D82088", Offset = "0x3D82088", VA = "0x3D82088")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD78", Offset = "0x197FD78")]
				private set
				{
				}
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x3D7F9E0", Offset = "0x3D7F9E0", VA = "0x3D7F9E0")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x3D8072C", Offset = "0x3D8072C", VA = "0x3D8072C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x3D82090", Offset = "0x3D82090", VA = "0x3D82090")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x3D804C0", Offset = "0x3D804C0", VA = "0x3D804C0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x3D7F8F4", Offset = "0x3D7F8F4", VA = "0x3D7F8F4")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975BD8", Offset = "0x1975BD8")]
		public LayerMask layers;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975C10", Offset = "0x1975C10")]
		public float maxStep;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975C48", Offset = "0x1975C48")]
		public float heightOffset;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975C80", Offset = "0x1975C80")]
		public float footSpeed;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975CB8", Offset = "0x1975CB8")]
		public float footRadius;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975CF0", Offset = "0x1975CF0")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975D3C", Offset = "0x1975D3C")]
		public float prediction;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975D74", Offset = "0x1975D74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975D74", Offset = "0x1975D74")]
		public float footRotationWeight;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975DC8", Offset = "0x1975DC8")]
		public float footRotationSpeed;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975E00", Offset = "0x1975E00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975E00", Offset = "0x1975E00")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975E58", Offset = "0x1975E58")]
		public bool rotateSolver;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975E90", Offset = "0x1975E90")]
		public float pelvisSpeed;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975EC8", Offset = "0x1975EC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1975EC8", Offset = "0x1975EC8")]
		public float pelvisDamper;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975F1C", Offset = "0x1975F1C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975F54", Offset = "0x1975F54")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975F8C", Offset = "0x1975F8C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975FC4", Offset = "0x1975FC4")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1975FFC", Offset = "0x1975FFC")]
		public Quality quality;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1976034", Offset = "0x1976034")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1976044", Offset = "0x1976044")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1976054", Offset = "0x1976054")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1976064", Offset = "0x1976064")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1976074", Offset = "0x1976074")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000020")]
		public Leg[] legs
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x3D7F2C0", Offset = "0x3D7F2C0", VA = "0x3D7F2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E154", Offset = "0x197E154")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x3D7F2C8", Offset = "0x3D7F2C8", VA = "0x3D7F2C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E164", Offset = "0x197E164")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x3D7F2D0", Offset = "0x3D7F2D0", VA = "0x3D7F2D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E174", Offset = "0x197E174")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x3D7F2D8", Offset = "0x3D7F2D8", VA = "0x3D7F2D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E184", Offset = "0x197E184")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool isGrounded
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x3D7F2E0", Offset = "0x3D7F2E0", VA = "0x3D7F2E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E194", Offset = "0x197E194")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x3D7F2E8", Offset = "0x3D7F2E8", VA = "0x3D7F2E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E1A4", Offset = "0x197E1A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Transform root
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x3D7F2F4", Offset = "0x3D7F2F4", VA = "0x3D7F2F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E1B4", Offset = "0x197E1B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x3D7F2FC", Offset = "0x3D7F2FC", VA = "0x3D7F2FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E1C4", Offset = "0x197E1C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x3D7F304", Offset = "0x3D7F304", VA = "0x3D7F304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E1D4", Offset = "0x197E1D4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x3D7F31C", Offset = "0x3D7F31C", VA = "0x3D7F31C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197E1E4", Offset = "0x197E1E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x3D7F33C", Offset = "0x3D7F33C", VA = "0x3D7F33C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 up
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x3D79834", Offset = "0x3D79834", VA = "0x3D79834")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x3D80890", Offset = "0x3D80890", VA = "0x3D80890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3D7F390", Offset = "0x3D7F390", VA = "0x3D7F390")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x3D7F770", Offset = "0x3D7F770", VA = "0x3D7F770")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x3D78C98", Offset = "0x3D78C98", VA = "0x3D78C98")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x3D794B8", Offset = "0x3D794B8", VA = "0x3D794B8")]
		public void Update()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x3D7B350", Offset = "0x3D7B350", VA = "0x3D7B350")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x3D787FC", Offset = "0x3D787FC", VA = "0x3D787FC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x3D7F9F0", Offset = "0x3D7F9F0", VA = "0x3D7F9F0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x3D80960", Offset = "0x3D80960", VA = "0x3D80960")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x3D80AC8", Offset = "0x3D80AC8", VA = "0x3D80AC8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x3D80BCC", Offset = "0x3D80BCC", VA = "0x3D80BCC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x3D7843C", Offset = "0x3D7843C", VA = "0x3D7843C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974444", Offset = "0x1974444")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974444", Offset = "0x1974444")]
	public class AimIK : IK
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x367D040", Offset = "0x367D040", VA = "0x367D040", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E1F4", Offset = "0x197E1F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x367D08C", Offset = "0x367D08C", VA = "0x367D08C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E22C", Offset = "0x197E22C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x367D0D8", Offset = "0x367D0D8", VA = "0x367D0D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E264", Offset = "0x197E264")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x367D124", Offset = "0x367D124", VA = "0x367D124")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E29C", Offset = "0x197E29C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x367D170", Offset = "0x367D170", VA = "0x367D170")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E2D4", Offset = "0x197E2D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x367D1BC", Offset = "0x367D1BC", VA = "0x367D1BC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x367D1C4", Offset = "0x367D1C4", VA = "0x367D1C4")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19744A4", Offset = "0x19744A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19744A4", Offset = "0x19744A4")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x367DC74", Offset = "0x367DC74", VA = "0x367DC74", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E30C", Offset = "0x197E30C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x367DCC0", Offset = "0x367DCC0", VA = "0x367DCC0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E344", Offset = "0x197E344")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x367DD0C", Offset = "0x367DD0C", VA = "0x367DD0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E37C", Offset = "0x197E37C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x367DD58", Offset = "0x367DD58", VA = "0x367DD58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E3B4", Offset = "0x197E3B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x367DDA4", Offset = "0x367DDA4", VA = "0x367DDA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x367DDAC", Offset = "0x367DDAC", VA = "0x367DDAC")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974504", Offset = "0x1974504")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974504", Offset = "0x1974504")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x367F8DC", Offset = "0x367F8DC", VA = "0x367F8DC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E3EC", Offset = "0x197E3EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x367F928", Offset = "0x367F928", VA = "0x367F928", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E424", Offset = "0x197E424")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x367F974", Offset = "0x367F974", VA = "0x367F974")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E45C", Offset = "0x197E45C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x367F9C0", Offset = "0x367F9C0", VA = "0x367F9C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E494", Offset = "0x197E494")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x367FA0C", Offset = "0x367FA0C", VA = "0x367FA0C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x367FA14", Offset = "0x367FA14", VA = "0x367FA14")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974564", Offset = "0x1974564")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974564", Offset = "0x1974564")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x3680FBC", Offset = "0x3680FBC", VA = "0x3680FBC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E4CC", Offset = "0x197E4CC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x3681008", Offset = "0x3681008", VA = "0x3681008", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E504", Offset = "0x197E504")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x3681054", Offset = "0x3681054", VA = "0x3681054")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E53C", Offset = "0x197E53C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x36810A0", Offset = "0x36810A0", VA = "0x36810A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E574", Offset = "0x197E574")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x36810EC", Offset = "0x36810EC", VA = "0x36810EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x36810F4", Offset = "0x36810F4", VA = "0x36810F4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19745C4", Offset = "0x19745C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19745C4", Offset = "0x19745C4")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x3D6E288", Offset = "0x3D6E288", VA = "0x3D6E288", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E5AC", Offset = "0x197E5AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x3D6E2D4", Offset = "0x3D6E2D4", VA = "0x3D6E2D4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E5E4", Offset = "0x197E5E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x3D6E320", Offset = "0x3D6E320", VA = "0x3D6E320")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E61C", Offset = "0x197E61C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x3D6E36C", Offset = "0x3D6E36C", VA = "0x3D6E36C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E654", Offset = "0x197E654")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x3D6E3B8", Offset = "0x3D6E3B8", VA = "0x3D6E3B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x3D6E3C0", Offset = "0x3D6E3C0", VA = "0x3D6E3C0")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974624", Offset = "0x1974624")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974624", Offset = "0x1974624")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x3D76E8C", Offset = "0x3D76E8C", VA = "0x3D76E8C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E68C", Offset = "0x197E68C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x3D76ED8", Offset = "0x3D76ED8", VA = "0x3D76ED8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E6C4", Offset = "0x197E6C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x3D76F24", Offset = "0x3D76F24", VA = "0x3D76F24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E6FC", Offset = "0x197E6FC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x3D76F70", Offset = "0x3D76F70", VA = "0x3D76F70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E734", Offset = "0x197E734")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x3D76FBC", Offset = "0x3D76FBC", VA = "0x3D76FBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E76C", Offset = "0x197E76C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x3D77008", Offset = "0x3D77008", VA = "0x3D77008")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E7A4", Offset = "0x197E7A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x3D77054", Offset = "0x3D77054", VA = "0x3D77054")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x3D77078", Offset = "0x3D77078", VA = "0x3D77078", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x3D77080", Offset = "0x3D77080", VA = "0x3D77080")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x3D7723C", Offset = "0x3D7723C", VA = "0x3D7723C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x3D77590", Offset = "0x3D77590", VA = "0x3D77590")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E7DC", Offset = "0x197E7DC")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3D775B0", Offset = "0x3D775B0", VA = "0x3D775B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E814", Offset = "0x197E814")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x3D7768C", Offset = "0x3D7768C", VA = "0x3D7768C")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000217")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x3D84B78", Offset = "0x3D84B78", VA = "0x3D84B78", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x3D84C00", Offset = "0x3D84C00", VA = "0x3D84C00", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x3D84C74", Offset = "0x3D84C74", VA = "0x3D84C74", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600021B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600021C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x3D6E428", Offset = "0x3D6E428", VA = "0x3D6E428")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976084", Offset = "0x1976084")]
		public IK[] IKComponents;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19760BC", Offset = "0x19760BC")]
		public Animator animator;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000028")]
		private bool animatePhysics
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x42A8C18", Offset = "0x42A8C18", VA = "0x42A8C18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x42A8CB4", Offset = "0x42A8CB4", VA = "0x42A8CB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x42A8D24", Offset = "0x42A8D24", VA = "0x42A8D24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x42A8DE0", Offset = "0x42A8DE0", VA = "0x42A8DE0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x42A8E1C", Offset = "0x42A8E1C", VA = "0x42A8E1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x42A8D58", Offset = "0x42A8D58", VA = "0x42A8D58")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x42A8F10", Offset = "0x42A8F10", VA = "0x42A8F10")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974684", Offset = "0x1974684")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974684", Offset = "0x1974684")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x3A9FBE4", Offset = "0x3A9FBE4", VA = "0x3A9FBE4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E84C", Offset = "0x197E84C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x3A9FC30", Offset = "0x3A9FC30", VA = "0x3A9FC30", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E884", Offset = "0x197E884")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x3A9FC7C", Offset = "0x3A9FC7C", VA = "0x3A9FC7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E8BC", Offset = "0x197E8BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x3A9FCC8", Offset = "0x3A9FCC8", VA = "0x3A9FCC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E8F4", Offset = "0x197E8F4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x3A9FD14", Offset = "0x3A9FD14", VA = "0x3A9FD14", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x3A9FD1C", Offset = "0x3A9FD1C", VA = "0x3A9FD1C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19746E4", Offset = "0x19746E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19746E4", Offset = "0x19746E4")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x3A9FD84", Offset = "0x3A9FD84", VA = "0x3A9FD84", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E92C", Offset = "0x197E92C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x3A9FDD0", Offset = "0x3A9FDD0", VA = "0x3A9FDD0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E964", Offset = "0x197E964")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x3A9FE1C", Offset = "0x3A9FE1C", VA = "0x3A9FE1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E99C", Offset = "0x197E99C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x3A9FE68", Offset = "0x3A9FE68", VA = "0x3A9FE68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197E9D4", Offset = "0x197E9D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x3A9FEB4", Offset = "0x3A9FEB4", VA = "0x3A9FEB4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3A9FEBC", Offset = "0x3A9FEBC", VA = "0x3A9FEBC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974744", Offset = "0x1974744")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974744", Offset = "0x1974744")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x3AA0D8C", Offset = "0x3AA0D8C", VA = "0x3AA0D8C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EA0C", Offset = "0x197EA0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3AA0DD8", Offset = "0x3AA0DD8", VA = "0x3AA0DD8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EA44", Offset = "0x197EA44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3AA0E24", Offset = "0x3AA0E24", VA = "0x3AA0E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EA7C", Offset = "0x197EA7C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3AA0E70", Offset = "0x3AA0E70", VA = "0x3AA0E70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EAB4", Offset = "0x197EAB4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3AA0EBC", Offset = "0x3AA0EBC", VA = "0x3AA0EBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3AA0EC4", Offset = "0x3AA0EC4", VA = "0x3AA0EC4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19747A4", Offset = "0x19747A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19747A4", Offset = "0x19747A4")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3AA950C", Offset = "0x3AA950C", VA = "0x3AA950C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EAEC", Offset = "0x197EAEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x3AA9558", Offset = "0x3AA9558", VA = "0x3AA9558", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EB24", Offset = "0x197EB24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x3AA95A4", Offset = "0x3AA95A4", VA = "0x3AA95A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EB5C", Offset = "0x197EB5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x3AA95F0", Offset = "0x3AA95F0", VA = "0x3AA95F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EB94", Offset = "0x197EB94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x3AA963C", Offset = "0x3AA963C", VA = "0x3AA963C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x3AA9644", Offset = "0x3AA9644", VA = "0x3AA9644")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974804", Offset = "0x1974804")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class References
		{
			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978AF0", Offset = "0x1978AF0")]
			public Transform chest;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978B28", Offset = "0x1978B28")]
			public Transform neck;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978B60", Offset = "0x1978B60")]
			public Transform leftShoulder;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978B98", Offset = "0x1978B98")]
			public Transform rightShoulder;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978BD0", Offset = "0x1978BD0")]
			public Transform leftThigh;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978C08", Offset = "0x1978C08")]
			public Transform leftCalf;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978C40", Offset = "0x1978C40")]
			public Transform leftFoot;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978C78", Offset = "0x1978C78")]
			public Transform leftToes;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978CB0", Offset = "0x1978CB0")]
			public Transform rightThigh;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978CE8", Offset = "0x1978CE8")]
			public Transform rightCalf;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978D20", Offset = "0x1978D20")]
			public Transform rightFoot;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978D58", Offset = "0x1978D58")]
			public Transform rightToes;

			[Token(Token = "0x17000090")]
			public bool isFilled
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0x4BE76B4", Offset = "0x4BE76B4", VA = "0x4BE76B4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000091")]
			public bool isEmpty
			{
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x4BE7B30", Offset = "0x4BE7B30", VA = "0x4BE7B30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x4BE7268", Offset = "0x4BE7268", VA = "0x4BE7268")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x4BE7FAC", Offset = "0x4BE7FAC", VA = "0x4BE7FAC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x4BE82E4", Offset = "0x4BE82E4", VA = "0x4BE82E4")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x19760F4", Offset = "0x19760F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19760F4", Offset = "0x19760F4")]
		public References references;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976170", Offset = "0x1976170")]
		public IKSolverVR solver;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x3AAA880", Offset = "0x3AAA880", VA = "0x3AAA880", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EBCC", Offset = "0x197EBCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x3AAA8CC", Offset = "0x3AAA8CC", VA = "0x3AAA8CC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EC04", Offset = "0x197EC04")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x3AAA918", Offset = "0x3AAA918", VA = "0x3AAA918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EC3C", Offset = "0x197EC3C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x3AAA964", Offset = "0x3AAA964", VA = "0x3AAA964")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EC74", Offset = "0x197EC74")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x3AAA990", Offset = "0x3AAA990", VA = "0x3AAA990")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197ECAC", Offset = "0x197ECAC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x3AAA9B8", Offset = "0x3AAA9B8", VA = "0x3AAA9B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x3AAA9C0", Offset = "0x3AAA9C0", VA = "0x3AAA9C0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x3AAAA40", Offset = "0x3AAAA40", VA = "0x3AAAA40", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x3AAABB8", Offset = "0x3AAABB8", VA = "0x3AAABB8")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class FABRIKChain
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19761A8", Offset = "0x19761A8")]
		public float pull;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19761C0", Offset = "0x19761C0")]
		public float pin;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x368115C", Offset = "0x368115C", VA = "0x368115C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x3681224", Offset = "0x3681224", VA = "0x3681224")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x3681244", Offset = "0x3681244", VA = "0x3681244")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x3681614", Offset = "0x3681614", VA = "0x3681614")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x3681318", Offset = "0x3681318", VA = "0x3681318")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x368170C", Offset = "0x368170C", VA = "0x368170C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x3D6E430", Offset = "0x3D6E430", VA = "0x3D6E430")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x3D6E998", Offset = "0x3D6E998", VA = "0x3D6E998")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x3D6EB58", Offset = "0x3D6EB58", VA = "0x3D6EB58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x3D6EC50", Offset = "0x3D6EC50", VA = "0x3D6EC50")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A8")]
		public class BendBone
		{
			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978D90", Offset = "0x1978D90")]
			public Transform transform;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978DC8", Offset = "0x1978DC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1978DC8", Offset = "0x1978DC8")]
			public float weight;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x3D71C80", Offset = "0x3D71C80", VA = "0x3D71C80")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x3D71D00", Offset = "0x3D71D00", VA = "0x3D71D00")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x3D6F410", Offset = "0x3D6F410", VA = "0x3D6F410")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x3D6F814", Offset = "0x3D6F814", VA = "0x3D6F814")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19761D8", Offset = "0x19761D8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1976210", Offset = "0x1976210")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976210", Offset = "0x1976210")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976210", Offset = "0x1976210")]
		public float positionWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976288", Offset = "0x1976288")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976288", Offset = "0x1976288")]
		public float bodyWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19762DC", Offset = "0x19762DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19762DC", Offset = "0x19762DC")]
		public float thighWeight;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976330", Offset = "0x1976330")]
		public bool handsPullBody;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1976368", Offset = "0x1976368")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976368", Offset = "0x1976368")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976368", Offset = "0x1976368")]
		public float rotationWeight;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19763E0", Offset = "0x19763E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19763E0", Offset = "0x19763E0")]
		public float bodyClampWeight;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976434", Offset = "0x1976434")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976434", Offset = "0x1976434")]
		public float headClampWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976488", Offset = "0x1976488")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976488", Offset = "0x1976488")]
		public float bendWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19764DC", Offset = "0x19764DC")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1976514", Offset = "0x1976514")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976514", Offset = "0x1976514")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976514", Offset = "0x1976514")]
		public float CCDWeight;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197658C", Offset = "0x197658C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197658C", Offset = "0x197658C")]
		public float roll;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19765E0", Offset = "0x19765E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19765E0", Offset = "0x19765E0")]
		public float damper;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976638", Offset = "0x1976638")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1976670", Offset = "0x1976670")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976670", Offset = "0x1976670")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976670", Offset = "0x1976670")]
		public float postStretchWeight;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19766E8", Offset = "0x19766E8")]
		public float maxStretch;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976720", Offset = "0x1976720")]
		public float stretchDamper;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976758", Offset = "0x1976758")]
		public bool fixHead;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976790", Offset = "0x1976790")]
		public Transform[] stretchBones;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x19767C8", Offset = "0x19767C8")]
		public Vector3 chestDirection;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976800", Offset = "0x1976800")]
		public float chestDirectionWeight;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x3D6EC58", Offset = "0x3D6EC58", VA = "0x3D6EC58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x3D6EF88", Offset = "0x3D6EF88", VA = "0x3D6EF88")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x3D6F448", Offset = "0x3D6F448", VA = "0x3D6F448")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x3D6F83C", Offset = "0x3D6F83C", VA = "0x3D6F83C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x3D701B4", Offset = "0x3D701B4", VA = "0x3D701B4")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x3D70500", Offset = "0x3D70500", VA = "0x3D70500")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x3D7089C", Offset = "0x3D7089C", VA = "0x3D7089C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x3D71308", Offset = "0x3D71308", VA = "0x3D71308")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x3D6FEE0", Offset = "0x3D6FEE0", VA = "0x3D6FEE0")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x3D71518", Offset = "0x3D71518", VA = "0x3D71518")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3D711C4", Offset = "0x3D711C4", VA = "0x3D711C4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3D71028", Offset = "0x3D71028", VA = "0x3D71028")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3D71884", Offset = "0x3D71884", VA = "0x3D71884")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3D71B04", Offset = "0x3D71B04", VA = "0x3D71B04")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978E3C", Offset = "0x1978E3C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978E4C", Offset = "0x1978E4C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000092")]
			public float nominalDistance
			{
				[Token(Token = "0x60005D1")]
				[Address(RVA = "0x3D754F8", Offset = "0x3D754F8", VA = "0x3D754F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD88", Offset = "0x197FD88")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D2")]
				[Address(RVA = "0x3D75500", Offset = "0x3D75500", VA = "0x3D75500")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FD98", Offset = "0x197FD98")]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public bool isRigid
			{
				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x3D75508", Offset = "0x3D75508", VA = "0x3D75508")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FDA8", Offset = "0x197FDA8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x3D75510", Offset = "0x3D75510", VA = "0x3D75510")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FDB8", Offset = "0x197FDB8")]
				private set
				{
				}
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x3D7551C", Offset = "0x3D7551C", VA = "0x3D7551C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x3D729C0", Offset = "0x3D729C0", VA = "0x3D729C0")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x3D731BC", Offset = "0x3D731BC", VA = "0x3D731BC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x3D751F4", Offset = "0x3D751F4", VA = "0x3D751F4")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AA")]
		public enum Smoothing
		{
			[Token(Token = "0x4000461")]
			None,
			[Token(Token = "0x4000462")]
			Exponential,
			[Token(Token = "0x4000463")]
			Cubic
		}

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976818", Offset = "0x1976818")]
		public float pin;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976830", Offset = "0x1976830")]
		public float pull;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976848", Offset = "0x1976848")]
		public float push;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976860", Offset = "0x1976860")]
		public float pushParent;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976878", Offset = "0x1976878")]
		public float reach;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001BB")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x3D71DA4", Offset = "0x3D71DA4", VA = "0x3D71DA4")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x3D71EF0", Offset = "0x3D71EF0", VA = "0x3D71EF0")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x3D71FF8", Offset = "0x3D71FF8", VA = "0x3D71FF8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x3D7211C", Offset = "0x3D7211C", VA = "0x3D7211C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x3D721F8", Offset = "0x3D721F8", VA = "0x3D721F8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x3D722FC", Offset = "0x3D722FC", VA = "0x3D722FC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x3D72CD4", Offset = "0x3D72CD4", VA = "0x3D72CD4")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x3D72488", Offset = "0x3D72488", VA = "0x3D72488")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x3D733C0", Offset = "0x3D733C0", VA = "0x3D733C0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x3D73764", Offset = "0x3D73764", VA = "0x3D73764")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3D73B48", Offset = "0x3D73B48", VA = "0x3D73B48")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x3D746CC", Offset = "0x3D746CC", VA = "0x3D746CC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x3D74C9C", Offset = "0x3D74C9C", VA = "0x3D74C9C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x3D74F34", Offset = "0x3D74F34", VA = "0x3D74F34")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x3D74B94", Offset = "0x3D74B94", VA = "0x3D74B94")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x3D744B4", Offset = "0x3D744B4", VA = "0x3D744B4")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x3D74B1C", Offset = "0x3D74B1C", VA = "0x3D74B1C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x3D7501C", Offset = "0x3D7501C", VA = "0x3D7501C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x3D74A3C", Offset = "0x3D74A3C", VA = "0x3D74A3C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x3D74E1C", Offset = "0x3D74E1C", VA = "0x3D74E1C")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976890", Offset = "0x1976890")]
		public float weight;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19768A8", Offset = "0x19768A8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000029")]
		public bool initiated
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x3D84E9C", Offset = "0x3D84E9C", VA = "0x3D84E9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ECE4", Offset = "0x197ECE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x3D84EA4", Offset = "0x3D84EA4", VA = "0x3D84EA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ECF4", Offset = "0x197ECF4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x3D84CD4", Offset = "0x3D84CD4", VA = "0x3D84CD4")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x3D71E6C", Offset = "0x3D71E6C", VA = "0x3D71E6C")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x3D84EB0", Offset = "0x3D84EB0", VA = "0x3D84EB0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x3D72A18", Offset = "0x3D72A18", VA = "0x3D72A18")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x3D72A24", Offset = "0x3D72A24", VA = "0x3D72A24")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x3D8519C", Offset = "0x3D8519C", VA = "0x3D8519C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x3D853D4", Offset = "0x3D853D4", VA = "0x3D853D4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x3D73EB0", Offset = "0x3D73EB0", VA = "0x3D73EB0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x3D84F5C", Offset = "0x3D84F5C", VA = "0x3D84F5C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x3D8507C", Offset = "0x3D8507C", VA = "0x3D8507C")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class IKEffector
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19768B8", Offset = "0x19768B8")]
		public float positionWeight;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19768D0", Offset = "0x19768D0")]
		public float rotationWeight;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19768E8", Offset = "0x19768E8")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19768F8", Offset = "0x19768F8")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700002A")]
		public bool isEndEffector
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x42A71A0", Offset = "0x42A71A0", VA = "0x42A71A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED04", Offset = "0x197ED04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x42A71A8", Offset = "0x42A71A8", VA = "0x42A71A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED14", Offset = "0x197ED14")]
			private set
			{
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x42A7138", Offset = "0x42A7138", VA = "0x42A7138")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x42A71B4", Offset = "0x42A71B4", VA = "0x42A71B4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x42A7288", Offset = "0x42A7288", VA = "0x42A7288")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x42A73C4", Offset = "0x42A73C4", VA = "0x42A73C4")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x42A751C", Offset = "0x42A751C", VA = "0x42A751C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x42A780C", Offset = "0x42A780C", VA = "0x42A780C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x42A7B18", Offset = "0x42A7B18", VA = "0x42A7B18")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x42A7CAC", Offset = "0x42A7CAC", VA = "0x42A7CAC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x42A7D58", Offset = "0x42A7D58", VA = "0x42A7D58")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x42A8398", Offset = "0x42A8398", VA = "0x42A8398")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x42A8408", Offset = "0x42A8408", VA = "0x42A8408")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x42A8614", Offset = "0x42A8614", VA = "0x42A8614")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x42A8948", Offset = "0x42A8948", VA = "0x42A8948")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000AB")]
		public class BoneMap
		{
			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000094")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x42A9180", Offset = "0x42A9180", VA = "0x42A9180")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000095")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x42A92EC", Offset = "0x42A92EC", VA = "0x42A92EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000096")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x42A98C4", Offset = "0x42A98C4", VA = "0x42A98C4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x42A9158", Offset = "0x42A9158", VA = "0x42A9158")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x42A924C", Offset = "0x42A924C", VA = "0x42A924C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x42A929C", Offset = "0x42A929C", VA = "0x42A929C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x42A92FC", Offset = "0x42A92FC", VA = "0x42A92FC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x42A93E4", Offset = "0x42A93E4", VA = "0x42A93E4")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x42A93EC", Offset = "0x42A93EC", VA = "0x42A93EC")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x42A957C", Offset = "0x42A957C", VA = "0x42A957C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x42A9688", Offset = "0x42A9688", VA = "0x42A9688")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x42A9714", Offset = "0x42A9714", VA = "0x42A9714")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x42A9AE8", Offset = "0x42A9AE8", VA = "0x42A9AE8")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x42A9B20", Offset = "0x42A9B20", VA = "0x42A9B20")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x42A9B58", Offset = "0x42A9B58", VA = "0x42A9B58")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x42A9B80", Offset = "0x42A9B80", VA = "0x42A9B80")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x42A9CA8", Offset = "0x42A9CA8", VA = "0x42A9CA8")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x42A9FE0", Offset = "0x42A9FE0", VA = "0x42A9FE0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x42AA010", Offset = "0x42AA010", VA = "0x42AA010")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x42AA1A8", Offset = "0x42AA1A8", VA = "0x42AA1A8")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x42AA218", Offset = "0x42AA218", VA = "0x42AA218")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x42AA45C", Offset = "0x42AA45C", VA = "0x42AA45C")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x42AA684", Offset = "0x42AA684", VA = "0x42AA684")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x42AA79C", Offset = "0x42AA79C", VA = "0x42AA79C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x42A9DE8", Offset = "0x42A9DE8", VA = "0x42A9DE8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x42AA92C", Offset = "0x42AA92C", VA = "0x42AA92C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x42A8F18", Offset = "0x42A8F18", VA = "0x42A8F18", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x42A8F20", Offset = "0x42A8F20", VA = "0x42A8F20", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x42A8F24", Offset = "0x42A8F24", VA = "0x42A8F24")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x42A9048", Offset = "0x42A9048", VA = "0x42A9048")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x42A9150", Offset = "0x42A9150", VA = "0x42A9150")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976910", Offset = "0x1976910")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x42AA948", Offset = "0x42AA948", VA = "0x42AA948", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x42AA9E8", Offset = "0x42AA9E8", VA = "0x42AA9E8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x42AAA6C", Offset = "0x42AAA6C", VA = "0x42AAA6C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x42AAB04", Offset = "0x42AAB04", VA = "0x42AAB04")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x42AAB1C", Offset = "0x42AAB1C", VA = "0x42AAB1C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x42AAB38", Offset = "0x42AAB38", VA = "0x42AAB38", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x42AABD4", Offset = "0x42AABD4", VA = "0x42AABD4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x42AABEC", Offset = "0x42AABEC", VA = "0x42AABEC")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public enum BoneMapType
		{
			[Token(Token = "0x400047B")]
			Parent,
			[Token(Token = "0x400047C")]
			Bone1,
			[Token(Token = "0x400047D")]
			Bone2,
			[Token(Token = "0x400047E")]
			Bone3
		}

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976928", Offset = "0x1976928")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976940", Offset = "0x1976940")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x42AAC10", Offset = "0x42AAC10", VA = "0x42AAC10", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x42AAC94", Offset = "0x42AAC94", VA = "0x42AAC94")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x42AAD68", Offset = "0x42AAD68", VA = "0x42AAD68")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x42AB0BC", Offset = "0x42AB0BC", VA = "0x42AB0BC")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x42AB1C4", Offset = "0x42AB1C4", VA = "0x42AB1C4")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x42AB2F8", Offset = "0x42AB2F8", VA = "0x42AB2F8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x42AB304", Offset = "0x42AB304", VA = "0x42AB304")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x42AB3AC", Offset = "0x42AB3AC", VA = "0x42AB3AC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x42AB464", Offset = "0x42AB464", VA = "0x42AB464", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x42AB6D4", Offset = "0x42AB6D4", VA = "0x42AB6D4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x42AB78C", Offset = "0x42AB78C", VA = "0x42AB78C")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976958", Offset = "0x1976958")]
		public int iterations;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976970", Offset = "0x1976970")]
		public float twistWeight;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x42AB8F4", Offset = "0x42AB8F4", VA = "0x42AB8F4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x42ABBE4", Offset = "0x42ABBE4", VA = "0x42ABBE4")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x42ABD00", Offset = "0x42ABD00", VA = "0x42ABD00")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x42ABE58", Offset = "0x42ABE58", VA = "0x42ABE58")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x42ABE68", Offset = "0x42ABE68", VA = "0x42ABE68")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x42ABED0", Offset = "0x42ABED0", VA = "0x42ABED0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x42ABF50", Offset = "0x42ABF50", VA = "0x42ABF50", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x42AC5A4", Offset = "0x42AC5A4", VA = "0x42AC5A4")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x42AC5DC", Offset = "0x42AC5DC", VA = "0x42AC5DC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x42AC8BC", Offset = "0x42AC8BC", VA = "0x42AC8BC")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x42ACC68", Offset = "0x42ACC68", VA = "0x42ACC68")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x42ACD54", Offset = "0x42ACD54", VA = "0x42ACD54")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x42ACE1C", Offset = "0x42ACE1C", VA = "0x42ACE1C")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000AD")]
		public class Point
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1978E5C", Offset = "0x1978E5C")]
			public float weight;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x42AEA90", Offset = "0x42AEA90", VA = "0x42AEA90")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x42AEAE0", Offset = "0x42AEAE0", VA = "0x42AEAE0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x42AEC68", Offset = "0x42AEC68", VA = "0x42AEC68")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x42AECA0", Offset = "0x42AECA0", VA = "0x42AECA0")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x42AECD8", Offset = "0x42AECD8", VA = "0x42AECD8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x42AED28", Offset = "0x42AED28", VA = "0x42AED28")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x42AE564", Offset = "0x42AE564", VA = "0x42AE564")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AE")]
		public class Bone : Point
		{
			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000097")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x42ADB34", Offset = "0x42ADB34", VA = "0x42ADB34")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x42ADC28", Offset = "0x42ADC28", VA = "0x42ADC28")]
				set
				{
				}
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x42ADCB0", Offset = "0x42ADCB0", VA = "0x42ADCB0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x42ADF70", Offset = "0x42ADF70", VA = "0x42ADF70")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x42AE250", Offset = "0x42AE250", VA = "0x42AE250")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x42AE4B8", Offset = "0x42AE4B8", VA = "0x42AE4B8")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x42AE4E0", Offset = "0x42AE4E0", VA = "0x42AE4E0")]
			public Bone()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x42AE5E4", Offset = "0x42AE5E4", VA = "0x42AE5E4")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x42AE67C", Offset = "0x42AE67C", VA = "0x42AE67C")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		public class Node : Point
		{
			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x42AEA2C", Offset = "0x42AEA2C", VA = "0x42AEA2C")]
			public Node()
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x42AEA30", Offset = "0x42AEA30", VA = "0x42AEA30")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x42AEA58", Offset = "0x42AEA58", VA = "0x42AEA58")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000B0")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000B1")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19769A8", Offset = "0x19769A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19769A8", Offset = "0x19769A8")]
		public float IKPositionWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19769FC", Offset = "0x19769FC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700002B")]
		public bool initiated
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x42AD584", Offset = "0x42AD584", VA = "0x42AD584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED24", Offset = "0x197ED24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x42AD58C", Offset = "0x42AD58C", VA = "0x42AD58C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED34", Offset = "0x197ED34")]
			private set
			{
			}
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x42AD0FC", Offset = "0x42AD0FC", VA = "0x42AD0FC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x42AD178", Offset = "0x42AD178", VA = "0x42AD178")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x42A8EA8", Offset = "0x42A8EA8", VA = "0x42A8EA8")]
		public void Update()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x42AD4D8", Offset = "0x42AD4D8", VA = "0x42AD4D8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x42AD4E4", Offset = "0x42AD4E4", VA = "0x42AD4E4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x42AD4F0", Offset = "0x42AD4F0", VA = "0x42AD4F0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x42AD4F8", Offset = "0x42AD4F8", VA = "0x42AD4F8")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x42AD57C", Offset = "0x42AD57C", VA = "0x42AD57C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002BE")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002BF")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002C0")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002C1")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002C2")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x42AD598", Offset = "0x42AD598", VA = "0x42AD598")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x42AD5B0", Offset = "0x42AD5B0", VA = "0x42AD5B0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x42AD6EC", Offset = "0x42AD6EC", VA = "0x42AD6EC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x42AD798", Offset = "0x42AD798", VA = "0x42AD798")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x42ADB1C", Offset = "0x42ADB1C", VA = "0x42ADB1C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976A44", Offset = "0x1976A44")]
		public float poleWeight;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976A5C", Offset = "0x1976A5C")]
		public float clampWeight;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976A74", Offset = "0x1976A74")]
		public int clampSmoothing;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700002C")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x42AEEC0", Offset = "0x42AEEC0", VA = "0x42AEEC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x42AEF8C", Offset = "0x42AEF8C", VA = "0x42AEF8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		protected override int minBones
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x42AFCFC", Offset = "0x42AFCFC", VA = "0x42AFCFC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x42B02A0", Offset = "0x42B02A0", VA = "0x42B02A0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x42AEDC0", Offset = "0x42AEDC0", VA = "0x42AEDC0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x42AF058", Offset = "0x42AF058", VA = "0x42AF058", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x42AF2D8", Offset = "0x42AF2D8", VA = "0x42AF2D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x42AFC48", Offset = "0x42AFC48", VA = "0x42AFC48")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x42AF870", Offset = "0x42AF870", VA = "0x42AF870")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x42AFD04", Offset = "0x42AFD04", VA = "0x42AFD04")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x42B0314", Offset = "0x42B0314", VA = "0x42B0314")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976A8C", Offset = "0x1976A8C")]
		public float IKRotationWeight;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x42B0424", Offset = "0x42B0424", VA = "0x42B0424", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x42B0798", Offset = "0x42B0798", VA = "0x42B0798")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x42B0804", Offset = "0x42B0804", VA = "0x42B0804", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x42B0960", Offset = "0x42B0960", VA = "0x42B0960", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x42B0AF8", Offset = "0x42B0AF8", VA = "0x42B0AF8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x42B0B44", Offset = "0x42B0B44", VA = "0x42B0B44", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x42B0BA4", Offset = "0x42B0BA4", VA = "0x42B0BA4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x42B0F14", Offset = "0x42B0F14", VA = "0x42B0F14", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x42B0F40", Offset = "0x42B0F40", VA = "0x42B0F40")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x42B0C08", Offset = "0x42B0C08", VA = "0x42B0C08")]
		private void Read()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x42B0FB4", Offset = "0x42B0FB4", VA = "0x42B0FB4")]
		private void Write()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x42B1140", Offset = "0x42B1140", VA = "0x42B1140")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x42B1290", Offset = "0x42B1290", VA = "0x42B1290")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x42B1340", Offset = "0x42B1340", VA = "0x42B1340", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x42B1934", Offset = "0x42B1934", VA = "0x42B1934", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x42B2084", Offset = "0x42B2084", VA = "0x42B2084")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x42B27D8", Offset = "0x42B27D8", VA = "0x42B27D8")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000030")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x42B39F8", Offset = "0x42B39F8", VA = "0x42B39F8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x42B27DC", Offset = "0x42B27DC", VA = "0x42B27DC")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x42B2F24", Offset = "0x42B2F24", VA = "0x42B2F24")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x42B305C", Offset = "0x42B305C", VA = "0x42B305C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x42B30F4", Offset = "0x42B30F4", VA = "0x42B30F4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x42B3698", Offset = "0x42B3698", VA = "0x42B3698", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x42B3A00", Offset = "0x42B3A00", VA = "0x42B3A00")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x42B28B0", Offset = "0x42B28B0", VA = "0x42B28B0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x42B3008", Offset = "0x42B3008", VA = "0x42B3008")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x42B399C", Offset = "0x42B399C", VA = "0x42B399C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x42B2D4C", Offset = "0x42B2D4C", VA = "0x42B2D4C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x42B4240", Offset = "0x42B4240", VA = "0x42B4240")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x42B4350", Offset = "0x42B4350", VA = "0x42B4350")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x42B447C", Offset = "0x42B447C", VA = "0x42B447C")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x42B4594", Offset = "0x42B4594", VA = "0x42B4594")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x42B3400", Offset = "0x42B3400", VA = "0x42B3400")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x42B354C", Offset = "0x42B354C", VA = "0x42B354C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x42B4780", Offset = "0x42B4780", VA = "0x42B4780")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x42B3CB8", Offset = "0x42B3CB8", VA = "0x42B3CB8")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x42B2FF8", Offset = "0x42B2FF8", VA = "0x42B2FF8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x42B4EE8", Offset = "0x42B4EE8", VA = "0x42B4EE8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x42B4954", Offset = "0x42B4954", VA = "0x42B4954")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x42B3B18", Offset = "0x42B3B18", VA = "0x42B3B18")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x42B3BF4", Offset = "0x42B3BF4", VA = "0x42B3BF4")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x42B4FB4", Offset = "0x42B4FB4", VA = "0x42B4FB4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976AA4", Offset = "0x1976AA4")]
		public float rootPin;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x42B5028", Offset = "0x42B5028", VA = "0x42B5028", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x42B58F4", Offset = "0x42B58F4", VA = "0x42B58F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x42B598C", Offset = "0x42B598C", VA = "0x42B598C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x42B5A2C", Offset = "0x42B5A2C", VA = "0x42B5A2C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x42B5B2C", Offset = "0x42B5B2C", VA = "0x42B5B2C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x42B5BC8", Offset = "0x42B5BC8", VA = "0x42B5BC8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x42B6130", Offset = "0x42B6130", VA = "0x42B6130", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x42B6330", Offset = "0x42B6330", VA = "0x42B6330", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x42B61E0", Offset = "0x42B61E0", VA = "0x42B61E0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x42B5DFC", Offset = "0x42B5DFC", VA = "0x42B5DFC")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x42B63C8", Offset = "0x42B63C8", VA = "0x42B63C8")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976ABC", Offset = "0x1976ABC")]
		public int iterations;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x42B6440", Offset = "0x42B6440", VA = "0x42B6440")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x42B6534", Offset = "0x42B6534", VA = "0x42B6534")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x42B6590", Offset = "0x42B6590", VA = "0x42B6590")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x42A7C50", Offset = "0x42A7C50", VA = "0x42A7C50")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x42A7A98", Offset = "0x42A7A98", VA = "0x42A7A98")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x42B66C4", Offset = "0x42B66C4", VA = "0x42B66C4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x42B686C", Offset = "0x42B686C", VA = "0x42B686C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x42B69E0", Offset = "0x42B69E0", VA = "0x42B69E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x42B6BE0", Offset = "0x42B6BE0", VA = "0x42B6BE0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x42B6CB0", Offset = "0x42B6CB0", VA = "0x42B6CB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x42B6D8C", Offset = "0x42B6D8C", VA = "0x42B6D8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x42B6EFC", Offset = "0x42B6EFC", VA = "0x42B6EFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x42B70B4", Offset = "0x42B70B4", VA = "0x42B70B4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x42B72F4", Offset = "0x42B72F4", VA = "0x42B72F4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x42B75B4", Offset = "0x42B75B4", VA = "0x42B75B4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x42B75F8", Offset = "0x42B75F8", VA = "0x42B75F8", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x42B76DC", Offset = "0x42B76DC", VA = "0x42B76DC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000246")]
		Body,
		[Token(Token = "0x4000247")]
		LeftShoulder,
		[Token(Token = "0x4000248")]
		RightShoulder,
		[Token(Token = "0x4000249")]
		LeftThigh,
		[Token(Token = "0x400024A")]
		RightThigh,
		[Token(Token = "0x400024B")]
		LeftHand,
		[Token(Token = "0x400024C")]
		RightHand,
		[Token(Token = "0x400024D")]
		LeftFoot,
		[Token(Token = "0x400024E")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000250")]
		LeftArm,
		[Token(Token = "0x4000251")]
		RightArm,
		[Token(Token = "0x4000252")]
		LeftLeg,
		[Token(Token = "0x4000253")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976AD4", Offset = "0x1976AD4")]
		public float spineStiffness;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976AEC", Offset = "0x1976AEC")]
		public float pullBodyVertical;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976B04", Offset = "0x1976B04")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1976B1C", Offset = "0x1976B1C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000031")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x42B77BC", Offset = "0x42B77BC", VA = "0x42B77BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x42B7904", Offset = "0x42B7904", VA = "0x42B7904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x42B790C", Offset = "0x42B790C", VA = "0x42B790C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x42B7914", Offset = "0x42B7914", VA = "0x42B7914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x42B791C", Offset = "0x42B791C", VA = "0x42B791C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x42B7924", Offset = "0x42B7924", VA = "0x42B7924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x42B792C", Offset = "0x42B792C", VA = "0x42B792C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x42B7934", Offset = "0x42B7934", VA = "0x42B7934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x42B793C", Offset = "0x42B793C", VA = "0x42B793C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x42B7944", Offset = "0x42B7944", VA = "0x42B7944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x42B797C", Offset = "0x42B797C", VA = "0x42B797C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x42B79B4", Offset = "0x42B79B4", VA = "0x42B79B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x42B79EC", Offset = "0x42B79EC", VA = "0x42B79EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x42B7A24", Offset = "0x42B7A24", VA = "0x42B7A24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x42B7A58", Offset = "0x42B7A58", VA = "0x42B7A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x42B7A90", Offset = "0x42B7A90", VA = "0x42B7A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x42B7AC8", Offset = "0x42B7AC8", VA = "0x42B7AC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x42B7B00", Offset = "0x42B7B00", VA = "0x42B7B00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x42B9A58", Offset = "0x42B9A58", VA = "0x42B9A58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED44", Offset = "0x197ED44")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x42B9A64", Offset = "0x42B9A64", VA = "0x42B9A64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED54", Offset = "0x197ED54")]
			private set
			{
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x42B7B34", Offset = "0x42B7B34", VA = "0x42B7B34")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x42B7C40", Offset = "0x42B7C40", VA = "0x42B7C40")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x42B7B88", Offset = "0x42B7B88", VA = "0x42B7B88")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x42B7D1C", Offset = "0x42B7D1C", VA = "0x42B7D1C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x42B77C4", Offset = "0x42B77C4", VA = "0x42B77C4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x42B7DEC", Offset = "0x42B7DEC", VA = "0x42B7DEC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x42B7EA4", Offset = "0x42B7EA4", VA = "0x42B7EA4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x42B7F58", Offset = "0x42B7F58", VA = "0x42B7F58")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x42B800C", Offset = "0x42B800C", VA = "0x42B800C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x42B8014", Offset = "0x42B8014", VA = "0x42B8014")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x42B8048", Offset = "0x42B8048", VA = "0x42B8048")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x42B8110", Offset = "0x42B8110", VA = "0x42B8110", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x42B82A0", Offset = "0x42B82A0", VA = "0x42B82A0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x42B9374", Offset = "0x42B9374", VA = "0x42B9374")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x42B9808", Offset = "0x42B9808", VA = "0x42B9808")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x42B9868", Offset = "0x42B9868", VA = "0x42B9868")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x42B9688", Offset = "0x42B9688", VA = "0x42B9688")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x42B9748", Offset = "0x42B9748", VA = "0x42B9748")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x42B9A70", Offset = "0x42B9A70", VA = "0x42B9A70")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x42B9B4C", Offset = "0x42B9B4C", VA = "0x42B9B4C", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x42B9C90", Offset = "0x42B9C90", VA = "0x42B9C90")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x42B9E20", Offset = "0x42B9E20", VA = "0x42B9E20")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x42BA020", Offset = "0x42BA020", VA = "0x42BA020")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x42BA220", Offset = "0x42BA220", VA = "0x42BA220", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x42BA550", Offset = "0x42BA550", VA = "0x42BA550", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x42BA650", Offset = "0x42BA650", VA = "0x42BA650")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000044")]
		protected virtual int minBones
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x42BAE88", Offset = "0x42BAE88", VA = "0x42BAE88", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x42BAE90", Offset = "0x42BAE90", VA = "0x42BAE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x42BAE98", Offset = "0x42BAE98", VA = "0x42BAE98", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x42BAEA8", Offset = "0x42BAEA8", VA = "0x42BAEA8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000048")]
		protected float positionOffset
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x42B1FC0", Offset = "0x42B1FC0", VA = "0x42B1FC0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x42BA65C", Offset = "0x42BA65C", VA = "0x42BA65C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x42BA7E8", Offset = "0x42BA7E8", VA = "0x42BA7E8")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x42BA924", Offset = "0x42BA924", VA = "0x42BA924", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x42BA98C", Offset = "0x42BA98C", VA = "0x42BA98C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x42BAA08", Offset = "0x42BAA08", VA = "0x42BAA08", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x42BAD8C", Offset = "0x42BAD8C", VA = "0x42BAD8C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x42BAD94", Offset = "0x42BAD94", VA = "0x42BAD94", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x42BAEA0", Offset = "0x42BAEA0", VA = "0x42BAEA0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x42BAEA4", Offset = "0x42BAEA4", VA = "0x42BAEA4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x42B13C0", Offset = "0x42B13C0", VA = "0x42B13C0")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x42B1C28", Offset = "0x42B1C28", VA = "0x42B1C28")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x42BAFDC", Offset = "0x42BAFDC", VA = "0x42BAFDC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x42B03A8", Offset = "0x42B03A8", VA = "0x42B03A8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976B2C", Offset = "0x1976B2C")]
		public float IKRotationWeight;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x42BB290", Offset = "0x42BB290", VA = "0x42BB290", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x42BB604", Offset = "0x42BB604", VA = "0x42BB604")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x42BB670", Offset = "0x42BB670", VA = "0x42BB670", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x42BB7CC", Offset = "0x42BB7CC", VA = "0x42BB7CC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x42BB964", Offset = "0x42BB964", VA = "0x42BB964", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x42BB9B0", Offset = "0x42BB9B0", VA = "0x42BB9B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x42BBA10", Offset = "0x42BBA10", VA = "0x42BBA10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x42BBD80", Offset = "0x42BBD80", VA = "0x42BBD80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x42BBDAC", Offset = "0x42BBDAC", VA = "0x42BBDAC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x42BBA74", Offset = "0x42BBA74", VA = "0x42BBA74")]
		private void Read()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x42BBEBC", Offset = "0x42BBEBC", VA = "0x42BBEBC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x42BC048", Offset = "0x42BC048", VA = "0x42BC048")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public enum BendModifier
		{
			[Token(Token = "0x400048F")]
			Animation,
			[Token(Token = "0x4000490")]
			Target,
			[Token(Token = "0x4000491")]
			Parent,
			[Token(Token = "0x4000492")]
			Arm,
			[Token(Token = "0x4000493")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x42BD6F4", Offset = "0x42BD6F4", VA = "0x42BD6F4")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976B44", Offset = "0x1976B44")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976B5C", Offset = "0x1976B5C")]
		public float bendModifierWeight;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000049")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x42BD6D8", Offset = "0x42BD6D8", VA = "0x42BD6D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x42BC198", Offset = "0x42BC198", VA = "0x42BC198")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x42BC1E8", Offset = "0x42BC1E8", VA = "0x42BC1E8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x42BC234", Offset = "0x42BC234", VA = "0x42BC234", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x42BC8AC", Offset = "0x42BC8AC", VA = "0x42BC8AC", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x42BD48C", Offset = "0x42BD48C", VA = "0x42BD48C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x42BD5D4", Offset = "0x42BD5D4", VA = "0x42BD5D4")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x42BD64C", Offset = "0x42BD64C", VA = "0x42BD64C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x42BC5A8", Offset = "0x42BC5A8", VA = "0x42BC5A8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x42BC9D8", Offset = "0x42BC9D8", VA = "0x42BC9D8")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000098")]
			public Vector3 forward
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x42BF7A4", Offset = "0x42BF7A4", VA = "0x42BF7A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x42BFEF0", Offset = "0x42BFEF0", VA = "0x42BFEF0")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x42BE940", Offset = "0x42BE940", VA = "0x42BE940")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x42BEC7C", Offset = "0x42BEC7C", VA = "0x42BEC7C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x42BFBA8", Offset = "0x42BFBA8", VA = "0x42BFBA8")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976B74", Offset = "0x1976B74")]
		public float bodyWeight;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976B8C", Offset = "0x1976B8C")]
		public float headWeight;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976BA4", Offset = "0x1976BA4")]
		public float eyesWeight;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976BBC", Offset = "0x1976BBC")]
		public float clampWeight;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976BD4", Offset = "0x1976BD4")]
		public float clampWeightHead;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976BEC", Offset = "0x1976BEC")]
		public float clampWeightEyes;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976C04", Offset = "0x1976C04")]
		public int clampSmoothing;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x1700004A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x42BE0A4", Offset = "0x42BE0A4", VA = "0x42BE0A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x42BE27C", Offset = "0x42BE27C", VA = "0x42BE27C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x42BE188", Offset = "0x42BE188", VA = "0x42BE188")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x42BE2A0", Offset = "0x42BE2A0", VA = "0x42BE2A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x42BE198", Offset = "0x42BE198", VA = "0x42BE198")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x42BE31C", Offset = "0x42BE31C", VA = "0x42BE31C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x42BD754", Offset = "0x42BD754", VA = "0x42BD754")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x42BD7D8", Offset = "0x42BD7D8", VA = "0x42BD7D8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x42BD884", Offset = "0x42BD884", VA = "0x42BD884")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x42BD94C", Offset = "0x42BD94C", VA = "0x42BD94C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x42BDA38", Offset = "0x42BDA38", VA = "0x42BDA38")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x42BDB44", Offset = "0x42BDB44", VA = "0x42BDB44")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x42BDC8C", Offset = "0x42BDC8C", VA = "0x42BDC8C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x42BDDBC", Offset = "0x42BDDBC", VA = "0x42BDDBC")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x42BDDC8", Offset = "0x42BDDC8", VA = "0x42BDDC8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x42BDF10", Offset = "0x42BDF10", VA = "0x42BDF10", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x42BE340", Offset = "0x42BE340", VA = "0x42BE340", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x42BE578", Offset = "0x42BE578", VA = "0x42BE578", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x42BE718", Offset = "0x42BE718", VA = "0x42BE718")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x42BE96C", Offset = "0x42BE96C", VA = "0x42BE96C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x42BEDB8", Offset = "0x42BEDB8", VA = "0x42BEDB8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x42BEEBC", Offset = "0x42BEEBC", VA = "0x42BEEBC")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x42BF0E8", Offset = "0x42BF0E8", VA = "0x42BF0E8")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x42BF344", Offset = "0x42BF344", VA = "0x42BF344")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x42BF870", Offset = "0x42BF870", VA = "0x42BF870")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x42BE7C8", Offset = "0x42BE7C8", VA = "0x42BE7C8")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x42BFD10", Offset = "0x42BFD10", VA = "0x42BFD10")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x42C14C8", Offset = "0x42C14C8", VA = "0x42C14C8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x42C214C", Offset = "0x42C214C", VA = "0x42C214C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x42C1D74", Offset = "0x42C1D74", VA = "0x42C1D74")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x42C2324", Offset = "0x42C2324", VA = "0x42C2324")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976C1C", Offset = "0x1976C1C")]
		public float IKRotationWeight;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x42BFEF8", Offset = "0x42BFEF8", VA = "0x42BFEF8")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x42C00E8", Offset = "0x42C00E8", VA = "0x42C00E8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x42C029C", Offset = "0x42C029C", VA = "0x42C029C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x42C02A8", Offset = "0x42C02A8", VA = "0x42C02A8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x42C032C", Offset = "0x42C032C", VA = "0x42C032C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x42C0338", Offset = "0x42C0338", VA = "0x42C0338")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x42C0340", Offset = "0x42C0340", VA = "0x42C0340", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x42C0444", Offset = "0x42C0444", VA = "0x42C0444", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x42C0564", Offset = "0x42C0564", VA = "0x42C0564", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x42C05B0", Offset = "0x42C05B0", VA = "0x42C05B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x42C0610", Offset = "0x42C0610", VA = "0x42C0610", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x42C09EC", Offset = "0x42C09EC", VA = "0x42C09EC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x42C0A44", Offset = "0x42C0A44", VA = "0x42C0A44")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x42C0FEC", Offset = "0x42C0FEC", VA = "0x42C0FEC")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x42C1204", Offset = "0x42C1204", VA = "0x42C1204", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x42C13C0", Offset = "0x42C13C0", VA = "0x42C13C0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x42C133C", Offset = "0x42C133C", VA = "0x42C133C")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x42C1668", Offset = "0x42C1668", VA = "0x42C1668", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x42C2208", Offset = "0x42C2208", VA = "0x42C2208", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x42C220C", Offset = "0x42C220C", VA = "0x42C220C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x42C2210", Offset = "0x42C2210", VA = "0x42C2210", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x42C1E40", Offset = "0x42C1E40", VA = "0x42C1E40")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x42C2214", Offset = "0x42C2214", VA = "0x42C2214")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000EA")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000660")]
				YawPitch,
				[Token(Token = "0x4000661")]
				FromTo
			}

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x1978E74", Offset = "0x1978E74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978E74", Offset = "0x1978E74")]
			public Transform target;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978ED4", Offset = "0x1978ED4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1978ED4", Offset = "0x1978ED4")]
			public float positionWeight;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978F28", Offset = "0x1978F28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1978F28", Offset = "0x1978F28")]
			public float rotationWeight;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x1978F7C", Offset = "0x1978F7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978F7C", Offset = "0x1978F7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1978F7C", Offset = "0x1978F7C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978FF4", Offset = "0x1978FF4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x1978FF4", Offset = "0x1978FF4")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19790CC", Offset = "0x19790CC")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x19790CC", Offset = "0x19790CC")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19791AC", Offset = "0x19791AC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x19791AC", Offset = "0x19791AC")]
			public float shoulderYawOffset;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979284", Offset = "0x1979284")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x1979284", Offset = "0x1979284")]
			public float shoulderPitchOffset;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x197935C", Offset = "0x197935C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197935C", Offset = "0x197935C")]
			public Transform bendGoal;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19793BC", Offset = "0x19793BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19793BC", Offset = "0x19793BC")]
			public float bendGoalWeight;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979410", Offset = "0x1979410")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1979410", Offset = "0x1979410")]
			public float swivelOffset;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197946C", Offset = "0x197946C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19794A4", Offset = "0x19794A4")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x19794DC", Offset = "0x19794DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19794DC", Offset = "0x19794DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19794DC", Offset = "0x19794DC")]
			public float armLengthMlp;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979558", Offset = "0x1979558")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19795D0", Offset = "0x19795D0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19795E0", Offset = "0x19795E0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool hasShoulder;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion chestRotation;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 chestForward;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Vector3 chestUp;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x17000099")]
			public Vector3 position
			{
				[Token(Token = "0x6000618")]
				[Address(RVA = "0x42CB9AC", Offset = "0x42CB9AC", VA = "0x42CB9AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FDC8", Offset = "0x197FDC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x42CB9B8", Offset = "0x42CB9B8", VA = "0x42CB9B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FDD8", Offset = "0x197FDD8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public Quaternion rotation
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x42CB9C4", Offset = "0x42CB9C4", VA = "0x42CB9C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FDE8", Offset = "0x197FDE8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600061B")]
				[Address(RVA = "0x42CB9D0", Offset = "0x42CB9D0", VA = "0x42CB9D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FDF8", Offset = "0x197FDF8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x42CB9DC", Offset = "0x42CB9DC", VA = "0x42CB9DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x42CBA10", Offset = "0x42CBA10", VA = "0x42CBA10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009D")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x42CBA50", Offset = "0x42CBA50", VA = "0x42CBA50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private VirtualBone hand
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x42CBA9C", Offset = "0x42CBA9C", VA = "0x42CBA9C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x42CBAE8", Offset = "0x42CBAE8", VA = "0x42CBAE8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x42CC46C", Offset = "0x42CC46C", VA = "0x42CC46C", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x42CC660", Offset = "0x42CC660", VA = "0x42CC660", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x42CC70C", Offset = "0x42CC70C", VA = "0x42CC70C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x42C972C", Offset = "0x42C972C", VA = "0x42C972C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x42CD358", Offset = "0x42CD358", VA = "0x42CD358", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x42CD3C8", Offset = "0x42CD3C8", VA = "0x42CD3C8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x42CCB24", Offset = "0x42CCB24", VA = "0x42CCB24")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x42CCBFC", Offset = "0x42CCBFC", VA = "0x42CCBFC")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x42CD5E8", Offset = "0x42CD5E8", VA = "0x42CD5E8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x42CB614", Offset = "0x42CB614", VA = "0x42CB614")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19795F0", Offset = "0x19795F0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1979600", Offset = "0x1979600")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x1700009F")]
			public float sqrMag
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x42CD7A8", Offset = "0x42CD7A8", VA = "0x42CD7A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE08", Offset = "0x197FE08")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x42CD7B0", Offset = "0x42CD7B0", VA = "0x42CD7B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE18", Offset = "0x197FE18")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public float mag
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x42CD7B8", Offset = "0x42CD7B8", VA = "0x42CD7B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE28", Offset = "0x197FE28")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x42CD7C0", Offset = "0x42CD7C0", VA = "0x42CD7C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE38", Offset = "0x197FE38")]
				private set
				{
				}
			}

			[Token(Token = "0x600062B")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600062C")]
			public abstract void PreSolve(float scale);

			[Token(Token = "0x600062D")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600062E")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x600062F")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x42CD7C8", Offset = "0x42CD7C8", VA = "0x42CD7C8")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x42C6244", Offset = "0x42C6244", VA = "0x42C6244")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x42CD7D0", Offset = "0x42CD7D0", VA = "0x42CD7D0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x42CD93C", Offset = "0x42CD93C", VA = "0x42CD93C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x42CD9E8", Offset = "0x42CD9E8", VA = "0x42CD9E8")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x42C92B0", Offset = "0x42C92B0", VA = "0x42C92B0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x42CD1B4", Offset = "0x42CD1B4", VA = "0x42CD1B4")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x42CDA3C", Offset = "0x42CDA3C", VA = "0x42CDA3C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x42CDB80", Offset = "0x42CDB80", VA = "0x42CDB80")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x42CD710", Offset = "0x42CD710", VA = "0x42CD710")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B8")]
		public class Footstep
		{
			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1979620", Offset = "0x1979620")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000A1")]
			public bool isStepping
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x42CDBA8", Offset = "0x42CDBA8", VA = "0x42CDBA8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A2")]
			public float stepProgress
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x42CDBBC", Offset = "0x42CDBBC", VA = "0x42CDBBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE48", Offset = "0x197FE48")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x42CDBC4", Offset = "0x42CDBC4", VA = "0x42CDBC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE58", Offset = "0x197FE58")]
				private set
				{
				}
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x42CDBCC", Offset = "0x42CDBCC", VA = "0x42CDBCC")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x42CDD5C", Offset = "0x42CDD5C", VA = "0x42CDD5C")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x42CDDA4", Offset = "0x42CDDA4", VA = "0x42CDDA4")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x42CDF74", Offset = "0x42CDF74", VA = "0x42CDF74")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x42CE128", Offset = "0x42CE128", VA = "0x42CE128")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x42CE30C", Offset = "0x42CE30C", VA = "0x42CE30C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep, float deltaTime)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B9")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x1979630", Offset = "0x1979630")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979630", Offset = "0x1979630")]
			public Transform target;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979690", Offset = "0x1979690")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1979690", Offset = "0x1979690")]
			public float positionWeight;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19796E4", Offset = "0x19796E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19796E4", Offset = "0x19796E4")]
			public float rotationWeight;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x1979738", Offset = "0x1979738")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979738", Offset = "0x1979738")]
			public Transform bendGoal;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979798", Offset = "0x1979798")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1979798", Offset = "0x1979798")]
			public float bendGoalWeight;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19797EC", Offset = "0x19797EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19797EC", Offset = "0x19797EC")]
			public float swivelOffset;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979848", Offset = "0x1979848")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1979848", Offset = "0x1979848")]
			public float bendToTargetWeight;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x197989C", Offset = "0x197989C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197989C", Offset = "0x197989C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197989C", Offset = "0x197989C")]
			public float legLengthMlp;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979918", Offset = "0x1979918")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19799C0", Offset = "0x19799C0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19799D0", Offset = "0x19799D0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19799E0", Offset = "0x19799E0")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19799F0", Offset = "0x19799F0")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1979A00", Offset = "0x1979A00")]
			private Vector3 <bendNormalRelToPelvis>k__BackingField;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1979A10", Offset = "0x1979A10")]
			private Vector3 <bendNormalRelToTarget>k__BackingField;

			[Token(Token = "0x170000A3")]
			public Vector3 position
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x42CE520", Offset = "0x42CE520", VA = "0x42CE520")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE68", Offset = "0x197FE68")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x42CE52C", Offset = "0x42CE52C", VA = "0x42CE52C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE78", Offset = "0x197FE78")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x42CE538", Offset = "0x42CE538", VA = "0x42CE538")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE88", Offset = "0x197FE88")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x42CE544", Offset = "0x42CE544", VA = "0x42CE544")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FE98", Offset = "0x197FE98")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			public bool hasToes
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x42CE550", Offset = "0x42CE550", VA = "0x42CE550")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FEA8", Offset = "0x197FEA8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x42CE558", Offset = "0x42CE558", VA = "0x42CE558")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FEB8", Offset = "0x197FEB8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600064D")]
				[Address(RVA = "0x42CE564", Offset = "0x42CE564", VA = "0x42CE564")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private VirtualBone calf
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0x42CE598", Offset = "0x42CE598", VA = "0x42CE598")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private VirtualBone foot
			{
				[Token(Token = "0x600064F")]
				[Address(RVA = "0x42CE5D0", Offset = "0x42CE5D0", VA = "0x42CE5D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000650")]
				[Address(RVA = "0x42CE608", Offset = "0x42CE608", VA = "0x42CE608")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x42C80B8", Offset = "0x42C80B8", VA = "0x42C80B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x42CE640", Offset = "0x42CE640", VA = "0x42CE640")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FEC8", Offset = "0x197FEC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x42CE64C", Offset = "0x42CE64C", VA = "0x42CE64C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FED8", Offset = "0x197FED8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AC")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x42CE658", Offset = "0x42CE658", VA = "0x42CE658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FEE8", Offset = "0x197FEE8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x42CE668", Offset = "0x42CE668", VA = "0x42CE668")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FEF8", Offset = "0x197FEF8")]
				set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x42CE678", Offset = "0x42CE678", VA = "0x42CE678")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FF08", Offset = "0x197FF08")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x42CE688", Offset = "0x42CE688", VA = "0x42CE688")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FF18", Offset = "0x197FF18")]
				set
				{
				}
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x42CE698", Offset = "0x42CE698", VA = "0x42CE698", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x42CECDC", Offset = "0x42CECDC", VA = "0x42CECDC", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x42CF5DC", Offset = "0x42CF5DC", VA = "0x42CF5DC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x42CF4D8", Offset = "0x42CF4D8", VA = "0x42CF4D8")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x42CF2A0", Offset = "0x42CF2A0", VA = "0x42CF2A0")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x42C94A0", Offset = "0x42C94A0", VA = "0x42C94A0")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x42D0094", Offset = "0x42D0094", VA = "0x42D0094")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x42CFB94", Offset = "0x42CFB94", VA = "0x42CFB94")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x42D04FC", Offset = "0x42D04FC", VA = "0x42D04FC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x42D0718", Offset = "0x42D0718", VA = "0x42D0718", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x42CB750", Offset = "0x42CB750", VA = "0x42CB750")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		public class Locomotion
		{
			[Serializable]
			[Token(Token = "0x20000EB")]
			public enum Mode
			{
				[Token(Token = "0x4000663")]
				Procedural,
				[Token(Token = "0x4000664")]
				Animated
			}

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979A20", Offset = "0x1979A20")]
			public Mode mode;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979A58", Offset = "0x1979A58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1979A58", Offset = "0x1979A58")]
			public float weight;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979AAC", Offset = "0x1979AAC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x1979AAC", Offset = "0x1979AAC")]
			public float moveThreshold;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x1979B70", Offset = "0x1979B70")]
			[SerializeField]
			private byte animationHeader;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979C3C", Offset = "0x1979C3C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x1979C3C", Offset = "0x1979C3C")]
			public float minAnimationSpeed;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979D0C", Offset = "0x1979D0C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x1979D0C", Offset = "0x1979D0C")]
			public float maxAnimationSpeed;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979DD8", Offset = "0x1979DD8")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x1979DD8", Offset = "0x1979DD8")]
			public float animationSmoothTime;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x1979EAC", Offset = "0x1979EAC")]
			[SerializeField]
			private byte rootPositionHeader;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1979F78", Offset = "0x1979F78")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x1979F78", Offset = "0x1979F78")]
			public Vector2 standOffset;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A03C", Offset = "0x197A03C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x197A03C", Offset = "0x197A03C")]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A10C", Offset = "0x197A10C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x197A10C", Offset = "0x197A10C")]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A1DC", Offset = "0x197A1DC")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x197A1DC", Offset = "0x197A1DC")]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A2AC", Offset = "0x197A2AC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197A2AC", Offset = "0x197A2AC")]
			public float maxRootOffset;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x197A370", Offset = "0x197A370")]
			[SerializeField]
			private byte rootRotationHeader;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A43C", Offset = "0x197A43C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x197A43C", Offset = "0x197A43C")]
			public float maxRootAngleMoving;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A50C", Offset = "0x197A50C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x197A50C", Offset = "0x197A50C")]
			public float maxRootAngleStanding;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[SerializeField]
			public float stepLengthMlp;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Animator animator;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 velocityLocal;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private Vector3 velocityLocalV;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastCorrection;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 lastHeadTargetPos;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Vector3 lastSpeedRootPos;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Vector3 lastEndRootPos;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float rootLerpSpeed;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float rootVelocityV;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private float animSpeed;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private float animSpeedV;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float stopMoveTimer;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float turn;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private float maxRootAngleV;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private float currentAnimationSmoothTime;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool isMoving;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool firstFrame;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int StrafeSpeed;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static int WalkSpeed;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int VRIK_IsMoving;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static int IKMultiplier;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static int TurnSpeed;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private static bool isHashed;

			[Token(Token = "0x4000511")]
			public const bool ChangedEngage = true;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float lastVelLocalMag;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x197A5EC", Offset = "0x197A5EC")]
			[SerializeField]
			private bool useCustomLocomotion;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x197A638", Offset = "0x197A638")]
			[SerializeField]
			private float refAnimVelocity;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197A670", Offset = "0x197A670")]
			[SerializeField]
			private float animVelocityScale;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197A6B0", Offset = "0x197A6B0")]
			[SerializeField]
			private float animSpeedSmoothTime;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x197A6F4", Offset = "0x197A6F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197A6F4", Offset = "0x197A6F4")]
			[SerializeField]
			private float turnSmoothTime;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197A744", Offset = "0x197A744")]
			[SerializeField]
			private float turnThreshold;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197A788", Offset = "0x197A788")]
			[SerializeField]
			private float comfortTurnTime;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197A7C8", Offset = "0x197A7C8")]
			[SerializeField]
			private float comfortTurnThreshold;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x197A80C", Offset = "0x197A80C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197A80C", Offset = "0x197A80C")]
			[SerializeField]
			private float standingStayTime;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private bool isTurning;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private float turnTarget;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private float turnDampV;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private Vector3 comfortForward;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 confortForwardDampV;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private float uncomfortTimer;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Vector3 standingPos;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Vector3 standingPosDampV;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A85C", Offset = "0x197A85C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197A85C", Offset = "0x197A85C")]
			public float footDistance;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A91C", Offset = "0x197A91C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197A91C", Offset = "0x197A91C")]
			public float stepThreshold;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197A9DC", Offset = "0x197A9DC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197A9DC", Offset = "0x197A9DC")]
			public float angleThreshold;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197AA9C", Offset = "0x197AA9C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197AA9C", Offset = "0x197AA9C")]
			public float comAngleMlp;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197AB5C", Offset = "0x197AB5C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197AB5C", Offset = "0x197AB5C")]
			public float maxVelocity;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197AC1C", Offset = "0x197AC1C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197AC1C", Offset = "0x197AC1C")]
			public float velocityFactor;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197ACDC", Offset = "0x197ACDC")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x197ACDC", Offset = "0x197ACDC")]
			public float maxLegStretch;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197ADA8", Offset = "0x197ADA8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197ADA8", Offset = "0x197ADA8")]
			public float rootSpeed;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197AE68", Offset = "0x197AE68")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197AE68", Offset = "0x197AE68")]
			public float stepSpeed;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197AF28", Offset = "0x197AF28")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197AF28", Offset = "0x197AF28")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197AFE8", Offset = "0x197AFE8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197AFE8", Offset = "0x197AFE8")]
			public float maxBodyYOffset;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B0A8", Offset = "0x197B0A8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197B0A8", Offset = "0x197B0A8")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B168", Offset = "0x197B168")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x197B168", Offset = "0x197B168")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B234", Offset = "0x197B234")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197B234", Offset = "0x197B234")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B2F4", Offset = "0x197B2F4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197B2F4", Offset = "0x197B2F4")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B3B4", Offset = "0x197B3B4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197B3B4", Offset = "0x197B3B4")]
			public Vector3 offset;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197B524", Offset = "0x197B524")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Footstep[] footsteps;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 comVelocity;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int leftFootIndex;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int rightFootIndex;

			[Token(Token = "0x170000AE")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600066F")]
				[Address(RVA = "0x42D2758", Offset = "0x42D2758", VA = "0x42D2758")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FF28", Offset = "0x197FF28")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000670")]
				[Address(RVA = "0x42D2768", Offset = "0x42D2768", VA = "0x42D2768")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FF38", Offset = "0x197FF38")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000677")]
				[Address(RVA = "0x42D2BB0", Offset = "0x42D2BB0", VA = "0x42D2BB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B0")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0x42D2BF0", Offset = "0x42D2BF0", VA = "0x42D2BF0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B1")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000679")]
				[Address(RVA = "0x42D2C34", Offset = "0x42D2C34", VA = "0x42D2C34")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000B2")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0x42D2C74", Offset = "0x42D2C74", VA = "0x42D2C74")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x42C6318", Offset = "0x42C6318", VA = "0x42C6318")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x42C3BA8", Offset = "0x42C3BA8", VA = "0x42C3BA8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x42D0E20", Offset = "0x42D0E20", VA = "0x42D0E20")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x42C32D8", Offset = "0x42C32D8", VA = "0x42C32D8")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x42C328C", Offset = "0x42C328C", VA = "0x42C328C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x42D0AD0", Offset = "0x42D0AD0", VA = "0x42D0AD0")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x42D175C", Offset = "0x42D175C", VA = "0x42D175C")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x42C80F8", Offset = "0x42C80F8", VA = "0x42C80F8")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x42D1268", Offset = "0x42D1268", VA = "0x42D1268")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x42D1648", Offset = "0x42D1648", VA = "0x42D1648")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x42C8300", Offset = "0x42C8300", VA = "0x42C8300")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x42D183C", Offset = "0x42D183C", VA = "0x42D183C")]
			private void SolveCustomLocomotion(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x42D07C8", Offset = "0x42D07C8", VA = "0x42D07C8")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x42D0BA0", Offset = "0x42D0BA0", VA = "0x42D0BA0")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x42D0E24", Offset = "0x42D0E24", VA = "0x42D0E24")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x42D0E88", Offset = "0x42D0E88", VA = "0x42D0E88")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x42D1490", Offset = "0x42D1490", VA = "0x42D1490")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x42C6AE0", Offset = "0x42C6AE0", VA = "0x42C6AE0")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x42D27B8", Offset = "0x42D27B8", VA = "0x42D27B8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x42D2960", Offset = "0x42D2960", VA = "0x42D2960")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x42D29E4", Offset = "0x42D29E4", VA = "0x42D29E4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x42CB844", Offset = "0x42CB844", VA = "0x42CB844")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x197B534", Offset = "0x197B534")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B534", Offset = "0x197B534")]
			public Transform headTarget;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B594", Offset = "0x197B594")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197B594", Offset = "0x197B594")]
			public float positionWeight;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B5E8", Offset = "0x197B5E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197B5E8", Offset = "0x197B5E8")]
			public float rotationWeight;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B63C", Offset = "0x197B63C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197B63C", Offset = "0x197B63C")]
			public float headClampWeight;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B690", Offset = "0x197B690")]
			public float minHeadHeight;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B6C8", Offset = "0x197B6C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197B6C8", Offset = "0x197B6C8")]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B71C", Offset = "0x197B71C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197B71C", Offset = "0x197B71C")]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B7F4", Offset = "0x197B7F4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x197B7F4", Offset = "0x197B7F4")]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x197B8CC", Offset = "0x197B8CC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B8CC", Offset = "0x197B8CC")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B92C", Offset = "0x197B92C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197B92C", Offset = "0x197B92C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B980", Offset = "0x197B980")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197B980", Offset = "0x197B980")]
			public float pelvisRotationWeight;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197B9D4", Offset = "0x197B9D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197B9D4", Offset = "0x197B9D4")]
			public float maintainPelvisPosition;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x197BA28", Offset = "0x197BA28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BA28", Offset = "0x197BA28")]
			public Transform chestGoal;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BA88", Offset = "0x197BA88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197BA88", Offset = "0x197BA88")]
			public float chestGoalWeight;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BADC", Offset = "0x197BADC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197BADC", Offset = "0x197BADC")]
			public float chestClampWeight;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BB30", Offset = "0x197BB30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197BB30", Offset = "0x197BB30")]
			public float rotateChestByHands;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x197BB84", Offset = "0x197BB84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BB84", Offset = "0x197BB84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197BB84", Offset = "0x197BB84")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BBFC", Offset = "0x197BBFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197BBFC", Offset = "0x197BBFC")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BC50", Offset = "0x197BC50")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x197BC50", Offset = "0x197BC50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197BC50", Offset = "0x197BC50")]
			public float neckStiffness;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BCC8", Offset = "0x197BCC8")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x197BD00", Offset = "0x197BD00")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BD00", Offset = "0x197BD00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197BD00", Offset = "0x197BD00")]
			public float maxRootAngle;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BD7C", Offset = "0x197BD7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197BD7C", Offset = "0x197BD7C")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[HideInInspector]
			internal Vector3 headPosition;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197BEA8", Offset = "0x197BEA8")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197BEB8", Offset = "0x197BEB8")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			private Quaternion headRotation;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int pelvisIndex;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int spineIndex;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int chestIndex;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private int neckIndex;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private int headIndex;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float length;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private bool hasChest;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
			private bool hasNeck;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21A")]
			private bool hasLegs;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private float headHeight;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private float sizeMlp;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
			private Vector3 chestForward;

			[Token(Token = "0x170000B3")]
			internal VirtualBone pelvis
			{
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x42C3BD4", Offset = "0x42C3BD4", VA = "0x42C3BD4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000680")]
				[Address(RVA = "0x42D2CB8", Offset = "0x42D2CB8", VA = "0x42D2CB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			internal VirtualBone chest
			{
				[Token(Token = "0x6000681")]
				[Address(RVA = "0x42C96D8", Offset = "0x42C96D8", VA = "0x42C96D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			internal VirtualBone head
			{
				[Token(Token = "0x6000682")]
				[Address(RVA = "0x42D2778", Offset = "0x42D2778", VA = "0x42D2778")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x42D2CF8", Offset = "0x42D2CF8", VA = "0x42D2CF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x42D2D38", Offset = "0x42D2D38", VA = "0x42D2D38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FF48", Offset = "0x197FF48")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x42D2D4C", Offset = "0x42D2D4C", VA = "0x42D2D4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FF58", Offset = "0x197FF58")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B9")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x42D2D60", Offset = "0x42D2D60", VA = "0x42D2D60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FF68", Offset = "0x197FF68")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x42D2D74", Offset = "0x42D2D74", VA = "0x42D2D74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FF78", Offset = "0x197FF78")]
				private set
				{
				}
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x42D2D88", Offset = "0x42D2D88", VA = "0x42D2D88", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x42D3808", Offset = "0x42D3808", VA = "0x42D3808", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x42D3CD0", Offset = "0x42D3CD0", VA = "0x42D3CD0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x42D435C", Offset = "0x42D435C", VA = "0x42D435C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x42C6364", Offset = "0x42C6364", VA = "0x42C6364")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x42D4DC0", Offset = "0x42D4DC0", VA = "0x42D4DC0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x42D5490", Offset = "0x42D5490", VA = "0x42D5490")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x42D57A4", Offset = "0x42D57A4", VA = "0x42D57A4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x42D5980", Offset = "0x42D5980", VA = "0x42D5980", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x42D45D0", Offset = "0x42D45D0", VA = "0x42D45D0")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x42C9144", Offset = "0x42C9144", VA = "0x42C9144")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x42D4960", Offset = "0x42D4960", VA = "0x42D4960")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x42D5A80", Offset = "0x42D5A80", VA = "0x42D5A80")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x42D5240", Offset = "0x42D5240", VA = "0x42D5240")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x42D4F88", Offset = "0x42D4F88", VA = "0x42D4F88")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x42CB448", Offset = "0x42CB448", VA = "0x42CB448")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public enum PositionOffset
		{
			[Token(Token = "0x400057A")]
			Pelvis,
			[Token(Token = "0x400057B")]
			Chest,
			[Token(Token = "0x400057C")]
			Head,
			[Token(Token = "0x400057D")]
			LeftHand,
			[Token(Token = "0x400057E")]
			RightHand,
			[Token(Token = "0x400057F")]
			LeftFoot,
			[Token(Token = "0x4000580")]
			RightFoot,
			[Token(Token = "0x4000581")]
			LeftHeel,
			[Token(Token = "0x4000582")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000584")]
			Pelvis,
			[Token(Token = "0x4000585")]
			Chest,
			[Token(Token = "0x4000586")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public class VirtualBone
		{
			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x3A93DD0", Offset = "0x3A93DD0", VA = "0x3A93DD0")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x3A93E4C", Offset = "0x3A93E4C", VA = "0x3A93E4C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x3A93E6C", Offset = "0x3A93E6C", VA = "0x3A93E6C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x3A940FC", Offset = "0x3A940FC", VA = "0x3A940FC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x3A943E8", Offset = "0x3A943E8", VA = "0x3A943E8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x3A945D0", Offset = "0x3A945D0", VA = "0x3A945D0")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x3A94808", Offset = "0x3A94808", VA = "0x3A94808")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x3A94A3C", Offset = "0x3A94A3C", VA = "0x3A94A3C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x3A94AF4", Offset = "0x3A94AF4", VA = "0x3A94AF4")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x3A950A0", Offset = "0x3A950A0", VA = "0x3A950A0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x3A952B8", Offset = "0x3A952B8", VA = "0x3A952B8")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x3A95718", Offset = "0x3A95718", VA = "0x3A95718")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x3A95820", Offset = "0x3A95820", VA = "0x3A95820")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1976C34", Offset = "0x1976C34")]
		private Animator <animator>k__BackingField;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool hasChest;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool hasNeck;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool hasShoulders;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool hasToes;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool hasLegs;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool hasArms;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] readPositions;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002A5")]
		public const bool ChangedEngage = true;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastLOD;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float lastLocomotionWeight;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976C44", Offset = "0x1976C44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976C44", Offset = "0x1976C44")]
		public int LOD;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976C98", Offset = "0x1976C98")]
		public float scale;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976CD0", Offset = "0x1976CD0")]
		public bool plantFeet;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1976D08", Offset = "0x1976D08")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976D18", Offset = "0x1976D18")]
		public Spine spine;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976D50", Offset = "0x1976D50")]
		public Arm leftArm;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976D88", Offset = "0x1976D88")]
		public Arm rightArm;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976DC0", Offset = "0x1976DC0")]
		public Leg leftLeg;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976DF8", Offset = "0x1976DF8")]
		public Leg rightLeg;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976E30", Offset = "0x1976E30")]
		public Locomotion locomotion;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Leg[] legs;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Arm[] arms;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 headPosition;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000050")]
		public Animator animator
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x42C232C", Offset = "0x42C232C", VA = "0x42C232C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED64", Offset = "0x197ED64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x42C2334", Offset = "0x42C2334", VA = "0x42C2334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED74", Offset = "0x197ED74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x42CB288", Offset = "0x42CB288", VA = "0x42CB288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED84", Offset = "0x197ED84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x42CB290", Offset = "0x42CB290", VA = "0x42CB290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197ED94", Offset = "0x197ED94")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x42C233C", Offset = "0x42C233C", VA = "0x42C233C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x42C27C0", Offset = "0x42C27C0", VA = "0x42C27C0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x42C2668", Offset = "0x42C2668", VA = "0x42C2668")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x42C2B94", Offset = "0x42C2B94", VA = "0x42C2B94")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x42C2E80", Offset = "0x42C2E80", VA = "0x42C2E80")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x42C2F24", Offset = "0x42C2F24", VA = "0x42C2F24")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x42C30B8", Offset = "0x42C30B8", VA = "0x42C30B8")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x42C3354", Offset = "0x42C3354", VA = "0x42C3354")]
		public void Reset(bool resetLegChain = true)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x42C3C14", Offset = "0x42C3C14", VA = "0x42C3C14", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x42C3D88", Offset = "0x42C3D88", VA = "0x42C3D88", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x42C3F90", Offset = "0x42C3F90", VA = "0x42C3F90", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x42C4004", Offset = "0x42C4004", VA = "0x42C4004", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x42C4078", Offset = "0x42C4078", VA = "0x42C4078", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x42C428C", Offset = "0x42C428C", VA = "0x42C428C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x42C2A70", Offset = "0x42C2A70", VA = "0x42C2A70")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x42C34E8", Offset = "0x42C34E8", VA = "0x42C34E8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x42C456C", Offset = "0x42C456C", VA = "0x42C456C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x42C45BC", Offset = "0x42C45BC", VA = "0x42C45BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x42C5DCC", Offset = "0x42C5DCC", VA = "0x42C5DCC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x42C3650", Offset = "0x42C3650", VA = "0x42C3650")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x42C4AA0", Offset = "0x42C4AA0", VA = "0x42C4AA0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x42C61B8", Offset = "0x42C61B8", VA = "0x42C61B8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x42C6200", Offset = "0x42C6200", VA = "0x42C6200")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x42C5C74", Offset = "0x42C5C74", VA = "0x42C5C74")]
		private void Write()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x42CACBC", Offset = "0x42CACBC", VA = "0x42CACBC")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x42CB298", Offset = "0x42CB298", VA = "0x42CB298")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976E68", Offset = "0x1976E68")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x3AA96AC", Offset = "0x3AA96AC", VA = "0x3AA96AC")]
		public void Start()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x3AA9E4C", Offset = "0x3AA9E4C", VA = "0x3AA9E4C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x3AA9FE4", Offset = "0x3AA9FE4", VA = "0x3AA9FE4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x3AAA568", Offset = "0x3AAA568", VA = "0x3AAA568")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x3AAA630", Offset = "0x3AAA630", VA = "0x3AAA630")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x3AAA734", Offset = "0x3AAA734", VA = "0x3AAA734")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class TwistSolver
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976EA0", Offset = "0x1976EA0")]
		public Transform transform;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976ED8", Offset = "0x1976ED8")]
		public Transform parent;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976F10", Offset = "0x1976F10")]
		public Transform[] children;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976F48", Offset = "0x1976F48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976F48", Offset = "0x1976F48")]
		public float weight;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976F9C", Offset = "0x1976F9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976F9C", Offset = "0x1976F9C")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1976FF0", Offset = "0x1976FF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1976FF0", Offset = "0x1976FF0")]
		public float twistAngleOffset;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultChildLocalRotations;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x3AAA794", Offset = "0x3AAA794", VA = "0x3AAA794")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x3AA985C", Offset = "0x3AA985C", VA = "0x3AA985C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x3AA9F24", Offset = "0x3AA9F24", VA = "0x3AA9F24")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x3AAA0AC", Offset = "0x3AAA0AC", VA = "0x3AAA0AC")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197704C", Offset = "0x197704C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197705C", Offset = "0x197705C")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197706C", Offset = "0x197706C")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000052")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x3A96144", Offset = "0x3A96144", VA = "0x3A96144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EDA4", Offset = "0x197EDA4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x3A9614C", Offset = "0x3A9614C", VA = "0x3A9614C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EDB4", Offset = "0x197EDB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool isPaused
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x3A96154", Offset = "0x3A96154", VA = "0x3A96154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EDC4", Offset = "0x197EDC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x3A9615C", Offset = "0x3A9615C", VA = "0x3A9615C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EDD4", Offset = "0x197EDD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x3A96168", Offset = "0x3A96168", VA = "0x3A96168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EDE4", Offset = "0x197EDE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x3A96170", Offset = "0x3A96170", VA = "0x3A96170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EDF4", Offset = "0x197EDF4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool inInteraction
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x3A96178", Offset = "0x3A96178", VA = "0x3A96178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public float progress
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x3A98DB4", Offset = "0x3A98DB4", VA = "0x3A98DB4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x3A961E8", Offset = "0x3A961E8", VA = "0x3A961E8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x3A9626C", Offset = "0x3A9626C", VA = "0x3A9626C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x3A96308", Offset = "0x3A96308", VA = "0x3A96308")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x3A96480", Offset = "0x3A96480", VA = "0x3A96480")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x3A96930", Offset = "0x3A96930", VA = "0x3A96930")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x3A96CF0", Offset = "0x3A96CF0", VA = "0x3A96CF0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x3A96D44", Offset = "0x3A96D44", VA = "0x3A96D44")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x3A979F4", Offset = "0x3A979F4", VA = "0x3A979F4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x3A9855C", Offset = "0x3A9855C", VA = "0x3A9855C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x3A98784", Offset = "0x3A98784", VA = "0x3A98784")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x3A98C60", Offset = "0x3A98C60", VA = "0x3A98C60")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x3A9929C", Offset = "0x3A9929C", VA = "0x3A9929C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197707C", Offset = "0x197707C")]
		public LookAtIK ik;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19770B4", Offset = "0x19770B4")]
		public float lerpSpeed;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19770EC", Offset = "0x19770EC")]
		public float weightSpeed;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x3A99584", Offset = "0x3A99584", VA = "0x3A99584")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x3A996FC", Offset = "0x3A996FC", VA = "0x3A996FC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x3A997A4", Offset = "0x3A997A4", VA = "0x3A997A4")]
		public void Update()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x3A999E8", Offset = "0x3A999E8", VA = "0x3A999E8")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x3A99AE0", Offset = "0x3A99AE0", VA = "0x3A99AE0")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x3A99BAC", Offset = "0x3A99BAC", VA = "0x3A99BAC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x197483C", Offset = "0x197483C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x197483C", Offset = "0x197483C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public class InteractionEvent
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BEC8", Offset = "0x197BEC8")]
			public float time;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BF00", Offset = "0x197BF00")]
			public bool pause;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BF38", Offset = "0x197BF38")]
			public bool pickUp;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BF70", Offset = "0x197BF70")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BFA8", Offset = "0x197BFA8")]
			public Message[] messages;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197BFE0", Offset = "0x197BFE0")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x3A98DF0", Offset = "0x3A98DF0", VA = "0x3A98DF0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x3A9AEA8", Offset = "0x3A9AEA8", VA = "0x3A9AEA8")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C0")]
		public class Message
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C018", Offset = "0x197C018")]
			public string function;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C050", Offset = "0x197C050")]
			public GameObject recipient;

			[Token(Token = "0x4000596")]
			private const string empty = "";

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x3A9ADB8", Offset = "0x3A9ADB8", VA = "0x3A9ADB8")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x3A9AEB0", Offset = "0x3A9AEB0", VA = "0x3A9AEB0")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C088", Offset = "0x197C088")]
			public Animator animator;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C0C0", Offset = "0x197C0C0")]
			public Animation animation;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C0F8", Offset = "0x197C0F8")]
			public string animationState;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C130", Offset = "0x197C130")]
			public float crossfadeTime;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C168", Offset = "0x197C168")]
			public int layer;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C1A0", Offset = "0x197C1A0")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400059D")]
			private const string empty = "";

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x3A9AB18", Offset = "0x3A9AB18", VA = "0x3A9AB18")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x3A9AC0C", Offset = "0x3A9AC0C", VA = "0x3A9AC0C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x3A9ACC4", Offset = "0x3A9ACC4", VA = "0x3A9ACC4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x3A9ADA4", Offset = "0x3A9ADA4", VA = "0x3A9ADA4")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000EC")]
			public enum Type
			{
				[Token(Token = "0x4000666")]
				PositionWeight,
				[Token(Token = "0x4000667")]
				RotationWeight,
				[Token(Token = "0x4000668")]
				PositionOffsetX,
				[Token(Token = "0x4000669")]
				PositionOffsetY,
				[Token(Token = "0x400066A")]
				PositionOffsetZ,
				[Token(Token = "0x400066B")]
				Pull,
				[Token(Token = "0x400066C")]
				Reach,
				[Token(Token = "0x400066D")]
				RotateBoneWeight,
				[Token(Token = "0x400066E")]
				Push,
				[Token(Token = "0x400066F")]
				PushParent,
				[Token(Token = "0x4000670")]
				PoserWeight,
				[Token(Token = "0x4000671")]
				BendGoalWeight
			}

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C1D8", Offset = "0x197C1D8")]
			public Type type;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C210", Offset = "0x197C210")]
			public AnimationCurve curve;

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x3A9A330", Offset = "0x3A9A330", VA = "0x3A9A330")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x3A9AEC8", Offset = "0x3A9AEC8", VA = "0x3A9AEC8")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public class Multiplier
		{
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C248", Offset = "0x197C248")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C280", Offset = "0x197C280")]
			public float multiplier;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C2B8", Offset = "0x197C2B8")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x3A9AA10", Offset = "0x3A9AA10", VA = "0x3A9AA10")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x3A9AEB8", Offset = "0x3A9AEB8", VA = "0x3A9AEB8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977134", Offset = "0x1977134")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197716C", Offset = "0x197716C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19771A4", Offset = "0x19771A4")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19771DC", Offset = "0x19771DC")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19771EC", Offset = "0x19771EC")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000057")]
		public float length
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x3A99E20", Offset = "0x3A99E20", VA = "0x3A99E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EFC4", Offset = "0x197EFC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x3A99E28", Offset = "0x3A99E28", VA = "0x3A99E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EFD4", Offset = "0x197EFD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x3A99E30", Offset = "0x3A99E30", VA = "0x3A99E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EFE4", Offset = "0x197EFE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x3A99E38", Offset = "0x3A99E38", VA = "0x3A99E38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197EFF4", Offset = "0x197EFF4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x3A9A054", Offset = "0x3A9A054", VA = "0x3A9A054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x3A99170", Offset = "0x3A99170", VA = "0x3A99170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x3A99BC0", Offset = "0x3A99BC0", VA = "0x3A99BC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EE04", Offset = "0x197EE04")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x3A99C0C", Offset = "0x3A99C0C", VA = "0x3A99C0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EE3C", Offset = "0x197EE3C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x3A99C58", Offset = "0x3A99C58", VA = "0x3A99C58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EE74", Offset = "0x197EE74")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x3A99CA4", Offset = "0x3A99CA4", VA = "0x3A99CA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EEAC", Offset = "0x197EEAC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x3A99CF0", Offset = "0x3A99CF0", VA = "0x3A99CF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EEE4", Offset = "0x197EEE4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x3A99D3C", Offset = "0x3A99D3C", VA = "0x3A99D3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EF1C", Offset = "0x197EF1C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x3A99D88", Offset = "0x3A99D88", VA = "0x3A99D88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EF54", Offset = "0x197EF54")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x3A99DD4", Offset = "0x3A99DD4", VA = "0x3A99DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197EF8C", Offset = "0x197EF8C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x3A99E40", Offset = "0x3A99E40", VA = "0x3A99E40")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x3A9A0E4", Offset = "0x3A9A0E4", VA = "0x3A9A0E4")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x3A972A8", Offset = "0x3A972A8", VA = "0x3A972A8")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x3A9A248", Offset = "0x3A9A248", VA = "0x3A9A248")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x3A97164", Offset = "0x3A97164", VA = "0x3A97164")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x3A972A0", Offset = "0x3A972A0", VA = "0x3A972A0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x3A98140", Offset = "0x3A98140", VA = "0x3A98140")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x3A98A38", Offset = "0x3A98A38", VA = "0x3A98A38")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x3A9AA4C", Offset = "0x3A9AA4C", VA = "0x3A9AA4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x3A9A34C", Offset = "0x3A9A34C", VA = "0x3A9A34C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x3A9A250", Offset = "0x3A9A250", VA = "0x3A9A250")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x3A9A9A8", Offset = "0x3A9A9A8", VA = "0x3A9A9A8")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x3A9AA50", Offset = "0x3A9AA50", VA = "0x3A9AA50")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x3A9AAB8", Offset = "0x3A9AAB8", VA = "0x3A9AAB8")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x197489C", Offset = "0x197489C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x197489C", Offset = "0x197489C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000C5")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19771FC", Offset = "0x19771FC")]
		public string targetTag;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977234", Offset = "0x1977234")]
		public float fadeInTime;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197726C", Offset = "0x197726C")]
		public float speed;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19772A4", Offset = "0x19772A4")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x19772DC", Offset = "0x19772DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19772DC", Offset = "0x19772DC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x19772DC", Offset = "0x19772DC")]
		public Collider characterCollider;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977360", Offset = "0x1977360")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1977360", Offset = "0x1977360")]
		public Transform FPSCamera;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19773C0", Offset = "0x19773C0")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19773F8", Offset = "0x19773F8")]
		public float camRaycastDistance;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1977430", Offset = "0x1977430")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1977440", Offset = "0x1977440")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977440", Offset = "0x1977440")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19774A0", Offset = "0x19774A0")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19774D8", Offset = "0x19774D8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700005B")]
		public bool inInteraction
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x3A9B130", Offset = "0x3A9B130", VA = "0x3A9B130")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x3A9CD48", Offset = "0x3A9CD48", VA = "0x3A9CD48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x3A9CD50", Offset = "0x3A9CD50", VA = "0x3A9CD50")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x3A9CD58", Offset = "0x3A9CD58", VA = "0x3A9CD58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197F1C4", Offset = "0x197F1C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x3A9CD60", Offset = "0x3A9CD60", VA = "0x3A9CD60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197F1D4", Offset = "0x197F1D4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool initiated
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x3A9CD68", Offset = "0x3A9CD68", VA = "0x3A9CD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197F1E4", Offset = "0x197F1E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x3A9CD70", Offset = "0x3A9CD70", VA = "0x3A9CD70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197F1F4", Offset = "0x197F1F4")]
			private set
			{
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x3A9AED0", Offset = "0x3A9AED0", VA = "0x3A9AED0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F004", Offset = "0x197F004")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x3A9AF1C", Offset = "0x3A9AF1C", VA = "0x3A9AF1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F03C", Offset = "0x197F03C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x3A9AF68", Offset = "0x3A9AF68", VA = "0x3A9AF68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F074", Offset = "0x197F074")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x3A9AFB4", Offset = "0x3A9AFB4", VA = "0x3A9AFB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F0AC", Offset = "0x197F0AC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x3A9B000", Offset = "0x3A9B000", VA = "0x3A9B000")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F0E4", Offset = "0x197F0E4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x3A9B04C", Offset = "0x3A9B04C", VA = "0x3A9B04C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F11C", Offset = "0x197F11C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x3A9B098", Offset = "0x3A9B098", VA = "0x3A9B098")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F154", Offset = "0x197F154")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x3A9B0E4", Offset = "0x3A9B0E4", VA = "0x3A9B0E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F18C", Offset = "0x197F18C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x3A9B2C0", Offset = "0x3A9B2C0", VA = "0x3A9B2C0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x3A9B38C", Offset = "0x3A9B38C", VA = "0x3A9B38C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x3A9B458", Offset = "0x3A9B458", VA = "0x3A9B458")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x3A9B504", Offset = "0x3A9B504", VA = "0x3A9B504")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x3A9B5FC", Offset = "0x3A9B5FC", VA = "0x3A9B5FC")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x3A9B718", Offset = "0x3A9B718", VA = "0x3A9B718")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x3A9B7A8", Offset = "0x3A9B7A8", VA = "0x3A9B7A8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x3A9B838", Offset = "0x3A9B838", VA = "0x3A9B838")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x3A9B8C8", Offset = "0x3A9B8C8", VA = "0x3A9B8C8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x3A9B93C", Offset = "0x3A9B93C", VA = "0x3A9B93C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x3A9B9B0", Offset = "0x3A9B9B0", VA = "0x3A9B9B0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x3A9BA18", Offset = "0x3A9BA18", VA = "0x3A9BA18")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3A9BAA4", Offset = "0x3A9BAA4", VA = "0x3A9BAA4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x3A9BB58", Offset = "0x3A9BB58", VA = "0x3A9BB58")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x3A9BC3C", Offset = "0x3A9BC3C", VA = "0x3A9BC3C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x3A9BEE0", Offset = "0x3A9BEE0", VA = "0x3A9BEE0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x3A9C0B8", Offset = "0x3A9C0B8", VA = "0x3A9C0B8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x3A9C32C", Offset = "0x3A9C32C", VA = "0x3A9C32C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x3A9C620", Offset = "0x3A9C620", VA = "0x3A9C620")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x3A9C664", Offset = "0x3A9C664", VA = "0x3A9C664")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x3A9C6DC", Offset = "0x3A9C6DC", VA = "0x3A9C6DC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x3A9C7FC", Offset = "0x3A9C7FC", VA = "0x3A9C7FC")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x3A9C974", Offset = "0x3A9C974", VA = "0x3A9C974")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x3A9CC1C", Offset = "0x3A9CC1C", VA = "0x3A9CC1C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x3A9C42C", Offset = "0x3A9C42C", VA = "0x3A9C42C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x3A9CD7C", Offset = "0x3A9CD7C", VA = "0x3A9CD7C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x3A9D430", Offset = "0x3A9D430", VA = "0x3A9D430")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x3A9D450", Offset = "0x3A9D450", VA = "0x3A9D450")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x3A9D46C", Offset = "0x3A9D46C", VA = "0x3A9D46C")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x3A9D488", Offset = "0x3A9D488", VA = "0x3A9D488")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x3A9D4E8", Offset = "0x3A9D4E8", VA = "0x3A9D4E8")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x3A9D604", Offset = "0x3A9D604", VA = "0x3A9D604")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x3A9D700", Offset = "0x3A9D700", VA = "0x3A9D700")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x3A9DA60", Offset = "0x3A9DA60", VA = "0x3A9DA60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x3A9DB4C", Offset = "0x3A9DB4C", VA = "0x3A9DB4C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x3A9DD64", Offset = "0x3A9DD64", VA = "0x3A9DD64")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x3A9D1A8", Offset = "0x3A9D1A8", VA = "0x3A9D1A8")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x3A9DEA4", Offset = "0x3A9DEA4", VA = "0x3A9DEA4")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x3A9DFD0", Offset = "0x3A9DFD0", VA = "0x3A9DFD0")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x3A9E068", Offset = "0x3A9E068", VA = "0x3A9E068")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x3A9E140", Offset = "0x3A9E140", VA = "0x3A9E140")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x3A9E158", Offset = "0x3A9E158", VA = "0x3A9E158")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x3A9B1DC", Offset = "0x3A9B1DC", VA = "0x3A9B1DC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x3A9BDDC", Offset = "0x3A9BDDC", VA = "0x3A9BDDC")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x3A9E448", Offset = "0x3A9E448", VA = "0x3A9E448")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19748FC", Offset = "0x19748FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19748FC", Offset = "0x19748FC")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public enum RotationMode
		{
			[Token(Token = "0x40005A4")]
			TwoDOF,
			[Token(Token = "0x40005A5")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Multiplier
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C2F0", Offset = "0x197C2F0")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C328", Offset = "0x197C328")]
			public float multiplier;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x3A9EBEC", Offset = "0x3A9EBEC", VA = "0x3A9EBEC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19774E8", Offset = "0x19774E8")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977520", Offset = "0x1977520")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977558", Offset = "0x1977558")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977590", Offset = "0x1977590")]
		public Transform pivot;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19775C8", Offset = "0x19775C8")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977600", Offset = "0x1977600")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977638", Offset = "0x1977638")]
		public float twistWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977670", Offset = "0x1977670")]
		public float swingWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19776A8", Offset = "0x19776A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19776A8", Offset = "0x19776A8")]
		public float threeDOFWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19776FC", Offset = "0x19776FC")]
		public bool rotateOnce;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x3A9E8FC", Offset = "0x3A9E8FC", VA = "0x3A9E8FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F204", Offset = "0x197F204")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x3A9E948", Offset = "0x3A9E948", VA = "0x3A9E948")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F23C", Offset = "0x197F23C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x3A9E994", Offset = "0x3A9E994", VA = "0x3A9E994")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F274", Offset = "0x197F274")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x3A9E9E0", Offset = "0x3A9E9E0", VA = "0x3A9E9E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F2AC", Offset = "0x197F2AC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x3A9EA2C", Offset = "0x3A9EA2C", VA = "0x3A9EA2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F2E4", Offset = "0x197F2E4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x3A9EA78", Offset = "0x3A9EA78", VA = "0x3A9EA78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F31C", Offset = "0x197F31C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x3A9EAC4", Offset = "0x3A9EAC4", VA = "0x3A9EAC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F354", Offset = "0x197F354")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x3A9EB10", Offset = "0x3A9EB10", VA = "0x3A9EB10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F38C", Offset = "0x197F38C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x3A9A2C0", Offset = "0x3A9A2C0", VA = "0x3A9A2C0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x3A99200", Offset = "0x3A99200", VA = "0x3A99200")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x3A9735C", Offset = "0x3A9735C", VA = "0x3A9735C")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x3A9EB5C", Offset = "0x3A9EB5C", VA = "0x3A9EB5C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x197495C", Offset = "0x197495C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x197495C", Offset = "0x197495C")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public class CharacterPosition
		{
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C360", Offset = "0x197C360")]
			public bool use;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C398", Offset = "0x197C398")]
			public Vector2 offset;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C3D0", Offset = "0x197C3D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197C3D0", Offset = "0x197C3D0")]
			public float angleOffset;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C42C", Offset = "0x197C42C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197C42C", Offset = "0x197C42C")]
			public float maxAngle;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C484", Offset = "0x197C484")]
			public float radius;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C4BC", Offset = "0x197C4BC")]
			public bool orbit;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C4F4", Offset = "0x197C4F4")]
			public bool fixYAxis;

			[Token(Token = "0x170000BA")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x3A9F408", Offset = "0x3A9F408", VA = "0x3A9F408")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BB")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x3A9F444", Offset = "0x3A9F444", VA = "0x3A9F444")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x3A9F53C", Offset = "0x3A9F53C", VA = "0x3A9F53C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x3A9FBB8", Offset = "0x3A9FBB8", VA = "0x3A9FBB8")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		public class CameraPosition
		{
			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C52C", Offset = "0x197C52C")]
			public Collider lookAtTarget;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C564", Offset = "0x197C564")]
			public Vector3 direction;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C59C", Offset = "0x197C59C")]
			public float maxDistance;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C5D4", Offset = "0x197C5D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197C5D4", Offset = "0x197C5D4")]
			public float maxAngle;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C62C", Offset = "0x197C62C")]
			public bool fixYAxis;

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x3A9EEF4", Offset = "0x3A9EEF4", VA = "0x3A9EEF4")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x3A9F09C", Offset = "0x3A9F09C", VA = "0x3A9F09C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x3A9F37C", Offset = "0x3A9F37C", VA = "0x3A9F37C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000ED")]
			public class Interaction
			{
				[Token(Token = "0x4000672")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D644", Offset = "0x197D644")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000673")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D67C", Offset = "0x197D67C")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600075B")]
				[Address(RVA = "0x3A9FBDC", Offset = "0x3A9FBDC", VA = "0x3A9FBDC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C684", Offset = "0x197C684")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C6BC", Offset = "0x197C6BC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C6F4", Offset = "0x197C6F4")]
			public Interaction[] interactions;

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x3A9ED70", Offset = "0x3A9ED70", VA = "0x3A9ED70")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x3A9FBCC", Offset = "0x3A9FBCC", VA = "0x3A9FBCC")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977734", Offset = "0x1977734")]
		public Range[] ranges;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x3A9EBF4", Offset = "0x3A9EBF4", VA = "0x3A9EBF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F3C4", Offset = "0x197F3C4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x3A9EC40", Offset = "0x3A9EC40", VA = "0x3A9EC40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F3FC", Offset = "0x197F3FC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x3A9EC8C", Offset = "0x3A9EC8C", VA = "0x3A9EC8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F434", Offset = "0x197F434")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x3A9ECD8", Offset = "0x3A9ECD8", VA = "0x3A9ECD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F46C", Offset = "0x197F46C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x3A9ED24", Offset = "0x3A9ED24", VA = "0x3A9ED24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F4A4", Offset = "0x197F4A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x3A9D8A4", Offset = "0x3A9D8A4", VA = "0x3A9D8A4")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x3A9EE94", Offset = "0x3A9EE94", VA = "0x3A9EE94")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Map
		{
			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x3D779FC", Offset = "0x3D779FC", VA = "0x3D779FC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x3D77E00", Offset = "0x3D77E00", VA = "0x3D77E00")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x3D77DB4", Offset = "0x3D77DB4", VA = "0x3D77DB4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x3D77BAC", Offset = "0x3D77BAC", VA = "0x3D77BAC")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x3D77714", Offset = "0x3D77714", VA = "0x3D77714", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F4DC", Offset = "0x197F4DC")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x3D77AA0", Offset = "0x3D77AA0", VA = "0x3D77AA0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x3D77AA4", Offset = "0x3D77AA4", VA = "0x3D77AA4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x3D77D4C", Offset = "0x3D77D4C", VA = "0x3D77D4C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x3D77A38", Offset = "0x3D77A38", VA = "0x3D77A38")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x3D7795C", Offset = "0x3D7795C", VA = "0x3D7795C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x3D77E50", Offset = "0x3D77E50", VA = "0x3D77E50")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x3D820F0", Offset = "0x3D820F0", VA = "0x3D820F0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x3D821A4", Offset = "0x3D821A4", VA = "0x3D821A4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x3D8235C", Offset = "0x3D8235C", VA = "0x3D8235C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x3D82458", Offset = "0x3D82458", VA = "0x3D82458", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x3D82200", Offset = "0x3D82200", VA = "0x3D82200")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x3D82808", Offset = "0x3D82808", VA = "0x3D82808")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197776C", Offset = "0x197776C")]
		public float weight;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1977784", Offset = "0x1977784")]
		public float localRotationWeight;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197779C", Offset = "0x197779C")]
		public float localPositionWeight;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600045B")]
		public abstract void AutoMapping();

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x3AA27A0", Offset = "0x3AA27A0", VA = "0x3AA27A0")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600045D")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x600045E")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x600045F")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x3AA27AC", Offset = "0x3AA27AC", VA = "0x3AA27AC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x3AA2800", Offset = "0x3AA2800", VA = "0x3AA2800", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x3AA283C", Offset = "0x3AA283C", VA = "0x3AA283C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x3AA2854", Offset = "0x3AA2854", VA = "0x3AA2854")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		public class Rigidbone
		{
			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x3AA2DD8", Offset = "0x3AA2DD8", VA = "0x3AA2DD8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x3AA39E4", Offset = "0x3AA39E4", VA = "0x3AA39E4")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x3AA37C8", Offset = "0x3AA37C8", VA = "0x3AA37C8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000CD")]
		public class Child
		{
			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x3AA2F34", Offset = "0x3AA2F34", VA = "0x3AA2F34")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x3AA3B80", Offset = "0x3AA3B80", VA = "0x3AA3B80")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x3AA3B30", Offset = "0x3AA3B30", VA = "0x3AA3B30")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974BB0", Offset = "0x1974BB0")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x3AA4160", Offset = "0x3AA4160", VA = "0x3AA4160", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D2")]
				[Address(RVA = "0x3AA41C8", Offset = "0x3AA41C8", VA = "0x3AA41C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x3AA2F94", Offset = "0x3AA2F94", VA = "0x3AA2F94")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x3AA3F18", Offset = "0x3AA3F18", VA = "0x3AA3F18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x3AA3F1C", Offset = "0x3AA3F1C", VA = "0x3AA3F1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x3AA4168", Offset = "0x3AA4168", VA = "0x3AA4168", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19777B4", Offset = "0x19777B4")]
		public IK ik;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19777EC", Offset = "0x19777EC")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977824", Offset = "0x1977824")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197785C", Offset = "0x197785C")]
		public float applyVelocity;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977894", Offset = "0x1977894")]
		public float applyAngularVelocity;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700005F")]
		private bool isRagdoll
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x3AA289C", Offset = "0x3AA289C", VA = "0x3AA289C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		private bool ikUsed
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x3AA3380", Offset = "0x3AA3380", VA = "0x3AA3380")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x3AA2864", Offset = "0x3AA2864", VA = "0x3AA2864")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x3AA2914", Offset = "0x3AA2914", VA = "0x3AA2914")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x3AA2A44", Offset = "0x3AA2A44", VA = "0x3AA2A44")]
		public void Start()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x3AA29D4", Offset = "0x3AA29D4", VA = "0x3AA29D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x197F514", Offset = "0x197F514")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x3AA2FC0", Offset = "0x3AA2FC0", VA = "0x3AA2FC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x3AA320C", Offset = "0x3AA320C", VA = "0x3AA320C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x3AA32C4", Offset = "0x3AA32C4", VA = "0x3AA32C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x3AA3504", Offset = "0x3AA3504", VA = "0x3AA3504")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x3AA3344", Offset = "0x3AA3344", VA = "0x3AA3344")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x3AA34C0", Offset = "0x3AA34C0", VA = "0x3AA34C0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x3AA35A0", Offset = "0x3AA35A0", VA = "0x3AA35A0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x3AA3538", Offset = "0x3AA3538", VA = "0x3AA3538")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x3AA296C", Offset = "0x3AA296C", VA = "0x3AA296C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x3AA324C", Offset = "0x3AA324C", VA = "0x3AA324C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x3AA3D48", Offset = "0x3AA3D48", VA = "0x3AA3D48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x3AA3E4C", Offset = "0x3AA3E4C", VA = "0x3AA3E4C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19778DC", Offset = "0x19778DC")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000061")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x3AA5A54", Offset = "0x3AA5A54", VA = "0x3AA5A54")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000062")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x3AA5A90", Offset = "0x3AA5A90", VA = "0x3AA5A90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000063")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x3AA5B60", Offset = "0x3AA5B60", VA = "0x3AA5B60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197F578", Offset = "0x197F578")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x3AA5B68", Offset = "0x3AA5B68", VA = "0x3AA5B68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197F588", Offset = "0x197F588")]
			private set
			{
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x3AA56B8", Offset = "0x3AA56B8", VA = "0x3AA56B8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x3AA5700", Offset = "0x3AA5700", VA = "0x3AA5700")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x3AA5718", Offset = "0x3AA5718", VA = "0x3AA5718")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x3AA59AC", Offset = "0x3AA59AC", VA = "0x3AA59AC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x3AA5A1C", Offset = "0x3AA5A1C", VA = "0x3AA5A1C")]
		public void Disable()
		{
		}

		[Token(Token = "0x600047F")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x3AA58BC", Offset = "0x3AA58BC", VA = "0x3AA58BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x3AA5B74", Offset = "0x3AA5B74", VA = "0x3AA5B74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x3AA5B78", Offset = "0x3AA5B78", VA = "0x3AA5B78")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x3AA5BAC", Offset = "0x3AA5BAC", VA = "0x3AA5BAC")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x3AA5C90", Offset = "0x3AA5C90", VA = "0x3AA5C90")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x3AA5F0C", Offset = "0x3AA5F0C", VA = "0x3AA5F0C")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x3AA5FC8", Offset = "0x3AA5FC8", VA = "0x3AA5FC8")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19749BC", Offset = "0x19749BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19749BC", Offset = "0x19749BC")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19778EC", Offset = "0x19778EC")]
		public float limit;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1977908", Offset = "0x1977908")]
		public float twistLimit;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x3AA6040", Offset = "0x3AA6040", VA = "0x3AA6040")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F598", Offset = "0x197F598")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x3AA608C", Offset = "0x3AA608C", VA = "0x3AA608C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F5D0", Offset = "0x197F5D0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x3AA60D8", Offset = "0x3AA60D8", VA = "0x3AA60D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F608", Offset = "0x197F608")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x3AA6124", Offset = "0x3AA6124", VA = "0x3AA6124")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F640", Offset = "0x197F640")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x3AA6170", Offset = "0x3AA6170", VA = "0x3AA6170", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x3AA6228", Offset = "0x3AA6228", VA = "0x3AA6228")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x3AA6470", Offset = "0x3AA6470", VA = "0x3AA6470")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974A1C", Offset = "0x1974A1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974A1C", Offset = "0x1974A1C")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x3AA6480", Offset = "0x3AA6480", VA = "0x3AA6480")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F678", Offset = "0x197F678")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x3AA64CC", Offset = "0x3AA64CC", VA = "0x3AA64CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F6B0", Offset = "0x197F6B0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x3AA6518", Offset = "0x3AA6518", VA = "0x3AA6518")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F6E8", Offset = "0x197F6E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x3AA6564", Offset = "0x3AA6564", VA = "0x3AA6564")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F720", Offset = "0x197F720")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x3AA65B0", Offset = "0x3AA65B0", VA = "0x3AA65B0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x3AA65B4", Offset = "0x3AA65B4", VA = "0x3AA65B4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x3AA6860", Offset = "0x3AA6860", VA = "0x3AA6860")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974A7C", Offset = "0x1974A7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974A7C", Offset = "0x1974A7C")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class ReachCone
		{
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000BE")]
			public Vector3 o
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x3AA8798", Offset = "0x3AA8798", VA = "0x3AA8798")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BF")]
			public Vector3 a
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x3AA87D0", Offset = "0x3AA87D0", VA = "0x3AA87D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C0")]
			public Vector3 b
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x3AA880C", Offset = "0x3AA880C", VA = "0x3AA880C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C1")]
			public Vector3 c
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x3AA8848", Offset = "0x3AA8848", VA = "0x3AA8848")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C2")]
			public bool isValid
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x3AA78FC", Offset = "0x3AA78FC", VA = "0x3AA78FC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x3AA7F48", Offset = "0x3AA7F48", VA = "0x3AA7F48")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x3AA80A8", Offset = "0x3AA80A8", VA = "0x3AA80A8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class LimitPoint
		{
			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x3AA790C", Offset = "0x3AA790C", VA = "0x3AA790C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1977934", Offset = "0x1977934")]
		public float twistLimit;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1977950", Offset = "0x1977950")]
		public int smoothIterations;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x3AA6878", Offset = "0x3AA6878", VA = "0x3AA6878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F758", Offset = "0x197F758")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x3AA68C4", Offset = "0x3AA68C4", VA = "0x3AA68C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F790", Offset = "0x197F790")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x3AA6910", Offset = "0x3AA6910", VA = "0x3AA6910")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F7C8", Offset = "0x197F7C8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x3AA695C", Offset = "0x3AA695C", VA = "0x3AA695C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F800", Offset = "0x197F800")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x3AA69A8", Offset = "0x3AA69A8", VA = "0x3AA69A8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x3AA6E90", Offset = "0x3AA6E90", VA = "0x3AA6E90", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x3AA6F88", Offset = "0x3AA6F88", VA = "0x3AA6F88")]
		private void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x3AA7548", Offset = "0x3AA7548", VA = "0x3AA7548")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x3AA6A48", Offset = "0x3AA6A48", VA = "0x3AA6A48")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x3AA7990", Offset = "0x3AA7990", VA = "0x3AA7990")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x3AA8268", Offset = "0x3AA8268", VA = "0x3AA8268")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x3AA82AC", Offset = "0x3AA82AC", VA = "0x3AA82AC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x3AA83F4", Offset = "0x3AA83F4", VA = "0x3AA83F4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x3AA720C", Offset = "0x3AA720C", VA = "0x3AA720C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x3AA8584", Offset = "0x3AA8584", VA = "0x3AA8584")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x3AA8734", Offset = "0x3AA8734", VA = "0x3AA8734")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1974ADC", Offset = "0x1974ADC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1974ADC", Offset = "0x1974ADC")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1977998", Offset = "0x1977998")]
		public float twistLimit;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x3AA8884", Offset = "0x3AA8884", VA = "0x3AA8884")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F838", Offset = "0x197F838")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x3AA88D0", Offset = "0x3AA88D0", VA = "0x3AA88D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F870", Offset = "0x197F870")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x3AA891C", Offset = "0x3AA891C", VA = "0x3AA891C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F8A8", Offset = "0x197F8A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x3AA8968", Offset = "0x3AA8968", VA = "0x3AA8968")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x197F8E0", Offset = "0x197F8E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x3AA89B4", Offset = "0x3AA89B4", VA = "0x3AA89B4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x3AA89D0", Offset = "0x3AA89D0", VA = "0x3AA89D0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x3AA8A88", Offset = "0x3AA8A88", VA = "0x3AA8A88")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x3AA8DB4", Offset = "0x3AA8DB4", VA = "0x3AA8DB4")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974BC0", Offset = "0x1974BC0")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x367CFD0", Offset = "0x367CFD0", VA = "0x367CFD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x367D038", Offset = "0x367D038", VA = "0x367D038", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x367CDAC", Offset = "0x367CDAC", VA = "0x367CDAC")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x367CEAC", Offset = "0x367CEAC", VA = "0x367CEAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x367CEB0", Offset = "0x367CEB0", VA = "0x367CEB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x367CFD8", Offset = "0x367CFD8", VA = "0x367CFD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19779C4", Offset = "0x19779C4")]
		public AimIK ik;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19779FC", Offset = "0x19779FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19779FC", Offset = "0x19779FC")]
		public float weight;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1977A50", Offset = "0x1977A50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977A50", Offset = "0x1977A50")]
		public Transform target;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977AB0", Offset = "0x1977AB0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977AE8", Offset = "0x1977AE8")]
		public float weightSmoothTime;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1977B20", Offset = "0x1977B20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977B20", Offset = "0x1977B20")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977B80", Offset = "0x1977B80")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977BB8", Offset = "0x1977BB8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977BF0", Offset = "0x1977BF0")]
		public float slerpSpeed;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977C28", Offset = "0x1977C28")]
		public float smoothDampTime;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977C60", Offset = "0x1977C60")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977C98", Offset = "0x1977C98")]
		public float minDistance;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977CD0", Offset = "0x1977CD0")]
		public Vector3 offset;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1977D08", Offset = "0x1977D08")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977D08", Offset = "0x1977D08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1977D08", Offset = "0x1977D08")]
		public float maxRootAngle;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977D84", Offset = "0x1977D84")]
		public bool turnToTarget;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977DBC", Offset = "0x1977DBC")]
		public float turnToTargetTime;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1977DF4", Offset = "0x1977DF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977DF4", Offset = "0x1977DF4")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977E54", Offset = "0x1977E54")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x17000064")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x367BD3C", Offset = "0x367BD3C", VA = "0x367BD3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x367BC40", Offset = "0x367BC40", VA = "0x367BC40")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x367BE88", Offset = "0x367BE88", VA = "0x367BE88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x367C830", Offset = "0x367C830", VA = "0x367C830")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x367C9CC", Offset = "0x367C9CC", VA = "0x367C9CC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x367CD3C", Offset = "0x367CD3C", VA = "0x367CD3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x197F918", Offset = "0x197F918")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x367CDD8", Offset = "0x367CDD8", VA = "0x367CDD8")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D2")]
		public class Pose
		{
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x367D308", Offset = "0x367D308", VA = "0x367D308")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x367D674", Offset = "0x367D674", VA = "0x367D674")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x367D67C", Offset = "0x367D67C", VA = "0x367D67C")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x367D22C", Offset = "0x367D22C", VA = "0x367D22C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x367D5A0", Offset = "0x367D5A0", VA = "0x367D5A0")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x367D60C", Offset = "0x367D60C", VA = "0x367D60C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000EE")]
			public class EffectorLink
			{
				[Token(Token = "0x4000674")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D6B4", Offset = "0x197D6B4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000675")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D6EC", Offset = "0x197D6EC")]
				public float weight;

				[Token(Token = "0x600075C")]
				[Address(RVA = "0x367DC6C", Offset = "0x367DC6C", VA = "0x367DC6C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C72C", Offset = "0x197C72C")]
			public Transform transform;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C764", Offset = "0x197C764")]
			public Transform relativeTo;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C79C", Offset = "0x197C79C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C7D4", Offset = "0x197C7D4")]
			public float verticalWeight;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C80C", Offset = "0x197C80C")]
			public float horizontalWeight;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C844", Offset = "0x197C844")]
			public float speed;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x367D7D8", Offset = "0x367D7D8", VA = "0x367D7D8")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x367DC44", Offset = "0x367DC44", VA = "0x367DC44")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x367DC54", Offset = "0x367DC54", VA = "0x367DC54")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977E8C", Offset = "0x1977E8C")]
		public Body[] bodies;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x367D698", Offset = "0x367D698", VA = "0x367D698", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x367DC3C", Offset = "0x367DC3C", VA = "0x367DC3C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977EC4", Offset = "0x1977EC4")]
		public float tiltSpeed;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977EFC", Offset = "0x1977EFC")]
		public float tiltSensitivity;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977F34", Offset = "0x1977F34")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977F6C", Offset = "0x1977F6C")]
		public OffsetPose poseRight;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x367F178", Offset = "0x367F178", VA = "0x367F178", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x367F1C0", Offset = "0x367F1C0", VA = "0x367F1C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x367F3F0", Offset = "0x367F3F0", VA = "0x367F3F0")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1977FA4", Offset = "0x1977FA4")]
		public float weight;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x367F404", Offset = "0x367F404", VA = "0x367F404")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x367F4C4", Offset = "0x367F4C4", VA = "0x367F4C4")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x367F7D4", Offset = "0x367F7D4", VA = "0x367F7D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x367F8CC", Offset = "0x367F8CC", VA = "0x367F8CC")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977FBC", Offset = "0x1977FBC")]
		public Animator animator;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1977FF4", Offset = "0x1977FF4")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197803C", Offset = "0x197803C")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x17000065")]
		public IK ik
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x3680330", Offset = "0x3680330", VA = "0x3680330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197F97C", Offset = "0x197F97C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x3680338", Offset = "0x3680338", VA = "0x3680338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197F98C", Offset = "0x197F98C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x3680340", Offset = "0x3680340", VA = "0x3680340")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x36804B0", Offset = "0x36804B0", VA = "0x36804B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x3680738", Offset = "0x3680738", VA = "0x3680738")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x3680878", Offset = "0x3680878", VA = "0x3680878")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x3680A40", Offset = "0x3680A40", VA = "0x3680A40")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x3680C50", Offset = "0x3680C50", VA = "0x3680C50")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x3680EE4", Offset = "0x3680EE4", VA = "0x3680EE4")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x1974B4C", Offset = "0x1974B4C")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x17000066")]
		public bool poseStored
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x36805AC", Offset = "0x36805AC", VA = "0x36805AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x36808F4", Offset = "0x36808F4", VA = "0x36808F4")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x36805D0", Offset = "0x36805D0", VA = "0x36805D0")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x3680F44", Offset = "0x3680F44", VA = "0x3680F44")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C87C", Offset = "0x197C87C")]
			public string name;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C8B4", Offset = "0x197C8B4")]
			public Collider collider;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C8EC", Offset = "0x197C8EC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197C938", Offset = "0x197C938")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197C948", Offset = "0x197C948")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197C958", Offset = "0x197C958")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197C968", Offset = "0x197C968")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000C5")]
			public bool inProgress
			{
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x3D828CC", Offset = "0x3D828CC", VA = "0x3D828CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C6")]
			protected float crossFader
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x3D82E74", Offset = "0x3D82E74", VA = "0x3D82E74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980028", Offset = "0x1980028")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0x3D82E7C", Offset = "0x3D82E7C", VA = "0x3D82E7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980038", Offset = "0x1980038")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			protected float timer
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0x3D82E84", Offset = "0x3D82E84", VA = "0x3D82E84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980048", Offset = "0x1980048")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006EB")]
				[Address(RVA = "0x3D82E8C", Offset = "0x3D82E8C", VA = "0x3D82E8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980058", Offset = "0x1980058")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C8")]
			protected Vector3 force
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x3D82E94", Offset = "0x3D82E94", VA = "0x3D82E94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980068", Offset = "0x1980068")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006ED")]
				[Address(RVA = "0x3D82EA0", Offset = "0x3D82EA0", VA = "0x3D82EA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980078", Offset = "0x1980078")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			protected Vector3 point
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x3D82EAC", Offset = "0x3D82EAC", VA = "0x3D82EAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980088", Offset = "0x1980088")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0x3D82EB8", Offset = "0x3D82EB8", VA = "0x3D82EB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980098", Offset = "0x1980098")]
				private set
				{
				}
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x3D82D40", Offset = "0x3D82D40", VA = "0x3D82D40")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x3D829B4", Offset = "0x3D829B4", VA = "0x3D829B4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F2")]
			protected abstract float GetLength();

			[Token(Token = "0x60006F3")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60006F4")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x3D82EC4", Offset = "0x3D82EC4", VA = "0x3D82EC4")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D5")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000EF")]
			public class EffectorLink
			{
				[Token(Token = "0x4000676")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D724", Offset = "0x197D724")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000677")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D75C", Offset = "0x197D75C")]
				public float weight;

				[Token(Token = "0x4000678")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000679")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600075D")]
				[Address(RVA = "0x3D83830", Offset = "0x3D83830", VA = "0x3D83830")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600075E")]
				[Address(RVA = "0x3D83624", Offset = "0x3D83624", VA = "0x3D83624")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600075F")]
				[Address(RVA = "0x3D8396C", Offset = "0x3D8396C", VA = "0x3D8396C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C978", Offset = "0x197C978")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C9B0", Offset = "0x197C9B0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197C9E8", Offset = "0x197C9E8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x3D83440", Offset = "0x3D83440", VA = "0x3D83440", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x3D835B8", Offset = "0x3D835B8", VA = "0x3D835B8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x3D83638", Offset = "0x3D83638", VA = "0x3D83638", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x3D83958", Offset = "0x3D83958", VA = "0x3D83958")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000F0")]
			public class BoneLink
			{
				[Token(Token = "0x400067A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D794", Offset = "0x197D794")]
				public Transform bone;

				[Token(Token = "0x400067B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D7CC", Offset = "0x197D7CC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197D7CC", Offset = "0x197D7CC")]
				public float weight;

				[Token(Token = "0x400067C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400067D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000760")]
				[Address(RVA = "0x3D83248", Offset = "0x3D83248", VA = "0x3D83248")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000761")]
				[Address(RVA = "0x3D82FE0", Offset = "0x3D82FE0", VA = "0x3D82FE0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000762")]
				[Address(RVA = "0x3D833B8", Offset = "0x3D833B8", VA = "0x3D833B8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CA20", Offset = "0x197CA20")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CA58", Offset = "0x197CA58")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x3D82ED8", Offset = "0x3D82ED8", VA = "0x3D82ED8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x3D82F7C", Offset = "0x3D82F7C", VA = "0x3D82F7C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x3D82FEC", Offset = "0x3D82FEC", VA = "0x3D82FEC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x3D833A4", Offset = "0x3D833A4", VA = "0x3D833A4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197804C", Offset = "0x197804C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978084", Offset = "0x1978084")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000067")]
		public bool inProgress
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x3D82810", Offset = "0x3D82810", VA = "0x3D82810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x3D828E0", Offset = "0x3D828E0", VA = "0x3D828E0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x3D82B00", Offset = "0x3D82B00", VA = "0x3D82B00")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x3D82E6C", Offset = "0x3D82E6C", VA = "0x3D82E6C")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public abstract class Offset
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CA90", Offset = "0x197CA90")]
			public string name;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CAC8", Offset = "0x197CAC8")]
			public Collider collider;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CB00", Offset = "0x197CB00")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197CB4C", Offset = "0x197CB4C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197CB5C", Offset = "0x197CB5C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197CB6C", Offset = "0x197CB6C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197CB7C", Offset = "0x197CB7C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000CA")]
			protected float crossFader
			{
				[Token(Token = "0x60006FE")]
				[Address(RVA = "0x3D83F24", Offset = "0x3D83F24", VA = "0x3D83F24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19800A8", Offset = "0x19800A8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006FF")]
				[Address(RVA = "0x3D83F2C", Offset = "0x3D83F2C", VA = "0x3D83F2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19800B8", Offset = "0x19800B8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			protected float timer
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x3D83F34", Offset = "0x3D83F34", VA = "0x3D83F34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19800C8", Offset = "0x19800C8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x3D83F3C", Offset = "0x3D83F3C", VA = "0x3D83F3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19800D8", Offset = "0x19800D8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			protected Vector3 force
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x3D83F44", Offset = "0x3D83F44", VA = "0x3D83F44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19800E8", Offset = "0x19800E8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000703")]
				[Address(RVA = "0x3D83F50", Offset = "0x3D83F50", VA = "0x3D83F50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19800F8", Offset = "0x19800F8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CD")]
			protected Vector3 point
			{
				[Token(Token = "0x6000704")]
				[Address(RVA = "0x3D83F5C", Offset = "0x3D83F5C", VA = "0x3D83F5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980108", Offset = "0x1980108")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000705")]
				[Address(RVA = "0x3D83F68", Offset = "0x3D83F68", VA = "0x3D83F68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1980118", Offset = "0x1980118")]
				private set
				{
				}
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x3D83DDC", Offset = "0x3D83DDC", VA = "0x3D83DDC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x3D83A40", Offset = "0x3D83A40", VA = "0x3D83A40")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000708")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000709")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600070A")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x3D83F74", Offset = "0x3D83F74", VA = "0x3D83F74")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000F1")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400067E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D820", Offset = "0x197D820")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400067F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D858", Offset = "0x197D858")]
				public float weight;

				[Token(Token = "0x4000680")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000681")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000763")]
				[Address(RVA = "0x3D84430", Offset = "0x3D84430", VA = "0x3D84430")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000764")]
				[Address(RVA = "0x3D841EC", Offset = "0x3D841EC", VA = "0x3D841EC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000765")]
				[Address(RVA = "0x3D8454C", Offset = "0x3D8454C", VA = "0x3D8454C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CB8C", Offset = "0x197CB8C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CBC4", Offset = "0x197CBC4")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CBFC", Offset = "0x197CBFC")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x3D83F88", Offset = "0x3D83F88", VA = "0x3D83F88", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x3D84180", Offset = "0x3D84180", VA = "0x3D84180", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x3D84200", Offset = "0x3D84200", VA = "0x3D84200", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x3D84530", Offset = "0x3D84530", VA = "0x3D84530")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000F2")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000682")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D890", Offset = "0x197D890")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000683")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D8C8", Offset = "0x197D8C8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197D8C8", Offset = "0x197D8C8")]
				public float weight;

				[Token(Token = "0x4000684")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000685")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000766")]
				[Address(RVA = "0x3D849B4", Offset = "0x3D849B4", VA = "0x3D849B4")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000767")]
				[Address(RVA = "0x3D8469C", Offset = "0x3D8469C", VA = "0x3D8469C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000768")]
				[Address(RVA = "0x3D84AF0", Offset = "0x3D84AF0", VA = "0x3D84AF0")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CC34", Offset = "0x197CC34")]
			public int curveIndex;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CC6C", Offset = "0x197CC6C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x3D84554", Offset = "0x3D84554", VA = "0x3D84554", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x3D84638", Offset = "0x3D84638", VA = "0x3D84638", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x3D846A8", Offset = "0x3D846A8", VA = "0x3D846A8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x3D84ADC", Offset = "0x3D84ADC", VA = "0x3D84ADC")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19780BC", Offset = "0x19780BC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19780F4", Offset = "0x19780F4")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x3D83974", Offset = "0x3D83974", VA = "0x3D83974", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x3D83B94", Offset = "0x3D83B94", VA = "0x3D83B94")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x3D83F1C", Offset = "0x3D83F1C", VA = "0x3D83F1C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000F3")]
			public class EffectorLink
			{
				[Token(Token = "0x4000686")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D91C", Offset = "0x197D91C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000687")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D954", Offset = "0x197D954")]
				public float weight;

				[Token(Token = "0x6000769")]
				[Address(RVA = "0x3A9613C", Offset = "0x3A9613C", VA = "0x3A9613C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CCA4", Offset = "0x197CCA4")]
			public Transform transform;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CCDC", Offset = "0x197CCDC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CD14", Offset = "0x197CD14")]
			public float speed;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CD4C", Offset = "0x197CD4C")]
			public float acceleration;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CD84", Offset = "0x197CD84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197CD84", Offset = "0x197CD84")]
			public float matchVelocity;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CDD8", Offset = "0x197CDD8")]
			public float gravity;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x3A95B0C", Offset = "0x3A95B0C", VA = "0x3A95B0C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x3A95CCC", Offset = "0x3A95CCC", VA = "0x3A95CCC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x3A96120", Offset = "0x3A96120", VA = "0x3A96120")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197812C", Offset = "0x197812C")]
		public Body[] bodies;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978164", Offset = "0x1978164")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x3A95A94", Offset = "0x3A95A94", VA = "0x3A95A94")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x3A95BE8", Offset = "0x3A95BE8", VA = "0x3A95BE8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x3A96100", Offset = "0x3A96100", VA = "0x3A96100")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x197819C", Offset = "0x197819C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197819C", Offset = "0x197819C")]
		public Transform target;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19781FC", Offset = "0x19781FC")]
		public float weight;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978214", Offset = "0x1978214")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197824C", Offset = "0x197824C")]
		public float weightSmoothTime;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1978284", Offset = "0x1978284")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978284", Offset = "0x1978284")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19782E4", Offset = "0x19782E4")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197831C", Offset = "0x197831C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978354", Offset = "0x1978354")]
		public float slerpSpeed;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197838C", Offset = "0x197838C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19783C4", Offset = "0x19783C4")]
		public float minDistance;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x19783FC", Offset = "0x19783FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19783FC", Offset = "0x19783FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19783FC", Offset = "0x19783FC")]
		public float maxRootAngle;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000068")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x3AA000C", Offset = "0x3AA000C", VA = "0x3AA000C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x3A9FF24", Offset = "0x3A9FF24", VA = "0x3A9FF24")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x3AA0158", Offset = "0x3AA0158", VA = "0x3AA0158")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x3AA0820", Offset = "0x3AA0820", VA = "0x3AA0820")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x3AA09BC", Offset = "0x3AA09BC", VA = "0x3AA09BC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x3AA0CD8", Offset = "0x3AA0CD8", VA = "0x3AA0CD8")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CE10", Offset = "0x197CE10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CE48", Offset = "0x197CE48")]
			public float spring;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CE80", Offset = "0x197CE80")]
			public bool x;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CEB8", Offset = "0x197CEB8")]
			public bool y;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CEF0", Offset = "0x197CEF0")]
			public bool z;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CF28", Offset = "0x197CF28")]
			public float minX;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CF60", Offset = "0x197CF60")]
			public float maxX;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CF98", Offset = "0x197CF98")]
			public float minY;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197CFD0", Offset = "0x197CFD0")]
			public float maxY;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D008", Offset = "0x197D008")]
			public float minZ;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D040", Offset = "0x197D040")]
			public float maxZ;

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x3AA1100", Offset = "0x3AA1100", VA = "0x3AA1100")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x3AA1608", Offset = "0x3AA1608", VA = "0x3AA1608")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x3AA1638", Offset = "0x3AA1638", VA = "0x3AA1638")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x3AA1710", Offset = "0x3AA1710", VA = "0x3AA1710")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974BD0", Offset = "0x1974BD0")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x3AA1598", Offset = "0x3AA1598", VA = "0x3AA1598", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000720")]
				[Address(RVA = "0x3AA1600", Offset = "0x3AA1600", VA = "0x3AA1600", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x3AA0FC8", Offset = "0x3AA0FC8", VA = "0x3AA0FC8")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x3AA1458", Offset = "0x3AA1458", VA = "0x3AA1458", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x3AA145C", Offset = "0x3AA145C", VA = "0x3AA145C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x3AA15A0", Offset = "0x3AA15A0", VA = "0x3AA15A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978478", Offset = "0x1978478")]
		public float weight;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19784B0", Offset = "0x19784B0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000069")]
		protected float deltaTime
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x3A95CA0", Offset = "0x3A95CA0", VA = "0x3A95CA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004DE")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x3AA0F2C", Offset = "0x3AA0F2C", VA = "0x3AA0F2C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x3AA0F58", Offset = "0x3AA0F58", VA = "0x3AA0F58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x197F99C", Offset = "0x197F99C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x3AA0FF4", Offset = "0x3AA0FF4", VA = "0x3AA0FF4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x3A96044", Offset = "0x3A96044", VA = "0x3A96044")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x3AA1360", Offset = "0x3AA1360", VA = "0x3AA1360", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x3A96110", Offset = "0x3A96110", VA = "0x3A96110")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974BE0", Offset = "0x1974BE0")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000724")]
				[Address(RVA = "0x3AA1B60", Offset = "0x3AA1B60", VA = "0x3AA1B60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000726")]
				[Address(RVA = "0x3AA1BC8", Offset = "0x3AA1BC8", VA = "0x3AA1BC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x3AA17E0", Offset = "0x3AA17E0", VA = "0x3AA17E0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x3AA1A20", Offset = "0x3AA1A20", VA = "0x3AA1A20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x3AA1A24", Offset = "0x3AA1A24", VA = "0x3AA1A24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x3AA1B68", Offset = "0x3AA1B68", VA = "0x3AA1B68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19784E8", Offset = "0x19784E8")]
		public float weight;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978520", Offset = "0x1978520")]
		public VRIK ik;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700006A")]
		protected float deltaTime
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x3AA1718", Offset = "0x3AA1718", VA = "0x3AA1718")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004E6")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x3AA1744", Offset = "0x3AA1744", VA = "0x3AA1744", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x3AA1770", Offset = "0x3AA1770", VA = "0x3AA1770")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x197FA00", Offset = "0x197FA00")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x3AA180C", Offset = "0x3AA180C", VA = "0x3AA180C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x3AA1918", Offset = "0x3AA1918", VA = "0x3AA1918", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x3AA1A10", Offset = "0x3AA1A10", VA = "0x3AA1A10")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class EffectorLink
		{
			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x3AA1C90", Offset = "0x3AA1C90", VA = "0x3AA1C90")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x3AA20E0", Offset = "0x3AA20E0", VA = "0x3AA20E0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x3AA1BD0", Offset = "0x3AA1BD0", VA = "0x3AA1BD0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x3AA1FC8", Offset = "0x3AA1FC8", VA = "0x3AA1FC8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x3AA2080", Offset = "0x3AA2080", VA = "0x3AA2080")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000F4")]
			public class EffectorLink
			{
				[Token(Token = "0x4000688")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D98C", Offset = "0x197D98C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D9C4", Offset = "0x197D9C4")]
				public float weight;

				[Token(Token = "0x600076A")]
				[Address(RVA = "0x3AA2798", Offset = "0x3AA2798", VA = "0x3AA2798")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D078", Offset = "0x197D078")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D0B0", Offset = "0x197D0B0")]
			public Transform raycastTo;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D0E8", Offset = "0x197D0E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197D0E8", Offset = "0x197D0E8")]
			public float raycastRadius;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D13C", Offset = "0x197D13C")]
			public EffectorLink[] effectors;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D174", Offset = "0x197D174")]
			public float smoothTimeIn;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D1AC", Offset = "0x197D1AC")]
			public float smoothTimeOut;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D1E4", Offset = "0x197D1E4")]
			public LayerMask layers;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x3AA216C", Offset = "0x3AA216C", VA = "0x3AA216C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x3AA2378", Offset = "0x3AA2378", VA = "0x3AA2378")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x3AA2510", Offset = "0x3AA2510", VA = "0x3AA2510")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x3AA2784", Offset = "0x3AA2784", VA = "0x3AA2784")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978558", Offset = "0x1978558")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x3AA20E8", Offset = "0x3AA20E8", VA = "0x3AA20E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x3AA2368", Offset = "0x3AA2368", VA = "0x3AA2368")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000F5")]
			public class EffectorLink
			{
				[Token(Token = "0x400068A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D9FC", Offset = "0x197D9FC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197DA34", Offset = "0x197DA34")]
				public float weight;

				[Token(Token = "0x600076B")]
				[Address(RVA = "0x3AA56B0", Offset = "0x3AA56B0", VA = "0x3AA56B0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D21C", Offset = "0x197D21C")]
			public Vector3 offset;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D254", Offset = "0x197D254")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197D254", Offset = "0x197D254")]
			public float additivity;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D2A8", Offset = "0x197D2A8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D2E0", Offset = "0x197D2E0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x3AA43F8", Offset = "0x3AA43F8", VA = "0x3AA43F8")]
			public void Start()
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x3AA4F88", Offset = "0x3AA4F88", VA = "0x3AA4F88")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x3AA569C", Offset = "0x3AA569C", VA = "0x3AA569C")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public enum Handedness
		{
			[Token(Token = "0x4000637")]
			Right,
			[Token(Token = "0x4000638")]
			Left
		}

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978590", Offset = "0x1978590")]
		public AimIK aimIK;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19785C8", Offset = "0x19785C8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978600", Offset = "0x1978600")]
		public Handedness handedness;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978638", Offset = "0x1978638")]
		public bool twoHanded;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978670", Offset = "0x1978670")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19786A8", Offset = "0x19786A8")]
		public float magnitudeRandom;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19786E0", Offset = "0x19786E0")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978718", Offset = "0x1978718")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978750", Offset = "0x1978750")]
		public float blendTime;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1978788", Offset = "0x1978788")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978788", Offset = "0x1978788")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700006B")]
		public bool isFinished
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x3AA41D0", Offset = "0x3AA41D0", VA = "0x3AA41D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x3AA523C", Offset = "0x3AA523C", VA = "0x3AA523C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x3AA527C", Offset = "0x3AA527C", VA = "0x3AA527C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x3AA51FC", Offset = "0x3AA51FC", VA = "0x3AA51FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x3AA521C", Offset = "0x3AA521C", VA = "0x3AA521C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x3AA4200", Offset = "0x3AA4200", VA = "0x3AA4200")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x3AA422C", Offset = "0x3AA422C", VA = "0x3AA422C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x3AA44A8", Offset = "0x3AA44A8", VA = "0x3AA44A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x3AA52BC", Offset = "0x3AA52BC", VA = "0x3AA52BC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x3AA5414", Offset = "0x3AA5414", VA = "0x3AA5414")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x3AA5450", Offset = "0x3AA5450", VA = "0x3AA5450", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x3AA55E8", Offset = "0x3AA55E8", VA = "0x3AA55E8")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19787E8", Offset = "0x19787E8")]
		public float weight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1978820", Offset = "0x1978820")]
		public float offset;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x3AA8DC0", Offset = "0x3AA8DC0", VA = "0x3AA8DC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x3AA8E94", Offset = "0x3AA8E94", VA = "0x3AA8E94")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x3AA8F80", Offset = "0x3AA8F80", VA = "0x3AA8F80")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x3AA93C8", Offset = "0x3AA93C8", VA = "0x3AA93C8")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x3AA9400", Offset = "0x3AA9400", VA = "0x3AA9400")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x3AA94F8", Offset = "0x3AA94F8", VA = "0x3AA94F8")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Settings
		{
			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D318", Offset = "0x197D318")]
			public float scaleMlp;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D350", Offset = "0x197D350")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D388", Offset = "0x197D388")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D3C0", Offset = "0x197D3C0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D3F8", Offset = "0x197D3F8")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D430", Offset = "0x197D430")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D468", Offset = "0x197D468")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x197D4A0", Offset = "0x197D4A0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D4A0", Offset = "0x197D4A0")]
			public Vector3 headOffset;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D4F0", Offset = "0x197D4F0")]
			public Vector3 handOffset;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D528", Offset = "0x197D528")]
			public float footForwardOffset;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D560", Offset = "0x197D560")]
			public float footInwardOffset;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x197D598", Offset = "0x197D598")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197D598", Offset = "0x197D598")]
			public float footHeadingOffset;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197D5F4", Offset = "0x197D5F4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x197D60C", Offset = "0x197D60C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x4BEC750", Offset = "0x4BEC750", VA = "0x4BEC750")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000F6")]
			public class Target
			{
				[Token(Token = "0x400068C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400068D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400068E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x600076C")]
				[Address(RVA = "0x4BEA2E8", Offset = "0x4BEA2E8", VA = "0x4BEA2E8")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600076D")]
				[Address(RVA = "0x4BEAE44", Offset = "0x4BEAE44", VA = "0x4BEAE44")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x4BE978C", Offset = "0x4BE978C", VA = "0x4BE978C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4BE82EC", Offset = "0x4BE82EC", VA = "0x4BE82EC")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4BE8304", Offset = "0x4BE8304", VA = "0x4BE8304")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x4BE849C", Offset = "0x4BE849C", VA = "0x4BE849C")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4BE8350", Offset = "0x4BE8350", VA = "0x4BE8350")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x4BE84B4", Offset = "0x4BE84B4", VA = "0x4BE84B4")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x4BE9904", Offset = "0x4BE9904", VA = "0x4BE9904")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x4BEA3AC", Offset = "0x4BEA3AC", VA = "0x4BEA3AC")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4BEAEA4", Offset = "0x4BEAEA4", VA = "0x4BEAEA4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x4BEB260", Offset = "0x4BEB260", VA = "0x4BEB260")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x4BEB460", Offset = "0x4BEB460", VA = "0x4BEB460")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x4BEBB5C", Offset = "0x4BEBB5C", VA = "0x4BEBB5C")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x4BEB928", Offset = "0x4BEB928", VA = "0x4BEB928")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x4BEBE2C", Offset = "0x4BEBE2C", VA = "0x4BEBE2C")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x4BEC128", Offset = "0x4BEC128", VA = "0x4BEC128")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x4BEC300", Offset = "0x4BEC300", VA = "0x4BEC300")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000085")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x4BEC828", Offset = "0x4BEC828", VA = "0x4BEC828")]
		private void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x4BEC880", Offset = "0x4BEC880", VA = "0x4BEC880")]
		private void Update()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x4BEC8B4", Offset = "0x4BEC8B4", VA = "0x4BEC8B4")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x4BECA3C", Offset = "0x4BECA3C", VA = "0x4BECA3C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978858", Offset = "0x1978858")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000070")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x4BECA54", Offset = "0x4BECA54", VA = "0x4BECA54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FA64", Offset = "0x197FA64")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x4BECA60", Offset = "0x4BECA60", VA = "0x4BECA60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FA74", Offset = "0x197FA74")]
			private set
			{
			}
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x4BECA6C", Offset = "0x4BECA6C", VA = "0x4BECA6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x4BEA0C4", Offset = "0x4BEA0C4", VA = "0x4BEA0C4")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x4BEB0F0", Offset = "0x4BEB0F0", VA = "0x4BEB0F0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x4BECB44", Offset = "0x4BECB44", VA = "0x4BECB44")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x4BECFE8", Offset = "0x4BECFE8", VA = "0x4BECFE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x4BED0E0", Offset = "0x4BED0E0", VA = "0x4BED0E0")]
		public VRIKRootController()
		{
		}
	}
}
namespace ImaginationOverflow.UniversalDeepLink.Storage
{
	[Token(Token = "0x2000087")]
	public static class Json
	{
		[Token(Token = "0x20000E4")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x20000F7")]
			private enum TOKEN
			{
				[Token(Token = "0x4000690")]
				NONE,
				[Token(Token = "0x4000691")]
				CURLY_OPEN,
				[Token(Token = "0x4000692")]
				CURLY_CLOSE,
				[Token(Token = "0x4000693")]
				SQUARED_OPEN,
				[Token(Token = "0x4000694")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000695")]
				COLON,
				[Token(Token = "0x4000696")]
				COMMA,
				[Token(Token = "0x4000697")]
				STRING,
				[Token(Token = "0x4000698")]
				NUMBER,
				[Token(Token = "0x4000699")]
				TRUE,
				[Token(Token = "0x400069A")]
				FALSE,
				[Token(Token = "0x400069B")]
				NULL
			}

			[Token(Token = "0x4000653")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4000654")]
			private const string HEX_DIGIT = "0123456789ABCDEFabcdef";

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x170000D2")]
			private char PeekChar
			{
				[Token(Token = "0x600073E")]
				[Address(RVA = "0x366BA94", Offset = "0x366BA94", VA = "0x366BA94")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000D3")]
			private char NextChar
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0x366B89C", Offset = "0x366B89C", VA = "0x366B89C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000D4")]
			private string NextWord
			{
				[Token(Token = "0x6000740")]
				[Address(RVA = "0x366B924", Offset = "0x366B924", VA = "0x366B924")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000741")]
				[Address(RVA = "0x366B108", Offset = "0x366B108", VA = "0x366B108")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x366ADE4", Offset = "0x366ADE4", VA = "0x366ADE4")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x366AE84", Offset = "0x366AE84", VA = "0x366AE84")]
			public static bool IsHexDigit(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x366AEEC", Offset = "0x366AEEC", VA = "0x366AEEC")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x366AC38", Offset = "0x366AC38", VA = "0x366AC38")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x366AF90", Offset = "0x366AF90", VA = "0x366AF90", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x366AFC4", Offset = "0x366AFC4", VA = "0x366AFC4")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x366B638", Offset = "0x366B638", VA = "0x366B638")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x366AF68", Offset = "0x366AF68", VA = "0x366AF68")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x366B55C", Offset = "0x366B55C", VA = "0x366B55C")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x366B2B8", Offset = "0x366B2B8", VA = "0x366B2B8")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x366B71C", Offset = "0x366B71C", VA = "0x366B71C")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x366B9E0", Offset = "0x366B9E0", VA = "0x366B9E0")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x20000E5")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x366BB1C", Offset = "0x366BB1C", VA = "0x366BB1C")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x366AD68", Offset = "0x366AD68", VA = "0x366AD68")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x366BB88", Offset = "0x366BB88", VA = "0x366BB88")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x366C128", Offset = "0x366C128", VA = "0x366C128")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x366BF84", Offset = "0x366BF84", VA = "0x366BF84")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x366BD24", Offset = "0x366BD24", VA = "0x366BD24")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x366C510", Offset = "0x366C510", VA = "0x366C510")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x366AC2C", Offset = "0x366AC2C", VA = "0x366AC2C")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x366AD64", Offset = "0x366AD64", VA = "0x366AD64")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace ImaginationOverflow.UniversalDeepLinking
{
	[Serializable]
	[Token(Token = "0x2000088")]
	public enum SupportedPlatforms
	{
		[Token(Token = "0x40003D1")]
		Android,
		[Token(Token = "0x40003D2")]
		iOS,
		[Token(Token = "0x40003D3")]
		UWP,
		[Token(Token = "0x40003D4")]
		Windows,
		[Token(Token = "0x40003D5")]
		OSX,
		[Token(Token = "0x40003D6")]
		Linux,
		[Token(Token = "0x40003D7")]
		tvOS
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class PlatformLinkingConfiguration
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<LinkInformation> _domainProtocols;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<LinkInformation> _deepLinkingProtocols;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _initialized;

		[Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x366ED00", Offset = "0x366ED00", VA = "0x366ED00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x366ED08", Offset = "0x366ED08", VA = "0x366ED08")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public List<LinkInformation> DeepLinkingProtocols
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x366ED14", Offset = "0x366ED14", VA = "0x366ED14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x366ED1C", Offset = "0x366ED1C", VA = "0x366ED1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public List<LinkInformation> DomainProtocols
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x366ED24", Offset = "0x366ED24", VA = "0x366ED24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x366ED2C", Offset = "0x366ED2C", VA = "0x366ED2C")]
			set
			{
			}
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x366CB90", Offset = "0x366CB90", VA = "0x366CB90")]
		public PlatformLinkingConfiguration(bool init = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class AppLinkingConfiguration
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974BF0", Offset = "0x1974BF0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<PlatformLinkingConfiguration, List<LinkInformation>> <>9__21_0;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<PlatformLinkingConfiguration, List<LinkInformation>> <>9__22_0;

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x366D14C", Offset = "0x366D14C", VA = "0x366D14C")]
			public <>c()
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x366D154", Offset = "0x366D154", VA = "0x366D154")]
			internal List<LinkInformation> <GetPlatformDeepLinkingProtocols>b__21_0(PlatformLinkingConfiguration c)
			{
				return null;
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x366D16C", Offset = "0x366D16C", VA = "0x366D16C")]
			internal List<LinkInformation> <GetPlatformDomainProtocols>b__22_0(PlatformLinkingConfiguration c)
			{
				return null;
			}
		}

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _steamId;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _displayName;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlatformLinkingConfiguration _globalConfiguration;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlatformLinkingConfiguration[] _customDeepLinkingProtocols;

		[Token(Token = "0x17000074")]
		public string SteamId
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x366C774", Offset = "0x366C774", VA = "0x366C774")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x366C77C", Offset = "0x366C77C", VA = "0x366C77C")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public List<LinkInformation> DeepLinkingProtocols
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x366C784", Offset = "0x366C784", VA = "0x366C784")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x366C7A0", Offset = "0x366C7A0", VA = "0x366C7A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public List<LinkInformation> DomainProtocols
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x366C7BC", Offset = "0x366C7BC", VA = "0x366C7BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x366C7D8", Offset = "0x366C7D8", VA = "0x366C7D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public PlatformLinkingConfiguration[] CustomDeepLinkingProtocols
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x366C7F4", Offset = "0x366C7F4", VA = "0x366C7F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x366C7FC", Offset = "0x366C7FC", VA = "0x366C7FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public string DisplayName
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x366C9F0", Offset = "0x366C9F0", VA = "0x366C9F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x366C9F8", Offset = "0x366C9F8", VA = "0x366C9F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x366CA00", Offset = "0x366CA00", VA = "0x366CA00")]
		public AppLinkingConfiguration()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x366CC30", Offset = "0x366CC30", VA = "0x366CC30")]
		internal void EnsureAllPlats()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x366CC58", Offset = "0x366CC58", VA = "0x366CC58")]
		public List<LinkInformation> GetPlatformDeepLinkingProtocols(SupportedPlatforms plat, bool includeDefault = false)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x366CE28", Offset = "0x366CE28", VA = "0x366CE28")]
		public List<LinkInformation> GetPlatformDomainProtocols(SupportedPlatforms plat, bool includeDefault = false)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x366CD60", Offset = "0x366CD60", VA = "0x366CD60")]
		private List<LinkInformation> GetCustomOrDefault(SupportedPlatforms plat, Func<PlatformLinkingConfiguration, List<LinkInformation>> func, bool includeDefault, List<LinkInformation> global)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x366CF30", Offset = "0x366CF30", VA = "0x366CF30")]
		public List<LinkInformation> GetCustomDeepLinkingProtocols(SupportedPlatforms value)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x366CF74", Offset = "0x366CF74", VA = "0x366CF74")]
		public List<LinkInformation> GetCustomDomainAssociation(SupportedPlatforms value)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x366CFB8", Offset = "0x366CFB8", VA = "0x366CFB8")]
		public void ActivatePlatformOverride(SupportedPlatforms value)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x366D000", Offset = "0x366D000", VA = "0x366D000")]
		public void DeactivatePlatformOverride(SupportedPlatforms value)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x366C824", Offset = "0x366C824", VA = "0x366C824")]
		private PlatformLinkingConfiguration[] EnsureAllPlats(PlatformLinkingConfiguration[] value)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public sealed class DeepLinkManager
	{
		[Token(Token = "0x20000E7")]
		private class UrlEncodingParser : Dictionary<string, string>
		{
			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197D624", Offset = "0x197D624")]
			private string <Url>k__BackingField;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197D634", Offset = "0x197D634")]
			private string <Query>k__BackingField;

			[Token(Token = "0x170000D6")]
			private string Url
			{
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x366E2DC", Offset = "0x366E2DC", VA = "0x366E2DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19801C8", Offset = "0x19801C8")]
				get
				{
					return null;
				}
				[Token(Token = "0x600074E")]
				[Address(RVA = "0x366E2E4", Offset = "0x366E2E4", VA = "0x366E2E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19801D8", Offset = "0x19801D8")]
				set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			public string Query
			{
				[Token(Token = "0x600074F")]
				[Address(RVA = "0x366E2EC", Offset = "0x366E2EC", VA = "0x366E2EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19801E8", Offset = "0x19801E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000750")]
				[Address(RVA = "0x366E2F4", Offset = "0x366E2F4", VA = "0x366E2F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19801F8", Offset = "0x19801F8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x366E140", Offset = "0x366E140", VA = "0x366E140")]
			public UrlEncodingParser([Optional] string queryStringOrUrl)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x366E560", Offset = "0x366E560", VA = "0x366E560")]
			public void SetValues(string key, IEnumerable<string> values)
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x366E2FC", Offset = "0x366E2FC", VA = "0x366E2FC")]
			public Dictionary<string, string> Parse(string query)
			{
				return null;
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x366E7D4", Offset = "0x366E7D4", VA = "0x366E7D4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19788D8", Offset = "0x19788D8")]
		private static DeepLinkManager <Instance>k__BackingField;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19788E8", Offset = "0x19788E8")]
		private bool <IsSteamBuild>k__BackingField;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ILinkProvider _currProvider;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _go;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _storedActivation;

		[Token(Token = "0x17000079")]
		public static DeepLinkManager Instance
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x366D184", Offset = "0x366D184", VA = "0x366D184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FA84", Offset = "0x197FA84")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x366D1EC", Offset = "0x366D1EC", VA = "0x366D1EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FA94", Offset = "0x197FA94")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool IsSteamBuild
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x366D258", Offset = "0x366D258", VA = "0x366D258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FAA4", Offset = "0x197FAA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x366D260", Offset = "0x366D260", VA = "0x366D260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FAB4", Offset = "0x197FAB4")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event LinkActivationHandler LinkActivated
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x366A990", Offset = "0x366A990", VA = "0x366A990")]
			add
			{
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x366D750", Offset = "0x366D750", VA = "0x366D750")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		private event LinkActivationHandler _activated
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x366D31C", Offset = "0x366D31C", VA = "0x366D31C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FAC4", Offset = "0x197FAC4")]
			add
			{
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x366D754", Offset = "0x366D754", VA = "0x366D754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FAD4", Offset = "0x197FAD4")]
			remove
			{
			}
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x366D26C", Offset = "0x366D26C", VA = "0x366D26C")]
		static DeepLinkManager()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x366D314", Offset = "0x366D314", VA = "0x366D314")]
		private DeepLinkManager()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x366D7F8", Offset = "0x366D7F8", VA = "0x366D7F8")]
		public void ManuallyTriggerDeepLink(string args)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x366D3C0", Offset = "0x366D3C0", VA = "0x366D3C0")]
		private void RegisterIfNecessary()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x366D91C", Offset = "0x366D91C", VA = "0x366D91C")]
		private void CreatePauseGameObject()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x366D824", Offset = "0x366D824", VA = "0x366D824")]
		private void _currProvider_LinkReceived(string s)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x366DC58", Offset = "0x366DC58", VA = "0x366DC58")]
		private void StoreActivation(string s)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x366DB18", Offset = "0x366DB18", VA = "0x366DB18")]
		private bool OnActivated(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x366DC60", Offset = "0x366DC60", VA = "0x366DC60")]
		private LinkActivation CreateLinkActivation(string s)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x366E220", Offset = "0x366E220", VA = "0x366E220")]
		internal void GameCameFromPause()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public delegate void LinkActivationHandler(LinkActivation s);
	[Token(Token = "0x200008D")]
	public delegate void UniversalLinkCallback(string link);
	[Token(Token = "0x200008E")]
	public interface ILinkProvider
	{
		[Token(Token = "0x14000003")]
		event Action<string> LinkReceived;

		[Token(Token = "0x6000555")]
		bool Initialize();

		[Token(Token = "0x6000558")]
		void PollInfoAfterPause();
	}
	[Token(Token = "0x200008F")]
	public class LinkActivation
	{
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978908", Offset = "0x1978908")]
		private string <Uri>k__BackingField;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978918", Offset = "0x1978918")]
		private string <RawQueryString>k__BackingField;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1978928", Offset = "0x1978928")]
		private Dictionary<string, string> <QueryString>k__BackingField;

		[Token(Token = "0x1700007B")]
		public string Uri
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x366EBE8", Offset = "0x366EBE8", VA = "0x366EBE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FB04", Offset = "0x197FB04")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x366EBF0", Offset = "0x366EBF0", VA = "0x366EBF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FB14", Offset = "0x197FB14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public string RawQueryString
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x366EBF8", Offset = "0x366EBF8", VA = "0x366EBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FB24", Offset = "0x197FB24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x366EC00", Offset = "0x366EC00", VA = "0x366EC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FB34", Offset = "0x197FB34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Dictionary<string, string> QueryString
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x366EC08", Offset = "0x366EC08", VA = "0x366EC08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FB44", Offset = "0x197FB44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x366EC10", Offset = "0x366EC10", VA = "0x366EC10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FB54", Offset = "0x197FB54")]
			private set
			{
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x366E1E0", Offset = "0x366E1E0", VA = "0x366E1E0")]
		public LinkActivation(string uri, string rawQueryString, Dictionary<string, string> queryStringParams)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x366EC18", Offset = "0x366EC18", VA = "0x366EC18", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class LinkInformation
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _scheme;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _host;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _path;

		[Token(Token = "0x1700007E")]
		public string Scheme
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x366EC50", Offset = "0x366EC50", VA = "0x366EC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x366EC58", Offset = "0x366EC58", VA = "0x366EC58")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public string Host
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x366EC60", Offset = "0x366EC60", VA = "0x366EC60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x366EC68", Offset = "0x366EC68", VA = "0x366EC68")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public string Path
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x366EC70", Offset = "0x366EC70", VA = "0x366EC70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x366EC78", Offset = "0x366EC78", VA = "0x366EC78")]
			set
			{
			}
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x366EC80", Offset = "0x366EC80", VA = "0x366EC80")]
		public LinkInformation()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class LinkProviderFactory
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string DeferredExePath;

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x366D8C0", Offset = "0x366D8C0", VA = "0x366D8C0")]
		public ILinkProvider GetProvider(bool isSteamBuild)
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x366D8B8", Offset = "0x366D8B8", VA = "0x366D8B8")]
		public LinkProviderFactory()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public static class ProviderHelpers
	{
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x366ED34", Offset = "0x366ED34", VA = "0x366ED34")]
		public static string GetExecutingPath()
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	public class UniversalDeeplinkingRuntimeScript : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1974C00", Offset = "0x1974C00")]
		private sealed class <CallDeepLinkManagerAfterDelay>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UniversalDeeplinkingRuntimeScript <>4__this;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000758")]
				[Address(RVA = "0x36707B4", Offset = "0x36707B4", VA = "0x36707B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075A")]
				[Address(RVA = "0x367081C", Offset = "0x367081C", VA = "0x367081C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x3670510", Offset = "0x3670510", VA = "0x3670510")]
			[DebuggerHidden]
			public <CallDeepLinkManagerAfterDelay>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x3670544", Offset = "0x3670544", VA = "0x3670544", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x3670548", Offset = "0x3670548", VA = "0x3670548", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x36707BC", Offset = "0x36707BC", VA = "0x36707BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _onJob;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x36703BC", Offset = "0x36703BC", VA = "0x36703BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x3670438", Offset = "0x3670438", VA = "0x3670438")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x36704DC", Offset = "0x36704DC", VA = "0x36704DC")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x367046C", Offset = "0x367046C", VA = "0x367046C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x197FB64", Offset = "0x197FB64")]
		public IEnumerator CallDeepLinkManagerAfterDelay()
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x367053C", Offset = "0x367053C", VA = "0x367053C")]
		public UniversalDeeplinkingRuntimeScript()
		{
		}
	}
}
namespace ImaginationOverflow.UniversalDeepLinking.Storage
{
	[Token(Token = "0x2000094")]
	public class ConfigurationStorage
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] SaveFolders;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string SaveFile;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _fileLocation;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x366FD18", Offset = "0x366FD18", VA = "0x366FD18")]
		public static void Save(AppLinkingConfiguration config)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x36700CC", Offset = "0x36700CC", VA = "0x36700CC")]
		public static AppLinkingConfiguration Load()
		{
			return null;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x366FF98", Offset = "0x366FF98", VA = "0x366FF98")]
		private static void EnsureDirectories()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x366FDD4", Offset = "0x366FDD4", VA = "0x366FDD4")]
		private static string GetConfigurationLocation()
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x36701E8", Offset = "0x36701E8", VA = "0x36701E8")]
		public static string CombinePaths(params string[] paths)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x36702B0", Offset = "0x36702B0", VA = "0x36702B0")]
		public ConfigurationStorage()
		{
		}
	}
}
namespace ImaginationOverflow.UniversalDeepLinking.Providers
{
	[Token(Token = "0x2000095")]
	public class AndroidLinkProvider : ILinkProvider
	{
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AndroidJavaClass _unityPlayer;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AndroidJavaObject _currentActivity;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AndroidJavaObject _deepLinkIntent;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _deepLink;

		[Token(Token = "0x14000004")]
		private event Action<string> _linkReceived
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x366F784", Offset = "0x366F784", VA = "0x366F784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FBC8", Offset = "0x197FBC8")]
			add
			{
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x366F828", Offset = "0x366F828", VA = "0x366F828")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FBD8", Offset = "0x197FBD8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<string> LinkReceived
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x366F8CC", Offset = "0x366F8CC", VA = "0x366F8CC", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x366F90C", Offset = "0x366F90C", VA = "0x366F90C", Slot = "6")]
			remove
			{
			}
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x366EF68", Offset = "0x366EF68", VA = "0x366EF68", Slot = "4")]
		public bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x366F014", Offset = "0x366F014", VA = "0x366F014")]
		private void VerifyIfHasOpenByLink()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x366F448", Offset = "0x366F448", VA = "0x366F448")]
		public static string safeCallStringMethod(AndroidJavaObject javaObject, string methodName, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x366F910", Offset = "0x366F910", VA = "0x366F910", Slot = "7")]
		public void PollInfoAfterPause()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x366F710", Offset = "0x366F710", VA = "0x366F710")]
		private void OnLinkReceived(string lastLink)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x366F5BC", Offset = "0x366F5BC", VA = "0x366F5BC")]
		private static bool IsValidUri(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x366D8B0", Offset = "0x366D8B0", VA = "0x366D8B0")]
		public AndroidLinkProvider()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class DummyLinkProvider : ILinkProvider
	{
		[Token(Token = "0x14000006")]
		public event Action<string> LinkReceived
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x366F988", Offset = "0x366F988", VA = "0x366F988", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FBE8", Offset = "0x197FBE8")]
			add
			{
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x366FA2C", Offset = "0x366FA2C", VA = "0x366FA2C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FBF8", Offset = "0x197FBF8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x366F914", Offset = "0x366F914", VA = "0x366F914", Slot = "4")]
		public bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x366FAD0", Offset = "0x366FAD0", VA = "0x366FAD0", Slot = "7")]
		public void PollInfoAfterPause()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x366FAD4", Offset = "0x366FAD4", VA = "0x366FAD4", Slot = "8")]
		protected virtual void OnLinkReceived(string obj)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x366ECF8", Offset = "0x366ECF8", VA = "0x366ECF8")]
		public DummyLinkProvider()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class EditorLinkProvider : ILinkProvider
	{
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static EditorLinkProvider _instance;

		[Token(Token = "0x14000007")]
		public event Action<string> LinkReceived
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x366FB50", Offset = "0x366FB50", VA = "0x366FB50", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC08", Offset = "0x197FC08")]
			add
			{
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x366FBF4", Offset = "0x366FBF4", VA = "0x366FBF4", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197FC18", Offset = "0x197FC18")]
			remove
			{
			}
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x366D850", Offset = "0x366D850", VA = "0x366D850")]
		public EditorLinkProvider()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x366FB48", Offset = "0x366FB48", VA = "0x366FB48", Slot = "4")]
		public bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x366FC98", Offset = "0x366FC98", VA = "0x366FC98", Slot = "7")]
		public void PollInfoAfterPause()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x366FC9C", Offset = "0x366FC9C", VA = "0x366FC9C")]
		public static void SimulateLink(string link)
		{
		}
	}
}
