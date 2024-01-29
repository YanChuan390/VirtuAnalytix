using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Febucci.Attributes;
using Febucci.UI.Core;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8092BC", Offset = "0x8092BC")]
internal sealed class <>f__AnonymousType0<<domainAssembly>j__TPar, <assemblyType>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80A940", Offset = "0x80A940")]
	private readonly <domainAssembly>j__TPar <domainAssembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80A954", Offset = "0x80A954")]
	private readonly <assemblyType>j__TPar <assemblyType>i__Field;

	[Token(Token = "0x17000001")]
	public <domainAssembly>j__TPar domainAssembly
	{
		[Token(Token = "0x6000001")]
		get
		{
			return (<domainAssembly>j__TPar)null;
		}
	}

	[Token(Token = "0x17000002")]
	public <assemblyType>j__TPar assemblyType
	{
		[Token(Token = "0x6000002")]
		get
		{
			return (<assemblyType>j__TPar)null;
		}
	}

	[Token(Token = "0x6000003")]
	[DebuggerHidden]
	public <>f__AnonymousType0(<domainAssembly>j__TPar domainAssembly, <assemblyType>j__TPar assemblyType)
	{
	}

	[Token(Token = "0x6000004")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public class VRIKCalibrationBasic : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool dynamicScale;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80A968", Offset = "0x80A968")]
	public VRIK ik;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80A9A0", Offset = "0x80A9A0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80A9A0", Offset = "0x80A9A0")]
	public Transform centerEyeAnchor;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AA00", Offset = "0x80AA00")]
	public Vector3 headAnchorPositionOffset;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AA38", Offset = "0x80AA38")]
	public Vector3 headAnchorRotationOffset;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80AA70", Offset = "0x80AA70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AA70", Offset = "0x80AA70")]
	public Transform leftHandAnchor;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AAD0", Offset = "0x80AAD0")]
	public Transform rightHandAnchor;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AB08", Offset = "0x80AB08")]
	public Vector3 handAnchorPositionOffset;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AB40", Offset = "0x80AB40")]
	public Vector3 handAnchorRotationOffset;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80AB78", Offset = "0x80AB78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AB78", Offset = "0x80AB78")]
	public float scaleMlp;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80ABD8", Offset = "0x80ABD8")]
	public VRIKCalibrator.CalibrationData data;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Stopwatch stopWatch;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool initialCalibrationOccured;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform floor;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Vector3 calcedLocalScale;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1522F70", Offset = "0x1522F70", VA = "0x1522F70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1522FEC", Offset = "0x1522FEC", VA = "0x1522FEC")]
	public void setPlayerScale(Vector3 scale)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x152301C", Offset = "0x152301C", VA = "0x152301C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1523554", Offset = "0x1523554", VA = "0x1523554")]
	public VRIKCalibrationBasic()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8092CC", Offset = "0x8092CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8092CC", Offset = "0x8092CC")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000005")]
		public enum Mode
		{
			[Token(Token = "0x4000025")]
			AnimationClips,
			[Token(Token = "0x4000026")]
			AnimationStates,
			[Token(Token = "0x4000027")]
			PlayableDirector,
			[Token(Token = "0x4000028")]
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
				[Token(Token = "0x4000036")]
				Original,
				[Token(Token = "0x4000037")]
				BodyOrientation
			}

			[Serializable]
			[Token(Token = "0x2000009")]
			public enum BasedUponY
			{
				[Token(Token = "0x4000039")]
				Original,
				[Token(Token = "0x400003A")]
				CenterOfMass,
				[Token(Token = "0x400003B")]
				Feet
			}

			[Serializable]
			[Token(Token = "0x200000A")]
			public enum BasedUponXZ
			{
				[Token(Token = "0x400003D")]
				Original,
				[Token(Token = "0x400003E")]
				CenterOfMass
			}

			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool loopTime;

			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool loopBlend;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float cycleOffset;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool loopBlendOrientation;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public BasedUponRotation basedUponRotation;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float orientationOffsetY;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool loopBlendPositionY;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BasedUponY basedUponY;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float level;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool loopBlendPositionXZ;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public BasedUponXZ basedUponXZ;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool mirror;

			[Token(Token = "0x6000022")]
			[Address(RVA = "0x15297C8", Offset = "0x15297C8", VA = "0x15297C8")]
			public ClipSettings()
			{
			}
		}

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80AC10", Offset = "0x80AC10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AC10", Offset = "0x80AC10")]
		public int frameRate;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80AC68", Offset = "0x80AC68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AC68", Offset = "0x80AC68")]
		public float keyReductionError;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80ACC0", Offset = "0x80ACC0")]
		public Mode mode;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80ACF8", Offset = "0x80ACF8")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AD30", Offset = "0x80AD30")]
		public string[] animationStates;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AD68", Offset = "0x80AD68")]
		public string saveToFolder;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80ADA0", Offset = "0x80ADA0")]
		public string appendName;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80ADD8", Offset = "0x80ADD8")]
		public string saveName;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AE10", Offset = "0x80AE10")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AE20", Offset = "0x80AE20")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BakerDelegate OnStartClip;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BakerDelegate OnUpdateClip;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AE50", Offset = "0x80AE50")]
		public bool inheritClipSettings;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AE88", Offset = "0x80AE88")]
		public ClipSettings clipSettings;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AEC0", Offset = "0x80AEC0")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected bool addLoopFrame;

		[Token(Token = "0x17000003")]
		public bool isBaking
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x19BC48C", Offset = "0x19BC48C", VA = "0x19BC48C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A58", Offset = "0x815A58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x19BC494", Offset = "0x19BC494", VA = "0x19BC494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A68", Offset = "0x815A68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public float bakingProgress
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x19BC4A0", Offset = "0x19BC4A0", VA = "0x19BC4A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A78", Offset = "0x815A78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x19BC4A8", Offset = "0x19BC4A8", VA = "0x19BC4A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A88", Offset = "0x815A88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		protected float clipLength
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x19BC4B0", Offset = "0x19BC4B0", VA = "0x19BC4B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A98", Offset = "0x815A98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x19BC4B8", Offset = "0x19BC4B8", VA = "0x19BC4B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AA8", Offset = "0x815AA8")]
			private set
			{
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x19BC36C", Offset = "0x19BC36C", VA = "0x19BC36C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815978", Offset = "0x815978")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x19BC3B4", Offset = "0x19BC3B4", VA = "0x19BC3B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8159B0", Offset = "0x8159B0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x19BC3FC", Offset = "0x19BC3FC", VA = "0x19BC3FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8159E8", Offset = "0x8159E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x19BC444", Offset = "0x19BC444", VA = "0x19BC444")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815A20", Offset = "0x815A20")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000013")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000014")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000015")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000016")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000017")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x19BC4C0", Offset = "0x19BC4C0", VA = "0x19BC4C0")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x19BC4C4", Offset = "0x19BC4C4", VA = "0x19BC4C4")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x19BC4C8", Offset = "0x19BC4C8", VA = "0x19BC4C8")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x19BC4CC", Offset = "0x19BC4CC", VA = "0x19BC4CC")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AED0", Offset = "0x80AED0")]
		public bool markAsLegacy;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AF08", Offset = "0x80AF08")]
		public Transform root;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AF40", Offset = "0x80AF40")]
		public Transform rootNode;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AF78", Offset = "0x80AF78")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AFB0", Offset = "0x80AFB0")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerTransform[] children;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int rootChildIndex;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1A3F57C", Offset = "0x1A3F57C", VA = "0x1A3F57C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1A3F980", Offset = "0x1A3F980", VA = "0x1A3F980", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1A3F988", Offset = "0x1A3F988", VA = "0x1A3F988", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1A3FA98", Offset = "0x1A3FA98", VA = "0x1A3FA98", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1A3FB14", Offset = "0x1A3FB14", VA = "0x1A3FB14", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1A3FB90", Offset = "0x1A3FB90", VA = "0x1A3FB90", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1A3F7D8", Offset = "0x1A3F7D8", VA = "0x1A3F7D8")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1A3F8AC", Offset = "0x1A3F8AC", VA = "0x1A3F8AC")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1A3FC0C", Offset = "0x1A3FC0C", VA = "0x1A3FC0C")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class TQ
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x13E6D34", Offset = "0x13E6D34", VA = "0x13E6D34")]
		public TQ()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x13E6D3C", Offset = "0x13E6D3C", VA = "0x13E6D3C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class AvatarUtility
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x19BB118", Offset = "0x19BB118", VA = "0x19BB118")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x19BB380", Offset = "0x19BB380", VA = "0x19BB380")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x19BB944", Offset = "0x19BB944", VA = "0x19BB944")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x19BBDF0", Offset = "0x19BBDF0", VA = "0x19BBDF0")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x19BB360", Offset = "0x19BB360", VA = "0x19BB360")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x19BBF84", Offset = "0x19BBF84", VA = "0x19BBF84")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x19BD9BC", Offset = "0x19BD9BC", VA = "0x19BD9BC")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x19BF2EC", Offset = "0x19BF2EC", VA = "0x19BF2EC")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x19BD40C", Offset = "0x19BD40C", VA = "0x19BD40C")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x19BDA04", Offset = "0x19BDA04", VA = "0x19BDA04")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x19BCF3C", Offset = "0x19BCF3C", VA = "0x19BCF3C")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x19BC5E0", Offset = "0x19BC5E0", VA = "0x19BC5E0")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x19BC8F4", Offset = "0x19BC8F4", VA = "0x19BC8F4")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x19BCAD0", Offset = "0x19BCAD0", VA = "0x19BCAD0")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x19BCB8C", Offset = "0x19BCB8C", VA = "0x19BCB8C")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x19BBEB4", Offset = "0x19BBEB4", VA = "0x19BBEB4")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x19BCC0C", Offset = "0x19BCC0C", VA = "0x19BCC0C")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x19BC798", Offset = "0x19BC798", VA = "0x19BC798")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x19BCC10", Offset = "0x19BCC10", VA = "0x19BCC10")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x19BD1A0", Offset = "0x19BD1A0", VA = "0x19BD1A0")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x19BD29C", Offset = "0x19BD29C", VA = "0x19BD29C")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x19BD398", Offset = "0x19BD398", VA = "0x19BD398")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x19BD604", Offset = "0x19BD604", VA = "0x19BD604")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x19BD310", Offset = "0x19BD310", VA = "0x19BD310")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x19BD608", Offset = "0x19BD608", VA = "0x19BD608")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x19BD6BC", Offset = "0x19BD6BC", VA = "0x19BD6BC")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class BakerMuscle
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x19BDA08", Offset = "0x19BDA08", VA = "0x19BDA08")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x19BDA84", Offset = "0x19BDA84", VA = "0x19BDA84")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x19BE520", Offset = "0x19BE520", VA = "0x19BE520")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x19BE5D4", Offset = "0x19BE5D4", VA = "0x19BE5D4")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x19BE4BC", Offset = "0x19BE4BC", VA = "0x19BE4BC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x19BE6CC", Offset = "0x19BE6CC", VA = "0x19BE6CC")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x19BE714", Offset = "0x19BE714", VA = "0x19BE714")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class BakerTransform
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x19BE71C", Offset = "0x19BE71C", VA = "0x19BE71C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x19BE90C", Offset = "0x19BE90C", VA = "0x19BE90C")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x19BE920", Offset = "0x19BE920", VA = "0x19BE920")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x19BEC0C", Offset = "0x19BEC0C", VA = "0x19BEC0C")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x19BE7C8", Offset = "0x19BE7C8", VA = "0x19BE7C8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x19BEEC0", Offset = "0x19BEEC0", VA = "0x19BEEC0")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x19BEF34", Offset = "0x19BEF34", VA = "0x19BEF34")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x19BF0E8", Offset = "0x19BF0E8", VA = "0x19BF0E8")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80AFE8", Offset = "0x80AFE8")]
		public bool bakeHandIK;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B020", Offset = "0x80B020")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B020", Offset = "0x80B020")]
		public float IKKeyReductionError;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B078", Offset = "0x80B078")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B078", Offset = "0x80B078")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] muscles;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private HumanPose pose;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mN;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1C16620", Offset = "0x1C16620", VA = "0x1C16620")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1C16BB4", Offset = "0x1C16BB4", VA = "0x1C16BB4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1C16BD0", Offset = "0x1C16BD0", VA = "0x1C16BD0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1C16CAC", Offset = "0x1C16CAC", VA = "0x1C16CAC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1C16D88", Offset = "0x1C16D88", VA = "0x1C16D88", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1C16F58", Offset = "0x1C16F58", VA = "0x1C16F58", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1C172A0", Offset = "0x1C172A0", VA = "0x1C172A0")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1C1738C", Offset = "0x1C1738C", VA = "0x1C1738C")]
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
			[Token(Token = "0x40000A2")]
			Update,
			[Token(Token = "0x40000A3")]
			FixedUpdate,
			[Token(Token = "0x40000A4")]
			LateUpdate,
			[Token(Token = "0x40000A5")]
			FixedLateUpdate
		}

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80B0CC", Offset = "0x80B0CC")]
		public bool smoothFollow;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80B104", Offset = "0x80B104")]
		public float rotationSensitivity;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80B13C", Offset = "0x80B13C")]
		public float distance;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80B174", Offset = "0x80B174")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B1AC", Offset = "0x80B1AC")]
		public float blockedOffset;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B1C4", Offset = "0x80B1C4")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B1D4", Offset = "0x80B1D4")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B1E4", Offset = "0x80B1E4")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000006")]
		public float x
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x19C9294", Offset = "0x19C9294", VA = "0x19C9294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AB8", Offset = "0x815AB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x19C929C", Offset = "0x19C929C", VA = "0x19C929C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AC8", Offset = "0x815AC8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float y
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x19C92A4", Offset = "0x19C92A4", VA = "0x19C92A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AD8", Offset = "0x815AD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x19C92AC", Offset = "0x19C92AC", VA = "0x19C92AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AE8", Offset = "0x815AE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public float distanceTarget
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x19C92B4", Offset = "0x19C92B4", VA = "0x19C92B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AF8", Offset = "0x815AF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x19C92BC", Offset = "0x19C92BC", VA = "0x19C92BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815B08", Offset = "0x815B08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		private float zoomAdd
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x19C9BA4", Offset = "0x19C9BA4", VA = "0x19C9BA4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x19C92C4", Offset = "0x19C92C4", VA = "0x19C92C4")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x19C9300", Offset = "0x19C9300", VA = "0x19C9300")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x19C9308", Offset = "0x19C9308", VA = "0x19C9308", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x19C9418", Offset = "0x19C9418", VA = "0x19C9418", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x19C9474", Offset = "0x19C9474", VA = "0x19C9474", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x19C94DC", Offset = "0x19C94DC", VA = "0x19C94DC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x19C9540", Offset = "0x19C9540", VA = "0x19C9540")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x19C944C", Offset = "0x19C944C", VA = "0x19C944C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x19C96C0", Offset = "0x19C96C0", VA = "0x19C96C0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x19C9B74", Offset = "0x19C9B74", VA = "0x19C9B74")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x19C9C14", Offset = "0x19C9C14", VA = "0x19C9C14")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x19C9CC0", Offset = "0x19C9CC0", VA = "0x19C9CC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x19C9CF8", Offset = "0x19C9CF8", VA = "0x19C9CF8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x19C9EA0", Offset = "0x19C9EA0", VA = "0x19C9EA0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x19C9ED0", Offset = "0x19C9ED0", VA = "0x19C9ED0")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public enum Axis
	{
		[Token(Token = "0x40000AC")]
		X,
		[Token(Token = "0x40000AD")]
		Y,
		[Token(Token = "0x40000AE")]
		Z
	}
	[Token(Token = "0x2000017")]
	public class AxisTools
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x19BBF8C", Offset = "0x19BBF8C", VA = "0x19BBF8C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x19BBFB0", Offset = "0x19BBFB0", VA = "0x19BBFB0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x19BBFE8", Offset = "0x19BBFE8", VA = "0x19BBFE8")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x19BC0D8", Offset = "0x19BC0D8", VA = "0x19BC0D8")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x19BC080", Offset = "0x19BC080", VA = "0x19BC080")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x19BC170", Offset = "0x19BC170", VA = "0x19BC170")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x19BC1B8", Offset = "0x19BC1B8", VA = "0x19BC1B8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x19BC364", Offset = "0x19BC364", VA = "0x19BC364")]
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
			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x1529854", Offset = "0x1529854", VA = "0x1529854")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700000A")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x19C1384", Offset = "0x19C1384", VA = "0x19C1384")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x19C15F4", Offset = "0x19C15F4", VA = "0x19C15F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x19C1304", Offset = "0x19C1304", VA = "0x19C1304")]
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
			[Token(Token = "0x40000C9")]
			Unassigned,
			[Token(Token = "0x40000CA")]
			Spine,
			[Token(Token = "0x40000CB")]
			Head,
			[Token(Token = "0x40000CC")]
			Arm,
			[Token(Token = "0x40000CD")]
			Leg,
			[Token(Token = "0x40000CE")]
			Tail,
			[Token(Token = "0x40000CF")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200001C")]
		public enum BoneSide
		{
			[Token(Token = "0x40000D1")]
			Center,
			[Token(Token = "0x40000D2")]
			Left,
			[Token(Token = "0x40000D3")]
			Right
		}

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x19C1864", Offset = "0x19C1864", VA = "0x19C1864")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x19C1B88", Offset = "0x19C1B88", VA = "0x19C1B88")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x19C1DFC", Offset = "0x19C1DFC", VA = "0x19C1DFC")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x19C1E7C", Offset = "0x19C1E7C", VA = "0x19C1E7C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x19C1F24", Offset = "0x19C1F24", VA = "0x19C1F24")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x19C1A3C", Offset = "0x19C1A3C", VA = "0x19C1A3C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x19C1D60", Offset = "0x19C1D60", VA = "0x19C1D60")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x19C2754", Offset = "0x19C2754", VA = "0x19C2754")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x19C255C", Offset = "0x19C255C", VA = "0x19C255C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x19C2658", Offset = "0x19C2658", VA = "0x19C2658")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x19C213C", Offset = "0x19C213C", VA = "0x19C213C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x19C21EC", Offset = "0x19C21EC", VA = "0x19C21EC")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x19C229C", Offset = "0x19C229C", VA = "0x19C229C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x19C234C", Offset = "0x19C234C", VA = "0x19C234C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x19C23FC", Offset = "0x19C23FC", VA = "0x19C23FC")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x19C24AC", Offset = "0x19C24AC", VA = "0x19C24AC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x19C295C", Offset = "0x19C295C", VA = "0x19C295C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x19C2054", Offset = "0x19C2054", VA = "0x19C2054")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x19C28CC", Offset = "0x19C28CC", VA = "0x19C28CC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x19C29C8", Offset = "0x19C29C8", VA = "0x19C29C8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x19C2A9C", Offset = "0x19C2A9C", VA = "0x19C2A9C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x19C2854", Offset = "0x19C2854", VA = "0x19C2854")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x19C27E0", Offset = "0x19C27E0", VA = "0x19C27E0")]
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
			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000E")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000B2")]
				[Address(RVA = "0x15298E0", Offset = "0x15298E0", VA = "0x15298E0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x15298CC", Offset = "0x15298CC", VA = "0x15298CC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000C")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x19C5304", Offset = "0x19C5304", VA = "0x19C5304", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public bool isEmpty
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x19C56EC", Offset = "0x19C56EC", VA = "0x19C56EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x19C56FC", Offset = "0x19C56FC", VA = "0x19C56FC", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x19C5B24", Offset = "0x19C5B24", VA = "0x19C5B24", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x19C5F58", Offset = "0x19C5F58", VA = "0x19C5F58")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x19C6628", Offset = "0x19C6628", VA = "0x19C6628")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x19C6184", Offset = "0x19C6184", VA = "0x19C6184")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x19C05D8", Offset = "0x19C05D8", VA = "0x19C05D8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x19C6EAC", Offset = "0x19C6EAC", VA = "0x19C6EAC")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x19C7468", Offset = "0x19C7468", VA = "0x19C7468")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x19C7248", Offset = "0x19C7248", VA = "0x19C7248")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x19C70C4", Offset = "0x19C70C4", VA = "0x19C70C4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x19C6F4C", Offset = "0x19C6F4C", VA = "0x19C6F4C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x19C7354", Offset = "0x19C7354", VA = "0x19C7354")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x19C7560", Offset = "0x19C7560", VA = "0x19C7560")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x19C8148", Offset = "0x19C8148", VA = "0x19C8148")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x19C7BB8", Offset = "0x19C7BB8", VA = "0x19C7BB8")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x19C8444", Offset = "0x19C8444", VA = "0x19C8444")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x19C7F30", Offset = "0x19C7F30", VA = "0x19C7F30")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x19C844C", Offset = "0x19C844C", VA = "0x19C844C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x19C8454", Offset = "0x19C8454", VA = "0x19C8454")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x19C8628", Offset = "0x19C8628", VA = "0x19C8628")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x19C87F0", Offset = "0x19C87F0", VA = "0x19C87F0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x19C0A58", Offset = "0x19C0A58", VA = "0x19C0A58")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1A31BA0", Offset = "0x1A31BA0", VA = "0x1A31BA0")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1A32EB8", Offset = "0x1A32EB8", VA = "0x1A32EB8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1A33000", Offset = "0x1A33000", VA = "0x1A33000")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Hierarchy
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1C13EC8", Offset = "0x1C13EC8", VA = "0x1C13EC8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1C140B4", Offset = "0x1C140B4", VA = "0x1C140B4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1C13F60", Offset = "0x1C13F60", VA = "0x1C13F60")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1C141D4", Offset = "0x1C141D4", VA = "0x1C141D4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1C14300", Offset = "0x1C14300", VA = "0x1C14300")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1C14554", Offset = "0x1C14554", VA = "0x1C14554")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1C1465C", Offset = "0x1C1465C", VA = "0x1C1465C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1C147D0", Offset = "0x1C147D0", VA = "0x1C147D0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1C14BAC", Offset = "0x1C14BAC", VA = "0x1C14BAC")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1C14970", Offset = "0x1C14970", VA = "0x1C14970")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1C14D60", Offset = "0x1C14D60", VA = "0x1C14D60")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1C317D0", Offset = "0x1C317D0", VA = "0x1C317D0")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1C3185C", Offset = "0x1C3185C", VA = "0x1C3185C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000ED")]
		None,
		[Token(Token = "0x40000EE")]
		InOutCubic,
		[Token(Token = "0x40000EF")]
		InOutQuintic,
		[Token(Token = "0x40000F0")]
		InOutSine,
		[Token(Token = "0x40000F1")]
		InQuintic,
		[Token(Token = "0x40000F2")]
		InQuartic,
		[Token(Token = "0x40000F3")]
		InCubic,
		[Token(Token = "0x40000F4")]
		InQuadratic,
		[Token(Token = "0x40000F5")]
		InElastic,
		[Token(Token = "0x40000F6")]
		InElasticSmall,
		[Token(Token = "0x40000F7")]
		InElasticBig,
		[Token(Token = "0x40000F8")]
		InSine,
		[Token(Token = "0x40000F9")]
		InBack,
		[Token(Token = "0x40000FA")]
		OutQuintic,
		[Token(Token = "0x40000FB")]
		OutQuartic,
		[Token(Token = "0x40000FC")]
		OutCubic,
		[Token(Token = "0x40000FD")]
		OutInCubic,
		[Token(Token = "0x40000FE")]
		OutInQuartic,
		[Token(Token = "0x40000FF")]
		OutElastic,
		[Token(Token = "0x4000100")]
		OutElasticSmall,
		[Token(Token = "0x4000101")]
		OutElasticBig,
		[Token(Token = "0x4000102")]
		OutSine,
		[Token(Token = "0x4000103")]
		OutBack,
		[Token(Token = "0x4000104")]
		OutBackCubic,
		[Token(Token = "0x4000105")]
		OutBackQuartic,
		[Token(Token = "0x4000106")]
		BackInCubic,
		[Token(Token = "0x4000107")]
		BackInQuartic
	}
	[Token(Token = "0x2000024")]
	public class Interp
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1B03DCC", Offset = "0x1B03DCC", VA = "0x1B03DCC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1B09D3C", Offset = "0x1B09D3C", VA = "0x1B09D3C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1B09DB0", Offset = "0x1B09DB0", VA = "0x1B09DB0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1B097A4", Offset = "0x1B097A4", VA = "0x1B097A4")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1B097B0", Offset = "0x1B097B0", VA = "0x1B097B0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1B097D4", Offset = "0x1B097D4", VA = "0x1B097D4")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1B09810", Offset = "0x1B09810", VA = "0x1B09810")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1B09828", Offset = "0x1B09828", VA = "0x1B09828")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1B0983C", Offset = "0x1B0983C", VA = "0x1B0983C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1B09850", Offset = "0x1B09850", VA = "0x1B09850")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1B09860", Offset = "0x1B09860", VA = "0x1B09860")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1B098A8", Offset = "0x1B098A8", VA = "0x1B098A8")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1B098E0", Offset = "0x1B098E0", VA = "0x1B098E0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1B09908", Offset = "0x1B09908", VA = "0x1B09908")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1B09E3C", Offset = "0x1B09E3C", VA = "0x1B09E3C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1B0993C", Offset = "0x1B0993C", VA = "0x1B0993C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1B09964", Offset = "0x1B09964", VA = "0x1B09964")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1B09994", Offset = "0x1B09994", VA = "0x1B09994")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1B099C8", Offset = "0x1B099C8", VA = "0x1B099C8")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1B09A0C", Offset = "0x1B09A0C", VA = "0x1B09A0C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1B09A70", Offset = "0x1B09A70", VA = "0x1B09A70")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1B09AD4", Offset = "0x1B09AD4", VA = "0x1B09AD4")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1B09B28", Offset = "0x1B09B28", VA = "0x1B09B28")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1B09B7C", Offset = "0x1B09B7C", VA = "0x1B09B7C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1B09BB8", Offset = "0x1B09BB8", VA = "0x1B09BB8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1B09BF0", Offset = "0x1B09BF0", VA = "0x1B09BF0")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1B09E70", Offset = "0x1B09E70", VA = "0x1B09E70")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1B09C38", Offset = "0x1B09C38", VA = "0x1B09C38")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1B09CCC", Offset = "0x1B09CCC", VA = "0x1B09CCC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1B09CFC", Offset = "0x1B09CFC", VA = "0x1B09CFC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1B09F04", Offset = "0x1B09F04", VA = "0x1B09F04")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1B0A0DC", Offset = "0x1B0A0DC", VA = "0x1B0A0DC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1B0A134", Offset = "0x1B0A134", VA = "0x1B0A134")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1B0A200", Offset = "0x1B0A200", VA = "0x1B0A200")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1B0A14C", Offset = "0x1B0A14C", VA = "0x1B0A14C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1B0A218", Offset = "0x1B0A218", VA = "0x1B0A218")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1B0A2BC", Offset = "0x1B0A2BC", VA = "0x1B0A2BC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1B0A2E8", Offset = "0x1B0A2E8", VA = "0x1B0A2E8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1B0A338", Offset = "0x1B0A338", VA = "0x1B0A338")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1B0A3A4", Offset = "0x1B0A3A4", VA = "0x1B0A3A4")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1B0A4B8", Offset = "0x1B0A4B8", VA = "0x1B0A4B8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1B0A5B0", Offset = "0x1B0A5B0", VA = "0x1B0A5B0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1B0A60C", Offset = "0x1B0A60C", VA = "0x1B0A60C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000026")]
	public abstract class LazySingleton<T> : MonoBehaviour where T : LazySingleton<T>
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000F")]
		public static bool hasInstance
		{
			[Token(Token = "0x60000EE")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public static T instance
		{
			[Token(Token = "0x60000EF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F0")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000F1")]
		protected LazySingleton()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public enum ShowIfMode
	{
		[Token(Token = "0x400010A")]
		Disabled,
		[Token(Token = "0x400010B")]
		Hidden
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x80933C", Offset = "0x80933C")]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B204", Offset = "0x80B204")]
		private string <propName>k__BackingField;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B214", Offset = "0x80B214")]
		private object <propValue>k__BackingField;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B224", Offset = "0x80B224")]
		private object <otherPropValue>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B234", Offset = "0x80B234")]
		private bool <indent>k__BackingField;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B244", Offset = "0x80B244")]
		private ShowIfMode <mode>k__BackingField;

		[Token(Token = "0x17000011")]
		public string propName
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x13E2A84", Offset = "0x13E2A84", VA = "0x13E2A84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815B88", Offset = "0x815B88")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x13E2A8C", Offset = "0x13E2A8C", VA = "0x13E2A8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815B98", Offset = "0x815B98")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public object propValue
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x13E2A94", Offset = "0x13E2A94", VA = "0x13E2A94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815BA8", Offset = "0x815BA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x13E2A9C", Offset = "0x13E2A9C", VA = "0x13E2A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815BB8", Offset = "0x815BB8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public object otherPropValue
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x13E2AA4", Offset = "0x13E2AA4", VA = "0x13E2AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815BC8", Offset = "0x815BC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x13E2AAC", Offset = "0x13E2AAC", VA = "0x13E2AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815BD8", Offset = "0x815BD8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool indent
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x13E2AB4", Offset = "0x13E2AB4", VA = "0x13E2AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815BE8", Offset = "0x815BE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x13E2ABC", Offset = "0x13E2ABC", VA = "0x13E2ABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815BF8", Offset = "0x815BF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x13E2AC8", Offset = "0x13E2AC8", VA = "0x13E2AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815C08", Offset = "0x815C08")]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x13E2AD0", Offset = "0x13E2AD0", VA = "0x13E2AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815C18", Offset = "0x815C18")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x13E2AD8", Offset = "0x13E2AD8", VA = "0x13E2AD8")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x809374", Offset = "0x809374")]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B254", Offset = "0x80B254")]
		private float <min>k__BackingField;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B264", Offset = "0x80B264")]
		private float <max>k__BackingField;

		[Token(Token = "0x17000016")]
		public float min
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x13E2CF0", Offset = "0x13E2CF0", VA = "0x13E2CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815C28", Offset = "0x815C28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x13E2CF8", Offset = "0x13E2CF8", VA = "0x13E2CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815C38", Offset = "0x815C38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public float max
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x13E2D00", Offset = "0x13E2D00", VA = "0x13E2D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815C48", Offset = "0x815C48")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x13E2D08", Offset = "0x13E2D08", VA = "0x13E2D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815C58", Offset = "0x815C58")]
			private set
			{
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x13E2D10", Offset = "0x13E2D10", VA = "0x13E2D10")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string color;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x13E2B5C", Offset = "0x13E2B5C", VA = "0x13E2B5C")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x13E2C24", Offset = "0x13E2C24", VA = "0x13E2C24")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1B09FC0", Offset = "0x1B09FC0", VA = "0x1B09FC0")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1B0A04C", Offset = "0x1B0A04C", VA = "0x1B0A04C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public static class QuaTools
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x13DB1FC", Offset = "0x13DB1FC", VA = "0x13DB1FC")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x13DB258", Offset = "0x13DB258", VA = "0x13DB258")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x13DB2E8", Offset = "0x13DB2E8", VA = "0x13DB2E8")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x13DB448", Offset = "0x13DB448", VA = "0x13DB448")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x13DB504", Offset = "0x13DB504", VA = "0x13DB504")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x13DB5C0", Offset = "0x13DB5C0", VA = "0x13DB5C0")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x13DB76C", Offset = "0x13DB76C", VA = "0x13DB76C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x13DB7BC", Offset = "0x13DB7BC", VA = "0x13DB7BC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x13DB80C", Offset = "0x13DB80C", VA = "0x13DB80C")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x13DB8B4", Offset = "0x13DB8B4", VA = "0x13DB8B4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x13DB95C", Offset = "0x13DB95C", VA = "0x13DB95C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x13DBA3C", Offset = "0x13DBA3C", VA = "0x13DBA3C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x13DBA90", Offset = "0x13DBA90", VA = "0x13DBA90")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x13DBB64", Offset = "0x13DBB64", VA = "0x13DBB64")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x13DBC74", Offset = "0x13DBC74", VA = "0x13DBC74")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x13DBE04", Offset = "0x13DBE04", VA = "0x13DBE04")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x13DBEF8", Offset = "0x13DBEF8", VA = "0x13DBEF8")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x13DC004", Offset = "0x13DC004", VA = "0x13DC004")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x13DC0F0", Offset = "0x13DC0F0", VA = "0x13DC0F0")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x13DC14C", Offset = "0x13DC14C", VA = "0x13DC14C")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x13DC288", Offset = "0x13DC288", VA = "0x13DC288")]
		public static Quaternion MirrorYZ(Quaternion r)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200002D")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000018")]
		public static T instance
		{
			[Token(Token = "0x600011C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011D")]
		public static void Clear()
		{
		}

		[Token(Token = "0x600011E")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600011F")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B274", Offset = "0x80B274")]
		public bool fixTransforms;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000019")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x13E40B4", Offset = "0x13E40B4", VA = "0x13E40B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		private bool isAnimated
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x13E4400", Offset = "0x13E4400", VA = "0x13E4400")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x13E3F74", Offset = "0x13E3F74", VA = "0x13E3F74")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x13E4014", Offset = "0x13E4014", VA = "0x13E4014", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x13E4018", Offset = "0x13E4018", VA = "0x13E4018", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x13E401C", Offset = "0x13E401C", VA = "0x13E401C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x13E4020", Offset = "0x13E4020", VA = "0x13E4020")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x13E40B0", Offset = "0x13E40B0", VA = "0x13E40B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x13E4058", Offset = "0x13E4058", VA = "0x13E4058")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x13E43B4", Offset = "0x13E43B4", VA = "0x13E43B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x13E41A0", Offset = "0x13E41A0", VA = "0x13E41A0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x13E44B8", Offset = "0x13E44B8", VA = "0x13E44B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x13E4514", Offset = "0x13E4514", VA = "0x13E4514")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x13E4570", Offset = "0x13E4570", VA = "0x13E4570")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x13E45B8", Offset = "0x13E45B8", VA = "0x13E45B8")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x151F110", Offset = "0x151F110", VA = "0x151F110")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x151F1D0", Offset = "0x151F1D0", VA = "0x151F1D0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x151F290", Offset = "0x151F290", VA = "0x151F290")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x151F350", Offset = "0x151F350", VA = "0x151F350")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public static class V2Tools
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x15217AC", Offset = "0x15217AC", VA = "0x15217AC")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x15217B4", Offset = "0x15217B4", VA = "0x15217B4")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1521804", Offset = "0x1521804", VA = "0x1521804")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1521858", Offset = "0x1521858", VA = "0x1521858")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1521930", Offset = "0x1521930", VA = "0x1521930")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000031")]
	public static class V3Tools
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x15219C4", Offset = "0x15219C4", VA = "0x15219C4")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x15219E8", Offset = "0x15219E8", VA = "0x15219E8")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1521A30", Offset = "0x1521A30", VA = "0x1521A30")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1521ABC", Offset = "0x1521ABC", VA = "0x1521ABC")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1521B1C", Offset = "0x1521B1C", VA = "0x1521B1C")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1521B7C", Offset = "0x1521B7C", VA = "0x1521B7C")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1521C98", Offset = "0x1521C98", VA = "0x1521C98")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1521D38", Offset = "0x1521D38", VA = "0x1521D38")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1521D74", Offset = "0x1521D74", VA = "0x1521D74")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1521E44", Offset = "0x1521E44", VA = "0x1521E44")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1521F3C", Offset = "0x1521F3C", VA = "0x1521F3C")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1521FE4", Offset = "0x1521FE4", VA = "0x1521FE4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1522140", Offset = "0x1522140", VA = "0x1522140")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x15222BC", Offset = "0x15222BC", VA = "0x15222BC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1522440", Offset = "0x1522440", VA = "0x1522440")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x15224FC", Offset = "0x15224FC", VA = "0x15224FC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x15225FC", Offset = "0x15225FC", VA = "0x15225FC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1522684", Offset = "0x1522684", VA = "0x1522684")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1522720", Offset = "0x1522720", VA = "0x1522720")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x15227C4", Offset = "0x15227C4", VA = "0x15227C4")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x15227B4", Offset = "0x15227B4", VA = "0x15227B4")]
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

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x15285CC", Offset = "0x15285CC", VA = "0x15285CC")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1528664", Offset = "0x1528664", VA = "0x1528664")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8093AC", Offset = "0x8093AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8093AC", Offset = "0x8093AC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x19BFC78", Offset = "0x19BFC78", VA = "0x19BFC78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815C68", Offset = "0x815C68")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x19BFCC0", Offset = "0x19BFCC0", VA = "0x19BFCC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815CA0", Offset = "0x815CA0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x19BFD08", Offset = "0x19BFD08", VA = "0x19BFD08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815CD8", Offset = "0x815CD8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x19BFD50", Offset = "0x19BFD50", VA = "0x19BFD50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815D10", Offset = "0x815D10")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x19BFD98", Offset = "0x19BFD98", VA = "0x19BFD98")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x19BFE34", Offset = "0x19BFE34", VA = "0x19BFE34")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x19BFE54", Offset = "0x19BFE54", VA = "0x19BFE54")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x19BFE84", Offset = "0x19BFE84", VA = "0x19BFE84")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x19BFEB4", Offset = "0x19BFEB4", VA = "0x19BFEB4")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x19BFEF4", Offset = "0x19BFEF4", VA = "0x19BFEF4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x19BFF38", Offset = "0x19BFF38", VA = "0x19BFF38")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x19BFF5C", Offset = "0x19BFF5C", VA = "0x19BFF5C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x19BFF80", Offset = "0x19BFF80", VA = "0x19BFF80")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x19BFFA8", Offset = "0x19BFFA8", VA = "0x19BFFA8")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x19BFFD4", Offset = "0x19BFFD4", VA = "0x19BFFD4")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x19C0000", Offset = "0x19C0000", VA = "0x19C0000")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x19BFDB8", Offset = "0x19BFDB8", VA = "0x19BFDB8")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x19C0028", Offset = "0x19C0028", VA = "0x19C0028")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x19C0034", Offset = "0x19C0034", VA = "0x19C0034")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x19C0040", Offset = "0x19C0040", VA = "0x19C0040")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x19C0364", Offset = "0x19C0364", VA = "0x19C0364", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x19C040C", Offset = "0x19C040C", VA = "0x19C040C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x19C07F8", Offset = "0x19C07F8", VA = "0x19C07F8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x19C0984", Offset = "0x19C0984", VA = "0x19C0984")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x19C09B8", Offset = "0x19C09B8", VA = "0x19C09B8")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700001B")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x19C01E0", Offset = "0x19C01E0", VA = "0x19C01E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x19C0CB0", Offset = "0x19C0CB0", VA = "0x19C0CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x19C06D4", Offset = "0x19C06D4", VA = "0x19C06D4")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x19C0ADC", Offset = "0x19C0ADC", VA = "0x19C0ADC")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public abstract class Constraint
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700001D")]
		public bool isValid
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1A31BA8", Offset = "0x1A31BA8", VA = "0x1A31BA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000172")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1A31C14", Offset = "0x1A31C14", VA = "0x1A31C14")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1A31C1C", Offset = "0x1A31C1C", VA = "0x1A31C1C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1A31CDC", Offset = "0x1A31CDC", VA = "0x1A31CDC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1A31CE4", Offset = "0x1A31CE4", VA = "0x1A31CE4")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700001E")]
		private bool positionChanged
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1A31E20", Offset = "0x1A31E20", VA = "0x1A31E20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1A31D18", Offset = "0x1A31D18", VA = "0x1A31D18", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1A31E5C", Offset = "0x1A31E5C", VA = "0x1A31E5C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1A31E64", Offset = "0x1A31E64", VA = "0x1A31E64")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1A31E98", Offset = "0x1A31E98", VA = "0x1A31E98", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1A31F18", Offset = "0x1A31F18", VA = "0x1A31F18")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1A31F20", Offset = "0x1A31F20", VA = "0x1A31F20")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700001F")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1A3205C", Offset = "0x1A3205C", VA = "0x1A3205C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1A31F54", Offset = "0x1A31F54", VA = "0x1A31F54", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1A32098", Offset = "0x1A32098", VA = "0x1A32098")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1A320A0", Offset = "0x1A320A0", VA = "0x1A320A0")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class Constraints
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B2AC", Offset = "0x80B2AC")]
		public float positionWeight;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B2C4", Offset = "0x80B2C4")]
		public float rotationWeight;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1A320D4", Offset = "0x1A320D4", VA = "0x1A320D4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1A32140", Offset = "0x1A32140", VA = "0x1A32140")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1A32198", Offset = "0x1A32198", VA = "0x1A32198")]
		public void Update()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1A32448", Offset = "0x1A32448", VA = "0x1A32448")]
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
			[Token(Token = "0x4000155")]
			One,
			[Token(Token = "0x4000156")]
			Three
		}

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B2DC", Offset = "0x80B2DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B2DC", Offset = "0x80B2DC")]
		public float weight;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B330", Offset = "0x80B330")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B330", Offset = "0x80B330")]
		public float rotationWeight;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B384", Offset = "0x80B384")]
		public DOF rotationDOF;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B3BC", Offset = "0x80B3BC")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B3F4", Offset = "0x80B3F4")]
		public Transform bone1;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B42C", Offset = "0x80B42C")]
		public Transform bone2;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B464", Offset = "0x80B464")]
		public Transform bone3;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B49C", Offset = "0x80B49C")]
		public Transform tip;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B4D4", Offset = "0x80B4D4")]
		public Transform target;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B50C", Offset = "0x80B50C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000020")]
		public bool initiated
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1A3D330", Offset = "0x1A3D330", VA = "0x1A3D330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815D48", Offset = "0x815D48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1A3D338", Offset = "0x1A3D338", VA = "0x1A3D338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815D58", Offset = "0x815D58")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1A3D344", Offset = "0x1A3D344", VA = "0x1A3D344")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1A3D364", Offset = "0x1A3D364", VA = "0x1A3D364")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1A3D384", Offset = "0x1A3D384", VA = "0x1A3D384")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1A3D3A4", Offset = "0x1A3D3A4", VA = "0x1A3D3A4")]
			set
			{
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1A3D3C4", Offset = "0x1A3D3C4", VA = "0x1A3D3C4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1A3D4D8", Offset = "0x1A3D4D8", VA = "0x1A3D4D8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1A3DA68", Offset = "0x1A3DA68", VA = "0x1A3DA68")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1A3DB40", Offset = "0x1A3DB40", VA = "0x1A3DB40")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1A3DC04", Offset = "0x1A3DC04", VA = "0x1A3DC04")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1A3E08C", Offset = "0x1A3E08C", VA = "0x1A3E08C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B51C", Offset = "0x80B51C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B51C", Offset = "0x80B51C")]
		public float weight;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B570", Offset = "0x80B570")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000023")]
		public bool initiated
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1A3E09C", Offset = "0x1A3E09C", VA = "0x1A3E09C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815D68", Offset = "0x815D68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1A3E0A4", Offset = "0x1A3E0A4", VA = "0x1A3E0A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815D78", Offset = "0x815D78")]
			private set
			{
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1A3E0B0", Offset = "0x1A3E0B0", VA = "0x1A3E0B0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1A3E138", Offset = "0x1A3E138", VA = "0x1A3E138")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815D88", Offset = "0x815D88")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1A3E4C4", Offset = "0x1A3E4C4", VA = "0x1A3E4C4")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1A3E688", Offset = "0x1A3E688", VA = "0x1A3E688")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1A3E3C0", Offset = "0x1A3E3C0", VA = "0x1A3E3C0")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1A3E814", Offset = "0x1A3E814", VA = "0x1A3E814", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1A3E8D4", Offset = "0x1A3E8D4", VA = "0x1A3E8D4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1A3E94C", Offset = "0x1A3E94C", VA = "0x1A3E94C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1A3E9C0", Offset = "0x1A3E9C0", VA = "0x1A3E9C0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1A3EA28", Offset = "0x1A3EA28", VA = "0x1A3EA28", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1A3EA2C", Offset = "0x1A3EA2C", VA = "0x1A3EA2C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1A3EA40", Offset = "0x1A3EA40", VA = "0x1A3EA40")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000040")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B580", Offset = "0x80B580")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B580", Offset = "0x80B580")]
		public float weight;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B5D4", Offset = "0x80B5D4")]
		public Grounding solver;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderDelegate OnPostIK;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B60C", Offset = "0x80B60C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000024")]
		public bool initiated
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1A4018C", Offset = "0x1A4018C", VA = "0x1A4018C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815DC0", Offset = "0x815DC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1A40194", Offset = "0x1A40194", VA = "0x1A40194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815DD0", Offset = "0x815DD0")]
			protected set
			{
			}
		}

		[Token(Token = "0x60001A0")]
		public abstract void ResetPosition();

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1A401A0", Offset = "0x1A401A0", VA = "0x1A401A0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1A4034C", Offset = "0x1A4034C", VA = "0x1A4034C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1A4024C", Offset = "0x1A4024C", VA = "0x1A4024C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1A40380", Offset = "0x1A40380", VA = "0x1A40380")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A7")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001A8")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1A404BC", Offset = "0x1A404BC", VA = "0x1A404BC")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80940C", Offset = "0x80940C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80940C", Offset = "0x80940C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B61C", Offset = "0x80B61C")]
		public BipedIK ik;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B654", Offset = "0x80B654")]
		public float spineBend;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B68C", Offset = "0x80B68C")]
		public float spineSpeed;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float lastWeight;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1A40534", Offset = "0x1A40534", VA = "0x1A40534", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815DE0", Offset = "0x815DE0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1A4057C", Offset = "0x1A4057C", VA = "0x1A4057C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815E18", Offset = "0x815E18")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1A405C4", Offset = "0x1A405C4", VA = "0x1A405C4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1A40604", Offset = "0x1A40604", VA = "0x1A40604")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1A406B0", Offset = "0x1A406B0", VA = "0x1A406B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1A40710", Offset = "0x1A40710", VA = "0x1A40710")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1A40A30", Offset = "0x1A40A30", VA = "0x1A40A30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1A40A84", Offset = "0x1A40A84", VA = "0x1A40A84")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1A40EA0", Offset = "0x1A40EA0", VA = "0x1A40EA0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1A40F74", Offset = "0x1A40F74", VA = "0x1A40F74")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1A410D4", Offset = "0x1A410D4", VA = "0x1A410D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1A41298", Offset = "0x1A41298", VA = "0x1A41298")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80946C", Offset = "0x80946C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80946C", Offset = "0x80946C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000043")]
		public class SpineEffector
		{
			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B76C", Offset = "0x80B76C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B7A4", Offset = "0x80B7A4")]
			public float horizontalWeight;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B7DC", Offset = "0x80B7DC")]
			public float verticalWeight;

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x152ACAC", Offset = "0x152ACAC", VA = "0x152ACAC")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x152ACBC", Offset = "0x152ACBC", VA = "0x152ACBC")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B6C4", Offset = "0x80B6C4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B6FC", Offset = "0x80B6FC")]
		public float spineBend;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B734", Offset = "0x80B734")]
		public float spineSpeed;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SpineEffector[] spine;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] feet;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 spineOffset;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool firstSolve;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1A416E8", Offset = "0x1A416E8", VA = "0x1A416E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815E50", Offset = "0x815E50")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1A41730", Offset = "0x1A41730", VA = "0x1A41730", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815E88", Offset = "0x815E88")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1A41778", Offset = "0x1A41778", VA = "0x1A41778", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815EC0", Offset = "0x815EC0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1A417C0", Offset = "0x1A417C0", VA = "0x1A417C0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1A41800", Offset = "0x1A41800", VA = "0x1A41800")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1A41894", Offset = "0x1A41894", VA = "0x1A41894")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1A41BCC", Offset = "0x1A41BCC", VA = "0x1A41BCC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1A41BD8", Offset = "0x1A41BD8", VA = "0x1A41BD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1A418FC", Offset = "0x1A418FC", VA = "0x1A418FC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1A41BE4", Offset = "0x1A41BE4", VA = "0x1A41BE4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1A41F04", Offset = "0x1A41F04", VA = "0x1A41F04")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1A42014", Offset = "0x1A42014", VA = "0x1A42014")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1A42190", Offset = "0x1A42190", VA = "0x1A42190")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1A421A4", Offset = "0x1A421A4", VA = "0x1A421A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1A42358", Offset = "0x1A42358", VA = "0x1A42358")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8094CC", Offset = "0x8094CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8094CC", Offset = "0x8094CC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IK[] legs;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B814", Offset = "0x80B814")]
		public Transform pelvis;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B84C", Offset = "0x80B84C")]
		public Transform characterRoot;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B884", Offset = "0x80B884")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B884", Offset = "0x80B884")]
		public float rootRotationWeight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B8D8", Offset = "0x80B8D8")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B910", Offset = "0x80B910")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] feet;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int solvedFeet;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool solved;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float lastWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1A423F8", Offset = "0x1A423F8", VA = "0x1A423F8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815EF8", Offset = "0x815EF8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1A42440", Offset = "0x1A42440", VA = "0x1A42440", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815F30", Offset = "0x815F30")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1A42488", Offset = "0x1A42488", VA = "0x1A42488", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1A42688", Offset = "0x1A42688", VA = "0x1A42688")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1A428BC", Offset = "0x1A428BC", VA = "0x1A428BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1A429B8", Offset = "0x1A429B8", VA = "0x1A429B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1A42E0C", Offset = "0x1A42E0C", VA = "0x1A42E0C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1A43274", Offset = "0x1A43274", VA = "0x1A43274")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1A43404", Offset = "0x1A43404", VA = "0x1A43404")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1A43708", Offset = "0x1A43708", VA = "0x1A43708")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1A43874", Offset = "0x1A43874", VA = "0x1A43874")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1A43A80", Offset = "0x1A43A80", VA = "0x1A43A80")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80952C", Offset = "0x80952C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80952C", Offset = "0x80952C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000046")]
		public struct Foot
		{
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x152AD04", Offset = "0x152AD04", VA = "0x152AD04")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B948", Offset = "0x80B948")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B980", Offset = "0x80B980")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B980", Offset = "0x80B980")]
		public float rootRotationWeight;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80B9D4", Offset = "0x80B9D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80B9D4", Offset = "0x80B9D4")]
		public float minRootRotation;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80BA2C", Offset = "0x80BA2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BA2C", Offset = "0x80BA2C")]
		public float maxRootRotation;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BA84", Offset = "0x80BA84")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BABC", Offset = "0x80BABC")]
		public float maxLegOffset;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BAF4", Offset = "0x80BAF4")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80BB2C", Offset = "0x80BB2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BB2C", Offset = "0x80BB2C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BB80", Offset = "0x80BB80")]
		public Transform characterRoot;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BBB8", Offset = "0x80BBB8")]
		public Transform pelvis;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BBF0", Offset = "0x80BBF0")]
		public Transform lastSpineBone;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BC28", Offset = "0x80BC28")]
		public Transform head;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] legs;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IK[] forelegs;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Foot[] feet;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int solvedFeet;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool solved;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float angle;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform forefeetRoot;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Quaternion headRotation;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float lastWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1C10810", Offset = "0x1C10810", VA = "0x1C10810", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815F68", Offset = "0x815F68")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1C10858", Offset = "0x1C10858", VA = "0x1C10858", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x815FA0", Offset = "0x815FA0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1C108A0", Offset = "0x1C108A0", VA = "0x1C108A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1C10AB4", Offset = "0x1C10AB4", VA = "0x1C10AB4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1C10BE0", Offset = "0x1C10BE0", VA = "0x1C10BE0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1C10DD0", Offset = "0x1C10DD0", VA = "0x1C10DD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1C10E38", Offset = "0x1C10E38", VA = "0x1C10E38")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1C10E9C", Offset = "0x1C10E9C", VA = "0x1C10E9C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1C111FC", Offset = "0x1C111FC", VA = "0x1C111FC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1C11864", Offset = "0x1C11864", VA = "0x1C11864")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1C1195C", Offset = "0x1C1195C", VA = "0x1C1195C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1C11D28", Offset = "0x1C11D28", VA = "0x1C11D28")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1C12348", Offset = "0x1C12348", VA = "0x1C12348")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1C12788", Offset = "0x1C12788", VA = "0x1C12788")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1C12864", Offset = "0x1C12864", VA = "0x1C12864")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1C12AD0", Offset = "0x1C12AD0", VA = "0x1C12AD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1C12B08", Offset = "0x1C12B08", VA = "0x1C12B08")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1C12D0C", Offset = "0x1C12D0C", VA = "0x1C12D0C")]
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
			[Token(Token = "0x40001BE")]
			Fastest,
			[Token(Token = "0x40001BF")]
			Simple,
			[Token(Token = "0x40001C0")]
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
			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C11C", Offset = "0x80C11C")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C12C", Offset = "0x80C12C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C13C", Offset = "0x80C13C")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C14C", Offset = "0x80C14C")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C15C", Offset = "0x80C15C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C16C", Offset = "0x80C16C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C17C", Offset = "0x80C17C")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C18C", Offset = "0x80C18C")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C19C", Offset = "0x80C19C")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700002D")]
			public bool isGrounded
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x152AD68", Offset = "0x152AD68", VA = "0x152AD68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816078", Offset = "0x816078")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600020F")]
				[Address(RVA = "0x152AD70", Offset = "0x152AD70", VA = "0x152AD70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816088", Offset = "0x816088")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0x152AD7C", Offset = "0x152AD7C", VA = "0x152AD7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816098", Offset = "0x816098")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000211")]
				[Address(RVA = "0x152AD88", Offset = "0x152AD88", VA = "0x152AD88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160A8", Offset = "0x8160A8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public bool initiated
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0x152AD94", Offset = "0x152AD94", VA = "0x152AD94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160B8", Offset = "0x8160B8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000213")]
				[Address(RVA = "0x152AD9C", Offset = "0x152AD9C", VA = "0x152AD9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160C8", Offset = "0x8160C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public float heightFromGround
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0x152ADA8", Offset = "0x152ADA8", VA = "0x152ADA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160D8", Offset = "0x8160D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000215")]
				[Address(RVA = "0x152ADB0", Offset = "0x152ADB0", VA = "0x152ADB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160E8", Offset = "0x8160E8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000031")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000216")]
				[Address(RVA = "0x152ADB8", Offset = "0x152ADB8", VA = "0x152ADB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160F8", Offset = "0x8160F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000217")]
				[Address(RVA = "0x152ADC4", Offset = "0x152ADC4", VA = "0x152ADC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816108", Offset = "0x816108")]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public Transform transform
			{
				[Token(Token = "0x6000218")]
				[Address(RVA = "0x152ADD0", Offset = "0x152ADD0", VA = "0x152ADD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816118", Offset = "0x816118")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000219")]
				[Address(RVA = "0x152ADD8", Offset = "0x152ADD8", VA = "0x152ADD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816128", Offset = "0x816128")]
				private set
				{
				}
			}

			[Token(Token = "0x17000033")]
			public float IKOffset
			{
				[Token(Token = "0x600021A")]
				[Address(RVA = "0x152ADE0", Offset = "0x152ADE0", VA = "0x152ADE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816138", Offset = "0x816138")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600021B")]
				[Address(RVA = "0x152ADE8", Offset = "0x152ADE8", VA = "0x152ADE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816148", Offset = "0x816148")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0x152ADF0", Offset = "0x152ADF0", VA = "0x152ADF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816158", Offset = "0x816158")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600021D")]
				[Address(RVA = "0x152AE08", Offset = "0x152AE08", VA = "0x152AE08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816168", Offset = "0x816168")]
				private set
				{
				}
			}

			[Token(Token = "0x17000035")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x152AE28", Offset = "0x152AE28", VA = "0x152AE28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816178", Offset = "0x816178")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x152AE40", Offset = "0x152AE40", VA = "0x152AE40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816188", Offset = "0x816188")]
				private set
				{
				}
			}

			[Token(Token = "0x17000036")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000220")]
				[Address(RVA = "0x152AE60", Offset = "0x152AE60", VA = "0x152AE60")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000037")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000226")]
				[Address(RVA = "0x152C010", Offset = "0x152C010", VA = "0x152C010")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000038")]
			private float rootYOffset
			{
				[Token(Token = "0x600022F")]
				[Address(RVA = "0x152C878", Offset = "0x152C878", VA = "0x152C878")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x152AEA8", Offset = "0x152AEA8", VA = "0x152AEA8")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x152AEBC", Offset = "0x152AEBC", VA = "0x152AEBC")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x152AF4C", Offset = "0x152AF4C", VA = "0x152AF4C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x152AF98", Offset = "0x152AF98", VA = "0x152AF98")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x152B008", Offset = "0x152B008", VA = "0x152B008")]
			public void Process()
			{
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x152BC9C", Offset = "0x152BC9C", VA = "0x152BC9C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x152B854", Offset = "0x152B854", VA = "0x152B854")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x152C7A8", Offset = "0x152C7A8", VA = "0x152C7A8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x152BADC", Offset = "0x152BADC", VA = "0x152BADC")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x152BB68", Offset = "0x152BB68", VA = "0x152BB68")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x152C818", Offset = "0x152C818", VA = "0x152C818")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x152C038", Offset = "0x152C038", VA = "0x152C038")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x152C90C", Offset = "0x152C90C", VA = "0x152C90C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x152C998", Offset = "0x152C998", VA = "0x152C998")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200004D")]
		public class Pelvis
		{
			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C1AC", Offset = "0x80C1AC")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C1BC", Offset = "0x80C1BC")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000039")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000231")]
				[Address(RVA = "0x152D284", Offset = "0x152D284", VA = "0x152D284")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816198", Offset = "0x816198")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000232")]
				[Address(RVA = "0x152D290", Offset = "0x152D290", VA = "0x152D290")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161A8", Offset = "0x8161A8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003A")]
			public float heightOffset
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x152D29C", Offset = "0x152D29C", VA = "0x152D29C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161B8", Offset = "0x8161B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000234")]
				[Address(RVA = "0x152D2A4", Offset = "0x152D2A4", VA = "0x152D2A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161C8", Offset = "0x8161C8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x152D2AC", Offset = "0x152D2AC", VA = "0x152D2AC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x152D33C", Offset = "0x152D33C", VA = "0x152D33C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x152D2DC", Offset = "0x152D2DC", VA = "0x152D2DC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x152D3A8", Offset = "0x152D3A8", VA = "0x152D3A8")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x152D548", Offset = "0x152D548", VA = "0x152D548")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BC70", Offset = "0x80BC70")]
		public LayerMask layers;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BCA8", Offset = "0x80BCA8")]
		public float maxStep;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BCE0", Offset = "0x80BCE0")]
		public float heightOffset;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BD18", Offset = "0x80BD18")]
		public float footSpeed;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BD50", Offset = "0x80BD50")]
		public float footRadius;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BD88", Offset = "0x80BD88")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BDD4", Offset = "0x80BDD4")]
		public float prediction;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BE0C", Offset = "0x80BE0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80BE0C", Offset = "0x80BE0C")]
		public float footRotationWeight;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BE60", Offset = "0x80BE60")]
		public float footRotationSpeed;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80BE98", Offset = "0x80BE98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BE98", Offset = "0x80BE98")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BEF0", Offset = "0x80BEF0")]
		public bool rotateSolver;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BF28", Offset = "0x80BF28")]
		public float pelvisSpeed;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80BF60", Offset = "0x80BF60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BF60", Offset = "0x80BF60")]
		public float pelvisDamper;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BFB4", Offset = "0x80BFB4")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80BFEC", Offset = "0x80BFEC")]
		public float liftPelvisWeight;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C024", Offset = "0x80C024")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C05C", Offset = "0x80C05C")]
		public bool overstepFallsDown;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C094", Offset = "0x80C094")]
		public Quality quality;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C0CC", Offset = "0x80C0CC")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C0DC", Offset = "0x80C0DC")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C0EC", Offset = "0x80C0EC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C0FC", Offset = "0x80C0FC")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C10C", Offset = "0x80C10C")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public OnRaycastDelegate Raycast;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public OnCapsuleCastDelegate CapsuleCast;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public OnSphereCastDelegate SphereCast;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool initiated;

		[Token(Token = "0x17000025")]
		public Leg[] legs
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x1C12F54", Offset = "0x1C12F54", VA = "0x1C12F54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815FD8", Offset = "0x815FD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x1C12F5C", Offset = "0x1C12F5C", VA = "0x1C12F5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815FE8", Offset = "0x815FE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x1C12F64", Offset = "0x1C12F64", VA = "0x1C12F64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815FF8", Offset = "0x815FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x1C12F6C", Offset = "0x1C12F6C", VA = "0x1C12F6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816008", Offset = "0x816008")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool isGrounded
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x1C12F74", Offset = "0x1C12F74", VA = "0x1C12F74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816018", Offset = "0x816018")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x1C12F7C", Offset = "0x1C12F7C", VA = "0x1C12F7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816028", Offset = "0x816028")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Transform root
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x1C12F88", Offset = "0x1C12F88", VA = "0x1C12F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816038", Offset = "0x816038")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x1C12F90", Offset = "0x1C12F90", VA = "0x1C12F90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816048", Offset = "0x816048")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1C12F98", Offset = "0x1C12F98", VA = "0x1C12F98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816058", Offset = "0x816058")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1C12FB0", Offset = "0x1C12FB0", VA = "0x1C12FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816068", Offset = "0x816068")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x1C12FD0", Offset = "0x1C12FD0", VA = "0x1C12FD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002B")]
		public Vector3 up
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x1C13288", Offset = "0x1C13288", VA = "0x1C13288")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002C")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x1C13558", Offset = "0x1C13558", VA = "0x1C13558")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1C13024", Offset = "0x1C13024", VA = "0x1C13024")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1C132CC", Offset = "0x1C132CC", VA = "0x1C132CC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1C11594", Offset = "0x1C11594", VA = "0x1C11594")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1C12518", Offset = "0x1C12518", VA = "0x1C12518")]
		public void Update()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1C133F8", Offset = "0x1C133F8", VA = "0x1C133F8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1C10A28", Offset = "0x1C10A28", VA = "0x1C10A28")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1C133E0", Offset = "0x1C133E0", VA = "0x1C133E0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1C135D8", Offset = "0x1C135D8", VA = "0x1C135D8")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1C13668", Offset = "0x1C13668", VA = "0x1C13668")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1C13724", Offset = "0x1C13724", VA = "0x1C13724")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1C12DD4", Offset = "0x1C12DD4", VA = "0x1C12DD4")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80958C", Offset = "0x80958C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80958C", Offset = "0x80958C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x19B9328", Offset = "0x19B9328", VA = "0x19B9328", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8161D8", Offset = "0x8161D8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x19B9370", Offset = "0x19B9370", VA = "0x19B9370", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816210", Offset = "0x816210")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x19B93B8", Offset = "0x19B93B8", VA = "0x19B93B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816248", Offset = "0x816248")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x19B9400", Offset = "0x19B9400", VA = "0x19B9400")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816280", Offset = "0x816280")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x19B9448", Offset = "0x19B9448", VA = "0x19B9448")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8162B8", Offset = "0x8162B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x19B9490", Offset = "0x19B9490", VA = "0x19B9490", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x19B9498", Offset = "0x19B9498", VA = "0x19B9498")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8095EC", Offset = "0x8095EC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8095EC", Offset = "0x8095EC")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x19BAF80", Offset = "0x19BAF80", VA = "0x19BAF80", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8162F0", Offset = "0x8162F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x19BAFC8", Offset = "0x19BAFC8", VA = "0x19BAFC8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816328", Offset = "0x816328")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x19BB010", Offset = "0x19BB010", VA = "0x19BB010")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816360", Offset = "0x816360")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x19BB058", Offset = "0x19BB058", VA = "0x19BB058")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816398", Offset = "0x816398")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x19BB0A0", Offset = "0x19BB0A0", VA = "0x19BB0A0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x19BB0A8", Offset = "0x19BB0A8", VA = "0x19BB0A8")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80964C", Offset = "0x80964C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80964C", Offset = "0x80964C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x19C90FC", Offset = "0x19C90FC", VA = "0x19C90FC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8163D0", Offset = "0x8163D0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x19C9144", Offset = "0x19C9144", VA = "0x19C9144", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816408", Offset = "0x816408")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x19C918C", Offset = "0x19C918C", VA = "0x19C918C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816440", Offset = "0x816440")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x19C91D4", Offset = "0x19C91D4", VA = "0x19C91D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816478", Offset = "0x816478")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x19C921C", Offset = "0x19C921C", VA = "0x19C921C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x19C9224", Offset = "0x19C9224", VA = "0x19C9224")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8096AC", Offset = "0x8096AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8096AC", Offset = "0x8096AC")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1A352A8", Offset = "0x1A352A8", VA = "0x1A352A8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8164B0", Offset = "0x8164B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1A352F0", Offset = "0x1A352F0", VA = "0x1A352F0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8164E8", Offset = "0x8164E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1A35338", Offset = "0x1A35338", VA = "0x1A35338")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816520", Offset = "0x816520")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1A35380", Offset = "0x1A35380", VA = "0x1A35380")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816558", Offset = "0x816558")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1A353C8", Offset = "0x1A353C8", VA = "0x1A353C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1A353D0", Offset = "0x1A353D0", VA = "0x1A353D0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80970C", Offset = "0x80970C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80970C", Offset = "0x80970C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1A35918", Offset = "0x1A35918", VA = "0x1A35918", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816590", Offset = "0x816590")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1A35960", Offset = "0x1A35960", VA = "0x1A35960", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8165C8", Offset = "0x8165C8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1A359A8", Offset = "0x1A359A8", VA = "0x1A359A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816600", Offset = "0x816600")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1A359F0", Offset = "0x1A359F0", VA = "0x1A359F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816638", Offset = "0x816638")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1A35A38", Offset = "0x1A35A38", VA = "0x1A35A38", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1A35A40", Offset = "0x1A35A40", VA = "0x1A35A40")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80976C", Offset = "0x80976C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80976C", Offset = "0x80976C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1A3ED40", Offset = "0x1A3ED40", VA = "0x1A3ED40", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816670", Offset = "0x816670")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1A3ED88", Offset = "0x1A3ED88", VA = "0x1A3ED88", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8166A8", Offset = "0x8166A8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1A3EDD0", Offset = "0x1A3EDD0", VA = "0x1A3EDD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8166E0", Offset = "0x8166E0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1A3EE18", Offset = "0x1A3EE18", VA = "0x1A3EE18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816718", Offset = "0x816718")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1A3EE60", Offset = "0x1A3EE60", VA = "0x1A3EE60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816750", Offset = "0x816750")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1A3EEA8", Offset = "0x1A3EEA8", VA = "0x1A3EEA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816788", Offset = "0x816788")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1A3EEF0", Offset = "0x1A3EEF0", VA = "0x1A3EEF0")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1A3EF34", Offset = "0x1A3EF34", VA = "0x1A3EF34", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1A3EF3C", Offset = "0x1A3EF3C", VA = "0x1A3EF3C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1A3F124", Offset = "0x1A3F124", VA = "0x1A3F124")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1A3F3C4", Offset = "0x1A3F3C4", VA = "0x1A3F3C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8167C0", Offset = "0x8167C0")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1A3F3E4", Offset = "0x1A3F3E4", VA = "0x1A3F3E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8167F8", Offset = "0x8167F8")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1A3F4D4", Offset = "0x1A3F4D4", VA = "0x1A3F4D4")]
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
		[Address(RVA = "0x1C17430", Offset = "0x1C17430", VA = "0x1C17430", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1C17524", Offset = "0x1C17524", VA = "0x1C17524", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1C1771C", Offset = "0x1C1771C", VA = "0x1C1771C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600026A")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600026B")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1C1777C", Offset = "0x1C1777C", VA = "0x1C1777C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C1CC", Offset = "0x80C1CC")]
		public IK[] IKComponents;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C204", Offset = "0x80C204")]
		public Animator animator;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700003B")]
		private bool animatePhysics
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x1C19DB0", Offset = "0x1C19DB0", VA = "0x1C19DB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1C19E48", Offset = "0x1C19E48", VA = "0x1C19E48")]
		private void Start()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1C19EB8", Offset = "0x1C19EB8", VA = "0x1C19EB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1C19F74", Offset = "0x1C19F74", VA = "0x1C19F74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1C19FB0", Offset = "0x1C19FB0", VA = "0x1C19FB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1C19EEC", Offset = "0x1C19EEC", VA = "0x1C19EEC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1C1A03C", Offset = "0x1C1A03C", VA = "0x1C1A03C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8097CC", Offset = "0x8097CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8097CC", Offset = "0x8097CC")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1B0A63C", Offset = "0x1B0A63C", VA = "0x1B0A63C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816830", Offset = "0x816830")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1B0A684", Offset = "0x1B0A684", VA = "0x1B0A684", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816868", Offset = "0x816868")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1B0A6CC", Offset = "0x1B0A6CC", VA = "0x1B0A6CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8168A0", Offset = "0x8168A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1B0A714", Offset = "0x1B0A714", VA = "0x1B0A714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8168D8", Offset = "0x8168D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1B0A75C", Offset = "0x1B0A75C", VA = "0x1B0A75C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1B0A764", Offset = "0x1B0A764", VA = "0x1B0A764")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80982C", Offset = "0x80982C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80982C", Offset = "0x80982C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1B0A7D4", Offset = "0x1B0A7D4", VA = "0x1B0A7D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816910", Offset = "0x816910")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1B0A81C", Offset = "0x1B0A81C", VA = "0x1B0A81C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816948", Offset = "0x816948")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1B0A864", Offset = "0x1B0A864", VA = "0x1B0A864")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816980", Offset = "0x816980")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1B0A8AC", Offset = "0x1B0A8AC", VA = "0x1B0A8AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8169B8", Offset = "0x8169B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1B0A8F4", Offset = "0x1B0A8F4", VA = "0x1B0A8F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1B0A8FC", Offset = "0x1B0A8FC", VA = "0x1B0A8FC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x80988C", Offset = "0x80988C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80988C", Offset = "0x80988C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1B0B308", Offset = "0x1B0B308", VA = "0x1B0B308", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8169F0", Offset = "0x8169F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1B0B350", Offset = "0x1B0B350", VA = "0x1B0B350", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816A28", Offset = "0x816A28")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1B0B398", Offset = "0x1B0B398", VA = "0x1B0B398")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816A60", Offset = "0x816A60")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1B0B3E0", Offset = "0x1B0B3E0", VA = "0x1B0B3E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816A98", Offset = "0x816A98")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1B0B428", Offset = "0x1B0B428", VA = "0x1B0B428", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1B0B430", Offset = "0x1B0B430", VA = "0x1B0B430")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8098EC", Offset = "0x8098EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8098EC", Offset = "0x8098EC")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x151F358", Offset = "0x151F358", VA = "0x151F358", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816AD0", Offset = "0x816AD0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x151F3A0", Offset = "0x151F3A0", VA = "0x151F3A0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816B08", Offset = "0x816B08")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x151F3E8", Offset = "0x151F3E8", VA = "0x151F3E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816B40", Offset = "0x816B40")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x151F430", Offset = "0x151F430", VA = "0x151F430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816B78", Offset = "0x816B78")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x151F478", Offset = "0x151F478", VA = "0x151F478", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x151F480", Offset = "0x151F480", VA = "0x151F480")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80994C", Offset = "0x80994C")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public class References
		{
			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80C2F0", Offset = "0x80C2F0")]
			public Transform pelvis;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C328", Offset = "0x80C328")]
			public Transform chest;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C360", Offset = "0x80C360")]
			public Transform neck;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C398", Offset = "0x80C398")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80C398", Offset = "0x80C398")]
			public Transform leftShoulder;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C3F8", Offset = "0x80C3F8")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C430", Offset = "0x80C430")]
			public Transform leftForearm;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C468", Offset = "0x80C468")]
			public Transform leftHand;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C4A0", Offset = "0x80C4A0")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80C4A0", Offset = "0x80C4A0")]
			public Transform rightShoulder;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C500", Offset = "0x80C500")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C538", Offset = "0x80C538")]
			public Transform rightForearm;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C570", Offset = "0x80C570")]
			public Transform rightHand;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80C5A8", Offset = "0x80C5A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C5A8", Offset = "0x80C5A8")]
			public Transform leftThigh;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C608", Offset = "0x80C608")]
			public Transform leftCalf;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C640", Offset = "0x80C640")]
			public Transform leftFoot;

			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C678", Offset = "0x80C678")]
			public Transform leftToes;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C6B0", Offset = "0x80C6B0")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80C6B0", Offset = "0x80C6B0")]
			public Transform rightThigh;

			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C710", Offset = "0x80C710")]
			public Transform rightCalf;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C748", Offset = "0x80C748")]
			public Transform rightFoot;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C780", Offset = "0x80C780")]
			public Transform rightToes;

			[Token(Token = "0x1700003C")]
			public bool isFilled
			{
				[Token(Token = "0x6000298")]
				[Address(RVA = "0x1E5BB74", Offset = "0x1E5BB74", VA = "0x1E5BB74")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700003D")]
			public bool isEmpty
			{
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x1E5C154", Offset = "0x1E5C154", VA = "0x1E5C154")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1E5B404", Offset = "0x1E5B404", VA = "0x1E5B404")]
			public References()
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x1E5B40C", Offset = "0x1E5B40C", VA = "0x1E5B40C")]
			public References(BipedReferences b)
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1E5B624", Offset = "0x1E5B624", VA = "0x1E5B624")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1E5C5CC", Offset = "0x1E5C5CC", VA = "0x1E5C5CC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x80C23C", Offset = "0x80C23C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C23C", Offset = "0x80C23C")]
		public References references;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C2B8", Offset = "0x80C2B8")]
		public IKSolverVR solver;

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1522BA8", Offset = "0x1522BA8", VA = "0x1522BA8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816BB0", Offset = "0x816BB0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1522BF0", Offset = "0x1522BF0", VA = "0x1522BF0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816BE8", Offset = "0x816BE8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1522C38", Offset = "0x1522C38", VA = "0x1522C38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816C20", Offset = "0x816C20")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1522C80", Offset = "0x1522C80", VA = "0x1522C80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816C58", Offset = "0x816C58")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1522CAC", Offset = "0x1522CAC", VA = "0x1522CAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816C90", Offset = "0x816C90")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1522CD4", Offset = "0x1522CD4", VA = "0x1522CD4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1522CDC", Offset = "0x1522CDC", VA = "0x1522CDC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1522D5C", Offset = "0x1522D5C", VA = "0x1522D5C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1522EC8", Offset = "0x1522EC8", VA = "0x1522EC8")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80C7B8", Offset = "0x80C7B8")]
		public float pull;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80C7D0", Offset = "0x80C7D0")]
		public float pin;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1A35440", Offset = "0x1A35440", VA = "0x1A35440")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1A3551C", Offset = "0x1A3551C", VA = "0x1A3551C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1A3553C", Offset = "0x1A3553C", VA = "0x1A3553C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1A357B0", Offset = "0x1A357B0", VA = "0x1A357B0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1A35610", Offset = "0x1A35610", VA = "0x1A35610")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1A358A8", Offset = "0x1A358A8", VA = "0x1A358A8")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1A35AB0", Offset = "0x1A35AB0", VA = "0x1A35AB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1A35F28", Offset = "0x1A35F28", VA = "0x1A35F28")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1A360E4", Offset = "0x1A360E4", VA = "0x1A360E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1A36214", Offset = "0x1A36214", VA = "0x1A36214")]
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
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CE28", Offset = "0x80CE28")]
			public Transform transform;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CE60", Offset = "0x80CE60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CE60", Offset = "0x80CE60")]
			public float weight;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x152A080", Offset = "0x152A080", VA = "0x152A080")]
			public BendBone()
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x152A0BC", Offset = "0x152A0BC", VA = "0x152A0BC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x152A120", Offset = "0x152A120", VA = "0x152A120")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x152A158", Offset = "0x152A158", VA = "0x152A158")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C7E8", Offset = "0x80C7E8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x80C820", Offset = "0x80C820")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80C820", Offset = "0x80C820")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C820", Offset = "0x80C820")]
		public float positionWeight;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C898", Offset = "0x80C898")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80C898", Offset = "0x80C898")]
		public float bodyWeight;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80C8EC", Offset = "0x80C8EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C8EC", Offset = "0x80C8EC")]
		public float thighWeight;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C940", Offset = "0x80C940")]
		public bool handsPullBody;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x80C978", Offset = "0x80C978")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C978", Offset = "0x80C978")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80C978", Offset = "0x80C978")]
		public float rotationWeight;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80C9F0", Offset = "0x80C9F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80C9F0", Offset = "0x80C9F0")]
		public float bodyClampWeight;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CA44", Offset = "0x80CA44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CA44", Offset = "0x80CA44")]
		public float headClampWeight;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CA98", Offset = "0x80CA98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CA98", Offset = "0x80CA98")]
		public float bendWeight;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CAEC", Offset = "0x80CAEC")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CB24", Offset = "0x80CB24")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x80CB24", Offset = "0x80CB24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CB24", Offset = "0x80CB24")]
		public float CCDWeight;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CB9C", Offset = "0x80CB9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CB9C", Offset = "0x80CB9C")]
		public float roll;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CBF0", Offset = "0x80CBF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CBF0", Offset = "0x80CBF0")]
		public float damper;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CC48", Offset = "0x80CC48")]
		public Transform[] CCDBones;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x80CC80", Offset = "0x80CC80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CC80", Offset = "0x80CC80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CC80", Offset = "0x80CC80")]
		public float postStretchWeight;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CCF8", Offset = "0x80CCF8")]
		public float maxStretch;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CD30", Offset = "0x80CD30")]
		public float stretchDamper;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CD68", Offset = "0x80CD68")]
		public bool fixHead;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80CDA0", Offset = "0x80CDA0")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x80CDD8", Offset = "0x80CDD8")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CE10", Offset = "0x80CE10")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1A3621C", Offset = "0x1A3621C", VA = "0x1A3621C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1A365A4", Offset = "0x1A365A4", VA = "0x1A365A4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1A36A80", Offset = "0x1A36A80", VA = "0x1A36A80")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1A36E4C", Offset = "0x1A36E4C", VA = "0x1A36E4C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1A375D8", Offset = "0x1A375D8", VA = "0x1A375D8")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1A378B8", Offset = "0x1A378B8", VA = "0x1A378B8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1A37BBC", Offset = "0x1A37BBC", VA = "0x1A37BBC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1A38390", Offset = "0x1A38390", VA = "0x1A38390")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1A373BC", Offset = "0x1A373BC", VA = "0x1A373BC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1A38558", Offset = "0x1A38558", VA = "0x1A38558")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1A382A8", Offset = "0x1A382A8", VA = "0x1A382A8")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1A381DC", Offset = "0x1A381DC", VA = "0x1A381DC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1A387DC", Offset = "0x1A387DC", VA = "0x1A387DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1A38B10", Offset = "0x1A38B10", VA = "0x1A38B10")]
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
			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF4C", Offset = "0x80CF4C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF5C", Offset = "0x80CF5C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700003E")]
			public float nominalDistance
			{
				[Token(Token = "0x60002CB")]
				[Address(RVA = "0x152A214", Offset = "0x152A214", VA = "0x152A214")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CC8", Offset = "0x816CC8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0x152A21C", Offset = "0x152A21C", VA = "0x152A21C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CD8", Offset = "0x816CD8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003F")]
			public bool isRigid
			{
				[Token(Token = "0x60002CD")]
				[Address(RVA = "0x152A224", Offset = "0x152A224", VA = "0x152A224")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CE8", Offset = "0x816CE8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0x152A22C", Offset = "0x152A22C", VA = "0x152A22C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CF8", Offset = "0x816CF8")]
				private set
				{
				}
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x152A238", Offset = "0x152A238", VA = "0x152A238")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x152A2A0", Offset = "0x152A2A0", VA = "0x152A2A0")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x152A2F8", Offset = "0x152A2F8", VA = "0x152A2F8")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x152A49C", Offset = "0x152A49C", VA = "0x152A49C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000062")]
		public enum Smoothing
		{
			[Token(Token = "0x4000262")]
			None,
			[Token(Token = "0x4000263")]
			Exponential,
			[Token(Token = "0x4000264")]
			Cubic
		}

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CEB4", Offset = "0x80CEB4")]
		public float pin;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CECC", Offset = "0x80CECC")]
		public float pull;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CEE4", Offset = "0x80CEE4")]
		public float push;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CEFC", Offset = "0x80CEFC")]
		public float pushParent;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CF14", Offset = "0x80CF14")]
		public float reach;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000256")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1A3926C", Offset = "0x1A3926C", VA = "0x1A3926C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1A39388", Offset = "0x1A39388", VA = "0x1A39388")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1A394F8", Offset = "0x1A394F8", VA = "0x1A394F8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1A39634", Offset = "0x1A39634", VA = "0x1A39634")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1A3970C", Offset = "0x1A3970C", VA = "0x1A3970C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1A39830", Offset = "0x1A39830", VA = "0x1A39830")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1A39F00", Offset = "0x1A39F00", VA = "0x1A39F00")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1A399CC", Offset = "0x1A399CC", VA = "0x1A399CC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1A3A2F0", Offset = "0x1A3A2F0", VA = "0x1A3A2F0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1A3A550", Offset = "0x1A3A550", VA = "0x1A3A550")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1A3A7BC", Offset = "0x1A3A7BC", VA = "0x1A3A7BC")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1A3AB60", Offset = "0x1A3AB60", VA = "0x1A3AB60")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1A3AFF4", Offset = "0x1A3AFF4", VA = "0x1A3AFF4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1A3B218", Offset = "0x1A3B218", VA = "0x1A3B218")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1A3AF84", Offset = "0x1A3AF84", VA = "0x1A3AF84")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1A3A9EC", Offset = "0x1A3A9EC", VA = "0x1A3A9EC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1A3AF08", Offset = "0x1A3AF08", VA = "0x1A3AF08")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1A3B300", Offset = "0x1A3B300", VA = "0x1A3B300")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1A3AE28", Offset = "0x1A3AE28", VA = "0x1A3AE28")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1A3B100", Offset = "0x1A3B100", VA = "0x1A3B100")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CF6C", Offset = "0x80CF6C")]
		public float weight;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF84", Offset = "0x80CF84")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000040")]
		public bool initiated
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x1C1796C", Offset = "0x1C1796C", VA = "0x1C1796C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D08", Offset = "0x816D08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1C17974", Offset = "0x1C17974", VA = "0x1C17974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D18", Offset = "0x816D18")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1C17784", Offset = "0x1C17784", VA = "0x1C17784")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1C17980", Offset = "0x1C17980", VA = "0x1C17980")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1C179C0", Offset = "0x1C179C0", VA = "0x1C179C0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1C17A28", Offset = "0x1C17A28", VA = "0x1C17A28")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1C17A78", Offset = "0x1C17A78", VA = "0x1C17A78")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1C17D8C", Offset = "0x1C17D8C", VA = "0x1C17D8C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1C17F7C", Offset = "0x1C17F7C", VA = "0x1C17F7C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1C182C8", Offset = "0x1C182C8", VA = "0x1C182C8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1C17C3C", Offset = "0x1C17C3C", VA = "0x1C17C3C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1C17CE4", Offset = "0x1C17CE4", VA = "0x1C17CE4")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKEffector
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CF94", Offset = "0x80CF94")]
		public float positionWeight;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CFAC", Offset = "0x80CFAC")]
		public float rotationWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CFC4", Offset = "0x80CFC4")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CFD4", Offset = "0x80CFD4")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000041")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x1C18764", Offset = "0x1C18764", VA = "0x1C18764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D28", Offset = "0x816D28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x1C1876C", Offset = "0x1C1876C", VA = "0x1C1876C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D38", Offset = "0x816D38")]
			private set
			{
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1C186FC", Offset = "0x1C186FC", VA = "0x1C186FC")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1C18778", Offset = "0x1C18778", VA = "0x1C18778")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1C18808", Offset = "0x1C18808", VA = "0x1C18808")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1C1894C", Offset = "0x1C1894C", VA = "0x1C1894C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1C18ACC", Offset = "0x1C18ACC", VA = "0x1C18ACC")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1C18DF4", Offset = "0x1C18DF4", VA = "0x1C18DF4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1C190C0", Offset = "0x1C190C0", VA = "0x1C190C0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1C19194", Offset = "0x1C19194", VA = "0x1C19194")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1C1923C", Offset = "0x1C1923C", VA = "0x1C1923C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1C19778", Offset = "0x1C19778", VA = "0x1C19778")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1C197A4", Offset = "0x1C197A4", VA = "0x1C197A4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1C19904", Offset = "0x1C19904", VA = "0x1C19904")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1C19B90", Offset = "0x1C19B90", VA = "0x1C19B90")]
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
			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000042")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002F4")]
				[Address(RVA = "0x152EA0C", Offset = "0x152EA0C", VA = "0x152EA0C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000043")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002F7")]
				[Address(RVA = "0x152EAE8", Offset = "0x152EAE8", VA = "0x152EAE8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000044")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0x152EEB8", Offset = "0x152EEB8", VA = "0x152EEB8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x152E9BC", Offset = "0x152E9BC", VA = "0x152E9BC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x152EA48", Offset = "0x152EA48", VA = "0x152EA48")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x152EA98", Offset = "0x152EA98", VA = "0x152EA98")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x152EAF8", Offset = "0x152EAF8", VA = "0x152EAF8")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x152EB80", Offset = "0x152EB80", VA = "0x152EB80")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x152EB88", Offset = "0x152EB88", VA = "0x152EB88")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x152EC60", Offset = "0x152EC60", VA = "0x152EC60")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x152ECD8", Offset = "0x152ECD8", VA = "0x152ECD8")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x152ED9C", Offset = "0x152ED9C", VA = "0x152ED9C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x152EFF8", Offset = "0x152EFF8", VA = "0x152EFF8")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x152F030", Offset = "0x152F030", VA = "0x152F030")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x152F068", Offset = "0x152F068", VA = "0x152F068")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x152F090", Offset = "0x152F090", VA = "0x152F090")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x152F17C", Offset = "0x152F17C", VA = "0x152F17C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x152F308", Offset = "0x152F308", VA = "0x152F308")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x152F338", Offset = "0x152F338", VA = "0x152F338")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x152F400", Offset = "0x152F400", VA = "0x152F400")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x152F470", Offset = "0x152F470", VA = "0x152F470")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x152F5C0", Offset = "0x152F5C0", VA = "0x152F5C0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x152F710", Offset = "0x152F710", VA = "0x152F710")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x152F790", Offset = "0x152F790", VA = "0x152F790")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x152F1F8", Offset = "0x152F1F8", VA = "0x152F1F8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x152F8C8", Offset = "0x152F8C8", VA = "0x152F8C8")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1C1A044", Offset = "0x1C1A044", VA = "0x1C1A044", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1C1A04C", Offset = "0x1C1A04C", VA = "0x1C1A04C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1C1A050", Offset = "0x1C1A050", VA = "0x1C1A050")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1C1A1A0", Offset = "0x1C1A1A0", VA = "0x1C1A1A0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1C1A210", Offset = "0x1C1A210", VA = "0x1C1A210")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80CFEC", Offset = "0x80CFEC")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1C1A218", Offset = "0x1C1A218", VA = "0x1C1A218", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1C1A2CC", Offset = "0x1C1A2CC", VA = "0x1C1A2CC")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1C1A344", Offset = "0x1C1A344", VA = "0x1C1A344")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1C1A3D8", Offset = "0x1C1A3D8", VA = "0x1C1A3D8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1C1A3F4", Offset = "0x1C1A3F4", VA = "0x1C1A3F4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1C1A414", Offset = "0x1C1A414", VA = "0x1C1A414", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1C1A4AC", Offset = "0x1C1A4AC", VA = "0x1C1A4AC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1C1A4C8", Offset = "0x1C1A4C8", VA = "0x1C1A4C8")]
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
			[Token(Token = "0x40002BC")]
			Parent,
			[Token(Token = "0x40002BD")]
			Bone1,
			[Token(Token = "0x40002BE")]
			Bone2,
			[Token(Token = "0x40002BF")]
			Bone3
		}

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D004", Offset = "0x80D004")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D01C", Offset = "0x80D01C")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1C1A4F0", Offset = "0x1C1A4F0", VA = "0x1C1A4F0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1C1A574", Offset = "0x1C1A574", VA = "0x1C1A574")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1C1A650", Offset = "0x1C1A650", VA = "0x1C1A650")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1C1A874", Offset = "0x1C1A874", VA = "0x1C1A874")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1C1A968", Offset = "0x1C1A968", VA = "0x1C1A968")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1C1AA94", Offset = "0x1C1AA94", VA = "0x1C1AA94")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1C1AAF8", Offset = "0x1C1AAF8", VA = "0x1C1AAF8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1C1ABAC", Offset = "0x1C1ABAC", VA = "0x1C1ABAC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1C1AC70", Offset = "0x1C1AC70", VA = "0x1C1AC70", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1C1AF08", Offset = "0x1C1AF08", VA = "0x1C1AF08")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1C1AF7C", Offset = "0x1C1AF7C", VA = "0x1C1AF7C")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D034", Offset = "0x80D034")]
		public int iterations;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D04C", Offset = "0x80D04C")]
		public float twistWeight;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1C1B0FC", Offset = "0x1C1B0FC", VA = "0x1C1B0FC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1C1B468", Offset = "0x1C1B468", VA = "0x1C1B468")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1C1B588", Offset = "0x1C1B588", VA = "0x1C1B588")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1C1B6E8", Offset = "0x1C1B6E8", VA = "0x1C1B6E8")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1C1B768", Offset = "0x1C1B768", VA = "0x1C1B768")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1C1B7D4", Offset = "0x1C1B7D4", VA = "0x1C1B7D4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1C1B858", Offset = "0x1C1B858", VA = "0x1C1B858", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1C1BE9C", Offset = "0x1C1BE9C", VA = "0x1C1BE9C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1C1BED4", Offset = "0x1C1BED4", VA = "0x1C1BED4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1C1C158", Offset = "0x1C1C158", VA = "0x1C1C158")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1C1C460", Offset = "0x1C1C460", VA = "0x1C1C460")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1C1C54C", Offset = "0x1C1C54C", VA = "0x1C1C54C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1C1C614", Offset = "0x1C1C614", VA = "0x1C1C614")]
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
			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D120", Offset = "0x80D120")]
			public float weight;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1CEE9D4", Offset = "0x1CEE9D4", VA = "0x1CEE9D4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1CEEA24", Offset = "0x1CEEA24", VA = "0x1CEEA24")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x1CEEAC4", Offset = "0x1CEEAC4", VA = "0x1CEEAC4")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x1CEEAFC", Offset = "0x1CEEAFC", VA = "0x1CEEAFC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1CEEB34", Offset = "0x1CEEB34", VA = "0x1CEEB34")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x1CEEB84", Offset = "0x1CEEB84", VA = "0x1CEEB84")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x1CEE588", Offset = "0x1CEE588", VA = "0x1CEE588")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006D")]
		public class Bone : Point
		{
			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000046")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600034A")]
				[Address(RVA = "0x1CEDEA4", Offset = "0x1CEDEA4", VA = "0x1CEDEA4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600034B")]
				[Address(RVA = "0x1CEDFA8", Offset = "0x1CEDFA8", VA = "0x1CEDFA8")]
				set
				{
				}
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x1CEE038", Offset = "0x1CEE038", VA = "0x1CEE038")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x1CEE1E8", Offset = "0x1CEE1E8", VA = "0x1CEE1E8")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x1CEE3BC", Offset = "0x1CEE3BC", VA = "0x1CEE3BC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1CEE51C", Offset = "0x1CEE51C", VA = "0x1CEE51C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1CEE544", Offset = "0x1CEE544", VA = "0x1CEE544")]
			public Bone()
			{
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1CEE5C4", Offset = "0x1CEE5C4", VA = "0x1CEE5C4")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x1CEE61C", Offset = "0x1CEE61C", VA = "0x1CEE61C")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006E")]
		public class Node : Point
		{
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1CEE95C", Offset = "0x1CEE95C", VA = "0x1CEE95C")]
			public Node()
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1CEE960", Offset = "0x1CEE960", VA = "0x1CEE960")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1CEE990", Offset = "0x1CEE990", VA = "0x1CEE990")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200006F")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000070")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D084", Offset = "0x80D084")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D084", Offset = "0x80D084")]
		public float IKPositionWeight;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0D8", Offset = "0x80D0D8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000045")]
		public bool initiated
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1C1C94C", Offset = "0x1C1C94C", VA = "0x1C1C94C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D48", Offset = "0x816D48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1C1C954", Offset = "0x1C1C954", VA = "0x1C1C954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D58", Offset = "0x816D58")]
			private set
			{
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1C1C87C", Offset = "0x1C1C87C", VA = "0x1C1C87C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1C17594", Offset = "0x1C17594", VA = "0x1C17594")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1C174B4", Offset = "0x1C174B4", VA = "0x1C174B4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1C1C8F4", Offset = "0x1C1C8F4", VA = "0x1C1C8F4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1C1C900", Offset = "0x1C1C900", VA = "0x1C1C900")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1C1C90C", Offset = "0x1C1C90C", VA = "0x1C1C90C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1C1C914", Offset = "0x1C1C914", VA = "0x1C1C914")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1C1C944", Offset = "0x1C1C944", VA = "0x1C1C944")]
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
		[Address(RVA = "0x1C1C960", Offset = "0x1C1C960", VA = "0x1C1C960")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1C1C978", Offset = "0x1C1C978", VA = "0x1C1C978")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1C1CAB0", Offset = "0x1C1CAB0", VA = "0x1C1CAB0")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1C1CB58", Offset = "0x1C1CB58", VA = "0x1C1CB58")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1C1CDE0", Offset = "0x1C1CDE0", VA = "0x1C1CDE0")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D138", Offset = "0x80D138")]
		public float poleWeight;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D150", Offset = "0x80D150")]
		public float clampWeight;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D168", Offset = "0x80D168")]
		public int clampSmoothing;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000047")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1C1CE74", Offset = "0x1C1CE74", VA = "0x1C1CE74")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000048")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x1C1CEB0", Offset = "0x1C1CEB0", VA = "0x1C1CEB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000049")]
		protected override int minBones
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1C1D960", Offset = "0x1C1D960", VA = "0x1C1D960", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004A")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1C1DD44", Offset = "0x1C1DD44", VA = "0x1C1DD44", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1C1CDF8", Offset = "0x1C1CDF8", VA = "0x1C1CDF8")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1C1CEEC", Offset = "0x1C1CEEC", VA = "0x1C1CEEC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1C1D10C", Offset = "0x1C1D10C", VA = "0x1C1D10C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1C1D8AC", Offset = "0x1C1D8AC", VA = "0x1C1D8AC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1C1D63C", Offset = "0x1C1D63C", VA = "0x1C1D63C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1C1D968", Offset = "0x1C1D968", VA = "0x1C1D968")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1C1DDB8", Offset = "0x1C1DDB8", VA = "0x1C1DDB8")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D180", Offset = "0x80D180")]
		public float IKRotationWeight;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1C1DE0C", Offset = "0x1C1DE0C", VA = "0x1C1DE0C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1C1E1F0", Offset = "0x1C1E1F0", VA = "0x1C1E1F0")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1C1E2A4", Offset = "0x1C1E2A4", VA = "0x1C1E2A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1C1E438", Offset = "0x1C1E438", VA = "0x1C1E438", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1C1E5CC", Offset = "0x1C1E5CC", VA = "0x1C1E5CC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1C1E628", Offset = "0x1C1E628", VA = "0x1C1E628", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1C1E698", Offset = "0x1C1E698", VA = "0x1C1E698", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1C1EA08", Offset = "0x1C1EA08", VA = "0x1C1EA08", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1C1EA34", Offset = "0x1C1EA34", VA = "0x1C1EA34")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1C1E6FC", Offset = "0x1C1E6FC", VA = "0x1C1E6FC")]
		private void Read()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1C1EAA8", Offset = "0x1C1EAA8", VA = "0x1C1EAA8")]
		private void Write()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1C1EC34", Offset = "0x1C1EC34", VA = "0x1C1EC34")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1C1EDF8", Offset = "0x1C1EDF8", VA = "0x1C1EDF8")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1C1EEA8", Offset = "0x1C1EEA8", VA = "0x1C1EEA8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1C1EF2C", Offset = "0x1C1EF2C", VA = "0x1C1EF2C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1C1F15C", Offset = "0x1C1F15C", VA = "0x1C1F15C")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1C1F738", Offset = "0x1C1F738", VA = "0x1C1F738")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700004B")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1C20664", Offset = "0x1C20664", VA = "0x1C20664", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1C1F740", Offset = "0x1C1F740", VA = "0x1C1F740")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1C1FD04", Offset = "0x1C1FD04", VA = "0x1C1FD04")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1C1FE44", Offset = "0x1C1FE44", VA = "0x1C1FE44", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1C1FED8", Offset = "0x1C1FED8", VA = "0x1C1FED8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1C203D0", Offset = "0x1C203D0", VA = "0x1C203D0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1C2066C", Offset = "0x1C2066C", VA = "0x1C2066C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1C1F81C", Offset = "0x1C1F81C", VA = "0x1C1F81C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1C1FDF0", Offset = "0x1C1FDF0", VA = "0x1C1FDF0")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1C20608", Offset = "0x1C20608", VA = "0x1C20608")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1C1FB78", Offset = "0x1C1FB78", VA = "0x1C1FB78")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1C20CBC", Offset = "0x1C20CBC", VA = "0x1C20CBC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1C20D30", Offset = "0x1C20D30", VA = "0x1C20D30")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1C20DF8", Offset = "0x1C20DF8", VA = "0x1C20DF8")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1C20EA8", Offset = "0x1C20EA8", VA = "0x1C20EA8")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1C20180", Offset = "0x1C20180", VA = "0x1C20180")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1C202A8", Offset = "0x1C202A8", VA = "0x1C202A8")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1C20FAC", Offset = "0x1C20FAC", VA = "0x1C20FAC")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1C2088C", Offset = "0x1C2088C", VA = "0x1C2088C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1C1FDE0", Offset = "0x1C1FDE0", VA = "0x1C1FDE0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1C2153C", Offset = "0x1C2153C", VA = "0x1C2153C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1C210F0", Offset = "0x1C210F0", VA = "0x1C210F0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1C206E8", Offset = "0x1C206E8", VA = "0x1C206E8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1C207C8", Offset = "0x1C207C8", VA = "0x1C207C8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1C21608", Offset = "0x1C21608", VA = "0x1C21608")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D198", Offset = "0x80D198")]
		public float rootPin;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1C216A0", Offset = "0x1C216A0", VA = "0x1C216A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1C21D2C", Offset = "0x1C21D2C", VA = "0x1C21D2C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1C21DC4", Offset = "0x1C21DC4", VA = "0x1C21DC4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1C21E64", Offset = "0x1C21E64", VA = "0x1C21E64", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1C21F70", Offset = "0x1C21F70", VA = "0x1C21F70")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1C2200C", Offset = "0x1C2200C", VA = "0x1C2200C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1C2243C", Offset = "0x1C2243C", VA = "0x1C2243C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1C2264C", Offset = "0x1C2264C", VA = "0x1C2264C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1C224E8", Offset = "0x1C224E8", VA = "0x1C224E8")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1C221F8", Offset = "0x1C221F8", VA = "0x1C221F8")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1C226E4", Offset = "0x1C226E4", VA = "0x1C226E4")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D1B0", Offset = "0x80D1B0")]
		public int iterations;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1C22754", Offset = "0x1C22754", VA = "0x1C22754")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1C22844", Offset = "0x1C22844", VA = "0x1C22844")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1C228A0", Offset = "0x1C228A0", VA = "0x1C228A0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1C229D0", Offset = "0x1C229D0", VA = "0x1C229D0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1C22A2C", Offset = "0x1C22A2C", VA = "0x1C22A2C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1C22AAC", Offset = "0x1C22AAC", VA = "0x1C22AAC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1C22C58", Offset = "0x1C22C58", VA = "0x1C22C58", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1C22DC8", Offset = "0x1C22DC8", VA = "0x1C22DC8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1C22FD8", Offset = "0x1C22FD8", VA = "0x1C22FD8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1C230B0", Offset = "0x1C230B0", VA = "0x1C230B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1C2319C", Offset = "0x1C2319C", VA = "0x1C2319C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1C23310", Offset = "0x1C23310", VA = "0x1C23310", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1C23468", Offset = "0x1C23468", VA = "0x1C23468", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1C236B4", Offset = "0x1C236B4", VA = "0x1C236B4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1C23990", Offset = "0x1C23990", VA = "0x1C23990", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1C239D4", Offset = "0x1C239D4", VA = "0x1C239D4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1C23AC4", Offset = "0x1C23AC4", VA = "0x1C23AC4")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000319")]
		Body,
		[Token(Token = "0x400031A")]
		LeftShoulder,
		[Token(Token = "0x400031B")]
		RightShoulder,
		[Token(Token = "0x400031C")]
		LeftThigh,
		[Token(Token = "0x400031D")]
		RightThigh,
		[Token(Token = "0x400031E")]
		LeftHand,
		[Token(Token = "0x400031F")]
		RightHand,
		[Token(Token = "0x4000320")]
		LeftFoot,
		[Token(Token = "0x4000321")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000323")]
		LeftArm,
		[Token(Token = "0x4000324")]
		RightArm,
		[Token(Token = "0x4000325")]
		LeftLeg,
		[Token(Token = "0x4000326")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D1C8", Offset = "0x80D1C8")]
		public float spineStiffness;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D1E0", Offset = "0x80D1E0")]
		public float pullBodyVertical;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D1F8", Offset = "0x80D1F8")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D210", Offset = "0x80D210")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700004C")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1C23C04", Offset = "0x1C23C04", VA = "0x1C23C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x1C23D4C", Offset = "0x1C23D4C", VA = "0x1C23D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1C23D54", Offset = "0x1C23D54", VA = "0x1C23D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1C23D5C", Offset = "0x1C23D5C", VA = "0x1C23D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1C23D64", Offset = "0x1C23D64", VA = "0x1C23D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1C23D6C", Offset = "0x1C23D6C", VA = "0x1C23D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1C23D74", Offset = "0x1C23D74", VA = "0x1C23D74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1C23D7C", Offset = "0x1C23D7C", VA = "0x1C23D7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1C23D84", Offset = "0x1C23D84", VA = "0x1C23D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1C23D8C", Offset = "0x1C23D8C", VA = "0x1C23D8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1C23DC4", Offset = "0x1C23DC4", VA = "0x1C23DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1C23DFC", Offset = "0x1C23DFC", VA = "0x1C23DFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1C23E34", Offset = "0x1C23E34", VA = "0x1C23E34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1C23E6C", Offset = "0x1C23E6C", VA = "0x1C23E6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1C23EA0", Offset = "0x1C23EA0", VA = "0x1C23EA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1C23ED8", Offset = "0x1C23ED8", VA = "0x1C23ED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1C23F10", Offset = "0x1C23F10", VA = "0x1C23F10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1C23F48", Offset = "0x1C23F48", VA = "0x1C23F48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1C260D8", Offset = "0x1C260D8", VA = "0x1C260D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D68", Offset = "0x816D68")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1C260E4", Offset = "0x1C260E4", VA = "0x1C260E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D78", Offset = "0x816D78")]
			private set
			{
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1C23F7C", Offset = "0x1C23F7C", VA = "0x1C23F7C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1C24088", Offset = "0x1C24088", VA = "0x1C24088")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1C23FD0", Offset = "0x1C23FD0", VA = "0x1C23FD0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1C24114", Offset = "0x1C24114", VA = "0x1C24114")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1C23C0C", Offset = "0x1C23C0C", VA = "0x1C23C0C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1C241E4", Offset = "0x1C241E4", VA = "0x1C241E4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1C2429C", Offset = "0x1C2429C", VA = "0x1C2429C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1C24350", Offset = "0x1C24350", VA = "0x1C24350")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1C24404", Offset = "0x1C24404", VA = "0x1C24404")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1C2440C", Offset = "0x1C2440C", VA = "0x1C2440C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1C24440", Offset = "0x1C24440", VA = "0x1C24440")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1C24508", Offset = "0x1C24508", VA = "0x1C24508", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1C246B0", Offset = "0x1C246B0", VA = "0x1C246B0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1C25B54", Offset = "0x1C25B54", VA = "0x1C25B54")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1C25F68", Offset = "0x1C25F68", VA = "0x1C25F68")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1C25FC8", Offset = "0x1C25FC8", VA = "0x1C25FC8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1C25DF0", Offset = "0x1C25DF0", VA = "0x1C25DF0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1C25EAC", Offset = "0x1C25EAC", VA = "0x1C25EAC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1C260F0", Offset = "0x1C260F0", VA = "0x1C260F0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1C261C8", Offset = "0x1C261C8", VA = "0x1C261C8", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1C262C4", Offset = "0x1C262C4", VA = "0x1C262C4")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1C263EC", Offset = "0x1C263EC", VA = "0x1C263EC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1C26530", Offset = "0x1C26530", VA = "0x1C26530")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1C26660", Offset = "0x1C26660", VA = "0x1C26660", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1C268A0", Offset = "0x1C268A0", VA = "0x1C268A0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1C26924", Offset = "0x1C26924", VA = "0x1C26924")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700005F")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1C271E4", Offset = "0x1C271E4", VA = "0x1C271E4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000060")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1C271EC", Offset = "0x1C271EC", VA = "0x1C271EC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1C271F4", Offset = "0x1C271F4", VA = "0x1C271F4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1C2767C", Offset = "0x1C2767C", VA = "0x1C2767C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000063")]
		protected float positionOffset
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1C27744", Offset = "0x1C27744", VA = "0x1C27744")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1C26930", Offset = "0x1C26930", VA = "0x1C26930")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1C26AEC", Offset = "0x1C26AEC", VA = "0x1C26AEC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1C26C4C", Offset = "0x1C26C4C", VA = "0x1C26C4C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1C26CB8", Offset = "0x1C26CB8", VA = "0x1C26CB8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1C26D38", Offset = "0x1C26D38", VA = "0x1C26D38", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1C270EC", Offset = "0x1C270EC", VA = "0x1C270EC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1C270F4", Offset = "0x1C270F4", VA = "0x1C270F4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1C271FC", Offset = "0x1C271FC", VA = "0x1C271FC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1C27200", Offset = "0x1C27200", VA = "0x1C27200", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1C27204", Offset = "0x1C27204", VA = "0x1C27204")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1C27798", Offset = "0x1C27798", VA = "0x1C27798")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1C27AB0", Offset = "0x1C27AB0", VA = "0x1C27AB0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1C27CA4", Offset = "0x1C27CA4", VA = "0x1C27CA4")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D220", Offset = "0x80D220")]
		public float IKRotationWeight;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1C27D1C", Offset = "0x1C27D1C", VA = "0x1C27D1C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1C28104", Offset = "0x1C28104", VA = "0x1C28104")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1C281BC", Offset = "0x1C281BC", VA = "0x1C281BC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1C28350", Offset = "0x1C28350", VA = "0x1C28350", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1C284E4", Offset = "0x1C284E4", VA = "0x1C284E4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1C28540", Offset = "0x1C28540", VA = "0x1C28540", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1C285B0", Offset = "0x1C285B0", VA = "0x1C285B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1C28920", Offset = "0x1C28920", VA = "0x1C28920", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1C2894C", Offset = "0x1C2894C", VA = "0x1C2894C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1C28614", Offset = "0x1C28614", VA = "0x1C28614")]
		private void Read()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1C289E8", Offset = "0x1C289E8", VA = "0x1C289E8")]
		private void Write()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1C28B74", Offset = "0x1C28B74", VA = "0x1C28B74")]
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
			[Token(Token = "0x4000351")]
			Animation,
			[Token(Token = "0x4000352")]
			Target,
			[Token(Token = "0x4000353")]
			Parent,
			[Token(Token = "0x4000354")]
			Arm,
			[Token(Token = "0x4000355")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x1CEEE2C", Offset = "0x1CEEE2C", VA = "0x1CEEE2C")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D238", Offset = "0x80D238")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D250", Offset = "0x80D250")]
		public float bendModifierWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000064")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1C29EA4", Offset = "0x1C29EA4", VA = "0x1C29EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1C28D2C", Offset = "0x1C28D2C", VA = "0x1C28D2C")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1C28D7C", Offset = "0x1C28D7C", VA = "0x1C28D7C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1C28DC8", Offset = "0x1C28DC8", VA = "0x1C28DC8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1C2929C", Offset = "0x1C2929C", VA = "0x1C2929C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1C29BE4", Offset = "0x1C29BE4", VA = "0x1C29BE4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1C29C90", Offset = "0x1C29C90", VA = "0x1C29C90")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1C29E08", Offset = "0x1C29E08", VA = "0x1C29E08")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1C290C4", Offset = "0x1C290C4", VA = "0x1C290C4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1C29380", Offset = "0x1C29380", VA = "0x1C29380")]
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
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x1700006B")]
			public Vector3 forward
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0x1CEF0C0", Offset = "0x1CEF0C0", VA = "0x1CEF0C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1CEEE8C", Offset = "0x1CEEE8C", VA = "0x1CEEE8C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1CEEE90", Offset = "0x1CEEE90", VA = "0x1CEEE90")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x1CEEEC0", Offset = "0x1CEEEC0", VA = "0x1CEEEC0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1CEEFB8", Offset = "0x1CEEFB8", VA = "0x1CEEFB8")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D268", Offset = "0x80D268")]
		public float bodyWeight;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D280", Offset = "0x80D280")]
		public float headWeight;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D298", Offset = "0x80D298")]
		public float eyesWeight;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D2B0", Offset = "0x80D2B0")]
		public float clampWeight;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D2C8", Offset = "0x80D2C8")]
		public float clampWeightHead;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D2E0", Offset = "0x80D2E0")]
		public float clampWeightEyes;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D2F8", Offset = "0x80D2F8")]
		public int clampSmoothing;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000065")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1C2A660", Offset = "0x1C2A660", VA = "0x1C2A660")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1C2A830", Offset = "0x1C2A830", VA = "0x1C2A830")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1C2A740", Offset = "0x1C2A740", VA = "0x1C2A740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1C2A854", Offset = "0x1C2A854", VA = "0x1C2A854")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1C2A750", Offset = "0x1C2A750", VA = "0x1C2A750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1C2A8CC", Offset = "0x1C2A8CC", VA = "0x1C2A8CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1C29EC0", Offset = "0x1C29EC0", VA = "0x1C29EC0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1C29EF0", Offset = "0x1C29EF0", VA = "0x1C29EF0")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1C29F48", Offset = "0x1C29F48", VA = "0x1C29F48")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1C29FC4", Offset = "0x1C29FC4", VA = "0x1C29FC4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1C2A05C", Offset = "0x1C2A05C", VA = "0x1C2A05C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1C2A11C", Offset = "0x1C2A11C", VA = "0x1C2A11C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1C2A218", Offset = "0x1C2A218", VA = "0x1C2A218", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1C2A344", Offset = "0x1C2A344", VA = "0x1C2A344")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1C2A350", Offset = "0x1C2A350", VA = "0x1C2A350", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1C2A494", Offset = "0x1C2A494", VA = "0x1C2A494", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1C2A8F0", Offset = "0x1C2A8F0", VA = "0x1C2A8F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1C2AB60", Offset = "0x1C2AB60", VA = "0x1C2AB60", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1C2ACFC", Offset = "0x1C2ACFC", VA = "0x1C2ACFC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1C2AF60", Offset = "0x1C2AF60", VA = "0x1C2AF60", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1C2B274", Offset = "0x1C2B274", VA = "0x1C2B274", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1C2B344", Offset = "0x1C2B344", VA = "0x1C2B344")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1C2B4E4", Offset = "0x1C2B4E4", VA = "0x1C2B4E4")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1C2B708", Offset = "0x1C2B708", VA = "0x1C2B708")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1C2BABC", Offset = "0x1C2BABC", VA = "0x1C2BABC")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1C2ADB4", Offset = "0x1C2ADB4", VA = "0x1C2ADB4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1C2BD2C", Offset = "0x1C2BD2C", VA = "0x1C2BD2C")]
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
			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1CEF0FC", Offset = "0x1CEF0FC", VA = "0x1CEF0FC")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1CEF1F8", Offset = "0x1CEF1F8", VA = "0x1CEF1F8")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1CEF228", Offset = "0x1CEF228", VA = "0x1CEF228")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1CEF264", Offset = "0x1CEF264", VA = "0x1CEF264")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D310", Offset = "0x80D310")]
		public float IKRotationWeight;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1C2BF90", Offset = "0x1C2BF90", VA = "0x1C2BF90")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1C2C0EC", Offset = "0x1C2C0EC", VA = "0x1C2C0EC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1C2C230", Offset = "0x1C2C230", VA = "0x1C2C230")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1C2C23C", Offset = "0x1C2C23C", VA = "0x1C2C23C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1C2C26C", Offset = "0x1C2C26C", VA = "0x1C2C26C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1C2C278", Offset = "0x1C2C278", VA = "0x1C2C278")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1C2C280", Offset = "0x1C2C280", VA = "0x1C2C280", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1C2C3A4", Offset = "0x1C2C3A4", VA = "0x1C2C3A4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1C2C4C0", Offset = "0x1C2C4C0", VA = "0x1C2C4C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1C2C50C", Offset = "0x1C2C50C", VA = "0x1C2C50C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1C2C56C", Offset = "0x1C2C56C", VA = "0x1C2C56C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1C2C964", Offset = "0x1C2C964", VA = "0x1C2C964")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1C2C9E4", Offset = "0x1C2C9E4", VA = "0x1C2C9E4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1C2CDA0", Offset = "0x1C2CDA0", VA = "0x1C2CDA0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1C2CF08", Offset = "0x1C2CF08", VA = "0x1C2CF08", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1C2D070", Offset = "0x1C2D070", VA = "0x1C2D070")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1C2CFE4", Offset = "0x1C2CFE4", VA = "0x1C2CFE4")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1C2D174", Offset = "0x1C2D174", VA = "0x1C2D174", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1C2D948", Offset = "0x1C2D948", VA = "0x1C2D948", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1C2D94C", Offset = "0x1C2D94C", VA = "0x1C2D94C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1C2D950", Offset = "0x1C2D950", VA = "0x1C2D950", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1C2D760", Offset = "0x1C2D760", VA = "0x1C2D760")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1C29D18", Offset = "0x1C29D18", VA = "0x1C29D18")]
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
				[Token(Token = "0x40003BC")]
				YawPitch,
				[Token(Token = "0x40003BD")]
				FromTo
			}

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80D55C", Offset = "0x80D55C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D55C", Offset = "0x80D55C")]
			public Transform target;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D5BC", Offset = "0x80D5BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D5BC", Offset = "0x80D5BC")]
			public float positionWeight;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D610", Offset = "0x80D610")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D610", Offset = "0x80D610")]
			public float rotationWeight;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80D664", Offset = "0x80D664")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D664", Offset = "0x80D664")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D664", Offset = "0x80D664")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80D6DC", Offset = "0x80D6DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D6DC", Offset = "0x80D6DC")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80D7B8", Offset = "0x80D7B8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D7B8", Offset = "0x80D7B8")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D89C", Offset = "0x80D89C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80D89C", Offset = "0x80D89C")]
			public float shoulderYawOffset;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80D970", Offset = "0x80D970")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D970", Offset = "0x80D970")]
			public float shoulderPitchOffset;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DA4C", Offset = "0x80DA4C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80DA4C", Offset = "0x80DA4C")]
			public Transform bendGoal;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DAAC", Offset = "0x80DAAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DAAC", Offset = "0x80DAAC")]
			public float bendGoalWeight;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DB00", Offset = "0x80DB00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DB00", Offset = "0x80DB00")]
			public float swivelOffset;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DB5C", Offset = "0x80DB5C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DB94", Offset = "0x80DB94")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80DBCC", Offset = "0x80DBCC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DBCC", Offset = "0x80DBCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DBCC", Offset = "0x80DBCC")]
			public float armLengthMlp;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DC48", Offset = "0x80DC48")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80DCC0", Offset = "0x80DCC0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80DCD0", Offset = "0x80DCD0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool hasShoulder;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion chestRotation;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 chestForward;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Vector3 chestUp;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x1700006E")]
			public Vector3 position
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x1CEF268", Offset = "0x1CEF268", VA = "0x1CEF268")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816DC8", Offset = "0x816DC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x1CEF274", Offset = "0x1CEF274", VA = "0x1CEF274")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816DD8", Offset = "0x816DD8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x1CEF280", Offset = "0x1CEF280", VA = "0x1CEF280")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816DE8", Offset = "0x816DE8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x1CEF28C", Offset = "0x1CEF28C", VA = "0x1CEF28C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816DF8", Offset = "0x816DF8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x1CEF298", Offset = "0x1CEF298", VA = "0x1CEF298")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x1CEF2CC", Offset = "0x1CEF2CC", VA = "0x1CEF2CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x1CEF30C", Offset = "0x1CEF30C", VA = "0x1CEF30C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x1CEF358", Offset = "0x1CEF358", VA = "0x1CEF358")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1CEF3A4", Offset = "0x1CEF3A4", VA = "0x1CEF3A4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x1CEFD3C", Offset = "0x1CEFD3C", VA = "0x1CEFD3C", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1CEFEF8", Offset = "0x1CEFEF8", VA = "0x1CEFEF8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1CEFF1C", Offset = "0x1CEFF1C", VA = "0x1CEFF1C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x1CF01BC", Offset = "0x1CF01BC", VA = "0x1CF01BC")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1CF1C60", Offset = "0x1CF1C60", VA = "0x1CF1C60", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1CF1C8C", Offset = "0x1CF1C8C", VA = "0x1CF1C8C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x1CF1160", Offset = "0x1CF1160", VA = "0x1CF1160")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x1CF1318", Offset = "0x1CF1318", VA = "0x1CF1318")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x1CF1EAC", Offset = "0x1CF1EAC", VA = "0x1CF1EAC")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x1CF1FD0", Offset = "0x1CF1FD0", VA = "0x1CF1FD0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80DCE0", Offset = "0x80DCE0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80DCF0", Offset = "0x80DCF0")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000074")]
			public float sqrMag
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x1CF2154", Offset = "0x1CF2154", VA = "0x1CF2154")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E08", Offset = "0x816E08")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x1CF215C", Offset = "0x1CF215C", VA = "0x1CF215C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E18", Offset = "0x816E18")]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public float mag
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x1CF2164", Offset = "0x1CF2164", VA = "0x1CF2164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E28", Offset = "0x816E28")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x1CF216C", Offset = "0x1CF216C", VA = "0x1CF216C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E38", Offset = "0x816E38")]
				private set
				{
				}
			}

			[Token(Token = "0x6000472")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000473")]
			public abstract void PreSolve(float scale);

			[Token(Token = "0x6000474")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000475")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000476")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x1CF2174", Offset = "0x1CF2174", VA = "0x1CF2174")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1CF217C", Offset = "0x1CF217C", VA = "0x1CF217C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1CF243C", Offset = "0x1CF243C", VA = "0x1CF243C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1CF24D0", Offset = "0x1CF24D0", VA = "0x1CF24D0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1CF26A0", Offset = "0x1CF26A0", VA = "0x1CF26A0")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x1CF26F4", Offset = "0x1CF26F4", VA = "0x1CF26F4")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x1CF1B20", Offset = "0x1CF1B20", VA = "0x1CF1B20")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1CF282C", Offset = "0x1CF282C", VA = "0x1CF282C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x1CF296C", Offset = "0x1CF296C", VA = "0x1CF296C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1CF20D4", Offset = "0x1CF20D4", VA = "0x1CF20D4")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class Footstep
		{
			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80DD10", Offset = "0x80DD10")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000076")]
			public bool isStepping
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x1CF2994", Offset = "0x1CF2994", VA = "0x1CF2994")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000077")]
			public float stepProgress
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x1CF29A8", Offset = "0x1CF29A8", VA = "0x1CF29A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E48", Offset = "0x816E48")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x1CF29B0", Offset = "0x1CF29B0", VA = "0x1CF29B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E58", Offset = "0x816E58")]
				private set
				{
				}
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x1CF29B8", Offset = "0x1CF29B8", VA = "0x1CF29B8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1CF2AF0", Offset = "0x1CF2AF0", VA = "0x1CF2AF0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1CF2B38", Offset = "0x1CF2B38", VA = "0x1CF2B38")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1CF2D04", Offset = "0x1CF2D04", VA = "0x1CF2D04")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1CF2E4C", Offset = "0x1CF2E4C", VA = "0x1CF2E4C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1CF2FA0", Offset = "0x1CF2FA0", VA = "0x1CF2FA0")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep, float deltaTime)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80DD20", Offset = "0x80DD20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DD20", Offset = "0x80DD20")]
			public Transform target;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DD80", Offset = "0x80DD80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DD80", Offset = "0x80DD80")]
			public float positionWeight;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DDD4", Offset = "0x80DDD4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DDD4", Offset = "0x80DDD4")]
			public float rotationWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80DE28", Offset = "0x80DE28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DE28", Offset = "0x80DE28")]
			public Transform bendGoal;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DE88", Offset = "0x80DE88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DE88", Offset = "0x80DE88")]
			public float bendGoalWeight;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DEDC", Offset = "0x80DEDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DEDC", Offset = "0x80DEDC")]
			public float swivelOffset;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DF38", Offset = "0x80DF38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DF38", Offset = "0x80DF38")]
			public float bendToTargetWeight;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80DF8C", Offset = "0x80DF8C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80DF8C", Offset = "0x80DF8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80DF8C", Offset = "0x80DF8C")]
			public float legLengthMlp;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E008", Offset = "0x80E008")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E0B0", Offset = "0x80E0B0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E0C0", Offset = "0x80E0C0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E0D0", Offset = "0x80E0D0")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E0E0", Offset = "0x80E0E0")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E0F0", Offset = "0x80E0F0")]
			private Vector3 <bendNormalRelToPelvis>k__BackingField;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E100", Offset = "0x80E100")]
			private Vector3 <bendNormalRelToTarget>k__BackingField;

			[Token(Token = "0x17000078")]
			public Vector3 position
			{
				[Token(Token = "0x600048E")]
				[Address(RVA = "0x1CF30D8", Offset = "0x1CF30D8", VA = "0x1CF30D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E68", Offset = "0x816E68")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600048F")]
				[Address(RVA = "0x1CF30E4", Offset = "0x1CF30E4", VA = "0x1CF30E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E78", Offset = "0x816E78")]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000490")]
				[Address(RVA = "0x1CF30F0", Offset = "0x1CF30F0", VA = "0x1CF30F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E88", Offset = "0x816E88")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000491")]
				[Address(RVA = "0x1CF30FC", Offset = "0x1CF30FC", VA = "0x1CF30FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816E98", Offset = "0x816E98")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public bool hasToes
			{
				[Token(Token = "0x6000492")]
				[Address(RVA = "0x1CF3108", Offset = "0x1CF3108", VA = "0x1CF3108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816EA8", Offset = "0x816EA8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000493")]
				[Address(RVA = "0x1CF3110", Offset = "0x1CF3110", VA = "0x1CF3110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816EB8", Offset = "0x816EB8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000494")]
				[Address(RVA = "0x1CF311C", Offset = "0x1CF311C", VA = "0x1CF311C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000495")]
				[Address(RVA = "0x1CF3150", Offset = "0x1CF3150", VA = "0x1CF3150")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0x1CF3188", Offset = "0x1CF3188", VA = "0x1CF3188")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000497")]
				[Address(RVA = "0x1CF31C0", Offset = "0x1CF31C0", VA = "0x1CF31C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0x1CF31F8", Offset = "0x1CF31F8", VA = "0x1CF31F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000499")]
				[Address(RVA = "0x1CF3238", Offset = "0x1CF3238", VA = "0x1CF3238")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816EC8", Offset = "0x816EC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049A")]
				[Address(RVA = "0x1CF3244", Offset = "0x1CF3244", VA = "0x1CF3244")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816ED8", Offset = "0x816ED8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x600049B")]
				[Address(RVA = "0x1CF3250", Offset = "0x1CF3250", VA = "0x1CF3250")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816EE8", Offset = "0x816EE8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049C")]
				[Address(RVA = "0x1CF3260", Offset = "0x1CF3260", VA = "0x1CF3260")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816EF8", Offset = "0x816EF8")]
				set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x600049D")]
				[Address(RVA = "0x1CF3270", Offset = "0x1CF3270", VA = "0x1CF3270")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F08", Offset = "0x816F08")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049E")]
				[Address(RVA = "0x1CF3280", Offset = "0x1CF3280", VA = "0x1CF3280")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F18", Offset = "0x816F18")]
				set
				{
				}
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1CF3290", Offset = "0x1CF3290", VA = "0x1CF3290", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1CF38B0", Offset = "0x1CF38B0", VA = "0x1CF38B0", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1CF3E84", Offset = "0x1CF3E84", VA = "0x1CF3E84", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1CF3E34", Offset = "0x1CF3E34", VA = "0x1CF3E34")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1CF3CC4", Offset = "0x1CF3CC4", VA = "0x1CF3CC4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1CF426C", Offset = "0x1CF426C", VA = "0x1CF426C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x1CF46E0", Offset = "0x1CF46E0", VA = "0x1CF46E0")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x1CF4408", Offset = "0x1CF4408", VA = "0x1CF4408")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1CF49D8", Offset = "0x1CF49D8", VA = "0x1CF49D8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1CF4BF4", Offset = "0x1CF4BF4", VA = "0x1CF4BF4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1CF4C40", Offset = "0x1CF4C40", VA = "0x1CF4C40")]
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
				[Token(Token = "0x4000436")]
				Procedural,
				[Token(Token = "0x4000437")]
				Animated
			}

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E110", Offset = "0x80E110")]
			public Mode mode;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80E148", Offset = "0x80E148")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E148", Offset = "0x80E148")]
			public float weight;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E19C", Offset = "0x80E19C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80E19C", Offset = "0x80E19C")]
			public float moveThreshold;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x80E25C", Offset = "0x80E25C")]
			[SerializeField]
			private byte animationHeader;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E324", Offset = "0x80E324")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80E324", Offset = "0x80E324")]
			public float minAnimationSpeed;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E3F0", Offset = "0x80E3F0")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80E3F0", Offset = "0x80E3F0")]
			public float maxAnimationSpeed;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E4B8", Offset = "0x80E4B8")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80E4B8", Offset = "0x80E4B8")]
			public float animationSmoothTime;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x80E588", Offset = "0x80E588")]
			[SerializeField]
			private byte rootPositionHeader;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80E650", Offset = "0x80E650")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E650", Offset = "0x80E650")]
			public Vector2 standOffset;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80E710", Offset = "0x80E710")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E710", Offset = "0x80E710")]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80E7DC", Offset = "0x80E7DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E7DC", Offset = "0x80E7DC")]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80E8A8", Offset = "0x80E8A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E8A8", Offset = "0x80E8A8")]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80E974", Offset = "0x80E974")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80E974", Offset = "0x80E974")]
			public float maxRootOffset;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x80EA34", Offset = "0x80EA34")]
			[SerializeField]
			private byte rootRotationHeader;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80EAFC", Offset = "0x80EAFC")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80EAFC", Offset = "0x80EAFC")]
			public float maxRootAngleMoving;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80EBC8", Offset = "0x80EBC8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80EBC8", Offset = "0x80EBC8")]
			public float maxRootAngleStanding;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[HideInInspector]
			[SerializeField]
			public float stepLengthMlp;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Animator animator;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 velocityLocal;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private Vector3 velocityLocalV;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastCorrection;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 lastHeadTargetPos;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Vector3 lastSpeedRootPos;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Vector3 lastEndRootPos;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float rootLerpSpeed;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float rootVelocityV;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private float animSpeed;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private float animSpeedV;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float stopMoveTimer;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float turn;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private float maxRootAngleV;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private float currentAnimationSmoothTime;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool isMoving;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool firstFrame;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int VRIK_Horizontal;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static int VRIK_Vertical;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int VRIK_IsMoving;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static int VRIK_Speed;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static int VRIK_Turn;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private static bool isHashed;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float lastVelLocalMag;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80ECCC", Offset = "0x80ECCC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80ECCC", Offset = "0x80ECCC")]
			public float footDistance;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80ED88", Offset = "0x80ED88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80ED88", Offset = "0x80ED88")]
			public float stepThreshold;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80EE44", Offset = "0x80EE44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80EE44", Offset = "0x80EE44")]
			public float angleThreshold;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80EF00", Offset = "0x80EF00")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80EF00", Offset = "0x80EF00")]
			public float comAngleMlp;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80EFBC", Offset = "0x80EFBC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80EFBC", Offset = "0x80EFBC")]
			public float maxVelocity;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F078", Offset = "0x80F078")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F078", Offset = "0x80F078")]
			public float velocityFactor;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F134", Offset = "0x80F134")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80F134", Offset = "0x80F134")]
			public float maxLegStretch;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F1FC", Offset = "0x80F1FC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F1FC", Offset = "0x80F1FC")]
			public float rootSpeed;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F2B8", Offset = "0x80F2B8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F2B8", Offset = "0x80F2B8")]
			public float stepSpeed;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F374", Offset = "0x80F374")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F374", Offset = "0x80F374")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F430", Offset = "0x80F430")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F430", Offset = "0x80F430")]
			public float maxBodyYOffset;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F4EC", Offset = "0x80F4EC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F4EC", Offset = "0x80F4EC")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x80F5A8", Offset = "0x80F5A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F5A8", Offset = "0x80F5A8")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F670", Offset = "0x80F670")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F670", Offset = "0x80F670")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F72C", Offset = "0x80F72C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F72C", Offset = "0x80F72C")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F7E8", Offset = "0x80F7E8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80F7E8", Offset = "0x80F7E8")]
			public Vector3 offset;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F954", Offset = "0x80F954")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private int leftFootIndex;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private int rightFootIndex;

			[Token(Token = "0x17000083")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0x1CF65F8", Offset = "0x1CF65F8", VA = "0x1CF65F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F28", Offset = "0x816F28")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004B6")]
				[Address(RVA = "0x1CF6608", Offset = "0x1CF6608", VA = "0x1CF6608")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F38", Offset = "0x816F38")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60004BD")]
				[Address(RVA = "0x1CF7A34", Offset = "0x1CF7A34", VA = "0x1CF7A34")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000085")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60004BE")]
				[Address(RVA = "0x1CF7A74", Offset = "0x1CF7A74", VA = "0x1CF7A74")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000086")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0x1CF7AB8", Offset = "0x1CF7AB8", VA = "0x1CF7AB8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000087")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0x1CF7AF8", Offset = "0x1CF7AF8", VA = "0x1CF7AF8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1CF4D1C", Offset = "0x1CF4D1C", VA = "0x1CF4D1C")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1CF5138", Offset = "0x1CF5138", VA = "0x1CF5138")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1CF5588", Offset = "0x1CF5588", VA = "0x1CF5588")]
			public void Relax()
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1CF55F0", Offset = "0x1CF55F0", VA = "0x1CF55F0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1CF59D0", Offset = "0x1CF59D0", VA = "0x1CF59D0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1CF5048", Offset = "0x1CF5048", VA = "0x1CF5048")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1CF5B30", Offset = "0x1CF5B30", VA = "0x1CF5B30")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1CF533C", Offset = "0x1CF533C", VA = "0x1CF533C")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1CF58BC", Offset = "0x1CF58BC", VA = "0x1CF58BC")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1CF5AE0", Offset = "0x1CF5AE0", VA = "0x1CF5AE0")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1CF5BC0", Offset = "0x1CF5BC0", VA = "0x1CF5BC0")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1CF4D68", Offset = "0x1CF4D68", VA = "0x1CF4D68")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x1CF5164", Offset = "0x1CF5164", VA = "0x1CF5164")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1CF558C", Offset = "0x1CF558C", VA = "0x1CF558C")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1CF566C", Offset = "0x1CF566C", VA = "0x1CF566C")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x1CF5A1C", Offset = "0x1CF5A1C", VA = "0x1CF5A1C")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1CF6618", Offset = "0x1CF6618", VA = "0x1CF6618")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x1CF77A8", Offset = "0x1CF77A8", VA = "0x1CF77A8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x1CF78E4", Offset = "0x1CF78E4", VA = "0x1CF78E4")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x1CF7968", Offset = "0x1CF7968", VA = "0x1CF7968")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x1CF7B3C", Offset = "0x1CF7B3C", VA = "0x1CF7B3C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F964", Offset = "0x80F964")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80F964", Offset = "0x80F964")]
			public Transform headTarget;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80F9C4", Offset = "0x80F9C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80F9C4", Offset = "0x80F9C4")]
			public float positionWeight;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FA18", Offset = "0x80FA18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FA18", Offset = "0x80FA18")]
			public float rotationWeight;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FA6C", Offset = "0x80FA6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FA6C", Offset = "0x80FA6C")]
			public float headClampWeight;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FAC0", Offset = "0x80FAC0")]
			public float minHeadHeight;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FAF8", Offset = "0x80FAF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FAF8", Offset = "0x80FAF8")]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FB4C", Offset = "0x80FB4C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80FB4C", Offset = "0x80FB4C")]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FC20", Offset = "0x80FC20")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x80FC20", Offset = "0x80FC20")]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80FCF4", Offset = "0x80FCF4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FCF4", Offset = "0x80FCF4")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FD54", Offset = "0x80FD54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FD54", Offset = "0x80FD54")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FDA8", Offset = "0x80FDA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FDA8", Offset = "0x80FDA8")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FDFC", Offset = "0x80FDFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FDFC", Offset = "0x80FDFC")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80FE50", Offset = "0x80FE50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FE50", Offset = "0x80FE50")]
			public Transform chestGoal;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FEB0", Offset = "0x80FEB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FEB0", Offset = "0x80FEB0")]
			public float chestGoalWeight;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FF04", Offset = "0x80FF04")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FF04", Offset = "0x80FF04")]
			public float chestClampWeight;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FF58", Offset = "0x80FF58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FF58", Offset = "0x80FF58")]
			public float rotateChestByHands;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80FFAC", Offset = "0x80FFAC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x80FFAC", Offset = "0x80FFAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80FFAC", Offset = "0x80FFAC")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810024", Offset = "0x810024")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x810024", Offset = "0x810024")]
			public float bodyRotStiffness;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x810078", Offset = "0x810078")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x810078", Offset = "0x810078")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810078", Offset = "0x810078")]
			public float neckStiffness;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8100F0", Offset = "0x8100F0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x810128", Offset = "0x810128")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810128", Offset = "0x810128")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x810128", Offset = "0x810128")]
			public float maxRootAngle;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8101A4", Offset = "0x8101A4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8101A4", Offset = "0x8101A4")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[HideInInspector]
			internal Vector3 headPosition;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8102D0", Offset = "0x8102D0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8102E0", Offset = "0x8102E0")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			private Quaternion headRotation;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int pelvisIndex;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int spineIndex;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int chestIndex;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private int neckIndex;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private int headIndex;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float length;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private bool hasChest;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
			private bool hasNeck;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21A")]
			private bool hasLegs;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private float headHeight;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private float sizeMlp;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
			private Vector3 chestForward;

			[Token(Token = "0x17000088")]
			internal VirtualBone pelvis
			{
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0x1CF7728", Offset = "0x1CF7728", VA = "0x1CF7728")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x60004C6")]
				[Address(RVA = "0x1CF7CB0", Offset = "0x1CF7CB0", VA = "0x1CF7CB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			internal VirtualBone chest
			{
				[Token(Token = "0x60004C7")]
				[Address(RVA = "0x1CF7CF0", Offset = "0x1CF7CF0", VA = "0x1CF7CF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			internal VirtualBone head
			{
				[Token(Token = "0x60004C8")]
				[Address(RVA = "0x1CF7768", Offset = "0x1CF7768", VA = "0x1CF7768")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private VirtualBone neck
			{
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0x1CF7D44", Offset = "0x1CF7D44", VA = "0x1CF7D44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0x1CF7D84", Offset = "0x1CF7D84", VA = "0x1CF7D84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F48", Offset = "0x816F48")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004CB")]
				[Address(RVA = "0x1CF7D98", Offset = "0x1CF7D98", VA = "0x1CF7D98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F58", Offset = "0x816F58")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0x1CF7DAC", Offset = "0x1CF7DAC", VA = "0x1CF7DAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F68", Offset = "0x816F68")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004CD")]
				[Address(RVA = "0x1CF7DC0", Offset = "0x1CF7DC0", VA = "0x1CF7DC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F78", Offset = "0x816F78")]
				private set
				{
				}
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x1CF7DD4", Offset = "0x1CF7DD4", VA = "0x1CF7DD4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x1CF8820", Offset = "0x1CF8820", VA = "0x1CF8820", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1CF8BF4", Offset = "0x1CF8BF4", VA = "0x1CF8BF4", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1CF9040", Offset = "0x1CF9040", VA = "0x1CF9040")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1CF949C", Offset = "0x1CF949C", VA = "0x1CF949C")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x1CF9CFC", Offset = "0x1CF9CFC", VA = "0x1CF9CFC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1CFA380", Offset = "0x1CFA380", VA = "0x1CFA380")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1CFA904", Offset = "0x1CFA904", VA = "0x1CFA904", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1CFAAE0", Offset = "0x1CFAAE0", VA = "0x1CFAAE0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x1CF91F8", Offset = "0x1CF91F8", VA = "0x1CF91F8")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x1CFA0D0", Offset = "0x1CFA0D0", VA = "0x1CFA0D0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x1CF99A4", Offset = "0x1CF99A4", VA = "0x1CF99A4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1CFAB7C", Offset = "0x1CFAB7C", VA = "0x1CFAB7C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1CFA1AC", Offset = "0x1CFA1AC", VA = "0x1CFA1AC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1CF9E7C", Offset = "0x1CF9E7C", VA = "0x1CF9E7C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1CFAD7C", Offset = "0x1CFAD7C", VA = "0x1CFAD7C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000472")]
			Pelvis,
			[Token(Token = "0x4000473")]
			Chest,
			[Token(Token = "0x4000474")]
			Head,
			[Token(Token = "0x4000475")]
			LeftHand,
			[Token(Token = "0x4000476")]
			RightHand,
			[Token(Token = "0x4000477")]
			LeftFoot,
			[Token(Token = "0x4000478")]
			RightFoot,
			[Token(Token = "0x4000479")]
			LeftHeel,
			[Token(Token = "0x400047A")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public enum RotationOffset
		{
			[Token(Token = "0x400047C")]
			Pelvis,
			[Token(Token = "0x400047D")]
			Chest,
			[Token(Token = "0x400047E")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		public class VirtualBone
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1CEFCA0", Offset = "0x1CEFCA0", VA = "0x1CEFCA0")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1CEFD1C", Offset = "0x1CEFD1C", VA = "0x1CEFD1C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1CFAF10", Offset = "0x1CFAF10", VA = "0x1CFAF10")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1CF224C", Offset = "0x1CF224C", VA = "0x1CF224C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1CF2578", Offset = "0x1CF2578", VA = "0x1CF2578")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1CFB094", Offset = "0x1CFB094", VA = "0x1CFB094")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1CF11DC", Offset = "0x1CF11DC", VA = "0x1CF11DC")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1CFB1F4", Offset = "0x1CFB1F4", VA = "0x1CFB1F4")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1CF171C", Offset = "0x1CF171C", VA = "0x1CF171C")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1CFB2AC", Offset = "0x1CFB2AC", VA = "0x1CFB2AC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1CFA574", Offset = "0x1CFA574", VA = "0x1CFA574")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1CFB414", Offset = "0x1CFB414", VA = "0x1CFB414")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1CFB484", Offset = "0x1CFB484", VA = "0x1CFB484")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D328", Offset = "0x80D328")]
		private Animator <animator>k__BackingField;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool hasChest;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool hasNeck;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool hasShoulders;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool hasToes;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool hasLegs;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool hasArms;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] readPositions;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastLOD;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float lastLocomotionWeight;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D338", Offset = "0x80D338")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80D338", Offset = "0x80D338")]
		public int LOD;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D38C", Offset = "0x80D38C")]
		public float scale;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D3C4", Offset = "0x80D3C4")]
		public bool plantFeet;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D3FC", Offset = "0x80D3FC")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D40C", Offset = "0x80D40C")]
		public Spine spine;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D444", Offset = "0x80D444")]
		public Arm leftArm;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D47C", Offset = "0x80D47C")]
		public Arm rightArm;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D4B4", Offset = "0x80D4B4")]
		public Leg leftLeg;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D4EC", Offset = "0x80D4EC")]
		public Leg rightLeg;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x80D524", Offset = "0x80D524")]
		public Locomotion locomotion;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Leg[] legs;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Arm[] arms;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 headPosition;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos1;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos2;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 debugPos3;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700006C")]
		public Animator animator
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1C2D954", Offset = "0x1C2D954", VA = "0x1C2D954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D88", Offset = "0x816D88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1C2D95C", Offset = "0x1C2D95C", VA = "0x1C2D95C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D98", Offset = "0x816D98")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1C313A4", Offset = "0x1C313A4", VA = "0x1C313A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816DA8", Offset = "0x816DA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x1C313AC", Offset = "0x1C313AC", VA = "0x1C313AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816DB8", Offset = "0x816DB8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1C2D964", Offset = "0x1C2D964", VA = "0x1C2D964")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1C2DE84", Offset = "0x1C2DE84", VA = "0x1C2DE84")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1C2DD10", Offset = "0x1C2DD10", VA = "0x1C2DD10")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1C2E1E8", Offset = "0x1C2E1E8", VA = "0x1C2E1E8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1C2E330", Offset = "0x1C2E330", VA = "0x1C2E330")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1C2E360", Offset = "0x1C2E360", VA = "0x1C2E360")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1C2E410", Offset = "0x1C2E410", VA = "0x1C2E410")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1C2E4F8", Offset = "0x1C2E4F8", VA = "0x1C2E4F8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1C2ECD8", Offset = "0x1C2ECD8", VA = "0x1C2ECD8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1C2EE48", Offset = "0x1C2EE48", VA = "0x1C2EE48", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1C2F04C", Offset = "0x1C2F04C", VA = "0x1C2F04C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1C2F0C8", Offset = "0x1C2F0C8", VA = "0x1C2F0C8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1C2F144", Offset = "0x1C2F144", VA = "0x1C2F144", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1C2F328", Offset = "0x1C2F328", VA = "0x1C2F328")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1C2E0C8", Offset = "0x1C2E0C8", VA = "0x1C2E0C8")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1C2E5F4", Offset = "0x1C2E5F4", VA = "0x1C2E5F4")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1C2F4E8", Offset = "0x1C2F4E8", VA = "0x1C2F4E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1C2F538", Offset = "0x1C2F538", VA = "0x1C2F538", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1C30AC0", Offset = "0x1C30AC0", VA = "0x1C30AC0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1C2E758", Offset = "0x1C2E758", VA = "0x1C2E758")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1C2F8BC", Offset = "0x1C2F8BC", VA = "0x1C2F8BC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1C30E70", Offset = "0x1C30E70", VA = "0x1C30E70")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1C30EB8", Offset = "0x1C30EB8", VA = "0x1C30EB8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1C30968", Offset = "0x1C30968", VA = "0x1C30968")]
		private void Write()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1C30EFC", Offset = "0x1C30EFC", VA = "0x1C30EFC")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1C313B4", Offset = "0x1C313B4", VA = "0x1C313B4")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8102F0", Offset = "0x8102F0")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x151F684", Offset = "0x151F684", VA = "0x151F684")]
		public void Start()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x151FE28", Offset = "0x151FE28", VA = "0x151FE28")]
		private void Update()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x151FFBC", Offset = "0x151FFBC", VA = "0x151FFBC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x152044C", Offset = "0x152044C", VA = "0x152044C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1520510", Offset = "0x1520510", VA = "0x1520510")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x152064C", Offset = "0x152064C", VA = "0x152064C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class TwistSolver
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810328", Offset = "0x810328")]
		public Transform transform;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810360", Offset = "0x810360")]
		public Transform parent;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810398", Offset = "0x810398")]
		public Transform[] children;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8103D0", Offset = "0x8103D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8103D0", Offset = "0x8103D0")]
		public float weight;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810424", Offset = "0x810424")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x810424", Offset = "0x810424")]
		public float parentChildCrossfade;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x810478", Offset = "0x810478")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810478", Offset = "0x810478")]
		public float twistAngleOffset;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultChildLocalRotations;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x15206B4", Offset = "0x15206B4", VA = "0x15206B4")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x151F884", Offset = "0x151F884", VA = "0x151F884")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x151FEFC", Offset = "0x151FEFC", VA = "0x151FEFC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1520080", Offset = "0x1520080", VA = "0x1520080")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104D4", Offset = "0x8104D4")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104E4", Offset = "0x8104E4")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104F4", Offset = "0x8104F4")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x1700008F")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1B00F18", Offset = "0x1B00F18", VA = "0x1B00F18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F88", Offset = "0x816F88")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1B00F20", Offset = "0x1B00F20", VA = "0x1B00F20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816F98", Offset = "0x816F98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool isPaused
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1B00F28", Offset = "0x1B00F28", VA = "0x1B00F28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816FA8", Offset = "0x816FA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1B00F30", Offset = "0x1B00F30", VA = "0x1B00F30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816FB8", Offset = "0x816FB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1B00F3C", Offset = "0x1B00F3C", VA = "0x1B00F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816FC8", Offset = "0x816FC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1B00F44", Offset = "0x1B00F44", VA = "0x1B00F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816FD8", Offset = "0x816FD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool inInteraction
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1B00F4C", Offset = "0x1B00F4C", VA = "0x1B00F4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public float progress
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1B03648", Offset = "0x1B03648", VA = "0x1B03648")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1B00FB8", Offset = "0x1B00FB8", VA = "0x1B00FB8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1B01050", Offset = "0x1B01050", VA = "0x1B01050")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1B01110", Offset = "0x1B01110", VA = "0x1B01110")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1B01288", Offset = "0x1B01288", VA = "0x1B01288")]
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1B015E4", Offset = "0x1B015E4", VA = "0x1B015E4")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1B016A0", Offset = "0x1B016A0", VA = "0x1B016A0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1B016F8", Offset = "0x1B016F8", VA = "0x1B016F8")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1B0196C", Offset = "0x1B0196C", VA = "0x1B0196C")]
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1B02370", Offset = "0x1B02370", VA = "0x1B02370")]
		public void Update(Transform root, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1B02E40", Offset = "0x1B02E40", VA = "0x1B02E40")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1B03084", Offset = "0x1B03084", VA = "0x1B03084")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1B03524", Offset = "0x1B03524", VA = "0x1B03524")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1B037A8", Offset = "0x1B037A8", VA = "0x1B037A8")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810504", Offset = "0x810504")]
		public LookAtIK ik;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81053C", Offset = "0x81053C")]
		public float lerpSpeed;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810574", Offset = "0x810574")]
		public float weightSpeed;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1B039CC", Offset = "0x1B039CC", VA = "0x1B039CC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1B03AF4", Offset = "0x1B03AF4", VA = "0x1B03AF4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1B03B98", Offset = "0x1B03B98", VA = "0x1B03B98")]
		public void Update()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1B041E0", Offset = "0x1B041E0", VA = "0x1B041E0")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1B042D4", Offset = "0x1B042D4", VA = "0x1B042D4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1B0439C", Offset = "0x1B0439C", VA = "0x1B0439C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809984", Offset = "0x809984")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809984", Offset = "0x809984")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public class InteractionEvent
		{
			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810684", Offset = "0x810684")]
			public float time;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8106BC", Offset = "0x8106BC")]
			public bool pause;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8106F4", Offset = "0x8106F4")]
			public bool pickUp;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81072C", Offset = "0x81072C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810764", Offset = "0x810764")]
			public Message[] messages;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81079C", Offset = "0x81079C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x1CFBC30", Offset = "0x1CFBC30", VA = "0x1CFBC30")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1CFBE04", Offset = "0x1CFBE04", VA = "0x1CFBE04")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public class Message
		{
			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8107D4", Offset = "0x8107D4")]
			public string function;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81080C", Offset = "0x81080C")]
			public GameObject recipient;

			[Token(Token = "0x40004D3")]
			private const string empty = "";

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1CFBD00", Offset = "0x1CFBD00", VA = "0x1CFBD00")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1CFBE0C", Offset = "0x1CFBE0C", VA = "0x1CFBE0C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810844", Offset = "0x810844")]
			public Animator animator;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81087C", Offset = "0x81087C")]
			public Animation animation;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8108B4", Offset = "0x8108B4")]
			public string animationState;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8108EC", Offset = "0x8108EC")]
			public float crossfadeTime;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810924", Offset = "0x810924")]
			public int layer;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81095C", Offset = "0x81095C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40004DA")]
			private const string empty = "";

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1CFB99C", Offset = "0x1CFB99C", VA = "0x1CFB99C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x1CFBA8C", Offset = "0x1CFBA8C", VA = "0x1CFBA8C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1CFBB40", Offset = "0x1CFBB40", VA = "0x1CFBB40")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1CFBC1C", Offset = "0x1CFBC1C", VA = "0x1CFBC1C")]
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
				[Token(Token = "0x40004DE")]
				PositionWeight,
				[Token(Token = "0x40004DF")]
				RotationWeight,
				[Token(Token = "0x40004E0")]
				PositionOffsetX,
				[Token(Token = "0x40004E1")]
				PositionOffsetY,
				[Token(Token = "0x40004E2")]
				PositionOffsetZ,
				[Token(Token = "0x40004E3")]
				Pull,
				[Token(Token = "0x40004E4")]
				Reach,
				[Token(Token = "0x40004E5")]
				RotateBoneWeight,
				[Token(Token = "0x40004E6")]
				Push,
				[Token(Token = "0x40004E7")]
				PushParent,
				[Token(Token = "0x40004E8")]
				PoserWeight,
				[Token(Token = "0x40004E9")]
				BendGoalWeight
			}

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810994", Offset = "0x810994")]
			public Type type;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8109CC", Offset = "0x8109CC")]
			public AnimationCurve curve;

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1CFBE50", Offset = "0x1CFBE50", VA = "0x1CFBE50")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1CFBE7C", Offset = "0x1CFBE7C", VA = "0x1CFBE7C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class Multiplier
		{
			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810A04", Offset = "0x810A04")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810A3C", Offset = "0x810A3C")]
			public float multiplier;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810A74", Offset = "0x810A74")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1CFBE14", Offset = "0x1CFBE14", VA = "0x1CFBE14")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x1CFBE6C", Offset = "0x1CFBE6C", VA = "0x1CFBE6C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8105BC", Offset = "0x8105BC")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8105F4", Offset = "0x8105F4")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81062C", Offset = "0x81062C")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810664", Offset = "0x810664")]
		private float <length>k__BackingField;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810674", Offset = "0x810674")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000094")]
		public float length
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1B045F0", Offset = "0x1B045F0", VA = "0x1B045F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171A8", Offset = "0x8171A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1B045F8", Offset = "0x1B045F8", VA = "0x1B045F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171B8", Offset = "0x8171B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x1B04600", Offset = "0x1B04600", VA = "0x1B04600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171C8", Offset = "0x8171C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x1B04608", Offset = "0x1B04608", VA = "0x1B04608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171D8", Offset = "0x8171D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x1B047D8", Offset = "0x1B047D8", VA = "0x1B047D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x1B03684", Offset = "0x1B03684", VA = "0x1B03684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1B043B0", Offset = "0x1B043B0", VA = "0x1B043B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x816FE8", Offset = "0x816FE8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1B043F8", Offset = "0x1B043F8", VA = "0x1B043F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817020", Offset = "0x817020")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1B04440", Offset = "0x1B04440", VA = "0x1B04440")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817058", Offset = "0x817058")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1B04488", Offset = "0x1B04488", VA = "0x1B04488")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817090", Offset = "0x817090")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1B044D0", Offset = "0x1B044D0", VA = "0x1B044D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8170C8", Offset = "0x8170C8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1B04518", Offset = "0x1B04518", VA = "0x1B04518")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817100", Offset = "0x817100")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1B04560", Offset = "0x1B04560", VA = "0x1B04560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817138", Offset = "0x817138")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1B045A8", Offset = "0x1B045A8", VA = "0x1B045A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817170", Offset = "0x817170")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1B04610", Offset = "0x1B04610", VA = "0x1B04610")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1B04864", Offset = "0x1B04864", VA = "0x1B04864")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1B01D90", Offset = "0x1B01D90", VA = "0x1B01D90")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1B049D0", Offset = "0x1B049D0", VA = "0x1B049D0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1B01828", Offset = "0x1B01828", VA = "0x1B01828")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1B01D88", Offset = "0x1B01D88", VA = "0x1B01D88")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1B029E4", Offset = "0x1B029E4", VA = "0x1B029E4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1B03304", Offset = "0x1B03304", VA = "0x1B03304")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1B04F80", Offset = "0x1B04F80", VA = "0x1B04F80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1B04AB8", Offset = "0x1B04AB8", VA = "0x1B04AB8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1B049D8", Offset = "0x1B049D8", VA = "0x1B049D8")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1B04F18", Offset = "0x1B04F18", VA = "0x1B04F18")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1B04F84", Offset = "0x1B04F84", VA = "0x1B04F84")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1B04FEC", Offset = "0x1B04FEC", VA = "0x1B04FEC")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8099E4", Offset = "0x8099E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8099E4", Offset = "0x8099E4")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200009C")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810AAC", Offset = "0x810AAC")]
		public string targetTag;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810AE4", Offset = "0x810AE4")]
		public float fadeInTime;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810B1C", Offset = "0x810B1C")]
		public float speed;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810B54", Offset = "0x810B54")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x810B8C", Offset = "0x810B8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810B8C", Offset = "0x810B8C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x810B8C", Offset = "0x810B8C")]
		public Collider characterCollider;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x810C10", Offset = "0x810C10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810C10", Offset = "0x810C10")]
		public Transform FPSCamera;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810C70", Offset = "0x810C70")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810CA8", Offset = "0x810CA8")]
		public float camRaycastDistance;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810CE0", Offset = "0x810CE0")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x810CF0", Offset = "0x810CF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810CF0", Offset = "0x810CF0")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810D50", Offset = "0x810D50")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810D88", Offset = "0x810D88")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float lastTime;

		[Token(Token = "0x17000098")]
		public bool inInteraction
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1B05294", Offset = "0x1B05294", VA = "0x1B05294")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1B0709C", Offset = "0x1B0709C", VA = "0x1B0709C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x1B070A4", Offset = "0x1B070A4", VA = "0x1B070A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x1B070AC", Offset = "0x1B070AC", VA = "0x1B070AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8173A8", Offset = "0x8173A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x1B070B4", Offset = "0x1B070B4", VA = "0x1B070B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8173B8", Offset = "0x8173B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool initiated
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x1B070BC", Offset = "0x1B070BC", VA = "0x1B070BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8173C8", Offset = "0x8173C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x1B070C4", Offset = "0x1B070C4", VA = "0x1B070C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8173D8", Offset = "0x8173D8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1B05054", Offset = "0x1B05054", VA = "0x1B05054")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8171E8", Offset = "0x8171E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1B0509C", Offset = "0x1B0509C", VA = "0x1B0509C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817220", Offset = "0x817220")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1B050E4", Offset = "0x1B050E4", VA = "0x1B050E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817258", Offset = "0x817258")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1B0512C", Offset = "0x1B0512C", VA = "0x1B0512C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817290", Offset = "0x817290")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1B05174", Offset = "0x1B05174", VA = "0x1B05174")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8172C8", Offset = "0x8172C8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1B051BC", Offset = "0x1B051BC", VA = "0x1B051BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817300", Offset = "0x817300")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1B05204", Offset = "0x1B05204", VA = "0x1B05204")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817338", Offset = "0x817338")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1B0524C", Offset = "0x1B0524C", VA = "0x1B0524C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817370", Offset = "0x817370")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1B05438", Offset = "0x1B05438", VA = "0x1B05438")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1B05504", Offset = "0x1B05504", VA = "0x1B05504")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1B055D0", Offset = "0x1B055D0", VA = "0x1B055D0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1B0567C", Offset = "0x1B0567C", VA = "0x1B0567C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1B05774", Offset = "0x1B05774", VA = "0x1B05774")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1B0588C", Offset = "0x1B0588C", VA = "0x1B0588C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1B059A8", Offset = "0x1B059A8", VA = "0x1B059A8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1B05A38", Offset = "0x1B05A38", VA = "0x1B05A38")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1B05AC8", Offset = "0x1B05AC8", VA = "0x1B05AC8")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1B05B58", Offset = "0x1B05B58", VA = "0x1B05B58")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1B05BCC", Offset = "0x1B05BCC", VA = "0x1B05BCC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1B05C40", Offset = "0x1B05C40", VA = "0x1B05C40")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1B05CA8", Offset = "0x1B05CA8", VA = "0x1B05CA8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1B05D34", Offset = "0x1B05D34", VA = "0x1B05D34")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1B05DE8", Offset = "0x1B05DE8", VA = "0x1B05DE8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1B05ECC", Offset = "0x1B05ECC", VA = "0x1B05ECC")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1B061A4", Offset = "0x1B061A4", VA = "0x1B061A4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1B0639C", Offset = "0x1B0639C", VA = "0x1B0639C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1B06640", Offset = "0x1B06640", VA = "0x1B06640")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1B06918", Offset = "0x1B06918", VA = "0x1B06918")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1B0695C", Offset = "0x1B0695C", VA = "0x1B0695C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1B069D4", Offset = "0x1B069D4", VA = "0x1B069D4")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1B06B08", Offset = "0x1B06B08", VA = "0x1B06B08")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1B06CAC", Offset = "0x1B06CAC", VA = "0x1B06CAC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1B06F50", Offset = "0x1B06F50", VA = "0x1B06F50")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1B06754", Offset = "0x1B06754", VA = "0x1B06754")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1B070D0", Offset = "0x1B070D0", VA = "0x1B070D0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1B078F8", Offset = "0x1B078F8", VA = "0x1B078F8")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1B07918", Offset = "0x1B07918", VA = "0x1B07918")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1B07934", Offset = "0x1B07934", VA = "0x1B07934")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1B07950", Offset = "0x1B07950", VA = "0x1B07950")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1B079B0", Offset = "0x1B079B0", VA = "0x1B079B0")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1B07AEC", Offset = "0x1B07AEC", VA = "0x1B07AEC")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1B07BFC", Offset = "0x1B07BFC", VA = "0x1B07BFC")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1B07FA0", Offset = "0x1B07FA0", VA = "0x1B07FA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1B080CC", Offset = "0x1B080CC", VA = "0x1B080CC")]
		public void Update()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1B08328", Offset = "0x1B08328", VA = "0x1B08328")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1B07644", Offset = "0x1B07644", VA = "0x1B07644")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1B08464", Offset = "0x1B08464", VA = "0x1B08464")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1B0848C", Offset = "0x1B0848C", VA = "0x1B0848C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1B085E4", Offset = "0x1B085E4", VA = "0x1B085E4")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1B08678", Offset = "0x1B08678", VA = "0x1B08678")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1B0874C", Offset = "0x1B0874C", VA = "0x1B0874C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1B08764", Offset = "0x1B08764", VA = "0x1B08764")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1B05340", Offset = "0x1B05340", VA = "0x1B05340")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1B06074", Offset = "0x1B06074", VA = "0x1B06074")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1B08B60", Offset = "0x1B08B60", VA = "0x1B08B60")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809A44", Offset = "0x809A44")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809A44", Offset = "0x809A44")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public enum RotationMode
		{
			[Token(Token = "0x4000513")]
			TwoDOF,
			[Token(Token = "0x4000514")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public class Multiplier
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810FE4", Offset = "0x810FE4")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81101C", Offset = "0x81101C")]
			public float multiplier;

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x1CFC4F0", Offset = "0x1CFC4F0", VA = "0x1CFC4F0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810D98", Offset = "0x810D98")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810DD0", Offset = "0x810DD0")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810E08", Offset = "0x810E08")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810E40", Offset = "0x810E40")]
		public Transform pivot;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810E78", Offset = "0x810E78")]
		public RotationMode rotationMode;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810EB0", Offset = "0x810EB0")]
		public Vector3 twistAxis;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810EE8", Offset = "0x810EE8")]
		public float twistWeight;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810F20", Offset = "0x810F20")]
		public float swingWeight;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x810F58", Offset = "0x810F58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810F58", Offset = "0x810F58")]
		public float threeDOFWeight;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x810FAC", Offset = "0x810FAC")]
		public bool rotateOnce;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1B09348", Offset = "0x1B09348", VA = "0x1B09348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8173E8", Offset = "0x8173E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1B09390", Offset = "0x1B09390", VA = "0x1B09390")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817420", Offset = "0x817420")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1B093D8", Offset = "0x1B093D8", VA = "0x1B093D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817458", Offset = "0x817458")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1B09420", Offset = "0x1B09420", VA = "0x1B09420")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817490", Offset = "0x817490")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1B09468", Offset = "0x1B09468", VA = "0x1B09468")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8174C8", Offset = "0x8174C8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1B094B0", Offset = "0x1B094B0", VA = "0x1B094B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817500", Offset = "0x817500")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1B094F8", Offset = "0x1B094F8", VA = "0x1B094F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817538", Offset = "0x817538")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1B09540", Offset = "0x1B09540", VA = "0x1B09540")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817570", Offset = "0x817570")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1B04A48", Offset = "0x1B04A48", VA = "0x1B04A48")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1B03710", Offset = "0x1B03710", VA = "0x1B03710")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1B01E44", Offset = "0x1B01E44", VA = "0x1B01E44")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1B09588", Offset = "0x1B09588", VA = "0x1B09588")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809AA4", Offset = "0x809AA4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809AA4", Offset = "0x809AA4")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81108C", Offset = "0x81108C")]
			public bool use;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8110C4", Offset = "0x8110C4")]
			public Vector2 offset;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8110FC", Offset = "0x8110FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8110FC", Offset = "0x8110FC")]
			public float angleOffset;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x811158", Offset = "0x811158")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811158", Offset = "0x811158")]
			public float maxAngle;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8111B0", Offset = "0x8111B0")]
			public float radius;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8111E8", Offset = "0x8111E8")]
			public bool orbit;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811220", Offset = "0x811220")]
			public bool fixYAxis;

			[Token(Token = "0x1700009C")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0x1CFC860", Offset = "0x1CFC860", VA = "0x1CFC860")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x1CFC86C", Offset = "0x1CFC86C", VA = "0x1CFC86C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1CFC8F4", Offset = "0x1CFC8F4", VA = "0x1CFC8F4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1CFCD38", Offset = "0x1CFCD38", VA = "0x1CFCD38")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class CameraPosition
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811258", Offset = "0x811258")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811290", Offset = "0x811290")]
			public Vector3 direction;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8112C8", Offset = "0x8112C8")]
			public float maxDistance;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x811300", Offset = "0x811300")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811300", Offset = "0x811300")]
			public float maxAngle;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811358", Offset = "0x811358")]
			public bool fixYAxis;

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1CFC4F8", Offset = "0x1CFC4F8", VA = "0x1CFC4F8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x1CFC5EC", Offset = "0x1CFC5EC", VA = "0x1CFC5EC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x1CFC814", Offset = "0x1CFC814", VA = "0x1CFC814")]
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
				[Token(Token = "0x4000529")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811458", Offset = "0x811458")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400052A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811490", Offset = "0x811490")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600059B")]
				[Address(RVA = "0x1E5D2F4", Offset = "0x1E5D2F4", VA = "0x1E5D2F4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8113B0", Offset = "0x8113B0")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8113E8", Offset = "0x8113E8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811420", Offset = "0x811420")]
			public Interaction[] interactions;

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1CFCD4C", Offset = "0x1CFCD4C", VA = "0x1CFCD4C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1CFCE00", Offset = "0x1CFCE00", VA = "0x1CFCE00")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811054", Offset = "0x811054")]
		public Range[] ranges;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1B095D4", Offset = "0x1B095D4", VA = "0x1B095D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8175A8", Offset = "0x8175A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1B0961C", Offset = "0x1B0961C", VA = "0x1B0961C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8175E0", Offset = "0x8175E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1B09664", Offset = "0x1B09664", VA = "0x1B09664")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817618", Offset = "0x817618")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1B096AC", Offset = "0x1B096AC", VA = "0x1B096AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817650", Offset = "0x817650")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1B096F4", Offset = "0x1B096F4", VA = "0x1B096F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817688", Offset = "0x817688")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1B07DCC", Offset = "0x1B07DCC", VA = "0x1B07DCC")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1B0973C", Offset = "0x1B0973C", VA = "0x1B0973C")]
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
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x152A830", Offset = "0x152A830", VA = "0x152A830")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x152A888", Offset = "0x152A888", VA = "0x152A888")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x152A8D8", Offset = "0x152A8D8", VA = "0x152A8D8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x152A924", Offset = "0x152A924", VA = "0x152A924")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1A3FC7C", Offset = "0x1A3FC7C", VA = "0x1A3FC7C", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8176C0", Offset = "0x8176C0")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1A4000C", Offset = "0x1A4000C", VA = "0x1A4000C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1A40010", Offset = "0x1A40010", VA = "0x1A40010", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1A40118", Offset = "0x1A40118", VA = "0x1A40118", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1A3FFA0", Offset = "0x1A3FFA0", VA = "0x1A3FFA0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1A3FF00", Offset = "0x1A3FF00", VA = "0x1A3FF00")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1A40184", Offset = "0x1A40184", VA = "0x1A40184")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1C137A0", Offset = "0x1C137A0", VA = "0x1C137A0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1C1387C", Offset = "0x1C1387C", VA = "0x1C1387C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1C13A64", Offset = "0x1C13A64", VA = "0x1C13A64", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1C13B60", Offset = "0x1C13B60", VA = "0x1C13B60", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1C138E0", Offset = "0x1C138E0", VA = "0x1C138E0")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1C13EC0", Offset = "0x1C13EC0", VA = "0x1C13EC0")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8114C8", Offset = "0x8114C8")]
		public float weight;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8114E0", Offset = "0x8114E0")]
		public float localRotationWeight;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8114F8", Offset = "0x8114F8")]
		public float localPositionWeight;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60005AD")]
		public abstract void AutoMapping();

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1B11290", Offset = "0x1B11290", VA = "0x1B11290")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60005AF")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60005B0")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60005B1")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1B1129C", Offset = "0x1B1129C", VA = "0x1B1129C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1B112F0", Offset = "0x1B112F0", VA = "0x1B112F0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1B1132C", Offset = "0x1B1132C", VA = "0x1B1132C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1B11344", Offset = "0x1B11344", VA = "0x1B11344")]
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
			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1E584A8", Offset = "0x1E584A8", VA = "0x1E584A8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1E5866C", Offset = "0x1E5866C", VA = "0x1E5866C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1E5874C", Offset = "0x1E5874C", VA = "0x1E5874C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000AB")]
		public class Child
		{
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1E582A0", Offset = "0x1E582A0", VA = "0x1E582A0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1E58318", Offset = "0x1E58318", VA = "0x1E58318")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1E58458", Offset = "0x1E58458", VA = "0x1E58458")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809B04", Offset = "0x809B04")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D1")]
				[Address(RVA = "0x1E58250", Offset = "0x1E58250", VA = "0x1E58250", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x1E58298", Offset = "0x1E58298", VA = "0x1E58298", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1E58014", Offset = "0x1E58014", VA = "0x1E58014")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1E58040", Offset = "0x1E58040", VA = "0x1E58040", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1E58044", Offset = "0x1E58044", VA = "0x1E58044", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1E58258", Offset = "0x1E58258", VA = "0x1E58258", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811510", Offset = "0x811510")]
		public IK ik;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811548", Offset = "0x811548")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811580", Offset = "0x811580")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8115B8", Offset = "0x8115B8")]
		public float applyVelocity;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8115F0", Offset = "0x8115F0")]
		public float applyAngularVelocity;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700009E")]
		private bool isRagdoll
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x13DC384", Offset = "0x13DC384", VA = "0x13DC384")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		private bool ikUsed
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x13DCDB8", Offset = "0x13DCDB8", VA = "0x13DCDB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x13DC34C", Offset = "0x13DC34C", VA = "0x13DC34C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x13DC3FC", Offset = "0x13DC3FC", VA = "0x13DC3FC")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x13DC538", Offset = "0x13DC538", VA = "0x13DC538")]
		public void Start()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x13DC4C0", Offset = "0x13DC4C0", VA = "0x13DC4C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8176F8", Offset = "0x8176F8")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x13DC9F4", Offset = "0x13DC9F4", VA = "0x13DC9F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x13DCC40", Offset = "0x13DCC40", VA = "0x13DCC40")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x13DCCFC", Offset = "0x13DCCFC", VA = "0x13DCCFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x13DCF38", Offset = "0x13DCF38", VA = "0x13DCF38")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x13DCD7C", Offset = "0x13DCD7C", VA = "0x13DCD7C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x13DCEF4", Offset = "0x13DCEF4", VA = "0x13DCEF4")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x13DCFD8", Offset = "0x13DCFD8", VA = "0x13DCFD8")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x13DCF6C", Offset = "0x13DCF6C", VA = "0x13DCF6C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x13DC454", Offset = "0x13DC454", VA = "0x13DC454")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x13DCC80", Offset = "0x13DCC80", VA = "0x13DCC80")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x13DD204", Offset = "0x13DD204", VA = "0x13DD204")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x13DD340", Offset = "0x13DD340", VA = "0x13DD340")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811638", Offset = "0x811638")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000A2")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x13DF37C", Offset = "0x13DF37C", VA = "0x13DF37C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A3")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x13DF388", Offset = "0x13DF388", VA = "0x13DF388")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A4")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x13DF3A4", Offset = "0x13DF3A4", VA = "0x13DF3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8177A8", Offset = "0x8177A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x13DF3AC", Offset = "0x13DF3AC", VA = "0x13DF3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8177B8", Offset = "0x8177B8")]
			private set
			{
			}
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x13DF07C", Offset = "0x13DF07C", VA = "0x13DF07C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x13DF0C4", Offset = "0x13DF0C4", VA = "0x13DF0C4")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x13DF0DC", Offset = "0x13DF0DC", VA = "0x13DF0DC")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x13DF2D4", Offset = "0x13DF2D4", VA = "0x13DF2D4")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x13DF344", Offset = "0x13DF344", VA = "0x13DF344")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005DD")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x13DF1FC", Offset = "0x13DF1FC", VA = "0x13DF1FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x13DF3B8", Offset = "0x13DF3B8", VA = "0x13DF3B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x13DF3BC", Offset = "0x13DF3BC", VA = "0x13DF3BC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x13DF3F0", Offset = "0x13DF3F0", VA = "0x13DF3F0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x13DF46C", Offset = "0x13DF46C", VA = "0x13DF46C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x13DF600", Offset = "0x13DF600", VA = "0x13DF600")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x13DF670", Offset = "0x13DF670", VA = "0x13DF670")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809B14", Offset = "0x809B14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809B14", Offset = "0x809B14")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x811648", Offset = "0x811648")]
		public float limit;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x811664", Offset = "0x811664")]
		public float twistLimit;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x13DF6A4", Offset = "0x13DF6A4", VA = "0x13DF6A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8177C8", Offset = "0x8177C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x13DF6EC", Offset = "0x13DF6EC", VA = "0x13DF6EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817800", Offset = "0x817800")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x13DF734", Offset = "0x13DF734", VA = "0x13DF734")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817838", Offset = "0x817838")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x13DF77C", Offset = "0x13DF77C", VA = "0x13DF77C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817870", Offset = "0x817870")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x13DF7C4", Offset = "0x13DF7C4", VA = "0x13DF7C4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x13DF808", Offset = "0x13DF808", VA = "0x13DF808")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x13DF9C8", Offset = "0x13DF9C8", VA = "0x13DF9C8")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809B74", Offset = "0x809B74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809B74", Offset = "0x809B74")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x13DFA08", Offset = "0x13DFA08", VA = "0x13DFA08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8178A8", Offset = "0x8178A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x13DFA50", Offset = "0x13DFA50", VA = "0x13DFA50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8178E0", Offset = "0x8178E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x13DFA98", Offset = "0x13DFA98", VA = "0x13DFA98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817918", Offset = "0x817918")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x13DFAE0", Offset = "0x13DFAE0", VA = "0x13DFAE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817950", Offset = "0x817950")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x13DFB28", Offset = "0x13DFB28", VA = "0x13DFB28", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x13DFB2C", Offset = "0x13DFB2C", VA = "0x13DFB2C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x13DFCB0", Offset = "0x13DFCB0", VA = "0x13DFCB0")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809BD4", Offset = "0x809BD4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809BD4", Offset = "0x809BD4")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class ReachCone
		{
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000A5")]
			public Vector3 o
			{
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x1E58D98", Offset = "0x1E58D98", VA = "0x1E58D98")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 a
			{
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x1E58DD0", Offset = "0x1E58DD0", VA = "0x1E58DD0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A7")]
			public Vector3 b
			{
				[Token(Token = "0x6000605")]
				[Address(RVA = "0x1E58E0C", Offset = "0x1E58E0C", VA = "0x1E58E0C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A8")]
			public Vector3 c
			{
				[Token(Token = "0x6000606")]
				[Address(RVA = "0x1E58E48", Offset = "0x1E58E48", VA = "0x1E58E48")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A9")]
			public bool isValid
			{
				[Token(Token = "0x6000608")]
				[Address(RVA = "0x1E58FD4", Offset = "0x1E58FD4", VA = "0x1E58FD4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1E58E84", Offset = "0x1E58E84", VA = "0x1E58E84")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1E58FE4", Offset = "0x1E58FE4", VA = "0x1E58FE4")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		public class LimitPoint
		{
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1E58D5C", Offset = "0x1E58D5C", VA = "0x1E58D5C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x811690", Offset = "0x811690")]
		public float twistLimit;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8116AC", Offset = "0x8116AC")]
		public int smoothIterations;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x13DFCF8", Offset = "0x13DFCF8", VA = "0x13DFCF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817988", Offset = "0x817988")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x13DFD40", Offset = "0x13DFD40", VA = "0x13DFD40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8179C0", Offset = "0x8179C0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x13DFD88", Offset = "0x13DFD88", VA = "0x13DFD88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8179F8", Offset = "0x8179F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x13DFDD0", Offset = "0x13DFDD0", VA = "0x13DFDD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817A30", Offset = "0x817A30")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x13DFE18", Offset = "0x13DFE18", VA = "0x13DFE18")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x13E0314", Offset = "0x13E0314", VA = "0x13E0314", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x13E03A8", Offset = "0x13E03A8", VA = "0x13E03A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x13E091C", Offset = "0x13E091C", VA = "0x13E091C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x13DFEC0", Offset = "0x13DFEC0", VA = "0x13DFEC0")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x13E0CC8", Offset = "0x13E0CC8", VA = "0x13E0CC8")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x13E10D4", Offset = "0x13E10D4", VA = "0x13E10D4")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x13E1118", Offset = "0x13E1118", VA = "0x13E1118")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x13E1178", Offset = "0x13E1178", VA = "0x13E1178")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x13E06AC", Offset = "0x13E06AC", VA = "0x13E06AC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x13E11E4", Offset = "0x13E11E4", VA = "0x13E11E4")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x13E12C0", Offset = "0x13E12C0", VA = "0x13E12C0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809C34", Offset = "0x809C34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809C34", Offset = "0x809C34")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8116F4", Offset = "0x8116F4")]
		public float twistLimit;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x13E1340", Offset = "0x13E1340", VA = "0x13E1340")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817A68", Offset = "0x817A68")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x13E1388", Offset = "0x13E1388", VA = "0x13E1388")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817AA0", Offset = "0x817AA0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x13E13D0", Offset = "0x13E13D0", VA = "0x13E13D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817AD8", Offset = "0x817AD8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x13E1418", Offset = "0x13E1418", VA = "0x13E1418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x817B10", Offset = "0x817B10")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x13E1460", Offset = "0x13E1460", VA = "0x13E1460")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x13E147C", Offset = "0x13E147C", VA = "0x13E147C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x13E14C0", Offset = "0x13E14C0", VA = "0x13E14C0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x13E16E4", Offset = "0x13E16E4", VA = "0x13E16E4")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809C94", Offset = "0x809C94")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x1528DDC", Offset = "0x1528DDC", VA = "0x1528DDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x1528E24", Offset = "0x1528E24", VA = "0x1528E24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x1528CE0", Offset = "0x1528CE0", VA = "0x1528CE0")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1528D0C", Offset = "0x1528D0C", VA = "0x1528D0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1528D10", Offset = "0x1528D10", VA = "0x1528D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1528DE4", Offset = "0x1528DE4", VA = "0x1528DE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811720", Offset = "0x811720")]
		public AimIK ik;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x811758", Offset = "0x811758")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811758", Offset = "0x811758")]
		public float weight;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8117AC", Offset = "0x8117AC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8117AC", Offset = "0x8117AC")]
		public Transform target;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81180C", Offset = "0x81180C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811844", Offset = "0x811844")]
		public float weightSmoothTime;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81187C", Offset = "0x81187C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x81187C", Offset = "0x81187C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8118DC", Offset = "0x8118DC")]
		public float maxRadiansDelta;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811914", Offset = "0x811914")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81194C", Offset = "0x81194C")]
		public float slerpSpeed;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811984", Offset = "0x811984")]
		public float smoothDampTime;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8119BC", Offset = "0x8119BC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8119F4", Offset = "0x8119F4")]
		public float minDistance;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811A2C", Offset = "0x811A2C")]
		public Vector3 offset;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x811A64", Offset = "0x811A64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x811A64", Offset = "0x811A64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811A64", Offset = "0x811A64")]
		public float maxRootAngle;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811AE0", Offset = "0x811AE0")]
		public bool turnToTarget;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811B18", Offset = "0x811B18")]
		public float turnToTargetTime;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811B50", Offset = "0x811B50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x811B50", Offset = "0x811B50")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811BB0", Offset = "0x811BB0")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x170000AA")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x19B8770", Offset = "0x19B8770", VA = "0x19B8770")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x19B86E4", Offset = "0x19B86E4", VA = "0x19B86E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x19B8800", Offset = "0x19B8800", VA = "0x19B8800")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x19B8EE4", Offset = "0x19B8EE4", VA = "0x19B8EE4")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x19B8FD0", Offset = "0x19B8FD0", VA = "0x19B8FD0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x19B9220", Offset = "0x19B9220", VA = "0x19B9220")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x817B48", Offset = "0x817B48")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x19B9298", Offset = "0x19B9298", VA = "0x19B9298")]
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
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1528E2C", Offset = "0x1528E2C", VA = "0x1528E2C")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1528FB8", Offset = "0x1528FB8", VA = "0x1528FB8")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1528FC0", Offset = "0x1528FC0", VA = "0x1528FC0")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x19B9508", Offset = "0x19B9508", VA = "0x19B9508")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x19B95E8", Offset = "0x19B95E8", VA = "0x19B95E8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x19B9654", Offset = "0x19B9654", VA = "0x19B9654")]
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
				[Token(Token = "0x40005A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811D70", Offset = "0x811D70")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811DA8", Offset = "0x811DA8")]
				public float weight;

				[Token(Token = "0x600062B")]
				[Address(RVA = "0x1E5CECC", Offset = "0x1E5CECC", VA = "0x1E5CECC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811C20", Offset = "0x811C20")]
			public Transform transform;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811C58", Offset = "0x811C58")]
			public Transform relativeTo;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811C90", Offset = "0x811C90")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811CC8", Offset = "0x811CC8")]
			public float verticalWeight;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811D00", Offset = "0x811D00")]
			public float horizontalWeight;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811D38", Offset = "0x811D38")]
			public float speed;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x1528FDC", Offset = "0x1528FDC", VA = "0x1528FDC")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1529300", Offset = "0x1529300", VA = "0x1529300")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1529310", Offset = "0x1529310", VA = "0x1529310")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811BE8", Offset = "0x811BE8")]
		public Body[] bodies;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x19B9770", Offset = "0x19B9770", VA = "0x19B9770", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x19B98BC", Offset = "0x19B98BC", VA = "0x19B98BC")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811DE0", Offset = "0x811DE0")]
		public float tiltSpeed;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811E18", Offset = "0x811E18")]
		public float tiltSensitivity;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811E50", Offset = "0x811E50")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811E88", Offset = "0x811E88")]
		public OffsetPose poseRight;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x19C885C", Offset = "0x19C885C", VA = "0x19C885C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x19C88A4", Offset = "0x19C88A4", VA = "0x19C88A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x19C8A5C", Offset = "0x19C8A5C", VA = "0x19C8A5C")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x811EC0", Offset = "0x811EC0")]
		public float weight;

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x19C8CBC", Offset = "0x19C8CBC", VA = "0x19C8CBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x19C8D94", Offset = "0x19C8D94", VA = "0x19C8D94")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x19C8FBC", Offset = "0x19C8FBC", VA = "0x19C8FBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x19C90EC", Offset = "0x19C90EC", VA = "0x19C90EC")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811ED8", Offset = "0x811ED8")]
		public Animator animator;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811F10", Offset = "0x811F10")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811F58", Offset = "0x811F58")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x170000AD")]
		public IK ik
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1A332A4", Offset = "0x1A332A4", VA = "0x1A332A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817BF8", Offset = "0x817BF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1A332AC", Offset = "0x1A332AC", VA = "0x1A332AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C08", Offset = "0x817C08")]
			private set
			{
			}
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1A332B4", Offset = "0x1A332B4", VA = "0x1A332B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1A33470", Offset = "0x1A33470", VA = "0x1A33470")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1A336FC", Offset = "0x1A336FC", VA = "0x1A336FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1A33854", Offset = "0x1A33854", VA = "0x1A33854")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1A33A44", Offset = "0x1A33A44", VA = "0x1A33A44")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1A33C7C", Offset = "0x1A33C7C", VA = "0x1A33C7C")]
		public void Update()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1A33F28", Offset = "0x1A33F28", VA = "0x1A33F28")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x809CB4", Offset = "0x809CB4")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000AE")]
		public bool poseStored
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x1A33568", Offset = "0x1A33568", VA = "0x1A33568")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1A338D4", Offset = "0x1A338D4", VA = "0x1A338D4")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1A3358C", Offset = "0x1A3358C", VA = "0x1A3358C")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1A33F90", Offset = "0x1A33F90", VA = "0x1A33F90")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811FD8", Offset = "0x811FD8")]
			public string name;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812010", Offset = "0x812010")]
			public Collider collider;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812048", Offset = "0x812048")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812094", Offset = "0x812094")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8120A4", Offset = "0x8120A4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8120B4", Offset = "0x8120B4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000B0")]
			public bool inProgress
			{
				[Token(Token = "0x6000644")]
				[Address(RVA = "0x152D550", Offset = "0x152D550", VA = "0x152D550")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B1")]
			protected float crossFader
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x152D564", Offset = "0x152D564", VA = "0x152D564")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C18", Offset = "0x817C18")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000646")]
				[Address(RVA = "0x152D56C", Offset = "0x152D56C", VA = "0x152D56C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C28", Offset = "0x817C28")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			protected float timer
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x152D574", Offset = "0x152D574", VA = "0x152D574")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C38", Offset = "0x817C38")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x152D57C", Offset = "0x152D57C", VA = "0x152D57C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C48", Offset = "0x817C48")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			protected Vector3 force
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x152D584", Offset = "0x152D584", VA = "0x152D584")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C58", Offset = "0x817C58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x152D590", Offset = "0x152D590", VA = "0x152D590")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C68", Offset = "0x817C68")]
				private set
				{
				}
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x152D59C", Offset = "0x152D59C", VA = "0x152D59C", Slot = "4")]
			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x152D6B4", Offset = "0x152D6B4", VA = "0x152D6B4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600064D")]
			protected abstract float GetLength();

			[Token(Token = "0x600064E")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600064F")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x152D788", Offset = "0x152D788", VA = "0x152D788")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C2")]
			public class EffectorLink
			{
				[Token(Token = "0x40005C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81216C", Offset = "0x81216C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005C8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8121A4", Offset = "0x8121A4")]
				public float weight;

				[Token(Token = "0x40005C9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000655")]
				[Address(RVA = "0x1E5D048", Offset = "0x1E5D048", VA = "0x1E5D048")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000656")]
				[Address(RVA = "0x1E5D0F8", Offset = "0x1E5D0F8", VA = "0x1E5D0F8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000657")]
				[Address(RVA = "0x1E5D10C", Offset = "0x1E5D10C", VA = "0x1E5D10C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8120C4", Offset = "0x8120C4")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8120FC", Offset = "0x8120FC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812134", Offset = "0x812134")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x152DB24", Offset = "0x152DB24", VA = "0x152DB24", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x152DC54", Offset = "0x152DC54", VA = "0x152DC54", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x152DCC0", Offset = "0x152DCC0", VA = "0x152DCC0", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x152DE28", Offset = "0x152DE28", VA = "0x152DE28")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C4")]
			public class BoneLink
			{
				[Token(Token = "0x40005CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81224C", Offset = "0x81224C")]
				public Transform bone;

				[Token(Token = "0x40005D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x812284", Offset = "0x812284")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812284", Offset = "0x812284")]
				public float weight;

				[Token(Token = "0x40005D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40005D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600065D")]
				[Address(RVA = "0x1E5CEE0", Offset = "0x1E5CEE0", VA = "0x1E5CEE0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600065E")]
				[Address(RVA = "0x1E5CFF8", Offset = "0x1E5CFF8", VA = "0x1E5CFF8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600065F")]
				[Address(RVA = "0x1E5D004", Offset = "0x1E5D004", VA = "0x1E5D004")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8121DC", Offset = "0x8121DC")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812214", Offset = "0x812214")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rigidbody rigidbody;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 comAxis;

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x152D79C", Offset = "0x152D79C", VA = "0x152D79C", Slot = "4")]
			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x152D920", Offset = "0x152D920", VA = "0x152D920", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x152D9C4", Offset = "0x152D9C4", VA = "0x152D9C4", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x152DA30", Offset = "0x152DA30", VA = "0x152DA30", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x152DB10", Offset = "0x152DB10", VA = "0x152DB10")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811F68", Offset = "0x811F68")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x811FA0", Offset = "0x811FA0")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000AF")]
		public bool inProgress
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1C14D68", Offset = "0x1C14D68", VA = "0x1C14D68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1C14E38", Offset = "0x1C14E38", VA = "0x1C14E38", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1C14F14", Offset = "0x1C14F14", VA = "0x1C14F14")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1C15178", Offset = "0x1C15178", VA = "0x1C15178")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public abstract class Offset
		{
			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812348", Offset = "0x812348")]
			public string name;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812380", Offset = "0x812380")]
			public Collider collider;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8123B8", Offset = "0x8123B8")]
			private float crossFadeTime;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812404", Offset = "0x812404")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812414", Offset = "0x812414")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812424", Offset = "0x812424")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000B4")]
			protected float crossFader
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x152DE3C", Offset = "0x152DE3C", VA = "0x152DE3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C78", Offset = "0x817C78")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x152DE44", Offset = "0x152DE44", VA = "0x152DE44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C88", Offset = "0x817C88")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			protected float timer
			{
				[Token(Token = "0x6000665")]
				[Address(RVA = "0x152DE4C", Offset = "0x152DE4C", VA = "0x152DE4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817C98", Offset = "0x817C98")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x152DE54", Offset = "0x152DE54", VA = "0x152DE54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817CA8", Offset = "0x817CA8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			protected Vector3 force
			{
				[Token(Token = "0x6000667")]
				[Address(RVA = "0x152DE5C", Offset = "0x152DE5C", VA = "0x152DE5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817CB8", Offset = "0x817CB8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x152DE68", Offset = "0x152DE68", VA = "0x152DE68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817CC8", Offset = "0x817CC8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x152DE74", Offset = "0x152DE74", VA = "0x152DE74", Slot = "4")]
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x152DFA0", Offset = "0x152DFA0", VA = "0x152DFA0")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600066B")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600066C")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600066D")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x152E088", Offset = "0x152E088", VA = "0x152E088")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000C8")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40005E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8124DC", Offset = "0x8124DC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40005E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812514", Offset = "0x812514")]
				public float weight;

				[Token(Token = "0x40005E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000673")]
				[Address(RVA = "0x1E5D114", Offset = "0x1E5D114", VA = "0x1E5D114")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000674")]
				[Address(RVA = "0x1E5D1A4", Offset = "0x1E5D1A4", VA = "0x1E5D1A4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000675")]
				[Address(RVA = "0x1E5D1B8", Offset = "0x1E5D1B8", VA = "0x1E5D1B8")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812434", Offset = "0x812434")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81246C", Offset = "0x81246C")]
			public int upDirCurveIndex;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8124A4", Offset = "0x8124A4")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x152E09C", Offset = "0x152E09C", VA = "0x152E09C", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x152E24C", Offset = "0x152E24C", VA = "0x152E24C", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x152E2B8", Offset = "0x152E2B8", VA = "0x152E2B8", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x152E458", Offset = "0x152E458", VA = "0x152E458")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000CA")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40005EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8125BC", Offset = "0x8125BC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40005EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8125F4", Offset = "0x8125F4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8125F4", Offset = "0x8125F4")]
				public float weight;

				[Token(Token = "0x40005EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40005ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600067B")]
				[Address(RVA = "0x1E5D1C0", Offset = "0x1E5D1C0", VA = "0x1E5D1C0")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600067C")]
				[Address(RVA = "0x1E5D29C", Offset = "0x1E5D29C", VA = "0x1E5D29C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600067D")]
				[Address(RVA = "0x1E5D2A8", Offset = "0x1E5D2A8", VA = "0x1E5D2A8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81254C", Offset = "0x81254C")]
			public int curveIndex;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812584", Offset = "0x812584")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Rigidbody rigidbody;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3 comAxis;

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x152E474", Offset = "0x152E474", VA = "0x152E474", Slot = "4")]
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x152E600", Offset = "0x152E600", VA = "0x152E600", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x152E6E4", Offset = "0x152E6E4", VA = "0x152E6E4", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x152E750", Offset = "0x152E750", VA = "0x152E750", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x152E9A8", Offset = "0x152E9A8", VA = "0x152E9A8")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8122D8", Offset = "0x8122D8")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812310", Offset = "0x812310")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1C154D8", Offset = "0x1C154D8", VA = "0x1C154D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1C155AC", Offset = "0x1C155AC", VA = "0x1C155AC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1C15818", Offset = "0x1C15818", VA = "0x1C15818")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000CD")]
			public class EffectorLink
			{
				[Token(Token = "0x40005FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812824", Offset = "0x812824")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81285C", Offset = "0x81285C")]
				public float weight;

				[Token(Token = "0x6000684")]
				[Address(RVA = "0x1E5D2EC", Offset = "0x1E5D2EC", VA = "0x1E5D2EC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8126B8", Offset = "0x8126B8")]
			public Transform transform;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8126F0", Offset = "0x8126F0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812728", Offset = "0x812728")]
			public float speed;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812760", Offset = "0x812760")]
			public float acceleration;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812798", Offset = "0x812798")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x812798", Offset = "0x812798")]
			public float matchVelocity;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8127EC", Offset = "0x8127EC")]
			public float gravity;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1CFB60C", Offset = "0x1CFB60C", VA = "0x1CFB60C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1CFB6C4", Offset = "0x1CFB6C4", VA = "0x1CFB6C4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1CFB980", Offset = "0x1CFB980", VA = "0x1CFB980")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812648", Offset = "0x812648")]
		public Body[] bodies;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812680", Offset = "0x812680")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1C3168C", Offset = "0x1C3168C", VA = "0x1C3168C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1C31708", Offset = "0x1C31708", VA = "0x1C31708", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1C317C8", Offset = "0x1C317C8", VA = "0x1C317C8")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x812894", Offset = "0x812894")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812894", Offset = "0x812894")]
		public Transform target;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8128F4", Offset = "0x8128F4")]
		public float weight;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81290C", Offset = "0x81290C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812944", Offset = "0x812944")]
		public float weightSmoothTime;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81297C", Offset = "0x81297C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x81297C", Offset = "0x81297C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8129DC", Offset = "0x8129DC")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812A14", Offset = "0x812A14")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812A4C", Offset = "0x812A4C")]
		public float slerpSpeed;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812A84", Offset = "0x812A84")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812ABC", Offset = "0x812ABC")]
		public float minDistance;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x812AF4", Offset = "0x812AF4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x812AF4", Offset = "0x812AF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812AF4", Offset = "0x812AF4")]
		public float maxRootAngle;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000B7")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1B0A9E0", Offset = "0x1B0A9E0", VA = "0x1B0A9E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1B0A96C", Offset = "0x1B0A96C", VA = "0x1B0A96C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1B0AA70", Offset = "0x1B0AA70", VA = "0x1B0AA70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1B0AFB4", Offset = "0x1B0AFB4", VA = "0x1B0AFB4")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1B0B0A0", Offset = "0x1B0B0A0", VA = "0x1B0B0A0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1B0B298", Offset = "0x1B0B298", VA = "0x1B0B298")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812BE0", Offset = "0x812BE0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812C18", Offset = "0x812C18")]
			public float spring;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812C50", Offset = "0x812C50")]
			public bool x;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812C88", Offset = "0x812C88")]
			public bool y;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812CC0", Offset = "0x812CC0")]
			public bool z;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812CF8", Offset = "0x812CF8")]
			public float minX;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812D30", Offset = "0x812D30")]
			public float maxX;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812D68", Offset = "0x812D68")]
			public float minY;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812DA0", Offset = "0x812DA0")]
			public float maxY;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812DD8", Offset = "0x812DD8")]
			public float minZ;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812E10", Offset = "0x812E10")]
			public float maxZ;

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1E5701C", Offset = "0x1E5701C", VA = "0x1E5701C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1E57174", Offset = "0x1E57174", VA = "0x1E57174")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1E571EC", Offset = "0x1E571EC", VA = "0x1E571EC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1E57244", Offset = "0x1E57244", VA = "0x1E57244")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809D20", Offset = "0x809D20")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600069A")]
				[Address(RVA = "0x1E56FCC", Offset = "0x1E56FCC", VA = "0x1E56FCC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600069C")]
				[Address(RVA = "0x1E57014", Offset = "0x1E57014", VA = "0x1E57014", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x1E56E2C", Offset = "0x1E56E2C", VA = "0x1E56E2C")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1E56E58", Offset = "0x1E56E58", VA = "0x1E56E58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1E56E5C", Offset = "0x1E56E5C", VA = "0x1E56E5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1E56FD4", Offset = "0x1E56FD4", VA = "0x1E56FD4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812B70", Offset = "0x812B70")]
		public float weight;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812BA8", Offset = "0x812BA8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000B8")]
		protected float deltaTime
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1B0E8F8", Offset = "0x1B0E8F8", VA = "0x1B0E8F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600068C")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1B0D254", Offset = "0x1B0D254", VA = "0x1B0D254", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1B0E924", Offset = "0x1B0E924", VA = "0x1B0E924")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x817CD8", Offset = "0x817CD8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1B0E99C", Offset = "0x1B0E99C", VA = "0x1B0E99C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1B0EA78", Offset = "0x1B0EA78", VA = "0x1B0EA78")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1B0D5E8", Offset = "0x1B0D5E8", VA = "0x1B0D5E8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1B0D72C", Offset = "0x1B0D72C", VA = "0x1B0D72C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809D30", Offset = "0x809D30")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A7")]
				[Address(RVA = "0x1E573EC", Offset = "0x1E573EC", VA = "0x1E573EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x1E57434", Offset = "0x1E57434", VA = "0x1E57434", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x1E5724C", Offset = "0x1E5724C", VA = "0x1E5724C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1E57278", Offset = "0x1E57278", VA = "0x1E57278", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1E5727C", Offset = "0x1E5727C", VA = "0x1E5727C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1E573F4", Offset = "0x1E573F4", VA = "0x1E573F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812E48", Offset = "0x812E48")]
		public float weight;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812E80", Offset = "0x812E80")]
		public VRIK ik;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000BB")]
		protected float deltaTime
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1B0EB38", Offset = "0x1B0EB38", VA = "0x1B0EB38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600069E")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1B0EB64", Offset = "0x1B0EB64", VA = "0x1B0EB64", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1B0EB90", Offset = "0x1B0EB90", VA = "0x1B0EB90")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x817D88", Offset = "0x817D88")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1B0EC08", Offset = "0x1B0EC08", VA = "0x1B0EC08")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1B0ECE4", Offset = "0x1B0ECE4", VA = "0x1B0ECE4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1B0EE14", Offset = "0x1B0EE14", VA = "0x1B0EE14")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class EffectorLink
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1E5743C", Offset = "0x1E5743C", VA = "0x1E5743C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1E57658", Offset = "0x1E57658", VA = "0x1E57658")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1B0EE24", Offset = "0x1B0EE24", VA = "0x1B0EE24")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1B0EEE8", Offset = "0x1B0EEE8", VA = "0x1B0EEE8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1B0EFA4", Offset = "0x1B0EFA4", VA = "0x1B0EFA4")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000D8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000638")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813094", Offset = "0x813094")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000639")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8130CC", Offset = "0x8130CC")]
				public float weight;

				[Token(Token = "0x60006B5")]
				[Address(RVA = "0x1E5D2FC", Offset = "0x1E5D2FC", VA = "0x1E5D2FC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812EF0", Offset = "0x812EF0")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812F28", Offset = "0x812F28")]
			public Transform raycastTo;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812F60", Offset = "0x812F60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x812F60", Offset = "0x812F60")]
			public float raycastRadius;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812FB4", Offset = "0x812FB4")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812FEC", Offset = "0x812FEC")]
			public float smoothTimeIn;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813024", Offset = "0x813024")]
			public float smoothTimeOut;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81305C", Offset = "0x81305C")]
			public LayerMask layers;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1E57660", Offset = "0x1E57660", VA = "0x1E57660")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x1E577A4", Offset = "0x1E577A4", VA = "0x1E577A4")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1E5789C", Offset = "0x1E5789C", VA = "0x1E5789C")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1E57A6C", Offset = "0x1E57A6C", VA = "0x1E57A6C")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812EB8", Offset = "0x812EB8")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1B0FB08", Offset = "0x1B0FB08", VA = "0x1B0FB08", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1B0FB90", Offset = "0x1B0FB90", VA = "0x1B0FB90")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000DB")]
			public class EffectorLink
			{
				[Token(Token = "0x4000658")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813490", Offset = "0x813490")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000659")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8134C8", Offset = "0x8134C8")]
				public float weight;

				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x1E5D304", Offset = "0x1E5D304", VA = "0x1E5D304")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813394", Offset = "0x813394")]
			public Vector3 offset;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8133CC", Offset = "0x8133CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8133CC", Offset = "0x8133CC")]
			public float additivity;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813420", Offset = "0x813420")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813458", Offset = "0x813458")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1E588F0", Offset = "0x1E588F0", VA = "0x1E588F0")]
			public void Start()
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1E58940", Offset = "0x1E58940", VA = "0x1E58940")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1E58B04", Offset = "0x1E58B04", VA = "0x1E58B04")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DC")]
		public enum Handedness
		{
			[Token(Token = "0x400065B")]
			Right,
			[Token(Token = "0x400065C")]
			Left
		}

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813104", Offset = "0x813104")]
		public AimIK aimIK;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81313C", Offset = "0x81313C")]
		public AimIK headIK;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813174", Offset = "0x813174")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8131AC", Offset = "0x8131AC")]
		public Handedness handedness;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8131E4", Offset = "0x8131E4")]
		public bool twoHanded;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81321C", Offset = "0x81321C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813254", Offset = "0x813254")]
		public float magnitudeRandom;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81328C", Offset = "0x81328C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8132C4", Offset = "0x8132C4")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8132FC", Offset = "0x8132FC")]
		public float blendTime;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813334", Offset = "0x813334")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x813334", Offset = "0x813334")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float magnitudeMlp;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float endTime;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion handRotation;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion randomRotation;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float length;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool initiated;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float blendWeight;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float w;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool handRotationsSet;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000BE")]
		public bool isFinished
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x13DD92C", Offset = "0x13DD92C", VA = "0x13DD92C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x13DE40C", Offset = "0x13DE40C", VA = "0x13DE40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x13DE44C", Offset = "0x13DE44C", VA = "0x13DE44C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x13DE3CC", Offset = "0x13DE3CC", VA = "0x13DE3CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x13DE3EC", Offset = "0x13DE3EC", VA = "0x13DE3EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x13DD95C", Offset = "0x13DD95C", VA = "0x13DD95C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x13DD988", Offset = "0x13DD988", VA = "0x13DD988")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x13DDAD0", Offset = "0x13DDAD0", VA = "0x13DDAD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x13DE48C", Offset = "0x13DE48C", VA = "0x13DE48C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x13DE5B8", Offset = "0x13DE5B8", VA = "0x13DE5B8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x13DE680", Offset = "0x13DE680", VA = "0x13DE680", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x13DE870", Offset = "0x13DE870", VA = "0x13DE870")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813500", Offset = "0x813500")]
		public float weight;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813538", Offset = "0x813538")]
		public float offset;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x13E23C4", Offset = "0x13E23C4", VA = "0x13E23C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x13E24CC", Offset = "0x13E24CC", VA = "0x13E24CC")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x13E25B4", Offset = "0x13E25B4", VA = "0x13E25B4")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x13E2908", Offset = "0x13E2908", VA = "0x13E2908")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x13E2940", Offset = "0x13E2940", VA = "0x13E2940")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x13E2A70", Offset = "0x13E2A70", VA = "0x13E2A70")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		public class Settings
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813570", Offset = "0x813570")]
			public float scaleMlp;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8135A8", Offset = "0x8135A8")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8135E0", Offset = "0x8135E0")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813618", Offset = "0x813618")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813650", Offset = "0x813650")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813688", Offset = "0x813688")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8136C0", Offset = "0x8136C0")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8136F8", Offset = "0x8136F8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8136F8", Offset = "0x8136F8")]
			public Vector3 headOffset;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813748", Offset = "0x813748")]
			public Vector3 handOffset;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813780", Offset = "0x813780")]
			public float footForwardOffset;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8137B8", Offset = "0x8137B8")]
			public float footInwardOffset;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8137F0", Offset = "0x8137F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8137F0", Offset = "0x8137F0")]
			public float footHeadingOffset;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81384C", Offset = "0x81384C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813864", Offset = "0x813864")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1E5CA80", Offset = "0x1E5CA80", VA = "0x1E5CA80")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000E1")]
			public class Target
			{
				[Token(Token = "0x400067B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400067C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400067D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x1E5D424", Offset = "0x1E5D424", VA = "0x1E5D424")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x1E5D4E4", Offset = "0x1E5D4E4", VA = "0x1E5D4E4")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1E5CA78", Offset = "0x1E5CA78", VA = "0x1E5CA78")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1525518", Offset = "0x1525518", VA = "0x1525518")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x15255A0", Offset = "0x15255A0", VA = "0x15255A0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x15256D8", Offset = "0x15256D8", VA = "0x15256D8")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x15255EC", Offset = "0x15255EC", VA = "0x15255EC")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1523784", Offset = "0x1523784", VA = "0x1523784")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x15256F0", Offset = "0x15256F0", VA = "0x15256F0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1524A10", Offset = "0x1524A10", VA = "0x1524A10")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1525F34", Offset = "0x1525F34", VA = "0x1525F34")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x152331C", Offset = "0x152331C", VA = "0x152331C")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x15263A4", Offset = "0x15263A4", VA = "0x15263A4")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1526A34", Offset = "0x1526A34", VA = "0x1526A34")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1526800", Offset = "0x1526800", VA = "0x1526800")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1526CB0", Offset = "0x1526CB0", VA = "0x1526CB0")]
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1527000", Offset = "0x1527000", VA = "0x1527000")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x15270F0", Offset = "0x15270F0", VA = "0x15270F0")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000E2")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x152740C", Offset = "0x152740C", VA = "0x152740C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1527468", Offset = "0x1527468", VA = "0x1527468")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x152749C", Offset = "0x152749C", VA = "0x152749C")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x15275D8", Offset = "0x15275D8", VA = "0x15275D8")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81387C", Offset = "0x81387C")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000C3")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1527CE0", Offset = "0x1527CE0", VA = "0x1527CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817E38", Offset = "0x817E38")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x1527CEC", Offset = "0x1527CEC", VA = "0x1527CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817E48", Offset = "0x817E48")]
			private set
			{
			}
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1527CF8", Offset = "0x1527CF8", VA = "0x1527CF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1525D04", Offset = "0x1525D04", VA = "0x1525D04")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x15261E8", Offset = "0x15261E8", VA = "0x15261E8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1527E08", Offset = "0x1527E08", VA = "0x1527E08")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1528224", Offset = "0x1528224", VA = "0x1528224")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1528354", Offset = "0x1528354", VA = "0x1528354")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000E4")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Offset
		{
			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x152A6B4", Offset = "0x152A6B4", VA = "0x152A6B4")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x152A828", Offset = "0x152A828", VA = "0x152A828")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1A3BA64", Offset = "0x1A3BA64", VA = "0x1A3BA64")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1A3BAC0", Offset = "0x1A3BAC0", VA = "0x1A3BAC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1A3BB3C", Offset = "0x1A3BB3C", VA = "0x1A3BB3C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1A3BC20", Offset = "0x1A3BC20", VA = "0x1A3BC20")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x19B8658", Offset = "0x19B8658", VA = "0x19B8658")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x19B86DC", Offset = "0x19B86DC", VA = "0x19B86DC")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81389C", Offset = "0x81389C")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x19B96C4", Offset = "0x19B96C4", VA = "0x19B96C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x19B973C", Offset = "0x19B973C", VA = "0x19B973C")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderFBBIK grounder;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x13E1720", Offset = "0x13E1720", VA = "0x13E1720")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x13E17E4", Offset = "0x13E17E4", VA = "0x13E17E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x13E1A10", Offset = "0x13E1A10", VA = "0x13E1A10")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8138D4", Offset = "0x8138D4")]
		public AimPoser aimPoser;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81390C", Offset = "0x81390C")]
		public AimIK aim;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813944", Offset = "0x813944")]
		public LookAtIK lookAt;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81397C", Offset = "0x81397C")]
		public Animator animator;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8139B4", Offset = "0x8139B4")]
		public float crossfadeTime;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8139EC", Offset = "0x8139EC")]
		public float minAimDistance;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x13E2D48", Offset = "0x13E2D48", VA = "0x13E2D48")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x13E2D8C", Offset = "0x13E2D8C", VA = "0x13E2D8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x13E2E44", Offset = "0x13E2E44", VA = "0x13E2E44")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x13E2FCC", Offset = "0x13E2FCC", VA = "0x13E2FCC")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x13E30F8", Offset = "0x13E30F8", VA = "0x13E30F8")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x13E3174", Offset = "0x13E3174", VA = "0x13E3174")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x13E6DAC", Offset = "0x13E6DAC", VA = "0x13E6DAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x13E6F1C", Offset = "0x13E6F1C", VA = "0x13E6F1C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x13E70B0", Offset = "0x13E70B0", VA = "0x13E70B0")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x813A24", Offset = "0x813A24")]
		public Animator animator;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x813A5C", Offset = "0x813A5C")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813A94", Offset = "0x813A94")]
		public float lookAtWeight;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813AAC", Offset = "0x813AAC")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813AC4", Offset = "0x813AC4")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813ADC", Offset = "0x813ADC")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813AF4", Offset = "0x813AF4")]
		public float lookAtClampWeight;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813B0C", Offset = "0x813B0C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813B24", Offset = "0x813B24")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x813B3C", Offset = "0x813B3C")]
		public Transform footTargetBiped;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813B74", Offset = "0x813B74")]
		public float footPositionWeight;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813B8C", Offset = "0x813B8C")]
		public float footRotationWeight;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x813BA4", Offset = "0x813BA4")]
		public Transform handTargetBiped;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813BDC", Offset = "0x813BDC")]
		public float handPositionWeight;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813BF4", Offset = "0x813BF4")]
		public float handRotationWeight;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x19C0EDC", Offset = "0x19C0EDC", VA = "0x19C0EDC")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x19C12E4", Offset = "0x19C12E4", VA = "0x19C12E4")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813C0C", Offset = "0x813C0C")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000C4")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x1B0B4A0", Offset = "0x1B0B4A0", VA = "0x1B0B4A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817E58", Offset = "0x817E58")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1B0B4AC", Offset = "0x1B0B4AC", VA = "0x1B0B4AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817E68", Offset = "0x817E68")]
			private set
			{
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1B0B4B8", Offset = "0x1B0B4B8", VA = "0x1B0B4B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1B0B4F4", Offset = "0x1B0B4F4", VA = "0x1B0B4F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1B0BD68", Offset = "0x1B0BD68", VA = "0x1B0BD68")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1B0BB18", Offset = "0x1B0BB18", VA = "0x1B0BB18")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1B0BE64", Offset = "0x1B0BE64", VA = "0x1B0BE64")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000C5")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1B0BE90", Offset = "0x1B0BE90", VA = "0x1B0BE90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1B0BF14", Offset = "0x1B0BF14", VA = "0x1B0BF14")]
		private void Update()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1B0C138", Offset = "0x1B0C138", VA = "0x1B0C138")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809D40", Offset = "0x809D40")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600071B")]
				[Address(RVA = "0x1CFD8C4", Offset = "0x1CFD8C4", VA = "0x1CFD8C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600071D")]
				[Address(RVA = "0x1CFD90C", Offset = "0x1CFD90C", VA = "0x1CFD90C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1CFD5C8", Offset = "0x1CFD5C8", VA = "0x1CFD5C8")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1CFD5F4", Offset = "0x1CFD5F4", VA = "0x1CFD5F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1CFD5F8", Offset = "0x1CFD5F8", VA = "0x1CFD5F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1CFD8CC", Offset = "0x1CFD8CC", VA = "0x1CFD8CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000C6")]
		public bool isStepping
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1B0C14C", Offset = "0x1B0C14C", VA = "0x1B0C14C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C7")]
		public Vector3 position
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1B0BE30", Offset = "0x1B0BE30", VA = "0x1B0BE30")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1B0C160", Offset = "0x1B0C160", VA = "0x1B0C160")]
			set
			{
			}
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1B0C1B0", Offset = "0x1B0C1B0", VA = "0x1B0C1B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1B0C3DC", Offset = "0x1B0C3DC", VA = "0x1B0C3DC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1B0C578", Offset = "0x1B0C578", VA = "0x1B0C578")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1B0C7AC", Offset = "0x1B0C7AC", VA = "0x1B0C7AC")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1B0CA20", Offset = "0x1B0CA20", VA = "0x1B0CA20")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1B0CB98", Offset = "0x1B0CB98", VA = "0x1B0CB98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1B0C6F8", Offset = "0x1B0C6F8", VA = "0x1B0C6F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x817E78", Offset = "0x817E78")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1B0CD94", Offset = "0x1B0CD94", VA = "0x1B0CD94")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1B0CDF8", Offset = "0x1B0CDF8", VA = "0x1B0CDF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1B0CEC8", Offset = "0x1B0CEC8", VA = "0x1B0CEC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1B0D11C", Offset = "0x1B0D11C", VA = "0x1B0D11C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F2")]
		public struct Warp
		{
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813CDC", Offset = "0x813CDC")]
			public int animationLayer;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813D14", Offset = "0x813D14")]
			public string animationState;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813D4C", Offset = "0x813D4C")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813D84", Offset = "0x813D84")]
			public Transform warpFrom;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813DBC", Offset = "0x813DBC")]
			public Transform warpTo;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813DF4", Offset = "0x813DF4")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000F3")]
		public enum EffectorMode
		{
			[Token(Token = "0x40006FB")]
			PositionOffset,
			[Token(Token = "0x40006FC")]
			Position
		}

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813C1C", Offset = "0x813C1C")]
		public Animator animator;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813C54", Offset = "0x813C54")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x813C8C", Offset = "0x813C8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813C8C", Offset = "0x813C8C")]
		public Warp[] warps;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x19B98C4", Offset = "0x19B98C4", VA = "0x19B98C4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x19B98F0", Offset = "0x19B98F0", VA = "0x19B98F0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x19B9B30", Offset = "0x19B9B30", VA = "0x19B9B30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x19B9DF4", Offset = "0x19B9DF4", VA = "0x19B9DF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x19B9E94", Offset = "0x19B9E94", VA = "0x19B9E94")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x19B9E9C", Offset = "0x19B9E9C", VA = "0x19B9E9C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x19B9EF8", Offset = "0x19B9EF8", VA = "0x19B9EF8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x19BA094", Offset = "0x19BA094", VA = "0x19BA094", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x19BA29C", Offset = "0x19BA29C", VA = "0x19BA29C")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813E2C", Offset = "0x813E2C")]
		public float headLookWeight;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x19BA2B0", Offset = "0x19BA2B0", VA = "0x19BA2B0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x19BA47C", Offset = "0x19BA47C", VA = "0x19BA47C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x19BA4F8", Offset = "0x19BA4F8", VA = "0x19BA4F8")]
		private void Read()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x19BA5EC", Offset = "0x19BA5EC", VA = "0x19BA5EC")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x19BA634", Offset = "0x19BA634", VA = "0x19BA634")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x19BAA20", Offset = "0x19BAA20", VA = "0x19BAA20")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x19BA8A8", Offset = "0x19BA8A8", VA = "0x19BA8A8")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x19BAC7C", Offset = "0x19BAC7C", VA = "0x19BAC7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x19BADAC", Offset = "0x19BADAC", VA = "0x19BADAC")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x19CAE94", Offset = "0x19CAE94", VA = "0x19CAE94", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x19CAEF8", Offset = "0x19CAEF8", VA = "0x19CAEF8", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x19CB134", Offset = "0x19CB134", VA = "0x19CB134")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x19CB228", Offset = "0x19CB228", VA = "0x19CB228")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000CA")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x19CBC84", Offset = "0x19CBC84", VA = "0x19CBC84")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000CB")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x19CBD08", Offset = "0x19CBD08", VA = "0x19CBD08")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x19CBA84", Offset = "0x19CBA84", VA = "0x19CBA84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x19CBAF8", Offset = "0x19CBAF8", VA = "0x19CBAF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x19CBD8C", Offset = "0x19CBD8C", VA = "0x19CBD8C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813E44", Offset = "0x813E44")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1A3405C", Offset = "0x1A3405C", VA = "0x1A3405C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1A344BC", Offset = "0x1A344BC", VA = "0x1A344BC")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1A34D78", Offset = "0x1A34D78", VA = "0x1A34D78")]
		private void Start()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1A34E34", Offset = "0x1A34E34", VA = "0x1A34E34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1A351B8", Offset = "0x1A351B8", VA = "0x1A351B8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1A35264", Offset = "0x1A35264", VA = "0x1A35264")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Limb
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x152A180", Offset = "0x152A180", VA = "0x152A180")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x152A204", Offset = "0x152A204", VA = "0x152A204")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1A38CF8", Offset = "0x1A38CF8", VA = "0x1A38CF8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1A38E50", Offset = "0x1A38E50", VA = "0x1A38E50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1A38EF4", Offset = "0x1A38EF4", VA = "0x1A38EF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1A38EF8", Offset = "0x1A38EF8", VA = "0x1A38EF8")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1A38F08", Offset = "0x1A38F08", VA = "0x1A38F08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1A38F7C", Offset = "0x1A38F7C", VA = "0x1A38F7C")]
		private void Update()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1A3905C", Offset = "0x1A3905C", VA = "0x1A3905C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813E5C", Offset = "0x813E5C")]
		public Transform target;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813E94", Offset = "0x813E94")]
		public Transform pin;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813ECC", Offset = "0x813ECC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813F04", Offset = "0x813F04")]
		public AimIK aim;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813F3C", Offset = "0x813F3C")]
		public float weight;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813F74", Offset = "0x813F74")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813FAC", Offset = "0x813FAC")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1A39064", Offset = "0x1A39064", VA = "0x1A39064")]
		private void Start()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1A390C0", Offset = "0x1A390C0", VA = "0x1A390C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1A39264", Offset = "0x1A39264", VA = "0x1A39264")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1A3B3EC", Offset = "0x1A3B3EC", VA = "0x1A3B3EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1A3B4C4", Offset = "0x1A3B4C4", VA = "0x1A3B4C4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1A3B554", Offset = "0x1A3B554", VA = "0x1A3B554")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1A3B92C", Offset = "0x1A3B92C", VA = "0x1A3B92C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1A3BA5C", Offset = "0x1A3BA5C", VA = "0x1A3BA5C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813FE4", Offset = "0x813FE4")]
		public float aimWeight;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x813FFC", Offset = "0x813FFC")]
		public float sightWeight;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x814014", Offset = "0x814014")]
		public float maxAngle;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x814030", Offset = "0x814030")]
		public float cameraRecoilWeight;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1A3BC28", Offset = "0x1A3BC28", VA = "0x1A3BC28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1A3BDEC", Offset = "0x1A3BDEC", VA = "0x1A3BDEC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1A3BDF8", Offset = "0x1A3BDF8", VA = "0x1A3BDF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1A3C078", Offset = "0x1A3C078", VA = "0x1A3C078")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1A3C34C", Offset = "0x1A3C34C", VA = "0x1A3C34C")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1A3BEC0", Offset = "0x1A3BEC0", VA = "0x1A3BEC0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1A3CC40", Offset = "0x1A3CC40", VA = "0x1A3CC40")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x814048", Offset = "0x814048")]
		public float walkSpeed;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1A3CC60", Offset = "0x1A3CC60", VA = "0x1A3CC60")]
		private void Start()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1A3CCEC", Offset = "0x1A3CCEC", VA = "0x1A3CCEC")]
		private void Update()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1A3CDD8", Offset = "0x1A3CDD8", VA = "0x1A3CDD8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1A3CE90", Offset = "0x1A3CE90", VA = "0x1A3CE90")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1C15180", Offset = "0x1C15180", VA = "0x1C15180")]
		private void Update()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1C152E4", Offset = "0x1C152E4", VA = "0x1C152E4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1C154C8", Offset = "0x1C154C8", VA = "0x1C154C8")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1C15B78", Offset = "0x1C15B78", VA = "0x1C15B78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1C15CC0", Offset = "0x1C15CC0", VA = "0x1C15CC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1C15FFC", Offset = "0x1C15FFC", VA = "0x1C15FFC")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1C318EC", Offset = "0x1C318EC", VA = "0x1C318EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1C31A28", Offset = "0x1C31A28", VA = "0x1C31A28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1C31B34", Offset = "0x1C31B34", VA = "0x1C31B34")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1C31B3C", Offset = "0x1C31B3C", VA = "0x1C31B3C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1C32268", Offset = "0x1C32268", VA = "0x1C32268")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814060", Offset = "0x814060")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814098", Offset = "0x814098")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1B08FAC", Offset = "0x1B08FAC", VA = "0x1B08FAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1B09008", Offset = "0x1B09008", VA = "0x1B09008")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1B09340", Offset = "0x1B09340", VA = "0x1B09340")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class Partner
		{
			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000CC")]
			private Transform neck
			{
				[Token(Token = "0x6000771")]
				[Address(RVA = "0x1CFD55C", Offset = "0x1CFD55C", VA = "0x1CFD55C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1CFCE10", Offset = "0x1CFCE10", VA = "0x1CFCE10")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1CFCE30", Offset = "0x1CFCE30", VA = "0x1CFCE30")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1CFD3C8", Offset = "0x1CFD3C8", VA = "0x1CFD3C8")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1CFD5B4", Offset = "0x1CFD5B4", VA = "0x1CFD5B4")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1B09F0C", Offset = "0x1B09F0C", VA = "0x1B09F0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1B09F48", Offset = "0x1B09F48", VA = "0x1B09F48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1B09FB0", Offset = "0x1B09FB0", VA = "0x1B09FB0")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public enum Mode
		{
			[Token(Token = "0x4000788")]
			Position,
			[Token(Token = "0x4000789")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		public class Absorber
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8141B0", Offset = "0x8141B0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8141E8", Offset = "0x8141E8")]
			public float weight;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1CFD914", Offset = "0x1CFD914", VA = "0x1CFD914")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x1CFD9FC", Offset = "0x1CFD9FC", VA = "0x1CFD9FC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1CFDA38", Offset = "0x1CFDA38", VA = "0x1CFDA38")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1CFDAD0", Offset = "0x1CFDAD0", VA = "0x1CFDAD0")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1CFDB44", Offset = "0x1CFDB44", VA = "0x1CFDB44")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8140D0", Offset = "0x8140D0")]
		public Mode mode;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814108", Offset = "0x814108")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814140", Offset = "0x814140")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814178", Offset = "0x814178")]
		public float falloffSpeed;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1B0D158", Offset = "0x1B0D158", VA = "0x1B0D158", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1B0D280", Offset = "0x1B0D280", VA = "0x1B0D280")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1B0D310", Offset = "0x1B0D310", VA = "0x1B0D310", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1B0D424", Offset = "0x1B0D424", VA = "0x1B0D424")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1B0D4B0", Offset = "0x1B0D4B0", VA = "0x1B0D4B0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1B0D718", Offset = "0x1B0D718", VA = "0x1B0D718")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1B0D73C", Offset = "0x1B0D73C", VA = "0x1B0D73C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1B0D7B8", Offset = "0x1B0D7B8", VA = "0x1B0D7B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1B0D894", Offset = "0x1B0D894", VA = "0x1B0D894")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1B0D954", Offset = "0x1B0D954", VA = "0x1B0D954")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public class EffectorLink
		{
			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1E56E1C", Offset = "0x1E56E1C", VA = "0x1E56E1C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814220", Offset = "0x814220")]
		public Transform anchor;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 posRelToAnchor;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion rotRelToAnchor;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1B0E410", Offset = "0x1B0E410", VA = "0x1B0E410", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1B0E630", Offset = "0x1B0E630", VA = "0x1B0E630", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1B0E7BC", Offset = "0x1B0E7BC", VA = "0x1B0E7BC")]
		public void Anchor()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1B0E8BC", Offset = "0x1B0E8BC", VA = "0x1B0E8BC")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814268", Offset = "0x814268")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x814268", Offset = "0x814268")]
		public float weight;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8142BC", Offset = "0x8142BC")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8142F4", Offset = "0x8142F4")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814340", Offset = "0x814340")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1B0F1B0", Offset = "0x1B0F1B0", VA = "0x1B0F1B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1B0F480", Offset = "0x1B0F480", VA = "0x1B0F480")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1B0FAC8", Offset = "0x1B0FAC8", VA = "0x1B0FAC8")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000CD")]
		private bool holding
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1B100A4", Offset = "0x1B100A4", VA = "0x1B100A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		private bool holdingLeft
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1B10188", Offset = "0x1B10188", VA = "0x1B10188")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		private bool holdingRight
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1B100DC", Offset = "0x1B100DC", VA = "0x1B100DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1B0FBA0", Offset = "0x1B0FBA0", VA = "0x1B0FBA0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600078C")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1B10234", Offset = "0x1B10234", VA = "0x1B10234")]
		private void Start()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1B103EC", Offset = "0x1B103EC", VA = "0x1B103EC")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1B10570", Offset = "0x1B10570", VA = "0x1B10570")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1B1064C", Offset = "0x1B1064C", VA = "0x1B1064C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1B1078C", Offset = "0x1B1078C", VA = "0x1B1078C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1B108FC", Offset = "0x1B108FC", VA = "0x1B108FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1B10B0C", Offset = "0x1B10B0C", VA = "0x1B10B0C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1B10B20", Offset = "0x1B10B20", VA = "0x1B10B20", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1B10C7C", Offset = "0x1B10C7C", VA = "0x1B10C7C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1B10C90", Offset = "0x1B10C90", VA = "0x1B10C90", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1B10DC4", Offset = "0x1B10DC4", VA = "0x1B10DC4")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x13DD468", Offset = "0x13DD468", VA = "0x13DD468")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x13DD548", Offset = "0x13DD548", VA = "0x13DD548")]
		private void Update()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x13DD65C", Offset = "0x13DD65C", VA = "0x13DD65C")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x13DE8DC", Offset = "0x13DE8DC", VA = "0x13DE8DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x13DE938", Offset = "0x13DE938", VA = "0x13DE938")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x13DE990", Offset = "0x13DE990", VA = "0x13DE990")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x13DEA70", Offset = "0x13DEA70", VA = "0x13DEA70")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809D50", Offset = "0x809D50")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A9")]
				[Address(RVA = "0x1E58D0C", Offset = "0x1E58D0C", VA = "0x1E58D0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AB")]
				[Address(RVA = "0x1E58D54", Offset = "0x1E58D54", VA = "0x1E58D54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1E58B18", Offset = "0x1E58B18", VA = "0x1E58B18")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x1E58B44", Offset = "0x1E58B44", VA = "0x1E58B44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x1E58B48", Offset = "0x1E58B48", VA = "0x1E58B48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x1E58D14", Offset = "0x1E58D14", VA = "0x1E58D14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x13DEA80", Offset = "0x13DEA80", VA = "0x13DEA80")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x13DEB48", Offset = "0x13DEB48", VA = "0x13DEB48")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x13DEBAC", Offset = "0x13DEBAC", VA = "0x13DEBAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x817F28", Offset = "0x817F28")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x13DEC34", Offset = "0x13DEC34", VA = "0x13DEC34")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809D60", Offset = "0x809D60")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0x1E592A4", Offset = "0x1E592A4", VA = "0x1E592A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0x1E592EC", Offset = "0x1E592EC", VA = "0x1E592EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x1E59134", Offset = "0x1E59134", VA = "0x1E59134")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x1E59160", Offset = "0x1E59160", VA = "0x1E59160", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x1E59164", Offset = "0x1E59164", VA = "0x1E59164", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x1E592AC", Offset = "0x1E592AC", VA = "0x1E592AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x13E3E3C", Offset = "0x13E3E3C", VA = "0x13E3E3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x13E3EF4", Offset = "0x13E3EF4", VA = "0x13E3EF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x817FD8", Offset = "0x817FD8")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x13E3F6C", Offset = "0x13E3F6C", VA = "0x13E3F6C")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class EffectorLink
		{
			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1E5A598", Offset = "0x1E5A598", VA = "0x1E5A598")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x1E5A880", Offset = "0x1E5A880", VA = "0x1E5A880")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x1E5A96C", Offset = "0x1E5A96C", VA = "0x1E5A96C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1E5AE00", Offset = "0x1E5AE00", VA = "0x1E5AE00")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1E5AEF4", Offset = "0x1E5AEF4", VA = "0x1E5AEF4")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1E5AF8C", Offset = "0x1E5AF8C", VA = "0x1E5AF8C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1E5B020", Offset = "0x1E5B020", VA = "0x1E5B020")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1E5B0B4", Offset = "0x1E5B0B4", VA = "0x1E5B0B4")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1E5B280", Offset = "0x1E5B280", VA = "0x1E5B280")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x151EE50", Offset = "0x151EE50", VA = "0x151EE50")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x151EECC", Offset = "0x151EECC", VA = "0x151EECC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x151EF3C", Offset = "0x151EF3C", VA = "0x151EF3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x151F004", Offset = "0x151F004", VA = "0x151F004")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81438C", Offset = "0x81438C")]
		public Transform to;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8143C4", Offset = "0x8143C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8143C4", Offset = "0x8143C4")]
		public float transferMotion;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x151F00C", Offset = "0x151F00C", VA = "0x151F00C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x151F048", Offset = "0x151F048", VA = "0x151F048")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x151F0FC", Offset = "0x151F0FC", VA = "0x151F0FC")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x814418", Offset = "0x814418")]
		public float weight;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814430", Offset = "0x814430")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814468", Offset = "0x814468")]
		public Poser leftHandPoser;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8144A0", Offset = "0x8144A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8144A0", Offset = "0x8144A0")]
		public float leftHandWeight;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1520768", Offset = "0x1520768", VA = "0x1520768")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1520938", Offset = "0x1520938", VA = "0x1520938")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1520B84", Offset = "0x1520B84", VA = "0x1520B84")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1520D28", Offset = "0x1520D28", VA = "0x1520D28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1520E58", Offset = "0x1520E58", VA = "0x1520E58")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1521190", Offset = "0x1521190", VA = "0x1521190", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x152151C", Offset = "0x152151C", VA = "0x152151C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1521788", Offset = "0x1521788", VA = "0x1521788")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1A41338", Offset = "0x1A41338", VA = "0x1A41338")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1A41660", Offset = "0x1A41660", VA = "0x1A41660")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1A416E0", Offset = "0x1A416E0", VA = "0x1A416E0")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809D70", Offset = "0x809D70")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D9")]
				[Address(RVA = "0x1E57BCC", Offset = "0x1E57BCC", VA = "0x1E57BCC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x1E57C14", Offset = "0x1E57C14", VA = "0x1E57C14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1E57A80", Offset = "0x1E57A80", VA = "0x1E57A80")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1E57AAC", Offset = "0x1E57AAC", VA = "0x1E57AAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1E57AB0", Offset = "0x1E57AB0", VA = "0x1E57AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1E57BD4", Offset = "0x1E57BD4", VA = "0x1E57BD4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1B10DD8", Offset = "0x1B10DD8", VA = "0x1B10DD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1B10F1C", Offset = "0x1B10F1C", VA = "0x1B10F1C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1B10EA4", Offset = "0x1B10EA4", VA = "0x1B10EA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x818088", Offset = "0x818088")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1B110A0", Offset = "0x1B110A0", VA = "0x1B110A0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1B1118C", Offset = "0x1B1118C", VA = "0x1B1118C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1B11274", Offset = "0x1B11274", VA = "0x1B11274")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8144F4", Offset = "0x8144F4")]
		public float weight;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x19BFB3C", Offset = "0x19BFB3C", VA = "0x19BFB3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x19BFBB0", Offset = "0x19BFBB0", VA = "0x19BFBB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x19BFC68", Offset = "0x19BFC68", VA = "0x19BFC68")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000122")]
		public class Part
		{
			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1E5B2BC", Offset = "0x1E5B2BC", VA = "0x1E5B2BC")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1E5B3FC", Offset = "0x1E5B3FC", VA = "0x1E5B3FC")]
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

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x151F4F0", Offset = "0x151F4F0", VA = "0x151F4F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x151F56C", Offset = "0x151F56C", VA = "0x151F56C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000123")]
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

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1C15820", Offset = "0x1C15820", VA = "0x1C15820")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1C15984", Offset = "0x1C15984", VA = "0x1C15984")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1C15B68", Offset = "0x1C15B68", VA = "0x1C15B68")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class VRController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
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

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1522844", Offset = "0x1522844", VA = "0x1522844")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x15229D4", Offset = "0x15229D4", VA = "0x15229D4")]
		private Vector3 GetInput()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1522B94", Offset = "0x1522B94", VA = "0x1522B94")]
		public VRController()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81450C", Offset = "0x81450C")]
		public VRIK ik;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814544", Offset = "0x814544")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81457C", Offset = "0x81457C")]
		public Transform headTracker;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8145B4", Offset = "0x8145B4")]
		public Transform bodyTracker;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8145EC", Offset = "0x8145EC")]
		public Transform leftHandTracker;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814624", Offset = "0x814624")]
		public Transform rightHandTracker;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81465C", Offset = "0x81465C")]
		public Transform leftFootTracker;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814694", Offset = "0x814694")]
		public Transform rightFootTracker;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8146CC", Offset = "0x8146CC")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1523604", Offset = "0x1523604", VA = "0x1523604")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1525530", Offset = "0x1525530", VA = "0x1525530")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x15275F0", Offset = "0x15275F0", VA = "0x15275F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x152764C", Offset = "0x152764C", VA = "0x152764C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x15277D4", Offset = "0x15277D4", VA = "0x15277D4")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1527808", Offset = "0x1527808", VA = "0x1527808")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1527CA4", Offset = "0x1527CA4", VA = "0x1527CA4")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000D6")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x19CA090", Offset = "0x19CA090", VA = "0x19CA090", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x19CA06C", Offset = "0x19CA06C", VA = "0x19CA06C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x19CA098", Offset = "0x19CA098", VA = "0x19CA098")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x19CA0FC", Offset = "0x19CA0FC", VA = "0x19CA0FC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x19CA294", Offset = "0x19CA294", VA = "0x19CA294", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x19CA4B8", Offset = "0x19CA4B8", VA = "0x19CA4B8", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x19CA2A4", Offset = "0x19CA2A4", VA = "0x19CA2A4")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x19CA4C8", Offset = "0x19CA4C8", VA = "0x19CA4C8")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x19CA4E0", Offset = "0x19CA4E0", VA = "0x19CA4E0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x19CA544", Offset = "0x19CA544", VA = "0x19CA544", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x19CA5E0", Offset = "0x19CA5E0", VA = "0x19CA5E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x19CA6F8", Offset = "0x19CA6F8", VA = "0x19CA6F8")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x814734", Offset = "0x814734")]
		private float animSpeedMultiplier;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x400083C")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x400083D")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000D7")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x19CA7B8", Offset = "0x19CA7B8", VA = "0x19CA7B8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x19CA710", Offset = "0x19CA710", VA = "0x19CA710", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x19CA79C", Offset = "0x19CA79C", VA = "0x19CA79C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x19CA8B0", Offset = "0x19CA8B0", VA = "0x19CA8B0", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x19CAC94", Offset = "0x19CAC94", VA = "0x19CAC94")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x19CAE70", Offset = "0x19CAE70", VA = "0x19CAE70")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x814778", Offset = "0x814778")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814778", Offset = "0x814778")]
		public Transform gravityTarget;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8147D8", Offset = "0x8147D8")]
		public float gravityMultiplier;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x400084B")]
		protected const float half = 0.5f;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000802")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x19CB24C", Offset = "0x19CB24C", VA = "0x19CB24C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x19CB37C", Offset = "0x19CB37C", VA = "0x19CB37C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x19CB564", Offset = "0x19CB564", VA = "0x19CB564", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x19CB714", Offset = "0x19CB714", VA = "0x19CB714")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x19CB778", Offset = "0x19CB778", VA = "0x19CB778")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x19CB898", Offset = "0x19CB898", VA = "0x19CB898")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x19CB9BC", Offset = "0x19CB9BC", VA = "0x19CB9BC")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x19CB9E0", Offset = "0x19CB9E0", VA = "0x19CB9E0")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x19CBA04", Offset = "0x19CBA04", VA = "0x19CBA04")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x19CBA64", Offset = "0x19CBA64", VA = "0x19CBA64")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public enum MoveMode
		{
			[Token(Token = "0x400088A")]
			Directional,
			[Token(Token = "0x400088B")]
			Strafe
		}

		[Token(Token = "0x200012F")]
		public struct AnimState
		{
			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809D80", Offset = "0x809D80")]
		private sealed class <JumpSmooth>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000824")]
				[Address(RVA = "0x1529A18", Offset = "0x1529A18", VA = "0x1529A18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000826")]
				[Address(RVA = "0x1529A60", Offset = "0x1529A60", VA = "0x1529A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x15298E8", Offset = "0x15298E8", VA = "0x15298E8")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x1529914", Offset = "0x1529914", VA = "0x1529914", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x1529918", Offset = "0x1529918", VA = "0x1529918", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x1529A20", Offset = "0x1529A20", VA = "0x1529A20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x814810", Offset = "0x814810")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x814848", Offset = "0x814848")]
		public MoveMode moveMode;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x814880", Offset = "0x814880")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8148B8", Offset = "0x8148B8")]
		public bool smoothJump;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8148F0", Offset = "0x8148F0")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x814928", Offset = "0x814928")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814960", Offset = "0x814960")]
		private bool <fullRootMotion>k__BackingField;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814970", Offset = "0x814970")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000D8")]
		public bool fullRootMotion
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x19CBDE0", Offset = "0x19CBDE0", VA = "0x19CBDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818138", Offset = "0x818138")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x19CBDE8", Offset = "0x19CBDE8", VA = "0x19CBDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818148", Offset = "0x818148")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public bool onGround
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x19CBDF4", Offset = "0x19CBDF4", VA = "0x19CBDF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818158", Offset = "0x818158")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x19CBDFC", Offset = "0x19CBDFC", VA = "0x19CBDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818168", Offset = "0x818168")]
			private set
			{
			}
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x19CBE08", Offset = "0x19CBE08", VA = "0x19CBE08", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x19CBF70", Offset = "0x19CBF70", VA = "0x19CBF70")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x19CC000", Offset = "0x19CC000", VA = "0x19CC000", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x19CC0C8", Offset = "0x19CC0C8", VA = "0x19CC0C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x19CCD14", Offset = "0x19CCD14", VA = "0x19CCD14", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x19CCF6C", Offset = "0x19CCF6C", VA = "0x19CCF6C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x19CC5DC", Offset = "0x19CC5DC", VA = "0x19CC5DC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x19CD048", Offset = "0x19CD048", VA = "0x19CD048")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x19CD4F0", Offset = "0x19CD4F0", VA = "0x19CD4F0")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x19CCD9C", Offset = "0x19CCD9C", VA = "0x19CCD9C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x19CD598", Offset = "0x19CD598", VA = "0x19CD598", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x19CD8D4", Offset = "0x19CD8D4", VA = "0x19CD8D4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x19CD9C4", Offset = "0x19CD9C4", VA = "0x19CD9C4", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x19CDB24", Offset = "0x19CDB24", VA = "0x19CDB24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x818178", Offset = "0x818178")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x19CC960", Offset = "0x19CC960", VA = "0x19CC960")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x19CDBC0", Offset = "0x19CDBC0", VA = "0x19CDBC0")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000132")]
		public enum RotationMode
		{
			[Token(Token = "0x40008A7")]
			Smooth,
			[Token(Token = "0x40008A8")]
			Linear
		}

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814980", Offset = "0x814980")]
		public CameraController cameraController;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8149B8", Offset = "0x8149B8")]
		public float accelerationTime;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8149F0", Offset = "0x8149F0")]
		public float turnTime;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814A28", Offset = "0x814A28")]
		public bool walkByDefault;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814A60", Offset = "0x814A60")]
		public RotationMode rotationMode;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814A98", Offset = "0x814A98")]
		public float moveSpeed;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814AD0", Offset = "0x814AD0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000DC")]
		public bool isGrounded
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x13E3188", Offset = "0x13E3188", VA = "0x13E3188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818228", Offset = "0x818228")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x13E3190", Offset = "0x13E3190", VA = "0x13E3190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818238", Offset = "0x818238")]
			private set
			{
			}
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x13E319C", Offset = "0x13E319C", VA = "0x13E319C")]
		private void Start()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x13E3240", Offset = "0x13E3240", VA = "0x13E3240")]
		private void Update()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x13E3700", Offset = "0x13E3700", VA = "0x13E3700")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x13E3294", Offset = "0x13E3294", VA = "0x13E3294")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x13E3514", Offset = "0x13E3514", VA = "0x13E3514")]
		private void Move()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x13E373C", Offset = "0x13E373C", VA = "0x13E373C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x13E37D8", Offset = "0x13E37D8", VA = "0x13E37D8")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x13E385C", Offset = "0x13E385C", VA = "0x13E385C")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1520EF4", Offset = "0x1520EF4", VA = "0x1520EF4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x1520F78", Offset = "0x1520F78", VA = "0x1520F78", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x152113C", Offset = "0x152113C", VA = "0x152113C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1521164", Offset = "0x1521164", VA = "0x1521164")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		public struct State
		{
			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1520F38", Offset = "0x1520F38", VA = "0x1520F38", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x1521280", Offset = "0x1521280", VA = "0x1521280", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x1521180", Offset = "0x1521180", VA = "0x1521180")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x19BAF3C", Offset = "0x19BAF3C", VA = "0x19BAF3C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x19BAF78", Offset = "0x19BAF78", VA = "0x19BAF78")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x13E3D44", Offset = "0x13E3D44", VA = "0x13E3D44")]
		private void Update()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x13E3D78", Offset = "0x13E3D78", VA = "0x13E3D78")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x13E3E28", Offset = "0x13E3E28", VA = "0x13E3E28")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000138")]
	public class Navigator
	{
		[Token(Token = "0x2000139")]
		public enum State
		{
			[Token(Token = "0x40008CA")]
			Idle,
			[Token(Token = "0x40008CB")]
			Seeking,
			[Token(Token = "0x40008CC")]
			OnPath
		}

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814AE0", Offset = "0x814AE0")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814B18", Offset = "0x814B18")]
		public float cornerRadius;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814B50", Offset = "0x814B50")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814B88", Offset = "0x814B88")]
		public float maxSampleDistance;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814BC0", Offset = "0x814BC0")]
		public float nextPathInterval;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814BF8", Offset = "0x814BF8")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814C08", Offset = "0x814C08")]
		private State <state>k__BackingField;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000DD")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x1B0D968", Offset = "0x1B0D968", VA = "0x1B0D968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818248", Offset = "0x818248")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x1B0D974", Offset = "0x1B0D974", VA = "0x1B0D974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818258", Offset = "0x818258")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public State state
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1B0D980", Offset = "0x1B0D980", VA = "0x1B0D980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818268", Offset = "0x818268")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1B0D988", Offset = "0x1B0D988", VA = "0x1B0D988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818278", Offset = "0x818278")]
			private set
			{
			}
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1B0D990", Offset = "0x1B0D990", VA = "0x1B0D990")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1B0DA64", Offset = "0x1B0DA64", VA = "0x1B0DA64")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1B0DE64", Offset = "0x1B0DE64", VA = "0x1B0DE64")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1B0DEE0", Offset = "0x1B0DEE0", VA = "0x1B0DEE0")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1B0DE20", Offset = "0x1B0DE20", VA = "0x1B0DE20")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1B0DE50", Offset = "0x1B0DE50", VA = "0x1B0DE50")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1B0E02C", Offset = "0x1B0E02C", VA = "0x1B0E02C")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x1B0E1DC", Offset = "0x1B0E1DC", VA = "0x1B0E1DC")]
		public Navigator()
		{
		}
	}
}
namespace Febucci.Attributes
{
	[Token(Token = "0x200013A")]
	public class CharsDisplayTimeAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1A31AC0", Offset = "0x1A31AC0", VA = "0x1A31AC0")]
		public CharsDisplayTimeAttribute()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class MinValueAttribute : PropertyAttribute
	{
		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float min;

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1B0D124", Offset = "0x1B0D124", VA = "0x1B0D124")]
		public MinValueAttribute(float min)
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class NotZeroAttribute : PropertyAttribute
	{
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1B0E250", Offset = "0x1B0E250", VA = "0x1B0E250")]
		public NotZeroAttribute()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class PositiveValueAttribute : PropertyAttribute
	{
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1B11354", Offset = "0x1B11354", VA = "0x1B11354")]
		public PositiveValueAttribute()
		{
		}
	}
}
namespace Febucci.UI
{
	[Token(Token = "0x200013E")]
	public static class TAnimTags
	{
		[Token(Token = "0x40008CE")]
		public const string bh_Shake = "shake";

		[Token(Token = "0x40008CF")]
		public const string bh_Rot = "rot";

		[Token(Token = "0x40008D0")]
		public const string bh_Wiggle = "wiggle";

		[Token(Token = "0x40008D1")]
		public const string bh_Wave = "wave";

		[Token(Token = "0x40008D2")]
		public const string bh_Swing = "swing";

		[Token(Token = "0x40008D3")]
		public const string bh_Incr = "incr";

		[Token(Token = "0x40008D4")]
		public const string bh_Slide = "slide";

		[Token(Token = "0x40008D5")]
		public const string bh_Bounce = "bounce";

		[Token(Token = "0x40008D6")]
		public const string bh_Fade = "fade";

		[Token(Token = "0x40008D7")]
		public const string bh_Rainb = "rainb";

		[Token(Token = "0x40008D8")]
		public const string bh_Dangle = "dangle";

		[Token(Token = "0x40008D9")]
		public const string bh_Pendulum = "pend";

		[Token(Token = "0x40008DA")]
		public const string ap_Size = "size";

		[Token(Token = "0x40008DB")]
		public const string ap_Fade = "fade";

		[Token(Token = "0x40008DC")]
		public const string ap_Offset = "offset";

		[Token(Token = "0x40008DD")]
		public const string ap_VertExp = "vertexp";

		[Token(Token = "0x40008DE")]
		public const string ap_HoriExp = "horiexp";

		[Token(Token = "0x40008DF")]
		public const string ap_DiagExp = "diagexp";

		[Token(Token = "0x40008E0")]
		public const string ap_Rot = "rot";

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] defaultBehaviors;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string[] defaultAppearances;
	}
	[Token(Token = "0x200013F")]
	public struct TypewriterAction
	{
		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string actionID;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<string> parameters;
	}
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809D90", Offset = "0x809D90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809D90", Offset = "0x809D90")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x809D90", Offset = "0x809D90")]
	[DisallowMultipleComponent]
	public class TextAnimator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000141")]
		public struct TimeData
		{
			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814DEC", Offset = "0x814DEC")]
			private float <timeSinceStart>k__BackingField;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814DFC", Offset = "0x814DFC")]
			private float <deltaTime>k__BackingField;

			[Token(Token = "0x170000EA")]
			public float timeSinceStart
			{
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x1E5A444", Offset = "0x1E5A444", VA = "0x1E5A444")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8183F0", Offset = "0x8183F0")]
				readonly get
				{
					return default(float);
				}
				[Token(Token = "0x6000893")]
				[Address(RVA = "0x1E5A44C", Offset = "0x1E5A44C", VA = "0x1E5A44C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818428", Offset = "0x818428")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			public float deltaTime
			{
				[Token(Token = "0x6000894")]
				[Address(RVA = "0x1E5A454", Offset = "0x1E5A454", VA = "0x1E5A454")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818438", Offset = "0x818438")]
				readonly get
				{
					return default(float);
				}
				[Token(Token = "0x6000895")]
				[Address(RVA = "0x1E5A45C", Offset = "0x1E5A45C", VA = "0x1E5A45C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818470", Offset = "0x818470")]
				private set
				{
				}
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1E5A464", Offset = "0x1E5A464", VA = "0x1E5A464")]
			internal void ResetData()
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1E5A46C", Offset = "0x1E5A46C", VA = "0x1E5A46C")]
			internal void IncreaseTime()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1E5A47C", Offset = "0x1E5A47C", VA = "0x1E5A47C")]
			internal void UpdateDeltaTime(TimeScale timeScale)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000142")]
		private class AppearancesContainer
		{
			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x814E0C", Offset = "0x814E0C")]
			[SerializeField]
			public string[] tagsFallback_Appearances;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] tagsFallback_Disappearances;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AppearanceDefaultValues values;

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x1E59F18", Offset = "0x1E59F18", VA = "0x1E59F18")]
			public AppearancesContainer()
			{
			}
		}

		[Token(Token = "0x2000143")]
		internal struct InternalAction
		{
			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TypewriterAction action;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int charIndex;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool triggered;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int internalOrder;
		}

		[Token(Token = "0x2000144")]
		private enum ShowTextMode : byte
		{
			[Token(Token = "0x4000924")]
			Hidden,
			[Token(Token = "0x4000925")]
			Shown,
			[Token(Token = "0x4000926")]
			UserTyping
		}

		[Token(Token = "0x2000145")]
		public enum TimeScale
		{
			[Token(Token = "0x4000928")]
			Scaled,
			[Token(Token = "0x4000929")]
			Unscaled
		}

		[Token(Token = "0x2000146")]
		public delegate void MessageEvent(string message);

		[StructLayout(3)]
		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809E48", Offset = "0x809E48")]
		private struct <>c__DisplayClass105_0
		{
			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string richTextTag;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int realTextIndex;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TextAnimator <>4__this;
		}

		[StructLayout(3)]
		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809E58", Offset = "0x809E58")]
		private struct <>c__DisplayClass113_0
		{
			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StringBuilder temp_realText;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string text;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string entireTag;
		}

		[StructLayout(3)]
		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809E68", Offset = "0x809E68")]
		private struct <>c__DisplayClass113_1
		{
			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int realTextIndex;
		}

		[StructLayout(3)]
		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809E78", Offset = "0x809E78")]
		private struct <>c__DisplayClass114_0
		{
			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;
		}

		[StructLayout(3)]
		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809E88", Offset = "0x809E88")]
		private struct <>c__DisplayClass117_0
		{
			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float intensity;
		}

		[StructLayout(3)]
		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809E98", Offset = "0x809E98")]
		private struct <>c__DisplayClass121_0
		{
			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;
		}

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TAnimPlayerBase _tAnimPlayer;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814C18", Offset = "0x814C18")]
		[SerializeField]
		private bool triggerAnimPlayerOnChange;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float effectIntensityMultiplier;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x814C74", Offset = "0x814C74")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x814C74", Offset = "0x814C74")]
		[SerializeField]
		private AppearancesContainer appearancesContainer;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] tags_fallbackBehaviors;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BehaviorDefaultValues behaviorValues;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuiltinBehaviorsDataScriptable scriptable_globalBehaviorsValues;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuiltinAppearancesDataScriptable scriptable_globalAppearancesValues;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814D24", Offset = "0x814D24")]
		[SerializeField]
		private bool useDynamicScaling;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814D70", Offset = "0x814D70")]
		[SerializeField]
		private float referenceFontSize;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TMP_Text _tmproText;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TimeScale timeScale;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string latestText;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814DCC", Offset = "0x814DCC")]
		private TMP_CharacterInfo <latestCharacterShown>k__BackingField;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private TimeData m_time;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool forceMeshRefresh;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F9")]
		private bool skipAppearanceEffects;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FA")]
		private bool hasParentCanvas;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Canvas parentCanvas;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private bool autoSize;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private Rect sourceRect;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private Color sourceColor;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private int _maxVisibleCharacters;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private int _firstVisibleCharacter;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private bool hasText;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x235")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x814DDC", Offset = "0x814DDC")]
		private bool <hasActions>k__BackingField;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private int latestTriggeredEvent;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private int latestTriggeredAction;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private TMP_TextInfo textInfo;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private Character[] characters;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private List<BehaviorBase> behaviorEffects;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private List<AppearanceBase> appearanceEffects;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private List<AppearanceBase> disappearanceEffects;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private AppearanceBase[] fallbackAppearanceEffects;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private AppearanceBase[] fallbackDisappearanceEffects;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private BehaviorBase[] fallbackBehaviorEffects;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private List<InternalAction> typewriterActions;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private List<EventMarker> eventMarkers;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool enabled_globalAppearances;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool enabled_globalBehaviors;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool enabled_localBehaviors;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x291")]
		private bool enabled_localAppearances;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x292")]
		private bool databaseBuilt;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Dictionary<string, Type> localBehaviors;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Dictionary<string, Type> localAppearances;

		[Token(Token = "0x4000913")]
		private const char m_closureSymbol = '/';

		[Token(Token = "0x4000914")]
		private const char m_eventSymbol = '?';

		[Token(Token = "0x4000915")]
		private const char m_disappearanceSymbol = '#';

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool noparseEnabled;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private int internalEventActionIndex;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private List<int> temp_effectsToApply;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private int tmpFirstVisibleCharacter;

		[Token(Token = "0x170000DF")]
		private TAnimPlayerBase tAnimPlayer
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x13E7204", Offset = "0x13E7204", VA = "0x13E7204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		public TMP_Text tmproText
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x13E1BD4", Offset = "0x13E1BD4", VA = "0x13E1BD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x13E7334", Offset = "0x13E7334", VA = "0x13E7334")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public string text
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x13E747C", Offset = "0x13E747C", VA = "0x13E747C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x13E7484", Offset = "0x13E7484", VA = "0x13E7484")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public bool allLettersShown
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x13E748C", Offset = "0x13E748C", VA = "0x13E748C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		public TMP_CharacterInfo latestCharacterShown
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x13E74C8", Offset = "0x13E74C8", VA = "0x13E74C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8182A8", Offset = "0x8182A8")]
			get
			{
				return default(TMP_CharacterInfo);
			}
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x13E74D8", Offset = "0x13E74D8", VA = "0x13E74D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8182B8", Offset = "0x8182B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public TimeData time
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x13E7508", Offset = "0x13E7508", VA = "0x13E7508")]
			get
			{
				return default(TimeData);
			}
		}

		[Token(Token = "0x170000E5")]
		public int maxVisibleCharacters
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x13E7514", Offset = "0x13E7514", VA = "0x13E7514")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x13E61B8", Offset = "0x13E61B8", VA = "0x13E61B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public int firstVisibleCharacter
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x13E75F0", Offset = "0x13E75F0", VA = "0x13E75F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x13E5FEC", Offset = "0x13E5FEC", VA = "0x13E5FEC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		internal bool hasActions
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x13E75F8", Offset = "0x13E75F8", VA = "0x13E75F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8182C8", Offset = "0x8182C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x13E7600", Offset = "0x13E7600", VA = "0x13E7600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8182D8", Offset = "0x8182D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public static bool effectsBehaviorsEnabled
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x13E8E40", Offset = "0x13E8E40", VA = "0x13E8E40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public static bool effectsAppearancesEnabled
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x13E8EA4", Offset = "0x13E8EA4", VA = "0x13E8EA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event MessageEvent onEvent
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x13E733C", Offset = "0x13E733C", VA = "0x13E733C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818288", Offset = "0x818288")]
			add
			{
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x13E73DC", Offset = "0x13E73DC", VA = "0x13E73DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818298", Offset = "0x818298")]
			remove
			{
			}
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x13E70E0", Offset = "0x13E70E0", VA = "0x13E70E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x13E75AC", Offset = "0x13E75AC", VA = "0x13E75AC")]
		private bool IsCharacterVisible(int i)
		{
			return default(bool);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x13E751C", Offset = "0x13E751C", VA = "0x13E751C")]
		private void AssertCharacterTimes()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x13E5FD0", Offset = "0x13E5FD0", VA = "0x13E5FD0")]
		public void SetText(string text, bool hideText)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x13E7960", Offset = "0x13E7960", VA = "0x13E7960")]
		public void AppendText(string text, bool hideText)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x13E88AC", Offset = "0x13E88AC", VA = "0x13E88AC")]
		public bool TryGetNextCharacter(out TMP_CharacterInfo result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x13E8944", Offset = "0x13E8944", VA = "0x13E8944")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8182E8", Offset = "0x8182E8")]
		public char IncreaseVisibleChars()
		{
			return default(char);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x13E8970", Offset = "0x13E8970", VA = "0x13E8970")]
		public void ShowAllCharacters(bool skipAppearanceEffects)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x13E89AC", Offset = "0x13E89AC", VA = "0x13E89AC")]
		public void TriggerRemainingEvents()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x13E8AE0", Offset = "0x13E8AE0", VA = "0x13E8AE0")]
		public void ForceMeshRefresh()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x13E8AEC", Offset = "0x13E8AEC", VA = "0x13E8AEC")]
		public void TriggerVisibleEvents()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x13E8D50", Offset = "0x13E8D50", VA = "0x13E8D50")]
		public void ResetEffectsTime(bool skipAppearances)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x13E8F08", Offset = "0x13E8F08", VA = "0x13E8F08")]
		public static void EnableAllEffects(bool enabled)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x13E8FF8", Offset = "0x13E8FF8", VA = "0x13E8FF8")]
		public static void EnableAppearances(bool enabled)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x13E9064", Offset = "0x13E9064", VA = "0x13E9064")]
		public static void EnableBehaviors(bool enabled)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x13E90D0", Offset = "0x13E90D0", VA = "0x13E90D0")]
		public void EnableBehaviorsLocally(bool value)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x13E90DC", Offset = "0x13E90DC", VA = "0x13E90DC")]
		public void EnableAppearancesLocally(bool value)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x13E90E8", Offset = "0x13E90E8", VA = "0x13E90E8")]
		private void BuildTagsDatabase()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x13E9C3C", Offset = "0x13E9C3C", VA = "0x13E9C3C")]
		private bool TryGetBehaviorClassFromTag(string tag, string entireRichTextTag, int regionStartIndex, out BehaviorBase effectBase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x13E9D6C", Offset = "0x13E9D6C", VA = "0x13E9D6C")]
		private bool TryGetAppearingClassFromTag(string tag, string entireRichTextTag, int startIndex, out AppearanceBase effectBase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x13E9E84", Offset = "0x13E9E84", VA = "0x13E9E84")]
		private bool TryProcessingAppearanceTag(string richTextTag, int realTextIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000876")]
		private void TryProcessingModifier<T>(string[] tags, ref T effect) where T : EffectsBase
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x13EA1DC", Offset = "0x13EA1DC", VA = "0x13EA1DC")]
		private bool TryProcessingBehaviorTag(string richTextTag, string loweredRichTextTag, int realTextIndex, ref int internalEventActionIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x13EA544", Offset = "0x13EA544", VA = "0x13EA544")]
		private bool TryProcessingActionTag(string entireTag, int realTextIndex, ref int internalEventActionIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x13E760C", Offset = "0x13E760C", VA = "0x13E760C")]
		private void _SetText(string text, ShowTextMode showTextMode)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x13E7A04", Offset = "0x13E7A04", VA = "0x13E7A04")]
		private string _FormatText(string text, int startCharacterIndex)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x13E7D90", Offset = "0x13E7D90", VA = "0x13E7D90")]
		private void _ApplyTextToCharacters(string text)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x13E8AF4", Offset = "0x13E8AF4", VA = "0x13E8AF4")]
		private void TryTriggeringEvent(int maxInternalOrder)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x13EB0A0", Offset = "0x13EB0A0", VA = "0x13EB0A0")]
		internal bool TryGetAction(out TypewriterAction action)
		{
			return default(bool);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x13EABCC", Offset = "0x13EABCC", VA = "0x13EABCC")]
		private void SetupEffectsIntensity()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x13EADC4", Offset = "0x13EADC4", VA = "0x13EADC4")]
		private void CopyMeshSources()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x13EB2C8", Offset = "0x13EB2C8", VA = "0x13EB2C8")]
		private void UpdateMesh()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x13EB518", Offset = "0x13EB518", VA = "0x13EB518")]
		private void Update()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x13EBF84", Offset = "0x13EBF84", VA = "0x13EBF84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x13EBF90", Offset = "0x13EBF90", VA = "0x13EBF90")]
		public TextAnimator()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x13E97F8", Offset = "0x13E97F8", VA = "0x13E97F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818320", Offset = "0x818320")]
		private AppearanceBase[] <BuildTagsDatabase>g__GetFallbackAppearancesFromTag|99_0(string[] tagsToConvert)
		{
			return null;
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x13EA018", Offset = "0x13EA018", VA = "0x13EA018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818330", Offset = "0x818330")]
		private bool <TryProcessingAppearanceTag>g__ProcessOpeningTag|105_0(List<AppearanceBase> effectsList, ref <>c__DisplayClass105_0 P_1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x13EA914", Offset = "0x13EA914", VA = "0x13EA914")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818340", Offset = "0x818340")]
		private void <_SetText>g__HideCharacter|112_0(int i)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x13EA7E8", Offset = "0x13EA7E8", VA = "0x13EA7E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818350", Offset = "0x818350")]
		private void <_SetText>g__HideAllCharacters|112_1()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x13EA86C", Offset = "0x13EA86C", VA = "0x13EA86C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818360", Offset = "0x818360")]
		private void <_SetText>g__ShowAllCharacters|112_2()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x13EAB70", Offset = "0x13EAB70", VA = "0x13EAB70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818370", Offset = "0x818370")]
		internal static void <_FormatText>g__AppendCurrentCharacterToText|113_0(ref <>c__DisplayClass113_0 P_0, ref <>c__DisplayClass113_1 P_1)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x13EA9C4", Offset = "0x13EA9C4", VA = "0x13EA9C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818380", Offset = "0x818380")]
		internal static bool <_FormatText>g__TryGetClosingCharacter|113_1(out char _closingCharacter, ref <>c__DisplayClass113_0 P_1, ref <>c__DisplayClass113_1 P_2)
		{
			return default(bool);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x13EAB20", Offset = "0x13EAB20", VA = "0x13EAB20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818390", Offset = "0x818390")]
		internal static void <_FormatText>g__AppendCurrentTagToText|113_2(ref <>c__DisplayClass113_0 P_0, ref <>c__DisplayClass113_1 P_1)
		{
		}

		[Token(Token = "0x600088D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8183A0", Offset = "0x8183A0")]
		private void <_ApplyTextToCharacters>g__SetEffectsDependency|114_0<T>(ref int[] indexes, List<T> effects, int fallbackEffectsCount, ref <>c__DisplayClass114_0 P_3) where T : EffectsBase
		{
		}

		[Token(Token = "0x600088E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8183B0", Offset = "0x8183B0")]
		internal static void <_ApplyTextToCharacters>g__AssignFallbackEffect|114_1<T>(T[] effect, ref int[] indexes) where T : EffectsBase
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x13EACC4", Offset = "0x13EACC4", VA = "0x13EACC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8183C0", Offset = "0x8183C0")]
		internal static float <_ApplyTextToCharacters>g__CalculateAppearanceDuration|114_2(int[] effectsIndex, List<AppearanceBase> effects)
		{
			return default(float);
		}

		[Token(Token = "0x6000890")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8183D0", Offset = "0x8183D0")]
		internal static void <SetupEffectsIntensity>g__SetEffectsIntensity|117_0<T>(List<T> effects, ref <>c__DisplayClass117_0 P_1) where T : EffectsBase
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x13EBE20", Offset = "0x13EBE20", VA = "0x13EBE20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8183E0", Offset = "0x8183E0")]
		private void <Update>g__TryApplyingBehaviors|121_0(ref <>c__DisplayClass121_0 P_0)
		{
		}
	}
	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809EA8", Offset = "0x809EA8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x809EA8", Offset = "0x809EA8")]
	public class TextAnimatorPlayer : TAnimPlayerBase
	{
		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x809F08", Offset = "0x809F08")]
		private sealed class <WaitInput>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000EC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A6")]
				[Address(RVA = "0x1E5A548", Offset = "0x1E5A548", VA = "0x1E5A548", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A8")]
				[Address(RVA = "0x1E5A590", Offset = "0x1E5A590", VA = "0x1E5A590", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1E5A4BC", Offset = "0x1E5A4BC", VA = "0x1E5A4BC")]
			[DebuggerHidden]
			public <WaitInput>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1E5A4E8", Offset = "0x1E5A4E8", VA = "0x1E5A4E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1E5A4EC", Offset = "0x1E5A4EC", VA = "0x1E5A4EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1E5A550", Offset = "0x1E5A550", VA = "0x1E5A550", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814E58", Offset = "0x814E58")]
		[CharsDisplayTime]
		public float waitForNormalChars;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814EB4", Offset = "0x814EB4")]
		[SerializeField]
		[CharsDisplayTime]
		public float waitLong;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[CharsDisplayTime]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814F10", Offset = "0x814F10")]
		public float waitMiddle;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814F6C", Offset = "0x814F6C")]
		[SerializeField]
		private bool avoidMultiplePunctuactionWait;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x814FB8", Offset = "0x814FB8")]
		[SerializeField]
		private bool waitForNewLines;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x815004", Offset = "0x815004")]
		private bool waitForLastCharacter;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x815050", Offset = "0x815050")]
		private bool useTypewriterWaitForDisappearances;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[CharsDisplayTime]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81509C", Offset = "0x81509C")]
		private float disappearanceWaitTime;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8150F8", Offset = "0x8150F8")]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x8150F8", Offset = "0x8150F8")]
		[SerializeField]
		private float disappearanceSpeedMultiplier;

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x151E1B0", Offset = "0x151E1B0", VA = "0x151E1B0", Slot = "5")]
		protected override float GetWaitAppearanceTimeOf(char character)
		{
			return default(float);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x151E394", Offset = "0x151E394", VA = "0x151E394", Slot = "7")]
		protected override float GetWaitDisappearanceTimeOf(char character)
		{
			return default(float);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x151E3DC", Offset = "0x151E3DC", VA = "0x151E3DC", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x818480", Offset = "0x818480")]
		protected override IEnumerator WaitInput()
		{
			return null;
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x151E438", Offset = "0x151E438", VA = "0x151E438")]
		public TextAnimatorPlayer()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x151E37C", Offset = "0x151E37C", VA = "0x151E37C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8184E0", Offset = "0x8184E0")]
		internal static bool <GetWaitAppearanceTimeOf>g__IsUnicodeNewLine|9_0(ulong unicode)
		{
			return default(bool);
		}
	}
}
namespace Febucci.UI.Examples
{
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x809F18", Offset = "0x809F18")]
	public class AppearanceTemplate : AppearanceBase
	{
		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 vert;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float pct;

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x19BAF20", Offset = "0x19BAF20", VA = "0x19BAF20", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x19BAF24", Offset = "0x19BAF24", VA = "0x19BAF24", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x19BAF28", Offset = "0x19BAF28", VA = "0x19BAF28")]
		public AppearanceTemplate()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x809F50", Offset = "0x809F50")]
	public class BehaviorTemplate : BehaviorBase
	{
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x19BFB28", Offset = "0x19BFB28", VA = "0x19BFB28", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x19BFB2C", Offset = "0x19BFB2C", VA = "0x19BFB2C", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x19BFB30", Offset = "0x19BFB30", VA = "0x19BFB30", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x19BFB34", Offset = "0x19BFB34", VA = "0x19BFB34")]
		public BehaviorTemplate()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809F88", Offset = "0x809F88")]
	public class DefaultEffectsExample : MonoBehaviour
	{
		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAnimatorPlayer textAnimatorPlayer;

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x1A325CC", Offset = "0x1A325CC", VA = "0x1A325CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x1A325D0", Offset = "0x1A325D0", VA = "0x1A325D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x1A32EB0", Offset = "0x1A32EB0", VA = "0x1A32EB0")]
		public DefaultEffectsExample()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809FC0", Offset = "0x809FC0")]
	public class EffectsTesting : MonoBehaviour
	{
		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAnimatorPlayer textAnimatorPlayer;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x1A34654", Offset = "0x1A34654", VA = "0x1A34654")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1A346B0", Offset = "0x1A346B0", VA = "0x1A346B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1A329F8", Offset = "0x1A329F8", VA = "0x1A329F8")]
		public static string AddEffect(string tag)
		{
			return null;
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1A32C54", Offset = "0x1A32C54", VA = "0x1A32C54")]
		public static string AddAppearanceEffect(string tag)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1A346B4", Offset = "0x1A346B4", VA = "0x1A346B4")]
		public void ShowText()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1A34838", Offset = "0x1A34838", VA = "0x1A34838")]
		public EffectsTesting()
		{
		}
	}
	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x809FF8", Offset = "0x809FF8")]
	public class EventExample : MonoBehaviour
	{
		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAnimatorPlayer textAnimatorPlayer;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera cam;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int lastBGIndex;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color[] bgColors;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1A34BF8", Offset = "0x1A34BF8", VA = "0x1A34BF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1A34CA0", Offset = "0x1A34CA0", VA = "0x1A34CA0")]
		private void OnEvent(string message)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1A34D70", Offset = "0x1A34D70", VA = "0x1A34D70")]
		public EventExample()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80A030", Offset = "0x80A030")]
	public class UsageExample : MonoBehaviour
	{
		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAnimatorPlayer textAnimatorPlayer;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x81515C", Offset = "0x81515C")]
		[SerializeField]
		private string textToShow;

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1520E6C", Offset = "0x1520E6C", VA = "0x1520E6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1520E70", Offset = "0x1520E70", VA = "0x1520E70")]
		private void Start()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1520E74", Offset = "0x1520E74", VA = "0x1520E74")]
		public void ShowText()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1520E98", Offset = "0x1520E98", VA = "0x1520E98")]
		public UsageExample()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x80A068", Offset = "0x80A068")]
	public class SetTextOnEnable : MonoBehaviour
	{
		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAnimatorPlayer tanimPlayer;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string textToSet;

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x13E1A18", Offset = "0x13E1A18", VA = "0x13E1A18")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x13E1E54", Offset = "0x13E1E54", VA = "0x13E1E54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x13E1E74", Offset = "0x13E1E74", VA = "0x13E1E74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x13E1F94", Offset = "0x13E1F94", VA = "0x13E1F94")]
		public SetTextOnEnable()
		{
		}
	}
}
namespace Febucci.UI.Core
{
	[Token(Token = "0x2000156")]
	internal struct Character
	{
		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal bool initialized;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float disappearancesMaxDuration;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool isDisappearing;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool wantsToDisappear;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float appearancesMaxDuration;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] indexBehaviorEffects;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] indexAppearanceEffects;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] indexDisappearanceEffects;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CharacterSourceData sources;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CharacterData data;

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x19C9EEC", Offset = "0x19C9EEC", VA = "0x19C9EEC")]
		public void ResetVertices()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x19C9F70", Offset = "0x19C9F70", VA = "0x19C9F70")]
		public void ResetColors()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x19C9FE4", Offset = "0x19C9FE4", VA = "0x19C9FE4")]
		public void Hide()
		{
		}
	}
	[Token(Token = "0x2000157")]
	internal struct CharacterSourceData
	{
		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color32[] colors;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3[] vertices;
	}
	[Token(Token = "0x2000158")]
	public struct CharacterData
	{
		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float passedTime;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Color32[] colors;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] vertices;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_CharacterInfo tmp_CharInfo;
	}
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x80A0A0", Offset = "0x80A0A0")]
	public sealed class EffectInfoAttribute : Attribute
	{
		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string tag;

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x1A34028", Offset = "0x1A34028", VA = "0x1A34028")]
		public EffectInfoAttribute(string tag)
		{
		}
	}
	[Token(Token = "0x200015A")]
	public abstract class EffectsBase
	{
		[Token(Token = "0x200015B")]
		internal class RegionManager
		{
			[Token(Token = "0x200015C")]
			private struct TextRegion
			{
				[Token(Token = "0x4000962")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int startIndex;

				[Token(Token = "0x4000963")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public int endIndex;

				[Token(Token = "0x60008D9")]
				[Address(RVA = "0x1E5CED4", Offset = "0x1E5CED4", VA = "0x1E5CED4")]
				public TextRegion(int startIndex)
				{
				}
			}

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string entireRichTextTag;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<TextRegion> textRegions;

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x1529A68", Offset = "0x1529A68", VA = "0x1529A68")]
			internal bool IsLastRegionClosed()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1529AE8", Offset = "0x1529AE8", VA = "0x1529AE8")]
			internal void AddRegion(int startIndex)
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x1529B68", Offset = "0x1529B68", VA = "0x1529B68")]
			internal bool TryReutilizingWithTag(string richTextTag, int indexNewRegionStart)
			{
				return default(bool);
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x1529BC4", Offset = "0x1529BC4", VA = "0x1529BC4")]
			internal void CloseEffect(int index)
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x1529C74", Offset = "0x1529C74", VA = "0x1529C74")]
			internal bool IsCharInsideRegion(int charIndex)
			{
				return default(bool);
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x1529DC4", Offset = "0x1529DC4", VA = "0x1529DC4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x1529FFC", Offset = "0x1529FFC", VA = "0x1529FFC")]
			public RegionManager()
			{
			}
		}

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81519C", Offset = "0x81519C")]
		private string <effectTag>k__BackingField;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float uniformIntensity;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal RegionManager regionManager;

		[Token(Token = "0x170000EE")]
		public string effectTag
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1A344C4", Offset = "0x1A344C4", VA = "0x1A344C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818540", Offset = "0x818540")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1A344CC", Offset = "0x1A344CC", VA = "0x1A344CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818550", Offset = "0x818550")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x818B98", Offset = "0x818B98")]
		public float effectIntensity
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1A344D4", Offset = "0x1A344D4", VA = "0x1A344D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1A344DC", Offset = "0x1A344DC", VA = "0x1A344DC")]
		internal void _Initialize(string effectTag, string entireRichTextTag)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1A34578", Offset = "0x1A34578", VA = "0x1A34578")]
		protected void ApplyModifierTo(ref float value, string modifierValue)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1A3463C", Offset = "0x1A3463C", VA = "0x1A3463C", Slot = "4")]
		public virtual void Initialize(int charactersCount)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1A34640", Offset = "0x1A34640", VA = "0x1A34640", Slot = "5")]
		public virtual void Calculate()
		{
		}

		[Token(Token = "0x60008CF")]
		public abstract void ApplyEffect(ref CharacterData data, int charIndex);

		[Token(Token = "0x60008D0")]
		public abstract void SetModifier(string modifierName, string modifierValue);

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x1A34644", Offset = "0x1A34644", VA = "0x1A34644")]
		protected EffectsBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015D")]
	public class AppearanceDefaultValues
	{
		[Serializable]
		[Token(Token = "0x200015E")]
		public class Defaults
		{
			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[PositiveValue]
			public float sizeDuration;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x815254", Offset = "0x815254")]
			public float sizeAmplitude;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[PositiveValue]
			public float fadeDuration;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[PositiveValue]
			public float verticalExpandDuration;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool verticalFromBottom;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[PositiveValue]
			public float horizontalExpandDuration;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			internal HorizontalExpandAppearance.ExpType horizontalExpandStart;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[PositiveValue]
			public float diagonalExpandDuration;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool diagonalFromBttmLeft;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[NotZero]
			public Vector2 offsetDir;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[PositiveValue]
			public float offsetDuration;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[NotZero]
			public float offsetAmplitude;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[PositiveValue]
			public float rotationDuration;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float rotationStartAngle;

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x1529328", Offset = "0x1529328", VA = "0x1529328")]
			public Defaults()
			{
			}
		}

		[Token(Token = "0x4000964")]
		private const float defDuration = 0.3f;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8151AC", Offset = "0x8151AC")]
		public Defaults defaults;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8151F8", Offset = "0x8151F8")]
		internal PresetAppearanceValues[] presets;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x19BAE80", Offset = "0x19BAE80", VA = "0x19BAE80")]
		public AppearanceDefaultValues()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015F")]
	public class BehaviorDefaultValues
	{
		[Serializable]
		[Token(Token = "0x2000160")]
		public class Defaults
		{
			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NotZero]
			public float wiggleAmplitude;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[NotZero]
			public float wiggleFrequency;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NotZero]
			public float waveFrequency;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[NotZero]
			public float waveAmplitude;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float waveWaveSize;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[NotZero]
			public float angleSpeed;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float angleDiffBetweenChars;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[NotZero]
			public float swingAmplitude;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[NotZero]
			public float swingFrequency;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float swingWaveSize;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[NotZero]
			public float shakeStrength;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[PositiveValue]
			public float shakeDelay;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float sizeAmplitude;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[NotZero]
			public float sizeFrequency;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float sizeWaveSize;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[NotZero]
			public float slideAmplitude;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[NotZero]
			public float slideFrequency;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float slideWaveSize;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[NotZero]
			public float bounceAmplitude;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[NotZero]
			public float bounceFrequency;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float bounceWaveSize;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[NotZero]
			public float hueShiftSpeed;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float hueShiftWaveSize;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[PositiveValue]
			public float fadeDelay;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[NotZero]
			public float dangleAmplitude;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[NotZero]
			public float dangleFrequency;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public float dangleWaveSize;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public bool dangleAnchorBottom;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[NotZero]
			public float pendAmplitude;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[NotZero]
			public float pendFrequency;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public float pendWaveSize;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public bool pendInverted;

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x15297D0", Offset = "0x15297D0", VA = "0x15297D0")]
			public Defaults()
			{
			}
		}

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8152F8", Offset = "0x8152F8")]
		public Defaults defaults;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x815344", Offset = "0x815344")]
		internal PresetBehaviorValues[] presets;

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x19BF6F0", Offset = "0x19BF6F0", VA = "0x19BF6F0")]
		public BehaviorDefaultValues()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x80A0D4", Offset = "0x80A0D4")]
	public class BuiltinAppearancesDataScriptable : BuiltinDataScriptableBase<AppearanceDefaultValues.Defaults>
	{
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x19C8C24", Offset = "0x19C8C24", VA = "0x19C8C24")]
		public BuiltinAppearancesDataScriptable()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x80A134", Offset = "0x80A134")]
	public class BuiltinBehaviorsDataScriptable : BuiltinDataScriptableBase<BehaviorDefaultValues.Defaults>
	{
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x19C8C70", Offset = "0x19C8C70", VA = "0x19C8C70")]
		public BuiltinBehaviorsDataScriptable()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class BuiltinDataScriptableBase<T> : ScriptableObject where T : new()
	{
		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public T effectValues;

		[Token(Token = "0x60008E0")]
		public BuiltinDataScriptableBase()
		{
		}
	}
	[Token(Token = "0x2000164")]
	internal struct EventMarker
	{
		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int charIndex;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string eventMessage;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool triggered;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int internalOrder;
	}
	[Token(Token = "0x2000165")]
	public static class TAnimBuilder
	{
		[Serializable]
		[Token(Token = "0x2000166")]
		internal struct TagFormatting
		{
			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public char charOpeningTag;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public char charClosingTag;

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x1E59360", Offset = "0x1E59360", VA = "0x1E59360")]
			public TagFormatting(char openingChar, char closingChar)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80A194", Offset = "0x80A194")]
		private sealed class <>c
		{
			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1E59358", Offset = "0x1E59358", VA = "0x1E59358")]
			public <>c()
			{
			}

			[Token(Token = "0x60008F4")]
			internal IEnumerable<Type> <InitializeGlobalDatabase>b__14_2<T>(Assembly domainAssembly) where T : EffectsBase
			{
				return null;
			}

			[Token(Token = "0x60008F5")]
			internal <>f__AnonymousType0<Assembly, Type> <InitializeGlobalDatabase>b__14_3<T>(Assembly domainAssembly, Type assemblyType) where T : EffectsBase
			{
				return null;
			}

			[Token(Token = "0x60008F6")]
			internal bool <InitializeGlobalDatabase>b__14_4<T>(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0) where T : EffectsBase
			{
				return default(bool);
			}

			[Token(Token = "0x60008F7")]
			internal bool <InitializeGlobalDatabase>b__14_5<T>(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0) where T : EffectsBase
			{
				return default(bool);
			}

			[Token(Token = "0x60008F8")]
			internal Type <InitializeGlobalDatabase>b__14_6<T>(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0) where T : EffectsBase
			{
				return null;
			}
		}

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static TagFormatting tag_behaviors;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal static TagFormatting tag_appearances;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static TAnimGlobalDataScriptable _data;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool hasData;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, Type> behaviorsData;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Dictionary<string, Type> appearancesData;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static HashSet<string> globalDefaultActions;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static HashSet<string> globalCustomActions;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool globalDatabaseInitialized;

		[Token(Token = "0x170000F0")]
		internal static TAnimGlobalDataScriptable data
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x13E46C0", Offset = "0x13E46C0", VA = "0x13E46C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x13E4724", Offset = "0x13E4724", VA = "0x13E4724")]
		public static string[] GetAllBehaviorsTags()
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x13E48C0", Offset = "0x13E48C0", VA = "0x13E48C0")]
		public static string[] GetAllApppearancesTags()
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x13E4A5C", Offset = "0x13E4A5C", VA = "0x13E4A5C")]
		public static void InitializeGlobalDatabase()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x13DABCC", Offset = "0x13DABCC", VA = "0x13DABCC")]
		internal static bool TryGetGlobalPresetBehavior(string tag, out PresetBehaviorValues result)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x13E5894", Offset = "0x13E5894", VA = "0x13E5894")]
		internal static bool TryGetGlobalPresetAppearance(string tag, out PresetAppearanceValues result)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E7")]
		internal static bool GetPresetFromArray<T>(string tag, T[] presets, out T result) where T : PresetBaseValues
		{
			return default(bool);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x13E59B4", Offset = "0x13E59B4", VA = "0x13E59B4")]
		internal static bool IsDefaultAction(string tag)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x13E5A94", Offset = "0x13E5A94", VA = "0x13E5A94")]
		internal static bool IsCustomAction(string tag)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x13E5B74", Offset = "0x13E5B74", VA = "0x13E5B74")]
		internal static bool TryGetGlobalBehaviorFromTag(string effectTag, string entireRichTextTag, out BehaviorBase effectClass)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x13E5C10", Offset = "0x13E5C10", VA = "0x13E5C10")]
		internal static bool TryGetGlobalAppearanceFromTag(string effectTag, string entireRichTextTag, out AppearanceBase effectClass)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EC")]
		internal static bool TryGetEffectClassFromTag<T>(Dictionary<string, Type> dictionary, string effectTag, string entireRichTextTag, out T effectClass) where T : EffectsBase
		{
			return default(bool);
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x13E56D0", Offset = "0x13E56D0", VA = "0x13E56D0")]
		internal static void TryAddingPresetToDictionary(ref Dictionary<string, Type> database, string tag, Type type)
		{
		}

		[Token(Token = "0x60008EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818560", Offset = "0x818560")]
		internal static void <InitializeGlobalDatabase>g__PopulateEffectsFromAssembly|14_0<T>(ref Dictionary<string, Type> effectsList) where T : EffectsBase
		{
		}

		[Token(Token = "0x60008F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818570", Offset = "0x818570")]
		internal static List<Type> <InitializeGlobalDatabase>g__GetAssemblyClasses|14_1<T>() where T : EffectsBase
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x80A1A4", Offset = "0x80A1A4")]
	public class TAnimGlobalDataScriptable : ScriptableObject
	{
		[Token(Token = "0x40009A8")]
		public const string resourcesPath = "TextAnimator GlobalData";

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal PresetBehaviorValues[] globalBehaviorPresets;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal PresetAppearanceValues[] globalAppearancePresets;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal string[] customActions;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal bool customTagsFormatting;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[SerializeField]
		internal TAnimBuilder.TagFormatting tagInfo_behaviors;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[SerializeField]
		internal TAnimBuilder.TagFormatting tagInfo_appearances;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x13E5E3C", Offset = "0x13E5E3C", VA = "0x13E5E3C")]
		public TAnimGlobalDataScriptable()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000169")]
	public class CharacterEvent : UnityEvent<char>
	{
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x19CBD94", Offset = "0x19CBD94", VA = "0x19CBD94")]
		public CharacterEvent()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x80A204", Offset = "0x80A204")]
	public abstract class TAnimPlayerBase : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		[Flags]
		private enum StartTypewriterMode
		{
			[Token(Token = "0x40009C1")]
			FromScriptOnly = 0,
			[Token(Token = "0x40009C2")]
			OnEnable = 1,
			[Token(Token = "0x40009C3")]
			OnShowText = 2,
			[Token(Token = "0x40009C4")]
			AutomaticallyFromAllEvents = 3
		}

		[Token(Token = "0x200016C")]
		public enum DisappearanceOrientation
		{
			[Token(Token = "0x40009C6")]
			SameAsTypewriter,
			[Token(Token = "0x40009C7")]
			Inverted
		}

		[StructLayout(3)]
		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80A284", Offset = "0x80A284")]
		private struct <>c__DisplayClass23_0
		{
			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float deltaTime;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float typewriterTagsSpeed;
		}

		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80A294", Offset = "0x80A294")]
		private sealed class <ShowRemainingCharacters>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TAnimPlayerBase <>4__this;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass23_0 <>8__1;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <timeToWait>5__2;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePassed>5__3;

			[Token(Token = "0x170000F3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000916")]
				[Address(RVA = "0x1E59EC8", Offset = "0x1E59EC8", VA = "0x1E59EC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000918")]
				[Address(RVA = "0x1E59F10", Offset = "0x1E59F10", VA = "0x1E59F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x1E59958", Offset = "0x1E59958", VA = "0x1E59958")]
			[DebuggerHidden]
			public <ShowRemainingCharacters>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x1E59984", Offset = "0x1E59984", VA = "0x1E59984", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x1E59988", Offset = "0x1E59988", VA = "0x1E59988", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x1E59ED0", Offset = "0x1E59ED0", VA = "0x1E59ED0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80A2A4", Offset = "0x80A2A4")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x2000170")]
			private sealed class <<DisappearRoutine>g__WaitFor|0>d : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Token(Token = "0x40009D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int <>1__state;

				[Token(Token = "0x40009D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private object <>2__current;

				[Token(Token = "0x40009D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public <>c__DisplayClass30_0 <>4__this;

				[Token(Token = "0x40009D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public float duration;

				[Token(Token = "0x170000F5")]
				private object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[Token(Token = "0x600091F")]
					[Address(RVA = "0x1E5D3D4", Offset = "0x1E5D3D4", VA = "0x1E5D3D4", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x170000F6")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000921")]
					[Address(RVA = "0x1E5D41C", Offset = "0x1E5D41C", VA = "0x1E5D41C", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x600091C")]
				[Address(RVA = "0x1E59554", Offset = "0x1E59554", VA = "0x1E59554")]
				[DebuggerHidden]
				public <<DisappearRoutine>g__WaitFor|0>d(int <>1__state)
				{
				}

				[Token(Token = "0x600091D")]
				[Address(RVA = "0x1E5D30C", Offset = "0x1E5D30C", VA = "0x1E5D30C", Slot = "5")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x600091E")]
				[Address(RVA = "0x1E5D310", Offset = "0x1E5D310", VA = "0x1E5D310", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x6000920")]
				[Address(RVA = "0x1E5D3DC", Offset = "0x1E5D3DC", VA = "0x1E5D3DC", Slot = "8")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float t;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TAnimPlayerBase <>4__this;

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1E594C4", Offset = "0x1E594C4", VA = "0x1E594C4")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1E594CC", Offset = "0x1E594CC", VA = "0x1E594CC")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x818838", Offset = "0x818838")]
			internal IEnumerator <DisappearRoutine>g__WaitFor|0(float duration)
			{
				return null;
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1E59580", Offset = "0x1E59580", VA = "0x1E59580")]
			internal bool <DisappearRoutine>g__CanDisappear|1()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80A2B4", Offset = "0x80A2B4")]
		private sealed class <DisappearRoutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TAnimPlayerBase <>4__this;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass30_0 <>8__1;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_CharacterInfo[] <charInfo>5__2;

			[Token(Token = "0x170000F7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000925")]
				[Address(RVA = "0x1E59908", Offset = "0x1E59908", VA = "0x1E59908", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000927")]
				[Address(RVA = "0x1E59950", Offset = "0x1E59950", VA = "0x1E59950", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x1E5960C", Offset = "0x1E5960C", VA = "0x1E5960C")]
			[DebuggerHidden]
			public <DisappearRoutine>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x1E59638", Offset = "0x1E59638", VA = "0x1E59638", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x1E5963C", Offset = "0x1E5963C", VA = "0x1E5963C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x1E59910", Offset = "0x1E59910", VA = "0x1E59910", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80A2C4", Offset = "0x80A2C4")]
		private sealed class <<ShowRemainingCharacters>g__WaitTime|23_0>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TAnimPlayerBase <>4__this;

			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <t>5__2;

			[Token(Token = "0x170000F9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600092B")]
				[Address(RVA = "0x1E59474", Offset = "0x1E59474", VA = "0x1E59474", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x1E594BC", Offset = "0x1E594BC", VA = "0x1E594BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x1E5936C", Offset = "0x1E5936C", VA = "0x1E5936C")]
			[DebuggerHidden]
			public <<ShowRemainingCharacters>g__WaitTime|23_0>d(int <>1__state)
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x1E59398", Offset = "0x1E59398", VA = "0x1E59398", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x1E5939C", Offset = "0x1E5939C", VA = "0x1E5939C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1E5947C", Offset = "0x1E5947C", VA = "0x1E5947C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string textToShow;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAnimator _textAnimator;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isInsideRoutine;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool isDisappearing;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		protected bool wantsToSkip;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x815540", Offset = "0x815540")]
		public bool useTypeWriter;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81558C", Offset = "0x81558C")]
		[SerializeField]
		private StartTypewriterMode startTypewriterMode;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool canSkipTypewriter;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool hideAppearancesOnSkip;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8155F8", Offset = "0x8155F8")]
		[SerializeField]
		private bool triggerEventsOnSkip;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x815644", Offset = "0x815644")]
		[SerializeField]
		private bool resetTypingSpeedAtStartup;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected float typewriterPlayerSpeed;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public DisappearanceOrientation disappearanceOrientation;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent onTextShowed;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent onTypewriterStart;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent onTextDisappeared;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CharacterEvent onCharacterVisible;

		[Token(Token = "0x170000F1")]
		public TextAnimator textAnimator
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x13E1AA4", Offset = "0x13E1AA4", VA = "0x13E1AA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		protected bool isBaseInsideRoutine
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x13E5F50", Offset = "0x13E5F50", VA = "0x13E5F50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x13E5F58", Offset = "0x13E5F58", VA = "0x13E5F58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x818580", Offset = "0x818580")]
		private IEnumerator ShowRemainingCharacters()
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x13E1CCC", Offset = "0x13E1CCC", VA = "0x13E1CCC")]
		public void ShowText(string text)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x13E6110", Offset = "0x13E6110", VA = "0x13E6110")]
		private bool CanStartAnyCoroutine()
		{
			return default(bool);
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x13E6004", Offset = "0x13E6004", VA = "0x13E6004")]
		public void StartShowingText(bool resetVisibleCharacters = false)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x13E626C", Offset = "0x13E626C", VA = "0x13E626C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8185E0", Offset = "0x8185E0")]
		public void SkipTypewriter()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x13E1F24", Offset = "0x13E1F24", VA = "0x13E1F24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x818618", Offset = "0x818618")]
		public void StopShowingText()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x13E6278", Offset = "0x13E6278", VA = "0x13E6278")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x818650", Offset = "0x818650")]
		public void StartDisappearingText()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x13E633C", Offset = "0x13E633C", VA = "0x13E633C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x818688", Offset = "0x818688")]
		private IEnumerator DisappearRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x13E63B4", Offset = "0x13E63B4", VA = "0x13E63B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8186E8", Offset = "0x8186E8")]
		public void StopDisappearingText()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x13E63BC", Offset = "0x13E63BC", VA = "0x13E63BC")]
		public void SetTypewriterSpeed(float value)
		{
		}

		[Token(Token = "0x6000907")]
		protected abstract IEnumerator WaitInput();

		[Token(Token = "0x6000908")]
		protected abstract float GetWaitAppearanceTimeOf(char character);

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x13E63F0", Offset = "0x13E63F0", VA = "0x13E63F0", Slot = "6")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x818720", Offset = "0x818720")]
		protected virtual void WaitTimeOf(char character)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x13E63FC", Offset = "0x13E63FC", VA = "0x13E63FC", Slot = "7")]
		protected virtual float GetWaitDisappearanceTimeOf(char character)
		{
			return default(float);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x13E6408", Offset = "0x13E6408", VA = "0x13E6408", Slot = "8")]
		protected virtual IEnumerator DoCustomAction(TypewriterAction action)
		{
			return null;
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x13E6484", Offset = "0x13E6484", VA = "0x13E6484", Slot = "9")]
		protected virtual void OnTypewriterCharDelay()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x13E6488", Offset = "0x13E6488", VA = "0x13E6488", Slot = "10")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x13E6490", Offset = "0x13E6490", VA = "0x13E6490", Slot = "11")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x13E6538", Offset = "0x13E6538", VA = "0x13E6538")]
		protected TAnimPlayerBase()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x13E65BC", Offset = "0x13E65BC", VA = "0x13E65BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x818758", Offset = "0x818758")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818758", Offset = "0x818758")]
		private IEnumerator <ShowRemainingCharacters>g__WaitTime|23_0(float time)
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x13E6644", Offset = "0x13E6644", VA = "0x13E6644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8187C8", Offset = "0x8187C8")]
		private bool <ShowRemainingCharacters>g__HasSkipped|23_1()
		{
			return default(bool);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x13E6664", Offset = "0x13E6664", VA = "0x13E6664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8187D8", Offset = "0x8187D8")]
		private void <ShowRemainingCharacters>g__UpdateDeltaTime|23_2(ref <>c__DisplayClass23_0 P_0)
		{
		}
	}
	[Token(Token = "0x2000173")]
	public static class FormatUtils
	{
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x1A3EC50", Offset = "0x1A3EC50", VA = "0x1A3EC50")]
		public static bool TryGetFloat(List<string> attributes, int index, float defValue, out float result)
		{
			return default(bool);
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x1A3ED00", Offset = "0x1A3ED00", VA = "0x1A3ED00")]
		public static bool TryGetFloat(string attribute, float defValue, out float result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1A345B8", Offset = "0x1A345B8", VA = "0x1A345B8")]
		public static bool ParseFloat(string value, out float result)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000174")]
	internal static class TAnimExtensions
	{
		[Token(Token = "0x6000931")]
		internal static int GetIndexOfEffectNamed<T>(this List<T> effects, string tag) where T : EffectsBase
		{
			return default(int);
		}

		[Token(Token = "0x6000932")]
		internal static bool CloseElement<T>(this List<T> effects, int listIndex, int realTextIndex) where T : EffectsBase
		{
			return default(bool);
		}

		[Token(Token = "0x6000933")]
		internal static bool CloseRegionNamed<T>(this List<T> effects, string endTag, int realTextIndex) where T : EffectsBase
		{
			return default(bool);
		}

		[Token(Token = "0x6000934")]
		internal static bool TryAddingNewRegion<T>(this List<T> effects, T region) where T : EffectsBase
		{
			return default(bool);
		}

		[Token(Token = "0x6000935")]
		internal static bool CloseSingleOrAllEffects<T>(this List<T> effects, string closureTag, int realTextIndex) where T : EffectsBase
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000175")]
	public static class TextUtilities
	{
		[Token(Token = "0x40009E0")]
		public const int verticesPerChar = 4;

		[Token(Token = "0x40009E1")]
		internal const int fakeRandomsCount = 25;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Vector3[] fakeRandoms;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initialized;

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x151E474", Offset = "0x151E474", VA = "0x151E474")]
		internal static void Initialize()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x151E74C", Offset = "0x151E74C", VA = "0x151E74C")]
		public static Vector3 RotateAround(this Vector3 vec, Vector2 center, float rotDegrees)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x151E7E8", Offset = "0x151E7E8", VA = "0x151E7E8")]
		public static void MoveChar(this Vector3[] vec, Vector3 dir)
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x151E85C", Offset = "0x151E85C", VA = "0x151E85C")]
		public static void SetChar(this Vector3[] vec, Vector3 pos)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x151E8BC", Offset = "0x151E8BC", VA = "0x151E8BC")]
		public static void LerpUnclamped(this Vector3[] vec, Vector3 target, float pct)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x151E944", Offset = "0x151E944", VA = "0x151E944")]
		public static Vector3 GetMiddlePos(this Vector3[] vec)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x151E9A4", Offset = "0x151E9A4", VA = "0x151E9A4")]
		public static void RotateChar(this Vector3[] vec, float angle)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x151EB38", Offset = "0x151EB38", VA = "0x151EB38")]
		public static void RotateChar(this Vector3[] vec, float angle, Vector3 pivot)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x151ECAC", Offset = "0x151ECAC", VA = "0x151ECAC")]
		public static void SetColor(this Color32[] col, Color32 target)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x151ED00", Offset = "0x151ED00", VA = "0x151ED00")]
		public static void LerpUnclamped(this Color32[] col, Color32 target, float pct)
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x151ED98", Offset = "0x151ED98", VA = "0x151ED98")]
		public static float CalculateCurveDuration(this AnimationCurve curve)
		{
			return default(float);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x151EE2C", Offset = "0x151EE2C", VA = "0x151EE2C")]
		public static bool IsTagLongEnough(string tag)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000176")]
	public static class Tween
	{
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x151F574", Offset = "0x151F574", VA = "0x151F574")]
		public static float EaseIn(float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x151F57C", Offset = "0x151F57C", VA = "0x151F57C")]
		public static float Flip(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x151F588", Offset = "0x151F588", VA = "0x151F588")]
		public static float Square(float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x151F590", Offset = "0x151F590", VA = "0x151F590")]
		public static float EaseOut(float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x151F5A4", Offset = "0x151F5A4", VA = "0x151F5A4")]
		public static float EaseInOut(float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x151F5C4", Offset = "0x151F5C4", VA = "0x151F5C4")]
		public static float BounceOut(float t)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000177")]
	public abstract class AppearanceBase : EffectsBase
	{
		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float effectDuration;

		[Token(Token = "0x170000FB")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x818BD0", Offset = "0x818BD0")]
		protected float showDuration
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x19BADC8", Offset = "0x19BADC8", VA = "0x19BADC8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600094A")]
		public abstract void SetDefaultValues(AppearanceDefaultValues data);

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x19BADD0", Offset = "0x19BADD0", VA = "0x19BADD0", Slot = "9")]
		public virtual bool CanShowAppearanceOn(float timePassed)
		{
			return default(bool);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x19BADE0", Offset = "0x19BADE0", VA = "0x19BADE0", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x19BAE6C", Offset = "0x19BAE6C", VA = "0x19BAE6C")]
		protected AppearanceBase()
		{
		}
	}
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A2F4", Offset = "0x80A2F4")]
	[Preserve]
	internal class DiagonalExpandAppearance : AppearanceBase
	{
		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int targetA;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int targetB;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 middlePos;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float pct;

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1A33034", Offset = "0x1A33034", VA = "0x1A33034", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1A3307C", Offset = "0x1A3307C", VA = "0x1A3307C")]
		private void SetOrientation(bool btmLeft)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1A33098", Offset = "0x1A33098", VA = "0x1A33098", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x1A331E0", Offset = "0x1A331E0", VA = "0x1A331E0", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1A3329C", Offset = "0x1A3329C", VA = "0x1A3329C")]
		public DiagonalExpandAppearance()
		{
		}
	}
	[Token(Token = "0x2000179")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A340", Offset = "0x80A340")]
	internal class FadeAppearance : AppearanceBase
	{
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1A3CEA0", Offset = "0x1A3CEA0", VA = "0x1A3CEA0", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x1A3CEC8", Offset = "0x1A3CEC8", VA = "0x1A3CEC8", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x1A3CF80", Offset = "0x1A3CF80", VA = "0x1A3CF80")]
		public FadeAppearance()
		{
		}
	}
	[Token(Token = "0x200017A")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A38C", Offset = "0x80A38C")]
	internal class HorizontalExpandAppearance : AppearanceBase
	{
		[Token(Token = "0x200017B")]
		public enum ExpType
		{
			[Token(Token = "0x40009EE")]
			Left,
			[Token(Token = "0x40009EF")]
			Middle,
			[Token(Token = "0x40009F0")]
			Right
		}

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ExpType type;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 startTop;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 startBot;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float pct;

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x1C1600C", Offset = "0x1C1600C", VA = "0x1C1600C", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x1C16044", Offset = "0x1C16044", VA = "0x1C16044", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1C16318", Offset = "0x1C16318", VA = "0x1C16318", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1C16618", Offset = "0x1C16618", VA = "0x1C16618")]
		public HorizontalExpandAppearance()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A3D8", Offset = "0x80A3D8")]
	internal class OffsetAppearance : AppearanceBase
	{
		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float amount;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 direction;

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x1B0E258", Offset = "0x1B0E258", VA = "0x1B0E258", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x1B0E2A8", Offset = "0x1B0E2A8", VA = "0x1B0E2A8", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1B0E368", Offset = "0x1B0E368", VA = "0x1B0E368", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1B0E408", Offset = "0x1B0E408", VA = "0x1B0E408")]
		public OffsetAppearance()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A424", Offset = "0x80A424")]
	internal class RotatingAppearance : AppearanceBase
	{
		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float targetAngle;

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x13DEC44", Offset = "0x13DEC44", VA = "0x13DEC44", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x13DEC7C", Offset = "0x13DEC7C", VA = "0x13DEC7C", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x13DED28", Offset = "0x13DED28", VA = "0x13DED28", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x13DEDC8", Offset = "0x13DEDC8", VA = "0x13DEDC8")]
		public RotatingAppearance()
		{
		}
	}
	[Token(Token = "0x200017E")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A470", Offset = "0x80A470")]
	internal class SizeAppearance : AppearanceBase
	{
		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float amplitude;

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x13E3884", Offset = "0x13E3884", VA = "0x13E3884", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x13E38C4", Offset = "0x13E38C4", VA = "0x13E38C4", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x13E3990", Offset = "0x13E3990", VA = "0x13E3990", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x13E3A30", Offset = "0x13E3A30", VA = "0x13E3A30")]
		public SizeAppearance()
		{
		}
	}
	[Token(Token = "0x200017F")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A4BC", Offset = "0x80A4BC")]
	internal class VerticalExpandAppearance : AppearanceBase
	{
		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int startA;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int targetA;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int startB;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int targetB;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float pct;

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x152835C", Offset = "0x152835C", VA = "0x152835C", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x15283AC", Offset = "0x15283AC", VA = "0x15283AC")]
		private void SetOrientation(bool fromBottom)
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x15283D4", Offset = "0x15283D4", VA = "0x15283D4", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x15284FC", Offset = "0x15284FC", VA = "0x15284FC", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x15285C4", Offset = "0x15285C4", VA = "0x15285C4")]
		public VerticalExpandAppearance()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A508", Offset = "0x80A508")]
	[Preserve]
	internal class PresetAppearance : AppearanceBase
	{
		[Token(Token = "0x2000181")]
		internal abstract class Effector
		{
			[Token(Token = "0x6000970")]
			protected abstract Vector3 _EvaluateEffect(float passedTime, int charInde);

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x1E57C1C", Offset = "0x1E57C1C", VA = "0x1E57C1C")]
			public Vector3 EvaluateEffect(float passedTime, int charIndex)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x1E57C28", Offset = "0x1E57C28", VA = "0x1E57C28")]
			protected Effector()
			{
			}
		}

		[Token(Token = "0x2000182")]
		internal sealed class ThreeAxisEffector : Effector
		{
			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private EffectEvaluator x;

			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private EffectEvaluator y;

			[Token(Token = "0x4000A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private EffectEvaluator z;

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x1E57C30", Offset = "0x1E57C30", VA = "0x1E57C30")]
			public ThreeAxisEffector(EffectEvaluator x, EffectEvaluator y, EffectEvaluator z)
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x1E57C94", Offset = "0x1E57C94", VA = "0x1E57C94", Slot = "4")]
			protected override Vector3 _EvaluateEffect(float passedTime, int charIndex)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000183")]
		internal sealed class TwoAxisEffector : Effector
		{
			[Token(Token = "0x4000A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private EffectEvaluator x;

			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private EffectEvaluator y;

			[Token(Token = "0x6000975")]
			[Address(RVA = "0x1E57E6C", Offset = "0x1E57E6C", VA = "0x1E57E6C")]
			public TwoAxisEffector(EffectEvaluator x, EffectEvaluator y)
			{
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0x1E57EBC", Offset = "0x1E57EBC", VA = "0x1E57EBC", Slot = "4")]
			protected override Vector3 _EvaluateEffect(float passedTime, int charIndex)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool enabled;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Matrix4x4 matrix;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 offset;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Quaternion rotationQua;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool hasTransformEffects;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ThreeAxisEffector movement;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ThreeAxisEffector rotation;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TwoAxisEffector scale;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool setColor;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Color32 color;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ColorCurve colorCurve;

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x1B1135C", Offset = "0x1B1135C", VA = "0x1B1135C", Slot = "8")]
		public override void SetDefaultValues(AppearanceDefaultValues data)
		{
		}

		[Token(Token = "0x600096C")]
		public static bool SetPreset<T>(bool isAppearance, T values, ref ThreeAxisEffector movement, ref float showDuration, ref ThreeAxisEffector rotation, ref TwoAxisEffector scale, ref Quaternion rotationQua, ref bool hasTransformEffects, ref bool setColor, ref ColorCurve colorCurve) where T : PresetBaseValues
		{
			return default(bool);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1B114E8", Offset = "0x1B114E8", VA = "0x1B114E8", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1B11804", Offset = "0x1B11804", VA = "0x1B11804")]
		public PresetAppearance()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1B11450", Offset = "0x1B11450", VA = "0x1B11450")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818A78", Offset = "0x818A78")]
		private void <SetDefaultValues>g__AssignValues|11_0(PresetAppearanceValues result)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000184")]
	internal class PresetAppearanceValues : PresetBaseValues
	{
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x13DA6BC", Offset = "0x13DA6BC", VA = "0x13DA6BC")]
		public PresetAppearanceValues()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public abstract class BehaviorBase : EffectsBase
	{
		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8156A0", Offset = "0x8156A0")]
		private TextAnimator.TimeData <time>k__BackingField;

		[Token(Token = "0x170000FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x818C08", Offset = "0x818C08")]
		public float animatorTime
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x19BF6BC", Offset = "0x19BF6BC", VA = "0x19BF6BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FD")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x818C40", Offset = "0x818C40")]
		public float animatorDeltaTime
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x19BF6C4", Offset = "0x19BF6C4", VA = "0x19BF6C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FE")]
		public TextAnimator.TimeData time
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x19BF6CC", Offset = "0x19BF6CC", VA = "0x19BF6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818A88", Offset = "0x818A88")]
			get
			{
				return default(TextAnimator.TimeData);
			}
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x19BF6D4", Offset = "0x19BF6D4", VA = "0x19BF6D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818A98", Offset = "0x818A98")]
			private set
			{
			}
		}

		[Token(Token = "0x6000978")]
		public abstract void SetDefaultValues(BehaviorDefaultValues data);

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x19BF6DC", Offset = "0x19BF6DC", VA = "0x19BF6DC")]
		internal void SetAnimatorData(in TextAnimator.TimeData time)
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x19BF6E8", Offset = "0x19BF6E8", VA = "0x19BF6E8")]
		protected BehaviorBase()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public abstract class BehaviorSine : BehaviorBase
	{
		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected float amplitude;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected float frequency;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float waveSize;

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x19BF790", Offset = "0x19BF790", VA = "0x19BF790", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x19BF87C", Offset = "0x19BF87C", VA = "0x19BF87C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x19BFB0C", Offset = "0x19BFB0C", VA = "0x19BFB0C")]
		protected BehaviorSine()
		{
		}
	}
	[Token(Token = "0x2000187")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A554", Offset = "0x80A554")]
	internal class BounceBehavior : BehaviorSine
	{
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x19C8A70", Offset = "0x19C8A70", VA = "0x19C8A70", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x19C8AB8", Offset = "0x19C8AB8", VA = "0x19C8AB8", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x19C8C08", Offset = "0x19C8C08", VA = "0x19C8C08")]
		public BounceBehavior()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x19C8BA8", Offset = "0x19C8BA8", VA = "0x19C8BA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818AA8", Offset = "0x818AA8")]
		internal static float <ApplyEffect>g__BounceTween|1_0(float t)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A5A0", Offset = "0x80A5A0")]
	[Preserve]
	internal class DangleBehavior : BehaviorSine
	{
		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float sin;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int targetIndex1;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int targetIndex2;

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1A32450", Offset = "0x1A32450", VA = "0x1A32450", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x1A324B4", Offset = "0x1A324B4", VA = "0x1A324B4", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1A325C4", Offset = "0x1A325C4", VA = "0x1A325C4")]
		public DangleBehavior()
		{
		}
	}
	[Token(Token = "0x2000189")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A5EC", Offset = "0x80A5EC")]
	internal class FadeBehavior : BehaviorBase
	{
		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float delay;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] charPCTs;

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1A3CF88", Offset = "0x1A3CF88", VA = "0x1A3CF88", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1A3CFB0", Offset = "0x1A3CFB0", VA = "0x1A3CFB0", Slot = "4")]
		public override void Initialize(int charactersCount)
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1A3D018", Offset = "0x1A3D018", VA = "0x1A3D018", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1A3D0B0", Offset = "0x1A3D0B0", VA = "0x1A3D0B0", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1A3D25C", Offset = "0x1A3D25C", VA = "0x1A3D25C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1A3D31C", Offset = "0x1A3D31C", VA = "0x1A3D31C")]
		public FadeBehavior()
		{
		}
	}
	[Token(Token = "0x200018A")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A638", Offset = "0x80A638")]
	internal class PendulumBehavior : BehaviorSine
	{
		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int targetVertex1;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int targetVertex2;

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x1B0F00C", Offset = "0x1B0F00C", VA = "0x1B0F00C", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1B0F074", Offset = "0x1B0F074", VA = "0x1B0F074", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1B0F1A8", Offset = "0x1B0F1A8", VA = "0x1B0F1A8")]
		public PendulumBehavior()
		{
		}
	}
	[Token(Token = "0x200018B")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A684", Offset = "0x80A684")]
	internal class RainbowBehavior : BehaviorBase
	{
		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float hueShiftSpeed;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float hueShiftWaveSize;

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x13DD664", Offset = "0x13DD664", VA = "0x13DD664", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x13DD69C", Offset = "0x13DD69C", VA = "0x13DD69C", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x13DD758", Offset = "0x13DD758", VA = "0x13DD758", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x13DD814", Offset = "0x13DD814", VA = "0x13DD814", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x13DD918", Offset = "0x13DD918", VA = "0x13DD918")]
		public RainbowBehavior()
		{
		}
	}
	[Token(Token = "0x200018C")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A6D0", Offset = "0x80A6D0")]
	internal class RotationBehavior : BehaviorBase
	{
		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float angleSpeed;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float angleDiffBetweenChars;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x13DEDD0", Offset = "0x13DEDD0", VA = "0x13DEDD0", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x13DEE08", Offset = "0x13DEE08", VA = "0x13DEE08", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x13DEEC4", Offset = "0x13DEEC4", VA = "0x13DEEC4", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x13DEF64", Offset = "0x13DEF64", VA = "0x13DEF64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x13DF068", Offset = "0x13DF068", VA = "0x13DF068")]
		public RotationBehavior()
		{
		}
	}
	[Token(Token = "0x200018D")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A71C", Offset = "0x80A71C")]
	internal class ShakeBehavior : BehaviorBase
	{
		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float shakeStrength;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float shakeDelay;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float timePassed;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int randIndex;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int lastRandomIndex;

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x13E1F9C", Offset = "0x13E1F9C", VA = "0x13E1F9C", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x13E1FFC", Offset = "0x13E1FFC", VA = "0x13E1FFC")]
		private void ClampValues()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x13E2038", Offset = "0x13E2038", VA = "0x13E2038", Slot = "4")]
		public override void Initialize(int charactersCount)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x13E2070", Offset = "0x13E2070", VA = "0x13E2070", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x13E2140", Offset = "0x13E2140", VA = "0x13E2140", Slot = "5")]
		public override void Calculate()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x13E21AC", Offset = "0x13E21AC", VA = "0x13E21AC", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x13E22B8", Offset = "0x13E22B8", VA = "0x13E22B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x13E23BC", Offset = "0x13E23BC", VA = "0x13E23BC")]
		public ShakeBehavior()
		{
		}
	}
	[Token(Token = "0x200018E")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A768", Offset = "0x80A768")]
	internal sealed class SizeBehavior : BehaviorSine
	{
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x13E3A38", Offset = "0x13E3A38", VA = "0x13E3A38", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x13E3A88", Offset = "0x13E3A88", VA = "0x13E3A88", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x13E3B68", Offset = "0x13E3B68", VA = "0x13E3B68")]
		public SizeBehavior()
		{
		}
	}
	[Token(Token = "0x200018F")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A7B4", Offset = "0x80A7B4")]
	internal class SlideBehavior : BehaviorSine
	{
		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float sin;

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x13E3B70", Offset = "0x13E3B70", VA = "0x13E3B70", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x13E3BB8", Offset = "0x13E3BB8", VA = "0x13E3BB8", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x13E3D3C", Offset = "0x13E3D3C", VA = "0x13E3D3C")]
		public SlideBehavior()
		{
		}
	}
	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A800", Offset = "0x80A800")]
	[Preserve]
	internal class SwingBehavior : BehaviorSine
	{
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x13E45C8", Offset = "0x13E45C8", VA = "0x13E45C8", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x13E4610", Offset = "0x13E4610", VA = "0x13E4610", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x13E46B8", Offset = "0x13E46B8", VA = "0x13E46B8")]
		public SwingBehavior()
		{
		}
	}
	[Token(Token = "0x2000191")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A84C", Offset = "0x80A84C")]
	internal class WaveBehavior : BehaviorSine
	{
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x1528724", Offset = "0x1528724", VA = "0x1528724", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x152876C", Offset = "0x152876C", VA = "0x152876C", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1528858", Offset = "0x1528858", VA = "0x1528858")]
		public WaveBehavior()
		{
		}
	}
	[Token(Token = "0x2000192")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A898", Offset = "0x80A898")]
	internal class WiggleBehavior : BehaviorBase
	{
		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float amplitude;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float frequency;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] directions;

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x1528860", Offset = "0x1528860", VA = "0x1528860", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x1528898", Offset = "0x1528898", VA = "0x1528898", Slot = "4")]
		public override void Initialize(int charactersCount)
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x1528A08", Offset = "0x1528A08", VA = "0x1528A08", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x1528AC4", Offset = "0x1528AC4", VA = "0x1528AC4", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x1528BC8", Offset = "0x1528BC8", VA = "0x1528BC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1528CCC", Offset = "0x1528CCC", VA = "0x1528CCC")]
		public WiggleBehavior()
		{
		}
	}
	[Token(Token = "0x2000193")]
	[Preserve]
	[AttributeAttribute(Name = "EffectInfoAttribute", RVA = "0x80A8E4", Offset = "0x80A8E4")]
	internal class PresetBehavior : BehaviorBase
	{
		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool enabled;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float timeSpeed;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weightMult;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Matrix4x4 matrix;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 offset;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion rotationQua;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float uniformEffectTime;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool hasTransformEffects;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		private bool isOnOneCharacter;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float weight;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private EmissionControl emissionControl;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private PresetAppearance.ThreeAxisEffector movement;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private PresetAppearance.ThreeAxisEffector rotation;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private PresetAppearance.TwoAxisEffector scale;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool setColor;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Color32 color;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ColorCurve colorCurve;

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x13DA9F0", Offset = "0x13DA9F0", VA = "0x13DA9F0", Slot = "8")]
		public override void SetDefaultValues(BehaviorDefaultValues data)
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x13DACEC", Offset = "0x13DACEC", VA = "0x13DACEC", Slot = "7")]
		public override void SetModifier(string modifierName, string modifierValue)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x13DADA8", Offset = "0x13DADA8", VA = "0x13DADA8", Slot = "5")]
		public override void Calculate()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x13DADE8", Offset = "0x13DADE8", VA = "0x13DADE8", Slot = "6")]
		public override void ApplyEffect(ref CharacterData data, int charIndex)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x13DB1AC", Offset = "0x13DB1AC", VA = "0x13DB1AC")]
		public PresetBehavior()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x13DAAF0", Offset = "0x13DAAF0", VA = "0x13DAAF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818AB8", Offset = "0x818AB8")]
		private void <SetDefaultValues>g__AssignValues|17_0(PresetBehaviorValues result)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000194")]
	internal class PresetBehaviorValues : PresetBaseValues
	{
		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public EmissionControl emission;

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x13DB1BC", Offset = "0x13DB1BC", VA = "0x13DB1BC", Slot = "4")]
		public override void Initialize(bool isAppearance)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x13DB1F4", Offset = "0x13DB1F4", VA = "0x13DB1F4")]
		public PresetBehaviorValues()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000195")]
	internal class ColorCurve
	{
		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public bool enabled;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Gradient gradient;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x8156E0", Offset = "0x8156E0")]
		protected float duration;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x815720", Offset = "0x815720")]
		protected float charsTimeOffset;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isAppearance;

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x1A31AC8", Offset = "0x1A31AC8", VA = "0x1A31AC8")]
		public float GetDuration()
		{
			return default(float);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x1A31AD0", Offset = "0x1A31AD0", VA = "0x1A31AD0")]
		public void Initialize(bool isAppearance)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x1A31AFC", Offset = "0x1A31AFC", VA = "0x1A31AFC")]
		public Color32 GetColor(float time, int characterIndex)
		{
			return default(Color32);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x1A31B98", Offset = "0x1A31B98", VA = "0x1A31B98")]
		public ColorCurve()
		{
		}
	}
	[Token(Token = "0x2000196")]
	internal interface EffectEvaluator
	{
		[Token(Token = "0x170000FF")]
		bool isEnabled
		{
			[Token(Token = "0x60009C3")]
			get;
		}

		[Token(Token = "0x60009C2")]
		void Initialize(int type);

		[Token(Token = "0x60009C4")]
		float Evaluate(float time, int characterIndex);

		[Token(Token = "0x60009C5")]
		float GetDuration();
	}
	[Serializable]
	[Token(Token = "0x2000197")]
	internal struct EmissionControl
	{
		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x815764", Offset = "0x815764")]
		private int cycles;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private AnimationCurve attackCurve;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x8157B0", Offset = "0x8157B0")]
		private float overrideDuration;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool continueForever;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationCurve decayCurve;

		[NonSerialized]
		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float maxDuration;

		[NonSerialized]
		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnimationCurve intensityOverDuration;

		[NonSerialized]
		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float passedTime;

		[NonSerialized]
		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float cycleDuration;

		[NonSerialized]
		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float effectWeigth;

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1A34840", Offset = "0x1A34840", VA = "0x1A34840")]
		public void Initialize(float effectsMaxDuration)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1A34B58", Offset = "0x1A34B58", VA = "0x1A34B58")]
		public float IncreaseEffectTime(float deltaTime)
		{
			return default(float);
		}
	}
	[Serializable]
	[Token(Token = "0x2000198")]
	internal class FloatCurve : EffectEvaluator
	{
		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected float amplitude;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected AnimationCurve curve;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		protected float defaultReturn;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x815864", Offset = "0x815864")]
		[SerializeField]
		protected float charsTimeOffset;

		[NonSerialized]
		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float calculatedDuration;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool isAppearance;

		[Token(Token = "0x17000100")]
		public bool isEnabled
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x1A3EAB0", Offset = "0x1A3EAB0", VA = "0x1A3EAB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x1A3EAB8", Offset = "0x1A3EAB8", VA = "0x1A3EAB8", Slot = "7")]
		public float GetDuration()
		{
			return default(float);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x1A3EAC0", Offset = "0x1A3EAC0", VA = "0x1A3EAC0", Slot = "4")]
		public void Initialize(int type)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1A3EB68", Offset = "0x1A3EB68", VA = "0x1A3EB68", Slot = "6")]
		public float Evaluate(float time, int characterIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x1A3EC48", Offset = "0x1A3EC48", VA = "0x1A3EC48")]
		public FloatCurve()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000199")]
	internal class PresetBaseValues
	{
		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string effectTag;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public FloatCurve movementX;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public FloatCurve movementY;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public FloatCurve movementZ;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public FloatCurve scaleX;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public FloatCurve scaleY;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public FloatCurve rotX;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public FloatCurve rotY;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public FloatCurve rotZ;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public ColorCurve color;

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x13DA6CC", Offset = "0x13DA6CC", VA = "0x13DA6CC")]
		public float GetMaxDuration()
		{
			return default(float);
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x13DA900", Offset = "0x13DA900", VA = "0x13DA900", Slot = "4")]
		public virtual void Initialize(bool isAppearance)
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x13DA6C4", Offset = "0x13DA6C4", VA = "0x13DA6C4")]
		public PresetBaseValues()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x13DA7DC", Offset = "0x13DA7DC", VA = "0x13DA7DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818AC8", Offset = "0x818AC8")]
		internal static float <GetMaxDuration>g__GetEffectEvaluatorDuration|10_0(EffectEvaluator effect)
		{
			return default(float);
		}
	}
}
