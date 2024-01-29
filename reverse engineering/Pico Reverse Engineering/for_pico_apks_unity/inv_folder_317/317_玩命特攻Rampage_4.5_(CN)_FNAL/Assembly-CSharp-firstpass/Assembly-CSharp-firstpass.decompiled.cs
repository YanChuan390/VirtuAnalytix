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
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class OverDrawRenderCamera : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool IsFollowSceneView;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera m_camera;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1E81150", Offset = "0x1E81150", VA = "0x1E81150")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1E811A8", Offset = "0x1E811A8", VA = "0x1E811A8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1E811AC", Offset = "0x1E811AC", VA = "0x1E811AC")]
	public OverDrawRenderCamera()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x117D22C", Offset = "0x117D22C")]
public class OverDrawRenderData : ScriptableRendererData
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material m_OverDrawQuad;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material m_OverDrawTransparent;

	[Token(Token = "0x17000001")]
	public Material overDrawQuad
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1E811B4", Offset = "0x1E811B4", VA = "0x1E811B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public Material overDrawTransparent
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1E811BC", Offset = "0x1E811BC", VA = "0x1E811BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1E811C4", Offset = "0x1E811C4", VA = "0x1E811C4", Slot = "4")]
	protected override ScriptableRenderer Create()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1E813A0", Offset = "0x1E813A0", VA = "0x1E813A0")]
	public OverDrawRenderData()
	{
	}
}
[Token(Token = "0x2000004")]
public class OverDrawRenderer : ScriptableRenderer
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private OverDrawRenderPass m_OverDrawRenderQuadPass;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private OverDrawRenderPass m_OverDrawRenderTransparentPass;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1E81224", Offset = "0x1E81224", VA = "0x1E81224")]
	public OverDrawRenderer(ScriptableRendererData data)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1E82064", Offset = "0x1E82064", VA = "0x1E82064", Slot = "6")]
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
[Token(Token = "0x2000005")]
public class OverDrawRenderPass : ScriptableRenderPass
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private SortingCriteria m_Criteria;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Material m_OverDrawMaterial;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private FilteringSettings m_FilteringSettings;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RenderStateBlock m_RenderStateBlock;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<ShaderTagId> m_ShaderTagIds;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1E813A8", Offset = "0x1E813A8", VA = "0x1E813A8")]
	public OverDrawRenderPass(SortingCriteria criteria, RenderQueueRange renderQueueRange, Material overdrawMaterial)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1E81564", Offset = "0x1E81564", VA = "0x1E81564", Slot = "7")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
[Token(Token = "0x2000006")]
public class OverDrawRenderPipeline : RenderPipeline
{
	[Token(Token = "0x400000C")]
	private const string BUFF_NAME = "Render Camera";

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CommandBuffer s_CommandBuffer;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CullingResults cullingResults;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Material s_OverQueue;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Material s_OverTransparent;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static ShaderTagId[] s_ShaderTagIds;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1E81730", Offset = "0x1E81730", VA = "0x1E81730", Slot = "4")]
	protected override void Render(ScriptableRenderContext context, Camera[] cameras)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1E817B8", Offset = "0x1E817B8", VA = "0x1E817B8")]
	public void Render(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1E81D54", Offset = "0x1E81D54", VA = "0x1E81D54")]
	public OverDrawRenderPipeline()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x117D280", Offset = "0x117D280")]
public class OverDrawRenderPipelineAsset : RenderPipelineAsset
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1E82000", Offset = "0x1E82000", VA = "0x1E82000", Slot = "22")]
	protected override RenderPipeline CreatePipeline()
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1E8205C", Offset = "0x1E8205C", VA = "0x1E8205C")]
	public OverDrawRenderPipelineAsset()
	{
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public enum Axis
	{
		[Token(Token = "0x4000013")]
		X,
		[Token(Token = "0x4000014")]
		Y,
		[Token(Token = "0x4000015")]
		Z
	}
	[Token(Token = "0x2000009")]
	public class AxisTools
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2817F6C", Offset = "0x2817F6C", VA = "0x2817F6C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2818024", Offset = "0x2818024", VA = "0x2818024")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x28180D0", Offset = "0x28180D0", VA = "0x28180D0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x28182B4", Offset = "0x28182B4", VA = "0x28182B4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x28181EC", Offset = "0x28181EC", VA = "0x28181EC")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x28183D0", Offset = "0x28183D0", VA = "0x28183D0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2818418", Offset = "0x2818418", VA = "0x2818418")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x28186E0", Offset = "0x28186E0", VA = "0x28186E0")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public class LimbOrientation
		{
			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x28189A8", Offset = "0x28189A8", VA = "0x28189A8")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000003")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2818734", Offset = "0x2818734", VA = "0x2818734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2818A20", Offset = "0x2818A20", VA = "0x2818A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x28186E8", Offset = "0x28186E8", VA = "0x28186E8")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000090")]
		public enum BoneType
		{
			[Token(Token = "0x40003C9")]
			Unassigned,
			[Token(Token = "0x40003CA")]
			Spine,
			[Token(Token = "0x40003CB")]
			Head,
			[Token(Token = "0x40003CC")]
			Arm,
			[Token(Token = "0x40003CD")]
			Leg,
			[Token(Token = "0x40003CE")]
			Tail,
			[Token(Token = "0x40003CF")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		public enum BoneSide
		{
			[Token(Token = "0x40003D1")]
			Center,
			[Token(Token = "0x40003D2")]
			Left,
			[Token(Token = "0x40003D3")]
			Right
		}

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2818C94", Offset = "0x2818C94", VA = "0x2818C94")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2818F94", Offset = "0x2818F94", VA = "0x2818F94")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x28191E4", Offset = "0x28191E4", VA = "0x28191E4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2819268", Offset = "0x2819268", VA = "0x2819268")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2819314", Offset = "0x2819314", VA = "0x2819314")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2818E44", Offset = "0x2818E44", VA = "0x2818E44")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2819144", Offset = "0x2819144", VA = "0x2819144")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2819B54", Offset = "0x2819B54", VA = "0x2819B54")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x281996C", Offset = "0x281996C", VA = "0x281996C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2819A60", Offset = "0x2819A60", VA = "0x2819A60")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2819534", Offset = "0x2819534", VA = "0x2819534")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x28195E8", Offset = "0x28195E8", VA = "0x28195E8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x281969C", Offset = "0x281969C", VA = "0x281969C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2819750", Offset = "0x2819750", VA = "0x2819750")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2819804", Offset = "0x2819804", VA = "0x2819804")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x28198B8", Offset = "0x28198B8", VA = "0x28198B8")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2819D68", Offset = "0x2819D68", VA = "0x2819D68")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2819448", Offset = "0x2819448", VA = "0x2819448")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2819CD8", Offset = "0x2819CD8", VA = "0x2819CD8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2819DD8", Offset = "0x2819DD8", VA = "0x2819DD8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2819EB0", Offset = "0x2819EB0", VA = "0x2819EB0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2819C5C", Offset = "0x2819C5C", VA = "0x2819C5C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2819BE4", Offset = "0x2819BE4", VA = "0x2819BE4")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BipedReferences
	{
		[Token(Token = "0x2000092")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700009D")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x281EE40", Offset = "0x281EE40", VA = "0x281EE40")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x281EE2C", Offset = "0x281EE2C", VA = "0x281EE2C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000005")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x281BA24", Offset = "0x281BA24", VA = "0x281BA24", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000006")]
		public bool isEmpty
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x281BE10", Offset = "0x281BE10", VA = "0x281BE10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x281BE20", Offset = "0x281BE20", VA = "0x281BE20", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x281C24C", Offset = "0x281C24C", VA = "0x281C24C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x281C684", Offset = "0x281C684", VA = "0x281C684")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x281CC94", Offset = "0x281CC94", VA = "0x281CC94")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x281C8D0", Offset = "0x281C8D0", VA = "0x281C8D0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x281D444", Offset = "0x281D444", VA = "0x281D444")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x281D538", Offset = "0x281D538", VA = "0x281D538")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x281DA90", Offset = "0x281DA90", VA = "0x281DA90")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x281D894", Offset = "0x281D894", VA = "0x281D894")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x281D70C", Offset = "0x281D70C", VA = "0x281D70C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x281D5D8", Offset = "0x281D5D8", VA = "0x281D5D8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x281D998", Offset = "0x281D998", VA = "0x281D998")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x281DB8C", Offset = "0x281DB8C", VA = "0x281DB8C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x281E62C", Offset = "0x281E62C", VA = "0x281E62C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x281E110", Offset = "0x281E110", VA = "0x281E110")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x281E920", Offset = "0x281E920", VA = "0x281E920")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x281E450", Offset = "0x281E450", VA = "0x281E450")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x281E928", Offset = "0x281E928", VA = "0x281E928")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x281E930", Offset = "0x281E930", VA = "0x281E930")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x281EAF0", Offset = "0x281EAF0", VA = "0x281EAF0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x281ED08", Offset = "0x281ED08", VA = "0x281ED08")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x281C860", Offset = "0x281C860", VA = "0x281C860")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x281EE48", Offset = "0x281EE48", VA = "0x281EE48")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x281EE50", Offset = "0x281EE50", VA = "0x281EE50")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x281EF90", Offset = "0x281EF90", VA = "0x281EF90")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class Hierarchy
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2A005B4", Offset = "0x2A005B4", VA = "0x2A005B4")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2A007B4", Offset = "0x2A007B4", VA = "0x2A007B4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2A0064C", Offset = "0x2A0064C", VA = "0x2A0064C")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2A008D8", Offset = "0x2A008D8", VA = "0x2A008D8")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2A009FC", Offset = "0x2A009FC", VA = "0x2A009FC")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2A00CA4", Offset = "0x2A00CA4", VA = "0x2A00CA4")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2A00DC0", Offset = "0x2A00DC0", VA = "0x2A00DC0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2A00F48", Offset = "0x2A00F48", VA = "0x2A00F48")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2A012DC", Offset = "0x2A012DC", VA = "0x2A012DC")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2A010C8", Offset = "0x2A010C8", VA = "0x2A010C8")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2A0147C", Offset = "0x2A0147C", VA = "0x2A0147C")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2A01484", Offset = "0x2A01484", VA = "0x2A01484")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A014F4", Offset = "0x2A014F4", VA = "0x2A014F4")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000043")]
		None,
		[Token(Token = "0x4000044")]
		InOutCubic,
		[Token(Token = "0x4000045")]
		InOutQuintic,
		[Token(Token = "0x4000046")]
		InOutSine,
		[Token(Token = "0x4000047")]
		InQuintic,
		[Token(Token = "0x4000048")]
		InQuartic,
		[Token(Token = "0x4000049")]
		InCubic,
		[Token(Token = "0x400004A")]
		InQuadratic,
		[Token(Token = "0x400004B")]
		InElastic,
		[Token(Token = "0x400004C")]
		InElasticSmall,
		[Token(Token = "0x400004D")]
		InElasticBig,
		[Token(Token = "0x400004E")]
		InSine,
		[Token(Token = "0x400004F")]
		InBack,
		[Token(Token = "0x4000050")]
		OutQuintic,
		[Token(Token = "0x4000051")]
		OutQuartic,
		[Token(Token = "0x4000052")]
		OutCubic,
		[Token(Token = "0x4000053")]
		OutInCubic,
		[Token(Token = "0x4000054")]
		OutInQuartic,
		[Token(Token = "0x4000055")]
		OutElastic,
		[Token(Token = "0x4000056")]
		OutElasticSmall,
		[Token(Token = "0x4000057")]
		OutElasticBig,
		[Token(Token = "0x4000058")]
		OutSine,
		[Token(Token = "0x4000059")]
		OutBack,
		[Token(Token = "0x400005A")]
		OutBackCubic,
		[Token(Token = "0x400005B")]
		OutBackQuartic,
		[Token(Token = "0x400005C")]
		BackInCubic,
		[Token(Token = "0x400005D")]
		BackInQuartic
	}
	[Token(Token = "0x2000012")]
	public class Interp
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A01564", Offset = "0x2A01564", VA = "0x2A01564")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A01FCC", Offset = "0x2A01FCC", VA = "0x2A01FCC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A020D4", Offset = "0x2A020D4", VA = "0x2A020D4")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2A018D0", Offset = "0x2A018D0", VA = "0x2A018D0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2A018DC", Offset = "0x2A018DC", VA = "0x2A018DC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A01900", Offset = "0x2A01900", VA = "0x2A01900")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A0193C", Offset = "0x2A0193C", VA = "0x2A0193C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2A01954", Offset = "0x2A01954", VA = "0x2A01954")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A01968", Offset = "0x2A01968", VA = "0x2A01968")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2A0197C", Offset = "0x2A0197C", VA = "0x2A0197C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2A0198C", Offset = "0x2A0198C", VA = "0x2A0198C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2A019D4", Offset = "0x2A019D4", VA = "0x2A019D4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2A01A0C", Offset = "0x2A01A0C", VA = "0x2A01A0C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2A01A34", Offset = "0x2A01A34", VA = "0x2A01A34")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2A021D0", Offset = "0x2A021D0", VA = "0x2A021D0")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2A01A68", Offset = "0x2A01A68", VA = "0x2A01A68")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2A01A90", Offset = "0x2A01A90", VA = "0x2A01A90")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A01AC0", Offset = "0x2A01AC0", VA = "0x2A01AC0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2A01AF4", Offset = "0x2A01AF4", VA = "0x2A01AF4")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2A01B38", Offset = "0x2A01B38", VA = "0x2A01B38")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2A01B9C", Offset = "0x2A01B9C", VA = "0x2A01B9C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2A01C00", Offset = "0x2A01C00", VA = "0x2A01C00")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2A01C54", Offset = "0x2A01C54", VA = "0x2A01C54")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2A01CA8", Offset = "0x2A01CA8", VA = "0x2A01CA8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2A01D40", Offset = "0x2A01D40", VA = "0x2A01D40")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2A01DD4", Offset = "0x2A01DD4", VA = "0x2A01DD4")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2A02204", Offset = "0x2A02204", VA = "0x2A02204")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2A01E78", Offset = "0x2A01E78", VA = "0x2A01E78")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2A01F5C", Offset = "0x2A01F5C", VA = "0x2A01F5C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2A01F8C", Offset = "0x2A01F8C", VA = "0x2A01F8C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2A022EC", Offset = "0x2A022EC", VA = "0x2A022EC")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2A022F4", Offset = "0x2A022F4", VA = "0x2A022F4")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2A02364", Offset = "0x2A02364", VA = "0x2A02364")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2A023D4", Offset = "0x2A023D4", VA = "0x2A023D4")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A0242C", Offset = "0x2A0242C", VA = "0x2A0242C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2A024F8", Offset = "0x2A024F8", VA = "0x2A024F8")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2A02444", Offset = "0x2A02444", VA = "0x2A02444")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2A02510", Offset = "0x2A02510", VA = "0x2A02510")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2A025B4", Offset = "0x2A025B4", VA = "0x2A025B4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2A025E0", Offset = "0x2A025E0", VA = "0x2A025E0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2A02630", Offset = "0x2A02630", VA = "0x2A02630")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2A0269C", Offset = "0x2A0269C", VA = "0x2A0269C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2A02790", Offset = "0x2A02790", VA = "0x2A02790")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2A02868", Offset = "0x2A02868", VA = "0x2A02868")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2A028C8", Offset = "0x2A028C8", VA = "0x2A028C8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	public static class QuaTools
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2A028F8", Offset = "0x2A028F8", VA = "0x2A028F8")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2A029FC", Offset = "0x2A029FC", VA = "0x2A029FC")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2A02AFC", Offset = "0x2A02AFC", VA = "0x2A02AFC")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2A02CF8", Offset = "0x2A02CF8", VA = "0x2A02CF8")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2A02E6C", Offset = "0x2A02E6C", VA = "0x2A02E6C")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2A02FD8", Offset = "0x2A02FD8", VA = "0x2A02FD8")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2A03234", Offset = "0x2A03234", VA = "0x2A03234")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2A03380", Offset = "0x2A03380", VA = "0x2A03380")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2A034CC", Offset = "0x2A034CC", VA = "0x2A034CC")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2A035E0", Offset = "0x2A035E0", VA = "0x2A035E0")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2A036F4", Offset = "0x2A036F4", VA = "0x2A036F4")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2A03880", Offset = "0x2A03880", VA = "0x2A03880")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x29F3CFC", Offset = "0x29F3CFC", VA = "0x29F3CFC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2A03950", Offset = "0x2A03950", VA = "0x2A03950")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2A03BD4", Offset = "0x2A03BD4", VA = "0x2A03BD4")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2A03DE8", Offset = "0x2A03DE8", VA = "0x2A03DE8")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x29FCC60", Offset = "0x29FCC60", VA = "0x29FCC60")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2A03F68", Offset = "0x2A03F68", VA = "0x2A03F68")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2A04078", Offset = "0x2A04078", VA = "0x2A04078")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000016")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000007")]
		public static T instance
		{
			[Token(Token = "0x600009D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009E")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600009F")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E258", Offset = "0x117E258")]
		public bool fixTransforms;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsSkipUpdate;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000008")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2A04214", Offset = "0x2A04214", VA = "0x2A04214")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		private bool isAnimated
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2A04510", Offset = "0x2A04510", VA = "0x2A04510")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2A040D4", Offset = "0x2A040D4", VA = "0x2A040D4")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2A0416C", Offset = "0x2A0416C", VA = "0x2A0416C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2A04170", Offset = "0x2A04170", VA = "0x2A04170", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2A04174", Offset = "0x2A04174", VA = "0x2A04174", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A04178", Offset = "0x2A04178", VA = "0x2A04178")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2A04210", Offset = "0x2A04210", VA = "0x2A04210")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2A041B0", Offset = "0x2A041B0", VA = "0x2A041B0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2A044C4", Offset = "0x2A044C4", VA = "0x2A044C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2A04304", Offset = "0x2A04304", VA = "0x2A04304")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2A045CC", Offset = "0x2A045CC", VA = "0x2A045CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2A04630", Offset = "0x2A04630", VA = "0x2A04630")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2A0468C", Offset = "0x2A0468C", VA = "0x2A0468C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x29F237C", Offset = "0x29F237C", VA = "0x29F237C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2A046D4", Offset = "0x2A046D4", VA = "0x2A046D4")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2A0478C", Offset = "0x2A0478C", VA = "0x2A0478C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2A04844", Offset = "0x2A04844", VA = "0x2A04844")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2A048FC", Offset = "0x2A048FC", VA = "0x2A048FC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class V2Tools
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2A04904", Offset = "0x2A04904", VA = "0x2A04904")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2A04934", Offset = "0x2A04934", VA = "0x2A04934")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2A049E0", Offset = "0x2A049E0", VA = "0x2A049E0")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2A04A8C", Offset = "0x2A04A8C", VA = "0x2A04A8C")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2A04C5C", Offset = "0x2A04C5C", VA = "0x2A04C5C")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001A")]
	public static class V3Tools
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2A04DC4", Offset = "0x2A04DC4", VA = "0x2A04DC4")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2A04E48", Offset = "0x2A04E48", VA = "0x2A04E48")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2A04EE8", Offset = "0x2A04EE8", VA = "0x2A04EE8")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2A0502C", Offset = "0x2A0502C", VA = "0x2A0502C")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2A0514C", Offset = "0x2A0514C", VA = "0x2A0514C")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2A05264", Offset = "0x2A05264", VA = "0x2A05264")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2A05428", Offset = "0x2A05428", VA = "0x2A05428")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2A05520", Offset = "0x2A05520", VA = "0x2A05520")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2A05618", Offset = "0x2A05618", VA = "0x2A05618")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2A05710", Offset = "0x2A05710", VA = "0x2A05710")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2A05810", Offset = "0x2A05810", VA = "0x2A05810")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2A05A34", Offset = "0x2A05A34", VA = "0x2A05A34")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2A05C70", Offset = "0x2A05C70", VA = "0x2A05C70")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2A05EC0", Offset = "0x2A05EC0", VA = "0x2A05EC0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2A060C0", Offset = "0x2A060C0", VA = "0x2A060C0")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2A0629C", Offset = "0x2A0629C", VA = "0x2A0629C")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2A063D0", Offset = "0x2A063D0", VA = "0x2A063D0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2A06528", Offset = "0x2A06528", VA = "0x2A06528")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2A066B4", Offset = "0x2A066B4", VA = "0x2A066B4")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2A06674", Offset = "0x2A06674", VA = "0x2A06674")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200001B")]
	public static class Warning
	{
		[Token(Token = "0x2000093")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2A067F0", Offset = "0x2A067F0", VA = "0x2A067F0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x29F5828", Offset = "0x29F5828", VA = "0x29F5828")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x200001C")]
	public class Navigator
	{
		[Token(Token = "0x2000094")]
		public enum State
		{
			[Token(Token = "0x40003D7")]
			Idle,
			[Token(Token = "0x40003D8")]
			Seeking,
			[Token(Token = "0x40003D9")]
			OnPath
		}

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E290", Offset = "0x117E290")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E2C8", Offset = "0x117E2C8")]
		public float cornerRadius;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E300", Offset = "0x117E300")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E338", Offset = "0x117E338")]
		public float maxSampleDistance;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E370", Offset = "0x117E370")]
		public float nextPathInterval;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E3A8", Offset = "0x117E3A8")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E3B8", Offset = "0x117E3B8")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x1700000A")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x281EFC4", Offset = "0x281EFC4", VA = "0x281EFC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184F80", Offset = "0x1184F80")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x281EFD0", Offset = "0x281EFD0", VA = "0x281EFD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184F90", Offset = "0x1184F90")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public State state
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x281EFDC", Offset = "0x281EFDC", VA = "0x281EFDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184FA0", Offset = "0x1184FA0")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x281EFE4", Offset = "0x281EFE4", VA = "0x281EFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184FB0", Offset = "0x1184FB0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x281EFEC", Offset = "0x281EFEC", VA = "0x281EFEC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x281F0C0", Offset = "0x281F0C0", VA = "0x281F0C0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x281F604", Offset = "0x281F604", VA = "0x281F604")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x281F674", Offset = "0x281F674", VA = "0x281F674")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x281F4CC", Offset = "0x281F4CC", VA = "0x281F4CC")]
		private void Stop()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x281F540", Offset = "0x281F540", VA = "0x281F540")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x281F7BC", Offset = "0x281F7BC", VA = "0x281F7BC")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x281F96C", Offset = "0x281F96C", VA = "0x281F96C")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D2CC", Offset = "0x117D2CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D2CC", Offset = "0x117D2CC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2821BAC", Offset = "0x2821BAC", VA = "0x2821BAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1184FC0", Offset = "0x1184FC0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2821BF8", Offset = "0x2821BF8", VA = "0x2821BF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1184FF8", Offset = "0x1184FF8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2821C44", Offset = "0x2821C44", VA = "0x2821C44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185030", Offset = "0x1185030")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2821C90", Offset = "0x2821C90", VA = "0x2821C90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185068", Offset = "0x1185068")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2821CDC", Offset = "0x2821CDC", VA = "0x2821CDC")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2821D78", Offset = "0x2821D78", VA = "0x2821D78")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2821D98", Offset = "0x2821D98", VA = "0x2821D98")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2821DC8", Offset = "0x2821DC8", VA = "0x2821DC8")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2821DF8", Offset = "0x2821DF8", VA = "0x2821DF8")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2821E38", Offset = "0x2821E38", VA = "0x2821E38")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2821E7C", Offset = "0x2821E7C", VA = "0x2821E7C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2821EA0", Offset = "0x2821EA0", VA = "0x2821EA0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2821EC4", Offset = "0x2821EC4", VA = "0x2821EC4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2821EEC", Offset = "0x2821EEC", VA = "0x2821EEC")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2821F18", Offset = "0x2821F18", VA = "0x2821F18")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2821F44", Offset = "0x2821F44", VA = "0x2821F44")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2821CFC", Offset = "0x2821CFC", VA = "0x2821CFC")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2821F6C", Offset = "0x2821F6C", VA = "0x2821F6C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2821F78", Offset = "0x2821F78", VA = "0x2821F78")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2821F84", Offset = "0x2821F84", VA = "0x2821F84")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x282226C", Offset = "0x282226C", VA = "0x282226C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2822314", Offset = "0x2822314", VA = "0x2822314", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2822658", Offset = "0x2822658", VA = "0x2822658", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2822B40", Offset = "0x2822B40", VA = "0x2822B40")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2822B74", Offset = "0x2822B74", VA = "0x2822B74")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000C")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2822124", Offset = "0x2822124", VA = "0x2822124")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2822D3C", Offset = "0x2822D3C", VA = "0x2822D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x28224E0", Offset = "0x28224E0", VA = "0x28224E0")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2822BF4", Offset = "0x2822BF4", VA = "0x2822BF4")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700000E")]
		public bool isValid
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x2823814", Offset = "0x2823814", VA = "0x2823814")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F9")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2823884", Offset = "0x2823884", VA = "0x2823884")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x282388C", Offset = "0x282388C", VA = "0x282388C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2823998", Offset = "0x2823998", VA = "0x2823998")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x28239A0", Offset = "0x28239A0", VA = "0x28239A0")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700000F")]
		private bool positionChanged
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2823B68", Offset = "0x2823B68", VA = "0x2823B68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x28239CC", Offset = "0x28239CC", VA = "0x28239CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2823C24", Offset = "0x2823C24", VA = "0x2823C24")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2823C2C", Offset = "0x2823C2C", VA = "0x2823C2C")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2823C58", Offset = "0x2823C58", VA = "0x2823C58", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2823D80", Offset = "0x2823D80", VA = "0x2823D80")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2823D88", Offset = "0x2823D88", VA = "0x2823D88")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000010")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2823F54", Offset = "0x2823F54", VA = "0x2823F54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2823DB4", Offset = "0x2823DB4", VA = "0x2823DB4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2824024", Offset = "0x2824024", VA = "0x2824024")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x282402C", Offset = "0x282402C", VA = "0x282402C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class Constraints
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117E3C8", Offset = "0x117E3C8")]
		public float positionWeight;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117E3E0", Offset = "0x117E3E0")]
		public float rotationWeight;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2824058", Offset = "0x2824058", VA = "0x2824058")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2822604", Offset = "0x2822604", VA = "0x2822604")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x28227E0", Offset = "0x28227E0", VA = "0x28227E0")]
		public void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2822F08", Offset = "0x2822F08", VA = "0x2822F08")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000095")]
		public enum DOF
		{
			[Token(Token = "0x40003DB")]
			One,
			[Token(Token = "0x40003DC")]
			Three
		}

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E3F8", Offset = "0x117E3F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117E3F8", Offset = "0x117E3F8")]
		public float weight;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E44C", Offset = "0x117E44C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117E44C", Offset = "0x117E44C")]
		public float rotationWeight;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E4A0", Offset = "0x117E4A0")]
		public DOF rotationDOF;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E4D8", Offset = "0x117E4D8")]
		public bool fixBone1Twist;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E510", Offset = "0x117E510")]
		public Transform bone1;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E548", Offset = "0x117E548")]
		public Transform bone2;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E580", Offset = "0x117E580")]
		public Transform bone3;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E5B8", Offset = "0x117E5B8")]
		public Transform tip;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E5F0", Offset = "0x117E5F0")]
		public Transform target;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E628", Offset = "0x117E628")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000011")]
		public bool initiated
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x282BEB0", Offset = "0x282BEB0", VA = "0x282BEB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11850A0", Offset = "0x11850A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x282BEB8", Offset = "0x282BEB8", VA = "0x282BEB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11850B0", Offset = "0x11850B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x282BEC4", Offset = "0x282BEC4", VA = "0x282BEC4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x282BEE4", Offset = "0x282BEE4", VA = "0x282BEE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x282BF04", Offset = "0x282BF04", VA = "0x282BF04")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x282BF24", Offset = "0x282BF24", VA = "0x282BF24")]
			set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x282BF44", Offset = "0x282BF44", VA = "0x282BF44")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x282C044", Offset = "0x282C044", VA = "0x282C044")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x282C6D8", Offset = "0x282C6D8", VA = "0x282C6D8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x282C7B4", Offset = "0x282C7B4", VA = "0x282C7B4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x282C87C", Offset = "0x282C87C", VA = "0x282C87C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x282CE98", Offset = "0x282CE98", VA = "0x282CE98")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E638", Offset = "0x117E638")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117E638", Offset = "0x117E638")]
		public float weight;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E68C", Offset = "0x117E68C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x282CEA8", Offset = "0x282CEA8", VA = "0x282CEA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11850C0", Offset = "0x11850C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x282CEB0", Offset = "0x282CEB0", VA = "0x282CEB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11850D0", Offset = "0x11850D0")]
			private set
			{
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x282CEBC", Offset = "0x282CEBC", VA = "0x282CEBC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x282CF44", Offset = "0x282CF44", VA = "0x282CF44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11850E0", Offset = "0x11850E0")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x282D268", Offset = "0x282D268", VA = "0x282D268")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x282D3D8", Offset = "0x282D3D8", VA = "0x282D3D8")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x282D160", Offset = "0x282D160", VA = "0x282D160")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x282D540", Offset = "0x282D540", VA = "0x282D540", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x282D600", Offset = "0x282D600", VA = "0x282D600")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x282D678", Offset = "0x282D678", VA = "0x282D678")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x282D6EC", Offset = "0x282D6EC", VA = "0x282D6EC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x282D754", Offset = "0x282D754", VA = "0x282D754", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x282D758", Offset = "0x282D758", VA = "0x282D758", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x282D76C", Offset = "0x282D76C", VA = "0x282D76C")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000096")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E69C", Offset = "0x117E69C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117E69C", Offset = "0x117E69C")]
		public float weight;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E6F0", Offset = "0x117E6F0")]
		public Grounding solver;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E728", Offset = "0x117E728")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x282E76C", Offset = "0x282E76C", VA = "0x282E76C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185118", Offset = "0x1185118")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x282E774", Offset = "0x282E774", VA = "0x282E774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185128", Offset = "0x1185128")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000127")]
		public abstract void ResetPosition();

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x282E780", Offset = "0x282E780", VA = "0x282E780")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x282EA54", Offset = "0x282EA54", VA = "0x282EA54")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x282E8C4", Offset = "0x282E8C4", VA = "0x282E8C4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x282EA88", Offset = "0x282EA88", VA = "0x282EA88")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600012F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x282EC90", Offset = "0x282EC90", VA = "0x282EC90")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D32C", Offset = "0x117D32C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D32C", Offset = "0x117D32C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E738", Offset = "0x117E738")]
		public BipedIK ik;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E770", Offset = "0x117E770")]
		public float spineBend;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E7A8", Offset = "0x117E7A8")]
		public float spineSpeed;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x274DCE0", Offset = "0x274DCE0", VA = "0x274DCE0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185138", Offset = "0x1185138")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x274DD2C", Offset = "0x274DD2C", VA = "0x274DD2C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185170", Offset = "0x1185170")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x274DD78", Offset = "0x274DD78", VA = "0x274DD78", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x274DE7C", Offset = "0x274DE7C", VA = "0x274DE7C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x274DF2C", Offset = "0x274DF2C", VA = "0x274DF2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x274DFE0", Offset = "0x274DFE0", VA = "0x274DFE0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x274E4F4", Offset = "0x274E4F4", VA = "0x274E4F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x274E548", Offset = "0x274E548", VA = "0x274E548")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x274ED60", Offset = "0x274ED60", VA = "0x274ED60")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x274EEC0", Offset = "0x274EEC0", VA = "0x274EEC0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x274F050", Offset = "0x274F050", VA = "0x274F050")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x274F1B0", Offset = "0x274F1B0", VA = "0x274F1B0")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D38C", Offset = "0x117D38C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D38C", Offset = "0x117D38C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000097")]
		public class SpineEffector
		{
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181A8C", Offset = "0x1181A8C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181AC4", Offset = "0x1181AC4")]
			public float horizontalWeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181AFC", Offset = "0x1181AFC")]
			public float verticalWeight;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x275000C", Offset = "0x275000C", VA = "0x275000C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x275001C", Offset = "0x275001C", VA = "0x275001C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E7E0", Offset = "0x117E7E0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E818", Offset = "0x117E818")]
		public float spineBend;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E850", Offset = "0x117E850")]
		public float spineSpeed;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x274F234", Offset = "0x274F234", VA = "0x274F234")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11851A8", Offset = "0x11851A8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x274F280", Offset = "0x274F280", VA = "0x274F280", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11851E0", Offset = "0x11851E0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x274F2CC", Offset = "0x274F2CC", VA = "0x274F2CC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185218", Offset = "0x1185218")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x274F318", Offset = "0x274F318", VA = "0x274F318", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x274F398", Offset = "0x274F398", VA = "0x274F398")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x274F430", Offset = "0x274F430", VA = "0x274F430")]
		private void Update()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x274F6E0", Offset = "0x274F6E0", VA = "0x274F6E0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x274F6EC", Offset = "0x274F6EC", VA = "0x274F6EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x274F4EC", Offset = "0x274F4EC", VA = "0x274F4EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x274F6F8", Offset = "0x274F6F8", VA = "0x274F6F8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x274FB9C", Offset = "0x274FB9C", VA = "0x274FB9C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x274FD5C", Offset = "0x274FD5C", VA = "0x274FD5C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x274FE94", Offset = "0x274FE94", VA = "0x274FE94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x274FF88", Offset = "0x274FF88", VA = "0x274FF88")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D3EC", Offset = "0x117D3EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D3EC", Offset = "0x117D3EC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E888", Offset = "0x117E888")]
		public Transform pelvis;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E8C0", Offset = "0x117E8C0")]
		public Transform characterRoot;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E8F8", Offset = "0x117E8F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117E8F8", Offset = "0x117E8F8")]
		public float rootRotationWeight;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E94C", Offset = "0x117E94C")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E984", Offset = "0x117E984")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2750064", Offset = "0x2750064", VA = "0x2750064", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185250", Offset = "0x1185250")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x27500B0", Offset = "0x27500B0", VA = "0x27500B0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185288", Offset = "0x1185288")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x27500FC", Offset = "0x27500FC", VA = "0x27500FC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2750114", Offset = "0x2750114", VA = "0x2750114")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x27502F0", Offset = "0x27502F0", VA = "0x27502F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x27503F0", Offset = "0x27503F0", VA = "0x27503F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2750B38", Offset = "0x2750B38", VA = "0x2750B38")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2750F14", Offset = "0x2750F14", VA = "0x2750F14")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2751184", Offset = "0x2751184", VA = "0x2751184")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x27514A4", Offset = "0x27514A4", VA = "0x27514A4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2751640", Offset = "0x2751640", VA = "0x2751640")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2751800", Offset = "0x2751800", VA = "0x2751800")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D44C", Offset = "0x117D44C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D44C", Offset = "0x117D44C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000098")]
		public struct Foot
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x2752350", Offset = "0x2752350", VA = "0x2752350")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E9BC", Offset = "0x117E9BC")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117E9F4", Offset = "0x117E9F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117E9F4", Offset = "0x117E9F4")]
		public float rootRotationWeight;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EA48", Offset = "0x117EA48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117EA48", Offset = "0x117EA48")]
		public float minRootRotation;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EAA0", Offset = "0x117EAA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117EAA0", Offset = "0x117EAA0")]
		public float maxRootRotation;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EAF8", Offset = "0x117EAF8")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EB30", Offset = "0x117EB30")]
		public float maxLegOffset;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EB68", Offset = "0x117EB68")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EBA0", Offset = "0x117EBA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117EBA0", Offset = "0x117EBA0")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EBF4", Offset = "0x117EBF4")]
		public Transform characterRoot;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EC2C", Offset = "0x117EC2C")]
		public Transform pelvis;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EC64", Offset = "0x117EC64")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EC9C", Offset = "0x117EC9C")]
		public Transform head;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2751884", Offset = "0x2751884", VA = "0x2751884", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11852C0", Offset = "0x11852C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x27518D0", Offset = "0x27518D0", VA = "0x27518D0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11852F8", Offset = "0x11852F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x275191C", Offset = "0x275191C", VA = "0x275191C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2751950", Offset = "0x2751950", VA = "0x2751950")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2751A80", Offset = "0x2751A80", VA = "0x2751A80")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2751C2C", Offset = "0x2751C2C", VA = "0x2751C2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2751C94", Offset = "0x2751C94", VA = "0x2751C94")]
		private void Update()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2751D4C", Offset = "0x2751D4C", VA = "0x2751D4C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x275204C", Offset = "0x275204C", VA = "0x275204C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2752390", Offset = "0x2752390", VA = "0x2752390")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x27524DC", Offset = "0x27524DC", VA = "0x27524DC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2752980", Offset = "0x2752980", VA = "0x2752980")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2753170", Offset = "0x2753170", VA = "0x2753170")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2753430", Offset = "0x2753430", VA = "0x2753430")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2753590", Offset = "0x2753590", VA = "0x2753590")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x275386C", Offset = "0x275386C", VA = "0x275386C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x27538A4", Offset = "0x27538A4", VA = "0x27538A4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2753A5C", Offset = "0x2753A5C", VA = "0x2753A5C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D4AC", Offset = "0x117D4AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D4AC", Offset = "0x117D4AC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117ECE4", Offset = "0x117ECE4")]
		public VRIK ik;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2753BCC", Offset = "0x2753BCC", VA = "0x2753BCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185330", Offset = "0x1185330")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2753C18", Offset = "0x2753C18", VA = "0x2753C18", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185368", Offset = "0x1185368")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2753C64", Offset = "0x2753C64", VA = "0x2753C64", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11853A0", Offset = "0x11853A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2753CB0", Offset = "0x2753CB0", VA = "0x2753CB0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2753CC8", Offset = "0x2753CC8", VA = "0x2753CC8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2753D60", Offset = "0x2753D60", VA = "0x2753D60")]
		private void Update()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2753E14", Offset = "0x2753E14", VA = "0x2753E14")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2754004", Offset = "0x2754004", VA = "0x2754004")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2754298", Offset = "0x2754298", VA = "0x2754298")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x27543A0", Offset = "0x27543A0", VA = "0x27543A0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x27545A0", Offset = "0x27545A0", VA = "0x27545A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x27546D8", Offset = "0x27546D8", VA = "0x27546D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2754828", Offset = "0x2754828", VA = "0x2754828")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000099")]
		public enum Quality
		{
			[Token(Token = "0x40003E5")]
			Fastest,
			[Token(Token = "0x40003E6")]
			Simple,
			[Token(Token = "0x40003E7")]
			Best
		}

		[Token(Token = "0x200009A")]
		public class Leg
		{
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181B34", Offset = "0x1181B34")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181B44", Offset = "0x1181B44")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181B54", Offset = "0x1181B54")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181B64", Offset = "0x1181B64")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181B74", Offset = "0x1181B74")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181B84", Offset = "0x1181B84")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181B94", Offset = "0x1181B94")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181BA4", Offset = "0x1181BA4")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181BB4", Offset = "0x1181BB4")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700009E")]
			public bool isGrounded
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x2756284", Offset = "0x2756284", VA = "0x2756284")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187AC0", Offset = "0x1187AC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x275628C", Offset = "0x275628C", VA = "0x275628C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187AD0", Offset = "0x1187AD0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x2756298", Offset = "0x2756298", VA = "0x2756298")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187AE0", Offset = "0x1187AE0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x27562A4", Offset = "0x27562A4", VA = "0x27562A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187AF0", Offset = "0x1187AF0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public bool initiated
			{
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0x27562B0", Offset = "0x27562B0", VA = "0x27562B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B00", Offset = "0x1187B00")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0x27562B8", Offset = "0x27562B8", VA = "0x27562B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B10", Offset = "0x1187B10")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			public float heightFromGround
			{
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0x27562C4", Offset = "0x27562C4", VA = "0x27562C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B20", Offset = "0x1187B20")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005E7")]
				[Address(RVA = "0x27562CC", Offset = "0x27562CC", VA = "0x27562CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B30", Offset = "0x1187B30")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005E8")]
				[Address(RVA = "0x27562D4", Offset = "0x27562D4", VA = "0x27562D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B40", Offset = "0x1187B40")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E9")]
				[Address(RVA = "0x27562E0", Offset = "0x27562E0", VA = "0x27562E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B50", Offset = "0x1187B50")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			public Transform transform
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x27562EC", Offset = "0x27562EC", VA = "0x27562EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B60", Offset = "0x1187B60")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x27562F4", Offset = "0x27562F4", VA = "0x27562F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B70", Offset = "0x1187B70")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			public float IKOffset
			{
				[Token(Token = "0x60005EC")]
				[Address(RVA = "0x27562FC", Offset = "0x27562FC", VA = "0x27562FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B80", Offset = "0x1187B80")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005ED")]
				[Address(RVA = "0x2756304", Offset = "0x2756304", VA = "0x2756304")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187B90", Offset = "0x1187B90")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60005EE")]
				[Address(RVA = "0x275630C", Offset = "0x275630C", VA = "0x275630C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187BA0", Offset = "0x1187BA0")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60005EF")]
				[Address(RVA = "0x2756324", Offset = "0x2756324", VA = "0x2756324")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187BB0", Offset = "0x1187BB0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x2756344", Offset = "0x2756344", VA = "0x2756344")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187BC0", Offset = "0x1187BC0")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x275635C", Offset = "0x275635C", VA = "0x275635C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187BD0", Offset = "0x1187BD0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x275637C", Offset = "0x275637C", VA = "0x275637C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x170000A8")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x2757140", Offset = "0x2757140", VA = "0x2757140")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A9")]
			private float rootYOffset
			{
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x2757418", Offset = "0x2757418", VA = "0x2757418")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x27563C4", Offset = "0x27563C4", VA = "0x27563C4")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x2754EC4", Offset = "0x2754EC4", VA = "0x2754EC4")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x27563D8", Offset = "0x27563D8", VA = "0x27563D8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x2755DA4", Offset = "0x2755DA4", VA = "0x2755DA4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x2754FD0", Offset = "0x2754FD0", VA = "0x2754FD0")]
			public void Process()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x2756BB4", Offset = "0x2756BB4", VA = "0x2756BB4")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x2756424", Offset = "0x2756424", VA = "0x2756424")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x27572C0", Offset = "0x27572C0", VA = "0x27572C0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x2756860", Offset = "0x2756860", VA = "0x2756860")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x2756968", Offset = "0x2756968", VA = "0x2756968")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x27573BC", Offset = "0x27573BC", VA = "0x27573BC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x27571CC", Offset = "0x27571CC", VA = "0x27571CC")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x2757540", Offset = "0x2757540", VA = "0x2757540")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x2754E14", Offset = "0x2754E14", VA = "0x2754E14")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200009B")]
		public class Pelvis
		{
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181BC4", Offset = "0x1181BC4")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181BD4", Offset = "0x1181BD4")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000AA")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x2757630", Offset = "0x2757630", VA = "0x2757630")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187BE0", Offset = "0x1187BE0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x275763C", Offset = "0x275763C", VA = "0x275763C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187BF0", Offset = "0x1187BF0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			public float heightOffset
			{
				[Token(Token = "0x6000605")]
				[Address(RVA = "0x2757648", Offset = "0x2757648", VA = "0x2757648")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C00", Offset = "0x1187C00")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000606")]
				[Address(RVA = "0x2757650", Offset = "0x2757650", VA = "0x2757650")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C10", Offset = "0x1187C10")]
				private set
				{
				}
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x2754FA8", Offset = "0x2754FA8", VA = "0x2754FA8")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x2755CF4", Offset = "0x2755CF4", VA = "0x2755CF4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x2757658", Offset = "0x2757658", VA = "0x2757658")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x2755A88", Offset = "0x2755A88", VA = "0x2755A88")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x2754EBC", Offset = "0x2754EBC", VA = "0x2754EBC")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117ED1C", Offset = "0x117ED1C")]
		public LayerMask layers;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117ED54", Offset = "0x117ED54")]
		public float maxStep;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117ED8C", Offset = "0x117ED8C")]
		public float heightOffset;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EDC4", Offset = "0x117EDC4")]
		public float footSpeed;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EDFC", Offset = "0x117EDFC")]
		public float footRadius;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EE34", Offset = "0x117EE34")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EE80", Offset = "0x117EE80")]
		public float prediction;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EEB8", Offset = "0x117EEB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117EEB8", Offset = "0x117EEB8")]
		public float footRotationWeight;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EF0C", Offset = "0x117EF0C")]
		public float footRotationSpeed;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EF44", Offset = "0x117EF44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117EF44", Offset = "0x117EF44")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EF9C", Offset = "0x117EF9C")]
		public bool rotateSolver;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117EFD4", Offset = "0x117EFD4")]
		public float pelvisSpeed;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F00C", Offset = "0x117F00C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F00C", Offset = "0x117F00C")]
		public float pelvisDamper;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F060", Offset = "0x117F060")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F098", Offset = "0x117F098")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F0D0", Offset = "0x117F0D0")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F108", Offset = "0x117F108")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F140", Offset = "0x117F140")]
		public Quality quality;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117F178", Offset = "0x117F178")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117F188", Offset = "0x117F188")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117F198", Offset = "0x117F198")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117F1A8", Offset = "0x117F1A8")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117F1B8", Offset = "0x117F1B8")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000016")]
		public Leg[] legs
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2754888", Offset = "0x2754888", VA = "0x2754888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11853D8", Offset = "0x11853D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2754890", Offset = "0x2754890", VA = "0x2754890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11853E8", Offset = "0x11853E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2754898", Offset = "0x2754898", VA = "0x2754898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11853F8", Offset = "0x11853F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x27548A0", Offset = "0x27548A0", VA = "0x27548A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185408", Offset = "0x1185408")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool isGrounded
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x27548A8", Offset = "0x27548A8", VA = "0x27548A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185418", Offset = "0x1185418")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x27548B0", Offset = "0x27548B0", VA = "0x27548B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185428", Offset = "0x1185428")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Transform root
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x27548BC", Offset = "0x27548BC", VA = "0x27548BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185438", Offset = "0x1185438")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x27548C4", Offset = "0x27548C4", VA = "0x27548C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185448", Offset = "0x1185448")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x27548CC", Offset = "0x27548CC", VA = "0x27548CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185458", Offset = "0x1185458")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x27548E4", Offset = "0x27548E4", VA = "0x27548E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185468", Offset = "0x1185468")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2754904", Offset = "0x2754904", VA = "0x2754904")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 up
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x274EE34", Offset = "0x274EE34", VA = "0x274EE34")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001D")]
		private bool useRootRotation
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2755E58", Offset = "0x2755E58", VA = "0x2755E58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2754958", Offset = "0x2754958", VA = "0x2754958")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2754D38", Offset = "0x2754D38", VA = "0x2754D38")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x274E294", Offset = "0x274E294", VA = "0x274E294")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x274EAB8", Offset = "0x274EAB8", VA = "0x274EAB8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2750920", Offset = "0x2750920", VA = "0x2750920")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x274DDF8", Offset = "0x274DDF8", VA = "0x274DDF8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2754FB8", Offset = "0x2754FB8", VA = "0x2754FB8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2755F28", Offset = "0x2755F28", VA = "0x2755F28")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2756090", Offset = "0x2756090", VA = "0x2756090")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2756194", Offset = "0x2756194", VA = "0x2756194")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2753B78", Offset = "0x2753B78", VA = "0x2753B78")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D50C", Offset = "0x117D50C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D50C", Offset = "0x117D50C")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2820DD8", Offset = "0x2820DD8", VA = "0x2820DD8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185478", Offset = "0x1185478")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2820E24", Offset = "0x2820E24", VA = "0x2820E24", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11854B0", Offset = "0x11854B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2820E70", Offset = "0x2820E70", VA = "0x2820E70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11854E8", Offset = "0x11854E8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2820EBC", Offset = "0x2820EBC", VA = "0x2820EBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185520", Offset = "0x1185520")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2820F08", Offset = "0x2820F08", VA = "0x2820F08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185558", Offset = "0x1185558")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2820F54", Offset = "0x2820F54", VA = "0x2820F54", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2820F5C", Offset = "0x2820F5C", VA = "0x2820F5C")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D56C", Offset = "0x117D56C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D56C", Offset = "0x117D56C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2821A0C", Offset = "0x2821A0C", VA = "0x2821A0C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185590", Offset = "0x1185590")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2821A58", Offset = "0x2821A58", VA = "0x2821A58", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11855C8", Offset = "0x11855C8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2821AA4", Offset = "0x2821AA4", VA = "0x2821AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185600", Offset = "0x1185600")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2821AF0", Offset = "0x2821AF0", VA = "0x2821AF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185638", Offset = "0x1185638")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2821B3C", Offset = "0x2821B3C", VA = "0x2821B3C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2821B44", Offset = "0x2821B44", VA = "0x2821B44")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D5CC", Offset = "0x117D5CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D5CC", Offset = "0x117D5CC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2823674", Offset = "0x2823674", VA = "0x2823674", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185670", Offset = "0x1185670")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x28236C0", Offset = "0x28236C0", VA = "0x28236C0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11856A8", Offset = "0x11856A8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x282370C", Offset = "0x282370C", VA = "0x282370C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11856E0", Offset = "0x11856E0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2823758", Offset = "0x2823758", VA = "0x2823758")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185718", Offset = "0x1185718")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x28237A4", Offset = "0x28237A4", VA = "0x28237A4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x28237AC", Offset = "0x28237AC", VA = "0x28237AC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D62C", Offset = "0x117D62C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D62C", Offset = "0x117D62C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2824D54", Offset = "0x2824D54", VA = "0x2824D54", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185750", Offset = "0x1185750")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2824DA0", Offset = "0x2824DA0", VA = "0x2824DA0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185788", Offset = "0x1185788")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2824DEC", Offset = "0x2824DEC", VA = "0x2824DEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11857C0", Offset = "0x11857C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2824E38", Offset = "0x2824E38", VA = "0x2824E38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11857F8", Offset = "0x11857F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2824E84", Offset = "0x2824E84", VA = "0x2824E84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2824E8C", Offset = "0x2824E8C", VA = "0x2824E8C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D68C", Offset = "0x117D68C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D68C", Offset = "0x117D68C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x282550C", Offset = "0x282550C", VA = "0x282550C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185830", Offset = "0x1185830")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2825558", Offset = "0x2825558", VA = "0x2825558", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185868", Offset = "0x1185868")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x28255A4", Offset = "0x28255A4", VA = "0x28255A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11858A0", Offset = "0x11858A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x28255F0", Offset = "0x28255F0", VA = "0x28255F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11858D8", Offset = "0x11858D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x282563C", Offset = "0x282563C", VA = "0x282563C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2825644", Offset = "0x2825644", VA = "0x2825644")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D6EC", Offset = "0x117D6EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D6EC", Offset = "0x117D6EC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x282D7D4", Offset = "0x282D7D4", VA = "0x282D7D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185910", Offset = "0x1185910")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x282D820", Offset = "0x282D820", VA = "0x282D820", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185948", Offset = "0x1185948")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x282D86C", Offset = "0x282D86C", VA = "0x282D86C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185980", Offset = "0x1185980")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x282D8B8", Offset = "0x282D8B8", VA = "0x282D8B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11859B8", Offset = "0x11859B8")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x282D904", Offset = "0x282D904", VA = "0x282D904")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11859F0", Offset = "0x11859F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x282D950", Offset = "0x282D950", VA = "0x282D950")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185A28", Offset = "0x1185A28")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x282D99C", Offset = "0x282D99C", VA = "0x282D99C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x282D9C0", Offset = "0x282D9C0", VA = "0x282D9C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x282D9C8", Offset = "0x282D9C8", VA = "0x282D9C8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x282DB80", Offset = "0x282DB80", VA = "0x282DB80")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x282DED0", Offset = "0x282DED0", VA = "0x282DED0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185A60", Offset = "0x1185A60")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x282DEF0", Offset = "0x282DEF0", VA = "0x282DEF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185A98", Offset = "0x1185A98")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x282DFA4", Offset = "0x282DFA4", VA = "0x282DFA4")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60001BA")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x275A140", Offset = "0x275A140", VA = "0x275A140", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x275A22C", Offset = "0x275A22C", VA = "0x275A22C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x275A3F0", Offset = "0x275A3F0", VA = "0x275A3F0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001BE")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001BF")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x275A450", Offset = "0x275A450", VA = "0x275A450")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F1C8", Offset = "0x117F1C8")]
		public IK[] IKComponents;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F200", Offset = "0x117F200")]
		public Animator animator;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700001E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x275D398", Offset = "0x275D398", VA = "0x275D398")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x275D434", Offset = "0x275D434", VA = "0x275D434")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x275D4A4", Offset = "0x275D4A4", VA = "0x275D4A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x275D560", Offset = "0x275D560", VA = "0x275D560")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x275D59C", Offset = "0x275D59C", VA = "0x275D59C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x275D4D8", Offset = "0x275D4D8", VA = "0x275D4D8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x275D628", Offset = "0x275D628", VA = "0x275D628")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D74C", Offset = "0x117D74C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D74C", Offset = "0x117D74C")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2815370", Offset = "0x2815370", VA = "0x2815370", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185AD0", Offset = "0x1185AD0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x28153BC", Offset = "0x28153BC", VA = "0x28153BC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185B08", Offset = "0x1185B08")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2815408", Offset = "0x2815408", VA = "0x2815408")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185B40", Offset = "0x1185B40")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2815454", Offset = "0x2815454", VA = "0x2815454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185B78", Offset = "0x1185B78")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x28154A0", Offset = "0x28154A0", VA = "0x28154A0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x28154A8", Offset = "0x28154A8", VA = "0x28154A8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D7AC", Offset = "0x117D7AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D7AC", Offset = "0x117D7AC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2815510", Offset = "0x2815510", VA = "0x2815510", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185BB0", Offset = "0x1185BB0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x281555C", Offset = "0x281555C", VA = "0x281555C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185BE8", Offset = "0x1185BE8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x28155A8", Offset = "0x28155A8", VA = "0x28155A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185C20", Offset = "0x1185C20")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x28155F4", Offset = "0x28155F4", VA = "0x28155F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185C58", Offset = "0x1185C58")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2815640", Offset = "0x2815640", VA = "0x2815640", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2815648", Offset = "0x2815648", VA = "0x2815648")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D80C", Offset = "0x117D80C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D80C", Offset = "0x117D80C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2816518", Offset = "0x2816518", VA = "0x2816518", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185C90", Offset = "0x1185C90")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2816564", Offset = "0x2816564", VA = "0x2816564", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185CC8", Offset = "0x1185CC8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x28165B0", Offset = "0x28165B0", VA = "0x28165B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185D00", Offset = "0x1185D00")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x28165FC", Offset = "0x28165FC", VA = "0x28165FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185D38", Offset = "0x1185D38")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2816648", Offset = "0x2816648", VA = "0x2816648", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2816650", Offset = "0x2816650", VA = "0x2816650")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D86C", Offset = "0x117D86C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D86C", Offset = "0x117D86C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x29F9234", Offset = "0x29F9234", VA = "0x29F9234", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185D70", Offset = "0x1185D70")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x29F9280", Offset = "0x29F9280", VA = "0x29F9280", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185DA8", Offset = "0x1185DA8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x29F92CC", Offset = "0x29F92CC", VA = "0x29F92CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185DE0", Offset = "0x1185DE0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x29F9318", Offset = "0x29F9318", VA = "0x29F9318")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185E18", Offset = "0x1185E18")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x29F9364", Offset = "0x29F9364", VA = "0x29F9364", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x29F936C", Offset = "0x29F936C", VA = "0x29F936C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D8CC", Offset = "0x117D8CC")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200009C")]
		public class References
		{
			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181BE4", Offset = "0x1181BE4")]
			public Transform chest;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181C1C", Offset = "0x1181C1C")]
			public Transform neck;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181C54", Offset = "0x1181C54")]
			public Transform leftShoulder;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181C8C", Offset = "0x1181C8C")]
			public Transform rightShoulder;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181CC4", Offset = "0x1181CC4")]
			public Transform leftThigh;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181CFC", Offset = "0x1181CFC")]
			public Transform leftCalf;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181D34", Offset = "0x1181D34")]
			public Transform leftFoot;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181D6C", Offset = "0x1181D6C")]
			public Transform leftToes;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181DA4", Offset = "0x1181DA4")]
			public Transform rightThigh;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181DDC", Offset = "0x1181DDC")]
			public Transform rightCalf;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181E14", Offset = "0x1181E14")]
			public Transform rightFoot;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181E4C", Offset = "0x1181E4C")]
			public Transform rightToes;

			[Token(Token = "0x170000AC")]
			public bool isFilled
			{
				[Token(Token = "0x600060D")]
				[Address(RVA = "0x29FACD0", Offset = "0x29FACD0", VA = "0x29FACD0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AD")]
			public bool isEmpty
			{
				[Token(Token = "0x600060E")]
				[Address(RVA = "0x29FA854", Offset = "0x29FA854", VA = "0x29FA854")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x29FB354", Offset = "0x29FB354", VA = "0x29FB354")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x29FA440", Offset = "0x29FA440", VA = "0x29FA440")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x29FB34C", Offset = "0x29FB34C", VA = "0x29FB34C")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x117F238", Offset = "0x117F238")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F238", Offset = "0x117F238")]
		public References references;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F2B4", Offset = "0x117F2B4")]
		public IKSolverVR solver;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x29FA334", Offset = "0x29FA334", VA = "0x29FA334", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185E50", Offset = "0x1185E50")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x29FA380", Offset = "0x29FA380", VA = "0x29FA380", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185E88", Offset = "0x1185E88")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x29FA3CC", Offset = "0x29FA3CC", VA = "0x29FA3CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185EC0", Offset = "0x1185EC0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x29FA418", Offset = "0x29FA418", VA = "0x29FA418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185EF8", Offset = "0x1185EF8")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x29FA7B0", Offset = "0x29FA7B0", VA = "0x29FA7B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1185F30", Offset = "0x1185F30")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x29FA7D8", Offset = "0x29FA7D8", VA = "0x29FA7D8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x29FA7E0", Offset = "0x29FA7E0", VA = "0x29FA7E0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x29FB14C", Offset = "0x29FB14C", VA = "0x29FB14C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x29FB2C4", Offset = "0x29FB2C4", VA = "0x29FB2C4")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F2EC", Offset = "0x117F2EC")]
		public float pull;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F304", Offset = "0x117F304")]
		public float pin;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2824EF4", Offset = "0x2824EF4", VA = "0x2824EF4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2824FBC", Offset = "0x2824FBC", VA = "0x2824FBC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2824FDC", Offset = "0x2824FDC", VA = "0x2824FDC")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x28253AC", Offset = "0x28253AC", VA = "0x28253AC")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x28250B0", Offset = "0x28250B0", VA = "0x28250B0")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x28254A4", Offset = "0x28254A4", VA = "0x28254A4")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x28256AC", Offset = "0x28256AC", VA = "0x28256AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2825C14", Offset = "0x2825C14", VA = "0x2825C14")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2825DD4", Offset = "0x2825DD4", VA = "0x2825DD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2825ECC", Offset = "0x2825ECC", VA = "0x2825ECC")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009D")]
		public class BendBone
		{
			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181E84", Offset = "0x1181E84")]
			public Transform transform;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181EBC", Offset = "0x1181EBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1181EBC", Offset = "0x1181EBC")]
			public float weight;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x2828EFC", Offset = "0x2828EFC", VA = "0x2828EFC")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x2828F7C", Offset = "0x2828F7C", VA = "0x2828F7C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x282668C", Offset = "0x282668C", VA = "0x282668C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x2826A90", Offset = "0x2826A90", VA = "0x2826A90")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F31C", Offset = "0x117F31C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x117F354", Offset = "0x117F354")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F354", Offset = "0x117F354")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F354", Offset = "0x117F354")]
		public float positionWeight;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F3CC", Offset = "0x117F3CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F3CC", Offset = "0x117F3CC")]
		public float bodyWeight;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F420", Offset = "0x117F420")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F420", Offset = "0x117F420")]
		public float thighWeight;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F474", Offset = "0x117F474")]
		public bool handsPullBody;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x117F4AC", Offset = "0x117F4AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F4AC", Offset = "0x117F4AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F4AC", Offset = "0x117F4AC")]
		public float rotationWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F524", Offset = "0x117F524")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F524", Offset = "0x117F524")]
		public float bodyClampWeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F578", Offset = "0x117F578")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F578", Offset = "0x117F578")]
		public float headClampWeight;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F5CC", Offset = "0x117F5CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F5CC", Offset = "0x117F5CC")]
		public float bendWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F620", Offset = "0x117F620")]
		public BendBone[] bendBones;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x117F658", Offset = "0x117F658")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F658", Offset = "0x117F658")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F658", Offset = "0x117F658")]
		public float CCDWeight;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F6D0", Offset = "0x117F6D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F6D0", Offset = "0x117F6D0")]
		public float roll;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F724", Offset = "0x117F724")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F724", Offset = "0x117F724")]
		public float damper;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F77C", Offset = "0x117F77C")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x117F7B4", Offset = "0x117F7B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F7B4", Offset = "0x117F7B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F7B4", Offset = "0x117F7B4")]
		public float postStretchWeight;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F82C", Offset = "0x117F82C")]
		public float maxStretch;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F864", Offset = "0x117F864")]
		public float stretchDamper;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F89C", Offset = "0x117F89C")]
		public bool fixHead;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117F8D4", Offset = "0x117F8D4")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x117F90C", Offset = "0x117F90C")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F944", Offset = "0x117F944")]
		public float chestDirectionWeight;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2825ED4", Offset = "0x2825ED4", VA = "0x2825ED4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2826204", Offset = "0x2826204", VA = "0x2826204")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x28266C4", Offset = "0x28266C4", VA = "0x28266C4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2826AB8", Offset = "0x2826AB8", VA = "0x2826AB8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2827430", Offset = "0x2827430", VA = "0x2827430")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x282777C", Offset = "0x282777C", VA = "0x282777C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2827B18", Offset = "0x2827B18", VA = "0x2827B18")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2828584", Offset = "0x2828584", VA = "0x2828584")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x282715C", Offset = "0x282715C", VA = "0x282715C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2828794", Offset = "0x2828794", VA = "0x2828794")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2828440", Offset = "0x2828440", VA = "0x2828440")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x28282A4", Offset = "0x28282A4", VA = "0x28282A4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2828B00", Offset = "0x2828B00", VA = "0x2828B00")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2828D80", Offset = "0x2828D80", VA = "0x2828D80")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public class ChildConstraint
		{
			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181F30", Offset = "0x1181F30")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181F40", Offset = "0x1181F40")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000AE")]
			public float nominalDistance
			{
				[Token(Token = "0x6000615")]
				[Address(RVA = "0x282BE40", Offset = "0x282BE40", VA = "0x282BE40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C20", Offset = "0x1187C20")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x282BE48", Offset = "0x282BE48", VA = "0x282BE48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C30", Offset = "0x1187C30")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public bool isRigid
			{
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x282BE50", Offset = "0x282BE50", VA = "0x282BE50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C40", Offset = "0x1187C40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000618")]
				[Address(RVA = "0x282BE58", Offset = "0x282BE58", VA = "0x282BE58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C50", Offset = "0x1187C50")]
				private set
				{
				}
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x282BE64", Offset = "0x282BE64", VA = "0x282BE64")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x2829BC4", Offset = "0x2829BC4", VA = "0x2829BC4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x282A104", Offset = "0x282A104", VA = "0x282A104")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x282BB3C", Offset = "0x282BB3C", VA = "0x282BB3C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public enum Smoothing
		{
			[Token(Token = "0x4000428")]
			None,
			[Token(Token = "0x4000429")]
			Exponential,
			[Token(Token = "0x400042A")]
			Cubic
		}

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F95C", Offset = "0x117F95C")]
		public float pin;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F974", Offset = "0x117F974")]
		public float pull;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F98C", Offset = "0x117F98C")]
		public float push;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F9A4", Offset = "0x117F9A4")]
		public float pushParent;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F9BC", Offset = "0x117F9BC")]
		public float reach;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000169")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2829020", Offset = "0x2829020", VA = "0x2829020")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x28290EC", Offset = "0x28290EC", VA = "0x28290EC")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x28291F8", Offset = "0x28291F8", VA = "0x28291F8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x282931C", Offset = "0x282931C", VA = "0x282931C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x28293F8", Offset = "0x28293F8", VA = "0x28293F8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x28294FC", Offset = "0x28294FC", VA = "0x28294FC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2829C1C", Offset = "0x2829C1C", VA = "0x2829C1C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x282968C", Offset = "0x282968C", VA = "0x282968C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x282A308", Offset = "0x282A308", VA = "0x282A308")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x282A6AC", Offset = "0x282A6AC", VA = "0x282A6AC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x282AA90", Offset = "0x282AA90", VA = "0x282AA90")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x282B014", Offset = "0x282B014", VA = "0x282B014")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x282B5E4", Offset = "0x282B5E4", VA = "0x282B5E4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x282B87C", Offset = "0x282B87C", VA = "0x282B87C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x282B4DC", Offset = "0x282B4DC", VA = "0x282B4DC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x282ADFC", Offset = "0x282ADFC", VA = "0x282ADFC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x282B464", Offset = "0x282B464", VA = "0x282B464")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x282B964", Offset = "0x282B964", VA = "0x282B964")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x282B384", Offset = "0x282B384", VA = "0x282B384")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x282B764", Offset = "0x282B764", VA = "0x282B764")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F9D4", Offset = "0x117F9D4")]
		public float weight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117F9EC", Offset = "0x117F9EC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700001F")]
		public bool initiated
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x275A620", Offset = "0x275A620", VA = "0x275A620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185F68", Offset = "0x1185F68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x275A628", Offset = "0x275A628", VA = "0x275A628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185F78", Offset = "0x1185F78")]
			private set
			{
			}
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x275A458", Offset = "0x275A458", VA = "0x275A458")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x275A634", Offset = "0x275A634", VA = "0x275A634")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x275A6B8", Offset = "0x275A6B8", VA = "0x275A6B8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x275A764", Offset = "0x275A764", VA = "0x275A764")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x275A770", Offset = "0x275A770", VA = "0x275A770")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x275AC60", Offset = "0x275AC60", VA = "0x275AC60")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x275AE98", Offset = "0x275AE98", VA = "0x275AE98")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x275B334", Offset = "0x275B334", VA = "0x275B334")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x275AA20", Offset = "0x275AA20", VA = "0x275AA20")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x275AB40", Offset = "0x275AB40", VA = "0x275AB40")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IKEffector
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117F9FC", Offset = "0x117F9FC")]
		public float positionWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FA14", Offset = "0x117FA14")]
		public float rotationWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117FA2C", Offset = "0x117FA2C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FA3C", Offset = "0x117FA3C")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000020")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x275B9A0", Offset = "0x275B9A0", VA = "0x275B9A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185F88", Offset = "0x1185F88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x275B9A8", Offset = "0x275B9A8", VA = "0x275B9A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185F98", Offset = "0x1185F98")]
			private set
			{
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x275B938", Offset = "0x275B938", VA = "0x275B938")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x275B9B4", Offset = "0x275B9B4", VA = "0x275B9B4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x275BA88", Offset = "0x275BA88", VA = "0x275BA88")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x275BBC4", Offset = "0x275BBC4", VA = "0x275BBC4")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x275BD1C", Offset = "0x275BD1C", VA = "0x275BD1C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x275C00C", Offset = "0x275C00C", VA = "0x275C00C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x275C2AC", Offset = "0x275C2AC", VA = "0x275C2AC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x275C3EC", Offset = "0x275C3EC", VA = "0x275C3EC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x275C498", Offset = "0x275C498", VA = "0x275C498")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x275CAEC", Offset = "0x275CAEC", VA = "0x275CAEC")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x275CB5C", Offset = "0x275CB5C", VA = "0x275CB5C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x275CD74", Offset = "0x275CD74", VA = "0x275CD74")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x275D0BC", Offset = "0x275D0BC", VA = "0x275D0BC")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000A0")]
		public class BoneMap
		{
			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000B0")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x275D89C", Offset = "0x275D89C", VA = "0x275D89C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B1")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x275DA08", Offset = "0x275DA08", VA = "0x275DA08")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B2")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x275DFEC", Offset = "0x275DFEC", VA = "0x275DFEC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x275D870", Offset = "0x275D870", VA = "0x275D870")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x275D968", Offset = "0x275D968", VA = "0x275D968")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x275D9B8", Offset = "0x275D9B8", VA = "0x275D9B8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x275DA18", Offset = "0x275DA18", VA = "0x275DA18")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x275DB00", Offset = "0x275DB00", VA = "0x275DB00")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x275DB08", Offset = "0x275DB08", VA = "0x275DB08")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x275DC98", Offset = "0x275DC98", VA = "0x275DC98")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x275DDA4", Offset = "0x275DDA4", VA = "0x275DDA4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x275DE3C", Offset = "0x275DE3C", VA = "0x275DE3C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x275E210", Offset = "0x275E210", VA = "0x275E210")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x275E248", Offset = "0x275E248", VA = "0x275E248")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x275E280", Offset = "0x275E280", VA = "0x275E280")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x275E2A8", Offset = "0x275E2A8", VA = "0x275E2A8")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x275E3D4", Offset = "0x275E3D4", VA = "0x275E3D4")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x275E71C", Offset = "0x275E71C", VA = "0x275E71C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x275E74C", Offset = "0x275E74C", VA = "0x275E74C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x275E8E4", Offset = "0x275E8E4", VA = "0x275E8E4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x275E954", Offset = "0x275E954", VA = "0x275E954")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x275EB98", Offset = "0x275EB98", VA = "0x275EB98")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x275EDC0", Offset = "0x275EDC0", VA = "0x275EDC0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x275EED8", Offset = "0x275EED8", VA = "0x275EED8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x275E518", Offset = "0x275E518", VA = "0x275E518")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x275F074", Offset = "0x275F074", VA = "0x275F074")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x275D630", Offset = "0x275D630", VA = "0x275D630", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x275D638", Offset = "0x275D638", VA = "0x275D638", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x275D63C", Offset = "0x275D63C", VA = "0x275D63C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x275D760", Offset = "0x275D760", VA = "0x275D760")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x275D868", Offset = "0x275D868", VA = "0x275D868")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FA54", Offset = "0x117FA54")]
		public float maintainRotationWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x275F090", Offset = "0x275F090", VA = "0x275F090", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x275F130", Offset = "0x275F130", VA = "0x275F130")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x275F1B4", Offset = "0x275F1B4", VA = "0x275F1B4")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x275F24C", Offset = "0x275F24C", VA = "0x275F24C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x275F264", Offset = "0x275F264", VA = "0x275F264")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x275F280", Offset = "0x275F280", VA = "0x275F280", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x275F31C", Offset = "0x275F31C", VA = "0x275F31C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x275F334", Offset = "0x275F334", VA = "0x275F334")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000442")]
			Parent,
			[Token(Token = "0x4000443")]
			Bone1,
			[Token(Token = "0x4000444")]
			Bone2,
			[Token(Token = "0x4000445")]
			Bone3
		}

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FA6C", Offset = "0x117FA6C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FA84", Offset = "0x117FA84")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x275F358", Offset = "0x275F358", VA = "0x275F358", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x275F3DC", Offset = "0x275F3DC", VA = "0x275F3DC")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x275F4B0", Offset = "0x275F4B0", VA = "0x275F4B0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x275F804", Offset = "0x275F804", VA = "0x275F804")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x275F90C", Offset = "0x275F90C", VA = "0x275F90C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x275FA40", Offset = "0x275FA40", VA = "0x275FA40")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x275FA4C", Offset = "0x275FA4C", VA = "0x275FA4C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x275FAF4", Offset = "0x275FAF4", VA = "0x275FAF4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x275FBAC", Offset = "0x275FBAC", VA = "0x275FBAC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x275FE1C", Offset = "0x275FE1C", VA = "0x275FE1C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x275FED4", Offset = "0x275FED4", VA = "0x275FED4")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FA9C", Offset = "0x117FA9C")]
		public int iterations;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FAB4", Offset = "0x117FAB4")]
		public float twistWeight;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2760040", Offset = "0x2760040", VA = "0x2760040", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2760330", Offset = "0x2760330", VA = "0x2760330")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x276044C", Offset = "0x276044C", VA = "0x276044C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x27605A4", Offset = "0x27605A4", VA = "0x27605A4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x27605B4", Offset = "0x27605B4", VA = "0x27605B4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x276061C", Offset = "0x276061C", VA = "0x276061C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x276069C", Offset = "0x276069C", VA = "0x276069C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2760CF0", Offset = "0x2760CF0", VA = "0x2760CF0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2760D28", Offset = "0x2760D28", VA = "0x2760D28")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2761008", Offset = "0x2761008", VA = "0x2761008")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x27613BC", Offset = "0x27613BC", VA = "0x27613BC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x27614A8", Offset = "0x27614A8", VA = "0x27614A8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2761570", Offset = "0x2761570", VA = "0x2761570")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class Point
		{
			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1181F50", Offset = "0x1181F50")]
			public float weight;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x2763098", Offset = "0x2763098", VA = "0x2763098")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x27630E8", Offset = "0x27630E8", VA = "0x27630E8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x2763270", Offset = "0x2763270", VA = "0x2763270")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x27632A8", Offset = "0x27632A8", VA = "0x27632A8")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x27632E0", Offset = "0x27632E0", VA = "0x27632E0")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x2763330", Offset = "0x2763330", VA = "0x2763330")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x2762B6C", Offset = "0x2762B6C", VA = "0x2762B6C")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class Bone : Point
		{
			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000B3")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x276213C", Offset = "0x276213C", VA = "0x276213C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x2762230", Offset = "0x2762230", VA = "0x2762230")]
				set
				{
				}
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x27622B8", Offset = "0x27622B8", VA = "0x27622B8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x2762578", Offset = "0x2762578", VA = "0x2762578")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2762858", Offset = "0x2762858", VA = "0x2762858")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x2762AC0", Offset = "0x2762AC0", VA = "0x2762AC0")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x2762AE8", Offset = "0x2762AE8", VA = "0x2762AE8")]
			public Bone()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x2762BEC", Offset = "0x2762BEC", VA = "0x2762BEC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x2762C84", Offset = "0x2762C84", VA = "0x2762C84")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A4")]
		public class Node : Point
		{
			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x2763034", Offset = "0x2763034", VA = "0x2763034")]
			public Node()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x2763038", Offset = "0x2763038", VA = "0x2763038")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x2763060", Offset = "0x2763060", VA = "0x2763060")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000A5")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000A6")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FAEC", Offset = "0x117FAEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FAEC", Offset = "0x117FAEC")]
		public float IKPositionWeight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117FB40", Offset = "0x117FB40")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000021")]
		public bool initiated
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x2761B8C", Offset = "0x2761B8C", VA = "0x2761B8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185FA8", Offset = "0x1185FA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x2761B94", Offset = "0x2761B94", VA = "0x2761B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185FB8", Offset = "0x1185FB8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2761858", Offset = "0x2761858", VA = "0x2761858")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x275A29C", Offset = "0x275A29C", VA = "0x275A29C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x275A1C4", Offset = "0x275A1C4", VA = "0x275A1C4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2761AE0", Offset = "0x2761AE0", VA = "0x2761AE0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2761AEC", Offset = "0x2761AEC", VA = "0x2761AEC")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2761AF8", Offset = "0x2761AF8", VA = "0x2761AF8")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2761B00", Offset = "0x2761B00", VA = "0x2761B00")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2761B84", Offset = "0x2761B84", VA = "0x2761B84")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000261")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000262")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000263")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000264")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000265")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2761BA0", Offset = "0x2761BA0", VA = "0x2761BA0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2761BB8", Offset = "0x2761BB8", VA = "0x2761BB8")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2761CF4", Offset = "0x2761CF4", VA = "0x2761CF4")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2761DA0", Offset = "0x2761DA0", VA = "0x2761DA0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2762124", Offset = "0x2762124", VA = "0x2762124")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FB88", Offset = "0x117FB88")]
		public float poleWeight;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FBA0", Offset = "0x117FBA0")]
		public float clampWeight;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FBB8", Offset = "0x117FBB8")]
		public int clampSmoothing;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000022")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x27634B8", Offset = "0x27634B8", VA = "0x27634B8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000023")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2763584", Offset = "0x2763584", VA = "0x2763584")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000024")]
		protected override int minBones
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x27642F4", Offset = "0x27642F4", VA = "0x27642F4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2764898", Offset = "0x2764898", VA = "0x2764898", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x27633B8", Offset = "0x27633B8", VA = "0x27633B8")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2763650", Offset = "0x2763650", VA = "0x2763650", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x27638D0", Offset = "0x27638D0", VA = "0x27638D0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2764240", Offset = "0x2764240", VA = "0x2764240")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2763E68", Offset = "0x2763E68", VA = "0x2763E68")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x27642FC", Offset = "0x27642FC", VA = "0x27642FC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x276490C", Offset = "0x276490C", VA = "0x276490C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FBD0", Offset = "0x117FBD0")]
		public float IKRotationWeight;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x27649A4", Offset = "0x27649A4", VA = "0x27649A4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2764D18", Offset = "0x2764D18", VA = "0x2764D18")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2764D84", Offset = "0x2764D84", VA = "0x2764D84", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2764EE0", Offset = "0x2764EE0", VA = "0x2764EE0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2765078", Offset = "0x2765078", VA = "0x2765078", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x27650C4", Offset = "0x27650C4", VA = "0x27650C4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2765124", Offset = "0x2765124", VA = "0x2765124", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2765494", Offset = "0x2765494", VA = "0x2765494", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x27654C0", Offset = "0x27654C0", VA = "0x27654C0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2765188", Offset = "0x2765188", VA = "0x2765188")]
		private void Read()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2765530", Offset = "0x2765530", VA = "0x2765530")]
		private void Write()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x27656BC", Offset = "0x27656BC", VA = "0x27656BC")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2794920", Offset = "0x2794920", VA = "0x2794920")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x27949D0", Offset = "0x27949D0", VA = "0x27949D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2794FD0", Offset = "0x2794FD0", VA = "0x2794FD0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2795730", Offset = "0x2795730", VA = "0x2795730")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2795E94", Offset = "0x2795E94", VA = "0x2795E94")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000026")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x2797120", Offset = "0x2797120", VA = "0x2797120", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2795F08", Offset = "0x2795F08", VA = "0x2795F08")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x279664C", Offset = "0x279664C", VA = "0x279664C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2796780", Offset = "0x2796780", VA = "0x2796780", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2796818", Offset = "0x2796818", VA = "0x2796818", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2796DBC", Offset = "0x2796DBC", VA = "0x2796DBC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2797128", Offset = "0x2797128", VA = "0x2797128")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2795FD8", Offset = "0x2795FD8", VA = "0x2795FD8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x279672C", Offset = "0x279672C", VA = "0x279672C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x27970C4", Offset = "0x27970C4", VA = "0x27970C4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2796474", Offset = "0x2796474", VA = "0x2796474")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2797970", Offset = "0x2797970", VA = "0x2797970")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2797A80", Offset = "0x2797A80", VA = "0x2797A80")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2797BAC", Offset = "0x2797BAC", VA = "0x2797BAC")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2797CC4", Offset = "0x2797CC4", VA = "0x2797CC4")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2796B24", Offset = "0x2796B24", VA = "0x2796B24")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2796C70", Offset = "0x2796C70", VA = "0x2796C70")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2797EB0", Offset = "0x2797EB0", VA = "0x2797EB0")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x27973E4", Offset = "0x27973E4", VA = "0x27973E4")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x279671C", Offset = "0x279671C", VA = "0x279671C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2798620", Offset = "0x2798620", VA = "0x2798620")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2798088", Offset = "0x2798088", VA = "0x2798088")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2797240", Offset = "0x2797240", VA = "0x2797240")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2797320", Offset = "0x2797320", VA = "0x2797320")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x27986EC", Offset = "0x27986EC", VA = "0x27986EC")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FBE8", Offset = "0x117FBE8")]
		public float rootPin;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2798760", Offset = "0x2798760", VA = "0x2798760", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x279902C", Offset = "0x279902C", VA = "0x279902C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x27990C4", Offset = "0x27990C4", VA = "0x27990C4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2799164", Offset = "0x2799164", VA = "0x2799164", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2799264", Offset = "0x2799264", VA = "0x2799264")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2799300", Offset = "0x2799300", VA = "0x2799300", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2799868", Offset = "0x2799868", VA = "0x2799868", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2799A68", Offset = "0x2799A68", VA = "0x2799A68", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2799918", Offset = "0x2799918", VA = "0x2799918")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2799534", Offset = "0x2799534", VA = "0x2799534")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2799B00", Offset = "0x2799B00", VA = "0x2799B00")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FC00", Offset = "0x117FC00")]
		public int iterations;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2799B68", Offset = "0x2799B68", VA = "0x2799B68")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2799C5C", Offset = "0x2799C5C", VA = "0x2799C5C")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2799CB8", Offset = "0x2799CB8", VA = "0x2799CB8")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2799DEC", Offset = "0x2799DEC", VA = "0x2799DEC")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2799E48", Offset = "0x2799E48", VA = "0x2799E48")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2799EC8", Offset = "0x2799EC8", VA = "0x2799EC8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x279A070", Offset = "0x279A070", VA = "0x279A070", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x279A1E4", Offset = "0x279A1E4", VA = "0x279A1E4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x279A3E8", Offset = "0x279A3E8", VA = "0x279A3E8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x279A4C0", Offset = "0x279A4C0", VA = "0x279A4C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x279A5AC", Offset = "0x279A5AC", VA = "0x279A5AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x279A720", Offset = "0x279A720", VA = "0x279A720", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x279A8E8", Offset = "0x279A8E8", VA = "0x279A8E8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x279AB34", Offset = "0x279AB34", VA = "0x279AB34", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x279AE10", Offset = "0x279AE10", VA = "0x279AE10", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x279AE54", Offset = "0x279AE54", VA = "0x279AE54", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x279AF44", Offset = "0x279AF44", VA = "0x279AF44")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40001F4")]
		Body,
		[Token(Token = "0x40001F5")]
		LeftShoulder,
		[Token(Token = "0x40001F6")]
		RightShoulder,
		[Token(Token = "0x40001F7")]
		LeftThigh,
		[Token(Token = "0x40001F8")]
		RightThigh,
		[Token(Token = "0x40001F9")]
		LeftHand,
		[Token(Token = "0x40001FA")]
		RightHand,
		[Token(Token = "0x40001FB")]
		LeftFoot,
		[Token(Token = "0x40001FC")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40001FE")]
		LeftArm,
		[Token(Token = "0x40001FF")]
		RightArm,
		[Token(Token = "0x4000200")]
		LeftLeg,
		[Token(Token = "0x4000201")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FC18", Offset = "0x117FC18")]
		public float spineStiffness;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FC30", Offset = "0x117FC30")]
		public float pullBodyVertical;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FC48", Offset = "0x117FC48")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117FC60", Offset = "0x117FC60")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000027")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x279B01C", Offset = "0x279B01C", VA = "0x279B01C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x279B164", Offset = "0x279B164", VA = "0x279B164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x279B16C", Offset = "0x279B16C", VA = "0x279B16C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x279B174", Offset = "0x279B174", VA = "0x279B174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x279B17C", Offset = "0x279B17C", VA = "0x279B17C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x279B184", Offset = "0x279B184", VA = "0x279B184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x279B18C", Offset = "0x279B18C", VA = "0x279B18C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x279B194", Offset = "0x279B194", VA = "0x279B194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x279B19C", Offset = "0x279B19C", VA = "0x279B19C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x279B1A4", Offset = "0x279B1A4", VA = "0x279B1A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x279B1DC", Offset = "0x279B1DC", VA = "0x279B1DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x279B214", Offset = "0x279B214", VA = "0x279B214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x279B24C", Offset = "0x279B24C", VA = "0x279B24C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x279B284", Offset = "0x279B284", VA = "0x279B284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x279B2B8", Offset = "0x279B2B8", VA = "0x279B2B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x279B2F0", Offset = "0x279B2F0", VA = "0x279B2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x279B328", Offset = "0x279B328", VA = "0x279B328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x279B360", Offset = "0x279B360", VA = "0x279B360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x279D324", Offset = "0x279D324", VA = "0x279D324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185FC8", Offset = "0x1185FC8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x279D330", Offset = "0x279D330", VA = "0x279D330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185FD8", Offset = "0x1185FD8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x279B394", Offset = "0x279B394", VA = "0x279B394")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x279B4A0", Offset = "0x279B4A0", VA = "0x279B4A0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x279B3E8", Offset = "0x279B3E8", VA = "0x279B3E8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x279B57C", Offset = "0x279B57C", VA = "0x279B57C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x279B024", Offset = "0x279B024", VA = "0x279B024")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x279B64C", Offset = "0x279B64C", VA = "0x279B64C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x279B704", Offset = "0x279B704", VA = "0x279B704")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x279B7B8", Offset = "0x279B7B8", VA = "0x279B7B8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x279B86C", Offset = "0x279B86C", VA = "0x279B86C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x279B874", Offset = "0x279B874", VA = "0x279B874")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x279B8A8", Offset = "0x279B8A8", VA = "0x279B8A8")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x279B970", Offset = "0x279B970", VA = "0x279B970", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x279BB00", Offset = "0x279BB00", VA = "0x279BB00")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x279CC3C", Offset = "0x279CC3C", VA = "0x279CC3C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x279D0D0", Offset = "0x279D0D0", VA = "0x279D0D0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x279D130", Offset = "0x279D130", VA = "0x279D130")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x279CF50", Offset = "0x279CF50", VA = "0x279CF50")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x279D010", Offset = "0x279D010", VA = "0x279D010")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x279D33C", Offset = "0x279D33C", VA = "0x279D33C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x279D418", Offset = "0x279D418", VA = "0x279D418", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x279D560", Offset = "0x279D560", VA = "0x279D560")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x279D6F0", Offset = "0x279D6F0", VA = "0x279D6F0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x279D8F0", Offset = "0x279D8F0", VA = "0x279D8F0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x279DAF0", Offset = "0x279DAF0", VA = "0x279DAF0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x279DE24", Offset = "0x279DE24", VA = "0x279DE24", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x279DF24", Offset = "0x279DF24", VA = "0x279DF24")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700003A")]
		protected virtual int minBones
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x279E774", Offset = "0x279E774", VA = "0x279E774", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x279E77C", Offset = "0x279E77C", VA = "0x279E77C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x279E784", Offset = "0x279E784", VA = "0x279E784", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x279E794", Offset = "0x279E794", VA = "0x279E794", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected float positionOffset
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x279566C", Offset = "0x279566C", VA = "0x279566C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x279DF30", Offset = "0x279DF30", VA = "0x279DF30")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x279E0C4", Offset = "0x279E0C4", VA = "0x279E0C4")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x279E200", Offset = "0x279E200", VA = "0x279E200", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x279E26C", Offset = "0x279E26C", VA = "0x279E26C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x279E2EC", Offset = "0x279E2EC", VA = "0x279E2EC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x279E678", Offset = "0x279E678", VA = "0x279E678", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x279E680", Offset = "0x279E680", VA = "0x279E680", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x279E78C", Offset = "0x279E78C", VA = "0x279E78C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x279E790", Offset = "0x279E790", VA = "0x279E790", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2794A50", Offset = "0x2794A50", VA = "0x2794A50")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x27952C8", Offset = "0x27952C8", VA = "0x27952C8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x279E8C8", Offset = "0x279E8C8", VA = "0x279E8C8")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2795E98", Offset = "0x2795E98", VA = "0x2795E98")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FC70", Offset = "0x117FC70")]
		public float IKRotationWeight;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x279EB7C", Offset = "0x279EB7C", VA = "0x279EB7C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x279EEF0", Offset = "0x279EEF0", VA = "0x279EEF0")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x279EF60", Offset = "0x279EF60", VA = "0x279EF60", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x279F0BC", Offset = "0x279F0BC", VA = "0x279F0BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x279F254", Offset = "0x279F254", VA = "0x279F254", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x279F2B0", Offset = "0x279F2B0", VA = "0x279F2B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x279F320", Offset = "0x279F320", VA = "0x279F320", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x279F690", Offset = "0x279F690", VA = "0x279F690", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x279F6BC", Offset = "0x279F6BC", VA = "0x279F6BC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x279F384", Offset = "0x279F384", VA = "0x279F384")]
		private void Read()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x279F7C8", Offset = "0x279F7C8", VA = "0x279F7C8")]
		private void Write()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x279F954", Offset = "0x279F954", VA = "0x279F954")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public enum BendModifier
		{
			[Token(Token = "0x4000456")]
			Animation,
			[Token(Token = "0x4000457")]
			Target,
			[Token(Token = "0x4000458")]
			Parent,
			[Token(Token = "0x4000459")]
			Arm,
			[Token(Token = "0x400045A")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000A8")]
		public struct AxisDirection
		{
			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x27A11CC", Offset = "0x27A11CC", VA = "0x27A11CC")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FC88", Offset = "0x117FC88")]
		public float maintainRotationWeight;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FCA0", Offset = "0x117FCA0")]
		public float bendModifierWeight;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700003F")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x27A11B0", Offset = "0x27A11B0", VA = "0x27A11B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x279FAAC", Offset = "0x279FAAC", VA = "0x279FAAC")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x279FAFC", Offset = "0x279FAFC", VA = "0x279FAFC")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x279FC10", Offset = "0x279FC10", VA = "0x279FC10", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x27A0280", Offset = "0x27A0280", VA = "0x27A0280", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x27A0E5C", Offset = "0x27A0E5C", VA = "0x27A0E5C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x27A0FA4", Offset = "0x27A0FA4", VA = "0x27A0FA4")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x27A1128", Offset = "0x27A1128", VA = "0x27A1128")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x279FF8C", Offset = "0x279FF8C", VA = "0x279FF8C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x27A03AC", Offset = "0x27A03AC", VA = "0x27A03AC")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x170000B4")]
			public Vector3 forward
			{
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x27A327C", Offset = "0x27A327C", VA = "0x27A327C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x27A39C8", Offset = "0x27A39C8", VA = "0x27A39C8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x27A2418", Offset = "0x27A2418", VA = "0x27A2418")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x27A2754", Offset = "0x27A2754", VA = "0x27A2754")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x27A3680", Offset = "0x27A3680", VA = "0x27A3680")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FCB8", Offset = "0x117FCB8")]
		public float bodyWeight;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FCD0", Offset = "0x117FCD0")]
		public float headWeight;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FCE8", Offset = "0x117FCE8")]
		public float eyesWeight;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FD00", Offset = "0x117FD00")]
		public float clampWeight;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FD18", Offset = "0x117FD18")]
		public float clampWeightHead;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FD30", Offset = "0x117FD30")]
		public float clampWeightEyes;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FD48", Offset = "0x117FD48")]
		public int clampSmoothing;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000040")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x27A1B7C", Offset = "0x27A1B7C", VA = "0x27A1B7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x27A1D54", Offset = "0x27A1D54", VA = "0x27A1D54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x27A1C60", Offset = "0x27A1C60", VA = "0x27A1C60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x27A1D78", Offset = "0x27A1D78", VA = "0x27A1D78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x27A1C70", Offset = "0x27A1C70", VA = "0x27A1C70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x27A1DF4", Offset = "0x27A1DF4", VA = "0x27A1DF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x27A122C", Offset = "0x27A122C", VA = "0x27A122C")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x27A12B0", Offset = "0x27A12B0", VA = "0x27A12B0")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x27A135C", Offset = "0x27A135C", VA = "0x27A135C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x27A1424", Offset = "0x27A1424", VA = "0x27A1424")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x27A1510", Offset = "0x27A1510", VA = "0x27A1510")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x27A161C", Offset = "0x27A161C", VA = "0x27A161C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x27A1764", Offset = "0x27A1764", VA = "0x27A1764", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x27A1894", Offset = "0x27A1894", VA = "0x27A1894")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x27A18A0", Offset = "0x27A18A0", VA = "0x27A18A0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x27A19E8", Offset = "0x27A19E8", VA = "0x27A19E8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x27A1E18", Offset = "0x27A1E18", VA = "0x27A1E18", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x27A2050", Offset = "0x27A2050", VA = "0x27A2050", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x27A21F0", Offset = "0x27A21F0", VA = "0x27A21F0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x27A2444", Offset = "0x27A2444", VA = "0x27A2444", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x27A2890", Offset = "0x27A2890", VA = "0x27A2890", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x27A2994", Offset = "0x27A2994", VA = "0x27A2994")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x27A2BC0", Offset = "0x27A2BC0", VA = "0x27A2BC0")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x27A2E1C", Offset = "0x27A2E1C", VA = "0x27A2E1C")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x27A3348", Offset = "0x27A3348", VA = "0x27A3348")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x27A22A0", Offset = "0x27A22A0", VA = "0x27A22A0")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x27A37E8", Offset = "0x27A37E8", VA = "0x27A37E8")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x27A4FA0", Offset = "0x27A4FA0", VA = "0x27A4FA0")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x27A5B58", Offset = "0x27A5B58", VA = "0x27A5B58")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x279FB44", Offset = "0x279FB44", VA = "0x279FB44")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x27A5C20", Offset = "0x27A5C20", VA = "0x27A5C20")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FD60", Offset = "0x117FD60")]
		public float IKRotationWeight;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x27A39D0", Offset = "0x27A39D0", VA = "0x27A39D0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x27A3BC0", Offset = "0x27A3BC0", VA = "0x27A3BC0")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x27A3D74", Offset = "0x27A3D74", VA = "0x27A3D74")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x27A3D80", Offset = "0x27A3D80", VA = "0x27A3D80")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x27A3E04", Offset = "0x27A3E04", VA = "0x27A3E04")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x27A3E10", Offset = "0x27A3E10", VA = "0x27A3E10")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x27A3E18", Offset = "0x27A3E18", VA = "0x27A3E18", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x27A3F1C", Offset = "0x27A3F1C", VA = "0x27A3F1C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x27A403C", Offset = "0x27A403C", VA = "0x27A403C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x27A4088", Offset = "0x27A4088", VA = "0x27A4088", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x27A40E8", Offset = "0x27A40E8", VA = "0x27A40E8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x27A44C4", Offset = "0x27A44C4", VA = "0x27A44C4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x27A451C", Offset = "0x27A451C", VA = "0x27A451C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x27A4AC4", Offset = "0x27A4AC4", VA = "0x27A4AC4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x27A4CDC", Offset = "0x27A4CDC", VA = "0x27A4CDC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x27A4E98", Offset = "0x27A4E98", VA = "0x27A4E98")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x27A4E14", Offset = "0x27A4E14", VA = "0x27A4E14")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x27A5140", Offset = "0x27A5140", VA = "0x27A5140", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x27A5C14", Offset = "0x27A5C14", VA = "0x27A5C14", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x27A5C18", Offset = "0x27A5C18", VA = "0x27A5C18", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x27A5C1C", Offset = "0x27A5C1C", VA = "0x27A5C1C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x27A584C", Offset = "0x27A584C", VA = "0x27A584C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x27A1018", Offset = "0x27A1018", VA = "0x27A1018")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000AB")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000132")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000669")]
				YawPitch,
				[Token(Token = "0x400066A")]
				FromTo
			}

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181F68", Offset = "0x1181F68")]
			public Transform target;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181FA0", Offset = "0x1181FA0")]
			public Transform bendGoal;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181FD8", Offset = "0x1181FD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1181FD8", Offset = "0x1181FD8")]
			public float positionWeight;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118202C", Offset = "0x118202C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118202C", Offset = "0x118202C")]
			public float rotationWeight;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182080", Offset = "0x1182080")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11820B8", Offset = "0x11820B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11820B8", Offset = "0x11820B8")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118210C", Offset = "0x118210C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118210C", Offset = "0x118210C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182160", Offset = "0x1182160")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182160", Offset = "0x1182160")]
			public float bendGoalWeight;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11821B4", Offset = "0x11821B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11821B4", Offset = "0x11821B4")]
			public float swivelOffset;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182210", Offset = "0x1182210")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182248", Offset = "0x1182248")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182280", Offset = "0x1182280")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182280", Offset = "0x1182280")]
			public float armLengthMlp;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11822D8", Offset = "0x11822D8")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182350", Offset = "0x1182350")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182360", Offset = "0x1182360")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400047C")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400047D")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000B5")]
			public Vector3 position
			{
				[Token(Token = "0x600065C")]
				[Address(RVA = "0x27AB72C", Offset = "0x27AB72C", VA = "0x27AB72C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C60", Offset = "0x1187C60")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600065D")]
				[Address(RVA = "0x27AB738", Offset = "0x27AB738", VA = "0x27AB738")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C70", Offset = "0x1187C70")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			public Quaternion rotation
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x27AB744", Offset = "0x27AB744", VA = "0x27AB744")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C80", Offset = "0x1187C80")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x27AB750", Offset = "0x27AB750", VA = "0x27AB750")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187C90", Offset = "0x1187C90")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x27AB75C", Offset = "0x27AB75C", VA = "0x27AB75C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000661")]
				[Address(RVA = "0x27AB790", Offset = "0x27AB790", VA = "0x27AB790")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x27AB7D0", Offset = "0x27AB7D0", VA = "0x27AB7D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x27AB81C", Offset = "0x27AB81C", VA = "0x27AB81C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x27AB868", Offset = "0x27AB868", VA = "0x27AB868", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x27AC1E8", Offset = "0x27AC1E8", VA = "0x27AC1E8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x27AC3DC", Offset = "0x27AC3DC", VA = "0x27AC3DC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x27AC488", Offset = "0x27AC488", VA = "0x27AC488")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x27A98B0", Offset = "0x27A98B0", VA = "0x27A98B0")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x27ACF30", Offset = "0x27ACF30", VA = "0x27ACF30", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x27ACFA0", Offset = "0x27ACFA0", VA = "0x27ACFA0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x27AC8A0", Offset = "0x27AC8A0", VA = "0x27AC8A0")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x27AC978", Offset = "0x27AC978", VA = "0x27AC978")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x27AD1C0", Offset = "0x27AD1C0", VA = "0x27AD1C0")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x27AB600", Offset = "0x27AB600", VA = "0x27AB600")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182370", Offset = "0x1182370")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182380", Offset = "0x1182380")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x170000BB")]
			public float sqrMag
			{
				[Token(Token = "0x6000674")]
				[Address(RVA = "0x27FFDB8", Offset = "0x27FFDB8", VA = "0x27FFDB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187CA0", Offset = "0x1187CA0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000675")]
				[Address(RVA = "0x27FFDC0", Offset = "0x27FFDC0", VA = "0x27FFDC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187CB0", Offset = "0x1187CB0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			public float mag
			{
				[Token(Token = "0x6000676")]
				[Address(RVA = "0x27FFDC8", Offset = "0x27FFDC8", VA = "0x27FFDC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187CC0", Offset = "0x1187CC0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000677")]
				[Address(RVA = "0x27FFDD0", Offset = "0x27FFDD0", VA = "0x27FFDD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187CD0", Offset = "0x1187CD0")]
				private set
				{
				}
			}

			[Token(Token = "0x600066F")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000670")]
			public abstract void PreSolve();

			[Token(Token = "0x6000671")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000672")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000673")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x27FFDD8", Offset = "0x27FFDD8", VA = "0x27FFDD8")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x27FFDE0", Offset = "0x27FFDE0", VA = "0x27FFDE0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x280019C", Offset = "0x280019C", VA = "0x280019C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x2800308", Offset = "0x2800308", VA = "0x2800308")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x2800598", Offset = "0x2800598", VA = "0x2800598")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x28005EC", Offset = "0x28005EC", VA = "0x28005EC")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x28007D8", Offset = "0x28007D8", VA = "0x28007D8")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x2800978", Offset = "0x2800978", VA = "0x2800978")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x2800ABC", Offset = "0x2800ABC", VA = "0x2800ABC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x2800AE4", Offset = "0x2800AE4", VA = "0x2800AE4")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AD")]
		public class Footstep
		{
			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11823A0", Offset = "0x11823A0")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000BD")]
			public bool isStepping
			{
				[Token(Token = "0x6000682")]
				[Address(RVA = "0x2800B7C", Offset = "0x2800B7C", VA = "0x2800B7C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BE")]
			public float stepProgress
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x2800B90", Offset = "0x2800B90", VA = "0x2800B90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187CE0", Offset = "0x1187CE0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x2800B98", Offset = "0x2800B98", VA = "0x2800B98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187CF0", Offset = "0x1187CF0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x2800BA0", Offset = "0x2800BA0", VA = "0x2800BA0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x2800D30", Offset = "0x2800D30", VA = "0x2800D30")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x2800D78", Offset = "0x2800D78", VA = "0x2800D78")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x2800F48", Offset = "0x2800F48", VA = "0x2800F48")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x2801120", Offset = "0x2801120", VA = "0x2801120")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x280130C", Offset = "0x280130C", VA = "0x280130C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AE")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11823B0", Offset = "0x11823B0")]
			public Transform target;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11823E8", Offset = "0x11823E8")]
			public Transform bendGoal;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182420", Offset = "0x1182420")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182420", Offset = "0x1182420")]
			public float positionWeight;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182474", Offset = "0x1182474")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182474", Offset = "0x1182474")]
			public float rotationWeight;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11824C8", Offset = "0x11824C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11824C8", Offset = "0x11824C8")]
			public float bendGoalWeight;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118251C", Offset = "0x118251C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118251C", Offset = "0x118251C")]
			public float swivelOffset;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182578", Offset = "0x1182578")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182578", Offset = "0x1182578")]
			public float bendToTargetWeight;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11825CC", Offset = "0x11825CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11825CC", Offset = "0x11825CC")]
			public float legLengthMlp;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182624", Offset = "0x1182624")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11826CC", Offset = "0x11826CC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11826DC", Offset = "0x11826DC")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11826EC", Offset = "0x11826EC")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11826FC", Offset = "0x11826FC")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000BF")]
			public Vector3 position
			{
				[Token(Token = "0x600068B")]
				[Address(RVA = "0x2801528", Offset = "0x2801528", VA = "0x2801528")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D00", Offset = "0x1187D00")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x2801534", Offset = "0x2801534", VA = "0x2801534")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D10", Offset = "0x1187D10")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public Quaternion rotation
			{
				[Token(Token = "0x600068D")]
				[Address(RVA = "0x2801540", Offset = "0x2801540", VA = "0x2801540")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D20", Offset = "0x1187D20")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x280154C", Offset = "0x280154C", VA = "0x280154C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D30", Offset = "0x1187D30")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public bool hasToes
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x2801558", Offset = "0x2801558", VA = "0x2801558")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D40", Offset = "0x1187D40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x2801560", Offset = "0x2801560", VA = "0x2801560")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D50", Offset = "0x1187D50")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0x280156C", Offset = "0x280156C", VA = "0x280156C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x28015A0", Offset = "0x28015A0", VA = "0x28015A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0x28015D8", Offset = "0x28015D8", VA = "0x28015D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000694")]
				[Address(RVA = "0x2801610", Offset = "0x2801610", VA = "0x2801610")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000695")]
				[Address(RVA = "0x2801648", Offset = "0x2801648", VA = "0x2801648")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000696")]
				[Address(RVA = "0x2801688", Offset = "0x2801688", VA = "0x2801688")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D60", Offset = "0x1187D60")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000697")]
				[Address(RVA = "0x2801694", Offset = "0x2801694", VA = "0x2801694")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D70", Offset = "0x1187D70")]
				private set
				{
				}
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x28016A0", Offset = "0x28016A0", VA = "0x28016A0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x2801D58", Offset = "0x2801D58", VA = "0x2801D58", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x2802658", Offset = "0x2802658", VA = "0x2802658", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x2802554", Offset = "0x2802554", VA = "0x2802554")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x280231C", Offset = "0x280231C", VA = "0x280231C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x2802C10", Offset = "0x2802C10", VA = "0x2802C10")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x2803918", Offset = "0x2803918", VA = "0x2803918")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x2802E40", Offset = "0x2802E40", VA = "0x2802E40")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x2803D80", Offset = "0x2803D80", VA = "0x2803D80", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x2803F9C", Offset = "0x2803F9C", VA = "0x2803F9C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x280404C", Offset = "0x280404C", VA = "0x280404C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		public class Locomotion
		{
			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118270C", Offset = "0x118270C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118270C", Offset = "0x118270C")]
			public float weight;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182760", Offset = "0x1182760")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1182760", Offset = "0x1182760")]
			public float footDistance;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11827C0", Offset = "0x11827C0")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11827C0", Offset = "0x11827C0")]
			public float stepThreshold;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182820", Offset = "0x1182820")]
			public float angleThreshold;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182858", Offset = "0x1182858")]
			public float comAngleMlp;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182890", Offset = "0x1182890")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1182890", Offset = "0x1182890")]
			public float maxVelocity;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11828F8", Offset = "0x11828F8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11828F8", Offset = "0x11828F8")]
			public float velocityFactor;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182958", Offset = "0x1182958")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182958", Offset = "0x1182958")]
			public float maxLegStretch;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11829AC", Offset = "0x11829AC")]
			public float rootSpeed;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11829E4", Offset = "0x11829E4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11829E4", Offset = "0x11829E4")]
			public float stepSpeed;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182A44", Offset = "0x1182A44")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182A7C", Offset = "0x1182A7C")]
			public float maxBodyYOffset;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182AB4", Offset = "0x1182AB4")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182AEC", Offset = "0x1182AEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182AEC", Offset = "0x1182AEC")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182B44", Offset = "0x1182B44")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182B7C", Offset = "0x1182B7C")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182BB4", Offset = "0x1182BB4")]
			public Vector3 offset;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182C2C", Offset = "0x1182C2C")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182C64", Offset = "0x1182C64")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182C9C", Offset = "0x1182C9C")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x170000C8")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x2804140", Offset = "0x2804140", VA = "0x2804140")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D80", Offset = "0x1187D80")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x280414C", Offset = "0x280414C", VA = "0x280414C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187D90", Offset = "0x1187D90")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x28066C4", Offset = "0x28066C4", VA = "0x28066C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CA")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x2806704", Offset = "0x2806704", VA = "0x2806704")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CB")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x2806748", Offset = "0x2806748", VA = "0x2806748")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000CC")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x2806788", Offset = "0x2806788", VA = "0x2806788")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x2804158", Offset = "0x2804158", VA = "0x2804158")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x280445C", Offset = "0x280445C", VA = "0x280445C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x28046D0", Offset = "0x28046D0", VA = "0x28046D0")]
			public void Relax()
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x2804734", Offset = "0x2804734", VA = "0x2804734")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x2804B0C", Offset = "0x2804B0C", VA = "0x2804B0C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x2804CBC", Offset = "0x2804CBC", VA = "0x2804CBC")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x28062D0", Offset = "0x28062D0", VA = "0x28062D0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x2806474", Offset = "0x2806474", VA = "0x2806474")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x28064F8", Offset = "0x28064F8", VA = "0x28064F8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x28067CC", Offset = "0x28067CC", VA = "0x28067CC")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B0")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182CAC", Offset = "0x1182CAC")]
			public Transform headTarget;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182CE4", Offset = "0x1182CE4")]
			public Transform pelvisTarget;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182D1C", Offset = "0x1182D1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182D1C", Offset = "0x1182D1C")]
			public float positionWeight;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182D70", Offset = "0x1182D70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182D70", Offset = "0x1182D70")]
			public float rotationWeight;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182DC4", Offset = "0x1182DC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182DC4", Offset = "0x1182DC4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182E18", Offset = "0x1182E18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182E18", Offset = "0x1182E18")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182E6C", Offset = "0x1182E6C")]
			public Transform chestGoal;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182EA4", Offset = "0x1182EA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182EA4", Offset = "0x1182EA4")]
			public float chestGoalWeight;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182EF8", Offset = "0x1182EF8")]
			public float minHeadHeight;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182F30", Offset = "0x1182F30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182F30", Offset = "0x1182F30")]
			public float bodyPosStiffness;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182F84", Offset = "0x1182F84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182F84", Offset = "0x1182F84")]
			public float bodyRotStiffness;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182FD8", Offset = "0x1182FD8")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1182FD8", Offset = "0x1182FD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182FD8", Offset = "0x1182FD8")]
			public float neckStiffness;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183050", Offset = "0x1183050")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183050", Offset = "0x1183050")]
			public float rotateChestByHands;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11830A4", Offset = "0x11830A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11830A4", Offset = "0x11830A4")]
			public float chestClampWeight;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11830F8", Offset = "0x11830F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11830F8", Offset = "0x11830F8")]
			public float headClampWeight;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118314C", Offset = "0x118314C")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183184", Offset = "0x1183184")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183184", Offset = "0x1183184")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11831D8", Offset = "0x11831D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11831D8", Offset = "0x11831D8")]
			public float maxRootAngle;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183230", Offset = "0x1183230")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183230", Offset = "0x1183230")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118336C", Offset = "0x118336C")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118337C", Offset = "0x118337C")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000CD")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x2806250", Offset = "0x2806250", VA = "0x2806250")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006B4")]
				[Address(RVA = "0x28068BC", Offset = "0x28068BC", VA = "0x28068BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			public VirtualBone chest
			{
				[Token(Token = "0x60006B5")]
				[Address(RVA = "0x28068FC", Offset = "0x28068FC", VA = "0x28068FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006B6")]
				[Address(RVA = "0x2806950", Offset = "0x2806950", VA = "0x2806950")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			public VirtualBone head
			{
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x2806290", Offset = "0x2806290", VA = "0x2806290")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x2806990", Offset = "0x2806990", VA = "0x2806990")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187DA0", Offset = "0x1187DA0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x28069A4", Offset = "0x28069A4", VA = "0x28069A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187DB0", Offset = "0x1187DB0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D3")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x28069B8", Offset = "0x28069B8", VA = "0x28069B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187DC0", Offset = "0x1187DC0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x28069CC", Offset = "0x28069CC", VA = "0x28069CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187DD0", Offset = "0x1187DD0")]
				private set
				{
				}
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x28069E0", Offset = "0x28069E0", VA = "0x28069E0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x28074AC", Offset = "0x28074AC", VA = "0x28074AC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x28076BC", Offset = "0x28076BC", VA = "0x28076BC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x2807D44", Offset = "0x2807D44", VA = "0x2807D44")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x2808304", Offset = "0x2808304", VA = "0x2808304")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x2808D8C", Offset = "0x2808D8C", VA = "0x2808D8C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x28095B8", Offset = "0x28095B8", VA = "0x28095B8")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x2809D24", Offset = "0x2809D24", VA = "0x2809D24", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x2809F00", Offset = "0x2809F00", VA = "0x2809F00", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x2807F74", Offset = "0x2807F74", VA = "0x2807F74")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x2809200", Offset = "0x2809200", VA = "0x2809200")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x2808930", Offset = "0x2808930", VA = "0x2808930")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x2809FFC", Offset = "0x2809FFC", VA = "0x2809FFC")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x280936C", Offset = "0x280936C", VA = "0x280936C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x2808F4C", Offset = "0x2808F4C", VA = "0x2808F4C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x280A324", Offset = "0x280A324", VA = "0x280A324")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000505")]
			Pelvis,
			[Token(Token = "0x4000506")]
			Chest,
			[Token(Token = "0x4000507")]
			Head,
			[Token(Token = "0x4000508")]
			LeftHand,
			[Token(Token = "0x4000509")]
			RightHand,
			[Token(Token = "0x400050A")]
			LeftFoot,
			[Token(Token = "0x400050B")]
			RightFoot,
			[Token(Token = "0x400050C")]
			LeftHeel,
			[Token(Token = "0x400050D")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		public enum RotationOffset
		{
			[Token(Token = "0x400050F")]
			Pelvis,
			[Token(Token = "0x4000510")]
			Chest,
			[Token(Token = "0x4000511")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class VirtualBone
		{
			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x2801CBC", Offset = "0x2801CBC", VA = "0x2801CBC")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x2801D38", Offset = "0x2801D38", VA = "0x2801D38")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x280A4D8", Offset = "0x280A4D8", VA = "0x280A4D8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x27FFEB0", Offset = "0x27FFEB0", VA = "0x27FFEB0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x28003B0", Offset = "0x28003B0", VA = "0x28003B0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x280A768", Offset = "0x280A768", VA = "0x280A768")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x280A9A0", Offset = "0x280A9A0", VA = "0x280A9A0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x280ABD4", Offset = "0x280ABD4", VA = "0x280ABD4")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x280336C", Offset = "0x280336C", VA = "0x280336C")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x280AC8C", Offset = "0x280AC8C", VA = "0x280AC8C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x28098C4", Offset = "0x28098C4", VA = "0x28098C4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x280AEA4", Offset = "0x280AEA4", VA = "0x280AEA4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x280AFAC", Offset = "0x280AFAC", VA = "0x280AFAC")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FD78", Offset = "0x117FD78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x117FD78", Offset = "0x117FD78")]
		public int LOD;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FDCC", Offset = "0x117FDCC")]
		public float scale;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FE04", Offset = "0x117FE04")]
		public bool plantFeet;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117FE3C", Offset = "0x117FE3C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FE4C", Offset = "0x117FE4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x117FE4C", Offset = "0x117FE4C")]
		public Spine spine;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FEAC", Offset = "0x117FEAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x117FEAC", Offset = "0x117FEAC")]
		public Arm leftArm;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FF0C", Offset = "0x117FF0C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x117FF0C", Offset = "0x117FF0C")]
		public Arm rightArm;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FF6C", Offset = "0x117FF6C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x117FF6C", Offset = "0x117FF6C")]
		public Leg leftLeg;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x117FFCC", Offset = "0x117FFCC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x117FFCC", Offset = "0x117FFCC")]
		public Leg rightLeg;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118002C", Offset = "0x118002C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x118002C", Offset = "0x118002C")]
		public Locomotion locomotion;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000046")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x27AB430", Offset = "0x27AB430", VA = "0x27AB430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185FE8", Offset = "0x1185FE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x27AB438", Offset = "0x27AB438", VA = "0x27AB438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185FF8", Offset = "0x1185FF8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x27A5C28", Offset = "0x27A5C28", VA = "0x27A5C28")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x27A6064", Offset = "0x27A6064", VA = "0x27A6064")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x27A5F0C", Offset = "0x27A5F0C", VA = "0x27A5F0C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x27A6438", Offset = "0x27A6438", VA = "0x27A6438")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x27A6714", Offset = "0x27A6714", VA = "0x27A6714")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x27A67B8", Offset = "0x27A67B8", VA = "0x27A67B8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x27A694C", Offset = "0x27A694C", VA = "0x27A694C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x27A6AD8", Offset = "0x27A6AD8", VA = "0x27A6AD8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x27A7300", Offset = "0x27A7300", VA = "0x27A7300", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x27A7474", Offset = "0x27A7474", VA = "0x27A7474", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x27A767C", Offset = "0x27A767C", VA = "0x27A767C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x27A76F0", Offset = "0x27A76F0", VA = "0x27A76F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x27A7764", Offset = "0x27A7764", VA = "0x27A7764", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x27A7978", Offset = "0x27A7978", VA = "0x27A7978")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x27A6314", Offset = "0x27A6314", VA = "0x27A6314")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x27A6C50", Offset = "0x27A6C50", VA = "0x27A6C50")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x27A7C58", Offset = "0x27A7C58", VA = "0x27A7C58", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x27A7CA0", Offset = "0x27A7CA0", VA = "0x27A7CA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x27A9438", Offset = "0x27A9438", VA = "0x27A9438")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x27A6DB8", Offset = "0x27A6DB8", VA = "0x27A6DB8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x27A8168", Offset = "0x27A8168", VA = "0x27A8168")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x27A9824", Offset = "0x27A9824", VA = "0x27A9824")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x27A986C", Offset = "0x27A986C", VA = "0x27A986C")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x27A92E8", Offset = "0x27A92E8", VA = "0x27A92E8")]
		private void Write()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x27AAE30", Offset = "0x27AAE30", VA = "0x27AAE30")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x27AB440", Offset = "0x27AB440", VA = "0x27AB440")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118008C", Offset = "0x118008C")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x29F93D4", Offset = "0x29F93D4", VA = "0x29F93D4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x29F9AC8", Offset = "0x29F9AC8", VA = "0x29F9AC8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x29FA04C", Offset = "0x29FA04C", VA = "0x29FA04C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x29FA114", Offset = "0x29FA114", VA = "0x29FA114")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x29FA218", Offset = "0x29FA218", VA = "0x29FA218")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class TwistSolver
	{
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11800C4", Offset = "0x11800C4")]
		public Transform transform;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11800FC", Offset = "0x11800FC")]
		public Transform parent;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180134", Offset = "0x1180134")]
		public Transform[] children;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118016C", Offset = "0x118016C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118016C", Offset = "0x118016C")]
		public float weight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11801C0", Offset = "0x11801C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11801C0", Offset = "0x11801C0")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180214", Offset = "0x1180214")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180214", Offset = "0x1180214")]
		public float twistAngleOffset;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x29FA278", Offset = "0x29FA278", VA = "0x29FA278")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x29F9584", Offset = "0x29F9584", VA = "0x29F9584")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x29F9B90", Offset = "0x29F9B90", VA = "0x29F9B90")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1180270", Offset = "0x1180270")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1180280", Offset = "0x1180280")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1180290", Offset = "0x1180290")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000047")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x280B8D0", Offset = "0x280B8D0", VA = "0x280B8D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186008", Offset = "0x1186008")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x280B8D8", Offset = "0x280B8D8", VA = "0x280B8D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186018", Offset = "0x1186018")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool isPaused
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x280B8E0", Offset = "0x280B8E0", VA = "0x280B8E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186028", Offset = "0x1186028")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x280B8E8", Offset = "0x280B8E8", VA = "0x280B8E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186038", Offset = "0x1186038")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x280B8F4", Offset = "0x280B8F4", VA = "0x280B8F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186048", Offset = "0x1186048")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x280B8FC", Offset = "0x280B8FC", VA = "0x280B8FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186058", Offset = "0x1186058")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool inInteraction
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x280B904", Offset = "0x280B904", VA = "0x280B904")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public float progress
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x280E540", Offset = "0x280E540", VA = "0x280E540")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x280B974", Offset = "0x280B974", VA = "0x280B974")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x280B9F8", Offset = "0x280B9F8", VA = "0x280B9F8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x280BA94", Offset = "0x280BA94", VA = "0x280BA94")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x280BC0C", Offset = "0x280BC0C", VA = "0x280BC0C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x280C0BC", Offset = "0x280C0BC", VA = "0x280C0BC")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x280C47C", Offset = "0x280C47C", VA = "0x280C47C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x280C4D0", Offset = "0x280C4D0", VA = "0x280C4D0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x280D180", Offset = "0x280D180", VA = "0x280D180")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x280DCE8", Offset = "0x280DCE8", VA = "0x280DCE8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x280DF10", Offset = "0x280DF10", VA = "0x280DF10")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x280E3EC", Offset = "0x280E3EC", VA = "0x280E3EC")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x280EA28", Offset = "0x280EA28", VA = "0x280EA28")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11802A0", Offset = "0x11802A0")]
		public LookAtIK ik;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11802D8", Offset = "0x11802D8")]
		public float lerpSpeed;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180310", Offset = "0x1180310")]
		public float weightSpeed;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x280ED10", Offset = "0x280ED10", VA = "0x280ED10")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x280EE88", Offset = "0x280EE88", VA = "0x280EE88")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x280EF30", Offset = "0x280EF30", VA = "0x280EF30")]
		public void Update()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x280F174", Offset = "0x280F174", VA = "0x280F174")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x280F26C", Offset = "0x280F26C", VA = "0x280F26C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x280F338", Offset = "0x280F338", VA = "0x280F338")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D904", Offset = "0x117D904")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D904", Offset = "0x117D904")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118338C", Offset = "0x118338C")]
			public float time;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11833C4", Offset = "0x11833C4")]
			public bool pause;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11833FC", Offset = "0x11833FC")]
			public bool pickUp;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183434", Offset = "0x1183434")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118346C", Offset = "0x118346C")]
			public Message[] messages;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11834A4", Offset = "0x11834A4")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x280E57C", Offset = "0x280E57C", VA = "0x280E57C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x2810634", Offset = "0x2810634", VA = "0x2810634")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Message
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11834DC", Offset = "0x11834DC")]
			public string function;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183514", Offset = "0x1183514")]
			public GameObject recipient;

			[Token(Token = "0x4000521")]
			private const string empty = "";

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x2810544", Offset = "0x2810544", VA = "0x2810544")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x281063C", Offset = "0x281063C", VA = "0x281063C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118354C", Offset = "0x118354C")]
			public Animator animator;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183584", Offset = "0x1183584")]
			public Animation animation;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11835BC", Offset = "0x11835BC")]
			public string animationState;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11835F4", Offset = "0x11835F4")]
			public float crossfadeTime;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118362C", Offset = "0x118362C")]
			public int layer;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183664", Offset = "0x1183664")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000528")]
			private const string empty = "";

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x28102A4", Offset = "0x28102A4", VA = "0x28102A4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x2810398", Offset = "0x2810398", VA = "0x2810398")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x2810450", Offset = "0x2810450", VA = "0x2810450")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x2810530", Offset = "0x2810530", VA = "0x2810530")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000133")]
			public enum Type
			{
				[Token(Token = "0x400066C")]
				PositionWeight,
				[Token(Token = "0x400066D")]
				RotationWeight,
				[Token(Token = "0x400066E")]
				PositionOffsetX,
				[Token(Token = "0x400066F")]
				PositionOffsetY,
				[Token(Token = "0x4000670")]
				PositionOffsetZ,
				[Token(Token = "0x4000671")]
				Pull,
				[Token(Token = "0x4000672")]
				Reach,
				[Token(Token = "0x4000673")]
				RotateBoneWeight,
				[Token(Token = "0x4000674")]
				Push,
				[Token(Token = "0x4000675")]
				PushParent,
				[Token(Token = "0x4000676")]
				PoserWeight,
				[Token(Token = "0x4000677")]
				BendGoalWeight
			}

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118369C", Offset = "0x118369C")]
			public Type type;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11836D4", Offset = "0x11836D4")]
			public AnimationCurve curve;

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x280FABC", Offset = "0x280FABC", VA = "0x280FABC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x2810654", Offset = "0x2810654", VA = "0x2810654")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B8")]
		public class Multiplier
		{
			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118370C", Offset = "0x118370C")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183744", Offset = "0x1183744")]
			public float multiplier;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118377C", Offset = "0x118377C")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x281019C", Offset = "0x281019C", VA = "0x281019C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x2810644", Offset = "0x2810644", VA = "0x2810644")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180358", Offset = "0x1180358")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180390", Offset = "0x1180390")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11803C8", Offset = "0x11803C8")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1180400", Offset = "0x1180400")]
		private float <length>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1180410", Offset = "0x1180410")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004C")]
		public float length
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x280F5AC", Offset = "0x280F5AC", VA = "0x280F5AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186228", Offset = "0x1186228")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x280F5B4", Offset = "0x280F5B4", VA = "0x280F5B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186238", Offset = "0x1186238")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x280F5BC", Offset = "0x280F5BC", VA = "0x280F5BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186248", Offset = "0x1186248")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x280F5C4", Offset = "0x280F5C4", VA = "0x280F5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186258", Offset = "0x1186258")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x280F7E0", Offset = "0x280F7E0", VA = "0x280F7E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x280E8FC", Offset = "0x280E8FC", VA = "0x280E8FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x280F34C", Offset = "0x280F34C", VA = "0x280F34C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186068", Offset = "0x1186068")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x280F398", Offset = "0x280F398", VA = "0x280F398")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11860A0", Offset = "0x11860A0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x280F3E4", Offset = "0x280F3E4", VA = "0x280F3E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11860D8", Offset = "0x11860D8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x280F430", Offset = "0x280F430", VA = "0x280F430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186110", Offset = "0x1186110")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x280F47C", Offset = "0x280F47C", VA = "0x280F47C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186148", Offset = "0x1186148")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x280F4C8", Offset = "0x280F4C8", VA = "0x280F4C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186180", Offset = "0x1186180")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x280F514", Offset = "0x280F514", VA = "0x280F514")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11861B8", Offset = "0x11861B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x280F560", Offset = "0x280F560", VA = "0x280F560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11861F0", Offset = "0x11861F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x280F5CC", Offset = "0x280F5CC", VA = "0x280F5CC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x280F870", Offset = "0x280F870", VA = "0x280F870")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x280CA34", Offset = "0x280CA34", VA = "0x280CA34")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x280F9D4", Offset = "0x280F9D4", VA = "0x280F9D4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x280C8F0", Offset = "0x280C8F0", VA = "0x280C8F0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x280CA2C", Offset = "0x280CA2C", VA = "0x280CA2C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x280D8CC", Offset = "0x280D8CC", VA = "0x280D8CC")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x280E1C4", Offset = "0x280E1C4", VA = "0x280E1C4")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x28101D8", Offset = "0x28101D8", VA = "0x28101D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x280FAD8", Offset = "0x280FAD8", VA = "0x280FAD8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x280F9DC", Offset = "0x280F9DC", VA = "0x280F9DC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2810134", Offset = "0x2810134", VA = "0x2810134")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x28101DC", Offset = "0x28101DC", VA = "0x28101DC")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2810244", Offset = "0x2810244", VA = "0x2810244")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D964", Offset = "0x117D964")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D964", Offset = "0x117D964")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000B9")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000BA")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180420", Offset = "0x1180420")]
		public string targetTag;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180458", Offset = "0x1180458")]
		public float fadeInTime;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180490", Offset = "0x1180490")]
		public float speed;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11804C8", Offset = "0x11804C8")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1180500", Offset = "0x1180500")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180500", Offset = "0x1180500")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1180500", Offset = "0x1180500")]
		public Collider characterCollider;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180584", Offset = "0x1180584")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1180584", Offset = "0x1180584")]
		public Transform FPSCamera;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11805E4", Offset = "0x11805E4")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118061C", Offset = "0x118061C")]
		public float camRaycastDistance;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1180654", Offset = "0x1180654")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1180664", Offset = "0x1180664")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180664", Offset = "0x1180664")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11806C4", Offset = "0x11806C4")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11806FC", Offset = "0x11806FC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000050")]
		public bool inInteraction
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x28108BC", Offset = "0x28108BC", VA = "0x28108BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x28124D4", Offset = "0x28124D4", VA = "0x28124D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x28124DC", Offset = "0x28124DC", VA = "0x28124DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x28124E4", Offset = "0x28124E4", VA = "0x28124E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186428", Offset = "0x1186428")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x28124EC", Offset = "0x28124EC", VA = "0x28124EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186438", Offset = "0x1186438")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool initiated
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x28124F4", Offset = "0x28124F4", VA = "0x28124F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186448", Offset = "0x1186448")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x28124FC", Offset = "0x28124FC", VA = "0x28124FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186458", Offset = "0x1186458")]
			private set
			{
			}
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x281065C", Offset = "0x281065C", VA = "0x281065C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186268", Offset = "0x1186268")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x28106A8", Offset = "0x28106A8", VA = "0x28106A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11862A0", Offset = "0x11862A0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x28106F4", Offset = "0x28106F4", VA = "0x28106F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11862D8", Offset = "0x11862D8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2810740", Offset = "0x2810740", VA = "0x2810740")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186310", Offset = "0x1186310")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x281078C", Offset = "0x281078C", VA = "0x281078C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186348", Offset = "0x1186348")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x28107D8", Offset = "0x28107D8", VA = "0x28107D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186380", Offset = "0x1186380")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2810824", Offset = "0x2810824", VA = "0x2810824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11863B8", Offset = "0x11863B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2810870", Offset = "0x2810870", VA = "0x2810870")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11863F0", Offset = "0x11863F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2810A4C", Offset = "0x2810A4C", VA = "0x2810A4C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2810B18", Offset = "0x2810B18", VA = "0x2810B18")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2810BE4", Offset = "0x2810BE4", VA = "0x2810BE4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2810C90", Offset = "0x2810C90", VA = "0x2810C90")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2810D88", Offset = "0x2810D88", VA = "0x2810D88")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2810EA4", Offset = "0x2810EA4", VA = "0x2810EA4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2810F34", Offset = "0x2810F34", VA = "0x2810F34")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2810FC4", Offset = "0x2810FC4", VA = "0x2810FC4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2811054", Offset = "0x2811054", VA = "0x2811054")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x28110C8", Offset = "0x28110C8", VA = "0x28110C8")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x281113C", Offset = "0x281113C", VA = "0x281113C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x28111A4", Offset = "0x28111A4", VA = "0x28111A4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x2811230", Offset = "0x2811230", VA = "0x2811230")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x28112E4", Offset = "0x28112E4", VA = "0x28112E4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x28113C8", Offset = "0x28113C8", VA = "0x28113C8")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x281166C", Offset = "0x281166C", VA = "0x281166C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2811844", Offset = "0x2811844", VA = "0x2811844")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2811AB8", Offset = "0x2811AB8", VA = "0x2811AB8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2811DAC", Offset = "0x2811DAC", VA = "0x2811DAC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2811DF0", Offset = "0x2811DF0", VA = "0x2811DF0")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2811E68", Offset = "0x2811E68", VA = "0x2811E68")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2811F88", Offset = "0x2811F88", VA = "0x2811F88")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2812100", Offset = "0x2812100", VA = "0x2812100")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x28123A8", Offset = "0x28123A8", VA = "0x28123A8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2811BB8", Offset = "0x2811BB8", VA = "0x2811BB8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2812508", Offset = "0x2812508", VA = "0x2812508")]
		public void Start()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2812BBC", Offset = "0x2812BBC", VA = "0x2812BBC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2812BDC", Offset = "0x2812BDC", VA = "0x2812BDC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2812BF8", Offset = "0x2812BF8", VA = "0x2812BF8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2812C14", Offset = "0x2812C14", VA = "0x2812C14")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2812C74", Offset = "0x2812C74", VA = "0x2812C74")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2812D90", Offset = "0x2812D90", VA = "0x2812D90")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2812E8C", Offset = "0x2812E8C", VA = "0x2812E8C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x28131EC", Offset = "0x28131EC", VA = "0x28131EC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x28132D8", Offset = "0x28132D8", VA = "0x28132D8")]
		public void Update()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x28134F0", Offset = "0x28134F0", VA = "0x28134F0")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2812934", Offset = "0x2812934", VA = "0x2812934")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2813630", Offset = "0x2813630", VA = "0x2813630")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x281375C", Offset = "0x281375C", VA = "0x281375C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x28137F4", Offset = "0x28137F4", VA = "0x28137F4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x28138CC", Offset = "0x28138CC", VA = "0x28138CC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x28138E4", Offset = "0x28138E4", VA = "0x28138E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2810968", Offset = "0x2810968", VA = "0x2810968")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2811568", Offset = "0x2811568", VA = "0x2811568")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2813BD4", Offset = "0x2813BD4", VA = "0x2813BD4")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117D9C4", Offset = "0x117D9C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117D9C4", Offset = "0x117D9C4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public enum RotationMode
		{
			[Token(Token = "0x400052F")]
			TwoDOF,
			[Token(Token = "0x4000530")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public class Multiplier
		{
			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11837B4", Offset = "0x11837B4")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11837EC", Offset = "0x11837EC")]
			public float multiplier;

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x2814378", Offset = "0x2814378", VA = "0x2814378")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118070C", Offset = "0x118070C")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180744", Offset = "0x1180744")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118077C", Offset = "0x118077C")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11807B4", Offset = "0x11807B4")]
		public Transform pivot;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11807EC", Offset = "0x11807EC")]
		public RotationMode rotationMode;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180824", Offset = "0x1180824")]
		public Vector3 twistAxis;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118085C", Offset = "0x118085C")]
		public float twistWeight;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180894", Offset = "0x1180894")]
		public float swingWeight;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11808CC", Offset = "0x11808CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11808CC", Offset = "0x11808CC")]
		public float threeDOFWeight;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180920", Offset = "0x1180920")]
		public bool rotateOnce;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2814088", Offset = "0x2814088", VA = "0x2814088")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186468", Offset = "0x1186468")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x28140D4", Offset = "0x28140D4", VA = "0x28140D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11864A0", Offset = "0x11864A0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2814120", Offset = "0x2814120", VA = "0x2814120")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11864D8", Offset = "0x11864D8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x281416C", Offset = "0x281416C", VA = "0x281416C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186510", Offset = "0x1186510")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x28141B8", Offset = "0x28141B8", VA = "0x28141B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186548", Offset = "0x1186548")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2814204", Offset = "0x2814204", VA = "0x2814204")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186580", Offset = "0x1186580")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2814250", Offset = "0x2814250", VA = "0x2814250")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11865B8", Offset = "0x11865B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x281429C", Offset = "0x281429C", VA = "0x281429C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11865F0", Offset = "0x11865F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x280FA4C", Offset = "0x280FA4C", VA = "0x280FA4C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x280E98C", Offset = "0x280E98C", VA = "0x280E98C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x280CAE8", Offset = "0x280CAE8", VA = "0x280CAE8")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x28142E8", Offset = "0x28142E8", VA = "0x28142E8")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117DA24", Offset = "0x117DA24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117DA24", Offset = "0x117DA24")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183824", Offset = "0x1183824")]
			public bool use;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118385C", Offset = "0x118385C")]
			public Vector2 offset;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183894", Offset = "0x1183894")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183894", Offset = "0x1183894")]
			public float angleOffset;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11838F0", Offset = "0x11838F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11838F0", Offset = "0x11838F0")]
			public float maxAngle;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183948", Offset = "0x1183948")]
			public float radius;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183980", Offset = "0x1183980")]
			public bool orbit;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11839B8", Offset = "0x11839B8")]
			public bool fixYAxis;

			[Token(Token = "0x170000D4")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x2814B94", Offset = "0x2814B94", VA = "0x2814B94")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D5")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0x2814BD0", Offset = "0x2814BD0", VA = "0x2814BD0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x2814CC8", Offset = "0x2814CC8", VA = "0x2814CC8")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x2815344", Offset = "0x2815344", VA = "0x2815344")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public class CameraPosition
		{
			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11839F0", Offset = "0x11839F0")]
			public Collider lookAtTarget;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183A28", Offset = "0x1183A28")]
			public Vector3 direction;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183A60", Offset = "0x1183A60")]
			public float maxDistance;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183A98", Offset = "0x1183A98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183A98", Offset = "0x1183A98")]
			public float maxAngle;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183AF0", Offset = "0x1183AF0")]
			public bool fixYAxis;

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x2814680", Offset = "0x2814680", VA = "0x2814680")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x2814828", Offset = "0x2814828", VA = "0x2814828")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x2814B08", Offset = "0x2814B08", VA = "0x2814B08")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000134")]
			public class Interaction
			{
				[Token(Token = "0x4000678")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184AE8", Offset = "0x1184AE8")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000679")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184B20", Offset = "0x1184B20")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000860")]
				[Address(RVA = "0x2815368", Offset = "0x2815368", VA = "0x2815368")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183B48", Offset = "0x1183B48")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183B80", Offset = "0x1183B80")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183BB8", Offset = "0x1183BB8")]
			public Interaction[] interactions;

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x28144FC", Offset = "0x28144FC", VA = "0x28144FC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x2815358", Offset = "0x2815358", VA = "0x2815358")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180958", Offset = "0x1180958")]
		public Range[] ranges;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2814380", Offset = "0x2814380", VA = "0x2814380")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186628", Offset = "0x1186628")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x28143CC", Offset = "0x28143CC", VA = "0x28143CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186660", Offset = "0x1186660")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2814418", Offset = "0x2814418", VA = "0x2814418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186698", Offset = "0x1186698")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2814464", Offset = "0x2814464", VA = "0x2814464")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11866D0", Offset = "0x11866D0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x28144B0", Offset = "0x28144B0", VA = "0x28144B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186708", Offset = "0x1186708")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2813030", Offset = "0x2813030", VA = "0x2813030")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2814620", Offset = "0x2814620", VA = "0x2814620")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class Map
		{
			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x282E310", Offset = "0x282E310", VA = "0x282E310")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x282E714", Offset = "0x282E714", VA = "0x282E714")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x282E6C8", Offset = "0x282E6C8", VA = "0x282E6C8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x282E4C0", Offset = "0x282E4C0", VA = "0x282E4C0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x282E028", Offset = "0x282E028", VA = "0x282E028", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186740", Offset = "0x1186740")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x282E3B4", Offset = "0x282E3B4", VA = "0x282E3B4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x282E3B8", Offset = "0x282E3B8", VA = "0x282E3B8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x282E660", Offset = "0x282E660", VA = "0x282E660", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x282E34C", Offset = "0x282E34C", VA = "0x282E34C")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x282E270", Offset = "0x282E270", VA = "0x282E270")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x282E764", Offset = "0x282E764", VA = "0x282E764")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x27576B8", Offset = "0x27576B8", VA = "0x27576B8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x275776C", Offset = "0x275776C", VA = "0x275776C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2757924", Offset = "0x2757924", VA = "0x2757924", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2757A20", Offset = "0x2757A20", VA = "0x2757A20", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x27577C8", Offset = "0x27577C8", VA = "0x27577C8")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2757DD0", Offset = "0x2757DD0", VA = "0x2757DD0")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180990", Offset = "0x1180990")]
		public float weight;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11809A8", Offset = "0x11809A8")]
		public float localRotationWeight;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11809C0", Offset = "0x11809C0")]
		public float localPositionWeight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60003FA")]
		public abstract void AutoMapping();

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x29F22A8", Offset = "0x29F22A8", VA = "0x29F22A8")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60003FC")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60003FD")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60003FE")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x29F22B4", Offset = "0x29F22B4", VA = "0x29F22B4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x29F2308", Offset = "0x29F2308", VA = "0x29F2308", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x29F2344", Offset = "0x29F2344", VA = "0x29F2344", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x29F235C", Offset = "0x29F235C", VA = "0x29F235C")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		public class Rigidbone
		{
			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x29F2908", Offset = "0x29F2908", VA = "0x29F2908")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x29F3514", Offset = "0x29F3514", VA = "0x29F3514")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x29F32F8", Offset = "0x29F32F8", VA = "0x29F32F8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000C2")]
		public class Child
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x29F2A64", Offset = "0x29F2A64", VA = "0x29F2A64")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x29F36AC", Offset = "0x29F36AC", VA = "0x29F36AC")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x29F365C", Offset = "0x29F365C", VA = "0x29F365C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DCD8", Offset = "0x117DCD8")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000704")]
				[Address(RVA = "0x29F3C8C", Offset = "0x29F3C8C", VA = "0x29F3C8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000706")]
				[Address(RVA = "0x29F3CF4", Offset = "0x29F3CF4", VA = "0x29F3CF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x29F2AC4", Offset = "0x29F2AC4", VA = "0x29F2AC4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x29F3A44", Offset = "0x29F3A44", VA = "0x29F3A44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x29F3A48", Offset = "0x29F3A48", VA = "0x29F3A48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x29F3C94", Offset = "0x29F3C94", VA = "0x29F3C94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11809D8", Offset = "0x11809D8")]
		public IK ik;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180A10", Offset = "0x1180A10")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180A48", Offset = "0x1180A48")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180A80", Offset = "0x1180A80")]
		public float applyVelocity;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180AB8", Offset = "0x1180AB8")]
		public float applyAngularVelocity;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000054")]
		private bool isRagdoll
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x29F23CC", Offset = "0x29F23CC", VA = "0x29F23CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		private bool ikUsed
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x29F2EB0", Offset = "0x29F2EB0", VA = "0x29F2EB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x29F2394", Offset = "0x29F2394", VA = "0x29F2394")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x29F2444", Offset = "0x29F2444", VA = "0x29F2444")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x29F2574", Offset = "0x29F2574", VA = "0x29F2574")]
		public void Start()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x29F2504", Offset = "0x29F2504", VA = "0x29F2504")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1186778", Offset = "0x1186778")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x29F2AF0", Offset = "0x29F2AF0", VA = "0x29F2AF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x29F2D3C", Offset = "0x29F2D3C", VA = "0x29F2D3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x29F2DF4", Offset = "0x29F2DF4", VA = "0x29F2DF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x29F3034", Offset = "0x29F3034", VA = "0x29F3034")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x29F2E74", Offset = "0x29F2E74", VA = "0x29F2E74")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x29F2FF0", Offset = "0x29F2FF0", VA = "0x29F2FF0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x29F30D0", Offset = "0x29F30D0", VA = "0x29F30D0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x29F3068", Offset = "0x29F3068", VA = "0x29F3068")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x29F249C", Offset = "0x29F249C", VA = "0x29F249C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x29F2D7C", Offset = "0x29F2D7C", VA = "0x29F2D7C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x29F3874", Offset = "0x29F3874", VA = "0x29F3874")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x29F3978", Offset = "0x29F3978", VA = "0x29F3978")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1180B00", Offset = "0x1180B00")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000056")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x29F56D4", Offset = "0x29F56D4", VA = "0x29F56D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000057")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x29F5710", Offset = "0x29F5710", VA = "0x29F5710")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x29F57E0", Offset = "0x29F57E0", VA = "0x29F57E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11867DC", Offset = "0x11867DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x29F57E8", Offset = "0x29F57E8", VA = "0x29F57E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11867EC", Offset = "0x11867EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x29F5338", Offset = "0x29F5338", VA = "0x29F5338")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x29F5380", Offset = "0x29F5380", VA = "0x29F5380")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x29F5398", Offset = "0x29F5398", VA = "0x29F5398")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x29F562C", Offset = "0x29F562C", VA = "0x29F562C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x29F569C", Offset = "0x29F569C", VA = "0x29F569C")]
		public void Disable()
		{
		}

		[Token(Token = "0x600041E")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x29F553C", Offset = "0x29F553C", VA = "0x29F553C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x29F57F4", Offset = "0x29F57F4", VA = "0x29F57F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x29F57F8", Offset = "0x29F57F8", VA = "0x29F57F8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x29F58E0", Offset = "0x29F58E0", VA = "0x29F58E0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x29F59C4", Offset = "0x29F59C4", VA = "0x29F59C4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x29F5C40", Offset = "0x29F5C40", VA = "0x29F5C40")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x29F5CFC", Offset = "0x29F5CFC", VA = "0x29F5CFC")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117DA84", Offset = "0x117DA84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117DA84", Offset = "0x117DA84")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180B10", Offset = "0x1180B10")]
		public float limit;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180B2C", Offset = "0x1180B2C")]
		public float twistLimit;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x29F5D74", Offset = "0x29F5D74", VA = "0x29F5D74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11867FC", Offset = "0x11867FC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x29F5DC0", Offset = "0x29F5DC0", VA = "0x29F5DC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186834", Offset = "0x1186834")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x29F5E0C", Offset = "0x29F5E0C", VA = "0x29F5E0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118686C", Offset = "0x118686C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x29F5E58", Offset = "0x29F5E58", VA = "0x29F5E58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11868A4", Offset = "0x11868A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x29F5EA4", Offset = "0x29F5EA4", VA = "0x29F5EA4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x29F5F5C", Offset = "0x29F5F5C", VA = "0x29F5F5C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x29F61A4", Offset = "0x29F61A4", VA = "0x29F61A4")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117DAE4", Offset = "0x117DAE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117DAE4", Offset = "0x117DAE4")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x29F61B4", Offset = "0x29F61B4", VA = "0x29F61B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11868DC", Offset = "0x11868DC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x29F6200", Offset = "0x29F6200", VA = "0x29F6200")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186914", Offset = "0x1186914")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x29F624C", Offset = "0x29F624C", VA = "0x29F624C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118694C", Offset = "0x118694C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x29F6298", Offset = "0x29F6298", VA = "0x29F6298")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186984", Offset = "0x1186984")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x29F62E4", Offset = "0x29F62E4", VA = "0x29F62E4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x29F62E8", Offset = "0x29F62E8", VA = "0x29F62E8")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x29F6594", Offset = "0x29F6594", VA = "0x29F6594")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117DB44", Offset = "0x117DB44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117DB44", Offset = "0x117DB44")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class ReachCone
		{
			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000D8")]
			public Vector3 o
			{
				[Token(Token = "0x6000707")]
				[Address(RVA = "0x29F84C0", Offset = "0x29F84C0", VA = "0x29F84C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D9")]
			public Vector3 a
			{
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x29F84F8", Offset = "0x29F84F8", VA = "0x29F84F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DA")]
			public Vector3 b
			{
				[Token(Token = "0x6000709")]
				[Address(RVA = "0x29F8534", Offset = "0x29F8534", VA = "0x29F8534")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DB")]
			public Vector3 c
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x29F8570", Offset = "0x29F8570", VA = "0x29F8570")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DC")]
			public bool isValid
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x29F7624", Offset = "0x29F7624", VA = "0x29F7624")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x29F7C70", Offset = "0x29F7C70", VA = "0x29F7C70")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x29F7DD0", Offset = "0x29F7DD0", VA = "0x29F7DD0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public class LimitPoint
		{
			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x29F7634", Offset = "0x29F7634", VA = "0x29F7634")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180B58", Offset = "0x1180B58")]
		public float twistLimit;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180B74", Offset = "0x1180B74")]
		public int smoothIterations;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x29F65AC", Offset = "0x29F65AC", VA = "0x29F65AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11869BC", Offset = "0x11869BC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x29F65F8", Offset = "0x29F65F8", VA = "0x29F65F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11869F4", Offset = "0x11869F4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x29F6644", Offset = "0x29F6644", VA = "0x29F6644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186A2C", Offset = "0x1186A2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x29F6690", Offset = "0x29F6690", VA = "0x29F6690")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186A64", Offset = "0x1186A64")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x29F66DC", Offset = "0x29F66DC", VA = "0x29F66DC")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x29F6BC0", Offset = "0x29F6BC0", VA = "0x29F6BC0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x29F6CB8", Offset = "0x29F6CB8", VA = "0x29F6CB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x29F7270", Offset = "0x29F7270", VA = "0x29F7270")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x29F6778", Offset = "0x29F6778", VA = "0x29F6778")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x29F76B8", Offset = "0x29F76B8", VA = "0x29F76B8")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x29F7F90", Offset = "0x29F7F90", VA = "0x29F7F90")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x29F7FD4", Offset = "0x29F7FD4", VA = "0x29F7FD4")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x29F811C", Offset = "0x29F811C", VA = "0x29F811C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x29F6F38", Offset = "0x29F6F38", VA = "0x29F6F38")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x29F82AC", Offset = "0x29F82AC", VA = "0x29F82AC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x29F845C", Offset = "0x29F845C", VA = "0x29F845C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x117DBA4", Offset = "0x117DBA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x117DBA4", Offset = "0x117DBA4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180BBC", Offset = "0x1180BBC")]
		public float twistLimit;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x29F85AC", Offset = "0x29F85AC", VA = "0x29F85AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186A9C", Offset = "0x1186A9C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x29F85F8", Offset = "0x29F85F8", VA = "0x29F85F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186AD4", Offset = "0x1186AD4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x29F8644", Offset = "0x29F8644", VA = "0x29F8644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186B0C", Offset = "0x1186B0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x29F8690", Offset = "0x29F8690", VA = "0x29F8690")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1186B44", Offset = "0x1186B44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x29F86DC", Offset = "0x29F86DC", VA = "0x29F86DC")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x29F86F8", Offset = "0x29F86F8", VA = "0x29F86F8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x29F87B0", Offset = "0x29F87B0", VA = "0x29F87B0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x29F8ADC", Offset = "0x29F8ADC", VA = "0x29F8ADC")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DCE8", Offset = "0x117DCE8")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000712")]
				[Address(RVA = "0x2820D68", Offset = "0x2820D68", VA = "0x2820D68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000714")]
				[Address(RVA = "0x2820DD0", Offset = "0x2820DD0", VA = "0x2820DD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x2820B44", Offset = "0x2820B44", VA = "0x2820B44")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x2820C44", Offset = "0x2820C44", VA = "0x2820C44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x2820C48", Offset = "0x2820C48", VA = "0x2820C48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x2820D70", Offset = "0x2820D70", VA = "0x2820D70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180BE8", Offset = "0x1180BE8")]
		public AimIK ik;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180C20", Offset = "0x1180C20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180C20", Offset = "0x1180C20")]
		public float weight;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1180C74", Offset = "0x1180C74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180C74", Offset = "0x1180C74")]
		public Transform target;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180CD4", Offset = "0x1180CD4")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180D0C", Offset = "0x1180D0C")]
		public float weightSmoothTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1180D44", Offset = "0x1180D44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180D44", Offset = "0x1180D44")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180DA4", Offset = "0x1180DA4")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180DDC", Offset = "0x1180DDC")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180E14", Offset = "0x1180E14")]
		public float slerpSpeed;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180E4C", Offset = "0x1180E4C")]
		public float smoothDampTime;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180E84", Offset = "0x1180E84")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180EBC", Offset = "0x1180EBC")]
		public float minDistance;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180EF4", Offset = "0x1180EF4")]
		public Vector3 offset;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1180F2C", Offset = "0x1180F2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180F2C", Offset = "0x1180F2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1180F2C", Offset = "0x1180F2C")]
		public float maxRootAngle;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180FA8", Offset = "0x1180FA8")]
		public bool turnToTarget;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1180FE0", Offset = "0x1180FE0")]
		public float turnToTargetTime;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1181018", Offset = "0x1181018")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181018", Offset = "0x1181018")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181078", Offset = "0x1181078")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x17000059")]
		private Vector3 pivot
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x281FAD4", Offset = "0x281FAD4", VA = "0x281FAD4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x281F9D8", Offset = "0x281F9D8", VA = "0x281F9D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x281FC20", Offset = "0x281FC20", VA = "0x281FC20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x28205C8", Offset = "0x28205C8", VA = "0x28205C8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2820764", Offset = "0x2820764", VA = "0x2820764")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2820AD4", Offset = "0x2820AD4", VA = "0x2820AD4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1186B7C", Offset = "0x1186B7C")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2820B70", Offset = "0x2820B70", VA = "0x2820B70")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Pose
		{
			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x28210A0", Offset = "0x28210A0", VA = "0x28210A0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x282140C", Offset = "0x282140C", VA = "0x282140C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x2821414", Offset = "0x2821414", VA = "0x2821414")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2820FC4", Offset = "0x2820FC4", VA = "0x2820FC4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2821338", Offset = "0x2821338", VA = "0x2821338")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x28213A4", Offset = "0x28213A4", VA = "0x28213A4")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000135")]
			public class EffectorLink
			{
				[Token(Token = "0x400067A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184B58", Offset = "0x1184B58")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400067B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184B90", Offset = "0x1184B90")]
				public float weight;

				[Token(Token = "0x6000861")]
				[Address(RVA = "0x2821A04", Offset = "0x2821A04", VA = "0x2821A04")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183BF0", Offset = "0x1183BF0")]
			public Transform transform;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183C28", Offset = "0x1183C28")]
			public Transform relativeTo;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183C60", Offset = "0x1183C60")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183C98", Offset = "0x1183C98")]
			public float verticalWeight;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183CD0", Offset = "0x1183CD0")]
			public float horizontalWeight;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183D08", Offset = "0x1183D08")]
			public float speed;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x2821570", Offset = "0x2821570", VA = "0x2821570")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x28219DC", Offset = "0x28219DC", VA = "0x28219DC")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x28219EC", Offset = "0x28219EC", VA = "0x28219EC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11810B0", Offset = "0x11810B0")]
		public Body[] bodies;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2821430", Offset = "0x2821430", VA = "0x2821430", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x28219D4", Offset = "0x28219D4", VA = "0x28219D4")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11810E8", Offset = "0x11810E8")]
		public float tiltSpeed;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181120", Offset = "0x1181120")]
		public float tiltSensitivity;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181158", Offset = "0x1181158")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181190", Offset = "0x1181190")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2822F10", Offset = "0x2822F10", VA = "0x2822F10", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2822F58", Offset = "0x2822F58", VA = "0x2822F58", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2823188", Offset = "0x2823188", VA = "0x2823188")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11811C8", Offset = "0x11811C8")]
		public float weight;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x282319C", Offset = "0x282319C", VA = "0x282319C")]
		private void Start()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x282325C", Offset = "0x282325C", VA = "0x282325C")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x282356C", Offset = "0x282356C", VA = "0x282356C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2823664", Offset = "0x2823664", VA = "0x2823664")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11811E0", Offset = "0x11811E0")]
		public Animator animator;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181218", Offset = "0x1181218")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181260", Offset = "0x1181260")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700005A")]
		public IK ik
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x28240C8", Offset = "0x28240C8", VA = "0x28240C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186BE0", Offset = "0x1186BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x28240D0", Offset = "0x28240D0", VA = "0x28240D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186BF0", Offset = "0x1186BF0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x28240D8", Offset = "0x28240D8", VA = "0x28240D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x2824248", Offset = "0x2824248", VA = "0x2824248")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x28244D0", Offset = "0x28244D0", VA = "0x28244D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2824610", Offset = "0x2824610", VA = "0x2824610")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x28247D8", Offset = "0x28247D8", VA = "0x28247D8")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x28249E8", Offset = "0x28249E8", VA = "0x28249E8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2824C7C", Offset = "0x2824C7C", VA = "0x2824C7C")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x117DC14", Offset = "0x117DC14")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x1700005B")]
		public bool poseStored
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x2824344", Offset = "0x2824344", VA = "0x2824344")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x282468C", Offset = "0x282468C", VA = "0x282468C")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2824368", Offset = "0x2824368", VA = "0x2824368")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2824CDC", Offset = "0x2824CDC", VA = "0x2824CDC")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183D40", Offset = "0x1183D40")]
			public string name;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183D78", Offset = "0x1183D78")]
			public Collider collider;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183DB0", Offset = "0x1183DB0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183DFC", Offset = "0x1183DFC")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183E0C", Offset = "0x1183E0C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183E1C", Offset = "0x1183E1C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183E2C", Offset = "0x1183E2C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000DF")]
			public bool inProgress
			{
				[Token(Token = "0x600071B")]
				[Address(RVA = "0x2757E94", Offset = "0x2757E94", VA = "0x2757E94")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E0")]
			protected float crossFader
			{
				[Token(Token = "0x600071C")]
				[Address(RVA = "0x275843C", Offset = "0x275843C", VA = "0x275843C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187E80", Offset = "0x1187E80")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071D")]
				[Address(RVA = "0x2758444", Offset = "0x2758444", VA = "0x2758444")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187E90", Offset = "0x1187E90")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E1")]
			protected float timer
			{
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x275844C", Offset = "0x275844C", VA = "0x275844C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187EA0", Offset = "0x1187EA0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071F")]
				[Address(RVA = "0x2758454", Offset = "0x2758454", VA = "0x2758454")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187EB0", Offset = "0x1187EB0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			protected Vector3 force
			{
				[Token(Token = "0x6000720")]
				[Address(RVA = "0x275845C", Offset = "0x275845C", VA = "0x275845C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187EC0", Offset = "0x1187EC0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000721")]
				[Address(RVA = "0x2758468", Offset = "0x2758468", VA = "0x2758468")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187ED0", Offset = "0x1187ED0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E3")]
			protected Vector3 point
			{
				[Token(Token = "0x6000722")]
				[Address(RVA = "0x2758474", Offset = "0x2758474", VA = "0x2758474")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187EE0", Offset = "0x1187EE0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000723")]
				[Address(RVA = "0x2758480", Offset = "0x2758480", VA = "0x2758480")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187EF0", Offset = "0x1187EF0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x2758308", Offset = "0x2758308", VA = "0x2758308")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x2757F7C", Offset = "0x2757F7C", VA = "0x2757F7C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000726")]
			protected abstract float GetLength();

			[Token(Token = "0x6000727")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000728")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x275848C", Offset = "0x275848C", VA = "0x275848C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000136")]
			public class EffectorLink
			{
				[Token(Token = "0x400067C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184BC8", Offset = "0x1184BC8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400067D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184C00", Offset = "0x1184C00")]
				public float weight;

				[Token(Token = "0x400067E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400067F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000862")]
				[Address(RVA = "0x2758DF8", Offset = "0x2758DF8", VA = "0x2758DF8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000863")]
				[Address(RVA = "0x2758BEC", Offset = "0x2758BEC", VA = "0x2758BEC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000864")]
				[Address(RVA = "0x2758F34", Offset = "0x2758F34", VA = "0x2758F34")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183E3C", Offset = "0x1183E3C")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183E74", Offset = "0x1183E74")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183EAC", Offset = "0x1183EAC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x2758A08", Offset = "0x2758A08", VA = "0x2758A08", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x2758B80", Offset = "0x2758B80", VA = "0x2758B80", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x2758C00", Offset = "0x2758C00", VA = "0x2758C00", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x2758F20", Offset = "0x2758F20", VA = "0x2758F20")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CB")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000137")]
			public class BoneLink
			{
				[Token(Token = "0x4000680")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184C38", Offset = "0x1184C38")]
				public Transform bone;

				[Token(Token = "0x4000681")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184C70", Offset = "0x1184C70")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184C70", Offset = "0x1184C70")]
				public float weight;

				[Token(Token = "0x4000682")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000683")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000865")]
				[Address(RVA = "0x2758810", Offset = "0x2758810", VA = "0x2758810")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000866")]
				[Address(RVA = "0x27585A8", Offset = "0x27585A8", VA = "0x27585A8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000867")]
				[Address(RVA = "0x2758980", Offset = "0x2758980", VA = "0x2758980")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183EE4", Offset = "0x1183EE4")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183F1C", Offset = "0x1183F1C")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x27584A0", Offset = "0x27584A0", VA = "0x27584A0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x2758544", Offset = "0x2758544", VA = "0x2758544", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x27585B4", Offset = "0x27585B4", VA = "0x27585B4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x275896C", Offset = "0x275896C", VA = "0x275896C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181270", Offset = "0x1181270")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11812A8", Offset = "0x11812A8")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005C")]
		public bool inProgress
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2757DD8", Offset = "0x2757DD8", VA = "0x2757DD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x2757EA8", Offset = "0x2757EA8", VA = "0x2757EA8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x27580C8", Offset = "0x27580C8", VA = "0x27580C8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2758434", Offset = "0x2758434", VA = "0x2758434")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public abstract class Offset
		{
			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183F54", Offset = "0x1183F54")]
			public string name;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183F8C", Offset = "0x1183F8C")]
			public Collider collider;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183FC4", Offset = "0x1183FC4")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184010", Offset = "0x1184010")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184020", Offset = "0x1184020")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184030", Offset = "0x1184030")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184040", Offset = "0x1184040")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000E4")]
			protected float crossFader
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0x27594EC", Offset = "0x27594EC", VA = "0x27594EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187F00", Offset = "0x1187F00")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000733")]
				[Address(RVA = "0x27594F4", Offset = "0x27594F4", VA = "0x27594F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187F10", Offset = "0x1187F10")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			protected float timer
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0x27594FC", Offset = "0x27594FC", VA = "0x27594FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187F20", Offset = "0x1187F20")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x2759504", Offset = "0x2759504", VA = "0x2759504")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187F30", Offset = "0x1187F30")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			protected Vector3 force
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0x275950C", Offset = "0x275950C", VA = "0x275950C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187F40", Offset = "0x1187F40")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000737")]
				[Address(RVA = "0x2759518", Offset = "0x2759518", VA = "0x2759518")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187F50", Offset = "0x1187F50")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			protected Vector3 point
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0x2759524", Offset = "0x2759524", VA = "0x2759524")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187F60", Offset = "0x1187F60")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000739")]
				[Address(RVA = "0x2759530", Offset = "0x2759530", VA = "0x2759530")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1187F70", Offset = "0x1187F70")]
				private set
				{
				}
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x27593A4", Offset = "0x27593A4", VA = "0x27593A4")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x2759008", Offset = "0x2759008", VA = "0x2759008")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600073C")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600073D")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600073E")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x275953C", Offset = "0x275953C", VA = "0x275953C")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000138")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000684")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184CC4", Offset = "0x1184CC4")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000685")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184CFC", Offset = "0x1184CFC")]
				public float weight;

				[Token(Token = "0x4000686")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000687")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000868")]
				[Address(RVA = "0x27599F8", Offset = "0x27599F8", VA = "0x27599F8")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000869")]
				[Address(RVA = "0x27597B4", Offset = "0x27597B4", VA = "0x27597B4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600086A")]
				[Address(RVA = "0x2759B14", Offset = "0x2759B14", VA = "0x2759B14")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184050", Offset = "0x1184050")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184088", Offset = "0x1184088")]
			public int upDirCurveIndex;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11840C0", Offset = "0x11840C0")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x2759550", Offset = "0x2759550", VA = "0x2759550", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x2759748", Offset = "0x2759748", VA = "0x2759748", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x27597C8", Offset = "0x27597C8", VA = "0x27597C8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x2759AF8", Offset = "0x2759AF8", VA = "0x2759AF8")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000139")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000688")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184D34", Offset = "0x1184D34")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184D6C", Offset = "0x1184D6C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184D6C", Offset = "0x1184D6C")]
				public float weight;

				[Token(Token = "0x400068A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400068B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600086B")]
				[Address(RVA = "0x2759F7C", Offset = "0x2759F7C", VA = "0x2759F7C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600086C")]
				[Address(RVA = "0x2759C64", Offset = "0x2759C64", VA = "0x2759C64")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600086D")]
				[Address(RVA = "0x275A0B8", Offset = "0x275A0B8", VA = "0x275A0B8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11840F8", Offset = "0x11840F8")]
			public int curveIndex;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184130", Offset = "0x1184130")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x2759B1C", Offset = "0x2759B1C", VA = "0x2759B1C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x2759C00", Offset = "0x2759C00", VA = "0x2759C00", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x2759C70", Offset = "0x2759C70", VA = "0x2759C70", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x275A0A4", Offset = "0x275A0A4", VA = "0x275A0A4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11812E0", Offset = "0x11812E0")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181318", Offset = "0x1181318")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2758F3C", Offset = "0x2758F3C", VA = "0x2758F3C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x275915C", Offset = "0x275915C", VA = "0x275915C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x27594E4", Offset = "0x27594E4", VA = "0x27594E4")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200013A")]
			public class EffectorLink
			{
				[Token(Token = "0x400068C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184DC0", Offset = "0x1184DC0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184DF8", Offset = "0x1184DF8")]
				public float weight;

				[Token(Token = "0x600086E")]
				[Address(RVA = "0x280B8C8", Offset = "0x280B8C8", VA = "0x280B8C8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184168", Offset = "0x1184168")]
			public Transform transform;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11841A0", Offset = "0x11841A0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11841D8", Offset = "0x11841D8")]
			public float speed;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184210", Offset = "0x1184210")]
			public float acceleration;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184248", Offset = "0x1184248")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184248", Offset = "0x1184248")]
			public float matchVelocity;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118429C", Offset = "0x118429C")]
			public float gravity;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x280B298", Offset = "0x280B298", VA = "0x280B298")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x280B458", Offset = "0x280B458", VA = "0x280B458")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x280B8AC", Offset = "0x280B8AC", VA = "0x280B8AC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181350", Offset = "0x1181350")]
		public Body[] bodies;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181388", Offset = "0x1181388")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x280B220", Offset = "0x280B220", VA = "0x280B220")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x280B374", Offset = "0x280B374", VA = "0x280B374", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x280B88C", Offset = "0x280B88C", VA = "0x280B88C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11813C0", Offset = "0x11813C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11813C0", Offset = "0x11813C0")]
		public Transform target;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1181420", Offset = "0x1181420")]
		public float weight;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181438", Offset = "0x1181438")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181470", Offset = "0x1181470")]
		public float weightSmoothTime;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11814A8", Offset = "0x11814A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11814A8", Offset = "0x11814A8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181508", Offset = "0x1181508")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181540", Offset = "0x1181540")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181578", Offset = "0x1181578")]
		public float slerpSpeed;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11815B0", Offset = "0x11815B0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11815E8", Offset = "0x11815E8")]
		public float minDistance;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1181620", Offset = "0x1181620")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181620", Offset = "0x1181620")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1181620", Offset = "0x1181620")]
		public float maxRootAngle;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700005D")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x2815798", Offset = "0x2815798", VA = "0x2815798")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x28156B0", Offset = "0x28156B0", VA = "0x28156B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x28158E4", Offset = "0x28158E4", VA = "0x28158E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2815FAC", Offset = "0x2815FAC", VA = "0x2815FAC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2816148", Offset = "0x2816148", VA = "0x2816148")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2816464", Offset = "0x2816464", VA = "0x2816464")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class OffsetLimits
		{
			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11842D4", Offset = "0x11842D4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118430C", Offset = "0x118430C")]
			public float spring;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184344", Offset = "0x1184344")]
			public bool x;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118437C", Offset = "0x118437C")]
			public bool y;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11843B4", Offset = "0x11843B4")]
			public bool z;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11843EC", Offset = "0x11843EC")]
			public float minX;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184424", Offset = "0x1184424")]
			public float maxX;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118445C", Offset = "0x118445C")]
			public float minY;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184494", Offset = "0x1184494")]
			public float maxY;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11844CC", Offset = "0x11844CC")]
			public float minZ;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184504", Offset = "0x1184504")]
			public float maxZ;

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x281688C", Offset = "0x281688C", VA = "0x281688C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x2816D94", Offset = "0x2816D94", VA = "0x2816D94")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x2816DC4", Offset = "0x2816DC4", VA = "0x2816DC4")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x2816E9C", Offset = "0x2816E9C", VA = "0x2816E9C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DCF8", Offset = "0x117DCF8")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000E8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000752")]
				[Address(RVA = "0x2816D24", Offset = "0x2816D24", VA = "0x2816D24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000754")]
				[Address(RVA = "0x2816D8C", Offset = "0x2816D8C", VA = "0x2816D8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x2816754", Offset = "0x2816754", VA = "0x2816754")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x2816BE4", Offset = "0x2816BE4", VA = "0x2816BE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x2816BE8", Offset = "0x2816BE8", VA = "0x2816BE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x2816D2C", Offset = "0x2816D2C", VA = "0x2816D2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118169C", Offset = "0x118169C")]
		public float weight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11816D4", Offset = "0x11816D4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700005E")]
		protected float deltaTime
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x280B42C", Offset = "0x280B42C", VA = "0x280B42C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600047D")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x28166B8", Offset = "0x28166B8", VA = "0x28166B8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x28166E4", Offset = "0x28166E4", VA = "0x28166E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1186C00", Offset = "0x1186C00")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2816780", Offset = "0x2816780", VA = "0x2816780")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x280B7D0", Offset = "0x280B7D0", VA = "0x280B7D0")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2816AEC", Offset = "0x2816AEC", VA = "0x2816AEC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x280B89C", Offset = "0x280B89C", VA = "0x280B89C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD08", Offset = "0x117DD08")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000EA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000758")]
				[Address(RVA = "0x29F1670", Offset = "0x29F1670", VA = "0x29F1670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075A")]
				[Address(RVA = "0x29F16D8", Offset = "0x29F16D8", VA = "0x29F16D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x29F12F0", Offset = "0x29F12F0", VA = "0x29F12F0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x29F1530", Offset = "0x29F1530", VA = "0x29F1530", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x29F1534", Offset = "0x29F1534", VA = "0x29F1534", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x29F1678", Offset = "0x29F1678", VA = "0x29F1678", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118170C", Offset = "0x118170C")]
		public float weight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181744", Offset = "0x1181744")]
		public VRIK ik;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005F")]
		protected float deltaTime
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x29F1228", Offset = "0x29F1228", VA = "0x29F1228")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000485")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x29F1254", Offset = "0x29F1254", VA = "0x29F1254", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x29F1280", Offset = "0x29F1280", VA = "0x29F1280")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1186C64", Offset = "0x1186C64")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x29F131C", Offset = "0x29F131C", VA = "0x29F131C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x29F1428", Offset = "0x29F1428", VA = "0x29F1428", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x29F1520", Offset = "0x29F1520", VA = "0x29F1520")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class EffectorLink
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x29F17A0", Offset = "0x29F17A0", VA = "0x29F17A0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x29F1BF0", Offset = "0x29F1BF0", VA = "0x29F1BF0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x29F16E0", Offset = "0x29F16E0", VA = "0x29F16E0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x29F1AD8", Offset = "0x29F1AD8", VA = "0x29F1AD8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x29F1B90", Offset = "0x29F1B90", VA = "0x29F1B90")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x200013B")]
			public class EffectorLink
			{
				[Token(Token = "0x400068E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184E30", Offset = "0x1184E30")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184E68", Offset = "0x1184E68")]
				public float weight;

				[Token(Token = "0x600086F")]
				[Address(RVA = "0x29F22A0", Offset = "0x29F22A0", VA = "0x29F22A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118453C", Offset = "0x118453C")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184574", Offset = "0x1184574")]
			public Transform raycastTo;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11845AC", Offset = "0x11845AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11845AC", Offset = "0x11845AC")]
			public float raycastRadius;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184600", Offset = "0x1184600")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184638", Offset = "0x1184638")]
			public float smoothTimeIn;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184670", Offset = "0x1184670")]
			public float smoothTimeOut;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11846A8", Offset = "0x11846A8")]
			public LayerMask layers;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x29F1C7C", Offset = "0x29F1C7C", VA = "0x29F1C7C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x29F1E80", Offset = "0x29F1E80", VA = "0x29F1E80")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x29F2018", Offset = "0x29F2018", VA = "0x29F2018")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x29F228C", Offset = "0x29F228C", VA = "0x29F228C")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118177C", Offset = "0x118177C")]
		public Avoider[] avoiders;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x29F1BF8", Offset = "0x29F1BF8", VA = "0x29F1BF8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x29F1E78", Offset = "0x29F1E78", VA = "0x29F1E78")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200013C")]
			public class EffectorLink
			{
				[Token(Token = "0x4000690")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184EA0", Offset = "0x1184EA0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000691")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184ED8", Offset = "0x1184ED8")]
				public float weight;

				[Token(Token = "0x6000870")]
				[Address(RVA = "0x29F5330", Offset = "0x29F5330", VA = "0x29F5330")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11846E0", Offset = "0x11846E0")]
			public Vector3 offset;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184718", Offset = "0x1184718")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184718", Offset = "0x1184718")]
			public float additivity;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118476C", Offset = "0x118476C")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11847A4", Offset = "0x11847A4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x29F4078", Offset = "0x29F4078", VA = "0x29F4078")]
			public void Start()
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x29F4C08", Offset = "0x29F4C08", VA = "0x29F4C08")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x29F531C", Offset = "0x29F531C", VA = "0x29F531C")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public enum Handedness
		{
			[Token(Token = "0x40005C2")]
			Right,
			[Token(Token = "0x40005C3")]
			Left
		}

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11817B4", Offset = "0x11817B4")]
		public AimIK aimIK;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11817EC", Offset = "0x11817EC")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181824", Offset = "0x1181824")]
		public Handedness handedness;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118185C", Offset = "0x118185C")]
		public bool twoHanded;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181894", Offset = "0x1181894")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11818CC", Offset = "0x11818CC")]
		public float magnitudeRandom;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181904", Offset = "0x1181904")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118193C", Offset = "0x118193C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181974", Offset = "0x1181974")]
		public float blendTime;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11819AC", Offset = "0x11819AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11819AC", Offset = "0x11819AC")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000060")]
		public bool isFinished
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x29F3E50", Offset = "0x29F3E50", VA = "0x29F3E50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x29F4EBC", Offset = "0x29F4EBC", VA = "0x29F4EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x29F4EFC", Offset = "0x29F4EFC", VA = "0x29F4EFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x29F4E7C", Offset = "0x29F4E7C", VA = "0x29F4E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x29F4E9C", Offset = "0x29F4E9C", VA = "0x29F4E9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x29F3E80", Offset = "0x29F3E80", VA = "0x29F3E80")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x29F3EAC", Offset = "0x29F3EAC", VA = "0x29F3EAC")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x29F4128", Offset = "0x29F4128", VA = "0x29F4128", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x29F4F3C", Offset = "0x29F4F3C", VA = "0x29F4F3C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x29F5094", Offset = "0x29F5094", VA = "0x29F5094")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x29F50D0", Offset = "0x29F50D0", VA = "0x29F50D0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x29F526C", Offset = "0x29F526C", VA = "0x29F526C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181A0C", Offset = "0x1181A0C")]
		public float weight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1181A44", Offset = "0x1181A44")]
		public float offset;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x29F8AE8", Offset = "0x29F8AE8", VA = "0x29F8AE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x29F8BBC", Offset = "0x29F8BBC", VA = "0x29F8BBC")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x29F8CA8", Offset = "0x29F8CA8", VA = "0x29F8CA8")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x29F90F0", Offset = "0x29F90F0", VA = "0x29F90F0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x29F9128", Offset = "0x29F9128", VA = "0x29F9128")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x29F9220", Offset = "0x29F9220", VA = "0x29F9220")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class Settings
		{
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11847DC", Offset = "0x11847DC")]
			public float scaleMlp;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184814", Offset = "0x1184814")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118484C", Offset = "0x118484C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184884", Offset = "0x1184884")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11848BC", Offset = "0x11848BC")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11848F4", Offset = "0x11848F4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118492C", Offset = "0x118492C")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1184964", Offset = "0x1184964")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184964", Offset = "0x1184964")]
			public Vector3 headOffset;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11849B4", Offset = "0x11849B4")]
			public Vector3 handOffset;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11849EC", Offset = "0x11849EC")]
			public float footForwardOffset;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184A24", Offset = "0x1184A24")]
			public float footInwardOffset;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184A5C", Offset = "0x1184A5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184A5C", Offset = "0x1184A5C")]
			public float footHeadingOffset;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184AB8", Offset = "0x1184AB8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184AD0", Offset = "0x1184AD0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x29FFC1C", Offset = "0x29FFC1C", VA = "0x29FFC1C")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x200013D")]
			public class Target
			{
				[Token(Token = "0x4000692")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000693")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000694")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000871")]
				[Address(RVA = "0x29FD7B4", Offset = "0x29FD7B4", VA = "0x29FD7B4")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000872")]
				[Address(RVA = "0x29FE310", Offset = "0x29FE310", VA = "0x29FE310")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x29FCC58", Offset = "0x29FCC58", VA = "0x29FCC58")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x29FB7A0", Offset = "0x29FB7A0", VA = "0x29FB7A0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x29FB7B8", Offset = "0x29FB7B8", VA = "0x29FB7B8")]
		public static float RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
			return default(float);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x29FB968", Offset = "0x29FB968", VA = "0x29FB968")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x29FB814", Offset = "0x29FB814", VA = "0x29FB814")]
		private static float CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x29FB980", Offset = "0x29FB980", VA = "0x29FB980")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x29FCDD0", Offset = "0x29FCDD0", VA = "0x29FCDD0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x29FD878", Offset = "0x29FD878", VA = "0x29FD878")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x29FE370", Offset = "0x29FE370", VA = "0x29FE370")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x29FE72C", Offset = "0x29FE72C", VA = "0x29FE72C")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x29FE92C", Offset = "0x29FE92C", VA = "0x29FE92C")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x29FF028", Offset = "0x29FF028", VA = "0x29FF028")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x29FEDF4", Offset = "0x29FEDF4", VA = "0x29FEDF4")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x29FF2F8", Offset = "0x29FF2F8", VA = "0x29FF2F8")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x29FF5F4", Offset = "0x29FF5F4", VA = "0x29FF5F4")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x29FF7CC", Offset = "0x29FF7CC", VA = "0x29FF7CC")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000078")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x29FFCF4", Offset = "0x29FFCF4", VA = "0x29FFCF4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x29FFD4C", Offset = "0x29FFD4C", VA = "0x29FFD4C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x29FFD80", Offset = "0x29FFD80", VA = "0x29FFD80")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x29FFF08", Offset = "0x29FFF08", VA = "0x29FFF08")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1181A7C", Offset = "0x1181A7C")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000065")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x29FFF20", Offset = "0x29FFF20", VA = "0x29FFF20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186CC8", Offset = "0x1186CC8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x29FFF2C", Offset = "0x29FFF2C", VA = "0x29FFF2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186CD8", Offset = "0x1186CD8")]
			private set
			{
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x29FFF38", Offset = "0x29FFF38", VA = "0x29FFF38")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x29FD590", Offset = "0x29FD590", VA = "0x29FD590")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x29FE5BC", Offset = "0x29FE5BC", VA = "0x29FE5BC")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2A00010", Offset = "0x2A00010", VA = "0x2A00010")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2A004B4", Offset = "0x2A004B4", VA = "0x2A004B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2A005AC", Offset = "0x2A005AC", VA = "0x2A005AC")]
		public VRIKRootController()
		{
		}
	}
}
namespace Protobuf
{
	[Token(Token = "0x200007A")]
	public static class ChanelIDReflection
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FileDescriptor descriptor;

		[Token(Token = "0x17000066")]
		public static FileDescriptor Descriptor
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1E82FEC", Offset = "0x1E82FEC", VA = "0x1E82FEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1E83054", Offset = "0x1E83054", VA = "0x1E83054")]
		static ChanelIDReflection()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public sealed class SpeakVoiceChanel : IMessage<SpeakVoiceChanel>, IMessage, IEquatable<SpeakVoiceChanel>, IDeepCloneable<SpeakVoiceChanel>
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD18", Offset = "0x117DD18")]
		private sealed class <>c
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1E86428", Offset = "0x1E86428", VA = "0x1E86428")]
			public <>c()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1E86430", Offset = "0x1E86430", VA = "0x1E86430")]
			internal SpeakVoiceChanel <.cctor>b__30_0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SpeakVoiceChanel> _parser;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		[Token(Token = "0x400037B")]
		public const int ChanelIDFieldNumber = 1;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string chanelID_;

		[Token(Token = "0x400037D")]
		public const int ConnectionIDFieldNumber = 2;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int connectionID_;

		[Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		public static MessageParser<SpeakVoiceChanel> Parser
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x1E85B2C", Offset = "0x1E85B2C", VA = "0x1E85B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x1E85B94", Offset = "0x1E85B94", VA = "0x1E85B94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x1E85CB0", Offset = "0x1E85CB0", VA = "0x1E85CB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public string ChanelID
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x1E85E10", Offset = "0x1E85E10", VA = "0x1E85E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x1E85E18", Offset = "0x1E85E18", VA = "0x1E85E18")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public int ConnectionID
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x1E85E88", Offset = "0x1E85E88", VA = "0x1E85E88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1E85E90", Offset = "0x1E85E90", VA = "0x1E85E90")]
			set
			{
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1E85D0C", Offset = "0x1E85D0C", VA = "0x1E85D0C")]
		[DebuggerNonUserCode]
		public SpeakVoiceChanel()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1E85D64", Offset = "0x1E85D64", VA = "0x1E85D64")]
		[DebuggerNonUserCode]
		public SpeakVoiceChanel(SpeakVoiceChanel other)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1E85DB0", Offset = "0x1E85DB0", VA = "0x1E85DB0", Slot = "10")]
		[DebuggerNonUserCode]
		public SpeakVoiceChanel Clone()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1E85E98", Offset = "0x1E85E98", VA = "0x1E85E98", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1E85F0C", Offset = "0x1E85F0C", VA = "0x1E85F0C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SpeakVoiceChanel other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1E85F80", Offset = "0x1E85F80", VA = "0x1E85F80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1E8600C", Offset = "0x1E8600C", VA = "0x1E8600C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1E86074", Offset = "0x1E86074", VA = "0x1E86074", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1E86114", Offset = "0x1E86114", VA = "0x1E86114", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1E861FC", Offset = "0x1E861FC", VA = "0x1E861FC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SpeakVoiceChanel other)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1E8625C", Offset = "0x1E8625C", VA = "0x1E8625C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Token(Token = "0x200007C")]
	public static class GameReflection
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FileDescriptor descriptor;

		[Token(Token = "0x1700006C")]
		public static FileDescriptor Descriptor
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1E8335C", Offset = "0x1E8335C", VA = "0x1E8335C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1E833C4", Offset = "0x1E833C4", VA = "0x1E833C4")]
		static GameReflection()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public sealed class GameState : IMessage<GameState>, IMessage, IEquatable<GameState>, IDeepCloneable<GameState>
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD28", Offset = "0x117DD28")]
		private sealed class <>c
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1E83FBC", Offset = "0x1E83FBC", VA = "0x1E83FBC")]
			public <>c()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1E83FC4", Offset = "0x1E83FC4", VA = "0x1E83FC4")]
			internal GameState <.cctor>b__30_0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<GameState> _parser;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		[Token(Token = "0x4000382")]
		public const int LevelNameFieldNumber = 1;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string levelName_;

		[Token(Token = "0x4000384")]
		public const int LevelProgressFieldNumber = 2;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int levelProgress_;

		[Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public static MessageParser<GameState> Parser
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1E836C0", Offset = "0x1E836C0", VA = "0x1E836C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1E83728", Offset = "0x1E83728", VA = "0x1E83728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1E83844", Offset = "0x1E83844", VA = "0x1E83844", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public string LevelName
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1E839A4", Offset = "0x1E839A4", VA = "0x1E839A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1E839AC", Offset = "0x1E839AC", VA = "0x1E839AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public int LevelProgress
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1E83A1C", Offset = "0x1E83A1C", VA = "0x1E83A1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1E83A24", Offset = "0x1E83A24", VA = "0x1E83A24")]
			set
			{
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1E838A0", Offset = "0x1E838A0", VA = "0x1E838A0")]
		[DebuggerNonUserCode]
		public GameState()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1E838F8", Offset = "0x1E838F8", VA = "0x1E838F8")]
		[DebuggerNonUserCode]
		public GameState(GameState other)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1E83944", Offset = "0x1E83944", VA = "0x1E83944", Slot = "10")]
		[DebuggerNonUserCode]
		public GameState Clone()
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1E83A2C", Offset = "0x1E83A2C", VA = "0x1E83A2C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1E83AA0", Offset = "0x1E83AA0", VA = "0x1E83AA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GameState other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1E83B14", Offset = "0x1E83B14", VA = "0x1E83B14", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1E83BA0", Offset = "0x1E83BA0", VA = "0x1E83BA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1E83C08", Offset = "0x1E83C08", VA = "0x1E83C08", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1E83CA8", Offset = "0x1E83CA8", VA = "0x1E83CA8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1E83D90", Offset = "0x1E83D90", VA = "0x1E83D90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GameState other)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1E83DF0", Offset = "0x1E83DF0", VA = "0x1E83DF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public static class LoginReflection
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FileDescriptor descriptor;

		[Token(Token = "0x17000072")]
		public static FileDescriptor Descriptor
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1E8401C", Offset = "0x1E8401C", VA = "0x1E8401C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1E84084", Offset = "0x1E84084", VA = "0x1E84084")]
		static LoginReflection()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public sealed class LoginRequest : IMessage<LoginRequest>, IMessage, IEquatable<LoginRequest>, IDeepCloneable<LoginRequest>
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD38", Offset = "0x117DD38")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1E85AC8", Offset = "0x1E85AC8", VA = "0x1E85AC8")]
			public <>c()
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x1E85AD0", Offset = "0x1E85AD0", VA = "0x1E85AD0")]
			internal LoginRequest <.cctor>b__50_0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<LoginRequest> _parser;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		[Token(Token = "0x4000389")]
		public const int GameProfileIdFieldNumber = 1;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int gameProfileId_;

		[Token(Token = "0x400038B")]
		public const int GameVersionFieldNumber = 2;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int gameVersion_;

		[Token(Token = "0x400038D")]
		public const int AccountFieldNumber = 3;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AccountData account_;

		[Token(Token = "0x400038F")]
		public const int DifficultyFieldNumber = 4;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int difficulty_;

		[Token(Token = "0x4000391")]
		public const int RoomModeFieldNumber = 5;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int roomMode_;

		[Token(Token = "0x4000393")]
		public const int GameModeFieldNumber = 6;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int gameMode_;

		[Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public static MessageParser<LoginRequest> Parser
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1E84EA4", Offset = "0x1E84EA4", VA = "0x1E84EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1E84F0C", Offset = "0x1E84F0C", VA = "0x1E84F0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1E85028", Offset = "0x1E85028", VA = "0x1E85028", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		public int GameProfileId
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x1E85164", Offset = "0x1E85164", VA = "0x1E85164")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x1E8516C", Offset = "0x1E8516C", VA = "0x1E8516C")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public int GameVersion
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x1E85174", Offset = "0x1E85174", VA = "0x1E85174")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x1E8517C", Offset = "0x1E8517C", VA = "0x1E8517C")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		public AccountData Account
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1E85184", Offset = "0x1E85184", VA = "0x1E85184")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1E8518C", Offset = "0x1E8518C", VA = "0x1E8518C")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public int Difficulty
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1E85194", Offset = "0x1E85194", VA = "0x1E85194")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1E8519C", Offset = "0x1E8519C", VA = "0x1E8519C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		public int RoomMode
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1E851A4", Offset = "0x1E851A4", VA = "0x1E851A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1E851AC", Offset = "0x1E851AC", VA = "0x1E851AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public int GameMode
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1E851B4", Offset = "0x1E851B4", VA = "0x1E851B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1E851BC", Offset = "0x1E851BC", VA = "0x1E851BC")]
			set
			{
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1E85084", Offset = "0x1E85084", VA = "0x1E85084")]
		[DebuggerNonUserCode]
		public LoginRequest()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1E8508C", Offset = "0x1E8508C", VA = "0x1E8508C")]
		[DebuggerNonUserCode]
		public LoginRequest(LoginRequest other)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1E85104", Offset = "0x1E85104", VA = "0x1E85104", Slot = "10")]
		[DebuggerNonUserCode]
		public LoginRequest Clone()
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1E851C4", Offset = "0x1E851C4", VA = "0x1E851C4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1E85238", Offset = "0x1E85238", VA = "0x1E85238", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LoginRequest other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1E852EC", Offset = "0x1E852EC", VA = "0x1E852EC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1E853DC", Offset = "0x1E853DC", VA = "0x1E853DC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1E85444", Offset = "0x1E85444", VA = "0x1E85444", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1E8558C", Offset = "0x1E8558C", VA = "0x1E8558C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1E85750", Offset = "0x1E85750", VA = "0x1E85750", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LoginRequest other)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1E85830", Offset = "0x1E85830", VA = "0x1E85830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Token(Token = "0x2000080")]
	public sealed class LoginRefuse : IMessage<LoginRefuse>, IMessage, IEquatable<LoginRefuse>, IDeepCloneable<LoginRefuse>
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD48", Offset = "0x117DD48")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1E84E40", Offset = "0x1E84E40", VA = "0x1E84E40")]
			public <>c()
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1E84E48", Offset = "0x1E84E48", VA = "0x1E84E48")]
			internal LoginRefuse <.cctor>b__25_0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<LoginRefuse> _parser;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		[Token(Token = "0x4000397")]
		public const int ReasonFieldNumber = 1;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int reason_;

		[Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public static MessageParser<LoginRefuse> Parser
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1E8473C", Offset = "0x1E8473C", VA = "0x1E8473C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1E847A4", Offset = "0x1E847A4", VA = "0x1E847A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1E848C0", Offset = "0x1E848C0", VA = "0x1E848C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		[DebuggerNonUserCode]
		public int Reason
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x1E849CC", Offset = "0x1E849CC", VA = "0x1E849CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1E849D4", Offset = "0x1E849D4", VA = "0x1E849D4")]
			set
			{
			}
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1E8491C", Offset = "0x1E8491C", VA = "0x1E8491C")]
		[DebuggerNonUserCode]
		public LoginRefuse()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1E84924", Offset = "0x1E84924", VA = "0x1E84924")]
		[DebuggerNonUserCode]
		public LoginRefuse(LoginRefuse other)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1E8496C", Offset = "0x1E8496C", VA = "0x1E8496C", Slot = "10")]
		[DebuggerNonUserCode]
		public LoginRefuse Clone()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1E849DC", Offset = "0x1E849DC", VA = "0x1E849DC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1E84A50", Offset = "0x1E84A50", VA = "0x1E84A50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LoginRefuse other)
		{
			return default(bool);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1E84A8C", Offset = "0x1E84A8C", VA = "0x1E84A8C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1E84AF4", Offset = "0x1E84AF4", VA = "0x1E84AF4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1E84B5C", Offset = "0x1E84B5C", VA = "0x1E84B5C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1E84BC8", Offset = "0x1E84BC8", VA = "0x1E84BC8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1E84C58", Offset = "0x1E84C58", VA = "0x1E84C58", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LoginRefuse other)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1E84C98", Offset = "0x1E84C98", VA = "0x1E84C98", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Token(Token = "0x2000081")]
	public static class UserReflection
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FileDescriptor descriptor;

		[Token(Token = "0x17000080")]
		public static FileDescriptor Descriptor
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1E87998", Offset = "0x1E87998", VA = "0x1E87998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1E87A00", Offset = "0x1E87A00", VA = "0x1E87A00")]
		static UserReflection()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public sealed class User : IMessage<User>, IMessage, IEquatable<User>, IDeepCloneable<User>
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD58", Offset = "0x117DD58")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1E87934", Offset = "0x1E87934", VA = "0x1E87934")]
			public <>c()
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1E8793C", Offset = "0x1E8793C", VA = "0x1E8793C")]
			internal User <.cctor>b__40_0()
			{
				return null;
			}
		}

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<User> _parser;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		[Token(Token = "0x400039C")]
		public const int ConnectionIDFieldNumber = 1;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int connectionID_;

		[Token(Token = "0x400039E")]
		public const int UserIndexFieldNumber = 2;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int userIndex_;

		[Token(Token = "0x40003A0")]
		public const int AccountDataFieldNumber = 3;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AccountData accountData_;

		[Token(Token = "0x40003A2")]
		public const int TeamDataFieldNumber = 4;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TeamData teamData_;

		[Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public static MessageParser<User> Parser
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1E86E5C", Offset = "0x1E86E5C", VA = "0x1E86E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1E86EC4", Offset = "0x1E86EC4", VA = "0x1E86EC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1E86FE0", Offset = "0x1E86FE0", VA = "0x1E86FE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		[DebuggerNonUserCode]
		public int ConnectionID
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x1E87114", Offset = "0x1E87114", VA = "0x1E87114")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x1E8711C", Offset = "0x1E8711C", VA = "0x1E8711C")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		[DebuggerNonUserCode]
		public int UserIndex
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1E87124", Offset = "0x1E87124", VA = "0x1E87124")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1E8712C", Offset = "0x1E8712C", VA = "0x1E8712C")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		[DebuggerNonUserCode]
		public AccountData AccountData
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1E87134", Offset = "0x1E87134", VA = "0x1E87134")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x1E8713C", Offset = "0x1E8713C", VA = "0x1E8713C")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public TeamData TeamData
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x1E87144", Offset = "0x1E87144", VA = "0x1E87144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1E8714C", Offset = "0x1E8714C", VA = "0x1E8714C")]
			set
			{
			}
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1E8703C", Offset = "0x1E8703C", VA = "0x1E8703C")]
		[DebuggerNonUserCode]
		public User()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1E87044", Offset = "0x1E87044", VA = "0x1E87044")]
		[DebuggerNonUserCode]
		public User(User other)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1E870B4", Offset = "0x1E870B4", VA = "0x1E870B4", Slot = "10")]
		[DebuggerNonUserCode]
		public User Clone()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1E87154", Offset = "0x1E87154", VA = "0x1E87154", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1E871C8", Offset = "0x1E871C8", VA = "0x1E871C8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(User other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1E87260", Offset = "0x1E87260", VA = "0x1E87260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1E87314", Offset = "0x1E87314", VA = "0x1E87314", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1E8737C", Offset = "0x1E8737C", VA = "0x1E8737C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1E8746C", Offset = "0x1E8746C", VA = "0x1E8746C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1E875B8", Offset = "0x1E875B8", VA = "0x1E875B8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(User other)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1E876B4", Offset = "0x1E876B4", VA = "0x1E876B4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Token(Token = "0x2000083")]
	public sealed class Users : IMessage<Users>, IMessage, IEquatable<Users>, IDeepCloneable<Users>
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD68", Offset = "0x117DD68")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x2817F08", Offset = "0x2817F08", VA = "0x2817F08")]
			public <>c()
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x2817F10", Offset = "0x2817F10", VA = "0x2817F10")]
			internal Users <.cctor>b__25_0()
			{
				return null;
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Users> _parser;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		[Token(Token = "0x40003A6")]
		public const int Users_FieldNumber = 1;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<User> _repeated_users_codec;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<User> users_;

		[Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public static MessageParser<Users> Parser
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1E884A4", Offset = "0x1E884A4", VA = "0x1E884A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1E8850C", Offset = "0x1E8850C", VA = "0x1E8850C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1E88628", Offset = "0x1E88628", VA = "0x1E88628", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		[DebuggerNonUserCode]
		public RepeatedField<User> Users_
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1E887DC", Offset = "0x1E887DC", VA = "0x1E887DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1E88684", Offset = "0x1E88684", VA = "0x1E88684")]
		[DebuggerNonUserCode]
		public Users()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1E886F4", Offset = "0x1E886F4", VA = "0x1E886F4")]
		[DebuggerNonUserCode]
		public Users(Users other)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1E8877C", Offset = "0x1E8877C", VA = "0x1E8877C", Slot = "10")]
		[DebuggerNonUserCode]
		public Users Clone()
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1E887E4", Offset = "0x1E887E4", VA = "0x1E887E4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1E88858", Offset = "0x1E88858", VA = "0x1E88858", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Users other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1E888FC", Offset = "0x1E888FC", VA = "0x1E888FC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1E88954", Offset = "0x1E88954", VA = "0x1E88954", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1E889BC", Offset = "0x1E889BC", VA = "0x1E889BC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1E88A78", Offset = "0x1E88A78", VA = "0x1E88A78", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1E88B2C", Offset = "0x1E88B2C", VA = "0x1E88B2C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Users other)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1E88BB0", Offset = "0x1E88BB0", VA = "0x1E88BB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Token(Token = "0x2000084")]
	public sealed class AccountData : IMessage<AccountData>, IMessage, IEquatable<AccountData>, IDeepCloneable<AccountData>
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD78", Offset = "0x117DD78")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x1E82F8C", Offset = "0x1E82F8C", VA = "0x1E82F8C")]
			public <>c()
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1E82F94", Offset = "0x1E82F94", VA = "0x1E82F94")]
			internal AccountData <.cctor>b__55_0()
			{
				return null;
			}
		}

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AccountData> _parser;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		[Token(Token = "0x40003AB")]
		public const int IDFieldNumber = 1;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string iD_;

		[Token(Token = "0x40003AD")]
		public const int NameFieldNumber = 2;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string name_;

		[Token(Token = "0x40003AF")]
		public const int HeadImgUrlFieldNumber = 3;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string headImgUrl_;

		[Token(Token = "0x40003B1")]
		public const int CareerFieldNumber = 4;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int career_;

		[Token(Token = "0x40003B3")]
		public const int LevelFieldNumber = 5;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int level_;

		[Token(Token = "0x40003B5")]
		public const int PlatformFieldNumber = 6;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int platform_;

		[Token(Token = "0x40003B7")]
		public const int SkinFieldNumber = 7;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string skin_;

		[Token(Token = "0x1700008C")]
		[DebuggerNonUserCode]
		public static MessageParser<AccountData> Parser
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x1E82098", Offset = "0x1E82098", VA = "0x1E82098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x1E82100", Offset = "0x1E82100", VA = "0x1E82100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1E8221C", Offset = "0x1E8221C", VA = "0x1E8221C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public string ID
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x1E823AC", Offset = "0x1E823AC", VA = "0x1E823AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x1E823B4", Offset = "0x1E823B4", VA = "0x1E823B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x1E82424", Offset = "0x1E82424", VA = "0x1E82424")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x1E8242C", Offset = "0x1E8242C", VA = "0x1E8242C")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public string HeadImgUrl
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1E8249C", Offset = "0x1E8249C", VA = "0x1E8249C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x1E824A4", Offset = "0x1E824A4", VA = "0x1E824A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public int Career
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1E82514", Offset = "0x1E82514", VA = "0x1E82514")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x1E8251C", Offset = "0x1E8251C", VA = "0x1E8251C")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1E82524", Offset = "0x1E82524", VA = "0x1E82524")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x1E8252C", Offset = "0x1E8252C", VA = "0x1E8252C")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		[DebuggerNonUserCode]
		public int Platform
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1E82534", Offset = "0x1E82534", VA = "0x1E82534")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x1E8253C", Offset = "0x1E8253C", VA = "0x1E8253C")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		[DebuggerNonUserCode]
		public string Skin
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x1E82544", Offset = "0x1E82544", VA = "0x1E82544")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x1E8254C", Offset = "0x1E8254C", VA = "0x1E8254C")]
			set
			{
			}
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1E82278", Offset = "0x1E82278", VA = "0x1E82278")]
		[DebuggerNonUserCode]
		public AccountData()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1E822D8", Offset = "0x1E822D8", VA = "0x1E822D8")]
		[DebuggerNonUserCode]
		public AccountData(AccountData other)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1E8234C", Offset = "0x1E8234C", VA = "0x1E8234C", Slot = "10")]
		[DebuggerNonUserCode]
		public AccountData Clone()
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1E825BC", Offset = "0x1E825BC", VA = "0x1E825BC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1E82630", Offset = "0x1E82630", VA = "0x1E82630", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AccountData other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1E82700", Offset = "0x1E82700", VA = "0x1E82700", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1E82824", Offset = "0x1E82824", VA = "0x1E82824", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1E8288C", Offset = "0x1E8288C", VA = "0x1E8288C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1E82A20", Offset = "0x1E82A20", VA = "0x1E82A20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1E82C4C", Offset = "0x1E82C4C", VA = "0x1E82C4C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AccountData other)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1E82D0C", Offset = "0x1E82D0C", VA = "0x1E82D0C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Token(Token = "0x2000085")]
	public sealed class TeamData : IMessage<TeamData>, IMessage, IEquatable<TeamData>, IDeepCloneable<TeamData>
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD88", Offset = "0x117DD88")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1E86DF8", Offset = "0x1E86DF8", VA = "0x1E86DF8")]
			public <>c()
			{
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1E86E00", Offset = "0x1E86E00", VA = "0x1E86E00")]
			internal TeamData <.cctor>b__40_0()
			{
				return null;
			}
		}

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<TeamData> _parser;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		[Token(Token = "0x40003BB")]
		public const int IsLeaderFieldNumber = 1;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isLeader_;

		[Token(Token = "0x40003BD")]
		public const int IsReadyFieldNumber = 2;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool isReady_;

		[Token(Token = "0x40003BF")]
		public const int TeamDiffFieldNumber = 3;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int teamDiff_;

		[Token(Token = "0x40003C1")]
		public const int TeamModeFieldNumber = 4;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int teamMode_;

		[Token(Token = "0x17000096")]
		[DebuggerNonUserCode]
		public static MessageParser<TeamData> Parser
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1E86488", Offset = "0x1E86488", VA = "0x1E86488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x1E864F0", Offset = "0x1E864F0", VA = "0x1E864F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x1E8660C", Offset = "0x1E8660C", VA = "0x1E8660C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public bool IsLeader
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x1E86730", Offset = "0x1E86730", VA = "0x1E86730")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1E86738", Offset = "0x1E86738", VA = "0x1E86738")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public bool IsReady
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1E86744", Offset = "0x1E86744", VA = "0x1E86744")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x1E8674C", Offset = "0x1E8674C", VA = "0x1E8674C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public int TeamDiff
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x1E86758", Offset = "0x1E86758", VA = "0x1E86758")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1E86760", Offset = "0x1E86760", VA = "0x1E86760")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		[DebuggerNonUserCode]
		public int TeamMode
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x1E86768", Offset = "0x1E86768", VA = "0x1E86768")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x1E86770", Offset = "0x1E86770", VA = "0x1E86770")]
			set
			{
			}
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1E86668", Offset = "0x1E86668", VA = "0x1E86668")]
		[DebuggerNonUserCode]
		public TeamData()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1E86670", Offset = "0x1E86670", VA = "0x1E86670")]
		[DebuggerNonUserCode]
		public TeamData(TeamData other)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1E866D0", Offset = "0x1E866D0", VA = "0x1E866D0", Slot = "10")]
		[DebuggerNonUserCode]
		public TeamData Clone()
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1E86778", Offset = "0x1E86778", VA = "0x1E86778", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1E867EC", Offset = "0x1E867EC", VA = "0x1E867EC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TeamData other)
		{
			return default(bool);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1E86878", Offset = "0x1E86878", VA = "0x1E86878", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1E86938", Offset = "0x1E86938", VA = "0x1E86938", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1E869A0", Offset = "0x1E869A0", VA = "0x1E869A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1E86A90", Offset = "0x1E86A90", VA = "0x1E86A90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1E86B88", Offset = "0x1E86B88", VA = "0x1E86B88", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TeamData other)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1E86BEC", Offset = "0x1E86BEC", VA = "0x1E86BEC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000086")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DD98", Offset = "0x117DD98")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1E75BD8", Offset = "0x1E75BD8", VA = "0x1E75BD8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1E76398", Offset = "0x1E76398", VA = "0x1E76398")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1E763B4", Offset = "0x1E763B4", VA = "0x1E763B4")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DDA8", Offset = "0x117DDA8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x1E75D1C", Offset = "0x1E75D1C", VA = "0x1E75D1C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x1E763D0", Offset = "0x1E763D0", VA = "0x1E763D0")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x1E763EC", Offset = "0x1E763EC", VA = "0x1E763EC")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DDB8", Offset = "0x117DDB8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1E75E64", Offset = "0x1E75E64", VA = "0x1E75E64")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1E76408", Offset = "0x1E76408", VA = "0x1E76408")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1E76448", Offset = "0x1E76448", VA = "0x1E76448")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1E75A74", Offset = "0x1E75A74", VA = "0x1E75A74")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1E75BE0", Offset = "0x1E75BE0", VA = "0x1E75BE0")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1E75D24", Offset = "0x1E75D24", VA = "0x1E75D24")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1E75E6C", Offset = "0x1E75E6C", VA = "0x1E75E6C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1E75EE4", Offset = "0x1E75EE4", VA = "0x1E75EE4")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1E75F5C", Offset = "0x1E75F5C", VA = "0x1E75F5C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1E75FC4", Offset = "0x1E75FC4", VA = "0x1E75FC4")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1E7604C", Offset = "0x1E7604C", VA = "0x1E7604C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1E760B4", Offset = "0x1E760B4", VA = "0x1E760B4")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1E7611C", Offset = "0x1E7611C", VA = "0x1E7611C")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1E76184", Offset = "0x1E76184", VA = "0x1E76184")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1E761EC", Offset = "0x1E761EC", VA = "0x1E761EC")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1E7625C", Offset = "0x1E7625C", VA = "0x1E7625C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1E762C8", Offset = "0x1E762C8", VA = "0x1E762C8")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1E76330", Offset = "0x1E76330", VA = "0x1E76330")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000087")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DDC8", Offset = "0x117DDC8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1E765DC", Offset = "0x1E765DC", VA = "0x1E765DC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1E77978", Offset = "0x1E77978", VA = "0x1E77978")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DDD8", Offset = "0x117DDD8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x1E7676C", Offset = "0x1E7676C", VA = "0x1E7676C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x1E77AB4", Offset = "0x1E77AB4", VA = "0x1E77AB4")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DDE8", Offset = "0x117DDE8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x1E768FC", Offset = "0x1E768FC", VA = "0x1E768FC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x1E77AD0", Offset = "0x1E77AD0", VA = "0x1E77AD0")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DDF8", Offset = "0x117DDF8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x1E76A8C", Offset = "0x1E76A8C", VA = "0x1E76A8C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x1E77AEC", Offset = "0x1E77AEC", VA = "0x1E77AEC")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE08", Offset = "0x117DE08")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1E76C00", Offset = "0x1E76C00", VA = "0x1E76C00")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1E77B08", Offset = "0x1E77B08", VA = "0x1E77B08")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE18", Offset = "0x117DE18")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1E76DEC", Offset = "0x1E76DEC", VA = "0x1E76DEC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1E77B24", Offset = "0x1E77B24", VA = "0x1E77B24")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE28", Offset = "0x117DE28")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1E77268", Offset = "0x1E77268", VA = "0x1E77268")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1E77B40", Offset = "0x1E77B40", VA = "0x1E77B40")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1E77B5C", Offset = "0x1E77B5C", VA = "0x1E77B5C")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1E77B90", Offset = "0x1E77B90", VA = "0x1E77B90")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1E77BAC", Offset = "0x1E77BAC", VA = "0x1E77BAC")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x1E77BC8", Offset = "0x1E77BC8", VA = "0x1E77BC8")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE38", Offset = "0x117DE38")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1E7745C", Offset = "0x1E7745C", VA = "0x1E7745C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1E77C88", Offset = "0x1E77C88", VA = "0x1E77C88")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE48", Offset = "0x117DE48")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1E77664", Offset = "0x1E77664", VA = "0x1E77664")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1E77CA4", Offset = "0x1E77CA4", VA = "0x1E77CA4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x1E77CC0", Offset = "0x1E77CC0", VA = "0x1E77CC0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE58", Offset = "0x117DE58")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x1E777E4", Offset = "0x1E777E4", VA = "0x1E777E4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x1E77DC4", Offset = "0x1E77DC4", VA = "0x1E77DC4")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE68", Offset = "0x117DE68")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1E77970", Offset = "0x1E77970", VA = "0x1E77970")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1E77994", Offset = "0x1E77994", VA = "0x1E77994")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1E779B0", Offset = "0x1E779B0", VA = "0x1E779B0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1E7646C", Offset = "0x1E7646C", VA = "0x1E7646C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1E765E4", Offset = "0x1E765E4", VA = "0x1E765E4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1E76774", Offset = "0x1E76774", VA = "0x1E76774")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1E76904", Offset = "0x1E76904", VA = "0x1E76904")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1E76A94", Offset = "0x1E76A94", VA = "0x1E76A94")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1E76C08", Offset = "0x1E76C08", VA = "0x1E76C08")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1E76DF4", Offset = "0x1E76DF4", VA = "0x1E76DF4")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1E77270", Offset = "0x1E77270", VA = "0x1E77270")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1E77464", Offset = "0x1E77464", VA = "0x1E77464")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1E7766C", Offset = "0x1E7766C", VA = "0x1E7766C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1E777EC", Offset = "0x1E777EC", VA = "0x1E777EC")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE78", Offset = "0x117DE78")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1E77F48", Offset = "0x1E77F48", VA = "0x1E77F48")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1E78C88", Offset = "0x1E78C88", VA = "0x1E78C88")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE88", Offset = "0x117DE88")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x1E780C4", Offset = "0x1E780C4", VA = "0x1E780C4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1E78CA4", Offset = "0x1E78CA4", VA = "0x1E78CA4")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DE98", Offset = "0x117DE98")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x1E78240", Offset = "0x1E78240", VA = "0x1E78240")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x1E78CC0", Offset = "0x1E78CC0", VA = "0x1E78CC0")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DEA8", Offset = "0x117DEA8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1E78388", Offset = "0x1E78388", VA = "0x1E78388")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x1E78CDC", Offset = "0x1E78CDC", VA = "0x1E78CDC")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DEB8", Offset = "0x117DEB8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x1E78708", Offset = "0x1E78708", VA = "0x1E78708")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x1E78CF8", Offset = "0x1E78CF8", VA = "0x1E78CF8")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x1E78D14", Offset = "0x1E78D14", VA = "0x1E78D14")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x1E78D30", Offset = "0x1E78D30", VA = "0x1E78D30")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x1E78D64", Offset = "0x1E78D64", VA = "0x1E78D64")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x1E78D80", Offset = "0x1E78D80", VA = "0x1E78D80")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x1E78D9C", Offset = "0x1E78D9C", VA = "0x1E78D9C")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DEC8", Offset = "0x117DEC8")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x1E789BC", Offset = "0x1E789BC", VA = "0x1E789BC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x1E78EC4", Offset = "0x1E78EC4", VA = "0x1E78EC4")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x1E78F54", Offset = "0x1E78F54", VA = "0x1E78F54")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DED8", Offset = "0x117DED8")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x1E78C80", Offset = "0x1E78C80", VA = "0x1E78C80")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1E78FF8", Offset = "0x1E78FF8", VA = "0x1E78FF8")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1E79014", Offset = "0x1E79014", VA = "0x1E79014")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1E77DE0", Offset = "0x1E77DE0", VA = "0x1E77DE0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1E77F50", Offset = "0x1E77F50", VA = "0x1E77F50")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1E780CC", Offset = "0x1E780CC", VA = "0x1E780CC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1E78248", Offset = "0x1E78248", VA = "0x1E78248")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1E78390", Offset = "0x1E78390", VA = "0x1E78390")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1E78710", Offset = "0x1E78710", VA = "0x1E78710")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1E789C4", Offset = "0x1E789C4", VA = "0x1E789C4")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000089")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DEE8", Offset = "0x117DEE8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x1E792A4", Offset = "0x1E792A4", VA = "0x1E792A4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1E797B4", Offset = "0x1E797B4", VA = "0x1E797B4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x1E797D0", Offset = "0x1E797D0", VA = "0x1E797D0")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DEF8", Offset = "0x117DEF8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x1E793E8", Offset = "0x1E793E8", VA = "0x1E793E8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1E797EC", Offset = "0x1E797EC", VA = "0x1E797EC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1E79808", Offset = "0x1E79808", VA = "0x1E79808")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF08", Offset = "0x117DF08")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1E797AC", Offset = "0x1E797AC", VA = "0x1E797AC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1E79824", Offset = "0x1E79824", VA = "0x1E79824")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1E79830", Offset = "0x1E79830", VA = "0x1E79830")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1E79140", Offset = "0x1E79140", VA = "0x1E79140")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1E792AC", Offset = "0x1E792AC", VA = "0x1E792AC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1E793F0", Offset = "0x1E793F0", VA = "0x1E793F0")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1E795C8", Offset = "0x1E795C8", VA = "0x1E795C8")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20000F9")]
		public static class Utils
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1E7E968", Offset = "0x1E7E968", VA = "0x1E7E968")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF18", Offset = "0x117DF18")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1E79A18", Offset = "0x1E79A18", VA = "0x1E79A18")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1E7D77C", Offset = "0x1E7D77C", VA = "0x1E7D77C")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1E7D798", Offset = "0x1E7D798", VA = "0x1E7D798")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF28", Offset = "0x117DF28")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1E79B84", Offset = "0x1E79B84", VA = "0x1E79B84")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1E7D9EC", Offset = "0x1E7D9EC", VA = "0x1E7D9EC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1E7DA10", Offset = "0x1E7DA10", VA = "0x1E7DA10")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF38", Offset = "0x117DF38")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1E79CC8", Offset = "0x1E79CC8", VA = "0x1E79CC8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1E7E078", Offset = "0x1E7E078", VA = "0x1E7E078")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x1E7E09C", Offset = "0x1E7E09C", VA = "0x1E7E09C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF48", Offset = "0x117DF48")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x1E79E34", Offset = "0x1E79E34", VA = "0x1E79E34")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x1E7E544", Offset = "0x1E7E544", VA = "0x1E7E544")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x1E7E568", Offset = "0x1E7E568", VA = "0x1E7E568")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF58", Offset = "0x117DF58")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x1E79F78", Offset = "0x1E79F78", VA = "0x1E79F78")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x1E7E654", Offset = "0x1E7E654", VA = "0x1E7E654")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1E7E678", Offset = "0x1E7E678", VA = "0x1E7E678")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF68", Offset = "0x117DF68")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1E7A0E0", Offset = "0x1E7A0E0", VA = "0x1E7A0E0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1E7E69C", Offset = "0x1E7E69C", VA = "0x1E7E69C")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x1E7E6B8", Offset = "0x1E7E6B8", VA = "0x1E7E6B8")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF78", Offset = "0x117DF78")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1E7A424", Offset = "0x1E7A424", VA = "0x1E7A424")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1E7E6D4", Offset = "0x1E7E6D4", VA = "0x1E7E6D4")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1E7E754", Offset = "0x1E7E754", VA = "0x1E7E754")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF88", Offset = "0x117DF88")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1E7A588", Offset = "0x1E7A588", VA = "0x1E7A588")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1E7E7B0", Offset = "0x1E7E7B0", VA = "0x1E7E7B0")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x1E7E830", Offset = "0x1E7E830", VA = "0x1E7E830")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DF98", Offset = "0x117DF98")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1E7A6EC", Offset = "0x1E7A6EC", VA = "0x1E7A6EC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1E7E88C", Offset = "0x1E7E88C", VA = "0x1E7E88C")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1E7E90C", Offset = "0x1E7E90C", VA = "0x1E7E90C")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DFA8", Offset = "0x117DFA8")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1E7A858", Offset = "0x1E7A858", VA = "0x1E7A858")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1E7D7B4", Offset = "0x1E7D7B4", VA = "0x1E7D7B4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1E7D7D4", Offset = "0x1E7D7D4", VA = "0x1E7D7D4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DFB8", Offset = "0x117DFB8")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1E7A99C", Offset = "0x1E7A99C", VA = "0x1E7A99C")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1E7D7F0", Offset = "0x1E7D7F0", VA = "0x1E7D7F0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1E7D810", Offset = "0x1E7D810", VA = "0x1E7D810")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DFC8", Offset = "0x117DFC8")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1E7AAF0", Offset = "0x1E7AAF0", VA = "0x1E7AAF0")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1E7D82C", Offset = "0x1E7D82C", VA = "0x1E7D82C")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x1E7D848", Offset = "0x1E7D848", VA = "0x1E7D848")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DFD8", Offset = "0x117DFD8")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1E7AC54", Offset = "0x1E7AC54", VA = "0x1E7AC54")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1E7D864", Offset = "0x1E7D864", VA = "0x1E7D864")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1E7D880", Offset = "0x1E7D880", VA = "0x1E7D880")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DFE8", Offset = "0x117DFE8")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1E7ADCC", Offset = "0x1E7ADCC", VA = "0x1E7ADCC")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x1E7D89C", Offset = "0x1E7D89C", VA = "0x1E7D89C")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x1E7D8B8", Offset = "0x1E7D8B8", VA = "0x1E7D8B8")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117DFF8", Offset = "0x117DFF8")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x1E7AF44", Offset = "0x1E7AF44", VA = "0x1E7AF44")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x1E7D8D4", Offset = "0x1E7D8D4", VA = "0x1E7D8D4")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x1E7D8F0", Offset = "0x1E7D8F0", VA = "0x1E7D8F0")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E008", Offset = "0x117E008")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1E7B0B0", Offset = "0x1E7B0B0", VA = "0x1E7B0B0")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x1E7D90C", Offset = "0x1E7D90C", VA = "0x1E7D90C")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1E7D928", Offset = "0x1E7D928", VA = "0x1E7D928")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E018", Offset = "0x117E018")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1E7B234", Offset = "0x1E7B234", VA = "0x1E7B234")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1E7D944", Offset = "0x1E7D944", VA = "0x1E7D944")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x1E7D960", Offset = "0x1E7D960", VA = "0x1E7D960")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E028", Offset = "0x117E028")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x1E7B3B8", Offset = "0x1E7B3B8", VA = "0x1E7B3B8")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1E7D97C", Offset = "0x1E7D97C", VA = "0x1E7D97C")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x1E7D998", Offset = "0x1E7D998", VA = "0x1E7D998")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E038", Offset = "0x117E038")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1E7B53C", Offset = "0x1E7B53C", VA = "0x1E7B53C")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1E7D9B4", Offset = "0x1E7D9B4", VA = "0x1E7D9B4")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1E7D9D0", Offset = "0x1E7D9D0", VA = "0x1E7D9D0")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E048", Offset = "0x117E048")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x1E7B6A0", Offset = "0x1E7B6A0", VA = "0x1E7B6A0")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1E7DA34", Offset = "0x1E7DA34", VA = "0x1E7DA34")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1E7DA50", Offset = "0x1E7DA50", VA = "0x1E7DA50")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E058", Offset = "0x117E058")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1E7B804", Offset = "0x1E7B804", VA = "0x1E7B804")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1E7DA6C", Offset = "0x1E7DA6C", VA = "0x1E7DA6C")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1E7DA88", Offset = "0x1E7DA88", VA = "0x1E7DA88")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E068", Offset = "0x117E068")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x1E7B958", Offset = "0x1E7B958", VA = "0x1E7B958")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1E7DAA4", Offset = "0x1E7DAA4", VA = "0x1E7DAA4")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1E7DAC0", Offset = "0x1E7DAC0", VA = "0x1E7DAC0")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E078", Offset = "0x117E078")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1E7BAC4", Offset = "0x1E7BAC4", VA = "0x1E7BAC4")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1E7DADC", Offset = "0x1E7DADC", VA = "0x1E7DADC")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1E7DAF8", Offset = "0x1E7DAF8", VA = "0x1E7DAF8")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E088", Offset = "0x117E088")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1E7BC30", Offset = "0x1E7BC30", VA = "0x1E7BC30")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1E7DB14", Offset = "0x1E7DB14", VA = "0x1E7DB14")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1E7DB30", Offset = "0x1E7DB30", VA = "0x1E7DB30")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E098", Offset = "0x117E098")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x1E7BD94", Offset = "0x1E7BD94", VA = "0x1E7BD94")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x1E7DB4C", Offset = "0x1E7DB4C", VA = "0x1E7DB4C")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x1E7DB68", Offset = "0x1E7DB68", VA = "0x1E7DB68")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E0A8", Offset = "0x117E0A8")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x1E7BF4C", Offset = "0x1E7BF4C", VA = "0x1E7BF4C")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1E7DB84", Offset = "0x1E7DB84", VA = "0x1E7DB84")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x1E7DC14", Offset = "0x1E7DC14", VA = "0x1E7DC14")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E0B8", Offset = "0x117E0B8")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x1E7C0D4", Offset = "0x1E7C0D4", VA = "0x1E7C0D4")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1E7DCB8", Offset = "0x1E7DCB8", VA = "0x1E7DCB8")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x1E7DD48", Offset = "0x1E7DD48", VA = "0x1E7DD48")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E0C8", Offset = "0x117E0C8")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x1E7C2A8", Offset = "0x1E7C2A8", VA = "0x1E7C2A8")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1E7DDEC", Offset = "0x1E7DDEC", VA = "0x1E7DDEC")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x1E7DE7C", Offset = "0x1E7DE7C", VA = "0x1E7DE7C")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E0D8", Offset = "0x117E0D8")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x1E7C62C", Offset = "0x1E7C62C", VA = "0x1E7C62C")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x1E7DF20", Offset = "0x1E7DF20", VA = "0x1E7DF20")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x1E7DF3C", Offset = "0x1E7DF3C", VA = "0x1E7DF3C")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x1E7DF58", Offset = "0x1E7DF58", VA = "0x1E7DF58")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x1E7DF8C", Offset = "0x1E7DF8C", VA = "0x1E7DF8C")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x1E7DFA8", Offset = "0x1E7DFA8", VA = "0x1E7DFA8")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x1E7DFC4", Offset = "0x1E7DFC4", VA = "0x1E7DFC4")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E0E8", Offset = "0x117E0E8")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x1E7C784", Offset = "0x1E7C784", VA = "0x1E7C784")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x1E7E0C0", Offset = "0x1E7E0C0", VA = "0x1E7E0C0")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x1E7E130", Offset = "0x1E7E130", VA = "0x1E7E130")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E0F8", Offset = "0x117E0F8")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1E7C8CC", Offset = "0x1E7C8CC", VA = "0x1E7C8CC")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x1E7E17C", Offset = "0x1E7E17C", VA = "0x1E7E17C")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x1E7E198", Offset = "0x1E7E198", VA = "0x1E7E198")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E108", Offset = "0x117E108")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x1E7CA14", Offset = "0x1E7CA14", VA = "0x1E7CA14")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x1E7E1B4", Offset = "0x1E7E1B4", VA = "0x1E7E1B4")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x1E7E1D0", Offset = "0x1E7E1D0", VA = "0x1E7E1D0")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E118", Offset = "0x117E118")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000826")]
			[Address(RVA = "0x1E7CB68", Offset = "0x1E7CB68", VA = "0x1E7CB68")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x1E7E1EC", Offset = "0x1E7E1EC", VA = "0x1E7E1EC")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1E7E210", Offset = "0x1E7E210", VA = "0x1E7E210")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E128", Offset = "0x117E128")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x1E7CCD4", Offset = "0x1E7CCD4", VA = "0x1E7CCD4")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x1E7E234", Offset = "0x1E7E234", VA = "0x1E7E234")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x1E7E258", Offset = "0x1E7E258", VA = "0x1E7E258")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E138", Offset = "0x117E138")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x1E7CE78", Offset = "0x1E7CE78", VA = "0x1E7CE78")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x1E7E27C", Offset = "0x1E7E27C", VA = "0x1E7E27C")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x1E7E284", Offset = "0x1E7E284", VA = "0x1E7E284")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E148", Offset = "0x117E148")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x1E7CFBC", Offset = "0x1E7CFBC", VA = "0x1E7CFBC")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x1E7E324", Offset = "0x1E7E324", VA = "0x1E7E324")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x1E7E348", Offset = "0x1E7E348", VA = "0x1E7E348")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E158", Offset = "0x117E158")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x1E7D198", Offset = "0x1E7D198", VA = "0x1E7D198")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x1E7E36C", Offset = "0x1E7E36C", VA = "0x1E7E36C")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0x1E7E390", Offset = "0x1E7E390", VA = "0x1E7E390")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E168", Offset = "0x117E168")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x1E7D38C", Offset = "0x1E7D38C", VA = "0x1E7D38C")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x1E7E3B4", Offset = "0x1E7E3B4", VA = "0x1E7E3B4")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x1E7E3C0", Offset = "0x1E7E3C0", VA = "0x1E7E3C0")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E178", Offset = "0x117E178")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000838")]
			[Address(RVA = "0x1E7D580", Offset = "0x1E7D580", VA = "0x1E7D580")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x1E7E47C", Offset = "0x1E7E47C", VA = "0x1E7E47C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x1E7E488", Offset = "0x1E7E488", VA = "0x1E7E488")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E188", Offset = "0x117E188")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x600083B")]
			[Address(RVA = "0x1E7D774", Offset = "0x1E7D774", VA = "0x1E7D774")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x1E7E58C", Offset = "0x1E7E58C", VA = "0x1E7E58C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x1E7E598", Offset = "0x1E7E598", VA = "0x1E7E598")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1E798DC", Offset = "0x1E798DC", VA = "0x1E798DC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1E79A20", Offset = "0x1E79A20", VA = "0x1E79A20")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1E79B8C", Offset = "0x1E79B8C", VA = "0x1E79B8C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1E79CD0", Offset = "0x1E79CD0", VA = "0x1E79CD0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1E79E3C", Offset = "0x1E79E3C", VA = "0x1E79E3C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1E79F80", Offset = "0x1E79F80", VA = "0x1E79F80")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1E7A0E8", Offset = "0x1E7A0E8", VA = "0x1E7A0E8")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1E7A2C8", Offset = "0x1E7A2C8", VA = "0x1E7A2C8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1E7A42C", Offset = "0x1E7A42C", VA = "0x1E7A42C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1E7A590", Offset = "0x1E7A590", VA = "0x1E7A590")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1E7A6F4", Offset = "0x1E7A6F4", VA = "0x1E7A6F4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1E7A860", Offset = "0x1E7A860", VA = "0x1E7A860")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1E7A9A4", Offset = "0x1E7A9A4", VA = "0x1E7A9A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1E7AAF8", Offset = "0x1E7AAF8", VA = "0x1E7AAF8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1E7AC5C", Offset = "0x1E7AC5C", VA = "0x1E7AC5C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1E7ADD4", Offset = "0x1E7ADD4", VA = "0x1E7ADD4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1E7AF4C", Offset = "0x1E7AF4C", VA = "0x1E7AF4C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1E7B0B8", Offset = "0x1E7B0B8", VA = "0x1E7B0B8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1E7B23C", Offset = "0x1E7B23C", VA = "0x1E7B23C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1E7B3C0", Offset = "0x1E7B3C0", VA = "0x1E7B3C0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1E7B544", Offset = "0x1E7B544", VA = "0x1E7B544")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1E7B6A8", Offset = "0x1E7B6A8", VA = "0x1E7B6A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1E7B80C", Offset = "0x1E7B80C", VA = "0x1E7B80C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1E7B960", Offset = "0x1E7B960", VA = "0x1E7B960")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1E7BACC", Offset = "0x1E7BACC", VA = "0x1E7BACC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1E7BC38", Offset = "0x1E7BC38", VA = "0x1E7BC38")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1E7BD9C", Offset = "0x1E7BD9C", VA = "0x1E7BD9C")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1E7BF54", Offset = "0x1E7BF54", VA = "0x1E7BF54")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1E7C0DC", Offset = "0x1E7C0DC", VA = "0x1E7C0DC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1E7C2B0", Offset = "0x1E7C2B0", VA = "0x1E7C2B0")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1E7C634", Offset = "0x1E7C634", VA = "0x1E7C634")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1E7C78C", Offset = "0x1E7C78C", VA = "0x1E7C78C")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1E7C8D4", Offset = "0x1E7C8D4", VA = "0x1E7C8D4")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1E7CA1C", Offset = "0x1E7CA1C", VA = "0x1E7CA1C")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1E7CB70", Offset = "0x1E7CB70", VA = "0x1E7CB70")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1E7CCDC", Offset = "0x1E7CCDC", VA = "0x1E7CCDC")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1E7CE80", Offset = "0x1E7CE80", VA = "0x1E7CE80")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1E7CFC4", Offset = "0x1E7CFC4", VA = "0x1E7CFC4")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1E7D1A0", Offset = "0x1E7D1A0", VA = "0x1E7D1A0")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1E7D394", Offset = "0x1E7D394", VA = "0x1E7D394")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1E7D588", Offset = "0x1E7D588", VA = "0x1E7D588")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E198", Offset = "0x117E198")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x1E7F670", Offset = "0x1E7F670", VA = "0x1E7F670")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1E7FE00", Offset = "0x1E7FE00", VA = "0x1E7FE00")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1E7FE24", Offset = "0x1E7FE24", VA = "0x1E7FE24")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E1A8", Offset = "0x117E1A8")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1E7F838", Offset = "0x1E7F838", VA = "0x1E7F838")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1E7FE48", Offset = "0x1E7FE48", VA = "0x1E7FE48")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1E7FE6C", Offset = "0x1E7FE6C", VA = "0x1E7FE6C")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E1B8", Offset = "0x117E1B8")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x1E7FE90", Offset = "0x1E7FE90", VA = "0x1E7FE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x1E800D4", Offset = "0x1E800D4", VA = "0x1E800D4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E1C8", Offset = "0x117E1C8")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1E807E4", Offset = "0x1E807E4", VA = "0x1E807E4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1E80A4C", Offset = "0x1E80A4C", VA = "0x1E80A4C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E1D8", Offset = "0x117E1D8")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1E80338", Offset = "0x1E80338", VA = "0x1E80338", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1E80568", Offset = "0x1E80568", VA = "0x1E80568", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E1E8", Offset = "0x117E1E8")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1E800E0", Offset = "0x1E800E0", VA = "0x1E800E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x1E8032C", Offset = "0x1E8032C", VA = "0x1E8032C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E1F8", Offset = "0x117E1F8")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x1E80574", Offset = "0x1E80574", VA = "0x1E80574", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1E807D8", Offset = "0x1E807D8", VA = "0x1E807D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x117E208", Offset = "0x117E208")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x1E80A58", Offset = "0x1E80A58", VA = "0x1E80A58", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1E80C90", Offset = "0x1E80C90", VA = "0x1E80C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1E7EC14", Offset = "0x1E7EC14", VA = "0x1E7EC14")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1E7EDF0", Offset = "0x1E7EDF0", VA = "0x1E7EDF0")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1E7EFE0", Offset = "0x1E7EFE0", VA = "0x1E7EFE0")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1E7F0A8", Offset = "0x1E7F0A8", VA = "0x1E7F0A8")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1E7F170", Offset = "0x1E7F170", VA = "0x1E7F170")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1E7F238", Offset = "0x1E7F238", VA = "0x1E7F238")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1E7F310", Offset = "0x1E7F310", VA = "0x1E7F310")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1E7F3E8", Offset = "0x1E7F3E8", VA = "0x1E7F3E8")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1E7F4B0", Offset = "0x1E7F4B0", VA = "0x1E7F4B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1E7F678", Offset = "0x1E7F678", VA = "0x1E7F678")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1E7F840", Offset = "0x1E7F840", VA = "0x1E7F840")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x11877E8", Offset = "0x11877E8")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1E7F930", Offset = "0x1E7F930", VA = "0x1E7F930")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x118785C", Offset = "0x118785C")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1E7FA20", Offset = "0x1E7FA20", VA = "0x1E7FA20")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x11878D0", Offset = "0x11878D0")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1E7FB10", Offset = "0x1E7FB10", VA = "0x1E7FB10")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x1187944", Offset = "0x1187944")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1E7FC10", Offset = "0x1E7FC10", VA = "0x1E7FC10")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x11879B8", Offset = "0x11879B8")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1E7FD10", Offset = "0x1E7FD10", VA = "0x1E7FD10")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x1187A2C", Offset = "0x1187A2C")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200008C")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200012A")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000EC")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000850")]
				[Address(RVA = "0x1E757B4", Offset = "0x1E757B4", VA = "0x1E757B4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1E757E8", Offset = "0x1E757E8", VA = "0x1E757E8")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200012B")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000ED")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000852")]
				[Address(RVA = "0x1E75984", Offset = "0x1E75984", VA = "0x1E75984", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x1E759E8", Offset = "0x1E759E8", VA = "0x1E759E8")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x200012C")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000EE")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000854")]
				[Address(RVA = "0x1E7589C", Offset = "0x1E7589C", VA = "0x1E7589C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x1E758B8", Offset = "0x1E758B8", VA = "0x1E758B8")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200012D")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000EF")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000856")]
				[Address(RVA = "0x1E75814", Offset = "0x1E75814", VA = "0x1E75814", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x1E75860", Offset = "0x1E75860", VA = "0x1E75860")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200012E")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000F0")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000858")]
				[Address(RVA = "0x1E758E4", Offset = "0x1E758E4", VA = "0x1E758E4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x1E75948", Offset = "0x1E75948", VA = "0x1E75948")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200012F")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000F1")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600085A")]
				[Address(RVA = "0x1E75A14", Offset = "0x1E75A14", VA = "0x1E75A14", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x1E75A48", Offset = "0x1E75A48", VA = "0x1E75A48")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200008D")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000130")]
		public static class Physics
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x1E80DE0", Offset = "0x1E80DE0", VA = "0x1E80DE0")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x1E80EE8", Offset = "0x1E80EE8", VA = "0x1E80EE8")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x1E80F78", Offset = "0x1E80F78", VA = "0x1E80F78")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1E81008", Offset = "0x1E81008", VA = "0x1E81008")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1E80C9C", Offset = "0x1E80C9C", VA = "0x1E80C9C")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1E80D40", Offset = "0x1E80D40", VA = "0x1E80D40")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
