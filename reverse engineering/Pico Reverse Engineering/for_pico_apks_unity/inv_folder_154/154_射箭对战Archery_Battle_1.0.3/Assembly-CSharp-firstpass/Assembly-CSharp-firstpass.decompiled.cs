using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.UI;

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
		[Address(RVA = "0x1D59FC8", Offset = "0x1D59FC8", VA = "0x1D59FC8", Slot = "4")]
		public virtual void OnInitiate(Baker baker, Animator animator)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1D59FFC", Offset = "0x1D59FFC", VA = "0x1D59FFC", Slot = "5")]
		public virtual void OnStartClip(AnimationClip clip)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1D5A000", Offset = "0x1D5A000", VA = "0x1D5A000", Slot = "6")]
		public virtual void OnBakerUpdate(float normalizedTime)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1D5A004", Offset = "0x1D5A004", VA = "0x1D5A004")]
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
		[Address(RVA = "0x1D5A00C", Offset = "0x1D5A00C", VA = "0x1D5A00C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1D5A220", Offset = "0x1D5A220", VA = "0x1D5A220")]
		private void OnBakerStartClip(AnimationClip clip, float normalizedTime)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1D5A2A0", Offset = "0x1D5A2A0", VA = "0x1D5A2A0")]
		private void OnBakerUpdateClip(AnimationClip clip, float normalizedTime)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1D5A33C", Offset = "0x1D5A33C", VA = "0x1D5A33C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1D5A4D0", Offset = "0x1D5A4D0", VA = "0x1D5A4D0")]
		public AnimationModifierStack()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AB7C", Offset = "0x82AB7C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AB7C", Offset = "0x82AB7C")]
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
			[Address(RVA = "0x1513560", Offset = "0x1513560", VA = "0x1513560")]
			public ClipSettings()
			{
			}
		}

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BBD8", Offset = "0x82BBD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82BBD8", Offset = "0x82BBD8")]
		public int frameRate;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82BC30", Offset = "0x82BC30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BC30", Offset = "0x82BC30")]
		public float keyReductionError;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BC88", Offset = "0x82BC88")]
		public Mode mode;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BCC0", Offset = "0x82BCC0")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BCF8", Offset = "0x82BCF8")]
		public string[] animationStates;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BD30", Offset = "0x82BD30")]
		public string saveToFolder;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BD68", Offset = "0x82BD68")]
		public string appendName;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BDA0", Offset = "0x82BDA0")]
		public string saveName;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82BDD8", Offset = "0x82BDD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BDD8", Offset = "0x82BDD8")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BE14", Offset = "0x82BE14")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82BE14", Offset = "0x82BE14")]
		private float <bakingProgress>k__BackingField;

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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BE70", Offset = "0x82BE70")]
		public bool inheritClipSettings;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BEA8", Offset = "0x82BEA8")]
		public ClipSettings clipSettings;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82BEE0", Offset = "0x82BEE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BEE0", Offset = "0x82BEE0")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected bool addLoopFrame;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1D5CF70", Offset = "0x1D5CF70", VA = "0x1D5CF70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D1C", Offset = "0x836D1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1D5CF78", Offset = "0x1D5CF78", VA = "0x1D5CF78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D2C", Offset = "0x836D2C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1D5CF84", Offset = "0x1D5CF84", VA = "0x1D5CF84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D3C", Offset = "0x836D3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x1D5CF8C", Offset = "0x1D5CF8C", VA = "0x1D5CF8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D4C", Offset = "0x836D4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1D5CF94", Offset = "0x1D5CF94", VA = "0x1D5CF94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D5C", Offset = "0x836D5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x1D5CF9C", Offset = "0x1D5CF9C", VA = "0x1D5CF9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D6C", Offset = "0x836D6C")]
			private set
			{
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1D5CE50", Offset = "0x1D5CE50", VA = "0x1D5CE50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x836C3C", Offset = "0x836C3C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1D5CE98", Offset = "0x1D5CE98", VA = "0x1D5CE98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x836C74", Offset = "0x836C74")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1D5CEE0", Offset = "0x1D5CEE0", VA = "0x1D5CEE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x836CAC", Offset = "0x836CAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1D5CF28", Offset = "0x1D5CF28", VA = "0x1D5CF28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x836CE4", Offset = "0x836CE4")]
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
		[Address(RVA = "0x1D5CFA4", Offset = "0x1D5CFA4", VA = "0x1D5CFA4")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1D5CFA8", Offset = "0x1D5CFA8", VA = "0x1D5CFA8")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1D5CFAC", Offset = "0x1D5CFAC", VA = "0x1D5CFAC")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1D5CFB0", Offset = "0x1D5CFB0", VA = "0x1D5CFB0")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BF1C", Offset = "0x82BF1C")]
		public bool markAsLegacy;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BF54", Offset = "0x82BF54")]
		public Transform root;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BF8C", Offset = "0x82BF8C")]
		public Transform rootNode;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BFC4", Offset = "0x82BFC4")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82BFFC", Offset = "0x82BFFC")]
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
		[Address(RVA = "0x1E1A304", Offset = "0x1E1A304", VA = "0x1E1A304")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1E1A708", Offset = "0x1E1A708", VA = "0x1E1A708", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1E1A710", Offset = "0x1E1A710", VA = "0x1E1A710", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1E1A820", Offset = "0x1E1A820", VA = "0x1E1A820", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1E1A89C", Offset = "0x1E1A89C", VA = "0x1E1A89C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1E1A918", Offset = "0x1E1A918", VA = "0x1E1A918", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1E1A560", Offset = "0x1E1A560", VA = "0x1E1A560")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1E1A634", Offset = "0x1E1A634", VA = "0x1E1A634")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1E1A994", Offset = "0x1E1A994", VA = "0x1E1A994")]
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
		[Address(RVA = "0x17EEB38", Offset = "0x17EEB38", VA = "0x17EEB38")]
		public TQ()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x17EEB40", Offset = "0x17EEB40", VA = "0x17EEB40")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class AvatarUtility
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1D5BC18", Offset = "0x1D5BC18", VA = "0x1D5BC18")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1D5BE78", Offset = "0x1D5BE78", VA = "0x1D5BE78")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1D5C434", Offset = "0x1D5C434", VA = "0x1D5C434")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1D5C8D8", Offset = "0x1D5C8D8", VA = "0x1D5C8D8")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1D5BE58", Offset = "0x1D5BE58", VA = "0x1D5BE58")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1D5CA6C", Offset = "0x1D5CA6C", VA = "0x1D5CA6C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1D5E4A0", Offset = "0x1D5E4A0", VA = "0x1D5E4A0")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1D5FDD0", Offset = "0x1D5FDD0", VA = "0x1D5FDD0")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1D5DEF0", Offset = "0x1D5DEF0", VA = "0x1D5DEF0")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1D5E4E8", Offset = "0x1D5E4E8", VA = "0x1D5E4E8")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1D5DA20", Offset = "0x1D5DA20", VA = "0x1D5DA20")]
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
		[Address(RVA = "0x1D5D0C4", Offset = "0x1D5D0C4", VA = "0x1D5D0C4")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1D5D3D8", Offset = "0x1D5D3D8", VA = "0x1D5D3D8")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1D5D5B4", Offset = "0x1D5D5B4", VA = "0x1D5D5B4")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1D5D670", Offset = "0x1D5D670", VA = "0x1D5D670")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1D5C99C", Offset = "0x1D5C99C", VA = "0x1D5C99C")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1D5D6F0", Offset = "0x1D5D6F0", VA = "0x1D5D6F0")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1D5D27C", Offset = "0x1D5D27C", VA = "0x1D5D27C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1D5D6F4", Offset = "0x1D5D6F4", VA = "0x1D5D6F4")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1D5DC84", Offset = "0x1D5DC84", VA = "0x1D5DC84")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1D5DD80", Offset = "0x1D5DD80", VA = "0x1D5DD80")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1D5DE7C", Offset = "0x1D5DE7C", VA = "0x1D5DE7C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1D5E0E8", Offset = "0x1D5E0E8", VA = "0x1D5E0E8")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1D5DDF4", Offset = "0x1D5DDF4", VA = "0x1D5DDF4")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1D5E0EC", Offset = "0x1D5E0EC", VA = "0x1D5E0EC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1D5E1A0", Offset = "0x1D5E1A0", VA = "0x1D5E1A0")]
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
		[Address(RVA = "0x1D5E4EC", Offset = "0x1D5E4EC", VA = "0x1D5E4EC")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1D5E568", Offset = "0x1D5E568", VA = "0x1D5E568")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1D5F004", Offset = "0x1D5F004", VA = "0x1D5F004")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1D5F0B8", Offset = "0x1D5F0B8", VA = "0x1D5F0B8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1D5EFA0", Offset = "0x1D5EFA0", VA = "0x1D5EFA0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1D5F1B0", Offset = "0x1D5F1B0", VA = "0x1D5F1B0")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1D5F1F8", Offset = "0x1D5F1F8", VA = "0x1D5F1F8")]
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
		[Address(RVA = "0x1D5F200", Offset = "0x1D5F200", VA = "0x1D5F200")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1D5F3F0", Offset = "0x1D5F3F0", VA = "0x1D5F3F0")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1D5F404", Offset = "0x1D5F404", VA = "0x1D5F404")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1D5F6F0", Offset = "0x1D5F6F0", VA = "0x1D5F6F0")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1D5F2AC", Offset = "0x1D5F2AC", VA = "0x1D5F2AC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1D5F9A4", Offset = "0x1D5F9A4", VA = "0x1D5F9A4")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1D5FA18", Offset = "0x1D5FA18", VA = "0x1D5FA18")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1D5FBCC", Offset = "0x1D5FBCC", VA = "0x1D5FBCC")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C034", Offset = "0x82C034")]
		public bool bakeHandIK;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C06C", Offset = "0x82C06C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C06C", Offset = "0x82C06C")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C0C4", Offset = "0x82C0C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C0C4", Offset = "0x82C0C4")]
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
		[Address(RVA = "0x1E24100", Offset = "0x1E24100", VA = "0x1E24100")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1E24694", Offset = "0x1E24694", VA = "0x1E24694", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1E246B0", Offset = "0x1E246B0", VA = "0x1E246B0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1E2478C", Offset = "0x1E2478C", VA = "0x1E2478C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1E24868", Offset = "0x1E24868", VA = "0x1E24868", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1E24A38", Offset = "0x1E24A38", VA = "0x1E24A38", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1E24D80", Offset = "0x1E24D80", VA = "0x1E24D80")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1E24E6C", Offset = "0x1E24E6C", VA = "0x1E24E6C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x82C118", Offset = "0x82C118")]
		public bool smoothFollow;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x82C150", Offset = "0x82C150")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x82C188", Offset = "0x82C188")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x82C1C0", Offset = "0x82C1C0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C1F8", Offset = "0x82C1F8")]
		public float blockedOffset;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C210", Offset = "0x82C210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C210", Offset = "0x82C210")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C24C", Offset = "0x82C24C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C24C", Offset = "0x82C24C")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C288", Offset = "0x82C288")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C288", Offset = "0x82C288")]
		private float <distanceTarget>k__BackingField;

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
			[Address(RVA = "0x1D696C8", Offset = "0x1D696C8", VA = "0x1D696C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D7C", Offset = "0x836D7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x1D696D0", Offset = "0x1D696D0", VA = "0x1D696D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D8C", Offset = "0x836D8C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x1D696D8", Offset = "0x1D696D8", VA = "0x1D696D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836D9C", Offset = "0x836D9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x1D696E0", Offset = "0x1D696E0", VA = "0x1D696E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836DAC", Offset = "0x836DAC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x1D696E8", Offset = "0x1D696E8", VA = "0x1D696E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836DBC", Offset = "0x836DBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x1D696F0", Offset = "0x1D696F0", VA = "0x1D696F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836DCC", Offset = "0x836DCC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1D69FD8", Offset = "0x1D69FD8", VA = "0x1D69FD8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1D696F8", Offset = "0x1D696F8", VA = "0x1D696F8")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1D69734", Offset = "0x1D69734", VA = "0x1D69734")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1D6973C", Offset = "0x1D6973C", VA = "0x1D6973C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1D6984C", Offset = "0x1D6984C", VA = "0x1D6984C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1D698A8", Offset = "0x1D698A8", VA = "0x1D698A8", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1D69910", Offset = "0x1D69910", VA = "0x1D69910", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1D69974", Offset = "0x1D69974", VA = "0x1D69974")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1D69880", Offset = "0x1D69880", VA = "0x1D69880")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1D69AF4", Offset = "0x1D69AF4", VA = "0x1D69AF4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1D69FA8", Offset = "0x1D69FA8", VA = "0x1D69FA8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1D6A048", Offset = "0x1D6A048", VA = "0x1D6A048")]
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
		[Address(RVA = "0x1D6A0F4", Offset = "0x1D6A0F4", VA = "0x1D6A0F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1D6A12C", Offset = "0x1D6A12C", VA = "0x1D6A12C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1D6A2D4", Offset = "0x1D6A2D4", VA = "0x1D6A2D4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1D6A304", Offset = "0x1D6A304", VA = "0x1D6A304")]
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
		[Address(RVA = "0x1D5CA74", Offset = "0x1D5CA74", VA = "0x1D5CA74")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1D5CA98", Offset = "0x1D5CA98", VA = "0x1D5CA98")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1D5CACC", Offset = "0x1D5CACC", VA = "0x1D5CACC")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1D5CBBC", Offset = "0x1D5CBBC", VA = "0x1D5CBBC")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1D5CB64", Offset = "0x1D5CB64", VA = "0x1D5CB64")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1D5CC54", Offset = "0x1D5CC54", VA = "0x1D5CC54")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1D5CC9C", Offset = "0x1D5CC9C", VA = "0x1D5CC9C")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1D5CE48", Offset = "0x1D5CE48", VA = "0x1D5CE48")]
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
			[Address(RVA = "0x1513568", Offset = "0x1513568", VA = "0x1513568")]
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
			[Address(RVA = "0x1D61A14", Offset = "0x1D61A14", VA = "0x1D61A14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x1D61C84", Offset = "0x1D61C84", VA = "0x1D61C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1D61994", Offset = "0x1D61994", VA = "0x1D61994")]
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
		[Address(RVA = "0x1D61EF4", Offset = "0x1D61EF4", VA = "0x1D61EF4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1D62218", Offset = "0x1D62218", VA = "0x1D62218")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1D6248C", Offset = "0x1D6248C", VA = "0x1D6248C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1D6250C", Offset = "0x1D6250C", VA = "0x1D6250C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1D625A4", Offset = "0x1D625A4", VA = "0x1D625A4")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1D620CC", Offset = "0x1D620CC", VA = "0x1D620CC")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1D623F0", Offset = "0x1D623F0", VA = "0x1D623F0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1D62DD4", Offset = "0x1D62DD4", VA = "0x1D62DD4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1D62BDC", Offset = "0x1D62BDC", VA = "0x1D62BDC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1D62CD8", Offset = "0x1D62CD8", VA = "0x1D62CD8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1D627BC", Offset = "0x1D627BC", VA = "0x1D627BC")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1D6286C", Offset = "0x1D6286C", VA = "0x1D6286C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1D6291C", Offset = "0x1D6291C", VA = "0x1D6291C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1D629CC", Offset = "0x1D629CC", VA = "0x1D629CC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1D62A7C", Offset = "0x1D62A7C", VA = "0x1D62A7C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1D62B2C", Offset = "0x1D62B2C", VA = "0x1D62B2C")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1D62FDC", Offset = "0x1D62FDC", VA = "0x1D62FDC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1D626D4", Offset = "0x1D626D4", VA = "0x1D626D4")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1D62F4C", Offset = "0x1D62F4C", VA = "0x1D62F4C")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1D63048", Offset = "0x1D63048", VA = "0x1D63048")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1D6311C", Offset = "0x1D6311C", VA = "0x1D6311C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1D62ED4", Offset = "0x1D62ED4", VA = "0x1D62ED4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1D62E60", Offset = "0x1D62E60", VA = "0x1D62E60")]
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
				[Address(RVA = "0x15135F4", Offset = "0x15135F4", VA = "0x15135F4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x15135E0", Offset = "0x15135E0", VA = "0x15135E0")]
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
			[Address(RVA = "0x1D65984", Offset = "0x1D65984", VA = "0x1D65984", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x1D65D6C", Offset = "0x1D65D6C", VA = "0x1D65D6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1D65D7C", Offset = "0x1D65D7C", VA = "0x1D65D7C", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1D661A4", Offset = "0x1D661A4", VA = "0x1D661A4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1D665D8", Offset = "0x1D665D8", VA = "0x1D665D8")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1D66CA8", Offset = "0x1D66CA8", VA = "0x1D66CA8")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1D66804", Offset = "0x1D66804", VA = "0x1D66804")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1D60C5C", Offset = "0x1D60C5C", VA = "0x1D60C5C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1D6752C", Offset = "0x1D6752C", VA = "0x1D6752C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1D67AE8", Offset = "0x1D67AE8", VA = "0x1D67AE8")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1D678C8", Offset = "0x1D678C8", VA = "0x1D678C8")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1D67744", Offset = "0x1D67744", VA = "0x1D67744")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1D675CC", Offset = "0x1D675CC", VA = "0x1D675CC")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1D679D4", Offset = "0x1D679D4", VA = "0x1D679D4")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1D67BE0", Offset = "0x1D67BE0", VA = "0x1D67BE0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1D687C8", Offset = "0x1D687C8", VA = "0x1D687C8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1D68238", Offset = "0x1D68238", VA = "0x1D68238")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1D68AC4", Offset = "0x1D68AC4", VA = "0x1D68AC4")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1D685B0", Offset = "0x1D685B0", VA = "0x1D685B0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1D68ACC", Offset = "0x1D68ACC", VA = "0x1D68ACC")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1D68AD4", Offset = "0x1D68AD4", VA = "0x1D68AD4")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1D68CA8", Offset = "0x1D68CA8", VA = "0x1D68CA8")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1D68E70", Offset = "0x1D68E70", VA = "0x1D68E70")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1D610DC", Offset = "0x1D610DC", VA = "0x1D610DC")]
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
		[Address(RVA = "0x1215894", Offset = "0x1215894", VA = "0x1215894")]
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
		[Address(RVA = "0x12240D8", Offset = "0x12240D8", VA = "0x12240D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1224220", Offset = "0x1224220", VA = "0x1224220")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Hierarchy
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1E21FB0", Offset = "0x1E21FB0", VA = "0x1E21FB0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1E2219C", Offset = "0x1E2219C", VA = "0x1E2219C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1E22048", Offset = "0x1E22048", VA = "0x1E22048")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1E222C4", Offset = "0x1E222C4", VA = "0x1E222C4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1E223F0", Offset = "0x1E223F0", VA = "0x1E223F0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1E22644", Offset = "0x1E22644", VA = "0x1E22644")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1E2274C", Offset = "0x1E2274C", VA = "0x1E2274C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1E228C0", Offset = "0x1E228C0", VA = "0x1E228C0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1E22CA0", Offset = "0x1E22CA0", VA = "0x1E22CA0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1E22A64", Offset = "0x1E22A64", VA = "0x1E22A64")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1E22E54", Offset = "0x1E22E54", VA = "0x1E22E54")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1DE6F68", Offset = "0x1DE6F68", VA = "0x1DE6F68")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1DE6FF4", Offset = "0x1DE6FF4", VA = "0x1DE6FF4")]
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
		[Address(RVA = "0x1DEABF8", Offset = "0x1DEABF8", VA = "0x1DEABF8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1DF0C60", Offset = "0x1DF0C60", VA = "0x1DF0C60")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1DF0CD4", Offset = "0x1DF0CD4", VA = "0x1DF0CD4")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1DF06C8", Offset = "0x1DF06C8", VA = "0x1DF06C8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1DF06D4", Offset = "0x1DF06D4", VA = "0x1DF06D4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1DF06F8", Offset = "0x1DF06F8", VA = "0x1DF06F8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1DF0734", Offset = "0x1DF0734", VA = "0x1DF0734")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1DF074C", Offset = "0x1DF074C", VA = "0x1DF074C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1DF0760", Offset = "0x1DF0760", VA = "0x1DF0760")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1DF0774", Offset = "0x1DF0774", VA = "0x1DF0774")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1DF0784", Offset = "0x1DF0784", VA = "0x1DF0784")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1DF07CC", Offset = "0x1DF07CC", VA = "0x1DF07CC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1DF0804", Offset = "0x1DF0804", VA = "0x1DF0804")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1DF082C", Offset = "0x1DF082C", VA = "0x1DF082C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1DF0D60", Offset = "0x1DF0D60", VA = "0x1DF0D60")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1DF0860", Offset = "0x1DF0860", VA = "0x1DF0860")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1DF0888", Offset = "0x1DF0888", VA = "0x1DF0888")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1DF08B8", Offset = "0x1DF08B8", VA = "0x1DF08B8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1DF08EC", Offset = "0x1DF08EC", VA = "0x1DF08EC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1DF0930", Offset = "0x1DF0930", VA = "0x1DF0930")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1DF0994", Offset = "0x1DF0994", VA = "0x1DF0994")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1DF09F8", Offset = "0x1DF09F8", VA = "0x1DF09F8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1DF0A4C", Offset = "0x1DF0A4C", VA = "0x1DF0A4C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1DF0AA0", Offset = "0x1DF0AA0", VA = "0x1DF0AA0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1DF0ADC", Offset = "0x1DF0ADC", VA = "0x1DF0ADC")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1DF0B14", Offset = "0x1DF0B14", VA = "0x1DF0B14")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1DF0D94", Offset = "0x1DF0D94", VA = "0x1DF0D94")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1DF0B5C", Offset = "0x1DF0B5C", VA = "0x1DF0B5C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1DF0BF0", Offset = "0x1DF0BF0", VA = "0x1DF0BF0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1DF0C20", Offset = "0x1DF0C20", VA = "0x1DF0C20")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1DF0E28", Offset = "0x1DF0E28", VA = "0x1DF0E28")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1DF1000", Offset = "0x1DF1000", VA = "0x1DF1000")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1DF1058", Offset = "0x1DF1058", VA = "0x1DF1058")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1DF1124", Offset = "0x1DF1124", VA = "0x1DF1124")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1DF1070", Offset = "0x1DF1070", VA = "0x1DF1070")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1DF113C", Offset = "0x1DF113C", VA = "0x1DF113C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1DF11E0", Offset = "0x1DF11E0", VA = "0x1DF11E0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1DF120C", Offset = "0x1DF120C", VA = "0x1DF120C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1DF125C", Offset = "0x1DF125C", VA = "0x1DF125C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1DF12C8", Offset = "0x1DF12C8", VA = "0x1DF12C8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1DF13DC", Offset = "0x1DF13DC", VA = "0x1DF13DC")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1DF14D4", Offset = "0x1DF14D4", VA = "0x1DF14D4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1DF1530", Offset = "0x1DF1530", VA = "0x1DF1530")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x82ABEC", Offset = "0x82ABEC")]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C2D4", Offset = "0x82C2D4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C2D4", Offset = "0x82C2D4")]
		private string <propName>k__BackingField;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C310", Offset = "0x82C310")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C310", Offset = "0x82C310")]
		private object <propValue>k__BackingField;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C34C", Offset = "0x82C34C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C34C", Offset = "0x82C34C")]
		private object <otherPropValue>k__BackingField;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C388", Offset = "0x82C388")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C388", Offset = "0x82C388")]
		private bool <indent>k__BackingField;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C3C4", Offset = "0x82C3C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C3C4", Offset = "0x82C3C4")]
		private ShowIfMode <mode>k__BackingField;

		[Token(Token = "0x1700000F")]
		public string propName
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x17ED4C4", Offset = "0x17ED4C4", VA = "0x17ED4C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836E4C", Offset = "0x836E4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x17ED4CC", Offset = "0x17ED4CC", VA = "0x17ED4CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836E5C", Offset = "0x836E5C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public object propValue
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x17ED4D4", Offset = "0x17ED4D4", VA = "0x17ED4D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836E6C", Offset = "0x836E6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x17ED4DC", Offset = "0x17ED4DC", VA = "0x17ED4DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836E7C", Offset = "0x836E7C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public object otherPropValue
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x17ED4E4", Offset = "0x17ED4E4", VA = "0x17ED4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836E8C", Offset = "0x836E8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x17ED4EC", Offset = "0x17ED4EC", VA = "0x17ED4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836E9C", Offset = "0x836E9C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool indent
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x17ED4F4", Offset = "0x17ED4F4", VA = "0x17ED4F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836EAC", Offset = "0x836EAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x17ED4FC", Offset = "0x17ED4FC", VA = "0x17ED4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836EBC", Offset = "0x836EBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x17ED508", Offset = "0x17ED508", VA = "0x17ED508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836ECC", Offset = "0x836ECC")]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x17ED510", Offset = "0x17ED510", VA = "0x17ED510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836EDC", Offset = "0x836EDC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x17ED518", Offset = "0x17ED518", VA = "0x17ED518")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x82AC24", Offset = "0x82AC24")]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C400", Offset = "0x82C400")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C400", Offset = "0x82C400")]
		private float <min>k__BackingField;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C43C", Offset = "0x82C43C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C43C", Offset = "0x82C43C")]
		private float <max>k__BackingField;

		[Token(Token = "0x17000014")]
		public float min
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x17ED730", Offset = "0x17ED730", VA = "0x17ED730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836EEC", Offset = "0x836EEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x17ED738", Offset = "0x17ED738", VA = "0x17ED738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836EFC", Offset = "0x836EFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float max
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x17ED740", Offset = "0x17ED740", VA = "0x17ED740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836F0C", Offset = "0x836F0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x17ED748", Offset = "0x17ED748", VA = "0x17ED748")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836F1C", Offset = "0x836F1C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x17ED750", Offset = "0x17ED750", VA = "0x17ED750")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string color;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x17ED59C", Offset = "0x17ED59C", VA = "0x17ED59C")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x17ED664", Offset = "0x17ED664", VA = "0x17ED664")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1DF0EE4", Offset = "0x1DF0EE4", VA = "0x1DF0EE4")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1DF0F70", Offset = "0x1DF0F70", VA = "0x1DF0F70")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public static class QuaTools
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x17E6EB8", Offset = "0x17E6EB8", VA = "0x17E6EB8")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x17E6F14", Offset = "0x17E6F14", VA = "0x17E6F14")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x17E6FA4", Offset = "0x17E6FA4", VA = "0x17E6FA4")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x17E7104", Offset = "0x17E7104", VA = "0x17E7104")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x17E71C0", Offset = "0x17E71C0", VA = "0x17E71C0")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x17E727C", Offset = "0x17E727C", VA = "0x17E727C")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x17E7428", Offset = "0x17E7428", VA = "0x17E7428")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x17E7478", Offset = "0x17E7478", VA = "0x17E7478")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x17E74C8", Offset = "0x17E74C8", VA = "0x17E74C8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x17E7570", Offset = "0x17E7570", VA = "0x17E7570")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x17E7618", Offset = "0x17E7618", VA = "0x17E7618")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x17E76F8", Offset = "0x17E76F8", VA = "0x17E76F8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x17E66EC", Offset = "0x17E66EC", VA = "0x17E66EC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x17E65DC", Offset = "0x17E65DC", VA = "0x17E65DC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x17E774C", Offset = "0x17E774C", VA = "0x17E774C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x17E78DC", Offset = "0x17E78DC", VA = "0x17E78DC")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x17E79D0", Offset = "0x17E79D0", VA = "0x17E79D0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x17E7ADC", Offset = "0x17E7ADC", VA = "0x17E7ADC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x17E7BC8", Offset = "0x17E7BC8", VA = "0x17E7BC8")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x17E7C24", Offset = "0x17E7C24", VA = "0x17E7C24")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x17E7D60", Offset = "0x17E7D60", VA = "0x17E7D60")]
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
			[Token(Token = "0x600011B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011C")]
		public static void Clear()
		{
		}

		[Token(Token = "0x600011D")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600011E")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C478", Offset = "0x82C478")]
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
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x17EE634", Offset = "0x17EE634", VA = "0x17EE634")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		private bool isAnimated
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x17EE980", Offset = "0x17EE980", VA = "0x17EE980")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x17EE4F4", Offset = "0x17EE4F4", VA = "0x17EE4F4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x17EE594", Offset = "0x17EE594", VA = "0x17EE594", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x17EE598", Offset = "0x17EE598", VA = "0x17EE598", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x17EE59C", Offset = "0x17EE59C", VA = "0x17EE59C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x17EE5A0", Offset = "0x17EE5A0", VA = "0x17EE5A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x17EE630", Offset = "0x17EE630", VA = "0x17EE630")]
		private void Start()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x17EE5D8", Offset = "0x17EE5D8", VA = "0x17EE5D8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x17EE934", Offset = "0x17EE934", VA = "0x17EE934")]
		private void Update()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x17EE720", Offset = "0x17EE720", VA = "0x17EE720")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x17EEA38", Offset = "0x17EEA38", VA = "0x17EEA38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x17EEA94", Offset = "0x17EEA94", VA = "0x17EEA94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x17EEAF0", Offset = "0x17EEAF0", VA = "0x17EEAF0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x17E6EA8", Offset = "0x17E6EA8", VA = "0x17E6EA8")]
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

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x17EF1A4", Offset = "0x17EF1A4", VA = "0x17EF1A4")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x17EF264", Offset = "0x17EF264", VA = "0x17EF264")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x17EF324", Offset = "0x17EF324", VA = "0x17EF324")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x17EF3E4", Offset = "0x17EF3E4", VA = "0x17EF3E4")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public static class V2Tools
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x17F188C", Offset = "0x17F188C", VA = "0x17F188C")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x17F1894", Offset = "0x17F1894", VA = "0x17F1894")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x17F18E4", Offset = "0x17F18E4", VA = "0x17F18E4")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x17F1938", Offset = "0x17F1938", VA = "0x17F1938")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x17F1A10", Offset = "0x17F1A10", VA = "0x17F1A10")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000031")]
	public static class V3Tools
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x17F1AA4", Offset = "0x17F1AA4", VA = "0x17F1AA4")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x17F1AC8", Offset = "0x17F1AC8", VA = "0x17F1AC8")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x17F1B10", Offset = "0x17F1B10", VA = "0x17F1B10")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x17F1B9C", Offset = "0x17F1B9C", VA = "0x17F1B9C")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x17F1BFC", Offset = "0x17F1BFC", VA = "0x17F1BFC")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x17F1C5C", Offset = "0x17F1C5C", VA = "0x17F1C5C")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x17F1D78", Offset = "0x17F1D78", VA = "0x17F1D78")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x17F1E18", Offset = "0x17F1E18", VA = "0x17F1E18")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x17F1E54", Offset = "0x17F1E54", VA = "0x17F1E54")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x17F1F24", Offset = "0x17F1F24", VA = "0x17F1F24")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x17F201C", Offset = "0x17F201C", VA = "0x17F201C")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x17F20C4", Offset = "0x17F20C4", VA = "0x17F20C4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x17F2220", Offset = "0x17F2220", VA = "0x17F2220")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x17F239C", Offset = "0x17F239C", VA = "0x17F239C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x17F2520", Offset = "0x17F2520", VA = "0x17F2520")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x17F25DC", Offset = "0x17F25DC", VA = "0x17F25DC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x17F26DC", Offset = "0x17F26DC", VA = "0x17F26DC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x17F2764", Offset = "0x17F2764", VA = "0x17F2764")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x17F2800", Offset = "0x17F2800", VA = "0x17F2800")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x17F28A4", Offset = "0x17F28A4", VA = "0x17F28A4")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x17F2894", Offset = "0x17F2894", VA = "0x17F2894")]
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

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x15128E4", Offset = "0x15128E4", VA = "0x15128E4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x151297C", Offset = "0x151297C", VA = "0x151297C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AC5C", Offset = "0x82AC5C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AC5C", Offset = "0x82AC5C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1D602DC", Offset = "0x1D602DC", VA = "0x1D602DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x836F2C", Offset = "0x836F2C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1D60324", Offset = "0x1D60324", VA = "0x1D60324")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x836F64", Offset = "0x836F64")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1D6036C", Offset = "0x1D6036C", VA = "0x1D6036C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x836F9C", Offset = "0x836F9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1D603B4", Offset = "0x1D603B4", VA = "0x1D603B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x836FD4", Offset = "0x836FD4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1D603FC", Offset = "0x1D603FC", VA = "0x1D603FC")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1D60498", Offset = "0x1D60498", VA = "0x1D60498")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1D604B8", Offset = "0x1D604B8", VA = "0x1D604B8")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1D604E8", Offset = "0x1D604E8", VA = "0x1D604E8")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1D60518", Offset = "0x1D60518", VA = "0x1D60518")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1D60560", Offset = "0x1D60560", VA = "0x1D60560")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1D605B0", Offset = "0x1D605B0", VA = "0x1D605B0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1D605D4", Offset = "0x1D605D4", VA = "0x1D605D4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1D605F4", Offset = "0x1D605F4", VA = "0x1D605F4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1D6061C", Offset = "0x1D6061C", VA = "0x1D6061C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1D60644", Offset = "0x1D60644", VA = "0x1D60644")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1D6066C", Offset = "0x1D6066C", VA = "0x1D6066C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1D6041C", Offset = "0x1D6041C", VA = "0x1D6041C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1D60694", Offset = "0x1D60694", VA = "0x1D60694")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1D606A0", Offset = "0x1D606A0", VA = "0x1D606A0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1D606AC", Offset = "0x1D606AC", VA = "0x1D606AC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1D609D0", Offset = "0x1D609D0", VA = "0x1D609D0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1D60A90", Offset = "0x1D60A90", VA = "0x1D60A90", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1D60E7C", Offset = "0x1D60E7C", VA = "0x1D60E7C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1D61008", Offset = "0x1D61008", VA = "0x1D61008")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1D6103C", Offset = "0x1D6103C", VA = "0x1D6103C")]
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
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x1D6084C", Offset = "0x1D6084C", VA = "0x1D6084C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1D61334", Offset = "0x1D61334", VA = "0x1D61334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1D60D58", Offset = "0x1D60D58", VA = "0x1D60D58")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1D61160", Offset = "0x1D61160", VA = "0x1D61160")]
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
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x121589C", Offset = "0x121589C", VA = "0x121589C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000171")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1215908", Offset = "0x1215908", VA = "0x1215908")]
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

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1215910", Offset = "0x1215910", VA = "0x1215910", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x12159D0", Offset = "0x12159D0", VA = "0x12159D0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x12159D8", Offset = "0x12159D8", VA = "0x12159D8")]
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
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1215B14", Offset = "0x1215B14", VA = "0x1215B14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1215A0C", Offset = "0x1215A0C", VA = "0x1215A0C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1215B50", Offset = "0x1215B50", VA = "0x1215B50")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1215B58", Offset = "0x1215B58", VA = "0x1215B58")]
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

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1215B8C", Offset = "0x1215B8C", VA = "0x1215B8C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1215C0C", Offset = "0x1215C0C", VA = "0x1215C0C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1215C14", Offset = "0x1215C14", VA = "0x1215C14")]
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
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1215D50", Offset = "0x1215D50", VA = "0x1215D50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1215C48", Offset = "0x1215C48", VA = "0x1215C48", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1215D8C", Offset = "0x1215D8C", VA = "0x1215D8C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1215D94", Offset = "0x1215D94", VA = "0x1215D94")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C4B0", Offset = "0x82C4B0")]
		public float positionWeight;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C4C8", Offset = "0x82C4C8")]
		public float rotationWeight;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1215DC8", Offset = "0x1215DC8", VA = "0x1215DC8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1215E34", Offset = "0x1215E34", VA = "0x1215E34")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1215EB4", Offset = "0x1215EB4", VA = "0x1215EB4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1215F00", Offset = "0x1215F00", VA = "0x1215F00")]
		public void Update()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x12161B0", Offset = "0x12161B0", VA = "0x12161B0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C4E0", Offset = "0x82C4E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C4E0", Offset = "0x82C4E0")]
		public float weight;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C534", Offset = "0x82C534")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C534", Offset = "0x82C534")]
		public float rotationWeight;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C588", Offset = "0x82C588")]
		public DOF rotationDOF;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C5C0", Offset = "0x82C5C0")]
		public bool fixBone1Twist;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C5F8", Offset = "0x82C5F8")]
		public Transform bone1;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C630", Offset = "0x82C630")]
		public Transform bone2;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C668", Offset = "0x82C668")]
		public Transform bone3;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C6A0", Offset = "0x82C6A0")]
		public Transform tip;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C6D8", Offset = "0x82C6D8")]
		public Transform target;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C710", Offset = "0x82C710")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C710", Offset = "0x82C710")]
		private bool <initiated>k__BackingField;

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
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1E18348", Offset = "0x1E18348", VA = "0x1E18348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83700C", Offset = "0x83700C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1E18350", Offset = "0x1E18350", VA = "0x1E18350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83701C", Offset = "0x83701C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1E1835C", Offset = "0x1E1835C", VA = "0x1E1835C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1E1837C", Offset = "0x1E1837C", VA = "0x1E1837C")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1E1839C", Offset = "0x1E1839C", VA = "0x1E1839C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1E183BC", Offset = "0x1E183BC", VA = "0x1E183BC")]
			set
			{
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1E183DC", Offset = "0x1E183DC", VA = "0x1E183DC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1E184F0", Offset = "0x1E184F0", VA = "0x1E184F0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1E18A80", Offset = "0x1E18A80", VA = "0x1E18A80")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1E18B58", Offset = "0x1E18B58", VA = "0x1E18B58")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1E18C1C", Offset = "0x1E18C1C", VA = "0x1E18C1C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1E190A4", Offset = "0x1E190A4", VA = "0x1E190A4")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C74C", Offset = "0x82C74C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C74C", Offset = "0x82C74C")]
		public float weight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C7A0", Offset = "0x82C7A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C7A0", Offset = "0x82C7A0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000021")]
		public bool initiated
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1E190B4", Offset = "0x1E190B4", VA = "0x1E190B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83702C", Offset = "0x83702C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1E190BC", Offset = "0x1E190BC", VA = "0x1E190BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83703C", Offset = "0x83703C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1E190C8", Offset = "0x1E190C8", VA = "0x1E190C8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1E19150", Offset = "0x1E19150", VA = "0x1E19150")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83704C", Offset = "0x83704C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1E194DC", Offset = "0x1E194DC", VA = "0x1E194DC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1E196A0", Offset = "0x1E196A0", VA = "0x1E196A0")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1E193D8", Offset = "0x1E193D8", VA = "0x1E193D8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1E1982C", Offset = "0x1E1982C", VA = "0x1E1982C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1E198EC", Offset = "0x1E198EC", VA = "0x1E198EC")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1E19964", Offset = "0x1E19964", VA = "0x1E19964")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1E199D8", Offset = "0x1E199D8", VA = "0x1E199D8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1E19A40", Offset = "0x1E19A40", VA = "0x1E19A40", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1E19A44", Offset = "0x1E19A44", VA = "0x1E19A44", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1E19A58", Offset = "0x1E19A58", VA = "0x1E19A58")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C7DC", Offset = "0x82C7DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82C7DC", Offset = "0x82C7DC")]
		public float weight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C830", Offset = "0x82C830")]
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

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C868", Offset = "0x82C868")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82C868", Offset = "0x82C868")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1E1AF14", Offset = "0x1E1AF14", VA = "0x1E1AF14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837084", Offset = "0x837084")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1E1AF1C", Offset = "0x1E1AF1C", VA = "0x1E1AF1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837094", Offset = "0x837094")]
			protected set
			{
			}
		}

		[Token(Token = "0x60001A0")]
		public abstract void ResetPosition();

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1E1AF28", Offset = "0x1E1AF28", VA = "0x1E1AF28")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1E1B0D4", Offset = "0x1E1B0D4", VA = "0x1E1B0D4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1E1AFD4", Offset = "0x1E1AFD4", VA = "0x1E1AFD4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1E1B108", Offset = "0x1E1B108", VA = "0x1E1B108")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A7")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001A8")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1E1B244", Offset = "0x1E1B244", VA = "0x1E1B244")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82ACBC", Offset = "0x82ACBC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82ACBC", Offset = "0x82ACBC")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C8A4", Offset = "0x82C8A4")]
		public BipedIK ik;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C8DC", Offset = "0x82C8DC")]
		public float spineBend;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C914", Offset = "0x82C914")]
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

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1E1B2BC", Offset = "0x1E1B2BC", VA = "0x1E1B2BC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8370A4", Offset = "0x8370A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1E1B304", Offset = "0x1E1B304", VA = "0x1E1B304", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8370DC", Offset = "0x8370DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1E1B34C", Offset = "0x1E1B34C", VA = "0x1E1B34C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1E1B38C", Offset = "0x1E1B38C", VA = "0x1E1B38C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1E1B438", Offset = "0x1E1B438", VA = "0x1E1B438")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1E1B498", Offset = "0x1E1B498", VA = "0x1E1B498")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1E1B7B8", Offset = "0x1E1B7B8", VA = "0x1E1B7B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1E1B80C", Offset = "0x1E1B80C", VA = "0x1E1B80C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1E1BC28", Offset = "0x1E1BC28", VA = "0x1E1BC28")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1E1BCFC", Offset = "0x1E1BCFC", VA = "0x1E1BCFC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1E1BE5C", Offset = "0x1E1BE5C", VA = "0x1E1BE5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1E1C020", Offset = "0x1E1C020", VA = "0x1E1C020")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AD1C", Offset = "0x82AD1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AD1C", Offset = "0x82AD1C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000043")]
		public class SpineEffector
		{
			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C9F4", Offset = "0x82C9F4")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CA2C", Offset = "0x82CA2C")]
			public float horizontalWeight;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CA64", Offset = "0x82CA64")]
			public float verticalWeight;

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x151786C", Offset = "0x151786C", VA = "0x151786C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x151787C", Offset = "0x151787C", VA = "0x151787C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C94C", Offset = "0x82C94C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C984", Offset = "0x82C984")]
		public float spineBend;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82C9BC", Offset = "0x82C9BC")]
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

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1E1C470", Offset = "0x1E1C470", VA = "0x1E1C470")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837114", Offset = "0x837114")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1E1C4B8", Offset = "0x1E1C4B8", VA = "0x1E1C4B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83714C", Offset = "0x83714C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1E1C500", Offset = "0x1E1C500", VA = "0x1E1C500", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837184", Offset = "0x837184")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1E1C548", Offset = "0x1E1C548", VA = "0x1E1C548", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1E1C588", Offset = "0x1E1C588", VA = "0x1E1C588")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1E1C61C", Offset = "0x1E1C61C", VA = "0x1E1C61C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1E1C954", Offset = "0x1E1C954", VA = "0x1E1C954")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1E1C960", Offset = "0x1E1C960", VA = "0x1E1C960")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1E1C684", Offset = "0x1E1C684", VA = "0x1E1C684")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1E1C96C", Offset = "0x1E1C96C", VA = "0x1E1C96C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1E1CC8C", Offset = "0x1E1CC8C", VA = "0x1E1CC8C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1E1CD9C", Offset = "0x1E1CD9C", VA = "0x1E1CD9C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1E1CF18", Offset = "0x1E1CF18", VA = "0x1E1CF18")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1E1CF2C", Offset = "0x1E1CF2C", VA = "0x1E1CF2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1E1D0E0", Offset = "0x1E1D0E0", VA = "0x1E1D0E0")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AD7C", Offset = "0x82AD7C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AD7C", Offset = "0x82AD7C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IK[] legs;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CA9C", Offset = "0x82CA9C")]
		public Transform pelvis;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CAD4", Offset = "0x82CAD4")]
		public Transform characterRoot;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CB0C", Offset = "0x82CB0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82CB0C", Offset = "0x82CB0C")]
		public float rootRotationWeight;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CB60", Offset = "0x82CB60")]
		public float rootRotationSpeed;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CB98", Offset = "0x82CB98")]
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

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1E1D180", Offset = "0x1E1D180", VA = "0x1E1D180", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8371BC", Offset = "0x8371BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1E1D1C8", Offset = "0x1E1D1C8", VA = "0x1E1D1C8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8371F4", Offset = "0x8371F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1E1D210", Offset = "0x1E1D210", VA = "0x1E1D210", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1E1D410", Offset = "0x1E1D410", VA = "0x1E1D410")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1E1D648", Offset = "0x1E1D648", VA = "0x1E1D648")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1E1D744", Offset = "0x1E1D744", VA = "0x1E1D744")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1E1DB98", Offset = "0x1E1DB98", VA = "0x1E1DB98")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1E1E000", Offset = "0x1E1E000", VA = "0x1E1E000")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1E1E190", Offset = "0x1E1E190", VA = "0x1E1E190")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1E1E494", Offset = "0x1E1E494", VA = "0x1E1E494")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1E1E600", Offset = "0x1E1E600", VA = "0x1E1E600")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1E1E80C", Offset = "0x1E1E80C", VA = "0x1E1E80C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82ADDC", Offset = "0x82ADDC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82ADDC", Offset = "0x82ADDC")]
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

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x15178C4", Offset = "0x15178C4", VA = "0x15178C4")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CBD0", Offset = "0x82CBD0")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82CC08", Offset = "0x82CC08")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CC08", Offset = "0x82CC08")]
		public float rootRotationWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CC5C", Offset = "0x82CC5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82CC5C", Offset = "0x82CC5C")]
		public float minRootRotation;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CCB4", Offset = "0x82CCB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82CCB4", Offset = "0x82CCB4")]
		public float maxRootRotation;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CD0C", Offset = "0x82CD0C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CD44", Offset = "0x82CD44")]
		public float maxLegOffset;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CD7C", Offset = "0x82CD7C")]
		public float maxForeLegOffset;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CDB4", Offset = "0x82CDB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82CDB4", Offset = "0x82CDB4")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CE08", Offset = "0x82CE08")]
		public Transform characterRoot;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CE40", Offset = "0x82CE40")]
		public Transform pelvis;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CE78", Offset = "0x82CE78")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CEB0", Offset = "0x82CEB0")]
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

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1E1E8AC", Offset = "0x1E1E8AC", VA = "0x1E1E8AC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83722C", Offset = "0x83722C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1E1E8F4", Offset = "0x1E1E8F4", VA = "0x1E1E8F4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837264", Offset = "0x837264")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1E1E93C", Offset = "0x1E1E93C", VA = "0x1E1E93C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1E1EACC", Offset = "0x1E1EACC", VA = "0x1E1EACC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1E1EBF8", Offset = "0x1E1EBF8", VA = "0x1E1EBF8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1E1EDFC", Offset = "0x1E1EDFC", VA = "0x1E1EDFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1E1EE64", Offset = "0x1E1EE64", VA = "0x1E1EE64")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1E1EEC8", Offset = "0x1E1EEC8", VA = "0x1E1EEC8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1E1F230", Offset = "0x1E1F230", VA = "0x1E1F230")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1E1F5C8", Offset = "0x1E1F5C8", VA = "0x1E1F5C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1E1F6C0", Offset = "0x1E1F6C0", VA = "0x1E1F6C0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1E1FA8C", Offset = "0x1E1FA8C", VA = "0x1E1FA8C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1E200B4", Offset = "0x1E200B4", VA = "0x1E200B4")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1E20284", Offset = "0x1E20284", VA = "0x1E20284")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1E20360", Offset = "0x1E20360", VA = "0x1E20360")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1E205CC", Offset = "0x1E205CC", VA = "0x1E205CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1E20604", Offset = "0x1E20604", VA = "0x1E20604")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1E20808", Offset = "0x1E20808", VA = "0x1E20808")]
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
			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D480", Offset = "0x82D480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D480", Offset = "0x82D480")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D4BC", Offset = "0x82D4BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D4BC", Offset = "0x82D4BC")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D4F8", Offset = "0x82D4F8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D4F8", Offset = "0x82D4F8")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D534", Offset = "0x82D534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D534", Offset = "0x82D534")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D570", Offset = "0x82D570")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D570", Offset = "0x82D570")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D5AC", Offset = "0x82D5AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D5AC", Offset = "0x82D5AC")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D5E8", Offset = "0x82D5E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D5E8", Offset = "0x82D5E8")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D624", Offset = "0x82D624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D624", Offset = "0x82D624")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D660", Offset = "0x82D660")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D660", Offset = "0x82D660")]
			private RaycastHit <capsuleHit>k__BackingField;

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
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x1517928", Offset = "0x1517928", VA = "0x1517928")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83733C", Offset = "0x83733C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600020F")]
				[Address(RVA = "0x1517930", Offset = "0x1517930", VA = "0x1517930")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83734C", Offset = "0x83734C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0x151793C", Offset = "0x151793C", VA = "0x151793C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83735C", Offset = "0x83735C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000211")]
				[Address(RVA = "0x1517948", Offset = "0x1517948", VA = "0x1517948")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83736C", Offset = "0x83736C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public bool initiated
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0x1517954", Offset = "0x1517954", VA = "0x1517954")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83737C", Offset = "0x83737C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000213")]
				[Address(RVA = "0x151795C", Offset = "0x151795C", VA = "0x151795C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83738C", Offset = "0x83738C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public float heightFromGround
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0x1517968", Offset = "0x1517968", VA = "0x1517968")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83739C", Offset = "0x83739C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000215")]
				[Address(RVA = "0x1517970", Offset = "0x1517970", VA = "0x1517970")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8373AC", Offset = "0x8373AC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000216")]
				[Address(RVA = "0x1517978", Offset = "0x1517978", VA = "0x1517978")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8373BC", Offset = "0x8373BC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000217")]
				[Address(RVA = "0x1517984", Offset = "0x1517984", VA = "0x1517984")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8373CC", Offset = "0x8373CC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public Transform transform
			{
				[Token(Token = "0x6000218")]
				[Address(RVA = "0x1517990", Offset = "0x1517990", VA = "0x1517990")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8373DC", Offset = "0x8373DC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000219")]
				[Address(RVA = "0x1517998", Offset = "0x1517998", VA = "0x1517998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8373EC", Offset = "0x8373EC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000031")]
			public float IKOffset
			{
				[Token(Token = "0x600021A")]
				[Address(RVA = "0x15179A0", Offset = "0x15179A0", VA = "0x15179A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8373FC", Offset = "0x8373FC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600021B")]
				[Address(RVA = "0x15179A8", Offset = "0x15179A8", VA = "0x15179A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83740C", Offset = "0x83740C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0x15179B0", Offset = "0x15179B0", VA = "0x15179B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83741C", Offset = "0x83741C")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600021D")]
				[Address(RVA = "0x15179C8", Offset = "0x15179C8", VA = "0x15179C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83742C", Offset = "0x83742C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000033")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x15179E8", Offset = "0x15179E8", VA = "0x15179E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83743C", Offset = "0x83743C")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x1517A00", Offset = "0x1517A00", VA = "0x1517A00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83744C", Offset = "0x83744C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000220")]
				[Address(RVA = "0x1517A20", Offset = "0x1517A20", VA = "0x1517A20")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000035")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000226")]
				[Address(RVA = "0x1518C20", Offset = "0x1518C20", VA = "0x1518C20")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000036")]
			private float rootYOffset
			{
				[Token(Token = "0x600022F")]
				[Address(RVA = "0x1519498", Offset = "0x1519498", VA = "0x1519498")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1517A94", Offset = "0x1517A94", VA = "0x1517A94")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1517AA8", Offset = "0x1517AA8", VA = "0x1517AA8")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1517B38", Offset = "0x1517B38", VA = "0x1517B38")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1517B84", Offset = "0x1517B84", VA = "0x1517B84")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1517BF4", Offset = "0x1517BF4", VA = "0x1517BF4")]
			public void Process()
			{
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x15188AC", Offset = "0x15188AC", VA = "0x15188AC")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x1518440", Offset = "0x1518440", VA = "0x1518440")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x15193C8", Offset = "0x15193C8", VA = "0x15193C8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x15186E8", Offset = "0x15186E8", VA = "0x15186E8")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x1518774", Offset = "0x1518774", VA = "0x1518774")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1519438", Offset = "0x1519438", VA = "0x1519438")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x1518C48", Offset = "0x1518C48", VA = "0x1518C48")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x151952C", Offset = "0x151952C", VA = "0x151952C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x15195B8", Offset = "0x15195B8", VA = "0x15195B8")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200004D")]
		public class Pelvis
		{
			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D69C", Offset = "0x82D69C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D69C", Offset = "0x82D69C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D6D8", Offset = "0x82D6D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D6D8", Offset = "0x82D6D8")]
			private float <heightOffset>k__BackingField;

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
				[Token(Token = "0x6000231")]
				[Address(RVA = "0x1519FB4", Offset = "0x1519FB4", VA = "0x1519FB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83745C", Offset = "0x83745C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000232")]
				[Address(RVA = "0x1519FC0", Offset = "0x1519FC0", VA = "0x1519FC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83746C", Offset = "0x83746C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000038")]
			public float heightOffset
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x1519FCC", Offset = "0x1519FCC", VA = "0x1519FCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83747C", Offset = "0x83747C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000234")]
				[Address(RVA = "0x1519FD4", Offset = "0x1519FD4", VA = "0x1519FD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83748C", Offset = "0x83748C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x1519FDC", Offset = "0x1519FDC", VA = "0x1519FDC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x151A06C", Offset = "0x151A06C", VA = "0x151A06C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x151A00C", Offset = "0x151A00C", VA = "0x151A00C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x151A0D8", Offset = "0x151A0D8", VA = "0x151A0D8")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x151A278", Offset = "0x151A278", VA = "0x151A278")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CEF8", Offset = "0x82CEF8")]
		public LayerMask layers;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CF30", Offset = "0x82CF30")]
		public float maxStep;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CF68", Offset = "0x82CF68")]
		public float heightOffset;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CFA0", Offset = "0x82CFA0")]
		public float footSpeed;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82CFD8", Offset = "0x82CFD8")]
		public float footRadius;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D010", Offset = "0x82D010")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D05C", Offset = "0x82D05C")]
		public float prediction;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82D094", Offset = "0x82D094")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D094", Offset = "0x82D094")]
		public float footRotationWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D0E8", Offset = "0x82D0E8")]
		public float footRotationSpeed;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82D120", Offset = "0x82D120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D120", Offset = "0x82D120")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D178", Offset = "0x82D178")]
		public bool rotateSolver;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D1B0", Offset = "0x82D1B0")]
		public float pelvisSpeed;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D1E8", Offset = "0x82D1E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82D1E8", Offset = "0x82D1E8")]
		public float pelvisDamper;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D23C", Offset = "0x82D23C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D274", Offset = "0x82D274")]
		public float liftPelvisWeight;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D2AC", Offset = "0x82D2AC")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D2E4", Offset = "0x82D2E4")]
		public bool overstepFallsDown;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D31C", Offset = "0x82D31C")]
		public Quality quality;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D354", Offset = "0x82D354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D354", Offset = "0x82D354")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D390", Offset = "0x82D390")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D390", Offset = "0x82D390")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D3CC", Offset = "0x82D3CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D3CC", Offset = "0x82D3CC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D408", Offset = "0x82D408")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D408", Offset = "0x82D408")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D444", Offset = "0x82D444")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82D444", Offset = "0x82D444")]
		private RaycastHit <rootHit>k__BackingField;

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
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x1E208D0", Offset = "0x1E208D0", VA = "0x1E208D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83729C", Offset = "0x83729C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x1E208D8", Offset = "0x1E208D8", VA = "0x1E208D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8372AC", Offset = "0x8372AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x1E208E0", Offset = "0x1E208E0", VA = "0x1E208E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8372BC", Offset = "0x8372BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x1E208E8", Offset = "0x1E208E8", VA = "0x1E208E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8372CC", Offset = "0x8372CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool isGrounded
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x1E208F0", Offset = "0x1E208F0", VA = "0x1E208F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8372DC", Offset = "0x8372DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x1E208F8", Offset = "0x1E208F8", VA = "0x1E208F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8372EC", Offset = "0x8372EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform root
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x1E20904", Offset = "0x1E20904", VA = "0x1E20904")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8372FC", Offset = "0x8372FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x1E2090C", Offset = "0x1E2090C", VA = "0x1E2090C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83730C", Offset = "0x83730C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1E20914", Offset = "0x1E20914", VA = "0x1E20914")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83731C", Offset = "0x83731C")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1E2092C", Offset = "0x1E2092C", VA = "0x1E2092C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83732C", Offset = "0x83732C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x1E2094C", Offset = "0x1E2094C", VA = "0x1E2094C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public Vector3 up
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x1E20C24", Offset = "0x1E20C24", VA = "0x1E20C24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002A")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x1E214C0", Offset = "0x1E214C0", VA = "0x1E214C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1E209A0", Offset = "0x1E209A0", VA = "0x1E209A0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1E20C68", Offset = "0x1E20C68", VA = "0x1E20C68")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1E20D7C", Offset = "0x1E20D7C", VA = "0x1E20D7C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1E2104C", Offset = "0x1E2104C", VA = "0x1E2104C")]
		public void Update()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1E212D4", Offset = "0x1E212D4", VA = "0x1E212D4")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1E21434", Offset = "0x1E21434", VA = "0x1E21434")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1E212BC", Offset = "0x1E212BC", VA = "0x1E212BC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1E21540", Offset = "0x1E21540", VA = "0x1E21540")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1E215D0", Offset = "0x1E215D0", VA = "0x1E215D0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1E2168C", Offset = "0x1E2168C", VA = "0x1E2168C")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1E21708", Offset = "0x1E21708", VA = "0x1E21708")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AE3C", Offset = "0x82AE3C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AE3C", Offset = "0x82AE3C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1D59A10", Offset = "0x1D59A10", VA = "0x1D59A10", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83749C", Offset = "0x83749C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1D59A58", Offset = "0x1D59A58", VA = "0x1D59A58", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8374D4", Offset = "0x8374D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1D59AA0", Offset = "0x1D59AA0", VA = "0x1D59AA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83750C", Offset = "0x83750C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1D59AE8", Offset = "0x1D59AE8", VA = "0x1D59AE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837544", Offset = "0x837544")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1D59B30", Offset = "0x1D59B30", VA = "0x1D59B30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83757C", Offset = "0x83757C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1D59B78", Offset = "0x1D59B78", VA = "0x1D59B78", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1D59B80", Offset = "0x1D59B80", VA = "0x1D59B80")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AE9C", Offset = "0x82AE9C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AE9C", Offset = "0x82AE9C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1D5BA80", Offset = "0x1D5BA80", VA = "0x1D5BA80", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8375B4", Offset = "0x8375B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1D5BAC8", Offset = "0x1D5BAC8", VA = "0x1D5BAC8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8375EC", Offset = "0x8375EC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1D5BB10", Offset = "0x1D5BB10", VA = "0x1D5BB10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837624", Offset = "0x837624")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1D5BB58", Offset = "0x1D5BB58", VA = "0x1D5BB58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83765C", Offset = "0x83765C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1D5BBA0", Offset = "0x1D5BBA0", VA = "0x1D5BBA0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1D5BBA8", Offset = "0x1D5BBA8", VA = "0x1D5BBA8")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AEFC", Offset = "0x82AEFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AEFC", Offset = "0x82AEFC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1D69530", Offset = "0x1D69530", VA = "0x1D69530", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837694", Offset = "0x837694")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1D69578", Offset = "0x1D69578", VA = "0x1D69578", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8376CC", Offset = "0x8376CC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1D695C0", Offset = "0x1D695C0", VA = "0x1D695C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837704", Offset = "0x837704")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1D69608", Offset = "0x1D69608", VA = "0x1D69608")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83773C", Offset = "0x83773C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1D69650", Offset = "0x1D69650", VA = "0x1D69650", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1D69658", Offset = "0x1D69658", VA = "0x1D69658")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AF5C", Offset = "0x82AF5C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AF5C", Offset = "0x82AF5C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1225974", Offset = "0x1225974", VA = "0x1225974", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837774", Offset = "0x837774")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x12259BC", Offset = "0x12259BC", VA = "0x12259BC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8377AC", Offset = "0x8377AC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1225A04", Offset = "0x1225A04", VA = "0x1225A04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8377E4", Offset = "0x8377E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1225A4C", Offset = "0x1225A4C", VA = "0x1225A4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83781C", Offset = "0x83781C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1225A94", Offset = "0x1225A94", VA = "0x1225A94", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1225A9C", Offset = "0x1225A9C", VA = "0x1225A9C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82AFBC", Offset = "0x82AFBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82AFBC", Offset = "0x82AFBC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1226324", Offset = "0x1226324", VA = "0x1226324", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837854", Offset = "0x837854")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x122636C", Offset = "0x122636C", VA = "0x122636C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83788C", Offset = "0x83788C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x12263B4", Offset = "0x12263B4", VA = "0x12263B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8378C4", Offset = "0x8378C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x12263FC", Offset = "0x12263FC", VA = "0x12263FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8378FC", Offset = "0x8378FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1226444", Offset = "0x1226444", VA = "0x1226444", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x122644C", Offset = "0x122644C", VA = "0x122644C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B01C", Offset = "0x82B01C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B01C", Offset = "0x82B01C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1E19AC8", Offset = "0x1E19AC8", VA = "0x1E19AC8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837934", Offset = "0x837934")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1E19B10", Offset = "0x1E19B10", VA = "0x1E19B10", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83796C", Offset = "0x83796C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1E19B58", Offset = "0x1E19B58", VA = "0x1E19B58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8379A4", Offset = "0x8379A4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1E19BA0", Offset = "0x1E19BA0", VA = "0x1E19BA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8379DC", Offset = "0x8379DC")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1E19BE8", Offset = "0x1E19BE8", VA = "0x1E19BE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837A14", Offset = "0x837A14")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1E19C30", Offset = "0x1E19C30", VA = "0x1E19C30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837A4C", Offset = "0x837A4C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1E19C78", Offset = "0x1E19C78", VA = "0x1E19C78")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1E19CBC", Offset = "0x1E19CBC", VA = "0x1E19CBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1E19CC4", Offset = "0x1E19CC4", VA = "0x1E19CC4")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1E19EAC", Offset = "0x1E19EAC", VA = "0x1E19EAC")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1E1A14C", Offset = "0x1E1A14C", VA = "0x1E1A14C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837A84", Offset = "0x837A84")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1E1A16C", Offset = "0x1E1A16C", VA = "0x1E1A16C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837ABC", Offset = "0x837ABC")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1E1A25C", Offset = "0x1E1A25C", VA = "0x1E1A25C")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000266")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1E24F20", Offset = "0x1E24F20", VA = "0x1E24F20", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1E25014", Offset = "0x1E25014", VA = "0x1E25014", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1E2520C", Offset = "0x1E2520C", VA = "0x1E2520C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600026A")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600026B")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1E2526C", Offset = "0x1E2526C", VA = "0x1E2526C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D714", Offset = "0x82D714")]
		public IK[] IKComponents;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D74C", Offset = "0x82D74C")]
		public Animator animator;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000039")]
		private bool animatePhysics
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x1E278AC", Offset = "0x1E278AC", VA = "0x1E278AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1E27944", Offset = "0x1E27944", VA = "0x1E27944")]
		private void Start()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1E279B4", Offset = "0x1E279B4", VA = "0x1E279B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1E27A70", Offset = "0x1E27A70", VA = "0x1E27A70")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1E27AAC", Offset = "0x1E27AAC", VA = "0x1E27AAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1E279E8", Offset = "0x1E279E8", VA = "0x1E279E8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1E27B38", Offset = "0x1E27B38", VA = "0x1E27B38")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B07C", Offset = "0x82B07C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B07C", Offset = "0x82B07C")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1DF1560", Offset = "0x1DF1560", VA = "0x1DF1560", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837AF4", Offset = "0x837AF4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1DF15A8", Offset = "0x1DF15A8", VA = "0x1DF15A8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837B2C", Offset = "0x837B2C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1DF15F0", Offset = "0x1DF15F0", VA = "0x1DF15F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837B64", Offset = "0x837B64")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1DF1638", Offset = "0x1DF1638", VA = "0x1DF1638")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837B9C", Offset = "0x837B9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1DF1680", Offset = "0x1DF1680", VA = "0x1DF1680", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1DF1688", Offset = "0x1DF1688", VA = "0x1DF1688")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B0DC", Offset = "0x82B0DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B0DC", Offset = "0x82B0DC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1DF16F8", Offset = "0x1DF16F8", VA = "0x1DF16F8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837BD4", Offset = "0x837BD4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1DF1740", Offset = "0x1DF1740", VA = "0x1DF1740", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837C0C", Offset = "0x837C0C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1DF1788", Offset = "0x1DF1788", VA = "0x1DF1788")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837C44", Offset = "0x837C44")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1DF17D0", Offset = "0x1DF17D0", VA = "0x1DF17D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837C7C", Offset = "0x837C7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1DF1818", Offset = "0x1DF1818", VA = "0x1DF1818", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1DF1820", Offset = "0x1DF1820", VA = "0x1DF1820")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B13C", Offset = "0x82B13C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B13C", Offset = "0x82B13C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1DF222C", Offset = "0x1DF222C", VA = "0x1DF222C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837CB4", Offset = "0x837CB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1DF2274", Offset = "0x1DF2274", VA = "0x1DF2274", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837CEC", Offset = "0x837CEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1DF22BC", Offset = "0x1DF22BC", VA = "0x1DF22BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837D24", Offset = "0x837D24")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1DF2304", Offset = "0x1DF2304", VA = "0x1DF2304")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837D5C", Offset = "0x837D5C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1DF234C", Offset = "0x1DF234C", VA = "0x1DF234C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1DF2354", Offset = "0x1DF2354", VA = "0x1DF2354")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B19C", Offset = "0x82B19C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B19C", Offset = "0x82B19C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x17EF3EC", Offset = "0x17EF3EC", VA = "0x17EF3EC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837D94", Offset = "0x837D94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x17EF434", Offset = "0x17EF434", VA = "0x17EF434", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837DCC", Offset = "0x837DCC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x17EF47C", Offset = "0x17EF47C", VA = "0x17EF47C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837E04", Offset = "0x837E04")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x17EF4C4", Offset = "0x17EF4C4", VA = "0x17EF4C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837E3C", Offset = "0x837E3C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x17EF50C", Offset = "0x17EF50C", VA = "0x17EF50C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x17EF514", Offset = "0x17EF514", VA = "0x17EF514")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B1FC", Offset = "0x82B1FC")]
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
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82D830", Offset = "0x82D830")]
			public Transform pelvis;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D868", Offset = "0x82D868")]
			public Transform chest;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D8A0", Offset = "0x82D8A0")]
			public Transform neck;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D8D8", Offset = "0x82D8D8")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82D8D8", Offset = "0x82D8D8")]
			public Transform leftShoulder;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D938", Offset = "0x82D938")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D970", Offset = "0x82D970")]
			public Transform leftForearm;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D9A8", Offset = "0x82D9A8")]
			public Transform leftHand;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D9E0", Offset = "0x82D9E0")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82D9E0", Offset = "0x82D9E0")]
			public Transform rightShoulder;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DA40", Offset = "0x82DA40")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DA78", Offset = "0x82DA78")]
			public Transform rightForearm;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DAB0", Offset = "0x82DAB0")]
			public Transform rightHand;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DAE8", Offset = "0x82DAE8")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82DAE8", Offset = "0x82DAE8")]
			public Transform leftThigh;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DB48", Offset = "0x82DB48")]
			public Transform leftCalf;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DB80", Offset = "0x82DB80")]
			public Transform leftFoot;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DBB8", Offset = "0x82DBB8")]
			public Transform leftToes;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82DBF0", Offset = "0x82DBF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DBF0", Offset = "0x82DBF0")]
			public Transform rightThigh;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DC50", Offset = "0x82DC50")]
			public Transform rightCalf;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DC88", Offset = "0x82DC88")]
			public Transform rightFoot;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DCC0", Offset = "0x82DCC0")]
			public Transform rightToes;

			[Token(Token = "0x1700003A")]
			public bool isFilled
			{
				[Token(Token = "0x6000298")]
				[Address(RVA = "0x1DAA668", Offset = "0x1DAA668", VA = "0x1DAA668")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700003B")]
			public bool isEmpty
			{
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x1DAAC38", Offset = "0x1DAAC38", VA = "0x1DAAC38")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1DA9EF8", Offset = "0x1DA9EF8", VA = "0x1DA9EF8")]
			public References()
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x1DA9F00", Offset = "0x1DA9F00", VA = "0x1DA9F00")]
			public References(BipedReferences b)
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1DAA118", Offset = "0x1DAA118", VA = "0x1DAA118")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1DAB0B0", Offset = "0x1DAB0B0", VA = "0x1DAB0B0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D784", Offset = "0x82D784")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x82D784", Offset = "0x82D784")]
		public References references;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82D7F8", Offset = "0x82D7F8")]
		public IKSolverVR solver;

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x17F2C88", Offset = "0x17F2C88", VA = "0x17F2C88", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837E74", Offset = "0x837E74")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x17F2CD0", Offset = "0x17F2CD0", VA = "0x17F2CD0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837EAC", Offset = "0x837EAC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x17F2D18", Offset = "0x17F2D18", VA = "0x17F2D18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837EE4", Offset = "0x837EE4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x17F2D60", Offset = "0x17F2D60", VA = "0x17F2D60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837F1C", Offset = "0x837F1C")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x17F2D8C", Offset = "0x17F2D8C", VA = "0x17F2D8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x837F54", Offset = "0x837F54")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x17F2DB4", Offset = "0x17F2DB4", VA = "0x17F2DB4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x17F2DBC", Offset = "0x17F2DBC", VA = "0x17F2DBC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x17F2E3C", Offset = "0x17F2E3C", VA = "0x17F2E3C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x17F2FA8", Offset = "0x17F2FA8", VA = "0x17F2FA8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DCF8", Offset = "0x82DCF8")]
		public float pull;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DD10", Offset = "0x82DD10")]
		public float pin;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1225E4C", Offset = "0x1225E4C", VA = "0x1225E4C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1225F28", Offset = "0x1225F28", VA = "0x1225F28")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1225F48", Offset = "0x1225F48", VA = "0x1225F48")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x12261BC", Offset = "0x12261BC", VA = "0x12261BC")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x122601C", Offset = "0x122601C", VA = "0x122601C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x12262B4", Offset = "0x12262B4", VA = "0x12262B4")]
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

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x12264BC", Offset = "0x12264BC", VA = "0x12264BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1226934", Offset = "0x1226934", VA = "0x1226934")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1226AF0", Offset = "0x1226AF0", VA = "0x1226AF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1226C20", Offset = "0x1226C20", VA = "0x1226C20")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E368", Offset = "0x82E368")]
			public Transform transform;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E3A0", Offset = "0x82E3A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E3A0", Offset = "0x82E3A0")]
			public float weight;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x1516BE4", Offset = "0x1516BE4", VA = "0x1516BE4")]
			public BendBone()
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1516C20", Offset = "0x1516C20", VA = "0x1516C20")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1516C84", Offset = "0x1516C84", VA = "0x1516C84")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x1516CBC", Offset = "0x1516CBC", VA = "0x1516CBC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DD28", Offset = "0x82DD28")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x82DD60", Offset = "0x82DD60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DD60", Offset = "0x82DD60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DD60", Offset = "0x82DD60")]
		public float positionWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DDD8", Offset = "0x82DDD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DDD8", Offset = "0x82DDD8")]
		public float bodyWeight;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DE2C", Offset = "0x82DE2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DE2C", Offset = "0x82DE2C")]
		public float thighWeight;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DE80", Offset = "0x82DE80")]
		public bool handsPullBody;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DEB8", Offset = "0x82DEB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DEB8", Offset = "0x82DEB8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x82DEB8", Offset = "0x82DEB8")]
		public float rotationWeight;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DF30", Offset = "0x82DF30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DF30", Offset = "0x82DF30")]
		public float bodyClampWeight;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DF84", Offset = "0x82DF84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DF84", Offset = "0x82DF84")]
		public float headClampWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82DFD8", Offset = "0x82DFD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82DFD8", Offset = "0x82DFD8")]
		public float bendWeight;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E02C", Offset = "0x82E02C")]
		public BendBone[] bendBones;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x82E064", Offset = "0x82E064")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E064", Offset = "0x82E064")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E064", Offset = "0x82E064")]
		public float CCDWeight;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E0DC", Offset = "0x82E0DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E0DC", Offset = "0x82E0DC")]
		public float roll;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E130", Offset = "0x82E130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E130", Offset = "0x82E130")]
		public float damper;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E188", Offset = "0x82E188")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E1C0", Offset = "0x82E1C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E1C0", Offset = "0x82E1C0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x82E1C0", Offset = "0x82E1C0")]
		public float postStretchWeight;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E238", Offset = "0x82E238")]
		public float maxStretch;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E270", Offset = "0x82E270")]
		public float stretchDamper;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E2A8", Offset = "0x82E2A8")]
		public bool fixHead;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E2E0", Offset = "0x82E2E0")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x82E318", Offset = "0x82E318")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E350", Offset = "0x82E350")]
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

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1E116B4", Offset = "0x1E116B4", VA = "0x1E116B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1E11A3C", Offset = "0x1E11A3C", VA = "0x1E11A3C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1E11F18", Offset = "0x1E11F18", VA = "0x1E11F18")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1E122E4", Offset = "0x1E122E4", VA = "0x1E122E4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1E12A70", Offset = "0x1E12A70", VA = "0x1E12A70")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1E12D50", Offset = "0x1E12D50", VA = "0x1E12D50")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1E13054", Offset = "0x1E13054", VA = "0x1E13054")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1E13828", Offset = "0x1E13828", VA = "0x1E13828")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1E12854", Offset = "0x1E12854", VA = "0x1E12854")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1E139F0", Offset = "0x1E139F0", VA = "0x1E139F0")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1E13740", Offset = "0x1E13740", VA = "0x1E13740")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1E13674", Offset = "0x1E13674", VA = "0x1E13674")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1E13C74", Offset = "0x1E13C74", VA = "0x1E13C74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1E13FA8", Offset = "0x1E13FA8", VA = "0x1E13FA8")]
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

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E48C", Offset = "0x82E48C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82E48C", Offset = "0x82E48C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E4C8", Offset = "0x82E4C8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82E4C8", Offset = "0x82E4C8")]
			private bool <isRigid>k__BackingField;

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
				[Token(Token = "0x60002CB")]
				[Address(RVA = "0x1516D78", Offset = "0x1516D78", VA = "0x1516D78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F8C", Offset = "0x837F8C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0x1516D80", Offset = "0x1516D80", VA = "0x1516D80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F9C", Offset = "0x837F9C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003D")]
			public bool isRigid
			{
				[Token(Token = "0x60002CD")]
				[Address(RVA = "0x1516D88", Offset = "0x1516D88", VA = "0x1516D88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837FAC", Offset = "0x837FAC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0x1516D90", Offset = "0x1516D90", VA = "0x1516D90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837FBC", Offset = "0x837FBC")]
				private set
				{
				}
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1516D9C", Offset = "0x1516D9C", VA = "0x1516D9C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1516E08", Offset = "0x1516E08", VA = "0x1516E08")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1516E60", Offset = "0x1516E60", VA = "0x1516E60")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1517004", Offset = "0x1517004", VA = "0x1517004")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E3F4", Offset = "0x82E3F4")]
		public float pin;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E40C", Offset = "0x82E40C")]
		public float pull;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E424", Offset = "0x82E424")]
		public float push;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E43C", Offset = "0x82E43C")]
		public float pushParent;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E454", Offset = "0x82E454")]
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

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1E14714", Offset = "0x1E14714", VA = "0x1E14714")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1E14830", Offset = "0x1E14830", VA = "0x1E14830")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1E149A0", Offset = "0x1E149A0", VA = "0x1E149A0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1E14ADC", Offset = "0x1E14ADC", VA = "0x1E14ADC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1E14BB4", Offset = "0x1E14BB4", VA = "0x1E14BB4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1E14CD8", Offset = "0x1E14CD8", VA = "0x1E14CD8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1E153A8", Offset = "0x1E153A8", VA = "0x1E153A8")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1E14E74", Offset = "0x1E14E74", VA = "0x1E14E74")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1E15798", Offset = "0x1E15798", VA = "0x1E15798")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1E159F8", Offset = "0x1E159F8", VA = "0x1E159F8")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1E15C64", Offset = "0x1E15C64", VA = "0x1E15C64")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1E16008", Offset = "0x1E16008", VA = "0x1E16008")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1E1649C", Offset = "0x1E1649C", VA = "0x1E1649C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1E166C0", Offset = "0x1E166C0", VA = "0x1E166C0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1E1642C", Offset = "0x1E1642C", VA = "0x1E1642C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1E15E94", Offset = "0x1E15E94", VA = "0x1E15E94")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1E163B0", Offset = "0x1E163B0", VA = "0x1E163B0")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1E167A8", Offset = "0x1E167A8", VA = "0x1E167A8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1E162D0", Offset = "0x1E162D0", VA = "0x1E162D0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1E165A8", Offset = "0x1E165A8", VA = "0x1E165A8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E504", Offset = "0x82E504")]
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

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82E51C", Offset = "0x82E51C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E51C", Offset = "0x82E51C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700003E")]
		public bool initiated
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x1E2545C", Offset = "0x1E2545C", VA = "0x1E2545C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837FCC", Offset = "0x837FCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1E25464", Offset = "0x1E25464", VA = "0x1E25464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837FDC", Offset = "0x837FDC")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1E25274", Offset = "0x1E25274", VA = "0x1E25274")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1E25470", Offset = "0x1E25470", VA = "0x1E25470")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1E254B4", Offset = "0x1E254B4", VA = "0x1E254B4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1E25520", Offset = "0x1E25520", VA = "0x1E25520")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1E25570", Offset = "0x1E25570", VA = "0x1E25570")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1E25884", Offset = "0x1E25884", VA = "0x1E25884")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1E25A74", Offset = "0x1E25A74", VA = "0x1E25A74")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1E25DC4", Offset = "0x1E25DC4", VA = "0x1E25DC4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1E25734", Offset = "0x1E25734", VA = "0x1E25734")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1E257DC", Offset = "0x1E257DC", VA = "0x1E257DC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E558", Offset = "0x82E558")]
		public float positionWeight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E570", Offset = "0x82E570")]
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

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E588", Offset = "0x82E588")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82E588", Offset = "0x82E588")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E5C4", Offset = "0x82E5C4")]
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
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x1E26260", Offset = "0x1E26260", VA = "0x1E26260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837FEC", Offset = "0x837FEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x1E26268", Offset = "0x1E26268", VA = "0x1E26268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837FFC", Offset = "0x837FFC")]
			private set
			{
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1E261F8", Offset = "0x1E261F8", VA = "0x1E261F8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1E26274", Offset = "0x1E26274", VA = "0x1E26274")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1E26304", Offset = "0x1E26304", VA = "0x1E26304")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1E26448", Offset = "0x1E26448", VA = "0x1E26448")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1E265C8", Offset = "0x1E265C8", VA = "0x1E265C8")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1E268F0", Offset = "0x1E268F0", VA = "0x1E268F0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1E26BBC", Offset = "0x1E26BBC", VA = "0x1E26BBC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1E26C90", Offset = "0x1E26C90", VA = "0x1E26C90")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1E26D38", Offset = "0x1E26D38", VA = "0x1E26D38")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1E27274", Offset = "0x1E27274", VA = "0x1E27274")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1E272A0", Offset = "0x1E272A0", VA = "0x1E272A0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1E27400", Offset = "0x1E27400", VA = "0x1E27400")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1E2768C", Offset = "0x1E2768C", VA = "0x1E2768C")]
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
				[Token(Token = "0x60002F4")]
				[Address(RVA = "0x151B744", Offset = "0x151B744", VA = "0x151B744")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000041")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002F7")]
				[Address(RVA = "0x151B820", Offset = "0x151B820", VA = "0x151B820")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000042")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0x151BBF0", Offset = "0x151BBF0", VA = "0x151BBF0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x151B6F4", Offset = "0x151B6F4", VA = "0x151B6F4")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x151B780", Offset = "0x151B780", VA = "0x151B780")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x151B7D0", Offset = "0x151B7D0", VA = "0x151B7D0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x151B830", Offset = "0x151B830", VA = "0x151B830")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x151B8B8", Offset = "0x151B8B8", VA = "0x151B8B8")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x151B8C0", Offset = "0x151B8C0", VA = "0x151B8C0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x151B998", Offset = "0x151B998", VA = "0x151B998")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x151BA10", Offset = "0x151BA10", VA = "0x151BA10")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x151BAD4", Offset = "0x151BAD4", VA = "0x151BAD4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x151BD30", Offset = "0x151BD30", VA = "0x151BD30")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x151BD68", Offset = "0x151BD68", VA = "0x151BD68")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x151BDA0", Offset = "0x151BDA0", VA = "0x151BDA0")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x151BDC8", Offset = "0x151BDC8", VA = "0x151BDC8")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x151BEB4", Offset = "0x151BEB4", VA = "0x151BEB4")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x151C040", Offset = "0x151C040", VA = "0x151C040")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x151C070", Offset = "0x151C070", VA = "0x151C070")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x151C138", Offset = "0x151C138", VA = "0x151C138")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x151C1A8", Offset = "0x151C1A8", VA = "0x151C1A8")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x151C2F8", Offset = "0x151C2F8", VA = "0x151C2F8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x151C448", Offset = "0x151C448", VA = "0x151C448")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x151C4C8", Offset = "0x151C4C8", VA = "0x151C4C8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x151BF30", Offset = "0x151BF30", VA = "0x151BF30")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x151C600", Offset = "0x151C600", VA = "0x151C600")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1E27B40", Offset = "0x1E27B40", VA = "0x1E27B40", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1E27B48", Offset = "0x1E27B48", VA = "0x1E27B48", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1E27B4C", Offset = "0x1E27B4C", VA = "0x1E27B4C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1E27C9C", Offset = "0x1E27C9C", VA = "0x1E27C9C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1E27D0C", Offset = "0x1E27D0C", VA = "0x1E27D0C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E5DC", Offset = "0x82E5DC")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1E27D14", Offset = "0x1E27D14", VA = "0x1E27D14", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1E27DC8", Offset = "0x1E27DC8", VA = "0x1E27DC8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1E27E40", Offset = "0x1E27E40", VA = "0x1E27E40")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1E27ED4", Offset = "0x1E27ED4", VA = "0x1E27ED4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1E27EF0", Offset = "0x1E27EF0", VA = "0x1E27EF0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1E27F10", Offset = "0x1E27F10", VA = "0x1E27F10", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1E27FA8", Offset = "0x1E27FA8", VA = "0x1E27FA8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1E27FC4", Offset = "0x1E27FC4", VA = "0x1E27FC4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E5F4", Offset = "0x82E5F4")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E60C", Offset = "0x82E60C")]
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

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1E27FEC", Offset = "0x1E27FEC", VA = "0x1E27FEC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1E28070", Offset = "0x1E28070", VA = "0x1E28070")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1E2814C", Offset = "0x1E2814C", VA = "0x1E2814C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1E28370", Offset = "0x1E28370", VA = "0x1E28370")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1E28464", Offset = "0x1E28464", VA = "0x1E28464")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1E28590", Offset = "0x1E28590", VA = "0x1E28590")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1E285F4", Offset = "0x1E285F4", VA = "0x1E285F4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1E286A8", Offset = "0x1E286A8", VA = "0x1E286A8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1E2876C", Offset = "0x1E2876C", VA = "0x1E2876C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1E28A04", Offset = "0x1E28A04", VA = "0x1E28A04")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1E28A78", Offset = "0x1E28A78", VA = "0x1E28A78")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E624", Offset = "0x82E624")]
		public int iterations;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E63C", Offset = "0x82E63C")]
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

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1E28BF8", Offset = "0x1E28BF8", VA = "0x1E28BF8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1E28F64", Offset = "0x1E28F64", VA = "0x1E28F64")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1E29084", Offset = "0x1E29084", VA = "0x1E29084")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1E291E4", Offset = "0x1E291E4", VA = "0x1E291E4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1E29264", Offset = "0x1E29264", VA = "0x1E29264")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1E292D0", Offset = "0x1E292D0", VA = "0x1E292D0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1E29354", Offset = "0x1E29354", VA = "0x1E29354", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1E29998", Offset = "0x1E29998", VA = "0x1E29998")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1E299D0", Offset = "0x1E299D0", VA = "0x1E299D0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1E29C54", Offset = "0x1E29C54", VA = "0x1E29C54")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1E29F5C", Offset = "0x1E29F5C", VA = "0x1E29F5C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1E2A048", Offset = "0x1E2A048", VA = "0x1E2A048")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1E2A110", Offset = "0x1E2A110", VA = "0x1E2A110")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E73C", Offset = "0x82E73C")]
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

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x151D1A4", Offset = "0x151D1A4", VA = "0x151D1A4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x151D1F4", Offset = "0x151D1F4", VA = "0x151D1F4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x151D294", Offset = "0x151D294", VA = "0x151D294")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x151D2CC", Offset = "0x151D2CC", VA = "0x151D2CC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x151D304", Offset = "0x151D304", VA = "0x151D304")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x151D354", Offset = "0x151D354", VA = "0x151D354")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x151CD00", Offset = "0x151CD00", VA = "0x151CD00")]
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
				[Token(Token = "0x600034A")]
				[Address(RVA = "0x151C61C", Offset = "0x151C61C", VA = "0x151C61C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600034B")]
				[Address(RVA = "0x151C720", Offset = "0x151C720", VA = "0x151C720")]
				set
				{
				}
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x151C7B0", Offset = "0x151C7B0", VA = "0x151C7B0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x151C960", Offset = "0x151C960", VA = "0x151C960")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x151CB34", Offset = "0x151CB34", VA = "0x151CB34")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x151CC94", Offset = "0x151CC94", VA = "0x151CC94")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x151CCBC", Offset = "0x151CCBC", VA = "0x151CCBC")]
			public Bone()
			{
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x151CD3C", Offset = "0x151CD3C", VA = "0x151CD3C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x151CD94", Offset = "0x151CD94", VA = "0x151CD94")]
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

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x151D12C", Offset = "0x151D12C", VA = "0x151D12C")]
			public Node()
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x151D130", Offset = "0x151D130", VA = "0x151D130")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x151D160", Offset = "0x151D160", VA = "0x151D160")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E674", Offset = "0x82E674")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E674", Offset = "0x82E674")]
		public float IKPositionWeight;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E6C8", Offset = "0x82E6C8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82E6C8", Offset = "0x82E6C8")]
		private bool <initiated>k__BackingField;

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
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1E2A448", Offset = "0x1E2A448", VA = "0x1E2A448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83800C", Offset = "0x83800C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1E2A450", Offset = "0x1E2A450", VA = "0x1E2A450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83801C", Offset = "0x83801C")]
			private set
			{
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1E2A378", Offset = "0x1E2A378", VA = "0x1E2A378")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1E25084", Offset = "0x1E25084", VA = "0x1E25084")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1E24FA4", Offset = "0x1E24FA4", VA = "0x1E24FA4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1E2A3F0", Offset = "0x1E2A3F0", VA = "0x1E2A3F0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1E2A3FC", Offset = "0x1E2A3FC", VA = "0x1E2A3FC")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1E2A408", Offset = "0x1E2A408", VA = "0x1E2A408")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1E2A410", Offset = "0x1E2A410", VA = "0x1E2A410")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1E2A440", Offset = "0x1E2A440", VA = "0x1E2A440")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000339")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600033A")]
		public abstract void FixTransforms();

		[Token(Token = "0x600033B")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600033C")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600033D")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1E2A45C", Offset = "0x1E2A45C", VA = "0x1E2A45C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1E2A474", Offset = "0x1E2A474", VA = "0x1E2A474")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1E2A5B4", Offset = "0x1E2A5B4", VA = "0x1E2A5B4")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1E2A65C", Offset = "0x1E2A65C", VA = "0x1E2A65C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1E2A8E4", Offset = "0x1E2A8E4", VA = "0x1E2A8E4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E754", Offset = "0x82E754")]
		public float poleWeight;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E76C", Offset = "0x82E76C")]
		public float clampWeight;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E784", Offset = "0x82E784")]
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
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1E2A978", Offset = "0x1E2A978", VA = "0x1E2A978")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x1E2A9B4", Offset = "0x1E2A9B4", VA = "0x1E2A9B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000047")]
		protected override int minBones
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1E2B464", Offset = "0x1E2B464", VA = "0x1E2B464", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1E2B848", Offset = "0x1E2B848", VA = "0x1E2B848", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1E2A8FC", Offset = "0x1E2A8FC", VA = "0x1E2A8FC")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1E2A9F0", Offset = "0x1E2A9F0", VA = "0x1E2A9F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1E2AC10", Offset = "0x1E2AC10", VA = "0x1E2AC10", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1E2B3B0", Offset = "0x1E2B3B0", VA = "0x1E2B3B0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1E2B140", Offset = "0x1E2B140", VA = "0x1E2B140")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1E2B46C", Offset = "0x1E2B46C", VA = "0x1E2B46C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1E2B8BC", Offset = "0x1E2B8BC", VA = "0x1E2B8BC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E79C", Offset = "0x82E79C")]
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

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1E2B910", Offset = "0x1E2B910", VA = "0x1E2B910", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1E2BCF4", Offset = "0x1E2BCF4", VA = "0x1E2BCF4")]
		public void SetRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1E2BCFC", Offset = "0x1E2BCFC", VA = "0x1E2BCFC")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1E2BDB0", Offset = "0x1E2BDB0", VA = "0x1E2BDB0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1E2BF44", Offset = "0x1E2BF44", VA = "0x1E2BF44", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1E2C0D8", Offset = "0x1E2C0D8", VA = "0x1E2C0D8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1E2C134", Offset = "0x1E2C134", VA = "0x1E2C134", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1E2C1A4", Offset = "0x1E2C1A4", VA = "0x1E2C1A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1E2C514", Offset = "0x1E2C514", VA = "0x1E2C514", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1E2C540", Offset = "0x1E2C540", VA = "0x1E2C540")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1E2C208", Offset = "0x1E2C208", VA = "0x1E2C208")]
		private void Read()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1E2C5B4", Offset = "0x1E2C5B4", VA = "0x1E2C5B4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1E2C740", Offset = "0x1E2C740", VA = "0x1E2C740")]
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

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1E2C904", Offset = "0x1E2C904", VA = "0x1E2C904")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1E2C9B4", Offset = "0x1E2C9B4", VA = "0x1E2C9B4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1E2CA38", Offset = "0x1E2CA38", VA = "0x1E2CA38", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1E2CC68", Offset = "0x1E2CC68", VA = "0x1E2CC68")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1E2D244", Offset = "0x1E2D244", VA = "0x1E2D244")]
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
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x1E2E170", Offset = "0x1E2E170", VA = "0x1E2E170", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1E2D24C", Offset = "0x1E2D24C", VA = "0x1E2D24C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1E2D810", Offset = "0x1E2D810", VA = "0x1E2D810")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1E2D950", Offset = "0x1E2D950", VA = "0x1E2D950", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1E2D9E4", Offset = "0x1E2D9E4", VA = "0x1E2D9E4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1E2DEDC", Offset = "0x1E2DEDC", VA = "0x1E2DEDC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1E2E178", Offset = "0x1E2E178", VA = "0x1E2E178")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1E2D328", Offset = "0x1E2D328", VA = "0x1E2D328")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1E2D8FC", Offset = "0x1E2D8FC", VA = "0x1E2D8FC")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1E2E114", Offset = "0x1E2E114", VA = "0x1E2E114")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1E2D684", Offset = "0x1E2D684", VA = "0x1E2D684")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1E2E7C8", Offset = "0x1E2E7C8", VA = "0x1E2E7C8")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1E2E83C", Offset = "0x1E2E83C", VA = "0x1E2E83C")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1E2E904", Offset = "0x1E2E904", VA = "0x1E2E904")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1E2E9B4", Offset = "0x1E2E9B4", VA = "0x1E2E9B4")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1E2DC8C", Offset = "0x1E2DC8C", VA = "0x1E2DC8C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1E2DDB4", Offset = "0x1E2DDB4", VA = "0x1E2DDB4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1E2EAB8", Offset = "0x1E2EAB8", VA = "0x1E2EAB8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1E2E398", Offset = "0x1E2E398", VA = "0x1E2E398")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1E2D8EC", Offset = "0x1E2D8EC", VA = "0x1E2D8EC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1E2F048", Offset = "0x1E2F048", VA = "0x1E2F048")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1E2EBFC", Offset = "0x1E2EBFC", VA = "0x1E2EBFC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1E2E1F4", Offset = "0x1E2E1F4", VA = "0x1E2E1F4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1E2E2D4", Offset = "0x1E2E2D4", VA = "0x1E2E2D4")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1E2F114", Offset = "0x1E2F114", VA = "0x1E2F114")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E7B4", Offset = "0x82E7B4")]
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

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1E2F1AC", Offset = "0x1E2F1AC", VA = "0x1E2F1AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1E2F83C", Offset = "0x1E2F83C", VA = "0x1E2F83C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1E2F8D4", Offset = "0x1E2F8D4", VA = "0x1E2F8D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1E2F974", Offset = "0x1E2F974", VA = "0x1E2F974", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1E2FA80", Offset = "0x1E2FA80", VA = "0x1E2FA80")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1E2FB1C", Offset = "0x1E2FB1C", VA = "0x1E2FB1C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1E2FF4C", Offset = "0x1E2FF4C", VA = "0x1E2FF4C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1E3015C", Offset = "0x1E3015C", VA = "0x1E3015C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1E2FFF8", Offset = "0x1E2FFF8", VA = "0x1E2FFF8")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1E2FD08", Offset = "0x1E2FD08", VA = "0x1E2FD08")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1E301F4", Offset = "0x1E301F4", VA = "0x1E301F4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E7CC", Offset = "0x82E7CC")]
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

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1E5B448", Offset = "0x1E5B448", VA = "0x1E5B448")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1E5B538", Offset = "0x1E5B538", VA = "0x1E5B538")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1E5B594", Offset = "0x1E5B594", VA = "0x1E5B594")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1E5B6C4", Offset = "0x1E5B6C4", VA = "0x1E5B6C4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1E5B720", Offset = "0x1E5B720", VA = "0x1E5B720")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1E5B7A0", Offset = "0x1E5B7A0", VA = "0x1E5B7A0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1E5B94C", Offset = "0x1E5B94C", VA = "0x1E5B94C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1E5BABC", Offset = "0x1E5BABC", VA = "0x1E5BABC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1E5BCCC", Offset = "0x1E5BCCC", VA = "0x1E5BCCC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1E5BDA4", Offset = "0x1E5BDA4", VA = "0x1E5BDA4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1E5BE90", Offset = "0x1E5BE90", VA = "0x1E5BE90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1E5C004", Offset = "0x1E5C004", VA = "0x1E5C004", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1E5C15C", Offset = "0x1E5C15C", VA = "0x1E5C15C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1E5C3A8", Offset = "0x1E5C3A8", VA = "0x1E5C3A8", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1E5C684", Offset = "0x1E5C684", VA = "0x1E5C684", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1E5C6C8", Offset = "0x1E5C6C8", VA = "0x1E5C6C8", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1E5C7B8", Offset = "0x1E5C7B8", VA = "0x1E5C7B8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E7E4", Offset = "0x82E7E4")]
		public float spineStiffness;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E7FC", Offset = "0x82E7FC")]
		public float pullBodyVertical;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E814", Offset = "0x82E814")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E82C", Offset = "0x82E82C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82E82C", Offset = "0x82E82C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700004A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x1E5C8F8", Offset = "0x1E5C8F8", VA = "0x1E5C8F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1E5CA40", Offset = "0x1E5CA40", VA = "0x1E5CA40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1E5CA48", Offset = "0x1E5CA48", VA = "0x1E5CA48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1E5CA50", Offset = "0x1E5CA50", VA = "0x1E5CA50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1E5CA58", Offset = "0x1E5CA58", VA = "0x1E5CA58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1E5CA60", Offset = "0x1E5CA60", VA = "0x1E5CA60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1E5CA68", Offset = "0x1E5CA68", VA = "0x1E5CA68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1E5CA70", Offset = "0x1E5CA70", VA = "0x1E5CA70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1E5CA78", Offset = "0x1E5CA78", VA = "0x1E5CA78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1E5CA80", Offset = "0x1E5CA80", VA = "0x1E5CA80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1E5CAB8", Offset = "0x1E5CAB8", VA = "0x1E5CAB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1E5CAF0", Offset = "0x1E5CAF0", VA = "0x1E5CAF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1E5CB28", Offset = "0x1E5CB28", VA = "0x1E5CB28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1E5CB60", Offset = "0x1E5CB60", VA = "0x1E5CB60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1E5CB94", Offset = "0x1E5CB94", VA = "0x1E5CB94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1E5CBCC", Offset = "0x1E5CBCC", VA = "0x1E5CBCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1E5CC04", Offset = "0x1E5CC04", VA = "0x1E5CC04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x1E5CC3C", Offset = "0x1E5CC3C", VA = "0x1E5CC3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1E5EDC8", Offset = "0x1E5EDC8", VA = "0x1E5EDC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83802C", Offset = "0x83802C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1E5EDD4", Offset = "0x1E5EDD4", VA = "0x1E5EDD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83803C", Offset = "0x83803C")]
			private set
			{
			}
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1E5CC70", Offset = "0x1E5CC70", VA = "0x1E5CC70")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1E5CD7C", Offset = "0x1E5CD7C", VA = "0x1E5CD7C")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1E5CCC4", Offset = "0x1E5CCC4", VA = "0x1E5CCC4")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1E5CE08", Offset = "0x1E5CE08", VA = "0x1E5CE08")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1E5C900", Offset = "0x1E5C900", VA = "0x1E5C900")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1E5CED8", Offset = "0x1E5CED8", VA = "0x1E5CED8")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1E5CF90", Offset = "0x1E5CF90", VA = "0x1E5CF90")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1E5D044", Offset = "0x1E5D044", VA = "0x1E5D044")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1E5D0F8", Offset = "0x1E5D0F8", VA = "0x1E5D0F8")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1E5D100", Offset = "0x1E5D100", VA = "0x1E5D100")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1E5D134", Offset = "0x1E5D134", VA = "0x1E5D134")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1E5D1FC", Offset = "0x1E5D1FC", VA = "0x1E5D1FC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1E5D3A4", Offset = "0x1E5D3A4", VA = "0x1E5D3A4")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1E5E844", Offset = "0x1E5E844", VA = "0x1E5E844")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1E5EC58", Offset = "0x1E5EC58", VA = "0x1E5EC58")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1E5ECB8", Offset = "0x1E5ECB8", VA = "0x1E5ECB8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1E5EAE0", Offset = "0x1E5EAE0", VA = "0x1E5EAE0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1E5EB9C", Offset = "0x1E5EB9C", VA = "0x1E5EB9C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1E5EDE0", Offset = "0x1E5EDE0", VA = "0x1E5EDE0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1E5EEB8", Offset = "0x1E5EEB8", VA = "0x1E5EEB8", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1E5EFB4", Offset = "0x1E5EFB4", VA = "0x1E5EFB4")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1E5F0DC", Offset = "0x1E5F0DC", VA = "0x1E5F0DC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1E5F220", Offset = "0x1E5F220", VA = "0x1E5F220")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1E5F350", Offset = "0x1E5F350", VA = "0x1E5F350", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1E5F590", Offset = "0x1E5F590", VA = "0x1E5F590", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1E5F614", Offset = "0x1E5F614", VA = "0x1E5F614")]
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
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1E5FEC8", Offset = "0x1E5FEC8", VA = "0x1E5FEC8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1E5FED0", Offset = "0x1E5FED0", VA = "0x1E5FED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1E5FED8", Offset = "0x1E5FED8", VA = "0x1E5FED8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1E60360", Offset = "0x1E60360", VA = "0x1E60360", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		protected float positionOffset
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x1E60428", Offset = "0x1E60428", VA = "0x1E60428")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1E5F624", Offset = "0x1E5F624", VA = "0x1E5F624")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1E5F7E0", Offset = "0x1E5F7E0", VA = "0x1E5F7E0")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1E5F940", Offset = "0x1E5F940", VA = "0x1E5F940", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1E5F9AC", Offset = "0x1E5F9AC", VA = "0x1E5F9AC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1E5FA2C", Offset = "0x1E5FA2C", VA = "0x1E5FA2C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1E5FDD0", Offset = "0x1E5FDD0", VA = "0x1E5FDD0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1E5FDD8", Offset = "0x1E5FDD8", VA = "0x1E5FDD8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1E5FEE0", Offset = "0x1E5FEE0", VA = "0x1E5FEE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1E5FEE4", Offset = "0x1E5FEE4", VA = "0x1E5FEE4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1E5FEE8", Offset = "0x1E5FEE8", VA = "0x1E5FEE8")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1E6047C", Offset = "0x1E6047C", VA = "0x1E6047C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1E60794", Offset = "0x1E60794", VA = "0x1E60794")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1E60988", Offset = "0x1E60988", VA = "0x1E60988")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E868", Offset = "0x82E868")]
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

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1E60A00", Offset = "0x1E60A00", VA = "0x1E60A00", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1E60DE8", Offset = "0x1E60DE8", VA = "0x1E60DE8")]
		public void SetRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1E60DF0", Offset = "0x1E60DF0", VA = "0x1E60DF0")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1E60EA8", Offset = "0x1E60EA8", VA = "0x1E60EA8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1E6103C", Offset = "0x1E6103C", VA = "0x1E6103C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1E611D0", Offset = "0x1E611D0", VA = "0x1E611D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1E6122C", Offset = "0x1E6122C", VA = "0x1E6122C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1E6129C", Offset = "0x1E6129C", VA = "0x1E6129C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1E6160C", Offset = "0x1E6160C", VA = "0x1E6160C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1E61638", Offset = "0x1E61638", VA = "0x1E61638")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1E61300", Offset = "0x1E61300", VA = "0x1E61300")]
		private void Read()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1E616D4", Offset = "0x1E616D4", VA = "0x1E616D4")]
		private void Write()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1E61860", Offset = "0x1E61860", VA = "0x1E61860")]
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

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x151D5E8", Offset = "0x151D5E8", VA = "0x151D5E8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E880", Offset = "0x82E880")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E898", Offset = "0x82E898")]
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
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1E62B90", Offset = "0x1E62B90", VA = "0x1E62B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1E61A18", Offset = "0x1E61A18", VA = "0x1E61A18")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1E61A68", Offset = "0x1E61A68", VA = "0x1E61A68")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1E61AB4", Offset = "0x1E61AB4", VA = "0x1E61AB4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1E61F88", Offset = "0x1E61F88", VA = "0x1E61F88", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1E628D0", Offset = "0x1E628D0", VA = "0x1E628D0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1E6297C", Offset = "0x1E6297C", VA = "0x1E6297C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1E62AF4", Offset = "0x1E62AF4", VA = "0x1E62AF4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1E61DB0", Offset = "0x1E61DB0", VA = "0x1E61DB0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1E6206C", Offset = "0x1E6206C", VA = "0x1E6206C")]
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
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x151D87C", Offset = "0x151D87C", VA = "0x151D87C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x151D648", Offset = "0x151D648", VA = "0x151D648")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x151D64C", Offset = "0x151D64C", VA = "0x151D64C")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x151D67C", Offset = "0x151D67C", VA = "0x151D67C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x151D774", Offset = "0x151D774", VA = "0x151D774")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E8B0", Offset = "0x82E8B0")]
		public float bodyWeight;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E8C8", Offset = "0x82E8C8")]
		public float headWeight;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E8E0", Offset = "0x82E8E0")]
		public float eyesWeight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E8F8", Offset = "0x82E8F8")]
		public float clampWeight;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E910", Offset = "0x82E910")]
		public float clampWeightHead;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E928", Offset = "0x82E928")]
		public float clampWeightEyes;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E940", Offset = "0x82E940")]
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
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1E6334C", Offset = "0x1E6334C", VA = "0x1E6334C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1E6351C", Offset = "0x1E6351C", VA = "0x1E6351C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		protected bool headIsValid
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1E6342C", Offset = "0x1E6342C", VA = "0x1E6342C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1E63540", Offset = "0x1E63540", VA = "0x1E63540")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x1E6343C", Offset = "0x1E6343C", VA = "0x1E6343C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1E635B8", Offset = "0x1E635B8", VA = "0x1E635B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1E62BAC", Offset = "0x1E62BAC", VA = "0x1E62BAC")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1E62BDC", Offset = "0x1E62BDC", VA = "0x1E62BDC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1E62C34", Offset = "0x1E62C34", VA = "0x1E62C34")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1E62CB0", Offset = "0x1E62CB0", VA = "0x1E62CB0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1E62D48", Offset = "0x1E62D48", VA = "0x1E62D48")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1E62E08", Offset = "0x1E62E08", VA = "0x1E62E08")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1E62F04", Offset = "0x1E62F04", VA = "0x1E62F04", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1E63030", Offset = "0x1E63030", VA = "0x1E63030")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1E6303C", Offset = "0x1E6303C", VA = "0x1E6303C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1E63180", Offset = "0x1E63180", VA = "0x1E63180", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1E635DC", Offset = "0x1E635DC", VA = "0x1E635DC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1E6384C", Offset = "0x1E6384C", VA = "0x1E6384C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1E639E8", Offset = "0x1E639E8", VA = "0x1E639E8")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1E63C4C", Offset = "0x1E63C4C", VA = "0x1E63C4C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1E63F5C", Offset = "0x1E63F5C", VA = "0x1E63F5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1E6402C", Offset = "0x1E6402C", VA = "0x1E6402C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1E641CC", Offset = "0x1E641CC", VA = "0x1E641CC")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1E643F0", Offset = "0x1E643F0", VA = "0x1E643F0")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1E647A4", Offset = "0x1E647A4", VA = "0x1E647A4")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1E63AA0", Offset = "0x1E63AA0", VA = "0x1E63AA0")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1E64A14", Offset = "0x1E64A14", VA = "0x1E64A14")]
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

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x151D8B8", Offset = "0x151D8B8", VA = "0x151D8B8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x151D9B4", Offset = "0x151D9B4", VA = "0x151D9B4")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x151D9E4", Offset = "0x151D9E4", VA = "0x151D9E4")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x151DA20", Offset = "0x151DA20", VA = "0x151DA20")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E958", Offset = "0x82E958")]
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

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1E64C78", Offset = "0x1E64C78", VA = "0x1E64C78")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1E64DD4", Offset = "0x1E64DD4", VA = "0x1E64DD4")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1E64F18", Offset = "0x1E64F18", VA = "0x1E64F18")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1E64F24", Offset = "0x1E64F24", VA = "0x1E64F24")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1E64F54", Offset = "0x1E64F54", VA = "0x1E64F54")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1E64F60", Offset = "0x1E64F60", VA = "0x1E64F60")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1E64F68", Offset = "0x1E64F68", VA = "0x1E64F68", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1E6508C", Offset = "0x1E6508C", VA = "0x1E6508C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1E651A8", Offset = "0x1E651A8", VA = "0x1E651A8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1E651F4", Offset = "0x1E651F4", VA = "0x1E651F4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1E65254", Offset = "0x1E65254", VA = "0x1E65254", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1E6564C", Offset = "0x1E6564C", VA = "0x1E6564C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1E656CC", Offset = "0x1E656CC", VA = "0x1E656CC")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1E65A88", Offset = "0x1E65A88", VA = "0x1E65A88")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1E65BF0", Offset = "0x1E65BF0", VA = "0x1E65BF0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1E65D58", Offset = "0x1E65D58", VA = "0x1E65D58")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1E65CCC", Offset = "0x1E65CCC", VA = "0x1E65CCC")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1E65E5C", Offset = "0x1E65E5C", VA = "0x1E65E5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1E66630", Offset = "0x1E66630", VA = "0x1E66630", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1E66634", Offset = "0x1E66634", VA = "0x1E66634", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1E66638", Offset = "0x1E66638", VA = "0x1E66638", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1E66448", Offset = "0x1E66448", VA = "0x1E66448")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1E62A04", Offset = "0x1E62A04", VA = "0x1E62A04")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EBFC", Offset = "0x82EBFC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82EBFC", Offset = "0x82EBFC")]
			public Transform target;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EC5C", Offset = "0x82EC5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82EC5C", Offset = "0x82EC5C")]
			public float positionWeight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82ECB0", Offset = "0x82ECB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82ECB0", Offset = "0x82ECB0")]
			public float rotationWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82ED04", Offset = "0x82ED04")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82ED04", Offset = "0x82ED04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82ED04", Offset = "0x82ED04")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82ED7C", Offset = "0x82ED7C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x82ED7C", Offset = "0x82ED7C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EE50", Offset = "0x82EE50")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x82EE50", Offset = "0x82EE50")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EF2C", Offset = "0x82EF2C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x82EF2C", Offset = "0x82EF2C")]
			public float shoulderYawOffset;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F000", Offset = "0x82F000")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x82F000", Offset = "0x82F000")]
			public float shoulderPitchOffset;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82F0D4", Offset = "0x82F0D4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F0D4", Offset = "0x82F0D4")]
			public Transform bendGoal;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F134", Offset = "0x82F134")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F134", Offset = "0x82F134")]
			public float bendGoalWeight;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F188", Offset = "0x82F188")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F188", Offset = "0x82F188")]
			public float swivelOffset;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F1E4", Offset = "0x82F1E4")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F21C", Offset = "0x82F21C")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82F254", Offset = "0x82F254")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F254", Offset = "0x82F254")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F254", Offset = "0x82F254")]
			public float armLengthMlp;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F2D0", Offset = "0x82F2D0")]
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

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F348", Offset = "0x82F348")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F348", Offset = "0x82F348")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F384", Offset = "0x82F384")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F384", Offset = "0x82F384")]
			private Quaternion <rotation>k__BackingField;

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
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x151DA24", Offset = "0x151DA24", VA = "0x151DA24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83808C", Offset = "0x83808C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x151DA30", Offset = "0x151DA30", VA = "0x151DA30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83809C", Offset = "0x83809C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x151DA3C", Offset = "0x151DA3C", VA = "0x151DA3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380AC", Offset = "0x8380AC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x151DA48", Offset = "0x151DA48", VA = "0x151DA48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380BC", Offset = "0x8380BC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x151DA54", Offset = "0x151DA54", VA = "0x151DA54")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x151DA88", Offset = "0x151DA88", VA = "0x151DA88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x151DAC8", Offset = "0x151DAC8", VA = "0x151DAC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x151DB14", Offset = "0x151DB14", VA = "0x151DB14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x151DB60", Offset = "0x151DB60", VA = "0x151DB60", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x151E474", Offset = "0x151E474", VA = "0x151E474", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x151E630", Offset = "0x151E630", VA = "0x151E630", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x151E654", Offset = "0x151E654", VA = "0x151E654")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x151E8F4", Offset = "0x151E8F4", VA = "0x151E8F4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x151FE74", Offset = "0x151FE74", VA = "0x151FE74", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x151FEA0", Offset = "0x151FEA0", VA = "0x151FEA0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x151F8B0", Offset = "0x151F8B0", VA = "0x151F8B0")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x151F92C", Offset = "0x151F92C", VA = "0x151F92C")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x15200C0", Offset = "0x15200C0", VA = "0x15200C0")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x15201E4", Offset = "0x15201E4", VA = "0x15201E4")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F3C0", Offset = "0x82F3C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F3C0", Offset = "0x82F3C0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F3FC", Offset = "0x82F3FC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F3FC", Offset = "0x82F3FC")]
			private float <mag>k__BackingField;

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
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x1520368", Offset = "0x1520368", VA = "0x1520368")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380CC", Offset = "0x8380CC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x1520370", Offset = "0x1520370", VA = "0x1520370")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380DC", Offset = "0x8380DC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000073")]
			public float mag
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x1520378", Offset = "0x1520378", VA = "0x1520378")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380EC", Offset = "0x8380EC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x1520380", Offset = "0x1520380", VA = "0x1520380")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380FC", Offset = "0x8380FC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000474")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000475")]
			public abstract void PreSolve(float scale);

			[Token(Token = "0x6000476")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000477")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000478")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1520388", Offset = "0x1520388", VA = "0x1520388")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1520390", Offset = "0x1520390", VA = "0x1520390")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1520464", Offset = "0x1520464", VA = "0x1520464")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x15204F8", Offset = "0x15204F8", VA = "0x15204F8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x15205A4", Offset = "0x15205A4", VA = "0x15205A4")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x15205F8", Offset = "0x15205F8", VA = "0x15205F8")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x151FD30", Offset = "0x151FD30", VA = "0x151FD30")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1520734", Offset = "0x1520734", VA = "0x1520734")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1520874", Offset = "0x1520874", VA = "0x1520874")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x15202E8", Offset = "0x15202E8", VA = "0x15202E8")]
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

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F448", Offset = "0x82F448")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F448", Offset = "0x82F448")]
			private float <stepProgress>k__BackingField;

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
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x152089C", Offset = "0x152089C", VA = "0x152089C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000075")]
			public float stepProgress
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x15208B0", Offset = "0x15208B0", VA = "0x15208B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83810C", Offset = "0x83810C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x15208B8", Offset = "0x15208B8", VA = "0x15208B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83811C", Offset = "0x83811C")]
				private set
				{
				}
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x15208C0", Offset = "0x15208C0", VA = "0x15208C0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x15209F8", Offset = "0x15209F8", VA = "0x15209F8")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1520A40", Offset = "0x1520A40", VA = "0x1520A40")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1520C0C", Offset = "0x1520C0C", VA = "0x1520C0C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1520D54", Offset = "0x1520D54", VA = "0x1520D54")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1520EA8", Offset = "0x1520EA8", VA = "0x1520EA8")]
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
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82F484", Offset = "0x82F484")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F484", Offset = "0x82F484")]
			public Transform target;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F4E4", Offset = "0x82F4E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F4E4", Offset = "0x82F4E4")]
			public float positionWeight;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F538", Offset = "0x82F538")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F538", Offset = "0x82F538")]
			public float rotationWeight;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F58C", Offset = "0x82F58C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82F58C", Offset = "0x82F58C")]
			public Transform bendGoal;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F5EC", Offset = "0x82F5EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F5EC", Offset = "0x82F5EC")]
			public float bendGoalWeight;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F640", Offset = "0x82F640")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F640", Offset = "0x82F640")]
			public float swivelOffset;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F69C", Offset = "0x82F69C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F69C", Offset = "0x82F69C")]
			public float bendToTargetWeight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x82F6F0", Offset = "0x82F6F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F6F0", Offset = "0x82F6F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F6F0", Offset = "0x82F6F0")]
			public float legLengthMlp;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F76C", Offset = "0x82F76C")]
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

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F814", Offset = "0x82F814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F814", Offset = "0x82F814")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F850", Offset = "0x82F850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F850", Offset = "0x82F850")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F88C", Offset = "0x82F88C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F88C", Offset = "0x82F88C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F8C8", Offset = "0x82F8C8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F8C8", Offset = "0x82F8C8")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

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

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F904", Offset = "0x82F904")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F904", Offset = "0x82F904")]
			private Vector3 <bendNormalRelToPelvis>k__BackingField;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F940", Offset = "0x82F940")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82F940", Offset = "0x82F940")]
			private Vector3 <bendNormalRelToTarget>k__BackingField;

			[Token(Token = "0x17000076")]
			public Vector3 position
			{
				[Token(Token = "0x6000490")]
				[Address(RVA = "0x1520FE0", Offset = "0x1520FE0", VA = "0x1520FE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83812C", Offset = "0x83812C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000491")]
				[Address(RVA = "0x1520FEC", Offset = "0x1520FEC", VA = "0x1520FEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83813C", Offset = "0x83813C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000492")]
				[Address(RVA = "0x1520FF8", Offset = "0x1520FF8", VA = "0x1520FF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83814C", Offset = "0x83814C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000493")]
				[Address(RVA = "0x1521004", Offset = "0x1521004", VA = "0x1521004")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83815C", Offset = "0x83815C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public bool hasToes
			{
				[Token(Token = "0x6000494")]
				[Address(RVA = "0x1521010", Offset = "0x1521010", VA = "0x1521010")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83816C", Offset = "0x83816C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000495")]
				[Address(RVA = "0x1521018", Offset = "0x1521018", VA = "0x1521018")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83817C", Offset = "0x83817C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0x1521024", Offset = "0x1521024", VA = "0x1521024")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000497")]
				[Address(RVA = "0x1521058", Offset = "0x1521058", VA = "0x1521058")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0x1521090", Offset = "0x1521090", VA = "0x1521090")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000499")]
				[Address(RVA = "0x15210C8", Offset = "0x15210C8", VA = "0x15210C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600049A")]
				[Address(RVA = "0x1521100", Offset = "0x1521100", VA = "0x1521100")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600049B")]
				[Address(RVA = "0x1521140", Offset = "0x1521140", VA = "0x1521140")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83818C", Offset = "0x83818C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049C")]
				[Address(RVA = "0x152114C", Offset = "0x152114C", VA = "0x152114C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83819C", Offset = "0x83819C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x600049D")]
				[Address(RVA = "0x1521158", Offset = "0x1521158", VA = "0x1521158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381AC", Offset = "0x8381AC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049E")]
				[Address(RVA = "0x1521168", Offset = "0x1521168", VA = "0x1521168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381BC", Offset = "0x8381BC")]
				set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x600049F")]
				[Address(RVA = "0x1521178", Offset = "0x1521178", VA = "0x1521178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381CC", Offset = "0x8381CC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004A0")]
				[Address(RVA = "0x1521188", Offset = "0x1521188", VA = "0x1521188")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381DC", Offset = "0x8381DC")]
				set
				{
				}
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1521198", Offset = "0x1521198", VA = "0x1521198", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1521810", Offset = "0x1521810", VA = "0x1521810", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1521DE4", Offset = "0x1521DE4", VA = "0x1521DE4", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1521D94", Offset = "0x1521D94", VA = "0x1521D94")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x1521C24", Offset = "0x1521C24", VA = "0x1521C24")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x15221CC", Offset = "0x15221CC", VA = "0x15221CC")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1522650", Offset = "0x1522650", VA = "0x1522650")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1522370", Offset = "0x1522370", VA = "0x1522370")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1522948", Offset = "0x1522948", VA = "0x1522948", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1522B64", Offset = "0x1522B64", VA = "0x1522B64", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1522BB0", Offset = "0x1522BB0", VA = "0x1522BB0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F97C", Offset = "0x82F97C")]
			public Mode mode;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82F9B4", Offset = "0x82F9B4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82F9B4", Offset = "0x82F9B4")]
			public float weight;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x82FA08", Offset = "0x82FA08")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82FA08", Offset = "0x82FA08")]
			public float moveThreshold;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x82FAC8", Offset = "0x82FAC8")]
			[SerializeField]
			private byte animationHeader;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x82FB90", Offset = "0x82FB90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82FB90", Offset = "0x82FB90")]
			public float minAnimationSpeed;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82FC5C", Offset = "0x82FC5C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x82FC5C", Offset = "0x82FC5C")]
			public float maxAnimationSpeed;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82FD24", Offset = "0x82FD24")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x82FD24", Offset = "0x82FD24")]
			public float animationSmoothTime;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x82FDF4", Offset = "0x82FDF4")]
			[SerializeField]
			private byte rootPositionHeader;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82FEBC", Offset = "0x82FEBC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x82FEBC", Offset = "0x82FEBC")]
			public Vector2 standOffset;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82FF7C", Offset = "0x82FF7C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x82FF7C", Offset = "0x82FF7C")]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830048", Offset = "0x830048")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x830048", Offset = "0x830048")]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830114", Offset = "0x830114")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x830114", Offset = "0x830114")]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8301E0", Offset = "0x8301E0")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x8301E0", Offset = "0x8301E0")]
			public float maxRootOffset;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x8302A0", Offset = "0x8302A0")]
			[SerializeField]
			private byte rootRotationHeader;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830368", Offset = "0x830368")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x830368", Offset = "0x830368")]
			public float maxRootAngleMoving;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x830434", Offset = "0x830434")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830434", Offset = "0x830434")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830538", Offset = "0x830538")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830538", Offset = "0x830538")]
			public float footDistance;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x8305F4", Offset = "0x8305F4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8305F4", Offset = "0x8305F4")]
			public float stepThreshold;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x8306B0", Offset = "0x8306B0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8306B0", Offset = "0x8306B0")]
			public float angleThreshold;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83076C", Offset = "0x83076C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x83076C", Offset = "0x83076C")]
			public float comAngleMlp;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830828", Offset = "0x830828")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830828", Offset = "0x830828")]
			public float maxVelocity;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x8308E4", Offset = "0x8308E4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8308E4", Offset = "0x8308E4")]
			public float velocityFactor;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x8309A0", Offset = "0x8309A0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8309A0", Offset = "0x8309A0")]
			public float maxLegStretch;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830A68", Offset = "0x830A68")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830A68", Offset = "0x830A68")]
			public float rootSpeed;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830B24", Offset = "0x830B24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830B24", Offset = "0x830B24")]
			public float stepSpeed;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830BE0", Offset = "0x830BE0")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830BE0", Offset = "0x830BE0")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830C9C", Offset = "0x830C9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830C9C", Offset = "0x830C9C")]
			public float maxBodyYOffset;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830D58", Offset = "0x830D58")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830D58", Offset = "0x830D58")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830E14", Offset = "0x830E14")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x830E14", Offset = "0x830E14")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830EDC", Offset = "0x830EDC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830EDC", Offset = "0x830EDC")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x830F98", Offset = "0x830F98")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x830F98", Offset = "0x830F98")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831054", Offset = "0x831054")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x831054", Offset = "0x831054")]
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
			[HideInInspector]
			[SerializeField]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8311C0", Offset = "0x8311C0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8311C0", Offset = "0x8311C0")]
			private Vector3 <centerOfMass>k__BackingField;

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
				[Token(Token = "0x60004B7")]
				[Address(RVA = "0x1D9EDA4", Offset = "0x1D9EDA4", VA = "0x1D9EDA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381EC", Offset = "0x8381EC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004B8")]
				[Address(RVA = "0x1D9EDB4", Offset = "0x1D9EDB4", VA = "0x1D9EDB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381FC", Offset = "0x8381FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0x1DA026C", Offset = "0x1DA026C", VA = "0x1DA026C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000083")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0x1DA02AC", Offset = "0x1DA02AC", VA = "0x1DA02AC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000084")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60004C1")]
				[Address(RVA = "0x1DA02F0", Offset = "0x1DA02F0", VA = "0x1DA02F0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000085")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60004C2")]
				[Address(RVA = "0x1DA0330", Offset = "0x1DA0330", VA = "0x1DA0330")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1D9D4B8", Offset = "0x1D9D4B8", VA = "0x1D9D4B8")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1D9D8DC", Offset = "0x1D9D8DC", VA = "0x1D9D8DC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1D9DD34", Offset = "0x1D9DD34", VA = "0x1D9DD34")]
			public void Relax()
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1D9DD9C", Offset = "0x1D9DD9C", VA = "0x1D9DD9C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1D9E17C", Offset = "0x1D9E17C", VA = "0x1D9E17C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1D9D7EC", Offset = "0x1D9D7EC", VA = "0x1D9D7EC")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1D9E2DC", Offset = "0x1D9E2DC", VA = "0x1D9E2DC")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1D9DAE8", Offset = "0x1D9DAE8", VA = "0x1D9DAE8")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1D9E068", Offset = "0x1D9E068", VA = "0x1D9E068")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1D9E28C", Offset = "0x1D9E28C", VA = "0x1D9E28C")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1D9E36C", Offset = "0x1D9E36C", VA = "0x1D9E36C")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1D9D504", Offset = "0x1D9D504", VA = "0x1D9D504")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1D9D908", Offset = "0x1D9D908", VA = "0x1D9D908")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x1D9DD38", Offset = "0x1D9DD38", VA = "0x1D9DD38")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1D9DE18", Offset = "0x1D9DE18", VA = "0x1D9DE18")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1D9E1C8", Offset = "0x1D9E1C8", VA = "0x1D9E1C8")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x1D9EDC4", Offset = "0x1D9EDC4", VA = "0x1D9EDC4")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x1D9FFC0", Offset = "0x1D9FFC0", VA = "0x1D9FFC0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x1DA00FC", Offset = "0x1DA00FC", VA = "0x1DA00FC")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x1DA01A0", Offset = "0x1DA01A0", VA = "0x1DA01A0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x1DA0374", Offset = "0x1DA0374", VA = "0x1DA0374")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8311FC", Offset = "0x8311FC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x8311FC", Offset = "0x8311FC")]
			public Transform headTarget;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83125C", Offset = "0x83125C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83125C", Offset = "0x83125C")]
			public float positionWeight;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8312B0", Offset = "0x8312B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8312B0", Offset = "0x8312B0")]
			public float rotationWeight;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831304", Offset = "0x831304")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831304", Offset = "0x831304")]
			public float headClampWeight;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831358", Offset = "0x831358")]
			public float minHeadHeight;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831390", Offset = "0x831390")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831390", Offset = "0x831390")]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8313E4", Offset = "0x8313E4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x8313E4", Offset = "0x8313E4")]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x8314B8", Offset = "0x8314B8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8314B8", Offset = "0x8314B8")]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831594", Offset = "0x831594")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x831594", Offset = "0x831594")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8315F4", Offset = "0x8315F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8315F4", Offset = "0x8315F4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831648", Offset = "0x831648")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831648", Offset = "0x831648")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83169C", Offset = "0x83169C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83169C", Offset = "0x83169C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x8316F0", Offset = "0x8316F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8316F0", Offset = "0x8316F0")]
			public Transform chestGoal;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831750", Offset = "0x831750")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831750", Offset = "0x831750")]
			public float chestGoalWeight;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8317A4", Offset = "0x8317A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8317A4", Offset = "0x8317A4")]
			public float chestClampWeight;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8317F8", Offset = "0x8317F8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8317F8", Offset = "0x8317F8")]
			public float rotateChestByHands;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x83184C", Offset = "0x83184C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83184C", Offset = "0x83184C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83184C", Offset = "0x83184C")]
			public float bodyPosStiffness;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8318C4", Offset = "0x8318C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8318C4", Offset = "0x8318C4")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831918", Offset = "0x831918")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831918", Offset = "0x831918")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x831918", Offset = "0x831918")]
			public float neckStiffness;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831990", Offset = "0x831990")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x8319C8", Offset = "0x8319C8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8319C8", Offset = "0x8319C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8319C8", Offset = "0x8319C8")]
			public float maxRootAngle;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831A44", Offset = "0x831A44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831A44", Offset = "0x831A44")]
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

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B70", Offset = "0x831B70")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x831B70", Offset = "0x831B70")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x831BAC", Offset = "0x831BAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831BAC", Offset = "0x831BAC")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

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
				[Token(Token = "0x60004C7")]
				[Address(RVA = "0x1D9FF40", Offset = "0x1D9FF40", VA = "0x1D9FF40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x60004C8")]
				[Address(RVA = "0x1DA04E8", Offset = "0x1DA04E8", VA = "0x1DA04E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			internal VirtualBone chest
			{
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0x1DA0528", Offset = "0x1DA0528", VA = "0x1DA0528")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			internal VirtualBone head
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0x1D9FF80", Offset = "0x1D9FF80", VA = "0x1D9FF80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private VirtualBone neck
			{
				[Token(Token = "0x60004CB")]
				[Address(RVA = "0x1DA057C", Offset = "0x1DA057C", VA = "0x1DA057C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0x1DA05BC", Offset = "0x1DA05BC", VA = "0x1DA05BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83820C", Offset = "0x83820C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004CD")]
				[Address(RVA = "0x1DA05D0", Offset = "0x1DA05D0", VA = "0x1DA05D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83821C", Offset = "0x83821C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60004CE")]
				[Address(RVA = "0x1DA05E4", Offset = "0x1DA05E4", VA = "0x1DA05E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83822C", Offset = "0x83822C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004CF")]
				[Address(RVA = "0x1DA05F8", Offset = "0x1DA05F8", VA = "0x1DA05F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83823C", Offset = "0x83823C")]
				private set
				{
				}
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1DA060C", Offset = "0x1DA060C", VA = "0x1DA060C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1DA10F4", Offset = "0x1DA10F4", VA = "0x1DA10F4", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1DA14C8", Offset = "0x1DA14C8", VA = "0x1DA14C8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x1DA1914", Offset = "0x1DA1914", VA = "0x1DA1914")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1DA1D70", Offset = "0x1DA1D70", VA = "0x1DA1D70")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1DA2600", Offset = "0x1DA2600", VA = "0x1DA2600")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1DA2C88", Offset = "0x1DA2C88", VA = "0x1DA2C88")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x1DA3610", Offset = "0x1DA3610", VA = "0x1DA3610", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x1DA37EC", Offset = "0x1DA37EC", VA = "0x1DA37EC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x1DA1ACC", Offset = "0x1DA1ACC", VA = "0x1DA1ACC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1DA29D4", Offset = "0x1DA29D4", VA = "0x1DA29D4")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1DA22A4", Offset = "0x1DA22A4", VA = "0x1DA22A4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1DA3888", Offset = "0x1DA3888", VA = "0x1DA3888")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1DA2AB4", Offset = "0x1DA2AB4", VA = "0x1DA2AB4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1DA2780", Offset = "0x1DA2780", VA = "0x1DA2780")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1DA3BBC", Offset = "0x1DA3BBC", VA = "0x1DA3BBC")]
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

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1DA1058", Offset = "0x1DA1058", VA = "0x1DA1058")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1DA10D4", Offset = "0x1DA10D4", VA = "0x1DA10D4")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1DA3D54", Offset = "0x1DA3D54", VA = "0x1DA3D54")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1DA3ED8", Offset = "0x1DA3ED8", VA = "0x1DA3ED8")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1DA3A94", Offset = "0x1DA3A94", VA = "0x1DA3A94")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1DA40C8", Offset = "0x1DA40C8", VA = "0x1DA40C8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1DA4228", Offset = "0x1DA4228", VA = "0x1DA4228")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1DA4364", Offset = "0x1DA4364", VA = "0x1DA4364")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1DA320C", Offset = "0x1DA320C", VA = "0x1DA320C")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1DA441C", Offset = "0x1DA441C", VA = "0x1DA441C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1DA2E7C", Offset = "0x1DA2E7C", VA = "0x1DA2E7C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1DA4584", Offset = "0x1DA4584", VA = "0x1DA4584")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x1DA45F4", Offset = "0x1DA45F4", VA = "0x1DA45F4")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82E970", Offset = "0x82E970")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E970", Offset = "0x82E970")]
		private Animator <animator>k__BackingField;

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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82E9AC", Offset = "0x82E9AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82E9AC", Offset = "0x82E9AC")]
		public int LOD;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EA00", Offset = "0x82EA00")]
		public float scale;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EA38", Offset = "0x82EA38")]
		public bool plantFeet;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EA70", Offset = "0x82EA70")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x82EA70", Offset = "0x82EA70")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EAAC", Offset = "0x82EAAC")]
		public Spine spine;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EAE4", Offset = "0x82EAE4")]
		public Arm leftArm;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EB1C", Offset = "0x82EB1C")]
		public Arm rightArm;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EB54", Offset = "0x82EB54")]
		public Leg leftLeg;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EB8C", Offset = "0x82EB8C")]
		public Leg rightLeg;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82EBC4", Offset = "0x82EBC4")]
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
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1E6663C", Offset = "0x1E6663C", VA = "0x1E6663C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83804C", Offset = "0x83804C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1E66644", Offset = "0x1E66644", VA = "0x1E66644")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83805C", Offset = "0x83805C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1E6A0D4", Offset = "0x1E6A0D4", VA = "0x1E6A0D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83806C", Offset = "0x83806C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1E6A0DC", Offset = "0x1E6A0DC", VA = "0x1E6A0DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83807C", Offset = "0x83807C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1E6664C", Offset = "0x1E6664C", VA = "0x1E6664C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1E66B6C", Offset = "0x1E66B6C", VA = "0x1E66B6C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1E669F8", Offset = "0x1E669F8", VA = "0x1E669F8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1E66ED0", Offset = "0x1E66ED0", VA = "0x1E66ED0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1E67018", Offset = "0x1E67018", VA = "0x1E67018")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1E67048", Offset = "0x1E67048", VA = "0x1E67048")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1E670F8", Offset = "0x1E670F8", VA = "0x1E670F8")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1E671E0", Offset = "0x1E671E0", VA = "0x1E671E0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1E679C0", Offset = "0x1E679C0", VA = "0x1E679C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1E67B30", Offset = "0x1E67B30", VA = "0x1E67B30", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1E67D34", Offset = "0x1E67D34", VA = "0x1E67D34", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1E67DB0", Offset = "0x1E67DB0", VA = "0x1E67DB0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1E67E2C", Offset = "0x1E67E2C", VA = "0x1E67E2C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1E68010", Offset = "0x1E68010", VA = "0x1E68010")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1E66DB0", Offset = "0x1E66DB0", VA = "0x1E66DB0")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1E672DC", Offset = "0x1E672DC", VA = "0x1E672DC")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1E681D0", Offset = "0x1E681D0", VA = "0x1E681D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1E68220", Offset = "0x1E68220", VA = "0x1E68220", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1E697BC", Offset = "0x1E697BC", VA = "0x1E697BC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1E67440", Offset = "0x1E67440", VA = "0x1E67440")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1E685A4", Offset = "0x1E685A4", VA = "0x1E685A4")]
		private void Solve()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1E69BA0", Offset = "0x1E69BA0", VA = "0x1E69BA0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1E69BE8", Offset = "0x1E69BE8", VA = "0x1E69BE8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1E69664", Offset = "0x1E69664", VA = "0x1E69664")]
		private void Write()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1E69C2C", Offset = "0x1E69C2C", VA = "0x1E69C2C")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1E6A0E4", Offset = "0x1E6A0E4", VA = "0x1E6A0E4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831BE8", Offset = "0x831BE8")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x17EF608", Offset = "0x17EF608", VA = "0x17EF608")]
		public void Start()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x17EFDB0", Offset = "0x17EFDB0", VA = "0x17EFDB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x17EFF44", Offset = "0x17EFF44", VA = "0x17EFF44")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x17F04B4", Offset = "0x17F04B4", VA = "0x17F04B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x17F0578", Offset = "0x17F0578", VA = "0x17F0578")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x17F06B4", Offset = "0x17F06B4", VA = "0x17F06B4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831C20", Offset = "0x831C20")]
		public Transform transform;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831C58", Offset = "0x831C58")]
		public Transform parent;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831C90", Offset = "0x831C90")]
		public Transform[] children;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831CC8", Offset = "0x831CC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831CC8", Offset = "0x831CC8")]
		public float weight;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831D1C", Offset = "0x831D1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831D1C", Offset = "0x831D1C")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x831D70", Offset = "0x831D70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831D70", Offset = "0x831D70")]
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

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x17F071C", Offset = "0x17F071C", VA = "0x17F071C")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x17F07D0", Offset = "0x17F07D0", VA = "0x17F07D0")]
		public TwistSolver(Transform t)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x17EF808", Offset = "0x17EF808", VA = "0x17EF808")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x17EFE84", Offset = "0x17EFE84", VA = "0x17EFE84")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x17F0008", Offset = "0x17F0008", VA = "0x17F0008")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class InteractionEffector
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831DCC", Offset = "0x831DCC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x831DCC", Offset = "0x831DCC")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x831E08", Offset = "0x831E08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E08", Offset = "0x831E08")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x831E44", Offset = "0x831E44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E44", Offset = "0x831E44")]
		private InteractionObject <interactionObject>k__BackingField;

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
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1DE7C0C", Offset = "0x1DE7C0C", VA = "0x1DE7C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83824C", Offset = "0x83824C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1DE7C14", Offset = "0x1DE7C14", VA = "0x1DE7C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83825C", Offset = "0x83825C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool isPaused
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1DE7C1C", Offset = "0x1DE7C1C", VA = "0x1DE7C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83826C", Offset = "0x83826C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1DE7C24", Offset = "0x1DE7C24", VA = "0x1DE7C24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83827C", Offset = "0x83827C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1DE7C30", Offset = "0x1DE7C30", VA = "0x1DE7C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83828C", Offset = "0x83828C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1DE7C38", Offset = "0x1DE7C38", VA = "0x1DE7C38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83829C", Offset = "0x83829C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool inInteraction
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1DE7C40", Offset = "0x1DE7C40", VA = "0x1DE7C40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public float progress
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1DEA468", Offset = "0x1DEA468", VA = "0x1DEA468")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1DE7CAC", Offset = "0x1DE7CAC", VA = "0x1DE7CAC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1DE7D44", Offset = "0x1DE7D44", VA = "0x1DE7D44")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1DE7E04", Offset = "0x1DE7E04", VA = "0x1DE7E04")]
		public void StoreDefaults()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1DE8020", Offset = "0x1DE8020", VA = "0x1DE8020")]
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1DE8368", Offset = "0x1DE8368", VA = "0x1DE8368")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1DE8424", Offset = "0x1DE8424", VA = "0x1DE8424")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1DE847C", Offset = "0x1DE847C", VA = "0x1DE847C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1DE86C4", Offset = "0x1DE86C4", VA = "0x1DE86C4")]
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1DE912C", Offset = "0x1DE912C", VA = "0x1DE912C")]
		public void Update(Transform root, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1DE9C60", Offset = "0x1DE9C60", VA = "0x1DE9C60")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1DE9EA4", Offset = "0x1DE9EA4", VA = "0x1DE9EA4")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1DEA344", Offset = "0x1DEA344", VA = "0x1DEA344")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1DEA5C8", Offset = "0x1DEA5C8", VA = "0x1DEA5C8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831E80", Offset = "0x831E80")]
		public LookAtIK ik;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831EB8", Offset = "0x831EB8")]
		public float lerpSpeed;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831EF0", Offset = "0x831EF0")]
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

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1DEA7EC", Offset = "0x1DEA7EC", VA = "0x1DEA7EC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1DEA920", Offset = "0x1DEA920", VA = "0x1DEA920")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1DEA9C4", Offset = "0x1DEA9C4", VA = "0x1DEA9C4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1DEB00C", Offset = "0x1DEB00C", VA = "0x1DEB00C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1DEB100", Offset = "0x1DEB100", VA = "0x1DEB100")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1DEB1C8", Offset = "0x1DEB1C8", VA = "0x1DEB1C8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B234", Offset = "0x82B234")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B234", Offset = "0x82B234")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public class InteractionEvent
		{
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832058", Offset = "0x832058")]
			public float time;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832090", Offset = "0x832090")]
			public bool pause;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8320C8", Offset = "0x8320C8")]
			public bool pickUp;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832100", Offset = "0x832100")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832138", Offset = "0x832138")]
			public Message[] messages;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832170", Offset = "0x832170")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1DA4DA0", Offset = "0x1DA4DA0", VA = "0x1DA4DA0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1DA4F74", Offset = "0x1DA4F74", VA = "0x1DA4F74")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8321A8", Offset = "0x8321A8")]
			public string function;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8321E0", Offset = "0x8321E0")]
			public GameObject recipient;

			[Token(Token = "0x40004CB")]
			private const string empty = "";

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x1DA4E70", Offset = "0x1DA4E70", VA = "0x1DA4E70")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1DA4F7C", Offset = "0x1DA4F7C", VA = "0x1DA4F7C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832218", Offset = "0x832218")]
			public Animator animator;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832250", Offset = "0x832250")]
			public Animation animation;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832288", Offset = "0x832288")]
			public string animationState;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8322C0", Offset = "0x8322C0")]
			public float crossfadeTime;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8322F8", Offset = "0x8322F8")]
			public int layer;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832330", Offset = "0x832330")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40004D2")]
			private const string empty = "";

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1DA4B0C", Offset = "0x1DA4B0C", VA = "0x1DA4B0C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1DA4BFC", Offset = "0x1DA4BFC", VA = "0x1DA4BFC")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1DA4CB0", Offset = "0x1DA4CB0", VA = "0x1DA4CB0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1DA4D8C", Offset = "0x1DA4D8C", VA = "0x1DA4D8C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832368", Offset = "0x832368")]
			public Type type;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8323A0", Offset = "0x8323A0")]
			public AnimationCurve curve;

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x1DA4FC0", Offset = "0x1DA4FC0", VA = "0x1DA4FC0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1DA4FEC", Offset = "0x1DA4FEC", VA = "0x1DA4FEC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8323D8", Offset = "0x8323D8")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832410", Offset = "0x832410")]
			public float multiplier;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832448", Offset = "0x832448")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1DA4F84", Offset = "0x1DA4F84", VA = "0x1DA4F84")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1DA4FDC", Offset = "0x1DA4FDC", VA = "0x1DA4FDC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831F38", Offset = "0x831F38")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831F70", Offset = "0x831F70")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831FA8", Offset = "0x831FA8")]
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

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831FE0", Offset = "0x831FE0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x831FE0", Offset = "0x831FE0")]
		private float <length>k__BackingField;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83201C", Offset = "0x83201C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x83201C", Offset = "0x83201C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000092")]
		public float length
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x1DEB41C", Offset = "0x1DEB41C", VA = "0x1DEB41C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83846C", Offset = "0x83846C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x1DEB424", Offset = "0x1DEB424", VA = "0x1DEB424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83847C", Offset = "0x83847C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x1DEB42C", Offset = "0x1DEB42C", VA = "0x1DEB42C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83848C", Offset = "0x83848C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x1DEB434", Offset = "0x1DEB434", VA = "0x1DEB434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83849C", Offset = "0x83849C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1DEB604", Offset = "0x1DEB604", VA = "0x1DEB604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x1DEA4A4", Offset = "0x1DEA4A4", VA = "0x1DEA4A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1DEB1DC", Offset = "0x1DEB1DC", VA = "0x1DEB1DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8382AC", Offset = "0x8382AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1DEB224", Offset = "0x1DEB224", VA = "0x1DEB224")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8382E4", Offset = "0x8382E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1DEB26C", Offset = "0x1DEB26C", VA = "0x1DEB26C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83831C", Offset = "0x83831C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1DEB2B4", Offset = "0x1DEB2B4", VA = "0x1DEB2B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838354", Offset = "0x838354")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1DEB2FC", Offset = "0x1DEB2FC", VA = "0x1DEB2FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83838C", Offset = "0x83838C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1DEB344", Offset = "0x1DEB344", VA = "0x1DEB344")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8383C4", Offset = "0x8383C4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1DEB38C", Offset = "0x1DEB38C", VA = "0x1DEB38C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8383FC", Offset = "0x8383FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1DEB3D4", Offset = "0x1DEB3D4", VA = "0x1DEB3D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838434", Offset = "0x838434")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1DEB43C", Offset = "0x1DEB43C", VA = "0x1DEB43C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1DEB690", Offset = "0x1DEB690", VA = "0x1DEB690")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1DE8B4C", Offset = "0x1DE8B4C", VA = "0x1DE8B4C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1DEB804", Offset = "0x1DEB804", VA = "0x1DEB804")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1DE8580", Offset = "0x1DE8580", VA = "0x1DE8580")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1DE8B44", Offset = "0x1DE8B44", VA = "0x1DE8B44")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1DE97B4", Offset = "0x1DE97B4", VA = "0x1DE97B4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight, bool isPaused)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1DEA124", Offset = "0x1DEA124", VA = "0x1DEA124")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1DEBDCC", Offset = "0x1DEBDCC", VA = "0x1DEBDCC")]
		private void Start()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1DEB8EC", Offset = "0x1DEB8EC", VA = "0x1DEB8EC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1DEB80C", Offset = "0x1DEB80C", VA = "0x1DEB80C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1DEBD64", Offset = "0x1DEBD64", VA = "0x1DEBD64")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1DEBDD0", Offset = "0x1DEBDD0", VA = "0x1DEBDD0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1DEBE38", Offset = "0x1DEBE38", VA = "0x1DEBE38")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B294", Offset = "0x82B294")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B294", Offset = "0x82B294")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200009C")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832480", Offset = "0x832480")]
		public string targetTag;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8324B8", Offset = "0x8324B8")]
		public float fadeInTime;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8324F0", Offset = "0x8324F0")]
		public float speed;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832528", Offset = "0x832528")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x832560", Offset = "0x832560")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832560", Offset = "0x832560")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x832560", Offset = "0x832560")]
		public Collider characterCollider;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8325E4", Offset = "0x8325E4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8325E4", Offset = "0x8325E4")]
		public Transform FPSCamera;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832644", Offset = "0x832644")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83267C", Offset = "0x83267C")]
		public float camRaycastDistance;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8326B4", Offset = "0x8326B4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8326B4", Offset = "0x8326B4")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8326F0", Offset = "0x8326F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8326F0", Offset = "0x8326F0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832750", Offset = "0x832750")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832788", Offset = "0x832788")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x832788", Offset = "0x832788")]
		private bool <initiated>k__BackingField;

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
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x1DE7AE0", Offset = "0x1DE7AE0", VA = "0x1DE7AE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x1DE73DC", Offset = "0x1DE73DC", VA = "0x1DE73DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1DEDFCC", Offset = "0x1DEDFCC", VA = "0x1DEDFCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1DEDFD4", Offset = "0x1DEDFD4", VA = "0x1DEDFD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83866C", Offset = "0x83866C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x1DEDFDC", Offset = "0x1DEDFDC", VA = "0x1DEDFDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83867C", Offset = "0x83867C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool initiated
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x1DEDFE4", Offset = "0x1DEDFE4", VA = "0x1DEDFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83868C", Offset = "0x83868C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1DEDFEC", Offset = "0x1DEDFEC", VA = "0x1DEDFEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83869C", Offset = "0x83869C")]
			private set
			{
			}
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1DEBEA0", Offset = "0x1DEBEA0", VA = "0x1DEBEA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8384AC", Offset = "0x8384AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1DEBEE8", Offset = "0x1DEBEE8", VA = "0x1DEBEE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8384E4", Offset = "0x8384E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1DEBF30", Offset = "0x1DEBF30", VA = "0x1DEBF30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83851C", Offset = "0x83851C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1DEBF78", Offset = "0x1DEBF78", VA = "0x1DEBF78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838554", Offset = "0x838554")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1DEBFC0", Offset = "0x1DEBFC0", VA = "0x1DEBFC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83858C", Offset = "0x83858C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1DEC008", Offset = "0x1DEC008", VA = "0x1DEC008")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8385C4", Offset = "0x8385C4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1DEC050", Offset = "0x1DEC050", VA = "0x1DEC050")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8385FC", Offset = "0x8385FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1DEC098", Offset = "0x1DEC098", VA = "0x1DEC098")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838634", Offset = "0x838634")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1DEC1D4", Offset = "0x1DEC1D4", VA = "0x1DEC1D4")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1DEC2A0", Offset = "0x1DEC2A0", VA = "0x1DEC2A0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1DEC36C", Offset = "0x1DEC36C", VA = "0x1DEC36C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1DEC418", Offset = "0x1DEC418", VA = "0x1DEC418")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1DE71B8", Offset = "0x1DE71B8", VA = "0x1DE71B8")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1DEC514", Offset = "0x1DEC514", VA = "0x1DEC514")]
		public bool StartInteractionWithClosestTarget(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1DEC674", Offset = "0x1DEC674", VA = "0x1DEC674")]
		private int GetClosestTargetIndex(FullBodyBipedEffector effectorType, InteractionObject obj)
		{
			return default(int);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1DEC7D0", Offset = "0x1DEC7D0", VA = "0x1DEC7D0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1DEC8EC", Offset = "0x1DEC8EC", VA = "0x1DEC8EC")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1DEC97C", Offset = "0x1DEC97C", VA = "0x1DEC97C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1DECA0C", Offset = "0x1DECA0C", VA = "0x1DECA0C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1DECA9C", Offset = "0x1DECA9C", VA = "0x1DECA9C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1DE7B90", Offset = "0x1DE7B90", VA = "0x1DE7B90")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1DECB10", Offset = "0x1DECB10", VA = "0x1DECB10")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1DECB78", Offset = "0x1DECB78", VA = "0x1DECB78")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1DECC04", Offset = "0x1DECC04", VA = "0x1DECC04")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1DECCB8", Offset = "0x1DECCB8", VA = "0x1DECCB8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1DECD98", Offset = "0x1DECD98", VA = "0x1DECD98")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1DED070", Offset = "0x1DED070", VA = "0x1DED070")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1DED268", Offset = "0x1DED268", VA = "0x1DED268")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1DED50C", Offset = "0x1DED50C", VA = "0x1DED50C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1DED7E0", Offset = "0x1DED7E0", VA = "0x1DED7E0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1DED824", Offset = "0x1DED824", VA = "0x1DED824")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1DED89C", Offset = "0x1DED89C", VA = "0x1DED89C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1DED9D0", Offset = "0x1DED9D0", VA = "0x1DED9D0")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1DEDB74", Offset = "0x1DEDB74", VA = "0x1DEDB74")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1DEDE18", Offset = "0x1DEDE18", VA = "0x1DEDE18")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1DED61C", Offset = "0x1DED61C", VA = "0x1DED61C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1DEDF64", Offset = "0x1DEDF64", VA = "0x1DEDF64")]
		public void StoreDefaults()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1DEDFF8", Offset = "0x1DEDFF8", VA = "0x1DEDFF8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1DEE820", Offset = "0x1DEE820", VA = "0x1DEE820")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1DEE840", Offset = "0x1DEE840", VA = "0x1DEE840")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1DEE85C", Offset = "0x1DEE85C", VA = "0x1DEE85C")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1DEE878", Offset = "0x1DEE878", VA = "0x1DEE878")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1DEE8D8", Offset = "0x1DEE8D8", VA = "0x1DEE8D8")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1DEEA14", Offset = "0x1DEEA14", VA = "0x1DEEA14")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1DEEB24", Offset = "0x1DEEB24", VA = "0x1DEEB24")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1DEEEC8", Offset = "0x1DEEEC8", VA = "0x1DEEEC8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1DEEFF4", Offset = "0x1DEEFF4", VA = "0x1DEEFF4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1DEF250", Offset = "0x1DEF250", VA = "0x1DEF250")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1DEE56C", Offset = "0x1DEE56C", VA = "0x1DEE56C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1DEF38C", Offset = "0x1DEF38C", VA = "0x1DEF38C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1DEF3B4", Offset = "0x1DEF3B4", VA = "0x1DEF3B4")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1DEF50C", Offset = "0x1DEF50C", VA = "0x1DEF50C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1DEF5A0", Offset = "0x1DEF5A0", VA = "0x1DEF5A0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1DEF674", Offset = "0x1DEF674", VA = "0x1DEF674")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1DEF68C", Offset = "0x1DEF68C", VA = "0x1DEF68C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1DEC0E0", Offset = "0x1DEC0E0", VA = "0x1DEC0E0")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1DECF40", Offset = "0x1DECF40", VA = "0x1DECF40")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1DEFA88", Offset = "0x1DEFA88", VA = "0x1DEFA88")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B2F4", Offset = "0x82B2F4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B2F4", Offset = "0x82B2F4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832A48", Offset = "0x832A48")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832A80", Offset = "0x832A80")]
			public float multiplier;

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1DA5720", Offset = "0x1DA5720", VA = "0x1DA5720")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8327C4", Offset = "0x8327C4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8327FC", Offset = "0x8327FC")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832834", Offset = "0x832834")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83286C", Offset = "0x83286C")]
		public Transform pivot;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8328A4", Offset = "0x8328A4")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8328DC", Offset = "0x8328DC")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832914", Offset = "0x832914")]
		public float twistWeight;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83294C", Offset = "0x83294C")]
		public float swingWeight;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x832984", Offset = "0x832984")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832984", Offset = "0x832984")]
		public float threeDOFWeight;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8329D8", Offset = "0x8329D8")]
		public bool rotateOnce;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832A10", Offset = "0x832A10")]
		public bool usePoser;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1DF026C", Offset = "0x1DF026C", VA = "0x1DF026C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8386AC", Offset = "0x8386AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1DF02B4", Offset = "0x1DF02B4", VA = "0x1DF02B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8386E4", Offset = "0x8386E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1DF02FC", Offset = "0x1DF02FC", VA = "0x1DF02FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83871C", Offset = "0x83871C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1DF0344", Offset = "0x1DF0344", VA = "0x1DF0344")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838754", Offset = "0x838754")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1DF038C", Offset = "0x1DF038C", VA = "0x1DF038C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83878C", Offset = "0x83878C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1DF03D4", Offset = "0x1DF03D4", VA = "0x1DF03D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8387C4", Offset = "0x8387C4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1DF041C", Offset = "0x1DF041C", VA = "0x1DF041C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8387FC", Offset = "0x8387FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1DF0464", Offset = "0x1DF0464", VA = "0x1DF0464")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838834", Offset = "0x838834")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1DEB87C", Offset = "0x1DEB87C", VA = "0x1DEB87C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1DEA530", Offset = "0x1DEA530", VA = "0x1DEA530")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1DE8C00", Offset = "0x1DE8C00", VA = "0x1DE8C00")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1DF04AC", Offset = "0x1DF04AC", VA = "0x1DF04AC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B354", Offset = "0x82B354")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B354", Offset = "0x82B354")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832AF0", Offset = "0x832AF0")]
			public bool use;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832B28", Offset = "0x832B28")]
			public Vector2 offset;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832B60", Offset = "0x832B60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x832B60", Offset = "0x832B60")]
			public float angleOffset;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832BBC", Offset = "0x832BBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x832BBC", Offset = "0x832BBC")]
			public float maxAngle;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832C14", Offset = "0x832C14")]
			public float radius;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832C4C", Offset = "0x832C4C")]
			public bool orbit;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832C84", Offset = "0x832C84")]
			public bool fixYAxis;

			[Token(Token = "0x1700009A")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0x1DA5A90", Offset = "0x1DA5A90", VA = "0x1DA5A90")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000599")]
				[Address(RVA = "0x1DA5A9C", Offset = "0x1DA5A9C", VA = "0x1DA5A9C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1DA5B24", Offset = "0x1DA5B24", VA = "0x1DA5B24")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1DA5F68", Offset = "0x1DA5F68", VA = "0x1DA5F68")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832CBC", Offset = "0x832CBC")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832CF4", Offset = "0x832CF4")]
			public Vector3 direction;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832D2C", Offset = "0x832D2C")]
			public float maxDistance;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x832D64", Offset = "0x832D64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832D64", Offset = "0x832D64")]
			public float maxAngle;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832DBC", Offset = "0x832DBC")]
			public bool fixYAxis;

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1DA5728", Offset = "0x1DA5728", VA = "0x1DA5728")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x1DA581C", Offset = "0x1DA581C", VA = "0x1DA581C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1DA5A44", Offset = "0x1DA5A44", VA = "0x1DA5A44")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832EBC", Offset = "0x832EBC")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000523")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832EF4", Offset = "0x832EF4")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60005A1")]
				[Address(RVA = "0x20C8398", Offset = "0x20C8398", VA = "0x20C8398")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832E14", Offset = "0x832E14")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832E4C", Offset = "0x832E4C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832E84", Offset = "0x832E84")]
			public Interaction[] interactions;

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x1DA5F7C", Offset = "0x1DA5F7C", VA = "0x1DA5F7C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1DA6030", Offset = "0x1DA6030", VA = "0x1DA6030")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832AB8", Offset = "0x832AB8")]
		public Range[] ranges;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1DF04F8", Offset = "0x1DF04F8", VA = "0x1DF04F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83886C", Offset = "0x83886C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1DF0540", Offset = "0x1DF0540", VA = "0x1DF0540")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8388A4", Offset = "0x8388A4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1DF0588", Offset = "0x1DF0588", VA = "0x1DF0588")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8388DC", Offset = "0x8388DC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1DF05D0", Offset = "0x1DF05D0", VA = "0x1DF05D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838914", Offset = "0x838914")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1DF0618", Offset = "0x1DF0618", VA = "0x1DF0618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x83894C", Offset = "0x83894C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1DEECF4", Offset = "0x1DEECF4", VA = "0x1DEECF4")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1DF0660", Offset = "0x1DF0660", VA = "0x1DF0660")]
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

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1517398", Offset = "0x1517398", VA = "0x1517398")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x15173F0", Offset = "0x15173F0", VA = "0x15173F0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x1517440", Offset = "0x1517440", VA = "0x1517440")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x151748C", Offset = "0x151748C", VA = "0x151748C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1E1AA04", Offset = "0x1E1AA04", VA = "0x1E1AA04", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838984", Offset = "0x838984")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1E1AD94", Offset = "0x1E1AD94", VA = "0x1E1AD94", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1E1AD98", Offset = "0x1E1AD98", VA = "0x1E1AD98", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1E1AEA0", Offset = "0x1E1AEA0", VA = "0x1E1AEA0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1E1AD28", Offset = "0x1E1AD28", VA = "0x1E1AD28")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1E1AC88", Offset = "0x1E1AC88", VA = "0x1E1AC88")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1E1AF0C", Offset = "0x1E1AF0C", VA = "0x1E1AF0C")]
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

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1E21888", Offset = "0x1E21888", VA = "0x1E21888", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1E21964", Offset = "0x1E21964", VA = "0x1E21964", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1E21B4C", Offset = "0x1E21B4C", VA = "0x1E21B4C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1E21C48", Offset = "0x1E21C48", VA = "0x1E21C48", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1E219C8", Offset = "0x1E219C8", VA = "0x1E219C8")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1E21FA8", Offset = "0x1E21FA8", VA = "0x1E21FA8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x832F2C", Offset = "0x832F2C")]
		public float weight;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x832F44", Offset = "0x832F44")]
		public float localRotationWeight;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x832F5C", Offset = "0x832F5C")]
		public float localPositionWeight;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60005B3")]
		public abstract void AutoMapping();

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x17E6DDC", Offset = "0x17E6DDC", VA = "0x17E6DDC")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60005B5")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60005B6")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60005B7")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x17E6DE8", Offset = "0x17E6DE8", VA = "0x17E6DE8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x17E6E3C", Offset = "0x17E6E3C", VA = "0x17E6E3C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x17E6E78", Offset = "0x17E6E78", VA = "0x17E6E78", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x17E6E90", Offset = "0x17E6E90", VA = "0x17E6E90")]
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

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1DA8184", Offset = "0x1DA8184", VA = "0x1DA8184")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1DA8348", Offset = "0x1DA8348", VA = "0x1DA8348")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1DA8428", Offset = "0x1DA8428", VA = "0x1DA8428")]
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

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1DA7F7C", Offset = "0x1DA7F7C", VA = "0x1DA7F7C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1DA7FF4", Offset = "0x1DA7FF4", VA = "0x1DA7FF4")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1DA8134", Offset = "0x1DA8134", VA = "0x1DA8134")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B3B4", Offset = "0x82B3B4")]
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

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__1;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <i>5__2;

			[Token(Token = "0x1700009E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x1DA7F2C", Offset = "0x1DA7F2C", VA = "0x1DA7F2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x1DA7F74", Offset = "0x1DA7F74", VA = "0x1DA7F74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1DA7CAC", Offset = "0x1DA7CAC", VA = "0x1DA7CAC")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1DA7CD8", Offset = "0x1DA7CD8", VA = "0x1DA7CD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x1DA7CDC", Offset = "0x1DA7CDC", VA = "0x1DA7CDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x1DA7F34", Offset = "0x1DA7F34", VA = "0x1DA7F34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832F74", Offset = "0x832F74")]
		public IK ik;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832FAC", Offset = "0x832FAC")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x832FE4", Offset = "0x832FE4")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83301C", Offset = "0x83301C")]
		public float applyVelocity;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833054", Offset = "0x833054")]
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
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x17E7E5C", Offset = "0x17E7E5C", VA = "0x17E7E5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		private bool ikUsed
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x17E8890", Offset = "0x17E8890", VA = "0x17E8890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x17E7E24", Offset = "0x17E7E24", VA = "0x17E7E24")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x17E7ED4", Offset = "0x17E7ED4", VA = "0x17E7ED4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x17E8010", Offset = "0x17E8010", VA = "0x17E8010")]
		public void Start()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x17E7F98", Offset = "0x17E7F98", VA = "0x17E7F98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8389BC", Offset = "0x8389BC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x17E84CC", Offset = "0x17E84CC", VA = "0x17E84CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x17E8718", Offset = "0x17E8718", VA = "0x17E8718")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x17E87D4", Offset = "0x17E87D4", VA = "0x17E87D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x17E8A10", Offset = "0x17E8A10", VA = "0x17E8A10")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x17E8854", Offset = "0x17E8854", VA = "0x17E8854")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x17E89CC", Offset = "0x17E89CC", VA = "0x17E89CC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x17E8AB0", Offset = "0x17E8AB0", VA = "0x17E8AB0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x17E8A44", Offset = "0x17E8A44", VA = "0x17E8A44")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x17E7F2C", Offset = "0x17E7F2C", VA = "0x17E7F2C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x17E8758", Offset = "0x17E8758", VA = "0x17E8758")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x17E8CDC", Offset = "0x17E8CDC", VA = "0x17E8CDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x17E8E18", Offset = "0x17E8E18", VA = "0x17E8E18")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x83309C", Offset = "0x83309C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83309C", Offset = "0x83309C")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000A0")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x17EA754", Offset = "0x17EA754", VA = "0x17EA754")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A1")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x17EA760", Offset = "0x17EA760", VA = "0x17EA760")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A2")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x17EA77C", Offset = "0x17EA77C", VA = "0x17EA77C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A6C", Offset = "0x838A6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x17EA784", Offset = "0x17EA784", VA = "0x17EA784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A7C", Offset = "0x838A7C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x17EA454", Offset = "0x17EA454", VA = "0x17EA454")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x17EA49C", Offset = "0x17EA49C", VA = "0x17EA49C")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x17EA4B4", Offset = "0x17EA4B4", VA = "0x17EA4B4")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x17EA6AC", Offset = "0x17EA6AC", VA = "0x17EA6AC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x17EA71C", Offset = "0x17EA71C", VA = "0x17EA71C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005E3")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x17EA5D4", Offset = "0x17EA5D4", VA = "0x17EA5D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x17EA790", Offset = "0x17EA790", VA = "0x17EA790")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x17EA794", Offset = "0x17EA794", VA = "0x17EA794")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x17EA7C8", Offset = "0x17EA7C8", VA = "0x17EA7C8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x17EA844", Offset = "0x17EA844", VA = "0x17EA844")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x17EA9D8", Offset = "0x17EA9D8", VA = "0x17EA9D8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x17EAA48", Offset = "0x17EAA48", VA = "0x17EAA48")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B3C4", Offset = "0x82B3C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B3C4", Offset = "0x82B3C4")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8330D8", Offset = "0x8330D8")]
		public float limit;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8330F4", Offset = "0x8330F4")]
		public float twistLimit;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x17EAA7C", Offset = "0x17EAA7C", VA = "0x17EAA7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838A8C", Offset = "0x838A8C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x17EAAC4", Offset = "0x17EAAC4", VA = "0x17EAAC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838AC4", Offset = "0x838AC4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x17EAB0C", Offset = "0x17EAB0C", VA = "0x17EAB0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838AFC", Offset = "0x838AFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x17EAB54", Offset = "0x17EAB54", VA = "0x17EAB54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838B34", Offset = "0x838B34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x17EAB9C", Offset = "0x17EAB9C", VA = "0x17EAB9C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x17EABE0", Offset = "0x17EABE0", VA = "0x17EABE0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x17EADA0", Offset = "0x17EADA0", VA = "0x17EADA0")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B424", Offset = "0x82B424")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B424", Offset = "0x82B424")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x17EADE0", Offset = "0x17EADE0", VA = "0x17EADE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838B6C", Offset = "0x838B6C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x17EAE28", Offset = "0x17EAE28", VA = "0x17EAE28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838BA4", Offset = "0x838BA4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x17EAE70", Offset = "0x17EAE70", VA = "0x17EAE70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838BDC", Offset = "0x838BDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x17EAEB8", Offset = "0x17EAEB8", VA = "0x17EAEB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838C14", Offset = "0x838C14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x17EAF00", Offset = "0x17EAF00", VA = "0x17EAF00", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x17EAF04", Offset = "0x17EAF04", VA = "0x17EAF04")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x17EB09C", Offset = "0x17EB09C", VA = "0x17EB09C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B484", Offset = "0x82B484")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B484", Offset = "0x82B484")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class ReachCone
		{
			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000A3")]
			public Vector3 o
			{
				[Token(Token = "0x6000609")]
				[Address(RVA = "0x1DA8ABC", Offset = "0x1DA8ABC", VA = "0x1DA8ABC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 a
			{
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x1DA8AF4", Offset = "0x1DA8AF4", VA = "0x1DA8AF4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A5")]
			public Vector3 b
			{
				[Token(Token = "0x600060B")]
				[Address(RVA = "0x1DA8B30", Offset = "0x1DA8B30", VA = "0x1DA8B30")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 c
			{
				[Token(Token = "0x600060C")]
				[Address(RVA = "0x1DA8B6C", Offset = "0x1DA8B6C", VA = "0x1DA8B6C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A7")]
			public bool isValid
			{
				[Token(Token = "0x600060E")]
				[Address(RVA = "0x1DA8CF8", Offset = "0x1DA8CF8", VA = "0x1DA8CF8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1DA8BA8", Offset = "0x1DA8BA8", VA = "0x1DA8BA8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1DA8D08", Offset = "0x1DA8D08", VA = "0x1DA8D08")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		public class LimitPoint
		{
			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1DA8A80", Offset = "0x1DA8A80", VA = "0x1DA8A80")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x833120", Offset = "0x833120")]
		public float twistLimit;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83313C", Offset = "0x83313C")]
		public int smoothIterations;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x17EB0E4", Offset = "0x17EB0E4", VA = "0x17EB0E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838C4C", Offset = "0x838C4C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x17EB12C", Offset = "0x17EB12C", VA = "0x17EB12C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838C84", Offset = "0x838C84")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x17EB174", Offset = "0x17EB174", VA = "0x17EB174")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838CBC", Offset = "0x838CBC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x17EB1BC", Offset = "0x17EB1BC", VA = "0x17EB1BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838CF4", Offset = "0x838CF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x17EB204", Offset = "0x17EB204", VA = "0x17EB204")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x17EB700", Offset = "0x17EB700", VA = "0x17EB700", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x17EB794", Offset = "0x17EB794", VA = "0x17EB794")]
		private void Start()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x17EBD08", Offset = "0x17EBD08", VA = "0x17EBD08")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x17EB2AC", Offset = "0x17EB2AC", VA = "0x17EB2AC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x17EC0B4", Offset = "0x17EC0B4", VA = "0x17EC0B4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x17EC4C0", Offset = "0x17EC4C0", VA = "0x17EC4C0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x17EC504", Offset = "0x17EC504", VA = "0x17EC504")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x17EC564", Offset = "0x17EC564", VA = "0x17EC564")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x17EBA98", Offset = "0x17EBA98", VA = "0x17EBA98")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x17EC5D0", Offset = "0x17EC5D0", VA = "0x17EC5D0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x17EC6AC", Offset = "0x17EC6AC", VA = "0x17EC6AC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x82B4E4", Offset = "0x82B4E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B4E4", Offset = "0x82B4E4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x833184", Offset = "0x833184")]
		public float twistLimit;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x17EC72C", Offset = "0x17EC72C", VA = "0x17EC72C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838D2C", Offset = "0x838D2C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x17EC774", Offset = "0x17EC774", VA = "0x17EC774")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838D64", Offset = "0x838D64")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x17EC7BC", Offset = "0x17EC7BC", VA = "0x17EC7BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838D9C", Offset = "0x838D9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x17EC804", Offset = "0x17EC804", VA = "0x17EC804")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x838DD4", Offset = "0x838DD4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x17EC84C", Offset = "0x17EC84C", VA = "0x17EC84C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x17EC868", Offset = "0x17EC868", VA = "0x17EC868", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x17EC8AC", Offset = "0x17EC8AC", VA = "0x17EC8AC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x17ECAD0", Offset = "0x17ECAD0", VA = "0x17ECAD0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B544", Offset = "0x82B544")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000623")]
				[Address(RVA = "0x1512B58", Offset = "0x1512B58", VA = "0x1512B58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000625")]
				[Address(RVA = "0x1512BA0", Offset = "0x1512BA0", VA = "0x1512BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x1512A3C", Offset = "0x1512A3C", VA = "0x1512A3C")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1512A68", Offset = "0x1512A68", VA = "0x1512A68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1512A6C", Offset = "0x1512A6C", VA = "0x1512A6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1512B60", Offset = "0x1512B60", VA = "0x1512B60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8331B0", Offset = "0x8331B0")]
		public AimIK ik;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8331E8", Offset = "0x8331E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8331E8", Offset = "0x8331E8")]
		public float weight;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83323C", Offset = "0x83323C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83323C", Offset = "0x83323C")]
		public Transform target;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83329C", Offset = "0x83329C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8332D4", Offset = "0x8332D4")]
		public float weightSmoothTime;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83330C", Offset = "0x83330C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83330C", Offset = "0x83330C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83336C", Offset = "0x83336C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8333A4", Offset = "0x8333A4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8333DC", Offset = "0x8333DC")]
		public float slerpSpeed;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833414", Offset = "0x833414")]
		public float smoothDampTime;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83344C", Offset = "0x83344C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833484", Offset = "0x833484")]
		public float minDistance;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8334BC", Offset = "0x8334BC")]
		public Vector3 offset;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8334F4", Offset = "0x8334F4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8334F4", Offset = "0x8334F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8334F4", Offset = "0x8334F4")]
		public float maxRootAngle;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833570", Offset = "0x833570")]
		public bool turnToTarget;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8335A8", Offset = "0x8335A8")]
		public float turnToTargetTime;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8335E0", Offset = "0x8335E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8335E0", Offset = "0x8335E0")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833640", Offset = "0x833640")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x170000A8")]
		private Vector3 pivot
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1D58E5C", Offset = "0x1D58E5C", VA = "0x1D58E5C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1D58DD0", Offset = "0x1D58DD0", VA = "0x1D58DD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1D58EEC", Offset = "0x1D58EEC", VA = "0x1D58EEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1D595D0", Offset = "0x1D595D0", VA = "0x1D595D0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1D596BC", Offset = "0x1D596BC", VA = "0x1D596BC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1D5990C", Offset = "0x1D5990C", VA = "0x1D5990C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838E0C", Offset = "0x838E0C")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1D59984", Offset = "0x1D59984", VA = "0x1D59984")]
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
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1512BA8", Offset = "0x1512BA8", VA = "0x1512BA8")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1512D34", Offset = "0x1512D34", VA = "0x1512D34")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1512D3C", Offset = "0x1512D3C", VA = "0x1512D3C")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1D59BF0", Offset = "0x1D59BF0", VA = "0x1D59BF0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1D59CD0", Offset = "0x1D59CD0", VA = "0x1D59CD0")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1D59D58", Offset = "0x1D59D58", VA = "0x1D59D58")]
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
				[Token(Token = "0x40005A4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833800", Offset = "0x833800")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005A5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833838", Offset = "0x833838")]
				public float weight;

				[Token(Token = "0x6000631")]
				[Address(RVA = "0x20C7F7C", Offset = "0x20C7F7C", VA = "0x20C7F7C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8336B0", Offset = "0x8336B0")]
			public Transform transform;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8336E8", Offset = "0x8336E8")]
			public Transform relativeTo;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833720", Offset = "0x833720")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833758", Offset = "0x833758")]
			public float verticalWeight;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833790", Offset = "0x833790")]
			public float horizontalWeight;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8337C8", Offset = "0x8337C8")]
			public float speed;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1512D58", Offset = "0x1512D58", VA = "0x1512D58")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1513094", Offset = "0x1513094", VA = "0x1513094")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x15130A4", Offset = "0x15130A4", VA = "0x15130A4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833678", Offset = "0x833678")]
		public Body[] bodies;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1D59E74", Offset = "0x1D59E74", VA = "0x1D59E74", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1D59FC0", Offset = "0x1D59FC0", VA = "0x1D59FC0")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833870", Offset = "0x833870")]
		public float tiltSpeed;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8338A8", Offset = "0x8338A8")]
		public float tiltSensitivity;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8338E0", Offset = "0x8338E0")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833918", Offset = "0x833918")]
		public OffsetPose poseRight;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1D68EDC", Offset = "0x1D68EDC", VA = "0x1D68EDC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1D68F24", Offset = "0x1D68F24", VA = "0x1D68F24", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1D690DC", Offset = "0x1D690DC", VA = "0x1D690DC")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x833950", Offset = "0x833950")]
		public float weight;

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1D690F0", Offset = "0x1D690F0", VA = "0x1D690F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1D691C8", Offset = "0x1D691C8", VA = "0x1D691C8")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1D693F0", Offset = "0x1D693F0", VA = "0x1D693F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1D69520", Offset = "0x1D69520", VA = "0x1D69520")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833968", Offset = "0x833968")]
		public Animator animator;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8339A0", Offset = "0x8339A0")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8339E8", Offset = "0x8339E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8339E8", Offset = "0x8339E8")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x170000AB")]
		public IK ik
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x1224254", Offset = "0x1224254", VA = "0x1224254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838EBC", Offset = "0x838EBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x122425C", Offset = "0x122425C", VA = "0x122425C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838ECC", Offset = "0x838ECC")]
			private set
			{
			}
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1224264", Offset = "0x1224264", VA = "0x1224264")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1224420", Offset = "0x1224420", VA = "0x1224420")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x12246AC", Offset = "0x12246AC", VA = "0x12246AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1224804", Offset = "0x1224804", VA = "0x1224804")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x12249F4", Offset = "0x12249F4", VA = "0x12249F4")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1224C2C", Offset = "0x1224C2C", VA = "0x1224C2C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1224ED8", Offset = "0x1224ED8", VA = "0x1224ED8")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x82B564", Offset = "0x82B564")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000AC")]
		public bool poseStored
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1224518", Offset = "0x1224518", VA = "0x1224518")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1224884", Offset = "0x1224884", VA = "0x1224884")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x122453C", Offset = "0x122453C", VA = "0x122453C")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1224F40", Offset = "0x1224F40", VA = "0x1224F40")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class FABRIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FABRIK ik;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x833A24", Offset = "0x833A24")]
		public float weight;

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1225B0C", Offset = "0x1225B0C", VA = "0x1225B0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1225BE4", Offset = "0x1225BE4", VA = "0x1225BE4")]
		private void OnPreIteration(int it)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1225D0C", Offset = "0x1225D0C", VA = "0x1225D0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1225E3C", Offset = "0x1225E3C", VA = "0x1225E3C")]
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
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833AAC", Offset = "0x833AAC")]
			public string name;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833AE4", Offset = "0x833AE4")]
			public Collider collider;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833B1C", Offset = "0x833B1C")]
			private float crossFadeTime;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x833B68", Offset = "0x833B68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B68", Offset = "0x833B68")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x833BA4", Offset = "0x833BA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833BA4", Offset = "0x833BA4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x833BE0", Offset = "0x833BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833BE0", Offset = "0x833BE0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000AE")]
			public bool inProgress
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0x151A280", Offset = "0x151A280", VA = "0x151A280")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AF")]
			protected float crossFader
			{
				[Token(Token = "0x600064F")]
				[Address(RVA = "0x151A294", Offset = "0x151A294", VA = "0x151A294")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838EDC", Offset = "0x838EDC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000650")]
				[Address(RVA = "0x151A29C", Offset = "0x151A29C", VA = "0x151A29C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838EEC", Offset = "0x838EEC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			protected float timer
			{
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x151A2A4", Offset = "0x151A2A4", VA = "0x151A2A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838EFC", Offset = "0x838EFC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x151A2AC", Offset = "0x151A2AC", VA = "0x151A2AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F0C", Offset = "0x838F0C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			protected Vector3 force
			{
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x151A2B4", Offset = "0x151A2B4", VA = "0x151A2B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F1C", Offset = "0x838F1C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x151A2C0", Offset = "0x151A2C0", VA = "0x151A2C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F2C", Offset = "0x838F2C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x151A2CC", Offset = "0x151A2CC", VA = "0x151A2CC", Slot = "4")]
			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x151A3E4", Offset = "0x151A3E4", VA = "0x151A3E4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000657")]
			protected abstract float GetLength();

			[Token(Token = "0x6000658")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000659")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x151A4B8", Offset = "0x151A4B8", VA = "0x151A4B8")]
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
				[Token(Token = "0x40005C4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833CC4", Offset = "0x833CC4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833CFC", Offset = "0x833CFC")]
				public float weight;

				[Token(Token = "0x40005C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600065F")]
				[Address(RVA = "0x20C80EC", Offset = "0x20C80EC", VA = "0x20C80EC")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000660")]
				[Address(RVA = "0x20C819C", Offset = "0x20C819C", VA = "0x20C819C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000661")]
				[Address(RVA = "0x20C81B0", Offset = "0x20C81B0", VA = "0x20C81B0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833C1C", Offset = "0x833C1C")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833C54", Offset = "0x833C54")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833C8C", Offset = "0x833C8C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x151A854", Offset = "0x151A854", VA = "0x151A854", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x151A984", Offset = "0x151A984", VA = "0x151A984", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x151A9F0", Offset = "0x151A9F0", VA = "0x151A9F0", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x151AB60", Offset = "0x151AB60", VA = "0x151AB60")]
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
				[Token(Token = "0x40005CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833DA4", Offset = "0x833DA4")]
				public Transform bone;

				[Token(Token = "0x40005CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833DDC", Offset = "0x833DDC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x833DDC", Offset = "0x833DDC")]
				public float weight;

				[Token(Token = "0x40005CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40005CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000667")]
				[Address(RVA = "0x20C7F84", Offset = "0x20C7F84", VA = "0x20C7F84")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0x20C809C", Offset = "0x20C809C", VA = "0x20C809C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000669")]
				[Address(RVA = "0x20C80A8", Offset = "0x20C80A8", VA = "0x20C80A8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833D34", Offset = "0x833D34")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833D6C", Offset = "0x833D6C")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rigidbody rigidbody;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 comAxis;

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x151A4CC", Offset = "0x151A4CC", VA = "0x151A4CC", Slot = "4")]
			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x151A650", Offset = "0x151A650", VA = "0x151A650", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x151A6F4", Offset = "0x151A6F4", VA = "0x151A6F4", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x151A760", Offset = "0x151A760", VA = "0x151A760", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x151A840", Offset = "0x151A840", VA = "0x151A840")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833A3C", Offset = "0x833A3C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833A74", Offset = "0x833A74")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000AD")]
		public bool inProgress
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x1E22E5C", Offset = "0x1E22E5C", VA = "0x1E22E5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1E22F2C", Offset = "0x1E22F2C", VA = "0x1E22F2C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1E23008", Offset = "0x1E23008", VA = "0x1E23008")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1E2326C", Offset = "0x1E2326C", VA = "0x1E2326C")]
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
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833EA0", Offset = "0x833EA0")]
			public string name;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833ED8", Offset = "0x833ED8")]
			public Collider collider;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833F10", Offset = "0x833F10")]
			private float crossFadeTime;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x833F5C", Offset = "0x833F5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F5C", Offset = "0x833F5C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F98", Offset = "0x833F98")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x833F98", Offset = "0x833F98")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833FD4", Offset = "0x833FD4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x833FD4", Offset = "0x833FD4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000B2")]
			protected float crossFader
			{
				[Token(Token = "0x600066D")]
				[Address(RVA = "0x151AB74", Offset = "0x151AB74", VA = "0x151AB74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F3C", Offset = "0x838F3C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x151AB7C", Offset = "0x151AB7C", VA = "0x151AB7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F4C", Offset = "0x838F4C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			protected float timer
			{
				[Token(Token = "0x600066F")]
				[Address(RVA = "0x151AB84", Offset = "0x151AB84", VA = "0x151AB84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F5C", Offset = "0x838F5C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000670")]
				[Address(RVA = "0x151AB8C", Offset = "0x151AB8C", VA = "0x151AB8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F6C", Offset = "0x838F6C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			protected Vector3 force
			{
				[Token(Token = "0x6000671")]
				[Address(RVA = "0x151AB94", Offset = "0x151AB94", VA = "0x151AB94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F7C", Offset = "0x838F7C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x151ABA0", Offset = "0x151ABA0", VA = "0x151ABA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F8C", Offset = "0x838F8C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x151ABAC", Offset = "0x151ABAC", VA = "0x151ABAC", Slot = "4")]
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x151ACD8", Offset = "0x151ACD8", VA = "0x151ACD8")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000675")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000676")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000677")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x151ADC0", Offset = "0x151ADC0", VA = "0x151ADC0")]
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
				[Token(Token = "0x40005DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8340B8", Offset = "0x8340B8")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40005E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8340F0", Offset = "0x8340F0")]
				public float weight;

				[Token(Token = "0x40005E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600067D")]
				[Address(RVA = "0x20C81B8", Offset = "0x20C81B8", VA = "0x20C81B8")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600067E")]
				[Address(RVA = "0x20C8248", Offset = "0x20C8248", VA = "0x20C8248")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600067F")]
				[Address(RVA = "0x20C825C", Offset = "0x20C825C", VA = "0x20C825C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834010", Offset = "0x834010")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834048", Offset = "0x834048")]
			public int upDirCurveIndex;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834080", Offset = "0x834080")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x151ADD4", Offset = "0x151ADD4", VA = "0x151ADD4", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x151AF84", Offset = "0x151AF84", VA = "0x151AF84", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x151AFF0", Offset = "0x151AFF0", VA = "0x151AFF0", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x151B190", Offset = "0x151B190", VA = "0x151B190")]
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
				[Token(Token = "0x40005E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834198", Offset = "0x834198")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40005E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8341D0", Offset = "0x8341D0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8341D0", Offset = "0x8341D0")]
				public float weight;

				[Token(Token = "0x40005E9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40005EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000685")]
				[Address(RVA = "0x20C8264", Offset = "0x20C8264", VA = "0x20C8264")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000686")]
				[Address(RVA = "0x20C8340", Offset = "0x20C8340", VA = "0x20C8340")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000687")]
				[Address(RVA = "0x20C834C", Offset = "0x20C834C", VA = "0x20C834C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834128", Offset = "0x834128")]
			public int curveIndex;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834160", Offset = "0x834160")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Rigidbody rigidbody;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3 comAxis;

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x151B1AC", Offset = "0x151B1AC", VA = "0x151B1AC", Slot = "4")]
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x151B338", Offset = "0x151B338", VA = "0x151B338", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x151B41C", Offset = "0x151B41C", VA = "0x151B41C", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x151B488", Offset = "0x151B488", VA = "0x151B488", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x151B6E0", Offset = "0x151B6E0", VA = "0x151B6E0")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833E30", Offset = "0x833E30")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x833E68", Offset = "0x833E68")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1E235CC", Offset = "0x1E235CC", VA = "0x1E235CC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1E236A0", Offset = "0x1E236A0", VA = "0x1E236A0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1E2390C", Offset = "0x1E2390C", VA = "0x1E2390C")]
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
				[Token(Token = "0x40005F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834400", Offset = "0x834400")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834438", Offset = "0x834438")]
				public float weight;

				[Token(Token = "0x600068E")]
				[Address(RVA = "0x20C8390", Offset = "0x20C8390", VA = "0x20C8390")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834294", Offset = "0x834294")]
			public Transform transform;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8342CC", Offset = "0x8342CC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834304", Offset = "0x834304")]
			public float speed;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83433C", Offset = "0x83433C")]
			public float acceleration;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834374", Offset = "0x834374")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x834374", Offset = "0x834374")]
			public float matchVelocity;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8343C8", Offset = "0x8343C8")]
			public float gravity;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1DA477C", Offset = "0x1DA477C", VA = "0x1DA477C")]
			public void Reset()
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x1DA4834", Offset = "0x1DA4834", VA = "0x1DA4834")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1DA4AF0", Offset = "0x1DA4AF0", VA = "0x1DA4AF0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834224", Offset = "0x834224")]
		public Body[] bodies;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83425C", Offset = "0x83425C")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1DE6E24", Offset = "0x1DE6E24", VA = "0x1DE6E24")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1DE6EA0", Offset = "0x1DE6EA0", VA = "0x1DE6EA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1DE6F60", Offset = "0x1DE6F60", VA = "0x1DE6F60")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834470", Offset = "0x834470")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x834470", Offset = "0x834470")]
		public Transform target;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8344D0", Offset = "0x8344D0")]
		public float weight;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8344E8", Offset = "0x8344E8")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834520", Offset = "0x834520")]
		public float weightSmoothTime;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x834558", Offset = "0x834558")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834558", Offset = "0x834558")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8345B8", Offset = "0x8345B8")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8345F0", Offset = "0x8345F0")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834628", Offset = "0x834628")]
		public float slerpSpeed;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834660", Offset = "0x834660")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834698", Offset = "0x834698")]
		public float minDistance;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8346D0", Offset = "0x8346D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8346D0", Offset = "0x8346D0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8346D0", Offset = "0x8346D0")]
		public float maxRootAngle;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000B5")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1DF1904", Offset = "0x1DF1904", VA = "0x1DF1904")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1DF1890", Offset = "0x1DF1890", VA = "0x1DF1890")]
		private void Start()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1DF1994", Offset = "0x1DF1994", VA = "0x1DF1994")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1DF1ED8", Offset = "0x1DF1ED8", VA = "0x1DF1ED8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1DF1FC4", Offset = "0x1DF1FC4", VA = "0x1DF1FC4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1DF21BC", Offset = "0x1DF21BC", VA = "0x1DF21BC")]
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
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8347BC", Offset = "0x8347BC")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8347F4", Offset = "0x8347F4")]
			public float spring;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83482C", Offset = "0x83482C")]
			public bool x;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834864", Offset = "0x834864")]
			public bool y;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83489C", Offset = "0x83489C")]
			public bool z;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8348D4", Offset = "0x8348D4")]
			public float minX;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83490C", Offset = "0x83490C")]
			public float maxX;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834944", Offset = "0x834944")]
			public float minY;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83497C", Offset = "0x83497C")]
			public float maxY;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8349B4", Offset = "0x8349B4")]
			public float minZ;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8349EC", Offset = "0x8349EC")]
			public float maxZ;

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1DA7050", Offset = "0x1DA7050", VA = "0x1DA7050")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1DA71A8", Offset = "0x1DA71A8", VA = "0x1DA71A8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1DA7220", Offset = "0x1DA7220", VA = "0x1DA7220")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1DA7278", Offset = "0x1DA7278", VA = "0x1DA7278")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5D0", Offset = "0x82B5D0")]
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

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x1DA7000", Offset = "0x1DA7000", VA = "0x1DA7000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A6")]
				[Address(RVA = "0x1DA7048", Offset = "0x1DA7048", VA = "0x1DA7048", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1DA6E50", Offset = "0x1DA6E50", VA = "0x1DA6E50")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1DA6E7C", Offset = "0x1DA6E7C", VA = "0x1DA6E7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1DA6E80", Offset = "0x1DA6E80", VA = "0x1DA6E80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1DA7008", Offset = "0x1DA7008", VA = "0x1DA7008", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83474C", Offset = "0x83474C")]
		public float weight;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834784", Offset = "0x834784")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000B6")]
		protected float deltaTime
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x17E41B4", Offset = "0x17E41B4", VA = "0x17E41B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000696")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x17E41E0", Offset = "0x17E41E0", VA = "0x17E41E0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x17E420C", Offset = "0x17E420C", VA = "0x17E420C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838F9C", Offset = "0x838F9C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x17E4284", Offset = "0x17E4284", VA = "0x17E4284")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x17E4360", Offset = "0x17E4360", VA = "0x17E4360")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x17E4420", Offset = "0x17E4420", VA = "0x17E4420", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x17E4550", Offset = "0x17E4550", VA = "0x17E4550")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5E0", Offset = "0x82B5E0")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B1")]
				[Address(RVA = "0x1DA7434", Offset = "0x1DA7434", VA = "0x1DA7434", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x1DA747C", Offset = "0x1DA747C", VA = "0x1DA747C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1DA7284", Offset = "0x1DA7284", VA = "0x1DA7284")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1DA72B0", Offset = "0x1DA72B0", VA = "0x1DA72B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1DA72B4", Offset = "0x1DA72B4", VA = "0x1DA72B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x1DA743C", Offset = "0x1DA743C", VA = "0x1DA743C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834A24", Offset = "0x834A24")]
		public float weight;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834A5C", Offset = "0x834A5C")]
		public VRIK ik;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000B9")]
		protected float deltaTime
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x17E4560", Offset = "0x17E4560", VA = "0x17E4560")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006A8")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x17E458C", Offset = "0x17E458C", VA = "0x17E458C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x17E45B8", Offset = "0x17E45B8", VA = "0x17E45B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83904C", Offset = "0x83904C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x17E4630", Offset = "0x17E4630", VA = "0x17E4630")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x17E470C", Offset = "0x17E470C", VA = "0x17E470C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x17E483C", Offset = "0x17E483C", VA = "0x17E483C")]
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
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1DA7484", Offset = "0x1DA7484", VA = "0x1DA7484")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1DA76A8", Offset = "0x1DA76A8", VA = "0x1DA76A8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x17E484C", Offset = "0x17E484C", VA = "0x17E484C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x17E4918", Offset = "0x17E4918", VA = "0x17E4918")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x17E49D4", Offset = "0x17E49D4", VA = "0x17E49D4")]
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
				[Token(Token = "0x4000635")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834C70", Offset = "0x834C70")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000636")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834CA8", Offset = "0x834CA8")]
				public float weight;

				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x20C83A0", Offset = "0x20C83A0", VA = "0x20C83A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834ACC", Offset = "0x834ACC")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834B04", Offset = "0x834B04")]
			public Transform raycastTo;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x834B3C", Offset = "0x834B3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834B3C", Offset = "0x834B3C")]
			public float raycastRadius;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834B90", Offset = "0x834B90")]
			public EffectorLink[] effectors;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834BC8", Offset = "0x834BC8")]
			public float smoothTimeIn;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834C00", Offset = "0x834C00")]
			public float smoothTimeOut;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834C38", Offset = "0x834C38")]
			public LayerMask layers;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1DA76B0", Offset = "0x1DA76B0", VA = "0x1DA76B0")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1DA77F4", Offset = "0x1DA77F4", VA = "0x1DA77F4")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1DA78EC", Offset = "0x1DA78EC", VA = "0x1DA78EC")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1DA7ABC", Offset = "0x1DA7ABC", VA = "0x1DA7ABC")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834A94", Offset = "0x834A94")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x17E5394", Offset = "0x17E5394", VA = "0x17E5394", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x17E541C", Offset = "0x17E541C", VA = "0x17E541C")]
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
				[Token(Token = "0x4000655")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83506C", Offset = "0x83506C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000656")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8350A4", Offset = "0x8350A4")]
				public float weight;

				[Token(Token = "0x60006CF")]
				[Address(RVA = "0x20C83A8", Offset = "0x20C83A8", VA = "0x20C83A8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834F70", Offset = "0x834F70")]
			public Vector3 offset;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834FA8", Offset = "0x834FA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x834FA8", Offset = "0x834FA8")]
			public float additivity;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834FFC", Offset = "0x834FFC")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835034", Offset = "0x835034")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1DA85CC", Offset = "0x1DA85CC", VA = "0x1DA85CC")]
			public void Start()
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1DA861C", Offset = "0x1DA861C", VA = "0x1DA861C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1DA87E0", Offset = "0x1DA87E0", VA = "0x1DA87E0")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DD")]
		public enum Handedness
		{
			[Token(Token = "0x4000658")]
			Right,
			[Token(Token = "0x4000659")]
			Left
		}

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834CE0", Offset = "0x834CE0")]
		public AimIK aimIK;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834D18", Offset = "0x834D18")]
		public AimIK headIK;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834D50", Offset = "0x834D50")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834D88", Offset = "0x834D88")]
		public Handedness handedness;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834DC0", Offset = "0x834DC0")]
		public bool twoHanded;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834DF8", Offset = "0x834DF8")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834E30", Offset = "0x834E30")]
		public float magnitudeRandom;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834E68", Offset = "0x834E68")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834EA0", Offset = "0x834EA0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834ED8", Offset = "0x834ED8")]
		public float blendTime;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x834F10", Offset = "0x834F10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x834F10", Offset = "0x834F10")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float magnitudeMlp;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float endTime;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion handRotation;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float length;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool initiated;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float blendWeight;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float w;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool handRotationsSet;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000BC")]
		public bool isFinished
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x17E913C", Offset = "0x17E913C", VA = "0x17E913C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x17E9C1C", Offset = "0x17E9C1C", VA = "0x17E9C1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x17E9C5C", Offset = "0x17E9C5C", VA = "0x17E9C5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x17E9BDC", Offset = "0x17E9BDC", VA = "0x17E9BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x17E9BFC", Offset = "0x17E9BFC", VA = "0x17E9BFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x17E916C", Offset = "0x17E916C", VA = "0x17E916C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x17E9198", Offset = "0x17E9198", VA = "0x17E9198")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x17E92E0", Offset = "0x17E92E0", VA = "0x17E92E0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x17E9C9C", Offset = "0x17E9C9C", VA = "0x17E9C9C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x17E9DC8", Offset = "0x17E9DC8", VA = "0x17E9DC8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x17E9E90", Offset = "0x17E9E90", VA = "0x17E9E90", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x17EA07C", Offset = "0x17EA07C", VA = "0x17EA07C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8350DC", Offset = "0x8350DC")]
		public float weight;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835114", Offset = "0x835114")]
		public float offset;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x17ECE04", Offset = "0x17ECE04", VA = "0x17ECE04")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x17ECF0C", Offset = "0x17ECF0C", VA = "0x17ECF0C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x17ECFF4", Offset = "0x17ECFF4", VA = "0x17ECFF4")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x17ED348", Offset = "0x17ED348", VA = "0x17ED348")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x17ED380", Offset = "0x17ED380", VA = "0x17ED380")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x17ED4B0", Offset = "0x17ED4B0", VA = "0x17ED4B0")]
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
			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83514C", Offset = "0x83514C")]
			public float scaleMlp;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835184", Offset = "0x835184")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8351BC", Offset = "0x8351BC")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8351F4", Offset = "0x8351F4")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83522C", Offset = "0x83522C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835264", Offset = "0x835264")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83529C", Offset = "0x83529C")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8352D4", Offset = "0x8352D4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8352D4", Offset = "0x8352D4")]
			public Vector3 headOffset;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835324", Offset = "0x835324")]
			public Vector3 handOffset;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83535C", Offset = "0x83535C")]
			public float footForwardOffset;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835394", Offset = "0x835394")]
			public float footInwardOffset;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8353CC", Offset = "0x8353CC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8353CC", Offset = "0x8353CC")]
			public float footHeadingOffset;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835428", Offset = "0x835428")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835440", Offset = "0x835440")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x1DAB564", Offset = "0x1DAB564", VA = "0x1DAB564")]
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
				[Token(Token = "0x4000678")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000679")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400067A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x20C83B0", Offset = "0x20C83B0", VA = "0x20C83B0")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x20C8470", Offset = "0x20C8470", VA = "0x20C8470")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x1DAB55C", Offset = "0x1DAB55C", VA = "0x1DAB55C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x17F5954", Offset = "0x17F5954", VA = "0x17F5954")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x17F4488", Offset = "0x17F4488", VA = "0x17F4488")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x17F5AC8", Offset = "0x17F5AC8", VA = "0x17F5AC8")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x17F59DC", Offset = "0x17F59DC", VA = "0x17F59DC")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x17F46CC", Offset = "0x17F46CC", VA = "0x17F46CC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x17F5AE0", Offset = "0x17F5AE0", VA = "0x17F5AE0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x17F397C", Offset = "0x17F397C", VA = "0x17F397C")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x17F60F4", Offset = "0x17F60F4", VA = "0x17F60F4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x17F35E4", Offset = "0x17F35E4", VA = "0x17F35E4")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x17F63A8", Offset = "0x17F63A8", VA = "0x17F63A8")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x17F6A38", Offset = "0x17F6A38", VA = "0x17F6A38")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x17F6804", Offset = "0x17F6804", VA = "0x17F6804")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x17F6CB4", Offset = "0x17F6CB4", VA = "0x17F6CB4")]
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x17F7004", Offset = "0x17F7004", VA = "0x17F7004")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x17F70F4", Offset = "0x17F70F4", VA = "0x17F70F4")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000E3")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1511544", Offset = "0x1511544", VA = "0x1511544")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x15115A0", Offset = "0x15115A0", VA = "0x15115A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x15115D4", Offset = "0x15115D4", VA = "0x15115D4")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1511710", Offset = "0x1511710", VA = "0x1511710")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x835458", Offset = "0x835458")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835458", Offset = "0x835458")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000C1")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1511E18", Offset = "0x1511E18", VA = "0x1511E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8390FC", Offset = "0x8390FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x1511E24", Offset = "0x1511E24", VA = "0x1511E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83910C", Offset = "0x83910C")]
			private set
			{
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1511E30", Offset = "0x1511E30", VA = "0x1511E30")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1511FA8", Offset = "0x1511FA8", VA = "0x1511FA8")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x15121D8", Offset = "0x15121D8", VA = "0x15121D8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1512394", Offset = "0x1512394", VA = "0x1512394")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x15127B0", Offset = "0x15127B0", VA = "0x15127B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x15128DC", Offset = "0x15128DC", VA = "0x15128DC")]
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
			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x151721C", Offset = "0x151721C", VA = "0x151721C")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x1517390", Offset = "0x1517390", VA = "0x1517390")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1E16F0C", Offset = "0x1E16F0C", VA = "0x1E16F0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1E16F68", Offset = "0x1E16F68", VA = "0x1E16F68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1E16FE4", Offset = "0x1E16FE4", VA = "0x1E16FE4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1E170C8", Offset = "0x1E170C8", VA = "0x1E170C8")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1D58D44", Offset = "0x1D58D44", VA = "0x1D58D44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1D58DC8", Offset = "0x1D58DC8", VA = "0x1D58DC8")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8354A4", Offset = "0x8354A4")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1D59DC8", Offset = "0x1D59DC8", VA = "0x1D59DC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1D59E40", Offset = "0x1D59E40", VA = "0x1D59E40")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderFBBIK grounder;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x17ECB0C", Offset = "0x17ECB0C", VA = "0x17ECB0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x17ECBD0", Offset = "0x17ECBD0", VA = "0x17ECBD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x17ECDFC", Offset = "0x17ECDFC", VA = "0x17ECDFC")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8354DC", Offset = "0x8354DC")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835514", Offset = "0x835514")]
		public AimIK aim;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83554C", Offset = "0x83554C")]
		public LookAtIK lookAt;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835584", Offset = "0x835584")]
		public Animator animator;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8355BC", Offset = "0x8355BC")]
		public float crossfadeTime;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8355F4", Offset = "0x8355F4")]
		public float minAimDistance;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x17ED788", Offset = "0x17ED788", VA = "0x17ED788")]
		private void Start()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x17ED7CC", Offset = "0x17ED7CC", VA = "0x17ED7CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x17ED884", Offset = "0x17ED884", VA = "0x17ED884")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x17EDA0C", Offset = "0x17EDA0C", VA = "0x17EDA0C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x17EDB38", Offset = "0x17EDB38", VA = "0x17EDB38")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x17EDBB4", Offset = "0x17EDBB4", VA = "0x17EDBB4")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x17EEBB0", Offset = "0x17EEBB0", VA = "0x17EEBB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x17EED20", Offset = "0x17EED20", VA = "0x17EED20")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x17EEEB4", Offset = "0x17EEEB4", VA = "0x17EEEB4")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x83562C", Offset = "0x83562C")]
		public Animator animator;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x835664", Offset = "0x835664")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83569C", Offset = "0x83569C")]
		public float lookAtWeight;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8356B4", Offset = "0x8356B4")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8356CC", Offset = "0x8356CC")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8356E4", Offset = "0x8356E4")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8356FC", Offset = "0x8356FC")]
		public float lookAtClampWeight;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835714", Offset = "0x835714")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83572C", Offset = "0x83572C")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x835744", Offset = "0x835744")]
		public Transform footTargetBiped;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83577C", Offset = "0x83577C")]
		public float footPositionWeight;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835794", Offset = "0x835794")]
		public float footRotationWeight;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8357AC", Offset = "0x8357AC")]
		public Transform handTargetBiped;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8357E4", Offset = "0x8357E4")]
		public float handPositionWeight;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8357FC", Offset = "0x8357FC")]
		public float handRotationWeight;

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1D61560", Offset = "0x1D61560", VA = "0x1D61560")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1D61968", Offset = "0x1D61968", VA = "0x1D61968")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835814", Offset = "0x835814")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x835814", Offset = "0x835814")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000C2")]
		public Vector3 velocity
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1DF23C4", Offset = "0x1DF23C4", VA = "0x1DF23C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83911C", Offset = "0x83911C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1DF23D0", Offset = "0x1DF23D0", VA = "0x1DF23D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83912C", Offset = "0x83912C")]
			private set
			{
			}
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1DF23DC", Offset = "0x1DF23DC", VA = "0x1DF23DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1DF2418", Offset = "0x1DF2418", VA = "0x1DF2418")]
		private void Update()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1DF2C8C", Offset = "0x1DF2C8C", VA = "0x1DF2C8C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1DF2A3C", Offset = "0x1DF2A3C", VA = "0x1DF2A3C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1DF2D88", Offset = "0x1DF2D88", VA = "0x1DF2D88")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000C3")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1DF2DB4", Offset = "0x1DF2DB4", VA = "0x1DF2DB4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1DF2E38", Offset = "0x1DF2E38", VA = "0x1DF2E38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1DF305C", Offset = "0x1DF305C", VA = "0x1DF305C")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5F0", Offset = "0x82B5F0")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 targetPosition;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000725")]
				[Address(RVA = "0x1DA6B84", Offset = "0x1DA6B84", VA = "0x1DA6B84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000727")]
				[Address(RVA = "0x1DA6BCC", Offset = "0x1DA6BCC", VA = "0x1DA6BCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1DA67F8", Offset = "0x1DA67F8", VA = "0x1DA67F8")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1DA6824", Offset = "0x1DA6824", VA = "0x1DA6824", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1DA6828", Offset = "0x1DA6828", VA = "0x1DA6828", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1DA6B8C", Offset = "0x1DA6B8C", VA = "0x1DA6B8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000C4")]
		public bool isStepping
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1DF3070", Offset = "0x1DF3070", VA = "0x1DF3070")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public Vector3 position
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1DF2D54", Offset = "0x1DF2D54", VA = "0x1DF2D54")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1DF3084", Offset = "0x1DF3084", VA = "0x1DF3084")]
			set
			{
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1DF30DC", Offset = "0x1DF30DC", VA = "0x1DF30DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1DF3308", Offset = "0x1DF3308", VA = "0x1DF3308")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1DF34A4", Offset = "0x1DF34A4", VA = "0x1DF34A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1DF36D8", Offset = "0x1DF36D8", VA = "0x1DF36D8")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1DF394C", Offset = "0x1DF394C", VA = "0x1DF394C")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1DF3AC4", Offset = "0x1DF3AC4", VA = "0x1DF3AC4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1DF3624", Offset = "0x1DF3624", VA = "0x1DF3624")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83913C", Offset = "0x83913C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1DF3CC0", Offset = "0x1DF3CC0", VA = "0x1DF3CC0")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1DF3D3C", Offset = "0x1DF3D3C", VA = "0x1DF3D3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1DF3E0C", Offset = "0x1DF3E0C", VA = "0x1DF3E0C")]
		private void Update()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1DF4060", Offset = "0x1DF4060", VA = "0x1DF4060")]
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
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835910", Offset = "0x835910")]
			public int animationLayer;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835948", Offset = "0x835948")]
			public string animationState;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835980", Offset = "0x835980")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8359B8", Offset = "0x8359B8")]
			public Transform warpFrom;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8359F0", Offset = "0x8359F0")]
			public Transform warpTo;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835A28", Offset = "0x835A28")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		public enum EffectorMode
		{
			[Token(Token = "0x40006F8")]
			PositionOffset,
			[Token(Token = "0x40006F9")]
			Position
		}

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835850", Offset = "0x835850")]
		public Animator animator;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835888", Offset = "0x835888")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8358C0", Offset = "0x8358C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8358C0", Offset = "0x8358C0")]
		public Warp[] warps;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1D5A538", Offset = "0x1D5A538", VA = "0x1D5A538", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1D5A564", Offset = "0x1D5A564", VA = "0x1D5A564")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1D5A7A4", Offset = "0x1D5A7A4", VA = "0x1D5A7A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1D5AA68", Offset = "0x1D5AA68", VA = "0x1D5AA68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1D5AB08", Offset = "0x1D5AB08", VA = "0x1D5AB08")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1D5AB10", Offset = "0x1D5AB10", VA = "0x1D5AB10", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1D5AB6C", Offset = "0x1D5AB6C", VA = "0x1D5AB6C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1D5AD08", Offset = "0x1D5AD08", VA = "0x1D5AD08", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1D5AF10", Offset = "0x1D5AF10", VA = "0x1D5AF10")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835A60", Offset = "0x835A60")]
		public float headLookWeight;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1D5AF24", Offset = "0x1D5AF24", VA = "0x1D5AF24", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1D5B0F0", Offset = "0x1D5B0F0", VA = "0x1D5B0F0", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1D5B16C", Offset = "0x1D5B16C", VA = "0x1D5B16C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1D5B260", Offset = "0x1D5B260", VA = "0x1D5B260")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1D5B2A8", Offset = "0x1D5B2A8", VA = "0x1D5B2A8")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1D5B694", Offset = "0x1D5B694", VA = "0x1D5B694")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1D5B51C", Offset = "0x1D5B51C", VA = "0x1D5B51C")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1D5B8F0", Offset = "0x1D5B8F0", VA = "0x1D5B8F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1D5BA20", Offset = "0x1D5BA20", VA = "0x1D5BA20")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1212ADC", Offset = "0x1212ADC", VA = "0x1212ADC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1212B44", Offset = "0x1212B44", VA = "0x1212B44", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1212D78", Offset = "0x1212D78", VA = "0x1212D78")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1212E6C", Offset = "0x1212E6C", VA = "0x1212E6C")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000C8")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x12138C0", Offset = "0x12138C0", VA = "0x12138C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000C9")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1213944", Offset = "0x1213944", VA = "0x1213944")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x12136C4", Offset = "0x12136C4", VA = "0x12136C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1213738", Offset = "0x1213738", VA = "0x1213738")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x12139C8", Offset = "0x12139C8", VA = "0x12139C8")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835A78", Offset = "0x835A78")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1224FD8", Offset = "0x1224FD8", VA = "0x1224FD8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1225438", Offset = "0x1225438", VA = "0x1225438")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1225440", Offset = "0x1225440", VA = "0x1225440")]
		private void Start()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x12254FC", Offset = "0x12254FC", VA = "0x12254FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1225880", Offset = "0x1225880", VA = "0x1225880")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x122592C", Offset = "0x122592C", VA = "0x122592C")]
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
			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x1516CE4", Offset = "0x1516CE4", VA = "0x1516CE4")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x1516D68", Offset = "0x1516D68", VA = "0x1516D68")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1E1419C", Offset = "0x1E1419C", VA = "0x1E1419C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1E142F4", Offset = "0x1E142F4", VA = "0x1E142F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1E14398", Offset = "0x1E14398", VA = "0x1E14398")]
		private void Update()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1E1439C", Offset = "0x1E1439C", VA = "0x1E1439C")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1E143B0", Offset = "0x1E143B0", VA = "0x1E143B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1E14424", Offset = "0x1E14424", VA = "0x1E14424")]
		private void Update()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1E14504", Offset = "0x1E14504", VA = "0x1E14504")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835A90", Offset = "0x835A90")]
		public Transform target;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835AC8", Offset = "0x835AC8")]
		public Transform pin;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835B00", Offset = "0x835B00")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835B38", Offset = "0x835B38")]
		public AimIK aim;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835B70", Offset = "0x835B70")]
		public float weight;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835BA8", Offset = "0x835BA8")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835BE0", Offset = "0x835BE0")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1E1450C", Offset = "0x1E1450C", VA = "0x1E1450C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1E14568", Offset = "0x1E14568", VA = "0x1E14568")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1E1470C", Offset = "0x1E1470C", VA = "0x1E1470C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1E16894", Offset = "0x1E16894", VA = "0x1E16894")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1E1696C", Offset = "0x1E1696C", VA = "0x1E1696C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1E169FC", Offset = "0x1E169FC", VA = "0x1E169FC")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1E16DD4", Offset = "0x1E16DD4", VA = "0x1E16DD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1E16F04", Offset = "0x1E16F04", VA = "0x1E16F04")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835C18", Offset = "0x835C18")]
		public float aimWeight;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835C30", Offset = "0x835C30")]
		public float sightWeight;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835C48", Offset = "0x835C48")]
		public float maxAngle;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835C64", Offset = "0x835C64")]
		public float cameraRecoilWeight;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1E170D0", Offset = "0x1E170D0", VA = "0x1E170D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1E17294", Offset = "0x1E17294", VA = "0x1E17294")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1E172A0", Offset = "0x1E172A0", VA = "0x1E172A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1E17520", Offset = "0x1E17520", VA = "0x1E17520")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1E177F4", Offset = "0x1E177F4", VA = "0x1E177F4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1E17368", Offset = "0x1E17368", VA = "0x1E17368")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1E180E8", Offset = "0x1E180E8", VA = "0x1E180E8")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835C7C", Offset = "0x835C7C")]
		public float walkSpeed;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1E18108", Offset = "0x1E18108", VA = "0x1E18108")]
		private void Start()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1E18194", Offset = "0x1E18194", VA = "0x1E18194")]
		private void Update()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1E18280", Offset = "0x1E18280", VA = "0x1E18280")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1E18338", Offset = "0x1E18338", VA = "0x1E18338")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1E23274", Offset = "0x1E23274", VA = "0x1E23274")]
		private void Update()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1E233D8", Offset = "0x1E233D8", VA = "0x1E233D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1E235BC", Offset = "0x1E235BC", VA = "0x1E235BC")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1E23C6C", Offset = "0x1E23C6C", VA = "0x1E23C6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1E23DB4", Offset = "0x1E23DB4", VA = "0x1E23DB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1E240F0", Offset = "0x1E240F0", VA = "0x1E240F0")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1DE7084", Offset = "0x1DE7084", VA = "0x1DE7084")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1DE72D0", Offset = "0x1DE72D0", VA = "0x1DE72D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1DE73E4", Offset = "0x1DE73E4", VA = "0x1DE73E4")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1DE73EC", Offset = "0x1DE73EC", VA = "0x1DE73EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1DE7C04", Offset = "0x1DE7C04", VA = "0x1DE7C04")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835C94", Offset = "0x835C94")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835CCC", Offset = "0x835CCC")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1DEFED4", Offset = "0x1DEFED4", VA = "0x1DEFED4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1DEFF30", Offset = "0x1DEFF30", VA = "0x1DEFF30")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1DF0264", Offset = "0x1DF0264", VA = "0x1DF0264")]
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
			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000CA")]
			private Transform neck
			{
				[Token(Token = "0x600077B")]
				[Address(RVA = "0x1DA678C", Offset = "0x1DA678C", VA = "0x1DA678C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x1DA6040", Offset = "0x1DA6040", VA = "0x1DA6040")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1DA6060", Offset = "0x1DA6060", VA = "0x1DA6060")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1DA65F8", Offset = "0x1DA65F8", VA = "0x1DA65F8")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1DA67E4", Offset = "0x1DA67E4", VA = "0x1DA67E4")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835D04", Offset = "0x835D04")]
		public float weight;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835D1C", Offset = "0x835D1C")]
		public int iterations;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1DF0E30", Offset = "0x1DF0E30", VA = "0x1DF0E30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1DF0E6C", Offset = "0x1DF0E6C", VA = "0x1DF0E6C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1DF0ED4", Offset = "0x1DF0ED4", VA = "0x1DF0ED4")]
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
			[Token(Token = "0x4000785")]
			Position,
			[Token(Token = "0x4000786")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200010B")]
		public class Absorber
		{
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835E14", Offset = "0x835E14")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835E4C", Offset = "0x835E4C")]
			public float weight;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1DA6BD4", Offset = "0x1DA6BD4", VA = "0x1DA6BD4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1DA6CBC", Offset = "0x1DA6CBC", VA = "0x1DA6CBC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1DA6CF8", Offset = "0x1DA6CF8", VA = "0x1DA6CF8")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1DA6D90", Offset = "0x1DA6D90", VA = "0x1DA6D90")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1DA6E04", Offset = "0x1DA6E04", VA = "0x1DA6E04")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835D34", Offset = "0x835D34")]
		public Mode mode;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835D6C", Offset = "0x835D6C")]
		public Absorber[] absorbers;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835DA4", Offset = "0x835DA4")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835DDC", Offset = "0x835DDC")]
		public float falloffSpeed;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1DF4068", Offset = "0x1DF4068", VA = "0x1DF4068", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1DF4158", Offset = "0x1DF4158", VA = "0x1DF4158")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1DF41E8", Offset = "0x1DF41E8", VA = "0x1DF41E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1DF42FC", Offset = "0x1DF42FC", VA = "0x1DF42FC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1DF4388", Offset = "0x1DF4388", VA = "0x1DF4388", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1DF44C4", Offset = "0x1DF44C4", VA = "0x1DF44C4")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1DF44D4", Offset = "0x1DF44D4", VA = "0x1DF44D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1DF4550", Offset = "0x1DF4550", VA = "0x1DF4550")]
		private void Update()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1DF462C", Offset = "0x1DF462C", VA = "0x1DF462C")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1DF46EC", Offset = "0x1DF46EC", VA = "0x1DF46EC")]
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
			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1DA6E40", Offset = "0x1DA6E40", VA = "0x1DA6E40")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835E84", Offset = "0x835E84")]
		public Transform anchor;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 posRelToAnchor;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion rotRelToAnchor;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1DF4FE8", Offset = "0x1DF4FE8", VA = "0x1DF4FE8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1DF51FC", Offset = "0x1DF51FC", VA = "0x1DF51FC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1DF5388", Offset = "0x1DF5388", VA = "0x1DF5388")]
		public void Anchor()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1DF5488", Offset = "0x1DF5488", VA = "0x1DF5488")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x835ECC", Offset = "0x835ECC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835ECC", Offset = "0x835ECC")]
		public float weight;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835F20", Offset = "0x835F20")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835F58", Offset = "0x835F58")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835FA4", Offset = "0x835FA4")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x17E4A3C", Offset = "0x17E4A3C", VA = "0x17E4A3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x17E4D0C", Offset = "0x17E4D0C", VA = "0x17E4D0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x17E5354", Offset = "0x17E5354", VA = "0x17E5354")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000CB")]
		private bool holding
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x17E5944", Offset = "0x17E5944", VA = "0x17E5944")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		private bool holdingLeft
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x17E5A30", Offset = "0x17E5A30", VA = "0x17E5A30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		private bool holdingRight
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x17E597C", Offset = "0x17E597C", VA = "0x17E597C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x17E542C", Offset = "0x17E542C", VA = "0x17E542C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000796")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x17E5AE4", Offset = "0x17E5AE4", VA = "0x17E5AE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x17E5C9C", Offset = "0x17E5C9C", VA = "0x17E5C9C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x17E5E20", Offset = "0x17E5E20", VA = "0x17E5E20")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x17E5EFC", Offset = "0x17E5EFC", VA = "0x17E5EFC")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x17E603C", Offset = "0x17E603C", VA = "0x17E603C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x17E61AC", Offset = "0x17E61AC", VA = "0x17E61AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x17E63BC", Offset = "0x17E63BC", VA = "0x17E63BC")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x17E63D0", Offset = "0x17E63D0", VA = "0x17E63D0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x17E67C0", Offset = "0x17E67C0", VA = "0x17E67C0")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x17E67D4", Offset = "0x17E67D4", VA = "0x17E67D4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x17E6910", Offset = "0x17E6910", VA = "0x17E6910")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x17E8F40", Offset = "0x17E8F40", VA = "0x17E8F40")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x17E9020", Offset = "0x17E9020", VA = "0x17E9020")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x17E9134", Offset = "0x17E9134", VA = "0x17E9134")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x17EA0EC", Offset = "0x17EA0EC", VA = "0x17EA0EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x17EA148", Offset = "0x17EA148", VA = "0x17EA148")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x17EA1A0", Offset = "0x17EA1A0", VA = "0x17EA1A0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x17EA280", Offset = "0x17EA280", VA = "0x17EA280")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B600", Offset = "0x82B600")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Poser <poser>5__1;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x1DA8A30", Offset = "0x1DA8A30", VA = "0x1DA8A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0x1DA8A78", Offset = "0x1DA8A78", VA = "0x1DA8A78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x1DA87F4", Offset = "0x1DA87F4", VA = "0x1DA87F4")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x1DA8820", Offset = "0x1DA8820", VA = "0x1DA8820", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x1DA8824", Offset = "0x1DA8824", VA = "0x1DA8824", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x1DA8A38", Offset = "0x1DA8A38", VA = "0x1DA8A38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x17EA290", Offset = "0x17EA290", VA = "0x17EA290")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x17EA358", Offset = "0x17EA358", VA = "0x17EA358")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x17EA3BC", Offset = "0x17EA3BC", VA = "0x17EA3BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8391EC", Offset = "0x8391EC")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x17EA444", Offset = "0x17EA444", VA = "0x17EA444")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B610", Offset = "0x82B610")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007BC")]
				[Address(RVA = "0x1DA8FE0", Offset = "0x1DA8FE0", VA = "0x1DA8FE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007BE")]
				[Address(RVA = "0x1DA9028", Offset = "0x1DA9028", VA = "0x1DA9028", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1DA8E58", Offset = "0x1DA8E58", VA = "0x1DA8E58")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x1DA8E84", Offset = "0x1DA8E84", VA = "0x1DA8E84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x1DA8E88", Offset = "0x1DA8E88", VA = "0x1DA8E88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1DA8FE8", Offset = "0x1DA8FE8", VA = "0x1DA8FE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x17EE3BC", Offset = "0x17EE3BC", VA = "0x17EE3BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x17EE474", Offset = "0x17EE474", VA = "0x17EE474")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83929C", Offset = "0x83929C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x17EE4EC", Offset = "0x17EE4EC", VA = "0x17EE4EC")]
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
			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1DA9030", Offset = "0x1DA9030", VA = "0x1DA9030")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1DA930C", Offset = "0x1DA930C", VA = "0x1DA930C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1DA93F8", Offset = "0x1DA93F8", VA = "0x1DA93F8")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1DA988C", Offset = "0x1DA988C", VA = "0x1DA988C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1DA99DC", Offset = "0x1DA99DC", VA = "0x1DA99DC")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1DA9A74", Offset = "0x1DA9A74", VA = "0x1DA9A74")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1DA9B08", Offset = "0x1DA9B08", VA = "0x1DA9B08")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x1DA9B9C", Offset = "0x1DA9B9C", VA = "0x1DA9B9C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x1DA9D5C", Offset = "0x1DA9D5C", VA = "0x1DA9D5C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x17EEEE4", Offset = "0x17EEEE4", VA = "0x17EEEE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x17EEF60", Offset = "0x17EEF60", VA = "0x17EEF60")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x17EEFD0", Offset = "0x17EEFD0", VA = "0x17EEFD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x17EF098", Offset = "0x17EF098", VA = "0x17EF098")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x835FF0", Offset = "0x835FF0")]
		public Transform to;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x836028", Offset = "0x836028")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836028", Offset = "0x836028")]
		public float transferMotion;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x17EF0A0", Offset = "0x17EF0A0", VA = "0x17EF0A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x17EF0DC", Offset = "0x17EF0DC", VA = "0x17EF0DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x17EF190", Offset = "0x17EF190", VA = "0x17EF190")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83607C", Offset = "0x83607C")]
		public float weight;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836094", Offset = "0x836094")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8360CC", Offset = "0x8360CC")]
		public Poser leftHandPoser;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836104", Offset = "0x836104")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x836104", Offset = "0x836104")]
		public float leftHandWeight;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x17F08A0", Offset = "0x17F08A0", VA = "0x17F08A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x17F0A70", Offset = "0x17F0A70", VA = "0x17F0A70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x17F0CBC", Offset = "0x17F0CBC", VA = "0x17F0CBC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x17F0E60", Offset = "0x17F0E60", VA = "0x17F0E60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x17F0F90", Offset = "0x17F0F90", VA = "0x17F0F90")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x17F1260", Offset = "0x17F1260", VA = "0x17F1260", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x17F15EC", Offset = "0x17F15EC", VA = "0x17F15EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x17F1858", Offset = "0x17F1858", VA = "0x17F1858")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1E1C0C0", Offset = "0x1E1C0C0", VA = "0x1E1C0C0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1E1C3E8", Offset = "0x1E1C3E8", VA = "0x1E1C3E8")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1E1C468", Offset = "0x1E1C468", VA = "0x1E1C468")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B620", Offset = "0x82B620")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <angle>5__1;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 <axis>5__2;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x1DA7C5C", Offset = "0x1DA7C5C", VA = "0x1DA7C5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x1DA7CA4", Offset = "0x1DA7CA4", VA = "0x1DA7CA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1DA7AD0", Offset = "0x1DA7AD0", VA = "0x1DA7AD0")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1DA7AFC", Offset = "0x1DA7AFC", VA = "0x1DA7AFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1DA7B00", Offset = "0x1DA7B00", VA = "0x1DA7B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1DA7C64", Offset = "0x1DA7C64", VA = "0x1DA7C64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x17E6924", Offset = "0x17E6924", VA = "0x17E6924")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x17E6A68", Offset = "0x17E6A68", VA = "0x17E6A68")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x17E69F0", Offset = "0x17E69F0", VA = "0x17E69F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83934C", Offset = "0x83934C")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x17E6BEC", Offset = "0x17E6BEC", VA = "0x17E6BEC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x17E6CD8", Offset = "0x17E6CD8", VA = "0x17E6CD8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x17E6DC0", Offset = "0x17E6DC0", VA = "0x17E6DC0")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x836158", Offset = "0x836158")]
		public float weight;

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1D601A0", Offset = "0x1D601A0", VA = "0x1D601A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1D60214", Offset = "0x1D60214", VA = "0x1D60214")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1D602CC", Offset = "0x1D602CC", VA = "0x1D602CC")]
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
			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x1DA9DB0", Offset = "0x1DA9DB0", VA = "0x1DA9DB0")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x1DA9EF0", Offset = "0x1DA9EF0", VA = "0x1DA9EF0")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x17EF584", Offset = "0x17EF584", VA = "0x17EF584")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x17EF600", Offset = "0x17EF600", VA = "0x17EF600")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1E23914", Offset = "0x1E23914", VA = "0x1E23914")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1E23A78", Offset = "0x1E23A78", VA = "0x1E23A78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1E23C5C", Offset = "0x1E23C5C", VA = "0x1E23C5C")]
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
			[Token(Token = "0x4000815")]
			Input,
			[Token(Token = "0x4000816")]
			WASDOnly
		}

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputMode inputMode;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRIK ik;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float walkSpeed;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float runSpeed;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float walkForwardSpeedMlp;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float runForwardSpeedMlp;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 smoothInput;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 smoothInputV;

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x17F2924", Offset = "0x17F2924", VA = "0x17F2924")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x17F2AB4", Offset = "0x17F2AB4", VA = "0x17F2AB4")]
		private Vector3 GetInput()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x17F2C74", Offset = "0x17F2C74", VA = "0x17F2C74")]
		public VRController()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class VRIKArmMocap : MonoBehaviour
	{
		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftElbowTarget;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightElbowTarget;

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x17F3050", Offset = "0x17F3050", VA = "0x17F3050")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x17F3128", Offset = "0x17F3128", VA = "0x17F3128")]
		private void AfterVRIK()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x17F31AC", Offset = "0x17F31AC", VA = "0x17F31AC")]
		private static void UpdateArm(Transform upperArm, Transform forearm, Transform hand, Transform elbowTarget, Transform handTarget)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x17F343C", Offset = "0x17F343C", VA = "0x17F343C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x17F356C", Offset = "0x17F356C", VA = "0x17F356C")]
		public VRIKArmMocap()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836170", Offset = "0x836170")]
		public VRIK ik;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8361A8", Offset = "0x8361A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8361A8", Offset = "0x8361A8")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836208", Offset = "0x836208")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836240", Offset = "0x836240")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836278", Offset = "0x836278")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836278", Offset = "0x836278")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8362D8", Offset = "0x8362D8")]
		public Transform rightHandAnchor;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836310", Offset = "0x836310")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836348", Offset = "0x836348")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836380", Offset = "0x836380")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836380", Offset = "0x836380")]
		public float scaleMlp;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8363E0", Offset = "0x8363E0")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x17F3574", Offset = "0x17F3574", VA = "0x17F3574")]
		public void SetCalibrate()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x17F381C", Offset = "0x17F381C", VA = "0x17F381C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x17F44D4", Offset = "0x17F44D4", VA = "0x17F44D4")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836418", Offset = "0x836418")]
		public VRIK ik;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836450", Offset = "0x836450")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836488", Offset = "0x836488")]
		public Transform headTracker;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8364C0", Offset = "0x8364C0")]
		public Transform bodyTracker;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8364F8", Offset = "0x8364F8")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836530", Offset = "0x836530")]
		public Transform rightHandTracker;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836568", Offset = "0x836568")]
		public Transform leftFootTracker;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8365A0", Offset = "0x8365A0")]
		public Transform rightFootTracker;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8365D8", Offset = "0x8365D8")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x17F454C", Offset = "0x17F454C", VA = "0x17F454C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x17F596C", Offset = "0x17F596C", VA = "0x17F596C")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1511728", Offset = "0x1511728", VA = "0x1511728")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1511784", Offset = "0x1511784", VA = "0x1511784")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x151190C", Offset = "0x151190C", VA = "0x151190C")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1511940", Offset = "0x1511940", VA = "0x1511940")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1511DDC", Offset = "0x1511DDC", VA = "0x1511DDC")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000D4")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1D6A344", Offset = "0x1D6A344", VA = "0x1D6A344", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1D6A320", Offset = "0x1D6A320", VA = "0x1D6A320", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1D6A34C", Offset = "0x1D6A34C", VA = "0x1D6A34C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1D6A3B0", Offset = "0x1D6A3B0", VA = "0x1D6A3B0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1D6A548", Offset = "0x1D6A548", VA = "0x1D6A548", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1D6A76C", Offset = "0x1D6A76C", VA = "0x1D6A76C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1D6A558", Offset = "0x1D6A558", VA = "0x1D6A558")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1D6A77C", Offset = "0x1D6A77C", VA = "0x1D6A77C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1D6A794", Offset = "0x1D6A794", VA = "0x1D6A794", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1D6A7F8", Offset = "0x1D6A7F8", VA = "0x1D6A7F8", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1D6A894", Offset = "0x1D6A894", VA = "0x1D6A894")]
		private void Update()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1D6A9AC", Offset = "0x1D6A9AC", VA = "0x1D6A9AC")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x836640", Offset = "0x836640")]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000849")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x400084A")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000D5")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x1D6AA6C", Offset = "0x1D6AA6C", VA = "0x1D6AA6C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1D6A9C4", Offset = "0x1D6A9C4", VA = "0x1D6A9C4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1D6AA50", Offset = "0x1D6AA50", VA = "0x1D6AA50", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1D6AB64", Offset = "0x1D6AB64", VA = "0x1D6AB64", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1D6AF48", Offset = "0x1D6AF48", VA = "0x1D6AF48")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1D6B124", Offset = "0x1D6B124", VA = "0x1D6B124")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836684", Offset = "0x836684")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836684", Offset = "0x836684")]
		public Transform gravityTarget;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8366E4", Offset = "0x8366E4")]
		public float gravityMultiplier;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000858")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000814")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1212E74", Offset = "0x1212E74", VA = "0x1212E74")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1212FA4", Offset = "0x1212FA4", VA = "0x1212FA4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x121318C", Offset = "0x121318C", VA = "0x121318C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1213354", Offset = "0x1213354", VA = "0x1213354")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x12133B8", Offset = "0x12133B8", VA = "0x12133B8")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x12134D8", Offset = "0x12134D8", VA = "0x12134D8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x12135FC", Offset = "0x12135FC", VA = "0x12135FC")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1213620", Offset = "0x1213620", VA = "0x1213620")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1213644", Offset = "0x1213644", VA = "0x1213644")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x12136A4", Offset = "0x12136A4", VA = "0x12136A4")]
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
			[Token(Token = "0x4000897")]
			Directional,
			[Token(Token = "0x4000898")]
			Strafe
		}

		[Token(Token = "0x2000132")]
		public struct AnimState
		{
			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B630", Offset = "0x82B630")]
		private sealed class <JumpSmooth>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <steps>5__1;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <stepsToTake>5__2;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000836")]
				[Address(RVA = "0x1513728", Offset = "0x1513728", VA = "0x1513728", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000838")]
				[Address(RVA = "0x1513770", Offset = "0x1513770", VA = "0x1513770", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x15135FC", Offset = "0x15135FC", VA = "0x15135FC")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0x1513628", Offset = "0x1513628", VA = "0x1513628", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x151362C", Offset = "0x151362C", VA = "0x151362C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x1513730", Offset = "0x1513730", VA = "0x1513730", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83671C", Offset = "0x83671C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836754", Offset = "0x836754")]
		public MoveMode moveMode;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83678C", Offset = "0x83678C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8367C4", Offset = "0x8367C4")]
		public bool smoothJump;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8367FC", Offset = "0x8367FC")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836834", Offset = "0x836834")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x83686C", Offset = "0x83686C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83686C", Offset = "0x83686C")]
		private bool <fullRootMotion>k__BackingField;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368A8", Offset = "0x8368A8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8368A8", Offset = "0x8368A8")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000D6")]
		public bool fullRootMotion
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x12139D0", Offset = "0x12139D0", VA = "0x12139D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393FC", Offset = "0x8393FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x12139D8", Offset = "0x12139D8", VA = "0x12139D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83940C", Offset = "0x83940C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public bool onGround
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x12139E4", Offset = "0x12139E4", VA = "0x12139E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83941C", Offset = "0x83941C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x12139EC", Offset = "0x12139EC", VA = "0x12139EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83942C", Offset = "0x83942C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x12139F8", Offset = "0x12139F8", VA = "0x12139F8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x1213B60", Offset = "0x1213B60", VA = "0x1213B60")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1213BF0", Offset = "0x1213BF0", VA = "0x1213BF0", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1213CB8", Offset = "0x1213CB8", VA = "0x1213CB8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1214904", Offset = "0x1214904", VA = "0x1214904", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1214B5C", Offset = "0x1214B5C", VA = "0x1214B5C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x12141CC", Offset = "0x12141CC", VA = "0x12141CC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1214C40", Offset = "0x1214C40", VA = "0x1214C40")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x12150E8", Offset = "0x12150E8", VA = "0x12150E8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x121498C", Offset = "0x121498C", VA = "0x121498C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1215190", Offset = "0x1215190", VA = "0x1215190", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x12154CC", Offset = "0x12154CC", VA = "0x12154CC")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x12155BC", Offset = "0x12155BC", VA = "0x12155BC", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x121571C", Offset = "0x121571C", VA = "0x121571C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83943C", Offset = "0x83943C")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1214550", Offset = "0x1214550", VA = "0x1214550")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x12157B8", Offset = "0x12157B8", VA = "0x12157B8")]
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
			[Token(Token = "0x40008B4")]
			Smooth,
			[Token(Token = "0x40008B5")]
			Linear
		}

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8368E4", Offset = "0x8368E4")]
		public CameraController cameraController;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83691C", Offset = "0x83691C")]
		public float accelerationTime;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836954", Offset = "0x836954")]
		public float turnTime;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83698C", Offset = "0x83698C")]
		public bool walkByDefault;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8369C4", Offset = "0x8369C4")]
		public RotationMode rotationMode;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8369FC", Offset = "0x8369FC")]
		public float moveSpeed;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x836A34", Offset = "0x836A34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A34", Offset = "0x836A34")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000DA")]
		public bool isGrounded
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x17EDBC8", Offset = "0x17EDBC8", VA = "0x17EDBC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394EC", Offset = "0x8394EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x17EDBD0", Offset = "0x17EDBD0", VA = "0x17EDBD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394FC", Offset = "0x8394FC")]
			private set
			{
			}
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x17EDBDC", Offset = "0x17EDBDC", VA = "0x17EDBDC")]
		private void Start()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x17EDC80", Offset = "0x17EDC80", VA = "0x17EDC80")]
		private void Update()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x17EE140", Offset = "0x17EE140", VA = "0x17EE140")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x17EDCD4", Offset = "0x17EDCD4", VA = "0x17EDCD4")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x17EDF54", Offset = "0x17EDF54", VA = "0x17EDF54")]
		private void Move()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x17EE17C", Offset = "0x17EE17C", VA = "0x17EE17C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x17EE218", Offset = "0x17EE218", VA = "0x17EE218")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x17EE29C", Offset = "0x17EE29C", VA = "0x17EE29C")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x17F0FA4", Offset = "0x17F0FA4", VA = "0x17F0FA4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x17F1028", Offset = "0x17F1028", VA = "0x17F1028", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x17F11EC", Offset = "0x17F11EC", VA = "0x17F11EC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x17F1214", Offset = "0x17F1214", VA = "0x17F1214")]
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
			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x17F0FE8", Offset = "0x17F0FE8", VA = "0x17F0FE8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x17F1350", Offset = "0x17F1350", VA = "0x17F1350", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x17F1240", Offset = "0x17F1240", VA = "0x17F1240")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1D5BA3C", Offset = "0x1D5BA3C", VA = "0x1D5BA3C")]
		private void Update()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1D5BA78", Offset = "0x1D5BA78", VA = "0x1D5BA78")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x17EE2C4", Offset = "0x17EE2C4", VA = "0x17EE2C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x17EE2F8", Offset = "0x17EE2F8", VA = "0x17EE2F8")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x17EE3A8", Offset = "0x17EE3A8", VA = "0x17EE3A8")]
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
			[Token(Token = "0x40008D7")]
			Idle,
			[Token(Token = "0x40008D8")]
			Seeking,
			[Token(Token = "0x40008D9")]
			OnPath
		}

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836A70", Offset = "0x836A70")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836AA8", Offset = "0x836AA8")]
		public float cornerRadius;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836AE0", Offset = "0x836AE0")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836B18", Offset = "0x836B18")]
		public float maxSampleDistance;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836B50", Offset = "0x836B50")]
		public float nextPathInterval;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836B88", Offset = "0x836B88")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x836B88", Offset = "0x836B88")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x836BC4", Offset = "0x836BC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836BC4", Offset = "0x836BC4")]
		private State <state>k__BackingField;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000DB")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1DF4700", Offset = "0x1DF4700", VA = "0x1DF4700")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83950C", Offset = "0x83950C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x1DF470C", Offset = "0x1DF470C", VA = "0x1DF470C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83951C", Offset = "0x83951C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public State state
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1DF4718", Offset = "0x1DF4718", VA = "0x1DF4718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83952C", Offset = "0x83952C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x1DF4720", Offset = "0x1DF4720", VA = "0x1DF4720")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83953C", Offset = "0x83953C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1DF4728", Offset = "0x1DF4728", VA = "0x1DF4728")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1DF47FC", Offset = "0x1DF47FC", VA = "0x1DF47FC")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1DF4BFC", Offset = "0x1DF4BFC", VA = "0x1DF4BFC")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1DF4C78", Offset = "0x1DF4C78", VA = "0x1DF4C78")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x1DF4BB8", Offset = "0x1DF4BB8", VA = "0x1DF4BB8")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x1DF4BE8", Offset = "0x1DF4BE8", VA = "0x1DF4BE8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x1DF4DC4", Offset = "0x1DF4DC4", VA = "0x1DF4DC4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1DF4F74", Offset = "0x1DF4F74", VA = "0x1DF4F74")]
		public Navigator()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200013D")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B650", Offset = "0x82B650")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x1513A70", Offset = "0x1513A70", VA = "0x1513A70")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x1513A78", Offset = "0x1513A78", VA = "0x1513A78")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x1513A94", Offset = "0x1513A94", VA = "0x1513A94")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B660", Offset = "0x82B660")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x1513AB0", Offset = "0x1513AB0", VA = "0x1513AB0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x1513AB8", Offset = "0x1513AB8", VA = "0x1513AB8")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x1513AD4", Offset = "0x1513AD4", VA = "0x1513AD4")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B670", Offset = "0x82B670")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x1513AF0", Offset = "0x1513AF0", VA = "0x1513AF0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x1513AF8", Offset = "0x1513AF8", VA = "0x1513AF8")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x1513B38", Offset = "0x1513B38", VA = "0x1513B38")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x121AFB8", Offset = "0x121AFB8", VA = "0x121AFB8")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x121B188", Offset = "0x121B188", VA = "0x121B188")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x121B330", Offset = "0x121B330", VA = "0x121B330")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x121B4EC", Offset = "0x121B4EC", VA = "0x121B4EC")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x121B560", Offset = "0x121B560", VA = "0x121B560")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x121B5D4", Offset = "0x121B5D4", VA = "0x121B5D4")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x121B638", Offset = "0x121B638", VA = "0x121B638")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x121B6BC", Offset = "0x121B6BC", VA = "0x121B6BC")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x121B720", Offset = "0x121B720", VA = "0x121B720")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x121B784", Offset = "0x121B784", VA = "0x121B784")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x121B7E8", Offset = "0x121B7E8", VA = "0x121B7E8")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x121B84C", Offset = "0x121B84C", VA = "0x121B84C")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x121B8B8", Offset = "0x121B8B8", VA = "0x121B8B8")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x121B920", Offset = "0x121B920", VA = "0x121B920")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x121B984", Offset = "0x121B984", VA = "0x121B984")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000141")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B690", Offset = "0x82B690")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x1513B5C", Offset = "0x1513B5C", VA = "0x1513B5C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x1513B64", Offset = "0x1513B64", VA = "0x1513B64")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B6A0", Offset = "0x82B6A0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x1513CA4", Offset = "0x1513CA4", VA = "0x1513CA4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x1513CAC", Offset = "0x1513CAC", VA = "0x1513CAC")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B6B0", Offset = "0x82B6B0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x1513CC8", Offset = "0x1513CC8", VA = "0x1513CC8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x1513CD0", Offset = "0x1513CD0", VA = "0x1513CD0")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B6C0", Offset = "0x82B6C0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x1513CEC", Offset = "0x1513CEC", VA = "0x1513CEC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x1513CF4", Offset = "0x1513CF4", VA = "0x1513CF4")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B6D0", Offset = "0x82B6D0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x1513D10", Offset = "0x1513D10", VA = "0x1513D10")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x1513D18", Offset = "0x1513D18", VA = "0x1513D18")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B6E0", Offset = "0x82B6E0")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1513D34", Offset = "0x1513D34", VA = "0x1513D34")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x1513D3C", Offset = "0x1513D3C", VA = "0x1513D3C")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B6F0", Offset = "0x82B6F0")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x1513D58", Offset = "0x1513D58", VA = "0x1513D58")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x1513D60", Offset = "0x1513D60", VA = "0x1513D60")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x1513D7C", Offset = "0x1513D7C", VA = "0x1513D7C")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1513DB0", Offset = "0x1513DB0", VA = "0x1513DB0")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1513DCC", Offset = "0x1513DCC", VA = "0x1513DCC")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1513DE8", Offset = "0x1513DE8", VA = "0x1513DE8")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B700", Offset = "0x82B700")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1513EA8", Offset = "0x1513EA8", VA = "0x1513EA8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1513EB0", Offset = "0x1513EB0", VA = "0x1513EB0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B710", Offset = "0x82B710")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x1513ECC", Offset = "0x1513ECC", VA = "0x1513ECC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x1513ED4", Offset = "0x1513ED4", VA = "0x1513ED4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1513EF0", Offset = "0x1513EF0", VA = "0x1513EF0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B720", Offset = "0x82B720")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1513FF0", Offset = "0x1513FF0", VA = "0x1513FF0")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1513FF8", Offset = "0x1513FF8", VA = "0x1513FF8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B730", Offset = "0x82B730")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1513B80", Offset = "0x1513B80", VA = "0x1513B80")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1513B88", Offset = "0x1513B88", VA = "0x1513B88")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x1513BA4", Offset = "0x1513BA4", VA = "0x1513BA4")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x1217F30", Offset = "0x1217F30", VA = "0x1217F30")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x121B9E8", Offset = "0x121B9E8", VA = "0x121B9E8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x121BBB8", Offset = "0x121BBB8", VA = "0x121BBB8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x121BD88", Offset = "0x121BD88", VA = "0x121BD88")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x12182E0", Offset = "0x12182E0", VA = "0x12182E0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x121BF58", Offset = "0x121BF58", VA = "0x121BF58")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x121C1AC", Offset = "0x121C1AC", VA = "0x121C1AC")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x121C6E0", Offset = "0x121C6E0", VA = "0x121C6E0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x121C95C", Offset = "0x121C95C", VA = "0x121C95C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x121CBF8", Offset = "0x121CBF8", VA = "0x121CBF8")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x121CDE8", Offset = "0x121CDE8", VA = "0x121CDE8")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200014D")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B750", Offset = "0x82B750")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1514014", Offset = "0x1514014", VA = "0x1514014")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x151401C", Offset = "0x151401C", VA = "0x151401C")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B760", Offset = "0x82B760")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1514038", Offset = "0x1514038", VA = "0x1514038")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1514040", Offset = "0x1514040", VA = "0x1514040")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B770", Offset = "0x82B770")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x151405C", Offset = "0x151405C", VA = "0x151405C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1514064", Offset = "0x1514064", VA = "0x1514064")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B780", Offset = "0x82B780")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x1514080", Offset = "0x1514080", VA = "0x1514080")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x1514088", Offset = "0x1514088", VA = "0x1514088")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B790", Offset = "0x82B790")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x15140A4", Offset = "0x15140A4", VA = "0x15140A4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x15140AC", Offset = "0x15140AC", VA = "0x15140AC")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x15140C8", Offset = "0x15140C8", VA = "0x15140C8")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x15140E4", Offset = "0x15140E4", VA = "0x15140E4")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x1514118", Offset = "0x1514118", VA = "0x1514118")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1514134", Offset = "0x1514134", VA = "0x1514134")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1514150", Offset = "0x1514150", VA = "0x1514150")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B7A0", Offset = "0x82B7A0")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1514208", Offset = "0x1514208", VA = "0x1514208")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1514210", Offset = "0x1514210", VA = "0x1514210")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x1514238", Offset = "0x1514238", VA = "0x1514238")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B7B0", Offset = "0x82B7B0")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x1514254", Offset = "0x1514254", VA = "0x1514254")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x151425C", Offset = "0x151425C", VA = "0x151425C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1514278", Offset = "0x1514278", VA = "0x1514278")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B7C0", Offset = "0x82B7C0")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1514370", Offset = "0x1514370", VA = "0x1514370")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1514378", Offset = "0x1514378", VA = "0x1514378")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x15143A0", Offset = "0x15143A0", VA = "0x15143A0")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000156")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B7D0", Offset = "0x82B7D0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x15143BC", Offset = "0x15143BC", VA = "0x15143BC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x15143C4", Offset = "0x15143C4", VA = "0x15143C4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x15143E0", Offset = "0x15143E0", VA = "0x15143E0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x121810C", Offset = "0x121810C", VA = "0x121810C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x121CFF8", Offset = "0x121CFF8", VA = "0x121CFF8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x121D1C4", Offset = "0x121D1C4", VA = "0x121D1C4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x12184B8", Offset = "0x12184B8", VA = "0x12184B8")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x121D390", Offset = "0x121D390", VA = "0x121D390")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x121D7EC", Offset = "0x121D7EC", VA = "0x121D7EC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x121DAEC", Offset = "0x121DAEC", VA = "0x121DAEC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x121DE10", Offset = "0x121DE10", VA = "0x121DE10")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x121DFFC", Offset = "0x121DFFC", VA = "0x121DFFC")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000157")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B7F0", Offset = "0x82B7F0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x15144D8", Offset = "0x15144D8", VA = "0x15144D8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x15144E0", Offset = "0x15144E0", VA = "0x15144E0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x15144FC", Offset = "0x15144FC", VA = "0x15144FC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B800", Offset = "0x82B800")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1514518", Offset = "0x1514518", VA = "0x1514518")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x1514520", Offset = "0x1514520", VA = "0x1514520")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x151453C", Offset = "0x151453C", VA = "0x151453C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B810", Offset = "0x82B810")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1514558", Offset = "0x1514558", VA = "0x1514558")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1514560", Offset = "0x1514560", VA = "0x1514560")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x151456C", Offset = "0x151456C", VA = "0x151456C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1218834", Offset = "0x1218834", VA = "0x1218834")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1218DA4", Offset = "0x1218DA4", VA = "0x1218DA4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x121E20C", Offset = "0x121E20C", VA = "0x121E20C")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x121E3F8", Offset = "0x121E3F8", VA = "0x121E3F8")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200015B")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x200015C")]
		public static class Utils
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1515638", Offset = "0x1515638", VA = "0x1515638")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B830", Offset = "0x82B830")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x1514618", Offset = "0x1514618", VA = "0x1514618")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x1514620", Offset = "0x1514620", VA = "0x1514620")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x151463C", Offset = "0x151463C", VA = "0x151463C")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B840", Offset = "0x82B840")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x15148D8", Offset = "0x15148D8", VA = "0x15148D8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x15148E0", Offset = "0x15148E0", VA = "0x15148E0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x1514904", Offset = "0x1514904", VA = "0x1514904")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B850", Offset = "0x82B850")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1514CEC", Offset = "0x1514CEC", VA = "0x1514CEC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x1514CF4", Offset = "0x1514CF4", VA = "0x1514CF4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x1514D18", Offset = "0x1514D18", VA = "0x1514D18")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B860", Offset = "0x82B860")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x15151F0", Offset = "0x15151F0", VA = "0x15151F0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x15151F8", Offset = "0x15151F8", VA = "0x15151F8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x151521C", Offset = "0x151521C", VA = "0x151521C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B870", Offset = "0x82B870")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1515350", Offset = "0x1515350", VA = "0x1515350")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x1515358", Offset = "0x1515358", VA = "0x1515358")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x151537C", Offset = "0x151537C", VA = "0x151537C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B880", Offset = "0x82B880")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x15153A0", Offset = "0x15153A0", VA = "0x15153A0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x15153A8", Offset = "0x15153A8", VA = "0x15153A8")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x15153C4", Offset = "0x15153C4", VA = "0x15153C4")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B890", Offset = "0x82B890")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x15153E0", Offset = "0x15153E0", VA = "0x15153E0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x15153E8", Offset = "0x15153E8", VA = "0x15153E8")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x151544C", Offset = "0x151544C", VA = "0x151544C")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B8A0", Offset = "0x82B8A0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x15154A8", Offset = "0x15154A8", VA = "0x15154A8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x15154B0", Offset = "0x15154B0", VA = "0x15154B0")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x1515514", Offset = "0x1515514", VA = "0x1515514")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B8B0", Offset = "0x82B8B0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x1515570", Offset = "0x1515570", VA = "0x1515570")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x1515578", Offset = "0x1515578", VA = "0x1515578")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x15155DC", Offset = "0x15155DC", VA = "0x15155DC")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B8C0", Offset = "0x82B8C0")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x1514658", Offset = "0x1514658", VA = "0x1514658")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x1514660", Offset = "0x1514660", VA = "0x1514660")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x151467C", Offset = "0x151467C", VA = "0x151467C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B8D0", Offset = "0x82B8D0")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x1514698", Offset = "0x1514698", VA = "0x1514698")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x15146A0", Offset = "0x15146A0", VA = "0x15146A0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x15146BC", Offset = "0x15146BC", VA = "0x15146BC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B8E0", Offset = "0x82B8E0")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x15146D8", Offset = "0x15146D8", VA = "0x15146D8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x15146E0", Offset = "0x15146E0", VA = "0x15146E0")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x15146FC", Offset = "0x15146FC", VA = "0x15146FC")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B8F0", Offset = "0x82B8F0")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1514718", Offset = "0x1514718", VA = "0x1514718")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1514720", Offset = "0x1514720", VA = "0x1514720")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x151473C", Offset = "0x151473C", VA = "0x151473C")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B900", Offset = "0x82B900")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x1514758", Offset = "0x1514758", VA = "0x1514758")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x1514760", Offset = "0x1514760", VA = "0x1514760")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x151477C", Offset = "0x151477C", VA = "0x151477C")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B910", Offset = "0x82B910")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x1514798", Offset = "0x1514798", VA = "0x1514798")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x15147A0", Offset = "0x15147A0", VA = "0x15147A0")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x15147BC", Offset = "0x15147BC", VA = "0x15147BC")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B920", Offset = "0x82B920")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x15147D8", Offset = "0x15147D8", VA = "0x15147D8")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x15147E0", Offset = "0x15147E0", VA = "0x15147E0")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x15147FC", Offset = "0x15147FC", VA = "0x15147FC")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B930", Offset = "0x82B930")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x1514818", Offset = "0x1514818", VA = "0x1514818")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x1514820", Offset = "0x1514820", VA = "0x1514820")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x151483C", Offset = "0x151483C", VA = "0x151483C")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B940", Offset = "0x82B940")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x1514858", Offset = "0x1514858", VA = "0x1514858")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x1514860", Offset = "0x1514860", VA = "0x1514860")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x151487C", Offset = "0x151487C", VA = "0x151487C")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B950", Offset = "0x82B950")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1514898", Offset = "0x1514898", VA = "0x1514898")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x15148A0", Offset = "0x15148A0", VA = "0x15148A0")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x15148BC", Offset = "0x15148BC", VA = "0x15148BC")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B960", Offset = "0x82B960")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1514928", Offset = "0x1514928", VA = "0x1514928")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x1514930", Offset = "0x1514930", VA = "0x1514930")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x151494C", Offset = "0x151494C", VA = "0x151494C")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B970", Offset = "0x82B970")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x1514968", Offset = "0x1514968", VA = "0x1514968")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x1514970", Offset = "0x1514970", VA = "0x1514970")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x151498C", Offset = "0x151498C", VA = "0x151498C")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B980", Offset = "0x82B980")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x15149A8", Offset = "0x15149A8", VA = "0x15149A8")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x15149B0", Offset = "0x15149B0", VA = "0x15149B0")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x15149CC", Offset = "0x15149CC", VA = "0x15149CC")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B990", Offset = "0x82B990")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000938")]
			[Address(RVA = "0x15149E8", Offset = "0x15149E8", VA = "0x15149E8")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x15149F0", Offset = "0x15149F0", VA = "0x15149F0")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x1514A0C", Offset = "0x1514A0C", VA = "0x1514A0C")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B9A0", Offset = "0x82B9A0")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x1514A28", Offset = "0x1514A28", VA = "0x1514A28")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x1514A30", Offset = "0x1514A30", VA = "0x1514A30")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x1514A4C", Offset = "0x1514A4C", VA = "0x1514A4C")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B9B0", Offset = "0x82B9B0")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x1514A68", Offset = "0x1514A68", VA = "0x1514A68")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x1514A70", Offset = "0x1514A70", VA = "0x1514A70")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x1514A8C", Offset = "0x1514A8C", VA = "0x1514A8C")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B9C0", Offset = "0x82B9C0")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x1514AA8", Offset = "0x1514AA8", VA = "0x1514AA8")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x1514AB0", Offset = "0x1514AB0", VA = "0x1514AB0")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x1514AD8", Offset = "0x1514AD8", VA = "0x1514AD8")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B9D0", Offset = "0x82B9D0")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000944")]
			[Address(RVA = "0x1514AF4", Offset = "0x1514AF4", VA = "0x1514AF4")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0x1514AFC", Offset = "0x1514AFC", VA = "0x1514AFC")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0x1514B24", Offset = "0x1514B24", VA = "0x1514B24")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B9E0", Offset = "0x82B9E0")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000947")]
			[Address(RVA = "0x1514B40", Offset = "0x1514B40", VA = "0x1514B40")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x1514B48", Offset = "0x1514B48", VA = "0x1514B48")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000949")]
			[Address(RVA = "0x1514B70", Offset = "0x1514B70", VA = "0x1514B70")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000179")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B9F0", Offset = "0x82B9F0")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x1514B8C", Offset = "0x1514B8C", VA = "0x1514B8C")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x1514B94", Offset = "0x1514B94", VA = "0x1514B94")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600094C")]
			[Address(RVA = "0x1514BB0", Offset = "0x1514BB0", VA = "0x1514BB0")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0x1514BCC", Offset = "0x1514BCC", VA = "0x1514BCC")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x1514C00", Offset = "0x1514C00", VA = "0x1514C00")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x1514C1C", Offset = "0x1514C1C", VA = "0x1514C1C")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x1514C38", Offset = "0x1514C38", VA = "0x1514C38")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200017A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA00", Offset = "0x82BA00")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x1514D3C", Offset = "0x1514D3C", VA = "0x1514D3C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x1514D44", Offset = "0x1514D44", VA = "0x1514D44")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x1514D98", Offset = "0x1514D98", VA = "0x1514D98")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA10", Offset = "0x82BA10")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x1514DE4", Offset = "0x1514DE4", VA = "0x1514DE4")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x1514DEC", Offset = "0x1514DEC", VA = "0x1514DEC")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x1514E08", Offset = "0x1514E08", VA = "0x1514E08")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200017C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA20", Offset = "0x82BA20")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1514E24", Offset = "0x1514E24", VA = "0x1514E24")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x1514E2C", Offset = "0x1514E2C", VA = "0x1514E2C")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x1514E48", Offset = "0x1514E48", VA = "0x1514E48")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA30", Offset = "0x82BA30")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x1514E64", Offset = "0x1514E64", VA = "0x1514E64")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1514E6C", Offset = "0x1514E6C", VA = "0x1514E6C")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x1514E90", Offset = "0x1514E90", VA = "0x1514E90")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA40", Offset = "0x82BA40")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x1514EB4", Offset = "0x1514EB4", VA = "0x1514EB4")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x1514EBC", Offset = "0x1514EBC", VA = "0x1514EBC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x1514EE0", Offset = "0x1514EE0", VA = "0x1514EE0")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA50", Offset = "0x82BA50")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1514F04", Offset = "0x1514F04", VA = "0x1514F04")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x1514F0C", Offset = "0x1514F0C", VA = "0x1514F0C")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0x1514F14", Offset = "0x1514F14", VA = "0x1514F14")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x2000180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA60", Offset = "0x82BA60")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x1514FB0", Offset = "0x1514FB0", VA = "0x1514FB0")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0x1514FB8", Offset = "0x1514FB8", VA = "0x1514FB8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0x1514FDC", Offset = "0x1514FDC", VA = "0x1514FDC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000181")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA70", Offset = "0x82BA70")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x1515000", Offset = "0x1515000", VA = "0x1515000")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x1515008", Offset = "0x1515008", VA = "0x1515008")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x151502C", Offset = "0x151502C", VA = "0x151502C")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA80", Offset = "0x82BA80")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1515050", Offset = "0x1515050", VA = "0x1515050")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x1515058", Offset = "0x1515058", VA = "0x1515058")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x1515064", Offset = "0x1515064", VA = "0x1515064")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA90", Offset = "0x82BA90")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x600096C")]
			[Address(RVA = "0x1515120", Offset = "0x1515120", VA = "0x1515120")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x1515128", Offset = "0x1515128", VA = "0x1515128")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x1515134", Offset = "0x1515134", VA = "0x1515134")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BAA0", Offset = "0x82BAA0")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x1515240", Offset = "0x1515240", VA = "0x1515240")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x1515248", Offset = "0x1515248", VA = "0x1515248")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x1515254", Offset = "0x1515254", VA = "0x1515254")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BAB0", Offset = "0x82BAB0")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x1515310", Offset = "0x1515310", VA = "0x1515310")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x1515318", Offset = "0x1515318", VA = "0x1515318")]
			internal Vector2 <DOShapeCircle>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x1515334", Offset = "0x1515334", VA = "0x1515334")]
			internal void <DOShapeCircle>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x121929C", Offset = "0x121929C", VA = "0x121929C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1218A04", Offset = "0x1218A04", VA = "0x1218A04")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1218F4C", Offset = "0x1218F4C", VA = "0x1218F4C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x121E654", Offset = "0x121E654", VA = "0x121E654")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x121E824", Offset = "0x121E824", VA = "0x121E824")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x121E9CC", Offset = "0x121E9CC", VA = "0x121E9CC")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x121EB98", Offset = "0x121EB98", VA = "0x121EB98")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x121ED8C", Offset = "0x121ED8C", VA = "0x121ED8C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x121EF5C", Offset = "0x121EF5C", VA = "0x121EF5C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x121F12C", Offset = "0x121F12C", VA = "0x121F12C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x121F2FC", Offset = "0x121F2FC", VA = "0x121F2FC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x121F4CC", Offset = "0x121F4CC", VA = "0x121F4CC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x121F674", Offset = "0x121F674", VA = "0x121F674")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x121F82C", Offset = "0x121F82C", VA = "0x121F82C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x121F9FC", Offset = "0x121F9FC", VA = "0x121F9FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x121FBC4", Offset = "0x121FBC4", VA = "0x121FBC4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1217D58", Offset = "0x1217D58", VA = "0x1217D58")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x121FD8C", Offset = "0x121FD8C", VA = "0x121FD8C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x121FF58", Offset = "0x121FF58", VA = "0x121FF58")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1220124", Offset = "0x1220124", VA = "0x1220124")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x12202F0", Offset = "0x12202F0", VA = "0x12202F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x12204C0", Offset = "0x12204C0", VA = "0x12204C0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1220690", Offset = "0x1220690", VA = "0x1220690")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1220848", Offset = "0x1220848", VA = "0x1220848")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1220A04", Offset = "0x1220A04", VA = "0x1220A04")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1218664", Offset = "0x1218664", VA = "0x1218664")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1219698", Offset = "0x1219698", VA = "0x1219698")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1220BC0", Offset = "0x1220BC0", VA = "0x1220BC0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1219870", Offset = "0x1219870", VA = "0x1219870")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1220DC0", Offset = "0x1220DC0", VA = "0x1220DC0")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1221214", Offset = "0x1221214", VA = "0x1221214")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x12213D8", Offset = "0x12213D8", VA = "0x12213D8")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x122158C", Offset = "0x122158C", VA = "0x122158C")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1221740", Offset = "0x1221740", VA = "0x1221740")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1218BD4", Offset = "0x1218BD4", VA = "0x1218BD4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x1221900", Offset = "0x1221900", VA = "0x1221900")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x12190F4", Offset = "0x12190F4", VA = "0x12190F4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1219444", Offset = "0x1219444", VA = "0x1219444")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x1221B28", Offset = "0x1221B28", VA = "0x1221B28")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x1221D8C", Offset = "0x1221D8C", VA = "0x1221D8C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x1221FF0", Offset = "0x1221FF0", VA = "0x1221FF0")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x1222254", Offset = "0x1222254", VA = "0x1222254")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000186")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BAD0", Offset = "0x82BAD0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x151587C", Offset = "0x151587C", VA = "0x151587C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x1515884", Offset = "0x1515884", VA = "0x1515884")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x15158A8", Offset = "0x15158A8", VA = "0x15158A8")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BAE0", Offset = "0x82BAE0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x15158CC", Offset = "0x15158CC", VA = "0x15158CC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x15158D4", Offset = "0x15158D4", VA = "0x15158D4")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x15158F8", Offset = "0x15158F8", VA = "0x15158F8")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BAF0", Offset = "0x82BAF0")]
		private sealed class <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int <>1__state;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Tween t;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x151591C", Offset = "0x151591C", VA = "0x151591C")]
			public <AsyncWaitForCompletion>d__10()
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x1515924", Offset = "0x1515924", VA = "0x1515924", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x1515B70", Offset = "0x1515B70", VA = "0x1515B70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200018A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BB00", Offset = "0x82BB00")]
		private sealed class <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int <>1__state;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Tween t;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x1516290", Offset = "0x1516290", VA = "0x1516290")]
			public <AsyncWaitForRewind>d__11()
			{
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x1516298", Offset = "0x1516298", VA = "0x1516298", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x1516508", Offset = "0x1516508", VA = "0x1516508", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200018B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BB10", Offset = "0x82BB10")]
		private sealed class <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int <>1__state;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Tween t;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x1515DD4", Offset = "0x1515DD4", VA = "0x1515DD4")]
			public <AsyncWaitForKill>d__12()
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x1515DDC", Offset = "0x1515DDC", VA = "0x1515DDC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x1516014", Offset = "0x1516014", VA = "0x1516014", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BB20", Offset = "0x82BB20")]
		private sealed class <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int <>1__state;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Tween t;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int elapsedLoops;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x1515B74", Offset = "0x1515B74", VA = "0x1515B74")]
			public <AsyncWaitForElapsedLoops>d__13()
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x1515B7C", Offset = "0x1515B7C", VA = "0x1515B7C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x1515DD0", Offset = "0x1515DD0", VA = "0x1515DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BB30", Offset = "0x82BB30")]
		private sealed class <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int <>1__state;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Tween t;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float position;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x1516018", Offset = "0x1516018", VA = "0x1516018")]
			public <AsyncWaitForPosition>d__14()
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x1516020", Offset = "0x1516020", VA = "0x1516020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x151628C", Offset = "0x151628C", VA = "0x151628C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200018E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BB40", Offset = "0x82BB40")]
		private sealed class <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int <>1__state;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Tween t;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x151650C", Offset = "0x151650C", VA = "0x151650C")]
			public <AsyncWaitForStart>d__15()
			{
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x1516514", Offset = "0x1516514", VA = "0x1516514", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x1516758", Offset = "0x1516758", VA = "0x1516758", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1222464", Offset = "0x1222464", VA = "0x1222464")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x1222654", Offset = "0x1222654", VA = "0x1222654")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1222858", Offset = "0x1222858", VA = "0x1222858")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1222918", Offset = "0x1222918", VA = "0x1222918")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x12229D8", Offset = "0x12229D8", VA = "0x12229D8")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1222A98", Offset = "0x1222A98", VA = "0x1222A98")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1222B68", Offset = "0x1222B68", VA = "0x1222B68")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1222C38", Offset = "0x1222C38", VA = "0x1222C38")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1222CF8", Offset = "0x1222CF8", VA = "0x1222CF8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1222F20", Offset = "0x1222F20", VA = "0x1222F20")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1223148", Offset = "0x1223148", VA = "0x1223148")]
		[DebuggerStepThrough]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x839AFC", Offset = "0x839AFC")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x122327C", Offset = "0x122327C", VA = "0x122327C")]
		[DebuggerStepThrough]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x839B7C", Offset = "0x839B7C")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x12233B0", Offset = "0x12233B0", VA = "0x12233B0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x839BFC", Offset = "0x839BFC")]
		[DebuggerStepThrough]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x12234E4", Offset = "0x12234E4", VA = "0x12234E4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x839C7C", Offset = "0x839C7C")]
		[DebuggerStepThrough]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x122362C", Offset = "0x122362C", VA = "0x122362C")]
		[DebuggerStepThrough]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x839CFC", Offset = "0x839CFC")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x122377C", Offset = "0x122377C", VA = "0x122377C")]
		[DebuggerStepThrough]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x839D7C", Offset = "0x839D7C")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200018F")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000190")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000DD")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600099D")]
				[Address(RVA = "0x1513778", Offset = "0x1513778", VA = "0x1513778", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x15137AC", Offset = "0x15137AC", VA = "0x15137AC")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000191")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000DE")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x1513970", Offset = "0x1513970", VA = "0x1513970", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x15139D4", Offset = "0x15139D4", VA = "0x15139D4")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000192")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000DF")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60009A1")]
				[Address(RVA = "0x1513874", Offset = "0x1513874", VA = "0x1513874", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x1513890", Offset = "0x1513890", VA = "0x1513890")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000193")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000E0")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60009A3")]
				[Address(RVA = "0x15137E0", Offset = "0x15137E0", VA = "0x15137E0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x151382C", Offset = "0x151382C", VA = "0x151382C")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000194")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000E1")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60009A5")]
				[Address(RVA = "0x15138C4", Offset = "0x15138C4", VA = "0x15138C4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x1513928", Offset = "0x1513928", VA = "0x1513928")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000195")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000E2")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60009A7")]
				[Address(RVA = "0x1513A08", Offset = "0x1513A08", VA = "0x1513A08", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x1513A3C", Offset = "0x1513A3C", VA = "0x1513A3C")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000196")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000197")]
		public static class Physics
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x151675C", Offset = "0x151675C", VA = "0x151675C")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x1516860", Offset = "0x1516860", VA = "0x1516860")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x15168F8", Offset = "0x15168F8", VA = "0x15168F8")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x1516990", Offset = "0x1516990", VA = "0x1516990")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x12238B0", Offset = "0x12238B0", VA = "0x12238B0")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x1223974", Offset = "0x1223974", VA = "0x1223974")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82BB50", Offset = "0x82BB50")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000199")]
		public enum AnimationType
		{
			[Token(Token = "0x400098A")]
			None,
			[Token(Token = "0x400098B")]
			Move,
			[Token(Token = "0x400098C")]
			LocalMove,
			[Token(Token = "0x400098D")]
			Rotate,
			[Token(Token = "0x400098E")]
			LocalRotate,
			[Token(Token = "0x400098F")]
			Scale,
			[Token(Token = "0x4000990")]
			Color,
			[Token(Token = "0x4000991")]
			Fade,
			[Token(Token = "0x4000992")]
			Text,
			[Token(Token = "0x4000993")]
			PunchPosition,
			[Token(Token = "0x4000994")]
			PunchRotation,
			[Token(Token = "0x4000995")]
			PunchScale,
			[Token(Token = "0x4000996")]
			ShakePosition,
			[Token(Token = "0x4000997")]
			ShakeRotation,
			[Token(Token = "0x4000998")]
			ShakeScale,
			[Token(Token = "0x4000999")]
			CameraAspect,
			[Token(Token = "0x400099A")]
			CameraBackgroundColor,
			[Token(Token = "0x400099B")]
			CameraFieldOfView,
			[Token(Token = "0x400099C")]
			CameraOrthoSize,
			[Token(Token = "0x400099D")]
			CameraPixelRect,
			[Token(Token = "0x400099E")]
			CameraRect,
			[Token(Token = "0x400099F")]
			UIWidthHeight
		}

		[Token(Token = "0x200019A")]
		public enum TargetType
		{
			[Token(Token = "0x40009A1")]
			Unset,
			[Token(Token = "0x40009A2")]
			Camera,
			[Token(Token = "0x40009A3")]
			CanvasGroup,
			[Token(Token = "0x40009A4")]
			Image,
			[Token(Token = "0x40009A5")]
			Light,
			[Token(Token = "0x40009A6")]
			RectTransform,
			[Token(Token = "0x40009A7")]
			Renderer,
			[Token(Token = "0x40009A8")]
			SpriteRenderer,
			[Token(Token = "0x40009A9")]
			Rigidbody,
			[Token(Token = "0x40009AA")]
			Rigidbody2D,
			[Token(Token = "0x40009AB")]
			Text,
			[Token(Token = "0x40009AC")]
			Transform,
			[Token(Token = "0x40009AD")]
			tk2dBaseSprite,
			[Token(Token = "0x40009AE")]
			tk2dTextMesh,
			[Token(Token = "0x40009AF")]
			TextMeshPro,
			[Token(Token = "0x40009B0")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool autoGenerate;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isActive;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool isValid;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool optionalBool1;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x12161B8", Offset = "0x12161B8", VA = "0x12161B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E9C", Offset = "0x839E9C")]
			add
			{
			}
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x1216274", Offset = "0x1216274", VA = "0x1216274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839EAC", Offset = "0x839EAC")]
			remove
			{
			}
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x1216330", Offset = "0x1216330", VA = "0x1216330")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x12163AC", Offset = "0x12163AC", VA = "0x12163AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x12179E8", Offset = "0x12179E8", VA = "0x12179E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x1217A34", Offset = "0x1217A34", VA = "0x1217A34")]
		private void Reset()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1217A38", Offset = "0x1217A38", VA = "0x1217A38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x1217A7C", Offset = "0x1217A7C", VA = "0x1217A7C")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x1217AC0", Offset = "0x1217AC0", VA = "0x1217AC0")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x1217B04", Offset = "0x1217B04", VA = "0x1217B04")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1217B10", Offset = "0x1217B10", VA = "0x1217B10")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x1216404", Offset = "0x1216404", VA = "0x1216404")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x1219A98", Offset = "0x1219A98", VA = "0x1219A98")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1219BB0", Offset = "0x1219BB0", VA = "0x1219BB0")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x1219CA8", Offset = "0x1219CA8", VA = "0x1219CA8", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x1219D34", Offset = "0x1219D34", VA = "0x1219D34", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x1219DC0", Offset = "0x1219DC0", VA = "0x1219DC0", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x1219E4C", Offset = "0x1219E4C", VA = "0x1219E4C", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x1219ED8", Offset = "0x1219ED8", VA = "0x1219ED8", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x1219F64", Offset = "0x1219F64", VA = "0x1219F64", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x121A05C", Offset = "0x121A05C", VA = "0x121A05C", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x121A06C", Offset = "0x121A06C", VA = "0x121A06C", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x121A3FC", Offset = "0x121A3FC", VA = "0x121A3FC", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x121A48C", Offset = "0x121A48C", VA = "0x121A48C", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x121A52C", Offset = "0x121A52C", VA = "0x121A52C")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x121A5C8", Offset = "0x121A5C8", VA = "0x121A5C8")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x121A62C", Offset = "0x121A62C", VA = "0x121A62C")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x121A690", Offset = "0x121A690", VA = "0x121A690")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x121A72C", Offset = "0x121A72C", VA = "0x121A72C")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x121A790", Offset = "0x121A790", VA = "0x121A790")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x121A82C", Offset = "0x121A82C", VA = "0x121A82C")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x121A890", Offset = "0x121A890", VA = "0x121A890")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x121A9E4", Offset = "0x121A9E4", VA = "0x121A9E4")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x121AA84", Offset = "0x121AA84", VA = "0x121AA84")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x121AB00", Offset = "0x121AB00", VA = "0x121AB00")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x121ABAC", Offset = "0x121ABAC", VA = "0x121ABAC")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x121AC2C", Offset = "0x121AC2C", VA = "0x121AC2C")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x121ACCC", Offset = "0x121ACCC", VA = "0x121ACCC")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x1217B34", Offset = "0x1217B34", VA = "0x1217B34")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x121AD34", Offset = "0x121AD34", VA = "0x121AD34")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1217B1C", Offset = "0x1217B1C", VA = "0x1217B1C")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x1219A78", Offset = "0x1219A78", VA = "0x1219A78")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x121A194", Offset = "0x121A194", VA = "0x121A194")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x121AD78", Offset = "0x121AD78", VA = "0x121AD78")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x121AFAC", Offset = "0x121AFAC", VA = "0x121AFAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839EBC", Offset = "0x839EBC")]
		private void <CreateTween>b__53_0()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x60009DC")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200019C")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x200019D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BBA8", Offset = "0x82BBA8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1516B80", Offset = "0x1516B80", VA = "0x1516B80")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x1516B88", Offset = "0x1516B88", VA = "0x1516B88")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1516BA4", Offset = "0x1516BA4", VA = "0x1516BA4")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200019E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BBB8", Offset = "0x82BBB8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1516BC0", Offset = "0x1516BC0", VA = "0x1516BC0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1516BC8", Offset = "0x1516BC8", VA = "0x1516BC8")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x1223A28", Offset = "0x1223A28", VA = "0x1223A28")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x1223A74", Offset = "0x1223A74", VA = "0x1223A74")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1223DA4", Offset = "0x1223DA4", VA = "0x1223DA4")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
