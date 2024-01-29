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
	[Address(RVA = "0x1EE4608", Offset = "0x1EE4608", VA = "0x1EE4608")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1EE4660", Offset = "0x1EE4660", VA = "0x1EE4660")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1EE4664", Offset = "0x1EE4664", VA = "0x1EE4664")]
	public OverDrawRenderCamera()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x1181564", Offset = "0x1181564")]
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
		[Address(RVA = "0x1EE466C", Offset = "0x1EE466C", VA = "0x1EE466C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public Material overDrawTransparent
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1EE4674", Offset = "0x1EE4674", VA = "0x1EE4674")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1EE467C", Offset = "0x1EE467C", VA = "0x1EE467C", Slot = "4")]
	protected override ScriptableRenderer Create()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1EE4858", Offset = "0x1EE4858", VA = "0x1EE4858")]
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
	[Address(RVA = "0x1EE46DC", Offset = "0x1EE46DC", VA = "0x1EE46DC")]
	public OverDrawRenderer(ScriptableRendererData data)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1EE551C", Offset = "0x1EE551C", VA = "0x1EE551C", Slot = "6")]
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
	[Address(RVA = "0x1EE4860", Offset = "0x1EE4860", VA = "0x1EE4860")]
	public OverDrawRenderPass(SortingCriteria criteria, RenderQueueRange renderQueueRange, Material overdrawMaterial)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1EE4A1C", Offset = "0x1EE4A1C", VA = "0x1EE4A1C", Slot = "7")]
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
	[Address(RVA = "0x1EE4BE8", Offset = "0x1EE4BE8", VA = "0x1EE4BE8", Slot = "4")]
	protected override void Render(ScriptableRenderContext context, Camera[] cameras)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1EE4C70", Offset = "0x1EE4C70", VA = "0x1EE4C70")]
	public void Render(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1EE520C", Offset = "0x1EE520C", VA = "0x1EE520C")]
	public OverDrawRenderPipeline()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x11815B8", Offset = "0x11815B8")]
public class OverDrawRenderPipelineAsset : RenderPipelineAsset
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1EE54B8", Offset = "0x1EE54B8", VA = "0x1EE54B8", Slot = "22")]
	protected override RenderPipeline CreatePipeline()
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1EE5514", Offset = "0x1EE5514", VA = "0x1EE5514")]
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
		[Address(RVA = "0x28171C4", Offset = "0x28171C4", VA = "0x28171C4")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x281727C", Offset = "0x281727C", VA = "0x281727C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2817328", Offset = "0x2817328", VA = "0x2817328")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x281750C", Offset = "0x281750C", VA = "0x281750C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2817444", Offset = "0x2817444", VA = "0x2817444")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2817628", Offset = "0x2817628", VA = "0x2817628")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2817670", Offset = "0x2817670", VA = "0x2817670")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2817938", Offset = "0x2817938", VA = "0x2817938")]
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
			[Address(RVA = "0x2817C00", Offset = "0x2817C00", VA = "0x2817C00")]
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
			[Address(RVA = "0x281798C", Offset = "0x281798C", VA = "0x281798C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2817C78", Offset = "0x2817C78", VA = "0x2817C78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2817940", Offset = "0x2817940", VA = "0x2817940")]
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
		[Address(RVA = "0x2817EEC", Offset = "0x2817EEC", VA = "0x2817EEC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x28181EC", Offset = "0x28181EC", VA = "0x28181EC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x281843C", Offset = "0x281843C", VA = "0x281843C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x28184C0", Offset = "0x28184C0", VA = "0x28184C0")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x281856C", Offset = "0x281856C", VA = "0x281856C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x281809C", Offset = "0x281809C", VA = "0x281809C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x281839C", Offset = "0x281839C", VA = "0x281839C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2818DAC", Offset = "0x2818DAC", VA = "0x2818DAC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2818BC4", Offset = "0x2818BC4", VA = "0x2818BC4")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2818CB8", Offset = "0x2818CB8", VA = "0x2818CB8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x281878C", Offset = "0x281878C", VA = "0x281878C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2818840", Offset = "0x2818840", VA = "0x2818840")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x28188F4", Offset = "0x28188F4", VA = "0x28188F4")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x28189A8", Offset = "0x28189A8", VA = "0x28189A8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2818A5C", Offset = "0x2818A5C", VA = "0x2818A5C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2818B10", Offset = "0x2818B10", VA = "0x2818B10")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2818FC0", Offset = "0x2818FC0", VA = "0x2818FC0")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x28186A0", Offset = "0x28186A0", VA = "0x28186A0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2818F30", Offset = "0x2818F30", VA = "0x2818F30")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2819030", Offset = "0x2819030", VA = "0x2819030")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2819108", Offset = "0x2819108", VA = "0x2819108")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2818EB4", Offset = "0x2818EB4", VA = "0x2818EB4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2818E3C", Offset = "0x2818E3C", VA = "0x2818E3C")]
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
				[Address(RVA = "0x281E098", Offset = "0x281E098", VA = "0x281E098")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x281E084", Offset = "0x281E084", VA = "0x281E084")]
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
			[Address(RVA = "0x281AC7C", Offset = "0x281AC7C", VA = "0x281AC7C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000006")]
		public bool isEmpty
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x281B068", Offset = "0x281B068", VA = "0x281B068")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x281B078", Offset = "0x281B078", VA = "0x281B078", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x281B4A4", Offset = "0x281B4A4", VA = "0x281B4A4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x281B8DC", Offset = "0x281B8DC", VA = "0x281B8DC")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x281BEEC", Offset = "0x281BEEC", VA = "0x281BEEC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x281BB28", Offset = "0x281BB28", VA = "0x281BB28")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x281C69C", Offset = "0x281C69C", VA = "0x281C69C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x281C790", Offset = "0x281C790", VA = "0x281C790")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x281CCE8", Offset = "0x281CCE8", VA = "0x281CCE8")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x281CAEC", Offset = "0x281CAEC", VA = "0x281CAEC")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x281C964", Offset = "0x281C964", VA = "0x281C964")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x281C830", Offset = "0x281C830", VA = "0x281C830")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x281CBF0", Offset = "0x281CBF0", VA = "0x281CBF0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x281CDE4", Offset = "0x281CDE4", VA = "0x281CDE4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x281D884", Offset = "0x281D884", VA = "0x281D884")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x281D368", Offset = "0x281D368", VA = "0x281D368")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x281DB78", Offset = "0x281DB78", VA = "0x281DB78")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x281D6A8", Offset = "0x281D6A8", VA = "0x281D6A8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x281DB80", Offset = "0x281DB80", VA = "0x281DB80")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x281DB88", Offset = "0x281DB88", VA = "0x281DB88")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x281DD48", Offset = "0x281DD48", VA = "0x281DD48")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x281DF60", Offset = "0x281DF60", VA = "0x281DF60")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x281BAB8", Offset = "0x281BAB8", VA = "0x281BAB8")]
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
		[Address(RVA = "0x281E0A0", Offset = "0x281E0A0", VA = "0x281E0A0")]
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
		[Address(RVA = "0x281E0A8", Offset = "0x281E0A8", VA = "0x281E0A8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x281E1E8", Offset = "0x281E1E8", VA = "0x281E1E8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class Hierarchy
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x29B4B28", Offset = "0x29B4B28", VA = "0x29B4B28")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x29B4D28", Offset = "0x29B4D28", VA = "0x29B4D28")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x29B4BC0", Offset = "0x29B4BC0", VA = "0x29B4BC0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x29B4E4C", Offset = "0x29B4E4C", VA = "0x29B4E4C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x29B4F70", Offset = "0x29B4F70", VA = "0x29B4F70")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x29B5218", Offset = "0x29B5218", VA = "0x29B5218")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x29B5334", Offset = "0x29B5334", VA = "0x29B5334")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x29B54BC", Offset = "0x29B54BC", VA = "0x29B54BC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x29B5850", Offset = "0x29B5850", VA = "0x29B5850")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x29B563C", Offset = "0x29B563C", VA = "0x29B563C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x29B59F0", Offset = "0x29B59F0", VA = "0x29B59F0")]
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
		[Address(RVA = "0x29B59F8", Offset = "0x29B59F8", VA = "0x29B59F8")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x29B5A68", Offset = "0x29B5A68", VA = "0x29B5A68")]
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
		[Address(RVA = "0x29B5AD8", Offset = "0x29B5AD8", VA = "0x29B5AD8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x29B6540", Offset = "0x29B6540", VA = "0x29B6540")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x29B6648", Offset = "0x29B6648", VA = "0x29B6648")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x29B5E44", Offset = "0x29B5E44", VA = "0x29B5E44")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x29B5E50", Offset = "0x29B5E50", VA = "0x29B5E50")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x29B5E74", Offset = "0x29B5E74", VA = "0x29B5E74")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x29B5EB0", Offset = "0x29B5EB0", VA = "0x29B5EB0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x29B5EC8", Offset = "0x29B5EC8", VA = "0x29B5EC8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x29B5EDC", Offset = "0x29B5EDC", VA = "0x29B5EDC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x29B5EF0", Offset = "0x29B5EF0", VA = "0x29B5EF0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x29B5F00", Offset = "0x29B5F00", VA = "0x29B5F00")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x29B5F48", Offset = "0x29B5F48", VA = "0x29B5F48")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5F80", VA = "0x29B5F80")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x29B5FA8", Offset = "0x29B5FA8", VA = "0x29B5FA8")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x29B6744", Offset = "0x29B6744", VA = "0x29B6744")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x29B5FDC", Offset = "0x29B5FDC", VA = "0x29B5FDC")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x29B6004", Offset = "0x29B6004", VA = "0x29B6004")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x29B6034", Offset = "0x29B6034", VA = "0x29B6034")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x29B6068", Offset = "0x29B6068", VA = "0x29B6068")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x29B60AC", Offset = "0x29B60AC", VA = "0x29B60AC")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x29B6110", Offset = "0x29B6110", VA = "0x29B6110")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x29B6174", Offset = "0x29B6174", VA = "0x29B6174")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x29B61C8", Offset = "0x29B61C8", VA = "0x29B61C8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x29B621C", Offset = "0x29B621C", VA = "0x29B621C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x29B62B4", Offset = "0x29B62B4", VA = "0x29B62B4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x29B6348", Offset = "0x29B6348", VA = "0x29B6348")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x29B6778", Offset = "0x29B6778", VA = "0x29B6778")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x29B63EC", Offset = "0x29B63EC", VA = "0x29B63EC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x29B64D0", Offset = "0x29B64D0", VA = "0x29B64D0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x29B6500", Offset = "0x29B6500", VA = "0x29B6500")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x29B6860", Offset = "0x29B6860", VA = "0x29B6860")]
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
		[Address(RVA = "0x29B6868", Offset = "0x29B6868", VA = "0x29B6868")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x29B68D8", Offset = "0x29B68D8", VA = "0x29B68D8")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x29B6948", Offset = "0x29B6948", VA = "0x29B6948")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x29B69A0", Offset = "0x29B69A0", VA = "0x29B69A0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x29B6A6C", Offset = "0x29B6A6C", VA = "0x29B6A6C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x29B69B8", Offset = "0x29B69B8", VA = "0x29B69B8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x29B6A84", Offset = "0x29B6A84", VA = "0x29B6A84")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x29B6B28", Offset = "0x29B6B28", VA = "0x29B6B28")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x29B6B54", Offset = "0x29B6B54", VA = "0x29B6B54")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x29B6BA4", Offset = "0x29B6BA4", VA = "0x29B6BA4")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x29B6C10", Offset = "0x29B6C10", VA = "0x29B6C10")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x29B6D04", Offset = "0x29B6D04", VA = "0x29B6D04")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x29B6DDC", Offset = "0x29B6DDC", VA = "0x29B6DDC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x29B6E3C", Offset = "0x29B6E3C", VA = "0x29B6E3C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	public static class QuaTools
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x29B6E6C", Offset = "0x29B6E6C", VA = "0x29B6E6C")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x29B6F70", Offset = "0x29B6F70", VA = "0x29B6F70")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x29B7070", Offset = "0x29B7070", VA = "0x29B7070")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x29B726C", Offset = "0x29B726C", VA = "0x29B726C")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x29B73E0", Offset = "0x29B73E0", VA = "0x29B73E0")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x29B754C", Offset = "0x29B754C", VA = "0x29B754C")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x29B77A8", Offset = "0x29B77A8", VA = "0x29B77A8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x29B78F4", Offset = "0x29B78F4", VA = "0x29B78F4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x29B7A40", Offset = "0x29B7A40", VA = "0x29B7A40")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x29B7B54", Offset = "0x29B7B54", VA = "0x29B7B54")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x29B7C68", Offset = "0x29B7C68", VA = "0x29B7C68")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x29B7DF4", Offset = "0x29B7DF4", VA = "0x29B7DF4")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x29A8270", Offset = "0x29A8270", VA = "0x29A8270")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x29B7EC4", Offset = "0x29B7EC4", VA = "0x29B7EC4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x29B8148", Offset = "0x29B8148", VA = "0x29B8148")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x29B835C", Offset = "0x29B835C", VA = "0x29B835C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x29B11D4", Offset = "0x29B11D4", VA = "0x29B11D4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x29B84DC", Offset = "0x29B84DC", VA = "0x29B84DC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x29B85EC", Offset = "0x29B85EC", VA = "0x29B85EC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182590", Offset = "0x1182590")]
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
			[Address(RVA = "0x29B8788", Offset = "0x29B8788", VA = "0x29B8788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		private bool isAnimated
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x29B8A84", Offset = "0x29B8A84", VA = "0x29B8A84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x29B8648", Offset = "0x29B8648", VA = "0x29B8648")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x29B86E0", Offset = "0x29B86E0", VA = "0x29B86E0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x29B86E4", Offset = "0x29B86E4", VA = "0x29B86E4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x29B86E8", Offset = "0x29B86E8", VA = "0x29B86E8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x29B86EC", Offset = "0x29B86EC", VA = "0x29B86EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x29B8784", Offset = "0x29B8784", VA = "0x29B8784")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x29B8724", Offset = "0x29B8724", VA = "0x29B8724")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x29B8A38", Offset = "0x29B8A38", VA = "0x29B8A38")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x29B8878", Offset = "0x29B8878", VA = "0x29B8878")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x29B8B40", Offset = "0x29B8B40", VA = "0x29B8B40")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x29B8BA4", Offset = "0x29B8BA4", VA = "0x29B8BA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x29B8C00", Offset = "0x29B8C00", VA = "0x29B8C00")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x29A68F0", Offset = "0x29A68F0", VA = "0x29A68F0")]
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
		[Address(RVA = "0x29B8C48", Offset = "0x29B8C48", VA = "0x29B8C48")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x29B8D00", Offset = "0x29B8D00", VA = "0x29B8D00")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x29B8DB8", Offset = "0x29B8DB8", VA = "0x29B8DB8")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x29B8E70", Offset = "0x29B8E70", VA = "0x29B8E70")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class V2Tools
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x29B8E78", Offset = "0x29B8E78", VA = "0x29B8E78")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x29B8EA8", Offset = "0x29B8EA8", VA = "0x29B8EA8")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x29B8F54", Offset = "0x29B8F54", VA = "0x29B8F54")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x29B9000", Offset = "0x29B9000", VA = "0x29B9000")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x29B91D0", Offset = "0x29B91D0", VA = "0x29B91D0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001A")]
	public static class V3Tools
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x29B9338", Offset = "0x29B9338", VA = "0x29B9338")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x29B93BC", Offset = "0x29B93BC", VA = "0x29B93BC")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x29B945C", Offset = "0x29B945C", VA = "0x29B945C")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x29B95A0", Offset = "0x29B95A0", VA = "0x29B95A0")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x29B96C0", Offset = "0x29B96C0", VA = "0x29B96C0")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x29B97D8", Offset = "0x29B97D8", VA = "0x29B97D8")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x29B999C", Offset = "0x29B999C", VA = "0x29B999C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x29B9A94", Offset = "0x29B9A94", VA = "0x29B9A94")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x29B9B8C", Offset = "0x29B9B8C", VA = "0x29B9B8C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x29B9C84", Offset = "0x29B9C84", VA = "0x29B9C84")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x29B9D84", Offset = "0x29B9D84", VA = "0x29B9D84")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x29B9FA8", Offset = "0x29B9FA8", VA = "0x29B9FA8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x29BA1E4", Offset = "0x29BA1E4", VA = "0x29BA1E4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x29BA434", Offset = "0x29BA434", VA = "0x29BA434")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x29BA634", Offset = "0x29BA634", VA = "0x29BA634")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x29BA810", Offset = "0x29BA810", VA = "0x29BA810")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x29BA944", Offset = "0x29BA944", VA = "0x29BA944")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x29BAA9C", Offset = "0x29BAA9C", VA = "0x29BAA9C")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x29BAC28", Offset = "0x29BAC28", VA = "0x29BAC28")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x29BABE8", Offset = "0x29BABE8", VA = "0x29BABE8")]
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
		[Address(RVA = "0x29BAD64", Offset = "0x29BAD64", VA = "0x29BAD64")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x29A9D9C", Offset = "0x29A9D9C", VA = "0x29A9D9C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11825C8", Offset = "0x11825C8")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182600", Offset = "0x1182600")]
		public float cornerRadius;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182638", Offset = "0x1182638")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182670", Offset = "0x1182670")]
		public float maxSampleDistance;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11826A8", Offset = "0x11826A8")]
		public float nextPathInterval;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11826E0", Offset = "0x11826E0")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11826F0", Offset = "0x11826F0")]
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
			[Address(RVA = "0x281E21C", Offset = "0x281E21C", VA = "0x281E21C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11892B8", Offset = "0x11892B8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x281E228", Offset = "0x281E228", VA = "0x281E228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11892C8", Offset = "0x11892C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public State state
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x281E234", Offset = "0x281E234", VA = "0x281E234")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11892D8", Offset = "0x11892D8")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x281E23C", Offset = "0x281E23C", VA = "0x281E23C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11892E8", Offset = "0x11892E8")]
			private set
			{
			}
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x281E244", Offset = "0x281E244", VA = "0x281E244")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x281E318", Offset = "0x281E318", VA = "0x281E318")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x281E85C", Offset = "0x281E85C", VA = "0x281E85C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x281E8CC", Offset = "0x281E8CC", VA = "0x281E8CC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x281E724", Offset = "0x281E724", VA = "0x281E724")]
		private void Stop()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x281E798", Offset = "0x281E798", VA = "0x281E798")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x281EA14", Offset = "0x281EA14", VA = "0x281EA14")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x281EBC4", Offset = "0x281EBC4", VA = "0x281EBC4")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181604", Offset = "0x1181604")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181604", Offset = "0x1181604")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2820E04", Offset = "0x2820E04", VA = "0x2820E04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11892F8", Offset = "0x11892F8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2820E50", Offset = "0x2820E50", VA = "0x2820E50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189330", Offset = "0x1189330")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2820E9C", Offset = "0x2820E9C", VA = "0x2820E9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189368", Offset = "0x1189368")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2820EE8", Offset = "0x2820EE8", VA = "0x2820EE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11893A0", Offset = "0x11893A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2820F34", Offset = "0x2820F34", VA = "0x2820F34")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2820FD0", Offset = "0x2820FD0", VA = "0x2820FD0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2820FF0", Offset = "0x2820FF0", VA = "0x2820FF0")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2821020", Offset = "0x2821020", VA = "0x2821020")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2821050", Offset = "0x2821050", VA = "0x2821050")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2821090", Offset = "0x2821090", VA = "0x2821090")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x28210D4", Offset = "0x28210D4", VA = "0x28210D4")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x28210F8", Offset = "0x28210F8", VA = "0x28210F8")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x282111C", Offset = "0x282111C", VA = "0x282111C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2821144", Offset = "0x2821144", VA = "0x2821144")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2821170", Offset = "0x2821170", VA = "0x2821170")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x282119C", Offset = "0x282119C", VA = "0x282119C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2820F54", Offset = "0x2820F54", VA = "0x2820F54")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x28211C4", Offset = "0x28211C4", VA = "0x28211C4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x28211D0", Offset = "0x28211D0", VA = "0x28211D0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x28211DC", Offset = "0x28211DC", VA = "0x28211DC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x28214C4", Offset = "0x28214C4", VA = "0x28214C4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x282156C", Offset = "0x282156C", VA = "0x282156C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x28218B0", Offset = "0x28218B0", VA = "0x28218B0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2821D98", Offset = "0x2821D98", VA = "0x2821D98")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2821DCC", Offset = "0x2821DCC", VA = "0x2821DCC")]
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
			[Address(RVA = "0x282137C", Offset = "0x282137C", VA = "0x282137C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2821F94", Offset = "0x2821F94", VA = "0x2821F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2821738", Offset = "0x2821738", VA = "0x2821738")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2821E4C", Offset = "0x2821E4C", VA = "0x2821E4C")]
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
			[Address(RVA = "0x2822A6C", Offset = "0x2822A6C", VA = "0x2822A6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F9")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2822ADC", Offset = "0x2822ADC", VA = "0x2822ADC")]
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
		[Address(RVA = "0x2822AE4", Offset = "0x2822AE4", VA = "0x2822AE4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2822BF0", Offset = "0x2822BF0", VA = "0x2822BF0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2822BF8", Offset = "0x2822BF8", VA = "0x2822BF8")]
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
			[Address(RVA = "0x2822DC0", Offset = "0x2822DC0", VA = "0x2822DC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2822C24", Offset = "0x2822C24", VA = "0x2822C24", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2822E7C", Offset = "0x2822E7C", VA = "0x2822E7C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2822E84", Offset = "0x2822E84", VA = "0x2822E84")]
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
		[Address(RVA = "0x2822EB0", Offset = "0x2822EB0", VA = "0x2822EB0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2822FD8", Offset = "0x2822FD8", VA = "0x2822FD8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2822FE0", Offset = "0x2822FE0", VA = "0x2822FE0")]
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
			[Address(RVA = "0x28231AC", Offset = "0x28231AC", VA = "0x28231AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x282300C", Offset = "0x282300C", VA = "0x282300C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x282327C", Offset = "0x282327C", VA = "0x282327C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2823284", Offset = "0x2823284", VA = "0x2823284")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182700", Offset = "0x1182700")]
		public float positionWeight;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182718", Offset = "0x1182718")]
		public float rotationWeight;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x28232B0", Offset = "0x28232B0", VA = "0x28232B0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x282185C", Offset = "0x282185C", VA = "0x282185C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2821A38", Offset = "0x2821A38", VA = "0x2821A38")]
		public void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2822160", Offset = "0x2822160", VA = "0x2822160")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182730", Offset = "0x1182730")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182730", Offset = "0x1182730")]
		public float weight;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182784", Offset = "0x1182784")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182784", Offset = "0x1182784")]
		public float rotationWeight;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11827D8", Offset = "0x11827D8")]
		public DOF rotationDOF;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182810", Offset = "0x1182810")]
		public bool fixBone1Twist;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182848", Offset = "0x1182848")]
		public Transform bone1;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182880", Offset = "0x1182880")]
		public Transform bone2;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11828B8", Offset = "0x11828B8")]
		public Transform bone3;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11828F0", Offset = "0x11828F0")]
		public Transform tip;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182928", Offset = "0x1182928")]
		public Transform target;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182960", Offset = "0x1182960")]
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
			[Address(RVA = "0x282B108", Offset = "0x282B108", VA = "0x282B108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11893D8", Offset = "0x11893D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x282B110", Offset = "0x282B110", VA = "0x282B110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11893E8", Offset = "0x11893E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x282B11C", Offset = "0x282B11C", VA = "0x282B11C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x282B13C", Offset = "0x282B13C", VA = "0x282B13C")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x282B15C", Offset = "0x282B15C", VA = "0x282B15C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x282B17C", Offset = "0x282B17C", VA = "0x282B17C")]
			set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x282B19C", Offset = "0x282B19C", VA = "0x282B19C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x282B29C", Offset = "0x282B29C", VA = "0x282B29C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x282B930", Offset = "0x282B930", VA = "0x282B930")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x282BA0C", Offset = "0x282BA0C", VA = "0x282BA0C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x282BAD4", Offset = "0x282BAD4", VA = "0x282BAD4")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x282C0F0", Offset = "0x282C0F0", VA = "0x282C0F0")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182970", Offset = "0x1182970")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182970", Offset = "0x1182970")]
		public float weight;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11829C4", Offset = "0x11829C4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x282C100", Offset = "0x282C100", VA = "0x282C100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11893F8", Offset = "0x11893F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x282C108", Offset = "0x282C108", VA = "0x282C108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189408", Offset = "0x1189408")]
			private set
			{
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x282C114", Offset = "0x282C114", VA = "0x282C114")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x282C19C", Offset = "0x282C19C", VA = "0x282C19C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189418", Offset = "0x1189418")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x282C4C0", Offset = "0x282C4C0", VA = "0x282C4C0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x282C630", Offset = "0x282C630", VA = "0x282C630")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x282C3B8", Offset = "0x282C3B8", VA = "0x282C3B8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x282C798", Offset = "0x282C798", VA = "0x282C798", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x282C858", Offset = "0x282C858", VA = "0x282C858")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x282C8D0", Offset = "0x282C8D0", VA = "0x282C8D0")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x282C944", Offset = "0x282C944", VA = "0x282C944")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x282C9AC", Offset = "0x282C9AC", VA = "0x282C9AC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x282C9B0", Offset = "0x282C9B0", VA = "0x282C9B0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x282C9C4", Offset = "0x282C9C4", VA = "0x282C9C4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11829D4", Offset = "0x11829D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11829D4", Offset = "0x11829D4")]
		public float weight;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182A28", Offset = "0x1182A28")]
		public Grounding solver;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182A60", Offset = "0x1182A60")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x282D9C4", Offset = "0x282D9C4", VA = "0x282D9C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189450", Offset = "0x1189450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x282D9CC", Offset = "0x282D9CC", VA = "0x282D9CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189460", Offset = "0x1189460")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000127")]
		public abstract void ResetPosition();

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x282D9D8", Offset = "0x282D9D8", VA = "0x282D9D8")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x282DCAC", Offset = "0x282DCAC", VA = "0x282DCAC")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x282DB1C", Offset = "0x282DB1C", VA = "0x282DB1C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x282DCE0", Offset = "0x282DCE0", VA = "0x282DCE0")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600012F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x282DEE8", Offset = "0x282DEE8", VA = "0x282DEE8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181664", Offset = "0x1181664")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181664", Offset = "0x1181664")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182A70", Offset = "0x1182A70")]
		public BipedIK ik;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182AA8", Offset = "0x1182AA8")]
		public float spineBend;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182AE0", Offset = "0x1182AE0")]
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
		[Address(RVA = "0x273A9CC", Offset = "0x273A9CC", VA = "0x273A9CC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189470", Offset = "0x1189470")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x273AA18", Offset = "0x273AA18", VA = "0x273AA18", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11894A8", Offset = "0x11894A8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x273AA64", Offset = "0x273AA64", VA = "0x273AA64", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x273AB68", Offset = "0x273AB68", VA = "0x273AB68")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x273AC18", Offset = "0x273AC18", VA = "0x273AC18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x273ACCC", Offset = "0x273ACCC", VA = "0x273ACCC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x273B1E0", Offset = "0x273B1E0", VA = "0x273B1E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x273B234", Offset = "0x273B234", VA = "0x273B234")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x273BA4C", Offset = "0x273BA4C", VA = "0x273BA4C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x273BBAC", Offset = "0x273BBAC", VA = "0x273BBAC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x273BD3C", Offset = "0x273BD3C", VA = "0x273BD3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x273BE9C", Offset = "0x273BE9C", VA = "0x273BE9C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11816C4", Offset = "0x11816C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11816C4", Offset = "0x11816C4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000097")]
		public class SpineEffector
		{
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185DC4", Offset = "0x1185DC4")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185DFC", Offset = "0x1185DFC")]
			public float horizontalWeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185E34", Offset = "0x1185E34")]
			public float verticalWeight;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x273CCF8", Offset = "0x273CCF8", VA = "0x273CCF8")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x273CD08", Offset = "0x273CD08", VA = "0x273CD08")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182B18", Offset = "0x1182B18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182B50", Offset = "0x1182B50")]
		public float spineBend;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182B88", Offset = "0x1182B88")]
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
		[Address(RVA = "0x273BF20", Offset = "0x273BF20", VA = "0x273BF20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11894E0", Offset = "0x11894E0")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x273BF6C", Offset = "0x273BF6C", VA = "0x273BF6C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189518", Offset = "0x1189518")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x273BFB8", Offset = "0x273BFB8", VA = "0x273BFB8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189550", Offset = "0x1189550")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x273C004", Offset = "0x273C004", VA = "0x273C004", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x273C084", Offset = "0x273C084", VA = "0x273C084")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x273C11C", Offset = "0x273C11C", VA = "0x273C11C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x273C3CC", Offset = "0x273C3CC", VA = "0x273C3CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x273C3D8", Offset = "0x273C3D8", VA = "0x273C3D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x273C1D8", Offset = "0x273C1D8", VA = "0x273C1D8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x273C3E4", Offset = "0x273C3E4", VA = "0x273C3E4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x273C888", Offset = "0x273C888", VA = "0x273C888")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x273CA48", Offset = "0x273CA48", VA = "0x273CA48")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x273CB80", Offset = "0x273CB80", VA = "0x273CB80")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x273CC74", Offset = "0x273CC74", VA = "0x273CC74")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181724", Offset = "0x1181724")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181724", Offset = "0x1181724")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182BC0", Offset = "0x1182BC0")]
		public Transform pelvis;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182BF8", Offset = "0x1182BF8")]
		public Transform characterRoot;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182C30", Offset = "0x1182C30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182C30", Offset = "0x1182C30")]
		public float rootRotationWeight;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182C84", Offset = "0x1182C84")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182CBC", Offset = "0x1182CBC")]
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
		[Address(RVA = "0x273CD50", Offset = "0x273CD50", VA = "0x273CD50", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189588", Offset = "0x1189588")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x273CD9C", Offset = "0x273CD9C", VA = "0x273CD9C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11895C0", Offset = "0x11895C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x273CDE8", Offset = "0x273CDE8", VA = "0x273CDE8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x273CE00", Offset = "0x273CE00", VA = "0x273CE00")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x273CFDC", Offset = "0x273CFDC", VA = "0x273CFDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x273D0DC", Offset = "0x273D0DC", VA = "0x273D0DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x273D824", Offset = "0x273D824", VA = "0x273D824")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x273DC00", Offset = "0x273DC00", VA = "0x273DC00")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x273DE70", Offset = "0x273DE70", VA = "0x273DE70")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x273E190", Offset = "0x273E190", VA = "0x273E190")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x273E32C", Offset = "0x273E32C", VA = "0x273E32C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x273E4EC", Offset = "0x273E4EC", VA = "0x273E4EC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181784", Offset = "0x1181784")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181784", Offset = "0x1181784")]
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
			[Address(RVA = "0x273F03C", Offset = "0x273F03C", VA = "0x273F03C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182CF4", Offset = "0x1182CF4")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182D2C", Offset = "0x1182D2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182D2C", Offset = "0x1182D2C")]
		public float rootRotationWeight;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182D80", Offset = "0x1182D80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182D80", Offset = "0x1182D80")]
		public float minRootRotation;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182DD8", Offset = "0x1182DD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182DD8", Offset = "0x1182DD8")]
		public float maxRootRotation;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182E30", Offset = "0x1182E30")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182E68", Offset = "0x1182E68")]
		public float maxLegOffset;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182EA0", Offset = "0x1182EA0")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182ED8", Offset = "0x1182ED8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1182ED8", Offset = "0x1182ED8")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182F2C", Offset = "0x1182F2C")]
		public Transform characterRoot;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182F64", Offset = "0x1182F64")]
		public Transform pelvis;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182F9C", Offset = "0x1182F9C")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1182FD4", Offset = "0x1182FD4")]
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
		[Address(RVA = "0x273E570", Offset = "0x273E570", VA = "0x273E570", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11895F8", Offset = "0x11895F8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x273E5BC", Offset = "0x273E5BC", VA = "0x273E5BC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189630", Offset = "0x1189630")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x273E608", Offset = "0x273E608", VA = "0x273E608", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x273E63C", Offset = "0x273E63C", VA = "0x273E63C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x273E76C", Offset = "0x273E76C", VA = "0x273E76C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x273E918", Offset = "0x273E918", VA = "0x273E918")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x273E980", Offset = "0x273E980", VA = "0x273E980")]
		private void Update()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x273EA38", Offset = "0x273EA38", VA = "0x273EA38")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x273ED38", Offset = "0x273ED38", VA = "0x273ED38")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x273F07C", Offset = "0x273F07C", VA = "0x273F07C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x273F1C8", Offset = "0x273F1C8", VA = "0x273F1C8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x273F66C", Offset = "0x273F66C", VA = "0x273F66C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x273FE5C", Offset = "0x273FE5C", VA = "0x273FE5C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x274011C", Offset = "0x274011C", VA = "0x274011C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x274027C", Offset = "0x274027C", VA = "0x274027C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2740558", Offset = "0x2740558", VA = "0x2740558")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2740590", Offset = "0x2740590", VA = "0x2740590")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2740748", Offset = "0x2740748", VA = "0x2740748")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11817E4", Offset = "0x11817E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11817E4", Offset = "0x11817E4")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118301C", Offset = "0x118301C")]
		public VRIK ik;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x27408B8", Offset = "0x27408B8", VA = "0x27408B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189668", Offset = "0x1189668")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2740904", Offset = "0x2740904", VA = "0x2740904", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11896A0", Offset = "0x11896A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2740950", Offset = "0x2740950", VA = "0x2740950", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11896D8", Offset = "0x11896D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x274099C", Offset = "0x274099C", VA = "0x274099C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x27409B4", Offset = "0x27409B4", VA = "0x27409B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2740A4C", Offset = "0x2740A4C", VA = "0x2740A4C")]
		private void Update()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2740B00", Offset = "0x2740B00", VA = "0x2740B00")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2740CF0", Offset = "0x2740CF0", VA = "0x2740CF0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2740F84", Offset = "0x2740F84", VA = "0x2740F84")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x274108C", Offset = "0x274108C", VA = "0x274108C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x274128C", Offset = "0x274128C", VA = "0x274128C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x27413C4", Offset = "0x27413C4", VA = "0x27413C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2741514", Offset = "0x2741514", VA = "0x2741514")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185E6C", Offset = "0x1185E6C")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185E7C", Offset = "0x1185E7C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185E8C", Offset = "0x1185E8C")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185E9C", Offset = "0x1185E9C")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185EAC", Offset = "0x1185EAC")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185EBC", Offset = "0x1185EBC")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185ECC", Offset = "0x1185ECC")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185EDC", Offset = "0x1185EDC")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185EEC", Offset = "0x1185EEC")]
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
				[Address(RVA = "0x2742F70", Offset = "0x2742F70", VA = "0x2742F70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BDF8", Offset = "0x118BDF8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x2742F78", Offset = "0x2742F78", VA = "0x2742F78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE08", Offset = "0x118BE08")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x2742F84", Offset = "0x2742F84", VA = "0x2742F84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE18", Offset = "0x118BE18")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x2742F90", Offset = "0x2742F90", VA = "0x2742F90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE28", Offset = "0x118BE28")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public bool initiated
			{
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0x2742F9C", Offset = "0x2742F9C", VA = "0x2742F9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE38", Offset = "0x118BE38")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0x2742FA4", Offset = "0x2742FA4", VA = "0x2742FA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE48", Offset = "0x118BE48")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			public float heightFromGround
			{
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0x2742FB0", Offset = "0x2742FB0", VA = "0x2742FB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE58", Offset = "0x118BE58")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005E7")]
				[Address(RVA = "0x2742FB8", Offset = "0x2742FB8", VA = "0x2742FB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE68", Offset = "0x118BE68")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005E8")]
				[Address(RVA = "0x2742FC0", Offset = "0x2742FC0", VA = "0x2742FC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE78", Offset = "0x118BE78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E9")]
				[Address(RVA = "0x2742FCC", Offset = "0x2742FCC", VA = "0x2742FCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE88", Offset = "0x118BE88")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			public Transform transform
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x2742FD8", Offset = "0x2742FD8", VA = "0x2742FD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BE98", Offset = "0x118BE98")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x2742FE0", Offset = "0x2742FE0", VA = "0x2742FE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BEA8", Offset = "0x118BEA8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			public float IKOffset
			{
				[Token(Token = "0x60005EC")]
				[Address(RVA = "0x2742FE8", Offset = "0x2742FE8", VA = "0x2742FE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BEB8", Offset = "0x118BEB8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005ED")]
				[Address(RVA = "0x2742FF0", Offset = "0x2742FF0", VA = "0x2742FF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BEC8", Offset = "0x118BEC8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60005EE")]
				[Address(RVA = "0x2742FF8", Offset = "0x2742FF8", VA = "0x2742FF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BED8", Offset = "0x118BED8")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60005EF")]
				[Address(RVA = "0x2743010", Offset = "0x2743010", VA = "0x2743010")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BEE8", Offset = "0x118BEE8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x2743030", Offset = "0x2743030", VA = "0x2743030")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BEF8", Offset = "0x118BEF8")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x2743048", Offset = "0x2743048", VA = "0x2743048")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF08", Offset = "0x118BF08")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x2743068", Offset = "0x2743068", VA = "0x2743068")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x170000A8")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x2743E2C", Offset = "0x2743E2C", VA = "0x2743E2C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A9")]
			private float rootYOffset
			{
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x2744104", Offset = "0x2744104", VA = "0x2744104")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x27430B0", Offset = "0x27430B0", VA = "0x27430B0")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x2741BB0", Offset = "0x2741BB0", VA = "0x2741BB0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x27430C4", Offset = "0x27430C4", VA = "0x27430C4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x2742A90", Offset = "0x2742A90", VA = "0x2742A90")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x2741CBC", Offset = "0x2741CBC", VA = "0x2741CBC")]
			public void Process()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x27438A0", Offset = "0x27438A0", VA = "0x27438A0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x2743110", Offset = "0x2743110", VA = "0x2743110")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x2743FAC", Offset = "0x2743FAC", VA = "0x2743FAC")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x274354C", Offset = "0x274354C", VA = "0x274354C")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x2743654", Offset = "0x2743654", VA = "0x2743654")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x27440A8", Offset = "0x27440A8", VA = "0x27440A8")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x2743EB8", Offset = "0x2743EB8", VA = "0x2743EB8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x274422C", Offset = "0x274422C", VA = "0x274422C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x2741B00", Offset = "0x2741B00", VA = "0x2741B00")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200009B")]
		public class Pelvis
		{
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185EFC", Offset = "0x1185EFC")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185F0C", Offset = "0x1185F0C")]
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
				[Address(RVA = "0x274431C", Offset = "0x274431C", VA = "0x274431C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF18", Offset = "0x118BF18")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x2744328", Offset = "0x2744328", VA = "0x2744328")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF28", Offset = "0x118BF28")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			public float heightOffset
			{
				[Token(Token = "0x6000605")]
				[Address(RVA = "0x2744334", Offset = "0x2744334", VA = "0x2744334")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF38", Offset = "0x118BF38")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000606")]
				[Address(RVA = "0x274433C", Offset = "0x274433C", VA = "0x274433C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF48", Offset = "0x118BF48")]
				private set
				{
				}
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x2741C94", Offset = "0x2741C94", VA = "0x2741C94")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x27429E0", Offset = "0x27429E0", VA = "0x27429E0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x2744344", Offset = "0x2744344", VA = "0x2744344")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x2742774", Offset = "0x2742774", VA = "0x2742774")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x2741BA8", Offset = "0x2741BA8", VA = "0x2741BA8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183054", Offset = "0x1183054")]
		public LayerMask layers;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118308C", Offset = "0x118308C")]
		public float maxStep;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11830C4", Offset = "0x11830C4")]
		public float heightOffset;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11830FC", Offset = "0x11830FC")]
		public float footSpeed;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183134", Offset = "0x1183134")]
		public float footRadius;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118316C", Offset = "0x118316C")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11831B8", Offset = "0x11831B8")]
		public float prediction;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11831F0", Offset = "0x11831F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11831F0", Offset = "0x11831F0")]
		public float footRotationWeight;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183244", Offset = "0x1183244")]
		public float footRotationSpeed;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118327C", Offset = "0x118327C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118327C", Offset = "0x118327C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11832D4", Offset = "0x11832D4")]
		public bool rotateSolver;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118330C", Offset = "0x118330C")]
		public float pelvisSpeed;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183344", Offset = "0x1183344")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183344", Offset = "0x1183344")]
		public float pelvisDamper;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183398", Offset = "0x1183398")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11833D0", Offset = "0x11833D0")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183408", Offset = "0x1183408")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183440", Offset = "0x1183440")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183478", Offset = "0x1183478")]
		public Quality quality;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834B0", Offset = "0x11834B0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834C0", Offset = "0x11834C0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834D0", Offset = "0x11834D0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834E0", Offset = "0x11834E0")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834F0", Offset = "0x11834F0")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000016")]
		public Leg[] legs
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2741574", Offset = "0x2741574", VA = "0x2741574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189710", Offset = "0x1189710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x274157C", Offset = "0x274157C", VA = "0x274157C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189720", Offset = "0x1189720")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2741584", Offset = "0x2741584", VA = "0x2741584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189730", Offset = "0x1189730")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x274158C", Offset = "0x274158C", VA = "0x274158C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189740", Offset = "0x1189740")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool isGrounded
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2741594", Offset = "0x2741594", VA = "0x2741594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189750", Offset = "0x1189750")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x274159C", Offset = "0x274159C", VA = "0x274159C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189760", Offset = "0x1189760")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Transform root
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x27415A8", Offset = "0x27415A8", VA = "0x27415A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189770", Offset = "0x1189770")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x27415B0", Offset = "0x27415B0", VA = "0x27415B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189780", Offset = "0x1189780")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x27415B8", Offset = "0x27415B8", VA = "0x27415B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1189790", Offset = "0x1189790")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x27415D0", Offset = "0x27415D0", VA = "0x27415D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11897A0", Offset = "0x11897A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x27415F0", Offset = "0x27415F0", VA = "0x27415F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 up
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x273BB20", Offset = "0x273BB20", VA = "0x273BB20")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001D")]
		private bool useRootRotation
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2742B44", Offset = "0x2742B44", VA = "0x2742B44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2741644", Offset = "0x2741644", VA = "0x2741644")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2741A24", Offset = "0x2741A24", VA = "0x2741A24")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x273AF80", Offset = "0x273AF80", VA = "0x273AF80")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x273B7A4", Offset = "0x273B7A4", VA = "0x273B7A4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x273D60C", Offset = "0x273D60C", VA = "0x273D60C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x273AAE4", Offset = "0x273AAE4", VA = "0x273AAE4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2741CA4", Offset = "0x2741CA4", VA = "0x2741CA4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2742C14", Offset = "0x2742C14", VA = "0x2742C14")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2742D7C", Offset = "0x2742D7C", VA = "0x2742D7C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2742E80", Offset = "0x2742E80", VA = "0x2742E80")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2740864", Offset = "0x2740864", VA = "0x2740864")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181844", Offset = "0x1181844")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181844", Offset = "0x1181844")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2820030", Offset = "0x2820030", VA = "0x2820030", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11897B0", Offset = "0x11897B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x282007C", Offset = "0x282007C", VA = "0x282007C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11897E8", Offset = "0x11897E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x28200C8", Offset = "0x28200C8", VA = "0x28200C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189820", Offset = "0x1189820")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2820114", Offset = "0x2820114", VA = "0x2820114")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189858", Offset = "0x1189858")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2820160", Offset = "0x2820160", VA = "0x2820160")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189890", Offset = "0x1189890")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x28201AC", Offset = "0x28201AC", VA = "0x28201AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x28201B4", Offset = "0x28201B4", VA = "0x28201B4")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11818A4", Offset = "0x11818A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11818A4", Offset = "0x11818A4")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2820C64", Offset = "0x2820C64", VA = "0x2820C64", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11898C8", Offset = "0x11898C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2820CB0", Offset = "0x2820CB0", VA = "0x2820CB0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189900", Offset = "0x1189900")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2820CFC", Offset = "0x2820CFC", VA = "0x2820CFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189938", Offset = "0x1189938")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2820D48", Offset = "0x2820D48", VA = "0x2820D48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189970", Offset = "0x1189970")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2820D94", Offset = "0x2820D94", VA = "0x2820D94", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2820D9C", Offset = "0x2820D9C", VA = "0x2820D9C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181904", Offset = "0x1181904")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181904", Offset = "0x1181904")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x28228CC", Offset = "0x28228CC", VA = "0x28228CC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11899A8", Offset = "0x11899A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2822918", Offset = "0x2822918", VA = "0x2822918", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x11899E0", Offset = "0x11899E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2822964", Offset = "0x2822964", VA = "0x2822964")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189A18", Offset = "0x1189A18")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x28229B0", Offset = "0x28229B0", VA = "0x28229B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189A50", Offset = "0x1189A50")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x28229FC", Offset = "0x28229FC", VA = "0x28229FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2822A04", Offset = "0x2822A04", VA = "0x2822A04")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181964", Offset = "0x1181964")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181964", Offset = "0x1181964")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2823FAC", Offset = "0x2823FAC", VA = "0x2823FAC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189A88", Offset = "0x1189A88")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2823FF8", Offset = "0x2823FF8", VA = "0x2823FF8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189AC0", Offset = "0x1189AC0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2824044", Offset = "0x2824044", VA = "0x2824044")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189AF8", Offset = "0x1189AF8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2824090", Offset = "0x2824090", VA = "0x2824090")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189B30", Offset = "0x1189B30")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x28240DC", Offset = "0x28240DC", VA = "0x28240DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x28240E4", Offset = "0x28240E4", VA = "0x28240E4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11819C4", Offset = "0x11819C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11819C4", Offset = "0x11819C4")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2824764", Offset = "0x2824764", VA = "0x2824764", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189B68", Offset = "0x1189B68")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x28247B0", Offset = "0x28247B0", VA = "0x28247B0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189BA0", Offset = "0x1189BA0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x28247FC", Offset = "0x28247FC", VA = "0x28247FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189BD8", Offset = "0x1189BD8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2824848", Offset = "0x2824848", VA = "0x2824848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189C10", Offset = "0x1189C10")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2824894", Offset = "0x2824894", VA = "0x2824894", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x282489C", Offset = "0x282489C", VA = "0x282489C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181A24", Offset = "0x1181A24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181A24", Offset = "0x1181A24")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x282CA2C", Offset = "0x282CA2C", VA = "0x282CA2C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189C48", Offset = "0x1189C48")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x282CA78", Offset = "0x282CA78", VA = "0x282CA78", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189C80", Offset = "0x1189C80")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x282CAC4", Offset = "0x282CAC4", VA = "0x282CAC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189CB8", Offset = "0x1189CB8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x282CB10", Offset = "0x282CB10", VA = "0x282CB10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189CF0", Offset = "0x1189CF0")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x282CB5C", Offset = "0x282CB5C", VA = "0x282CB5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189D28", Offset = "0x1189D28")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x282CBA8", Offset = "0x282CBA8", VA = "0x282CBA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189D60", Offset = "0x1189D60")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x282CBF4", Offset = "0x282CBF4", VA = "0x282CBF4")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x282CC18", Offset = "0x282CC18", VA = "0x282CC18", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x282CC20", Offset = "0x282CC20", VA = "0x282CC20")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x282CDD8", Offset = "0x282CDD8", VA = "0x282CDD8")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x282D128", Offset = "0x282D128", VA = "0x282D128")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189D98", Offset = "0x1189D98")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x282D148", Offset = "0x282D148", VA = "0x282D148")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189DD0", Offset = "0x1189DD0")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x282D1FC", Offset = "0x282D1FC", VA = "0x282D1FC")]
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
		[Address(RVA = "0x2746E2C", Offset = "0x2746E2C", VA = "0x2746E2C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2746F18", Offset = "0x2746F18", VA = "0x2746F18", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x27470DC", Offset = "0x27470DC", VA = "0x27470DC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001BE")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001BF")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x274713C", Offset = "0x274713C", VA = "0x274713C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183500", Offset = "0x1183500")]
		public IK[] IKComponents;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183538", Offset = "0x1183538")]
		public Animator animator;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700001E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x274A084", Offset = "0x274A084", VA = "0x274A084")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x274A120", Offset = "0x274A120", VA = "0x274A120")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x274A190", Offset = "0x274A190", VA = "0x274A190")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x274A24C", Offset = "0x274A24C", VA = "0x274A24C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x274A288", Offset = "0x274A288", VA = "0x274A288")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x274A1C4", Offset = "0x274A1C4", VA = "0x274A1C4")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x274A314", Offset = "0x274A314", VA = "0x274A314")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181A84", Offset = "0x1181A84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181A84", Offset = "0x1181A84")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x27EE7B0", Offset = "0x27EE7B0", VA = "0x27EE7B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189E08", Offset = "0x1189E08")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x27EE7FC", Offset = "0x27EE7FC", VA = "0x27EE7FC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189E40", Offset = "0x1189E40")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x27EE848", Offset = "0x27EE848", VA = "0x27EE848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189E78", Offset = "0x1189E78")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x27EE894", Offset = "0x27EE894", VA = "0x27EE894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189EB0", Offset = "0x1189EB0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x27EE8E0", Offset = "0x27EE8E0", VA = "0x27EE8E0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x27EE8E8", Offset = "0x27EE8E8", VA = "0x27EE8E8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181AE4", Offset = "0x1181AE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181AE4", Offset = "0x1181AE4")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x27EE950", Offset = "0x27EE950", VA = "0x27EE950", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189EE8", Offset = "0x1189EE8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x27EE99C", Offset = "0x27EE99C", VA = "0x27EE99C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189F20", Offset = "0x1189F20")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x27EE9E8", Offset = "0x27EE9E8", VA = "0x27EE9E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189F58", Offset = "0x1189F58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x27EEA34", Offset = "0x27EEA34", VA = "0x27EEA34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189F90", Offset = "0x1189F90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x27EEA80", Offset = "0x27EEA80", VA = "0x27EEA80", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x27EEA88", Offset = "0x27EEA88", VA = "0x27EEA88")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181B44", Offset = "0x1181B44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181B44", Offset = "0x1181B44")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x27EF958", Offset = "0x27EF958", VA = "0x27EF958", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1189FC8", Offset = "0x1189FC8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x27EF9A4", Offset = "0x27EF9A4", VA = "0x27EF9A4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A000", Offset = "0x118A000")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x27EF9F0", Offset = "0x27EF9F0", VA = "0x27EF9F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A038", Offset = "0x118A038")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x27EFA3C", Offset = "0x27EFA3C", VA = "0x27EFA3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A070", Offset = "0x118A070")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x27EFA88", Offset = "0x27EFA88", VA = "0x27EFA88", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x27EFA90", Offset = "0x27EFA90", VA = "0x27EFA90")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181BA4", Offset = "0x1181BA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181BA4", Offset = "0x1181BA4")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x29AD7A8", Offset = "0x29AD7A8", VA = "0x29AD7A8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A0A8", Offset = "0x118A0A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x29AD7F4", Offset = "0x29AD7F4", VA = "0x29AD7F4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A0E0", Offset = "0x118A0E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x29AD840", Offset = "0x29AD840", VA = "0x29AD840")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A118", Offset = "0x118A118")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x29AD88C", Offset = "0x29AD88C", VA = "0x29AD88C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A150", Offset = "0x118A150")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x29AD8D8", Offset = "0x29AD8D8", VA = "0x29AD8D8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x29AD8E0", Offset = "0x29AD8E0", VA = "0x29AD8E0")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181C04", Offset = "0x1181C04")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185F1C", Offset = "0x1185F1C")]
			public Transform chest;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185F54", Offset = "0x1185F54")]
			public Transform neck;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185F8C", Offset = "0x1185F8C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185FC4", Offset = "0x1185FC4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185FFC", Offset = "0x1185FFC")]
			public Transform leftThigh;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186034", Offset = "0x1186034")]
			public Transform leftCalf;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118606C", Offset = "0x118606C")]
			public Transform leftFoot;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11860A4", Offset = "0x11860A4")]
			public Transform leftToes;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11860DC", Offset = "0x11860DC")]
			public Transform rightThigh;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186114", Offset = "0x1186114")]
			public Transform rightCalf;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118614C", Offset = "0x118614C")]
			public Transform rightFoot;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186184", Offset = "0x1186184")]
			public Transform rightToes;

			[Token(Token = "0x170000AC")]
			public bool isFilled
			{
				[Token(Token = "0x600060D")]
				[Address(RVA = "0x29AF244", Offset = "0x29AF244", VA = "0x29AF244")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AD")]
			public bool isEmpty
			{
				[Token(Token = "0x600060E")]
				[Address(RVA = "0x29AEDC8", Offset = "0x29AEDC8", VA = "0x29AEDC8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x29AF8C8", Offset = "0x29AF8C8", VA = "0x29AF8C8")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x29AE9B4", Offset = "0x29AE9B4", VA = "0x29AE9B4")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x29AF8C0", Offset = "0x29AF8C0", VA = "0x29AF8C0")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x1183570", Offset = "0x1183570")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183570", Offset = "0x1183570")]
		public References references;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11835EC", Offset = "0x11835EC")]
		public IKSolverVR solver;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x29AE8A8", Offset = "0x29AE8A8", VA = "0x29AE8A8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A188", Offset = "0x118A188")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x29AE8F4", Offset = "0x29AE8F4", VA = "0x29AE8F4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A1C0", Offset = "0x118A1C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x29AE940", Offset = "0x29AE940", VA = "0x29AE940")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A1F8", Offset = "0x118A1F8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x29AE98C", Offset = "0x29AE98C", VA = "0x29AE98C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A230", Offset = "0x118A230")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x29AED24", Offset = "0x29AED24", VA = "0x29AED24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A268", Offset = "0x118A268")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x29AED4C", Offset = "0x29AED4C", VA = "0x29AED4C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x29AED54", Offset = "0x29AED54", VA = "0x29AED54", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x29AF6C0", Offset = "0x29AF6C0", VA = "0x29AF6C0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x29AF838", Offset = "0x29AF838", VA = "0x29AF838")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183624", Offset = "0x1183624")]
		public float pull;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118363C", Offset = "0x118363C")]
		public float pin;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x282414C", Offset = "0x282414C", VA = "0x282414C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2824214", Offset = "0x2824214", VA = "0x2824214")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2824234", Offset = "0x2824234", VA = "0x2824234")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2824604", Offset = "0x2824604", VA = "0x2824604")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2824308", Offset = "0x2824308", VA = "0x2824308")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x28246FC", Offset = "0x28246FC", VA = "0x28246FC")]
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
		[Address(RVA = "0x2824904", Offset = "0x2824904", VA = "0x2824904")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2824E6C", Offset = "0x2824E6C", VA = "0x2824E6C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x282502C", Offset = "0x282502C", VA = "0x282502C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2825124", Offset = "0x2825124", VA = "0x2825124")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11861BC", Offset = "0x11861BC")]
			public Transform transform;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11861F4", Offset = "0x11861F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11861F4", Offset = "0x11861F4")]
			public float weight;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x2828154", Offset = "0x2828154", VA = "0x2828154")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x28281D4", Offset = "0x28281D4", VA = "0x28281D4")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x28258E4", Offset = "0x28258E4", VA = "0x28258E4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x2825CE8", Offset = "0x2825CE8", VA = "0x2825CE8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183654", Offset = "0x1183654")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x118368C", Offset = "0x118368C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118368C", Offset = "0x118368C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118368C", Offset = "0x118368C")]
		public float positionWeight;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183704", Offset = "0x1183704")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183704", Offset = "0x1183704")]
		public float bodyWeight;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183758", Offset = "0x1183758")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183758", Offset = "0x1183758")]
		public float thighWeight;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11837AC", Offset = "0x11837AC")]
		public bool handsPullBody;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x11837E4", Offset = "0x11837E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11837E4", Offset = "0x11837E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11837E4", Offset = "0x11837E4")]
		public float rotationWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118385C", Offset = "0x118385C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118385C", Offset = "0x118385C")]
		public float bodyClampWeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11838B0", Offset = "0x11838B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11838B0", Offset = "0x11838B0")]
		public float headClampWeight;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183904", Offset = "0x1183904")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183904", Offset = "0x1183904")]
		public float bendWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183958", Offset = "0x1183958")]
		public BendBone[] bendBones;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1183990", Offset = "0x1183990")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183990", Offset = "0x1183990")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183990", Offset = "0x1183990")]
		public float CCDWeight;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183A08", Offset = "0x1183A08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183A08", Offset = "0x1183A08")]
		public float roll;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183A5C", Offset = "0x1183A5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183A5C", Offset = "0x1183A5C")]
		public float damper;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183AB4", Offset = "0x1183AB4")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1183AEC", Offset = "0x1183AEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183AEC", Offset = "0x1183AEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183AEC", Offset = "0x1183AEC")]
		public float postStretchWeight;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183B64", Offset = "0x1183B64")]
		public float maxStretch;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183B9C", Offset = "0x1183B9C")]
		public float stretchDamper;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183BD4", Offset = "0x1183BD4")]
		public bool fixHead;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183C0C", Offset = "0x1183C0C")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1183C44", Offset = "0x1183C44")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183C7C", Offset = "0x1183C7C")]
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
		[Address(RVA = "0x282512C", Offset = "0x282512C", VA = "0x282512C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x282545C", Offset = "0x282545C", VA = "0x282545C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x282591C", Offset = "0x282591C", VA = "0x282591C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2825D10", Offset = "0x2825D10", VA = "0x2825D10")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2826688", Offset = "0x2826688", VA = "0x2826688")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x28269D4", Offset = "0x28269D4", VA = "0x28269D4")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2826D70", Offset = "0x2826D70", VA = "0x2826D70")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x28277DC", Offset = "0x28277DC", VA = "0x28277DC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x28263B4", Offset = "0x28263B4", VA = "0x28263B4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x28279EC", Offset = "0x28279EC", VA = "0x28279EC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2827698", Offset = "0x2827698", VA = "0x2827698")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x28274FC", Offset = "0x28274FC", VA = "0x28274FC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2827D58", Offset = "0x2827D58", VA = "0x2827D58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2827FD8", Offset = "0x2827FD8", VA = "0x2827FD8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186268", Offset = "0x1186268")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186278", Offset = "0x1186278")]
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
				[Address(RVA = "0x282B098", Offset = "0x282B098", VA = "0x282B098")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF58", Offset = "0x118BF58")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x282B0A0", Offset = "0x282B0A0", VA = "0x282B0A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF68", Offset = "0x118BF68")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public bool isRigid
			{
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x282B0A8", Offset = "0x282B0A8", VA = "0x282B0A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF78", Offset = "0x118BF78")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000618")]
				[Address(RVA = "0x282B0B0", Offset = "0x282B0B0", VA = "0x282B0B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF88", Offset = "0x118BF88")]
				private set
				{
				}
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x282B0BC", Offset = "0x282B0BC", VA = "0x282B0BC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x2828E1C", Offset = "0x2828E1C", VA = "0x2828E1C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x282935C", Offset = "0x282935C", VA = "0x282935C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x282AD94", Offset = "0x282AD94", VA = "0x282AD94")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183C94", Offset = "0x1183C94")]
		public float pin;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183CAC", Offset = "0x1183CAC")]
		public float pull;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183CC4", Offset = "0x1183CC4")]
		public float push;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183CDC", Offset = "0x1183CDC")]
		public float pushParent;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183CF4", Offset = "0x1183CF4")]
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
		[Address(RVA = "0x2828278", Offset = "0x2828278", VA = "0x2828278")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2828344", Offset = "0x2828344", VA = "0x2828344")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2828450", Offset = "0x2828450", VA = "0x2828450")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2828574", Offset = "0x2828574", VA = "0x2828574")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2828650", Offset = "0x2828650", VA = "0x2828650")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2828754", Offset = "0x2828754", VA = "0x2828754")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2828E74", Offset = "0x2828E74", VA = "0x2828E74")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x28288E4", Offset = "0x28288E4", VA = "0x28288E4")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2829560", Offset = "0x2829560", VA = "0x2829560")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2829904", Offset = "0x2829904", VA = "0x2829904")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2829CE8", Offset = "0x2829CE8", VA = "0x2829CE8")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x282A26C", Offset = "0x282A26C", VA = "0x282A26C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x282A83C", Offset = "0x282A83C", VA = "0x282A83C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x282AAD4", Offset = "0x282AAD4", VA = "0x282AAD4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x282A734", Offset = "0x282A734", VA = "0x282A734")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x282A054", Offset = "0x282A054", VA = "0x282A054")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x282A6BC", Offset = "0x282A6BC", VA = "0x282A6BC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x282ABBC", Offset = "0x282ABBC", VA = "0x282ABBC")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x282A5DC", Offset = "0x282A5DC", VA = "0x282A5DC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x282A9BC", Offset = "0x282A9BC", VA = "0x282A9BC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183D0C", Offset = "0x1183D0C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183D24", Offset = "0x1183D24")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700001F")]
		public bool initiated
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x274730C", Offset = "0x274730C", VA = "0x274730C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A2A0", Offset = "0x118A2A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x2747314", Offset = "0x2747314", VA = "0x2747314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A2B0", Offset = "0x118A2B0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2747144", Offset = "0x2747144", VA = "0x2747144")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2747320", Offset = "0x2747320", VA = "0x2747320")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x27473A4", Offset = "0x27473A4", VA = "0x27473A4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2747450", Offset = "0x2747450", VA = "0x2747450")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x274745C", Offset = "0x274745C", VA = "0x274745C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x274794C", Offset = "0x274794C", VA = "0x274794C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2747B84", Offset = "0x2747B84", VA = "0x2747B84")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2748020", Offset = "0x2748020", VA = "0x2748020")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x274770C", Offset = "0x274770C", VA = "0x274770C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x274782C", Offset = "0x274782C", VA = "0x274782C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183D34", Offset = "0x1183D34")]
		public float positionWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183D4C", Offset = "0x1183D4C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183D64", Offset = "0x1183D64")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183D74", Offset = "0x1183D74")]
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
			[Address(RVA = "0x274868C", Offset = "0x274868C", VA = "0x274868C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A2C0", Offset = "0x118A2C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2748694", Offset = "0x2748694", VA = "0x2748694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A2D0", Offset = "0x118A2D0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2748624", Offset = "0x2748624", VA = "0x2748624")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x27486A0", Offset = "0x27486A0", VA = "0x27486A0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2748774", Offset = "0x2748774", VA = "0x2748774")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x27488B0", Offset = "0x27488B0", VA = "0x27488B0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2748A08", Offset = "0x2748A08", VA = "0x2748A08")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2748CF8", Offset = "0x2748CF8", VA = "0x2748CF8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2748F98", Offset = "0x2748F98", VA = "0x2748F98")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x27490D8", Offset = "0x27490D8", VA = "0x27490D8")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2749184", Offset = "0x2749184", VA = "0x2749184")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x27497D8", Offset = "0x27497D8", VA = "0x27497D8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2749848", Offset = "0x2749848", VA = "0x2749848")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2749A60", Offset = "0x2749A60", VA = "0x2749A60")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2749DA8", Offset = "0x2749DA8", VA = "0x2749DA8")]
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
				[Address(RVA = "0x274A588", Offset = "0x274A588", VA = "0x274A588")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B1")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x274A6F4", Offset = "0x274A6F4", VA = "0x274A6F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B2")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x274ACD8", Offset = "0x274ACD8", VA = "0x274ACD8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x274A55C", Offset = "0x274A55C", VA = "0x274A55C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x274A654", Offset = "0x274A654", VA = "0x274A654")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x274A6A4", Offset = "0x274A6A4", VA = "0x274A6A4")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x274A704", Offset = "0x274A704", VA = "0x274A704")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x274A7EC", Offset = "0x274A7EC", VA = "0x274A7EC")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x274A7F4", Offset = "0x274A7F4", VA = "0x274A7F4")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x274A984", Offset = "0x274A984", VA = "0x274A984")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x274AA90", Offset = "0x274AA90", VA = "0x274AA90")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x274AB28", Offset = "0x274AB28", VA = "0x274AB28")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x274AEFC", Offset = "0x274AEFC", VA = "0x274AEFC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x274AF34", Offset = "0x274AF34", VA = "0x274AF34")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x274AF6C", Offset = "0x274AF6C", VA = "0x274AF6C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x274AF94", Offset = "0x274AF94", VA = "0x274AF94")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x274B0C0", Offset = "0x274B0C0", VA = "0x274B0C0")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x274B408", Offset = "0x274B408", VA = "0x274B408")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x274B438", Offset = "0x274B438", VA = "0x274B438")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x274B5D0", Offset = "0x274B5D0", VA = "0x274B5D0")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x274B640", Offset = "0x274B640", VA = "0x274B640")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x274B884", Offset = "0x274B884", VA = "0x274B884")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x274BAAC", Offset = "0x274BAAC", VA = "0x274BAAC")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x274BBC4", Offset = "0x274BBC4", VA = "0x274BBC4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x274B204", Offset = "0x274B204", VA = "0x274B204")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x274BD60", Offset = "0x274BD60", VA = "0x274BD60")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x274A31C", Offset = "0x274A31C", VA = "0x274A31C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x274A324", Offset = "0x274A324", VA = "0x274A324", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x274A328", Offset = "0x274A328", VA = "0x274A328")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x274A44C", Offset = "0x274A44C", VA = "0x274A44C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x274A554", Offset = "0x274A554", VA = "0x274A554")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183D8C", Offset = "0x1183D8C")]
		public float maintainRotationWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x274BD7C", Offset = "0x274BD7C", VA = "0x274BD7C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x274BE1C", Offset = "0x274BE1C", VA = "0x274BE1C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x274BEA0", Offset = "0x274BEA0", VA = "0x274BEA0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x274BF38", Offset = "0x274BF38", VA = "0x274BF38")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x274BF50", Offset = "0x274BF50", VA = "0x274BF50")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x274BF6C", Offset = "0x274BF6C", VA = "0x274BF6C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x274C008", Offset = "0x274C008", VA = "0x274C008")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x274C020", Offset = "0x274C020", VA = "0x274C020")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183DA4", Offset = "0x1183DA4")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183DBC", Offset = "0x1183DBC")]
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
		[Address(RVA = "0x274C044", Offset = "0x274C044", VA = "0x274C044", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x274C0C8", Offset = "0x274C0C8", VA = "0x274C0C8")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x274C19C", Offset = "0x274C19C", VA = "0x274C19C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x274C4F0", Offset = "0x274C4F0", VA = "0x274C4F0")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x274C5F8", Offset = "0x274C5F8", VA = "0x274C5F8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x274C72C", Offset = "0x274C72C", VA = "0x274C72C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x274C738", Offset = "0x274C738", VA = "0x274C738")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x274C7E0", Offset = "0x274C7E0", VA = "0x274C7E0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x274C898", Offset = "0x274C898", VA = "0x274C898", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x274CB08", Offset = "0x274CB08", VA = "0x274CB08")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x274CBC0", Offset = "0x274CBC0", VA = "0x274CBC0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183DD4", Offset = "0x1183DD4")]
		public int iterations;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183DEC", Offset = "0x1183DEC")]
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
		[Address(RVA = "0x274CD2C", Offset = "0x274CD2C", VA = "0x274CD2C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x274D01C", Offset = "0x274D01C", VA = "0x274D01C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x274D138", Offset = "0x274D138", VA = "0x274D138")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x274D290", Offset = "0x274D290", VA = "0x274D290")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x274D2A0", Offset = "0x274D2A0", VA = "0x274D2A0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x274D308", Offset = "0x274D308", VA = "0x274D308")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x274D388", Offset = "0x274D388", VA = "0x274D388", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x274D9DC", Offset = "0x274D9DC", VA = "0x274D9DC")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x274DA14", Offset = "0x274DA14", VA = "0x274DA14")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x274DCF4", Offset = "0x274DCF4", VA = "0x274DCF4")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x274E0A8", Offset = "0x274E0A8", VA = "0x274E0A8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x274E194", Offset = "0x274E194", VA = "0x274E194")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x274E25C", Offset = "0x274E25C", VA = "0x274E25C")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186288", Offset = "0x1186288")]
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
			[Address(RVA = "0x274FD84", Offset = "0x274FD84", VA = "0x274FD84")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x274FDD4", Offset = "0x274FDD4", VA = "0x274FDD4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x274FF5C", Offset = "0x274FF5C", VA = "0x274FF5C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x274FF94", Offset = "0x274FF94", VA = "0x274FF94")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x274FFCC", Offset = "0x274FFCC", VA = "0x274FFCC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x275001C", Offset = "0x275001C", VA = "0x275001C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x274F858", Offset = "0x274F858", VA = "0x274F858")]
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
				[Address(RVA = "0x274EE28", Offset = "0x274EE28", VA = "0x274EE28")]
				get
				{
					return null;
				}
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x274EF1C", Offset = "0x274EF1C", VA = "0x274EF1C")]
				set
				{
				}
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x274EFA4", Offset = "0x274EFA4", VA = "0x274EFA4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x274F264", Offset = "0x274F264", VA = "0x274F264")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x274F544", Offset = "0x274F544", VA = "0x274F544")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x274F7AC", Offset = "0x274F7AC", VA = "0x274F7AC")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x274F7D4", Offset = "0x274F7D4", VA = "0x274F7D4")]
			public Bone()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x274F8D8", Offset = "0x274F8D8", VA = "0x274F8D8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x274F970", Offset = "0x274F970", VA = "0x274F970")]
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
			[Address(RVA = "0x274FD20", Offset = "0x274FD20", VA = "0x274FD20")]
			public Node()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x274FD24", Offset = "0x274FD24", VA = "0x274FD24")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x274FD4C", Offset = "0x274FD4C", VA = "0x274FD4C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183E24", Offset = "0x1183E24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183E24", Offset = "0x1183E24")]
		public float IKPositionWeight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183E78", Offset = "0x1183E78")]
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
			[Address(RVA = "0x274E878", Offset = "0x274E878", VA = "0x274E878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A2E0", Offset = "0x118A2E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x274E880", Offset = "0x274E880", VA = "0x274E880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A2F0", Offset = "0x118A2F0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x274E544", Offset = "0x274E544", VA = "0x274E544")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2746F88", Offset = "0x2746F88", VA = "0x2746F88")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2746EB0", Offset = "0x2746EB0", VA = "0x2746EB0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x274E7CC", Offset = "0x274E7CC", VA = "0x274E7CC", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x274E7D8", Offset = "0x274E7D8", VA = "0x274E7D8")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x274E7E4", Offset = "0x274E7E4", VA = "0x274E7E4")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x274E7EC", Offset = "0x274E7EC", VA = "0x274E7EC")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x274E870", Offset = "0x274E870", VA = "0x274E870")]
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
		[Address(RVA = "0x274E88C", Offset = "0x274E88C", VA = "0x274E88C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x274E8A4", Offset = "0x274E8A4", VA = "0x274E8A4")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x274E9E0", Offset = "0x274E9E0", VA = "0x274E9E0")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x274EA8C", Offset = "0x274EA8C", VA = "0x274EA8C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x274EE10", Offset = "0x274EE10", VA = "0x274EE10")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183EC0", Offset = "0x1183EC0")]
		public float poleWeight;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183ED8", Offset = "0x1183ED8")]
		public float clampWeight;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183EF0", Offset = "0x1183EF0")]
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
			[Address(RVA = "0x27501A4", Offset = "0x27501A4", VA = "0x27501A4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000023")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2750270", Offset = "0x2750270", VA = "0x2750270")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000024")]
		protected override int minBones
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x2750FE0", Offset = "0x2750FE0", VA = "0x2750FE0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2751584", Offset = "0x2751584", VA = "0x2751584", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x27500A4", Offset = "0x27500A4", VA = "0x27500A4")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x275033C", Offset = "0x275033C", VA = "0x275033C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x27505BC", Offset = "0x27505BC", VA = "0x27505BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2750F2C", Offset = "0x2750F2C", VA = "0x2750F2C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2750B54", Offset = "0x2750B54", VA = "0x2750B54")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2750FE8", Offset = "0x2750FE8", VA = "0x2750FE8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x27515F8", Offset = "0x27515F8", VA = "0x27515F8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183F08", Offset = "0x1183F08")]
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
		[Address(RVA = "0x2751690", Offset = "0x2751690", VA = "0x2751690", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2751A04", Offset = "0x2751A04", VA = "0x2751A04")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2751A70", Offset = "0x2751A70", VA = "0x2751A70", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2751BCC", Offset = "0x2751BCC", VA = "0x2751BCC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2751D64", Offset = "0x2751D64", VA = "0x2751D64", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2751DB0", Offset = "0x2751DB0", VA = "0x2751DB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2751E10", Offset = "0x2751E10", VA = "0x2751E10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2752180", Offset = "0x2752180", VA = "0x2752180", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x27521AC", Offset = "0x27521AC", VA = "0x27521AC")]
		private void Solve()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2751E74", Offset = "0x2751E74", VA = "0x2751E74")]
		private void Read()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x275221C", Offset = "0x275221C", VA = "0x275221C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x27523A8", Offset = "0x27523A8", VA = "0x27523A8")]
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
		[Address(RVA = "0x27B085C", Offset = "0x27B085C", VA = "0x27B085C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x27B090C", Offset = "0x27B090C", VA = "0x27B090C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x27B0F0C", Offset = "0x27B0F0C", VA = "0x27B0F0C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x27B166C", Offset = "0x27B166C", VA = "0x27B166C")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x27B1DD0", Offset = "0x27B1DD0", VA = "0x27B1DD0")]
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
			[Address(RVA = "0x27B305C", Offset = "0x27B305C", VA = "0x27B305C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x27B1E44", Offset = "0x27B1E44", VA = "0x27B1E44")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x27B2588", Offset = "0x27B2588", VA = "0x27B2588")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x27B26BC", Offset = "0x27B26BC", VA = "0x27B26BC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x27B2754", Offset = "0x27B2754", VA = "0x27B2754", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x27B2CF8", Offset = "0x27B2CF8", VA = "0x27B2CF8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x27B3064", Offset = "0x27B3064", VA = "0x27B3064")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x27B1F14", Offset = "0x27B1F14", VA = "0x27B1F14")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x27B2668", Offset = "0x27B2668", VA = "0x27B2668")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x27B3000", Offset = "0x27B3000", VA = "0x27B3000")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x27B23B0", Offset = "0x27B23B0", VA = "0x27B23B0")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x27B38AC", Offset = "0x27B38AC", VA = "0x27B38AC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x27B39BC", Offset = "0x27B39BC", VA = "0x27B39BC")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x27B3AE8", Offset = "0x27B3AE8", VA = "0x27B3AE8")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x27B3C00", Offset = "0x27B3C00", VA = "0x27B3C00")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x27B2A60", Offset = "0x27B2A60", VA = "0x27B2A60")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x27B2BAC", Offset = "0x27B2BAC", VA = "0x27B2BAC")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x27B3DEC", Offset = "0x27B3DEC", VA = "0x27B3DEC")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x27B3320", Offset = "0x27B3320", VA = "0x27B3320")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x27B2658", Offset = "0x27B2658", VA = "0x27B2658")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x27B455C", Offset = "0x27B455C", VA = "0x27B455C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x27B3FC4", Offset = "0x27B3FC4", VA = "0x27B3FC4")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x27B317C", Offset = "0x27B317C", VA = "0x27B317C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x27B325C", Offset = "0x27B325C", VA = "0x27B325C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x27B4628", Offset = "0x27B4628", VA = "0x27B4628")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183F20", Offset = "0x1183F20")]
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
		[Address(RVA = "0x27B469C", Offset = "0x27B469C", VA = "0x27B469C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x27B4F68", Offset = "0x27B4F68", VA = "0x27B4F68", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x27B5000", Offset = "0x27B5000", VA = "0x27B5000", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x27B50A0", Offset = "0x27B50A0", VA = "0x27B50A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x27B51A0", Offset = "0x27B51A0", VA = "0x27B51A0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x27B523C", Offset = "0x27B523C", VA = "0x27B523C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x27B57A4", Offset = "0x27B57A4", VA = "0x27B57A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x27B59A4", Offset = "0x27B59A4", VA = "0x27B59A4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x27B5854", Offset = "0x27B5854", VA = "0x27B5854")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x27B5470", Offset = "0x27B5470", VA = "0x27B5470")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x27B5A3C", Offset = "0x27B5A3C", VA = "0x27B5A3C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183F38", Offset = "0x1183F38")]
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
		[Address(RVA = "0x27B5AA4", Offset = "0x27B5AA4", VA = "0x27B5AA4")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x27B5B98", Offset = "0x27B5B98", VA = "0x27B5B98")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x27B5BF4", Offset = "0x27B5BF4", VA = "0x27B5BF4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x27B5D28", Offset = "0x27B5D28", VA = "0x27B5D28")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x27B5D84", Offset = "0x27B5D84", VA = "0x27B5D84")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x27B5E04", Offset = "0x27B5E04", VA = "0x27B5E04", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x27B5FAC", Offset = "0x27B5FAC", VA = "0x27B5FAC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x27B6120", Offset = "0x27B6120", VA = "0x27B6120", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x27B6324", Offset = "0x27B6324", VA = "0x27B6324", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x27B63FC", Offset = "0x27B63FC", VA = "0x27B63FC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x27B64E8", Offset = "0x27B64E8", VA = "0x27B64E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x27B665C", Offset = "0x27B665C", VA = "0x27B665C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x27B6824", Offset = "0x27B6824", VA = "0x27B6824", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x27B6A70", Offset = "0x27B6A70", VA = "0x27B6A70", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x27B6D4C", Offset = "0x27B6D4C", VA = "0x27B6D4C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x27B6D90", Offset = "0x27B6D90", VA = "0x27B6D90", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x27B6E80", Offset = "0x27B6E80", VA = "0x27B6E80")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183F50", Offset = "0x1183F50")]
		public float spineStiffness;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183F68", Offset = "0x1183F68")]
		public float pullBodyVertical;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183F80", Offset = "0x1183F80")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183F98", Offset = "0x1183F98")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000027")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x27B6F58", Offset = "0x27B6F58", VA = "0x27B6F58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x27B70A0", Offset = "0x27B70A0", VA = "0x27B70A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x27B70A8", Offset = "0x27B70A8", VA = "0x27B70A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x27B70B0", Offset = "0x27B70B0", VA = "0x27B70B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x27B70B8", Offset = "0x27B70B8", VA = "0x27B70B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x27B70C0", Offset = "0x27B70C0", VA = "0x27B70C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x27B70C8", Offset = "0x27B70C8", VA = "0x27B70C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x27B70D0", Offset = "0x27B70D0", VA = "0x27B70D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x27B70D8", Offset = "0x27B70D8", VA = "0x27B70D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x27B70E0", Offset = "0x27B70E0", VA = "0x27B70E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x27B7118", Offset = "0x27B7118", VA = "0x27B7118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x27B7150", Offset = "0x27B7150", VA = "0x27B7150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x27B7188", Offset = "0x27B7188", VA = "0x27B7188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x27B71C0", Offset = "0x27B71C0", VA = "0x27B71C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x27B71F4", Offset = "0x27B71F4", VA = "0x27B71F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x27B722C", Offset = "0x27B722C", VA = "0x27B722C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x27B7264", Offset = "0x27B7264", VA = "0x27B7264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x27B729C", Offset = "0x27B729C", VA = "0x27B729C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x27B9260", Offset = "0x27B9260", VA = "0x27B9260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A300", Offset = "0x118A300")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x27B926C", Offset = "0x27B926C", VA = "0x27B926C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A310", Offset = "0x118A310")]
			private set
			{
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x27B72D0", Offset = "0x27B72D0", VA = "0x27B72D0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x27B73DC", Offset = "0x27B73DC", VA = "0x27B73DC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x27B7324", Offset = "0x27B7324", VA = "0x27B7324")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x27B74B8", Offset = "0x27B74B8", VA = "0x27B74B8")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x27B6F60", Offset = "0x27B6F60", VA = "0x27B6F60")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x27B7588", Offset = "0x27B7588", VA = "0x27B7588")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x27B7640", Offset = "0x27B7640", VA = "0x27B7640")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x27B76F4", Offset = "0x27B76F4", VA = "0x27B76F4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x27B77A8", Offset = "0x27B77A8", VA = "0x27B77A8")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x27B77B0", Offset = "0x27B77B0", VA = "0x27B77B0")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x27B77E4", Offset = "0x27B77E4", VA = "0x27B77E4")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x27B78AC", Offset = "0x27B78AC", VA = "0x27B78AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x27B7A3C", Offset = "0x27B7A3C", VA = "0x27B7A3C")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x27B8B78", Offset = "0x27B8B78", VA = "0x27B8B78")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x27B900C", Offset = "0x27B900C", VA = "0x27B900C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x27B906C", Offset = "0x27B906C", VA = "0x27B906C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x27B8E8C", Offset = "0x27B8E8C", VA = "0x27B8E8C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x27B8F4C", Offset = "0x27B8F4C", VA = "0x27B8F4C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x27B9278", Offset = "0x27B9278", VA = "0x27B9278")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x27B9354", Offset = "0x27B9354", VA = "0x27B9354", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x27B949C", Offset = "0x27B949C", VA = "0x27B949C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x27B962C", Offset = "0x27B962C", VA = "0x27B962C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x27B982C", Offset = "0x27B982C", VA = "0x27B982C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x27B9A2C", Offset = "0x27B9A2C", VA = "0x27B9A2C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x27B9D60", Offset = "0x27B9D60", VA = "0x27B9D60", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x27B9E60", Offset = "0x27B9E60", VA = "0x27B9E60")]
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
			[Address(RVA = "0x27BA6B0", Offset = "0x27BA6B0", VA = "0x27BA6B0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x27BA6B8", Offset = "0x27BA6B8", VA = "0x27BA6B8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x27BA6C0", Offset = "0x27BA6C0", VA = "0x27BA6C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x27BA6D0", Offset = "0x27BA6D0", VA = "0x27BA6D0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected float positionOffset
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x27B15A8", Offset = "0x27B15A8", VA = "0x27B15A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x27B9E6C", Offset = "0x27B9E6C", VA = "0x27B9E6C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x27BA000", Offset = "0x27BA000", VA = "0x27BA000")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x27BA13C", Offset = "0x27BA13C", VA = "0x27BA13C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x27BA1A8", Offset = "0x27BA1A8", VA = "0x27BA1A8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x27BA228", Offset = "0x27BA228", VA = "0x27BA228", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x27BA5B4", Offset = "0x27BA5B4", VA = "0x27BA5B4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x27BA5BC", Offset = "0x27BA5BC", VA = "0x27BA5BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x27BA6C8", Offset = "0x27BA6C8", VA = "0x27BA6C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x27BA6CC", Offset = "0x27BA6CC", VA = "0x27BA6CC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x27B098C", Offset = "0x27B098C", VA = "0x27B098C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x27B1204", Offset = "0x27B1204", VA = "0x27B1204")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x27BA804", Offset = "0x27BA804", VA = "0x27BA804")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x27B1DD4", Offset = "0x27B1DD4", VA = "0x27B1DD4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183FA8", Offset = "0x1183FA8")]
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
		[Address(RVA = "0x27BAAB8", Offset = "0x27BAAB8", VA = "0x27BAAB8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x27BAE2C", Offset = "0x27BAE2C", VA = "0x27BAE2C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x27BAE9C", Offset = "0x27BAE9C", VA = "0x27BAE9C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x27BAFF8", Offset = "0x27BAFF8", VA = "0x27BAFF8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x27BB190", Offset = "0x27BB190", VA = "0x27BB190", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x27BB1EC", Offset = "0x27BB1EC", VA = "0x27BB1EC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x27BB25C", Offset = "0x27BB25C", VA = "0x27BB25C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x27BB5CC", Offset = "0x27BB5CC", VA = "0x27BB5CC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x27BB5F8", Offset = "0x27BB5F8", VA = "0x27BB5F8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x27BB2C0", Offset = "0x27BB2C0", VA = "0x27BB2C0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x27BB704", Offset = "0x27BB704", VA = "0x27BB704")]
		private void Write()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x27BB890", Offset = "0x27BB890", VA = "0x27BB890")]
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
			[Address(RVA = "0x27BD108", Offset = "0x27BD108", VA = "0x27BD108")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183FC0", Offset = "0x1183FC0")]
		public float maintainRotationWeight;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183FD8", Offset = "0x1183FD8")]
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
			[Address(RVA = "0x27BD0EC", Offset = "0x27BD0EC", VA = "0x27BD0EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x27BB9E8", Offset = "0x27BB9E8", VA = "0x27BB9E8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x27BBA38", Offset = "0x27BBA38", VA = "0x27BBA38")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x27BBB4C", Offset = "0x27BBB4C", VA = "0x27BBB4C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x27BC1BC", Offset = "0x27BC1BC", VA = "0x27BC1BC", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x27BCD98", Offset = "0x27BCD98", VA = "0x27BCD98", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x27BCEE0", Offset = "0x27BCEE0", VA = "0x27BCEE0")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x27BD064", Offset = "0x27BD064", VA = "0x27BD064")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x27BBEC8", Offset = "0x27BBEC8", VA = "0x27BBEC8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x27BC2E8", Offset = "0x27BC2E8", VA = "0x27BC2E8")]
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
				[Address(RVA = "0x27BF1B8", Offset = "0x27BF1B8", VA = "0x27BF1B8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x27BF904", Offset = "0x27BF904", VA = "0x27BF904")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x27BE354", Offset = "0x27BE354", VA = "0x27BE354")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x27BE690", Offset = "0x27BE690", VA = "0x27BE690")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x27BF5BC", Offset = "0x27BF5BC", VA = "0x27BF5BC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183FF0", Offset = "0x1183FF0")]
		public float bodyWeight;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184008", Offset = "0x1184008")]
		public float headWeight;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184020", Offset = "0x1184020")]
		public float eyesWeight;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184038", Offset = "0x1184038")]
		public float clampWeight;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184050", Offset = "0x1184050")]
		public float clampWeightHead;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184068", Offset = "0x1184068")]
		public float clampWeightEyes;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184080", Offset = "0x1184080")]
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
			[Address(RVA = "0x27BDAB8", Offset = "0x27BDAB8", VA = "0x27BDAB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x27BDC90", Offset = "0x27BDC90", VA = "0x27BDC90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x27BDB9C", Offset = "0x27BDB9C", VA = "0x27BDB9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x27BDCB4", Offset = "0x27BDCB4", VA = "0x27BDCB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x27BDBAC", Offset = "0x27BDBAC", VA = "0x27BDBAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x27BDD30", Offset = "0x27BDD30", VA = "0x27BDD30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x27BD168", Offset = "0x27BD168", VA = "0x27BD168")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x27BD1EC", Offset = "0x27BD1EC", VA = "0x27BD1EC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x27BD298", Offset = "0x27BD298", VA = "0x27BD298")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x27BD360", Offset = "0x27BD360", VA = "0x27BD360")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x27BD44C", Offset = "0x27BD44C", VA = "0x27BD44C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x27BD558", Offset = "0x27BD558", VA = "0x27BD558")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x27BD6A0", Offset = "0x27BD6A0", VA = "0x27BD6A0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x27BD7D0", Offset = "0x27BD7D0", VA = "0x27BD7D0")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x27BD7DC", Offset = "0x27BD7DC", VA = "0x27BD7DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x27BD924", Offset = "0x27BD924", VA = "0x27BD924", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x27BDD54", Offset = "0x27BDD54", VA = "0x27BDD54", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x27BDF8C", Offset = "0x27BDF8C", VA = "0x27BDF8C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x27BE12C", Offset = "0x27BE12C", VA = "0x27BE12C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x27BE380", Offset = "0x27BE380", VA = "0x27BE380", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x27BE7CC", Offset = "0x27BE7CC", VA = "0x27BE7CC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x27BE8D0", Offset = "0x27BE8D0", VA = "0x27BE8D0")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x27BEAFC", Offset = "0x27BEAFC", VA = "0x27BEAFC")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x27BED58", Offset = "0x27BED58", VA = "0x27BED58")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x27BF284", Offset = "0x27BF284", VA = "0x27BF284")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x27BE1DC", Offset = "0x27BE1DC", VA = "0x27BE1DC")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x27BF724", Offset = "0x27BF724", VA = "0x27BF724")]
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
			[Address(RVA = "0x27C0EDC", Offset = "0x27C0EDC", VA = "0x27C0EDC")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x27C1A94", Offset = "0x27C1A94", VA = "0x27C1A94")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x27BBA80", Offset = "0x27BBA80", VA = "0x27BBA80")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x27C1B5C", Offset = "0x27C1B5C", VA = "0x27C1B5C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184098", Offset = "0x1184098")]
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
		[Address(RVA = "0x27BF90C", Offset = "0x27BF90C", VA = "0x27BF90C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x27BFAFC", Offset = "0x27BFAFC", VA = "0x27BFAFC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x27BFCB0", Offset = "0x27BFCB0", VA = "0x27BFCB0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x27BFCBC", Offset = "0x27BFCBC", VA = "0x27BFCBC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x27BFD40", Offset = "0x27BFD40", VA = "0x27BFD40")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x27BFD4C", Offset = "0x27BFD4C", VA = "0x27BFD4C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x27BFD54", Offset = "0x27BFD54", VA = "0x27BFD54", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x27BFE58", Offset = "0x27BFE58", VA = "0x27BFE58", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x27BFF78", Offset = "0x27BFF78", VA = "0x27BFF78", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x27BFFC4", Offset = "0x27BFFC4", VA = "0x27BFFC4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x27C0024", Offset = "0x27C0024", VA = "0x27C0024", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x27C0400", Offset = "0x27C0400", VA = "0x27C0400")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x27C0458", Offset = "0x27C0458", VA = "0x27C0458")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x27C0A00", Offset = "0x27C0A00", VA = "0x27C0A00")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x27C0C18", Offset = "0x27C0C18", VA = "0x27C0C18", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x27C0DD4", Offset = "0x27C0DD4", VA = "0x27C0DD4")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x27C0D50", Offset = "0x27C0D50", VA = "0x27C0D50")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x27C107C", Offset = "0x27C107C", VA = "0x27C107C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x27C1B50", Offset = "0x27C1B50", VA = "0x27C1B50", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x27C1B54", Offset = "0x27C1B54", VA = "0x27C1B54", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x27C1B58", Offset = "0x27C1B58", VA = "0x27C1B58", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x27C1788", Offset = "0x27C1788", VA = "0x27C1788")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x27BCF54", Offset = "0x27BCF54", VA = "0x27BCF54")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11862A0", Offset = "0x11862A0")]
			public Transform target;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11862D8", Offset = "0x11862D8")]
			public Transform bendGoal;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186310", Offset = "0x1186310")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186310", Offset = "0x1186310")]
			public float positionWeight;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186364", Offset = "0x1186364")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186364", Offset = "0x1186364")]
			public float rotationWeight;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11863B8", Offset = "0x11863B8")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11863F0", Offset = "0x11863F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11863F0", Offset = "0x11863F0")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186444", Offset = "0x1186444")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186444", Offset = "0x1186444")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186498", Offset = "0x1186498")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186498", Offset = "0x1186498")]
			public float bendGoalWeight;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11864EC", Offset = "0x11864EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11864EC", Offset = "0x11864EC")]
			public float swivelOffset;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186548", Offset = "0x1186548")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186580", Offset = "0x1186580")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11865B8", Offset = "0x11865B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11865B8", Offset = "0x11865B8")]
			public float armLengthMlp;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186610", Offset = "0x1186610")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186688", Offset = "0x1186688")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186698", Offset = "0x1186698")]
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
				[Address(RVA = "0x27C7668", Offset = "0x27C7668", VA = "0x27C7668")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BF98", Offset = "0x118BF98")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600065D")]
				[Address(RVA = "0x27C7674", Offset = "0x27C7674", VA = "0x27C7674")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BFA8", Offset = "0x118BFA8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			public Quaternion rotation
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x27C7680", Offset = "0x27C7680", VA = "0x27C7680")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BFB8", Offset = "0x118BFB8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x27C768C", Offset = "0x27C768C", VA = "0x27C768C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BFC8", Offset = "0x118BFC8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x27C7698", Offset = "0x27C7698", VA = "0x27C7698")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000661")]
				[Address(RVA = "0x27C76CC", Offset = "0x27C76CC", VA = "0x27C76CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x27C770C", Offset = "0x27C770C", VA = "0x27C770C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x27C7758", Offset = "0x27C7758", VA = "0x27C7758")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x27C77A4", Offset = "0x27C77A4", VA = "0x27C77A4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x27C8124", Offset = "0x27C8124", VA = "0x27C8124", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x27C8318", Offset = "0x27C8318", VA = "0x27C8318", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x27C83C4", Offset = "0x27C83C4", VA = "0x27C83C4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x27C57EC", Offset = "0x27C57EC", VA = "0x27C57EC")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x27C8E6C", Offset = "0x27C8E6C", VA = "0x27C8E6C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x27C8EDC", Offset = "0x27C8EDC", VA = "0x27C8EDC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x27C87DC", Offset = "0x27C87DC", VA = "0x27C87DC")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x27C88B4", Offset = "0x27C88B4", VA = "0x27C88B4")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x27C90FC", Offset = "0x27C90FC", VA = "0x27C90FC")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x27C753C", Offset = "0x27C753C", VA = "0x27C753C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866A8", Offset = "0x11866A8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866B8", Offset = "0x11866B8")]
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
				[Address(RVA = "0x27D91F8", Offset = "0x27D91F8", VA = "0x27D91F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BFD8", Offset = "0x118BFD8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000675")]
				[Address(RVA = "0x27D9200", Offset = "0x27D9200", VA = "0x27D9200")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BFE8", Offset = "0x118BFE8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			public float mag
			{
				[Token(Token = "0x6000676")]
				[Address(RVA = "0x27D9208", Offset = "0x27D9208", VA = "0x27D9208")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118BFF8", Offset = "0x118BFF8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000677")]
				[Address(RVA = "0x27D9210", Offset = "0x27D9210", VA = "0x27D9210")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C008", Offset = "0x118C008")]
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
			[Address(RVA = "0x27D9218", Offset = "0x27D9218", VA = "0x27D9218")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x27D9220", Offset = "0x27D9220", VA = "0x27D9220")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x27D95DC", Offset = "0x27D95DC", VA = "0x27D95DC")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x27D9748", Offset = "0x27D9748", VA = "0x27D9748")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x27D99D8", Offset = "0x27D99D8", VA = "0x27D99D8")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x27D9A2C", Offset = "0x27D9A2C", VA = "0x27D9A2C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x27D9C18", Offset = "0x27D9C18", VA = "0x27D9C18")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x27D9DB8", Offset = "0x27D9DB8", VA = "0x27D9DB8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x27D9EFC", Offset = "0x27D9EFC", VA = "0x27D9EFC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x27D9F24", Offset = "0x27D9F24", VA = "0x27D9F24")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866D8", Offset = "0x11866D8")]
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
				[Address(RVA = "0x27D9FBC", Offset = "0x27D9FBC", VA = "0x27D9FBC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BE")]
			public float stepProgress
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x27D9FD0", Offset = "0x27D9FD0", VA = "0x27D9FD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C018", Offset = "0x118C018")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x27D9FD8", Offset = "0x27D9FD8", VA = "0x27D9FD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C028", Offset = "0x118C028")]
				private set
				{
				}
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x27D9FE0", Offset = "0x27D9FE0", VA = "0x27D9FE0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x27DA170", Offset = "0x27DA170", VA = "0x27DA170")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x27DA1B8", Offset = "0x27DA1B8", VA = "0x27DA1B8")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x27DA388", Offset = "0x27DA388", VA = "0x27DA388")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x27DA560", Offset = "0x27DA560", VA = "0x27DA560")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x27DA74C", Offset = "0x27DA74C", VA = "0x27DA74C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11866E8", Offset = "0x11866E8")]
			public Transform target;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186720", Offset = "0x1186720")]
			public Transform bendGoal;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186758", Offset = "0x1186758")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186758", Offset = "0x1186758")]
			public float positionWeight;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11867AC", Offset = "0x11867AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11867AC", Offset = "0x11867AC")]
			public float rotationWeight;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186800", Offset = "0x1186800")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186800", Offset = "0x1186800")]
			public float bendGoalWeight;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186854", Offset = "0x1186854")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186854", Offset = "0x1186854")]
			public float swivelOffset;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11868B0", Offset = "0x11868B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11868B0", Offset = "0x11868B0")]
			public float bendToTargetWeight;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186904", Offset = "0x1186904")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186904", Offset = "0x1186904")]
			public float legLengthMlp;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118695C", Offset = "0x118695C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186A04", Offset = "0x1186A04")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186A14", Offset = "0x1186A14")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186A24", Offset = "0x1186A24")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186A34", Offset = "0x1186A34")]
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
				[Address(RVA = "0x27DA968", Offset = "0x27DA968", VA = "0x27DA968")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C038", Offset = "0x118C038")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x27DA974", Offset = "0x27DA974", VA = "0x27DA974")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C048", Offset = "0x118C048")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public Quaternion rotation
			{
				[Token(Token = "0x600068D")]
				[Address(RVA = "0x27DA980", Offset = "0x27DA980", VA = "0x27DA980")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C058", Offset = "0x118C058")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x27DA98C", Offset = "0x27DA98C", VA = "0x27DA98C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C068", Offset = "0x118C068")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public bool hasToes
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x27DA998", Offset = "0x27DA998", VA = "0x27DA998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C078", Offset = "0x118C078")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x27DA9A0", Offset = "0x27DA9A0", VA = "0x27DA9A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C088", Offset = "0x118C088")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0x27DA9AC", Offset = "0x27DA9AC", VA = "0x27DA9AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x27DA9E0", Offset = "0x27DA9E0", VA = "0x27DA9E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0x27DAA18", Offset = "0x27DAA18", VA = "0x27DAA18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000694")]
				[Address(RVA = "0x27DAA50", Offset = "0x27DAA50", VA = "0x27DAA50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000695")]
				[Address(RVA = "0x27DAA88", Offset = "0x27DAA88", VA = "0x27DAA88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000696")]
				[Address(RVA = "0x27DAAC8", Offset = "0x27DAAC8", VA = "0x27DAAC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C098", Offset = "0x118C098")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000697")]
				[Address(RVA = "0x27DAAD4", Offset = "0x27DAAD4", VA = "0x27DAAD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C0A8", Offset = "0x118C0A8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x27DAAE0", Offset = "0x27DAAE0", VA = "0x27DAAE0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x27DB198", Offset = "0x27DB198", VA = "0x27DB198", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x27DBA98", Offset = "0x27DBA98", VA = "0x27DBA98", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x27DB994", Offset = "0x27DB994", VA = "0x27DB994")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x27DB75C", Offset = "0x27DB75C", VA = "0x27DB75C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x27DC050", Offset = "0x27DC050", VA = "0x27DC050")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x27DCD58", Offset = "0x27DCD58", VA = "0x27DCD58")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x27DC280", Offset = "0x27DC280", VA = "0x27DC280")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x27DD1C0", Offset = "0x27DD1C0", VA = "0x27DD1C0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x27DD3DC", Offset = "0x27DD3DC", VA = "0x27DD3DC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x27DD48C", Offset = "0x27DD48C", VA = "0x27DD48C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186A44", Offset = "0x1186A44")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186A44", Offset = "0x1186A44")]
			public float weight;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186A98", Offset = "0x1186A98")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1186A98", Offset = "0x1186A98")]
			public float footDistance;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186AF8", Offset = "0x1186AF8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1186AF8", Offset = "0x1186AF8")]
			public float stepThreshold;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186B58", Offset = "0x1186B58")]
			public float angleThreshold;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186B90", Offset = "0x1186B90")]
			public float comAngleMlp;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186BC8", Offset = "0x1186BC8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1186BC8", Offset = "0x1186BC8")]
			public float maxVelocity;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186C30", Offset = "0x1186C30")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1186C30", Offset = "0x1186C30")]
			public float velocityFactor;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186C90", Offset = "0x1186C90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186C90", Offset = "0x1186C90")]
			public float maxLegStretch;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186CE4", Offset = "0x1186CE4")]
			public float rootSpeed;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186D1C", Offset = "0x1186D1C")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1186D1C", Offset = "0x1186D1C")]
			public float stepSpeed;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186D7C", Offset = "0x1186D7C")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186DB4", Offset = "0x1186DB4")]
			public float maxBodyYOffset;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186DEC", Offset = "0x1186DEC")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186E24", Offset = "0x1186E24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186E24", Offset = "0x1186E24")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186E7C", Offset = "0x1186E7C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186EB4", Offset = "0x1186EB4")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186EEC", Offset = "0x1186EEC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186F64", Offset = "0x1186F64")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186F9C", Offset = "0x1186F9C")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186FD4", Offset = "0x1186FD4")]
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
				[Address(RVA = "0x27DD580", Offset = "0x27DD580", VA = "0x27DD580")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C0B8", Offset = "0x118C0B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x27DD58C", Offset = "0x27DD58C", VA = "0x27DD58C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C0C8", Offset = "0x118C0C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x27DFB04", Offset = "0x27DFB04", VA = "0x27DFB04")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CA")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x27DFB44", Offset = "0x27DFB44", VA = "0x27DFB44")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CB")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x27DFB88", Offset = "0x27DFB88", VA = "0x27DFB88")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000CC")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x27DFBC8", Offset = "0x27DFBC8", VA = "0x27DFBC8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x27DD598", Offset = "0x27DD598", VA = "0x27DD598")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x27DD89C", Offset = "0x27DD89C", VA = "0x27DD89C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x27DDB10", Offset = "0x27DDB10", VA = "0x27DDB10")]
			public void Relax()
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x27DDB74", Offset = "0x27DDB74", VA = "0x27DDB74")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x27DDF4C", Offset = "0x27DDF4C", VA = "0x27DDF4C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x27DE0FC", Offset = "0x27DE0FC", VA = "0x27DE0FC")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x27DF710", Offset = "0x27DF710", VA = "0x27DF710")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x27DF8B4", Offset = "0x27DF8B4", VA = "0x27DF8B4")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x27DF938", Offset = "0x27DF938", VA = "0x27DF938")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x27DFC0C", Offset = "0x27DFC0C", VA = "0x27DFC0C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1186FE4", Offset = "0x1186FE4")]
			public Transform headTarget;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118701C", Offset = "0x118701C")]
			public Transform pelvisTarget;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187054", Offset = "0x1187054")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187054", Offset = "0x1187054")]
			public float positionWeight;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11870A8", Offset = "0x11870A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11870A8", Offset = "0x11870A8")]
			public float rotationWeight;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11870FC", Offset = "0x11870FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11870FC", Offset = "0x11870FC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187150", Offset = "0x1187150")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187150", Offset = "0x1187150")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11871A4", Offset = "0x11871A4")]
			public Transform chestGoal;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11871DC", Offset = "0x11871DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11871DC", Offset = "0x11871DC")]
			public float chestGoalWeight;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187230", Offset = "0x1187230")]
			public float minHeadHeight;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187268", Offset = "0x1187268")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187268", Offset = "0x1187268")]
			public float bodyPosStiffness;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11872BC", Offset = "0x11872BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11872BC", Offset = "0x11872BC")]
			public float bodyRotStiffness;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187310", Offset = "0x1187310")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1187310", Offset = "0x1187310")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187310", Offset = "0x1187310")]
			public float neckStiffness;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187388", Offset = "0x1187388")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187388", Offset = "0x1187388")]
			public float rotateChestByHands;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11873DC", Offset = "0x11873DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11873DC", Offset = "0x11873DC")]
			public float chestClampWeight;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187430", Offset = "0x1187430")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187430", Offset = "0x1187430")]
			public float headClampWeight;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187484", Offset = "0x1187484")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11874BC", Offset = "0x11874BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11874BC", Offset = "0x11874BC")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187510", Offset = "0x1187510")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187510", Offset = "0x1187510")]
			public float maxRootAngle;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187568", Offset = "0x1187568")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187568", Offset = "0x1187568")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11876A4", Offset = "0x11876A4")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11876B4", Offset = "0x11876B4")]
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
				[Address(RVA = "0x27DF690", Offset = "0x27DF690", VA = "0x27DF690")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006B4")]
				[Address(RVA = "0x27DFCFC", Offset = "0x27DFCFC", VA = "0x27DFCFC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			public VirtualBone chest
			{
				[Token(Token = "0x60006B5")]
				[Address(RVA = "0x27DFD3C", Offset = "0x27DFD3C", VA = "0x27DFD3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006B6")]
				[Address(RVA = "0x27DFD90", Offset = "0x27DFD90", VA = "0x27DFD90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			public VirtualBone head
			{
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x27DF6D0", Offset = "0x27DF6D0", VA = "0x27DF6D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x27DFDD0", Offset = "0x27DFDD0", VA = "0x27DFDD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C0D8", Offset = "0x118C0D8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x27DFDE4", Offset = "0x27DFDE4", VA = "0x27DFDE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C0E8", Offset = "0x118C0E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D3")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x27DFDF8", Offset = "0x27DFDF8", VA = "0x27DFDF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C0F8", Offset = "0x118C0F8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x27DFE0C", Offset = "0x27DFE0C", VA = "0x27DFE0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C108", Offset = "0x118C108")]
				private set
				{
				}
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x27DFE20", Offset = "0x27DFE20", VA = "0x27DFE20", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x27E08EC", Offset = "0x27E08EC", VA = "0x27E08EC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x27E0AFC", Offset = "0x27E0AFC", VA = "0x27E0AFC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x27E1184", Offset = "0x27E1184", VA = "0x27E1184")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x27E1744", Offset = "0x27E1744", VA = "0x27E1744")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x27E21CC", Offset = "0x27E21CC", VA = "0x27E21CC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x27E29F8", Offset = "0x27E29F8", VA = "0x27E29F8")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x27E3164", Offset = "0x27E3164", VA = "0x27E3164", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x27E3340", Offset = "0x27E3340", VA = "0x27E3340", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x27E13B4", Offset = "0x27E13B4", VA = "0x27E13B4")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x27E2640", Offset = "0x27E2640", VA = "0x27E2640")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x27E1D70", Offset = "0x27E1D70", VA = "0x27E1D70")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x27E343C", Offset = "0x27E343C", VA = "0x27E343C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x27E27AC", Offset = "0x27E27AC", VA = "0x27E27AC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x27E238C", Offset = "0x27E238C", VA = "0x27E238C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x27E3764", Offset = "0x27E3764", VA = "0x27E3764")]
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
			[Address(RVA = "0x27DB0FC", Offset = "0x27DB0FC", VA = "0x27DB0FC")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x27DB178", Offset = "0x27DB178", VA = "0x27DB178")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x27E3918", Offset = "0x27E3918", VA = "0x27E3918")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x27D92F0", Offset = "0x27D92F0", VA = "0x27D92F0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x27D97F0", Offset = "0x27D97F0", VA = "0x27D97F0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x27E3BA8", Offset = "0x27E3BA8", VA = "0x27E3BA8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x27E3DE0", Offset = "0x27E3DE0", VA = "0x27E3DE0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x27E4014", Offset = "0x27E4014", VA = "0x27E4014")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x27DC7AC", Offset = "0x27DC7AC", VA = "0x27DC7AC")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x27E40CC", Offset = "0x27E40CC", VA = "0x27E40CC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x27E2D04", Offset = "0x27E2D04", VA = "0x27E2D04")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x27E42E4", Offset = "0x27E42E4", VA = "0x27E42E4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x27E43EC", Offset = "0x27E43EC", VA = "0x27E43EC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11840B0", Offset = "0x11840B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11840B0", Offset = "0x11840B0")]
		public int LOD;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184104", Offset = "0x1184104")]
		public float scale;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118413C", Offset = "0x118413C")]
		public bool plantFeet;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184174", Offset = "0x1184174")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184184", Offset = "0x1184184")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1184184", Offset = "0x1184184")]
		public Spine spine;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11841E4", Offset = "0x11841E4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11841E4", Offset = "0x11841E4")]
		public Arm leftArm;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184244", Offset = "0x1184244")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1184244", Offset = "0x1184244")]
		public Arm rightArm;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11842A4", Offset = "0x11842A4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11842A4", Offset = "0x11842A4")]
		public Leg leftLeg;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184304", Offset = "0x1184304")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1184304", Offset = "0x1184304")]
		public Leg rightLeg;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184364", Offset = "0x1184364")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1184364", Offset = "0x1184364")]
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
			[Address(RVA = "0x27C736C", Offset = "0x27C736C", VA = "0x27C736C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A320", Offset = "0x118A320")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x27C7374", Offset = "0x27C7374", VA = "0x27C7374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A330", Offset = "0x118A330")]
			private set
			{
			}
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x27C1B64", Offset = "0x27C1B64", VA = "0x27C1B64")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x27C1FA0", Offset = "0x27C1FA0", VA = "0x27C1FA0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x27C1E48", Offset = "0x27C1E48", VA = "0x27C1E48")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x27C2374", Offset = "0x27C2374", VA = "0x27C2374")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x27C2650", Offset = "0x27C2650", VA = "0x27C2650")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x27C26F4", Offset = "0x27C26F4", VA = "0x27C26F4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x27C2888", Offset = "0x27C2888", VA = "0x27C2888")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x27C2A14", Offset = "0x27C2A14", VA = "0x27C2A14")]
		public void Reset()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x27C323C", Offset = "0x27C323C", VA = "0x27C323C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x27C33B0", Offset = "0x27C33B0", VA = "0x27C33B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x27C35B8", Offset = "0x27C35B8", VA = "0x27C35B8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x27C362C", Offset = "0x27C362C", VA = "0x27C362C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x27C36A0", Offset = "0x27C36A0", VA = "0x27C36A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x27C38B4", Offset = "0x27C38B4", VA = "0x27C38B4")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x27C2250", Offset = "0x27C2250", VA = "0x27C2250")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x27C2B8C", Offset = "0x27C2B8C", VA = "0x27C2B8C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x27C3B94", Offset = "0x27C3B94", VA = "0x27C3B94", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x27C3BDC", Offset = "0x27C3BDC", VA = "0x27C3BDC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x27C5374", Offset = "0x27C5374", VA = "0x27C5374")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x27C2CF4", Offset = "0x27C2CF4", VA = "0x27C2CF4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x27C40A4", Offset = "0x27C40A4", VA = "0x27C40A4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x27C5760", Offset = "0x27C5760", VA = "0x27C5760")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x27C57A8", Offset = "0x27C57A8", VA = "0x27C57A8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x27C5224", Offset = "0x27C5224", VA = "0x27C5224")]
		private void Write()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x27C6D6C", Offset = "0x27C6D6C", VA = "0x27C6D6C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x27C737C", Offset = "0x27C737C", VA = "0x27C737C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11843C4", Offset = "0x11843C4")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x29AD948", Offset = "0x29AD948", VA = "0x29AD948")]
		public void Start()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x29AE03C", Offset = "0x29AE03C", VA = "0x29AE03C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x29AE5C0", Offset = "0x29AE5C0", VA = "0x29AE5C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x29AE688", Offset = "0x29AE688", VA = "0x29AE688")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x29AE78C", Offset = "0x29AE78C", VA = "0x29AE78C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11843FC", Offset = "0x11843FC")]
		public Transform transform;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184434", Offset = "0x1184434")]
		public Transform parent;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118446C", Offset = "0x118446C")]
		public Transform[] children;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11844A4", Offset = "0x11844A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11844A4", Offset = "0x11844A4")]
		public float weight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11844F8", Offset = "0x11844F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11844F8", Offset = "0x11844F8")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118454C", Offset = "0x118454C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118454C", Offset = "0x118454C")]
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
		[Address(RVA = "0x29AE7EC", Offset = "0x29AE7EC", VA = "0x29AE7EC")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x29ADAF8", Offset = "0x29ADAF8", VA = "0x29ADAF8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x29AE104", Offset = "0x29AE104", VA = "0x29AE104")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11845A8", Offset = "0x11845A8")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11845B8", Offset = "0x11845B8")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11845C8", Offset = "0x11845C8")]
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
			[Address(RVA = "0x27E4D10", Offset = "0x27E4D10", VA = "0x27E4D10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A340", Offset = "0x118A340")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x27E4D18", Offset = "0x27E4D18", VA = "0x27E4D18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A350", Offset = "0x118A350")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool isPaused
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x27E4D20", Offset = "0x27E4D20", VA = "0x27E4D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A360", Offset = "0x118A360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x27E4D28", Offset = "0x27E4D28", VA = "0x27E4D28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A370", Offset = "0x118A370")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x27E4D34", Offset = "0x27E4D34", VA = "0x27E4D34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A380", Offset = "0x118A380")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x27E4D3C", Offset = "0x27E4D3C", VA = "0x27E4D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A390", Offset = "0x118A390")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool inInteraction
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x27E4D44", Offset = "0x27E4D44", VA = "0x27E4D44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public float progress
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x27E7980", Offset = "0x27E7980", VA = "0x27E7980")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x27E4DB4", Offset = "0x27E4DB4", VA = "0x27E4DB4")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x27E4E38", Offset = "0x27E4E38", VA = "0x27E4E38")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x27E4ED4", Offset = "0x27E4ED4", VA = "0x27E4ED4")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x27E504C", Offset = "0x27E504C", VA = "0x27E504C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x27E54FC", Offset = "0x27E54FC", VA = "0x27E54FC")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x27E58BC", Offset = "0x27E58BC", VA = "0x27E58BC")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x27E5910", Offset = "0x27E5910", VA = "0x27E5910")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x27E65C0", Offset = "0x27E65C0", VA = "0x27E65C0")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x27E7128", Offset = "0x27E7128", VA = "0x27E7128")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x27E7350", Offset = "0x27E7350", VA = "0x27E7350")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x27E782C", Offset = "0x27E782C", VA = "0x27E782C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x27E7E68", Offset = "0x27E7E68", VA = "0x27E7E68")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11845D8", Offset = "0x11845D8")]
		public LookAtIK ik;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184610", Offset = "0x1184610")]
		public float lerpSpeed;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184648", Offset = "0x1184648")]
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
		[Address(RVA = "0x27E8150", Offset = "0x27E8150", VA = "0x27E8150")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x27E82C8", Offset = "0x27E82C8", VA = "0x27E82C8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x27E8370", Offset = "0x27E8370", VA = "0x27E8370")]
		public void Update()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x27E85B4", Offset = "0x27E85B4", VA = "0x27E85B4")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x27E86AC", Offset = "0x27E86AC", VA = "0x27E86AC")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x27E8778", Offset = "0x27E8778", VA = "0x27E8778")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181C3C", Offset = "0x1181C3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181C3C", Offset = "0x1181C3C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11876C4", Offset = "0x11876C4")]
			public float time;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11876FC", Offset = "0x11876FC")]
			public bool pause;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187734", Offset = "0x1187734")]
			public bool pickUp;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118776C", Offset = "0x118776C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11877A4", Offset = "0x11877A4")]
			public Message[] messages;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11877DC", Offset = "0x11877DC")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x27E79BC", Offset = "0x27E79BC", VA = "0x27E79BC")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x27E9A74", Offset = "0x27E9A74", VA = "0x27E9A74")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187814", Offset = "0x1187814")]
			public string function;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118784C", Offset = "0x118784C")]
			public GameObject recipient;

			[Token(Token = "0x4000521")]
			private const string empty = "";

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x27E9984", Offset = "0x27E9984", VA = "0x27E9984")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x27E9A7C", Offset = "0x27E9A7C", VA = "0x27E9A7C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187884", Offset = "0x1187884")]
			public Animator animator;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11878BC", Offset = "0x11878BC")]
			public Animation animation;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11878F4", Offset = "0x11878F4")]
			public string animationState;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118792C", Offset = "0x118792C")]
			public float crossfadeTime;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187964", Offset = "0x1187964")]
			public int layer;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118799C", Offset = "0x118799C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000528")]
			private const string empty = "";

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x27E96E4", Offset = "0x27E96E4", VA = "0x27E96E4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x27E97D8", Offset = "0x27E97D8", VA = "0x27E97D8")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x27E9890", Offset = "0x27E9890", VA = "0x27E9890")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x27E9970", Offset = "0x27E9970", VA = "0x27E9970")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11879D4", Offset = "0x11879D4")]
			public Type type;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187A0C", Offset = "0x1187A0C")]
			public AnimationCurve curve;

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x27E8EFC", Offset = "0x27E8EFC", VA = "0x27E8EFC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x27E9A94", Offset = "0x27E9A94", VA = "0x27E9A94")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187A44", Offset = "0x1187A44")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187A7C", Offset = "0x1187A7C")]
			public float multiplier;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187AB4", Offset = "0x1187AB4")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x27E95DC", Offset = "0x27E95DC", VA = "0x27E95DC")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x27E9A84", Offset = "0x27E9A84", VA = "0x27E9A84")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184690", Offset = "0x1184690")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11846C8", Offset = "0x11846C8")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184700", Offset = "0x1184700")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184738", Offset = "0x1184738")]
		private float <length>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184748", Offset = "0x1184748")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004C")]
		public float length
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x27E89EC", Offset = "0x27E89EC", VA = "0x27E89EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A560", Offset = "0x118A560")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x27E89F4", Offset = "0x27E89F4", VA = "0x27E89F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A570", Offset = "0x118A570")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x27E89FC", Offset = "0x27E89FC", VA = "0x27E89FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A580", Offset = "0x118A580")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x27E8A04", Offset = "0x27E8A04", VA = "0x27E8A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A590", Offset = "0x118A590")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x27E8C20", Offset = "0x27E8C20", VA = "0x27E8C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x27E7D3C", Offset = "0x27E7D3C", VA = "0x27E7D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x27E878C", Offset = "0x27E878C", VA = "0x27E878C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A3A0", Offset = "0x118A3A0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x27E87D8", Offset = "0x27E87D8", VA = "0x27E87D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A3D8", Offset = "0x118A3D8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x27E8824", Offset = "0x27E8824", VA = "0x27E8824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A410", Offset = "0x118A410")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x27E8870", Offset = "0x27E8870", VA = "0x27E8870")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A448", Offset = "0x118A448")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x27E88BC", Offset = "0x27E88BC", VA = "0x27E88BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A480", Offset = "0x118A480")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x27E8908", Offset = "0x27E8908", VA = "0x27E8908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A4B8", Offset = "0x118A4B8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x27E8954", Offset = "0x27E8954", VA = "0x27E8954")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A4F0", Offset = "0x118A4F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x27E89A0", Offset = "0x27E89A0", VA = "0x27E89A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A528", Offset = "0x118A528")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x27E8A0C", Offset = "0x27E8A0C", VA = "0x27E8A0C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x27E8CB0", Offset = "0x27E8CB0", VA = "0x27E8CB0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x27E5E74", Offset = "0x27E5E74", VA = "0x27E5E74")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x27E8E14", Offset = "0x27E8E14", VA = "0x27E8E14")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x27E5D30", Offset = "0x27E5D30", VA = "0x27E5D30")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x27E5E6C", Offset = "0x27E5E6C", VA = "0x27E5E6C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x27E6D0C", Offset = "0x27E6D0C", VA = "0x27E6D0C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x27E7604", Offset = "0x27E7604", VA = "0x27E7604")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x27E9618", Offset = "0x27E9618", VA = "0x27E9618")]
		private void Start()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x27E8F18", Offset = "0x27E8F18", VA = "0x27E8F18")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x27E8E1C", Offset = "0x27E8E1C", VA = "0x27E8E1C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x27E9574", Offset = "0x27E9574", VA = "0x27E9574")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x27E961C", Offset = "0x27E961C", VA = "0x27E961C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x27E9684", Offset = "0x27E9684", VA = "0x27E9684")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181C9C", Offset = "0x1181C9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181C9C", Offset = "0x1181C9C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000B9")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000BA")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184758", Offset = "0x1184758")]
		public string targetTag;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184790", Offset = "0x1184790")]
		public float fadeInTime;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11847C8", Offset = "0x11847C8")]
		public float speed;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184800", Offset = "0x1184800")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1184838", Offset = "0x1184838")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184838", Offset = "0x1184838")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1184838", Offset = "0x1184838")]
		public Collider characterCollider;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11848BC", Offset = "0x11848BC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x11848BC", Offset = "0x11848BC")]
		public Transform FPSCamera;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118491C", Offset = "0x118491C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184954", Offset = "0x1184954")]
		public float camRaycastDistance;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118498C", Offset = "0x118498C")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x118499C", Offset = "0x118499C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118499C", Offset = "0x118499C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11849FC", Offset = "0x11849FC")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184A34", Offset = "0x1184A34")]
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
			[Address(RVA = "0x27E9CFC", Offset = "0x27E9CFC", VA = "0x27E9CFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x27EB914", Offset = "0x27EB914", VA = "0x27EB914")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x27EB91C", Offset = "0x27EB91C", VA = "0x27EB91C")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x27EB924", Offset = "0x27EB924", VA = "0x27EB924")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A760", Offset = "0x118A760")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x27EB92C", Offset = "0x27EB92C", VA = "0x27EB92C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A770", Offset = "0x118A770")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool initiated
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x27EB934", Offset = "0x27EB934", VA = "0x27EB934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A780", Offset = "0x118A780")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x27EB93C", Offset = "0x27EB93C", VA = "0x27EB93C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118A790", Offset = "0x118A790")]
			private set
			{
			}
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x27E9A9C", Offset = "0x27E9A9C", VA = "0x27E9A9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A5A0", Offset = "0x118A5A0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x27E9AE8", Offset = "0x27E9AE8", VA = "0x27E9AE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A5D8", Offset = "0x118A5D8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x27E9B34", Offset = "0x27E9B34", VA = "0x27E9B34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A610", Offset = "0x118A610")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x27E9B80", Offset = "0x27E9B80", VA = "0x27E9B80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A648", Offset = "0x118A648")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x27E9BCC", Offset = "0x27E9BCC", VA = "0x27E9BCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A680", Offset = "0x118A680")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x27E9C18", Offset = "0x27E9C18", VA = "0x27E9C18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A6B8", Offset = "0x118A6B8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x27E9C64", Offset = "0x27E9C64", VA = "0x27E9C64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A6F0", Offset = "0x118A6F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x27E9CB0", Offset = "0x27E9CB0", VA = "0x27E9CB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A728", Offset = "0x118A728")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x27E9E8C", Offset = "0x27E9E8C", VA = "0x27E9E8C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x27E9F58", Offset = "0x27E9F58", VA = "0x27E9F58")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x27EA024", Offset = "0x27EA024", VA = "0x27EA024")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x27EA0D0", Offset = "0x27EA0D0", VA = "0x27EA0D0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x27EA1C8", Offset = "0x27EA1C8", VA = "0x27EA1C8")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x27EA2E4", Offset = "0x27EA2E4", VA = "0x27EA2E4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x27EA374", Offset = "0x27EA374", VA = "0x27EA374")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x27EA404", Offset = "0x27EA404", VA = "0x27EA404")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x27EA494", Offset = "0x27EA494", VA = "0x27EA494")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x27EA508", Offset = "0x27EA508", VA = "0x27EA508")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x27EA57C", Offset = "0x27EA57C", VA = "0x27EA57C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x27EA5E4", Offset = "0x27EA5E4", VA = "0x27EA5E4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x27EA670", Offset = "0x27EA670", VA = "0x27EA670")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x27EA724", Offset = "0x27EA724", VA = "0x27EA724")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x27EA808", Offset = "0x27EA808", VA = "0x27EA808")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x27EAAAC", Offset = "0x27EAAAC", VA = "0x27EAAAC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x27EAC84", Offset = "0x27EAC84", VA = "0x27EAC84")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x27EAEF8", Offset = "0x27EAEF8", VA = "0x27EAEF8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x27EB1EC", Offset = "0x27EB1EC", VA = "0x27EB1EC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x27EB230", Offset = "0x27EB230", VA = "0x27EB230")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x27EB2A8", Offset = "0x27EB2A8", VA = "0x27EB2A8")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x27EB3C8", Offset = "0x27EB3C8", VA = "0x27EB3C8")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x27EB540", Offset = "0x27EB540", VA = "0x27EB540")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x27EB7E8", Offset = "0x27EB7E8", VA = "0x27EB7E8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x27EAFF8", Offset = "0x27EAFF8", VA = "0x27EAFF8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x27EB948", Offset = "0x27EB948", VA = "0x27EB948")]
		public void Start()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x27EBFFC", Offset = "0x27EBFFC", VA = "0x27EBFFC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x27EC01C", Offset = "0x27EC01C", VA = "0x27EC01C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x27EC038", Offset = "0x27EC038", VA = "0x27EC038")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x27EC054", Offset = "0x27EC054", VA = "0x27EC054")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x27EC0B4", Offset = "0x27EC0B4", VA = "0x27EC0B4")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x27EC1D0", Offset = "0x27EC1D0", VA = "0x27EC1D0")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x27EC2CC", Offset = "0x27EC2CC", VA = "0x27EC2CC")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x27EC62C", Offset = "0x27EC62C", VA = "0x27EC62C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x27EC718", Offset = "0x27EC718", VA = "0x27EC718")]
		public void Update()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x27EC930", Offset = "0x27EC930", VA = "0x27EC930")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x27EBD74", Offset = "0x27EBD74", VA = "0x27EBD74")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x27ECA70", Offset = "0x27ECA70", VA = "0x27ECA70")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x27ECB9C", Offset = "0x27ECB9C", VA = "0x27ECB9C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x27ECC34", Offset = "0x27ECC34", VA = "0x27ECC34")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x27ECD0C", Offset = "0x27ECD0C", VA = "0x27ECD0C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x27ECD24", Offset = "0x27ECD24", VA = "0x27ECD24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x27E9DA8", Offset = "0x27E9DA8", VA = "0x27E9DA8")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x27EA9A8", Offset = "0x27EA9A8", VA = "0x27EA9A8")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x27ED014", Offset = "0x27ED014", VA = "0x27ED014")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181CFC", Offset = "0x1181CFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181CFC", Offset = "0x1181CFC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187AEC", Offset = "0x1187AEC")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187B24", Offset = "0x1187B24")]
			public float multiplier;

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x27ED7B8", Offset = "0x27ED7B8", VA = "0x27ED7B8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184A44", Offset = "0x1184A44")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184A7C", Offset = "0x1184A7C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184AB4", Offset = "0x1184AB4")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184AEC", Offset = "0x1184AEC")]
		public Transform pivot;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184B24", Offset = "0x1184B24")]
		public RotationMode rotationMode;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184B5C", Offset = "0x1184B5C")]
		public Vector3 twistAxis;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184B94", Offset = "0x1184B94")]
		public float twistWeight;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184BCC", Offset = "0x1184BCC")]
		public float swingWeight;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184C04", Offset = "0x1184C04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184C04", Offset = "0x1184C04")]
		public float threeDOFWeight;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184C58", Offset = "0x1184C58")]
		public bool rotateOnce;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x27ED4C8", Offset = "0x27ED4C8", VA = "0x27ED4C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A7A0", Offset = "0x118A7A0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x27ED514", Offset = "0x27ED514", VA = "0x27ED514")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A7D8", Offset = "0x118A7D8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x27ED560", Offset = "0x27ED560", VA = "0x27ED560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A810", Offset = "0x118A810")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x27ED5AC", Offset = "0x27ED5AC", VA = "0x27ED5AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A848", Offset = "0x118A848")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x27ED5F8", Offset = "0x27ED5F8", VA = "0x27ED5F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A880", Offset = "0x118A880")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x27ED644", Offset = "0x27ED644", VA = "0x27ED644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A8B8", Offset = "0x118A8B8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x27ED690", Offset = "0x27ED690", VA = "0x27ED690")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A8F0", Offset = "0x118A8F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x27ED6DC", Offset = "0x27ED6DC", VA = "0x27ED6DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A928", Offset = "0x118A928")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x27E8E8C", Offset = "0x27E8E8C", VA = "0x27E8E8C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x27E7DCC", Offset = "0x27E7DCC", VA = "0x27E7DCC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x27E5F28", Offset = "0x27E5F28", VA = "0x27E5F28")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x27ED728", Offset = "0x27ED728", VA = "0x27ED728")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181D5C", Offset = "0x1181D5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181D5C", Offset = "0x1181D5C")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187B5C", Offset = "0x1187B5C")]
			public bool use;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187B94", Offset = "0x1187B94")]
			public Vector2 offset;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187BCC", Offset = "0x1187BCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187BCC", Offset = "0x1187BCC")]
			public float angleOffset;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187C28", Offset = "0x1187C28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187C28", Offset = "0x1187C28")]
			public float maxAngle;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187C80", Offset = "0x1187C80")]
			public float radius;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187CB8", Offset = "0x1187CB8")]
			public bool orbit;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187CF0", Offset = "0x1187CF0")]
			public bool fixYAxis;

			[Token(Token = "0x170000D4")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x27EDFD4", Offset = "0x27EDFD4", VA = "0x27EDFD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D5")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0x27EE010", Offset = "0x27EE010", VA = "0x27EE010")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x27EE108", Offset = "0x27EE108", VA = "0x27EE108")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x27EE784", Offset = "0x27EE784", VA = "0x27EE784")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187D28", Offset = "0x1187D28")]
			public Collider lookAtTarget;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187D60", Offset = "0x1187D60")]
			public Vector3 direction;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187D98", Offset = "0x1187D98")]
			public float maxDistance;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187DD0", Offset = "0x1187DD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1187DD0", Offset = "0x1187DD0")]
			public float maxAngle;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187E28", Offset = "0x1187E28")]
			public bool fixYAxis;

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x27EDAC0", Offset = "0x27EDAC0", VA = "0x27EDAC0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x27EDC68", Offset = "0x27EDC68", VA = "0x27EDC68")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x27EDF48", Offset = "0x27EDF48", VA = "0x27EDF48")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188E20", Offset = "0x1188E20")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000679")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188E58", Offset = "0x1188E58")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000860")]
				[Address(RVA = "0x27EE7A8", Offset = "0x27EE7A8", VA = "0x27EE7A8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187E80", Offset = "0x1187E80")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187EB8", Offset = "0x1187EB8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187EF0", Offset = "0x1187EF0")]
			public Interaction[] interactions;

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x27ED93C", Offset = "0x27ED93C", VA = "0x27ED93C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x27EE798", Offset = "0x27EE798", VA = "0x27EE798")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184C90", Offset = "0x1184C90")]
		public Range[] ranges;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x27ED7C0", Offset = "0x27ED7C0", VA = "0x27ED7C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A960", Offset = "0x118A960")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x27ED80C", Offset = "0x27ED80C", VA = "0x27ED80C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A998", Offset = "0x118A998")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x27ED858", Offset = "0x27ED858", VA = "0x27ED858")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118A9D0", Offset = "0x118A9D0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x27ED8A4", Offset = "0x27ED8A4", VA = "0x27ED8A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AA08", Offset = "0x118AA08")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x27ED8F0", Offset = "0x27ED8F0", VA = "0x27ED8F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AA40", Offset = "0x118AA40")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x27EC470", Offset = "0x27EC470", VA = "0x27EC470")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x27EDA60", Offset = "0x27EDA60", VA = "0x27EDA60")]
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
			[Address(RVA = "0x282D568", Offset = "0x282D568", VA = "0x282D568")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x282D96C", Offset = "0x282D96C", VA = "0x282D96C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x282D920", Offset = "0x282D920", VA = "0x282D920")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x282D718", Offset = "0x282D718", VA = "0x282D718")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x282D280", Offset = "0x282D280", VA = "0x282D280", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AA78", Offset = "0x118AA78")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x282D60C", Offset = "0x282D60C", VA = "0x282D60C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x282D610", Offset = "0x282D610", VA = "0x282D610", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x282D8B8", Offset = "0x282D8B8", VA = "0x282D8B8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x282D5A4", Offset = "0x282D5A4", VA = "0x282D5A4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x282D4C8", Offset = "0x282D4C8", VA = "0x282D4C8")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x282D9BC", Offset = "0x282D9BC", VA = "0x282D9BC")]
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
		[Address(RVA = "0x27443A4", Offset = "0x27443A4", VA = "0x27443A4", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2744458", Offset = "0x2744458", VA = "0x2744458", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2744610", Offset = "0x2744610", VA = "0x2744610", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x274470C", Offset = "0x274470C", VA = "0x274470C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x27444B4", Offset = "0x27444B4", VA = "0x27444B4")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2744ABC", Offset = "0x2744ABC", VA = "0x2744ABC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184CC8", Offset = "0x1184CC8")]
		public float weight;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184CE0", Offset = "0x1184CE0")]
		public float localRotationWeight;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184CF8", Offset = "0x1184CF8")]
		public float localPositionWeight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60003FA")]
		public abstract void AutoMapping();

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x29A681C", Offset = "0x29A681C", VA = "0x29A681C")]
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
		[Address(RVA = "0x29A6828", Offset = "0x29A6828", VA = "0x29A6828", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x29A687C", Offset = "0x29A687C", VA = "0x29A687C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x29A68B8", Offset = "0x29A68B8", VA = "0x29A68B8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x29A68D0", Offset = "0x29A68D0", VA = "0x29A68D0")]
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
			[Address(RVA = "0x29A6E7C", Offset = "0x29A6E7C", VA = "0x29A6E7C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x29A7A88", Offset = "0x29A7A88", VA = "0x29A7A88")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x29A786C", Offset = "0x29A786C", VA = "0x29A786C")]
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
			[Address(RVA = "0x29A6FD8", Offset = "0x29A6FD8", VA = "0x29A6FD8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x29A7C20", Offset = "0x29A7C20", VA = "0x29A7C20")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x29A7BD0", Offset = "0x29A7BD0", VA = "0x29A7BD0")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182010", Offset = "0x1182010")]
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
				[Address(RVA = "0x29A8200", Offset = "0x29A8200", VA = "0x29A8200", Slot = "4")]
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
				[Address(RVA = "0x29A8268", Offset = "0x29A8268", VA = "0x29A8268", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x29A7038", Offset = "0x29A7038", VA = "0x29A7038")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x29A7FB8", Offset = "0x29A7FB8", VA = "0x29A7FB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x29A7FBC", Offset = "0x29A7FBC", VA = "0x29A7FBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x29A8208", Offset = "0x29A8208", VA = "0x29A8208", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184D10", Offset = "0x1184D10")]
		public IK ik;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184D48", Offset = "0x1184D48")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184D80", Offset = "0x1184D80")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184DB8", Offset = "0x1184DB8")]
		public float applyVelocity;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184DF0", Offset = "0x1184DF0")]
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
			[Address(RVA = "0x29A6940", Offset = "0x29A6940", VA = "0x29A6940")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		private bool ikUsed
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x29A7424", Offset = "0x29A7424", VA = "0x29A7424")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x29A6908", Offset = "0x29A6908", VA = "0x29A6908")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x29A69B8", Offset = "0x29A69B8", VA = "0x29A69B8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x29A6AE8", Offset = "0x29A6AE8", VA = "0x29A6AE8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x29A6A78", Offset = "0x29A6A78", VA = "0x29A6A78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x118AAB0", Offset = "0x118AAB0")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x29A7064", Offset = "0x29A7064", VA = "0x29A7064")]
		private void Update()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x29A72B0", Offset = "0x29A72B0", VA = "0x29A72B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x29A7368", Offset = "0x29A7368", VA = "0x29A7368")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x29A75A8", Offset = "0x29A75A8", VA = "0x29A75A8")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x29A73E8", Offset = "0x29A73E8", VA = "0x29A73E8")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x29A7564", Offset = "0x29A7564", VA = "0x29A7564")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x29A7644", Offset = "0x29A7644", VA = "0x29A7644")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x29A75DC", Offset = "0x29A75DC", VA = "0x29A75DC")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x29A6A10", Offset = "0x29A6A10", VA = "0x29A6A10")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x29A72F0", Offset = "0x29A72F0", VA = "0x29A72F0")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x29A7DE8", Offset = "0x29A7DE8", VA = "0x29A7DE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x29A7EEC", Offset = "0x29A7EEC", VA = "0x29A7EEC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184E38", Offset = "0x1184E38")]
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
			[Address(RVA = "0x29A9C48", Offset = "0x29A9C48", VA = "0x29A9C48")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000057")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x29A9C84", Offset = "0x29A9C84", VA = "0x29A9C84")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x29A9D54", Offset = "0x29A9D54", VA = "0x29A9D54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118AB14", Offset = "0x118AB14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x29A9D5C", Offset = "0x29A9D5C", VA = "0x29A9D5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118AB24", Offset = "0x118AB24")]
			private set
			{
			}
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x29A98AC", Offset = "0x29A98AC", VA = "0x29A98AC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x29A98F4", Offset = "0x29A98F4", VA = "0x29A98F4")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x29A990C", Offset = "0x29A990C", VA = "0x29A990C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x29A9BA0", Offset = "0x29A9BA0", VA = "0x29A9BA0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x29A9C10", Offset = "0x29A9C10", VA = "0x29A9C10")]
		public void Disable()
		{
		}

		[Token(Token = "0x600041E")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x29A9AB0", Offset = "0x29A9AB0", VA = "0x29A9AB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x29A9D68", Offset = "0x29A9D68", VA = "0x29A9D68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x29A9D6C", Offset = "0x29A9D6C", VA = "0x29A9D6C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x29A9E54", Offset = "0x29A9E54", VA = "0x29A9E54")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x29A9F38", Offset = "0x29A9F38", VA = "0x29A9F38")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x29AA1B4", Offset = "0x29AA1B4", VA = "0x29AA1B4")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x29AA270", Offset = "0x29AA270", VA = "0x29AA270")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181DBC", Offset = "0x1181DBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181DBC", Offset = "0x1181DBC")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184E48", Offset = "0x1184E48")]
		public float limit;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184E64", Offset = "0x1184E64")]
		public float twistLimit;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x29AA2E8", Offset = "0x29AA2E8", VA = "0x29AA2E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AB34", Offset = "0x118AB34")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x29AA334", Offset = "0x29AA334", VA = "0x29AA334")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AB6C", Offset = "0x118AB6C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x29AA380", Offset = "0x29AA380", VA = "0x29AA380")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118ABA4", Offset = "0x118ABA4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x29AA3CC", Offset = "0x29AA3CC", VA = "0x29AA3CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118ABDC", Offset = "0x118ABDC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x29AA418", Offset = "0x29AA418", VA = "0x29AA418", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x29AA4D0", Offset = "0x29AA4D0", VA = "0x29AA4D0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x29AA718", Offset = "0x29AA718", VA = "0x29AA718")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181E1C", Offset = "0x1181E1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181E1C", Offset = "0x1181E1C")]
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
		[Address(RVA = "0x29AA728", Offset = "0x29AA728", VA = "0x29AA728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AC14", Offset = "0x118AC14")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x29AA774", Offset = "0x29AA774", VA = "0x29AA774")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AC4C", Offset = "0x118AC4C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x29AA7C0", Offset = "0x29AA7C0", VA = "0x29AA7C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AC84", Offset = "0x118AC84")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x29AA80C", Offset = "0x29AA80C", VA = "0x29AA80C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118ACBC", Offset = "0x118ACBC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x29AA858", Offset = "0x29AA858", VA = "0x29AA858", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x29AA85C", Offset = "0x29AA85C", VA = "0x29AA85C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x29AAB08", Offset = "0x29AAB08", VA = "0x29AAB08")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181E7C", Offset = "0x1181E7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181E7C", Offset = "0x1181E7C")]
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
				[Address(RVA = "0x29ACA34", Offset = "0x29ACA34", VA = "0x29ACA34")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D9")]
			public Vector3 a
			{
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x29ACA6C", Offset = "0x29ACA6C", VA = "0x29ACA6C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DA")]
			public Vector3 b
			{
				[Token(Token = "0x6000709")]
				[Address(RVA = "0x29ACAA8", Offset = "0x29ACAA8", VA = "0x29ACAA8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DB")]
			public Vector3 c
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x29ACAE4", Offset = "0x29ACAE4", VA = "0x29ACAE4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DC")]
			public bool isValid
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x29ABB98", Offset = "0x29ABB98", VA = "0x29ABB98")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x29AC1E4", Offset = "0x29AC1E4", VA = "0x29AC1E4")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x29AC344", Offset = "0x29AC344", VA = "0x29AC344")]
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
			[Address(RVA = "0x29ABBA8", Offset = "0x29ABBA8", VA = "0x29ABBA8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184E90", Offset = "0x1184E90")]
		public float twistLimit;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184EAC", Offset = "0x1184EAC")]
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
		[Address(RVA = "0x29AAB20", Offset = "0x29AAB20", VA = "0x29AAB20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118ACF4", Offset = "0x118ACF4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x29AAB6C", Offset = "0x29AAB6C", VA = "0x29AAB6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AD2C", Offset = "0x118AD2C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x29AABB8", Offset = "0x29AABB8", VA = "0x29AABB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AD64", Offset = "0x118AD64")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x29AAC04", Offset = "0x29AAC04", VA = "0x29AAC04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AD9C", Offset = "0x118AD9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x29AAC50", Offset = "0x29AAC50", VA = "0x29AAC50")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x29AB134", Offset = "0x29AB134", VA = "0x29AB134", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x29AB22C", Offset = "0x29AB22C", VA = "0x29AB22C")]
		private void Start()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x29AB7E4", Offset = "0x29AB7E4", VA = "0x29AB7E4")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x29AACEC", Offset = "0x29AACEC", VA = "0x29AACEC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x29ABC2C", Offset = "0x29ABC2C", VA = "0x29ABC2C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x29AC504", Offset = "0x29AC504", VA = "0x29AC504")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x29AC548", Offset = "0x29AC548", VA = "0x29AC548")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x29AC690", Offset = "0x29AC690", VA = "0x29AC690")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x29AB4AC", Offset = "0x29AB4AC", VA = "0x29AB4AC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x29AC820", Offset = "0x29AC820", VA = "0x29AC820")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x29AC9D0", Offset = "0x29AC9D0", VA = "0x29AC9D0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1181EDC", Offset = "0x1181EDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1181EDC", Offset = "0x1181EDC")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184EF4", Offset = "0x1184EF4")]
		public float twistLimit;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x29ACB20", Offset = "0x29ACB20", VA = "0x29ACB20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118ADD4", Offset = "0x118ADD4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x29ACB6C", Offset = "0x29ACB6C", VA = "0x29ACB6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AE0C", Offset = "0x118AE0C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x29ACBB8", Offset = "0x29ACBB8", VA = "0x29ACBB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AE44", Offset = "0x118AE44")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x29ACC04", Offset = "0x29ACC04", VA = "0x29ACC04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x118AE7C", Offset = "0x118AE7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x29ACC50", Offset = "0x29ACC50", VA = "0x29ACC50")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x29ACC6C", Offset = "0x29ACC6C", VA = "0x29ACC6C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x29ACD24", Offset = "0x29ACD24", VA = "0x29ACD24")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x29AD050", Offset = "0x29AD050", VA = "0x29AD050")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182020", Offset = "0x1182020")]
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
				[Address(RVA = "0x281FFC0", Offset = "0x281FFC0", VA = "0x281FFC0", Slot = "4")]
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
				[Address(RVA = "0x2820028", Offset = "0x2820028", VA = "0x2820028", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x281FD9C", Offset = "0x281FD9C", VA = "0x281FD9C")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x281FE9C", Offset = "0x281FE9C", VA = "0x281FE9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x281FEA0", Offset = "0x281FEA0", VA = "0x281FEA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x281FFC8", Offset = "0x281FFC8", VA = "0x281FFC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184F20", Offset = "0x1184F20")]
		public AimIK ik;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184F58", Offset = "0x1184F58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1184F58", Offset = "0x1184F58")]
		public float weight;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1184FAC", Offset = "0x1184FAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1184FAC", Offset = "0x1184FAC")]
		public Transform target;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118500C", Offset = "0x118500C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185044", Offset = "0x1185044")]
		public float weightSmoothTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x118507C", Offset = "0x118507C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118507C", Offset = "0x118507C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11850DC", Offset = "0x11850DC")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185114", Offset = "0x1185114")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118514C", Offset = "0x118514C")]
		public float slerpSpeed;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185184", Offset = "0x1185184")]
		public float smoothDampTime;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11851BC", Offset = "0x11851BC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11851F4", Offset = "0x11851F4")]
		public float minDistance;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118522C", Offset = "0x118522C")]
		public Vector3 offset;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1185264", Offset = "0x1185264")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185264", Offset = "0x1185264")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1185264", Offset = "0x1185264")]
		public float maxRootAngle;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11852E0", Offset = "0x11852E0")]
		public bool turnToTarget;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185318", Offset = "0x1185318")]
		public float turnToTargetTime;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1185350", Offset = "0x1185350")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185350", Offset = "0x1185350")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11853B0", Offset = "0x11853B0")]
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
			[Address(RVA = "0x281ED2C", Offset = "0x281ED2C", VA = "0x281ED2C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x281EC30", Offset = "0x281EC30", VA = "0x281EC30")]
		private void Start()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x281EE78", Offset = "0x281EE78", VA = "0x281EE78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x281F820", Offset = "0x281F820", VA = "0x281F820")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x281F9BC", Offset = "0x281F9BC", VA = "0x281F9BC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x281FD2C", Offset = "0x281FD2C", VA = "0x281FD2C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x118AEB4", Offset = "0x118AEB4")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x281FDC8", Offset = "0x281FDC8", VA = "0x281FDC8")]
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
			[Address(RVA = "0x28202F8", Offset = "0x28202F8", VA = "0x28202F8")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x2820664", Offset = "0x2820664", VA = "0x2820664")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x282066C", Offset = "0x282066C", VA = "0x282066C")]
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
		[Address(RVA = "0x282021C", Offset = "0x282021C", VA = "0x282021C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2820590", Offset = "0x2820590", VA = "0x2820590")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x28205FC", Offset = "0x28205FC", VA = "0x28205FC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188E90", Offset = "0x1188E90")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400067B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188EC8", Offset = "0x1188EC8")]
				public float weight;

				[Token(Token = "0x6000861")]
				[Address(RVA = "0x2820C5C", Offset = "0x2820C5C", VA = "0x2820C5C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187F28", Offset = "0x1187F28")]
			public Transform transform;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187F60", Offset = "0x1187F60")]
			public Transform relativeTo;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187F98", Offset = "0x1187F98")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1187FD0", Offset = "0x1187FD0")]
			public float verticalWeight;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188008", Offset = "0x1188008")]
			public float horizontalWeight;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188040", Offset = "0x1188040")]
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
			[Address(RVA = "0x28207C8", Offset = "0x28207C8", VA = "0x28207C8")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x2820C34", Offset = "0x2820C34", VA = "0x2820C34")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x2820C44", Offset = "0x2820C44", VA = "0x2820C44")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11853E8", Offset = "0x11853E8")]
		public Body[] bodies;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2820688", Offset = "0x2820688", VA = "0x2820688", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2820C2C", Offset = "0x2820C2C", VA = "0x2820C2C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185420", Offset = "0x1185420")]
		public float tiltSpeed;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185458", Offset = "0x1185458")]
		public float tiltSensitivity;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185490", Offset = "0x1185490")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11854C8", Offset = "0x11854C8")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2822168", Offset = "0x2822168", VA = "0x2822168", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x28221B0", Offset = "0x28221B0", VA = "0x28221B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x28223E0", Offset = "0x28223E0", VA = "0x28223E0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1185500", Offset = "0x1185500")]
		public float weight;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x28223F4", Offset = "0x28223F4", VA = "0x28223F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x28224B4", Offset = "0x28224B4", VA = "0x28224B4")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x28227C4", Offset = "0x28227C4", VA = "0x28227C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x28228BC", Offset = "0x28228BC", VA = "0x28228BC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185518", Offset = "0x1185518")]
		public Animator animator;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185550", Offset = "0x1185550")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185598", Offset = "0x1185598")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700005A")]
		public IK ik
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x2823320", Offset = "0x2823320", VA = "0x2823320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118AF18", Offset = "0x118AF18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x2823328", Offset = "0x2823328", VA = "0x2823328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118AF28", Offset = "0x118AF28")]
			private set
			{
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2823330", Offset = "0x2823330", VA = "0x2823330")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x28234A0", Offset = "0x28234A0", VA = "0x28234A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x2823728", Offset = "0x2823728", VA = "0x2823728")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2823868", Offset = "0x2823868", VA = "0x2823868")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2823A30", Offset = "0x2823A30", VA = "0x2823A30")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x2823C40", Offset = "0x2823C40", VA = "0x2823C40")]
		public void Update()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2823ED4", Offset = "0x2823ED4", VA = "0x2823ED4")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x1181F4C", Offset = "0x1181F4C")]
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
			[Address(RVA = "0x282359C", Offset = "0x282359C", VA = "0x282359C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x28238E4", Offset = "0x28238E4", VA = "0x28238E4")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x28235C0", Offset = "0x28235C0", VA = "0x28235C0")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2823F34", Offset = "0x2823F34", VA = "0x2823F34")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188078", Offset = "0x1188078")]
			public string name;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11880B0", Offset = "0x11880B0")]
			public Collider collider;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11880E8", Offset = "0x11880E8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1188134", Offset = "0x1188134")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1188144", Offset = "0x1188144")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1188154", Offset = "0x1188154")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1188164", Offset = "0x1188164")]
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
				[Address(RVA = "0x2744B80", Offset = "0x2744B80", VA = "0x2744B80")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E0")]
			protected float crossFader
			{
				[Token(Token = "0x600071C")]
				[Address(RVA = "0x2745128", Offset = "0x2745128", VA = "0x2745128")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C1B8", Offset = "0x118C1B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071D")]
				[Address(RVA = "0x2745130", Offset = "0x2745130", VA = "0x2745130")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C1C8", Offset = "0x118C1C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E1")]
			protected float timer
			{
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x2745138", Offset = "0x2745138", VA = "0x2745138")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C1D8", Offset = "0x118C1D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071F")]
				[Address(RVA = "0x2745140", Offset = "0x2745140", VA = "0x2745140")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C1E8", Offset = "0x118C1E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			protected Vector3 force
			{
				[Token(Token = "0x6000720")]
				[Address(RVA = "0x2745148", Offset = "0x2745148", VA = "0x2745148")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C1F8", Offset = "0x118C1F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000721")]
				[Address(RVA = "0x2745154", Offset = "0x2745154", VA = "0x2745154")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C208", Offset = "0x118C208")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E3")]
			protected Vector3 point
			{
				[Token(Token = "0x6000722")]
				[Address(RVA = "0x2745160", Offset = "0x2745160", VA = "0x2745160")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C218", Offset = "0x118C218")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000723")]
				[Address(RVA = "0x274516C", Offset = "0x274516C", VA = "0x274516C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C228", Offset = "0x118C228")]
				private set
				{
				}
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x2744FF4", Offset = "0x2744FF4", VA = "0x2744FF4")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x2744C68", Offset = "0x2744C68", VA = "0x2744C68")]
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
			[Address(RVA = "0x2745178", Offset = "0x2745178", VA = "0x2745178")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188F00", Offset = "0x1188F00")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400067D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188F38", Offset = "0x1188F38")]
				public float weight;

				[Token(Token = "0x400067E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400067F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000862")]
				[Address(RVA = "0x2745AE4", Offset = "0x2745AE4", VA = "0x2745AE4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000863")]
				[Address(RVA = "0x27458D8", Offset = "0x27458D8", VA = "0x27458D8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000864")]
				[Address(RVA = "0x2745C20", Offset = "0x2745C20", VA = "0x2745C20")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188174", Offset = "0x1188174")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11881AC", Offset = "0x11881AC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11881E4", Offset = "0x11881E4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x27456F4", Offset = "0x27456F4", VA = "0x27456F4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x274586C", Offset = "0x274586C", VA = "0x274586C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x27458EC", Offset = "0x27458EC", VA = "0x27458EC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x2745C0C", Offset = "0x2745C0C", VA = "0x2745C0C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188F70", Offset = "0x1188F70")]
				public Transform bone;

				[Token(Token = "0x4000681")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188FA8", Offset = "0x1188FA8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1188FA8", Offset = "0x1188FA8")]
				public float weight;

				[Token(Token = "0x4000682")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000683")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000865")]
				[Address(RVA = "0x27454FC", Offset = "0x27454FC", VA = "0x27454FC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000866")]
				[Address(RVA = "0x2745294", Offset = "0x2745294", VA = "0x2745294")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000867")]
				[Address(RVA = "0x274566C", Offset = "0x274566C", VA = "0x274566C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118821C", Offset = "0x118821C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188254", Offset = "0x1188254")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x274518C", Offset = "0x274518C", VA = "0x274518C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x2745230", Offset = "0x2745230", VA = "0x2745230", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x27452A0", Offset = "0x27452A0", VA = "0x27452A0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x2745658", Offset = "0x2745658", VA = "0x2745658")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11855A8", Offset = "0x11855A8")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11855E0", Offset = "0x11855E0")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005C")]
		public bool inProgress
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2744AC4", Offset = "0x2744AC4", VA = "0x2744AC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x2744B94", Offset = "0x2744B94", VA = "0x2744B94", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2744DB4", Offset = "0x2744DB4", VA = "0x2744DB4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2745120", Offset = "0x2745120", VA = "0x2745120")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118828C", Offset = "0x118828C")]
			public string name;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11882C4", Offset = "0x11882C4")]
			public Collider collider;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11882FC", Offset = "0x11882FC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1188348", Offset = "0x1188348")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1188358", Offset = "0x1188358")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1188368", Offset = "0x1188368")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1188378", Offset = "0x1188378")]
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
				[Address(RVA = "0x27461D8", Offset = "0x27461D8", VA = "0x27461D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C238", Offset = "0x118C238")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000733")]
				[Address(RVA = "0x27461E0", Offset = "0x27461E0", VA = "0x27461E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C248", Offset = "0x118C248")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			protected float timer
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0x27461E8", Offset = "0x27461E8", VA = "0x27461E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C258", Offset = "0x118C258")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x27461F0", Offset = "0x27461F0", VA = "0x27461F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C268", Offset = "0x118C268")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			protected Vector3 force
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0x27461F8", Offset = "0x27461F8", VA = "0x27461F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C278", Offset = "0x118C278")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000737")]
				[Address(RVA = "0x2746204", Offset = "0x2746204", VA = "0x2746204")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C288", Offset = "0x118C288")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			protected Vector3 point
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0x2746210", Offset = "0x2746210", VA = "0x2746210")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C298", Offset = "0x118C298")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000739")]
				[Address(RVA = "0x274621C", Offset = "0x274621C", VA = "0x274621C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118C2A8", Offset = "0x118C2A8")]
				private set
				{
				}
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x2746090", Offset = "0x2746090", VA = "0x2746090")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x2745CF4", Offset = "0x2745CF4", VA = "0x2745CF4")]
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
			[Address(RVA = "0x2746228", Offset = "0x2746228", VA = "0x2746228")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188FFC", Offset = "0x1188FFC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000685")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1189034", Offset = "0x1189034")]
				public float weight;

				[Token(Token = "0x4000686")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000687")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000868")]
				[Address(RVA = "0x27466E4", Offset = "0x27466E4", VA = "0x27466E4")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000869")]
				[Address(RVA = "0x27464A0", Offset = "0x27464A0", VA = "0x27464A0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600086A")]
				[Address(RVA = "0x2746800", Offset = "0x2746800", VA = "0x2746800")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188388", Offset = "0x1188388")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11883C0", Offset = "0x11883C0")]
			public int upDirCurveIndex;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11883F8", Offset = "0x11883F8")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x274623C", Offset = "0x274623C", VA = "0x274623C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x2746434", Offset = "0x2746434", VA = "0x2746434", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x27464B4", Offset = "0x27464B4", VA = "0x27464B4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x27467E4", Offset = "0x27467E4", VA = "0x27467E4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118906C", Offset = "0x118906C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11890A4", Offset = "0x11890A4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11890A4", Offset = "0x11890A4")]
				public float weight;

				[Token(Token = "0x400068A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400068B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600086B")]
				[Address(RVA = "0x2746C68", Offset = "0x2746C68", VA = "0x2746C68")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600086C")]
				[Address(RVA = "0x2746950", Offset = "0x2746950", VA = "0x2746950")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600086D")]
				[Address(RVA = "0x2746DA4", Offset = "0x2746DA4", VA = "0x2746DA4")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188430", Offset = "0x1188430")]
			public int curveIndex;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188468", Offset = "0x1188468")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x2746808", Offset = "0x2746808", VA = "0x2746808", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x27468EC", Offset = "0x27468EC", VA = "0x27468EC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x274695C", Offset = "0x274695C", VA = "0x274695C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x2746D90", Offset = "0x2746D90", VA = "0x2746D90")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185618", Offset = "0x1185618")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185650", Offset = "0x1185650")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2745C28", Offset = "0x2745C28", VA = "0x2745C28", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x2745E48", Offset = "0x2745E48", VA = "0x2745E48")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x27461D0", Offset = "0x27461D0", VA = "0x27461D0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11890F8", Offset = "0x11890F8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1189130", Offset = "0x1189130")]
				public float weight;

				[Token(Token = "0x600086E")]
				[Address(RVA = "0x27E4D08", Offset = "0x27E4D08", VA = "0x27E4D08")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11884A0", Offset = "0x11884A0")]
			public Transform transform;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11884D8", Offset = "0x11884D8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188510", Offset = "0x1188510")]
			public float speed;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188548", Offset = "0x1188548")]
			public float acceleration;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188580", Offset = "0x1188580")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1188580", Offset = "0x1188580")]
			public float matchVelocity;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11885D4", Offset = "0x11885D4")]
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
			[Address(RVA = "0x27E46D8", Offset = "0x27E46D8", VA = "0x27E46D8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x27E4898", Offset = "0x27E4898", VA = "0x27E4898")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x27E4CEC", Offset = "0x27E4CEC", VA = "0x27E4CEC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185688", Offset = "0x1185688")]
		public Body[] bodies;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11856C0", Offset = "0x11856C0")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x27E4660", Offset = "0x27E4660", VA = "0x27E4660")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x27E47B4", Offset = "0x27E47B4", VA = "0x27E47B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x27E4CCC", Offset = "0x27E4CCC", VA = "0x27E4CCC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11856F8", Offset = "0x11856F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11856F8", Offset = "0x11856F8")]
		public Transform target;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1185758", Offset = "0x1185758")]
		public float weight;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185770", Offset = "0x1185770")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11857A8", Offset = "0x11857A8")]
		public float weightSmoothTime;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11857E0", Offset = "0x11857E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11857E0", Offset = "0x11857E0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185840", Offset = "0x1185840")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185878", Offset = "0x1185878")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11858B0", Offset = "0x11858B0")]
		public float slerpSpeed;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11858E8", Offset = "0x11858E8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185920", Offset = "0x1185920")]
		public float minDistance;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1185958", Offset = "0x1185958")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185958", Offset = "0x1185958")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1185958", Offset = "0x1185958")]
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
			[Address(RVA = "0x27EEBD8", Offset = "0x27EEBD8", VA = "0x27EEBD8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x27EEAF0", Offset = "0x27EEAF0", VA = "0x27EEAF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x27EED24", Offset = "0x27EED24", VA = "0x27EED24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x27EF3EC", Offset = "0x27EF3EC", VA = "0x27EF3EC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x27EF588", Offset = "0x27EF588", VA = "0x27EF588")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x27EF8A4", Offset = "0x27EF8A4", VA = "0x27EF8A4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118860C", Offset = "0x118860C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188644", Offset = "0x1188644")]
			public float spring;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118867C", Offset = "0x118867C")]
			public bool x;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11886B4", Offset = "0x11886B4")]
			public bool y;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11886EC", Offset = "0x11886EC")]
			public bool z;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188724", Offset = "0x1188724")]
			public float minX;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118875C", Offset = "0x118875C")]
			public float maxX;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188794", Offset = "0x1188794")]
			public float minY;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11887CC", Offset = "0x11887CC")]
			public float maxY;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188804", Offset = "0x1188804")]
			public float minZ;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x118883C", Offset = "0x118883C")]
			public float maxZ;

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x27EFCCC", Offset = "0x27EFCCC", VA = "0x27EFCCC")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x27F01D4", Offset = "0x27F01D4", VA = "0x27F01D4")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x27F0204", Offset = "0x27F0204", VA = "0x27F0204")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x27F02DC", Offset = "0x27F02DC", VA = "0x27F02DC")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182030", Offset = "0x1182030")]
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
				[Address(RVA = "0x27F0164", Offset = "0x27F0164", VA = "0x27F0164", Slot = "4")]
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
				[Address(RVA = "0x27F01CC", Offset = "0x27F01CC", VA = "0x27F01CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x27EFB94", Offset = "0x27EFB94", VA = "0x27EFB94")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x27F0024", Offset = "0x27F0024", VA = "0x27F0024", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x27F0028", Offset = "0x27F0028", VA = "0x27F0028", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x27F016C", Offset = "0x27F016C", VA = "0x27F016C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11859D4", Offset = "0x11859D4")]
		public float weight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185A0C", Offset = "0x1185A0C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700005E")]
		protected float deltaTime
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x27E486C", Offset = "0x27E486C", VA = "0x27E486C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600047D")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x27EFAF8", Offset = "0x27EFAF8", VA = "0x27EFAF8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x27EFB24", Offset = "0x27EFB24", VA = "0x27EFB24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x118AF38", Offset = "0x118AF38")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x27EFBC0", Offset = "0x27EFBC0", VA = "0x27EFBC0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x27E4C10", Offset = "0x27E4C10", VA = "0x27E4C10")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x27EFF2C", Offset = "0x27EFF2C", VA = "0x27EFF2C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x27E4CDC", Offset = "0x27E4CDC", VA = "0x27E4CDC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182040", Offset = "0x1182040")]
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
				[Address(RVA = "0x29A5BE4", Offset = "0x29A5BE4", VA = "0x29A5BE4", Slot = "4")]
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
				[Address(RVA = "0x29A5C4C", Offset = "0x29A5C4C", VA = "0x29A5C4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x29A5864", Offset = "0x29A5864", VA = "0x29A5864")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x29A5AA4", Offset = "0x29A5AA4", VA = "0x29A5AA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x29A5AA8", Offset = "0x29A5AA8", VA = "0x29A5AA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x29A5BEC", Offset = "0x29A5BEC", VA = "0x29A5BEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185A44", Offset = "0x1185A44")]
		public float weight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185A7C", Offset = "0x1185A7C")]
		public VRIK ik;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005F")]
		protected float deltaTime
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x29A579C", Offset = "0x29A579C", VA = "0x29A579C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000485")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x29A57C8", Offset = "0x29A57C8", VA = "0x29A57C8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x29A57F4", Offset = "0x29A57F4", VA = "0x29A57F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x118AF9C", Offset = "0x118AF9C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x29A5890", Offset = "0x29A5890", VA = "0x29A5890")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x29A599C", Offset = "0x29A599C", VA = "0x29A599C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x29A5A94", Offset = "0x29A5A94", VA = "0x29A5A94")]
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
			[Address(RVA = "0x29A5D14", Offset = "0x29A5D14", VA = "0x29A5D14")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x29A6164", Offset = "0x29A6164", VA = "0x29A6164")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x29A5C54", Offset = "0x29A5C54", VA = "0x29A5C54")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x29A604C", Offset = "0x29A604C", VA = "0x29A604C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x29A6104", Offset = "0x29A6104", VA = "0x29A6104")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1189168", Offset = "0x1189168")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11891A0", Offset = "0x11891A0")]
				public float weight;

				[Token(Token = "0x600086F")]
				[Address(RVA = "0x29A6814", Offset = "0x29A6814", VA = "0x29A6814")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188874", Offset = "0x1188874")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11888AC", Offset = "0x11888AC")]
			public Transform raycastTo;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11888E4", Offset = "0x11888E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11888E4", Offset = "0x11888E4")]
			public float raycastRadius;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188938", Offset = "0x1188938")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188970", Offset = "0x1188970")]
			public float smoothTimeIn;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11889A8", Offset = "0x11889A8")]
			public float smoothTimeOut;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11889E0", Offset = "0x11889E0")]
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
			[Address(RVA = "0x29A61F0", Offset = "0x29A61F0", VA = "0x29A61F0")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x29A63F4", Offset = "0x29A63F4", VA = "0x29A63F4")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x29A658C", Offset = "0x29A658C", VA = "0x29A658C")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x29A6800", Offset = "0x29A6800", VA = "0x29A6800")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185AB4", Offset = "0x1185AB4")]
		public Avoider[] avoiders;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x29A616C", Offset = "0x29A616C", VA = "0x29A616C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x29A63EC", Offset = "0x29A63EC", VA = "0x29A63EC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11891D8", Offset = "0x11891D8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000691")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1189210", Offset = "0x1189210")]
				public float weight;

				[Token(Token = "0x6000870")]
				[Address(RVA = "0x29A98A4", Offset = "0x29A98A4", VA = "0x29A98A4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188A18", Offset = "0x1188A18")]
			public Vector3 offset;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188A50", Offset = "0x1188A50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1188A50", Offset = "0x1188A50")]
			public float additivity;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188AA4", Offset = "0x1188AA4")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188ADC", Offset = "0x1188ADC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x29A85EC", Offset = "0x29A85EC", VA = "0x29A85EC")]
			public void Start()
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x29A917C", Offset = "0x29A917C", VA = "0x29A917C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x29A9890", Offset = "0x29A9890", VA = "0x29A9890")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185AEC", Offset = "0x1185AEC")]
		public AimIK aimIK;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185B24", Offset = "0x1185B24")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185B5C", Offset = "0x1185B5C")]
		public Handedness handedness;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185B94", Offset = "0x1185B94")]
		public bool twoHanded;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185BCC", Offset = "0x1185BCC")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185C04", Offset = "0x1185C04")]
		public float magnitudeRandom;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185C3C", Offset = "0x1185C3C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185C74", Offset = "0x1185C74")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185CAC", Offset = "0x1185CAC")]
		public float blendTime;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1185CE4", Offset = "0x1185CE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185CE4", Offset = "0x1185CE4")]
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
			[Address(RVA = "0x29A83C4", Offset = "0x29A83C4", VA = "0x29A83C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x29A9430", Offset = "0x29A9430", VA = "0x29A9430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x29A9470", Offset = "0x29A9470", VA = "0x29A9470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x29A93F0", Offset = "0x29A93F0", VA = "0x29A93F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x29A9410", Offset = "0x29A9410", VA = "0x29A9410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x29A83F4", Offset = "0x29A83F4", VA = "0x29A83F4")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x29A8420", Offset = "0x29A8420", VA = "0x29A8420")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x29A869C", Offset = "0x29A869C", VA = "0x29A869C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x29A94B0", Offset = "0x29A94B0", VA = "0x29A94B0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x29A9608", Offset = "0x29A9608", VA = "0x29A9608")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x29A9644", Offset = "0x29A9644", VA = "0x29A9644", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x29A97E0", Offset = "0x29A97E0", VA = "0x29A97E0")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185D44", Offset = "0x1185D44")]
		public float weight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1185D7C", Offset = "0x1185D7C")]
		public float offset;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x29AD05C", Offset = "0x29AD05C", VA = "0x29AD05C")]
		private void Start()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x29AD130", Offset = "0x29AD130", VA = "0x29AD130")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x29AD21C", Offset = "0x29AD21C", VA = "0x29AD21C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x29AD664", Offset = "0x29AD664", VA = "0x29AD664")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x29AD69C", Offset = "0x29AD69C", VA = "0x29AD69C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x29AD794", Offset = "0x29AD794", VA = "0x29AD794")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188B14", Offset = "0x1188B14")]
			public float scaleMlp;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188B4C", Offset = "0x1188B4C")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188B84", Offset = "0x1188B84")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188BBC", Offset = "0x1188BBC")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188BF4", Offset = "0x1188BF4")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188C2C", Offset = "0x1188C2C")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188C64", Offset = "0x1188C64")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1188C9C", Offset = "0x1188C9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188C9C", Offset = "0x1188C9C")]
			public Vector3 headOffset;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188CEC", Offset = "0x1188CEC")]
			public Vector3 handOffset;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188D24", Offset = "0x1188D24")]
			public float footForwardOffset;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188D5C", Offset = "0x1188D5C")]
			public float footInwardOffset;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1188D94", Offset = "0x1188D94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1188D94", Offset = "0x1188D94")]
			public float footHeadingOffset;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1188DF0", Offset = "0x1188DF0")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1188E08", Offset = "0x1188E08")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x29B4190", Offset = "0x29B4190", VA = "0x29B4190")]
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
				[Address(RVA = "0x29B1D28", Offset = "0x29B1D28", VA = "0x29B1D28")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000872")]
				[Address(RVA = "0x29B2884", Offset = "0x29B2884", VA = "0x29B2884")]
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
			[Address(RVA = "0x29B11CC", Offset = "0x29B11CC", VA = "0x29B11CC")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x29AFD14", Offset = "0x29AFD14", VA = "0x29AFD14")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x29AFD2C", Offset = "0x29AFD2C", VA = "0x29AFD2C")]
		public static float RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
			return default(float);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x29AFEDC", Offset = "0x29AFEDC", VA = "0x29AFEDC")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x29AFD88", Offset = "0x29AFD88", VA = "0x29AFD88")]
		private static float CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x29AFEF4", Offset = "0x29AFEF4", VA = "0x29AFEF4")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x29B1344", Offset = "0x29B1344", VA = "0x29B1344")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x29B1DEC", Offset = "0x29B1DEC", VA = "0x29B1DEC")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x29B28E4", Offset = "0x29B28E4", VA = "0x29B28E4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x29B2CA0", Offset = "0x29B2CA0", VA = "0x29B2CA0")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x29B2EA0", Offset = "0x29B2EA0", VA = "0x29B2EA0")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x29B359C", Offset = "0x29B359C", VA = "0x29B359C")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x29B3368", Offset = "0x29B3368", VA = "0x29B3368")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x29B386C", Offset = "0x29B386C", VA = "0x29B386C")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x29B3B68", Offset = "0x29B3B68", VA = "0x29B3B68")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x29B3D40", Offset = "0x29B3D40", VA = "0x29B3D40")]
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
		[Address(RVA = "0x29B4268", Offset = "0x29B4268", VA = "0x29B4268")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x29B42C0", Offset = "0x29B42C0", VA = "0x29B42C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x29B42F4", Offset = "0x29B42F4", VA = "0x29B42F4")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x29B447C", Offset = "0x29B447C", VA = "0x29B447C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185DB4", Offset = "0x1185DB4")]
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
			[Address(RVA = "0x29B4494", Offset = "0x29B4494", VA = "0x29B4494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118B000", Offset = "0x118B000")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x29B44A0", Offset = "0x29B44A0", VA = "0x29B44A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118B010", Offset = "0x118B010")]
			private set
			{
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x29B44AC", Offset = "0x29B44AC", VA = "0x29B44AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x29B1B04", Offset = "0x29B1B04", VA = "0x29B1B04")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x29B2B30", Offset = "0x29B2B30", VA = "0x29B2B30")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x29B4584", Offset = "0x29B4584", VA = "0x29B4584")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x29B4A28", Offset = "0x29B4A28", VA = "0x29B4A28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x29B4B20", Offset = "0x29B4B20", VA = "0x29B4B20")]
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
			[Address(RVA = "0x1EE64A4", Offset = "0x1EE64A4", VA = "0x1EE64A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1EE650C", Offset = "0x1EE650C", VA = "0x1EE650C")]
		static ChanelIDReflection()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public sealed class SpeakVoiceChanel : IMessage<SpeakVoiceChanel>, IMessage, IEquatable<SpeakVoiceChanel>, IDeepCloneable<SpeakVoiceChanel>
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182050", Offset = "0x1182050")]
		private sealed class <>c
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1EE98E0", Offset = "0x1EE98E0", VA = "0x1EE98E0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1EE98E8", Offset = "0x1EE98E8", VA = "0x1EE98E8")]
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
			[Address(RVA = "0x1EE8FE4", Offset = "0x1EE8FE4", VA = "0x1EE8FE4")]
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
			[Address(RVA = "0x1EE904C", Offset = "0x1EE904C", VA = "0x1EE904C")]
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
			[Address(RVA = "0x1EE9168", Offset = "0x1EE9168", VA = "0x1EE9168", Slot = "8")]
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
			[Address(RVA = "0x1EE92C8", Offset = "0x1EE92C8", VA = "0x1EE92C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x1EE92D0", Offset = "0x1EE92D0", VA = "0x1EE92D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public int ConnectionID
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x1EE9340", Offset = "0x1EE9340", VA = "0x1EE9340")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1EE9348", Offset = "0x1EE9348", VA = "0x1EE9348")]
			set
			{
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1EE91C4", Offset = "0x1EE91C4", VA = "0x1EE91C4")]
		[DebuggerNonUserCode]
		public SpeakVoiceChanel()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1EE921C", Offset = "0x1EE921C", VA = "0x1EE921C")]
		[DebuggerNonUserCode]
		public SpeakVoiceChanel(SpeakVoiceChanel other)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1EE9268", Offset = "0x1EE9268", VA = "0x1EE9268", Slot = "10")]
		[DebuggerNonUserCode]
		public SpeakVoiceChanel Clone()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1EE9350", Offset = "0x1EE9350", VA = "0x1EE9350", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1EE93C4", Offset = "0x1EE93C4", VA = "0x1EE93C4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SpeakVoiceChanel other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1EE9438", Offset = "0x1EE9438", VA = "0x1EE9438", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1EE94C4", Offset = "0x1EE94C4", VA = "0x1EE94C4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1EE952C", Offset = "0x1EE952C", VA = "0x1EE952C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1EE95CC", Offset = "0x1EE95CC", VA = "0x1EE95CC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1EE96B4", Offset = "0x1EE96B4", VA = "0x1EE96B4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SpeakVoiceChanel other)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1EE9714", Offset = "0x1EE9714", VA = "0x1EE9714", Slot = "5")]
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
			[Address(RVA = "0x1EE6814", Offset = "0x1EE6814", VA = "0x1EE6814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1EE687C", Offset = "0x1EE687C", VA = "0x1EE687C")]
		static GameReflection()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public sealed class GameState : IMessage<GameState>, IMessage, IEquatable<GameState>, IDeepCloneable<GameState>
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182060", Offset = "0x1182060")]
		private sealed class <>c
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1EE7474", Offset = "0x1EE7474", VA = "0x1EE7474")]
			public <>c()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1EE747C", Offset = "0x1EE747C", VA = "0x1EE747C")]
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
			[Address(RVA = "0x1EE6B78", Offset = "0x1EE6B78", VA = "0x1EE6B78")]
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
			[Address(RVA = "0x1EE6BE0", Offset = "0x1EE6BE0", VA = "0x1EE6BE0")]
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
			[Address(RVA = "0x1EE6CFC", Offset = "0x1EE6CFC", VA = "0x1EE6CFC", Slot = "8")]
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
			[Address(RVA = "0x1EE6E5C", Offset = "0x1EE6E5C", VA = "0x1EE6E5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1EE6E64", Offset = "0x1EE6E64", VA = "0x1EE6E64")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public int LevelProgress
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1EE6ED4", Offset = "0x1EE6ED4", VA = "0x1EE6ED4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1EE6EDC", Offset = "0x1EE6EDC", VA = "0x1EE6EDC")]
			set
			{
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1EE6D58", Offset = "0x1EE6D58", VA = "0x1EE6D58")]
		[DebuggerNonUserCode]
		public GameState()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1EE6DB0", Offset = "0x1EE6DB0", VA = "0x1EE6DB0")]
		[DebuggerNonUserCode]
		public GameState(GameState other)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1EE6DFC", Offset = "0x1EE6DFC", VA = "0x1EE6DFC", Slot = "10")]
		[DebuggerNonUserCode]
		public GameState Clone()
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1EE6EE4", Offset = "0x1EE6EE4", VA = "0x1EE6EE4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1EE6F58", Offset = "0x1EE6F58", VA = "0x1EE6F58", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GameState other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1EE6FCC", Offset = "0x1EE6FCC", VA = "0x1EE6FCC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1EE7058", Offset = "0x1EE7058", VA = "0x1EE7058", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1EE70C0", Offset = "0x1EE70C0", VA = "0x1EE70C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1EE7160", Offset = "0x1EE7160", VA = "0x1EE7160", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1EE7248", Offset = "0x1EE7248", VA = "0x1EE7248", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GameState other)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1EE72A8", Offset = "0x1EE72A8", VA = "0x1EE72A8", Slot = "5")]
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
			[Address(RVA = "0x1EE74D4", Offset = "0x1EE74D4", VA = "0x1EE74D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1EE753C", Offset = "0x1EE753C", VA = "0x1EE753C")]
		static LoginReflection()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public sealed class LoginRequest : IMessage<LoginRequest>, IMessage, IEquatable<LoginRequest>, IDeepCloneable<LoginRequest>
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182070", Offset = "0x1182070")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1EE8F80", Offset = "0x1EE8F80", VA = "0x1EE8F80")]
			public <>c()
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x1EE8F88", Offset = "0x1EE8F88", VA = "0x1EE8F88")]
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
			[Address(RVA = "0x1EE835C", Offset = "0x1EE835C", VA = "0x1EE835C")]
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
			[Address(RVA = "0x1EE83C4", Offset = "0x1EE83C4", VA = "0x1EE83C4")]
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
			[Address(RVA = "0x1EE84E0", Offset = "0x1EE84E0", VA = "0x1EE84E0", Slot = "8")]
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
			[Address(RVA = "0x1EE861C", Offset = "0x1EE861C", VA = "0x1EE861C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x1EE8624", Offset = "0x1EE8624", VA = "0x1EE8624")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public int GameVersion
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x1EE862C", Offset = "0x1EE862C", VA = "0x1EE862C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x1EE8634", Offset = "0x1EE8634", VA = "0x1EE8634")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		public AccountData Account
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1EE863C", Offset = "0x1EE863C", VA = "0x1EE863C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1EE8644", Offset = "0x1EE8644", VA = "0x1EE8644")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public int Difficulty
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1EE864C", Offset = "0x1EE864C", VA = "0x1EE864C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1EE8654", Offset = "0x1EE8654", VA = "0x1EE8654")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		public int RoomMode
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1EE865C", Offset = "0x1EE865C", VA = "0x1EE865C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1EE8664", Offset = "0x1EE8664", VA = "0x1EE8664")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public int GameMode
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1EE866C", Offset = "0x1EE866C", VA = "0x1EE866C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1EE8674", Offset = "0x1EE8674", VA = "0x1EE8674")]
			set
			{
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1EE853C", Offset = "0x1EE853C", VA = "0x1EE853C")]
		[DebuggerNonUserCode]
		public LoginRequest()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1EE8544", Offset = "0x1EE8544", VA = "0x1EE8544")]
		[DebuggerNonUserCode]
		public LoginRequest(LoginRequest other)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1EE85BC", Offset = "0x1EE85BC", VA = "0x1EE85BC", Slot = "10")]
		[DebuggerNonUserCode]
		public LoginRequest Clone()
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1EE867C", Offset = "0x1EE867C", VA = "0x1EE867C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1EE86F0", Offset = "0x1EE86F0", VA = "0x1EE86F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LoginRequest other)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1EE87A4", Offset = "0x1EE87A4", VA = "0x1EE87A4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1EE8894", Offset = "0x1EE8894", VA = "0x1EE8894", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1EE88FC", Offset = "0x1EE88FC", VA = "0x1EE88FC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1EE8A44", Offset = "0x1EE8A44", VA = "0x1EE8A44", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1EE8C08", Offset = "0x1EE8C08", VA = "0x1EE8C08", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LoginRequest other)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1EE8CE8", Offset = "0x1EE8CE8", VA = "0x1EE8CE8", Slot = "5")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182080", Offset = "0x1182080")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1EE82F8", Offset = "0x1EE82F8", VA = "0x1EE82F8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1EE8300", Offset = "0x1EE8300", VA = "0x1EE8300")]
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
			[Address(RVA = "0x1EE7BF4", Offset = "0x1EE7BF4", VA = "0x1EE7BF4")]
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
			[Address(RVA = "0x1EE7C5C", Offset = "0x1EE7C5C", VA = "0x1EE7C5C")]
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
			[Address(RVA = "0x1EE7D78", Offset = "0x1EE7D78", VA = "0x1EE7D78", Slot = "8")]
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
			[Address(RVA = "0x1EE7E84", Offset = "0x1EE7E84", VA = "0x1EE7E84")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1EE7E8C", Offset = "0x1EE7E8C", VA = "0x1EE7E8C")]
			set
			{
			}
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1EE7DD4", Offset = "0x1EE7DD4", VA = "0x1EE7DD4")]
		[DebuggerNonUserCode]
		public LoginRefuse()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1EE7DDC", Offset = "0x1EE7DDC", VA = "0x1EE7DDC")]
		[DebuggerNonUserCode]
		public LoginRefuse(LoginRefuse other)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1EE7E24", Offset = "0x1EE7E24", VA = "0x1EE7E24", Slot = "10")]
		[DebuggerNonUserCode]
		public LoginRefuse Clone()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1EE7E94", Offset = "0x1EE7E94", VA = "0x1EE7E94", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1EE7F08", Offset = "0x1EE7F08", VA = "0x1EE7F08", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LoginRefuse other)
		{
			return default(bool);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1EE7F44", Offset = "0x1EE7F44", VA = "0x1EE7F44", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1EE7FAC", Offset = "0x1EE7FAC", VA = "0x1EE7FAC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1EE8014", Offset = "0x1EE8014", VA = "0x1EE8014", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1EE8080", Offset = "0x1EE8080", VA = "0x1EE8080", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1EE8110", Offset = "0x1EE8110", VA = "0x1EE8110", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LoginRefuse other)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1EE8150", Offset = "0x1EE8150", VA = "0x1EE8150", Slot = "5")]
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
			[Address(RVA = "0x1EEAE50", Offset = "0x1EEAE50", VA = "0x1EEAE50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1EEAEB8", Offset = "0x1EEAEB8", VA = "0x1EEAEB8")]
		static UserReflection()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public sealed class User : IMessage<User>, IMessage, IEquatable<User>, IDeepCloneable<User>
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182090", Offset = "0x1182090")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1EEADEC", Offset = "0x1EEADEC", VA = "0x1EEADEC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1EEADF4", Offset = "0x1EEADF4", VA = "0x1EEADF4")]
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
			[Address(RVA = "0x1EEA314", Offset = "0x1EEA314", VA = "0x1EEA314")]
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
			[Address(RVA = "0x1EEA37C", Offset = "0x1EEA37C", VA = "0x1EEA37C")]
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
			[Address(RVA = "0x1EEA498", Offset = "0x1EEA498", VA = "0x1EEA498", Slot = "8")]
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
			[Address(RVA = "0x1EEA5CC", Offset = "0x1EEA5CC", VA = "0x1EEA5CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x1EEA5D4", Offset = "0x1EEA5D4", VA = "0x1EEA5D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		[DebuggerNonUserCode]
		public int UserIndex
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1EEA5DC", Offset = "0x1EEA5DC", VA = "0x1EEA5DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1EEA5E4", Offset = "0x1EEA5E4", VA = "0x1EEA5E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		[DebuggerNonUserCode]
		public AccountData AccountData
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1EEA5EC", Offset = "0x1EEA5EC", VA = "0x1EEA5EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x1EEA5F4", Offset = "0x1EEA5F4", VA = "0x1EEA5F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public TeamData TeamData
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x1EEA5FC", Offset = "0x1EEA5FC", VA = "0x1EEA5FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1EEA604", Offset = "0x1EEA604", VA = "0x1EEA604")]
			set
			{
			}
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1EEA4F4", Offset = "0x1EEA4F4", VA = "0x1EEA4F4")]
		[DebuggerNonUserCode]
		public User()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1EEA4FC", Offset = "0x1EEA4FC", VA = "0x1EEA4FC")]
		[DebuggerNonUserCode]
		public User(User other)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1EEA56C", Offset = "0x1EEA56C", VA = "0x1EEA56C", Slot = "10")]
		[DebuggerNonUserCode]
		public User Clone()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1EEA60C", Offset = "0x1EEA60C", VA = "0x1EEA60C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1EEA680", Offset = "0x1EEA680", VA = "0x1EEA680", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(User other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1EEA718", Offset = "0x1EEA718", VA = "0x1EEA718", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1EEA7CC", Offset = "0x1EEA7CC", VA = "0x1EEA7CC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1EEA834", Offset = "0x1EEA834", VA = "0x1EEA834", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1EEA924", Offset = "0x1EEA924", VA = "0x1EEA924", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1EEAA70", Offset = "0x1EEAA70", VA = "0x1EEAA70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(User other)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1EEAB6C", Offset = "0x1EEAB6C", VA = "0x1EEAB6C", Slot = "5")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11820A0", Offset = "0x11820A0")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x2817160", Offset = "0x2817160", VA = "0x2817160")]
			public <>c()
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x2817168", Offset = "0x2817168", VA = "0x2817168")]
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
			[Address(RVA = "0x1EEB95C", Offset = "0x1EEB95C", VA = "0x1EEB95C")]
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
			[Address(RVA = "0x1EEB9C4", Offset = "0x1EEB9C4", VA = "0x1EEB9C4")]
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
			[Address(RVA = "0x1EEBAE0", Offset = "0x1EEBAE0", VA = "0x1EEBAE0", Slot = "8")]
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
			[Address(RVA = "0x1EEBC94", Offset = "0x1EEBC94", VA = "0x1EEBC94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1EEBB3C", Offset = "0x1EEBB3C", VA = "0x1EEBB3C")]
		[DebuggerNonUserCode]
		public Users()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1EEBBAC", Offset = "0x1EEBBAC", VA = "0x1EEBBAC")]
		[DebuggerNonUserCode]
		public Users(Users other)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1EEBC34", Offset = "0x1EEBC34", VA = "0x1EEBC34", Slot = "10")]
		[DebuggerNonUserCode]
		public Users Clone()
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1EEBC9C", Offset = "0x1EEBC9C", VA = "0x1EEBC9C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1EEBD10", Offset = "0x1EEBD10", VA = "0x1EEBD10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Users other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1EEBDB4", Offset = "0x1EEBDB4", VA = "0x1EEBDB4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1EEBE0C", Offset = "0x1EEBE0C", VA = "0x1EEBE0C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1EEBE74", Offset = "0x1EEBE74", VA = "0x1EEBE74", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1EEBF30", Offset = "0x1EEBF30", VA = "0x1EEBF30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1EEBFE4", Offset = "0x1EEBFE4", VA = "0x1EEBFE4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Users other)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1EEC068", Offset = "0x1EEC068", VA = "0x1EEC068", Slot = "5")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11820B0", Offset = "0x11820B0")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x1EE6444", Offset = "0x1EE6444", VA = "0x1EE6444")]
			public <>c()
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1EE644C", Offset = "0x1EE644C", VA = "0x1EE644C")]
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
			[Address(RVA = "0x1EE5550", Offset = "0x1EE5550", VA = "0x1EE5550")]
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
			[Address(RVA = "0x1EE55B8", Offset = "0x1EE55B8", VA = "0x1EE55B8")]
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
			[Address(RVA = "0x1EE56D4", Offset = "0x1EE56D4", VA = "0x1EE56D4", Slot = "8")]
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
			[Address(RVA = "0x1EE5864", Offset = "0x1EE5864", VA = "0x1EE5864")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x1EE586C", Offset = "0x1EE586C", VA = "0x1EE586C")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x1EE58DC", Offset = "0x1EE58DC", VA = "0x1EE58DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x1EE58E4", Offset = "0x1EE58E4", VA = "0x1EE58E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public string HeadImgUrl
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1EE5954", Offset = "0x1EE5954", VA = "0x1EE5954")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x1EE595C", Offset = "0x1EE595C", VA = "0x1EE595C")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public int Career
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1EE59CC", Offset = "0x1EE59CC", VA = "0x1EE59CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x1EE59D4", Offset = "0x1EE59D4", VA = "0x1EE59D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1EE59DC", Offset = "0x1EE59DC", VA = "0x1EE59DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x1EE59E4", Offset = "0x1EE59E4", VA = "0x1EE59E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		[DebuggerNonUserCode]
		public int Platform
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1EE59EC", Offset = "0x1EE59EC", VA = "0x1EE59EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x1EE59F4", Offset = "0x1EE59F4", VA = "0x1EE59F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		[DebuggerNonUserCode]
		public string Skin
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x1EE59FC", Offset = "0x1EE59FC", VA = "0x1EE59FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x1EE5A04", Offset = "0x1EE5A04", VA = "0x1EE5A04")]
			set
			{
			}
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1EE5730", Offset = "0x1EE5730", VA = "0x1EE5730")]
		[DebuggerNonUserCode]
		public AccountData()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1EE5790", Offset = "0x1EE5790", VA = "0x1EE5790")]
		[DebuggerNonUserCode]
		public AccountData(AccountData other)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1EE5804", Offset = "0x1EE5804", VA = "0x1EE5804", Slot = "10")]
		[DebuggerNonUserCode]
		public AccountData Clone()
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1EE5A74", Offset = "0x1EE5A74", VA = "0x1EE5A74", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1EE5AE8", Offset = "0x1EE5AE8", VA = "0x1EE5AE8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AccountData other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1EE5BB8", Offset = "0x1EE5BB8", VA = "0x1EE5BB8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1EE5CDC", Offset = "0x1EE5CDC", VA = "0x1EE5CDC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1EE5D44", Offset = "0x1EE5D44", VA = "0x1EE5D44", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1EE5ED8", Offset = "0x1EE5ED8", VA = "0x1EE5ED8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1EE6104", Offset = "0x1EE6104", VA = "0x1EE6104", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AccountData other)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1EE61C4", Offset = "0x1EE61C4", VA = "0x1EE61C4", Slot = "5")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11820C0", Offset = "0x11820C0")]
		private sealed class <>c
		{
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1EEA2B0", Offset = "0x1EEA2B0", VA = "0x1EEA2B0")]
			public <>c()
			{
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1EEA2B8", Offset = "0x1EEA2B8", VA = "0x1EEA2B8")]
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
			[Address(RVA = "0x1EE9940", Offset = "0x1EE9940", VA = "0x1EE9940")]
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
			[Address(RVA = "0x1EE99A8", Offset = "0x1EE99A8", VA = "0x1EE99A8")]
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
			[Address(RVA = "0x1EE9AC4", Offset = "0x1EE9AC4", VA = "0x1EE9AC4", Slot = "8")]
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
			[Address(RVA = "0x1EE9BE8", Offset = "0x1EE9BE8", VA = "0x1EE9BE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1EE9BF0", Offset = "0x1EE9BF0", VA = "0x1EE9BF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public bool IsReady
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1EE9BFC", Offset = "0x1EE9BFC", VA = "0x1EE9BFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x1EE9C04", Offset = "0x1EE9C04", VA = "0x1EE9C04")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public int TeamDiff
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x1EE9C10", Offset = "0x1EE9C10", VA = "0x1EE9C10")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1EE9C18", Offset = "0x1EE9C18", VA = "0x1EE9C18")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		[DebuggerNonUserCode]
		public int TeamMode
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x1EE9C20", Offset = "0x1EE9C20", VA = "0x1EE9C20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x1EE9C28", Offset = "0x1EE9C28", VA = "0x1EE9C28")]
			set
			{
			}
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1EE9B20", Offset = "0x1EE9B20", VA = "0x1EE9B20")]
		[DebuggerNonUserCode]
		public TeamData()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1EE9B28", Offset = "0x1EE9B28", VA = "0x1EE9B28")]
		[DebuggerNonUserCode]
		public TeamData(TeamData other)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1EE9B88", Offset = "0x1EE9B88", VA = "0x1EE9B88", Slot = "10")]
		[DebuggerNonUserCode]
		public TeamData Clone()
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1EE9C30", Offset = "0x1EE9C30", VA = "0x1EE9C30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1EE9CA4", Offset = "0x1EE9CA4", VA = "0x1EE9CA4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TeamData other)
		{
			return default(bool);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1EE9D30", Offset = "0x1EE9D30", VA = "0x1EE9D30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1EE9DF0", Offset = "0x1EE9DF0", VA = "0x1EE9DF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1EE9E58", Offset = "0x1EE9E58", VA = "0x1EE9E58", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1EE9F48", Offset = "0x1EE9F48", VA = "0x1EE9F48", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1EEA040", Offset = "0x1EEA040", VA = "0x1EEA040", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TeamData other)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1EEA0A4", Offset = "0x1EEA0A4", VA = "0x1EEA0A4", Slot = "5")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11820D0", Offset = "0x11820D0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1ED9090", Offset = "0x1ED9090", VA = "0x1ED9090")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1ED9850", Offset = "0x1ED9850", VA = "0x1ED9850")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1ED986C", Offset = "0x1ED986C", VA = "0x1ED986C")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11820E0", Offset = "0x11820E0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x1ED91D4", Offset = "0x1ED91D4", VA = "0x1ED91D4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x1ED9888", Offset = "0x1ED9888", VA = "0x1ED9888")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x1ED98A4", Offset = "0x1ED98A4", VA = "0x1ED98A4")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11820F0", Offset = "0x11820F0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1ED931C", Offset = "0x1ED931C", VA = "0x1ED931C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1ED98C0", Offset = "0x1ED98C0", VA = "0x1ED98C0")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1ED9900", Offset = "0x1ED9900", VA = "0x1ED9900")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1ED8F2C", Offset = "0x1ED8F2C", VA = "0x1ED8F2C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1ED9098", Offset = "0x1ED9098", VA = "0x1ED9098")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1ED91DC", Offset = "0x1ED91DC", VA = "0x1ED91DC")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1ED9324", Offset = "0x1ED9324", VA = "0x1ED9324")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1ED939C", Offset = "0x1ED939C", VA = "0x1ED939C")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1ED9414", Offset = "0x1ED9414", VA = "0x1ED9414")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1ED947C", Offset = "0x1ED947C", VA = "0x1ED947C")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1ED9504", Offset = "0x1ED9504", VA = "0x1ED9504")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1ED956C", Offset = "0x1ED956C", VA = "0x1ED956C")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1ED95D4", Offset = "0x1ED95D4", VA = "0x1ED95D4")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1ED963C", Offset = "0x1ED963C", VA = "0x1ED963C")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1ED96A4", Offset = "0x1ED96A4", VA = "0x1ED96A4")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1ED9714", Offset = "0x1ED9714", VA = "0x1ED9714")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1ED9780", Offset = "0x1ED9780", VA = "0x1ED9780")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1ED97E8", Offset = "0x1ED97E8", VA = "0x1ED97E8")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000087")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182100", Offset = "0x1182100")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1ED9A94", Offset = "0x1ED9A94", VA = "0x1ED9A94")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1EDAE30", Offset = "0x1EDAE30", VA = "0x1EDAE30")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182110", Offset = "0x1182110")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x1ED9C24", Offset = "0x1ED9C24", VA = "0x1ED9C24")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x1EDAF6C", Offset = "0x1EDAF6C", VA = "0x1EDAF6C")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182120", Offset = "0x1182120")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x1ED9DB4", Offset = "0x1ED9DB4", VA = "0x1ED9DB4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x1EDAF88", Offset = "0x1EDAF88", VA = "0x1EDAF88")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182130", Offset = "0x1182130")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x1ED9F44", Offset = "0x1ED9F44", VA = "0x1ED9F44")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x1EDAFA4", Offset = "0x1EDAFA4", VA = "0x1EDAFA4")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182140", Offset = "0x1182140")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1EDA0B8", Offset = "0x1EDA0B8", VA = "0x1EDA0B8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1EDAFC0", Offset = "0x1EDAFC0", VA = "0x1EDAFC0")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182150", Offset = "0x1182150")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1EDA2A4", Offset = "0x1EDA2A4", VA = "0x1EDA2A4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1EDAFDC", Offset = "0x1EDAFDC", VA = "0x1EDAFDC")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182160", Offset = "0x1182160")]
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
			[Address(RVA = "0x1EDA720", Offset = "0x1EDA720", VA = "0x1EDA720")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1EDAFF8", Offset = "0x1EDAFF8", VA = "0x1EDAFF8")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1EDB014", Offset = "0x1EDB014", VA = "0x1EDB014")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1EDB048", Offset = "0x1EDB048", VA = "0x1EDB048")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1EDB064", Offset = "0x1EDB064", VA = "0x1EDB064")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x1EDB080", Offset = "0x1EDB080", VA = "0x1EDB080")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182170", Offset = "0x1182170")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1EDA914", Offset = "0x1EDA914", VA = "0x1EDA914")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1EDB140", Offset = "0x1EDB140", VA = "0x1EDB140")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182180", Offset = "0x1182180")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1EDAB1C", Offset = "0x1EDAB1C", VA = "0x1EDAB1C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1EDB15C", Offset = "0x1EDB15C", VA = "0x1EDB15C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x1EDB178", Offset = "0x1EDB178", VA = "0x1EDB178")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182190", Offset = "0x1182190")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x1EDAC9C", Offset = "0x1EDAC9C", VA = "0x1EDAC9C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x1EDB27C", Offset = "0x1EDB27C", VA = "0x1EDB27C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11821A0", Offset = "0x11821A0")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1EDAE28", Offset = "0x1EDAE28", VA = "0x1EDAE28")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1EDAE4C", Offset = "0x1EDAE4C", VA = "0x1EDAE4C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1EDAE68", Offset = "0x1EDAE68", VA = "0x1EDAE68")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1ED9924", Offset = "0x1ED9924", VA = "0x1ED9924")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1ED9A9C", Offset = "0x1ED9A9C", VA = "0x1ED9A9C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1ED9C2C", Offset = "0x1ED9C2C", VA = "0x1ED9C2C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1ED9DBC", Offset = "0x1ED9DBC", VA = "0x1ED9DBC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1ED9F4C", Offset = "0x1ED9F4C", VA = "0x1ED9F4C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1EDA0C0", Offset = "0x1EDA0C0", VA = "0x1EDA0C0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1EDA2AC", Offset = "0x1EDA2AC", VA = "0x1EDA2AC")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1EDA728", Offset = "0x1EDA728", VA = "0x1EDA728")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1EDA91C", Offset = "0x1EDA91C", VA = "0x1EDA91C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1EDAB24", Offset = "0x1EDAB24", VA = "0x1EDAB24")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1EDACA4", Offset = "0x1EDACA4", VA = "0x1EDACA4")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11821B0", Offset = "0x11821B0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1EDB400", Offset = "0x1EDB400", VA = "0x1EDB400")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1EDC140", Offset = "0x1EDC140", VA = "0x1EDC140")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11821C0", Offset = "0x11821C0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x1EDB57C", Offset = "0x1EDB57C", VA = "0x1EDB57C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1EDC15C", Offset = "0x1EDC15C", VA = "0x1EDC15C")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11821D0", Offset = "0x11821D0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x1EDB6F8", Offset = "0x1EDB6F8", VA = "0x1EDB6F8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x1EDC178", Offset = "0x1EDC178", VA = "0x1EDC178")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11821E0", Offset = "0x11821E0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1EDB840", Offset = "0x1EDB840", VA = "0x1EDB840")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x1EDC194", Offset = "0x1EDC194", VA = "0x1EDC194")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11821F0", Offset = "0x11821F0")]
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
			[Address(RVA = "0x1EDBBC0", Offset = "0x1EDBBC0", VA = "0x1EDBBC0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x1EDC1B0", Offset = "0x1EDC1B0", VA = "0x1EDC1B0")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x1EDC1CC", Offset = "0x1EDC1CC", VA = "0x1EDC1CC")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x1EDC1E8", Offset = "0x1EDC1E8", VA = "0x1EDC1E8")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x1EDC21C", Offset = "0x1EDC21C", VA = "0x1EDC21C")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x1EDC238", Offset = "0x1EDC238", VA = "0x1EDC238")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x1EDC254", Offset = "0x1EDC254", VA = "0x1EDC254")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182200", Offset = "0x1182200")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x1EDBE74", Offset = "0x1EDBE74", VA = "0x1EDBE74")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x1EDC37C", Offset = "0x1EDC37C", VA = "0x1EDC37C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x1EDC40C", Offset = "0x1EDC40C", VA = "0x1EDC40C")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182210", Offset = "0x1182210")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x1EDC138", Offset = "0x1EDC138", VA = "0x1EDC138")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1EDC4B0", Offset = "0x1EDC4B0", VA = "0x1EDC4B0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1EDC4CC", Offset = "0x1EDC4CC", VA = "0x1EDC4CC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1EDB298", Offset = "0x1EDB298", VA = "0x1EDB298")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1EDB408", Offset = "0x1EDB408", VA = "0x1EDB408")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1EDB584", Offset = "0x1EDB584", VA = "0x1EDB584")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1EDB700", Offset = "0x1EDB700", VA = "0x1EDB700")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1EDB848", Offset = "0x1EDB848", VA = "0x1EDB848")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1EDBBC8", Offset = "0x1EDBBC8", VA = "0x1EDBBC8")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1EDBE7C", Offset = "0x1EDBE7C", VA = "0x1EDBE7C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000089")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182220", Offset = "0x1182220")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x1EDC75C", Offset = "0x1EDC75C", VA = "0x1EDC75C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1EDCC6C", Offset = "0x1EDCC6C", VA = "0x1EDCC6C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x1EDCC88", Offset = "0x1EDCC88", VA = "0x1EDCC88")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182230", Offset = "0x1182230")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x1EDC8A0", Offset = "0x1EDC8A0", VA = "0x1EDC8A0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1EDCCA4", Offset = "0x1EDCCA4", VA = "0x1EDCCA4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1EDCCC0", Offset = "0x1EDCCC0", VA = "0x1EDCCC0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182240", Offset = "0x1182240")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1EDCC64", Offset = "0x1EDCC64", VA = "0x1EDCC64")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1EDCCDC", Offset = "0x1EDCCDC", VA = "0x1EDCCDC")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1EDCCE8", Offset = "0x1EDCCE8", VA = "0x1EDCCE8")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1EDC5F8", Offset = "0x1EDC5F8", VA = "0x1EDC5F8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1EDC764", Offset = "0x1EDC764", VA = "0x1EDC764")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1EDC8A8", Offset = "0x1EDC8A8", VA = "0x1EDC8A8")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1EDCA80", Offset = "0x1EDCA80", VA = "0x1EDCA80")]
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
			[Address(RVA = "0x1EE1E20", Offset = "0x1EE1E20", VA = "0x1EE1E20")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182250", Offset = "0x1182250")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1EDCED0", Offset = "0x1EDCED0", VA = "0x1EDCED0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1EE0C34", Offset = "0x1EE0C34", VA = "0x1EE0C34")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1EE0C50", Offset = "0x1EE0C50", VA = "0x1EE0C50")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182260", Offset = "0x1182260")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1EDD03C", Offset = "0x1EDD03C", VA = "0x1EDD03C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1EE0EA4", Offset = "0x1EE0EA4", VA = "0x1EE0EA4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1EE0EC8", Offset = "0x1EE0EC8", VA = "0x1EE0EC8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182270", Offset = "0x1182270")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1EDD180", Offset = "0x1EDD180", VA = "0x1EDD180")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1EE1530", Offset = "0x1EE1530", VA = "0x1EE1530")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x1EE1554", Offset = "0x1EE1554", VA = "0x1EE1554")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182280", Offset = "0x1182280")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x1EDD2EC", Offset = "0x1EDD2EC", VA = "0x1EDD2EC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x1EE19FC", Offset = "0x1EE19FC", VA = "0x1EE19FC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x1EE1A20", Offset = "0x1EE1A20", VA = "0x1EE1A20")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182290", Offset = "0x1182290")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x1EDD430", Offset = "0x1EDD430", VA = "0x1EDD430")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x1EE1B0C", Offset = "0x1EE1B0C", VA = "0x1EE1B0C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1EE1B30", Offset = "0x1EE1B30", VA = "0x1EE1B30")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11822A0", Offset = "0x11822A0")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1EDD598", Offset = "0x1EDD598", VA = "0x1EDD598")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1EE1B54", Offset = "0x1EE1B54", VA = "0x1EE1B54")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x1EE1B70", Offset = "0x1EE1B70", VA = "0x1EE1B70")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11822B0", Offset = "0x11822B0")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1EDD8DC", Offset = "0x1EDD8DC", VA = "0x1EDD8DC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1EE1B8C", Offset = "0x1EE1B8C", VA = "0x1EE1B8C")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1EE1C0C", Offset = "0x1EE1C0C", VA = "0x1EE1C0C")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11822C0", Offset = "0x11822C0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1EDDA40", Offset = "0x1EDDA40", VA = "0x1EDDA40")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1EE1C68", Offset = "0x1EE1C68", VA = "0x1EE1C68")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x1EE1CE8", Offset = "0x1EE1CE8", VA = "0x1EE1CE8")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11822D0", Offset = "0x11822D0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1EDDBA4", Offset = "0x1EDDBA4", VA = "0x1EDDBA4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1EE1D44", Offset = "0x1EE1D44", VA = "0x1EE1D44")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1EE1DC4", Offset = "0x1EE1DC4", VA = "0x1EE1DC4")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11822E0", Offset = "0x11822E0")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1EDDD10", Offset = "0x1EDDD10", VA = "0x1EDDD10")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1EE0C6C", Offset = "0x1EE0C6C", VA = "0x1EE0C6C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1EE0C8C", Offset = "0x1EE0C8C", VA = "0x1EE0C8C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11822F0", Offset = "0x11822F0")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1EDDE54", Offset = "0x1EDDE54", VA = "0x1EDDE54")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1EE0CA8", Offset = "0x1EE0CA8", VA = "0x1EE0CA8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1EE0CC8", Offset = "0x1EE0CC8", VA = "0x1EE0CC8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182300", Offset = "0x1182300")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1EDDFA8", Offset = "0x1EDDFA8", VA = "0x1EDDFA8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1EE0CE4", Offset = "0x1EE0CE4", VA = "0x1EE0CE4")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x1EE0D00", Offset = "0x1EE0D00", VA = "0x1EE0D00")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182310", Offset = "0x1182310")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1EDE10C", Offset = "0x1EDE10C", VA = "0x1EDE10C")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1EE0D1C", Offset = "0x1EE0D1C", VA = "0x1EE0D1C")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1EE0D38", Offset = "0x1EE0D38", VA = "0x1EE0D38")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182320", Offset = "0x1182320")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1EDE284", Offset = "0x1EDE284", VA = "0x1EDE284")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x1EE0D54", Offset = "0x1EE0D54", VA = "0x1EE0D54")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x1EE0D70", Offset = "0x1EE0D70", VA = "0x1EE0D70")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182330", Offset = "0x1182330")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x1EDE3FC", Offset = "0x1EDE3FC", VA = "0x1EDE3FC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x1EE0D8C", Offset = "0x1EE0D8C", VA = "0x1EE0D8C")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x1EE0DA8", Offset = "0x1EE0DA8", VA = "0x1EE0DA8")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182340", Offset = "0x1182340")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1EDE568", Offset = "0x1EDE568", VA = "0x1EDE568")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x1EE0DC4", Offset = "0x1EE0DC4", VA = "0x1EE0DC4")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1EE0DE0", Offset = "0x1EE0DE0", VA = "0x1EE0DE0")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182350", Offset = "0x1182350")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1EDE6EC", Offset = "0x1EDE6EC", VA = "0x1EDE6EC")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1EE0DFC", Offset = "0x1EE0DFC", VA = "0x1EE0DFC")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x1EE0E18", Offset = "0x1EE0E18", VA = "0x1EE0E18")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182360", Offset = "0x1182360")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x1EDE870", Offset = "0x1EDE870", VA = "0x1EDE870")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1EE0E34", Offset = "0x1EE0E34", VA = "0x1EE0E34")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x1EE0E50", Offset = "0x1EE0E50", VA = "0x1EE0E50")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182370", Offset = "0x1182370")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1EDE9F4", Offset = "0x1EDE9F4", VA = "0x1EDE9F4")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1EE0E6C", Offset = "0x1EE0E6C", VA = "0x1EE0E6C")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1EE0E88", Offset = "0x1EE0E88", VA = "0x1EE0E88")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182380", Offset = "0x1182380")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x1EDEB58", Offset = "0x1EDEB58", VA = "0x1EDEB58")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1EE0EEC", Offset = "0x1EE0EEC", VA = "0x1EE0EEC")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1EE0F08", Offset = "0x1EE0F08", VA = "0x1EE0F08")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182390", Offset = "0x1182390")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1EDECBC", Offset = "0x1EDECBC", VA = "0x1EDECBC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1EE0F24", Offset = "0x1EE0F24", VA = "0x1EE0F24")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1EE0F40", Offset = "0x1EE0F40", VA = "0x1EE0F40")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11823A0", Offset = "0x11823A0")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x1EDEE10", Offset = "0x1EDEE10", VA = "0x1EDEE10")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1EE0F5C", Offset = "0x1EE0F5C", VA = "0x1EE0F5C")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1EE0F78", Offset = "0x1EE0F78", VA = "0x1EE0F78")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11823B0", Offset = "0x11823B0")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1EDEF7C", Offset = "0x1EDEF7C", VA = "0x1EDEF7C")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1EE0F94", Offset = "0x1EE0F94", VA = "0x1EE0F94")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1EE0FB0", Offset = "0x1EE0FB0", VA = "0x1EE0FB0")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11823C0", Offset = "0x11823C0")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1EDF0E8", Offset = "0x1EDF0E8", VA = "0x1EDF0E8")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1EE0FCC", Offset = "0x1EE0FCC", VA = "0x1EE0FCC")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1EE0FE8", Offset = "0x1EE0FE8", VA = "0x1EE0FE8")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11823D0", Offset = "0x11823D0")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x1EDF24C", Offset = "0x1EDF24C", VA = "0x1EDF24C")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x1EE1004", Offset = "0x1EE1004", VA = "0x1EE1004")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x1EE1020", Offset = "0x1EE1020", VA = "0x1EE1020")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11823E0", Offset = "0x11823E0")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x1EDF404", Offset = "0x1EDF404", VA = "0x1EDF404")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1EE103C", Offset = "0x1EE103C", VA = "0x1EE103C")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x1EE10CC", Offset = "0x1EE10CC", VA = "0x1EE10CC")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11823F0", Offset = "0x11823F0")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x1EDF58C", Offset = "0x1EDF58C", VA = "0x1EDF58C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1EE1170", Offset = "0x1EE1170", VA = "0x1EE1170")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x1EE1200", Offset = "0x1EE1200", VA = "0x1EE1200")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182400", Offset = "0x1182400")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x1EDF760", Offset = "0x1EDF760", VA = "0x1EDF760")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1EE12A4", Offset = "0x1EE12A4", VA = "0x1EE12A4")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x1EE1334", Offset = "0x1EE1334", VA = "0x1EE1334")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182410", Offset = "0x1182410")]
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
			[Address(RVA = "0x1EDFAE4", Offset = "0x1EDFAE4", VA = "0x1EDFAE4")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x1EE13D8", Offset = "0x1EE13D8", VA = "0x1EE13D8")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x1EE13F4", Offset = "0x1EE13F4", VA = "0x1EE13F4")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x1EE1410", Offset = "0x1EE1410", VA = "0x1EE1410")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x1EE1444", Offset = "0x1EE1444", VA = "0x1EE1444")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x1EE1460", Offset = "0x1EE1460", VA = "0x1EE1460")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x1EE147C", Offset = "0x1EE147C", VA = "0x1EE147C")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182420", Offset = "0x1182420")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x1EDFC3C", Offset = "0x1EDFC3C", VA = "0x1EDFC3C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x1EE1578", Offset = "0x1EE1578", VA = "0x1EE1578")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x1EE15E8", Offset = "0x1EE15E8", VA = "0x1EE15E8")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182430", Offset = "0x1182430")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1EDFD84", Offset = "0x1EDFD84", VA = "0x1EDFD84")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x1EE1634", Offset = "0x1EE1634", VA = "0x1EE1634")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x1EE1650", Offset = "0x1EE1650", VA = "0x1EE1650")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182440", Offset = "0x1182440")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x1EDFECC", Offset = "0x1EDFECC", VA = "0x1EDFECC")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x1EE166C", Offset = "0x1EE166C", VA = "0x1EE166C")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x1EE1688", Offset = "0x1EE1688", VA = "0x1EE1688")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182450", Offset = "0x1182450")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000826")]
			[Address(RVA = "0x1EE0020", Offset = "0x1EE0020", VA = "0x1EE0020")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x1EE16A4", Offset = "0x1EE16A4", VA = "0x1EE16A4")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1EE16C8", Offset = "0x1EE16C8", VA = "0x1EE16C8")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182460", Offset = "0x1182460")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x1EE018C", Offset = "0x1EE018C", VA = "0x1EE018C")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x1EE16EC", Offset = "0x1EE16EC", VA = "0x1EE16EC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x1EE1710", Offset = "0x1EE1710", VA = "0x1EE1710")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182470", Offset = "0x1182470")]
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
			[Address(RVA = "0x1EE0330", Offset = "0x1EE0330", VA = "0x1EE0330")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x1EE1734", Offset = "0x1EE1734", VA = "0x1EE1734")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x1EE173C", Offset = "0x1EE173C", VA = "0x1EE173C")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182480", Offset = "0x1182480")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x1EE0474", Offset = "0x1EE0474", VA = "0x1EE0474")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x1EE17DC", Offset = "0x1EE17DC", VA = "0x1EE17DC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x1EE1800", Offset = "0x1EE1800", VA = "0x1EE1800")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182490", Offset = "0x1182490")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x1EE0650", Offset = "0x1EE0650", VA = "0x1EE0650")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x1EE1824", Offset = "0x1EE1824", VA = "0x1EE1824")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0x1EE1848", Offset = "0x1EE1848", VA = "0x1EE1848")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11824A0", Offset = "0x11824A0")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x1EE0844", Offset = "0x1EE0844", VA = "0x1EE0844")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x1EE186C", Offset = "0x1EE186C", VA = "0x1EE186C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x1EE1878", Offset = "0x1EE1878", VA = "0x1EE1878")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11824B0", Offset = "0x11824B0")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000838")]
			[Address(RVA = "0x1EE0A38", Offset = "0x1EE0A38", VA = "0x1EE0A38")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x1EE1934", Offset = "0x1EE1934", VA = "0x1EE1934")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x1EE1940", Offset = "0x1EE1940", VA = "0x1EE1940")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11824C0", Offset = "0x11824C0")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x600083B")]
			[Address(RVA = "0x1EE0C2C", Offset = "0x1EE0C2C", VA = "0x1EE0C2C")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x1EE1A44", Offset = "0x1EE1A44", VA = "0x1EE1A44")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x1EE1A50", Offset = "0x1EE1A50", VA = "0x1EE1A50")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1EDCD94", Offset = "0x1EDCD94", VA = "0x1EDCD94")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1EDCED8", Offset = "0x1EDCED8", VA = "0x1EDCED8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1EDD044", Offset = "0x1EDD044", VA = "0x1EDD044")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1EDD188", Offset = "0x1EDD188", VA = "0x1EDD188")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1EDD2F4", Offset = "0x1EDD2F4", VA = "0x1EDD2F4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1EDD438", Offset = "0x1EDD438", VA = "0x1EDD438")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1EDD5A0", Offset = "0x1EDD5A0", VA = "0x1EDD5A0")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1EDD780", Offset = "0x1EDD780", VA = "0x1EDD780")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1EDD8E4", Offset = "0x1EDD8E4", VA = "0x1EDD8E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1EDDA48", Offset = "0x1EDDA48", VA = "0x1EDDA48")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1EDDBAC", Offset = "0x1EDDBAC", VA = "0x1EDDBAC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1EDDD18", Offset = "0x1EDDD18", VA = "0x1EDDD18")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1EDDE5C", Offset = "0x1EDDE5C", VA = "0x1EDDE5C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1EDDFB0", Offset = "0x1EDDFB0", VA = "0x1EDDFB0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1EDE114", Offset = "0x1EDE114", VA = "0x1EDE114")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1EDE28C", Offset = "0x1EDE28C", VA = "0x1EDE28C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1EDE404", Offset = "0x1EDE404", VA = "0x1EDE404")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1EDE570", Offset = "0x1EDE570", VA = "0x1EDE570")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1EDE6F4", Offset = "0x1EDE6F4", VA = "0x1EDE6F4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1EDE878", Offset = "0x1EDE878", VA = "0x1EDE878")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1EDE9FC", Offset = "0x1EDE9FC", VA = "0x1EDE9FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1EDEB60", Offset = "0x1EDEB60", VA = "0x1EDEB60")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1EDECC4", Offset = "0x1EDECC4", VA = "0x1EDECC4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1EDEE18", Offset = "0x1EDEE18", VA = "0x1EDEE18")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1EDEF84", Offset = "0x1EDEF84", VA = "0x1EDEF84")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1EDF0F0", Offset = "0x1EDF0F0", VA = "0x1EDF0F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1EDF254", Offset = "0x1EDF254", VA = "0x1EDF254")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1EDF40C", Offset = "0x1EDF40C", VA = "0x1EDF40C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1EDF594", Offset = "0x1EDF594", VA = "0x1EDF594")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1EDF768", Offset = "0x1EDF768", VA = "0x1EDF768")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1EDFAEC", Offset = "0x1EDFAEC", VA = "0x1EDFAEC")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1EDFC44", Offset = "0x1EDFC44", VA = "0x1EDFC44")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1EDFD8C", Offset = "0x1EDFD8C", VA = "0x1EDFD8C")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1EDFED4", Offset = "0x1EDFED4", VA = "0x1EDFED4")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1EE0028", Offset = "0x1EE0028", VA = "0x1EE0028")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1EE0194", Offset = "0x1EE0194", VA = "0x1EE0194")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1EE0338", Offset = "0x1EE0338", VA = "0x1EE0338")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1EE047C", Offset = "0x1EE047C", VA = "0x1EE047C")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1EE0658", Offset = "0x1EE0658", VA = "0x1EE0658")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1EE084C", Offset = "0x1EE084C", VA = "0x1EE084C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1EE0A40", Offset = "0x1EE0A40", VA = "0x1EE0A40")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11824D0", Offset = "0x11824D0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x1EE2B28", Offset = "0x1EE2B28", VA = "0x1EE2B28")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1EE32B8", Offset = "0x1EE32B8", VA = "0x1EE32B8")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1EE32DC", Offset = "0x1EE32DC", VA = "0x1EE32DC")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11824E0", Offset = "0x11824E0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1EE2CF0", Offset = "0x1EE2CF0", VA = "0x1EE2CF0")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1EE3300", Offset = "0x1EE3300", VA = "0x1EE3300")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1EE3324", Offset = "0x1EE3324", VA = "0x1EE3324")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11824F0", Offset = "0x11824F0")]
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
			[Address(RVA = "0x1EE3348", Offset = "0x1EE3348", VA = "0x1EE3348", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x1EE358C", Offset = "0x1EE358C", VA = "0x1EE358C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182500", Offset = "0x1182500")]
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
			[Address(RVA = "0x1EE3C9C", Offset = "0x1EE3C9C", VA = "0x1EE3C9C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1EE3F04", Offset = "0x1EE3F04", VA = "0x1EE3F04", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182510", Offset = "0x1182510")]
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
			[Address(RVA = "0x1EE37F0", Offset = "0x1EE37F0", VA = "0x1EE37F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1EE3A20", Offset = "0x1EE3A20", VA = "0x1EE3A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182520", Offset = "0x1182520")]
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
			[Address(RVA = "0x1EE3598", Offset = "0x1EE3598", VA = "0x1EE3598", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x1EE37E4", Offset = "0x1EE37E4", VA = "0x1EE37E4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182530", Offset = "0x1182530")]
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
			[Address(RVA = "0x1EE3A2C", Offset = "0x1EE3A2C", VA = "0x1EE3A2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1EE3C90", Offset = "0x1EE3C90", VA = "0x1EE3C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1182540", Offset = "0x1182540")]
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
			[Address(RVA = "0x1EE3F10", Offset = "0x1EE3F10", VA = "0x1EE3F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1EE4148", Offset = "0x1EE4148", VA = "0x1EE4148", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1EE20CC", Offset = "0x1EE20CC", VA = "0x1EE20CC")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1EE22A8", Offset = "0x1EE22A8", VA = "0x1EE22A8")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1EE2498", Offset = "0x1EE2498", VA = "0x1EE2498")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1EE2560", Offset = "0x1EE2560", VA = "0x1EE2560")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1EE2628", Offset = "0x1EE2628", VA = "0x1EE2628")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1EE26F0", Offset = "0x1EE26F0", VA = "0x1EE26F0")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1EE27C8", Offset = "0x1EE27C8", VA = "0x1EE27C8")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1EE28A0", Offset = "0x1EE28A0", VA = "0x1EE28A0")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1EE2968", Offset = "0x1EE2968", VA = "0x1EE2968")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1EE2B30", Offset = "0x1EE2B30", VA = "0x1EE2B30")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1EE2CF8", Offset = "0x1EE2CF8", VA = "0x1EE2CF8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x118BB20", Offset = "0x118BB20")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1EE2DE8", Offset = "0x1EE2DE8", VA = "0x1EE2DE8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x118BB94", Offset = "0x118BB94")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1EE2ED8", Offset = "0x1EE2ED8", VA = "0x1EE2ED8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x118BC08", Offset = "0x118BC08")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1EE2FC8", Offset = "0x1EE2FC8", VA = "0x1EE2FC8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x118BC7C", Offset = "0x118BC7C")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1EE30C8", Offset = "0x1EE30C8", VA = "0x1EE30C8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x118BCF0", Offset = "0x118BCF0")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1EE31C8", Offset = "0x1EE31C8", VA = "0x1EE31C8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x118BD64", Offset = "0x118BD64")]
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
				[Address(RVA = "0x1ED8C6C", Offset = "0x1ED8C6C", VA = "0x1ED8C6C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1ED8CA0", Offset = "0x1ED8CA0", VA = "0x1ED8CA0")]
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
				[Address(RVA = "0x1ED8E3C", Offset = "0x1ED8E3C", VA = "0x1ED8E3C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x1ED8EA0", Offset = "0x1ED8EA0", VA = "0x1ED8EA0")]
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
				[Address(RVA = "0x1ED8D54", Offset = "0x1ED8D54", VA = "0x1ED8D54", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x1ED8D70", Offset = "0x1ED8D70", VA = "0x1ED8D70")]
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
				[Address(RVA = "0x1ED8CCC", Offset = "0x1ED8CCC", VA = "0x1ED8CCC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x1ED8D18", Offset = "0x1ED8D18", VA = "0x1ED8D18")]
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
				[Address(RVA = "0x1ED8D9C", Offset = "0x1ED8D9C", VA = "0x1ED8D9C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x1ED8E00", Offset = "0x1ED8E00", VA = "0x1ED8E00")]
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
				[Address(RVA = "0x1ED8ECC", Offset = "0x1ED8ECC", VA = "0x1ED8ECC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x1ED8F00", Offset = "0x1ED8F00", VA = "0x1ED8F00")]
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
			[Address(RVA = "0x1EE4298", Offset = "0x1EE4298", VA = "0x1EE4298")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x1EE43A0", Offset = "0x1EE43A0", VA = "0x1EE43A0")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x1EE4430", Offset = "0x1EE4430", VA = "0x1EE4430")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1EE44C0", Offset = "0x1EE44C0", VA = "0x1EE44C0")]
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
		[Address(RVA = "0x1EE4154", Offset = "0x1EE4154", VA = "0x1EE4154")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1EE41F8", Offset = "0x1EE41F8", VA = "0x1EE41F8")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
