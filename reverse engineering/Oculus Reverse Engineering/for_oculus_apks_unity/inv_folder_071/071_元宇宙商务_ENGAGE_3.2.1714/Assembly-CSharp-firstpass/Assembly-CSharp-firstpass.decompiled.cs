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
	[Address(RVA = "0x361BE60", Offset = "0x361BE60", VA = "0x361BE60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x361BF58", Offset = "0x361BF58", VA = "0x361BF58")]
	private void SetupUi()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x361BFAC", Offset = "0x361BFAC", VA = "0x361BFAC")]
	private void Instance_LinkActivated(LinkActivation s)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x361C168", Offset = "0x361C168", VA = "0x361C168")]
	private void UpdateContentSize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x361C21C", Offset = "0x361C21C", VA = "0x361C21C")]
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
	[Address(RVA = "0x36221F0", Offset = "0x36221F0", VA = "0x36221F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3622294", Offset = "0x3622294", VA = "0x3622294")]
	public void Open()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x36222A0", Offset = "0x36222A0", VA = "0x36222A0")]
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
		[Address(RVA = "0x4B9FEA4", Offset = "0x4B9FEA4", VA = "0x4B9FEA4")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4BA0024", Offset = "0x4BA0024", VA = "0x4BA0024")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4BA00D8", Offset = "0x4BA00D8", VA = "0x4BA00D8")]
		public void Update()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4BA015C", Offset = "0x4BA015C", VA = "0x4BA015C")]
		public WaterBase()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958944", Offset = "0x1958944")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958944", Offset = "0x1958944")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959430", Offset = "0x1959430")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959430", Offset = "0x1959430")]
		public int frameRate;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959488", Offset = "0x1959488")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959488", Offset = "0x1959488")]
		public float keyReductionError;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19594E0", Offset = "0x19594E0")]
		public Mode mode;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959518", Offset = "0x1959518")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959550", Offset = "0x1959550")]
		public string[] animationStates;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959588", Offset = "0x1959588")]
		public bool loop;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19595C0", Offset = "0x19595C0")]
		public string saveToFolder;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19595F8", Offset = "0x19595F8")]
		public string appendName;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959630", Offset = "0x1959630")]
		public string saveName;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959668", Offset = "0x1959668")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959678", Offset = "0x1959678")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19596A8", Offset = "0x19596A8")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x36233D8", Offset = "0x36233D8", VA = "0x36233D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196236C", Offset = "0x196236C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x36233E0", Offset = "0x36233E0", VA = "0x36233E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196237C", Offset = "0x196237C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x36233EC", Offset = "0x36233EC", VA = "0x36233EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196238C", Offset = "0x196238C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x36233F4", Offset = "0x36233F4", VA = "0x36233F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196239C", Offset = "0x196239C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x36233FC", Offset = "0x36233FC", VA = "0x36233FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19623AC", Offset = "0x19623AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x3623404", Offset = "0x3623404", VA = "0x3623404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19623BC", Offset = "0x19623BC")]
			private set
			{
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x36232A8", Offset = "0x36232A8", VA = "0x36232A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196228C", Offset = "0x196228C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x36232F4", Offset = "0x36232F4", VA = "0x36232F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19622C4", Offset = "0x19622C4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3623340", Offset = "0x3623340", VA = "0x3623340")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19622FC", Offset = "0x19622FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x362338C", Offset = "0x362338C", VA = "0x362338C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962334", Offset = "0x1962334")]
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
		[Address(RVA = "0x362340C", Offset = "0x362340C", VA = "0x362340C")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3623410", Offset = "0x3623410", VA = "0x3623410")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3623414", Offset = "0x3623414", VA = "0x3623414")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3623418", Offset = "0x3623418", VA = "0x3623418")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19596B8", Offset = "0x19596B8")]
		public bool markAsLegacy;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19596F0", Offset = "0x19596F0")]
		public Transform root;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959728", Offset = "0x1959728")]
		public Transform rootNode;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959760", Offset = "0x1959760")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959798", Offset = "0x1959798")]
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
		[Address(RVA = "0x4B979A0", Offset = "0x4B979A0", VA = "0x4B979A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4B97D6C", Offset = "0x4B97D6C", VA = "0x4B97D6C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4B97D74", Offset = "0x4B97D74", VA = "0x4B97D74", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4B97E84", Offset = "0x4B97E84", VA = "0x4B97E84", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4B97F00", Offset = "0x4B97F00", VA = "0x4B97F00", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4B97F7C", Offset = "0x4B97F7C", VA = "0x4B97F7C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4B97BBC", Offset = "0x4B97BBC", VA = "0x4B97BBC")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4B97C94", Offset = "0x4B97C94", VA = "0x4B97C94")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4B97FF8", Offset = "0x4B97FF8", VA = "0x4B97FF8")]
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
		[Address(RVA = "0x4B9D598", Offset = "0x4B9D598", VA = "0x4B9D598")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AvatarUtility
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x36222A8", Offset = "0x36222A8", VA = "0x36222A8")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x36224BC", Offset = "0x36224BC", VA = "0x36224BC")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x362249C", Offset = "0x362249C", VA = "0x362249C")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3622B3C", Offset = "0x3622B3C", VA = "0x3622B3C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x362468C", Offset = "0x362468C", VA = "0x362468C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3625B60", Offset = "0x3625B60", VA = "0x3625B60")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x36240A0", Offset = "0x36240A0", VA = "0x36240A0")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x36246D4", Offset = "0x36246D4", VA = "0x36246D4")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3623BD8", Offset = "0x3623BD8", VA = "0x3623BD8")]
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
		[Address(RVA = "0x36234D8", Offset = "0x36234D8", VA = "0x36234D8")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3623724", Offset = "0x3623724", VA = "0x3623724")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x36235F8", Offset = "0x36235F8", VA = "0x36235F8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x362385C", Offset = "0x362385C", VA = "0x362385C")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3623E34", Offset = "0x3623E34", VA = "0x3623E34")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3623F30", Offset = "0x3623F30", VA = "0x3623F30")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x362402C", Offset = "0x362402C", VA = "0x362402C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3623FA4", Offset = "0x3623FA4", VA = "0x3623FA4")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x36242EC", Offset = "0x36242EC", VA = "0x36242EC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x36243A0", Offset = "0x36243A0", VA = "0x36243A0")]
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
		[Address(RVA = "0x36246D8", Offset = "0x36246D8", VA = "0x36246D8")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3624748", Offset = "0x3624748", VA = "0x3624748")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3624E30", Offset = "0x3624E30", VA = "0x3624E30")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x3624EE4", Offset = "0x3624EE4", VA = "0x3624EE4")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3624DD0", Offset = "0x3624DD0", VA = "0x3624DD0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3624FC8", Offset = "0x3624FC8", VA = "0x3624FC8")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3625010", Offset = "0x3625010", VA = "0x3625010")]
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
		[Address(RVA = "0x3625018", Offset = "0x3625018", VA = "0x3625018")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x36251AC", Offset = "0x36251AC", VA = "0x36251AC")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x36251C0", Offset = "0x36251C0", VA = "0x36251C0")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3625450", Offset = "0x3625450", VA = "0x3625450")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x36250B4", Offset = "0x36250B4", VA = "0x36250B4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x362569C", Offset = "0x362569C", VA = "0x362569C")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x3625710", Offset = "0x3625710", VA = "0x3625710")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x362595C", Offset = "0x362595C", VA = "0x362595C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19597D0", Offset = "0x19597D0")]
		public bool bakeHandIK;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959808", Offset = "0x1959808")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959808", Offset = "0x1959808")]
		public float IKKeyReductionError;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959860", Offset = "0x1959860")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959860", Offset = "0x1959860")]
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
		[Address(RVA = "0x4B98F30", Offset = "0x4B98F30", VA = "0x4B98F30")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4B9935C", Offset = "0x4B9935C", VA = "0x4B9935C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4B99378", Offset = "0x4B99378", VA = "0x4B99378", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4B99498", Offset = "0x4B99498", VA = "0x4B99498", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4B99574", Offset = "0x4B99574", VA = "0x4B99574", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4B99744", Offset = "0x4B99744", VA = "0x4B99744", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4B99ADC", Offset = "0x4B99ADC", VA = "0x4B99ADC")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4B99BB8", Offset = "0x4B99BB8", VA = "0x4B99BB8")]
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
		[Address(RVA = "0x3622B44", Offset = "0x3622B44", VA = "0x3622B44")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x3622BFC", Offset = "0x3622BFC", VA = "0x3622BFC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x3622CA8", Offset = "0x3622CA8", VA = "0x3622CA8")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x3622E8C", Offset = "0x3622E8C", VA = "0x3622E8C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x3622DC4", Offset = "0x3622DC4", VA = "0x3622DC4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x3622FA8", Offset = "0x3622FA8", VA = "0x3622FA8")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x3622FF0", Offset = "0x3622FF0", VA = "0x3622FF0")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x36232A0", Offset = "0x36232A0", VA = "0x36232A0")]
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
			[Address(RVA = "0x3626208", Offset = "0x3626208", VA = "0x3626208")]
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
			[Address(RVA = "0x3625F94", Offset = "0x3625F94", VA = "0x3625F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x3626280", Offset = "0x3626280", VA = "0x3626280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x3625F48", Offset = "0x3625F48", VA = "0x3625F48")]
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
		[Address(RVA = "0x36264F4", Offset = "0x36264F4", VA = "0x36264F4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x36267F4", Offset = "0x36267F4", VA = "0x36267F4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x3626A44", Offset = "0x3626A44", VA = "0x3626A44")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3626AC8", Offset = "0x3626AC8", VA = "0x3626AC8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3626B74", Offset = "0x3626B74", VA = "0x3626B74")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x36266A4", Offset = "0x36266A4", VA = "0x36266A4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x36269A4", Offset = "0x36269A4", VA = "0x36269A4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x36273B4", Offset = "0x36273B4", VA = "0x36273B4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x36271CC", Offset = "0x36271CC", VA = "0x36271CC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x36272C0", Offset = "0x36272C0", VA = "0x36272C0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3626D94", Offset = "0x3626D94", VA = "0x3626D94")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x3626E48", Offset = "0x3626E48", VA = "0x3626E48")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x3626EFC", Offset = "0x3626EFC", VA = "0x3626EFC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x3626FB0", Offset = "0x3626FB0", VA = "0x3626FB0")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x3627064", Offset = "0x3627064", VA = "0x3627064")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3627118", Offset = "0x3627118", VA = "0x3627118")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x36275C8", Offset = "0x36275C8", VA = "0x36275C8")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3626CA8", Offset = "0x3626CA8", VA = "0x3626CA8")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3627538", Offset = "0x3627538", VA = "0x3627538")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3627638", Offset = "0x3627638", VA = "0x3627638")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x3627710", Offset = "0x3627710", VA = "0x3627710")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x36274BC", Offset = "0x36274BC", VA = "0x36274BC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x3627444", Offset = "0x3627444", VA = "0x3627444")]
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
				[Address(RVA = "0x362C6A0", Offset = "0x362C6A0", VA = "0x362C6A0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x362C68C", Offset = "0x362C68C", VA = "0x362C68C")]
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
			[Address(RVA = "0x3629284", Offset = "0x3629284", VA = "0x3629284", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public bool isEmpty
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x3629670", Offset = "0x3629670", VA = "0x3629670")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x3629680", Offset = "0x3629680", VA = "0x3629680", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x3629AAC", Offset = "0x3629AAC", VA = "0x3629AAC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x3629EE4", Offset = "0x3629EE4", VA = "0x3629EE4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x362A4F4", Offset = "0x362A4F4", VA = "0x362A4F4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x362A130", Offset = "0x362A130", VA = "0x362A130")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x362ACA4", Offset = "0x362ACA4", VA = "0x362ACA4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x362AD98", Offset = "0x362AD98", VA = "0x362AD98")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x362B2F0", Offset = "0x362B2F0", VA = "0x362B2F0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x362B0F4", Offset = "0x362B0F4", VA = "0x362B0F4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x362AF6C", Offset = "0x362AF6C", VA = "0x362AF6C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x362AE38", Offset = "0x362AE38", VA = "0x362AE38")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x362B1F8", Offset = "0x362B1F8", VA = "0x362B1F8")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x362B3EC", Offset = "0x362B3EC", VA = "0x362B3EC")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x362BE8C", Offset = "0x362BE8C", VA = "0x362BE8C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x362B970", Offset = "0x362B970", VA = "0x362B970")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x362C180", Offset = "0x362C180", VA = "0x362C180")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x362BCB0", Offset = "0x362BCB0", VA = "0x362BCB0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x362C188", Offset = "0x362C188", VA = "0x362C188")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x362C190", Offset = "0x362C190", VA = "0x362C190")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x362C350", Offset = "0x362C350", VA = "0x362C350")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x362C568", Offset = "0x362C568", VA = "0x362C568")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x362A0C0", Offset = "0x362A0C0", VA = "0x362A0C0")]
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
		[Address(RVA = "0x362C6A8", Offset = "0x362C6A8", VA = "0x362C6A8")]
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
		[Address(RVA = "0x362C6B0", Offset = "0x362C6B0", VA = "0x362C6B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x362C7F0", Offset = "0x362C7F0", VA = "0x362C7F0")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class Hierarchy
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x4B98060", Offset = "0x4B98060", VA = "0x4B98060")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x4B98260", Offset = "0x4B98260", VA = "0x4B98260")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x4B980F8", Offset = "0x4B980F8", VA = "0x4B980F8")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4B98384", Offset = "0x4B98384", VA = "0x4B98384")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4B984A8", Offset = "0x4B984A8", VA = "0x4B984A8")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4B98750", Offset = "0x4B98750", VA = "0x4B98750")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4B9886C", Offset = "0x4B9886C", VA = "0x4B9886C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x4B989F4", Offset = "0x4B989F4", VA = "0x4B989F4")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x4B98D88", Offset = "0x4B98D88", VA = "0x4B98D88")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x4B98B74", Offset = "0x4B98B74", VA = "0x4B98B74")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4B98F28", Offset = "0x4B98F28", VA = "0x4B98F28")]
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
		[Address(RVA = "0x4B99C6C", Offset = "0x4B99C6C", VA = "0x4B99C6C")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4B99CDC", Offset = "0x4B99CDC", VA = "0x4B99CDC")]
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
		[Address(RVA = "0x4B99D4C", Offset = "0x4B99D4C", VA = "0x4B99D4C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4B9A7B4", Offset = "0x4B9A7B4", VA = "0x4B9A7B4")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4B9A8BC", Offset = "0x4B9A8BC", VA = "0x4B9A8BC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4B9A0B8", Offset = "0x4B9A0B8", VA = "0x4B9A0B8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4B9A0C4", Offset = "0x4B9A0C4", VA = "0x4B9A0C4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x4B9A0E8", Offset = "0x4B9A0E8", VA = "0x4B9A0E8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x4B9A124", Offset = "0x4B9A124", VA = "0x4B9A124")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x4B9A13C", Offset = "0x4B9A13C", VA = "0x4B9A13C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x4B9A150", Offset = "0x4B9A150", VA = "0x4B9A150")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x4B9A164", Offset = "0x4B9A164", VA = "0x4B9A164")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4B9A174", Offset = "0x4B9A174", VA = "0x4B9A174")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x4B9A1BC", Offset = "0x4B9A1BC", VA = "0x4B9A1BC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4B9A1F4", Offset = "0x4B9A1F4", VA = "0x4B9A1F4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4B9A21C", Offset = "0x4B9A21C", VA = "0x4B9A21C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4B9A9B8", Offset = "0x4B9A9B8", VA = "0x4B9A9B8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4B9A250", Offset = "0x4B9A250", VA = "0x4B9A250")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x4B9A278", Offset = "0x4B9A278", VA = "0x4B9A278")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4B9A2A8", Offset = "0x4B9A2A8", VA = "0x4B9A2A8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4B9A2DC", Offset = "0x4B9A2DC", VA = "0x4B9A2DC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4B9A320", Offset = "0x4B9A320", VA = "0x4B9A320")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4B9A384", Offset = "0x4B9A384", VA = "0x4B9A384")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4B9A3E8", Offset = "0x4B9A3E8", VA = "0x4B9A3E8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4B9A43C", Offset = "0x4B9A43C", VA = "0x4B9A43C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4B9A490", Offset = "0x4B9A490", VA = "0x4B9A490")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x4B9A528", Offset = "0x4B9A528", VA = "0x4B9A528")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x4B9A5BC", Offset = "0x4B9A5BC", VA = "0x4B9A5BC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4B9A9EC", Offset = "0x4B9A9EC", VA = "0x4B9A9EC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x4B9A660", Offset = "0x4B9A660", VA = "0x4B9A660")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4B9A744", Offset = "0x4B9A744", VA = "0x4B9A744")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4B9A774", Offset = "0x4B9A774", VA = "0x4B9A774")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4B9AAD4", Offset = "0x4B9AAD4", VA = "0x4B9AAD4")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4B9ABBC", Offset = "0x4B9ABBC", VA = "0x4B9ABBC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4B9AC14", Offset = "0x4B9AC14", VA = "0x4B9AC14")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4B9ACE0", Offset = "0x4B9ACE0", VA = "0x4B9ACE0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4B9AC2C", Offset = "0x4B9AC2C", VA = "0x4B9AC2C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4B9ACF8", Offset = "0x4B9ACF8", VA = "0x4B9ACF8")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4B9AD9C", Offset = "0x4B9AD9C", VA = "0x4B9AD9C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4B9ADC8", Offset = "0x4B9ADC8", VA = "0x4B9ADC8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4B9AE18", Offset = "0x4B9AE18", VA = "0x4B9AE18")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4B9AE84", Offset = "0x4B9AE84", VA = "0x4B9AE84")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4B9AF78", Offset = "0x4B9AF78", VA = "0x4B9AF78")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4B9B050", Offset = "0x4B9B050", VA = "0x4B9B050")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4B9B0B0", Offset = "0x4B9B0B0", VA = "0x4B9B0B0")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x19589B4", Offset = "0x19589B4")]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19598C4", Offset = "0x19598C4")]
		private string <propName>k__BackingField;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19598D4", Offset = "0x19598D4")]
		private object <propValue>k__BackingField;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19598E4", Offset = "0x19598E4")]
		private object <otherPropValue>k__BackingField;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19598F4", Offset = "0x19598F4")]
		private bool <indent>k__BackingField;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959904", Offset = "0x1959904")]
		private ShowIfMode <mode>k__BackingField;

		[Token(Token = "0x1700000A")]
		public string propName
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x4B9CD00", Offset = "0x4B9CD00", VA = "0x4B9CD00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196243C", Offset = "0x196243C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x4B9CD08", Offset = "0x4B9CD08", VA = "0x4B9CD08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196244C", Offset = "0x196244C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public object propValue
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x4B9CD10", Offset = "0x4B9CD10", VA = "0x4B9CD10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196245C", Offset = "0x196245C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x4B9CD18", Offset = "0x4B9CD18", VA = "0x4B9CD18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196246C", Offset = "0x196246C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public object otherPropValue
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x4B9CD20", Offset = "0x4B9CD20", VA = "0x4B9CD20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196247C", Offset = "0x196247C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x4B9CD28", Offset = "0x4B9CD28", VA = "0x4B9CD28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196248C", Offset = "0x196248C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool indent
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x4B9CD30", Offset = "0x4B9CD30", VA = "0x4B9CD30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196249C", Offset = "0x196249C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4B9CD38", Offset = "0x4B9CD38", VA = "0x4B9CD38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19624AC", Offset = "0x19624AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x4B9CD44", Offset = "0x4B9CD44", VA = "0x4B9CD44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19624BC", Offset = "0x19624BC")]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x4B9CD4C", Offset = "0x4B9CD4C", VA = "0x4B9CD4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19624CC", Offset = "0x19624CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4B9CD54", Offset = "0x4B9CD54", VA = "0x4B9CD54")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x19589EC", Offset = "0x19589EC")]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959914", Offset = "0x1959914")]
		private float <min>k__BackingField;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959924", Offset = "0x1959924")]
		private float <max>k__BackingField;

		[Token(Token = "0x1700000F")]
		public float min
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x4B9CF08", Offset = "0x4B9CF08", VA = "0x4B9CF08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19624DC", Offset = "0x19624DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x4B9CF10", Offset = "0x4B9CF10", VA = "0x4B9CF10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19624EC", Offset = "0x19624EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float max
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x4B9CF18", Offset = "0x4B9CF18", VA = "0x4B9CF18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19624FC", Offset = "0x19624FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x4B9CF20", Offset = "0x4B9CF20", VA = "0x4B9CF20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196250C", Offset = "0x196250C")]
			private set
			{
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4B9CF28", Offset = "0x4B9CF28", VA = "0x4B9CF28")]
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
		[Address(RVA = "0x4B9CDB0", Offset = "0x4B9CDB0", VA = "0x4B9CDB0")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x4B9CE58", Offset = "0x4B9CE58", VA = "0x4B9CE58")]
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
		[Address(RVA = "0x4B9AADC", Offset = "0x4B9AADC", VA = "0x4B9AADC")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4B9AB4C", Offset = "0x4B9AB4C", VA = "0x4B9AB4C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public static class QuaTools
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x4B9B0E0", Offset = "0x4B9B0E0", VA = "0x4B9B0E0")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4B9B1E4", Offset = "0x4B9B1E4", VA = "0x4B9B1E4")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4B9B2E4", Offset = "0x4B9B2E4", VA = "0x4B9B2E4")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x4B9B4E0", Offset = "0x4B9B4E0", VA = "0x4B9B4E0")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x4B9B654", Offset = "0x4B9B654", VA = "0x4B9B654")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x4B9B7C0", Offset = "0x4B9B7C0", VA = "0x4B9B7C0")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x4B9BA1C", Offset = "0x4B9BA1C", VA = "0x4B9BA1C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x4B9BB68", Offset = "0x4B9BB68", VA = "0x4B9BB68")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x4B9BCB4", Offset = "0x4B9BCB4", VA = "0x4B9BCB4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x4B9BDC8", Offset = "0x4B9BDC8", VA = "0x4B9BDC8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x4B9BEDC", Offset = "0x4B9BEDC", VA = "0x4B9BEDC")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x4B9C068", Offset = "0x4B9C068", VA = "0x4B9C068")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x4B9C138", Offset = "0x4B9C138", VA = "0x4B9C138")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x4B9C28C", Offset = "0x4B9C28C", VA = "0x4B9C28C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x4B9C510", Offset = "0x4B9C510", VA = "0x4B9C510")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x4B9C724", Offset = "0x4B9C724", VA = "0x4B9C724")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x4B9404C", Offset = "0x4B9404C", VA = "0x4B9404C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x4B9C8A4", Offset = "0x4B9C8A4", VA = "0x4B9C8A4")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4B9C9B4", Offset = "0x4B9C9B4", VA = "0x4B9C9B4")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x4B9CA10", Offset = "0x4B9CA10", VA = "0x4B9CA10")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4B9CBC4", Offset = "0x4B9CBC4", VA = "0x4B9CBC4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959934", Offset = "0x1959934")]
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
			[Address(RVA = "0x4B9D0D0", Offset = "0x4B9D0D0", VA = "0x4B9D0D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		private bool isAnimated
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x4B9D3CC", Offset = "0x4B9D3CC", VA = "0x4B9D3CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4B9CF98", Offset = "0x4B9CF98", VA = "0x4B9CF98")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4B9D030", Offset = "0x4B9D030", VA = "0x4B9D030", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4B9D034", Offset = "0x4B9D034", VA = "0x4B9D034", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4B9D038", Offset = "0x4B9D038", VA = "0x4B9D038", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4B9D03C", Offset = "0x4B9D03C", VA = "0x4B9D03C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4B9D0CC", Offset = "0x4B9D0CC", VA = "0x4B9D0CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4B9D074", Offset = "0x4B9D074", VA = "0x4B9D074")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4B9D380", Offset = "0x4B9D380", VA = "0x4B9D380")]
		private void Update()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4B9D1C0", Offset = "0x4B9D1C0", VA = "0x4B9D1C0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4B9D488", Offset = "0x4B9D488", VA = "0x4B9D488")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4B9D4E4", Offset = "0x4B9D4E4", VA = "0x4B9D4E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4B9D540", Offset = "0x4B9D540", VA = "0x4B9D540")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x4B9D588", Offset = "0x4B9D588", VA = "0x4B9D588")]
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
		[Address(RVA = "0x4B9D608", Offset = "0x4B9D608", VA = "0x4B9D608")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4B9D6C0", Offset = "0x4B9D6C0", VA = "0x4B9D6C0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x4B9D778", Offset = "0x4B9D778", VA = "0x4B9D778")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x4B9D830", Offset = "0x4B9D830", VA = "0x4B9D830")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class V2Tools
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x4B9D838", Offset = "0x4B9D838", VA = "0x4B9D838")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x4B9D868", Offset = "0x4B9D868", VA = "0x4B9D868")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4B9D914", Offset = "0x4B9D914", VA = "0x4B9D914")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x4B9D9C0", Offset = "0x4B9D9C0", VA = "0x4B9D9C0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x4B9DB90", Offset = "0x4B9DB90", VA = "0x4B9DB90")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	public static class V3Tools
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4B9DCF8", Offset = "0x4B9DCF8", VA = "0x4B9DCF8")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4B9DD7C", Offset = "0x4B9DD7C", VA = "0x4B9DD7C")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4B9DE1C", Offset = "0x4B9DE1C", VA = "0x4B9DE1C")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4B9DF60", Offset = "0x4B9DF60", VA = "0x4B9DF60")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4B9E080", Offset = "0x4B9E080", VA = "0x4B9E080")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4B9E198", Offset = "0x4B9E198", VA = "0x4B9E198")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4B9E35C", Offset = "0x4B9E35C", VA = "0x4B9E35C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4B9E454", Offset = "0x4B9E454", VA = "0x4B9E454")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4B9E54C", Offset = "0x4B9E54C", VA = "0x4B9E54C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4B9E6B8", Offset = "0x4B9E6B8", VA = "0x4B9E6B8")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4B9E854", Offset = "0x4B9E854", VA = "0x4B9E854")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x4B9E9A0", Offset = "0x4B9E9A0", VA = "0x4B9E9A0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x4B9EBC4", Offset = "0x4B9EBC4", VA = "0x4B9EBC4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4B9EE00", Offset = "0x4B9EE00", VA = "0x4B9EE00")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4B9F050", Offset = "0x4B9F050", VA = "0x4B9F050")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x4B9F250", Offset = "0x4B9F250", VA = "0x4B9F250")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x4B9F42C", Offset = "0x4B9F42C", VA = "0x4B9F42C")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4B9F560", Offset = "0x4B9F560", VA = "0x4B9F560")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x4B9F6B8", Offset = "0x4B9F6B8", VA = "0x4B9F6B8")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4B9F844", Offset = "0x4B9F844", VA = "0x4B9F844")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4B9F804", Offset = "0x4B9F804", VA = "0x4B9F804")]
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
		[Address(RVA = "0x4B9F980", Offset = "0x4B9F980", VA = "0x4B9F980")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4B9FDAC", Offset = "0x4B9FDAC", VA = "0x4B9FDAC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195996C", Offset = "0x195996C")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19599A4", Offset = "0x19599A4")]
		public float cornerRadius;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19599DC", Offset = "0x19599DC")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959A14", Offset = "0x1959A14")]
		public float maxSampleDistance;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959A4C", Offset = "0x1959A4C")]
		public float nextPathInterval;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959A84", Offset = "0x1959A84")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959A94", Offset = "0x1959A94")]
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
			[Address(RVA = "0x362C824", Offset = "0x362C824", VA = "0x362C824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196251C", Offset = "0x196251C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x362C830", Offset = "0x362C830", VA = "0x362C830")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196252C", Offset = "0x196252C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public State state
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x362C83C", Offset = "0x362C83C", VA = "0x362C83C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196253C", Offset = "0x196253C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x362C844", Offset = "0x362C844", VA = "0x362C844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196254C", Offset = "0x196254C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x362C84C", Offset = "0x362C84C", VA = "0x362C84C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x362C920", Offset = "0x362C920", VA = "0x362C920")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x362CE64", Offset = "0x362CE64", VA = "0x362CE64")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x362CED4", Offset = "0x362CED4", VA = "0x362CED4")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x362CD2C", Offset = "0x362CD2C", VA = "0x362CD2C")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x362CDA0", Offset = "0x362CDA0", VA = "0x362CDA0")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x362D01C", Offset = "0x362D01C", VA = "0x362D01C")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x362D1CC", Offset = "0x362D1CC", VA = "0x362D1CC")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958A24", Offset = "0x1958A24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958A24", Offset = "0x1958A24")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x362F40C", Offset = "0x362F40C", VA = "0x362F40C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196255C", Offset = "0x196255C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x362F458", Offset = "0x362F458", VA = "0x362F458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962594", Offset = "0x1962594")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x362F4A4", Offset = "0x362F4A4", VA = "0x362F4A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19625CC", Offset = "0x19625CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x362F4F0", Offset = "0x362F4F0", VA = "0x362F4F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962604", Offset = "0x1962604")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x362F53C", Offset = "0x362F53C", VA = "0x362F53C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x362F5D8", Offset = "0x362F5D8", VA = "0x362F5D8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x362F5F8", Offset = "0x362F5F8", VA = "0x362F5F8")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x362F628", Offset = "0x362F628", VA = "0x362F628")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x362F658", Offset = "0x362F658", VA = "0x362F658")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x362F698", Offset = "0x362F698", VA = "0x362F698")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x362F6DC", Offset = "0x362F6DC", VA = "0x362F6DC")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x362F700", Offset = "0x362F700", VA = "0x362F700")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x362F724", Offset = "0x362F724", VA = "0x362F724")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x362F74C", Offset = "0x362F74C", VA = "0x362F74C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x362F778", Offset = "0x362F778", VA = "0x362F778")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x362F7A4", Offset = "0x362F7A4", VA = "0x362F7A4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x362F55C", Offset = "0x362F55C", VA = "0x362F55C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x362F7CC", Offset = "0x362F7CC", VA = "0x362F7CC")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x362F7D8", Offset = "0x362F7D8", VA = "0x362F7D8")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x362F7E4", Offset = "0x362F7E4", VA = "0x362F7E4")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x362FACC", Offset = "0x362FACC", VA = "0x362FACC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x362FB74", Offset = "0x362FB74", VA = "0x362FB74", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x362FEB8", Offset = "0x362FEB8", VA = "0x362FEB8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x36303A0", Offset = "0x36303A0", VA = "0x36303A0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x36303D4", Offset = "0x36303D4", VA = "0x36303D4")]
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
			[Address(RVA = "0x362F984", Offset = "0x362F984", VA = "0x362F984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x363059C", Offset = "0x363059C", VA = "0x363059C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x362FD40", Offset = "0x362FD40", VA = "0x362FD40")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x3630454", Offset = "0x3630454", VA = "0x3630454")]
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
			[Address(RVA = "0x3631074", Offset = "0x3631074", VA = "0x3631074")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000156")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x36310E4", Offset = "0x36310E4", VA = "0x36310E4")]
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
		[Address(RVA = "0x36310EC", Offset = "0x36310EC", VA = "0x36310EC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x36311F8", Offset = "0x36311F8", VA = "0x36311F8")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x3631200", Offset = "0x3631200", VA = "0x3631200")]
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
			[Address(RVA = "0x36313C8", Offset = "0x36313C8", VA = "0x36313C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x363122C", Offset = "0x363122C", VA = "0x363122C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x3631484", Offset = "0x3631484", VA = "0x3631484")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x363148C", Offset = "0x363148C", VA = "0x363148C")]
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
		[Address(RVA = "0x36314B8", Offset = "0x36314B8", VA = "0x36314B8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x36315E0", Offset = "0x36315E0", VA = "0x36315E0")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x36315E8", Offset = "0x36315E8", VA = "0x36315E8")]
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
			[Address(RVA = "0x36317B4", Offset = "0x36317B4", VA = "0x36317B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x3631614", Offset = "0x3631614", VA = "0x3631614", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x3631884", Offset = "0x3631884", VA = "0x3631884")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x363188C", Offset = "0x363188C", VA = "0x363188C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959AA4", Offset = "0x1959AA4")]
		public float positionWeight;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959ABC", Offset = "0x1959ABC")]
		public float rotationWeight;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x36318B8", Offset = "0x36318B8", VA = "0x36318B8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x362FE64", Offset = "0x362FE64", VA = "0x362FE64")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x3630040", Offset = "0x3630040", VA = "0x3630040")]
		public void Update()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x3630768", Offset = "0x3630768", VA = "0x3630768")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959AD4", Offset = "0x1959AD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959AD4", Offset = "0x1959AD4")]
		public float weight;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959B28", Offset = "0x1959B28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959B28", Offset = "0x1959B28")]
		public float rotationWeight;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959B7C", Offset = "0x1959B7C")]
		public DOF rotationDOF;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959BB4", Offset = "0x1959BB4")]
		public bool fixBone1Twist;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959BEC", Offset = "0x1959BEC")]
		public Transform bone1;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959C24", Offset = "0x1959C24")]
		public Transform bone2;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959C5C", Offset = "0x1959C5C")]
		public Transform bone3;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959C94", Offset = "0x1959C94")]
		public Transform tip;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959CCC", Offset = "0x1959CCC")]
		public Transform target;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959D04", Offset = "0x1959D04")]
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
			[Address(RVA = "0x3D4A6B8", Offset = "0x3D4A6B8", VA = "0x3D4A6B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196263C", Offset = "0x196263C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x3D4A6C0", Offset = "0x3D4A6C0", VA = "0x3D4A6C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196264C", Offset = "0x196264C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x3D4A6CC", Offset = "0x3D4A6CC", VA = "0x3D4A6CC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x3D4A6EC", Offset = "0x3D4A6EC", VA = "0x3D4A6EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x3D4A70C", Offset = "0x3D4A70C", VA = "0x3D4A70C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x3D4A72C", Offset = "0x3D4A72C", VA = "0x3D4A72C")]
			set
			{
			}
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x3D4A74C", Offset = "0x3D4A74C", VA = "0x3D4A74C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x3D4A84C", Offset = "0x3D4A84C", VA = "0x3D4A84C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x3D4AEE0", Offset = "0x3D4AEE0", VA = "0x3D4AEE0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x3D4AFBC", Offset = "0x3D4AFBC", VA = "0x3D4AFBC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x3D4B084", Offset = "0x3D4B084", VA = "0x3D4B084")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x3D4B6A0", Offset = "0x3D4B6A0", VA = "0x3D4B6A0")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959D14", Offset = "0x1959D14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959D14", Offset = "0x1959D14")]
		public float weight;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959D68", Offset = "0x1959D68")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001E")]
		public bool initiated
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x3D4B6B0", Offset = "0x3D4B6B0", VA = "0x3D4B6B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196265C", Offset = "0x196265C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x3D4B6B8", Offset = "0x3D4B6B8", VA = "0x3D4B6B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196266C", Offset = "0x196266C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x3D4B6C4", Offset = "0x3D4B6C4", VA = "0x3D4B6C4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3D4B74C", Offset = "0x3D4B74C", VA = "0x3D4B74C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196267C", Offset = "0x196267C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x3D4BA70", Offset = "0x3D4BA70", VA = "0x3D4BA70")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x3D4BBE0", Offset = "0x3D4BBE0", VA = "0x3D4BBE0")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x3D4B968", Offset = "0x3D4B968", VA = "0x3D4B968")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x3D4BD48", Offset = "0x3D4BD48", VA = "0x3D4BD48", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x3D4BE08", Offset = "0x3D4BE08", VA = "0x3D4BE08")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x3D4BE80", Offset = "0x3D4BE80", VA = "0x3D4BE80")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x3D4BEF4", Offset = "0x3D4BEF4", VA = "0x3D4BEF4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x3D4BF5C", Offset = "0x3D4BF5C", VA = "0x3D4BF5C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x3D4BF60", Offset = "0x3D4BF60", VA = "0x3D4BF60", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x3D4BF74", Offset = "0x3D4BF74", VA = "0x3D4BF74")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959D78", Offset = "0x1959D78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959D78", Offset = "0x1959D78")]
		public float weight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959DCC", Offset = "0x1959DCC")]
		public Grounding solver;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959E04", Offset = "0x1959E04")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001F")]
		public bool initiated
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x3D4CFA8", Offset = "0x3D4CFA8", VA = "0x3D4CFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19626B4", Offset = "0x19626B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x3D4CFB0", Offset = "0x3D4CFB0", VA = "0x3D4CFB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19626C4", Offset = "0x19626C4")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000184")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x3D4CFBC", Offset = "0x3D4CFBC", VA = "0x3D4CFBC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x3D4D290", Offset = "0x3D4D290", VA = "0x3D4D290")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x3D4D100", Offset = "0x3D4D100", VA = "0x3D4D100")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x3D4D2C4", Offset = "0x3D4D2C4", VA = "0x3D4D2C4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600018C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x3D4D4CC", Offset = "0x3D4D4CC", VA = "0x3D4D4CC")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958A84", Offset = "0x1958A84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958A84", Offset = "0x1958A84")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959E14", Offset = "0x1959E14")]
		public BipedIK ik;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959E4C", Offset = "0x1959E4C")]
		public float spineBend;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959E84", Offset = "0x1959E84")]
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
		[Address(RVA = "0x3D4D834", Offset = "0x3D4D834", VA = "0x3D4D834", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19626D4", Offset = "0x19626D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x3D4D880", Offset = "0x3D4D880", VA = "0x3D4D880", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196270C", Offset = "0x196270C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3D4D8CC", Offset = "0x3D4D8CC", VA = "0x3D4D8CC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x3D4D9D0", Offset = "0x3D4D9D0", VA = "0x3D4D9D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x3D4DA80", Offset = "0x3D4DA80", VA = "0x3D4DA80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x3D4DB34", Offset = "0x3D4DB34", VA = "0x3D4DB34")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x3D4E048", Offset = "0x3D4E048", VA = "0x3D4E048")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x3D4E09C", Offset = "0x3D4E09C", VA = "0x3D4E09C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x3D4E8B0", Offset = "0x3D4E8B0", VA = "0x3D4E8B0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3D4EA10", Offset = "0x3D4EA10", VA = "0x3D4EA10")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x3D4EBA0", Offset = "0x3D4EBA0", VA = "0x3D4EBA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x3D4ED10", Offset = "0x3D4ED10", VA = "0x3D4ED10")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958AE4", Offset = "0x1958AE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958AE4", Offset = "0x1958AE4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class SpineEffector
		{
			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D1B8", Offset = "0x195D1B8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D1F0", Offset = "0x195D1F0")]
			public float horizontalWeight;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D228", Offset = "0x195D228")]
			public float verticalWeight;

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x3D4FB78", Offset = "0x3D4FB78", VA = "0x3D4FB78")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x3D4FB88", Offset = "0x3D4FB88", VA = "0x3D4FB88")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959EBC", Offset = "0x1959EBC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959EF4", Offset = "0x1959EF4")]
		public float spineBend;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959F2C", Offset = "0x1959F2C")]
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
		[Address(RVA = "0x3D4ED90", Offset = "0x3D4ED90", VA = "0x3D4ED90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962744", Offset = "0x1962744")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x3D4EDDC", Offset = "0x3D4EDDC", VA = "0x3D4EDDC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196277C", Offset = "0x196277C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x3D4EE28", Offset = "0x3D4EE28", VA = "0x3D4EE28", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19627B4", Offset = "0x19627B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x3D4EE74", Offset = "0x3D4EE74", VA = "0x3D4EE74", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x3D4EEF4", Offset = "0x3D4EEF4", VA = "0x3D4EEF4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3D4EF8C", Offset = "0x3D4EF8C", VA = "0x3D4EF8C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x3D4F248", Offset = "0x3D4F248", VA = "0x3D4F248")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x3D4F254", Offset = "0x3D4F254", VA = "0x3D4F254")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x3D4F048", Offset = "0x3D4F048", VA = "0x3D4F048")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x3D4F260", Offset = "0x3D4F260", VA = "0x3D4F260")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x3D4F700", Offset = "0x3D4F700", VA = "0x3D4F700")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x3D4F8C0", Offset = "0x3D4F8C0", VA = "0x3D4F8C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x3D4F9F8", Offset = "0x3D4F9F8", VA = "0x3D4F9F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3D4FAF8", Offset = "0x3D4FAF8", VA = "0x3D4FAF8")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958B44", Offset = "0x1958B44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958B44", Offset = "0x1958B44")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959F64", Offset = "0x1959F64")]
		public Transform pelvis;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959F9C", Offset = "0x1959F9C")]
		public Transform characterRoot;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1959FD4", Offset = "0x1959FD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1959FD4", Offset = "0x1959FD4")]
		public float rootRotationWeight;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A028", Offset = "0x195A028")]
		public float rootRotationSpeed;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A060", Offset = "0x195A060")]
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
		[Address(RVA = "0x3D4FBD0", Offset = "0x3D4FBD0", VA = "0x3D4FBD0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19627EC", Offset = "0x19627EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x3D4FC1C", Offset = "0x3D4FC1C", VA = "0x3D4FC1C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962824", Offset = "0x1962824")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x3D4FC68", Offset = "0x3D4FC68", VA = "0x3D4FC68", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x3D4FC80", Offset = "0x3D4FC80", VA = "0x3D4FC80")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x3D4FE70", Offset = "0x3D4FE70", VA = "0x3D4FE70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x3D4FF70", Offset = "0x3D4FF70", VA = "0x3D4FF70")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x3D506B8", Offset = "0x3D506B8", VA = "0x3D506B8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x3D50A9C", Offset = "0x3D50A9C", VA = "0x3D50A9C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x3D50D0C", Offset = "0x3D50D0C", VA = "0x3D50D0C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x3D5102C", Offset = "0x3D5102C", VA = "0x3D5102C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x3D511C8", Offset = "0x3D511C8", VA = "0x3D511C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x3D51390", Offset = "0x3D51390", VA = "0x3D51390")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958BA4", Offset = "0x1958BA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958BA4", Offset = "0x1958BA4")]
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
			[Address(RVA = "0x3D51F0C", Offset = "0x3D51F0C", VA = "0x3D51F0C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A098", Offset = "0x195A098")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A0D0", Offset = "0x195A0D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A0D0", Offset = "0x195A0D0")]
		public float rootRotationWeight;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A124", Offset = "0x195A124")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A124", Offset = "0x195A124")]
		public float minRootRotation;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A17C", Offset = "0x195A17C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A17C", Offset = "0x195A17C")]
		public float maxRootRotation;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A1D4", Offset = "0x195A1D4")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A20C", Offset = "0x195A20C")]
		public float maxLegOffset;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A244", Offset = "0x195A244")]
		public float maxForeLegOffset;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A27C", Offset = "0x195A27C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A27C", Offset = "0x195A27C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A2D0", Offset = "0x195A2D0")]
		public Transform characterRoot;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A308", Offset = "0x195A308")]
		public Transform pelvis;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A340", Offset = "0x195A340")]
		public Transform lastSpineBone;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A378", Offset = "0x195A378")]
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
		[Address(RVA = "0x3D51410", Offset = "0x3D51410", VA = "0x3D51410", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196285C", Offset = "0x196285C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x3D5145C", Offset = "0x3D5145C", VA = "0x3D5145C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962894", Offset = "0x1962894")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x3D514A8", Offset = "0x3D514A8", VA = "0x3D514A8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x3D514DC", Offset = "0x3D514DC", VA = "0x3D514DC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x3D5160C", Offset = "0x3D5160C", VA = "0x3D5160C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x3D517CC", Offset = "0x3D517CC", VA = "0x3D517CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x3D51834", Offset = "0x3D51834", VA = "0x3D51834")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x3D518EC", Offset = "0x3D518EC", VA = "0x3D518EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x3D51BEC", Offset = "0x3D51BEC", VA = "0x3D51BEC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x3D51F4C", Offset = "0x3D51F4C", VA = "0x3D51F4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x3D52098", Offset = "0x3D52098", VA = "0x3D52098")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x3D5253C", Offset = "0x3D5253C", VA = "0x3D5253C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x3D52D2C", Offset = "0x3D52D2C", VA = "0x3D52D2C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x3D52FEC", Offset = "0x3D52FEC", VA = "0x3D52FEC")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x3D5314C", Offset = "0x3D5314C", VA = "0x3D5314C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x3D53428", Offset = "0x3D53428", VA = "0x3D53428")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x3D53460", Offset = "0x3D53460", VA = "0x3D53460")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x3D53620", Offset = "0x3D53620", VA = "0x3D53620")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958C04", Offset = "0x1958C04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958C04", Offset = "0x1958C04")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A3C0", Offset = "0x195A3C0")]
		public VRIK ik;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x3D53738", Offset = "0x3D53738", VA = "0x3D53738")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19628CC", Offset = "0x19628CC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x3D53784", Offset = "0x3D53784", VA = "0x3D53784", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962904", Offset = "0x1962904")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x3D537D0", Offset = "0x3D537D0", VA = "0x3D537D0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196293C", Offset = "0x196293C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x3D5381C", Offset = "0x3D5381C", VA = "0x3D5381C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x3D53834", Offset = "0x3D53834", VA = "0x3D53834")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x3D538CC", Offset = "0x3D538CC", VA = "0x3D538CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x3D53980", Offset = "0x3D53980", VA = "0x3D53980")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x3D53B80", Offset = "0x3D53B80", VA = "0x3D53B80")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x3D53E14", Offset = "0x3D53E14", VA = "0x3D53E14")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x3D53F1C", Offset = "0x3D53F1C", VA = "0x3D53F1C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x3D5411C", Offset = "0x3D5411C", VA = "0x3D5411C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x3D54254", Offset = "0x3D54254", VA = "0x3D54254")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x3D543B4", Offset = "0x3D543B4", VA = "0x3D543B4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D260", Offset = "0x195D260")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D270", Offset = "0x195D270")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D280", Offset = "0x195D280")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D290", Offset = "0x195D290")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D2A0", Offset = "0x195D2A0")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D2B0", Offset = "0x195D2B0")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D2C0", Offset = "0x195D2C0")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D2D0", Offset = "0x195D2D0")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D2E0", Offset = "0x195D2E0")]
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
				[Address(RVA = "0x3D55E0C", Offset = "0x3D55E0C", VA = "0x3D55E0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964448", Offset = "0x1964448")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600059D")]
				[Address(RVA = "0x3D55E14", Offset = "0x3D55E14", VA = "0x3D55E14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964458", Offset = "0x1964458")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600059E")]
				[Address(RVA = "0x3D55E20", Offset = "0x3D55E20", VA = "0x3D55E20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964468", Offset = "0x1964468")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600059F")]
				[Address(RVA = "0x3D55E2C", Offset = "0x3D55E2C", VA = "0x3D55E2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964478", Offset = "0x1964478")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public bool initiated
			{
				[Token(Token = "0x60005A0")]
				[Address(RVA = "0x3D55E38", Offset = "0x3D55E38", VA = "0x3D55E38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964488", Offset = "0x1964488")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005A1")]
				[Address(RVA = "0x3D55E40", Offset = "0x3D55E40", VA = "0x3D55E40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964498", Offset = "0x1964498")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public float heightFromGround
			{
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0x3D55E4C", Offset = "0x3D55E4C", VA = "0x3D55E4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19644A8", Offset = "0x19644A8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0x3D55E54", Offset = "0x3D55E54", VA = "0x3D55E54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19644B8", Offset = "0x19644B8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x3D55E5C", Offset = "0x3D55E5C", VA = "0x3D55E5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19644C8", Offset = "0x19644C8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x3D55E68", Offset = "0x3D55E68", VA = "0x3D55E68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19644D8", Offset = "0x19644D8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000087")]
			public Transform transform
			{
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x3D55E74", Offset = "0x3D55E74", VA = "0x3D55E74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19644E8", Offset = "0x19644E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0x3D55E7C", Offset = "0x3D55E7C", VA = "0x3D55E7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19644F8", Offset = "0x19644F8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public float IKOffset
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x3D55E84", Offset = "0x3D55E84", VA = "0x3D55E84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964508", Offset = "0x1964508")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0x3D55E8C", Offset = "0x3D55E8C", VA = "0x3D55E8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964518", Offset = "0x1964518")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x3D55E94", Offset = "0x3D55E94", VA = "0x3D55E94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964528", Offset = "0x1964528")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0x3D55EAC", Offset = "0x3D55EAC", VA = "0x3D55EAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964538", Offset = "0x1964538")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0x3D55ECC", Offset = "0x3D55ECC", VA = "0x3D55ECC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964548", Offset = "0x1964548")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x3D55EE4", Offset = "0x3D55EE4", VA = "0x3D55EE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964558", Offset = "0x1964558")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0x3D55F04", Offset = "0x3D55F04", VA = "0x3D55F04")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700008C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005B4")]
				[Address(RVA = "0x3D56CC8", Offset = "0x3D56CC8", VA = "0x3D56CC8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700008D")]
			private float rootYOffset
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x3D56FA0", Offset = "0x3D56FA0", VA = "0x3D56FA0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x3D55F4C", Offset = "0x3D55F4C", VA = "0x3D55F4C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x3D54A4C", Offset = "0x3D54A4C", VA = "0x3D54A4C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x3D55F60", Offset = "0x3D55F60", VA = "0x3D55F60")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x3D5592C", Offset = "0x3D5592C", VA = "0x3D5592C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x3D54B58", Offset = "0x3D54B58", VA = "0x3D54B58")]
			public void Process()
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x3D5673C", Offset = "0x3D5673C", VA = "0x3D5673C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x3D55FAC", Offset = "0x3D55FAC", VA = "0x3D55FAC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x3D56E48", Offset = "0x3D56E48", VA = "0x3D56E48")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x3D563E8", Offset = "0x3D563E8", VA = "0x3D563E8")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x3D564F0", Offset = "0x3D564F0", VA = "0x3D564F0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x3D56F44", Offset = "0x3D56F44", VA = "0x3D56F44")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x3D56D54", Offset = "0x3D56D54", VA = "0x3D56D54")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x3D570C8", Offset = "0x3D570C8", VA = "0x3D570C8")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x3D5499C", Offset = "0x3D5499C", VA = "0x3D5499C")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000A6")]
		public class Pelvis
		{
			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D2F0", Offset = "0x195D2F0")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D300", Offset = "0x195D300")]
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
				[Address(RVA = "0x3D571B8", Offset = "0x3D571B8", VA = "0x3D571B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964568", Offset = "0x1964568")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x3D571C4", Offset = "0x3D571C4", VA = "0x3D571C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964578", Offset = "0x1964578")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			public float heightOffset
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x3D571D0", Offset = "0x3D571D0", VA = "0x3D571D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964588", Offset = "0x1964588")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x3D571D8", Offset = "0x3D571D8", VA = "0x3D571D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964598", Offset = "0x1964598")]
				private set
				{
				}
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x3D54B30", Offset = "0x3D54B30", VA = "0x3D54B30")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x3D5587C", Offset = "0x3D5587C", VA = "0x3D5587C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x3D571E0", Offset = "0x3D571E0", VA = "0x3D571E0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x3D55610", Offset = "0x3D55610", VA = "0x3D55610")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x3D54A44", Offset = "0x3D54A44", VA = "0x3D54A44")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A3F8", Offset = "0x195A3F8")]
		public LayerMask layers;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A430", Offset = "0x195A430")]
		public float maxStep;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A468", Offset = "0x195A468")]
		public float heightOffset;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A4A0", Offset = "0x195A4A0")]
		public float footSpeed;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A4D8", Offset = "0x195A4D8")]
		public float footRadius;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A510", Offset = "0x195A510")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A55C", Offset = "0x195A55C")]
		public float prediction;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A594", Offset = "0x195A594")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A594", Offset = "0x195A594")]
		public float footRotationWeight;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A5E8", Offset = "0x195A5E8")]
		public float footRotationSpeed;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A620", Offset = "0x195A620")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A620", Offset = "0x195A620")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A678", Offset = "0x195A678")]
		public bool rotateSolver;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A6B0", Offset = "0x195A6B0")]
		public float pelvisSpeed;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A6E8", Offset = "0x195A6E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A6E8", Offset = "0x195A6E8")]
		public float pelvisDamper;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A73C", Offset = "0x195A73C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A774", Offset = "0x195A774")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A7AC", Offset = "0x195A7AC")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A7E4", Offset = "0x195A7E4")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A81C", Offset = "0x195A81C")]
		public Quality quality;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195A854", Offset = "0x195A854")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195A864", Offset = "0x195A864")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195A874", Offset = "0x195A874")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195A884", Offset = "0x195A884")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195A894", Offset = "0x195A894")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000020")]
		public Leg[] legs
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x3D54410", Offset = "0x3D54410", VA = "0x3D54410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1962974", Offset = "0x1962974")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x3D54418", Offset = "0x3D54418", VA = "0x3D54418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1962984", Offset = "0x1962984")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x3D54420", Offset = "0x3D54420", VA = "0x3D54420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1962994", Offset = "0x1962994")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x3D54428", Offset = "0x3D54428", VA = "0x3D54428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19629A4", Offset = "0x19629A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool isGrounded
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x3D54430", Offset = "0x3D54430", VA = "0x3D54430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19629B4", Offset = "0x19629B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x3D54438", Offset = "0x3D54438", VA = "0x3D54438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19629C4", Offset = "0x19629C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Transform root
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x3D54444", Offset = "0x3D54444", VA = "0x3D54444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19629D4", Offset = "0x19629D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x3D5444C", Offset = "0x3D5444C", VA = "0x3D5444C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19629E4", Offset = "0x19629E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x3D54454", Offset = "0x3D54454", VA = "0x3D54454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19629F4", Offset = "0x19629F4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x3D5446C", Offset = "0x3D5446C", VA = "0x3D5446C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1962A04", Offset = "0x1962A04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x3D5448C", Offset = "0x3D5448C", VA = "0x3D5448C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 up
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x3D4E984", Offset = "0x3D4E984", VA = "0x3D4E984")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x3D559E0", Offset = "0x3D559E0", VA = "0x3D559E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3D544E0", Offset = "0x3D544E0", VA = "0x3D544E0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x3D548C0", Offset = "0x3D548C0", VA = "0x3D548C0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x3D4DDE8", Offset = "0x3D4DDE8", VA = "0x3D4DDE8")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x3D4E608", Offset = "0x3D4E608", VA = "0x3D4E608")]
		public void Update()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x3D504A0", Offset = "0x3D504A0", VA = "0x3D504A0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x3D4D94C", Offset = "0x3D4D94C", VA = "0x3D4D94C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x3D54B40", Offset = "0x3D54B40", VA = "0x3D54B40")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x3D55AB0", Offset = "0x3D55AB0", VA = "0x3D55AB0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x3D55C18", Offset = "0x3D55C18", VA = "0x3D55C18")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x3D55D1C", Offset = "0x3D55D1C", VA = "0x3D55D1C")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x3D4D58C", Offset = "0x3D4D58C", VA = "0x3D4D58C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958C64", Offset = "0x1958C64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958C64", Offset = "0x1958C64")]
	public class AimIK : IK
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x362E638", Offset = "0x362E638", VA = "0x362E638", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962A14", Offset = "0x1962A14")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x362E684", Offset = "0x362E684", VA = "0x362E684", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962A4C", Offset = "0x1962A4C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x362E6D0", Offset = "0x362E6D0", VA = "0x362E6D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962A84", Offset = "0x1962A84")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x362E71C", Offset = "0x362E71C", VA = "0x362E71C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962ABC", Offset = "0x1962ABC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x362E768", Offset = "0x362E768", VA = "0x362E768")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962AF4", Offset = "0x1962AF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x362E7B4", Offset = "0x362E7B4", VA = "0x362E7B4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x362E7BC", Offset = "0x362E7BC", VA = "0x362E7BC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958CC4", Offset = "0x1958CC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958CC4", Offset = "0x1958CC4")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x362F26C", Offset = "0x362F26C", VA = "0x362F26C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962B2C", Offset = "0x1962B2C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x362F2B8", Offset = "0x362F2B8", VA = "0x362F2B8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962B64", Offset = "0x1962B64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x362F304", Offset = "0x362F304", VA = "0x362F304")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962B9C", Offset = "0x1962B9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x362F350", Offset = "0x362F350", VA = "0x362F350")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962BD4", Offset = "0x1962BD4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x362F39C", Offset = "0x362F39C", VA = "0x362F39C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x362F3A4", Offset = "0x362F3A4", VA = "0x362F3A4")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958D24", Offset = "0x1958D24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958D24", Offset = "0x1958D24")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x3630ED4", Offset = "0x3630ED4", VA = "0x3630ED4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962C0C", Offset = "0x1962C0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x3630F20", Offset = "0x3630F20", VA = "0x3630F20", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962C44", Offset = "0x1962C44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x3630F6C", Offset = "0x3630F6C", VA = "0x3630F6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962C7C", Offset = "0x1962C7C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x3630FB8", Offset = "0x3630FB8", VA = "0x3630FB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962CB4", Offset = "0x1962CB4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x3631004", Offset = "0x3631004", VA = "0x3631004", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x363100C", Offset = "0x363100C", VA = "0x363100C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958D84", Offset = "0x1958D84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958D84", Offset = "0x1958D84")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x36325B4", Offset = "0x36325B4", VA = "0x36325B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962CEC", Offset = "0x1962CEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x3632600", Offset = "0x3632600", VA = "0x3632600", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962D24", Offset = "0x1962D24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x363264C", Offset = "0x363264C", VA = "0x363264C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962D5C", Offset = "0x1962D5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x3632698", Offset = "0x3632698", VA = "0x3632698")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962D94", Offset = "0x1962D94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x36326E4", Offset = "0x36326E4", VA = "0x36326E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x36326EC", Offset = "0x36326EC", VA = "0x36326EC")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958DE4", Offset = "0x1958DE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958DE4", Offset = "0x1958DE4")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x3D433D8", Offset = "0x3D433D8", VA = "0x3D433D8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962DCC", Offset = "0x1962DCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x3D43424", Offset = "0x3D43424", VA = "0x3D43424", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962E04", Offset = "0x1962E04")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x3D43470", Offset = "0x3D43470", VA = "0x3D43470")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962E3C", Offset = "0x1962E3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x3D434BC", Offset = "0x3D434BC", VA = "0x3D434BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962E74", Offset = "0x1962E74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x3D43508", Offset = "0x3D43508", VA = "0x3D43508", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x3D43510", Offset = "0x3D43510", VA = "0x3D43510")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958E44", Offset = "0x1958E44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958E44", Offset = "0x1958E44")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x3D4BFDC", Offset = "0x3D4BFDC", VA = "0x3D4BFDC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962EAC", Offset = "0x1962EAC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x3D4C028", Offset = "0x3D4C028", VA = "0x3D4C028", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962EE4", Offset = "0x1962EE4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x3D4C074", Offset = "0x3D4C074", VA = "0x3D4C074")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962F1C", Offset = "0x1962F1C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x3D4C0C0", Offset = "0x3D4C0C0", VA = "0x3D4C0C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962F54", Offset = "0x1962F54")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x3D4C10C", Offset = "0x3D4C10C", VA = "0x3D4C10C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962F8C", Offset = "0x1962F8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x3D4C158", Offset = "0x3D4C158", VA = "0x3D4C158")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962FC4", Offset = "0x1962FC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x3D4C1A4", Offset = "0x3D4C1A4", VA = "0x3D4C1A4")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x3D4C1C8", Offset = "0x3D4C1C8", VA = "0x3D4C1C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x3D4C1D0", Offset = "0x3D4C1D0", VA = "0x3D4C1D0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x3D4C38C", Offset = "0x3D4C38C", VA = "0x3D4C38C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x3D4C6E0", Offset = "0x3D4C6E0", VA = "0x3D4C6E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1962FFC", Offset = "0x1962FFC")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3D4C700", Offset = "0x3D4C700", VA = "0x3D4C700")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963034", Offset = "0x1963034")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x3D4C7DC", Offset = "0x3D4C7DC", VA = "0x3D4C7DC")]
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
		[Address(RVA = "0x3D59CC8", Offset = "0x3D59CC8", VA = "0x3D59CC8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x3D59D50", Offset = "0x3D59D50", VA = "0x3D59D50", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x3D59DC4", Offset = "0x3D59DC4", VA = "0x3D59DC4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600021B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600021C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x3D43578", Offset = "0x3D43578", VA = "0x3D43578")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A8A4", Offset = "0x195A8A4")]
		public IK[] IKComponents;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A8DC", Offset = "0x195A8DC")]
		public Animator animator;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000028")]
		private bool animatePhysics
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x42AF9B0", Offset = "0x42AF9B0", VA = "0x42AF9B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x42AFA4C", Offset = "0x42AFA4C", VA = "0x42AFA4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x42AFABC", Offset = "0x42AFABC", VA = "0x42AFABC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x42AFB78", Offset = "0x42AFB78", VA = "0x42AFB78")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x42AFBB4", Offset = "0x42AFBB4", VA = "0x42AFBB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x42AFAF0", Offset = "0x42AFAF0", VA = "0x42AFAF0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x42AFCA8", Offset = "0x42AFCA8", VA = "0x42AFCA8")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958EA4", Offset = "0x1958EA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958EA4", Offset = "0x1958EA4")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x3A43820", Offset = "0x3A43820", VA = "0x3A43820", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196306C", Offset = "0x196306C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x3A4386C", Offset = "0x3A4386C", VA = "0x3A4386C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19630A4", Offset = "0x19630A4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x3A438B8", Offset = "0x3A438B8", VA = "0x3A438B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19630DC", Offset = "0x19630DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x3A43904", Offset = "0x3A43904", VA = "0x3A43904")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963114", Offset = "0x1963114")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x3A43950", Offset = "0x3A43950", VA = "0x3A43950", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x3A43958", Offset = "0x3A43958", VA = "0x3A43958")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958F04", Offset = "0x1958F04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958F04", Offset = "0x1958F04")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x3A439C0", Offset = "0x3A439C0", VA = "0x3A439C0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196314C", Offset = "0x196314C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x3A43A0C", Offset = "0x3A43A0C", VA = "0x3A43A0C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963184", Offset = "0x1963184")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x3A43A58", Offset = "0x3A43A58", VA = "0x3A43A58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19631BC", Offset = "0x19631BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x3A43AA4", Offset = "0x3A43AA4", VA = "0x3A43AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19631F4", Offset = "0x19631F4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x3A43AF0", Offset = "0x3A43AF0", VA = "0x3A43AF0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3A43AF8", Offset = "0x3A43AF8", VA = "0x3A43AF8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958F64", Offset = "0x1958F64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958F64", Offset = "0x1958F64")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x3A449C8", Offset = "0x3A449C8", VA = "0x3A449C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196322C", Offset = "0x196322C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3A44A14", Offset = "0x3A44A14", VA = "0x3A44A14", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963264", Offset = "0x1963264")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3A44A60", Offset = "0x3A44A60", VA = "0x3A44A60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196329C", Offset = "0x196329C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3A44AAC", Offset = "0x3A44AAC", VA = "0x3A44AAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19632D4", Offset = "0x19632D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3A44AF8", Offset = "0x3A44AF8", VA = "0x3A44AF8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3A44B00", Offset = "0x3A44B00", VA = "0x3A44B00")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1958FC4", Offset = "0x1958FC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1958FC4", Offset = "0x1958FC4")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3A4D148", Offset = "0x3A4D148", VA = "0x3A4D148", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196330C", Offset = "0x196330C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x3A4D194", Offset = "0x3A4D194", VA = "0x3A4D194", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963344", Offset = "0x1963344")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x3A4D1E0", Offset = "0x3A4D1E0", VA = "0x3A4D1E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196337C", Offset = "0x196337C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x3A4D22C", Offset = "0x3A4D22C", VA = "0x3A4D22C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19633B4", Offset = "0x19633B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x3A4D278", Offset = "0x3A4D278", VA = "0x3A4D278", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x3A4D280", Offset = "0x3A4D280", VA = "0x3A4D280")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1959024", Offset = "0x1959024")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D310", Offset = "0x195D310")]
			public Transform chest;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D348", Offset = "0x195D348")]
			public Transform neck;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D380", Offset = "0x195D380")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D3B8", Offset = "0x195D3B8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D3F0", Offset = "0x195D3F0")]
			public Transform leftThigh;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D428", Offset = "0x195D428")]
			public Transform leftCalf;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D460", Offset = "0x195D460")]
			public Transform leftFoot;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D498", Offset = "0x195D498")]
			public Transform leftToes;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D4D0", Offset = "0x195D4D0")]
			public Transform rightThigh;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D508", Offset = "0x195D508")]
			public Transform rightCalf;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D540", Offset = "0x195D540")]
			public Transform rightFoot;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D578", Offset = "0x195D578")]
			public Transform rightToes;

			[Token(Token = "0x17000090")]
			public bool isFilled
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0x4B91F6C", Offset = "0x4B91F6C", VA = "0x4B91F6C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000091")]
			public bool isEmpty
			{
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x4B923E8", Offset = "0x4B923E8", VA = "0x4B923E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x4B91B20", Offset = "0x4B91B20", VA = "0x4B91B20")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x4B92864", Offset = "0x4B92864", VA = "0x4B92864")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x4B92B9C", Offset = "0x4B92B9C", VA = "0x4B92B9C")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x195A914", Offset = "0x195A914")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A914", Offset = "0x195A914")]
		public References references;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A990", Offset = "0x195A990")]
		public IKSolverVR solver;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x3A4E4BC", Offset = "0x3A4E4BC", VA = "0x3A4E4BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19633EC", Offset = "0x19633EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x3A4E508", Offset = "0x3A4E508", VA = "0x3A4E508", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963424", Offset = "0x1963424")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x3A4E554", Offset = "0x3A4E554", VA = "0x3A4E554")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196345C", Offset = "0x196345C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x3A4E5A0", Offset = "0x3A4E5A0", VA = "0x3A4E5A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963494", Offset = "0x1963494")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x3A4E5CC", Offset = "0x3A4E5CC", VA = "0x3A4E5CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19634CC", Offset = "0x19634CC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x3A4E5F4", Offset = "0x3A4E5F4", VA = "0x3A4E5F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x3A4E5FC", Offset = "0x3A4E5FC", VA = "0x3A4E5FC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x3A4E67C", Offset = "0x3A4E67C", VA = "0x3A4E67C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x3A4E7F4", Offset = "0x3A4E7F4", VA = "0x3A4E7F4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A9C8", Offset = "0x195A9C8")]
		public float pull;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195A9E0", Offset = "0x195A9E0")]
		public float pin;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x3632754", Offset = "0x3632754", VA = "0x3632754")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x363281C", Offset = "0x363281C", VA = "0x363281C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x363283C", Offset = "0x363283C", VA = "0x363283C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x3632C0C", Offset = "0x3632C0C", VA = "0x3632C0C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x3632910", Offset = "0x3632910", VA = "0x3632910")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x3632D04", Offset = "0x3632D04", VA = "0x3632D04")]
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
		[Address(RVA = "0x3D43580", Offset = "0x3D43580", VA = "0x3D43580")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x3D43AE8", Offset = "0x3D43AE8", VA = "0x3D43AE8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x3D43CA8", Offset = "0x3D43CA8", VA = "0x3D43CA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x3D43DA0", Offset = "0x3D43DA0", VA = "0x3D43DA0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D5B0", Offset = "0x195D5B0")]
			public Transform transform;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D5E8", Offset = "0x195D5E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195D5E8", Offset = "0x195D5E8")]
			public float weight;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x3D46DD0", Offset = "0x3D46DD0", VA = "0x3D46DD0")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x3D46E50", Offset = "0x3D46E50", VA = "0x3D46E50")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x3D44560", Offset = "0x3D44560", VA = "0x3D44560")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x3D44964", Offset = "0x3D44964", VA = "0x3D44964")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195A9F8", Offset = "0x195A9F8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x195AA30", Offset = "0x195AA30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AA30", Offset = "0x195AA30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AA30", Offset = "0x195AA30")]
		public float positionWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AAA8", Offset = "0x195AAA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AAA8", Offset = "0x195AAA8")]
		public float bodyWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AAFC", Offset = "0x195AAFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AAFC", Offset = "0x195AAFC")]
		public float thighWeight;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AB50", Offset = "0x195AB50")]
		public bool handsPullBody;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x195AB88", Offset = "0x195AB88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AB88", Offset = "0x195AB88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AB88", Offset = "0x195AB88")]
		public float rotationWeight;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AC00", Offset = "0x195AC00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AC00", Offset = "0x195AC00")]
		public float bodyClampWeight;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AC54", Offset = "0x195AC54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AC54", Offset = "0x195AC54")]
		public float headClampWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195ACA8", Offset = "0x195ACA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195ACA8", Offset = "0x195ACA8")]
		public float bendWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195ACFC", Offset = "0x195ACFC")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x195AD34", Offset = "0x195AD34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AD34", Offset = "0x195AD34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AD34", Offset = "0x195AD34")]
		public float CCDWeight;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195ADAC", Offset = "0x195ADAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195ADAC", Offset = "0x195ADAC")]
		public float roll;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AE00", Offset = "0x195AE00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AE00", Offset = "0x195AE00")]
		public float damper;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AE58", Offset = "0x195AE58")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x195AE90", Offset = "0x195AE90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AE90", Offset = "0x195AE90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195AE90", Offset = "0x195AE90")]
		public float postStretchWeight;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AF08", Offset = "0x195AF08")]
		public float maxStretch;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AF40", Offset = "0x195AF40")]
		public float stretchDamper;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AF78", Offset = "0x195AF78")]
		public bool fixHead;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195AFB0", Offset = "0x195AFB0")]
		public Transform[] stretchBones;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x195AFE8", Offset = "0x195AFE8")]
		public Vector3 chestDirection;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B020", Offset = "0x195B020")]
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
		[Address(RVA = "0x3D43DA8", Offset = "0x3D43DA8", VA = "0x3D43DA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x3D440D8", Offset = "0x3D440D8", VA = "0x3D440D8")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x3D44598", Offset = "0x3D44598", VA = "0x3D44598")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x3D4498C", Offset = "0x3D4498C", VA = "0x3D4498C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x3D45304", Offset = "0x3D45304", VA = "0x3D45304")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x3D45650", Offset = "0x3D45650", VA = "0x3D45650")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x3D459EC", Offset = "0x3D459EC", VA = "0x3D459EC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x3D46458", Offset = "0x3D46458", VA = "0x3D46458")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x3D45030", Offset = "0x3D45030", VA = "0x3D45030")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x3D46668", Offset = "0x3D46668", VA = "0x3D46668")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3D46314", Offset = "0x3D46314", VA = "0x3D46314")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3D46178", Offset = "0x3D46178", VA = "0x3D46178")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3D469D4", Offset = "0x3D469D4", VA = "0x3D469D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3D46C54", Offset = "0x3D46C54", VA = "0x3D46C54")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D65C", Offset = "0x195D65C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D66C", Offset = "0x195D66C")]
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
				[Address(RVA = "0x3D4A648", Offset = "0x3D4A648", VA = "0x3D4A648")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19645A8", Offset = "0x19645A8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D2")]
				[Address(RVA = "0x3D4A650", Offset = "0x3D4A650", VA = "0x3D4A650")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19645B8", Offset = "0x19645B8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public bool isRigid
			{
				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x3D4A658", Offset = "0x3D4A658", VA = "0x3D4A658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19645C8", Offset = "0x19645C8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x3D4A660", Offset = "0x3D4A660", VA = "0x3D4A660")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19645D8", Offset = "0x19645D8")]
				private set
				{
				}
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x3D4A66C", Offset = "0x3D4A66C", VA = "0x3D4A66C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x3D47B10", Offset = "0x3D47B10", VA = "0x3D47B10")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x3D4830C", Offset = "0x3D4830C", VA = "0x3D4830C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x3D4A344", Offset = "0x3D4A344", VA = "0x3D4A344")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B038", Offset = "0x195B038")]
		public float pin;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B050", Offset = "0x195B050")]
		public float pull;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B068", Offset = "0x195B068")]
		public float push;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B080", Offset = "0x195B080")]
		public float pushParent;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B098", Offset = "0x195B098")]
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
		[Address(RVA = "0x3D46EF4", Offset = "0x3D46EF4", VA = "0x3D46EF4")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x3D47040", Offset = "0x3D47040", VA = "0x3D47040")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x3D47148", Offset = "0x3D47148", VA = "0x3D47148")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x3D4726C", Offset = "0x3D4726C", VA = "0x3D4726C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x3D47348", Offset = "0x3D47348", VA = "0x3D47348")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x3D4744C", Offset = "0x3D4744C", VA = "0x3D4744C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x3D47E24", Offset = "0x3D47E24", VA = "0x3D47E24")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x3D475D8", Offset = "0x3D475D8", VA = "0x3D475D8")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x3D48510", Offset = "0x3D48510", VA = "0x3D48510")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x3D488B4", Offset = "0x3D488B4", VA = "0x3D488B4")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3D48C98", Offset = "0x3D48C98", VA = "0x3D48C98")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x3D4981C", Offset = "0x3D4981C", VA = "0x3D4981C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x3D49DEC", Offset = "0x3D49DEC", VA = "0x3D49DEC")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x3D4A084", Offset = "0x3D4A084", VA = "0x3D4A084")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x3D49CE4", Offset = "0x3D49CE4", VA = "0x3D49CE4")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x3D49604", Offset = "0x3D49604", VA = "0x3D49604")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x3D49C6C", Offset = "0x3D49C6C", VA = "0x3D49C6C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x3D4A16C", Offset = "0x3D4A16C", VA = "0x3D4A16C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x3D49B8C", Offset = "0x3D49B8C", VA = "0x3D49B8C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x3D49F6C", Offset = "0x3D49F6C", VA = "0x3D49F6C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B0B0", Offset = "0x195B0B0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B0C8", Offset = "0x195B0C8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000029")]
		public bool initiated
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x3D59FEC", Offset = "0x3D59FEC", VA = "0x3D59FEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963504", Offset = "0x1963504")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x3D59FF4", Offset = "0x3D59FF4", VA = "0x3D59FF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963514", Offset = "0x1963514")]
			private set
			{
			}
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x3D59E24", Offset = "0x3D59E24", VA = "0x3D59E24")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x3D46FBC", Offset = "0x3D46FBC", VA = "0x3D46FBC")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x3D5A000", Offset = "0x3D5A000", VA = "0x3D5A000")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x3D47B68", Offset = "0x3D47B68", VA = "0x3D47B68")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x3D47B74", Offset = "0x3D47B74", VA = "0x3D47B74")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x3D5A2EC", Offset = "0x3D5A2EC", VA = "0x3D5A2EC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x3D5A524", Offset = "0x3D5A524", VA = "0x3D5A524")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x3D49000", Offset = "0x3D49000", VA = "0x3D49000")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x3D5A0AC", Offset = "0x3D5A0AC", VA = "0x3D5A0AC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x3D5A1CC", Offset = "0x3D5A1CC", VA = "0x3D5A1CC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B0D8", Offset = "0x195B0D8")]
		public float positionWeight;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B0F0", Offset = "0x195B0F0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B108", Offset = "0x195B108")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B118", Offset = "0x195B118")]
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
			[Address(RVA = "0x42ADF38", Offset = "0x42ADF38", VA = "0x42ADF38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963524", Offset = "0x1963524")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x42ADF40", Offset = "0x42ADF40", VA = "0x42ADF40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963534", Offset = "0x1963534")]
			private set
			{
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x42ADED0", Offset = "0x42ADED0", VA = "0x42ADED0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x42ADF4C", Offset = "0x42ADF4C", VA = "0x42ADF4C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x42AE020", Offset = "0x42AE020", VA = "0x42AE020")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x42AE15C", Offset = "0x42AE15C", VA = "0x42AE15C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x42AE2B4", Offset = "0x42AE2B4", VA = "0x42AE2B4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x42AE5A4", Offset = "0x42AE5A4", VA = "0x42AE5A4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x42AE8B0", Offset = "0x42AE8B0", VA = "0x42AE8B0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x42AEA44", Offset = "0x42AEA44", VA = "0x42AEA44")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x42AEAF0", Offset = "0x42AEAF0", VA = "0x42AEAF0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x42AF130", Offset = "0x42AF130", VA = "0x42AF130")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x42AF1A0", Offset = "0x42AF1A0", VA = "0x42AF1A0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x42AF3AC", Offset = "0x42AF3AC", VA = "0x42AF3AC")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x42AF6E0", Offset = "0x42AF6E0", VA = "0x42AF6E0")]
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
				[Address(RVA = "0x42AFF18", Offset = "0x42AFF18", VA = "0x42AFF18")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000095")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x42B0084", Offset = "0x42B0084", VA = "0x42B0084")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000096")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x42B065C", Offset = "0x42B065C", VA = "0x42B065C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x42AFEF0", Offset = "0x42AFEF0", VA = "0x42AFEF0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x42AFFE4", Offset = "0x42AFFE4", VA = "0x42AFFE4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x42B0034", Offset = "0x42B0034", VA = "0x42B0034")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x42B0094", Offset = "0x42B0094", VA = "0x42B0094")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x42B017C", Offset = "0x42B017C", VA = "0x42B017C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x42B0184", Offset = "0x42B0184", VA = "0x42B0184")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x42B0314", Offset = "0x42B0314", VA = "0x42B0314")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x42B0420", Offset = "0x42B0420", VA = "0x42B0420")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x42B04AC", Offset = "0x42B04AC", VA = "0x42B04AC")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x42B0880", Offset = "0x42B0880", VA = "0x42B0880")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x42B08B8", Offset = "0x42B08B8", VA = "0x42B08B8")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x42B08F0", Offset = "0x42B08F0", VA = "0x42B08F0")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x42B0918", Offset = "0x42B0918", VA = "0x42B0918")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x42B0A40", Offset = "0x42B0A40", VA = "0x42B0A40")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x42B0D78", Offset = "0x42B0D78", VA = "0x42B0D78")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x42B0DA8", Offset = "0x42B0DA8", VA = "0x42B0DA8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x42B0F40", Offset = "0x42B0F40", VA = "0x42B0F40")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x42B0FB0", Offset = "0x42B0FB0", VA = "0x42B0FB0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x42B11F4", Offset = "0x42B11F4", VA = "0x42B11F4")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x42B141C", Offset = "0x42B141C", VA = "0x42B141C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x42B1534", Offset = "0x42B1534", VA = "0x42B1534")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x42B0B80", Offset = "0x42B0B80", VA = "0x42B0B80")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x42B16C4", Offset = "0x42B16C4", VA = "0x42B16C4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x42AFCB0", Offset = "0x42AFCB0", VA = "0x42AFCB0", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x42AFCB8", Offset = "0x42AFCB8", VA = "0x42AFCB8", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x42AFCBC", Offset = "0x42AFCBC", VA = "0x42AFCBC")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x42AFDE0", Offset = "0x42AFDE0", VA = "0x42AFDE0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x42AFEE8", Offset = "0x42AFEE8", VA = "0x42AFEE8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B130", Offset = "0x195B130")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x42B16E0", Offset = "0x42B16E0", VA = "0x42B16E0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x42B1780", Offset = "0x42B1780", VA = "0x42B1780")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x42B1804", Offset = "0x42B1804", VA = "0x42B1804")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x42B189C", Offset = "0x42B189C", VA = "0x42B189C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x42B18B4", Offset = "0x42B18B4", VA = "0x42B18B4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x42B18D0", Offset = "0x42B18D0", VA = "0x42B18D0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x42B196C", Offset = "0x42B196C", VA = "0x42B196C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x42B1984", Offset = "0x42B1984", VA = "0x42B1984")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B148", Offset = "0x195B148")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B160", Offset = "0x195B160")]
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
		[Address(RVA = "0x42B19A8", Offset = "0x42B19A8", VA = "0x42B19A8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x42B1A2C", Offset = "0x42B1A2C", VA = "0x42B1A2C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x42B1B00", Offset = "0x42B1B00", VA = "0x42B1B00")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x42B1E54", Offset = "0x42B1E54", VA = "0x42B1E54")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x42B1F5C", Offset = "0x42B1F5C", VA = "0x42B1F5C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x42B2090", Offset = "0x42B2090", VA = "0x42B2090")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x42B209C", Offset = "0x42B209C", VA = "0x42B209C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x42B2144", Offset = "0x42B2144", VA = "0x42B2144")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x42B21FC", Offset = "0x42B21FC", VA = "0x42B21FC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x42B246C", Offset = "0x42B246C", VA = "0x42B246C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x42B2524", Offset = "0x42B2524", VA = "0x42B2524")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B178", Offset = "0x195B178")]
		public int iterations;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B190", Offset = "0x195B190")]
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
		[Address(RVA = "0x42B268C", Offset = "0x42B268C", VA = "0x42B268C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x42B297C", Offset = "0x42B297C", VA = "0x42B297C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x42B2A98", Offset = "0x42B2A98", VA = "0x42B2A98")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x42B2BF0", Offset = "0x42B2BF0", VA = "0x42B2BF0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x42B2C00", Offset = "0x42B2C00", VA = "0x42B2C00")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x42B2C68", Offset = "0x42B2C68", VA = "0x42B2C68")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x42B2CE8", Offset = "0x42B2CE8", VA = "0x42B2CE8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x42B333C", Offset = "0x42B333C", VA = "0x42B333C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x42B3374", Offset = "0x42B3374", VA = "0x42B3374")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x42B3654", Offset = "0x42B3654", VA = "0x42B3654")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x42B3A00", Offset = "0x42B3A00", VA = "0x42B3A00")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x42B3AEC", Offset = "0x42B3AEC", VA = "0x42B3AEC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x42B3BB4", Offset = "0x42B3BB4", VA = "0x42B3BB4")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195D67C", Offset = "0x195D67C")]
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
			[Address(RVA = "0x42B5828", Offset = "0x42B5828", VA = "0x42B5828")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x42B5878", Offset = "0x42B5878", VA = "0x42B5878")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x42B5A00", Offset = "0x42B5A00", VA = "0x42B5A00")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x42B5A38", Offset = "0x42B5A38", VA = "0x42B5A38")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x42B5A70", Offset = "0x42B5A70", VA = "0x42B5A70")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x42B5AC0", Offset = "0x42B5AC0", VA = "0x42B5AC0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x42B52FC", Offset = "0x42B52FC", VA = "0x42B52FC")]
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
				[Address(RVA = "0x42B48CC", Offset = "0x42B48CC", VA = "0x42B48CC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x42B49C0", Offset = "0x42B49C0", VA = "0x42B49C0")]
				set
				{
				}
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x42B4A48", Offset = "0x42B4A48", VA = "0x42B4A48")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x42B4D08", Offset = "0x42B4D08", VA = "0x42B4D08")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x42B4FE8", Offset = "0x42B4FE8", VA = "0x42B4FE8")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x42B5250", Offset = "0x42B5250", VA = "0x42B5250")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x42B5278", Offset = "0x42B5278", VA = "0x42B5278")]
			public Bone()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x42B537C", Offset = "0x42B537C", VA = "0x42B537C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x42B5414", Offset = "0x42B5414", VA = "0x42B5414")]
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
			[Address(RVA = "0x42B57C4", Offset = "0x42B57C4", VA = "0x42B57C4")]
			public Node()
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x42B57C8", Offset = "0x42B57C8", VA = "0x42B57C8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x42B57F0", Offset = "0x42B57F0", VA = "0x42B57F0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B1C8", Offset = "0x195B1C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B1C8", Offset = "0x195B1C8")]
		public float IKPositionWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B21C", Offset = "0x195B21C")]
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
			[Address(RVA = "0x42B431C", Offset = "0x42B431C", VA = "0x42B431C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963544", Offset = "0x1963544")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x42B4324", Offset = "0x42B4324", VA = "0x42B4324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963554", Offset = "0x1963554")]
			private set
			{
			}
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x42B3E94", Offset = "0x42B3E94", VA = "0x42B3E94")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x42B3F10", Offset = "0x42B3F10", VA = "0x42B3F10")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x42AFC40", Offset = "0x42AFC40", VA = "0x42AFC40")]
		public void Update()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x42B4270", Offset = "0x42B4270", VA = "0x42B4270", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x42B427C", Offset = "0x42B427C", VA = "0x42B427C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x42B4288", Offset = "0x42B4288", VA = "0x42B4288")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x42B4290", Offset = "0x42B4290", VA = "0x42B4290")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x42B4314", Offset = "0x42B4314", VA = "0x42B4314")]
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
		[Address(RVA = "0x42B4330", Offset = "0x42B4330", VA = "0x42B4330")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x42B4348", Offset = "0x42B4348", VA = "0x42B4348")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x42B4484", Offset = "0x42B4484", VA = "0x42B4484")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x42B4530", Offset = "0x42B4530", VA = "0x42B4530")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x42B48B4", Offset = "0x42B48B4", VA = "0x42B48B4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B264", Offset = "0x195B264")]
		public float poleWeight;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B27C", Offset = "0x195B27C")]
		public float clampWeight;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B294", Offset = "0x195B294")]
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
			[Address(RVA = "0x42B5C58", Offset = "0x42B5C58", VA = "0x42B5C58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x42B5D24", Offset = "0x42B5D24", VA = "0x42B5D24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		protected override int minBones
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x42B6A94", Offset = "0x42B6A94", VA = "0x42B6A94", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x42B7038", Offset = "0x42B7038", VA = "0x42B7038", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x42B5B58", Offset = "0x42B5B58", VA = "0x42B5B58")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x42B5DF0", Offset = "0x42B5DF0", VA = "0x42B5DF0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x42B6070", Offset = "0x42B6070", VA = "0x42B6070", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x42B69E0", Offset = "0x42B69E0", VA = "0x42B69E0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x42B6608", Offset = "0x42B6608", VA = "0x42B6608")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x42B6A9C", Offset = "0x42B6A9C", VA = "0x42B6A9C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x42B70AC", Offset = "0x42B70AC", VA = "0x42B70AC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B2AC", Offset = "0x195B2AC")]
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
		[Address(RVA = "0x42B71BC", Offset = "0x42B71BC", VA = "0x42B71BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x42B7530", Offset = "0x42B7530", VA = "0x42B7530")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x42B759C", Offset = "0x42B759C", VA = "0x42B759C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x42B76F8", Offset = "0x42B76F8", VA = "0x42B76F8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x42B7890", Offset = "0x42B7890", VA = "0x42B7890", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x42B78DC", Offset = "0x42B78DC", VA = "0x42B78DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x42B793C", Offset = "0x42B793C", VA = "0x42B793C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x42B7CAC", Offset = "0x42B7CAC", VA = "0x42B7CAC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x42B7CD8", Offset = "0x42B7CD8", VA = "0x42B7CD8")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x42B79A0", Offset = "0x42B79A0", VA = "0x42B79A0")]
		private void Read()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x42B7D4C", Offset = "0x42B7D4C", VA = "0x42B7D4C")]
		private void Write()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x42B7ED8", Offset = "0x42B7ED8", VA = "0x42B7ED8")]
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
		[Address(RVA = "0x42B8028", Offset = "0x42B8028", VA = "0x42B8028")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x42B80D8", Offset = "0x42B80D8", VA = "0x42B80D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x42B86CC", Offset = "0x42B86CC", VA = "0x42B86CC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x42B8E1C", Offset = "0x42B8E1C", VA = "0x42B8E1C")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x42B9570", Offset = "0x42B9570", VA = "0x42B9570")]
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
			[Address(RVA = "0x42BA790", Offset = "0x42BA790", VA = "0x42BA790", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x42B9574", Offset = "0x42B9574", VA = "0x42B9574")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x42B9CBC", Offset = "0x42B9CBC", VA = "0x42B9CBC")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x42B9DF4", Offset = "0x42B9DF4", VA = "0x42B9DF4", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x42B9E8C", Offset = "0x42B9E8C", VA = "0x42B9E8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x42BA430", Offset = "0x42BA430", VA = "0x42BA430", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x42BA798", Offset = "0x42BA798", VA = "0x42BA798")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x42B9648", Offset = "0x42B9648", VA = "0x42B9648")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x42B9DA0", Offset = "0x42B9DA0", VA = "0x42B9DA0")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x42BA734", Offset = "0x42BA734", VA = "0x42BA734")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x42B9AE4", Offset = "0x42B9AE4", VA = "0x42B9AE4")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x42BAFD8", Offset = "0x42BAFD8", VA = "0x42BAFD8")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x42BB0E8", Offset = "0x42BB0E8", VA = "0x42BB0E8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x42BB214", Offset = "0x42BB214", VA = "0x42BB214")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x42BB32C", Offset = "0x42BB32C", VA = "0x42BB32C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x42BA198", Offset = "0x42BA198", VA = "0x42BA198")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x42BA2E4", Offset = "0x42BA2E4", VA = "0x42BA2E4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x42BB518", Offset = "0x42BB518", VA = "0x42BB518")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x42BAA50", Offset = "0x42BAA50", VA = "0x42BAA50")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x42B9D90", Offset = "0x42B9D90", VA = "0x42B9D90")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x42BBC80", Offset = "0x42BBC80", VA = "0x42BBC80")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x42BB6EC", Offset = "0x42BB6EC", VA = "0x42BB6EC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x42BA8B0", Offset = "0x42BA8B0", VA = "0x42BA8B0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x42BA98C", Offset = "0x42BA98C", VA = "0x42BA98C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x42BBD4C", Offset = "0x42BBD4C", VA = "0x42BBD4C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B2C4", Offset = "0x195B2C4")]
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
		[Address(RVA = "0x42BBDC0", Offset = "0x42BBDC0", VA = "0x42BBDC0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x42BC68C", Offset = "0x42BC68C", VA = "0x42BC68C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x42BC724", Offset = "0x42BC724", VA = "0x42BC724", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x42BC7C4", Offset = "0x42BC7C4", VA = "0x42BC7C4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x42BC8C4", Offset = "0x42BC8C4", VA = "0x42BC8C4")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x42BC960", Offset = "0x42BC960", VA = "0x42BC960", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x42BCEC8", Offset = "0x42BCEC8", VA = "0x42BCEC8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x42BD0C8", Offset = "0x42BD0C8", VA = "0x42BD0C8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x42BCF78", Offset = "0x42BCF78", VA = "0x42BCF78")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x42BCB94", Offset = "0x42BCB94", VA = "0x42BCB94")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x42BD160", Offset = "0x42BD160", VA = "0x42BD160")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B2DC", Offset = "0x195B2DC")]
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
		[Address(RVA = "0x42BD1D8", Offset = "0x42BD1D8", VA = "0x42BD1D8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x42BD2CC", Offset = "0x42BD2CC", VA = "0x42BD2CC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x42BD328", Offset = "0x42BD328", VA = "0x42BD328")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x42AE9E8", Offset = "0x42AE9E8", VA = "0x42AE9E8")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x42AE830", Offset = "0x42AE830", VA = "0x42AE830")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x42BD45C", Offset = "0x42BD45C", VA = "0x42BD45C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x42BD604", Offset = "0x42BD604", VA = "0x42BD604", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x42BD778", Offset = "0x42BD778", VA = "0x42BD778", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x42BD978", Offset = "0x42BD978", VA = "0x42BD978", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x42BDA48", Offset = "0x42BDA48", VA = "0x42BDA48", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x42BDB24", Offset = "0x42BDB24", VA = "0x42BDB24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x42BDC94", Offset = "0x42BDC94", VA = "0x42BDC94", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x42BDE4C", Offset = "0x42BDE4C", VA = "0x42BDE4C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x42BE08C", Offset = "0x42BE08C", VA = "0x42BE08C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x42BE34C", Offset = "0x42BE34C", VA = "0x42BE34C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x42BE390", Offset = "0x42BE390", VA = "0x42BE390", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x42BE474", Offset = "0x42BE474", VA = "0x42BE474")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B2F4", Offset = "0x195B2F4")]
		public float spineStiffness;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B30C", Offset = "0x195B30C")]
		public float pullBodyVertical;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B324", Offset = "0x195B324")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B33C", Offset = "0x195B33C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000031")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x42BE554", Offset = "0x42BE554", VA = "0x42BE554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x42BE69C", Offset = "0x42BE69C", VA = "0x42BE69C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x42BE6A4", Offset = "0x42BE6A4", VA = "0x42BE6A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x42BE6AC", Offset = "0x42BE6AC", VA = "0x42BE6AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x42BE6B4", Offset = "0x42BE6B4", VA = "0x42BE6B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x42BE6BC", Offset = "0x42BE6BC", VA = "0x42BE6BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x42BE6C4", Offset = "0x42BE6C4", VA = "0x42BE6C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x42BE6CC", Offset = "0x42BE6CC", VA = "0x42BE6CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x42BE6D4", Offset = "0x42BE6D4", VA = "0x42BE6D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x42BE6DC", Offset = "0x42BE6DC", VA = "0x42BE6DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x42BE714", Offset = "0x42BE714", VA = "0x42BE714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x42BE74C", Offset = "0x42BE74C", VA = "0x42BE74C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x42BE784", Offset = "0x42BE784", VA = "0x42BE784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x42BE7BC", Offset = "0x42BE7BC", VA = "0x42BE7BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x42BE7F0", Offset = "0x42BE7F0", VA = "0x42BE7F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x42BE828", Offset = "0x42BE828", VA = "0x42BE828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x42BE860", Offset = "0x42BE860", VA = "0x42BE860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x42BE898", Offset = "0x42BE898", VA = "0x42BE898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x42C07F0", Offset = "0x42C07F0", VA = "0x42C07F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963564", Offset = "0x1963564")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x42C07FC", Offset = "0x42C07FC", VA = "0x42C07FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963574", Offset = "0x1963574")]
			private set
			{
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x42BE8CC", Offset = "0x42BE8CC", VA = "0x42BE8CC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x42BE9D8", Offset = "0x42BE9D8", VA = "0x42BE9D8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x42BE920", Offset = "0x42BE920", VA = "0x42BE920")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x42BEAB4", Offset = "0x42BEAB4", VA = "0x42BEAB4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x42BE55C", Offset = "0x42BE55C", VA = "0x42BE55C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x42BEB84", Offset = "0x42BEB84", VA = "0x42BEB84")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x42BEC3C", Offset = "0x42BEC3C", VA = "0x42BEC3C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x42BECF0", Offset = "0x42BECF0", VA = "0x42BECF0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x42BEDA4", Offset = "0x42BEDA4", VA = "0x42BEDA4")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x42BEDAC", Offset = "0x42BEDAC", VA = "0x42BEDAC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x42BEDE0", Offset = "0x42BEDE0", VA = "0x42BEDE0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x42BEEA8", Offset = "0x42BEEA8", VA = "0x42BEEA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x42BF038", Offset = "0x42BF038", VA = "0x42BF038")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x42C010C", Offset = "0x42C010C", VA = "0x42C010C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x42C05A0", Offset = "0x42C05A0", VA = "0x42C05A0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x42C0600", Offset = "0x42C0600", VA = "0x42C0600")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x42C0420", Offset = "0x42C0420", VA = "0x42C0420")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x42C04E0", Offset = "0x42C04E0", VA = "0x42C04E0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x42C0808", Offset = "0x42C0808", VA = "0x42C0808")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x42C08E4", Offset = "0x42C08E4", VA = "0x42C08E4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x42C0A28", Offset = "0x42C0A28", VA = "0x42C0A28")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x42C0BB8", Offset = "0x42C0BB8", VA = "0x42C0BB8")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x42C0DB8", Offset = "0x42C0DB8", VA = "0x42C0DB8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x42C0FB8", Offset = "0x42C0FB8", VA = "0x42C0FB8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x42C12E8", Offset = "0x42C12E8", VA = "0x42C12E8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x42C13E8", Offset = "0x42C13E8", VA = "0x42C13E8")]
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
			[Address(RVA = "0x42C1C20", Offset = "0x42C1C20", VA = "0x42C1C20", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x42C1C28", Offset = "0x42C1C28", VA = "0x42C1C28", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x42C1C30", Offset = "0x42C1C30", VA = "0x42C1C30", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x42C1C40", Offset = "0x42C1C40", VA = "0x42C1C40", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000048")]
		protected float positionOffset
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x42B8D58", Offset = "0x42B8D58", VA = "0x42B8D58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x42C13F4", Offset = "0x42C13F4", VA = "0x42C13F4")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x42C1580", Offset = "0x42C1580", VA = "0x42C1580")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x42C16BC", Offset = "0x42C16BC", VA = "0x42C16BC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x42C1724", Offset = "0x42C1724", VA = "0x42C1724", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x42C17A0", Offset = "0x42C17A0", VA = "0x42C17A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x42C1B24", Offset = "0x42C1B24", VA = "0x42C1B24", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x42C1B2C", Offset = "0x42C1B2C", VA = "0x42C1B2C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x42C1C38", Offset = "0x42C1C38", VA = "0x42C1C38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x42C1C3C", Offset = "0x42C1C3C", VA = "0x42C1C3C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x42B8158", Offset = "0x42B8158", VA = "0x42B8158")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x42B89C0", Offset = "0x42B89C0", VA = "0x42B89C0")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x42C1D74", Offset = "0x42C1D74", VA = "0x42C1D74")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x42B7140", Offset = "0x42B7140", VA = "0x42B7140")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B34C", Offset = "0x195B34C")]
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
		[Address(RVA = "0x42C2028", Offset = "0x42C2028", VA = "0x42C2028", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x42C239C", Offset = "0x42C239C", VA = "0x42C239C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x42C2408", Offset = "0x42C2408", VA = "0x42C2408", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x42C2564", Offset = "0x42C2564", VA = "0x42C2564", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x42C26FC", Offset = "0x42C26FC", VA = "0x42C26FC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x42C2748", Offset = "0x42C2748", VA = "0x42C2748", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x42C27A8", Offset = "0x42C27A8", VA = "0x42C27A8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x42C2B18", Offset = "0x42C2B18", VA = "0x42C2B18", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x42C2B44", Offset = "0x42C2B44", VA = "0x42C2B44")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x42C280C", Offset = "0x42C280C", VA = "0x42C280C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x42C2C54", Offset = "0x42C2C54", VA = "0x42C2C54")]
		private void Write()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x42C2DE0", Offset = "0x42C2DE0", VA = "0x42C2DE0")]
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
			[Address(RVA = "0x42C548C", Offset = "0x42C548C", VA = "0x42C548C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B364", Offset = "0x195B364")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B37C", Offset = "0x195B37C")]
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
			[Address(RVA = "0x42C4470", Offset = "0x42C4470", VA = "0x42C4470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x42C2F30", Offset = "0x42C2F30", VA = "0x42C2F30")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x42C2F80", Offset = "0x42C2F80", VA = "0x42C2F80")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x42C2FCC", Offset = "0x42C2FCC", VA = "0x42C2FCC", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x42C3644", Offset = "0x42C3644", VA = "0x42C3644", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x42C4224", Offset = "0x42C4224", VA = "0x42C4224", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x42C436C", Offset = "0x42C436C", VA = "0x42C436C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x42C43E4", Offset = "0x42C43E4", VA = "0x42C43E4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x42C3340", Offset = "0x42C3340", VA = "0x42C3340")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x42C3770", Offset = "0x42C3770", VA = "0x42C3770")]
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
				[Address(RVA = "0x42C753C", Offset = "0x42C753C", VA = "0x42C753C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x42C7C88", Offset = "0x42C7C88", VA = "0x42C7C88")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x42C66D8", Offset = "0x42C66D8", VA = "0x42C66D8")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x42C6A14", Offset = "0x42C6A14", VA = "0x42C6A14")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x42C7940", Offset = "0x42C7940", VA = "0x42C7940")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B394", Offset = "0x195B394")]
		public float bodyWeight;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B3AC", Offset = "0x195B3AC")]
		public float headWeight;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B3C4", Offset = "0x195B3C4")]
		public float eyesWeight;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B3DC", Offset = "0x195B3DC")]
		public float clampWeight;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B3F4", Offset = "0x195B3F4")]
		public float clampWeightHead;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B40C", Offset = "0x195B40C")]
		public float clampWeightEyes;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B424", Offset = "0x195B424")]
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
			[Address(RVA = "0x42C5E3C", Offset = "0x42C5E3C", VA = "0x42C5E3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x42C6014", Offset = "0x42C6014", VA = "0x42C6014")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x42C5F20", Offset = "0x42C5F20", VA = "0x42C5F20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x42C6038", Offset = "0x42C6038", VA = "0x42C6038")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x42C5F30", Offset = "0x42C5F30", VA = "0x42C5F30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x42C60B4", Offset = "0x42C60B4", VA = "0x42C60B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x42C54EC", Offset = "0x42C54EC", VA = "0x42C54EC")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x42C5570", Offset = "0x42C5570", VA = "0x42C5570")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x42C561C", Offset = "0x42C561C", VA = "0x42C561C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x42C56E4", Offset = "0x42C56E4", VA = "0x42C56E4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x42C57D0", Offset = "0x42C57D0", VA = "0x42C57D0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x42C58DC", Offset = "0x42C58DC", VA = "0x42C58DC")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x42C5A24", Offset = "0x42C5A24", VA = "0x42C5A24", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x42C5B54", Offset = "0x42C5B54", VA = "0x42C5B54")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x42C5B60", Offset = "0x42C5B60", VA = "0x42C5B60", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x42C5CA8", Offset = "0x42C5CA8", VA = "0x42C5CA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x42C60D8", Offset = "0x42C60D8", VA = "0x42C60D8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x42C6310", Offset = "0x42C6310", VA = "0x42C6310", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x42C64B0", Offset = "0x42C64B0", VA = "0x42C64B0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x42C6704", Offset = "0x42C6704", VA = "0x42C6704", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x42C6B50", Offset = "0x42C6B50", VA = "0x42C6B50", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x42C6C54", Offset = "0x42C6C54", VA = "0x42C6C54")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x42C6E80", Offset = "0x42C6E80", VA = "0x42C6E80")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x42C70DC", Offset = "0x42C70DC", VA = "0x42C70DC")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x42C7608", Offset = "0x42C7608", VA = "0x42C7608")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x42C6560", Offset = "0x42C6560", VA = "0x42C6560")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x42C7AA8", Offset = "0x42C7AA8", VA = "0x42C7AA8")]
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
			[Address(RVA = "0x42C9260", Offset = "0x42C9260", VA = "0x42C9260")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x42C9EE4", Offset = "0x42C9EE4", VA = "0x42C9EE4")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x42C9B0C", Offset = "0x42C9B0C", VA = "0x42C9B0C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x42CA0BC", Offset = "0x42CA0BC", VA = "0x42CA0BC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B43C", Offset = "0x195B43C")]
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
		[Address(RVA = "0x42C7C90", Offset = "0x42C7C90", VA = "0x42C7C90")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x42C7E80", Offset = "0x42C7E80", VA = "0x42C7E80")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x42C8034", Offset = "0x42C8034", VA = "0x42C8034")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x42C8040", Offset = "0x42C8040", VA = "0x42C8040")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x42C80C4", Offset = "0x42C80C4", VA = "0x42C80C4")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x42C80D0", Offset = "0x42C80D0", VA = "0x42C80D0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x42C80D8", Offset = "0x42C80D8", VA = "0x42C80D8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x42C81DC", Offset = "0x42C81DC", VA = "0x42C81DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x42C82FC", Offset = "0x42C82FC", VA = "0x42C82FC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x42C8348", Offset = "0x42C8348", VA = "0x42C8348", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x42C83A8", Offset = "0x42C83A8", VA = "0x42C83A8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x42C8784", Offset = "0x42C8784", VA = "0x42C8784")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x42C87DC", Offset = "0x42C87DC", VA = "0x42C87DC")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x42C8D84", Offset = "0x42C8D84", VA = "0x42C8D84")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x42C8F9C", Offset = "0x42C8F9C", VA = "0x42C8F9C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x42C9158", Offset = "0x42C9158", VA = "0x42C9158")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x42C90D4", Offset = "0x42C90D4", VA = "0x42C90D4")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x42C9400", Offset = "0x42C9400", VA = "0x42C9400", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x42C9FA0", Offset = "0x42C9FA0", VA = "0x42C9FA0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x42C9FA4", Offset = "0x42C9FA4", VA = "0x42C9FA4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x42C9FA8", Offset = "0x42C9FA8", VA = "0x42C9FA8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x42C9BD8", Offset = "0x42C9BD8", VA = "0x42C9BD8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x42C9FAC", Offset = "0x42C9FAC", VA = "0x42C9FAC")]
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
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x195D694", Offset = "0x195D694")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D694", Offset = "0x195D694")]
			public Transform target;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D6F4", Offset = "0x195D6F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195D6F4", Offset = "0x195D6F4")]
			public float positionWeight;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D748", Offset = "0x195D748")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195D748", Offset = "0x195D748")]
			public float rotationWeight;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x195D79C", Offset = "0x195D79C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D79C", Offset = "0x195D79C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195D79C", Offset = "0x195D79C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D814", Offset = "0x195D814")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195D814", Offset = "0x195D814")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D8EC", Offset = "0x195D8EC")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195D8EC", Offset = "0x195D8EC")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D9CC", Offset = "0x195D9CC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195D9CC", Offset = "0x195D9CC")]
			public float shoulderYawOffset;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DAA4", Offset = "0x195DAA4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195DAA4", Offset = "0x195DAA4")]
			public float shoulderPitchOffset;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x195DB7C", Offset = "0x195DB7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DB7C", Offset = "0x195DB7C")]
			public Transform bendGoal;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DBDC", Offset = "0x195DBDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195DBDC", Offset = "0x195DBDC")]
			public float bendGoalWeight;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DC30", Offset = "0x195DC30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195DC30", Offset = "0x195DC30")]
			public float swivelOffset;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DC8C", Offset = "0x195DC8C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DCC4", Offset = "0x195DCC4")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x195DCFC", Offset = "0x195DCFC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DCFC", Offset = "0x195DCFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195DCFC", Offset = "0x195DCFC")]
			public float armLengthMlp;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DD78", Offset = "0x195DD78")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195DDF0", Offset = "0x195DDF0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195DE00", Offset = "0x195DE00")]
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
				[Address(RVA = "0x42D3744", Offset = "0x42D3744", VA = "0x42D3744")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19645E8", Offset = "0x19645E8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x42D3750", Offset = "0x42D3750", VA = "0x42D3750")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19645F8", Offset = "0x19645F8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public Quaternion rotation
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x42D375C", Offset = "0x42D375C", VA = "0x42D375C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964608", Offset = "0x1964608")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600061B")]
				[Address(RVA = "0x42D3768", Offset = "0x42D3768", VA = "0x42D3768")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964618", Offset = "0x1964618")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x42D3774", Offset = "0x42D3774", VA = "0x42D3774")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x42D37A8", Offset = "0x42D37A8", VA = "0x42D37A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009D")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x42D37E8", Offset = "0x42D37E8", VA = "0x42D37E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private VirtualBone hand
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x42D3834", Offset = "0x42D3834", VA = "0x42D3834")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x42D3880", Offset = "0x42D3880", VA = "0x42D3880", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x42D4204", Offset = "0x42D4204", VA = "0x42D4204", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x42D43F8", Offset = "0x42D43F8", VA = "0x42D43F8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x42D44A4", Offset = "0x42D44A4", VA = "0x42D44A4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x42D14C4", Offset = "0x42D14C4", VA = "0x42D14C4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x42D50F0", Offset = "0x42D50F0", VA = "0x42D50F0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x42D5160", Offset = "0x42D5160", VA = "0x42D5160", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x42D48BC", Offset = "0x42D48BC", VA = "0x42D48BC")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x42D4994", Offset = "0x42D4994", VA = "0x42D4994")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x42D5380", Offset = "0x42D5380", VA = "0x42D5380")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x42D33AC", Offset = "0x42D33AC", VA = "0x42D33AC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195DE10", Offset = "0x195DE10")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195DE20", Offset = "0x195DE20")]
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
				[Address(RVA = "0x42D5540", Offset = "0x42D5540", VA = "0x42D5540")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964628", Offset = "0x1964628")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x42D5548", Offset = "0x42D5548", VA = "0x42D5548")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964638", Offset = "0x1964638")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public float mag
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x42D5550", Offset = "0x42D5550", VA = "0x42D5550")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964648", Offset = "0x1964648")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x42D5558", Offset = "0x42D5558", VA = "0x42D5558")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964658", Offset = "0x1964658")]
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
			[Address(RVA = "0x42D5560", Offset = "0x42D5560", VA = "0x42D5560")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x42CDFDC", Offset = "0x42CDFDC", VA = "0x42CDFDC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x42D5568", Offset = "0x42D5568", VA = "0x42D5568")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x42D56D4", Offset = "0x42D56D4", VA = "0x42D56D4")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x42D5780", Offset = "0x42D5780", VA = "0x42D5780")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x42D1048", Offset = "0x42D1048", VA = "0x42D1048")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x42D4F4C", Offset = "0x42D4F4C", VA = "0x42D4F4C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x42D57D4", Offset = "0x42D57D4", VA = "0x42D57D4")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x42D5918", Offset = "0x42D5918", VA = "0x42D5918")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x42D54A8", Offset = "0x42D54A8", VA = "0x42D54A8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195DE40", Offset = "0x195DE40")]
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
				[Address(RVA = "0x42D5940", Offset = "0x42D5940", VA = "0x42D5940")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A2")]
			public float stepProgress
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x42D5954", Offset = "0x42D5954", VA = "0x42D5954")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964668", Offset = "0x1964668")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x42D595C", Offset = "0x42D595C", VA = "0x42D595C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964678", Offset = "0x1964678")]
				private set
				{
				}
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x42D5964", Offset = "0x42D5964", VA = "0x42D5964")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x42D5AF4", Offset = "0x42D5AF4", VA = "0x42D5AF4")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x42D5B3C", Offset = "0x42D5B3C", VA = "0x42D5B3C")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x42D5D0C", Offset = "0x42D5D0C", VA = "0x42D5D0C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x42D5EC0", Offset = "0x42D5EC0", VA = "0x42D5EC0")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x42D60A4", Offset = "0x42D60A4", VA = "0x42D60A4")]
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
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x195DE50", Offset = "0x195DE50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DE50", Offset = "0x195DE50")]
			public Transform target;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DEB0", Offset = "0x195DEB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195DEB0", Offset = "0x195DEB0")]
			public float positionWeight;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DF04", Offset = "0x195DF04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195DF04", Offset = "0x195DF04")]
			public float rotationWeight;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x195DF58", Offset = "0x195DF58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DF58", Offset = "0x195DF58")]
			public Transform bendGoal;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195DFB8", Offset = "0x195DFB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195DFB8", Offset = "0x195DFB8")]
			public float bendGoalWeight;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E00C", Offset = "0x195E00C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195E00C", Offset = "0x195E00C")]
			public float swivelOffset;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E068", Offset = "0x195E068")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195E068", Offset = "0x195E068")]
			public float bendToTargetWeight;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x195E0BC", Offset = "0x195E0BC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E0BC", Offset = "0x195E0BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195E0BC", Offset = "0x195E0BC")]
			public float legLengthMlp;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E138", Offset = "0x195E138")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195E1E0", Offset = "0x195E1E0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195E1F0", Offset = "0x195E1F0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195E200", Offset = "0x195E200")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195E210", Offset = "0x195E210")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195E220", Offset = "0x195E220")]
			private Vector3 <bendNormalRelToPelvis>k__BackingField;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195E230", Offset = "0x195E230")]
			private Vector3 <bendNormalRelToTarget>k__BackingField;

			[Token(Token = "0x170000A3")]
			public Vector3 position
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x42D62B8", Offset = "0x42D62B8", VA = "0x42D62B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964688", Offset = "0x1964688")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x42D62C4", Offset = "0x42D62C4", VA = "0x42D62C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964698", Offset = "0x1964698")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x42D62D0", Offset = "0x42D62D0", VA = "0x42D62D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19646A8", Offset = "0x19646A8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x42D62DC", Offset = "0x42D62DC", VA = "0x42D62DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19646B8", Offset = "0x19646B8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			public bool hasToes
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x42D62E8", Offset = "0x42D62E8", VA = "0x42D62E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19646C8", Offset = "0x19646C8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x42D62F0", Offset = "0x42D62F0", VA = "0x42D62F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19646D8", Offset = "0x19646D8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600064D")]
				[Address(RVA = "0x42D62FC", Offset = "0x42D62FC", VA = "0x42D62FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private VirtualBone calf
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0x42D6330", Offset = "0x42D6330", VA = "0x42D6330")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private VirtualBone foot
			{
				[Token(Token = "0x600064F")]
				[Address(RVA = "0x42D6368", Offset = "0x42D6368", VA = "0x42D6368")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000650")]
				[Address(RVA = "0x42D63A0", Offset = "0x42D63A0", VA = "0x42D63A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x42CFE50", Offset = "0x42CFE50", VA = "0x42CFE50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x42D63D8", Offset = "0x42D63D8", VA = "0x42D63D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19646E8", Offset = "0x19646E8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x42D63E4", Offset = "0x42D63E4", VA = "0x42D63E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19646F8", Offset = "0x19646F8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AC")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x42D63F0", Offset = "0x42D63F0", VA = "0x42D63F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964708", Offset = "0x1964708")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x42D6400", Offset = "0x42D6400", VA = "0x42D6400")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964718", Offset = "0x1964718")]
				set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x42D6410", Offset = "0x42D6410", VA = "0x42D6410")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964728", Offset = "0x1964728")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x42D6420", Offset = "0x42D6420", VA = "0x42D6420")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964738", Offset = "0x1964738")]
				set
				{
				}
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x42D6430", Offset = "0x42D6430", VA = "0x42D6430", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x42D6A74", Offset = "0x42D6A74", VA = "0x42D6A74", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x42D7374", Offset = "0x42D7374", VA = "0x42D7374", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x42D7270", Offset = "0x42D7270", VA = "0x42D7270")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x42D7038", Offset = "0x42D7038", VA = "0x42D7038")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x42D1238", Offset = "0x42D1238", VA = "0x42D1238")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x42D7E2C", Offset = "0x42D7E2C", VA = "0x42D7E2C")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x42D792C", Offset = "0x42D792C", VA = "0x42D792C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x42D8294", Offset = "0x42D8294", VA = "0x42D8294", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x42D84B0", Offset = "0x42D84B0", VA = "0x42D84B0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x42D34E8", Offset = "0x42D34E8", VA = "0x42D34E8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E240", Offset = "0x195E240")]
			public Mode mode;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E278", Offset = "0x195E278")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195E278", Offset = "0x195E278")]
			public float weight;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E2CC", Offset = "0x195E2CC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195E2CC", Offset = "0x195E2CC")]
			public float moveThreshold;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x195E390", Offset = "0x195E390")]
			[SerializeField]
			private byte animationHeader;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E45C", Offset = "0x195E45C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195E45C", Offset = "0x195E45C")]
			public float minAnimationSpeed;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E52C", Offset = "0x195E52C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195E52C", Offset = "0x195E52C")]
			public float maxAnimationSpeed;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E5F8", Offset = "0x195E5F8")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195E5F8", Offset = "0x195E5F8")]
			public float animationSmoothTime;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x195E6CC", Offset = "0x195E6CC")]
			[SerializeField]
			private byte rootPositionHeader;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E798", Offset = "0x195E798")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195E798", Offset = "0x195E798")]
			public Vector2 standOffset;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E85C", Offset = "0x195E85C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195E85C", Offset = "0x195E85C")]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E92C", Offset = "0x195E92C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195E92C", Offset = "0x195E92C")]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195E9FC", Offset = "0x195E9FC")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195E9FC", Offset = "0x195E9FC")]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195EACC", Offset = "0x195EACC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195EACC", Offset = "0x195EACC")]
			public float maxRootOffset;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x195EB90", Offset = "0x195EB90")]
			[SerializeField]
			private byte rootRotationHeader;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195EC5C", Offset = "0x195EC5C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195EC5C", Offset = "0x195EC5C")]
			public float maxRootAngleMoving;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195ED2C", Offset = "0x195ED2C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195ED2C", Offset = "0x195ED2C")]
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
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195EE0C", Offset = "0x195EE0C")]
			[SerializeField]
			private bool useCustomLocomotion;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x195EE58", Offset = "0x195EE58")]
			[SerializeField]
			private float refAnimVelocity;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195EE90", Offset = "0x195EE90")]
			[SerializeField]
			private float animVelocityScale;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195EED0", Offset = "0x195EED0")]
			[SerializeField]
			private float animSpeedSmoothTime;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x195EF14", Offset = "0x195EF14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195EF14", Offset = "0x195EF14")]
			[SerializeField]
			private float turnSmoothTime;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195EF64", Offset = "0x195EF64")]
			[SerializeField]
			private float turnThreshold;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195EFA8", Offset = "0x195EFA8")]
			[SerializeField]
			private float comfortTurnTime;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195EFE8", Offset = "0x195EFE8")]
			[SerializeField]
			private float comfortTurnThreshold;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x195F02C", Offset = "0x195F02C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195F02C", Offset = "0x195F02C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F07C", Offset = "0x195F07C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F07C", Offset = "0x195F07C")]
			public float footDistance;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F13C", Offset = "0x195F13C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F13C", Offset = "0x195F13C")]
			public float stepThreshold;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F1FC", Offset = "0x195F1FC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F1FC", Offset = "0x195F1FC")]
			public float angleThreshold;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F2BC", Offset = "0x195F2BC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F2BC", Offset = "0x195F2BC")]
			public float comAngleMlp;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F37C", Offset = "0x195F37C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F37C", Offset = "0x195F37C")]
			public float maxVelocity;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F43C", Offset = "0x195F43C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F43C", Offset = "0x195F43C")]
			public float velocityFactor;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F4FC", Offset = "0x195F4FC")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195F4FC", Offset = "0x195F4FC")]
			public float maxLegStretch;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F5C8", Offset = "0x195F5C8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F5C8", Offset = "0x195F5C8")]
			public float rootSpeed;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F688", Offset = "0x195F688")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F688", Offset = "0x195F688")]
			public float stepSpeed;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F748", Offset = "0x195F748")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F748", Offset = "0x195F748")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F808", Offset = "0x195F808")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F808", Offset = "0x195F808")]
			public float maxBodyYOffset;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F8C8", Offset = "0x195F8C8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195F8C8", Offset = "0x195F8C8")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195F988", Offset = "0x195F988")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x195F988", Offset = "0x195F988")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FA54", Offset = "0x195FA54")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195FA54", Offset = "0x195FA54")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FB14", Offset = "0x195FB14")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195FB14", Offset = "0x195FB14")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FBD4", Offset = "0x195FBD4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195FBD4", Offset = "0x195FBD4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195FD44", Offset = "0x195FD44")]
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
				[Address(RVA = "0x42DA4F0", Offset = "0x42DA4F0", VA = "0x42DA4F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964748", Offset = "0x1964748")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000670")]
				[Address(RVA = "0x42DA500", Offset = "0x42DA500", VA = "0x42DA500")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964758", Offset = "0x1964758")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000677")]
				[Address(RVA = "0x42DA948", Offset = "0x42DA948", VA = "0x42DA948")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B0")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0x42DA988", Offset = "0x42DA988", VA = "0x42DA988")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B1")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000679")]
				[Address(RVA = "0x42DA9CC", Offset = "0x42DA9CC", VA = "0x42DA9CC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000B2")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0x42DAA0C", Offset = "0x42DAA0C", VA = "0x42DAA0C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x42CE0B0", Offset = "0x42CE0B0", VA = "0x42CE0B0")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x42CB940", Offset = "0x42CB940", VA = "0x42CB940")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x42D8BB8", Offset = "0x42D8BB8", VA = "0x42D8BB8")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x42CB070", Offset = "0x42CB070", VA = "0x42CB070")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x42CB024", Offset = "0x42CB024", VA = "0x42CB024")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x42D8868", Offset = "0x42D8868", VA = "0x42D8868")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x42D94F4", Offset = "0x42D94F4", VA = "0x42D94F4")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x42CFE90", Offset = "0x42CFE90", VA = "0x42CFE90")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x42D9000", Offset = "0x42D9000", VA = "0x42D9000")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x42D93E0", Offset = "0x42D93E0", VA = "0x42D93E0")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x42D0098", Offset = "0x42D0098", VA = "0x42D0098")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x42D95D4", Offset = "0x42D95D4", VA = "0x42D95D4")]
			private void SolveCustomLocomotion(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x42D8560", Offset = "0x42D8560", VA = "0x42D8560")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x42D8938", Offset = "0x42D8938", VA = "0x42D8938")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x42D8BBC", Offset = "0x42D8BBC", VA = "0x42D8BBC")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x42D8C20", Offset = "0x42D8C20", VA = "0x42D8C20")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x42D9228", Offset = "0x42D9228", VA = "0x42D9228")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x42CE878", Offset = "0x42CE878", VA = "0x42CE878")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x42DA550", Offset = "0x42DA550", VA = "0x42DA550")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x42DA6F8", Offset = "0x42DA6F8", VA = "0x42DA6F8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x42DA77C", Offset = "0x42DA77C", VA = "0x42DA77C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x42D35DC", Offset = "0x42D35DC", VA = "0x42D35DC")]
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
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x195FD54", Offset = "0x195FD54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FD54", Offset = "0x195FD54")]
			public Transform headTarget;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FDB4", Offset = "0x195FDB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195FDB4", Offset = "0x195FDB4")]
			public float positionWeight;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FE08", Offset = "0x195FE08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195FE08", Offset = "0x195FE08")]
			public float rotationWeight;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FE5C", Offset = "0x195FE5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195FE5C", Offset = "0x195FE5C")]
			public float headClampWeight;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FEB0", Offset = "0x195FEB0")]
			public float minHeadHeight;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FEE8", Offset = "0x195FEE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195FEE8", Offset = "0x195FEE8")]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195FF3C", Offset = "0x195FF3C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x195FF3C", Offset = "0x195FF3C")]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960014", Offset = "0x1960014")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x1960014", Offset = "0x1960014")]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x19600EC", Offset = "0x19600EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19600EC", Offset = "0x19600EC")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196014C", Offset = "0x196014C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x196014C", Offset = "0x196014C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19601A0", Offset = "0x19601A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19601A0", Offset = "0x19601A0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19601F4", Offset = "0x19601F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19601F4", Offset = "0x19601F4")]
			public float maintainPelvisPosition;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x1960248", Offset = "0x1960248")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960248", Offset = "0x1960248")]
			public Transform chestGoal;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19602A8", Offset = "0x19602A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19602A8", Offset = "0x19602A8")]
			public float chestGoalWeight;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19602FC", Offset = "0x19602FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19602FC", Offset = "0x19602FC")]
			public float chestClampWeight;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960350", Offset = "0x1960350")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1960350", Offset = "0x1960350")]
			public float rotateChestByHands;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x19603A4", Offset = "0x19603A4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19603A4", Offset = "0x19603A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19603A4", Offset = "0x19603A4")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196041C", Offset = "0x196041C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x196041C", Offset = "0x196041C")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960470", Offset = "0x1960470")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1960470", Offset = "0x1960470")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1960470", Offset = "0x1960470")]
			public float neckStiffness;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19604E8", Offset = "0x19604E8")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x1960520", Offset = "0x1960520")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960520", Offset = "0x1960520")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1960520", Offset = "0x1960520")]
			public float maxRootAngle;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196059C", Offset = "0x196059C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x196059C", Offset = "0x196059C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19606C8", Offset = "0x19606C8")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19606D8", Offset = "0x19606D8")]
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
				[Address(RVA = "0x42CB96C", Offset = "0x42CB96C", VA = "0x42CB96C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000680")]
				[Address(RVA = "0x42DAA50", Offset = "0x42DAA50", VA = "0x42DAA50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			internal VirtualBone chest
			{
				[Token(Token = "0x6000681")]
				[Address(RVA = "0x42D1470", Offset = "0x42D1470", VA = "0x42D1470")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			internal VirtualBone head
			{
				[Token(Token = "0x6000682")]
				[Address(RVA = "0x42DA510", Offset = "0x42DA510", VA = "0x42DA510")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x42DAA90", Offset = "0x42DAA90", VA = "0x42DAA90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x42DAAD0", Offset = "0x42DAAD0", VA = "0x42DAAD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964768", Offset = "0x1964768")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x42DAAE4", Offset = "0x42DAAE4", VA = "0x42DAAE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964778", Offset = "0x1964778")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B9")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x42DAAF8", Offset = "0x42DAAF8", VA = "0x42DAAF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964788", Offset = "0x1964788")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x42DAB0C", Offset = "0x42DAB0C", VA = "0x42DAB0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964798", Offset = "0x1964798")]
				private set
				{
				}
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x42DAB20", Offset = "0x42DAB20", VA = "0x42DAB20", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x42DB5A0", Offset = "0x42DB5A0", VA = "0x42DB5A0", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x42DBA68", Offset = "0x42DBA68", VA = "0x42DBA68", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x42DC0F4", Offset = "0x42DC0F4", VA = "0x42DC0F4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x42CE0FC", Offset = "0x42CE0FC", VA = "0x42CE0FC")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x42DCB58", Offset = "0x42DCB58", VA = "0x42DCB58")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x42DD228", Offset = "0x42DD228", VA = "0x42DD228")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x42DD53C", Offset = "0x42DD53C", VA = "0x42DD53C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x42DD718", Offset = "0x42DD718", VA = "0x42DD718", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x42DC368", Offset = "0x42DC368", VA = "0x42DC368")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x42D0EDC", Offset = "0x42D0EDC", VA = "0x42D0EDC")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x42DC6F8", Offset = "0x42DC6F8", VA = "0x42DC6F8")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x42DD818", Offset = "0x42DD818", VA = "0x42DD818")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x42DCFD8", Offset = "0x42DCFD8", VA = "0x42DCFD8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x42DCD20", Offset = "0x42DCD20", VA = "0x42DCD20")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x42D31E0", Offset = "0x42D31E0", VA = "0x42D31E0")]
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
			[Address(RVA = "0x3A37A0C", Offset = "0x3A37A0C", VA = "0x3A37A0C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x3A37A88", Offset = "0x3A37A88", VA = "0x3A37A88")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x3A37AA8", Offset = "0x3A37AA8", VA = "0x3A37AA8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x3A37D38", Offset = "0x3A37D38", VA = "0x3A37D38")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x3A38024", Offset = "0x3A38024", VA = "0x3A38024")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x3A3820C", Offset = "0x3A3820C", VA = "0x3A3820C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x3A38444", Offset = "0x3A38444", VA = "0x3A38444")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x3A38678", Offset = "0x3A38678", VA = "0x3A38678")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x3A38730", Offset = "0x3A38730", VA = "0x3A38730")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x3A38CDC", Offset = "0x3A38CDC", VA = "0x3A38CDC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x3A38EF4", Offset = "0x3A38EF4", VA = "0x3A38EF4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x3A39354", Offset = "0x3A39354", VA = "0x3A39354")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x3A3945C", Offset = "0x3A3945C", VA = "0x3A3945C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B454", Offset = "0x195B454")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B464", Offset = "0x195B464")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B464", Offset = "0x195B464")]
		public int LOD;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B4B8", Offset = "0x195B4B8")]
		public float scale;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B4F0", Offset = "0x195B4F0")]
		public bool plantFeet;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B528", Offset = "0x195B528")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B538", Offset = "0x195B538")]
		public Spine spine;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B570", Offset = "0x195B570")]
		public Arm leftArm;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B5A8", Offset = "0x195B5A8")]
		public Arm rightArm;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B5E0", Offset = "0x195B5E0")]
		public Leg leftLeg;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B618", Offset = "0x195B618")]
		public Leg rightLeg;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B650", Offset = "0x195B650")]
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
			[Address(RVA = "0x42CA0C4", Offset = "0x42CA0C4", VA = "0x42CA0C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963584", Offset = "0x1963584")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x42CA0CC", Offset = "0x42CA0CC", VA = "0x42CA0CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963594", Offset = "0x1963594")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x42D3020", Offset = "0x42D3020", VA = "0x42D3020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19635A4", Offset = "0x19635A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x42D3028", Offset = "0x42D3028", VA = "0x42D3028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19635B4", Offset = "0x19635B4")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x42CA0D4", Offset = "0x42CA0D4", VA = "0x42CA0D4")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x42CA558", Offset = "0x42CA558", VA = "0x42CA558")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x42CA400", Offset = "0x42CA400", VA = "0x42CA400")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x42CA92C", Offset = "0x42CA92C", VA = "0x42CA92C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x42CAC18", Offset = "0x42CAC18", VA = "0x42CAC18")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x42CACBC", Offset = "0x42CACBC", VA = "0x42CACBC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x42CAE50", Offset = "0x42CAE50", VA = "0x42CAE50")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x42CB0EC", Offset = "0x42CB0EC", VA = "0x42CB0EC")]
		public void Reset(bool resetLegChain = true)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x42CB9AC", Offset = "0x42CB9AC", VA = "0x42CB9AC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x42CBB20", Offset = "0x42CBB20", VA = "0x42CBB20", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x42CBD28", Offset = "0x42CBD28", VA = "0x42CBD28", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x42CBD9C", Offset = "0x42CBD9C", VA = "0x42CBD9C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x42CBE10", Offset = "0x42CBE10", VA = "0x42CBE10", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x42CC024", Offset = "0x42CC024", VA = "0x42CC024")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x42CA808", Offset = "0x42CA808", VA = "0x42CA808")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x42CB280", Offset = "0x42CB280", VA = "0x42CB280")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x42CC304", Offset = "0x42CC304", VA = "0x42CC304", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x42CC354", Offset = "0x42CC354", VA = "0x42CC354", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x42CDB64", Offset = "0x42CDB64", VA = "0x42CDB64")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x42CB3E8", Offset = "0x42CB3E8", VA = "0x42CB3E8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x42CC838", Offset = "0x42CC838", VA = "0x42CC838")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x42CDF50", Offset = "0x42CDF50", VA = "0x42CDF50")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x42CDF98", Offset = "0x42CDF98", VA = "0x42CDF98")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x42CDA0C", Offset = "0x42CDA0C", VA = "0x42CDA0C")]
		private void Write()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x42D2A54", Offset = "0x42D2A54", VA = "0x42D2A54")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x42D3030", Offset = "0x42D3030", VA = "0x42D3030")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B688", Offset = "0x195B688")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x3A4D2E8", Offset = "0x3A4D2E8", VA = "0x3A4D2E8")]
		public void Start()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x3A4DA88", Offset = "0x3A4DA88", VA = "0x3A4DA88")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x3A4DC20", Offset = "0x3A4DC20", VA = "0x3A4DC20")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x3A4E1A4", Offset = "0x3A4E1A4", VA = "0x3A4E1A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x3A4E26C", Offset = "0x3A4E26C", VA = "0x3A4E26C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x3A4E370", Offset = "0x3A4E370", VA = "0x3A4E370")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B6C0", Offset = "0x195B6C0")]
		public Transform transform;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B6F8", Offset = "0x195B6F8")]
		public Transform parent;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B730", Offset = "0x195B730")]
		public Transform[] children;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B768", Offset = "0x195B768")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B768", Offset = "0x195B768")]
		public float weight;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B7BC", Offset = "0x195B7BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B7BC", Offset = "0x195B7BC")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B810", Offset = "0x195B810")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195B810", Offset = "0x195B810")]
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
		[Address(RVA = "0x3A4E3D0", Offset = "0x3A4E3D0", VA = "0x3A4E3D0")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x3A4D498", Offset = "0x3A4D498", VA = "0x3A4D498")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x3A4DB60", Offset = "0x3A4DB60", VA = "0x3A4DB60")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x3A4DCE8", Offset = "0x3A4DCE8", VA = "0x3A4DCE8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B86C", Offset = "0x195B86C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B87C", Offset = "0x195B87C")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B88C", Offset = "0x195B88C")]
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
			[Address(RVA = "0x3A39D80", Offset = "0x3A39D80", VA = "0x3A39D80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19635C4", Offset = "0x19635C4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x3A39D88", Offset = "0x3A39D88", VA = "0x3A39D88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19635D4", Offset = "0x19635D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool isPaused
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x3A39D90", Offset = "0x3A39D90", VA = "0x3A39D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19635E4", Offset = "0x19635E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x3A39D98", Offset = "0x3A39D98", VA = "0x3A39D98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19635F4", Offset = "0x19635F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x3A39DA4", Offset = "0x3A39DA4", VA = "0x3A39DA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963604", Offset = "0x1963604")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x3A39DAC", Offset = "0x3A39DAC", VA = "0x3A39DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963614", Offset = "0x1963614")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool inInteraction
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x3A39DB4", Offset = "0x3A39DB4", VA = "0x3A39DB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public float progress
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x3A3C9F0", Offset = "0x3A3C9F0", VA = "0x3A3C9F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x3A39E24", Offset = "0x3A39E24", VA = "0x3A39E24")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x3A39EA8", Offset = "0x3A39EA8", VA = "0x3A39EA8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x3A39F44", Offset = "0x3A39F44", VA = "0x3A39F44")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x3A3A0BC", Offset = "0x3A3A0BC", VA = "0x3A3A0BC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x3A3A56C", Offset = "0x3A3A56C", VA = "0x3A3A56C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x3A3A92C", Offset = "0x3A3A92C", VA = "0x3A3A92C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x3A3A980", Offset = "0x3A3A980", VA = "0x3A3A980")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x3A3B630", Offset = "0x3A3B630", VA = "0x3A3B630")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x3A3C198", Offset = "0x3A3C198", VA = "0x3A3C198")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x3A3C3C0", Offset = "0x3A3C3C0", VA = "0x3A3C3C0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x3A3C89C", Offset = "0x3A3C89C", VA = "0x3A3C89C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x3A3CED8", Offset = "0x3A3CED8", VA = "0x3A3CED8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B89C", Offset = "0x195B89C")]
		public LookAtIK ik;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B8D4", Offset = "0x195B8D4")]
		public float lerpSpeed;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B90C", Offset = "0x195B90C")]
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
		[Address(RVA = "0x3A3D1C0", Offset = "0x3A3D1C0", VA = "0x3A3D1C0")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x3A3D338", Offset = "0x3A3D338", VA = "0x3A3D338")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x3A3D3E0", Offset = "0x3A3D3E0", VA = "0x3A3D3E0")]
		public void Update()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x3A3D624", Offset = "0x3A3D624", VA = "0x3A3D624")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x3A3D71C", Offset = "0x3A3D71C", VA = "0x3A3D71C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x3A3D7E8", Offset = "0x3A3D7E8", VA = "0x3A3D7E8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x195905C", Offset = "0x195905C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x195905C", Offset = "0x195905C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public class InteractionEvent
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19606E8", Offset = "0x19606E8")]
			public float time;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960720", Offset = "0x1960720")]
			public bool pause;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960758", Offset = "0x1960758")]
			public bool pickUp;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960790", Offset = "0x1960790")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19607C8", Offset = "0x19607C8")]
			public Message[] messages;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960800", Offset = "0x1960800")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x3A3CA2C", Offset = "0x3A3CA2C", VA = "0x3A3CA2C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x3A3EAE4", Offset = "0x3A3EAE4", VA = "0x3A3EAE4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960838", Offset = "0x1960838")]
			public string function;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960870", Offset = "0x1960870")]
			public GameObject recipient;

			[Token(Token = "0x4000596")]
			private const string empty = "";

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x3A3E9F4", Offset = "0x3A3E9F4", VA = "0x3A3E9F4")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x3A3EAEC", Offset = "0x3A3EAEC", VA = "0x3A3EAEC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19608A8", Offset = "0x19608A8")]
			public Animator animator;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19608E0", Offset = "0x19608E0")]
			public Animation animation;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960918", Offset = "0x1960918")]
			public string animationState;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960950", Offset = "0x1960950")]
			public float crossfadeTime;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960988", Offset = "0x1960988")]
			public int layer;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19609C0", Offset = "0x19609C0")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400059D")]
			private const string empty = "";

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x3A3E754", Offset = "0x3A3E754", VA = "0x3A3E754")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x3A3E848", Offset = "0x3A3E848", VA = "0x3A3E848")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x3A3E900", Offset = "0x3A3E900", VA = "0x3A3E900")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x3A3E9E0", Offset = "0x3A3E9E0", VA = "0x3A3E9E0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19609F8", Offset = "0x19609F8")]
			public Type type;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960A30", Offset = "0x1960A30")]
			public AnimationCurve curve;

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x3A3DF6C", Offset = "0x3A3DF6C", VA = "0x3A3DF6C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x3A3EB04", Offset = "0x3A3EB04", VA = "0x3A3EB04")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960A68", Offset = "0x1960A68")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960AA0", Offset = "0x1960AA0")]
			public float multiplier;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960AD8", Offset = "0x1960AD8")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x3A3E64C", Offset = "0x3A3E64C", VA = "0x3A3E64C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x3A3EAF4", Offset = "0x3A3EAF4", VA = "0x3A3EAF4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B954", Offset = "0x195B954")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B98C", Offset = "0x195B98C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195B9C4", Offset = "0x195B9C4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B9FC", Offset = "0x195B9FC")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BA0C", Offset = "0x195BA0C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000057")]
		public float length
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x3A3DA5C", Offset = "0x3A3DA5C", VA = "0x3A3DA5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19637E4", Offset = "0x19637E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x3A3DA64", Offset = "0x3A3DA64", VA = "0x3A3DA64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19637F4", Offset = "0x19637F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x3A3DA6C", Offset = "0x3A3DA6C", VA = "0x3A3DA6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963804", Offset = "0x1963804")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x3A3DA74", Offset = "0x3A3DA74", VA = "0x3A3DA74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963814", Offset = "0x1963814")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x3A3DC90", Offset = "0x3A3DC90", VA = "0x3A3DC90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x3A3CDAC", Offset = "0x3A3CDAC", VA = "0x3A3CDAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x3A3D7FC", Offset = "0x3A3D7FC", VA = "0x3A3D7FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963624", Offset = "0x1963624")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x3A3D848", Offset = "0x3A3D848", VA = "0x3A3D848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196365C", Offset = "0x196365C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x3A3D894", Offset = "0x3A3D894", VA = "0x3A3D894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963694", Offset = "0x1963694")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x3A3D8E0", Offset = "0x3A3D8E0", VA = "0x3A3D8E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19636CC", Offset = "0x19636CC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x3A3D92C", Offset = "0x3A3D92C", VA = "0x3A3D92C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963704", Offset = "0x1963704")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x3A3D978", Offset = "0x3A3D978", VA = "0x3A3D978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196373C", Offset = "0x196373C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x3A3D9C4", Offset = "0x3A3D9C4", VA = "0x3A3D9C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963774", Offset = "0x1963774")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x3A3DA10", Offset = "0x3A3DA10", VA = "0x3A3DA10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19637AC", Offset = "0x19637AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x3A3DA7C", Offset = "0x3A3DA7C", VA = "0x3A3DA7C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x3A3DD20", Offset = "0x3A3DD20", VA = "0x3A3DD20")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x3A3AEE4", Offset = "0x3A3AEE4", VA = "0x3A3AEE4")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x3A3DE84", Offset = "0x3A3DE84", VA = "0x3A3DE84")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x3A3ADA0", Offset = "0x3A3ADA0", VA = "0x3A3ADA0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x3A3AEDC", Offset = "0x3A3AEDC", VA = "0x3A3AEDC")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x3A3BD7C", Offset = "0x3A3BD7C", VA = "0x3A3BD7C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x3A3C674", Offset = "0x3A3C674", VA = "0x3A3C674")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x3A3E688", Offset = "0x3A3E688", VA = "0x3A3E688")]
		private void Start()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x3A3DF88", Offset = "0x3A3DF88", VA = "0x3A3DF88")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x3A3DE8C", Offset = "0x3A3DE8C", VA = "0x3A3DE8C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x3A3E5E4", Offset = "0x3A3E5E4", VA = "0x3A3E5E4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x3A3E68C", Offset = "0x3A3E68C", VA = "0x3A3E68C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x3A3E6F4", Offset = "0x3A3E6F4", VA = "0x3A3E6F4")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19590BC", Offset = "0x19590BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19590BC", Offset = "0x19590BC")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000C5")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BA1C", Offset = "0x195BA1C")]
		public string targetTag;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BA54", Offset = "0x195BA54")]
		public float fadeInTime;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BA8C", Offset = "0x195BA8C")]
		public float speed;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BAC4", Offset = "0x195BAC4")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195BAFC", Offset = "0x195BAFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BAFC", Offset = "0x195BAFC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x195BAFC", Offset = "0x195BAFC")]
		public Collider characterCollider;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BB80", Offset = "0x195BB80")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x195BB80", Offset = "0x195BB80")]
		public Transform FPSCamera;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BBE0", Offset = "0x195BBE0")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BC18", Offset = "0x195BC18")]
		public float camRaycastDistance;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BC50", Offset = "0x195BC50")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x195BC60", Offset = "0x195BC60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BC60", Offset = "0x195BC60")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BCC0", Offset = "0x195BCC0")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BCF8", Offset = "0x195BCF8")]
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
			[Address(RVA = "0x3A3ED6C", Offset = "0x3A3ED6C", VA = "0x3A3ED6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x3A40984", Offset = "0x3A40984", VA = "0x3A40984")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x3A4098C", Offset = "0x3A4098C", VA = "0x3A4098C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x3A40994", Offset = "0x3A40994", VA = "0x3A40994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19639E4", Offset = "0x19639E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x3A4099C", Offset = "0x3A4099C", VA = "0x3A4099C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19639F4", Offset = "0x19639F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool initiated
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x3A409A4", Offset = "0x3A409A4", VA = "0x3A409A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963A04", Offset = "0x1963A04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x3A409AC", Offset = "0x3A409AC", VA = "0x3A409AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963A14", Offset = "0x1963A14")]
			private set
			{
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x3A3EB0C", Offset = "0x3A3EB0C", VA = "0x3A3EB0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963824", Offset = "0x1963824")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x3A3EB58", Offset = "0x3A3EB58", VA = "0x3A3EB58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196385C", Offset = "0x196385C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x3A3EBA4", Offset = "0x3A3EBA4", VA = "0x3A3EBA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963894", Offset = "0x1963894")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x3A3EBF0", Offset = "0x3A3EBF0", VA = "0x3A3EBF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19638CC", Offset = "0x19638CC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x3A3EC3C", Offset = "0x3A3EC3C", VA = "0x3A3EC3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963904", Offset = "0x1963904")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x3A3EC88", Offset = "0x3A3EC88", VA = "0x3A3EC88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x196393C", Offset = "0x196393C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x3A3ECD4", Offset = "0x3A3ECD4", VA = "0x3A3ECD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963974", Offset = "0x1963974")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x3A3ED20", Offset = "0x3A3ED20", VA = "0x3A3ED20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19639AC", Offset = "0x19639AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x3A3EEFC", Offset = "0x3A3EEFC", VA = "0x3A3EEFC")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x3A3EFC8", Offset = "0x3A3EFC8", VA = "0x3A3EFC8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x3A3F094", Offset = "0x3A3F094", VA = "0x3A3F094")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x3A3F140", Offset = "0x3A3F140", VA = "0x3A3F140")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x3A3F238", Offset = "0x3A3F238", VA = "0x3A3F238")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x3A3F354", Offset = "0x3A3F354", VA = "0x3A3F354")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x3A3F3E4", Offset = "0x3A3F3E4", VA = "0x3A3F3E4")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x3A3F474", Offset = "0x3A3F474", VA = "0x3A3F474")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x3A3F504", Offset = "0x3A3F504", VA = "0x3A3F504")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x3A3F578", Offset = "0x3A3F578", VA = "0x3A3F578")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x3A3F5EC", Offset = "0x3A3F5EC", VA = "0x3A3F5EC")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x3A3F654", Offset = "0x3A3F654", VA = "0x3A3F654")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3A3F6E0", Offset = "0x3A3F6E0", VA = "0x3A3F6E0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x3A3F794", Offset = "0x3A3F794", VA = "0x3A3F794")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x3A3F878", Offset = "0x3A3F878", VA = "0x3A3F878")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x3A3FB1C", Offset = "0x3A3FB1C", VA = "0x3A3FB1C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x3A3FCF4", Offset = "0x3A3FCF4", VA = "0x3A3FCF4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x3A3FF68", Offset = "0x3A3FF68", VA = "0x3A3FF68")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x3A4025C", Offset = "0x3A4025C", VA = "0x3A4025C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x3A402A0", Offset = "0x3A402A0", VA = "0x3A402A0")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x3A40318", Offset = "0x3A40318", VA = "0x3A40318")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x3A40438", Offset = "0x3A40438", VA = "0x3A40438")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x3A405B0", Offset = "0x3A405B0", VA = "0x3A405B0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x3A40858", Offset = "0x3A40858", VA = "0x3A40858")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x3A40068", Offset = "0x3A40068", VA = "0x3A40068")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x3A409B8", Offset = "0x3A409B8", VA = "0x3A409B8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x3A4106C", Offset = "0x3A4106C", VA = "0x3A4106C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x3A4108C", Offset = "0x3A4108C", VA = "0x3A4108C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x3A410A8", Offset = "0x3A410A8", VA = "0x3A410A8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x3A410C4", Offset = "0x3A410C4", VA = "0x3A410C4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x3A41124", Offset = "0x3A41124", VA = "0x3A41124")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x3A41240", Offset = "0x3A41240", VA = "0x3A41240")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x3A4133C", Offset = "0x3A4133C", VA = "0x3A4133C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x3A4169C", Offset = "0x3A4169C", VA = "0x3A4169C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x3A41788", Offset = "0x3A41788", VA = "0x3A41788")]
		public void Update()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x3A419A0", Offset = "0x3A419A0", VA = "0x3A419A0")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x3A40DE4", Offset = "0x3A40DE4", VA = "0x3A40DE4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x3A41AE0", Offset = "0x3A41AE0", VA = "0x3A41AE0")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x3A41C0C", Offset = "0x3A41C0C", VA = "0x3A41C0C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x3A41CA4", Offset = "0x3A41CA4", VA = "0x3A41CA4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x3A41D7C", Offset = "0x3A41D7C", VA = "0x3A41D7C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x3A41D94", Offset = "0x3A41D94", VA = "0x3A41D94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x3A3EE18", Offset = "0x3A3EE18", VA = "0x3A3EE18")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x3A3FA18", Offset = "0x3A3FA18", VA = "0x3A3FA18")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x3A42084", Offset = "0x3A42084", VA = "0x3A42084")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x195911C", Offset = "0x195911C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x195911C", Offset = "0x195911C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960B10", Offset = "0x1960B10")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960B48", Offset = "0x1960B48")]
			public float multiplier;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x3A42828", Offset = "0x3A42828", VA = "0x3A42828")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BD08", Offset = "0x195BD08")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BD40", Offset = "0x195BD40")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BD78", Offset = "0x195BD78")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BDB0", Offset = "0x195BDB0")]
		public Transform pivot;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BDE8", Offset = "0x195BDE8")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BE20", Offset = "0x195BE20")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BE58", Offset = "0x195BE58")]
		public float twistWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BE90", Offset = "0x195BE90")]
		public float swingWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BEC8", Offset = "0x195BEC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195BEC8", Offset = "0x195BEC8")]
		public float threeDOFWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BF1C", Offset = "0x195BF1C")]
		public bool rotateOnce;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x3A42538", Offset = "0x3A42538", VA = "0x3A42538")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963A24", Offset = "0x1963A24")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x3A42584", Offset = "0x3A42584", VA = "0x3A42584")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963A5C", Offset = "0x1963A5C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x3A425D0", Offset = "0x3A425D0", VA = "0x3A425D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963A94", Offset = "0x1963A94")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x3A4261C", Offset = "0x3A4261C", VA = "0x3A4261C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963ACC", Offset = "0x1963ACC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x3A42668", Offset = "0x3A42668", VA = "0x3A42668")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963B04", Offset = "0x1963B04")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x3A426B4", Offset = "0x3A426B4", VA = "0x3A426B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963B3C", Offset = "0x1963B3C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x3A42700", Offset = "0x3A42700", VA = "0x3A42700")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963B74", Offset = "0x1963B74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x3A4274C", Offset = "0x3A4274C", VA = "0x3A4274C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963BAC", Offset = "0x1963BAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x3A3DEFC", Offset = "0x3A3DEFC", VA = "0x3A3DEFC")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x3A3CE3C", Offset = "0x3A3CE3C", VA = "0x3A3CE3C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x3A3AF98", Offset = "0x3A3AF98", VA = "0x3A3AF98")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x3A42798", Offset = "0x3A42798", VA = "0x3A42798")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x195917C", Offset = "0x195917C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x195917C", Offset = "0x195917C")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public class CharacterPosition
		{
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960B80", Offset = "0x1960B80")]
			public bool use;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960BB8", Offset = "0x1960BB8")]
			public Vector2 offset;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960BF0", Offset = "0x1960BF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1960BF0", Offset = "0x1960BF0")]
			public float angleOffset;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960C4C", Offset = "0x1960C4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1960C4C", Offset = "0x1960C4C")]
			public float maxAngle;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960CA4", Offset = "0x1960CA4")]
			public float radius;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960CDC", Offset = "0x1960CDC")]
			public bool orbit;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960D14", Offset = "0x1960D14")]
			public bool fixYAxis;

			[Token(Token = "0x170000BA")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x3A43044", Offset = "0x3A43044", VA = "0x3A43044")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BB")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x3A43080", Offset = "0x3A43080", VA = "0x3A43080")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x3A43178", Offset = "0x3A43178", VA = "0x3A43178")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x3A437F4", Offset = "0x3A437F4", VA = "0x3A437F4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960D4C", Offset = "0x1960D4C")]
			public Collider lookAtTarget;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960D84", Offset = "0x1960D84")]
			public Vector3 direction;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960DBC", Offset = "0x1960DBC")]
			public float maxDistance;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960DF4", Offset = "0x1960DF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1960DF4", Offset = "0x1960DF4")]
			public float maxAngle;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960E4C", Offset = "0x1960E4C")]
			public bool fixYAxis;

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x3A42B30", Offset = "0x3A42B30", VA = "0x3A42B30")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x3A42CD8", Offset = "0x3A42CD8", VA = "0x3A42CD8")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x3A42FB8", Offset = "0x3A42FB8", VA = "0x3A42FB8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961E64", Offset = "0x1961E64")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000673")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961E9C", Offset = "0x1961E9C")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600075B")]
				[Address(RVA = "0x3A43818", Offset = "0x3A43818", VA = "0x3A43818")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960EA4", Offset = "0x1960EA4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960EDC", Offset = "0x1960EDC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960F14", Offset = "0x1960F14")]
			public Interaction[] interactions;

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x3A429AC", Offset = "0x3A429AC", VA = "0x3A429AC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x3A43808", Offset = "0x3A43808", VA = "0x3A43808")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BF54", Offset = "0x195BF54")]
		public Range[] ranges;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x3A42830", Offset = "0x3A42830", VA = "0x3A42830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963BE4", Offset = "0x1963BE4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x3A4287C", Offset = "0x3A4287C", VA = "0x3A4287C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963C1C", Offset = "0x1963C1C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x3A428C8", Offset = "0x3A428C8", VA = "0x3A428C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963C54", Offset = "0x1963C54")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x3A42914", Offset = "0x3A42914", VA = "0x3A42914")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963C8C", Offset = "0x1963C8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x3A42960", Offset = "0x3A42960", VA = "0x3A42960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963CC4", Offset = "0x1963CC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x3A414E0", Offset = "0x3A414E0", VA = "0x3A414E0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x3A42AD0", Offset = "0x3A42AD0", VA = "0x3A42AD0")]
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
			[Address(RVA = "0x3D4CB4C", Offset = "0x3D4CB4C", VA = "0x3D4CB4C")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x3D4CF50", Offset = "0x3D4CF50", VA = "0x3D4CF50")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x3D4CF04", Offset = "0x3D4CF04", VA = "0x3D4CF04")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x3D4CCFC", Offset = "0x3D4CCFC", VA = "0x3D4CCFC")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x3D4C864", Offset = "0x3D4C864", VA = "0x3D4C864", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963CFC", Offset = "0x1963CFC")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x3D4CBF0", Offset = "0x3D4CBF0", VA = "0x3D4CBF0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x3D4CBF4", Offset = "0x3D4CBF4", VA = "0x3D4CBF4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x3D4CE9C", Offset = "0x3D4CE9C", VA = "0x3D4CE9C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x3D4CB88", Offset = "0x3D4CB88", VA = "0x3D4CB88")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x3D4CAAC", Offset = "0x3D4CAAC", VA = "0x3D4CAAC")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x3D4CFA0", Offset = "0x3D4CFA0", VA = "0x3D4CFA0")]
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
		[Address(RVA = "0x3D57240", Offset = "0x3D57240", VA = "0x3D57240", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x3D572F4", Offset = "0x3D572F4", VA = "0x3D572F4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x3D574AC", Offset = "0x3D574AC", VA = "0x3D574AC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x3D575A8", Offset = "0x3D575A8", VA = "0x3D575A8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x3D57350", Offset = "0x3D57350", VA = "0x3D57350")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x3D57958", Offset = "0x3D57958", VA = "0x3D57958")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195BF8C", Offset = "0x195BF8C")]
		public float weight;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195BFA4", Offset = "0x195BFA4")]
		public float localRotationWeight;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195BFBC", Offset = "0x195BFBC")]
		public float localPositionWeight;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600045B")]
		public abstract void AutoMapping();

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x3A463DC", Offset = "0x3A463DC", VA = "0x3A463DC")]
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
		[Address(RVA = "0x3A463E8", Offset = "0x3A463E8", VA = "0x3A463E8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x3A4643C", Offset = "0x3A4643C", VA = "0x3A4643C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x3A46478", Offset = "0x3A46478", VA = "0x3A46478", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x3A46490", Offset = "0x3A46490", VA = "0x3A46490")]
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
			[Address(RVA = "0x3A46A14", Offset = "0x3A46A14", VA = "0x3A46A14")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x3A47620", Offset = "0x3A47620", VA = "0x3A47620")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x3A47404", Offset = "0x3A47404", VA = "0x3A47404")]
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
			[Address(RVA = "0x3A46B70", Offset = "0x3A46B70", VA = "0x3A46B70")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x3A477BC", Offset = "0x3A477BC", VA = "0x3A477BC")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x3A4776C", Offset = "0x3A4776C", VA = "0x3A4776C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19593D0", Offset = "0x19593D0")]
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
				[Address(RVA = "0x3A47D9C", Offset = "0x3A47D9C", VA = "0x3A47D9C", Slot = "4")]
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
				[Address(RVA = "0x3A47E04", Offset = "0x3A47E04", VA = "0x3A47E04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x3A46BD0", Offset = "0x3A46BD0", VA = "0x3A46BD0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x3A47B54", Offset = "0x3A47B54", VA = "0x3A47B54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x3A47B58", Offset = "0x3A47B58", VA = "0x3A47B58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x3A47DA4", Offset = "0x3A47DA4", VA = "0x3A47DA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195BFD4", Offset = "0x195BFD4")]
		public IK ik;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C00C", Offset = "0x195C00C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C044", Offset = "0x195C044")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C07C", Offset = "0x195C07C")]
		public float applyVelocity;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C0B4", Offset = "0x195C0B4")]
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
			[Address(RVA = "0x3A464D8", Offset = "0x3A464D8", VA = "0x3A464D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		private bool ikUsed
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x3A46FBC", Offset = "0x3A46FBC", VA = "0x3A46FBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x3A464A0", Offset = "0x3A464A0", VA = "0x3A464A0")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x3A46550", Offset = "0x3A46550", VA = "0x3A46550")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x3A46680", Offset = "0x3A46680", VA = "0x3A46680")]
		public void Start()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x3A46610", Offset = "0x3A46610", VA = "0x3A46610")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1963D34", Offset = "0x1963D34")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x3A46BFC", Offset = "0x3A46BFC", VA = "0x3A46BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x3A46E48", Offset = "0x3A46E48", VA = "0x3A46E48")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x3A46F00", Offset = "0x3A46F00", VA = "0x3A46F00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x3A47140", Offset = "0x3A47140", VA = "0x3A47140")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x3A46F80", Offset = "0x3A46F80", VA = "0x3A46F80")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x3A470FC", Offset = "0x3A470FC", VA = "0x3A470FC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x3A471DC", Offset = "0x3A471DC", VA = "0x3A471DC")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x3A47174", Offset = "0x3A47174", VA = "0x3A47174")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x3A465A8", Offset = "0x3A465A8", VA = "0x3A465A8")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x3A46E88", Offset = "0x3A46E88", VA = "0x3A46E88")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x3A47984", Offset = "0x3A47984", VA = "0x3A47984")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x3A47A88", Offset = "0x3A47A88", VA = "0x3A47A88")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195C0FC", Offset = "0x195C0FC")]
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
			[Address(RVA = "0x3A49690", Offset = "0x3A49690", VA = "0x3A49690")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000062")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x3A496CC", Offset = "0x3A496CC", VA = "0x3A496CC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000063")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x3A4979C", Offset = "0x3A4979C", VA = "0x3A4979C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963D98", Offset = "0x1963D98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x3A497A4", Offset = "0x3A497A4", VA = "0x3A497A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1963DA8", Offset = "0x1963DA8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x3A492F4", Offset = "0x3A492F4", VA = "0x3A492F4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x3A4933C", Offset = "0x3A4933C", VA = "0x3A4933C")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x3A49354", Offset = "0x3A49354", VA = "0x3A49354")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x3A495E8", Offset = "0x3A495E8", VA = "0x3A495E8")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x3A49658", Offset = "0x3A49658", VA = "0x3A49658")]
		public void Disable()
		{
		}

		[Token(Token = "0x600047F")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x3A494F8", Offset = "0x3A494F8", VA = "0x3A494F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x3A497B0", Offset = "0x3A497B0", VA = "0x3A497B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x3A497B4", Offset = "0x3A497B4", VA = "0x3A497B4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x3A497E8", Offset = "0x3A497E8", VA = "0x3A497E8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x3A498CC", Offset = "0x3A498CC", VA = "0x3A498CC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x3A49B48", Offset = "0x3A49B48", VA = "0x3A49B48")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x3A49C04", Offset = "0x3A49C04", VA = "0x3A49C04")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19591DC", Offset = "0x19591DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19591DC", Offset = "0x19591DC")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195C10C", Offset = "0x195C10C")]
		public float limit;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195C128", Offset = "0x195C128")]
		public float twistLimit;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x3A49C7C", Offset = "0x3A49C7C", VA = "0x3A49C7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963DB8", Offset = "0x1963DB8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x3A49CC8", Offset = "0x3A49CC8", VA = "0x3A49CC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963DF0", Offset = "0x1963DF0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x3A49D14", Offset = "0x3A49D14", VA = "0x3A49D14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963E28", Offset = "0x1963E28")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x3A49D60", Offset = "0x3A49D60", VA = "0x3A49D60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963E60", Offset = "0x1963E60")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x3A49DAC", Offset = "0x3A49DAC", VA = "0x3A49DAC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x3A49E64", Offset = "0x3A49E64", VA = "0x3A49E64")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x3A4A0AC", Offset = "0x3A4A0AC", VA = "0x3A4A0AC")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x195923C", Offset = "0x195923C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x195923C", Offset = "0x195923C")]
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
		[Address(RVA = "0x3A4A0BC", Offset = "0x3A4A0BC", VA = "0x3A4A0BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963E98", Offset = "0x1963E98")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x3A4A108", Offset = "0x3A4A108", VA = "0x3A4A108")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963ED0", Offset = "0x1963ED0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x3A4A154", Offset = "0x3A4A154", VA = "0x3A4A154")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963F08", Offset = "0x1963F08")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x3A4A1A0", Offset = "0x3A4A1A0", VA = "0x3A4A1A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963F40", Offset = "0x1963F40")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x3A4A1EC", Offset = "0x3A4A1EC", VA = "0x3A4A1EC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x3A4A1F0", Offset = "0x3A4A1F0", VA = "0x3A4A1F0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x3A4A49C", Offset = "0x3A4A49C", VA = "0x3A4A49C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x195929C", Offset = "0x195929C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x195929C", Offset = "0x195929C")]
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
				[Address(RVA = "0x3A4C3D4", Offset = "0x3A4C3D4", VA = "0x3A4C3D4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BF")]
			public Vector3 a
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x3A4C40C", Offset = "0x3A4C40C", VA = "0x3A4C40C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C0")]
			public Vector3 b
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x3A4C448", Offset = "0x3A4C448", VA = "0x3A4C448")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C1")]
			public Vector3 c
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x3A4C484", Offset = "0x3A4C484", VA = "0x3A4C484")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C2")]
			public bool isValid
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x3A4B538", Offset = "0x3A4B538", VA = "0x3A4B538")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x3A4BB84", Offset = "0x3A4BB84", VA = "0x3A4BB84")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x3A4BCE4", Offset = "0x3A4BCE4", VA = "0x3A4BCE4")]
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
			[Address(RVA = "0x3A4B548", Offset = "0x3A4B548", VA = "0x3A4B548")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195C154", Offset = "0x195C154")]
		public float twistLimit;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195C170", Offset = "0x195C170")]
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
		[Address(RVA = "0x3A4A4B4", Offset = "0x3A4A4B4", VA = "0x3A4A4B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963F78", Offset = "0x1963F78")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x3A4A500", Offset = "0x3A4A500", VA = "0x3A4A500")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963FB0", Offset = "0x1963FB0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x3A4A54C", Offset = "0x3A4A54C", VA = "0x3A4A54C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1963FE8", Offset = "0x1963FE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x3A4A598", Offset = "0x3A4A598", VA = "0x3A4A598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1964020", Offset = "0x1964020")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x3A4A5E4", Offset = "0x3A4A5E4", VA = "0x3A4A5E4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x3A4AACC", Offset = "0x3A4AACC", VA = "0x3A4AACC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x3A4ABC4", Offset = "0x3A4ABC4", VA = "0x3A4ABC4")]
		private void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x3A4B184", Offset = "0x3A4B184", VA = "0x3A4B184")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x3A4A684", Offset = "0x3A4A684", VA = "0x3A4A684")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x3A4B5CC", Offset = "0x3A4B5CC", VA = "0x3A4B5CC")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x3A4BEA4", Offset = "0x3A4BEA4", VA = "0x3A4BEA4")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x3A4BEE8", Offset = "0x3A4BEE8", VA = "0x3A4BEE8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x3A4C030", Offset = "0x3A4C030", VA = "0x3A4C030")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x3A4AE48", Offset = "0x3A4AE48", VA = "0x3A4AE48")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x3A4C1C0", Offset = "0x3A4C1C0", VA = "0x3A4C1C0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x3A4C370", Offset = "0x3A4C370", VA = "0x3A4C370")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x19592FC", Offset = "0x19592FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x19592FC", Offset = "0x19592FC")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195C1B8", Offset = "0x195C1B8")]
		public float twistLimit;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x3A4C4C0", Offset = "0x3A4C4C0", VA = "0x3A4C4C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1964058", Offset = "0x1964058")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x3A4C50C", Offset = "0x3A4C50C", VA = "0x3A4C50C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1964090", Offset = "0x1964090")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x3A4C558", Offset = "0x3A4C558", VA = "0x3A4C558")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x19640C8", Offset = "0x19640C8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x3A4C5A4", Offset = "0x3A4C5A4", VA = "0x3A4C5A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1964100", Offset = "0x1964100")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x3A4C5F0", Offset = "0x3A4C5F0", VA = "0x3A4C5F0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x3A4C60C", Offset = "0x3A4C60C", VA = "0x3A4C60C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x3A4C6C4", Offset = "0x3A4C6C4", VA = "0x3A4C6C4")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x3A4C9F0", Offset = "0x3A4C9F0", VA = "0x3A4C9F0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19593E0", Offset = "0x19593E0")]
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
				[Address(RVA = "0x362E5C8", Offset = "0x362E5C8", VA = "0x362E5C8", Slot = "4")]
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
				[Address(RVA = "0x362E630", Offset = "0x362E630", VA = "0x362E630", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x362E3A4", Offset = "0x362E3A4", VA = "0x362E3A4")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x362E4A4", Offset = "0x362E4A4", VA = "0x362E4A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x362E4A8", Offset = "0x362E4A8", VA = "0x362E4A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x362E5D0", Offset = "0x362E5D0", VA = "0x362E5D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C1E4", Offset = "0x195C1E4")]
		public AimIK ik;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C21C", Offset = "0x195C21C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195C21C", Offset = "0x195C21C")]
		public float weight;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195C270", Offset = "0x195C270")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C270", Offset = "0x195C270")]
		public Transform target;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C2D0", Offset = "0x195C2D0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C308", Offset = "0x195C308")]
		public float weightSmoothTime;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195C340", Offset = "0x195C340")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C340", Offset = "0x195C340")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C3A0", Offset = "0x195C3A0")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C3D8", Offset = "0x195C3D8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C410", Offset = "0x195C410")]
		public float slerpSpeed;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C448", Offset = "0x195C448")]
		public float smoothDampTime;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C480", Offset = "0x195C480")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C4B8", Offset = "0x195C4B8")]
		public float minDistance;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C4F0", Offset = "0x195C4F0")]
		public Vector3 offset;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195C528", Offset = "0x195C528")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C528", Offset = "0x195C528")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195C528", Offset = "0x195C528")]
		public float maxRootAngle;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C5A4", Offset = "0x195C5A4")]
		public bool turnToTarget;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C5DC", Offset = "0x195C5DC")]
		public float turnToTargetTime;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195C614", Offset = "0x195C614")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C614", Offset = "0x195C614")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C674", Offset = "0x195C674")]
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
			[Address(RVA = "0x362D334", Offset = "0x362D334", VA = "0x362D334")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x362D238", Offset = "0x362D238", VA = "0x362D238")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x362D480", Offset = "0x362D480", VA = "0x362D480")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x362DE28", Offset = "0x362DE28", VA = "0x362DE28")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x362DFC4", Offset = "0x362DFC4", VA = "0x362DFC4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x362E334", Offset = "0x362E334", VA = "0x362E334")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1964138", Offset = "0x1964138")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x362E3D0", Offset = "0x362E3D0", VA = "0x362E3D0")]
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
			[Address(RVA = "0x362E900", Offset = "0x362E900", VA = "0x362E900")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x362EC6C", Offset = "0x362EC6C", VA = "0x362EC6C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x362EC74", Offset = "0x362EC74", VA = "0x362EC74")]
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
		[Address(RVA = "0x362E824", Offset = "0x362E824", VA = "0x362E824")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x362EB98", Offset = "0x362EB98", VA = "0x362EB98")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x362EC04", Offset = "0x362EC04", VA = "0x362EC04")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961ED4", Offset = "0x1961ED4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000675")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961F0C", Offset = "0x1961F0C")]
				public float weight;

				[Token(Token = "0x600075C")]
				[Address(RVA = "0x362F264", Offset = "0x362F264", VA = "0x362F264")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960F4C", Offset = "0x1960F4C")]
			public Transform transform;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960F84", Offset = "0x1960F84")]
			public Transform relativeTo;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960FBC", Offset = "0x1960FBC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1960FF4", Offset = "0x1960FF4")]
			public float verticalWeight;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196102C", Offset = "0x196102C")]
			public float horizontalWeight;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961064", Offset = "0x1961064")]
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
			[Address(RVA = "0x362EDD0", Offset = "0x362EDD0", VA = "0x362EDD0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x362F23C", Offset = "0x362F23C", VA = "0x362F23C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x362F24C", Offset = "0x362F24C", VA = "0x362F24C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C6AC", Offset = "0x195C6AC")]
		public Body[] bodies;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x362EC90", Offset = "0x362EC90", VA = "0x362EC90", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x362F234", Offset = "0x362F234", VA = "0x362F234")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C6E4", Offset = "0x195C6E4")]
		public float tiltSpeed;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C71C", Offset = "0x195C71C")]
		public float tiltSensitivity;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C754", Offset = "0x195C754")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C78C", Offset = "0x195C78C")]
		public OffsetPose poseRight;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x3630770", Offset = "0x3630770", VA = "0x3630770", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x36307B8", Offset = "0x36307B8", VA = "0x36307B8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x36309E8", Offset = "0x36309E8", VA = "0x36309E8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195C7C4", Offset = "0x195C7C4")]
		public float weight;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x36309FC", Offset = "0x36309FC", VA = "0x36309FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x3630ABC", Offset = "0x3630ABC", VA = "0x3630ABC")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x3630DCC", Offset = "0x3630DCC", VA = "0x3630DCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x3630EC4", Offset = "0x3630EC4", VA = "0x3630EC4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C7DC", Offset = "0x195C7DC")]
		public Animator animator;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C814", Offset = "0x195C814")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195C85C", Offset = "0x195C85C")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x17000065")]
		public IK ik
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x3631928", Offset = "0x3631928", VA = "0x3631928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196419C", Offset = "0x196419C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x3631930", Offset = "0x3631930", VA = "0x3631930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19641AC", Offset = "0x19641AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x3631938", Offset = "0x3631938", VA = "0x3631938")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x3631AA8", Offset = "0x3631AA8", VA = "0x3631AA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x3631D30", Offset = "0x3631D30", VA = "0x3631D30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x3631E70", Offset = "0x3631E70", VA = "0x3631E70")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x3632038", Offset = "0x3632038", VA = "0x3632038")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x3632248", Offset = "0x3632248", VA = "0x3632248")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x36324DC", Offset = "0x36324DC", VA = "0x36324DC")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x195936C", Offset = "0x195936C")]
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
			[Address(RVA = "0x3631BA4", Offset = "0x3631BA4", VA = "0x3631BA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x3631EEC", Offset = "0x3631EEC", VA = "0x3631EEC")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x3631BC8", Offset = "0x3631BC8", VA = "0x3631BC8")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x363253C", Offset = "0x363253C", VA = "0x363253C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196109C", Offset = "0x196109C")]
			public string name;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19610D4", Offset = "0x19610D4")]
			public Collider collider;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196110C", Offset = "0x196110C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1961158", Offset = "0x1961158")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1961168", Offset = "0x1961168")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1961178", Offset = "0x1961178")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1961188", Offset = "0x1961188")]
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
				[Address(RVA = "0x3D57A1C", Offset = "0x3D57A1C", VA = "0x3D57A1C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C6")]
			protected float crossFader
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x3D57FC4", Offset = "0x3D57FC4", VA = "0x3D57FC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964848", Offset = "0x1964848")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0x3D57FCC", Offset = "0x3D57FCC", VA = "0x3D57FCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964858", Offset = "0x1964858")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			protected float timer
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0x3D57FD4", Offset = "0x3D57FD4", VA = "0x3D57FD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964868", Offset = "0x1964868")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006EB")]
				[Address(RVA = "0x3D57FDC", Offset = "0x3D57FDC", VA = "0x3D57FDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964878", Offset = "0x1964878")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C8")]
			protected Vector3 force
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x3D57FE4", Offset = "0x3D57FE4", VA = "0x3D57FE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964888", Offset = "0x1964888")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006ED")]
				[Address(RVA = "0x3D57FF0", Offset = "0x3D57FF0", VA = "0x3D57FF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964898", Offset = "0x1964898")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			protected Vector3 point
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x3D57FFC", Offset = "0x3D57FFC", VA = "0x3D57FFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19648A8", Offset = "0x19648A8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0x3D58008", Offset = "0x3D58008", VA = "0x3D58008")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19648B8", Offset = "0x19648B8")]
				private set
				{
				}
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x3D57E90", Offset = "0x3D57E90", VA = "0x3D57E90")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x3D57B04", Offset = "0x3D57B04", VA = "0x3D57B04")]
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
			[Address(RVA = "0x3D58014", Offset = "0x3D58014", VA = "0x3D58014")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961F44", Offset = "0x1961F44")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000677")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961F7C", Offset = "0x1961F7C")]
				public float weight;

				[Token(Token = "0x4000678")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000679")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600075D")]
				[Address(RVA = "0x3D58980", Offset = "0x3D58980", VA = "0x3D58980")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600075E")]
				[Address(RVA = "0x3D58774", Offset = "0x3D58774", VA = "0x3D58774")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600075F")]
				[Address(RVA = "0x3D58ABC", Offset = "0x3D58ABC", VA = "0x3D58ABC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961198", Offset = "0x1961198")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19611D0", Offset = "0x19611D0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961208", Offset = "0x1961208")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x3D58590", Offset = "0x3D58590", VA = "0x3D58590", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x3D58708", Offset = "0x3D58708", VA = "0x3D58708", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x3D58788", Offset = "0x3D58788", VA = "0x3D58788", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x3D58AA8", Offset = "0x3D58AA8", VA = "0x3D58AA8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961FB4", Offset = "0x1961FB4")]
				public Transform bone;

				[Token(Token = "0x400067B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961FEC", Offset = "0x1961FEC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1961FEC", Offset = "0x1961FEC")]
				public float weight;

				[Token(Token = "0x400067C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400067D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000760")]
				[Address(RVA = "0x3D58398", Offset = "0x3D58398", VA = "0x3D58398")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000761")]
				[Address(RVA = "0x3D58130", Offset = "0x3D58130", VA = "0x3D58130")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000762")]
				[Address(RVA = "0x3D58508", Offset = "0x3D58508", VA = "0x3D58508")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961240", Offset = "0x1961240")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961278", Offset = "0x1961278")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x3D58028", Offset = "0x3D58028", VA = "0x3D58028", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x3D580CC", Offset = "0x3D580CC", VA = "0x3D580CC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x3D5813C", Offset = "0x3D5813C", VA = "0x3D5813C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x3D584F4", Offset = "0x3D584F4", VA = "0x3D584F4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C86C", Offset = "0x195C86C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C8A4", Offset = "0x195C8A4")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000067")]
		public bool inProgress
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x3D57960", Offset = "0x3D57960", VA = "0x3D57960")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x3D57A30", Offset = "0x3D57A30", VA = "0x3D57A30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x3D57C50", Offset = "0x3D57C50", VA = "0x3D57C50")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x3D57FBC", Offset = "0x3D57FBC", VA = "0x3D57FBC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19612B0", Offset = "0x19612B0")]
			public string name;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19612E8", Offset = "0x19612E8")]
			public Collider collider;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961320", Offset = "0x1961320")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196136C", Offset = "0x196136C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196137C", Offset = "0x196137C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196138C", Offset = "0x196138C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x196139C", Offset = "0x196139C")]
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
				[Address(RVA = "0x3D59074", Offset = "0x3D59074", VA = "0x3D59074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19648C8", Offset = "0x19648C8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006FF")]
				[Address(RVA = "0x3D5907C", Offset = "0x3D5907C", VA = "0x3D5907C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19648D8", Offset = "0x19648D8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			protected float timer
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x3D59084", Offset = "0x3D59084", VA = "0x3D59084")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19648E8", Offset = "0x19648E8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x3D5908C", Offset = "0x3D5908C", VA = "0x3D5908C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19648F8", Offset = "0x19648F8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			protected Vector3 force
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x3D59094", Offset = "0x3D59094", VA = "0x3D59094")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964908", Offset = "0x1964908")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000703")]
				[Address(RVA = "0x3D590A0", Offset = "0x3D590A0", VA = "0x3D590A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964918", Offset = "0x1964918")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CD")]
			protected Vector3 point
			{
				[Token(Token = "0x6000704")]
				[Address(RVA = "0x3D590AC", Offset = "0x3D590AC", VA = "0x3D590AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964928", Offset = "0x1964928")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000705")]
				[Address(RVA = "0x3D590B8", Offset = "0x3D590B8", VA = "0x3D590B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964938", Offset = "0x1964938")]
				private set
				{
				}
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x3D58F2C", Offset = "0x3D58F2C", VA = "0x3D58F2C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x3D58B90", Offset = "0x3D58B90", VA = "0x3D58B90")]
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
			[Address(RVA = "0x3D590C4", Offset = "0x3D590C4", VA = "0x3D590C4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1962040", Offset = "0x1962040")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400067F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1962078", Offset = "0x1962078")]
				public float weight;

				[Token(Token = "0x4000680")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000681")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000763")]
				[Address(RVA = "0x3D59580", Offset = "0x3D59580", VA = "0x3D59580")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000764")]
				[Address(RVA = "0x3D5933C", Offset = "0x3D5933C", VA = "0x3D5933C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000765")]
				[Address(RVA = "0x3D5969C", Offset = "0x3D5969C", VA = "0x3D5969C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19613AC", Offset = "0x19613AC")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19613E4", Offset = "0x19613E4")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196141C", Offset = "0x196141C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x3D590D8", Offset = "0x3D590D8", VA = "0x3D590D8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x3D592D0", Offset = "0x3D592D0", VA = "0x3D592D0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x3D59350", Offset = "0x3D59350", VA = "0x3D59350", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x3D59680", Offset = "0x3D59680", VA = "0x3D59680")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19620B0", Offset = "0x19620B0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000683")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19620E8", Offset = "0x19620E8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19620E8", Offset = "0x19620E8")]
				public float weight;

				[Token(Token = "0x4000684")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000685")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000766")]
				[Address(RVA = "0x3D59B04", Offset = "0x3D59B04", VA = "0x3D59B04")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000767")]
				[Address(RVA = "0x3D597EC", Offset = "0x3D597EC", VA = "0x3D597EC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000768")]
				[Address(RVA = "0x3D59C40", Offset = "0x3D59C40", VA = "0x3D59C40")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961454", Offset = "0x1961454")]
			public int curveIndex;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196148C", Offset = "0x196148C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x3D596A4", Offset = "0x3D596A4", VA = "0x3D596A4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x3D59788", Offset = "0x3D59788", VA = "0x3D59788", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x3D597F8", Offset = "0x3D597F8", VA = "0x3D597F8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x3D59C2C", Offset = "0x3D59C2C", VA = "0x3D59C2C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C8DC", Offset = "0x195C8DC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C914", Offset = "0x195C914")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x3D58AC4", Offset = "0x3D58AC4", VA = "0x3D58AC4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x3D58CE4", Offset = "0x3D58CE4", VA = "0x3D58CE4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x3D5906C", Offset = "0x3D5906C", VA = "0x3D5906C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196213C", Offset = "0x196213C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000687")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1962174", Offset = "0x1962174")]
				public float weight;

				[Token(Token = "0x6000769")]
				[Address(RVA = "0x3A39D78", Offset = "0x3A39D78", VA = "0x3A39D78")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19614C4", Offset = "0x19614C4")]
			public Transform transform;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19614FC", Offset = "0x19614FC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961534", Offset = "0x1961534")]
			public float speed;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196156C", Offset = "0x196156C")]
			public float acceleration;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19615A4", Offset = "0x19615A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19615A4", Offset = "0x19615A4")]
			public float matchVelocity;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19615F8", Offset = "0x19615F8")]
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
			[Address(RVA = "0x3A39748", Offset = "0x3A39748", VA = "0x3A39748")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x3A39908", Offset = "0x3A39908", VA = "0x3A39908")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x3A39D5C", Offset = "0x3A39D5C", VA = "0x3A39D5C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C94C", Offset = "0x195C94C")]
		public Body[] bodies;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C984", Offset = "0x195C984")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x3A396D0", Offset = "0x3A396D0", VA = "0x3A396D0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x3A39824", Offset = "0x3A39824", VA = "0x3A39824", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x3A39D3C", Offset = "0x3A39D3C", VA = "0x3A39D3C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195C9BC", Offset = "0x195C9BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195C9BC", Offset = "0x195C9BC")]
		public Transform target;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195CA1C", Offset = "0x195CA1C")]
		public float weight;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CA34", Offset = "0x195CA34")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CA6C", Offset = "0x195CA6C")]
		public float weightSmoothTime;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195CAA4", Offset = "0x195CAA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CAA4", Offset = "0x195CAA4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CB04", Offset = "0x195CB04")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CB3C", Offset = "0x195CB3C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CB74", Offset = "0x195CB74")]
		public float slerpSpeed;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CBAC", Offset = "0x195CBAC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CBE4", Offset = "0x195CBE4")]
		public float minDistance;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x195CC1C", Offset = "0x195CC1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CC1C", Offset = "0x195CC1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x195CC1C", Offset = "0x195CC1C")]
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
			[Address(RVA = "0x3A43C48", Offset = "0x3A43C48", VA = "0x3A43C48")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x3A43B60", Offset = "0x3A43B60", VA = "0x3A43B60")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x3A43D94", Offset = "0x3A43D94", VA = "0x3A43D94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x3A4445C", Offset = "0x3A4445C", VA = "0x3A4445C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x3A445F8", Offset = "0x3A445F8", VA = "0x3A445F8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x3A44914", Offset = "0x3A44914", VA = "0x3A44914")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961630", Offset = "0x1961630")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961668", Offset = "0x1961668")]
			public float spring;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19616A0", Offset = "0x19616A0")]
			public bool x;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19616D8", Offset = "0x19616D8")]
			public bool y;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961710", Offset = "0x1961710")]
			public bool z;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961748", Offset = "0x1961748")]
			public float minX;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961780", Offset = "0x1961780")]
			public float maxX;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19617B8", Offset = "0x19617B8")]
			public float minY;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19617F0", Offset = "0x19617F0")]
			public float maxY;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961828", Offset = "0x1961828")]
			public float minZ;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961860", Offset = "0x1961860")]
			public float maxZ;

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x3A44D3C", Offset = "0x3A44D3C", VA = "0x3A44D3C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x3A45244", Offset = "0x3A45244", VA = "0x3A45244")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x3A45274", Offset = "0x3A45274", VA = "0x3A45274")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x3A4534C", Offset = "0x3A4534C", VA = "0x3A4534C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19593F0", Offset = "0x19593F0")]
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
				[Address(RVA = "0x3A451D4", Offset = "0x3A451D4", VA = "0x3A451D4", Slot = "4")]
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
				[Address(RVA = "0x3A4523C", Offset = "0x3A4523C", VA = "0x3A4523C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x3A44C04", Offset = "0x3A44C04", VA = "0x3A44C04")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x3A45094", Offset = "0x3A45094", VA = "0x3A45094", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x3A45098", Offset = "0x3A45098", VA = "0x3A45098", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x3A451DC", Offset = "0x3A451DC", VA = "0x3A451DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CC98", Offset = "0x195CC98")]
		public float weight;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CCD0", Offset = "0x195CCD0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000069")]
		protected float deltaTime
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x3A398DC", Offset = "0x3A398DC", VA = "0x3A398DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004DE")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x3A44B68", Offset = "0x3A44B68", VA = "0x3A44B68", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x3A44B94", Offset = "0x3A44B94", VA = "0x3A44B94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x19641BC", Offset = "0x19641BC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x3A44C30", Offset = "0x3A44C30", VA = "0x3A44C30")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x3A39C80", Offset = "0x3A39C80", VA = "0x3A39C80")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x3A44F9C", Offset = "0x3A44F9C", VA = "0x3A44F9C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x3A39D4C", Offset = "0x3A39D4C", VA = "0x3A39D4C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959400", Offset = "0x1959400")]
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
				[Address(RVA = "0x3A4579C", Offset = "0x3A4579C", VA = "0x3A4579C", Slot = "4")]
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
				[Address(RVA = "0x3A45804", Offset = "0x3A45804", VA = "0x3A45804", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x3A4541C", Offset = "0x3A4541C", VA = "0x3A4541C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x3A4565C", Offset = "0x3A4565C", VA = "0x3A4565C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x3A45660", Offset = "0x3A45660", VA = "0x3A45660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x3A457A4", Offset = "0x3A457A4", VA = "0x3A457A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CD08", Offset = "0x195CD08")]
		public float weight;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CD40", Offset = "0x195CD40")]
		public VRIK ik;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700006A")]
		protected float deltaTime
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x3A45354", Offset = "0x3A45354", VA = "0x3A45354")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004E6")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x3A45380", Offset = "0x3A45380", VA = "0x3A45380", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x3A453AC", Offset = "0x3A453AC", VA = "0x3A453AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1964220", Offset = "0x1964220")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x3A45448", Offset = "0x3A45448", VA = "0x3A45448")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x3A45554", Offset = "0x3A45554", VA = "0x3A45554", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x3A4564C", Offset = "0x3A4564C", VA = "0x3A4564C")]
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
			[Address(RVA = "0x3A458CC", Offset = "0x3A458CC", VA = "0x3A458CC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x3A45D1C", Offset = "0x3A45D1C", VA = "0x3A45D1C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x3A4580C", Offset = "0x3A4580C", VA = "0x3A4580C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x3A45C04", Offset = "0x3A45C04", VA = "0x3A45C04")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x3A45CBC", Offset = "0x3A45CBC", VA = "0x3A45CBC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19621AC", Offset = "0x19621AC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19621E4", Offset = "0x19621E4")]
				public float weight;

				[Token(Token = "0x600076A")]
				[Address(RVA = "0x3A463D4", Offset = "0x3A463D4", VA = "0x3A463D4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961898", Offset = "0x1961898")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19618D0", Offset = "0x19618D0")]
			public Transform raycastTo;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961908", Offset = "0x1961908")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1961908", Offset = "0x1961908")]
			public float raycastRadius;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196195C", Offset = "0x196195C")]
			public EffectorLink[] effectors;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961994", Offset = "0x1961994")]
			public float smoothTimeIn;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x19619CC", Offset = "0x19619CC")]
			public float smoothTimeOut;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961A04", Offset = "0x1961A04")]
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
			[Address(RVA = "0x3A45DA8", Offset = "0x3A45DA8", VA = "0x3A45DA8")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x3A45FB4", Offset = "0x3A45FB4", VA = "0x3A45FB4")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x3A4614C", Offset = "0x3A4614C", VA = "0x3A4614C")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x3A463C0", Offset = "0x3A463C0", VA = "0x3A463C0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CD78", Offset = "0x195CD78")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x3A45D24", Offset = "0x3A45D24", VA = "0x3A45D24", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x3A45FA4", Offset = "0x3A45FA4", VA = "0x3A45FA4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x196221C", Offset = "0x196221C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1962254", Offset = "0x1962254")]
				public float weight;

				[Token(Token = "0x600076B")]
				[Address(RVA = "0x3A492EC", Offset = "0x3A492EC", VA = "0x3A492EC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961A3C", Offset = "0x1961A3C")]
			public Vector3 offset;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961A74", Offset = "0x1961A74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1961A74", Offset = "0x1961A74")]
			public float additivity;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961AC8", Offset = "0x1961AC8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961B00", Offset = "0x1961B00")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x3A48034", Offset = "0x3A48034", VA = "0x3A48034")]
			public void Start()
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x3A48BC4", Offset = "0x3A48BC4", VA = "0x3A48BC4")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x3A492D8", Offset = "0x3A492D8", VA = "0x3A492D8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CDB0", Offset = "0x195CDB0")]
		public AimIK aimIK;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CDE8", Offset = "0x195CDE8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CE20", Offset = "0x195CE20")]
		public Handedness handedness;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CE58", Offset = "0x195CE58")]
		public bool twoHanded;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CE90", Offset = "0x195CE90")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CEC8", Offset = "0x195CEC8")]
		public float magnitudeRandom;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CF00", Offset = "0x195CF00")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CF38", Offset = "0x195CF38")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CF70", Offset = "0x195CF70")]
		public float blendTime;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x195CFA8", Offset = "0x195CFA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195CFA8", Offset = "0x195CFA8")]
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
			[Address(RVA = "0x3A47E0C", Offset = "0x3A47E0C", VA = "0x3A47E0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x3A48E78", Offset = "0x3A48E78", VA = "0x3A48E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x3A48EB8", Offset = "0x3A48EB8", VA = "0x3A48EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x3A48E38", Offset = "0x3A48E38", VA = "0x3A48E38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x3A48E58", Offset = "0x3A48E58", VA = "0x3A48E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x3A47E3C", Offset = "0x3A47E3C", VA = "0x3A47E3C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x3A47E68", Offset = "0x3A47E68", VA = "0x3A47E68")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x3A480E4", Offset = "0x3A480E4", VA = "0x3A480E4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x3A48EF8", Offset = "0x3A48EF8", VA = "0x3A48EF8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x3A49050", Offset = "0x3A49050", VA = "0x3A49050")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x3A4908C", Offset = "0x3A4908C", VA = "0x3A4908C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x3A49224", Offset = "0x3A49224", VA = "0x3A49224")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D008", Offset = "0x195D008")]
		public float weight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x195D040", Offset = "0x195D040")]
		public float offset;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x3A4C9FC", Offset = "0x3A4C9FC", VA = "0x3A4C9FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x3A4CAD0", Offset = "0x3A4CAD0", VA = "0x3A4CAD0")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x3A4CBBC", Offset = "0x3A4CBBC", VA = "0x3A4CBBC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x3A4D004", Offset = "0x3A4D004", VA = "0x3A4D004")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x3A4D03C", Offset = "0x3A4D03C", VA = "0x3A4D03C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x3A4D134", Offset = "0x3A4D134", VA = "0x3A4D134")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961B38", Offset = "0x1961B38")]
			public float scaleMlp;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961B70", Offset = "0x1961B70")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961BA8", Offset = "0x1961BA8")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961BE0", Offset = "0x1961BE0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961C18", Offset = "0x1961C18")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961C50", Offset = "0x1961C50")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961C88", Offset = "0x1961C88")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1961CC0", Offset = "0x1961CC0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961CC0", Offset = "0x1961CC0")]
			public Vector3 headOffset;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961D10", Offset = "0x1961D10")]
			public Vector3 handOffset;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961D48", Offset = "0x1961D48")]
			public float footForwardOffset;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961D80", Offset = "0x1961D80")]
			public float footInwardOffset;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1961DB8", Offset = "0x1961DB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1961DB8", Offset = "0x1961DB8")]
			public float footHeadingOffset;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1961E14", Offset = "0x1961E14")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1961E2C", Offset = "0x1961E2C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x4B97008", Offset = "0x4B97008", VA = "0x4B97008")]
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
				[Address(RVA = "0x4B94BA0", Offset = "0x4B94BA0", VA = "0x4B94BA0")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600076D")]
				[Address(RVA = "0x4B956FC", Offset = "0x4B956FC", VA = "0x4B956FC")]
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
			[Address(RVA = "0x4B94044", Offset = "0x4B94044", VA = "0x4B94044")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4B92BA4", Offset = "0x4B92BA4", VA = "0x4B92BA4")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4B92BBC", Offset = "0x4B92BBC", VA = "0x4B92BBC")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x4B92D54", Offset = "0x4B92D54", VA = "0x4B92D54")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4B92C08", Offset = "0x4B92C08", VA = "0x4B92C08")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x4B92D6C", Offset = "0x4B92D6C", VA = "0x4B92D6C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x4B941BC", Offset = "0x4B941BC", VA = "0x4B941BC")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x4B94C64", Offset = "0x4B94C64", VA = "0x4B94C64")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4B9575C", Offset = "0x4B9575C", VA = "0x4B9575C")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x4B95B18", Offset = "0x4B95B18", VA = "0x4B95B18")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x4B95D18", Offset = "0x4B95D18", VA = "0x4B95D18")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x4B96414", Offset = "0x4B96414", VA = "0x4B96414")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x4B961E0", Offset = "0x4B961E0", VA = "0x4B961E0")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x4B966E4", Offset = "0x4B966E4", VA = "0x4B966E4")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x4B969E0", Offset = "0x4B969E0", VA = "0x4B969E0")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x4B96BB8", Offset = "0x4B96BB8", VA = "0x4B96BB8")]
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
		[Address(RVA = "0x4B970E0", Offset = "0x4B970E0", VA = "0x4B970E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x4B97138", Offset = "0x4B97138", VA = "0x4B97138")]
		private void Update()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x4B9716C", Offset = "0x4B9716C", VA = "0x4B9716C")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x4B972F4", Offset = "0x4B972F4", VA = "0x4B972F4")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D078", Offset = "0x195D078")]
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
			[Address(RVA = "0x4B9730C", Offset = "0x4B9730C", VA = "0x4B9730C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964284", Offset = "0x1964284")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x4B97318", Offset = "0x4B97318", VA = "0x4B97318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964294", Offset = "0x1964294")]
			private set
			{
			}
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x4B97324", Offset = "0x4B97324", VA = "0x4B97324")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x4B9497C", Offset = "0x4B9497C", VA = "0x4B9497C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x4B959A8", Offset = "0x4B959A8", VA = "0x4B959A8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x4B973FC", Offset = "0x4B973FC", VA = "0x4B973FC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x4B978A0", Offset = "0x4B978A0", VA = "0x4B978A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x4B97998", Offset = "0x4B97998", VA = "0x4B97998")]
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
				[Address(RVA = "0x361D08C", Offset = "0x361D08C", VA = "0x361D08C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000D3")]
			private char NextChar
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0x361CE94", Offset = "0x361CE94", VA = "0x361CE94")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000D4")]
			private string NextWord
			{
				[Token(Token = "0x6000740")]
				[Address(RVA = "0x361CF1C", Offset = "0x361CF1C", VA = "0x361CF1C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000741")]
				[Address(RVA = "0x361C700", Offset = "0x361C700", VA = "0x361C700")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x361C3DC", Offset = "0x361C3DC", VA = "0x361C3DC")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x361C47C", Offset = "0x361C47C", VA = "0x361C47C")]
			public static bool IsHexDigit(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x361C4E4", Offset = "0x361C4E4", VA = "0x361C4E4")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x361C230", Offset = "0x361C230", VA = "0x361C230")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x361C588", Offset = "0x361C588", VA = "0x361C588", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x361C5BC", Offset = "0x361C5BC", VA = "0x361C5BC")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x361CC30", Offset = "0x361CC30", VA = "0x361CC30")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x361C560", Offset = "0x361C560", VA = "0x361C560")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x361CB54", Offset = "0x361CB54", VA = "0x361CB54")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x361C8B0", Offset = "0x361C8B0", VA = "0x361C8B0")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x361CD14", Offset = "0x361CD14", VA = "0x361CD14")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x361CFD8", Offset = "0x361CFD8", VA = "0x361CFD8")]
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
			[Address(RVA = "0x361D114", Offset = "0x361D114", VA = "0x361D114")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x361C360", Offset = "0x361C360", VA = "0x361C360")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x361D180", Offset = "0x361D180", VA = "0x361D180")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x361D720", Offset = "0x361D720", VA = "0x361D720")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x361D57C", Offset = "0x361D57C", VA = "0x361D57C")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x361D31C", Offset = "0x361D31C", VA = "0x361D31C")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x361DB08", Offset = "0x361DB08", VA = "0x361DB08")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x361C224", Offset = "0x361C224", VA = "0x361C224")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x361C35C", Offset = "0x361C35C", VA = "0x361C35C")]
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
			[Address(RVA = "0x36202F8", Offset = "0x36202F8", VA = "0x36202F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x3620300", Offset = "0x3620300", VA = "0x3620300")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public List<LinkInformation> DeepLinkingProtocols
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x362030C", Offset = "0x362030C", VA = "0x362030C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x3620314", Offset = "0x3620314", VA = "0x3620314")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public List<LinkInformation> DomainProtocols
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x362031C", Offset = "0x362031C", VA = "0x362031C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x3620324", Offset = "0x3620324", VA = "0x3620324")]
			set
			{
			}
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x361E188", Offset = "0x361E188", VA = "0x361E188")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959410", Offset = "0x1959410")]
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
			[Address(RVA = "0x361E744", Offset = "0x361E744", VA = "0x361E744")]
			public <>c()
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x361E74C", Offset = "0x361E74C", VA = "0x361E74C")]
			internal List<LinkInformation> <GetPlatformDeepLinkingProtocols>b__21_0(PlatformLinkingConfiguration c)
			{
				return null;
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x361E764", Offset = "0x361E764", VA = "0x361E764")]
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
			[Address(RVA = "0x361DD6C", Offset = "0x361DD6C", VA = "0x361DD6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x361DD74", Offset = "0x361DD74", VA = "0x361DD74")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public List<LinkInformation> DeepLinkingProtocols
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x361DD7C", Offset = "0x361DD7C", VA = "0x361DD7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x361DD98", Offset = "0x361DD98", VA = "0x361DD98")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public List<LinkInformation> DomainProtocols
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x361DDB4", Offset = "0x361DDB4", VA = "0x361DDB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x361DDD0", Offset = "0x361DDD0", VA = "0x361DDD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public PlatformLinkingConfiguration[] CustomDeepLinkingProtocols
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x361DDEC", Offset = "0x361DDEC", VA = "0x361DDEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x361DDF4", Offset = "0x361DDF4", VA = "0x361DDF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public string DisplayName
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x361DFE8", Offset = "0x361DFE8", VA = "0x361DFE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x361DFF0", Offset = "0x361DFF0", VA = "0x361DFF0")]
			set
			{
			}
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x361DFF8", Offset = "0x361DFF8", VA = "0x361DFF8")]
		public AppLinkingConfiguration()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x361E228", Offset = "0x361E228", VA = "0x361E228")]
		internal void EnsureAllPlats()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x361E250", Offset = "0x361E250", VA = "0x361E250")]
		public List<LinkInformation> GetPlatformDeepLinkingProtocols(SupportedPlatforms plat, bool includeDefault = false)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x361E420", Offset = "0x361E420", VA = "0x361E420")]
		public List<LinkInformation> GetPlatformDomainProtocols(SupportedPlatforms plat, bool includeDefault = false)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x361E358", Offset = "0x361E358", VA = "0x361E358")]
		private List<LinkInformation> GetCustomOrDefault(SupportedPlatforms plat, Func<PlatformLinkingConfiguration, List<LinkInformation>> func, bool includeDefault, List<LinkInformation> global)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x361E528", Offset = "0x361E528", VA = "0x361E528")]
		public List<LinkInformation> GetCustomDeepLinkingProtocols(SupportedPlatforms value)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x361E56C", Offset = "0x361E56C", VA = "0x361E56C")]
		public List<LinkInformation> GetCustomDomainAssociation(SupportedPlatforms value)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x361E5B0", Offset = "0x361E5B0", VA = "0x361E5B0")]
		public void ActivatePlatformOverride(SupportedPlatforms value)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x361E5F8", Offset = "0x361E5F8", VA = "0x361E5F8")]
		public void DeactivatePlatformOverride(SupportedPlatforms value)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x361DE1C", Offset = "0x361DE1C", VA = "0x361DE1C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1961E44", Offset = "0x1961E44")]
			private string <Url>k__BackingField;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1961E54", Offset = "0x1961E54")]
			private string <Query>k__BackingField;

			[Token(Token = "0x170000D6")]
			private string Url
			{
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x361F8D4", Offset = "0x361F8D4", VA = "0x361F8D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19649E8", Offset = "0x19649E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x600074E")]
				[Address(RVA = "0x361F8DC", Offset = "0x361F8DC", VA = "0x361F8DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19649F8", Offset = "0x19649F8")]
				set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			public string Query
			{
				[Token(Token = "0x600074F")]
				[Address(RVA = "0x361F8E4", Offset = "0x361F8E4", VA = "0x361F8E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964A08", Offset = "0x1964A08")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000750")]
				[Address(RVA = "0x361F8EC", Offset = "0x361F8EC", VA = "0x361F8EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964A18", Offset = "0x1964A18")]
				private set
				{
				}
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x361F738", Offset = "0x361F738", VA = "0x361F738")]
			public UrlEncodingParser([Optional] string queryStringOrUrl)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x361FB58", Offset = "0x361FB58", VA = "0x361FB58")]
			public void SetValues(string key, IEnumerable<string> values)
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x361F8F4", Offset = "0x361F8F4", VA = "0x361F8F4")]
			public Dictionary<string, string> Parse(string query)
			{
				return null;
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x361FDCC", Offset = "0x361FDCC", VA = "0x361FDCC", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D0F8", Offset = "0x195D0F8")]
		private static DeepLinkManager <Instance>k__BackingField;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D108", Offset = "0x195D108")]
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
			[Address(RVA = "0x361E77C", Offset = "0x361E77C", VA = "0x361E77C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19642A4", Offset = "0x19642A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x361E7E4", Offset = "0x361E7E4", VA = "0x361E7E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19642B4", Offset = "0x19642B4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool IsSteamBuild
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x361E850", Offset = "0x361E850", VA = "0x361E850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19642C4", Offset = "0x19642C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x361E858", Offset = "0x361E858", VA = "0x361E858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19642D4", Offset = "0x19642D4")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event LinkActivationHandler LinkActivated
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x361BF88", Offset = "0x361BF88", VA = "0x361BF88")]
			add
			{
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x361ED48", Offset = "0x361ED48", VA = "0x361ED48")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		private event LinkActivationHandler _activated
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x361E914", Offset = "0x361E914", VA = "0x361E914")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19642E4", Offset = "0x19642E4")]
			add
			{
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x361ED4C", Offset = "0x361ED4C", VA = "0x361ED4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19642F4", Offset = "0x19642F4")]
			remove
			{
			}
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x361E864", Offset = "0x361E864", VA = "0x361E864")]
		static DeepLinkManager()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x361E90C", Offset = "0x361E90C", VA = "0x361E90C")]
		private DeepLinkManager()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x361EDF0", Offset = "0x361EDF0", VA = "0x361EDF0")]
		public void ManuallyTriggerDeepLink(string args)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x361E9B8", Offset = "0x361E9B8", VA = "0x361E9B8")]
		private void RegisterIfNecessary()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x361EF14", Offset = "0x361EF14", VA = "0x361EF14")]
		private void CreatePauseGameObject()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x361EE1C", Offset = "0x361EE1C", VA = "0x361EE1C")]
		private void _currProvider_LinkReceived(string s)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x361F250", Offset = "0x361F250", VA = "0x361F250")]
		private void StoreActivation(string s)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x361F110", Offset = "0x361F110", VA = "0x361F110")]
		private bool OnActivated(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x361F258", Offset = "0x361F258", VA = "0x361F258")]
		private LinkActivation CreateLinkActivation(string s)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x361F818", Offset = "0x361F818", VA = "0x361F818")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D128", Offset = "0x195D128")]
		private string <Uri>k__BackingField;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D138", Offset = "0x195D138")]
		private string <RawQueryString>k__BackingField;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195D148", Offset = "0x195D148")]
		private Dictionary<string, string> <QueryString>k__BackingField;

		[Token(Token = "0x1700007B")]
		public string Uri
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x36201E0", Offset = "0x36201E0", VA = "0x36201E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964324", Offset = "0x1964324")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x36201E8", Offset = "0x36201E8", VA = "0x36201E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964334", Offset = "0x1964334")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public string RawQueryString
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x36201F0", Offset = "0x36201F0", VA = "0x36201F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964344", Offset = "0x1964344")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x36201F8", Offset = "0x36201F8", VA = "0x36201F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964354", Offset = "0x1964354")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Dictionary<string, string> QueryString
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x3620200", Offset = "0x3620200", VA = "0x3620200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964364", Offset = "0x1964364")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x3620208", Offset = "0x3620208", VA = "0x3620208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964374", Offset = "0x1964374")]
			private set
			{
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x361F7D8", Offset = "0x361F7D8", VA = "0x361F7D8")]
		public LinkActivation(string uri, string rawQueryString, Dictionary<string, string> queryStringParams)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x3620210", Offset = "0x3620210", VA = "0x3620210", Slot = "3")]
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
			[Address(RVA = "0x3620248", Offset = "0x3620248", VA = "0x3620248")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x3620250", Offset = "0x3620250", VA = "0x3620250")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public string Host
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x3620258", Offset = "0x3620258", VA = "0x3620258")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x3620260", Offset = "0x3620260", VA = "0x3620260")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public string Path
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x3620268", Offset = "0x3620268", VA = "0x3620268")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x3620270", Offset = "0x3620270", VA = "0x3620270")]
			set
			{
			}
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x3620278", Offset = "0x3620278", VA = "0x3620278")]
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
		[Address(RVA = "0x361EEB8", Offset = "0x361EEB8", VA = "0x361EEB8")]
		public ILinkProvider GetProvider(bool isSteamBuild)
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x361EEB0", Offset = "0x361EEB0", VA = "0x361EEB0")]
		public LinkProviderFactory()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public static class ProviderHelpers
	{
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x362032C", Offset = "0x362032C", VA = "0x362032C")]
		public static string GetExecutingPath()
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	public class UniversalDeeplinkingRuntimeScript : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959420", Offset = "0x1959420")]
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
				[Address(RVA = "0x3621DAC", Offset = "0x3621DAC", VA = "0x3621DAC", Slot = "4")]
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
				[Address(RVA = "0x3621E14", Offset = "0x3621E14", VA = "0x3621E14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x3621B08", Offset = "0x3621B08", VA = "0x3621B08")]
			[DebuggerHidden]
			public <CallDeepLinkManagerAfterDelay>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x3621B3C", Offset = "0x3621B3C", VA = "0x3621B3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x3621B40", Offset = "0x3621B40", VA = "0x3621B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x3621DB4", Offset = "0x3621DB4", VA = "0x3621DB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _onJob;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x36219B4", Offset = "0x36219B4", VA = "0x36219B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x3621A30", Offset = "0x3621A30", VA = "0x3621A30")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x3621AD4", Offset = "0x3621AD4", VA = "0x3621AD4")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x3621A64", Offset = "0x3621A64", VA = "0x3621A64")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1964384", Offset = "0x1964384")]
		public IEnumerator CallDeepLinkManagerAfterDelay()
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x3621B34", Offset = "0x3621B34", VA = "0x3621B34")]
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
		[Address(RVA = "0x3621310", Offset = "0x3621310", VA = "0x3621310")]
		public static void Save(AppLinkingConfiguration config)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x36216C4", Offset = "0x36216C4", VA = "0x36216C4")]
		public static AppLinkingConfiguration Load()
		{
			return null;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x3621590", Offset = "0x3621590", VA = "0x3621590")]
		private static void EnsureDirectories()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x36213CC", Offset = "0x36213CC", VA = "0x36213CC")]
		private static string GetConfigurationLocation()
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x36217E0", Offset = "0x36217E0", VA = "0x36217E0")]
		public static string CombinePaths(params string[] paths)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x36218A8", Offset = "0x36218A8", VA = "0x36218A8")]
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
			[Address(RVA = "0x3620D7C", Offset = "0x3620D7C", VA = "0x3620D7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19643E8", Offset = "0x19643E8")]
			add
			{
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x3620E20", Offset = "0x3620E20", VA = "0x3620E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19643F8", Offset = "0x19643F8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<string> LinkReceived
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x3620EC4", Offset = "0x3620EC4", VA = "0x3620EC4", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x3620F04", Offset = "0x3620F04", VA = "0x3620F04", Slot = "6")]
			remove
			{
			}
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x3620560", Offset = "0x3620560", VA = "0x3620560", Slot = "4")]
		public bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x362060C", Offset = "0x362060C", VA = "0x362060C")]
		private void VerifyIfHasOpenByLink()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x3620A40", Offset = "0x3620A40", VA = "0x3620A40")]
		public static string safeCallStringMethod(AndroidJavaObject javaObject, string methodName, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x3620F08", Offset = "0x3620F08", VA = "0x3620F08", Slot = "7")]
		public void PollInfoAfterPause()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x3620D08", Offset = "0x3620D08", VA = "0x3620D08")]
		private void OnLinkReceived(string lastLink)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x3620BB4", Offset = "0x3620BB4", VA = "0x3620BB4")]
		private static bool IsValidUri(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x361EEA8", Offset = "0x361EEA8", VA = "0x361EEA8")]
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
			[Address(RVA = "0x3620F80", Offset = "0x3620F80", VA = "0x3620F80", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964408", Offset = "0x1964408")]
			add
			{
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x3621024", Offset = "0x3621024", VA = "0x3621024", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964418", Offset = "0x1964418")]
			remove
			{
			}
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x3620F0C", Offset = "0x3620F0C", VA = "0x3620F0C", Slot = "4")]
		public bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x36210C8", Offset = "0x36210C8", VA = "0x36210C8", Slot = "7")]
		public void PollInfoAfterPause()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x36210CC", Offset = "0x36210CC", VA = "0x36210CC", Slot = "8")]
		protected virtual void OnLinkReceived(string obj)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x36202F0", Offset = "0x36202F0", VA = "0x36202F0")]
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
			[Address(RVA = "0x3621148", Offset = "0x3621148", VA = "0x3621148", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964428", Offset = "0x1964428")]
			add
			{
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x36211EC", Offset = "0x36211EC", VA = "0x36211EC", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1964438", Offset = "0x1964438")]
			remove
			{
			}
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x361EE48", Offset = "0x361EE48", VA = "0x361EE48")]
		public EditorLinkProvider()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x3621140", Offset = "0x3621140", VA = "0x3621140", Slot = "4")]
		public bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x3621290", Offset = "0x3621290", VA = "0x3621290", Slot = "7")]
		public void PollInfoAfterPause()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x3621294", Offset = "0x3621294", VA = "0x3621294")]
		public static void SimulateLink(string link)
		{
		}
	}
}
